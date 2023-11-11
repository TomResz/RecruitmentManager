namespace RecruitmentManager.Forms.Candidate.DataDictionary
{
	partial class CandidateSkillsView
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CandidateSkillsView));
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			descriptionTextBox = new RichTextBox();
			tableLayoutPanel = new TableLayoutPanel();
			skillsDGV = new DataGridView();
			leftTableLayout = new TableLayoutPanel();
			buttonTableLayout = new TableLayoutPanel();
			deleteBtn = new Button();
			editBtn = new Button();
			addBtn = new Button();
			tableLayoutPanel1 = new TableLayoutPanel();
			descriptionPB = new PictureBox();
			dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
			DescriptionO = new DataGridViewTextBoxColumn();
			tableLayoutPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)skillsDGV).BeginInit();
			leftTableLayout.SuspendLayout();
			buttonTableLayout.SuspendLayout();
			tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)descriptionPB).BeginInit();
			SuspendLayout();
			// 
			// descriptionTextBox
			// 
			descriptionTextBox.Dock = DockStyle.Fill;
			descriptionTextBox.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			descriptionTextBox.Location = new Point(88, 3);
			descriptionTextBox.Name = "descriptionTextBox";
			descriptionTextBox.Size = new Size(411, 472);
			descriptionTextBox.TabIndex = 1;
			descriptionTextBox.Text = "";
			// 
			// tableLayoutPanel
			// 
			tableLayoutPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.InsetDouble;
			tableLayoutPanel.ColumnCount = 2;
			tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel.Controls.Add(skillsDGV, 1, 0);
			tableLayoutPanel.Controls.Add(leftTableLayout, 0, 0);
			tableLayoutPanel.Dock = DockStyle.Fill;
			tableLayoutPanel.Location = new Point(0, 0);
			tableLayoutPanel.Name = "tableLayoutPanel";
			tableLayoutPanel.RowCount = 1;
			tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel.Size = new Size(1037, 581);
			tableLayoutPanel.TabIndex = 1;
			// 
			// skillsDGV
			// 
			skillsDGV.AllowUserToAddRows = false;
			skillsDGV.AllowUserToDeleteRows = false;
			skillsDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			skillsDGV.BackgroundColor = SystemColors.Control;
			skillsDGV.BorderStyle = BorderStyle.None;
			dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = Color.Blue;
			dataGridViewCellStyle1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
			dataGridViewCellStyle1.ForeColor = Color.White;
			dataGridViewCellStyle1.SelectionBackColor = Color.Blue;
			dataGridViewCellStyle1.SelectionForeColor = Color.White;
			dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
			skillsDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			skillsDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			skillsDGV.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, DescriptionO });
			skillsDGV.Dock = DockStyle.Fill;
			skillsDGV.EnableHeadersVisualStyles = false;
			skillsDGV.Location = new Point(523, 6);
			skillsDGV.MultiSelect = false;
			skillsDGV.Name = "skillsDGV";
			skillsDGV.RowHeadersVisible = false;
			skillsDGV.RowHeadersWidth = 51;
			skillsDGV.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			skillsDGV.RowTemplate.Height = 29;
			skillsDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			skillsDGV.Size = new Size(508, 569);
			skillsDGV.TabIndex = 7;
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
			leftTableLayout.Size = new Size(508, 569);
			leftTableLayout.TabIndex = 8;
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
			buttonTableLayout.Location = new Point(3, 487);
			buttonTableLayout.Name = "buttonTableLayout";
			buttonTableLayout.RowCount = 1;
			buttonTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			buttonTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
			buttonTableLayout.Size = new Size(502, 79);
			buttonTableLayout.TabIndex = 0;
			// 
			// deleteBtn
			// 
			deleteBtn.Dock = DockStyle.Fill;
			deleteBtn.FlatStyle = FlatStyle.Flat;
			deleteBtn.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
			deleteBtn.Location = new Point(337, 3);
			deleteBtn.Name = "deleteBtn";
			deleteBtn.Size = new Size(162, 73);
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
			editBtn.Location = new Point(170, 3);
			editBtn.Name = "editBtn";
			editBtn.Size = new Size(161, 73);
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
			addBtn.Size = new Size(161, 73);
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
			tableLayoutPanel1.Size = new Size(502, 478);
			tableLayoutPanel1.TabIndex = 1;
			// 
			// descriptionPB
			// 
			descriptionPB.Image = (Image)resources.GetObject("descriptionPB.Image");
			descriptionPB.Location = new Point(3, 3);
			descriptionPB.Name = "descriptionPB";
			descriptionPB.Size = new Size(79, 103);
			descriptionPB.TabIndex = 0;
			descriptionPB.TabStop = false;
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
			DescriptionO.HeaderText = "Umiejętności";
			DescriptionO.MinimumWidth = 6;
			DescriptionO.Name = "DescriptionO";
			DescriptionO.ReadOnly = true;
			// 
			// CandidateSkillsView
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(tableLayoutPanel);
			Name = "CandidateSkillsView";
			Size = new Size(1037, 581);
			tableLayoutPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)skillsDGV).EndInit();
			leftTableLayout.ResumeLayout(false);
			buttonTableLayout.ResumeLayout(false);
			tableLayoutPanel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)descriptionPB).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private RichTextBox descriptionTextBox;
		private TableLayoutPanel tableLayoutPanel;
		private DataGridView skillsDGV;
		private TableLayoutPanel leftTableLayout;
		private TableLayoutPanel buttonTableLayout;
		private Button deleteBtn;
		private Button editBtn;
		private Button addBtn;
		private TableLayoutPanel tableLayoutPanel1;
		private PictureBox descriptionPB;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private DataGridViewTextBoxColumn DescriptionO;
	}
}
