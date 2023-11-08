namespace RecruitmentManager.Forms.Candidate.JobOfferViews
{
	partial class CandidateJobOfferMainView
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CandidateJobOfferMainView));
			mainLayout = new TableLayoutPanel();
			headerLayout = new TableLayoutPanel();
			myApplicationsBtn = new Button();
			activeJobOffersBtn = new Button();
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
			mainLayout.Size = new Size(1160, 603);
			mainLayout.TabIndex = 1;
			// 
			// headerLayout
			// 
			headerLayout.ColumnCount = 3;
			headerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
			headerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
			headerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
			headerLayout.Controls.Add(myApplicationsBtn, 1, 0);
			headerLayout.Controls.Add(activeJobOffersBtn, 0, 0);
			headerLayout.Dock = DockStyle.Fill;
			headerLayout.Location = new Point(3, 3);
			headerLayout.Name = "headerLayout";
			headerLayout.RowCount = 1;
			headerLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			headerLayout.Size = new Size(1154, 79);
			headerLayout.TabIndex = 0;
			// 
			// myApplicationsBtn
			// 
			myApplicationsBtn.Dock = DockStyle.Fill;
			myApplicationsBtn.FlatStyle = FlatStyle.Flat;
			myApplicationsBtn.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			myApplicationsBtn.Image = (Image)resources.GetObject("myApplicationsBtn.Image");
			myApplicationsBtn.ImageAlign = ContentAlignment.MiddleLeft;
			myApplicationsBtn.Location = new Point(230, 0);
			myApplicationsBtn.Margin = new Padding(0);
			myApplicationsBtn.Name = "myApplicationsBtn";
			myApplicationsBtn.Size = new Size(230, 79);
			myApplicationsBtn.TabIndex = 1;
			myApplicationsBtn.Text = "Moje Aplikacje";
			myApplicationsBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
			myApplicationsBtn.UseVisualStyleBackColor = true;
			// 
			// activeJobOffersBtn
			// 
			activeJobOffersBtn.Dock = DockStyle.Fill;
			activeJobOffersBtn.FlatStyle = FlatStyle.Flat;
			activeJobOffersBtn.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			activeJobOffersBtn.Image = (Image)resources.GetObject("activeJobOffersBtn.Image");
			activeJobOffersBtn.ImageAlign = ContentAlignment.MiddleLeft;
			activeJobOffersBtn.Location = new Point(0, 0);
			activeJobOffersBtn.Margin = new Padding(0);
			activeJobOffersBtn.Name = "activeJobOffersBtn";
			activeJobOffersBtn.Size = new Size(230, 79);
			activeJobOffersBtn.TabIndex = 0;
			activeJobOffersBtn.Text = "Aktualne Oferty Pracy";
			activeJobOffersBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
			activeJobOffersBtn.UseVisualStyleBackColor = true;
			activeJobOffersBtn.Click += activeJobOffersBtn_Click;
			// 
			// CandidateJobOfferMainView
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(mainLayout);
			Name = "CandidateJobOfferMainView";
			Size = new Size(1160, 603);
			mainLayout.ResumeLayout(false);
			headerLayout.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private TableLayoutPanel mainLayout;
		private TableLayoutPanel headerLayout;
		private Button myApplicationsBtn;
		private Button activeJobOffersBtn;
	}
}
