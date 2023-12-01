namespace RecruitmentManager.Forms.Manager.Registrations
{
	partial class ManagerMainRegistrationView
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerMainRegistrationView));
			mainLayout = new TableLayoutPanel();
			headerLayout = new TableLayoutPanel();
			endedBtn = new Button();
			currentBtn = new Button();
			mainLayout.SuspendLayout();
			headerLayout.SuspendLayout();
			SuspendLayout();
			// 
			// mainLayout
			// 
			mainLayout.ColumnCount = 1;
			mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			mainLayout.Controls.Add(headerLayout, 0, 0);
			mainLayout.Dock = DockStyle.Fill;
			mainLayout.Location = new Point(0, 0);
			mainLayout.Margin = new Padding(3, 2, 3, 2);
			mainLayout.Name = "mainLayout";
			mainLayout.RowCount = 2;
			mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 85F));
			mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			mainLayout.Size = new Size(976, 387);
			mainLayout.TabIndex = 1;
			// 
			// headerLayout
			// 
			headerLayout.ColumnCount = 3;
			headerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
			headerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
			headerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
			headerLayout.Controls.Add(endedBtn, 1, 0);
			headerLayout.Controls.Add(currentBtn, 0, 0);
			headerLayout.Dock = DockStyle.Fill;
			headerLayout.Location = new Point(3, 2);
			headerLayout.Margin = new Padding(3, 2, 3, 2);
			headerLayout.Name = "headerLayout";
			headerLayout.RowCount = 1;
			headerLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			headerLayout.Size = new Size(970, 81);
			headerLayout.TabIndex = 0;
			// 
			// endedBtn
			// 
			endedBtn.Dock = DockStyle.Fill;
			endedBtn.FlatStyle = FlatStyle.Flat;
			endedBtn.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			endedBtn.Image = (Image)resources.GetObject("endedBtn.Image");
			endedBtn.ImageAlign = ContentAlignment.MiddleLeft;
			endedBtn.Location = new Point(291, 0);
			endedBtn.Margin = new Padding(0);
			endedBtn.Name = "endedBtn";
			endedBtn.Size = new Size(291, 81);
			endedBtn.TabIndex = 1;
			endedBtn.Text = "Zakończony Proces Rekrutacyjny";
			endedBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
			endedBtn.UseVisualStyleBackColor = true;
			endedBtn.Click += endedBtn_Click;
			// 
			// currentBtn
			// 
			currentBtn.Dock = DockStyle.Fill;
			currentBtn.FlatStyle = FlatStyle.Flat;
			currentBtn.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			currentBtn.Image = (Image)resources.GetObject("currentBtn.Image");
			currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
			currentBtn.Location = new Point(0, 0);
			currentBtn.Margin = new Padding(0);
			currentBtn.Name = "currentBtn";
			currentBtn.Size = new Size(291, 81);
			currentBtn.TabIndex = 0;
			currentBtn.Text = "Trwa Proces Rekrutacyjny";
			currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
			currentBtn.UseVisualStyleBackColor = true;
			currentBtn.Click += currentBtn_Click;
			// 
			// ManagerMainRegistrationView
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(mainLayout);
			Margin = new Padding(3, 2, 3, 2);
			Name = "ManagerMainRegistrationView";
			Size = new Size(976, 387);
			mainLayout.ResumeLayout(false);
			headerLayout.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private TableLayoutPanel mainLayout;
		private TableLayoutPanel headerLayout;
		private Button endedBtn;
		private Button currentBtn;
	}
}
