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
			mainLayout.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)workersDGV).BeginInit();
			SuspendLayout();
			// 
			// mainLayout
			// 
			mainLayout.ColumnCount = 1;
			mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			mainLayout.Controls.Add(workersDGV, 0, 0);
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
			// WorkersManagementView
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(mainLayout);
			Name = "WorkersManagementView";
			Size = new Size(1328, 630);
			mainLayout.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)workersDGV).EndInit();
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
	}
}
