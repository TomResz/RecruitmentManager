namespace RecruitmentManager.Forms.Candidate.DataDictionary
{
	partial class CandidateHobbyView
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
			DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CandidateHobbyView));
			tableLayoutPanel = new TableLayoutPanel();
			hobbiesDGV = new DataGridView();
			dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
			DescriptionO = new DataGridViewTextBoxColumn();
			leftTableLayout = new TableLayoutPanel();
			buttonTableLayout = new TableLayoutPanel();
			deleteBtn = new Button();
			editBtn = new Button();
			addBtn = new Button();
			tableLayoutPanel1 = new TableLayoutPanel();
			descriptionPB = new PictureBox();
			descriptionTextBox = new RichTextBox();
			tableLayoutPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)hobbiesDGV).BeginInit();
			leftTableLayout.SuspendLayout();
			buttonTableLayout.SuspendLayout();
			tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)descriptionPB).BeginInit();
			SuspendLayout();
			// 
			// tableLayoutPanel
			// 
			tableLayoutPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.InsetDouble;
			tableLayoutPanel.ColumnCount = 2;
			tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel.Controls.Add(hobbiesDGV, 1, 0);
			tableLayoutPanel.Controls.Add(leftTableLayout, 0, 0);
			tableLayoutPanel.Dock = DockStyle.Fill;
			tableLayoutPanel.Location = new Point(0, 0);
			tableLayoutPanel.Name = "tableLayoutPanel";
			tableLayoutPanel.RowCount = 1;
			tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel.Size = new Size(1196, 582);
			tableLayoutPanel.TabIndex = 0;
			tableLayoutPanel.Paint += tableLayoutPanel_Paint;
			// 
			// hobbiesDGV
			// 
			hobbiesDGV.AllowUserToAddRows = false;
			hobbiesDGV.AllowUserToDeleteRows = false;
			hobbiesDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			hobbiesDGV.BackgroundColor = SystemColors.Control;
			hobbiesDGV.BorderStyle = BorderStyle.None;
			dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = Color.Blue;
			dataGridViewCellStyle1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
			dataGridViewCellStyle1.ForeColor = Color.White;
			dataGridViewCellStyle1.SelectionBackColor = Color.Blue;
			dataGridViewCellStyle1.SelectionForeColor = Color.White;
			dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
			hobbiesDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			hobbiesDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			hobbiesDGV.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, DescriptionO });
			hobbiesDGV.Dock = DockStyle.Fill;
			hobbiesDGV.EnableHeadersVisualStyles = false;
			hobbiesDGV.Location = new Point(602, 6);
			hobbiesDGV.MultiSelect = false;
			hobbiesDGV.Name = "hobbiesDGV";
			hobbiesDGV.RowHeadersVisible = false;
			hobbiesDGV.RowHeadersWidth = 51;
			hobbiesDGV.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			hobbiesDGV.RowTemplate.Height = 29;
			hobbiesDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			hobbiesDGV.Size = new Size(588, 570);
			hobbiesDGV.TabIndex = 7;
			hobbiesDGV.CellContentClick += hobbiesDGV_CellContentClick;
			// 
			// dataGridViewTextBoxColumn1
			// 
			dataGridViewTextBoxColumn1.HeaderText = "ID";
			dataGridViewTextBoxColumn1.MinimumWidth = 6;
			dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			dataGridViewTextBoxColumn1.ReadOnly = true;
			dataGridViewTextBoxColumn1.Visible = false;
			// 
			// DescriptionO
			// 
			DescriptionO.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dataGridViewCellStyle2.BackColor = Color.FromArgb(128, 255, 255);
			dataGridViewCellStyle2.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			dataGridViewCellStyle2.ForeColor = Color.Black;
			dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 192, 192);
			dataGridViewCellStyle2.SelectionForeColor = Color.Black;
			DescriptionO.DefaultCellStyle = dataGridViewCellStyle2;
			DescriptionO.FillWeight = 230F;
			DescriptionO.HeaderText = "Opis";
			DescriptionO.MinimumWidth = 6;
			DescriptionO.Name = "DescriptionO";
			DescriptionO.ReadOnly = true;
			// 
			// leftTableLayout
			// 
			leftTableLayout.ColumnCount = 1;
			leftTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			leftTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
			leftTableLayout.Controls.Add(buttonTableLayout, 0, 1);
			leftTableLayout.Controls.Add(tableLayoutPanel1, 0, 0);
			leftTableLayout.Dock = DockStyle.Fill;
			leftTableLayout.Location = new Point(6, 6);
			leftTableLayout.Name = "leftTableLayout";
			leftTableLayout.RowCount = 2;
			leftTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			leftTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 85F));
			leftTableLayout.Size = new Size(587, 570);
			leftTableLayout.TabIndex = 8;
			leftTableLayout.Paint += leftTableLayout_Paint;
			// 
			// buttonTableLayout
			// 
			buttonTableLayout.ColumnCount = 3;
			buttonTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
			buttonTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
			buttonTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
			buttonTableLayout.Controls.Add(deleteBtn, 2, 0);
			buttonTableLayout.Controls.Add(editBtn, 1, 0);
			buttonTableLayout.Controls.Add(addBtn, 0, 0);
			buttonTableLayout.Dock = DockStyle.Fill;
			buttonTableLayout.Location = new Point(3, 488);
			buttonTableLayout.Name = "buttonTableLayout";
			buttonTableLayout.RowCount = 1;
			buttonTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			buttonTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
			buttonTableLayout.Size = new Size(581, 79);
			buttonTableLayout.TabIndex = 0;
			buttonTableLayout.Paint += buttonTableLayout_Paint;
			// 
			// deleteBtn
			// 
			deleteBtn.Dock = DockStyle.Fill;
			deleteBtn.FlatStyle = FlatStyle.Flat;
			deleteBtn.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
			deleteBtn.Location = new Point(389, 3);
			deleteBtn.Name = "deleteBtn";
			deleteBtn.Size = new Size(189, 73);
			deleteBtn.TabIndex = 2;
			deleteBtn.Text = "Usuń";
			deleteBtn.UseVisualStyleBackColor = true;
			deleteBtn.Click += deleteBtn_Click;
			// 
			// editBtn
			// 
			editBtn.Dock = DockStyle.Fill;
			editBtn.FlatStyle = FlatStyle.Flat;
			editBtn.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
			editBtn.Location = new Point(196, 3);
			editBtn.Name = "editBtn";
			editBtn.Size = new Size(187, 73);
			editBtn.TabIndex = 1;
			editBtn.Text = "Edytuj";
			editBtn.UseVisualStyleBackColor = true;
			editBtn.Click += editBtn_Click;
			// 
			// addBtn
			// 
			addBtn.Dock = DockStyle.Fill;
			addBtn.FlatStyle = FlatStyle.Flat;
			addBtn.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
			addBtn.Location = new Point(3, 3);
			addBtn.Name = "addBtn";
			addBtn.Size = new Size(187, 73);
			addBtn.TabIndex = 0;
			addBtn.Text = "Dodaj";
			addBtn.UseVisualStyleBackColor = true;
			addBtn.Click += addBtn_Click;
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.ColumnCount = 2;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 85F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			tableLayoutPanel1.Controls.Add(descriptionPB, 0, 0);
			tableLayoutPanel1.Controls.Add(descriptionTextBox, 1, 0);
			tableLayoutPanel1.Dock = DockStyle.Fill;
			tableLayoutPanel1.Location = new Point(3, 3);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 1;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
			tableLayoutPanel1.Size = new Size(581, 479);
			tableLayoutPanel1.TabIndex = 1;
			tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
			// 
			// descriptionPB
			// 
			descriptionPB.Image = (Image)resources.GetObject("descriptionPB.Image");
			descriptionPB.Location = new Point(3, 3);
			descriptionPB.Name = "descriptionPB";
			descriptionPB.Size = new Size(79, 103);
			descriptionPB.TabIndex = 0;
			descriptionPB.TabStop = false;
			descriptionPB.Click += descriptionPB_Click;
			// 
			// descriptionTextBox
			// 
			descriptionTextBox.Dock = DockStyle.Fill;
			descriptionTextBox.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			descriptionTextBox.Location = new Point(88, 3);
			descriptionTextBox.Name = "descriptionTextBox";
			descriptionTextBox.Size = new Size(490, 473);
			descriptionTextBox.TabIndex = 1;
			descriptionTextBox.Text = "";
			descriptionTextBox.TextChanged += descriptionTextBox_TextChanged;
			// 
			// CandidateHobbyView
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(tableLayoutPanel);
			Name = "CandidateHobbyView";
			Size = new Size(1196, 582);
			tableLayoutPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)hobbiesDGV).EndInit();
			leftTableLayout.ResumeLayout(false);
			buttonTableLayout.ResumeLayout(false);
			tableLayoutPanel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)descriptionPB).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private TableLayoutPanel tableLayoutPanel;
		private DataGridView hobbiesDGV;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private DataGridViewTextBoxColumn DescriptionO;
		private TableLayoutPanel leftTableLayout;
		private TableLayoutPanel buttonTableLayout;
		private Button addBtn;
		private Button editBtn;
		private Button deleteBtn;
		private TableLayoutPanel tableLayoutPanel1;
		private PictureBox descriptionPB;
		private RichTextBox descriptionTextBox;
	}
}
