namespace RecruitmentManager.Forms.Manager.JobOffers
{
	partial class JobOffersMainView
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JobOffersMainView));
			mainLayout = new TableLayoutPanel();
			headerLayout = new TableLayoutPanel();
			button1 = new Button();
			completedBtn = new Button();
			activeBtn = new Button();
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
			mainLayout.Size = new Size(1010, 392);
			mainLayout.TabIndex = 0;
			// 
			// headerLayout
			// 
			headerLayout.ColumnCount = 4;
			headerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
			headerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
			headerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
			headerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
			headerLayout.Controls.Add(button1, 0, 0);
			headerLayout.Controls.Add(completedBtn, 1, 0);
			headerLayout.Controls.Add(activeBtn, 0, 0);
			headerLayout.Dock = DockStyle.Fill;
			headerLayout.Location = new Point(3, 2);
			headerLayout.Margin = new Padding(3, 2, 3, 2);
			headerLayout.Name = "headerLayout";
			headerLayout.RowCount = 1;
			headerLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			headerLayout.Size = new Size(1004, 81);
			headerLayout.TabIndex = 0;
			// 
			// button1
			// 
			button1.Dock = DockStyle.Fill;
			button1.FlatStyle = FlatStyle.Flat;
			button1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			button1.Image = (Image)resources.GetObject("button1.Image");
			button1.ImageAlign = ContentAlignment.MiddleLeft;
			button1.Location = new Point(200, 0);
			button1.Margin = new Padding(0);
			button1.Name = "button1";
			button1.Size = new Size(200, 81);
			button1.TabIndex = 2;
			button1.Text = "Trwa Nabór Kandydatów";
			button1.TextImageRelation = TextImageRelation.ImageBeforeText;
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// completedBtn
			// 
			completedBtn.Dock = DockStyle.Fill;
			completedBtn.FlatStyle = FlatStyle.Flat;
			completedBtn.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			completedBtn.Image = (Image)resources.GetObject("completedBtn.Image");
			completedBtn.ImageAlign = ContentAlignment.MiddleLeft;
			completedBtn.Location = new Point(400, 0);
			completedBtn.Margin = new Padding(0);
			completedBtn.Name = "completedBtn";
			completedBtn.Size = new Size(200, 81);
			completedBtn.TabIndex = 1;
			completedBtn.Text = "Zakończone";
			completedBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
			completedBtn.UseVisualStyleBackColor = true;
			completedBtn.Click += completedBtn_Click;
			// 
			// activeBtn
			// 
			activeBtn.Dock = DockStyle.Fill;
			activeBtn.FlatStyle = FlatStyle.Flat;
			activeBtn.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			activeBtn.Image = (Image)resources.GetObject("activeBtn.Image");
			activeBtn.ImageAlign = ContentAlignment.MiddleLeft;
			activeBtn.Location = new Point(0, 0);
			activeBtn.Margin = new Padding(0);
			activeBtn.Name = "activeBtn";
			activeBtn.Size = new Size(200, 81);
			activeBtn.TabIndex = 0;
			activeBtn.Text = "Aktywne";
			activeBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
			activeBtn.UseVisualStyleBackColor = true;
			activeBtn.Click += activeBtn_Click;
			// 
			// JobOffersMainView
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(mainLayout);
			Margin = new Padding(3, 2, 3, 2);
			Name = "JobOffersMainView";
			Size = new Size(1010, 392);
			mainLayout.ResumeLayout(false);
			headerLayout.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private TableLayoutPanel mainLayout;
		private TableLayoutPanel headerLayout;
		private Button activeBtn;
		private Button completedBtn;
		private Button button1;
	}
}
