namespace RecruitmentManager.Forms.Manager.StagesSetup
{
	partial class StagesSetupView
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
			DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
			tableLayoutPanel = new TableLayoutPanel();
			stagesDgv = new DataGridView();
			Id = new DataGridViewTextBoxColumn();
			Position = new DataGridViewTextBoxColumn();
			RecruitmentStageName = new DataGridViewTextBoxColumn();
			CandidateData = new DataGridViewTextBoxColumn();
			DateTimeSU = new DataGridViewTextBoxColumn();
			tableLayoutPanel1 = new TableLayoutPanel();
			datePicker = new DateTimePicker();
			UpdateBtn = new Button();
			toCheckCB = new CheckBox();
			tableLayoutPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)stagesDgv).BeginInit();
			tableLayoutPanel1.SuspendLayout();
			SuspendLayout();
			// 
			// tableLayoutPanel
			// 
			tableLayoutPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.OutsetDouble;
			tableLayoutPanel.ColumnCount = 2;
			tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
			tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
			tableLayoutPanel.Controls.Add(stagesDgv, 0, 0);
			tableLayoutPanel.Controls.Add(tableLayoutPanel1, 1, 0);
			tableLayoutPanel.Dock = DockStyle.Fill;
			tableLayoutPanel.Location = new Point(0, 0);
			tableLayoutPanel.Margin = new Padding(3, 2, 3, 2);
			tableLayoutPanel.Name = "tableLayoutPanel";
			tableLayoutPanel.RowCount = 1;
			tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			tableLayoutPanel.Size = new Size(1154, 455);
			tableLayoutPanel.TabIndex = 0;
			// 
			// stagesDgv
			// 
			stagesDgv.AllowUserToAddRows = false;
			stagesDgv.AllowUserToDeleteRows = false;
			stagesDgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			stagesDgv.BackgroundColor = SystemColors.Control;
			stagesDgv.BorderStyle = BorderStyle.None;
			dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = Color.Blue;
			dataGridViewCellStyle1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
			dataGridViewCellStyle1.ForeColor = Color.White;
			dataGridViewCellStyle1.SelectionBackColor = Color.Blue;
			dataGridViewCellStyle1.SelectionForeColor = Color.White;
			dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
			stagesDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			stagesDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			stagesDgv.Columns.AddRange(new DataGridViewColumn[] { Id, Position, RecruitmentStageName, CandidateData, DateTimeSU });
			stagesDgv.Dock = DockStyle.Fill;
			stagesDgv.EnableHeadersVisualStyles = false;
			stagesDgv.Location = new Point(6, 5);
			stagesDgv.Margin = new Padding(3, 2, 3, 2);
			stagesDgv.MultiSelect = false;
			stagesDgv.Name = "stagesDgv";
			stagesDgv.RowHeadersVisible = false;
			stagesDgv.RowHeadersWidth = 51;
			stagesDgv.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			stagesDgv.RowTemplate.Height = 29;
			stagesDgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			stagesDgv.Size = new Size(852, 445);
			stagesDgv.TabIndex = 1;
			// 
			// Id
			// 
			Id.HeaderText = "ID";
			Id.MinimumWidth = 6;
			Id.Name = "Id";
			Id.ReadOnly = true;
			Id.Visible = false;
			// 
			// Position
			// 
			Position.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dataGridViewCellStyle2.BackColor = Color.FromArgb(128, 255, 255);
			dataGridViewCellStyle2.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			dataGridViewCellStyle2.ForeColor = Color.Black;
			dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 192, 192);
			dataGridViewCellStyle2.SelectionForeColor = Color.Black;
			Position.DefaultCellStyle = dataGridViewCellStyle2;
			Position.FillWeight = 230F;
			Position.HeaderText = "Stanowisko";
			Position.MinimumWidth = 6;
			Position.Name = "Position";
			Position.ReadOnly = true;
			// 
			// RecruitmentStageName
			// 
			dataGridViewCellStyle3.BackColor = Color.FromArgb(128, 255, 255);
			dataGridViewCellStyle3.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			dataGridViewCellStyle3.ForeColor = Color.Black;
			dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 192, 192);
			dataGridViewCellStyle3.SelectionForeColor = Color.Black;
			RecruitmentStageName.DefaultCellStyle = dataGridViewCellStyle3;
			RecruitmentStageName.HeaderText = "Etap Rekrutacyjny";
			RecruitmentStageName.MinimumWidth = 6;
			RecruitmentStageName.Name = "RecruitmentStageName";
			RecruitmentStageName.ReadOnly = true;
			// 
			// CandidateData
			// 
			dataGridViewCellStyle4.BackColor = Color.FromArgb(128, 255, 255);
			dataGridViewCellStyle4.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			dataGridViewCellStyle4.ForeColor = Color.Black;
			dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(0, 192, 192);
			dataGridViewCellStyle4.SelectionForeColor = Color.Black;
			CandidateData.DefaultCellStyle = dataGridViewCellStyle4;
			CandidateData.HeaderText = "Kandydat";
			CandidateData.MinimumWidth = 6;
			CandidateData.Name = "CandidateData";
			CandidateData.ReadOnly = true;
			// 
			// DateTimeSU
			// 
			dataGridViewCellStyle5.BackColor = Color.FromArgb(128, 255, 255);
			dataGridViewCellStyle5.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			dataGridViewCellStyle5.ForeColor = Color.Black;
			dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(0, 192, 192);
			dataGridViewCellStyle5.SelectionForeColor = Color.Black;
			DateTimeSU.DefaultCellStyle = dataGridViewCellStyle5;
			DateTimeSU.HeaderText = "Data";
			DateTimeSU.MinimumWidth = 6;
			DateTimeSU.Name = "DateTimeSU";
			DateTimeSU.ReadOnly = true;
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.ColumnCount = 1;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			tableLayoutPanel1.Controls.Add(datePicker, 0, 2);
			tableLayoutPanel1.Controls.Add(UpdateBtn, 0, 3);
			tableLayoutPanel1.Controls.Add(toCheckCB, 0, 1);
			tableLayoutPanel1.Dock = DockStyle.Fill;
			tableLayoutPanel1.Location = new Point(864, 3);
			tableLayoutPanel1.Margin = new Padding(0);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 4;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
			tableLayoutPanel1.Size = new Size(287, 449);
			tableLayoutPanel1.TabIndex = 0;
			// 
			// datePicker
			// 
			datePicker.Dock = DockStyle.Fill;
			datePicker.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			datePicker.Location = new Point(3, 270);
			datePicker.Margin = new Padding(3, 2, 3, 2);
			datePicker.Name = "datePicker";
			datePicker.Size = new Size(281, 29);
			datePicker.TabIndex = 0;
			// 
			// UpdateBtn
			// 
			UpdateBtn.Dock = DockStyle.Fill;
			UpdateBtn.FlatStyle = FlatStyle.Flat;
			UpdateBtn.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
			UpdateBtn.Location = new Point(3, 359);
			UpdateBtn.Margin = new Padding(3, 2, 3, 2);
			UpdateBtn.Name = "UpdateBtn";
			UpdateBtn.Size = new Size(281, 88);
			UpdateBtn.TabIndex = 1;
			UpdateBtn.Text = "Aktualizuj";
			UpdateBtn.UseVisualStyleBackColor = true;
			UpdateBtn.Click += UpdateBtn_Click;
			// 
			// toCheckCB
			// 
			toCheckCB.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			toCheckCB.AutoSize = true;
			toCheckCB.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
			toCheckCB.Location = new Point(3, 181);
			toCheckCB.Margin = new Padding(3, 2, 3, 2);
			toCheckCB.Name = "toCheckCB";
			toCheckCB.Size = new Size(281, 29);
			toCheckCB.TabIndex = 2;
			toCheckCB.Text = "Do zatwierdzenia";
			toCheckCB.UseVisualStyleBackColor = true;
			toCheckCB.CheckedChanged += toCheckCB_CheckedChanged;
			// 
			// StagesSetupView
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(tableLayoutPanel);
			Margin = new Padding(3, 2, 3, 2);
			Name = "StagesSetupView";
			Size = new Size(1154, 455);
			tableLayoutPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)stagesDgv).EndInit();
			tableLayoutPanel1.ResumeLayout(false);
			tableLayoutPanel1.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private TableLayoutPanel tableLayoutPanel;
		private TableLayoutPanel tableLayoutPanel1;
		private DateTimePicker datePicker;
		private DataGridView stagesDgv;
		private DataGridViewTextBoxColumn Id;
		private DataGridViewTextBoxColumn Position;
		private DataGridViewTextBoxColumn RecruitmentStageName;
		private DataGridViewTextBoxColumn CandidateData;
		private DataGridViewTextBoxColumn DateTimeSU;
		private Button UpdateBtn;
		private CheckBox toCheckCB;
	}
}
