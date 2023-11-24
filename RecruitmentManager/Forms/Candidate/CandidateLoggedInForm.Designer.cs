namespace RecruitmentManager.Forms.Candidate
{
	partial class CandidateLoggedInForm
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
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CandidateLoggedInForm));
			mainLayout = new TableLayoutPanel();
			leftLayout = new TableLayoutPanel();
			profilePicturePB = new PictureBox();
			logoutBtn = new Button();
			navigationBarLayout = new TableLayoutPanel();
			jobOfferBtn = new Button();
			interviewBtn = new Button();
			editDataBtn = new Button();
			newsBtn = new Button();
			headeLayout = new TableLayoutPanel();
			menuStrip1 = new MenuStrip();
			menuToolStripMenuItem = new ToolStripMenuItem();
			dsadsToolStripMenuItem = new ToolStripMenuItem();
			edycjaToolStripMenuItem = new ToolStripMenuItem();
			edytujDaneToolStripMenuItem = new ToolStripMenuItem();
			toolTip1 = new ToolTip(components);
			mainLayout.SuspendLayout();
			leftLayout.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)profilePicturePB).BeginInit();
			navigationBarLayout.SuspendLayout();
			headeLayout.SuspendLayout();
			menuStrip1.SuspendLayout();
			SuspendLayout();
			// 
			// mainLayout
			// 
			mainLayout.ColumnCount = 2;
			mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
			mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
			mainLayout.Controls.Add(leftLayout, 0, 0);
			mainLayout.Dock = DockStyle.Fill;
			mainLayout.Location = new Point(3, 38);
			mainLayout.Name = "mainLayout";
			mainLayout.RowCount = 1;
			mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			mainLayout.Size = new Size(1432, 576);
			mainLayout.TabIndex = 2;
			// 
			// leftLayout
			// 
			leftLayout.CellBorderStyle = TableLayoutPanelCellBorderStyle.OutsetDouble;
			leftLayout.ColumnCount = 1;
			leftLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			leftLayout.Controls.Add(profilePicturePB, 0, 0);
			leftLayout.Controls.Add(logoutBtn, 0, 2);
			leftLayout.Controls.Add(navigationBarLayout, 0, 1);
			leftLayout.Dock = DockStyle.Fill;
			leftLayout.Location = new Point(3, 3);
			leftLayout.Name = "leftLayout";
			leftLayout.RowCount = 3;
			leftLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
			leftLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 75F));
			leftLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
			leftLayout.Size = new Size(280, 570);
			leftLayout.TabIndex = 0;
			// 
			// profilePicturePB
			// 
			profilePicturePB.Dock = DockStyle.Fill;
			profilePicturePB.Image = (Image)resources.GetObject("profilePicturePB.Image");
			profilePicturePB.Location = new Point(6, 6);
			profilePicturePB.Name = "profilePicturePB";
			profilePicturePB.Size = new Size(268, 108);
			profilePicturePB.SizeMode = PictureBoxSizeMode.Zoom;
			profilePicturePB.TabIndex = 0;
			profilePicturePB.TabStop = false;
			profilePicturePB.Click += profilePicture_Click;
			// 
			// logoutBtn
			// 
			logoutBtn.BackColor = SystemColors.GradientActiveCaption;
			logoutBtn.Dock = DockStyle.Fill;
			logoutBtn.FlatStyle = FlatStyle.Flat;
			logoutBtn.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
			logoutBtn.Location = new Point(6, 469);
			logoutBtn.Name = "logoutBtn";
			logoutBtn.Size = new Size(268, 95);
			logoutBtn.TabIndex = 1;
			logoutBtn.Text = "Wyloguj się";
			logoutBtn.UseVisualStyleBackColor = false;
			logoutBtn.Click += logoutBtn_Click_1;
			// 
			// navigationBarLayout
			// 
			navigationBarLayout.ColumnCount = 1;
			navigationBarLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			navigationBarLayout.Controls.Add(jobOfferBtn, 0, 3);
			navigationBarLayout.Controls.Add(interviewBtn, 0, 2);
			navigationBarLayout.Controls.Add(editDataBtn, 0, 1);
			navigationBarLayout.Controls.Add(newsBtn, 0, 0);
			navigationBarLayout.Dock = DockStyle.Fill;
			navigationBarLayout.Location = new Point(3, 120);
			navigationBarLayout.Margin = new Padding(0);
			navigationBarLayout.Name = "navigationBarLayout";
			navigationBarLayout.RowCount = 4;
			navigationBarLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
			navigationBarLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
			navigationBarLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
			navigationBarLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
			navigationBarLayout.Size = new Size(274, 343);
			navigationBarLayout.TabIndex = 2;
			// 
			// jobOfferBtn
			// 
			jobOfferBtn.Dock = DockStyle.Fill;
			jobOfferBtn.FlatStyle = FlatStyle.Flat;
			jobOfferBtn.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			jobOfferBtn.Image = (Image)resources.GetObject("jobOfferBtn.Image");
			jobOfferBtn.Location = new Point(3, 258);
			jobOfferBtn.Name = "jobOfferBtn";
			jobOfferBtn.Size = new Size(268, 82);
			jobOfferBtn.TabIndex = 3;
			jobOfferBtn.Text = "Oferty Pracy";
			jobOfferBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
			jobOfferBtn.UseVisualStyleBackColor = true;
			jobOfferBtn.Click += jobOfferBtn_Click;
			// 
			// interviewBtn
			// 
			interviewBtn.Dock = DockStyle.Fill;
			interviewBtn.FlatStyle = FlatStyle.Flat;
			interviewBtn.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			interviewBtn.Image = (Image)resources.GetObject("interviewBtn.Image");
			interviewBtn.Location = new Point(3, 173);
			interviewBtn.Name = "interviewBtn";
			interviewBtn.Size = new Size(268, 79);
			interviewBtn.TabIndex = 2;
			interviewBtn.Text = "Rozmowy Rekrutacyjne";
			interviewBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
			interviewBtn.UseVisualStyleBackColor = true;
			interviewBtn.Click += interviewBtn_Click;
			// 
			// editDataBtn
			// 
			editDataBtn.Dock = DockStyle.Fill;
			editDataBtn.FlatStyle = FlatStyle.Flat;
			editDataBtn.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			editDataBtn.Image = (Image)resources.GetObject("editDataBtn.Image");
			editDataBtn.Location = new Point(3, 88);
			editDataBtn.Name = "editDataBtn";
			editDataBtn.Size = new Size(268, 79);
			editDataBtn.TabIndex = 1;
			editDataBtn.Text = "Edycja Danych";
			editDataBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
			editDataBtn.UseVisualStyleBackColor = true;
			editDataBtn.Click += editDataBtn_Click;
			// 
			// newsBtn
			// 
			newsBtn.Dock = DockStyle.Fill;
			newsBtn.FlatStyle = FlatStyle.Flat;
			newsBtn.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			newsBtn.Image = (Image)resources.GetObject("newsBtn.Image");
			newsBtn.Location = new Point(3, 3);
			newsBtn.Name = "newsBtn";
			newsBtn.Size = new Size(268, 79);
			newsBtn.TabIndex = 0;
			newsBtn.Text = "Aktualności";
			newsBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
			newsBtn.UseVisualStyleBackColor = true;
			newsBtn.Click += newsBtn_Click;
			// 
			// headeLayout
			// 
			headeLayout.ColumnCount = 1;
			headeLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			headeLayout.Controls.Add(mainLayout, 0, 1);
			headeLayout.Controls.Add(menuStrip1, 0, 0);
			headeLayout.Dock = DockStyle.Fill;
			headeLayout.Location = new Point(0, 0);
			headeLayout.Name = "headeLayout";
			headeLayout.RowCount = 2;
			headeLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
			headeLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			headeLayout.Size = new Size(1438, 617);
			headeLayout.TabIndex = 1;
			// 
			// menuStrip1
			// 
			menuStrip1.Dock = DockStyle.Fill;
			menuStrip1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
			menuStrip1.ImageScalingSize = new Size(20, 20);
			menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem, edycjaToolStripMenuItem });
			menuStrip1.Location = new Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Size = new Size(1438, 35);
			menuStrip1.TabIndex = 0;
			menuStrip1.Text = "menuStrip1";
			// 
			// menuToolStripMenuItem
			// 
			menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dsadsToolStripMenuItem });
			menuToolStripMenuItem.Name = "menuToolStripMenuItem";
			menuToolStripMenuItem.Size = new Size(72, 31);
			menuToolStripMenuItem.Text = "Menu";
			// 
			// dsadsToolStripMenuItem
			// 
			dsadsToolStripMenuItem.Name = "dsadsToolStripMenuItem";
			dsadsToolStripMenuItem.Size = new Size(140, 28);
			dsadsToolStripMenuItem.Text = "dsads";
			// 
			// edycjaToolStripMenuItem
			// 
			edycjaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { edytujDaneToolStripMenuItem });
			edycjaToolStripMenuItem.Name = "edycjaToolStripMenuItem";
			edycjaToolStripMenuItem.Size = new Size(83, 31);
			edycjaToolStripMenuItem.Text = "Edycja";
			// 
			// edytujDaneToolStripMenuItem
			// 
			edytujDaneToolStripMenuItem.Name = "edytujDaneToolStripMenuItem";
			edytujDaneToolStripMenuItem.Size = new Size(200, 28);
			edytujDaneToolStripMenuItem.Text = "Edytuj Dane";
			edytujDaneToolStripMenuItem.Click += edytujDaneToolStripMenuItem_Click;
			// 
			// CandidateLoggedInForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1438, 617);
			Controls.Add(headeLayout);
			Name = "CandidateLoggedInForm";
			Text = "Formularz Kandydata";
			mainLayout.ResumeLayout(false);
			leftLayout.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)profilePicturePB).EndInit();
			navigationBarLayout.ResumeLayout(false);
			headeLayout.ResumeLayout(false);
			headeLayout.PerformLayout();
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private TableLayoutPanel mainLayout;
		private TableLayoutPanel headeLayout;
		private MenuStrip menuStrip1;
		private ToolStripMenuItem menuToolStripMenuItem;
		private ToolStripMenuItem dsadsToolStripMenuItem;
		private ToolStripMenuItem edycjaToolStripMenuItem;
		private ToolStripMenuItem edytujDaneToolStripMenuItem;
		private TableLayoutPanel leftLayout;
		private PictureBox profilePicturePB;
		private ToolTip toolTip1;
		private Button logoutBtn;
		private TableLayoutPanel navigationBarLayout;
		private Button newsBtn;
		private Button jobOfferBtn;
		private Button interviewBtn;
		private Button editDataBtn;
	}
}