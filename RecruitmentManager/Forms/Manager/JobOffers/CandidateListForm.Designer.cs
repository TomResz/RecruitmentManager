namespace RecruitmentManager.Forms.Manager.JobOffers
{
	partial class CandidateListForm
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
			DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
			usersView = new DataGridView();
			dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
			dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
			DetailsBtn = new DataGridViewButtonColumn();
			((System.ComponentModel.ISupportInitialize)usersView).BeginInit();
			SuspendLayout();
			// 
			// usersView
			// 
			usersView.AllowUserToAddRows = false;
			usersView.AllowUserToDeleteRows = false;
			usersView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			usersView.BackgroundColor = SystemColors.Control;
			usersView.BorderStyle = BorderStyle.None;
			dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = Color.Blue;
			dataGridViewCellStyle1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
			dataGridViewCellStyle1.ForeColor = Color.White;
			dataGridViewCellStyle1.SelectionBackColor = Color.Blue;
			dataGridViewCellStyle1.SelectionForeColor = Color.White;
			dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
			usersView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			usersView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			usersView.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, DetailsBtn });
			usersView.Dock = DockStyle.Fill;
			usersView.EnableHeadersVisualStyles = false;
			usersView.Location = new Point(0, 0);
			usersView.Margin = new Padding(3, 2, 3, 2);
			usersView.MultiSelect = false;
			usersView.Name = "usersView";
			usersView.RowHeadersVisible = false;
			usersView.RowHeadersWidth = 51;
			usersView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			usersView.RowTemplate.Height = 29;
			usersView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			usersView.Size = new Size(458, 457);
			usersView.TabIndex = 3;
			// 
			// dataGridViewTextBoxColumn1
			// 
			dataGridViewTextBoxColumn1.HeaderText = "ID";
			dataGridViewTextBoxColumn1.MinimumWidth = 6;
			dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			dataGridViewTextBoxColumn1.ReadOnly = true;
			dataGridViewTextBoxColumn1.Visible = false;
			// 
			// dataGridViewTextBoxColumn2
			// 
			dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dataGridViewCellStyle2.BackColor = Color.FromArgb(128, 255, 255);
			dataGridViewCellStyle2.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			dataGridViewCellStyle2.ForeColor = Color.Black;
			dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 192, 192);
			dataGridViewCellStyle2.SelectionForeColor = Color.Black;
			dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle2;
			dataGridViewTextBoxColumn2.FillWeight = 230F;
			dataGridViewTextBoxColumn2.HeaderText = "Imię i Nazwisko";
			dataGridViewTextBoxColumn2.MinimumWidth = 6;
			dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			dataGridViewTextBoxColumn2.ReadOnly = true;
			// 
			// DetailsBtn
			// 
			DetailsBtn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.BackColor = Color.Navy;
			dataGridViewCellStyle3.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			dataGridViewCellStyle3.ForeColor = Color.White;
			dataGridViewCellStyle3.SelectionBackColor = Color.Navy;
			dataGridViewCellStyle3.SelectionForeColor = Color.White;
			DetailsBtn.DefaultCellStyle = dataGridViewCellStyle3;
			DetailsBtn.FillWeight = 250F;
			DetailsBtn.FlatStyle = FlatStyle.Popup;
			DetailsBtn.HeaderText = "Szczegóły";
			DetailsBtn.MinimumWidth = 6;
			DetailsBtn.Name = "DetailsBtn";
			DetailsBtn.Text = "Wyświetl szczegóły!";
			DetailsBtn.UseColumnTextForButtonValue = true;
			// 
			// CandidateListForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(458, 457);
			Controls.Add(usersView);
			Name = "CandidateListForm";
			Text = "Lista Wybranych Kandydatów";
			((System.ComponentModel.ISupportInitialize)usersView).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private DataGridView usersView;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private DataGridViewButtonColumn DetailsBtn;
	}
}