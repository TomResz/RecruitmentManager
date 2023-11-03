namespace RecruitmentManager.Forms.Candidate
{
	partial class CandidateNotLoginForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CandidateNotLoginForm));
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
			registerBtn = new Button();
			loginBtn = new Button();
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
			jobOffersDGV.Size = new Size(1373, 463);
			jobOffersDGV.TabIndex = 0;
			jobOffersDGV.SizeChanged += jobOffersDGV_SizeChanged;
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
			mainLayout.Size = new Size(1379, 544);
			mainLayout.TabIndex = 1;
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
			footerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
			footerLayout.Controls.Add(pageCounterLabel, 6, 0);
			footerLayout.Controls.Add(nextPageButton, 5, 0);
			footerLayout.Controls.Add(previousPageButton, 4, 0);
			footerLayout.Controls.Add(registerBtn, 3, 0);
			footerLayout.Controls.Add(loginBtn, 2, 0);
			footerLayout.Dock = DockStyle.Fill;
			footerLayout.Location = new Point(3, 472);
			footerLayout.Name = "footerLayout";
			footerLayout.RowCount = 1;
			footerLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			footerLayout.Size = new Size(1373, 69);
			footerLayout.TabIndex = 1;
			// 
			// pageCounterLabel
			// 
			pageCounterLabel.Anchor = AnchorStyles.None;
			pageCounterLabel.AutoSize = true;
			pageCounterLabel.Location = new Point(1326, 14);
			pageCounterLabel.Name = "pageCounterLabel";
			pageCounterLabel.Size = new Size(42, 40);
			pageCounterLabel.TabIndex = 4;
			pageCounterLabel.Text = "label1";
			// 
			// nextPageButton
			// 
			nextPageButton.Image = (Image)resources.GetObject("nextPageButton.Image");
			nextPageButton.Location = new Point(1259, 3);
			nextPageButton.Name = "nextPageButton";
			nextPageButton.Size = new Size(59, 63);
			nextPageButton.TabIndex = 3;
			nextPageButton.TabStop = false;
			nextPageButton.Click += nextPagePB_Click;
			// 
			// previousPageButton
			// 
			previousPageButton.Image = (Image)resources.GetObject("previousPageButton.Image");
			previousPageButton.Location = new Point(1194, 3);
			previousPageButton.Name = "previousPageButton";
			previousPageButton.Size = new Size(59, 63);
			previousPageButton.TabIndex = 2;
			previousPageButton.TabStop = false;
			previousPageButton.Click += previousPagePB_Click;
			// 
			// registerBtn
			// 
			registerBtn.Dock = DockStyle.Fill;
			registerBtn.FlatStyle = FlatStyle.Flat;
			registerBtn.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
			registerBtn.Location = new Point(980, 3);
			registerBtn.Name = "registerBtn";
			registerBtn.Size = new Size(208, 63);
			registerBtn.TabIndex = 5;
			registerBtn.Text = "Zarejestruj się";
			registerBtn.UseVisualStyleBackColor = true;
			registerBtn.Click += registerBtn_Click;
			// 
			// loginBtn
			// 
			loginBtn.Dock = DockStyle.Fill;
			loginBtn.FlatStyle = FlatStyle.Flat;
			loginBtn.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
			loginBtn.Location = new Point(766, 3);
			loginBtn.Name = "loginBtn";
			loginBtn.Size = new Size(208, 63);
			loginBtn.TabIndex = 6;
			loginBtn.Text = "Zaloguj się";
			loginBtn.UseVisualStyleBackColor = true;
			loginBtn.Click += loginBtn_Click;
			// 
			// CandidateNotLoginForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1379, 544);
			Controls.Add(mainLayout);
			Name = "CandidateNotLoginForm";
			Text = "Ogłoszenia Pracy";
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
		private TableLayoutPanel mainLayout;
		private TableLayoutPanel footerLayout;
		private Label pageCounterLabel;
		private PictureBox nextPageButton;
		private PictureBox previousPageButton;
		private Button registerBtn;
		private Button loginBtn;
		private DataGridViewTextBoxColumn Id;
		private DataGridViewTextBoxColumn Position;
		private DataGridViewTextBoxColumn AddedDate;
		private DataGridViewTextBoxColumn EndedDate;
		private DataGridViewButtonColumn PasswdReset;
	}
}