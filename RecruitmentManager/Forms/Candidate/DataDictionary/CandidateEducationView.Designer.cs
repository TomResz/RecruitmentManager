namespace RecruitmentManager.Forms.Candidate.DataDictionary
{
	partial class CandidateEducationView
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CandidateEducationView));
			DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
			toolTip1 = new ToolTip(components);
			endDateTimePicker = new DateTimePicker();
			startDateLabel = new Label();
			endDateLabel = new Label();
			beginDateTimePicker = new DateTimePicker();
			tableLayoutPanel2 = new TableLayoutPanel();
			actualCheckBox = new CheckBox();
			datesLayoutPanel = new TableLayoutPanel();
			majorPB = new PictureBox();
			schoolPB = new PictureBox();
			schoolNameTextBox = new RichTextBox();
			majorTextBox = new RichTextBox();
			TitletableLayoutPanel = new TableLayoutPanel();
			deleteBtn = new Button();
			editBtn = new Button();
			addBtn = new Button();
			buttonsTableLayoutPanel = new TableLayoutPanel();
			levelOfEduPb = new PictureBox();
			tableLayoutPanel1 = new TableLayoutPanel();
			levelOfEduComboBox = new ComboBox();
			leftLayoutPanel = new TableLayoutPanel();
			mainLayoutPanel = new TableLayoutPanel();
			educationDGV = new DataGridView();
			Id = new DataGridViewTextBoxColumn();
			SchoolNameO = new DataGridViewTextBoxColumn();
			TypeOO = new DataGridViewTextBoxColumn();
			startDate = new DataGridViewTextBoxColumn();
			DateOfCompleted = new DataGridViewTextBoxColumn();
			tableLayoutPanel2.SuspendLayout();
			datesLayoutPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)majorPB).BeginInit();
			((System.ComponentModel.ISupportInitialize)schoolPB).BeginInit();
			TitletableLayoutPanel.SuspendLayout();
			buttonsTableLayoutPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)levelOfEduPb).BeginInit();
			tableLayoutPanel1.SuspendLayout();
			leftLayoutPanel.SuspendLayout();
			mainLayoutPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)educationDGV).BeginInit();
			SuspendLayout();
			// 
			// endDateTimePicker
			// 
			endDateTimePicker.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			endDateTimePicker.CalendarFont = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
			endDateTimePicker.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
			endDateTimePicker.Location = new Point(3, 3);
			endDateTimePicker.Name = "endDateTimePicker";
			endDateTimePicker.Size = new Size(176, 30);
			endDateTimePicker.TabIndex = 3;
			// 
			// startDateLabel
			// 
			startDateLabel.AutoSize = true;
			startDateLabel.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			startDateLabel.Location = new Point(3, 0);
			startDateLabel.Name = "startDateLabel";
			startDateLabel.Size = new Size(135, 40);
			startDateLabel.TabIndex = 0;
			startDateLabel.Text = "Data rozpoczęcia:";
			// 
			// endDateLabel
			// 
			endDateLabel.AutoSize = true;
			endDateLabel.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			endDateLabel.Location = new Point(190, 0);
			endDateLabel.Name = "endDateLabel";
			endDateLabel.Size = new Size(139, 40);
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
			beginDateTimePicker.Size = new Size(181, 30);
			beginDateTimePicker.TabIndex = 2;
			// 
			// tableLayoutPanel2
			// 
			tableLayoutPanel2.ColumnCount = 1;
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel2.Controls.Add(endDateTimePicker, 0, 0);
			tableLayoutPanel2.Controls.Add(actualCheckBox, 0, 1);
			tableLayoutPanel2.Dock = DockStyle.Fill;
			tableLayoutPanel2.Location = new Point(190, 43);
			tableLayoutPanel2.Name = "tableLayoutPanel2";
			tableLayoutPanel2.RowCount = 2;
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel2.Size = new Size(182, 68);
			tableLayoutPanel2.TabIndex = 3;
			// 
			// actualCheckBox
			// 
			actualCheckBox.AutoSize = true;
			actualCheckBox.Dock = DockStyle.Fill;
			actualCheckBox.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
			actualCheckBox.Location = new Point(3, 37);
			actualCheckBox.Name = "actualCheckBox";
			actualCheckBox.Size = new Size(176, 28);
			actualCheckBox.TabIndex = 4;
			actualCheckBox.Text = "Do tej pory";
			actualCheckBox.UseVisualStyleBackColor = true;
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
			datesLayoutPanel.Location = new Point(3, 405);
			datesLayoutPanel.Name = "datesLayoutPanel";
			datesLayoutPanel.RowCount = 2;
			datesLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
			datesLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			datesLayoutPanel.Size = new Size(375, 114);
			datesLayoutPanel.TabIndex = 3;
			// 
			// majorPB
			// 
			majorPB.Dock = DockStyle.Fill;
			majorPB.Image = (Image)resources.GetObject("majorPB.Image");
			majorPB.Location = new Point(0, 97);
			majorPB.Margin = new Padding(0);
			majorPB.Name = "majorPB";
			majorPB.Size = new Size(100, 98);
			majorPB.TabIndex = 2;
			majorPB.TabStop = false;
			// 
			// schoolPB
			// 
			schoolPB.Dock = DockStyle.Fill;
			schoolPB.Image = (Image)resources.GetObject("schoolPB.Image");
			schoolPB.Location = new Point(0, 0);
			schoolPB.Margin = new Padding(0);
			schoolPB.Name = "schoolPB";
			schoolPB.Size = new Size(100, 97);
			schoolPB.TabIndex = 0;
			schoolPB.TabStop = false;
			// 
			// schoolNameTextBox
			// 
			schoolNameTextBox.BorderStyle = BorderStyle.FixedSingle;
			schoolNameTextBox.Dock = DockStyle.Fill;
			schoolNameTextBox.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
			schoolNameTextBox.Location = new Point(103, 3);
			schoolNameTextBox.Name = "schoolNameTextBox";
			schoolNameTextBox.Size = new Size(269, 91);
			schoolNameTextBox.TabIndex = 1;
			schoolNameTextBox.Text = "";
			// 
			// majorTextBox
			// 
			majorTextBox.BorderStyle = BorderStyle.FixedSingle;
			majorTextBox.Dock = DockStyle.Fill;
			majorTextBox.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			majorTextBox.Location = new Point(103, 100);
			majorTextBox.Name = "majorTextBox";
			majorTextBox.Size = new Size(269, 92);
			majorTextBox.TabIndex = 3;
			majorTextBox.Text = "";
			// 
			// TitletableLayoutPanel
			// 
			TitletableLayoutPanel.ColumnCount = 2;
			TitletableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
			TitletableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			TitletableLayoutPanel.Controls.Add(majorPB, 0, 1);
			TitletableLayoutPanel.Controls.Add(schoolPB, 0, 0);
			TitletableLayoutPanel.Controls.Add(schoolNameTextBox, 1, 0);
			TitletableLayoutPanel.Controls.Add(majorTextBox, 1, 1);
			TitletableLayoutPanel.Dock = DockStyle.Fill;
			TitletableLayoutPanel.Location = new Point(3, 3);
			TitletableLayoutPanel.Name = "TitletableLayoutPanel";
			TitletableLayoutPanel.RowCount = 2;
			TitletableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			TitletableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			TitletableLayoutPanel.Size = new Size(375, 195);
			TitletableLayoutPanel.TabIndex = 1;
			// 
			// deleteBtn
			// 
			deleteBtn.Dock = DockStyle.Fill;
			deleteBtn.FlatStyle = FlatStyle.Flat;
			deleteBtn.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			deleteBtn.Location = new Point(257, 3);
			deleteBtn.Name = "deleteBtn";
			deleteBtn.Size = new Size(121, 80);
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
			editBtn.Location = new Point(130, 3);
			editBtn.Name = "editBtn";
			editBtn.Size = new Size(121, 80);
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
			addBtn.Size = new Size(121, 80);
			addBtn.TabIndex = 0;
			addBtn.Text = "Dodaj";
			addBtn.UseVisualStyleBackColor = true;
			addBtn.Click += addBtn_Click;
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
			buttonsTableLayoutPanel.Location = new Point(0, 522);
			buttonsTableLayoutPanel.Margin = new Padding(0);
			buttonsTableLayoutPanel.Name = "buttonsTableLayoutPanel";
			buttonsTableLayoutPanel.RowCount = 1;
			buttonsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			buttonsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
			buttonsTableLayoutPanel.Size = new Size(381, 86);
			buttonsTableLayoutPanel.TabIndex = 0;
			// 
			// levelOfEduPb
			// 
			levelOfEduPb.Dock = DockStyle.Fill;
			levelOfEduPb.Image = (Image)resources.GetObject("levelOfEduPb.Image");
			levelOfEduPb.Location = new Point(0, 0);
			levelOfEduPb.Margin = new Padding(0);
			levelOfEduPb.Name = "levelOfEduPb";
			levelOfEduPb.Size = new Size(100, 195);
			levelOfEduPb.TabIndex = 0;
			levelOfEduPb.TabStop = false;
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.ColumnCount = 2;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			tableLayoutPanel1.Controls.Add(levelOfEduPb, 0, 0);
			tableLayoutPanel1.Controls.Add(levelOfEduComboBox, 1, 0);
			tableLayoutPanel1.Dock = DockStyle.Fill;
			tableLayoutPanel1.Location = new Point(3, 204);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 1;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			tableLayoutPanel1.Size = new Size(375, 195);
			tableLayoutPanel1.TabIndex = 2;
			// 
			// levelOfEduComboBox
			// 
			levelOfEduComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			levelOfEduComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
			levelOfEduComboBox.FlatStyle = FlatStyle.Flat;
			levelOfEduComboBox.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
			levelOfEduComboBox.FormattingEnabled = true;
			levelOfEduComboBox.Items.AddRange(new object[] { "Podstawowe", "Średnie", "Wyższe" });
			levelOfEduComboBox.Location = new Point(103, 3);
			levelOfEduComboBox.Name = "levelOfEduComboBox";
			levelOfEduComboBox.Size = new Size(269, 39);
			levelOfEduComboBox.TabIndex = 1;
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
			leftLayoutPanel.Size = new Size(381, 608);
			leftLayoutPanel.TabIndex = 4;
			// 
			// mainLayoutPanel
			// 
			mainLayoutPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.InsetDouble;
			mainLayoutPanel.ColumnCount = 2;
			mainLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
			mainLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
			mainLayoutPanel.Controls.Add(educationDGV, 1, 0);
			mainLayoutPanel.Controls.Add(leftLayoutPanel, 0, 0);
			mainLayoutPanel.Dock = DockStyle.Fill;
			mainLayoutPanel.Location = new Point(0, 0);
			mainLayoutPanel.Name = "mainLayoutPanel";
			mainLayoutPanel.RowCount = 1;
			mainLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			mainLayoutPanel.Size = new Size(1098, 614);
			mainLayoutPanel.TabIndex = 1;
			// 
			// educationDGV
			// 
			educationDGV.AllowUserToAddRows = false;
			educationDGV.AllowUserToDeleteRows = false;
			educationDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			educationDGV.BackgroundColor = SystemColors.Control;
			educationDGV.BorderStyle = BorderStyle.None;
			dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = Color.Blue;
			dataGridViewCellStyle1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
			dataGridViewCellStyle1.ForeColor = Color.White;
			dataGridViewCellStyle1.SelectionBackColor = Color.Blue;
			dataGridViewCellStyle1.SelectionForeColor = Color.White;
			dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
			educationDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			educationDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			educationDGV.Columns.AddRange(new DataGridViewColumn[] { Id, SchoolNameO, TypeOO, startDate, DateOfCompleted });
			educationDGV.Dock = DockStyle.Fill;
			educationDGV.EnableHeadersVisualStyles = false;
			educationDGV.Location = new Point(390, 6);
			educationDGV.MultiSelect = false;
			educationDGV.Name = "educationDGV";
			educationDGV.RowHeadersVisible = false;
			educationDGV.RowHeadersWidth = 51;
			educationDGV.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			educationDGV.RowTemplate.Height = 29;
			educationDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			educationDGV.Size = new Size(702, 602);
			educationDGV.TabIndex = 3;
			// 
			// Id
			// 
			Id.HeaderText = "ID";
			Id.MinimumWidth = 6;
			Id.Name = "Id";
			Id.ReadOnly = true;
			Id.Visible = false;
			// 
			// SchoolNameO
			// 
			SchoolNameO.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dataGridViewCellStyle2.BackColor = Color.FromArgb(128, 255, 255);
			dataGridViewCellStyle2.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			dataGridViewCellStyle2.ForeColor = Color.Black;
			dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 192, 192);
			dataGridViewCellStyle2.SelectionForeColor = Color.Black;
			SchoolNameO.DefaultCellStyle = dataGridViewCellStyle2;
			SchoolNameO.FillWeight = 230F;
			SchoolNameO.HeaderText = "Placówka Edukacyjna";
			SchoolNameO.MinimumWidth = 6;
			SchoolNameO.Name = "SchoolNameO";
			SchoolNameO.ReadOnly = true;
			// 
			// TypeOO
			// 
			dataGridViewCellStyle3.BackColor = Color.FromArgb(128, 255, 255);
			dataGridViewCellStyle3.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			dataGridViewCellStyle3.ForeColor = Color.Black;
			dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 192, 192);
			dataGridViewCellStyle3.SelectionForeColor = Color.Black;
			TypeOO.DefaultCellStyle = dataGridViewCellStyle3;
			TypeOO.HeaderText = "Typ Wykształcenia";
			TypeOO.MinimumWidth = 6;
			TypeOO.Name = "TypeOO";
			TypeOO.ReadOnly = true;
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
			// CandidateEducationView
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(mainLayoutPanel);
			Name = "CandidateEducationView";
			Size = new Size(1098, 614);
			tableLayoutPanel2.ResumeLayout(false);
			tableLayoutPanel2.PerformLayout();
			datesLayoutPanel.ResumeLayout(false);
			datesLayoutPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)majorPB).EndInit();
			((System.ComponentModel.ISupportInitialize)schoolPB).EndInit();
			TitletableLayoutPanel.ResumeLayout(false);
			buttonsTableLayoutPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)levelOfEduPb).EndInit();
			tableLayoutPanel1.ResumeLayout(false);
			leftLayoutPanel.ResumeLayout(false);
			mainLayoutPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)educationDGV).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private ToolTip toolTip1;
		private DateTimePicker endDateTimePicker;
		private Label startDateLabel;
		private Label endDateLabel;
		private DateTimePicker beginDateTimePicker;
		private TableLayoutPanel tableLayoutPanel2;
		private CheckBox actualCheckBox;
		private TableLayoutPanel datesLayoutPanel;
		private PictureBox majorPB;
		private PictureBox schoolPB;
		private RichTextBox schoolNameTextBox;
		private RichTextBox majorTextBox;
		private TableLayoutPanel TitletableLayoutPanel;
		private Button deleteBtn;
		private Button editBtn;
		private Button addBtn;
		private TableLayoutPanel buttonsTableLayoutPanel;
		private PictureBox levelOfEduPb;
		private TableLayoutPanel tableLayoutPanel1;
		private TableLayoutPanel leftLayoutPanel;
		private TableLayoutPanel mainLayoutPanel;
		private DataGridView educationDGV;
		private DataGridViewTextBoxColumn Id;
		private DataGridViewTextBoxColumn SchoolNameO;
		private DataGridViewTextBoxColumn TypeOO;
		private DataGridViewTextBoxColumn startDate;
		private DataGridViewTextBoxColumn DateOfCompleted;
		private ComboBox levelOfEduComboBox;
	}
}
