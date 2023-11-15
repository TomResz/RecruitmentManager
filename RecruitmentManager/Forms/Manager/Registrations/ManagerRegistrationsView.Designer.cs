namespace RecruitmentManager.Forms.Manager.Registrations
{
	partial class ManagerRegistrationsView
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
			DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerRegistrationsView));
			DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
			tableLayoutPanel = new TableLayoutPanel();
			mainLayout = new TableLayoutPanel();
			jobOffersDGV = new DataGridView();
			Id = new DataGridViewTextBoxColumn();
			Position = new DataGridViewTextBoxColumn();
			AddedDate = new DataGridViewTextBoxColumn();
			EndedDate = new DataGridViewTextBoxColumn();
			footerLayout = new TableLayoutPanel();
			pageCounterLabel = new Label();
			nextPageButton = new PictureBox();
			previousPageButton = new PictureBox();
			usersView = new DataGridView();
			dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
			dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
			DetailsBtn = new DataGridViewButtonColumn();
			tableLayoutPanel.SuspendLayout();
			mainLayout.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)jobOffersDGV).BeginInit();
			footerLayout.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)nextPageButton).BeginInit();
			((System.ComponentModel.ISupportInitialize)previousPageButton).BeginInit();
			((System.ComponentModel.ISupportInitialize)usersView).BeginInit();
			SuspendLayout();
			// 
			// tableLayoutPanel
			// 
			tableLayoutPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.OutsetDouble;
			tableLayoutPanel.ColumnCount = 2;
			tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel.Controls.Add(mainLayout, 0, 0);
			tableLayoutPanel.Controls.Add(usersView, 1, 0);
			tableLayoutPanel.Dock = DockStyle.Fill;
			tableLayoutPanel.Location = new Point(0, 0);
			tableLayoutPanel.Name = "tableLayoutPanel";
			tableLayoutPanel.RowCount = 1;
			tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
			tableLayoutPanel.Size = new Size(1226, 582);
			tableLayoutPanel.TabIndex = 0;
			// 
			// mainLayout
			// 
			mainLayout.ColumnCount = 1;
			mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			mainLayout.Controls.Add(jobOffersDGV, 0, 0);
			mainLayout.Controls.Add(footerLayout, 0, 1);
			mainLayout.Dock = DockStyle.Fill;
			mainLayout.Location = new Point(6, 6);
			mainLayout.Name = "mainLayout";
			mainLayout.RowCount = 2;
			mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
			mainLayout.Size = new Size(602, 570);
			mainLayout.TabIndex = 3;
			// 
			// jobOffersDGV
			// 
			jobOffersDGV.AllowUserToAddRows = false;
			jobOffersDGV.AllowUserToDeleteRows = false;
			jobOffersDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			jobOffersDGV.BackgroundColor = SystemColors.Control;
			jobOffersDGV.BorderStyle = BorderStyle.None;
			dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = Color.Blue;
			dataGridViewCellStyle1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
			dataGridViewCellStyle1.ForeColor = Color.White;
			dataGridViewCellStyle1.SelectionBackColor = Color.Blue;
			dataGridViewCellStyle1.SelectionForeColor = Color.White;
			dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
			jobOffersDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			jobOffersDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			jobOffersDGV.Columns.AddRange(new DataGridViewColumn[] { Id, Position, AddedDate, EndedDate });
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
			jobOffersDGV.Size = new Size(596, 489);
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
			dataGridViewCellStyle2.BackColor = Color.FromArgb(128, 255, 255);
			dataGridViewCellStyle2.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			dataGridViewCellStyle2.ForeColor = Color.Black;
			dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 192, 192);
			dataGridViewCellStyle2.SelectionForeColor = Color.Black;
			Position.DefaultCellStyle = dataGridViewCellStyle2;
			Position.FillWeight = 230F;
			Position.HeaderText = "Stanowisko";
			Position.MinimumWidth = 6;
			Position.Name = "Position";
			Position.ReadOnly = true;
			// 
			// AddedDate
			// 
			AddedDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dataGridViewCellStyle3.BackColor = Color.FromArgb(128, 255, 255);
			dataGridViewCellStyle3.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			dataGridViewCellStyle3.ForeColor = Color.Black;
			dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 192, 192);
			dataGridViewCellStyle3.SelectionForeColor = Color.Black;
			AddedDate.DefaultCellStyle = dataGridViewCellStyle3;
			AddedDate.FillWeight = 280.748657F;
			AddedDate.HeaderText = "Data Dodania";
			AddedDate.MinimumWidth = 6;
			AddedDate.Name = "AddedDate";
			AddedDate.ReadOnly = true;
			// 
			// EndedDate
			// 
			dataGridViewCellStyle4.BackColor = Color.FromArgb(128, 255, 255);
			dataGridViewCellStyle4.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			dataGridViewCellStyle4.ForeColor = Color.Black;
			dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(0, 192, 192);
			dataGridViewCellStyle4.SelectionForeColor = Color.Black;
			EndedDate.DefaultCellStyle = dataGridViewCellStyle4;
			EndedDate.HeaderText = "Data Zakończenia";
			EndedDate.MinimumWidth = 6;
			EndedDate.Name = "EndedDate";
			EndedDate.ReadOnly = true;
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
			footerLayout.Dock = DockStyle.Fill;
			footerLayout.Location = new Point(3, 498);
			footerLayout.Name = "footerLayout";
			footerLayout.RowCount = 1;
			footerLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			footerLayout.Size = new Size(596, 69);
			footerLayout.TabIndex = 1;
			// 
			// pageCounterLabel
			// 
			pageCounterLabel.Anchor = AnchorStyles.Left;
			pageCounterLabel.AutoSize = true;
			pageCounterLabel.Location = new Point(533, 24);
			pageCounterLabel.Name = "pageCounterLabel";
			pageCounterLabel.Size = new Size(50, 20);
			pageCounterLabel.TabIndex = 4;
			pageCounterLabel.Text = "label1";
			// 
			// nextPageButton
			// 
			nextPageButton.Image = (Image)resources.GetObject("nextPageButton.Image");
			nextPageButton.Location = new Point(468, 3);
			nextPageButton.Name = "nextPageButton";
			nextPageButton.Size = new Size(59, 63);
			nextPageButton.TabIndex = 3;
			nextPageButton.TabStop = false;
			nextPageButton.Click += nextPageButton_Click;
			// 
			// previousPageButton
			// 
			previousPageButton.Image = (Image)resources.GetObject("previousPageButton.Image");
			previousPageButton.Location = new Point(403, 3);
			previousPageButton.Name = "previousPageButton";
			previousPageButton.Size = new Size(59, 63);
			previousPageButton.TabIndex = 2;
			previousPageButton.TabStop = false;
			previousPageButton.Click += previousPageButton_Click;
			// 
			// usersView
			// 
			usersView.AllowUserToAddRows = false;
			usersView.AllowUserToDeleteRows = false;
			usersView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			usersView.BackgroundColor = SystemColors.Control;
			usersView.BorderStyle = BorderStyle.None;
			dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = Color.Blue;
			dataGridViewCellStyle5.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
			dataGridViewCellStyle5.ForeColor = Color.White;
			dataGridViewCellStyle5.SelectionBackColor = Color.Blue;
			dataGridViewCellStyle5.SelectionForeColor = Color.White;
			dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
			usersView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
			usersView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			usersView.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, DetailsBtn });
			usersView.Dock = DockStyle.Fill;
			usersView.EnableHeadersVisualStyles = false;
			usersView.Location = new Point(617, 6);
			usersView.MultiSelect = false;
			usersView.Name = "usersView";
			usersView.RowHeadersVisible = false;
			usersView.RowHeadersWidth = 51;
			usersView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			usersView.RowTemplate.Height = 29;
			usersView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			usersView.Size = new Size(603, 570);
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
			// dataGridViewTextBoxColumn2
			// 
			dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dataGridViewCellStyle6.BackColor = Color.FromArgb(128, 255, 255);
			dataGridViewCellStyle6.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			dataGridViewCellStyle6.ForeColor = Color.Black;
			dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(0, 192, 192);
			dataGridViewCellStyle6.SelectionForeColor = Color.Black;
			dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle6;
			dataGridViewTextBoxColumn2.FillWeight = 230F;
			dataGridViewTextBoxColumn2.HeaderText = "Imię i Nazwisko";
			dataGridViewTextBoxColumn2.MinimumWidth = 6;
			dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			dataGridViewTextBoxColumn2.ReadOnly = true;
			// 
			// DetailsBtn
			// 
			DetailsBtn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle7.BackColor = Color.Navy;
			dataGridViewCellStyle7.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			dataGridViewCellStyle7.ForeColor = Color.White;
			dataGridViewCellStyle7.SelectionBackColor = Color.Navy;
			dataGridViewCellStyle7.SelectionForeColor = Color.White;
			DetailsBtn.DefaultCellStyle = dataGridViewCellStyle7;
			DetailsBtn.FillWeight = 250F;
			DetailsBtn.FlatStyle = FlatStyle.Popup;
			DetailsBtn.HeaderText = "Szczegóły";
			DetailsBtn.MinimumWidth = 6;
			DetailsBtn.Name = "DetailsBtn";
			DetailsBtn.Text = "Wyświetl szczegóły!";
			DetailsBtn.UseColumnTextForButtonValue = true;
			// 
			// ManagerRegistrationsView
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(tableLayoutPanel);
			Name = "ManagerRegistrationsView";
			Size = new Size(1226, 582);
			tableLayoutPanel.ResumeLayout(false);
			mainLayout.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)jobOffersDGV).EndInit();
			footerLayout.ResumeLayout(false);
			footerLayout.PerformLayout();
			((System.ComponentModel.ISupportInitialize)nextPageButton).EndInit();
			((System.ComponentModel.ISupportInitialize)previousPageButton).EndInit();
			((System.ComponentModel.ISupportInitialize)usersView).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private TableLayoutPanel tableLayoutPanel;
		private DataGridView usersView;
		private TableLayoutPanel mainLayout;
		private DataGridView jobOffersDGV;
		private TableLayoutPanel footerLayout;
		private Label pageCounterLabel;
		private PictureBox nextPageButton;
		private PictureBox previousPageButton;
		private DataGridViewTextBoxColumn Id;
		private DataGridViewTextBoxColumn Position;
		private DataGridViewTextBoxColumn AddedDate;
		private DataGridViewTextBoxColumn EndedDate;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private DataGridViewButtonColumn DetailsBtn;
	}
}
