using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace TestTask
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void downloadCsv_Click(object sender, EventArgs e)
		{
			var fileDialog = new OpenFileDialog();
			if (fileDialog.ShowDialog() == DialogResult.OK)
			{
				var dataProcessor = new DataProcessor(fileDialog.FileName);
				dataProcessor.NewDataReceived += AddRows;
				dataProcessor.DownloadDataAsync();
			}
		}

		private void clearTable_Click(object sender, EventArgs e)
		{
			contactsTable.Rows.Clear();
		}

		public void AddRows(List<Test> items)
		{
			var itemsCount = items.Count;
			for (var i = 0; i < itemsCount; i++)
			{
				var curItem = items[i];
				contactsTable.Invoke(new Action(() =>
					contactsTable.Rows.Add(curItem.a1, curItem.a2, curItem.a3, curItem.a4,
						curItem.a5, curItem.a6, curItem.a7, curItem.a8)));
			}
		}
	}
}
