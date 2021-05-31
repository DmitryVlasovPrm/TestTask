using System;
using System.IO;
using System.Windows.Forms;

namespace TestTask
{
	public partial class ChooseFile : Form
	{
		public ChooseFile()
		{
			InitializeComponent();
		}

		private void chooseFileButton_Click(object sender, EventArgs e)
		{
			var fileDialog = new OpenFileDialog();
			if (fileDialog.ShowDialog() == DialogResult.OK)
				filePathBox.Text = fileDialog.FileName;
		}

		private void startProcessButton_Click(object sender, EventArgs e)
		{
			var filePath = filePathBox.Text;
			if (!File.Exists(filePath))
			{
				MessageBox.Show("Данный файл не существует", "Ошибка при выборе файла",
						MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			var contactInfo = new ContactInfo
			{
				Comment = commentBox.Text,
				CsvFileName = StringFunctions.GetFileName(filePath),
				DownloadTime = DateTime.Now
			};

			var dataProcessor = new DataProcessor(filePath, contactInfo);
			dataProcessor.DownloadDataAsync();
			Close();
		}

		private void filePathBox_TextChanged(object sender, EventArgs e)
		{
			if (filePathBox.Text != "")
				startProcessButton.Enabled = true;
			else
				startProcessButton.Enabled = false;
		}
	}
}
