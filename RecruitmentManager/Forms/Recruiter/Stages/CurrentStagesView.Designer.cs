namespace RecruitmentManager.Forms.Recruiter.Stages
{
	partial class CurrentStagesView
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CurrentStagesView));
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
			tableLayoutPanel = new TableLayoutPanel();
			stagesDgv = new DataGridView();
			pictureBox1 = new PictureBox();
			Id = new DataGridViewTextBoxColumn();
			candidateid = new DataGridViewTextBoxColumn();
			Position = new DataGridViewTextBoxColumn();
			RecruitmentStageName = new DataGridViewTextBoxColumn();
			CandidateData = new DataGridViewTextBoxColumn();
			DateTimeSU = new DataGridViewTextBoxColumn();
			Details = new DataGridViewButtonColumn();
			tableLayoutPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)stagesDgv).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// tableLayoutPanel
			// 
			tableLayoutPanel.ColumnCount = 2;
			tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
			tableLayoutPanel.Controls.Add(stagesDgv, 0, 0);
			tableLayoutPanel.Controls.Add(pictureBox1, 1, 0);
			tableLayoutPanel.Dock = DockStyle.Fill;
			tableLayoutPanel.Location = new Point(0, 0);
			tableLayoutPanel.Name = "tableLayoutPanel";
			tableLayoutPanel.RowCount = 1;
			tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			tableLayoutPanel.Size = new Size(1450, 587);
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
			stagesDgv.Columns.AddRange(new DataGridViewColumn[] { Id, candidateid, Position, RecruitmentStageName, CandidateData, DateTimeSU, Details });
			stagesDgv.Dock = DockStyle.Fill;
			stagesDgv.EnableHeadersVisualStyles = false;
			stagesDgv.Location = new Point(3, 3);
			stagesDgv.MultiSelect = false;
			stagesDgv.Name = "stagesDgv";
			stagesDgv.RowHeadersVisible = false;
			stagesDgv.RowHeadersWidth = 51;
			stagesDgv.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			stagesDgv.RowTemplate.Height = 29;
			stagesDgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			stagesDgv.Size = new Size(1344, 581);
			stagesDgv.TabIndex = 3;
			// 
			// pictureBox1
			// 
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(1353, 3);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(94, 95);
			pictureBox1.TabIndex = 0;
			pictureBox1.TabStop = false;
			// 
			// Id
			// 
			Id.HeaderText = "ID";
			Id.MinimumWidth = 6;
			Id.Name = "Id";
			Id.ReadOnly = true;
			Id.Visible = false;
			// 
			// candidateid
			// 
			candidateid.HeaderText = "id kandydata";
			candidateid.MinimumWidth = 6;
			candidateid.Name = "candidateid";
			candidateid.ReadOnly = true;
			candidateid.Visible = false;
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
			// Details
			// 
			dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle6.BackColor = Color.FromArgb(0, 0, 192);
			dataGridViewCellStyle6.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			dataGridViewCellStyle6.ForeColor = Color.White;
			dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(0, 0, 192);
			dataGridViewCellStyle6.SelectionForeColor = Color.White;
			Details.DefaultCellStyle = dataGridViewCellStyle6;
			Details.FlatStyle = FlatStyle.Popup;
			Details.HeaderText = "Szczegóły kandydata";
			Details.MinimumWidth = 6;
			Details.Name = "Details";
			Details.Text = "Szczegóły kandydata";
			Details.UseColumnTextForButtonValue = true;
			// 
			// CurrentStagesView
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(tableLayoutPanel);
			Name = "CurrentStagesView";
			Size = new Size(1450, 587);
			tableLayoutPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)stagesDgv).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private TableLayoutPanel tableLayoutPanel;
		private PictureBox pictureBox1;
		private DataGridView stagesDgv;
		private DataGridViewTextBoxColumn Id;
		private DataGridViewTextBoxColumn candidateid;
		private DataGridViewTextBoxColumn Position;
		private DataGridViewTextBoxColumn RecruitmentStageName;
		private DataGridViewTextBoxColumn CandidateData;
		private DataGridViewTextBoxColumn DateTimeSU;
		private DataGridViewButtonColumn Details;
	}
}
