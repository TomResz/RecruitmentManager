namespace RecruitmentManager.Forms.Recruiter.Assessment
{
	partial class AssessmentMainView
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssessmentMainView));
			mainLayout = new TableLayoutPanel();
			headerLayout = new TableLayoutPanel();
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
			mainLayout.Size = new Size(1152, 451);
			mainLayout.TabIndex = 2;
			// 
			// headerLayout
			// 
			headerLayout.ColumnCount = 5;
			headerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
			headerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
			headerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
			headerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
			headerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
			headerLayout.Controls.Add(currentBtn, 0, 0);
			headerLayout.Dock = DockStyle.Fill;
			headerLayout.Location = new Point(0, 0);
			headerLayout.Margin = new Padding(0);
			headerLayout.Name = "headerLayout";
			headerLayout.RowCount = 1;
			headerLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			headerLayout.Size = new Size(1152, 85);
			headerLayout.TabIndex = 0;
			// 
			// currentBtn
			// 
			currentBtn.Dock = DockStyle.Fill;
			currentBtn.FlatStyle = FlatStyle.Flat;
			currentBtn.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
			currentBtn.Image = (Image)resources.GetObject("currentBtn.Image");
			currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
			currentBtn.Location = new Point(3, 2);
			currentBtn.Margin = new Padding(3, 2, 3, 2);
			currentBtn.Name = "currentBtn";
			currentBtn.Size = new Size(224, 81);
			currentBtn.TabIndex = 0;
			currentBtn.Text = "Aktualne";
			currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
			currentBtn.UseVisualStyleBackColor = true;
			currentBtn.Click += currentBtn_Click;
			// 
			// AssessmentMainView
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(mainLayout);
			Margin = new Padding(3, 2, 3, 2);
			Name = "AssessmentMainView";
			Size = new Size(1152, 451);
			mainLayout.ResumeLayout(false);
			headerLayout.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private TableLayoutPanel mainLayout;
		private TableLayoutPanel headerLayout;
		private Button currentBtn;
	}
}
