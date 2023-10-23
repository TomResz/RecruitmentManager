namespace RecruitmentManager
{
	partial class MainForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			pictureBox1 = new PictureBox();
			candidateModeBtn = new Button();
			workerModeBtn = new Button();
			pictureBox2 = new PictureBox();
			label1 = new Label();
			label2 = new Label();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
			SuspendLayout();
			// 
			// pictureBox1
			// 
			pictureBox1.BorderStyle = BorderStyle.Fixed3D;
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(15, 160);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(95, 91);
			pictureBox1.TabIndex = 0;
			pictureBox1.TabStop = false;
			// 
			// candidateModeBtn
			// 
			candidateModeBtn.FlatStyle = FlatStyle.Flat;
			candidateModeBtn.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
			candidateModeBtn.Location = new Point(117, 160);
			candidateModeBtn.Name = "candidateModeBtn";
			candidateModeBtn.Size = new Size(274, 91);
			candidateModeBtn.TabIndex = 2;
			candidateModeBtn.Text = "Tryb Kandydata";
			candidateModeBtn.UseVisualStyleBackColor = true;
			candidateModeBtn.Click += candidateModeBtn_Click;
			// 
			// workerModeBtn
			// 
			workerModeBtn.FlatStyle = FlatStyle.Flat;
			workerModeBtn.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
			workerModeBtn.Location = new Point(117, 276);
			workerModeBtn.Name = "workerModeBtn";
			workerModeBtn.Size = new Size(274, 91);
			workerModeBtn.TabIndex = 5;
			workerModeBtn.Text = "Tryb Pracownika";
			workerModeBtn.UseVisualStyleBackColor = true;
			workerModeBtn.Click += workerModeBtn_Click;
			// 
			// pictureBox2
			// 
			pictureBox2.BorderStyle = BorderStyle.Fixed3D;
			pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
			pictureBox2.Location = new Point(15, 276);
			pictureBox2.Name = "pictureBox2";
			pictureBox2.Size = new Size(95, 91);
			pictureBox2.TabIndex = 4;
			pictureBox2.TabStop = false;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Times New Roman", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
			label1.Location = new Point(28, 9);
			label1.Name = "label1";
			label1.Size = new Size(341, 42);
			label1.TabIndex = 6;
			label1.Text = "Menadżer rekrutacji";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
			label2.Location = new Point(15, 109);
			label2.Name = "label2";
			label2.Size = new Size(189, 32);
			label2.TabIndex = 7;
			label2.Text = "Wybierz tryb :";
			// 
			// MainForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(394, 372);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(workerModeBtn);
			Controls.Add(pictureBox2);
			Controls.Add(candidateModeBtn);
			Controls.Add(pictureBox1);
			MaximumSize = new Size(412, 419);
			MinimumSize = new Size(412, 419);
			Name = "MainForm";
			Text = "Menadżer Rekrutacji";
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private PictureBox pictureBox1;
		private Button candidateModeBtn;
		private Button workerModeBtn;
		private PictureBox pictureBox2;
		private Label label1;
		private Label label2;
	}
}