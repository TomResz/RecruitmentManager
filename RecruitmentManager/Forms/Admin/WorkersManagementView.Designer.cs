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
			DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkersManagementView));
			mainLayout = new TableLayoutPanel();
			workersDGV = new DataGridView();
			Id = new DataGridViewTextBoxColumn();
			Mail = new DataGridViewTextBoxColumn();
			Data = new DataGridViewTextBoxColumn();
			Role = new DataGridViewTextBoxColumn();
			PasswdReset = new DataGridViewButtonColumn();
			footerLayout = new TableLayoutPanel();
			pageCounterLabel = new Label();
			nextPageButton = new PictureBox();
			previousPageButton = new PictureBox();
			deleteBtn = new Button();
			addBtn = new Button();
			mainLayout.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)workersDGV).BeginInit();
			footerLayout.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)nextPageButton).BeginInit();
			((System.ComponentModel.ISupportInitialize)previousPageButton).BeginInit();
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
			dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = Color.Blue;
			dataGridViewCellStyle1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
			dataGridViewCellStyle1.ForeColor = Color.White;
			dataGridViewCellStyle1.SelectionBackColor = Color.Blue;
			dataGridViewCellStyle1.SelectionForeColor = Color.White;
			dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
			workersDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
			dataGridViewCellStyle2.BackColor = Color.FromArgb(128, 255, 255);
			dataGridViewCellStyle2.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			dataGridViewCellStyle2.ForeColor = Color.Black;
			dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 192, 192);
			dataGridViewCellStyle2.SelectionForeColor = Color.Black;
			Mail.DefaultCellStyle = dataGridViewCellStyle2;
			Mail.HeaderText = "E-Mail";
			Mail.MinimumWidth = 6;
			Mail.Name = "Mail";
			Mail.ReadOnly = true;
			// 
			// Data
			// 
			dataGridViewCellStyle3.BackColor = Color.FromArgb(128, 255, 255);
			dataGridViewCellStyle3.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			dataGridViewCellStyle3.ForeColor = Color.Black;
			dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 192, 192);
			dataGridViewCellStyle3.SelectionForeColor = Color.Black;
			Data.DefaultCellStyle = dataGridViewCellStyle3;
			Data.HeaderText = "Imię i nazwisko";
			Data.MinimumWidth = 6;
			Data.Name = "Data";
			Data.ReadOnly = true;
			// 
			// Role
			// 
			dataGridViewCellStyle4.BackColor = Color.FromArgb(128, 255, 255);
			dataGridViewCellStyle4.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			dataGridViewCellStyle4.ForeColor = Color.Black;
			dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(0, 192, 192);
			dataGridViewCellStyle4.SelectionForeColor = Color.Black;
			Role.DefaultCellStyle = dataGridViewCellStyle4;
			Role.HeaderText = "Rola";
			Role.MinimumWidth = 6;
			Role.Name = "Role";
			Role.ReadOnly = true;
			// 
			// PasswdReset
			// 
			dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle5.BackColor = Color.Navy;
			dataGridViewCellStyle5.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			dataGridViewCellStyle5.ForeColor = Color.White;
			dataGridViewCellStyle5.SelectionBackColor = Color.Navy;
			dataGridViewCellStyle5.SelectionForeColor = Color.White;
			PasswdReset.DefaultCellStyle = dataGridViewCellStyle5;
			PasswdReset.FlatStyle = FlatStyle.Popup;
			PasswdReset.HeaderText = "Reset Hasła";
			PasswdReset.MinimumWidth = 6;
			PasswdReset.Name = "PasswdReset";
			PasswdReset.Text = "Resetuj Hasło";
			PasswdReset.UseColumnTextForButtonValue = true;
			// 
			// footerLayout
			// 
			footerLayout.ColumnCount = 7;
			footerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			footerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26F));
			footerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12F));
			footerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12F));
			footerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 65F));
			footerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 65F));
			footerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
			footerLayout.Controls.Add(pageCounterLabel, 6, 0);
			footerLayout.Controls.Add(nextPageButton, 5, 0);
			footerLayout.Controls.Add(previousPageButton, 4, 0);
			footerLayout.Controls.Add(deleteBtn, 3, 0);
			footerLayout.Controls.Add(addBtn, 2, 0);
			footerLayout.Dock = DockStyle.Fill;
			footerLayout.Location = new Point(3, 558);
			footerLayout.Name = "footerLayout";
			footerLayout.RowCount = 1;
			footerLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			footerLayout.Size = new Size(1322, 69);
			footerLayout.TabIndex = 1;
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
			// nextPageButton
			// 
			nextPageButton.Image = (Image)resources.GetObject("nextPageButton.Image");
			nextPageButton.Location = new Point(1209, 3);
			nextPageButton.Name = "nextPageButton";
			nextPageButton.Size = new Size(59, 63);
			nextPageButton.TabIndex = 3;
			nextPageButton.TabStop = false;
			nextPageButton.Click += nextPageButton_Click;
			// 
			// previousPageButton
			// 
			previousPageButton.Image = (Image)resources.GetObject("previousPageButton.Image");
			previousPageButton.Location = new Point(1144, 3);
			previousPageButton.Name = "previousPageButton";
			previousPageButton.Size = new Size(59, 63);
			previousPageButton.TabIndex = 2;
			previousPageButton.TabStop = false;
			previousPageButton.Click += previousPageButton_ClickAsync;
			// 
			// deleteBtn
			// 
			deleteBtn.Dock = DockStyle.Fill;
			deleteBtn.FlatStyle = FlatStyle.Flat;
			deleteBtn.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			deleteBtn.Location = new Point(1007, 3);
			deleteBtn.Name = "deleteBtn";
			deleteBtn.Size = new Size(131, 63);
			deleteBtn.TabIndex = 5;
			deleteBtn.Text = "Usuń";
			deleteBtn.UseVisualStyleBackColor = true;
			deleteBtn.Click += deleteBtn_Click;
			// 
			// addBtn
			// 
			addBtn.Dock = DockStyle.Fill;
			addBtn.FlatStyle = FlatStyle.Flat;
			addBtn.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			addBtn.Location = new Point(870, 3);
			addBtn.Name = "addBtn";
			addBtn.Size = new Size(131, 63);
			addBtn.TabIndex = 6;
			addBtn.Text = "Dodaj";
			addBtn.UseVisualStyleBackColor = true;
			addBtn.Click += addEmployeeBtn_Click;
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
			((System.ComponentModel.ISupportInitialize)nextPageButton).EndInit();
			((System.ComponentModel.ISupportInitialize)previousPageButton).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private TableLayoutPanel mainLayout;
		private DataGridView workersDGV;
		private TableLayoutPanel footerLayout;
		private PictureBox previousPageButton;
		private Label pageCounterLabel;
		private DataGridViewTextBoxColumn Id;
		private DataGridViewTextBoxColumn Mail;
		private DataGridViewTextBoxColumn Data;
		private DataGridViewTextBoxColumn Role;
		private DataGridViewButtonColumn PasswdReset;
		private PictureBox nextPageButton;
		private Button deleteBtn;
		private Button addBtn;
	}
}
