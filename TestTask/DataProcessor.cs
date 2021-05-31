using System;
using System.Text;
using CsvHelper;
using System.IO;
using System.Globalization;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace TestTask
{
	public class DataProcessor
	{
		private const int MAX_BATCH_SIZE = 5000;
		private readonly string _fileName;
		private readonly ContactInfo _contactInfo;
		private List<OriginalContact> _dataFromFile;

		public DataProcessor(string fileName, ContactInfo contactInfo)
		{
			_fileName = fileName;
			_contactInfo = contactInfo;
			_dataFromFile = new List<OriginalContact>();
		}

		public async void DownloadDataAsync()
		{
			await Task.Run(() =>
			{
				try
				{
					Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
					using (var fileReader = new StreamReader(_fileName, Encoding.GetEncoding(1251)))
					{
						using (var csvReader = new CsvReader(fileReader, CultureInfo.CurrentCulture))
						{
							var dbWriter = new DbWriter(_contactInfo);
							var allTasks = new List<Task>();

							while (csvReader.Read())
							{
								_dataFromFile.Add(csvReader.GetRecord<OriginalContact>());
								if (_dataFromFile.Count == MAX_BATCH_SIZE)
								{
									var newTask = dbWriter.InsertDataAsync(_dataFromFile);
									allTasks.Add(newTask);
									_dataFromFile = new List<OriginalContact>();
								}
							}

							if (_dataFromFile.Count != 0)
							{
								var newTask = dbWriter.InsertDataAsync(_dataFromFile);
								allTasks.Add(newTask);
							}

							_dataFromFile = null;
							Task.WaitAll(allTasks.ToArray());
							MessageBox.Show("Файл успешно считан и данные записаны в БД", "TestTask",
									MessageBoxButtons.OK, MessageBoxIcon.Information);
						}
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			});
		}
	}
}
