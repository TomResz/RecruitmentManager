namespace RecruitmentManager.Forms.Candidate.Interviews
{
	partial class CandidateInterviewMainView
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CandidateInterviewMainView));
			mainLayout = new TableLayoutPanel();
			headerLayout = new TableLayoutPanel();
			pastBtn = new Button();
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
			mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
			mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			mainLayout.Size = new Size(973, 416);
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
			headerLayout.Controls.Add(pastBtn, 0, 0);
			headerLayout.Controls.Add(currentBtn, 0, 0);
			headerLayout.Dock = DockStyle.Fill;
			headerLayout.Location = new Point(0, 0);
			headerLayout.Margin = new Padding(0);
			headerLayout.Name = "headerLayout";
			headerLayout.RowCount = 1;
			headerLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			headerLayout.Size = new Size(973, 80);
			headerLayout.TabIndex = 0;
			// 
			// pastBtn
			// 
			pastBtn.Dock = DockStyle.Fill;
			pastBtn.FlatStyle = FlatStyle.Flat;
			pastBtn.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
			pastBtn.Image = (Image)resources.GetObject("pastBtn.Image");
			pastBtn.ImageAlign = ContentAlignment.MiddleLeft;
			pastBtn.Location = new Point(197, 2);
			pastBtn.Margin = new Padding(3, 2, 3, 2);
			pastBtn.Name = "pastBtn";
			pastBtn.Size = new Size(188, 76);
			pastBtn.TabIndex = 1;
			pastBtn.Text = "Historia";
			pastBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
			pastBtn.UseVisualStyleBackColor = true;
			pastBtn.Click += pastBtn_Click;
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
			currentBtn.Size = new Size(188, 76);
			currentBtn.TabIndex = 0;
			currentBtn.Text = "Aktualne";
			currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
			currentBtn.UseVisualStyleBackColor = true;
			currentBtn.Click += currentBtn_Click;
			// 
			// CandidateInterviewMainView
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(mainLayout);
			Margin = new Padding(3, 2, 3, 2);
			Name = "CandidateInterviewMainView";
			Size = new Size(973, 416);
			mainLayout.ResumeLayout(false);
			headerLayout.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private TableLayoutPanel mainLayout;
		private TableLayoutPanel headerLayout;
		private Button pastBtn;
		private Button currentBtn;
	}
}
