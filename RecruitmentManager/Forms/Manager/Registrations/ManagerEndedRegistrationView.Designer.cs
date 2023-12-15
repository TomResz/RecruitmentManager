namespace RecruitmentManager.Forms.Manager.Registrations
{
	partial class ManagerEndedRegistrationView
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerEndedRegistrationView));
			DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
			jobOffersDGV = new DataGridView();
			Id = new DataGridViewTextBoxColumn();
			Position = new DataGridViewTextBoxColumn();
			AddedDate = new DataGridViewTextBoxColumn();
			EndedDate = new DataGridViewTextBoxColumn();
			pageCounterLabel = new Label();
			nextPageButton = new PictureBox();
			previousPageButton = new PictureBox();
			footerLayout = new TableLayoutPanel();
			selectCandidatesBtn = new Button();
			mainLayout = new TableLayoutPanel();
			tableLayoutPanel = new TableLayoutPanel();
			usersView = new DataGridView();
			dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
			positionOnListColumn = new DataGridViewTextBoxColumn();
			dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
			averageText = new DataGridViewTextBoxColumn();
			concludeBtn = new Button();
			((System.ComponentModel.ISupportInitialize)jobOffersDGV).BeginInit();
			((System.ComponentModel.ISupportInitialize)nextPageButton).BeginInit();
			((System.ComponentModel.ISupportInitialize)previousPageButton).BeginInit();
			footerLayout.SuspendLayout();
			mainLayout.SuspendLayout();
			tableLayoutPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)usersView).BeginInit();
			SuspendLayout();
			// 
			// jobOffersDGV
			// 
			jobOffersDGV.AllowUserToAddRows = false;
			jobOffersDGV.AllowUserToDeleteRows = false;
			jobOffersDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			jobOffersDGV.BackgroundColor = SystemColors.Control;
			jobOffersDGV.BorderStyle = BorderStyle.None;
			dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle9.BackColor = Color.Blue;
			dataGridViewCellStyle9.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
			dataGridViewCellStyle9.ForeColor = Color.White;
			dataGridViewCellStyle9.SelectionBackColor = Color.Blue;
			dataGridViewCellStyle9.SelectionForeColor = Color.White;
			dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
			jobOffersDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
			jobOffersDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			jobOffersDGV.Columns.AddRange(new DataGridViewColumn[] { Id, Position, AddedDate, EndedDate });
			jobOffersDGV.Dock = DockStyle.Fill;
			jobOffersDGV.EnableHeadersVisualStyles = false;
			jobOffersDGV.Location = new Point(3, 2);
			jobOffersDGV.Margin = new Padding(3, 2, 3, 2);
			jobOffersDGV.MultiSelect = false;
			jobOffersDGV.Name = "jobOffersDGV";
			jobOffersDGV.RowHeadersVisible = false;
			jobOffersDGV.RowHeadersWidth = 51;
			jobOffersDGV.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			jobOffersDGV.RowTemplate.Height = 29;
			jobOffersDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			jobOffersDGV.Size = new Size(433, 413);
			jobOffersDGV.TabIndex = 0;
			// 
			// Id
			// 
			Id.HeaderText = "ID";
			Id.MinimumWidth = 6;
			Id.Name = "Id";
			Id.ReadOnly = true;
			Id.Visible = false;
			// 
			// Position
			// 
			Position.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dataGridViewCellStyle10.BackColor = Color.FromArgb(128, 255, 255);
			dataGridViewCellStyle10.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			dataGridViewCellStyle10.ForeColor = Color.Black;
			dataGridViewCellStyle10.SelectionBackColor = Color.FromArgb(0, 192, 192);
			dataGridViewCellStyle10.SelectionForeColor = Color.Black;
			Position.DefaultCellStyle = dataGridViewCellStyle10;
			Position.FillWeight = 230F;
			Position.HeaderText = "Stanowisko";
			Position.MinimumWidth = 6;
			Position.Name = "Position";
			Position.ReadOnly = true;
			// 
			// AddedDate
			// 
			AddedDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dataGridViewCellStyle11.BackColor = Color.FromArgb(128, 255, 255);
			dataGridViewCellStyle11.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			dataGridViewCellStyle11.ForeColor = Color.Black;
			dataGridViewCellStyle11.SelectionBackColor = Color.FromArgb(0, 192, 192);
			dataGridViewCellStyle11.SelectionForeColor = Color.Black;
			AddedDate.DefaultCellStyle = dataGridViewCellStyle11;
			AddedDate.FillWeight = 280.748657F;
			AddedDate.HeaderText = "Data Dodania";
			AddedDate.MinimumWidth = 6;
			AddedDate.Name = "AddedDate";
			AddedDate.ReadOnly = true;
			// 
			// EndedDate
			// 
			dataGridViewCellStyle12.BackColor = Color.FromArgb(128, 255, 255);
			dataGridViewCellStyle12.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			dataGridViewCellStyle12.ForeColor = Color.Black;
			dataGridViewCellStyle12.SelectionBackColor = Color.FromArgb(0, 192, 192);
			dataGridViewCellStyle12.SelectionForeColor = Color.Black;
			EndedDate.DefaultCellStyle = dataGridViewCellStyle12;
			EndedDate.HeaderText = "Data Zakończenia";
			EndedDate.MinimumWidth = 6;
			EndedDate.Name = "EndedDate";
			EndedDate.ReadOnly = true;
			// 
			// pageCounterLabel
			// 
			pageCounterLabel.Anchor = AnchorStyles.Left;
			pageCounterLabel.AutoSize = true;
			pageCounterLabel.Location = new Point(377, 18);
			pageCounterLabel.Name = "pageCounterLabel";
			pageCounterLabel.Size = new Size(38, 15);
			pageCounterLabel.TabIndex = 4;
			pageCounterLabel.Text = "label1";
			// 
			// nextPageButton
			// 
			nextPageButton.Image = (Image)resources.GetObject("nextPageButton.Image");
			nextPageButton.Location = new Point(320, 2);
			nextPageButton.Margin = new Padding(3, 2, 3, 2);
			nextPageButton.Name = "nextPageButton";
			nextPageButton.Size = new Size(51, 47);
			nextPageButton.TabIndex = 3;
			nextPageButton.TabStop = false;
			nextPageButton.Click += nextPageButton_Click;
			// 
			// previousPageButton
			// 
			previousPageButton.Image = (Image)resources.GetObject("previousPageButton.Image");
			previousPageButton.Location = new Point(263, 2);
			previousPageButton.Margin = new Padding(3, 2, 3, 2);
			previousPageButton.Name = "previousPageButton";
			previousPageButton.Size = new Size(51, 47);
			previousPageButton.TabIndex = 2;
			previousPageButton.TabStop = false;
			previousPageButton.Click += previousPageButton_Click;
			// 
			// footerLayout
			// 
			footerLayout.ColumnCount = 5;
			footerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			footerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			footerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 57F));
			footerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 57F));
			footerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 59F));
			footerLayout.Controls.Add(concludeBtn, 0, 0);
			footerLayout.Controls.Add(pageCounterLabel, 4, 0);
			footerLayout.Controls.Add(nextPageButton, 3, 0);
			footerLayout.Controls.Add(previousPageButton, 2, 0);
			footerLayout.Controls.Add(selectCandidatesBtn, 0, 0);
			footerLayout.Dock = DockStyle.Fill;
			footerLayout.Location = new Point(3, 419);
			footerLayout.Margin = new Padding(3, 2, 3, 2);
			footerLayout.Name = "footerLayout";
			footerLayout.RowCount = 1;
			footerLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			footerLayout.Size = new Size(433, 52);
			footerLayout.TabIndex = 1;
			// 
			// selectCandidatesBtn
			// 
			selectCandidatesBtn.Dock = DockStyle.Fill;
			selectCandidatesBtn.FlatStyle = FlatStyle.Flat;
			selectCandidatesBtn.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
			selectCandidatesBtn.Location = new Point(3, 3);
			selectCandidatesBtn.Name = "selectCandidatesBtn";
			selectCandidatesBtn.Size = new Size(124, 46);
			selectCandidatesBtn.TabIndex = 5;
			selectCandidatesBtn.Text = "Wybierz Kandydatów";
			selectCandidatesBtn.UseVisualStyleBackColor = true;
			selectCandidatesBtn.Click += selectCandidatesBtn_Click;
			// 
			// mainLayout
			// 
			mainLayout.ColumnCount = 1;
			mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			mainLayout.Controls.Add(jobOffersDGV, 0, 0);
			mainLayout.Controls.Add(footerLayout, 0, 1);
			mainLayout.Dock = DockStyle.Fill;
			mainLayout.Location = new Point(6, 5);
			mainLayout.Margin = new Padding(3, 2, 3, 2);
			mainLayout.Name = "mainLayout";
			mainLayout.RowCount = 2;
			mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
			mainLayout.Size = new Size(439, 473);
			mainLayout.TabIndex = 3;
			// 
			// tableLayoutPanel
			// 
			tableLayoutPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.OutsetDouble;
			tableLayoutPanel.ColumnCount = 2;
			tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
			tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
			tableLayoutPanel.Controls.Add(mainLayout, 0, 0);
			tableLayoutPanel.Controls.Add(usersView, 1, 0);
			tableLayoutPanel.Dock = DockStyle.Fill;
			tableLayoutPanel.Location = new Point(0, 0);
			tableLayoutPanel.Margin = new Padding(3, 2, 3, 2);
			tableLayoutPanel.Name = "tableLayoutPanel";
			tableLayoutPanel.RowCount = 1;
			tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			tableLayoutPanel.Size = new Size(1123, 483);
			tableLayoutPanel.TabIndex = 1;
			// 
			// usersView
			// 
			usersView.AllowUserToAddRows = false;
			usersView.AllowUserToDeleteRows = false;
			usersView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			usersView.BackgroundColor = SystemColors.Control;
			usersView.BorderStyle = BorderStyle.None;
			dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle13.BackColor = Color.Blue;
			dataGridViewCellStyle13.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
			dataGridViewCellStyle13.ForeColor = Color.White;
			dataGridViewCellStyle13.SelectionBackColor = Color.Blue;
			dataGridViewCellStyle13.SelectionForeColor = Color.White;
			dataGridViewCellStyle13.WrapMode = DataGridViewTriState.True;
			usersView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
			usersView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			usersView.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, positionOnListColumn, dataGridViewTextBoxColumn2, averageText });
			usersView.Dock = DockStyle.Fill;
			usersView.EnableHeadersVisualStyles = false;
			usersView.Location = new Point(454, 5);
			usersView.Margin = new Padding(3, 2, 3, 2);
			usersView.MultiSelect = false;
			usersView.Name = "usersView";
			usersView.RowHeadersVisible = false;
			usersView.RowHeadersWidth = 51;
			usersView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			usersView.RowTemplate.Height = 29;
			usersView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			usersView.Size = new Size(663, 473);
			usersView.TabIndex = 2;
			// 
			// dataGridViewTextBoxColumn1
			// 
			dataGridViewTextBoxColumn1.HeaderText = "ID";
			dataGridViewTextBoxColumn1.MinimumWidth = 6;
			dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			dataGridViewTextBoxColumn1.ReadOnly = true;
			dataGridViewTextBoxColumn1.Visible = false;
			// 
			// positionOnListColumn
			// 
			dataGridViewCellStyle14.BackColor = Color.FromArgb(128, 255, 255);
			dataGridViewCellStyle14.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			dataGridViewCellStyle14.ForeColor = Color.Black;
			dataGridViewCellStyle14.SelectionBackColor = Color.FromArgb(0, 192, 192);
			dataGridViewCellStyle14.SelectionForeColor = Color.Black;
			positionOnListColumn.DefaultCellStyle = dataGridViewCellStyle14;
			positionOnListColumn.HeaderText = "Pozycja Na Liście";
			positionOnListColumn.MinimumWidth = 6;
			positionOnListColumn.Name = "positionOnListColumn";
			positionOnListColumn.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn2
			// 
			dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dataGridViewCellStyle15.BackColor = Color.FromArgb(128, 255, 255);
			dataGridViewCellStyle15.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			dataGridViewCellStyle15.ForeColor = Color.Black;
			dataGridViewCellStyle15.SelectionBackColor = Color.FromArgb(0, 192, 192);
			dataGridViewCellStyle15.SelectionForeColor = Color.Black;
			dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle15;
			dataGridViewTextBoxColumn2.FillWeight = 230F;
			dataGridViewTextBoxColumn2.HeaderText = "Imię i Nazwisko";
			dataGridViewTextBoxColumn2.MinimumWidth = 6;
			dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			dataGridViewTextBoxColumn2.ReadOnly = true;
			// 
			// averageText
			// 
			dataGridViewCellStyle16.BackColor = Color.FromArgb(128, 255, 255);
			dataGridViewCellStyle16.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			dataGridViewCellStyle16.ForeColor = Color.Black;
			dataGridViewCellStyle16.SelectionBackColor = Color.FromArgb(0, 192, 192);
			dataGridViewCellStyle16.SelectionForeColor = Color.Black;
			averageText.DefaultCellStyle = dataGridViewCellStyle16;
			averageText.HeaderText = "Średnia ważona";
			averageText.MinimumWidth = 6;
			averageText.Name = "averageText";
			averageText.ReadOnly = true;
			// 
			// concludeBtn
			// 
			concludeBtn.Dock = DockStyle.Fill;
			concludeBtn.FlatStyle = FlatStyle.Flat;
			concludeBtn.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
			concludeBtn.Location = new Point(133, 3);
			concludeBtn.Name = "concludeBtn";
			concludeBtn.Size = new Size(124, 46);
			concludeBtn.TabIndex = 6;
			concludeBtn.Text = "Zakończ Proces";
			concludeBtn.UseVisualStyleBackColor = true;
			concludeBtn.Click += concludeBtn_Click;
			// 
			// ManagerEndedRegistrationView
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(tableLayoutPanel);
			Name = "ManagerEndedRegistrationView";
			Size = new Size(1123, 483);
			((System.ComponentModel.ISupportInitialize)jobOffersDGV).EndInit();
			((System.ComponentModel.ISupportInitialize)nextPageButton).EndInit();
			((System.ComponentModel.ISupportInitialize)previousPageButton).EndInit();
			footerLayout.ResumeLayout(false);
			footerLayout.PerformLayout();
			mainLayout.ResumeLayout(false);
			tableLayoutPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)usersView).EndInit();
			ResumeLayout(false);
		}

		#endregion
		private DataGridView jobOffersDGV;
		private DataGridViewTextBoxColumn Id;
		private DataGridViewTextBoxColumn Position;
		private DataGridViewTextBoxColumn AddedDate;
		private DataGridViewTextBoxColumn EndedDate;
		private Label pageCounterLabel;
		private PictureBox nextPageButton;
		private PictureBox previousPageButton;
		private TableLayoutPanel footerLayout;
		private TableLayoutPanel mainLayout;
		private TableLayoutPanel tableLayoutPanel;
		private DataGridView usersView;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private DataGridViewTextBoxColumn positionOnListColumn;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private DataGridViewTextBoxColumn averageText;
		private Button selectCandidatesBtn;
		private Button concludeBtn;
	}
}
