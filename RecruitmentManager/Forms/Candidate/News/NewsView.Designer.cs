namespace RecruitmentManager.Forms.Candidate.News
{
	partial class NewsView
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
			DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
			tableLayoutPanel1 = new TableLayoutPanel();
			stagesDgv = new DataGridView();
			Id = new DataGridViewTextBoxColumn();
			Position = new DataGridViewTextBoxColumn();
			RecruitmentStageName = new DataGridViewTextBoxColumn();
			DateTimeSU = new DataGridViewTextBoxColumn();
			userView = new DataGridView();
			dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
			dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
			label1 = new Label();
			label2 = new Label();
			tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)stagesDgv).BeginInit();
			((System.ComponentModel.ISupportInitialize)userView).BeginInit();
			SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Outset;
			tableLayoutPanel1.ColumnCount = 2;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel1.Controls.Add(stagesDgv, 1, 1);
			tableLayoutPanel1.Controls.Add(userView, 0, 1);
			tableLayoutPanel1.Controls.Add(label1, 0, 0);
			tableLayoutPanel1.Controls.Add(label2, 1, 0);
			tableLayoutPanel1.Dock = DockStyle.Fill;
			tableLayoutPanel1.Location = new Point(0, 0);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 3;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
			tableLayoutPanel1.Size = new Size(1239, 492);
			tableLayoutPanel1.TabIndex = 0;
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
			stagesDgv.Columns.AddRange(new DataGridViewColumn[] { Id, Position, RecruitmentStageName, DateTimeSU });
			stagesDgv.Dock = DockStyle.Fill;
			stagesDgv.EnableHeadersVisualStyles = false;
			stagesDgv.Location = new Point(623, 86);
			stagesDgv.Margin = new Padding(3, 2, 3, 2);
			stagesDgv.MultiSelect = false;
			stagesDgv.Name = "stagesDgv";
			stagesDgv.RowHeadersVisible = false;
			stagesDgv.RowHeadersWidth = 51;
			stagesDgv.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			stagesDgv.RowTemplate.Height = 29;
			stagesDgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			stagesDgv.Size = new Size(611, 320);
			stagesDgv.TabIndex = 4;
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
			// DateTimeSU
			// 
			dataGridViewCellStyle4.BackColor = Color.FromArgb(128, 255, 255);
			dataGridViewCellStyle4.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			dataGridViewCellStyle4.ForeColor = Color.Black;
			dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(0, 192, 192);
			dataGridViewCellStyle4.SelectionForeColor = Color.Black;
			DateTimeSU.DefaultCellStyle = dataGridViewCellStyle4;
			DateTimeSU.HeaderText = "Data";
			DateTimeSU.MinimumWidth = 6;
			DateTimeSU.Name = "DateTimeSU";
			DateTimeSU.ReadOnly = true;
			// 
			// userView
			// 
			userView.AllowUserToAddRows = false;
			userView.AllowUserToDeleteRows = false;
			userView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			userView.BackgroundColor = SystemColors.Control;
			userView.BorderStyle = BorderStyle.None;
			dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = Color.Blue;
			dataGridViewCellStyle5.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
			dataGridViewCellStyle5.ForeColor = Color.White;
			dataGridViewCellStyle5.SelectionBackColor = Color.Blue;
			dataGridViewCellStyle5.SelectionForeColor = Color.White;
			dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
			userView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
			userView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			userView.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3 });
			userView.Dock = DockStyle.Fill;
			userView.EnableHeadersVisualStyles = false;
			userView.Location = new Point(5, 86);
			userView.Margin = new Padding(3, 2, 3, 2);
			userView.MultiSelect = false;
			userView.Name = "userView";
			userView.RowHeadersVisible = false;
			userView.RowHeadersWidth = 51;
			userView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			userView.RowTemplate.Height = 29;
			userView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			userView.Size = new Size(610, 320);
			userView.TabIndex = 5;
			// 
			// dataGridViewTextBoxColumn2
			// 
			dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dataGridViewCellStyle6.BackColor = Color.FromArgb(128, 255, 255);
			dataGridViewCellStyle6.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			dataGridViewCellStyle6.ForeColor = Color.Black;
			dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(0, 192, 192);
			dataGridViewCellStyle6.SelectionForeColor = Color.Black;
			dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle6;
			dataGridViewTextBoxColumn2.FillWeight = 230F;
			dataGridViewTextBoxColumn2.HeaderText = "Stanowisko";
			dataGridViewTextBoxColumn2.MinimumWidth = 6;
			dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			dataGridViewTextBoxColumn2.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn3
			// 
			dataGridViewCellStyle7.BackColor = Color.FromArgb(128, 255, 255);
			dataGridViewCellStyle7.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			dataGridViewCellStyle7.ForeColor = Color.Black;
			dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(0, 192, 192);
			dataGridViewCellStyle7.SelectionForeColor = Color.Black;
			dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle7;
			dataGridViewTextBoxColumn3.HeaderText = "Decyzja";
			dataGridViewTextBoxColumn3.MinimumWidth = 6;
			dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			dataGridViewTextBoxColumn3.ReadOnly = true;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point);
			label1.Location = new Point(5, 2);
			label1.Name = "label1";
			label1.Size = new Size(414, 36);
			label1.TabIndex = 6;
			label1.Text = "Decyzje dotyczące rekrutacji:";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point);
			label2.Location = new Point(623, 2);
			label2.Name = "label2";
			label2.Size = new Size(290, 36);
			label2.TabIndex = 7;
			label2.Text = "Etapy rekrutacyjne:";
			// 
			// NewsView
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(tableLayoutPanel1);
			Name = "NewsView";
			Size = new Size(1239, 492);
			tableLayoutPanel1.ResumeLayout(false);
			tableLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)stagesDgv).EndInit();
			((System.ComponentModel.ISupportInitialize)userView).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private TableLayoutPanel tableLayoutPanel1;
		private DataGridView stagesDgv;
		private DataGridViewTextBoxColumn Id;
		private DataGridViewTextBoxColumn Position;
		private DataGridViewTextBoxColumn RecruitmentStageName;
		private DataGridViewTextBoxColumn DateTimeSU;
		private DataGridView userView;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private Label label1;
		private Label label2;
	}
}
