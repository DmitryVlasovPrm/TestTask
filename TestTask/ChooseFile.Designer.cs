
namespace TestTask
{
	partial class ChooseFile
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.filePathBox = new System.Windows.Forms.TextBox();
			this.commentBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.chooseFileButton = new System.Windows.Forms.Button();
			this.startProcessButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// filePathBox
			// 
			this.filePathBox.Location = new System.Drawing.Point(12, 35);
			this.filePathBox.Name = "filePathBox";
			this.filePathBox.Size = new System.Drawing.Size(384, 26);
			this.filePathBox.TabIndex = 0;
			this.filePathBox.TextChanged += new System.EventHandler(this.filePathBox_TextChanged);
			// 
			// commentBox
			// 
			this.commentBox.Location = new System.Drawing.Point(12, 126);
			this.commentBox.Name = "commentBox";
			this.commentBox.Size = new System.Drawing.Size(384, 26);
			this.commentBox.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(93, 19);
			this.label1.TabIndex = 2;
			this.label1.Text = "Путь к файлу";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 100);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(97, 19);
			this.label2.TabIndex = 3;
			this.label2.Text = "Комментарий";
			// 
			// chooseFileButton
			// 
			this.chooseFileButton.Location = new System.Drawing.Point(402, 35);
			this.chooseFileButton.Name = "chooseFileButton";
			this.chooseFileButton.Size = new System.Drawing.Size(143, 26);
			this.chooseFileButton.TabIndex = 4;
			this.chooseFileButton.Text = "Выбрать файл";
			this.chooseFileButton.UseVisualStyleBackColor = true;
			this.chooseFileButton.Click += new System.EventHandler(this.chooseFileButton_Click);
			// 
			// startProcessButton
			// 
			this.startProcessButton.Enabled = false;
			this.startProcessButton.Location = new System.Drawing.Point(12, 170);
			this.startProcessButton.Name = "startProcessButton";
			this.startProcessButton.Size = new System.Drawing.Size(233, 55);
			this.startProcessButton.TabIndex = 5;
			this.startProcessButton.Text = "Загрузить";
			this.startProcessButton.UseVisualStyleBackColor = true;
			this.startProcessButton.Click += new System.EventHandler(this.startProcessButton_Click);
			// 
			// ChooseFile
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(557, 237);
			this.Controls.Add(this.startProcessButton);
			this.Controls.Add(this.chooseFileButton);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.commentBox);
			this.Controls.Add(this.filePathBox);
			this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "ChooseFile";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "TestTask";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox filePathBox;
		private System.Windows.Forms.TextBox commentBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button chooseFileButton;
		private System.Windows.Forms.Button startProcessButton;
	}
}