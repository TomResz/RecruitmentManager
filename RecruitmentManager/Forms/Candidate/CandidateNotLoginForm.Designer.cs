namespace RecruitmentManager.Forms.Candidate
{
	partial class CandidateNotLoginForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CandidateNotLoginForm));
			mainLayout = new TableLayoutPanel();
			jobOffersDGV = new DataGridView();
			footerLayout = new TableLayoutPanel();
			loginBtn = new Button();
			registerBtn = new Button();
			previousPagePB = new PictureBox();
			nextPagePB = new PictureBox();
			pageCounterLabel = new Label();
			mainLayout.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)jobOffersDGV).BeginInit();
			footerLayout.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)previousPagePB).BeginInit();
			((System.ComponentModel.ISupportInitialize)nextPagePB).BeginInit();
			SuspendLayout();
			// 
			// mainLayout
			// 
			mainLayout.ColumnCount = 1;
			mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			mainLayout.Controls.Add(jobOffersDGV, 0, 0);
			mainLayout.Controls.Add(footerLayout, 0, 1);
			mainLayout.Dock = DockStyle.Fill;
			mainLayout.Location = new Point(0, 0);
			mainLayout.Name = "mainLayout";
			mainLayout.RowCount = 2;
			mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 85F));
			mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
			mainLayout.Size = new Size(1379, 544);
			mainLayout.TabIndex = 0;
			// 
			// jobOffersDGV
			// 
			jobOffersDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			jobOffersDGV.Dock = DockStyle.Fill;
			jobOffersDGV.Location = new Point(3, 3);
			jobOffersDGV.Name = "jobOffersDGV";
			jobOffersDGV.RowHeadersWidth = 51;
			jobOffersDGV.RowTemplate.Height = 29;
			jobOffersDGV.Size = new Size(1373, 456);
			jobOffersDGV.TabIndex = 0;
			// 
			// footerLayout
			// 
			footerLayout.ColumnCount = 6;
			footerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
			footerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
			footerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
			footerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
			footerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
			footerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 85F));
			footerLayout.Controls.Add(loginBtn, 0, 0);
			footerLayout.Controls.Add(registerBtn, 1, 0);
			footerLayout.Controls.Add(previousPagePB, 3, 0);
			footerLayout.Controls.Add(nextPagePB, 4, 0);
			footerLayout.Controls.Add(pageCounterLabel, 5, 0);
			footerLayout.Dock = DockStyle.Fill;
			footerLayout.Location = new Point(0, 462);
			footerLayout.Margin = new Padding(0);
			footerLayout.Name = "footerLayout";
			footerLayout.RowCount = 1;
			footerLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
			footerLayout.Size = new Size(1379, 82);
			footerLayout.TabIndex = 1;
			// 
			// loginBtn
			// 
			loginBtn.Dock = DockStyle.Fill;
			loginBtn.FlatStyle = FlatStyle.Flat;
			loginBtn.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
			loginBtn.Location = new Point(3, 3);
			loginBtn.Name = "loginBtn";
			loginBtn.Size = new Size(228, 76);
			loginBtn.TabIndex = 2;
			loginBtn.Text = "Zaloguj się";
			loginBtn.UseVisualStyleBackColor = true;
			loginBtn.Click += loginBtn_Click;
			// 
			// registerBtn
			// 
			registerBtn.Dock = DockStyle.Fill;
			registerBtn.FlatStyle = FlatStyle.Flat;
			registerBtn.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
			registerBtn.Location = new Point(237, 3);
			registerBtn.Name = "registerBtn";
			registerBtn.Size = new Size(228, 76);
			registerBtn.TabIndex = 3;
			registerBtn.Text = "Zarejestruj się";
			registerBtn.UseVisualStyleBackColor = true;
			registerBtn.Click += registerBtn_Click;
			// 
			// previousPagePB
			// 
			previousPagePB.Dock = DockStyle.Fill;
			previousPagePB.Image = (Image)resources.GetObject("previousPagePB.Image");
			previousPagePB.Location = new Point(1172, 0);
			previousPagePB.Margin = new Padding(0);
			previousPagePB.Name = "previousPagePB";
			previousPagePB.Size = new Size(60, 82);
			previousPagePB.SizeMode = PictureBoxSizeMode.CenterImage;
			previousPagePB.TabIndex = 4;
			previousPagePB.TabStop = false;
			previousPagePB.Click += previousPagePB_Click;
			// 
			// nextPagePB
			// 
			nextPagePB.Dock = DockStyle.Fill;
			nextPagePB.Image = (Image)resources.GetObject("nextPagePB.Image");
			nextPagePB.Location = new Point(1232, 0);
			nextPagePB.Margin = new Padding(0);
			nextPagePB.Name = "nextPagePB";
			nextPagePB.Size = new Size(60, 82);
			nextPagePB.SizeMode = PictureBoxSizeMode.CenterImage;
			nextPagePB.TabIndex = 5;
			nextPagePB.TabStop = false;
			nextPagePB.Click += nextPagePB_Click;
			// 
			// pageCounterLabel
			// 
			pageCounterLabel.Anchor = AnchorStyles.None;
			pageCounterLabel.AutoSize = true;
			pageCounterLabel.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
			pageCounterLabel.Location = new Point(1312, 32);
			pageCounterLabel.Name = "pageCounterLabel";
			pageCounterLabel.Size = new Size(47, 17);
			pageCounterLabel.TabIndex = 6;
			pageCounterLabel.Text = "label1";
			// 
			// CandidateNotLoginForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1379, 544);
			Controls.Add(mainLayout);
			Name = "CandidateNotLoginForm";
			Text = "CandidateNotLoginForm";
			mainLayout.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)jobOffersDGV).EndInit();
			footerLayout.ResumeLayout(false);
			footerLayout.PerformLayout();
			((System.ComponentModel.ISupportInitialize)previousPagePB).EndInit();
			((System.ComponentModel.ISupportInitialize)nextPagePB).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private TableLayoutPanel mainLayout;
		private DataGridView jobOffersDGV;
		private TableLayoutPanel footerLayout;
		private Button loginBtn;
		private Button registerBtn;
		private PictureBox previousPagePB;
		private PictureBox nextPagePB;
		private Label pageCounterLabel;
	}
}