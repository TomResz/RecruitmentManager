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
			mainLayout.Name = "mainLayout";
			mainLayout.RowCount = 2;
			mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 85F));
			mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			mainLayout.Size = new Size(1112, 555);
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
			headerLayout.Size = new Size(1112, 85);
			headerLayout.TabIndex = 0;
			// 
			// pastBtn
			// 
			pastBtn.Dock = DockStyle.Fill;
			pastBtn.FlatStyle = FlatStyle.Flat;
			pastBtn.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
			pastBtn.Image = (Image)resources.GetObject("pastBtn.Image");
			pastBtn.ImageAlign = ContentAlignment.MiddleLeft;
			pastBtn.Location = new Point(225, 3);
			pastBtn.Name = "pastBtn";
			pastBtn.Size = new Size(216, 79);
			pastBtn.TabIndex = 1;
			pastBtn.Text = "Historia";
			pastBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
			pastBtn.UseVisualStyleBackColor = true;
			// 
			// currentBtn
			// 
			currentBtn.Dock = DockStyle.Fill;
			currentBtn.FlatStyle = FlatStyle.Flat;
			currentBtn.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
			currentBtn.Image = (Image)resources.GetObject("currentBtn.Image");
			currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
			currentBtn.Location = new Point(3, 3);
			currentBtn.Name = "currentBtn";
			currentBtn.Size = new Size(216, 79);
			currentBtn.TabIndex = 0;
			currentBtn.Text = "Aktualne";
			currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
			currentBtn.UseVisualStyleBackColor = true;
			currentBtn.Click += currentBtn_Click;
			// 
			// CandidateInterviewMainView
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(mainLayout);
			Name = "CandidateInterviewMainView";
			Size = new Size(1112, 555);
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
