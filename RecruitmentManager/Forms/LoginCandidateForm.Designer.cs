namespace RecruitmentManager
{
	partial class LoginCandidateForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginCandidateForm));
			pictureBox1 = new PictureBox();
			pictureBox2 = new PictureBox();
			emailTb = new TextBox();
			passwordTb = new TextBox();
			emailLabel = new Label();
			passwordLabel = new Label();
			showPasswdCB = new CheckBox();
			loginBtn = new Button();
			label1 = new Label();
			label2 = new Label();
			backToMainFormLabel = new Label();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
			SuspendLayout();
			// 
			// pictureBox1
			// 
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(12, 52);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(88, 81);
			pictureBox1.TabIndex = 0;
			pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
			pictureBox2.Location = new Point(12, 139);
			pictureBox2.Name = "pictureBox2";
			pictureBox2.Size = new Size(88, 81);
			pictureBox2.TabIndex = 1;
			pictureBox2.TabStop = false;
			// 
			// emailTb
			// 
			emailTb.BackColor = SystemColors.Control;
			emailTb.BorderStyle = BorderStyle.FixedSingle;
			emailTb.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
			emailTb.Location = new Point(106, 77);
			emailTb.Name = "emailTb";
			emailTb.Size = new Size(402, 42);
			emailTb.TabIndex = 2;
			emailTb.TextChanged += emailTb_TextChanged;
			// 
			// passwordTb
			// 
			passwordTb.BackColor = SystemColors.Control;
			passwordTb.BorderStyle = BorderStyle.FixedSingle;
			passwordTb.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
			passwordTb.Location = new Point(109, 164);
			passwordTb.Name = "passwordTb";
			passwordTb.Size = new Size(402, 42);
			passwordTb.TabIndex = 3;
			passwordTb.TextChanged += passwordTb_TextChanged;
			// 
			// emailLabel
			// 
			emailLabel.AutoSize = true;
			emailLabel.Enabled = false;
			emailLabel.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
			emailLabel.Location = new Point(116, 79);
			emailLabel.Name = "emailLabel";
			emailLabel.Size = new Size(85, 34);
			emailLabel.TabIndex = 4;
			emailLabel.Text = "label1";
			// 
			// passwordLabel
			// 
			passwordLabel.AutoSize = true;
			passwordLabel.Enabled = false;
			passwordLabel.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
			passwordLabel.Location = new Point(119, 166);
			passwordLabel.Name = "passwordLabel";
			passwordLabel.Size = new Size(85, 34);
			passwordLabel.TabIndex = 5;
			passwordLabel.Text = "label1";
			// 
			// showPasswdCB
			// 
			showPasswdCB.AutoSize = true;
			showPasswdCB.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
			showPasswdCB.Location = new Point(332, 221);
			showPasswdCB.Name = "showPasswdCB";
			showPasswdCB.Size = new Size(179, 36);
			showPasswdCB.TabIndex = 6;
			showPasswdCB.Text = "Pokaż hasło";
			showPasswdCB.UseVisualStyleBackColor = true;
			showPasswdCB.CheckedChanged += showPasswdCB_CheckedChanged;
			// 
			// loginBtn
			// 
			loginBtn.FlatStyle = FlatStyle.Flat;
			loginBtn.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
			loginBtn.Location = new Point(109, 263);
			loginBtn.Name = "loginBtn";
			loginBtn.Size = new Size(402, 78);
			loginBtn.TabIndex = 7;
			loginBtn.Text = "Zaloguj się";
			loginBtn.UseVisualStyleBackColor = true;
			loginBtn.Click += loginBtn_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			label1.Location = new Point(150, 356);
			label1.Name = "label1";
			label1.Size = new Size(299, 25);
			label1.TabIndex = 8;
			label1.Text = "Nie posiadasz jeszcze konta ?";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
			label2.Location = new Point(222, 391);
			label2.Name = "label2";
			label2.Size = new Size(136, 23);
			label2.TabIndex = 9;
			label2.Text = "Zarejestruj się ";
			label2.Click += label2_Click;
			// 
			// backToMainFormLabel
			// 
			backToMainFormLabel.AutoSize = true;
			backToMainFormLabel.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
			backToMainFormLabel.Location = new Point(165, 448);
			backToMainFormLabel.Name = "backToMainFormLabel";
			backToMainFormLabel.Size = new Size(252, 26);
			backToMainFormLabel.TabIndex = 19;
			backToMainFormLabel.Text = "Powrót do strony głównej";
			backToMainFormLabel.Click += backToMainFormLabel_Click;
			// 
			// LoginCandidateForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.Control;
			ClientSize = new Size(522, 492);
			Controls.Add(backToMainFormLabel);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(loginBtn);
			Controls.Add(showPasswdCB);
			Controls.Add(passwordLabel);
			Controls.Add(emailLabel);
			Controls.Add(passwordTb);
			Controls.Add(emailTb);
			Controls.Add(pictureBox2);
			Controls.Add(pictureBox1);
			MaximumSize = new Size(540, 539);
			MinimumSize = new Size(540, 539);
			Name = "LoginCandidateForm";
			Text = "Formularz Logowania Kandydata";
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private PictureBox pictureBox1;
		private PictureBox pictureBox2;
		private TextBox emailTb;
		private TextBox passwordTb;
		private Label emailLabel;
		private Label passwordLabel;
		private CheckBox showPasswdCB;
		private Button loginBtn;
		private Label label1;
		private Label label2;
		private Label backToMainFormLabel;
	}
}