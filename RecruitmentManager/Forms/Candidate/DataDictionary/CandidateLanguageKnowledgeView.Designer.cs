namespace RecruitmentManager.Forms.Candidate.DataDictionary
{
	partial class CandidateLanguageKnowledgeView
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
			DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CandidateLanguageKnowledgeView));
			mainTableLayoutPanel = new TableLayoutPanel();
			languageDGV = new DataGridView();
			dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
			LanguageOo = new DataGridViewTextBoxColumn();
			KnowledgeO = new DataGridViewTextBoxColumn();
			leftTableLayoutPanel = new TableLayoutPanel();
			tableLayoutPanel2 = new TableLayoutPanel();
			levelOfKnowledgeComboBox = new ComboBox();
			pictureBox1 = new PictureBox();
			tableLayoutPanel1 = new TableLayoutPanel();
			languagePB = new PictureBox();
			languageComboBox = new ComboBox();
			buttonTableLayout = new TableLayoutPanel();
			deleteBtn = new Button();
			editBtn = new Button();
			addBtn = new Button();
			Id = new DataGridViewTextBoxColumn();
			Language = new DataGridViewTextBoxColumn();
			Knowledge = new DataGridViewTextBoxColumn();
			mainTableLayoutPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)languageDGV).BeginInit();
			leftTableLayoutPanel.SuspendLayout();
			tableLayoutPanel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)languagePB).BeginInit();
			buttonTableLayout.SuspendLayout();
			SuspendLayout();
			// 
			// mainTableLayoutPanel
			// 
			mainTableLayoutPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.InsetDouble;
			mainTableLayoutPanel.ColumnCount = 2;
			mainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			mainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			mainTableLayoutPanel.Controls.Add(languageDGV, 0, 0);
			mainTableLayoutPanel.Controls.Add(leftTableLayoutPanel, 0, 0);
			mainTableLayoutPanel.Dock = DockStyle.Fill;
			mainTableLayoutPanel.Location = new Point(0, 0);
			mainTableLayoutPanel.Name = "mainTableLayoutPanel";
			mainTableLayoutPanel.RowCount = 1;
			mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			mainTableLayoutPanel.Size = new Size(1180, 591);
			mainTableLayoutPanel.TabIndex = 0;
			// 
			// languageDGV
			// 
			languageDGV.AllowUserToAddRows = false;
			languageDGV.AllowUserToDeleteRows = false;
			languageDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			languageDGV.BackgroundColor = SystemColors.Control;
			languageDGV.BorderStyle = BorderStyle.None;
			dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = Color.Blue;
			dataGridViewCellStyle1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
			dataGridViewCellStyle1.ForeColor = Color.White;
			dataGridViewCellStyle1.SelectionBackColor = Color.Blue;
			dataGridViewCellStyle1.SelectionForeColor = Color.White;
			dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
			languageDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			languageDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			languageDGV.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, LanguageOo, KnowledgeO });
			languageDGV.Dock = DockStyle.Fill;
			languageDGV.EnableHeadersVisualStyles = false;
			languageDGV.Location = new Point(594, 6);
			languageDGV.MultiSelect = false;
			languageDGV.Name = "languageDGV";
			languageDGV.RowHeadersVisible = false;
			languageDGV.RowHeadersWidth = 51;
			languageDGV.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			languageDGV.RowTemplate.Height = 29;
			languageDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			languageDGV.Size = new Size(580, 579);
			languageDGV.TabIndex = 6;
			// 
			// dataGridViewTextBoxColumn1
			// 
			dataGridViewTextBoxColumn1.HeaderText = "ID";
			dataGridViewTextBoxColumn1.MinimumWidth = 6;
			dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			dataGridViewTextBoxColumn1.ReadOnly = true;
			dataGridViewTextBoxColumn1.Visible = false;
			// 
			// LanguageOo
			// 
			LanguageOo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dataGridViewCellStyle2.BackColor = Color.FromArgb(128, 255, 255);
			dataGridViewCellStyle2.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			dataGridViewCellStyle2.ForeColor = Color.Black;
			dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 192, 192);
			dataGridViewCellStyle2.SelectionForeColor = Color.Black;
			LanguageOo.DefaultCellStyle = dataGridViewCellStyle2;
			LanguageOo.FillWeight = 230F;
			LanguageOo.HeaderText = "Język";
			LanguageOo.MinimumWidth = 6;
			LanguageOo.Name = "LanguageOo";
			LanguageOo.ReadOnly = true;
			// 
			// KnowledgeO
			// 
			dataGridViewCellStyle3.BackColor = Color.FromArgb(128, 255, 255);
			dataGridViewCellStyle3.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			dataGridViewCellStyle3.ForeColor = Color.Black;
			dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 192, 192);
			dataGridViewCellStyle3.SelectionForeColor = Color.Black;
			KnowledgeO.DefaultCellStyle = dataGridViewCellStyle3;
			KnowledgeO.HeaderText = "Poziom Znajomości";
			KnowledgeO.MinimumWidth = 6;
			KnowledgeO.Name = "KnowledgeO";
			KnowledgeO.ReadOnly = true;
			// 
			// leftTableLayoutPanel
			// 
			leftTableLayoutPanel.ColumnCount = 1;
			leftTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			leftTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
			leftTableLayoutPanel.Controls.Add(tableLayoutPanel2, 0, 1);
			leftTableLayoutPanel.Controls.Add(tableLayoutPanel1, 0, 0);
			leftTableLayoutPanel.Controls.Add(buttonTableLayout, 0, 2);
			leftTableLayoutPanel.Dock = DockStyle.Fill;
			leftTableLayoutPanel.Location = new Point(6, 6);
			leftTableLayoutPanel.Name = "leftTableLayoutPanel";
			leftTableLayoutPanel.RowCount = 3;
			leftTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			leftTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			leftTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 85F));
			leftTableLayoutPanel.Size = new Size(579, 579);
			leftTableLayoutPanel.TabIndex = 5;
			// 
			// tableLayoutPanel2
			// 
			tableLayoutPanel2.ColumnCount = 2;
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 85F));
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			tableLayoutPanel2.Controls.Add(levelOfKnowledgeComboBox, 0, 0);
			tableLayoutPanel2.Controls.Add(pictureBox1, 0, 0);
			tableLayoutPanel2.Dock = DockStyle.Fill;
			tableLayoutPanel2.Location = new Point(3, 250);
			tableLayoutPanel2.Name = "tableLayoutPanel2";
			tableLayoutPanel2.RowCount = 1;
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			tableLayoutPanel2.Size = new Size(573, 241);
			tableLayoutPanel2.TabIndex = 1;
			// 
			// levelOfKnowledgeComboBox
			// 
			levelOfKnowledgeComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			levelOfKnowledgeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
			levelOfKnowledgeComboBox.FlatStyle = FlatStyle.Flat;
			levelOfKnowledgeComboBox.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
			levelOfKnowledgeComboBox.FormattingEnabled = true;
			levelOfKnowledgeComboBox.Items.AddRange(new object[] { "A1", "A2", "B1", "B2", "C1", "C2" });
			levelOfKnowledgeComboBox.Location = new Point(88, 3);
			levelOfKnowledgeComboBox.Name = "levelOfKnowledgeComboBox";
			levelOfKnowledgeComboBox.Size = new Size(482, 39);
			levelOfKnowledgeComboBox.TabIndex = 2;
			// 
			// pictureBox1
			// 
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(3, 3);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(79, 70);
			pictureBox1.TabIndex = 0;
			pictureBox1.TabStop = false;
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.ColumnCount = 2;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 85F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			tableLayoutPanel1.Controls.Add(languagePB, 0, 0);
			tableLayoutPanel1.Controls.Add(languageComboBox, 1, 0);
			tableLayoutPanel1.Dock = DockStyle.Fill;
			tableLayoutPanel1.Location = new Point(3, 3);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 1;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			tableLayoutPanel1.Size = new Size(573, 241);
			tableLayoutPanel1.TabIndex = 0;
			// 
			// languagePB
			// 
			languagePB.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			languagePB.Image = (Image)resources.GetObject("languagePB.Image");
			languagePB.Location = new Point(3, 3);
			languagePB.Name = "languagePB";
			languagePB.Size = new Size(79, 89);
			languagePB.TabIndex = 0;
			languagePB.TabStop = false;
			// 
			// languageComboBox
			// 
			languageComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			languageComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
			languageComboBox.FlatStyle = FlatStyle.Flat;
			languageComboBox.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
			languageComboBox.FormattingEnabled = true;
			languageComboBox.Items.AddRange(new object[] { "Angielski", "Arabski", "Chiński (uproszczony)", "Duński", "Francuski", "Hiszpański", "Holenderski", "Japoński", "Koreański", "Niemiecki", "Norweski", "Polski", "Portugalski", "Rosyjski", "Szwedzki", "Włoski" });
			languageComboBox.Location = new Point(88, 3);
			languageComboBox.Name = "languageComboBox";
			languageComboBox.Size = new Size(482, 39);
			languageComboBox.Sorted = true;
			languageComboBox.TabIndex = 1;
			// 
			// buttonTableLayout
			// 
			buttonTableLayout.ColumnCount = 3;
			buttonTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
			buttonTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
			buttonTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
			buttonTableLayout.Controls.Add(deleteBtn, 2, 0);
			buttonTableLayout.Controls.Add(editBtn, 1, 0);
			buttonTableLayout.Controls.Add(addBtn, 0, 0);
			buttonTableLayout.Dock = DockStyle.Fill;
			buttonTableLayout.Location = new Point(0, 494);
			buttonTableLayout.Margin = new Padding(0);
			buttonTableLayout.Name = "buttonTableLayout";
			buttonTableLayout.RowCount = 1;
			buttonTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			buttonTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
			buttonTableLayout.Size = new Size(579, 85);
			buttonTableLayout.TabIndex = 2;
			// 
			// deleteBtn
			// 
			deleteBtn.Dock = DockStyle.Fill;
			deleteBtn.FlatStyle = FlatStyle.Flat;
			deleteBtn.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
			deleteBtn.Location = new Point(388, 3);
			deleteBtn.Name = "deleteBtn";
			deleteBtn.Size = new Size(188, 79);
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
			editBtn.Location = new Point(195, 3);
			editBtn.Name = "editBtn";
			editBtn.Size = new Size(187, 79);
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
			addBtn.Size = new Size(186, 79);
			addBtn.TabIndex = 0;
			addBtn.Text = "Dodaj";
			addBtn.UseVisualStyleBackColor = true;
			addBtn.Click += addBtn_Click;
			// 
			// Id
			// 
			Id.MinimumWidth = 6;
			Id.Name = "Id";
			Id.Width = 125;
			// 
			// Language
			// 
			Language.MinimumWidth = 6;
			Language.Name = "Language";
			Language.Width = 125;
			// 
			// Knowledge
			// 
			Knowledge.MinimumWidth = 6;
			Knowledge.Name = "Knowledge";
			Knowledge.Width = 125;
			// 
			// CandidateLanguageKnowledgeView
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(mainTableLayoutPanel);
			Name = "CandidateLanguageKnowledgeView";
			Size = new Size(1180, 591);
			mainTableLayoutPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)languageDGV).EndInit();
			leftTableLayoutPanel.ResumeLayout(false);
			tableLayoutPanel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			tableLayoutPanel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)languagePB).EndInit();
			buttonTableLayout.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private TableLayoutPanel mainTableLayoutPanel;
		private DataGridViewTextBoxColumn Id;
		private DataGridViewTextBoxColumn Language;
		private DataGridViewTextBoxColumn Knowledge;
		private TableLayoutPanel leftTableLayoutPanel;
		private TableLayoutPanel tableLayoutPanel1;
		private PictureBox languagePB;
		private TableLayoutPanel tableLayoutPanel2;
		private PictureBox pictureBox1;
		private ComboBox languageComboBox;
		private ComboBox levelOfKnowledgeComboBox;
		private DataGridView languageDGV;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private DataGridViewTextBoxColumn LanguageOo;
		private DataGridViewTextBoxColumn KnowledgeO;
		private TableLayoutPanel buttonTableLayout;
		private Button addBtn;
		private Button deleteBtn;
		private Button editBtn;
	}
}
