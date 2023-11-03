namespace RecruitmentManager.Forms.Manager.JobOffers
{
	partial class CurrentJobOffersView
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
			DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CurrentJobOffersView));
			jobOffersDGV = new DataGridView();
			Id = new DataGridViewTextBoxColumn();
			Position = new DataGridViewTextBoxColumn();
			AddedDate = new DataGridViewTextBoxColumn();
			EndedDate = new DataGridViewTextBoxColumn();
			PasswdReset = new DataGridViewButtonColumn();
			mainLayout = new TableLayoutPanel();
			footerLayout = new TableLayoutPanel();
			nextPageButton = new PictureBox();
			previousPageButton = new PictureBox();
			button1 = new Button();
			addBtn = new Button();
			editBtn = new Button();
			pageCounterLabel = new Label();
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
			dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = Color.Blue;
			dataGridViewCellStyle1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
			dataGridViewCellStyle1.ForeColor = Color.White;
			dataGridViewCellStyle1.SelectionBackColor = Color.Blue;
			dataGridViewCellStyle1.SelectionForeColor = Color.White;
			dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
			jobOffersDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
			jobOffersDGV.Size = new Size(1199, 501);
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
			// PasswdReset
			// 
			PasswdReset.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle5.BackColor = Color.Navy;
			dataGridViewCellStyle5.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			dataGridViewCellStyle5.ForeColor = Color.White;
			dataGridViewCellStyle5.SelectionBackColor = Color.Navy;
			dataGridViewCellStyle5.SelectionForeColor = Color.White;
			PasswdReset.DefaultCellStyle = dataGridViewCellStyle5;
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
			mainLayout.Size = new Size(1205, 582);
			mainLayout.TabIndex = 3;
			// 
			// footerLayout
			// 
			footerLayout.ColumnCount = 7;
			footerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 46F));
			footerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18F));
			footerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18F));
			footerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18F));
			footerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 65F));
			footerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 65F));
			footerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 65F));
			footerLayout.Controls.Add(nextPageButton, 5, 0);
			footerLayout.Controls.Add(previousPageButton, 4, 0);
			footerLayout.Controls.Add(button1, 3, 0);
			footerLayout.Controls.Add(addBtn, 1, 0);
			footerLayout.Controls.Add(editBtn, 2, 0);
			footerLayout.Controls.Add(pageCounterLabel, 6, 0);
			footerLayout.Dock = DockStyle.Fill;
			footerLayout.Location = new Point(3, 510);
			footerLayout.Name = "footerLayout";
			footerLayout.RowCount = 1;
			footerLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			footerLayout.Size = new Size(1199, 69);
			footerLayout.TabIndex = 1;
			// 
			// nextPageButton
			// 
			nextPageButton.Image = (Image)resources.GetObject("nextPageButton.Image");
			nextPageButton.Location = new Point(1069, 3);
			nextPageButton.Name = "nextPageButton";
			nextPageButton.Size = new Size(59, 63);
			nextPageButton.TabIndex = 3;
			nextPageButton.TabStop = false;
			nextPageButton.Click += nextPageButton_Click;
			// 
			// previousPageButton
			// 
			previousPageButton.Image = (Image)resources.GetObject("previousPageButton.Image");
			previousPageButton.Location = new Point(1004, 3);
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
			button1.Location = new Point(824, 3);
			button1.Name = "button1";
			button1.Size = new Size(174, 63);
			button1.TabIndex = 5;
			button1.Text = "Usuń";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// addBtn
			// 
			addBtn.Dock = DockStyle.Fill;
			addBtn.FlatStyle = FlatStyle.Flat;
			addBtn.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			addBtn.Location = new Point(464, 3);
			addBtn.Name = "addBtn";
			addBtn.Size = new Size(174, 63);
			addBtn.TabIndex = 6;
			addBtn.Text = "Dodaj";
			addBtn.UseVisualStyleBackColor = true;
			addBtn.Click += addBtn_Click;
			// 
			// editBtn
			// 
			editBtn.Dock = DockStyle.Fill;
			editBtn.FlatStyle = FlatStyle.Flat;
			editBtn.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			editBtn.Location = new Point(644, 3);
			editBtn.Name = "editBtn";
			editBtn.Size = new Size(174, 63);
			editBtn.TabIndex = 7;
			editBtn.Text = "Edytuj";
			editBtn.UseVisualStyleBackColor = true;
			editBtn.Click += editBtn_Click;
			// 
			// pageCounterLabel
			// 
			pageCounterLabel.Anchor = AnchorStyles.Left;
			pageCounterLabel.AutoSize = true;
			pageCounterLabel.Location = new Point(1134, 24);
			pageCounterLabel.Name = "pageCounterLabel";
			pageCounterLabel.Size = new Size(50, 20);
			pageCounterLabel.TabIndex = 4;
			pageCounterLabel.Text = "label1";
			// 
			// CurrentJobOffersView
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(mainLayout);
			Name = "CurrentJobOffersView";
			Size = new Size(1205, 582);
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
		private Button addBtn;
		private Button editBtn;
	}
}
