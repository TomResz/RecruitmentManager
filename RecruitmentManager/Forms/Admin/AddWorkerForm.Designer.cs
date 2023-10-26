namespace RecruitmentManager.Forms.Admin
{
	partial class AddWorkerForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddWorkerForm));
			confirmedPasswdLabel = new Label();
			confirmedPasswdTb = new TextBox();
			pictureBox3 = new PictureBox();
			registerBtn = new Button();
			showPasswdCB = new CheckBox();
			passwordLabel = new Label();
			emailLabel = new Label();
			passwordTb = new TextBox();
			emailTb = new TextBox();
			pictureBox2 = new PictureBox();
			pictureBox1 = new PictureBox();
			lastNameLabel = new Label();
			lastNameTb = new TextBox();
			pictureBox4 = new PictureBox();
			firstNameLabel = new Label();
			firstNameTb = new TextBox();
			pictureBox5 = new PictureBox();
			groupBox1 = new GroupBox();
			recruiterRb = new RadioButton();
			managerRb = new RadioButton();
			adminRb = new RadioButton();
			((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
			groupBox1.SuspendLayout();
			SuspendLayout();
			// 
			// confirmedPasswdLabel
			// 
			confirmedPasswdLabel.AutoSize = true;
			confirmedPasswdLabel.Enabled = false;
			confirmedPasswdLabel.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
			confirmedPasswdLabel.Location = new Point(119, 370);
			confirmedPasswdLabel.Name = "confirmedPasswdLabel";
			confirmedPasswdLabel.Size = new Size(85, 34);
			confirmedPasswdLabel.TabIndex = 35;
			confirmedPasswdLabel.Text = "label1";
			// 
			// confirmedPasswdTb
			// 
			confirmedPasswdTb.BackColor = SystemColors.Control;
			confirmedPasswdTb.BorderStyle = BorderStyle.FixedSingle;
			confirmedPasswdTb.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
			confirmedPasswdTb.Location = new Point(109, 368);
			confirmedPasswdTb.Name = "confirmedPasswdTb";
			confirmedPasswdTb.Size = new Size(418, 42);
			confirmedPasswdTb.TabIndex = 34;
			confirmedPasswdTb.TextChanged += confirmedPasswdTb_TextChanged;
			// 
			// pictureBox3
			// 
			pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
			pictureBox3.Location = new Point(12, 343);
			pictureBox3.Name = "pictureBox3";
			pictureBox3.Size = new Size(88, 81);
			pictureBox3.TabIndex = 33;
			pictureBox3.TabStop = false;
			// 
			// registerBtn
			// 
			registerBtn.FlatStyle = FlatStyle.Flat;
			registerBtn.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
			registerBtn.Location = new Point(12, 570);
			registerBtn.Name = "registerBtn";
			registerBtn.Size = new Size(512, 78);
			registerBtn.TabIndex = 30;
			registerBtn.Text = "Dodaj pracownika";
			registerBtn.UseVisualStyleBackColor = true;
			registerBtn.Click += registerBtn_Click;
			// 
			// showPasswdCB
			// 
			showPasswdCB.AutoSize = true;
			showPasswdCB.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
			showPasswdCB.Location = new Point(345, 528);
			showPasswdCB.Name = "showPasswdCB";
			showPasswdCB.Size = new Size(179, 36);
			showPasswdCB.TabIndex = 29;
			showPasswdCB.Text = "Pokaż hasło";
			showPasswdCB.UseVisualStyleBackColor = true;
			showPasswdCB.CheckedChanged += showPasswdCB_CheckedChanged;
			// 
			// passwordLabel
			// 
			passwordLabel.AutoSize = true;
			passwordLabel.Enabled = false;
			passwordLabel.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
			passwordLabel.Location = new Point(119, 283);
			passwordLabel.Name = "passwordLabel";
			passwordLabel.Size = new Size(85, 34);
			passwordLabel.TabIndex = 28;
			passwordLabel.Text = "label1";
			// 
			// emailLabel
			// 
			emailLabel.AutoSize = true;
			emailLabel.Enabled = false;
			emailLabel.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
			emailLabel.Location = new Point(116, 196);
			emailLabel.Name = "emailLabel";
			emailLabel.Size = new Size(85, 34);
			emailLabel.TabIndex = 27;
			emailLabel.Text = "label1";
			// 
			// passwordTb
			// 
			passwordTb.BackColor = SystemColors.Control;
			passwordTb.BorderStyle = BorderStyle.FixedSingle;
			passwordTb.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
			passwordTb.Location = new Point(109, 281);
			passwordTb.Name = "passwordTb";
			passwordTb.Size = new Size(418, 42);
			passwordTb.TabIndex = 26;
			passwordTb.TextChanged += passwordTb_TextChanged;
			// 
			// emailTb
			// 
			emailTb.BackColor = SystemColors.Control;
			emailTb.BorderStyle = BorderStyle.FixedSingle;
			emailTb.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
			emailTb.Location = new Point(106, 194);
			emailTb.Name = "emailTb";
			emailTb.Size = new Size(421, 42);
			emailTb.TabIndex = 25;
			emailTb.TextChanged += emailTb_TextChanged;
			// 
			// pictureBox2
			// 
			pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
			pictureBox2.Location = new Point(12, 256);
			pictureBox2.Name = "pictureBox2";
			pictureBox2.Size = new Size(88, 81);
			pictureBox2.TabIndex = 24;
			pictureBox2.TabStop = false;
			// 
			// pictureBox1
			// 
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(12, 169);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(88, 81);
			pictureBox1.TabIndex = 23;
			pictureBox1.TabStop = false;
			// 
			// lastNameLabel
			// 
			lastNameLabel.AutoSize = true;
			lastNameLabel.Enabled = false;
			lastNameLabel.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
			lastNameLabel.Location = new Point(116, 109);
			lastNameLabel.Name = "lastNameLabel";
			lastNameLabel.Size = new Size(85, 34);
			lastNameLabel.TabIndex = 38;
			lastNameLabel.Text = "label1";
			// 
			// lastNameTb
			// 
			lastNameTb.BackColor = SystemColors.Control;
			lastNameTb.BorderStyle = BorderStyle.FixedSingle;
			lastNameTb.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
			lastNameTb.Location = new Point(106, 107);
			lastNameTb.Name = "lastNameTb";
			lastNameTb.Size = new Size(421, 42);
			lastNameTb.TabIndex = 37;
			lastNameTb.TextChanged += lastNameTb_TextChanged;
			// 
			// pictureBox4
			// 
			pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
			pictureBox4.Location = new Point(12, 82);
			pictureBox4.Name = "pictureBox4";
			pictureBox4.Size = new Size(88, 81);
			pictureBox4.TabIndex = 36;
			pictureBox4.TabStop = false;
			// 
			// firstNameLabel
			// 
			firstNameLabel.AutoSize = true;
			firstNameLabel.Enabled = false;
			firstNameLabel.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
			firstNameLabel.Location = new Point(116, 22);
			firstNameLabel.Name = "firstNameLabel";
			firstNameLabel.Size = new Size(85, 34);
			firstNameLabel.TabIndex = 41;
			firstNameLabel.Text = "label1";
			// 
			// firstNameTb
			// 
			firstNameTb.BackColor = SystemColors.Control;
			firstNameTb.BorderStyle = BorderStyle.FixedSingle;
			firstNameTb.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
			firstNameTb.Location = new Point(106, 20);
			firstNameTb.Name = "firstNameTb";
			firstNameTb.Size = new Size(421, 42);
			firstNameTb.TabIndex = 40;
			firstNameTb.TextChanged += firstNameTb_TextChanged;
			// 
			// pictureBox5
			// 
			pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
			pictureBox5.Location = new Point(12, -5);
			pictureBox5.Name = "pictureBox5";
			pictureBox5.Size = new Size(88, 81);
			pictureBox5.TabIndex = 39;
			pictureBox5.TabStop = false;
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(recruiterRb);
			groupBox1.Controls.Add(managerRb);
			groupBox1.Controls.Add(adminRb);
			groupBox1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
			groupBox1.Location = new Point(12, 430);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(515, 92);
			groupBox1.TabIndex = 42;
			groupBox1.TabStop = false;
			groupBox1.Text = "Wybór roli pracownika :";
			// 
			// recruiterRb
			// 
			recruiterRb.AutoSize = true;
			recruiterRb.Location = new Point(392, 37);
			recruiterRb.Name = "recruiterRb";
			recruiterRb.Size = new Size(109, 27);
			recruiterRb.TabIndex = 2;
			recruiterRb.TabStop = true;
			recruiterRb.Text = "Rekruter";
			recruiterRb.UseVisualStyleBackColor = true;
			// 
			// managerRb
			// 
			managerRb.AutoSize = true;
			managerRb.Location = new Point(162, 37);
			managerRb.Name = "managerRb";
			managerRb.Size = new Size(224, 27);
			managerRb.TabIndex = 1;
			managerRb.TabStop = true;
			managerRb.Text = "Szef Działu Rekrutacji";
			managerRb.UseVisualStyleBackColor = true;
			// 
			// adminRb
			// 
			adminRb.AutoSize = true;
			adminRb.Location = new Point(8, 37);
			adminRb.Name = "adminRb";
			adminRb.Size = new Size(148, 27);
			adminRb.TabIndex = 0;
			adminRb.TabStop = true;
			adminRb.Text = "Administrator";
			adminRb.UseVisualStyleBackColor = true;
			// 
			// AddWorkerForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(539, 653);
			Controls.Add(groupBox1);
			Controls.Add(firstNameLabel);
			Controls.Add(firstNameTb);
			Controls.Add(pictureBox5);
			Controls.Add(lastNameLabel);
			Controls.Add(lastNameTb);
			Controls.Add(pictureBox4);
			Controls.Add(confirmedPasswdLabel);
			Controls.Add(confirmedPasswdTb);
			Controls.Add(pictureBox3);
			Controls.Add(registerBtn);
			Controls.Add(showPasswdCB);
			Controls.Add(passwordLabel);
			Controls.Add(emailLabel);
			Controls.Add(passwordTb);
			Controls.Add(emailTb);
			Controls.Add(pictureBox2);
			Controls.Add(pictureBox1);
			MaximumSize = new Size(557, 700);
			MinimumSize = new Size(557, 700);
			Name = "AddWorkerForm";
			Text = "AddWorkerForm";
			((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label confirmedPasswdLabel;
		private TextBox confirmedPasswdTb;
		private PictureBox pictureBox3;
		private Button registerBtn;
		private CheckBox showPasswdCB;
		private Label passwordLabel;
		private Label emailLabel;
		private TextBox passwordTb;
		private TextBox emailTb;
		private PictureBox pictureBox2;
		private PictureBox pictureBox1;
		private Label lastNameLabel;
		private TextBox lastNameTb;
		private PictureBox pictureBox4;
		private Label firstNameLabel;
		private TextBox firstNameTb;
		private PictureBox pictureBox5;
		private GroupBox groupBox1;
		private RadioButton managerRb;
		private RadioButton adminRb;
		private RadioButton recruiterRb;
	}
}