namespace RecruitmentManager.Forms.Manager.Registrations
{
	partial class ManagerCurrentsRegistrationsView
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
			DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerCurrentsRegistrationsView));
			DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle17 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle18 = new DataGridViewCellStyle();
			tableLayoutPanel = new TableLayoutPanel();
			mainLayout = new TableLayoutPanel();
			jobOffersDGV = new DataGridView();
			Id = new DataGridViewTextBoxColumn();
			Position = new DataGridViewTextBoxColumn();
			AddedDate = new DataGridViewTextBoxColumn();
			EndedDate = new DataGridViewTextBoxColumn();
			footerLayout = new TableLayoutPanel();
			pageCounterLabel = new Label();
			nextPageButton = new PictureBox();
			previousPageButton = new PictureBox();
			usersView = new DataGridView();
			dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
			dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
			qualificatedoo = new DataGridViewTextBoxColumn();
			DetailsBtn = new DataGridViewButtonColumn();
			qulifactedbtn = new DataGridViewButtonColumn();
			endBtn = new Button();
			tableLayoutPanel.SuspendLayout();
			mainLayout.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)jobOffersDGV).BeginInit();
			footerLayout.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)nextPageButton).BeginInit();
			((System.ComponentModel.ISupportInitialize)previousPageButton).BeginInit();
			((System.ComponentModel.ISupportInitialize)usersView).BeginInit();
			SuspendLayout();
			// 
			// tableLayoutPanel
			// 
			tableLayoutPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.OutsetDouble;
			tableLayoutPanel.ColumnCount = 2;
			tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
			tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
			tableLayoutPanel.Controls.Add(mainLayout, 0, 0);
			tableLayoutPanel.Controls.Add(usersView, 1, 0);
			tableLayoutPanel.Dock = DockStyle.Fill;
			tableLayoutPanel.Location = new Point(0, 0);
			tableLayoutPanel.Margin = new Padding(3, 2, 3, 2);
			tableLayoutPanel.Name = "tableLayoutPanel";
			tableLayoutPanel.RowCount = 1;
			tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			tableLayoutPanel.Size = new Size(1073, 436);
			tableLayoutPanel.TabIndex = 0;
			// 
			// mainLayout
			// 
			mainLayout.ColumnCount = 1;
			mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			mainLayout.Controls.Add(jobOffersDGV, 0, 0);
			mainLayout.Controls.Add(footerLayout, 0, 1);
			mainLayout.Dock = DockStyle.Fill;
			mainLayout.Location = new Point(6, 5);
			mainLayout.Margin = new Padding(3, 2, 3, 2);
			mainLayout.Name = "mainLayout";
			mainLayout.RowCount = 2;
			mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
			mainLayout.Size = new Size(419, 426);
			mainLayout.TabIndex = 3;
			// 
			// jobOffersDGV
			// 
			jobOffersDGV.AllowUserToAddRows = false;
			jobOffersDGV.AllowUserToDeleteRows = false;
			jobOffersDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			jobOffersDGV.BackgroundColor = SystemColors.Control;
			jobOffersDGV.BorderStyle = BorderStyle.None;
			dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle10.BackColor = Color.Blue;
			dataGridViewCellStyle10.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
			dataGridViewCellStyle10.ForeColor = Color.White;
			dataGridViewCellStyle10.SelectionBackColor = Color.Blue;
			dataGridViewCellStyle10.SelectionForeColor = Color.White;
			dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
			jobOffersDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
			jobOffersDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			jobOffersDGV.Columns.AddRange(new DataGridViewColumn[] { Id, Position, AddedDate, EndedDate });
			jobOffersDGV.Dock = DockStyle.Fill;
			jobOffersDGV.EnableHeadersVisualStyles = false;
			jobOffersDGV.Location = new Point(3, 2);
			jobOffersDGV.Margin = new Padding(3, 2, 3, 2);
			jobOffersDGV.MultiSelect = false;
			jobOffersDGV.Name = "jobOffersDGV";
			jobOffersDGV.RowHeadersVisible = false;
			jobOffersDGV.RowHeadersWidth = 51;
			jobOffersDGV.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			jobOffersDGV.RowTemplate.Height = 29;
			jobOffersDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			jobOffersDGV.Size = new Size(413, 366);
			jobOffersDGV.TabIndex = 0;
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
			dataGridViewCellStyle11.BackColor = Color.FromArgb(128, 255, 255);
			dataGridViewCellStyle11.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			dataGridViewCellStyle11.ForeColor = Color.Black;
			dataGridViewCellStyle11.SelectionBackColor = Color.FromArgb(0, 192, 192);
			dataGridViewCellStyle11.SelectionForeColor = Color.Black;
			Position.DefaultCellStyle = dataGridViewCellStyle11;
			Position.FillWeight = 230F;
			Position.HeaderText = "Stanowisko";
			Position.MinimumWidth = 6;
			Position.Name = "Position";
			Position.ReadOnly = true;
			// 
			// AddedDate
			// 
			AddedDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dataGridViewCellStyle12.BackColor = Color.FromArgb(128, 255, 255);
			dataGridViewCellStyle12.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			dataGridViewCellStyle12.ForeColor = Color.Black;
			dataGridViewCellStyle12.SelectionBackColor = Color.FromArgb(0, 192, 192);
			dataGridViewCellStyle12.SelectionForeColor = Color.Black;
			AddedDate.DefaultCellStyle = dataGridViewCellStyle12;
			AddedDate.FillWeight = 280.748657F;
			AddedDate.HeaderText = "Data Dodania";
			AddedDate.MinimumWidth = 6;
			AddedDate.Name = "AddedDate";
			AddedDate.ReadOnly = true;
			// 
			// EndedDate
			// 
			dataGridViewCellStyle13.BackColor = Color.FromArgb(128, 255, 255);
			dataGridViewCellStyle13.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			dataGridViewCellStyle13.ForeColor = Color.Black;
			dataGridViewCellStyle13.SelectionBackColor = Color.FromArgb(0, 192, 192);
			dataGridViewCellStyle13.SelectionForeColor = Color.Black;
			EndedDate.DefaultCellStyle = dataGridViewCellStyle13;
			EndedDate.HeaderText = "Data Zakończenia";
			EndedDate.MinimumWidth = 6;
			EndedDate.Name = "EndedDate";
			EndedDate.ReadOnly = true;
			// 
			// footerLayout
			// 
			footerLayout.ColumnCount = 6;
			footerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 46.341465F));
			footerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.7073174F));
			footerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.95122F));
			footerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 57F));
			footerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 57F));
			footerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 58F));
			footerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
			footerLayout.Controls.Add(pageCounterLabel, 5, 0);
			footerLayout.Controls.Add(nextPageButton, 4, 0);
			footerLayout.Controls.Add(previousPageButton, 3, 0);
			footerLayout.Controls.Add(endBtn, 0, 0);
			footerLayout.Dock = DockStyle.Fill;
			footerLayout.Location = new Point(3, 372);
			footerLayout.Margin = new Padding(3, 2, 3, 2);
			footerLayout.Name = "footerLayout";
			footerLayout.RowCount = 1;
			footerLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			footerLayout.Size = new Size(413, 52);
			footerLayout.TabIndex = 1;
			// 
			// pageCounterLabel
			// 
			pageCounterLabel.Anchor = AnchorStyles.Left;
			pageCounterLabel.AutoSize = true;
			pageCounterLabel.Location = new Point(356, 18);
			pageCounterLabel.Name = "pageCounterLabel";
			pageCounterLabel.Size = new Size(38, 15);
			pageCounterLabel.TabIndex = 4;
			pageCounterLabel.Text = "label1";
			// 
			// nextPageButton
			// 
			nextPageButton.Image = (Image)resources.GetObject("nextPageButton.Image");
			nextPageButton.Location = new Point(299, 2);
			nextPageButton.Margin = new Padding(3, 2, 3, 2);
			nextPageButton.Name = "nextPageButton";
			nextPageButton.Size = new Size(51, 47);
			nextPageButton.TabIndex = 3;
			nextPageButton.TabStop = false;
			nextPageButton.Click += nextPageButton_Click;
			// 
			// previousPageButton
			// 
			previousPageButton.Image = (Image)resources.GetObject("previousPageButton.Image");
			previousPageButton.Location = new Point(242, 2);
			previousPageButton.Margin = new Padding(3, 2, 3, 2);
			previousPageButton.Name = "previousPageButton";
			previousPageButton.Size = new Size(51, 47);
			previousPageButton.TabIndex = 2;
			previousPageButton.TabStop = false;
			previousPageButton.Click += previousPageButton_Click;
			// 
			// usersView
			// 
			usersView.AllowUserToAddRows = false;
			usersView.AllowUserToDeleteRows = false;
			usersView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			usersView.BackgroundColor = SystemColors.Control;
			usersView.BorderStyle = BorderStyle.None;
			dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle14.BackColor = Color.Blue;
			dataGridViewCellStyle14.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
			dataGridViewCellStyle14.ForeColor = Color.White;
			dataGridViewCellStyle14.SelectionBackColor = Color.Blue;
			dataGridViewCellStyle14.SelectionForeColor = Color.White;
			dataGridViewCellStyle14.WrapMode = DataGridViewTriState.True;
			usersView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
			usersView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			usersView.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, qualificatedoo, DetailsBtn, qulifactedbtn });
			usersView.Dock = DockStyle.Fill;
			usersView.EnableHeadersVisualStyles = false;
			usersView.Location = new Point(434, 5);
			usersView.Margin = new Padding(3, 2, 3, 2);
			usersView.MultiSelect = false;
			usersView.Name = "usersView";
			usersView.RowHeadersVisible = false;
			usersView.RowHeadersWidth = 51;
			usersView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			usersView.RowTemplate.Height = 29;
			usersView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			usersView.Size = new Size(633, 426);
			usersView.TabIndex = 2;
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
			dataGridViewCellStyle15.BackColor = Color.FromArgb(128, 255, 255);
			dataGridViewCellStyle15.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			dataGridViewCellStyle15.ForeColor = Color.Black;
			dataGridViewCellStyle15.SelectionBackColor = Color.FromArgb(0, 192, 192);
			dataGridViewCellStyle15.SelectionForeColor = Color.Black;
			dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle15;
			dataGridViewTextBoxColumn2.FillWeight = 230F;
			dataGridViewTextBoxColumn2.HeaderText = "Imię i Nazwisko";
			dataGridViewTextBoxColumn2.MinimumWidth = 6;
			dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			dataGridViewTextBoxColumn2.ReadOnly = true;
			// 
			// qualificatedoo
			// 
			dataGridViewCellStyle16.BackColor = Color.FromArgb(128, 255, 255);
			dataGridViewCellStyle16.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			dataGridViewCellStyle16.ForeColor = Color.Black;
			dataGridViewCellStyle16.SelectionBackColor = Color.FromArgb(0, 192, 192);
			dataGridViewCellStyle16.SelectionForeColor = Color.Black;
			qualificatedoo.DefaultCellStyle = dataGridViewCellStyle16;
			qualificatedoo.HeaderText = "Kwalifikacja do rozmowy rekrutacyjnej";
			qualificatedoo.MinimumWidth = 6;
			qualificatedoo.Name = "qualificatedoo";
			qualificatedoo.ReadOnly = true;
			// 
			// DetailsBtn
			// 
			DetailsBtn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dataGridViewCellStyle17.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle17.BackColor = Color.Navy;
			dataGridViewCellStyle17.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			dataGridViewCellStyle17.ForeColor = Color.White;
			dataGridViewCellStyle17.SelectionBackColor = Color.Navy;
			dataGridViewCellStyle17.SelectionForeColor = Color.White;
			DetailsBtn.DefaultCellStyle = dataGridViewCellStyle17;
			DetailsBtn.FillWeight = 250F;
			DetailsBtn.FlatStyle = FlatStyle.Popup;
			DetailsBtn.HeaderText = "Szczegóły";
			DetailsBtn.MinimumWidth = 6;
			DetailsBtn.Name = "DetailsBtn";
			DetailsBtn.Text = "Wyświetl szczegóły!";
			DetailsBtn.UseColumnTextForButtonValue = true;
			// 
			// qulifactedbtn
			// 
			dataGridViewCellStyle18.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle18.BackColor = Color.Navy;
			dataGridViewCellStyle18.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			dataGridViewCellStyle18.ForeColor = Color.White;
			dataGridViewCellStyle18.SelectionBackColor = Color.Navy;
			dataGridViewCellStyle18.SelectionForeColor = Color.White;
			qulifactedbtn.DefaultCellStyle = dataGridViewCellStyle18;
			qulifactedbtn.FlatStyle = FlatStyle.Popup;
			qulifactedbtn.HeaderText = "Kwalifikacja";
			qulifactedbtn.MinimumWidth = 6;
			qulifactedbtn.Name = "qulifactedbtn";
			qulifactedbtn.Text = "Zakwalifikuj";
			qulifactedbtn.UseColumnTextForButtonValue = true;
			// 
			// endBtn
			// 
			endBtn.Dock = DockStyle.Fill;
			endBtn.FlatStyle = FlatStyle.Flat;
			endBtn.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
			endBtn.Location = new Point(3, 3);
			endBtn.Name = "endBtn";
			endBtn.Size = new Size(105, 46);
			endBtn.TabIndex = 5;
			endBtn.Text = "Zakończ";
			endBtn.UseVisualStyleBackColor = true;
			endBtn.Click += endBtn_Click;
			// 
			// ManagerCurrentsRegistrationsView
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(tableLayoutPanel);
			Margin = new Padding(3, 2, 3, 2);
			Name = "ManagerCurrentsRegistrationsView";
			Size = new Size(1073, 436);
			tableLayoutPanel.ResumeLayout(false);
			mainLayout.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)jobOffersDGV).EndInit();
			footerLayout.ResumeLayout(false);
			footerLayout.PerformLayout();
			((System.ComponentModel.ISupportInitialize)nextPageButton).EndInit();
			((System.ComponentModel.ISupportInitialize)previousPageButton).EndInit();
			((System.ComponentModel.ISupportInitialize)usersView).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private TableLayoutPanel tableLayoutPanel;
		private DataGridView usersView;
		private TableLayoutPanel mainLayout;
		private DataGridView jobOffersDGV;
		private TableLayoutPanel footerLayout;
		private Label pageCounterLabel;
		private PictureBox nextPageButton;
		private PictureBox previousPageButton;
		private DataGridViewTextBoxColumn Id;
		private DataGridViewTextBoxColumn Position;
		private DataGridViewTextBoxColumn AddedDate;
		private DataGridViewTextBoxColumn EndedDate;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private DataGridViewTextBoxColumn qualificatedoo;
		private DataGridViewButtonColumn DetailsBtn;
		private DataGridViewButtonColumn qulifactedbtn;
		private Button endBtn;
	}
}
