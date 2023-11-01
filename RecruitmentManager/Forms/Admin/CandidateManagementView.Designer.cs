namespace RecruitmentManager.Forms.Admin
{
	partial class CandidateManagementView
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CandidateManagementView));
			candidateDGV = new DataGridView();
			Id = new DataGridViewTextBoxColumn();
			Mail = new DataGridViewTextBoxColumn();
			Data = new DataGridViewTextBoxColumn();
			PasswdReset = new DataGridViewButtonColumn();
			mainLayout = new TableLayoutPanel();
			footerLayout = new TableLayoutPanel();
			deleteBtn = new Button();
			previousPageButton = new PictureBox();
			nextPageButton = new PictureBox();
			pageCounterLabel = new Label();
			addBtn = new Button();
			((System.ComponentModel.ISupportInitialize)candidateDGV).BeginInit();
			mainLayout.SuspendLayout();
			footerLayout.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)previousPageButton).BeginInit();
			((System.ComponentModel.ISupportInitialize)nextPageButton).BeginInit();
			SuspendLayout();
			// 
			// candidateDGV
			// 
			candidateDGV.AllowUserToAddRows = false;
			candidateDGV.AllowUserToDeleteRows = false;
			candidateDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			candidateDGV.BackgroundColor = SystemColors.Control;
			candidateDGV.BorderStyle = BorderStyle.None;
			dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle9.BackColor = Color.Blue;
			dataGridViewCellStyle9.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
			dataGridViewCellStyle9.ForeColor = Color.White;
			dataGridViewCellStyle9.SelectionBackColor = Color.Blue;
			dataGridViewCellStyle9.SelectionForeColor = Color.White;
			dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
			candidateDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
			candidateDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			candidateDGV.Columns.AddRange(new DataGridViewColumn[] { Id, Mail, Data, PasswdReset });
			candidateDGV.Dock = DockStyle.Fill;
			candidateDGV.EnableHeadersVisualStyles = false;
			candidateDGV.Location = new Point(3, 3);
			candidateDGV.Name = "candidateDGV";
			candidateDGV.RowHeadersVisible = false;
			candidateDGV.RowHeadersWidth = 51;
			candidateDGV.RowTemplate.Height = 29;
			candidateDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			candidateDGV.Size = new Size(1252, 573);
			candidateDGV.TabIndex = 0;
			candidateDGV.CellContentClick += candidateDGV_CellContentClick;
			// 
			// Id
			// 
			Id.HeaderText = "ID";
			Id.MinimumWidth = 6;
			Id.Name = "Id";
			Id.ReadOnly = true;
			Id.Visible = false;
			// 
			// Mail
			// 
			dataGridViewCellStyle10.BackColor = Color.FromArgb(128, 255, 255);
			dataGridViewCellStyle10.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			dataGridViewCellStyle10.ForeColor = Color.Black;
			dataGridViewCellStyle10.SelectionBackColor = Color.FromArgb(0, 192, 192);
			dataGridViewCellStyle10.SelectionForeColor = Color.Black;
			Mail.DefaultCellStyle = dataGridViewCellStyle10;
			Mail.HeaderText = "E-Mail";
			Mail.MinimumWidth = 6;
			Mail.Name = "Mail";
			Mail.ReadOnly = true;
			// 
			// Data
			// 
			dataGridViewCellStyle11.BackColor = Color.FromArgb(128, 255, 255);
			dataGridViewCellStyle11.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			dataGridViewCellStyle11.ForeColor = Color.Black;
			dataGridViewCellStyle11.SelectionBackColor = Color.FromArgb(0, 192, 192);
			dataGridViewCellStyle11.SelectionForeColor = Color.Black;
			Data.DefaultCellStyle = dataGridViewCellStyle11;
			Data.HeaderText = "Imię i nazwisko";
			Data.MinimumWidth = 6;
			Data.Name = "Data";
			Data.ReadOnly = true;
			// 
			// PasswdReset
			// 
			dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle12.BackColor = Color.Navy;
			dataGridViewCellStyle12.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			dataGridViewCellStyle12.ForeColor = Color.White;
			dataGridViewCellStyle12.SelectionBackColor = Color.Navy;
			dataGridViewCellStyle12.SelectionForeColor = Color.White;
			PasswdReset.DefaultCellStyle = dataGridViewCellStyle12;
			PasswdReset.FlatStyle = FlatStyle.Flat;
			PasswdReset.HeaderText = "Reset Hasła";
			PasswdReset.MinimumWidth = 6;
			PasswdReset.Name = "PasswdReset";
			PasswdReset.Text = "Resetuj Hasło";
			PasswdReset.UseColumnTextForButtonValue = true;
			// 
			// mainLayout
			// 
			mainLayout.ColumnCount = 1;
			mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			mainLayout.Controls.Add(candidateDGV, 0, 0);
			mainLayout.Controls.Add(footerLayout, 0, 1);
			mainLayout.Dock = DockStyle.Fill;
			mainLayout.Location = new Point(0, 0);
			mainLayout.Name = "mainLayout";
			mainLayout.RowCount = 2;
			mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
			mainLayout.Size = new Size(1258, 654);
			mainLayout.TabIndex = 1;
			// 
			// footerLayout
			// 
			footerLayout.ColumnCount = 6;
			footerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 76F));
			footerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12F));
			footerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12F));
			footerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 65F));
			footerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 65F));
			footerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
			footerLayout.Controls.Add(deleteBtn, 2, 0);
			footerLayout.Controls.Add(previousPageButton, 3, 0);
			footerLayout.Controls.Add(nextPageButton, 4, 0);
			footerLayout.Controls.Add(pageCounterLabel, 5, 0);
			footerLayout.Controls.Add(addBtn, 1, 0);
			footerLayout.Dock = DockStyle.Fill;
			footerLayout.Location = new Point(3, 582);
			footerLayout.Name = "footerLayout";
			footerLayout.RowCount = 1;
			footerLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			footerLayout.Size = new Size(1252, 69);
			footerLayout.TabIndex = 1;
			// 
			// deleteBtn
			// 
			deleteBtn.Dock = DockStyle.Fill;
			deleteBtn.FlatStyle = FlatStyle.Flat;
			deleteBtn.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			deleteBtn.Location = new Point(945, 3);
			deleteBtn.Name = "deleteBtn";
			deleteBtn.Size = new Size(122, 63);
			deleteBtn.TabIndex = 1;
			deleteBtn.Text = "Usuń";
			deleteBtn.UseVisualStyleBackColor = true;
			deleteBtn.Click += deleteBtn_Click;
			// 
			// previousPageButton
			// 
			previousPageButton.Dock = DockStyle.Fill;
			previousPageButton.Image = (Image)resources.GetObject("previousPageButton.Image");
			previousPageButton.Location = new Point(1073, 3);
			previousPageButton.Name = "previousPageButton";
			previousPageButton.Size = new Size(59, 63);
			previousPageButton.TabIndex = 2;
			previousPageButton.TabStop = false;
			previousPageButton.Click += previousPageButton_Click;
			// 
			// nextPageButton
			// 
			nextPageButton.Dock = DockStyle.Fill;
			nextPageButton.Image = (Image)resources.GetObject("nextPageButton.Image");
			nextPageButton.Location = new Point(1138, 3);
			nextPageButton.Name = "nextPageButton";
			nextPageButton.Size = new Size(59, 63);
			nextPageButton.TabIndex = 3;
			nextPageButton.TabStop = false;
			nextPageButton.Click += nextPageButton_Click;
			// 
			// pageCounterLabel
			// 
			pageCounterLabel.Anchor = AnchorStyles.None;
			pageCounterLabel.AutoSize = true;
			pageCounterLabel.Location = new Point(1205, 14);
			pageCounterLabel.Name = "pageCounterLabel";
			pageCounterLabel.Size = new Size(42, 40);
			pageCounterLabel.TabIndex = 4;
			pageCounterLabel.Text = "label1";
			// 
			// addBtn
			// 
			addBtn.Dock = DockStyle.Fill;
			addBtn.FlatStyle = FlatStyle.Flat;
			addBtn.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			addBtn.Location = new Point(817, 3);
			addBtn.Name = "addBtn";
			addBtn.Size = new Size(122, 63);
			addBtn.TabIndex = 5;
			addBtn.Text = "Dodaj";
			addBtn.UseVisualStyleBackColor = true;
			addBtn.Click += addBtn_Click;
			// 
			// CandidateManagementView
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(mainLayout);
			Name = "CandidateManagementView";
			Size = new Size(1258, 654);
			((System.ComponentModel.ISupportInitialize)candidateDGV).EndInit();
			mainLayout.ResumeLayout(false);
			footerLayout.ResumeLayout(false);
			footerLayout.PerformLayout();
			((System.ComponentModel.ISupportInitialize)previousPageButton).EndInit();
			((System.ComponentModel.ISupportInitialize)nextPageButton).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private DataGridView candidateDGV;
		private TableLayoutPanel mainLayout;
		private TableLayoutPanel footerLayout;
		private Button deleteBtn;
		private PictureBox previousPageButton;
		private PictureBox nextPageButton;
		private Label pageCounterLabel;
		private DataGridViewTextBoxColumn Id;
		private DataGridViewTextBoxColumn Mail;
		private DataGridViewTextBoxColumn Data;
		private DataGridViewButtonColumn PasswdReset;
		private Button addBtn;
	}
}
