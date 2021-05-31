using System;
using System.Text;
using CsvHelper;
using System.IO;
using System.Globalization;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Diagnostics;

namespace TestTask
{
	public class DataProcessor
	{
		private const int MAX_BATCH_SIZE = 1000;
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
			var sw = new Stopwatch();
			sw.Start();

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
									MainForm.Instance.AddRows(new List<Contact>());
								}
							}

							if (_dataFromFile.Count != 0)
							{
								var newTask = dbWriter.InsertDataAsync(_dataFromFile);
								allTasks.Add(newTask);
							}

							_dataFromFile = null;
							Task.WaitAll(allTasks.ToArray());

							sw.Stop();
							MainForm.Instance.ChangeProcessStatus();
							MessageBox.Show($"Файл успешно считан и данные записаны в БД ({Math.Round(sw.Elapsed.TotalSeconds, 1)} сек)", "TestTask",
									MessageBoxButtons.OK, MessageBoxIcon.Information);
						}
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, "Ошибка в DownloadDataAsync", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			});
		}
	}
}
