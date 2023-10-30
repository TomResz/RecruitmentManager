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
			firstNameLabel = new Label();
			firstNameTb = new TextBox();
			pictureBox5 = new PictureBox();
			lastNameLabel = new Label();
			lastNameTb = new TextBox();
			pictureBox4 = new PictureBox();
			((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
			SuspendLayout();
			// 
			// loginLabel
			// 
			loginLabel.AutoSize = true;
			loginLabel.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
			loginLabel.Location = new Point(232, 591);
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
			label1.Location = new Point(178, 555);
			label1.Name = "label1";
			label1.Size = new Size(224, 25);
			label1.TabIndex = 18;
			label1.Text = "Posiadasz już konto ?";
			// 
			// registerBtn
			// 
			registerBtn.FlatStyle = FlatStyle.Flat;
			registerBtn.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
			registerBtn.Location = new Point(109, 459);
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
			showPasswdCB.Location = new Point(332, 425);
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
			passwordLabel.Location = new Point(119, 292);
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
			emailLabel.Location = new Point(116, 205);
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
			passwordTb.Location = new Point(109, 290);
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
			emailTb.Location = new Point(106, 203);
			emailTb.Name = "emailTb";
			emailTb.Size = new Size(402, 42);
			emailTb.TabIndex = 12;
			emailTb.TextChanged += emailTb_TextChanged;
			// 
			// pictureBox2
			// 
			pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
			pictureBox2.Location = new Point(12, 265);
			pictureBox2.Name = "pictureBox2";
			pictureBox2.Size = new Size(88, 81);
			pictureBox2.TabIndex = 11;
			pictureBox2.TabStop = false;
			// 
			// pictureBox1
			// 
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(12, 178);
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
			confirmedPasswdLabel.Location = new Point(119, 379);
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
			confirmedPasswdTb.Location = new Point(109, 377);
			confirmedPasswdTb.Name = "confirmedPasswdTb";
			confirmedPasswdTb.Size = new Size(402, 42);
			confirmedPasswdTb.TabIndex = 21;
			confirmedPasswdTb.TextChanged += confirmedPasswdTb_TextChanged;
			// 
			// pictureBox3
			// 
			pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
			pictureBox3.Location = new Point(12, 352);
			pictureBox3.Name = "pictureBox3";
			pictureBox3.Size = new Size(88, 81);
			pictureBox3.TabIndex = 20;
			pictureBox3.TabStop = false;
			// 
			// firstNameLabel
			// 
			firstNameLabel.AutoSize = true;
			firstNameLabel.Enabled = false;
			firstNameLabel.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
			firstNameLabel.Location = new Point(116, 31);
			firstNameLabel.Name = "firstNameLabel";
			firstNameLabel.Size = new Size(85, 34);
			firstNameLabel.TabIndex = 47;
			firstNameLabel.Text = "label1";
			// 
			// firstNameTb
			// 
			firstNameTb.BackColor = SystemColors.Control;
			firstNameTb.BorderStyle = BorderStyle.FixedSingle;
			firstNameTb.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
			firstNameTb.Location = new Point(106, 29);
			firstNameTb.Name = "firstNameTb";
			firstNameTb.Size = new Size(402, 42);
			firstNameTb.TabIndex = 46;
			firstNameTb.TextChanged += firstNameTb_TextChanged;
			// 
			// pictureBox5
			// 
			pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
			pictureBox5.Location = new Point(12, 4);
			pictureBox5.Name = "pictureBox5";
			pictureBox5.Size = new Size(88, 81);
			pictureBox5.TabIndex = 45;
			pictureBox5.TabStop = false;
			// 
			// lastNameLabel
			// 
			lastNameLabel.AutoSize = true;
			lastNameLabel.Enabled = false;
			lastNameLabel.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
			lastNameLabel.Location = new Point(116, 118);
			lastNameLabel.Name = "lastNameLabel";
			lastNameLabel.Size = new Size(85, 34);
			lastNameLabel.TabIndex = 44;
			lastNameLabel.Text = "label1";
			// 
			// lastNameTb
			// 
			lastNameTb.BackColor = SystemColors.Control;
			lastNameTb.BorderStyle = BorderStyle.FixedSingle;
			lastNameTb.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
			lastNameTb.Location = new Point(106, 116);
			lastNameTb.Name = "lastNameTb";
			lastNameTb.Size = new Size(402, 42);
			lastNameTb.TabIndex = 43;
			lastNameTb.TextChanged += lastNameTb_TextChanged;
			// 
			// pictureBox4
			// 
			pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
			pictureBox4.Location = new Point(12, 91);
			pictureBox4.Name = "pictureBox4";
			pictureBox4.Size = new Size(88, 81);
			pictureBox4.TabIndex = 42;
			pictureBox4.TabStop = false;
			// 
			// RegisterCandidateForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(532, 616);
			Controls.Add(firstNameLabel);
			Controls.Add(firstNameTb);
			Controls.Add(pictureBox5);
			Controls.Add(lastNameLabel);
			Controls.Add(lastNameTb);
			Controls.Add(pictureBox4);
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
			MaximumSize = new Size(550, 663);
			MinimumSize = new Size(550, 663);
			Name = "RegisterCandidateForm";
			Text = "Formularz Rejestracji Kandydata";
			((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
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
		private Label firstNameLabel;
		private TextBox firstNameTb;
		private PictureBox pictureBox5;
		private Label lastNameLabel;
		private TextBox lastNameTb;
		private PictureBox pictureBox4;
	}
}