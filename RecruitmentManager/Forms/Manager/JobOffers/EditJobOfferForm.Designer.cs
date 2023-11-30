namespace RecruitmentManager.Forms.Manager.JobOffers
{
	partial class EditJobOfferForm
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
			components = new System.ComponentModel.Container();
			DataGridViewCellStyle dataGridViewCellStyle21 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle22 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle23 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle24 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle25 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle26 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle27 = new DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditJobOfferForm));
			DataGridViewCellStyle dataGridViewCellStyle28 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle29 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle30 = new DataGridViewCellStyle();
			addRecruitmentStageBtn = new Button();
			Data = new DataGridViewTextBoxColumn();
			secondPageLeftLayout = new TableLayoutPanel();
			recruitmentStagesDGV = new DataGridView();
			id_recruitmentstages = new DataGridViewTextBoxColumn();
			dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
			Order = new DataGridViewTextBoxColumn();
			Weight = new DataGridViewTextBoxColumn();
			NameColumn = new DataGridViewTextBoxColumn();
			EndedDate = new DataGridViewTextBoxColumn();
			PasswdReset = new DataGridViewButtonColumn();
			secondPageControlsLayout = new TableLayoutPanel();
			secondPageDesciptionLayout = new TableLayoutPanel();
			stageNamePB = new PictureBox();
			stageNameTitle = new RichTextBox();
			secondPageCountersLayout = new TableLayoutPanel();
			stageOrderPB = new PictureBox();
			weightPB = new PictureBox();
			orderUpAndDown = new NumericUpDown();
			weightUpAndDown = new NumericUpDown();
			secondPageButtonsLayout = new TableLayoutPanel();
			Mail = new DataGridViewTextBoxColumn();
			toolTip = new ToolTip(components);
			Checkbox = new DataGridViewCheckBoxColumn();
			descriptionTextBox = new RichTextBox();
			tabControl = new TabControl();
			description_work = new TabPage();
			mainLayout = new TableLayoutPanel();
			middleLayout = new TableLayoutPanel();
			headerLayout = new TableLayoutPanel();
			titlePB = new PictureBox();
			titleTextBox = new RichTextBox();
			descriptionLayout = new TableLayoutPanel();
			descriptionPB = new PictureBox();
			footerTableLayout = new TableLayoutPanel();
			beginDatePB = new PictureBox();
			endDatePB = new PictureBox();
			beginDateDatePicker = new DateTimePicker();
			endDateDatePicker = new DateTimePicker();
			numberOfPlacesPB = new PictureBox();
			counterControl = new NumericUpDown();
			editBtn = new Button();
			stages = new TabPage();
			secondPageTableLayout = new TableLayoutPanel();
			recruiterDGV = new DataGridView();
			Id = new DataGridViewTextBoxColumn();
			secondPageLeftLayout.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)recruitmentStagesDGV).BeginInit();
			secondPageControlsLayout.SuspendLayout();
			secondPageDesciptionLayout.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)stageNamePB).BeginInit();
			secondPageCountersLayout.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)stageOrderPB).BeginInit();
			((System.ComponentModel.ISupportInitialize)weightPB).BeginInit();
			((System.ComponentModel.ISupportInitialize)orderUpAndDown).BeginInit();
			((System.ComponentModel.ISupportInitialize)weightUpAndDown).BeginInit();
			secondPageButtonsLayout.SuspendLayout();
			tabControl.SuspendLayout();
			description_work.SuspendLayout();
			mainLayout.SuspendLayout();
			middleLayout.SuspendLayout();
			headerLayout.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)titlePB).BeginInit();
			descriptionLayout.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)descriptionPB).BeginInit();
			footerTableLayout.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)beginDatePB).BeginInit();
			((System.ComponentModel.ISupportInitialize)endDatePB).BeginInit();
			((System.ComponentModel.ISupportInitialize)numberOfPlacesPB).BeginInit();
			((System.ComponentModel.ISupportInitialize)counterControl).BeginInit();
			stages.SuspendLayout();
			secondPageTableLayout.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)recruiterDGV).BeginInit();
			SuspendLayout();
			// 
			// addRecruitmentStageBtn
			// 
			addRecruitmentStageBtn.Dock = DockStyle.Fill;
			addRecruitmentStageBtn.FlatStyle = FlatStyle.Flat;
			addRecruitmentStageBtn.Location = new Point(487, 3);
			addRecruitmentStageBtn.Name = "addRecruitmentStageBtn";
			addRecruitmentStageBtn.Size = new Size(237, 59);
			addRecruitmentStageBtn.TabIndex = 0;
			addRecruitmentStageBtn.Text = "Dodaj Nowy Etap Rekrutacji";
			addRecruitmentStageBtn.UseVisualStyleBackColor = true;
			addRecruitmentStageBtn.Click += addRecruitmentStageBtn_Click_1;
			// 
			// Data
			// 
			dataGridViewCellStyle21.BackColor = Color.FromArgb(128, 255, 255);
			dataGridViewCellStyle21.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			dataGridViewCellStyle21.ForeColor = Color.Black;
			dataGridViewCellStyle21.SelectionBackColor = Color.FromArgb(128, 255, 255);
			dataGridViewCellStyle21.SelectionForeColor = Color.Black;
			Data.DefaultCellStyle = dataGridViewCellStyle21;
			Data.HeaderText = "Imię i nazwisko";
			Data.MinimumWidth = 6;
			Data.Name = "Data";
			Data.ReadOnly = true;
			// 
			// secondPageLeftLayout
			// 
			secondPageLeftLayout.ColumnCount = 1;
			secondPageLeftLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			secondPageLeftLayout.Controls.Add(recruitmentStagesDGV, 0, 0);
			secondPageLeftLayout.Controls.Add(secondPageControlsLayout, 0, 1);
			secondPageLeftLayout.Dock = DockStyle.Fill;
			secondPageLeftLayout.Location = new Point(3, 3);
			secondPageLeftLayout.Name = "secondPageLeftLayout";
			secondPageLeftLayout.RowCount = 2;
			secondPageLeftLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
			secondPageLeftLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
			secondPageLeftLayout.Size = new Size(733, 517);
			secondPageLeftLayout.TabIndex = 2;
			// 
			// recruitmentStagesDGV
			// 
			recruitmentStagesDGV.AllowUserToAddRows = false;
			recruitmentStagesDGV.AllowUserToDeleteRows = false;
			recruitmentStagesDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			recruitmentStagesDGV.BackgroundColor = SystemColors.Control;
			recruitmentStagesDGV.BorderStyle = BorderStyle.None;
			dataGridViewCellStyle22.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle22.BackColor = Color.Blue;
			dataGridViewCellStyle22.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
			dataGridViewCellStyle22.ForeColor = Color.White;
			dataGridViewCellStyle22.SelectionBackColor = Color.Blue;
			dataGridViewCellStyle22.SelectionForeColor = Color.White;
			dataGridViewCellStyle22.WrapMode = DataGridViewTriState.True;
			recruitmentStagesDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
			recruitmentStagesDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			recruitmentStagesDGV.Columns.AddRange(new DataGridViewColumn[] { id_recruitmentstages, dataGridViewTextBoxColumn1, Order, Weight, NameColumn, EndedDate, PasswdReset });
			recruitmentStagesDGV.Dock = DockStyle.Fill;
			recruitmentStagesDGV.EnableHeadersVisualStyles = false;
			recruitmentStagesDGV.Location = new Point(3, 3);
			recruitmentStagesDGV.MultiSelect = false;
			recruitmentStagesDGV.Name = "recruitmentStagesDGV";
			recruitmentStagesDGV.RowHeadersVisible = false;
			recruitmentStagesDGV.RowHeadersWidth = 51;
			recruitmentStagesDGV.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			recruitmentStagesDGV.RowTemplate.Height = 29;
			recruitmentStagesDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			recruitmentStagesDGV.Size = new Size(727, 304);
			recruitmentStagesDGV.TabIndex = 1;
			recruitmentStagesDGV.CellContentClick += recruitmentStagesDGV_CellContentClick;
			recruitmentStagesDGV.SizeChanged += recruitmentStagesDGV_SizeChanged;
			// 
			// id_recruitmentstages
			// 
			id_recruitmentstages.HeaderText = "id_recruitmentstage";
			id_recruitmentstages.MinimumWidth = 6;
			id_recruitmentstages.Name = "id_recruitmentstages";
			id_recruitmentstages.ReadOnly = true;
			id_recruitmentstages.Visible = false;
			// 
			// dataGridViewTextBoxColumn1
			// 
			dataGridViewTextBoxColumn1.HeaderText = "ID pracownika";
			dataGridViewTextBoxColumn1.MinimumWidth = 6;
			dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			dataGridViewTextBoxColumn1.ReadOnly = true;
			dataGridViewTextBoxColumn1.Visible = false;
			// 
			// Order
			// 
			Order.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dataGridViewCellStyle23.BackColor = Color.FromArgb(128, 255, 255);
			dataGridViewCellStyle23.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			dataGridViewCellStyle23.ForeColor = Color.Black;
			dataGridViewCellStyle23.SelectionBackColor = Color.FromArgb(0, 192, 192);
			dataGridViewCellStyle23.SelectionForeColor = Color.Black;
			Order.DefaultCellStyle = dataGridViewCellStyle23;
			Order.FillWeight = 230F;
			Order.HeaderText = "Kolejność";
			Order.MinimumWidth = 6;
			Order.Name = "Order";
			Order.ReadOnly = true;
			// 
			// Weight
			// 
			Weight.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dataGridViewCellStyle24.BackColor = Color.FromArgb(128, 255, 255);
			dataGridViewCellStyle24.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			dataGridViewCellStyle24.ForeColor = Color.Black;
			dataGridViewCellStyle24.SelectionBackColor = Color.FromArgb(0, 192, 192);
			dataGridViewCellStyle24.SelectionForeColor = Color.Black;
			Weight.DefaultCellStyle = dataGridViewCellStyle24;
			Weight.FillWeight = 280.748657F;
			Weight.HeaderText = "Waga";
			Weight.MinimumWidth = 6;
			Weight.Name = "Weight";
			Weight.ReadOnly = true;
			// 
			// NameColumn
			// 
			dataGridViewCellStyle25.BackColor = Color.FromArgb(192, 255, 255);
			dataGridViewCellStyle25.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			dataGridViewCellStyle25.ForeColor = Color.Black;
			dataGridViewCellStyle25.SelectionBackColor = Color.FromArgb(0, 192, 192);
			dataGridViewCellStyle25.SelectionForeColor = Color.Black;
			NameColumn.DefaultCellStyle = dataGridViewCellStyle25;
			NameColumn.HeaderText = "Nazwa";
			NameColumn.MinimumWidth = 6;
			NameColumn.Name = "NameColumn";
			NameColumn.ReadOnly = true;
			// 
			// EndedDate
			// 
			dataGridViewCellStyle26.BackColor = Color.FromArgb(128, 255, 255);
			dataGridViewCellStyle26.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			dataGridViewCellStyle26.ForeColor = Color.Black;
			dataGridViewCellStyle26.SelectionBackColor = Color.FromArgb(0, 192, 192);
			dataGridViewCellStyle26.SelectionForeColor = Color.Black;
			EndedDate.DefaultCellStyle = dataGridViewCellStyle26;
			EndedDate.HeaderText = "Pracownik";
			EndedDate.MinimumWidth = 6;
			EndedDate.Name = "EndedDate";
			EndedDate.ReadOnly = true;
			// 
			// PasswdReset
			// 
			PasswdReset.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dataGridViewCellStyle27.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle27.BackColor = Color.Navy;
			dataGridViewCellStyle27.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			dataGridViewCellStyle27.ForeColor = Color.White;
			dataGridViewCellStyle27.SelectionBackColor = Color.Navy;
			dataGridViewCellStyle27.SelectionForeColor = Color.White;
			PasswdReset.DefaultCellStyle = dataGridViewCellStyle27;
			PasswdReset.FillWeight = 250F;
			PasswdReset.FlatStyle = FlatStyle.Popup;
			PasswdReset.HeaderText = "Usuwanie";
			PasswdReset.MinimumWidth = 6;
			PasswdReset.Name = "PasswdReset";
			PasswdReset.Text = "Usuń";
			PasswdReset.UseColumnTextForButtonValue = true;
			// 
			// secondPageControlsLayout
			// 
			secondPageControlsLayout.ColumnCount = 1;
			secondPageControlsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			secondPageControlsLayout.Controls.Add(secondPageDesciptionLayout, 0, 0);
			secondPageControlsLayout.Controls.Add(secondPageCountersLayout, 0, 1);
			secondPageControlsLayout.Controls.Add(secondPageButtonsLayout, 0, 2);
			secondPageControlsLayout.Dock = DockStyle.Fill;
			secondPageControlsLayout.Location = new Point(0, 310);
			secondPageControlsLayout.Margin = new Padding(0);
			secondPageControlsLayout.Name = "secondPageControlsLayout";
			secondPageControlsLayout.RowCount = 3;
			secondPageControlsLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			secondPageControlsLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			secondPageControlsLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
			secondPageControlsLayout.Size = new Size(733, 207);
			secondPageControlsLayout.TabIndex = 2;
			// 
			// secondPageDesciptionLayout
			// 
			secondPageDesciptionLayout.ColumnCount = 2;
			secondPageDesciptionLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 85F));
			secondPageDesciptionLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			secondPageDesciptionLayout.Controls.Add(stageNamePB, 0, 0);
			secondPageDesciptionLayout.Controls.Add(stageNameTitle, 1, 0);
			secondPageDesciptionLayout.Dock = DockStyle.Fill;
			secondPageDesciptionLayout.Location = new Point(3, 3);
			secondPageDesciptionLayout.Name = "secondPageDesciptionLayout";
			secondPageDesciptionLayout.RowCount = 1;
			secondPageDesciptionLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			secondPageDesciptionLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
			secondPageDesciptionLayout.Size = new Size(727, 62);
			secondPageDesciptionLayout.TabIndex = 0;
			// 
			// stageNamePB
			// 
			stageNamePB.Dock = DockStyle.Fill;
			stageNamePB.Image = (Image)resources.GetObject("stageNamePB.Image");
			stageNamePB.Location = new Point(3, 3);
			stageNamePB.Name = "stageNamePB";
			stageNamePB.Size = new Size(79, 56);
			stageNamePB.TabIndex = 0;
			stageNamePB.TabStop = false;
			// 
			// stageNameTitle
			// 
			stageNameTitle.BorderStyle = BorderStyle.FixedSingle;
			stageNameTitle.Dock = DockStyle.Fill;
			stageNameTitle.Location = new Point(88, 3);
			stageNameTitle.Name = "stageNameTitle";
			stageNameTitle.Size = new Size(636, 56);
			stageNameTitle.TabIndex = 1;
			stageNameTitle.Text = "";
			// 
			// secondPageCountersLayout
			// 
			secondPageCountersLayout.ColumnCount = 4;
			secondPageCountersLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 85F));
			secondPageCountersLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			secondPageCountersLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 85F));
			secondPageCountersLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			secondPageCountersLayout.Controls.Add(stageOrderPB, 0, 0);
			secondPageCountersLayout.Controls.Add(weightPB, 2, 0);
			secondPageCountersLayout.Controls.Add(orderUpAndDown, 1, 0);
			secondPageCountersLayout.Controls.Add(weightUpAndDown, 3, 0);
			secondPageCountersLayout.Dock = DockStyle.Fill;
			secondPageCountersLayout.Location = new Point(3, 71);
			secondPageCountersLayout.Name = "secondPageCountersLayout";
			secondPageCountersLayout.RowCount = 1;
			secondPageCountersLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			secondPageCountersLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
			secondPageCountersLayout.Size = new Size(727, 62);
			secondPageCountersLayout.TabIndex = 1;
			// 
			// stageOrderPB
			// 
			stageOrderPB.Dock = DockStyle.Fill;
			stageOrderPB.Image = (Image)resources.GetObject("stageOrderPB.Image");
			stageOrderPB.Location = new Point(3, 3);
			stageOrderPB.Name = "stageOrderPB";
			stageOrderPB.Size = new Size(79, 56);
			stageOrderPB.TabIndex = 0;
			stageOrderPB.TabStop = false;
			// 
			// weightPB
			// 
			weightPB.Dock = DockStyle.Fill;
			weightPB.Image = (Image)resources.GetObject("weightPB.Image");
			weightPB.Location = new Point(366, 3);
			weightPB.Name = "weightPB";
			weightPB.Size = new Size(79, 56);
			weightPB.TabIndex = 1;
			weightPB.TabStop = false;
			// 
			// orderUpAndDown
			// 
			orderUpAndDown.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			orderUpAndDown.Location = new Point(88, 11);
			orderUpAndDown.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
			orderUpAndDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
			orderUpAndDown.Name = "orderUpAndDown";
			orderUpAndDown.Size = new Size(272, 39);
			orderUpAndDown.TabIndex = 2;
			orderUpAndDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
			// 
			// weightUpAndDown
			// 
			weightUpAndDown.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			weightUpAndDown.Location = new Point(451, 11);
			weightUpAndDown.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
			weightUpAndDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
			weightUpAndDown.Name = "weightUpAndDown";
			weightUpAndDown.Size = new Size(273, 39);
			weightUpAndDown.TabIndex = 3;
			weightUpAndDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
			// 
			// secondPageButtonsLayout
			// 
			secondPageButtonsLayout.ColumnCount = 3;
			secondPageButtonsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
			secondPageButtonsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
			secondPageButtonsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
			secondPageButtonsLayout.Controls.Add(addRecruitmentStageBtn, 2, 0);
			secondPageButtonsLayout.Dock = DockStyle.Fill;
			secondPageButtonsLayout.Location = new Point(3, 139);
			secondPageButtonsLayout.Name = "secondPageButtonsLayout";
			secondPageButtonsLayout.RowCount = 1;
			secondPageButtonsLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			secondPageButtonsLayout.Size = new Size(727, 65);
			secondPageButtonsLayout.TabIndex = 2;
			// 
			// Mail
			// 
			dataGridViewCellStyle28.BackColor = Color.FromArgb(128, 255, 255);
			dataGridViewCellStyle28.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			dataGridViewCellStyle28.ForeColor = Color.Black;
			dataGridViewCellStyle28.SelectionBackColor = Color.FromArgb(128, 255, 255);
			dataGridViewCellStyle28.SelectionForeColor = Color.Black;
			Mail.DefaultCellStyle = dataGridViewCellStyle28;
			Mail.HeaderText = "E-Mail";
			Mail.MinimumWidth = 6;
			Mail.Name = "Mail";
			Mail.ReadOnly = true;
			// 
			// toolTip
			// 
			toolTip.AutomaticDelay = 100;
			// 
			// Checkbox
			// 
			Checkbox.HeaderText = "Wybierz";
			Checkbox.MinimumWidth = 6;
			Checkbox.Name = "Checkbox";
			// 
			// descriptionTextBox
			// 
			descriptionTextBox.BackColor = SystemColors.Control;
			descriptionTextBox.Dock = DockStyle.Fill;
			descriptionTextBox.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
			descriptionTextBox.Location = new Point(88, 3);
			descriptionTextBox.Name = "descriptionTextBox";
			descriptionTextBox.Size = new Size(1141, 354);
			descriptionTextBox.TabIndex = 2;
			descriptionTextBox.Text = "";
			// 
			// tabControl
			// 
			tabControl.Controls.Add(description_work);
			tabControl.Controls.Add(stages);
			tabControl.Dock = DockStyle.Fill;
			tabControl.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
			tabControl.Location = new Point(0, 0);
			tabControl.Name = "tabControl";
			tabControl.SelectedIndex = 0;
			tabControl.Size = new Size(1246, 573);
			tabControl.TabIndex = 1;
			// 
			// description_work
			// 
			description_work.Controls.Add(mainLayout);
			description_work.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
			description_work.Location = new Point(4, 40);
			description_work.Name = "description_work";
			description_work.Padding = new Padding(3);
			description_work.Size = new Size(1238, 529);
			description_work.TabIndex = 0;
			description_work.Text = "Opis Stanowiska";
			description_work.UseVisualStyleBackColor = true;
			// 
			// mainLayout
			// 
			mainLayout.ColumnCount = 1;
			mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			mainLayout.Controls.Add(middleLayout, 0, 0);
			mainLayout.Controls.Add(footerTableLayout, 0, 1);
			mainLayout.Dock = DockStyle.Fill;
			mainLayout.Location = new Point(3, 3);
			mainLayout.Margin = new Padding(0);
			mainLayout.Name = "mainLayout";
			mainLayout.RowCount = 2;
			mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 85F));
			mainLayout.Size = new Size(1232, 523);
			mainLayout.TabIndex = 1;
			// 
			// middleLayout
			// 
			middleLayout.ColumnCount = 1;
			middleLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			middleLayout.Controls.Add(headerLayout, 0, 0);
			middleLayout.Controls.Add(descriptionLayout, 0, 1);
			middleLayout.Dock = DockStyle.Fill;
			middleLayout.Location = new Point(0, 0);
			middleLayout.Margin = new Padding(0);
			middleLayout.Name = "middleLayout";
			middleLayout.RowCount = 2;
			middleLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 18F));
			middleLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 82F));
			middleLayout.Size = new Size(1232, 438);
			middleLayout.TabIndex = 0;
			// 
			// headerLayout
			// 
			headerLayout.ColumnCount = 2;
			headerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 85F));
			headerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			headerLayout.Controls.Add(titlePB, 0, 0);
			headerLayout.Controls.Add(titleTextBox, 1, 0);
			headerLayout.Dock = DockStyle.Fill;
			headerLayout.Location = new Point(0, 0);
			headerLayout.Margin = new Padding(0);
			headerLayout.Name = "headerLayout";
			headerLayout.RowCount = 1;
			headerLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			headerLayout.Size = new Size(1232, 78);
			headerLayout.TabIndex = 0;
			// 
			// titlePB
			// 
			titlePB.Dock = DockStyle.Fill;
			titlePB.Image = (Image)resources.GetObject("titlePB.Image");
			titlePB.Location = new Point(3, 3);
			titlePB.Name = "titlePB";
			titlePB.Size = new Size(79, 72);
			titlePB.SizeMode = PictureBoxSizeMode.CenterImage;
			titlePB.TabIndex = 0;
			titlePB.TabStop = false;
			// 
			// titleTextBox
			// 
			titleTextBox.BackColor = SystemColors.Control;
			titleTextBox.Dock = DockStyle.Fill;
			titleTextBox.Font = new Font("Times New Roman", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
			titleTextBox.Location = new Point(88, 3);
			titleTextBox.Multiline = false;
			titleTextBox.Name = "titleTextBox";
			titleTextBox.Size = new Size(1141, 72);
			titleTextBox.TabIndex = 1;
			titleTextBox.Text = "";
			// 
			// descriptionLayout
			// 
			descriptionLayout.ColumnCount = 2;
			descriptionLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 85F));
			descriptionLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			descriptionLayout.Controls.Add(descriptionTextBox, 0, 0);
			descriptionLayout.Controls.Add(descriptionPB, 0, 0);
			descriptionLayout.Dock = DockStyle.Fill;
			descriptionLayout.Location = new Point(0, 78);
			descriptionLayout.Margin = new Padding(0);
			descriptionLayout.Name = "descriptionLayout";
			descriptionLayout.RowCount = 1;
			descriptionLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			descriptionLayout.Size = new Size(1232, 360);
			descriptionLayout.TabIndex = 1;
			// 
			// descriptionPB
			// 
			descriptionPB.Dock = DockStyle.Top;
			descriptionPB.Image = (Image)resources.GetObject("descriptionPB.Image");
			descriptionPB.Location = new Point(3, 3);
			descriptionPB.Name = "descriptionPB";
			descriptionPB.Size = new Size(79, 75);
			descriptionPB.SizeMode = PictureBoxSizeMode.AutoSize;
			descriptionPB.TabIndex = 0;
			descriptionPB.TabStop = false;
			// 
			// footerTableLayout
			// 
			footerTableLayout.ColumnCount = 7;
			footerTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 85F));
			footerTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
			footerTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 85F));
			footerTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
			footerTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 85F));
			footerTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 85F));
			footerTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
			footerTableLayout.Controls.Add(beginDatePB, 0, 0);
			footerTableLayout.Controls.Add(endDatePB, 2, 0);
			footerTableLayout.Controls.Add(beginDateDatePicker, 1, 0);
			footerTableLayout.Controls.Add(endDateDatePicker, 3, 0);
			footerTableLayout.Controls.Add(numberOfPlacesPB, 4, 0);
			footerTableLayout.Controls.Add(counterControl, 5, 0);
			footerTableLayout.Controls.Add(editBtn, 6, 0);
			footerTableLayout.Dock = DockStyle.Fill;
			footerTableLayout.Location = new Point(0, 438);
			footerTableLayout.Margin = new Padding(0);
			footerTableLayout.Name = "footerTableLayout";
			footerTableLayout.RowCount = 1;
			footerTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			footerTableLayout.Size = new Size(1232, 85);
			footerTableLayout.TabIndex = 1;
			// 
			// beginDatePB
			// 
			beginDatePB.Dock = DockStyle.Fill;
			beginDatePB.Image = (Image)resources.GetObject("beginDatePB.Image");
			beginDatePB.Location = new Point(0, 0);
			beginDatePB.Margin = new Padding(0);
			beginDatePB.Name = "beginDatePB";
			beginDatePB.Size = new Size(85, 85);
			beginDatePB.TabIndex = 0;
			beginDatePB.TabStop = false;
			// 
			// endDatePB
			// 
			endDatePB.Dock = DockStyle.Fill;
			endDatePB.Image = (Image)resources.GetObject("endDatePB.Image");
			endDatePB.Location = new Point(382, 0);
			endDatePB.Margin = new Padding(0);
			endDatePB.Name = "endDatePB";
			endDatePB.Size = new Size(85, 85);
			endDatePB.TabIndex = 1;
			endDatePB.TabStop = false;
			// 
			// beginDateDatePicker
			// 
			beginDateDatePicker.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			beginDateDatePicker.CalendarFont = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
			beginDateDatePicker.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
			beginDateDatePicker.Location = new Point(88, 29);
			beginDateDatePicker.Name = "beginDateDatePicker";
			beginDateDatePicker.Size = new Size(291, 27);
			beginDateDatePicker.TabIndex = 2;
			// 
			// endDateDatePicker
			// 
			endDateDatePicker.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			endDateDatePicker.CalendarFont = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
			endDateDatePicker.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
			endDateDatePicker.Location = new Point(470, 29);
			endDateDatePicker.Name = "endDateDatePicker";
			endDateDatePicker.Size = new Size(291, 27);
			endDateDatePicker.TabIndex = 3;
			// 
			// numberOfPlacesPB
			// 
			numberOfPlacesPB.Dock = DockStyle.Fill;
			numberOfPlacesPB.Image = (Image)resources.GetObject("numberOfPlacesPB.Image");
			numberOfPlacesPB.Location = new Point(764, 0);
			numberOfPlacesPB.Margin = new Padding(0);
			numberOfPlacesPB.Name = "numberOfPlacesPB";
			numberOfPlacesPB.Size = new Size(85, 85);
			numberOfPlacesPB.TabIndex = 4;
			numberOfPlacesPB.TabStop = false;
			// 
			// counterControl
			// 
			counterControl.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			counterControl.Location = new Point(852, 23);
			counterControl.Maximum = new decimal(new int[] { 25, 0, 0, 0 });
			counterControl.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
			counterControl.Name = "counterControl";
			counterControl.Size = new Size(79, 39);
			counterControl.TabIndex = 5;
			counterControl.TextAlign = HorizontalAlignment.Center;
			counterControl.Value = new decimal(new int[] { 1, 0, 0, 0 });
			// 
			// editBtn
			// 
			editBtn.Dock = DockStyle.Fill;
			editBtn.FlatStyle = FlatStyle.Flat;
			editBtn.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
			editBtn.Location = new Point(937, 3);
			editBtn.Name = "editBtn";
			editBtn.Size = new Size(292, 79);
			editBtn.TabIndex = 6;
			editBtn.Text = "Edytuj";
			editBtn.UseVisualStyleBackColor = true;
			editBtn.Click += editBtn_Click;
			// 
			// stages
			// 
			stages.Controls.Add(secondPageTableLayout);
			stages.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
			stages.Location = new Point(4, 40);
			stages.Name = "stages";
			stages.Padding = new Padding(3);
			stages.Size = new Size(1238, 529);
			stages.TabIndex = 1;
			stages.Text = "Etapy Rekrutacji";
			stages.UseVisualStyleBackColor = true;
			// 
			// secondPageTableLayout
			// 
			secondPageTableLayout.ColumnCount = 2;
			secondPageTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
			secondPageTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
			secondPageTableLayout.Controls.Add(recruiterDGV, 1, 0);
			secondPageTableLayout.Controls.Add(secondPageLeftLayout, 0, 0);
			secondPageTableLayout.Dock = DockStyle.Fill;
			secondPageTableLayout.Location = new Point(3, 3);
			secondPageTableLayout.Name = "secondPageTableLayout";
			secondPageTableLayout.RowCount = 1;
			secondPageTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			secondPageTableLayout.Size = new Size(1232, 523);
			secondPageTableLayout.TabIndex = 0;
			// 
			// recruiterDGV
			// 
			recruiterDGV.AllowUserToAddRows = false;
			recruiterDGV.AllowUserToDeleteRows = false;
			recruiterDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			recruiterDGV.BackgroundColor = SystemColors.Control;
			recruiterDGV.BorderStyle = BorderStyle.None;
			dataGridViewCellStyle29.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle29.BackColor = Color.Blue;
			dataGridViewCellStyle29.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
			dataGridViewCellStyle29.ForeColor = Color.White;
			dataGridViewCellStyle29.SelectionBackColor = Color.Blue;
			dataGridViewCellStyle29.SelectionForeColor = Color.White;
			dataGridViewCellStyle29.WrapMode = DataGridViewTriState.True;
			recruiterDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle29;
			recruiterDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			recruiterDGV.Columns.AddRange(new DataGridViewColumn[] { Id, Checkbox, Mail, Data });
			recruiterDGV.Dock = DockStyle.Fill;
			recruiterDGV.EnableHeadersVisualStyles = false;
			recruiterDGV.Location = new Point(742, 3);
			recruiterDGV.Name = "recruiterDGV";
			recruiterDGV.RowHeadersVisible = false;
			recruiterDGV.RowHeadersWidth = 51;
			recruiterDGV.RowTemplate.Height = 29;
			recruiterDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			recruiterDGV.Size = new Size(487, 517);
			recruiterDGV.TabIndex = 1;
			// 
			// Id
			// 
			dataGridViewCellStyle30.SelectionBackColor = Color.White;
			dataGridViewCellStyle30.SelectionForeColor = Color.Black;
			Id.DefaultCellStyle = dataGridViewCellStyle30;
			Id.HeaderText = "ID";
			Id.MinimumWidth = 6;
			Id.Name = "Id";
			Id.ReadOnly = true;
			Id.Visible = false;
			// 
			// EditJobOfferForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1246, 573);
			Controls.Add(tabControl);
			Name = "EditJobOfferForm";
			Text = "EditJobOfferForm";
			secondPageLeftLayout.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)recruitmentStagesDGV).EndInit();
			secondPageControlsLayout.ResumeLayout(false);
			secondPageDesciptionLayout.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)stageNamePB).EndInit();
			secondPageCountersLayout.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)stageOrderPB).EndInit();
			((System.ComponentModel.ISupportInitialize)weightPB).EndInit();
			((System.ComponentModel.ISupportInitialize)orderUpAndDown).EndInit();
			((System.ComponentModel.ISupportInitialize)weightUpAndDown).EndInit();
			secondPageButtonsLayout.ResumeLayout(false);
			tabControl.ResumeLayout(false);
			description_work.ResumeLayout(false);
			mainLayout.ResumeLayout(false);
			middleLayout.ResumeLayout(false);
			headerLayout.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)titlePB).EndInit();
			descriptionLayout.ResumeLayout(false);
			descriptionLayout.PerformLayout();
			((System.ComponentModel.ISupportInitialize)descriptionPB).EndInit();
			footerTableLayout.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)beginDatePB).EndInit();
			((System.ComponentModel.ISupportInitialize)endDatePB).EndInit();
			((System.ComponentModel.ISupportInitialize)numberOfPlacesPB).EndInit();
			((System.ComponentModel.ISupportInitialize)counterControl).EndInit();
			stages.ResumeLayout(false);
			secondPageTableLayout.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)recruiterDGV).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private Button addRecruitmentStageBtn;
		private DataGridViewTextBoxColumn Data;
		private TableLayoutPanel secondPageLeftLayout;
		private DataGridView recruitmentStagesDGV;
		private TableLayoutPanel secondPageControlsLayout;
		private TableLayoutPanel secondPageDesciptionLayout;
		private PictureBox stageNamePB;
		private RichTextBox stageNameTitle;
		private TableLayoutPanel secondPageCountersLayout;
		private PictureBox stageOrderPB;
		private PictureBox weightPB;
		private NumericUpDown orderUpAndDown;
		private NumericUpDown weightUpAndDown;
		private TableLayoutPanel secondPageButtonsLayout;
		private DataGridViewTextBoxColumn Mail;
		private ToolTip toolTip;
		private DataGridViewCheckBoxColumn Checkbox;
		private RichTextBox descriptionTextBox;
		private TabControl tabControl;
		private TabPage description_work;
		private TableLayoutPanel mainLayout;
		private TableLayoutPanel middleLayout;
		private TableLayoutPanel headerLayout;
		private PictureBox titlePB;
		private RichTextBox titleTextBox;
		private TableLayoutPanel descriptionLayout;
		private PictureBox descriptionPB;
		private TableLayoutPanel footerTableLayout;
		private PictureBox beginDatePB;
		private PictureBox endDatePB;
		private DateTimePicker beginDateDatePicker;
		private DateTimePicker endDateDatePicker;
		private PictureBox numberOfPlacesPB;
		private NumericUpDown counterControl;
		private Button editBtn;
		private TabPage stages;
		private TableLayoutPanel secondPageTableLayout;
		private DataGridView recruiterDGV;
		private DataGridViewTextBoxColumn Id;
		private DataGridViewTextBoxColumn id_recruitmentstages;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private DataGridViewTextBoxColumn Order;
		private DataGridViewTextBoxColumn Weight;
		private DataGridViewTextBoxColumn NameColumn;
		private DataGridViewTextBoxColumn EndedDate;
		private DataGridViewButtonColumn PasswdReset;
	}
}