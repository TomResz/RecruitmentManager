namespace RecruitmentManager.Forms.Manager.Registrations
{
	partial class EndRegistrationForm
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
			DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
			mainPanel = new TableLayoutPanel();
			usersView = new DataGridView();
			footerPanel = new TableLayoutPanel();
			candidateCounterLabel = new Label();
			endBtn = new Button();
			dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
			isSelectedCb = new DataGridViewCheckBoxColumn();
			positionOnListColumn = new DataGridViewTextBoxColumn();
			dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
			averageText = new DataGridViewTextBoxColumn();
			mainPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)usersView).BeginInit();
			footerPanel.SuspendLayout();
			SuspendLayout();
			// 
			// mainPanel
			// 
			mainPanel.ColumnCount = 1;
			mainPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			mainPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
			mainPanel.Controls.Add(usersView, 0, 0);
			mainPanel.Controls.Add(footerPanel, 0, 1);
			mainPanel.Dock = DockStyle.Fill;
			mainPanel.Location = new Point(0, 0);
			mainPanel.Name = "mainPanel";
			mainPanel.RowCount = 2;
			mainPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			mainPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
			mainPanel.Size = new Size(516, 591);
			mainPanel.TabIndex = 0;
			// 
			// usersView
			// 
			usersView.AllowUserToAddRows = false;
			usersView.AllowUserToDeleteRows = false;
			usersView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			usersView.BackgroundColor = SystemColors.Control;
			usersView.BorderStyle = BorderStyle.None;
			dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = Color.Blue;
			dataGridViewCellStyle1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
			dataGridViewCellStyle1.ForeColor = Color.White;
			dataGridViewCellStyle1.SelectionBackColor = Color.Blue;
			dataGridViewCellStyle1.SelectionForeColor = Color.White;
			dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
			usersView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			usersView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			usersView.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, isSelectedCb, positionOnListColumn, dataGridViewTextBoxColumn2, averageText });
			usersView.Dock = DockStyle.Fill;
			usersView.EnableHeadersVisualStyles = false;
			usersView.Location = new Point(3, 2);
			usersView.Margin = new Padding(3, 2, 3, 2);
			usersView.MultiSelect = false;
			usersView.Name = "usersView";
			usersView.RowHeadersVisible = false;
			usersView.RowHeadersWidth = 51;
			usersView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			usersView.RowTemplate.Height = 29;
			usersView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			usersView.Size = new Size(510, 487);
			usersView.TabIndex = 3;
			// 
			// footerPanel
			// 
			footerPanel.ColumnCount = 2;
			footerPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			footerPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			footerPanel.Controls.Add(candidateCounterLabel, 0, 0);
			footerPanel.Controls.Add(endBtn, 1, 0);
			footerPanel.Dock = DockStyle.Fill;
			footerPanel.Location = new Point(3, 494);
			footerPanel.Name = "footerPanel";
			footerPanel.RowCount = 1;
			footerPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			footerPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
			footerPanel.Size = new Size(510, 94);
			footerPanel.TabIndex = 0;
			// 
			// candidateCounterLabel
			// 
			candidateCounterLabel.Anchor = AnchorStyles.None;
			candidateCounterLabel.AutoSize = true;
			candidateCounterLabel.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
			candidateCounterLabel.Location = new Point(48, 36);
			candidateCounterLabel.Name = "candidateCounterLabel";
			candidateCounterLabel.Size = new Size(159, 22);
			candidateCounterLabel.TabIndex = 0;
			candidateCounterLabel.Text = "Ilość kandydatów:";
			// 
			// endBtn
			// 
			endBtn.Dock = DockStyle.Fill;
			endBtn.FlatStyle = FlatStyle.Flat;
			endBtn.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
			endBtn.Location = new Point(258, 3);
			endBtn.Name = "endBtn";
			endBtn.Size = new Size(249, 88);
			endBtn.TabIndex = 1;
			endBtn.Text = "Wybierz kandydatów";
			endBtn.UseVisualStyleBackColor = true;
			endBtn.Click += endBtn_Click;
			// 
			// dataGridViewTextBoxColumn1
			// 
			dataGridViewTextBoxColumn1.HeaderText = "ID";
			dataGridViewTextBoxColumn1.MinimumWidth = 6;
			dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			dataGridViewTextBoxColumn1.ReadOnly = true;
			dataGridViewTextBoxColumn1.Visible = false;
			// 
			// isSelectedCb
			// 
			dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
			dataGridViewCellStyle2.NullValue = false;
			isSelectedCb.DefaultCellStyle = dataGridViewCellStyle2;
			isSelectedCb.HeaderText = "Czy wybrany ?";
			isSelectedCb.Name = "isSelectedCb";
			// 
			// positionOnListColumn
			// 
			dataGridViewCellStyle3.BackColor = Color.FromArgb(128, 255, 255);
			dataGridViewCellStyle3.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			dataGridViewCellStyle3.ForeColor = Color.Black;
			dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 192, 192);
			dataGridViewCellStyle3.SelectionForeColor = Color.Black;
			positionOnListColumn.DefaultCellStyle = dataGridViewCellStyle3;
			positionOnListColumn.HeaderText = "Pozycja Na Liście";
			positionOnListColumn.MinimumWidth = 6;
			positionOnListColumn.Name = "positionOnListColumn";
			positionOnListColumn.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn2
			// 
			dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dataGridViewCellStyle4.BackColor = Color.FromArgb(128, 255, 255);
			dataGridViewCellStyle4.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			dataGridViewCellStyle4.ForeColor = Color.Black;
			dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(0, 192, 192);
			dataGridViewCellStyle4.SelectionForeColor = Color.Black;
			dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle4;
			dataGridViewTextBoxColumn2.FillWeight = 230F;
			dataGridViewTextBoxColumn2.HeaderText = "Imię i Nazwisko";
			dataGridViewTextBoxColumn2.MinimumWidth = 6;
			dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			dataGridViewTextBoxColumn2.ReadOnly = true;
			// 
			// averageText
			// 
			dataGridViewCellStyle5.BackColor = Color.FromArgb(128, 255, 255);
			dataGridViewCellStyle5.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			dataGridViewCellStyle5.ForeColor = Color.Black;
			dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(0, 192, 192);
			dataGridViewCellStyle5.SelectionForeColor = Color.Black;
			averageText.DefaultCellStyle = dataGridViewCellStyle5;
			averageText.HeaderText = "Średnia ważona";
			averageText.MinimumWidth = 6;
			averageText.Name = "averageText";
			averageText.ReadOnly = true;
			// 
			// EndRegistrationForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(516, 591);
			Controls.Add(mainPanel);
			Name = "EndRegistrationForm";
			Text = "EndRegistrationForm";
			mainPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)usersView).EndInit();
			footerPanel.ResumeLayout(false);
			footerPanel.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private TableLayoutPanel mainPanel;
		private TableLayoutPanel footerPanel;
		private DataGridView usersView;
		private Label candidateCounterLabel;
		private Button endBtn;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private DataGridViewCheckBoxColumn isSelectedCb;
		private DataGridViewTextBoxColumn positionOnListColumn;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private DataGridViewTextBoxColumn averageText;
	}
}