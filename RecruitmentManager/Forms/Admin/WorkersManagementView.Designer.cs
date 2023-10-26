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
			mainLayout = new TableLayoutPanel();
			workersDGV = new DataGridView();
			Id = new DataGridViewTextBoxColumn();
			Mail = new DataGridViewTextBoxColumn();
			Data = new DataGridViewTextBoxColumn();
			Role = new DataGridViewTextBoxColumn();
			PasswdReset = new DataGridViewButtonColumn();
			footerLayout = new TableLayoutPanel();
			add = new Button();
			deleteBtn = new Button();
			mainLayout.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)workersDGV).BeginInit();
			footerLayout.SuspendLayout();
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
			workersDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			workersDGV.Columns.AddRange(new DataGridViewColumn[] { Id, Mail, Data, Role, PasswdReset });
			workersDGV.Dock = DockStyle.Fill;
			workersDGV.Location = new Point(3, 3);
			workersDGV.Name = "workersDGV";
			workersDGV.RowHeadersWidth = 51;
			workersDGV.RowTemplate.Height = 29;
			workersDGV.Size = new Size(1322, 549);
			workersDGV.TabIndex = 0;
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
			Mail.HeaderText = "E-Mail";
			Mail.MinimumWidth = 6;
			Mail.Name = "Mail";
			Mail.ReadOnly = true;
			// 
			// Data
			// 
			Data.HeaderText = "Imię i nazwisko";
			Data.MinimumWidth = 6;
			Data.Name = "Data";
			Data.ReadOnly = true;
			// 
			// Role
			// 
			Role.HeaderText = "Rola";
			Role.MinimumWidth = 6;
			Role.Name = "Role";
			Role.ReadOnly = true;
			// 
			// PasswdReset
			// 
			PasswdReset.FlatStyle = FlatStyle.Flat;
			PasswdReset.HeaderText = "Reset Hasła";
			PasswdReset.MinimumWidth = 6;
			PasswdReset.Name = "PasswdReset";
			PasswdReset.Text = "Resetuj Hasło";
			PasswdReset.UseColumnTextForButtonValue = true;
			// 
			// footerLayout
			// 
			footerLayout.ColumnCount = 4;
			footerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 76.92308F));
			footerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 75F));
			footerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.5384617F));
			footerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.5384617F));
			footerLayout.Controls.Add(add, 2, 0);
			footerLayout.Controls.Add(deleteBtn, 3, 0);
			footerLayout.Dock = DockStyle.Fill;
			footerLayout.Location = new Point(3, 558);
			footerLayout.Name = "footerLayout";
			footerLayout.RowCount = 1;
			footerLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			footerLayout.Size = new Size(1322, 69);
			footerLayout.TabIndex = 1;
			// 
			// add
			// 
			add.Dock = DockStyle.Fill;
			add.FlatStyle = FlatStyle.Flat;
			add.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			add.Location = new Point(1037, 3);
			add.Name = "add";
			add.Size = new Size(137, 63);
			add.TabIndex = 0;
			add.Text = "Dodaj";
			add.UseVisualStyleBackColor = true;
			add.Click += add_Click;
			// 
			// deleteBtn
			// 
			deleteBtn.Dock = DockStyle.Fill;
			deleteBtn.FlatStyle = FlatStyle.Flat;
			deleteBtn.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			deleteBtn.Location = new Point(1180, 3);
			deleteBtn.Name = "deleteBtn";
			deleteBtn.Size = new Size(139, 63);
			deleteBtn.TabIndex = 1;
			deleteBtn.Text = "Usuń";
			deleteBtn.UseVisualStyleBackColor = true;
			deleteBtn.Click += deleteBtn_Click;
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
			ResumeLayout(false);
		}

		#endregion

		private TableLayoutPanel mainLayout;
		private DataGridView workersDGV;
		private DataGridViewTextBoxColumn Id;
		private DataGridViewTextBoxColumn Mail;
		private DataGridViewTextBoxColumn Data;
		private DataGridViewTextBoxColumn Role;
		private DataGridViewButtonColumn PasswdReset;
		private TableLayoutPanel footerLayout;
		private Button add;
		private Button deleteBtn;
	}
}
