namespace RecruitmentManager.Forms
{
	partial class LoginWorkerForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginWorkerForm));
			loginBtn = new Button();
			showPasswdCB = new CheckBox();
			passwordLabel = new Label();
			emailLabel = new Label();
			passwordTb = new TextBox();
			emailTb = new TextBox();
			pictureBox2 = new PictureBox();
			pictureBox1 = new PictureBox();
			backToMainFormLabel = new Label();
			((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// loginBtn
			// 
			loginBtn.FlatStyle = FlatStyle.Flat;
			loginBtn.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
			loginBtn.Location = new Point(109, 273);
			loginBtn.Name = "loginBtn";
			loginBtn.Size = new Size(402, 78);
			loginBtn.TabIndex = 17;
			loginBtn.Text = "Zaloguj się";
			loginBtn.UseVisualStyleBackColor = true;
			loginBtn.Click += loginBtn_ClickAsync;
			// 
			// showPasswdCB
			// 
			showPasswdCB.AutoSize = true;
			showPasswdCB.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
			showPasswdCB.Location = new Point(332, 213);
			showPasswdCB.Name = "showPasswdCB";
			showPasswdCB.Size = new Size(179, 36);
			showPasswdCB.TabIndex = 16;
			showPasswdCB.Text = "Pokaż hasło";
			showPasswdCB.UseVisualStyleBackColor = true;
			showPasswdCB.CheckedChanged += showPasswdCB_CheckedChanged;
			// 
			// passwordLabel
			// 
			passwordLabel.AutoSize = true;
			passwordLabel.Enabled = false;
			passwordLabel.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
			passwordLabel.Location = new Point(119, 158);
			passwordLabel.Name = "passwordLabel";
			passwordLabel.Size = new Size(85, 34);
			passwordLabel.TabIndex = 15;
			passwordLabel.Text = "label1";
			// 
			// emailLabel
			// 
			emailLabel.AutoSize = true;
			emailLabel.Enabled = false;
			emailLabel.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
			emailLabel.Location = new Point(116, 62);
			emailLabel.Name = "emailLabel";
			emailLabel.Size = new Size(85, 34);
			emailLabel.TabIndex = 14;
			emailLabel.Text = "label1";
			// 
			// passwordTb
			// 
			passwordTb.BackColor = SystemColors.Control;
			passwordTb.BorderStyle = BorderStyle.FixedSingle;
			passwordTb.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
			passwordTb.Location = new Point(109, 156);
			passwordTb.Name = "passwordTb";
			passwordTb.Size = new Size(402, 42);
			passwordTb.TabIndex = 13;
			passwordTb.TextChanged += passwordTb_TextChanged;
			// 
			// emailTb
			// 
			emailTb.BackColor = SystemColors.Control;
			emailTb.BorderStyle = BorderStyle.FixedSingle;
			emailTb.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
			emailTb.Location = new Point(106, 60);
			emailTb.Name = "emailTb";
			emailTb.Size = new Size(402, 42);
			emailTb.TabIndex = 12;
			emailTb.TextChanged += emailTb_TextChanged;
			// 
			// pictureBox2
			// 
			pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
			pictureBox2.Location = new Point(12, 131);
			pictureBox2.Name = "pictureBox2";
			pictureBox2.Size = new Size(88, 81);
			pictureBox2.TabIndex = 11;
			pictureBox2.TabStop = false;
			// 
			// pictureBox1
			// 
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(12, 35);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(88, 81);
			pictureBox1.TabIndex = 10;
			pictureBox1.TabStop = false;
			// 
			// backToMainFormLabel
			// 
			backToMainFormLabel.AutoSize = true;
			backToMainFormLabel.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
			backToMainFormLabel.Location = new Point(174, 375);
			backToMainFormLabel.Name = "backToMainFormLabel";
			backToMainFormLabel.Size = new Size(252, 26);
			backToMainFormLabel.TabIndex = 18;
			backToMainFormLabel.Text = "Powrót do strony głównej";
			backToMainFormLabel.Click += backToMainFormLabel_Click;
			// 
			// LoginWorkerForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(522, 433);
			Controls.Add(backToMainFormLabel);
			Controls.Add(loginBtn);
			Controls.Add(showPasswdCB);
			Controls.Add(passwordLabel);
			Controls.Add(emailLabel);
			Controls.Add(passwordTb);
			Controls.Add(emailTb);
			Controls.Add(pictureBox2);
			Controls.Add(pictureBox1);
			MaximumSize = new Size(540, 480);
			MinimumSize = new Size(540, 480);
			Name = "LoginWorkerForm";
			Text = "Formularz Logowania Pracowników";
			((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button loginBtn;
		private CheckBox showPasswdCB;
		private Label passwordLabel;
		private Label emailLabel;
		private TextBox passwordTb;
		private TextBox emailTb;
		private PictureBox pictureBox2;
		private PictureBox pictureBox1;
		private Label backToMainFormLabel;
	}
}