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
		private const int MAX_BATCH_SIZE = 10000;
		private readonly string _fileName;
		private List<Test> _dataFromFile;

		public DataProcessor(string fileName)
		{
			_fileName = fileName;
			_dataFromFile = new List<Test>();
		}

		public Action<List<Test>> NewDataReceived;

		public async void DownloadDataAsync()
		{
			await Task.Run(async () =>
			{
				try
				{
					Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
					using (var fileReader = new StreamReader(_fileName, Encoding.GetEncoding(1251)))
					{
						using (var csvReader = new CsvReader(fileReader, CultureInfo.CurrentCulture))
						{
							while (csvReader.Read())
							{
								_dataFromFile.Add(csvReader.GetRecord<Test>());
								if (_dataFromFile.Count > MAX_BATCH_SIZE)
								{
									_ = DbWriter.PushDataAsync(_dataFromFile);
									NewDataReceived.Invoke(_dataFromFile);
									_dataFromFile = new List<Test>();
								}
							}

							if (_dataFromFile.Count != 0)
							{
								await DbWriter.PushDataAsync(_dataFromFile);
								NewDataReceived.Invoke(_dataFromFile);
							}

							_dataFromFile = null;
							MessageBox.Show("Файл успешно считан и данные записаны в БД", "TestTask",
									MessageBoxButtons.OK, MessageBoxIcon.Information);
						}
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, "Ошибка во время загрузки данных",
						MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			});
		}
	}
}
