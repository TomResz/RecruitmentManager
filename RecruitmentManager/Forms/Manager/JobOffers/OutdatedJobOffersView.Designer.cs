namespace RecruitmentManager.Forms.Manager.JobOffers
{
	partial class OutdatedJobOffersView
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
			DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OutdatedJobOffersView));
			jobOffersDGV = new DataGridView();
			Id = new DataGridViewTextBoxColumn();
			Position = new DataGridViewTextBoxColumn();
			AddedDate = new DataGridViewTextBoxColumn();
			EndedDate = new DataGridViewTextBoxColumn();
			PasswdReset = new DataGridViewButtonColumn();
			mainLayout = new TableLayoutPanel();
			footerLayout = new TableLayoutPanel();
			pageCounterLabel = new Label();
			nextPageButton = new PictureBox();
			previousPageButton = new PictureBox();
			button1 = new Button();
			((System.ComponentModel.ISupportInitialize)jobOffersDGV).BeginInit();
			mainLayout.SuspendLayout();
			footerLayout.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)nextPageButton).BeginInit();
			((System.ComponentModel.ISupportInitialize)previousPageButton).BeginInit();
			SuspendLayout();
			// 
			// jobOffersDGV
			// 
			jobOffersDGV.AllowUserToAddRows = false;
			jobOffersDGV.AllowUserToDeleteRows = false;
			jobOffersDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			jobOffersDGV.BackgroundColor = SystemColors.Control;
			jobOffersDGV.BorderStyle = BorderStyle.None;
			dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = Color.Blue;
			dataGridViewCellStyle6.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
			dataGridViewCellStyle6.ForeColor = Color.White;
			dataGridViewCellStyle6.SelectionBackColor = Color.Blue;
			dataGridViewCellStyle6.SelectionForeColor = Color.White;
			dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
			jobOffersDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
			jobOffersDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			jobOffersDGV.Columns.AddRange(new DataGridViewColumn[] { Id, Position, AddedDate, EndedDate, PasswdReset });
			jobOffersDGV.Dock = DockStyle.Fill;
			jobOffersDGV.EnableHeadersVisualStyles = false;
			jobOffersDGV.Location = new Point(3, 3);
			jobOffersDGV.MultiSelect = false;
			jobOffersDGV.Name = "jobOffersDGV";
			jobOffersDGV.RowHeadersVisible = false;
			jobOffersDGV.RowHeadersWidth = 51;
			jobOffersDGV.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			jobOffersDGV.RowTemplate.Height = 29;
			jobOffersDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			jobOffersDGV.Size = new Size(1193, 427);
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
			dataGridViewCellStyle7.BackColor = Color.FromArgb(128, 255, 255);
			dataGridViewCellStyle7.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			dataGridViewCellStyle7.ForeColor = Color.Black;
			dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(0, 192, 192);
			dataGridViewCellStyle7.SelectionForeColor = Color.Black;
			Position.DefaultCellStyle = dataGridViewCellStyle7;
			Position.FillWeight = 230F;
			Position.HeaderText = "Stanowisko";
			Position.MinimumWidth = 6;
			Position.Name = "Position";
			Position.ReadOnly = true;
			// 
			// AddedDate
			// 
			AddedDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dataGridViewCellStyle8.BackColor = Color.FromArgb(128, 255, 255);
			dataGridViewCellStyle8.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			dataGridViewCellStyle8.ForeColor = Color.Black;
			dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(0, 192, 192);
			dataGridViewCellStyle8.SelectionForeColor = Color.Black;
			AddedDate.DefaultCellStyle = dataGridViewCellStyle8;
			AddedDate.FillWeight = 280.748657F;
			AddedDate.HeaderText = "Data Dodania";
			AddedDate.MinimumWidth = 6;
			AddedDate.Name = "AddedDate";
			AddedDate.ReadOnly = true;
			// 
			// EndedDate
			// 
			dataGridViewCellStyle9.BackColor = Color.FromArgb(128, 255, 255);
			dataGridViewCellStyle9.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			dataGridViewCellStyle9.ForeColor = Color.Black;
			dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(0, 192, 192);
			dataGridViewCellStyle9.SelectionForeColor = Color.Black;
			EndedDate.DefaultCellStyle = dataGridViewCellStyle9;
			EndedDate.HeaderText = "Data Zakończenia";
			EndedDate.MinimumWidth = 6;
			EndedDate.Name = "EndedDate";
			EndedDate.ReadOnly = true;
			// 
			// PasswdReset
			// 
			PasswdReset.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle10.BackColor = Color.Navy;
			dataGridViewCellStyle10.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			dataGridViewCellStyle10.ForeColor = Color.White;
			dataGridViewCellStyle10.SelectionBackColor = Color.Navy;
			dataGridViewCellStyle10.SelectionForeColor = Color.White;
			PasswdReset.DefaultCellStyle = dataGridViewCellStyle10;
			PasswdReset.FillWeight = 250F;
			PasswdReset.FlatStyle = FlatStyle.Popup;
			PasswdReset.HeaderText = "Szczegóły";
			PasswdReset.MinimumWidth = 6;
			PasswdReset.Name = "PasswdReset";
			PasswdReset.Text = "Wyświetl szegóły!";
			PasswdReset.UseColumnTextForButtonValue = true;
			// 
			// mainLayout
			// 
			mainLayout.ColumnCount = 1;
			mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			mainLayout.Controls.Add(jobOffersDGV, 0, 0);
			mainLayout.Controls.Add(footerLayout, 0, 1);
			mainLayout.Dock = DockStyle.Fill;
			mainLayout.Location = new Point(0, 0);
			mainLayout.Name = "mainLayout";
			mainLayout.RowCount = 2;
			mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
			mainLayout.Size = new Size(1199, 508);
			mainLayout.TabIndex = 2;
			// 
			// footerLayout
			// 
			footerLayout.ColumnCount = 7;
			footerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38F));
			footerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26F));
			footerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18F));
			footerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18F));
			footerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 65F));
			footerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 65F));
			footerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 65F));
			footerLayout.Controls.Add(pageCounterLabel, 6, 0);
			footerLayout.Controls.Add(nextPageButton, 5, 0);
			footerLayout.Controls.Add(previousPageButton, 4, 0);
			footerLayout.Controls.Add(button1, 3, 0);
			footerLayout.Dock = DockStyle.Fill;
			footerLayout.Location = new Point(3, 436);
			footerLayout.Name = "footerLayout";
			footerLayout.RowCount = 1;
			footerLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			footerLayout.Size = new Size(1193, 69);
			footerLayout.TabIndex = 1;
			// 
			// pageCounterLabel
			// 
			pageCounterLabel.Anchor = AnchorStyles.Left;
			pageCounterLabel.AutoSize = true;
			pageCounterLabel.Location = new Point(1129, 24);
			pageCounterLabel.Name = "pageCounterLabel";
			pageCounterLabel.Size = new Size(50, 20);
			pageCounterLabel.TabIndex = 4;
			pageCounterLabel.Text = "label1";
			// 
			// nextPageButton
			// 
			nextPageButton.Image = (Image)resources.GetObject("nextPageButton.Image");
			nextPageButton.Location = new Point(1064, 3);
			nextPageButton.Name = "nextPageButton";
			nextPageButton.Size = new Size(59, 63);
			nextPageButton.TabIndex = 3;
			nextPageButton.TabStop = false;
			nextPageButton.Click += nextPageButton_Click;
			// 
			// previousPageButton
			// 
			previousPageButton.Image = (Image)resources.GetObject("previousPageButton.Image");
			previousPageButton.Location = new Point(999, 3);
			previousPageButton.Name = "previousPageButton";
			previousPageButton.Size = new Size(59, 63);
			previousPageButton.TabIndex = 2;
			previousPageButton.TabStop = false;
			previousPageButton.Click += previousPageButton_Click;
			// 
			// button1
			// 
			button1.Dock = DockStyle.Fill;
			button1.FlatStyle = FlatStyle.Flat;
			button1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			button1.Location = new Point(820, 3);
			button1.Name = "button1";
			button1.Size = new Size(173, 63);
			button1.TabIndex = 5;
			button1.Text = "Usuń";
			button1.UseVisualStyleBackColor = true;
			// 
			// OutdatedJobOffersView
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(mainLayout);
			Name = "OutdatedJobOffersView";
			Size = new Size(1199, 508);
			((System.ComponentModel.ISupportInitialize)jobOffersDGV).EndInit();
			mainLayout.ResumeLayout(false);
			footerLayout.ResumeLayout(false);
			footerLayout.PerformLayout();
			((System.ComponentModel.ISupportInitialize)nextPageButton).EndInit();
			((System.ComponentModel.ISupportInitialize)previousPageButton).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private DataGridView jobOffersDGV;
		private DataGridViewTextBoxColumn Id;
		private DataGridViewTextBoxColumn Position;
		private DataGridViewTextBoxColumn AddedDate;
		private DataGridViewTextBoxColumn EndedDate;
		private DataGridViewButtonColumn PasswdReset;
		private TableLayoutPanel mainLayout;
		private TableLayoutPanel footerLayout;
		private Label pageCounterLabel;
		private PictureBox nextPageButton;
		private PictureBox previousPageButton;
		private Button button1;
	}
}
