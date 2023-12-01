namespace RecruitmentManager.Forms.Recruiter.Assessment
{
	partial class RateCandidateForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RateCandidateForm));
			tableLayoutPanel = new TableLayoutPanel();
			rateBtn = new Button();
			tableLayoutPanel1 = new TableLayoutPanel();
			tableLayoutPanel2 = new TableLayoutPanel();
			notesPB = new PictureBox();
			noteTb = new RichTextBox();
			tableLayoutPanel3 = new TableLayoutPanel();
			ratePB = new PictureBox();
			hasResignedCB = new CheckBox();
			rateNumericUpAndDown = new NumericUpDown();
			tableLayoutPanel.SuspendLayout();
			tableLayoutPanel1.SuspendLayout();
			tableLayoutPanel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)notesPB).BeginInit();
			tableLayoutPanel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)ratePB).BeginInit();
			((System.ComponentModel.ISupportInitialize)rateNumericUpAndDown).BeginInit();
			SuspendLayout();
			// 
			// tableLayoutPanel
			// 
			tableLayoutPanel.ColumnCount = 1;
			tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			tableLayoutPanel.Controls.Add(rateBtn, 0, 1);
			tableLayoutPanel.Controls.Add(tableLayoutPanel1, 0, 0);
			tableLayoutPanel.Dock = DockStyle.Fill;
			tableLayoutPanel.Location = new Point(0, 0);
			tableLayoutPanel.Name = "tableLayoutPanel";
			tableLayoutPanel.RowCount = 2;
			tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
			tableLayoutPanel.Size = new Size(595, 518);
			tableLayoutPanel.TabIndex = 0;
			// 
			// rateBtn
			// 
			rateBtn.Dock = DockStyle.Fill;
			rateBtn.FlatStyle = FlatStyle.Flat;
			rateBtn.Font = new Font("Times New Roman", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
			rateBtn.Location = new Point(3, 421);
			rateBtn.Name = "rateBtn";
			rateBtn.Size = new Size(589, 94);
			rateBtn.TabIndex = 0;
			rateBtn.Text = "Oceń";
			rateBtn.UseVisualStyleBackColor = true;
			rateBtn.Click += rateBtn_Click;
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.ColumnCount = 1;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
			tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 1);
			tableLayoutPanel1.Dock = DockStyle.Fill;
			tableLayoutPanel1.Location = new Point(3, 3);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 2;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
			tableLayoutPanel1.Size = new Size(589, 412);
			tableLayoutPanel1.TabIndex = 1;
			// 
			// tableLayoutPanel2
			// 
			tableLayoutPanel2.ColumnCount = 2;
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 85F));
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			tableLayoutPanel2.Controls.Add(notesPB, 0, 0);
			tableLayoutPanel2.Controls.Add(noteTb, 1, 0);
			tableLayoutPanel2.Dock = DockStyle.Fill;
			tableLayoutPanel2.Location = new Point(3, 3);
			tableLayoutPanel2.Name = "tableLayoutPanel2";
			tableLayoutPanel2.RowCount = 1;
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			tableLayoutPanel2.Size = new Size(583, 282);
			tableLayoutPanel2.TabIndex = 0;
			// 
			// notesPB
			// 
			notesPB.Image = (Image)resources.GetObject("notesPB.Image");
			notesPB.Location = new Point(3, 3);
			notesPB.Name = "notesPB";
			notesPB.Size = new Size(79, 86);
			notesPB.TabIndex = 0;
			notesPB.TabStop = false;
			// 
			// noteTb
			// 
			noteTb.Dock = DockStyle.Fill;
			noteTb.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
			noteTb.Location = new Point(88, 3);
			noteTb.Name = "noteTb";
			noteTb.Size = new Size(492, 276);
			noteTb.TabIndex = 1;
			noteTb.Text = "";
			// 
			// tableLayoutPanel3
			// 
			tableLayoutPanel3.ColumnCount = 3;
			tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 85F));
			tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel3.Controls.Add(ratePB, 0, 0);
			tableLayoutPanel3.Controls.Add(hasResignedCB, 2, 0);
			tableLayoutPanel3.Controls.Add(rateNumericUpAndDown, 1, 0);
			tableLayoutPanel3.Dock = DockStyle.Fill;
			tableLayoutPanel3.Location = new Point(3, 291);
			tableLayoutPanel3.Name = "tableLayoutPanel3";
			tableLayoutPanel3.RowCount = 1;
			tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			tableLayoutPanel3.Size = new Size(583, 118);
			tableLayoutPanel3.TabIndex = 1;
			// 
			// ratePB
			// 
			ratePB.Image = (Image)resources.GetObject("ratePB.Image");
			ratePB.Location = new Point(3, 3);
			ratePB.Name = "ratePB";
			ratePB.Size = new Size(79, 86);
			ratePB.TabIndex = 1;
			ratePB.TabStop = false;
			// 
			// hasResignedCB
			// 
			hasResignedCB.AutoSize = true;
			hasResignedCB.Dock = DockStyle.Fill;
			hasResignedCB.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
			hasResignedCB.Location = new Point(337, 3);
			hasResignedCB.Name = "hasResignedCB";
			hasResignedCB.Size = new Size(243, 112);
			hasResignedCB.TabIndex = 2;
			hasResignedCB.Text = "Czy kandydat zrezygnował ?";
			hasResignedCB.UseVisualStyleBackColor = true;
			// 
			// rateNumericUpAndDown
			// 
			rateNumericUpAndDown.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			rateNumericUpAndDown.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
			rateNumericUpAndDown.Location = new Point(88, 3);
			rateNumericUpAndDown.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
			rateNumericUpAndDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
			rateNumericUpAndDown.Name = "rateNumericUpAndDown";
			rateNumericUpAndDown.Size = new Size(243, 42);
			rateNumericUpAndDown.TabIndex = 3;
			rateNumericUpAndDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
			// 
			// RateCandidateForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(595, 518);
			Controls.Add(tableLayoutPanel);
			Name = "RateCandidateForm";
			Text = "Ocena kandydata";
			tableLayoutPanel.ResumeLayout(false);
			tableLayoutPanel1.ResumeLayout(false);
			tableLayoutPanel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)notesPB).EndInit();
			tableLayoutPanel3.ResumeLayout(false);
			tableLayoutPanel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)ratePB).EndInit();
			((System.ComponentModel.ISupportInitialize)rateNumericUpAndDown).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private TableLayoutPanel tableLayoutPanel;
		private Button rateBtn;
		private TableLayoutPanel tableLayoutPanel1;
		private TableLayoutPanel tableLayoutPanel2;
		private PictureBox notesPB;
		private RichTextBox noteTb;
		private TableLayoutPanel tableLayoutPanel3;
		private PictureBox ratePB;
		private CheckBox hasResignedCB;
		private NumericUpDown rateNumericUpAndDown;
	}
}