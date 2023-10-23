namespace RecruitmentManager
{
	partial class RegisterCandidateForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterCandidateForm));
			loginLabel = new Label();
			label1 = new Label();
			registerBtn = new Button();
			showPasswdCB = new CheckBox();
			passwordLabel = new Label();
			emailLabel = new Label();
			passwordTb = new TextBox();
			emailTb = new TextBox();
			pictureBox2 = new PictureBox();
			pictureBox1 = new PictureBox();
			confirmedPasswdLabel = new Label();
			confirmedPasswdTb = new TextBox();
			pictureBox3 = new PictureBox();
			((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
			SuspendLayout();
			// 
			// loginLabel
			// 
			loginLabel.AutoSize = true;
			loginLabel.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
			loginLabel.Location = new Point(235, 463);
			loginLabel.Name = "loginLabel";
			loginLabel.Size = new Size(116, 23);
			loginLabel.TabIndex = 19;
			loginLabel.Text = "Zaloguj się !";
			loginLabel.Click += loginLabel_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			label1.Location = new Point(181, 427);
			label1.Name = "label1";
			label1.Size = new Size(224, 25);
			label1.TabIndex = 18;
			label1.Text = "Posiadasz już konto ?";
			// 
			// registerBtn
			// 
			registerBtn.FlatStyle = FlatStyle.Flat;
			registerBtn.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
			registerBtn.Location = new Point(98, 324);
			registerBtn.Name = "registerBtn";
			registerBtn.Size = new Size(402, 78);
			registerBtn.TabIndex = 17;
			registerBtn.Text = "Zarejestruj się";
			registerBtn.UseVisualStyleBackColor = true;
			registerBtn.Click += registerBtn_Click;
			// 
			// showPasswdCB
			// 
			showPasswdCB.AutoSize = true;
			showPasswdCB.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
			showPasswdCB.Location = new Point(321, 282);
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
			passwordLabel.Location = new Point(111, 121);
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
			emailLabel.Location = new Point(108, 34);
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
			passwordTb.Location = new Point(101, 119);
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
			emailTb.Location = new Point(98, 32);
			emailTb.Name = "emailTb";
			emailTb.Size = new Size(402, 42);
			emailTb.TabIndex = 12;
			emailTb.TextChanged += emailTb_TextChanged;
			// 
			// pictureBox2
			// 
			pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
			pictureBox2.Location = new Point(4, 94);
			pictureBox2.Name = "pictureBox2";
			pictureBox2.Size = new Size(88, 81);
			pictureBox2.TabIndex = 11;
			pictureBox2.TabStop = false;
			// 
			// pictureBox1
			// 
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(4, 7);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(88, 81);
			pictureBox1.TabIndex = 10;
			pictureBox1.TabStop = false;
			// 
			// confirmedPasswdLabel
			// 
			confirmedPasswdLabel.AutoSize = true;
			confirmedPasswdLabel.Enabled = false;
			confirmedPasswdLabel.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
			confirmedPasswdLabel.Location = new Point(111, 208);
			confirmedPasswdLabel.Name = "confirmedPasswdLabel";
			confirmedPasswdLabel.Size = new Size(85, 34);
			confirmedPasswdLabel.TabIndex = 22;
			confirmedPasswdLabel.Text = "label1";
			// 
			// confirmedPasswdTb
			// 
			confirmedPasswdTb.BackColor = SystemColors.Control;
			confirmedPasswdTb.BorderStyle = BorderStyle.FixedSingle;
			confirmedPasswdTb.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
			confirmedPasswdTb.Location = new Point(101, 206);
			confirmedPasswdTb.Name = "confirmedPasswdTb";
			confirmedPasswdTb.Size = new Size(402, 42);
			confirmedPasswdTb.TabIndex = 21;
			confirmedPasswdTb.TextChanged += confirmedPasswdTb_TextChanged;
			// 
			// pictureBox3
			// 
			pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
			pictureBox3.Location = new Point(4, 181);
			pictureBox3.Name = "pictureBox3";
			pictureBox3.Size = new Size(88, 81);
			pictureBox3.TabIndex = 20;
			pictureBox3.TabStop = false;
			// 
			// RegisterCandidateForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(509, 521);
			Controls.Add(confirmedPasswdLabel);
			Controls.Add(confirmedPasswdTb);
			Controls.Add(pictureBox3);
			Controls.Add(loginLabel);
			Controls.Add(label1);
			Controls.Add(registerBtn);
			Controls.Add(showPasswdCB);
			Controls.Add(passwordLabel);
			Controls.Add(emailLabel);
			Controls.Add(passwordTb);
			Controls.Add(emailTb);
			Controls.Add(pictureBox2);
			Controls.Add(pictureBox1);
			MaximumSize = new Size(527, 568);
			MinimumSize = new Size(527, 568);
			Name = "RegisterCandidateForm";
			Text = "Formularz Rejestracji Kandydata";
			((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label loginLabel;
		private Label label1;
		private Button registerBtn;
		private CheckBox showPasswdCB;
		private Label passwordLabel;
		private Label emailLabel;
		private TextBox passwordTb;
		private TextBox emailTb;
		private PictureBox pictureBox2;
		private PictureBox pictureBox1;
		private Label confirmedPasswdLabel;
		private TextBox confirmedPasswdTb;
		private PictureBox pictureBox3;
	}
}