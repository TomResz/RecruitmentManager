namespace RecruitmentManager.Forms.Admin
{
	partial class WorkersManagementView
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkersManagementView));
			mainLayout = new TableLayoutPanel();
			workersDGV = new DataGridView();
			Id = new DataGridViewTextBoxColumn();
			Mail = new DataGridViewTextBoxColumn();
			Data = new DataGridViewTextBoxColumn();
			Role = new DataGridViewTextBoxColumn();
			PasswdReset = new DataGridViewButtonColumn();
			footerLayout = new TableLayoutPanel();
			addEmployeeBtn = new Button();
			deleteBtn = new Button();
			previousPageButton = new PictureBox();
			nextPageButton = new PictureBox();
			pageCounterLabel = new Label();
			mainLayout.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)workersDGV).BeginInit();
			footerLayout.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)previousPageButton).BeginInit();
			((System.ComponentModel.ISupportInitialize)nextPageButton).BeginInit();
			SuspendLayout();
			// 
			// mainLayout
			// 
			mainLayout.ColumnCount = 1;
			mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			mainLayout.Controls.Add(workersDGV, 0, 0);
			mainLayout.Controls.Add(footerLayout, 0, 1);
			mainLayout.Dock = DockStyle.Fill;
			mainLayout.Location = new Point(0, 0);
			mainLayout.Name = "mainLayout";
			mainLayout.RowCount = 2;
			mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
			mainLayout.Size = new Size(1328, 630);
			mainLayout.TabIndex = 0;
			// 
			// workersDGV
			// 
			workersDGV.AllowUserToAddRows = false;
			workersDGV.AllowUserToDeleteRows = false;
			workersDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			workersDGV.BackgroundColor = SystemColors.Control;
			workersDGV.BorderStyle = BorderStyle.None;
			dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = Color.Blue;
			dataGridViewCellStyle6.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
			dataGridViewCellStyle6.ForeColor = Color.White;
			dataGridViewCellStyle6.SelectionBackColor = Color.Blue;
			dataGridViewCellStyle6.SelectionForeColor = Color.White;
			dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
			workersDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
			workersDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			workersDGV.Columns.AddRange(new DataGridViewColumn[] { Id, Mail, Data, Role, PasswdReset });
			workersDGV.Dock = DockStyle.Fill;
			workersDGV.EnableHeadersVisualStyles = false;
			workersDGV.Location = new Point(3, 3);
			workersDGV.MultiSelect = false;
			workersDGV.Name = "workersDGV";
			workersDGV.RowHeadersVisible = false;
			workersDGV.RowHeadersWidth = 51;
			workersDGV.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			workersDGV.RowTemplate.Height = 29;
			workersDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			workersDGV.Size = new Size(1322, 549);
			workersDGV.TabIndex = 0;
			workersDGV.CellContentClick += workersDGV_CellContentClick;
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
			dataGridViewCellStyle7.BackColor = Color.FromArgb(128, 255, 255);
			dataGridViewCellStyle7.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			dataGridViewCellStyle7.ForeColor = Color.Black;
			dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(0, 192, 192);
			dataGridViewCellStyle7.SelectionForeColor = Color.Black;
			Mail.DefaultCellStyle = dataGridViewCellStyle7;
			Mail.HeaderText = "E-Mail";
			Mail.MinimumWidth = 6;
			Mail.Name = "Mail";
			Mail.ReadOnly = true;
			// 
			// Data
			// 
			dataGridViewCellStyle8.BackColor = Color.FromArgb(128, 255, 255);
			dataGridViewCellStyle8.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			dataGridViewCellStyle8.ForeColor = Color.Black;
			dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(0, 192, 192);
			dataGridViewCellStyle8.SelectionForeColor = Color.Black;
			Data.DefaultCellStyle = dataGridViewCellStyle8;
			Data.HeaderText = "Imię i nazwisko";
			Data.MinimumWidth = 6;
			Data.Name = "Data";
			Data.ReadOnly = true;
			// 
			// Role
			// 
			dataGridViewCellStyle9.BackColor = Color.FromArgb(128, 255, 255);
			dataGridViewCellStyle9.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			dataGridViewCellStyle9.ForeColor = Color.Black;
			dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(0, 192, 192);
			dataGridViewCellStyle9.SelectionForeColor = Color.Black;
			Role.DefaultCellStyle = dataGridViewCellStyle9;
			Role.HeaderText = "Rola";
			Role.MinimumWidth = 6;
			Role.Name = "Role";
			Role.ReadOnly = true;
			// 
			// PasswdReset
			// 
			dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle10.BackColor = Color.Navy;
			dataGridViewCellStyle10.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			dataGridViewCellStyle10.ForeColor = Color.White;
			dataGridViewCellStyle10.SelectionBackColor = Color.Navy;
			dataGridViewCellStyle10.SelectionForeColor = Color.White;
			PasswdReset.DefaultCellStyle = dataGridViewCellStyle10;
			PasswdReset.FlatStyle = FlatStyle.Popup;
			PasswdReset.HeaderText = "Reset Hasła";
			PasswdReset.MinimumWidth = 6;
			PasswdReset.Name = "PasswdReset";
			PasswdReset.Text = "Resetuj Hasło";
			PasswdReset.UseColumnTextForButtonValue = true;
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
			footerLayout.Controls.Add(addEmployeeBtn, 1, 0);
			footerLayout.Controls.Add(deleteBtn, 2, 0);
			footerLayout.Controls.Add(previousPageButton, 3, 0);
			footerLayout.Controls.Add(nextPageButton, 4, 0);
			footerLayout.Controls.Add(pageCounterLabel, 5, 0);
			footerLayout.Dock = DockStyle.Fill;
			footerLayout.Location = new Point(3, 558);
			footerLayout.Name = "footerLayout";
			footerLayout.RowCount = 1;
			footerLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			footerLayout.Size = new Size(1322, 69);
			footerLayout.TabIndex = 1;
			// 
			// addEmployeeBtn
			// 
			addEmployeeBtn.BackColor = SystemColors.Control;
			addEmployeeBtn.Dock = DockStyle.Fill;
			addEmployeeBtn.FlatStyle = FlatStyle.Flat;
			addEmployeeBtn.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			addEmployeeBtn.ForeColor = Color.Black;
			addEmployeeBtn.Location = new Point(870, 3);
			addEmployeeBtn.Name = "addEmployeeBtn";
			addEmployeeBtn.Size = new Size(131, 63);
			addEmployeeBtn.TabIndex = 0;
			addEmployeeBtn.Text = "Dodaj";
			addEmployeeBtn.UseVisualStyleBackColor = false;
			addEmployeeBtn.Click += addEmployeeBtn_Click;
			// 
			// deleteBtn
			// 
			deleteBtn.BackColor = SystemColors.Control;
			deleteBtn.Dock = DockStyle.Fill;
			deleteBtn.FlatStyle = FlatStyle.Flat;
			deleteBtn.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			deleteBtn.ForeColor = Color.Black;
			deleteBtn.Location = new Point(1007, 3);
			deleteBtn.Name = "deleteBtn";
			deleteBtn.Size = new Size(131, 63);
			deleteBtn.TabIndex = 1;
			deleteBtn.Text = "Usuń";
			deleteBtn.UseVisualStyleBackColor = false;
			deleteBtn.Click += deleteBtn_Click;
			// 
			// previousPageButton
			// 
			previousPageButton.Dock = DockStyle.Fill;
			previousPageButton.Image = (Image)resources.GetObject("previousPageButton.Image");
			previousPageButton.Location = new Point(1144, 3);
			previousPageButton.Name = "previousPageButton";
			previousPageButton.Size = new Size(59, 63);
			previousPageButton.TabIndex = 2;
			previousPageButton.TabStop = false;
			previousPageButton.Click += previousPageButton_ClickAsync;
			// 
			// nextPageButton
			// 
			nextPageButton.Dock = DockStyle.Fill;
			nextPageButton.Image = (Image)resources.GetObject("nextPageButton.Image");
			nextPageButton.Location = new Point(1209, 3);
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
			pageCounterLabel.Location = new Point(1275, 14);
			pageCounterLabel.Name = "pageCounterLabel";
			pageCounterLabel.Size = new Size(42, 40);
			pageCounterLabel.TabIndex = 4;
			pageCounterLabel.Text = "label1";
			// 
			// WorkersManagementView
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(mainLayout);
			Name = "WorkersManagementView";
			Size = new Size(1328, 630);
			mainLayout.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)workersDGV).EndInit();
			footerLayout.ResumeLayout(false);
			footerLayout.PerformLayout();
			((System.ComponentModel.ISupportInitialize)previousPageButton).EndInit();
			((System.ComponentModel.ISupportInitialize)nextPageButton).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private TableLayoutPanel mainLayout;
		private DataGridView workersDGV;
		private TableLayoutPanel footerLayout;
		private Button addEmployeeBtn;
		private Button deleteBtn;
		private PictureBox previousPageButton;
		private PictureBox nextPageButton;
		private Label pageCounterLabel;
		private DataGridViewTextBoxColumn Id;
		private DataGridViewTextBoxColumn Mail;
		private DataGridViewTextBoxColumn Data;
		private DataGridViewTextBoxColumn Role;
		private DataGridViewButtonColumn PasswdReset;
	}
}
