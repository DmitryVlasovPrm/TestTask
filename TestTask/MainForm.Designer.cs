
namespace TestTask
{
	partial class MainForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.downloadCsv = new System.Windows.Forms.ToolStripButton();
			this.clearTable = new System.Windows.Forms.ToolStripButton();
			this.processStatus = new System.Windows.Forms.ToolStripLabel();
			this.contactsTable = new System.Windows.Forms.DataGridView();
			this.phoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.firstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.patronymicName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.city = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.birthdayDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.toolStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.contactsTable)).BeginInit();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.downloadCsv,
            this.clearTable,
            this.processStatus});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(1187, 26);
			this.toolStrip1.TabIndex = 1;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// downloadCsv
			// 
			this.downloadCsv.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.downloadCsv.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.downloadCsv.Name = "downloadCsv";
			this.downloadCsv.Size = new System.Drawing.Size(103, 23);
			this.downloadCsv.Text = "Выбрать файл";
			this.downloadCsv.Click += new System.EventHandler(this.downloadCsv_Click);
			// 
			// clearTable
			// 
			this.clearTable.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.clearTable.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.clearTable.Name = "clearTable";
			this.clearTable.Size = new System.Drawing.Size(128, 23);
			this.clearTable.Text = "Очистить таблицу";
			this.clearTable.Click += new System.EventHandler(this.clearTable_Click);
			// 
			// processStatus
			// 
			this.processStatus.ForeColor = System.Drawing.Color.Green;
			this.processStatus.Name = "processStatus";
			this.processStatus.Size = new System.Drawing.Size(0, 23);
			// 
			// contactsTable
			// 
			this.contactsTable.AllowUserToAddRows = false;
			this.contactsTable.AllowUserToDeleteRows = false;
			this.contactsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.contactsTable.BackgroundColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.contactsTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.contactsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.contactsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.phoneNumber,
            this.lastName,
            this.firstName,
            this.patronymicName,
            this.category,
            this.sex,
            this.city,
            this.birthdayDate});
			this.contactsTable.Dock = System.Windows.Forms.DockStyle.Fill;
			this.contactsTable.Location = new System.Drawing.Point(0, 26);
			this.contactsTable.Name = "contactsTable";
			this.contactsTable.ReadOnly = true;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.contactsTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.contactsTable.RowHeadersVisible = false;
			this.contactsTable.RowHeadersWidth = 51;
			this.contactsTable.RowTemplate.Height = 29;
			this.contactsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.contactsTable.Size = new System.Drawing.Size(1187, 659);
			this.contactsTable.TabIndex = 2;
			// 
			// phoneNumber
			// 
			this.phoneNumber.HeaderText = "Телефон";
			this.phoneNumber.MinimumWidth = 6;
			this.phoneNumber.Name = "phoneNumber";
			this.phoneNumber.ReadOnly = true;
			// 
			// lastName
			// 
			this.lastName.HeaderText = "Фамилия";
			this.lastName.MinimumWidth = 6;
			this.lastName.Name = "lastName";
			this.lastName.ReadOnly = true;
			// 
			// firstName
			// 
			this.firstName.HeaderText = "Имя";
			this.firstName.MinimumWidth = 6;
			this.firstName.Name = "firstName";
			this.firstName.ReadOnly = true;
			// 
			// patronymicName
			// 
			this.patronymicName.HeaderText = "Отчество";
			this.patronymicName.MinimumWidth = 6;
			this.patronymicName.Name = "patronymicName";
			this.patronymicName.ReadOnly = true;
			// 
			// category
			// 
			this.category.HeaderText = "Категория";
			this.category.MinimumWidth = 6;
			this.category.Name = "category";
			this.category.ReadOnly = true;
			// 
			// sex
			// 
			this.sex.HeaderText = "Пол";
			this.sex.MinimumWidth = 6;
			this.sex.Name = "sex";
			this.sex.ReadOnly = true;
			// 
			// city
			// 
			this.city.HeaderText = "Город";
			this.city.MinimumWidth = 6;
			this.city.Name = "city";
			this.city.ReadOnly = true;
			// 
			// birthdayDate
			// 
			this.birthdayDate.HeaderText = "Дата рождения";
			this.birthdayDate.MinimumWidth = 6;
			this.birthdayDate.Name = "birthdayDate";
			this.birthdayDate.ReadOnly = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1187, 685);
			this.Controls.Add(this.contactsTable);
			this.Controls.Add(this.toolStrip1);
			this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "TestTask";
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.contactsTable)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton downloadCsv;
		private System.Windows.Forms.ToolStripButton clearTable;
		private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumber;
		private System.Windows.Forms.DataGridViewTextBoxColumn lastName;
		private System.Windows.Forms.DataGridViewTextBoxColumn firstName;
		private System.Windows.Forms.DataGridViewTextBoxColumn patronymicName;
		private System.Windows.Forms.DataGridViewTextBoxColumn category;
		private System.Windows.Forms.DataGridViewTextBoxColumn sex;
		private System.Windows.Forms.DataGridViewTextBoxColumn city;
		private System.Windows.Forms.DataGridViewTextBoxColumn birthdayDate;
		private System.Windows.Forms.DataGridView contactsTable;
		private System.Windows.Forms.ToolStripLabel processStatus;
	}
}

