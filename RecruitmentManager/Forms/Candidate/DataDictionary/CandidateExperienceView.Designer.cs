namespace RecruitmentManager.Forms.Candidate.DataDictionary
{
	partial class CandidateExperienceView
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CandidateExperienceView));
			mainLayoutPanel = new TableLayoutPanel();
			experienceDGV = new DataGridView();
			Id = new DataGridViewTextBoxColumn();
			NameOfWorkPlace = new DataGridViewTextBoxColumn();
			NameOfPosition = new DataGridViewTextBoxColumn();
			startDate = new DataGridViewTextBoxColumn();
			DateOfCompleted = new DataGridViewTextBoxColumn();
			leftLayoutPanel = new TableLayoutPanel();
			tableLayoutPanel1 = new TableLayoutPanel();
			descriptionPb = new PictureBox();
			descriptionTextBox = new RichTextBox();
			buttonsTableLayoutPanel = new TableLayoutPanel();
			deleteBtn = new Button();
			editBtn = new Button();
			addBtn = new Button();
			TitletableLayoutPanel = new TableLayoutPanel();
			companyNamePB = new PictureBox();
			titlePB = new PictureBox();
			titleTextBox = new RichTextBox();
			companyNameTextBox = new RichTextBox();
			datesLayoutPanel = new TableLayoutPanel();
			startDateLabel = new Label();
			endDateLabel = new Label();
			beginDateTimePicker = new DateTimePicker();
			tableLayoutPanel2 = new TableLayoutPanel();
			endDateTimePicker = new DateTimePicker();
			actualCheckBox = new CheckBox();
			toolTip1 = new ToolTip(components);
			mainLayoutPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)experienceDGV).BeginInit();
			leftLayoutPanel.SuspendLayout();
			tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)descriptionPb).BeginInit();
			buttonsTableLayoutPanel.SuspendLayout();
			TitletableLayoutPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)companyNamePB).BeginInit();
			((System.ComponentModel.ISupportInitialize)titlePB).BeginInit();
			datesLayoutPanel.SuspendLayout();
			tableLayoutPanel2.SuspendLayout();
			SuspendLayout();
			// 
			// mainLayoutPanel
			// 
			mainLayoutPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.InsetDouble;
			mainLayoutPanel.ColumnCount = 2;
			mainLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			mainLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			mainLayoutPanel.Controls.Add(experienceDGV, 1, 0);
			mainLayoutPanel.Controls.Add(leftLayoutPanel, 0, 0);
			mainLayoutPanel.Dock = DockStyle.Fill;
			mainLayoutPanel.Location = new Point(0, 0);
			mainLayoutPanel.Name = "mainLayoutPanel";
			mainLayoutPanel.RowCount = 1;
			mainLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			mainLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
			mainLayoutPanel.Size = new Size(1216, 561);
			mainLayoutPanel.TabIndex = 0;
			// 
			// experienceDGV
			// 
			experienceDGV.AllowUserToAddRows = false;
			experienceDGV.AllowUserToDeleteRows = false;
			experienceDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			experienceDGV.BackgroundColor = SystemColors.Control;
			experienceDGV.BorderStyle = BorderStyle.None;
			dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = Color.Blue;
			dataGridViewCellStyle1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
			dataGridViewCellStyle1.ForeColor = Color.White;
			dataGridViewCellStyle1.SelectionBackColor = Color.Blue;
			dataGridViewCellStyle1.SelectionForeColor = Color.White;
			dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
			experienceDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			experienceDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			experienceDGV.Columns.AddRange(new DataGridViewColumn[] { Id, NameOfWorkPlace, NameOfPosition, startDate, DateOfCompleted });
			experienceDGV.Dock = DockStyle.Fill;
			experienceDGV.EnableHeadersVisualStyles = false;
			experienceDGV.Location = new Point(612, 6);
			experienceDGV.MultiSelect = false;
			experienceDGV.Name = "experienceDGV";
			experienceDGV.RowHeadersVisible = false;
			experienceDGV.RowHeadersWidth = 51;
			experienceDGV.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			experienceDGV.RowTemplate.Height = 29;
			experienceDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			experienceDGV.Size = new Size(598, 549);
			experienceDGV.TabIndex = 3;
			// 
			// Id
			// 
			Id.HeaderText = "ID";
			Id.MinimumWidth = 6;
			Id.Name = "Id";
			Id.ReadOnly = true;
			Id.Visible = false;
			// 
			// NameOfWorkPlace
			// 
			NameOfWorkPlace.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dataGridViewCellStyle2.BackColor = Color.FromArgb(128, 255, 255);
			dataGridViewCellStyle2.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			dataGridViewCellStyle2.ForeColor = Color.Black;
			dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 192, 192);
			dataGridViewCellStyle2.SelectionForeColor = Color.Black;
			NameOfWorkPlace.DefaultCellStyle = dataGridViewCellStyle2;
			NameOfWorkPlace.FillWeight = 230F;
			NameOfWorkPlace.HeaderText = "Stanowisko";
			NameOfWorkPlace.MinimumWidth = 6;
			NameOfWorkPlace.Name = "NameOfWorkPlace";
			NameOfWorkPlace.ReadOnly = true;
			// 
			// NameOfPosition
			// 
			dataGridViewCellStyle3.BackColor = Color.FromArgb(128, 255, 255);
			dataGridViewCellStyle3.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			dataGridViewCellStyle3.ForeColor = Color.Black;
			dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 192, 192);
			dataGridViewCellStyle3.SelectionForeColor = Color.Black;
			NameOfPosition.DefaultCellStyle = dataGridViewCellStyle3;
			NameOfPosition.HeaderText = "Nazwa Firmy";
			NameOfPosition.MinimumWidth = 6;
			NameOfPosition.Name = "NameOfPosition";
			NameOfPosition.ReadOnly = true;
			// 
			// startDate
			// 
			dataGridViewCellStyle4.BackColor = Color.FromArgb(128, 255, 255);
			dataGridViewCellStyle4.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			dataGridViewCellStyle4.ForeColor = Color.Black;
			dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(0, 192, 192);
			dataGridViewCellStyle4.SelectionForeColor = Color.Black;
			startDate.DefaultCellStyle = dataGridViewCellStyle4;
			startDate.HeaderText = "Data rozpoczęcia";
			startDate.MinimumWidth = 6;
			startDate.Name = "startDate";
			startDate.ReadOnly = true;
			// 
			// DateOfCompleted
			// 
			dataGridViewCellStyle5.BackColor = Color.FromArgb(128, 255, 255);
			dataGridViewCellStyle5.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			dataGridViewCellStyle5.ForeColor = Color.Black;
			dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(0, 192, 192);
			dataGridViewCellStyle5.SelectionForeColor = Color.Black;
			DateOfCompleted.DefaultCellStyle = dataGridViewCellStyle5;
			DateOfCompleted.HeaderText = "Data Zakończenia";
			DateOfCompleted.MinimumWidth = 6;
			DateOfCompleted.Name = "DateOfCompleted";
			DateOfCompleted.ReadOnly = true;
			// 
			// leftLayoutPanel
			// 
			leftLayoutPanel.ColumnCount = 1;
			leftLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			leftLayoutPanel.Controls.Add(tableLayoutPanel1, 0, 1);
			leftLayoutPanel.Controls.Add(buttonsTableLayoutPanel, 0, 3);
			leftLayoutPanel.Controls.Add(TitletableLayoutPanel, 0, 0);
			leftLayoutPanel.Controls.Add(datesLayoutPanel, 0, 2);
			leftLayoutPanel.Dock = DockStyle.Fill;
			leftLayoutPanel.Location = new Point(3, 3);
			leftLayoutPanel.Margin = new Padding(0);
			leftLayoutPanel.Name = "leftLayoutPanel";
			leftLayoutPanel.RowCount = 4;
			leftLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			leftLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			leftLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 120F));
			leftLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 85F));
			leftLayoutPanel.Size = new Size(603, 555);
			leftLayoutPanel.TabIndex = 4;
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.ColumnCount = 2;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			tableLayoutPanel1.Controls.Add(descriptionPb, 0, 0);
			tableLayoutPanel1.Controls.Add(descriptionTextBox, 1, 0);
			tableLayoutPanel1.Dock = DockStyle.Fill;
			tableLayoutPanel1.Location = new Point(3, 178);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 1;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			tableLayoutPanel1.Size = new Size(597, 169);
			tableLayoutPanel1.TabIndex = 2;
			// 
			// descriptionPb
			// 
			descriptionPb.Dock = DockStyle.Fill;
			descriptionPb.Image = (Image)resources.GetObject("descriptionPb.Image");
			descriptionPb.Location = new Point(0, 0);
			descriptionPb.Margin = new Padding(0);
			descriptionPb.Name = "descriptionPb";
			descriptionPb.Size = new Size(100, 169);
			descriptionPb.TabIndex = 0;
			descriptionPb.TabStop = false;
			// 
			// descriptionTextBox
			// 
			descriptionTextBox.BorderStyle = BorderStyle.FixedSingle;
			descriptionTextBox.Dock = DockStyle.Fill;
			descriptionTextBox.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
			descriptionTextBox.Location = new Point(103, 3);
			descriptionTextBox.Name = "descriptionTextBox";
			descriptionTextBox.Size = new Size(491, 163);
			descriptionTextBox.TabIndex = 1;
			descriptionTextBox.Text = "";
			// 
			// buttonsTableLayoutPanel
			// 
			buttonsTableLayoutPanel.ColumnCount = 3;
			buttonsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
			buttonsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
			buttonsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
			buttonsTableLayoutPanel.Controls.Add(deleteBtn, 2, 0);
			buttonsTableLayoutPanel.Controls.Add(editBtn, 1, 0);
			buttonsTableLayoutPanel.Controls.Add(addBtn, 0, 0);
			buttonsTableLayoutPanel.Dock = DockStyle.Fill;
			buttonsTableLayoutPanel.Location = new Point(0, 470);
			buttonsTableLayoutPanel.Margin = new Padding(0);
			buttonsTableLayoutPanel.Name = "buttonsTableLayoutPanel";
			buttonsTableLayoutPanel.RowCount = 1;
			buttonsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			buttonsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
			buttonsTableLayoutPanel.Size = new Size(603, 85);
			buttonsTableLayoutPanel.TabIndex = 0;
			// 
			// deleteBtn
			// 
			deleteBtn.Dock = DockStyle.Fill;
			deleteBtn.FlatStyle = FlatStyle.Flat;
			deleteBtn.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			deleteBtn.Location = new Point(405, 3);
			deleteBtn.Name = "deleteBtn";
			deleteBtn.Size = new Size(195, 79);
			deleteBtn.TabIndex = 2;
			deleteBtn.Text = "Usuń";
			deleteBtn.UseVisualStyleBackColor = true;
			deleteBtn.Click += deleteBtn_Click;
			// 
			// editBtn
			// 
			editBtn.Dock = DockStyle.Fill;
			editBtn.FlatStyle = FlatStyle.Flat;
			editBtn.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			editBtn.Location = new Point(204, 3);
			editBtn.Name = "editBtn";
			editBtn.Size = new Size(195, 79);
			editBtn.TabIndex = 1;
			editBtn.Text = "Edytuj";
			editBtn.UseVisualStyleBackColor = true;
			editBtn.Click += editBtn_Click;
			// 
			// addBtn
			// 
			addBtn.Dock = DockStyle.Fill;
			addBtn.FlatStyle = FlatStyle.Flat;
			addBtn.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			addBtn.Location = new Point(3, 3);
			addBtn.Name = "addBtn";
			addBtn.Size = new Size(195, 79);
			addBtn.TabIndex = 0;
			addBtn.Text = "Dodaj";
			addBtn.UseVisualStyleBackColor = true;
			addBtn.Click += addBtn_Click;
			// 
			// TitletableLayoutPanel
			// 
			TitletableLayoutPanel.ColumnCount = 2;
			TitletableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
			TitletableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			TitletableLayoutPanel.Controls.Add(companyNamePB, 0, 1);
			TitletableLayoutPanel.Controls.Add(titlePB, 0, 0);
			TitletableLayoutPanel.Controls.Add(titleTextBox, 1, 0);
			TitletableLayoutPanel.Controls.Add(companyNameTextBox, 1, 1);
			TitletableLayoutPanel.Dock = DockStyle.Fill;
			TitletableLayoutPanel.Location = new Point(3, 3);
			TitletableLayoutPanel.Name = "TitletableLayoutPanel";
			TitletableLayoutPanel.RowCount = 2;
			TitletableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			TitletableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			TitletableLayoutPanel.Size = new Size(597, 169);
			TitletableLayoutPanel.TabIndex = 1;
			// 
			// companyNamePB
			// 
			companyNamePB.Dock = DockStyle.Fill;
			companyNamePB.Image = (Image)resources.GetObject("companyNamePB.Image");
			companyNamePB.Location = new Point(0, 84);
			companyNamePB.Margin = new Padding(0);
			companyNamePB.Name = "companyNamePB";
			companyNamePB.Size = new Size(100, 85);
			companyNamePB.TabIndex = 2;
			companyNamePB.TabStop = false;
			// 
			// titlePB
			// 
			titlePB.Dock = DockStyle.Fill;
			titlePB.Image = (Image)resources.GetObject("titlePB.Image");
			titlePB.Location = new Point(0, 0);
			titlePB.Margin = new Padding(0);
			titlePB.Name = "titlePB";
			titlePB.Size = new Size(100, 84);
			titlePB.TabIndex = 0;
			titlePB.TabStop = false;
			// 
			// titleTextBox
			// 
			titleTextBox.BorderStyle = BorderStyle.FixedSingle;
			titleTextBox.Dock = DockStyle.Fill;
			titleTextBox.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
			titleTextBox.Location = new Point(103, 3);
			titleTextBox.Name = "titleTextBox";
			titleTextBox.Size = new Size(491, 78);
			titleTextBox.TabIndex = 1;
			titleTextBox.Text = "";
			// 
			// companyNameTextBox
			// 
			companyNameTextBox.BorderStyle = BorderStyle.FixedSingle;
			companyNameTextBox.Dock = DockStyle.Fill;
			companyNameTextBox.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			companyNameTextBox.Location = new Point(103, 87);
			companyNameTextBox.Name = "companyNameTextBox";
			companyNameTextBox.Size = new Size(491, 79);
			companyNameTextBox.TabIndex = 3;
			companyNameTextBox.Text = "";
			// 
			// datesLayoutPanel
			// 
			datesLayoutPanel.ColumnCount = 2;
			datesLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			datesLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			datesLayoutPanel.Controls.Add(startDateLabel, 0, 0);
			datesLayoutPanel.Controls.Add(endDateLabel, 1, 0);
			datesLayoutPanel.Controls.Add(beginDateTimePicker, 0, 1);
			datesLayoutPanel.Controls.Add(tableLayoutPanel2, 1, 1);
			datesLayoutPanel.Dock = DockStyle.Fill;
			datesLayoutPanel.Location = new Point(3, 353);
			datesLayoutPanel.Name = "datesLayoutPanel";
			datesLayoutPanel.RowCount = 2;
			datesLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
			datesLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			datesLayoutPanel.Size = new Size(597, 114);
			datesLayoutPanel.TabIndex = 3;
			// 
			// startDateLabel
			// 
			startDateLabel.AutoSize = true;
			startDateLabel.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			startDateLabel.Location = new Point(3, 0);
			startDateLabel.Name = "startDateLabel";
			startDateLabel.Size = new Size(190, 25);
			startDateLabel.TabIndex = 0;
			startDateLabel.Text = "Data rozpoczęcia:";
			// 
			// endDateLabel
			// 
			endDateLabel.AutoSize = true;
			endDateLabel.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			endDateLabel.Location = new Point(301, 0);
			endDateLabel.Name = "endDateLabel";
			endDateLabel.Size = new Size(194, 25);
			endDateLabel.TabIndex = 1;
			endDateLabel.Text = "Data zakończenia:";
			// 
			// beginDateTimePicker
			// 
			beginDateTimePicker.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			beginDateTimePicker.CalendarFont = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
			beginDateTimePicker.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
			beginDateTimePicker.Location = new Point(3, 43);
			beginDateTimePicker.Name = "beginDateTimePicker";
			beginDateTimePicker.Size = new Size(292, 30);
			beginDateTimePicker.TabIndex = 2;
			// 
			// tableLayoutPanel2
			// 
			tableLayoutPanel2.ColumnCount = 1;
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel2.Controls.Add(endDateTimePicker, 0, 0);
			tableLayoutPanel2.Controls.Add(actualCheckBox, 0, 1);
			tableLayoutPanel2.Dock = DockStyle.Fill;
			tableLayoutPanel2.Location = new Point(301, 43);
			tableLayoutPanel2.Name = "tableLayoutPanel2";
			tableLayoutPanel2.RowCount = 2;
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel2.Size = new Size(293, 68);
			tableLayoutPanel2.TabIndex = 3;
			// 
			// endDateTimePicker
			// 
			endDateTimePicker.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			endDateTimePicker.CalendarFont = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
			endDateTimePicker.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
			endDateTimePicker.Location = new Point(3, 3);
			endDateTimePicker.Name = "endDateTimePicker";
			endDateTimePicker.Size = new Size(287, 30);
			endDateTimePicker.TabIndex = 3;
			// 
			// actualCheckBox
			// 
			actualCheckBox.AutoSize = true;
			actualCheckBox.Dock = DockStyle.Fill;
			actualCheckBox.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
			actualCheckBox.Location = new Point(3, 37);
			actualCheckBox.Name = "actualCheckBox";
			actualCheckBox.Size = new Size(287, 28);
			actualCheckBox.TabIndex = 4;
			actualCheckBox.Text = "Do tej pory";
			actualCheckBox.UseVisualStyleBackColor = true;
			// 
			// CandidateExperienceView
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(mainLayoutPanel);
			Name = "CandidateExperienceView";
			Size = new Size(1216, 561);
			mainLayoutPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)experienceDGV).EndInit();
			leftLayoutPanel.ResumeLayout(false);
			tableLayoutPanel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)descriptionPb).EndInit();
			buttonsTableLayoutPanel.ResumeLayout(false);
			TitletableLayoutPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)companyNamePB).EndInit();
			((System.ComponentModel.ISupportInitialize)titlePB).EndInit();
			datesLayoutPanel.ResumeLayout(false);
			datesLayoutPanel.PerformLayout();
			tableLayoutPanel2.ResumeLayout(false);
			tableLayoutPanel2.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private TableLayoutPanel mainLayoutPanel;
		private DataGridView experienceDGV;
		private TableLayoutPanel leftLayoutPanel;
		private TableLayoutPanel buttonsTableLayoutPanel;
		private Button deleteBtn;
		private Button editBtn;
		private TableLayoutPanel TitletableLayoutPanel;
		private PictureBox titlePB;
		private RichTextBox titleTextBox;
		private TableLayoutPanel tableLayoutPanel1;
		private PictureBox descriptionPb;
		private RichTextBox descriptionTextBox;
		private ToolTip toolTip1;
		private TableLayoutPanel datesLayoutPanel;
		private Label startDateLabel;
		private Label endDateLabel;
		private DateTimePicker beginDateTimePicker;
		private TableLayoutPanel tableLayoutPanel2;
		private DateTimePicker endDateTimePicker;
		private CheckBox actualCheckBox;
		private Button addBtn;
		private PictureBox companyNamePB;
		private RichTextBox companyNameTextBox;
		private DataGridViewTextBoxColumn Id;
		private DataGridViewTextBoxColumn NameOfWorkPlace;
		private DataGridViewTextBoxColumn NameOfPosition;
		private DataGridViewTextBoxColumn startDate;
		private DataGridViewTextBoxColumn DateOfCompleted;
	}
}
