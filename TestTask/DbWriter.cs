using System;
using System.Linq;
using System.Threading;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using EFCore.BulkExtensions;

namespace TestTask
{
	public class DbWriter
	{
		private const string CONNECTION_STRING = "Server=localhost;Database=Contacts;Trusted_Connection=True;";
		private readonly int _contactInfoId;
		private readonly SemaphoreSlim _semaphore;

		public DbWriter(ContactInfo contactInfo)
		{
			try
			{
				_semaphore = new SemaphoreSlim(1, 1);
				using (var dbContext = new ContactsContext(CONNECTION_STRING))
				{
					dbContext.Database.EnsureDeleted();
					dbContext.Database.EnsureCreated();

					dbContext.ContactInfos.Add(contactInfo);
					dbContext.SaveChanges();
					_contactInfoId = contactInfo.ContactInfoId;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		public async Task InsertDataAsync(List<OriginalContact> items)
		{
			await Task.Run(async () =>
			{
				try
				{
					using (var dbContext = new ContactsContext(CONNECTION_STRING))
					{
						var contacts = new List<Contact>();
						var itemsCount = items.Count;

						for (var i = 0; i < itemsCount; i++)
						{
							var formattedContact = items[i].FormatData();
							if (formattedContact != null)
								contacts.Add(await CreateContactAsync(formattedContact, dbContext));
						}

						await dbContext.Contacts.AddRangeAsync(contacts);
						await dbContext.SaveChangesAsync();
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			});
		}

		private async Task<Contact> CreateContactAsync(OriginalContact formattedContact, ContactsContext dbContext)
		{
			try
			{
				await _semaphore.WaitAsync();
				var curCategory = dbContext.Categories.
					FirstOrDefault(x => x.CategoryName == formattedContact.CategoryName);
				if (curCategory == null)
				{
					curCategory = new Category { CategoryName = formattedContact.CategoryName };
					await dbContext.Categories.AddAsync(curCategory);
					await dbContext.SaveChangesAsync();
				}

				var curCity = dbContext.Cities.
					FirstOrDefault(x => x.CityName == formattedContact.CityName);
				if (curCity == null)
				{
					curCity = new City { CityName = formattedContact.CityName };
					await dbContext.Cities.AddAsync(curCity);
					await dbContext.SaveChangesAsync();
				}

				var contact = new Contact
				{
					PhoneNumber = formattedContact.PhoneNumber,
					LastName = formattedContact.LastName,
					FirstName = formattedContact.FirstName,
					PatronymicName = formattedContact.PatronymicName,
					Category = curCategory,
					Sex = formattedContact.Sex,
					City = curCity,
					BirthdayDate = formattedContact.BirthdayDate,
					ContactInfoId = _contactInfoId
				};

				return contact;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return null;
			}
			finally
			{
				_semaphore.Release();
			}
		}
	}
}
