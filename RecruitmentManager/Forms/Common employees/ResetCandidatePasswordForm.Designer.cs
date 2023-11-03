namespace RecruitmentManager.Forms.Admin
{
	partial class ResetCandidatePasswordForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResetCandidatePasswordForm));
			confirmedPasswdLabel = new Label();
			confirmedPasswdTb = new TextBox();
			pictureBox3 = new PictureBox();
			changePasswordBtn = new Button();
			showPasswdCB = new CheckBox();
			passwordLabel = new Label();
			passwordTb = new TextBox();
			emailTb = new TextBox();
			pictureBox2 = new PictureBox();
			pictureBox1 = new PictureBox();
			((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// confirmedPasswdLabel
			// 
			confirmedPasswdLabel.AutoSize = true;
			confirmedPasswdLabel.Enabled = false;
			confirmedPasswdLabel.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
			confirmedPasswdLabel.Location = new Point(119, 213);
			confirmedPasswdLabel.Name = "confirmedPasswdLabel";
			confirmedPasswdLabel.Size = new Size(85, 34);
			confirmedPasswdLabel.TabIndex = 45;
			confirmedPasswdLabel.Text = "label1";
			// 
			// confirmedPasswdTb
			// 
			confirmedPasswdTb.BackColor = SystemColors.Control;
			confirmedPasswdTb.BorderStyle = BorderStyle.FixedSingle;
			confirmedPasswdTb.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
			confirmedPasswdTb.Location = new Point(109, 211);
			confirmedPasswdTb.Name = "confirmedPasswdTb";
			confirmedPasswdTb.Size = new Size(402, 42);
			confirmedPasswdTb.TabIndex = 44;
			confirmedPasswdTb.TextChanged += confirmedPasswdTb_TextChanged;
			// 
			// pictureBox3
			// 
			pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
			pictureBox3.Location = new Point(12, 186);
			pictureBox3.Name = "pictureBox3";
			pictureBox3.Size = new Size(88, 81);
			pictureBox3.TabIndex = 43;
			pictureBox3.TabStop = false;
			// 
			// changePasswordBtn
			// 
			changePasswordBtn.FlatStyle = FlatStyle.Flat;
			changePasswordBtn.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
			changePasswordBtn.Location = new Point(17, 329);
			changePasswordBtn.Name = "changePasswordBtn";
			changePasswordBtn.Size = new Size(491, 78);
			changePasswordBtn.TabIndex = 42;
			changePasswordBtn.Text = "Zmień hasło";
			changePasswordBtn.UseVisualStyleBackColor = true;
			changePasswordBtn.Click += changePasswordBtn_Click;
			// 
			// showPasswdCB
			// 
			showPasswdCB.AutoSize = true;
			showPasswdCB.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
			showPasswdCB.Location = new Point(329, 287);
			showPasswdCB.Name = "showPasswdCB";
			showPasswdCB.Size = new Size(179, 36);
			showPasswdCB.TabIndex = 41;
			showPasswdCB.Text = "Pokaż hasło";
			showPasswdCB.UseVisualStyleBackColor = true;
			showPasswdCB.CheckedChanged += showPasswdCB_CheckedChanged;
			// 
			// passwordLabel
			// 
			passwordLabel.AutoSize = true;
			passwordLabel.Enabled = false;
			passwordLabel.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
			passwordLabel.Location = new Point(119, 126);
			passwordLabel.Name = "passwordLabel";
			passwordLabel.Size = new Size(85, 34);
			passwordLabel.TabIndex = 40;
			passwordLabel.Text = "label1";
			// 
			// passwordTb
			// 
			passwordTb.BackColor = SystemColors.Control;
			passwordTb.BorderStyle = BorderStyle.FixedSingle;
			passwordTb.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
			passwordTb.Location = new Point(109, 124);
			passwordTb.Name = "passwordTb";
			passwordTb.Size = new Size(402, 42);
			passwordTb.TabIndex = 39;
			passwordTb.TextChanged += passwordTb_TextChanged;
			// 
			// emailTb
			// 
			emailTb.BackColor = SystemColors.Control;
			emailTb.BorderStyle = BorderStyle.FixedSingle;
			emailTb.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
			emailTb.Location = new Point(106, 37);
			emailTb.Name = "emailTb";
			emailTb.Size = new Size(402, 42);
			emailTb.TabIndex = 38;
			// 
			// pictureBox2
			// 
			pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
			pictureBox2.Location = new Point(12, 99);
			pictureBox2.Name = "pictureBox2";
			pictureBox2.Size = new Size(88, 81);
			pictureBox2.TabIndex = 37;
			pictureBox2.TabStop = false;
			// 
			// pictureBox1
			// 
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(12, 12);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(88, 81);
			pictureBox1.TabIndex = 36;
			pictureBox1.TabStop = false;
			// 
			// ResetCandidatePasswordForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(524, 413);
			Controls.Add(confirmedPasswdLabel);
			Controls.Add(confirmedPasswdTb);
			Controls.Add(pictureBox3);
			Controls.Add(changePasswordBtn);
			Controls.Add(showPasswdCB);
			Controls.Add(passwordLabel);
			Controls.Add(passwordTb);
			Controls.Add(emailTb);
			Controls.Add(pictureBox2);
			Controls.Add(pictureBox1);
			MaximumSize = new Size(542, 460);
			MinimumSize = new Size(542, 460);
			Name = "ResetCandidatePasswordForm";
			Text = "Formularz Resetowania Hasła";
			((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label confirmedPasswdLabel;
		private TextBox confirmedPasswdTb;
		private PictureBox pictureBox3;
		private Button changePasswordBtn;
		private CheckBox showPasswdCB;
		private Label passwordLabel;
		private TextBox passwordTb;
		private TextBox emailTb;
		private PictureBox pictureBox2;
		private PictureBox pictureBox1;
	}
}