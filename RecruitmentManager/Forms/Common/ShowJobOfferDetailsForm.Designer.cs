namespace RecruitmentManager.Forms.Common
{
	partial class ShowJobOfferDetailsForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowJobOfferDetailsForm));
			descriptionTextBox = new RichTextBox();
			tableLayoutPanel1 = new TableLayoutPanel();
			titleTextBox = new RichTextBox();
			titlePB = new PictureBox();
			descriptionPB = new PictureBox();
			beginDatePB = new PictureBox();
			footerLayout = new TableLayoutPanel();
			endDatePB = new PictureBox();
			numberOfPlacesPB = new PictureBox();
			beginDateLabel = new Label();
			endDateLabel = new Label();
			countLabel = new Label();
			toolTip1 = new ToolTip(components);
			tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)titlePB).BeginInit();
			((System.ComponentModel.ISupportInitialize)descriptionPB).BeginInit();
			((System.ComponentModel.ISupportInitialize)beginDatePB).BeginInit();
			footerLayout.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)endDatePB).BeginInit();
			((System.ComponentModel.ISupportInitialize)numberOfPlacesPB).BeginInit();
			SuspendLayout();
			// 
			// descriptionTextBox
			// 
			descriptionTextBox.BackColor = SystemColors.Control;
			descriptionTextBox.Dock = DockStyle.Fill;
			descriptionTextBox.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
			descriptionTextBox.Location = new Point(88, 79);
			descriptionTextBox.Name = "descriptionTextBox";
			descriptionTextBox.Size = new Size(1315, 424);
			descriptionTextBox.TabIndex = 4;
			descriptionTextBox.Text = "";
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.ColumnCount = 2;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 85F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			tableLayoutPanel1.Controls.Add(titleTextBox, 1, 0);
			tableLayoutPanel1.Controls.Add(descriptionTextBox, 1, 1);
			tableLayoutPanel1.Controls.Add(titlePB, 0, 0);
			tableLayoutPanel1.Controls.Add(descriptionPB, 0, 1);
			tableLayoutPanel1.Controls.Add(beginDatePB, 0, 2);
			tableLayoutPanel1.Controls.Add(footerLayout, 1, 2);
			tableLayoutPanel1.Dock = DockStyle.Fill;
			tableLayoutPanel1.Location = new Point(0, 0);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 3;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 85F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 85F));
			tableLayoutPanel1.Size = new Size(1406, 592);
			tableLayoutPanel1.TabIndex = 1;
			// 
			// titleTextBox
			// 
			titleTextBox.BackColor = SystemColors.Control;
			titleTextBox.Dock = DockStyle.Fill;
			titleTextBox.Font = new Font("Times New Roman", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
			titleTextBox.Location = new Point(88, 3);
			titleTextBox.Multiline = false;
			titleTextBox.Name = "titleTextBox";
			titleTextBox.Size = new Size(1315, 70);
			titleTextBox.TabIndex = 3;
			titleTextBox.Text = "";
			// 
			// titlePB
			// 
			titlePB.Dock = DockStyle.Fill;
			titlePB.Image = (Image)resources.GetObject("titlePB.Image");
			titlePB.Location = new Point(3, 3);
			titlePB.Name = "titlePB";
			titlePB.Size = new Size(79, 70);
			titlePB.SizeMode = PictureBoxSizeMode.CenterImage;
			titlePB.TabIndex = 5;
			titlePB.TabStop = false;
			// 
			// descriptionPB
			// 
			descriptionPB.Image = (Image)resources.GetObject("descriptionPB.Image");
			descriptionPB.Location = new Point(3, 79);
			descriptionPB.Name = "descriptionPB";
			descriptionPB.Size = new Size(75, 75);
			descriptionPB.SizeMode = PictureBoxSizeMode.AutoSize;
			descriptionPB.TabIndex = 6;
			descriptionPB.TabStop = false;
			// 
			// beginDatePB
			// 
			beginDatePB.Dock = DockStyle.Fill;
			beginDatePB.Image = (Image)resources.GetObject("beginDatePB.Image");
			beginDatePB.Location = new Point(0, 506);
			beginDatePB.Margin = new Padding(0);
			beginDatePB.Name = "beginDatePB";
			beginDatePB.Size = new Size(85, 86);
			beginDatePB.TabIndex = 7;
			beginDatePB.TabStop = false;
			// 
			// footerLayout
			// 
			footerLayout.ColumnCount = 6;
			footerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
			footerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 85F));
			footerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
			footerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 85F));
			footerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 85F));
			footerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
			footerLayout.Controls.Add(endDatePB, 1, 0);
			footerLayout.Controls.Add(numberOfPlacesPB, 4, 0);
			footerLayout.Controls.Add(beginDateLabel, 0, 0);
			footerLayout.Controls.Add(endDateLabel, 2, 0);
			footerLayout.Controls.Add(countLabel, 5, 0);
			footerLayout.Dock = DockStyle.Fill;
			footerLayout.Location = new Point(88, 509);
			footerLayout.Name = "footerLayout";
			footerLayout.RowCount = 1;
			footerLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			footerLayout.Size = new Size(1315, 80);
			footerLayout.TabIndex = 8;
			// 
			// endDatePB
			// 
			endDatePB.Dock = DockStyle.Fill;
			endDatePB.Image = (Image)resources.GetObject("endDatePB.Image");
			endDatePB.Location = new Point(353, 0);
			endDatePB.Margin = new Padding(0);
			endDatePB.Name = "endDatePB";
			endDatePB.Size = new Size(85, 80);
			endDatePB.TabIndex = 2;
			endDatePB.TabStop = false;
			// 
			// numberOfPlacesPB
			// 
			numberOfPlacesPB.Dock = DockStyle.Fill;
			numberOfPlacesPB.Image = (Image)resources.GetObject("numberOfPlacesPB.Image");
			numberOfPlacesPB.Location = new Point(876, 0);
			numberOfPlacesPB.Margin = new Padding(0);
			numberOfPlacesPB.Name = "numberOfPlacesPB";
			numberOfPlacesPB.Size = new Size(85, 80);
			numberOfPlacesPB.TabIndex = 5;
			numberOfPlacesPB.TabStop = false;
			// 
			// beginDateLabel
			// 
			beginDateLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			beginDateLabel.AutoSize = true;
			beginDateLabel.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
			beginDateLabel.Location = new Point(3, 24);
			beginDateLabel.Name = "beginDateLabel";
			beginDateLabel.Size = new Size(347, 32);
			beginDateLabel.TabIndex = 6;
			beginDateLabel.Text = "label1";
			// 
			// endDateLabel
			// 
			endDateLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			endDateLabel.AutoSize = true;
			endDateLabel.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
			endDateLabel.Location = new Point(441, 24);
			endDateLabel.Name = "endDateLabel";
			endDateLabel.Size = new Size(347, 32);
			endDateLabel.TabIndex = 7;
			endDateLabel.Text = "label2";
			// 
			// countLabel
			// 
			countLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			countLabel.AutoSize = true;
			countLabel.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
			countLabel.Location = new Point(964, 24);
			countLabel.Name = "countLabel";
			countLabel.Size = new Size(348, 32);
			countLabel.TabIndex = 8;
			countLabel.Text = "label3";
			// 
			// EditJobOfferDetailsForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1406, 592);
			Controls.Add(tableLayoutPanel1);
			Name = "EditJobOfferDetailsForm";
			Text = "EditJobOfferDetailsForm";
			tableLayoutPanel1.ResumeLayout(false);
			tableLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)titlePB).EndInit();
			((System.ComponentModel.ISupportInitialize)descriptionPB).EndInit();
			((System.ComponentModel.ISupportInitialize)beginDatePB).EndInit();
			footerLayout.ResumeLayout(false);
			footerLayout.PerformLayout();
			((System.ComponentModel.ISupportInitialize)endDatePB).EndInit();
			((System.ComponentModel.ISupportInitialize)numberOfPlacesPB).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private RichTextBox descriptionTextBox;
		private TableLayoutPanel tableLayoutPanel1;
		private RichTextBox titleTextBox;
		private PictureBox titlePB;
		private PictureBox descriptionPB;
		private PictureBox beginDatePB;
		private TableLayoutPanel footerLayout;
		private PictureBox endDatePB;
		private PictureBox numberOfPlacesPB;
		private Label beginDateLabel;
		private Label endDateLabel;
		private Label countLabel;
		private ToolTip toolTip1;
	}
}