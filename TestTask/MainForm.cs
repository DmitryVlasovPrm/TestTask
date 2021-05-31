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
			Instance = this;
		}

		public static MainForm Instance { get; private set; }

		private void downloadCsv_Click(object sender, EventArgs e)
		{
			var chooseFileForm = new ChooseFile();
			chooseFileForm.ShowDialog();
		}

		private void clearTable_Click(object sender, EventArgs e)
		{
			contactsTable.Rows.Clear();
		}

		// TODO: завершение тасок при exception
		public void AddRows(List<Contact> items)
		{
			var itemsCount = items.Count;
			var rows = new object[itemsCount];
			for (var i = 0; i < 100; i++)
			{
				//var curItem = items[i];
				//rows[i] = new object("a", "b", "c", "d", "e", "f", "g", "h");
			}
			contactsTable.Invoke(new Action(() => contactsTable.Rows.Add("a", "b", "c", "d", "e", "f", "g", "h")));
		}

		public void ChangeProcessStatus()
		{
			Invoke(new Action(() =>
			{
				if (processStatus.Text == "")
				{
					processStatus.Text = "Выполняется загрузка...";
					downloadCsv.Enabled = false;
					clearTable.Enabled = false;
					contactsTable.Rows.Clear();
				}
				else
				{
					processStatus.Text = "";
					downloadCsv.Enabled = true;
					clearTable.Enabled = true;
				}
			}));
		}
	}
}
