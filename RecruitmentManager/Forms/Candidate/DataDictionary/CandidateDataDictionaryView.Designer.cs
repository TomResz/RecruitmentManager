namespace RecruitmentManager.Forms.Candidate.DataDictionary
{
	partial class CandidateDataDictionaryView
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CandidateDataDictionaryView));
			mainLayout = new TableLayoutPanel();
			headerLayout = new TableLayoutPanel();
			languageKnowledgeTabBtn = new Button();
			hobbiesTabBtn = new Button();
			skillTabBtn = new Button();
			educationTabBtn = new Button();
			experienceBtn = new Button();
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
			mainLayout.Size = new Size(1142, 579);
			mainLayout.TabIndex = 0;
			// 
			// headerLayout
			// 
			headerLayout.ColumnCount = 5;
			headerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
			headerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
			headerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
			headerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
			headerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
			headerLayout.Controls.Add(languageKnowledgeTabBtn, 4, 0);
			headerLayout.Controls.Add(hobbiesTabBtn, 3, 0);
			headerLayout.Controls.Add(skillTabBtn, 2, 0);
			headerLayout.Controls.Add(educationTabBtn, 1, 0);
			headerLayout.Controls.Add(experienceBtn, 0, 0);
			headerLayout.Dock = DockStyle.Fill;
			headerLayout.Location = new Point(0, 0);
			headerLayout.Margin = new Padding(0);
			headerLayout.Name = "headerLayout";
			headerLayout.RowCount = 1;
			headerLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			headerLayout.Size = new Size(1142, 85);
			headerLayout.TabIndex = 0;
			// 
			// languageKnowledgeTabBtn
			// 
			languageKnowledgeTabBtn.Dock = DockStyle.Fill;
			languageKnowledgeTabBtn.FlatStyle = FlatStyle.Flat;
			languageKnowledgeTabBtn.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
			languageKnowledgeTabBtn.Image = (Image)resources.GetObject("languageKnowledgeTabBtn.Image");
			languageKnowledgeTabBtn.Location = new Point(915, 3);
			languageKnowledgeTabBtn.Name = "languageKnowledgeTabBtn";
			languageKnowledgeTabBtn.Size = new Size(224, 79);
			languageKnowledgeTabBtn.TabIndex = 4;
			languageKnowledgeTabBtn.Text = "Znajomość Języka";
			languageKnowledgeTabBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
			languageKnowledgeTabBtn.UseVisualStyleBackColor = true;
			languageKnowledgeTabBtn.Click += languageKnowledgeTabBtn_Click;
			// 
			// hobbiesTabBtn
			// 
			hobbiesTabBtn.Dock = DockStyle.Fill;
			hobbiesTabBtn.FlatStyle = FlatStyle.Flat;
			hobbiesTabBtn.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
			hobbiesTabBtn.Image = (Image)resources.GetObject("hobbiesTabBtn.Image");
			hobbiesTabBtn.Location = new Point(687, 3);
			hobbiesTabBtn.Name = "hobbiesTabBtn";
			hobbiesTabBtn.Size = new Size(222, 79);
			hobbiesTabBtn.TabIndex = 3;
			hobbiesTabBtn.Text = "Zainteresowania";
			hobbiesTabBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
			hobbiesTabBtn.UseVisualStyleBackColor = true;
			// 
			// skillTabBtn
			// 
			skillTabBtn.Dock = DockStyle.Fill;
			skillTabBtn.FlatStyle = FlatStyle.Flat;
			skillTabBtn.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
			skillTabBtn.Image = (Image)resources.GetObject("skillTabBtn.Image");
			skillTabBtn.Location = new Point(459, 3);
			skillTabBtn.Name = "skillTabBtn";
			skillTabBtn.Size = new Size(222, 79);
			skillTabBtn.TabIndex = 2;
			skillTabBtn.Text = "Umiejętności";
			skillTabBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
			skillTabBtn.UseVisualStyleBackColor = true;
			// 
			// educationTabBtn
			// 
			educationTabBtn.Dock = DockStyle.Fill;
			educationTabBtn.FlatStyle = FlatStyle.Flat;
			educationTabBtn.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
			educationTabBtn.Image = (Image)resources.GetObject("educationTabBtn.Image");
			educationTabBtn.Location = new Point(231, 3);
			educationTabBtn.Name = "educationTabBtn";
			educationTabBtn.Size = new Size(222, 79);
			educationTabBtn.TabIndex = 1;
			educationTabBtn.Text = "Edukacja";
			educationTabBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
			educationTabBtn.UseVisualStyleBackColor = true;
			// 
			// experienceBtn
			// 
			experienceBtn.Dock = DockStyle.Fill;
			experienceBtn.FlatStyle = FlatStyle.Flat;
			experienceBtn.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
			experienceBtn.Image = (Image)resources.GetObject("experienceBtn.Image");
			experienceBtn.Location = new Point(3, 3);
			experienceBtn.Name = "experienceBtn";
			experienceBtn.Size = new Size(222, 79);
			experienceBtn.TabIndex = 0;
			experienceBtn.Text = "Doświadczenie";
			experienceBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
			experienceBtn.UseVisualStyleBackColor = true;
			experienceBtn.Click += experienceBtn_Click;
			// 
			// CandidateDataDictionaryView
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(mainLayout);
			Name = "CandidateDataDictionaryView";
			Size = new Size(1142, 579);
			mainLayout.ResumeLayout(false);
			headerLayout.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private TableLayoutPanel mainLayout;
		private TableLayoutPanel headerLayout;
		private Button experienceBtn;
		private Button educationTabBtn;
		private Button skillTabBtn;
		private Button hobbiesTabBtn;
		private Button languageKnowledgeTabBtn;
	}
}
