namespace RecruitmentManager.Forms
{
	partial class AdminForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
			mainLayout = new TableLayoutPanel();
			tableLayoutPanel1 = new TableLayoutPanel();
			logoutBtn = new Button();
			userLabel = new Label();
			tabControlLayout = new TableLayoutPanel();
			usersBtn = new Button();
			candidatesBtn = new Button();
			mainLayout.SuspendLayout();
			tableLayoutPanel1.SuspendLayout();
			tabControlLayout.SuspendLayout();
			SuspendLayout();
			// 
			// mainLayout
			// 
			mainLayout.ColumnCount = 2;
			mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
			mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
			mainLayout.Controls.Add(tableLayoutPanel1, 0, 0);
			mainLayout.Dock = DockStyle.Fill;
			mainLayout.Location = new Point(0, 0);
			mainLayout.Name = "mainLayout";
			mainLayout.RowCount = 1;
			mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			mainLayout.Size = new Size(1358, 627);
			mainLayout.TabIndex = 0;
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.OutsetPartial;
			tableLayoutPanel1.ColumnCount = 1;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			tableLayoutPanel1.Controls.Add(logoutBtn, 0, 2);
			tableLayoutPanel1.Controls.Add(userLabel, 0, 0);
			tableLayoutPanel1.Controls.Add(tabControlLayout, 0, 1);
			tableLayoutPanel1.Dock = DockStyle.Fill;
			tableLayoutPanel1.Location = new Point(0, 0);
			tableLayoutPanel1.Margin = new Padding(0);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 3;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
			tableLayoutPanel1.Size = new Size(271, 627);
			tableLayoutPanel1.TabIndex = 0;
			// 
			// logoutBtn
			// 
			logoutBtn.Dock = DockStyle.Fill;
			logoutBtn.FlatStyle = FlatStyle.Flat;
			logoutBtn.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
			logoutBtn.Location = new Point(6, 534);
			logoutBtn.Name = "logoutBtn";
			logoutBtn.Size = new Size(259, 87);
			logoutBtn.TabIndex = 0;
			logoutBtn.Text = "Wyloguj Się";
			logoutBtn.UseVisualStyleBackColor = true;
			logoutBtn.Click += logoutBtn_Click;
			// 
			// userLabel
			// 
			userLabel.AutoSize = true;
			userLabel.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
			userLabel.Location = new Point(6, 3);
			userLabel.Name = "userLabel";
			userLabel.Size = new Size(174, 32);
			userLabel.TabIndex = 1;
			userLabel.Text = "Zalogowano :";
			// 
			// tabControlLayout
			// 
			tabControlLayout.ColumnCount = 1;
			tabControlLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			tabControlLayout.Controls.Add(usersBtn, 0, 0);
			tabControlLayout.Controls.Add(candidatesBtn, 0, 1);
			tabControlLayout.Dock = DockStyle.Fill;
			tabControlLayout.Location = new Point(3, 98);
			tabControlLayout.Margin = new Padding(0);
			tabControlLayout.Name = "tabControlLayout";
			tabControlLayout.RowCount = 5;
			tabControlLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
			tabControlLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
			tabControlLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
			tabControlLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
			tabControlLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
			tabControlLayout.Size = new Size(265, 430);
			tabControlLayout.TabIndex = 2;
			// 
			// usersBtn
			// 
			usersBtn.BackColor = SystemColors.ButtonFace;
			usersBtn.Dock = DockStyle.Fill;
			usersBtn.FlatStyle = FlatStyle.Flat;
			usersBtn.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
			usersBtn.Image = (Image)resources.GetObject("usersBtn.Image");
			usersBtn.ImageAlign = ContentAlignment.MiddleLeft;
			usersBtn.Location = new Point(3, 3);
			usersBtn.Name = "usersBtn";
			usersBtn.Size = new Size(259, 80);
			usersBtn.TabIndex = 0;
			usersBtn.Text = "Pracownicy";
			usersBtn.TextAlign = ContentAlignment.MiddleRight;
			usersBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
			usersBtn.UseVisualStyleBackColor = false;
			usersBtn.Click += usersBtn_Click;
			// 
			// candidatesBtn
			// 
			candidatesBtn.BackColor = SystemColors.ButtonFace;
			candidatesBtn.Dock = DockStyle.Fill;
			candidatesBtn.FlatStyle = FlatStyle.Flat;
			candidatesBtn.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
			candidatesBtn.Image = (Image)resources.GetObject("candidatesBtn.Image");
			candidatesBtn.ImageAlign = ContentAlignment.MiddleLeft;
			candidatesBtn.Location = new Point(3, 89);
			candidatesBtn.Name = "candidatesBtn";
			candidatesBtn.Size = new Size(259, 80);
			candidatesBtn.TabIndex = 1;
			candidatesBtn.Text = "Kandydaci";
			candidatesBtn.TextAlign = ContentAlignment.MiddleRight;
			candidatesBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
			candidatesBtn.UseVisualStyleBackColor = false;
			candidatesBtn.Click += candidatesBtn_Click;
			// 
			// AdminForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1358, 627);
			Controls.Add(mainLayout);
			Name = "AdminForm";
			Text = "Formularz Administratora";
			mainLayout.ResumeLayout(false);
			tableLayoutPanel1.ResumeLayout(false);
			tableLayoutPanel1.PerformLayout();
			tabControlLayout.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private TableLayoutPanel mainLayout;
		private TableLayoutPanel tableLayoutPanel1;
		private Button logoutBtn;
		private Label userLabel;
		private TableLayoutPanel tabControlLayout;
		private Button usersBtn;
		private Button candidatesBtn;
	}
}