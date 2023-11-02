namespace RecruitmentManager.Forms.Manager.JobOffers
{
	partial class JobOffersMainView
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
			tabControl = new TabControl();
			actual = new TabPage();
			outofdate = new TabPage();
			tabControl.SuspendLayout();
			SuspendLayout();
			// 
			// tabControl
			// 
			tabControl.Controls.Add(actual);
			tabControl.Controls.Add(outofdate);
			tabControl.Dock = DockStyle.Fill;
			tabControl.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
			tabControl.Location = new Point(0, 0);
			tabControl.Name = "tabControl";
			tabControl.SelectedIndex = 0;
			tabControl.Size = new Size(1154, 522);
			tabControl.TabIndex = 0;
			tabControl.Selected += tabControl_Selected;
			// 
			// actual
			// 
			actual.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
			actual.Location = new Point(4, 40);
			actual.Name = "actual";
			actual.Padding = new Padding(3);
			actual.Size = new Size(1146, 478);
			actual.TabIndex = 0;
			actual.Text = "Aktualne";
			actual.UseVisualStyleBackColor = true;
			// 
			// outofdate
			// 
			outofdate.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
			outofdate.Location = new Point(4, 40);
			outofdate.Name = "outofdate";
			outofdate.Padding = new Padding(3);
			outofdate.Size = new Size(1146, 478);
			outofdate.TabIndex = 1;
			outofdate.Text = "Nieaktualne";
			outofdate.UseVisualStyleBackColor = true;
			// 
			// JobOffersMainView
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(tabControl);
			Name = "JobOffersMainView";
			Size = new Size(1154, 522);
			tabControl.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private TabControl tabControl;
		private TabPage actual;
		private TabPage outofdate;
	}
}
