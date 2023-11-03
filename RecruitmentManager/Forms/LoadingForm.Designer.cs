namespace RecruitmentManager.Forms
{
	partial class LoadingForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadingForm));
			mainLabel = new Label();
			pictureBox1 = new PictureBox();
			label1 = new Label();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// mainLabel
			// 
			mainLabel.AutoSize = true;
			mainLabel.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point);
			mainLabel.Location = new Point(12, 20);
			mainLabel.Name = "mainLabel";
			mainLabel.Size = new Size(385, 45);
			mainLabel.TabIndex = 0;
			mainLabel.Text = "Menadżer Rekrutacji";
			// 
			// pictureBox1
			// 
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(109, 68);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(172, 139);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 1;
			pictureBox1.TabStop = false;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
			label1.Location = new Point(29, 224);
			label1.Name = "label1";
			label1.Size = new Size(333, 32);
			label1.TabIndex = 2;
			label1.Text = "Trwa Łączenie ze Serwerem";
			// 
			// LoadingForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(389, 265);
			Controls.Add(label1);
			Controls.Add(pictureBox1);
			Controls.Add(mainLabel);
			MaximumSize = new Size(407, 312);
			MinimumSize = new Size(407, 312);
			Name = "LoadingForm";
			Text = "Ładowanie programu ...";
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label mainLabel;
		private PictureBox pictureBox1;
		private Label label1;
	}
}