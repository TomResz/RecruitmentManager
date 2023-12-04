namespace RecruitmentManager.Forms.Manager.JobOffers
{
	partial class JobOfferStatistics
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
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			total = new Label();
			label4 = new Label();
			resignationLabel = new Label();
			qualificatedCandidates = new Label();
			interviewHeld = new Label();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			label1.Location = new Point(12, 9);
			label1.Name = "label1";
			label1.Size = new Size(125, 21);
			label1.TabIndex = 0;
			label1.Text = "Ilość zgłoszeń :";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			label2.Location = new Point(12, 106);
			label2.Name = "label2";
			label2.Size = new Size(193, 21);
			label2.TabIndex = 1;
			label2.Text = "Ilość odbytych rozmów:";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			label3.Location = new Point(12, 39);
			label3.Name = "label3";
			label3.Size = new Size(135, 21);
			label3.TabIndex = 2;
			label3.Text = "Ilość rezygnacji :";
			// 
			// total
			// 
			total.AutoSize = true;
			total.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
			total.Location = new Point(143, 8);
			total.Name = "total";
			total.Size = new Size(59, 22);
			total.TabIndex = 4;
			total.Text = "label5";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			label4.Location = new Point(12, 71);
			label4.Name = "label4";
			label4.Size = new Size(292, 21);
			label4.TabIndex = 5;
			label4.Text = "Ilość zakwalifikowanych kandydatów:";
			// 
			// resignationLabel
			// 
			resignationLabel.AutoSize = true;
			resignationLabel.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
			resignationLabel.Location = new Point(143, 38);
			resignationLabel.Name = "resignationLabel";
			resignationLabel.Size = new Size(59, 22);
			resignationLabel.TabIndex = 6;
			resignationLabel.Text = "label5";
			// 
			// qualificatedCandidates
			// 
			qualificatedCandidates.AutoSize = true;
			qualificatedCandidates.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
			qualificatedCandidates.Location = new Point(310, 67);
			qualificatedCandidates.Name = "qualificatedCandidates";
			qualificatedCandidates.Size = new Size(65, 25);
			qualificatedCandidates.TabIndex = 7;
			qualificatedCandidates.Text = "label5";
			// 
			// interviewHeld
			// 
			interviewHeld.AutoSize = true;
			interviewHeld.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
			interviewHeld.Location = new Point(211, 105);
			interviewHeld.Name = "interviewHeld";
			interviewHeld.Size = new Size(59, 22);
			interviewHeld.TabIndex = 8;
			interviewHeld.Text = "label5";
			// 
			// JobOfferStatistics
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(503, 143);
			Controls.Add(interviewHeld);
			Controls.Add(qualificatedCandidates);
			Controls.Add(resignationLabel);
			Controls.Add(label4);
			Controls.Add(total);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			MaximumSize = new Size(519, 182);
			MinimumSize = new Size(519, 182);
			Name = "JobOfferStatistics";
			StartPosition = FormStartPosition.Manual;
			Text = "Statystyka";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private Label label3;
		private Label total;
		private Label label4;
		private Label resignationLabel;
		private Label qualificatedCandidates;
		private Label interviewHeld;
	}
}