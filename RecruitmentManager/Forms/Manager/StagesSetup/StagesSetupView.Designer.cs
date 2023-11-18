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
			DataGridViewCellStyle dataGridViewCellStyle21 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle22 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle23 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle24 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle25 = new DataGridViewCellStyle();
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
			tableLayoutPanel.Name = "tableLayoutPanel";
			tableLayoutPanel.RowCount = 1;
			tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			tableLayoutPanel.Size = new Size(1319, 607);
			tableLayoutPanel.TabIndex = 0;
			// 
			// stagesDgv
			// 
			stagesDgv.AllowUserToAddRows = false;
			stagesDgv.AllowUserToDeleteRows = false;
			stagesDgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			stagesDgv.BackgroundColor = SystemColors.Control;
			stagesDgv.BorderStyle = BorderStyle.None;
			dataGridViewCellStyle21.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle21.BackColor = Color.Blue;
			dataGridViewCellStyle21.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
			dataGridViewCellStyle21.ForeColor = Color.White;
			dataGridViewCellStyle21.SelectionBackColor = Color.Blue;
			dataGridViewCellStyle21.SelectionForeColor = Color.White;
			dataGridViewCellStyle21.WrapMode = DataGridViewTriState.True;
			stagesDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle21;
			stagesDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			stagesDgv.Columns.AddRange(new DataGridViewColumn[] { Id, Position, RecruitmentStageName, CandidateData, DateTimeSU });
			stagesDgv.Dock = DockStyle.Fill;
			stagesDgv.EnableHeadersVisualStyles = false;
			stagesDgv.Location = new Point(6, 6);
			stagesDgv.MultiSelect = false;
			stagesDgv.Name = "stagesDgv";
			stagesDgv.RowHeadersVisible = false;
			stagesDgv.RowHeadersWidth = 51;
			stagesDgv.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			stagesDgv.RowTemplate.Height = 29;
			stagesDgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			stagesDgv.Size = new Size(976, 595);
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
			dataGridViewCellStyle22.BackColor = Color.FromArgb(128, 255, 255);
			dataGridViewCellStyle22.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			dataGridViewCellStyle22.ForeColor = Color.Black;
			dataGridViewCellStyle22.SelectionBackColor = Color.FromArgb(0, 192, 192);
			dataGridViewCellStyle22.SelectionForeColor = Color.Black;
			Position.DefaultCellStyle = dataGridViewCellStyle22;
			Position.FillWeight = 230F;
			Position.HeaderText = "Stanowisko";
			Position.MinimumWidth = 6;
			Position.Name = "Position";
			Position.ReadOnly = true;
			// 
			// RecruitmentStageName
			// 
			dataGridViewCellStyle23.BackColor = Color.FromArgb(128, 255, 255);
			dataGridViewCellStyle23.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			dataGridViewCellStyle23.ForeColor = Color.Black;
			dataGridViewCellStyle23.SelectionBackColor = Color.FromArgb(0, 192, 192);
			dataGridViewCellStyle23.SelectionForeColor = Color.Black;
			RecruitmentStageName.DefaultCellStyle = dataGridViewCellStyle23;
			RecruitmentStageName.HeaderText = "Etap Rekrutacyjny";
			RecruitmentStageName.MinimumWidth = 6;
			RecruitmentStageName.Name = "RecruitmentStageName";
			RecruitmentStageName.ReadOnly = true;
			// 
			// CandidateData
			// 
			dataGridViewCellStyle24.BackColor = Color.FromArgb(128, 255, 255);
			dataGridViewCellStyle24.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			dataGridViewCellStyle24.ForeColor = Color.Black;
			dataGridViewCellStyle24.SelectionBackColor = Color.FromArgb(0, 192, 192);
			dataGridViewCellStyle24.SelectionForeColor = Color.Black;
			CandidateData.DefaultCellStyle = dataGridViewCellStyle24;
			CandidateData.HeaderText = "Kandydat";
			CandidateData.MinimumWidth = 6;
			CandidateData.Name = "CandidateData";
			CandidateData.ReadOnly = true;
			// 
			// DateTimeSU
			// 
			dataGridViewCellStyle25.BackColor = Color.FromArgb(128, 255, 255);
			dataGridViewCellStyle25.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			dataGridViewCellStyle25.ForeColor = Color.Black;
			dataGridViewCellStyle25.SelectionBackColor = Color.FromArgb(0, 192, 192);
			dataGridViewCellStyle25.SelectionForeColor = Color.Black;
			DateTimeSU.DefaultCellStyle = dataGridViewCellStyle25;
			DateTimeSU.HeaderText = "Data";
			DateTimeSU.MinimumWidth = 6;
			DateTimeSU.Name = "DateTimeSU";
			DateTimeSU.ReadOnly = true;
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.ColumnCount = 1;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			tableLayoutPanel1.Controls.Add(datePicker, 0, 1);
			tableLayoutPanel1.Controls.Add(UpdateBtn, 0, 2);
			tableLayoutPanel1.Dock = DockStyle.Fill;
			tableLayoutPanel1.Location = new Point(988, 3);
			tableLayoutPanel1.Margin = new Padding(0);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 3;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
			tableLayoutPanel1.Size = new Size(328, 601);
			tableLayoutPanel1.TabIndex = 0;
			// 
			// datePicker
			// 
			datePicker.Dock = DockStyle.Fill;
			datePicker.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			datePicker.Location = new Point(3, 363);
			datePicker.Name = "datePicker";
			datePicker.Size = new Size(322, 34);
			datePicker.TabIndex = 0;
			// 
			// UpdateBtn
			// 
			UpdateBtn.Dock = DockStyle.Fill;
			UpdateBtn.FlatStyle = FlatStyle.Flat;
			UpdateBtn.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
			UpdateBtn.Location = new Point(3, 483);
			UpdateBtn.Name = "UpdateBtn";
			UpdateBtn.Size = new Size(322, 115);
			UpdateBtn.TabIndex = 1;
			UpdateBtn.Text = "Aktualizuj";
			UpdateBtn.UseVisualStyleBackColor = true;
			UpdateBtn.Click += UpdateBtn_Click;
			// 
			// StagesSetupView
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(tableLayoutPanel);
			Name = "StagesSetupView";
			Size = new Size(1319, 607);
			tableLayoutPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)stagesDgv).EndInit();
			tableLayoutPanel1.ResumeLayout(false);
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
	}
}
