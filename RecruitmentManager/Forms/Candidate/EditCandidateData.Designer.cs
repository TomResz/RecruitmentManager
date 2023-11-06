namespace RecruitmentManager.Forms.Candidate
{
	partial class EditCandidateData
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditCandidateData));
			editDataBtn = new Button();
			birthDatePicker = new DateTimePicker();
			birthDatePB = new PictureBox();
			phoneNumberLabel = new Label();
			phoneNumberTb = new TextBox();
			phoneNumberPB = new PictureBox();
			firstNameLabel = new Label();
			firstNameTb = new TextBox();
			firstNamePb = new PictureBox();
			lastNameLabel = new Label();
			lastNameTb = new TextBox();
			lastNamePB = new PictureBox();
			emailTb = new TextBox();
			emailPB = new PictureBox();
			cityLabel = new Label();
			cityTb = new TextBox();
			cityPB = new PictureBox();
			setProfilePictureBtn = new Button();
			profilePicturePB = new PictureBox();
			toolTip1 = new ToolTip(components);
			((System.ComponentModel.ISupportInitialize)birthDatePB).BeginInit();
			((System.ComponentModel.ISupportInitialize)phoneNumberPB).BeginInit();
			((System.ComponentModel.ISupportInitialize)firstNamePb).BeginInit();
			((System.ComponentModel.ISupportInitialize)lastNamePB).BeginInit();
			((System.ComponentModel.ISupportInitialize)emailPB).BeginInit();
			((System.ComponentModel.ISupportInitialize)cityPB).BeginInit();
			((System.ComponentModel.ISupportInitialize)profilePicturePB).BeginInit();
			SuspendLayout();
			// 
			// editDataBtn
			// 
			editDataBtn.FlatStyle = FlatStyle.Flat;
			editDataBtn.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
			editDataBtn.Location = new Point(12, 285);
			editDataBtn.Name = "editDataBtn";
			editDataBtn.Size = new Size(515, 66);
			editDataBtn.TabIndex = 70;
			editDataBtn.Text = "Edytuj Dane";
			editDataBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
			editDataBtn.UseVisualStyleBackColor = true;
			editDataBtn.Click += editDataBtn_Click;
			// 
			// birthDatePicker
			// 
			birthDatePicker.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
			birthDatePicker.Format = DateTimePickerFormat.Short;
			birthDatePicker.Location = new Point(106, 211);
			birthDatePicker.Name = "birthDatePicker";
			birthDatePicker.Size = new Size(421, 30);
			birthDatePicker.TabIndex = 69;
			// 
			// birthDatePB
			// 
			birthDatePB.Image = (Image)resources.GetObject("birthDatePB.Image");
			birthDatePB.Location = new Point(12, 186);
			birthDatePB.Name = "birthDatePB";
			birthDatePB.Size = new Size(88, 81);
			birthDatePB.TabIndex = 68;
			birthDatePB.TabStop = false;
			// 
			// phoneNumberLabel
			// 
			phoneNumberLabel.AutoSize = true;
			phoneNumberLabel.Enabled = false;
			phoneNumberLabel.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
			phoneNumberLabel.Location = new Point(649, 126);
			phoneNumberLabel.Name = "phoneNumberLabel";
			phoneNumberLabel.Size = new Size(85, 34);
			phoneNumberLabel.TabIndex = 67;
			phoneNumberLabel.Text = "label1";
			// 
			// phoneNumberTb
			// 
			phoneNumberTb.BackColor = SystemColors.Control;
			phoneNumberTb.BorderStyle = BorderStyle.FixedSingle;
			phoneNumberTb.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
			phoneNumberTb.Location = new Point(639, 124);
			phoneNumberTb.Name = "phoneNumberTb";
			phoneNumberTb.Size = new Size(421, 42);
			phoneNumberTb.TabIndex = 66;
			phoneNumberTb.TextChanged += phoneNumberTb_TextChanged;
			// 
			// phoneNumberPB
			// 
			phoneNumberPB.Image = (Image)resources.GetObject("phoneNumberPB.Image");
			phoneNumberPB.Location = new Point(545, 99);
			phoneNumberPB.Name = "phoneNumberPB";
			phoneNumberPB.Size = new Size(88, 81);
			phoneNumberPB.TabIndex = 65;
			phoneNumberPB.TabStop = false;
			// 
			// firstNameLabel
			// 
			firstNameLabel.AutoSize = true;
			firstNameLabel.Enabled = false;
			firstNameLabel.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
			firstNameLabel.Location = new Point(116, 39);
			firstNameLabel.Name = "firstNameLabel";
			firstNameLabel.Size = new Size(85, 34);
			firstNameLabel.TabIndex = 64;
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
			firstNameTb.TabIndex = 63;
			firstNameTb.TextChanged += firstNameTb_TextChanged;
			// 
			// firstNamePb
			// 
			firstNamePb.Image = (Image)resources.GetObject("firstNamePb.Image");
			firstNamePb.Location = new Point(12, 12);
			firstNamePb.Name = "firstNamePb";
			firstNamePb.Size = new Size(88, 81);
			firstNamePb.TabIndex = 62;
			firstNamePb.TabStop = false;
			// 
			// lastNameLabel
			// 
			lastNameLabel.AutoSize = true;
			lastNameLabel.Enabled = false;
			lastNameLabel.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
			lastNameLabel.Location = new Point(116, 126);
			lastNameLabel.Name = "lastNameLabel";
			lastNameLabel.Size = new Size(85, 34);
			lastNameLabel.TabIndex = 61;
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
			lastNameTb.TabIndex = 60;
			lastNameTb.TextChanged += lastNameTb_TextChanged;
			// 
			// lastNamePB
			// 
			lastNamePB.Image = (Image)resources.GetObject("lastNamePB.Image");
			lastNamePB.Location = new Point(12, 99);
			lastNamePB.Name = "lastNamePB";
			lastNamePB.Size = new Size(88, 81);
			lastNamePB.TabIndex = 59;
			lastNamePB.TabStop = false;
			// 
			// emailTb
			// 
			emailTb.BackColor = SystemColors.Control;
			emailTb.BorderStyle = BorderStyle.FixedSingle;
			emailTb.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
			emailTb.Location = new Point(639, 37);
			emailTb.Name = "emailTb";
			emailTb.Size = new Size(421, 42);
			emailTb.TabIndex = 58;
			// 
			// emailPB
			// 
			emailPB.Image = (Image)resources.GetObject("emailPB.Image");
			emailPB.Location = new Point(545, 12);
			emailPB.Name = "emailPB";
			emailPB.Size = new Size(88, 81);
			emailPB.TabIndex = 57;
			emailPB.TabStop = false;
			// 
			// cityLabel
			// 
			cityLabel.AutoSize = true;
			cityLabel.Enabled = false;
			cityLabel.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
			cityLabel.Location = new Point(649, 213);
			cityLabel.Name = "cityLabel";
			cityLabel.Size = new Size(85, 34);
			cityLabel.TabIndex = 73;
			cityLabel.Text = "label1";
			// 
			// cityTb
			// 
			cityTb.BackColor = SystemColors.Control;
			cityTb.BorderStyle = BorderStyle.FixedSingle;
			cityTb.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
			cityTb.Location = new Point(639, 211);
			cityTb.Name = "cityTb";
			cityTb.Size = new Size(421, 42);
			cityTb.TabIndex = 72;
			cityTb.TextChanged += cityTb_TextChanged;
			// 
			// cityPB
			// 
			cityPB.Image = (Image)resources.GetObject("cityPB.Image");
			cityPB.Location = new Point(545, 186);
			cityPB.Name = "cityPB";
			cityPB.Size = new Size(88, 81);
			cityPB.TabIndex = 71;
			cityPB.TabStop = false;
			// 
			// setProfilePictureBtn
			// 
			setProfilePictureBtn.FlatStyle = FlatStyle.Flat;
			setProfilePictureBtn.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
			setProfilePictureBtn.Location = new Point(545, 285);
			setProfilePictureBtn.Name = "setProfilePictureBtn";
			setProfilePictureBtn.Size = new Size(515, 66);
			setProfilePictureBtn.TabIndex = 74;
			setProfilePictureBtn.Text = "Wybierz zdjęcie";
			setProfilePictureBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
			setProfilePictureBtn.UseVisualStyleBackColor = true;
			setProfilePictureBtn.Click += button1_Click;
			// 
			// profilePicturePB
			// 
			profilePicturePB.BorderStyle = BorderStyle.Fixed3D;
			profilePicturePB.Location = new Point(1076, 37);
			profilePicturePB.Margin = new Padding(0);
			profilePicturePB.Name = "profilePicturePB";
			profilePicturePB.Size = new Size(316, 311);
			profilePicturePB.SizeMode = PictureBoxSizeMode.Zoom;
			profilePicturePB.TabIndex = 75;
			profilePicturePB.TabStop = false;
			profilePicturePB.Click += profilePicturePB_Click;
			// 
			// EditCandidateData
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1401, 357);
			Controls.Add(profilePicturePB);
			Controls.Add(setProfilePictureBtn);
			Controls.Add(cityLabel);
			Controls.Add(cityTb);
			Controls.Add(cityPB);
			Controls.Add(editDataBtn);
			Controls.Add(birthDatePicker);
			Controls.Add(birthDatePB);
			Controls.Add(phoneNumberLabel);
			Controls.Add(phoneNumberTb);
			Controls.Add(phoneNumberPB);
			Controls.Add(firstNameLabel);
			Controls.Add(firstNameTb);
			Controls.Add(firstNamePb);
			Controls.Add(lastNameLabel);
			Controls.Add(lastNameTb);
			Controls.Add(lastNamePB);
			Controls.Add(emailTb);
			Controls.Add(emailPB);
			MaximumSize = new Size(1419, 404);
			MinimumSize = new Size(1419, 404);
			Name = "EditCandidateData";
			Text = "Edytuj Dane";
			((System.ComponentModel.ISupportInitialize)birthDatePB).EndInit();
			((System.ComponentModel.ISupportInitialize)phoneNumberPB).EndInit();
			((System.ComponentModel.ISupportInitialize)firstNamePb).EndInit();
			((System.ComponentModel.ISupportInitialize)lastNamePB).EndInit();
			((System.ComponentModel.ISupportInitialize)emailPB).EndInit();
			((System.ComponentModel.ISupportInitialize)cityPB).EndInit();
			((System.ComponentModel.ISupportInitialize)profilePicturePB).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button editDataBtn;
		private DateTimePicker birthDatePicker;
		private PictureBox birthDatePB;
		private Label phoneNumberLabel;
		private TextBox phoneNumberTb;
		private PictureBox phoneNumberPB;
		private Label firstNameLabel;
		private TextBox firstNameTb;
		private PictureBox firstNamePb;
		private Label lastNameLabel;
		private TextBox lastNameTb;
		private PictureBox lastNamePB;
		private TextBox emailTb;
		private PictureBox emailPB;
		private Label cityLabel;
		private TextBox cityTb;
		private PictureBox cityPB;
		private Button setProfilePictureBtn;
		private PictureBox profilePicturePB;
		private ToolTip toolTip1;
	}
}