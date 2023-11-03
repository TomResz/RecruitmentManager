namespace RecruitmentManager.Forms.Admin
{
	partial class EditEmployeeDataForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditEmployeeDataForm));
			firstNameLabel = new Label();
			firstNameTb = new TextBox();
			pictureBox5 = new PictureBox();
			lastNameLabel = new Label();
			lastNameTb = new TextBox();
			pictureBox4 = new PictureBox();
			emailTb = new TextBox();
			pictureBox1 = new PictureBox();
			phoneNumberLabel = new Label();
			phoneNumberTb = new TextBox();
			pictureBox2 = new PictureBox();
			pictureBox3 = new PictureBox();
			birthDatePicker = new DateTimePicker();
			editDataBtn = new Button();
			((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
			SuspendLayout();
			// 
			// firstNameLabel
			// 
			firstNameLabel.AutoSize = true;
			firstNameLabel.Enabled = false;
			firstNameLabel.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
			firstNameLabel.Location = new Point(116, 39);
			firstNameLabel.Name = "firstNameLabel";
			firstNameLabel.Size = new Size(85, 34);
			firstNameLabel.TabIndex = 50;
			firstNameLabel.Text = "label1";
			// 
			// firstNameTb
			// 
			firstNameTb.BackColor = SystemColors.Control;
			firstNameTb.BorderStyle = BorderStyle.FixedSingle;
			firstNameTb.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
			firstNameTb.Location = new Point(106, 37);
			firstNameTb.Name = "firstNameTb";
			firstNameTb.Size = new Size(421, 42);
			firstNameTb.TabIndex = 49;
			firstNameTb.TextChanged += firstNameTb_TextChanged;
			// 
			// pictureBox5
			// 
			pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
			pictureBox5.Location = new Point(12, 12);
			pictureBox5.Name = "pictureBox5";
			pictureBox5.Size = new Size(88, 81);
			pictureBox5.TabIndex = 48;
			pictureBox5.TabStop = false;
			// 
			// lastNameLabel
			// 
			lastNameLabel.AutoSize = true;
			lastNameLabel.Enabled = false;
			lastNameLabel.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
			lastNameLabel.Location = new Point(116, 126);
			lastNameLabel.Name = "lastNameLabel";
			lastNameLabel.Size = new Size(85, 34);
			lastNameLabel.TabIndex = 47;
			lastNameLabel.Text = "label1";
			// 
			// lastNameTb
			// 
			lastNameTb.BackColor = SystemColors.Control;
			lastNameTb.BorderStyle = BorderStyle.FixedSingle;
			lastNameTb.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
			lastNameTb.Location = new Point(106, 124);
			lastNameTb.Name = "lastNameTb";
			lastNameTb.Size = new Size(421, 42);
			lastNameTb.TabIndex = 46;
			lastNameTb.TextChanged += lastNameTb_TextChanged;
			// 
			// pictureBox4
			// 
			pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
			pictureBox4.Location = new Point(12, 99);
			pictureBox4.Name = "pictureBox4";
			pictureBox4.Size = new Size(88, 81);
			pictureBox4.TabIndex = 45;
			pictureBox4.TabStop = false;
			// 
			// emailTb
			// 
			emailTb.BackColor = SystemColors.Control;
			emailTb.BorderStyle = BorderStyle.FixedSingle;
			emailTb.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
			emailTb.Location = new Point(637, 37);
			emailTb.Name = "emailTb";
			emailTb.Size = new Size(421, 42);
			emailTb.TabIndex = 43;
			// 
			// pictureBox1
			// 
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(543, 12);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(88, 81);
			pictureBox1.TabIndex = 42;
			pictureBox1.TabStop = false;
			// 
			// phoneNumberLabel
			// 
			phoneNumberLabel.AutoSize = true;
			phoneNumberLabel.Enabled = false;
			phoneNumberLabel.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
			phoneNumberLabel.Location = new Point(647, 126);
			phoneNumberLabel.Name = "phoneNumberLabel";
			phoneNumberLabel.Size = new Size(85, 34);
			phoneNumberLabel.TabIndex = 53;
			phoneNumberLabel.Text = "label1";
			// 
			// phoneNumberTb
			// 
			phoneNumberTb.BackColor = SystemColors.Control;
			phoneNumberTb.BorderStyle = BorderStyle.FixedSingle;
			phoneNumberTb.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
			phoneNumberTb.Location = new Point(637, 124);
			phoneNumberTb.Name = "phoneNumberTb";
			phoneNumberTb.Size = new Size(421, 42);
			phoneNumberTb.TabIndex = 52;
			phoneNumberTb.TextChanged += phoneNumberTb_TextChanged;
			// 
			// pictureBox2
			// 
			pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
			pictureBox2.Location = new Point(543, 99);
			pictureBox2.Name = "pictureBox2";
			pictureBox2.Size = new Size(88, 81);
			pictureBox2.TabIndex = 51;
			pictureBox2.TabStop = false;
			// 
			// pictureBox3
			// 
			pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
			pictureBox3.Location = new Point(12, 186);
			pictureBox3.Name = "pictureBox3";
			pictureBox3.Size = new Size(88, 81);
			pictureBox3.TabIndex = 54;
			pictureBox3.TabStop = false;
			// 
			// birthDatePicker
			// 
			birthDatePicker.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
			birthDatePicker.Format = DateTimePickerFormat.Short;
			birthDatePicker.Location = new Point(106, 211);
			birthDatePicker.Name = "birthDatePicker";
			birthDatePicker.Size = new Size(421, 30);
			birthDatePicker.TabIndex = 55;
			// 
			// editDataBtn
			// 
			editDataBtn.FlatStyle = FlatStyle.Flat;
			editDataBtn.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
			editDataBtn.Location = new Point(543, 211);
			editDataBtn.Name = "editDataBtn";
			editDataBtn.Size = new Size(515, 66);
			editDataBtn.TabIndex = 56;
			editDataBtn.Text = "Edytuj Dane";
			editDataBtn.UseVisualStyleBackColor = true;
			editDataBtn.Click += editDataBtn_Click;
			// 
			// EditEmployeeDataForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1071, 284);
			Controls.Add(editDataBtn);
			Controls.Add(birthDatePicker);
			Controls.Add(pictureBox3);
			Controls.Add(phoneNumberLabel);
			Controls.Add(phoneNumberTb);
			Controls.Add(pictureBox2);
			Controls.Add(firstNameLabel);
			Controls.Add(firstNameTb);
			Controls.Add(pictureBox5);
			Controls.Add(lastNameLabel);
			Controls.Add(lastNameTb);
			Controls.Add(pictureBox4);
			Controls.Add(emailTb);
			Controls.Add(pictureBox1);
			MaximumSize = new Size(1089, 331);
			MinimumSize = new Size(1089, 331);
			Name = "EditEmployeeDataForm";
			Text = "Edytowanie Danych Pracownika";
			((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label firstNameLabel;
		private TextBox firstNameTb;
		private PictureBox pictureBox5;
		private Label lastNameLabel;
		private TextBox lastNameTb;
		private PictureBox pictureBox4;
		private TextBox emailTb;
		private PictureBox pictureBox1;
		private Label phoneNumberLabel;
		private TextBox phoneNumberTb;
		private PictureBox pictureBox2;
		private PictureBox pictureBox3;
		private DateTimePicker birthDatePicker;
		private Button editDataBtn;
	}
}