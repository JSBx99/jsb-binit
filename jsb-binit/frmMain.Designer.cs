namespace jsb_binit
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			btnTest = new Button();
			msMain = new MenuStrip();
			fileToolStripMenuItem = new ToolStripMenuItem();
			tvMain = new TreeView();
			splitMain = new SplitContainer();
			msMain.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)splitMain).BeginInit();
			splitMain.Panel1.SuspendLayout();
			splitMain.Panel2.SuspendLayout();
			splitMain.SuspendLayout();
			SuspendLayout();
			// 
			// btnTest
			// 
			btnTest.Location = new Point(120, 170);
			btnTest.Name = "btnTest";
			btnTest.Size = new Size(176, 75);
			btnTest.TabIndex = 0;
			btnTest.Text = "Click Me!";
			btnTest.UseVisualStyleBackColor = true;
			btnTest.Click += btnTest_Click;
			// 
			// msMain
			// 
			msMain.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
			msMain.Location = new Point(0, 0);
			msMain.Name = "msMain";
			msMain.Size = new Size(824, 24);
			msMain.TabIndex = 1;
			msMain.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			fileToolStripMenuItem.Size = new Size(37, 20);
			fileToolStripMenuItem.Text = "File";
			// 
			// tvMain
			// 
			tvMain.Dock = DockStyle.Fill;
			tvMain.Location = new Point(0, 0);
			tvMain.Name = "tvMain";
			tvMain.Size = new Size(269, 445);
			tvMain.TabIndex = 2;
			// 
			// splitMain
			// 
			splitMain.BorderStyle = BorderStyle.Fixed3D;
			splitMain.Dock = DockStyle.Fill;
			splitMain.Location = new Point(0, 24);
			splitMain.Name = "splitMain";
			// 
			// splitMain.Panel1
			// 
			splitMain.Panel1.Controls.Add(tvMain);
			// 
			// splitMain.Panel2
			// 
			splitMain.Panel2.Controls.Add(btnTest);
			splitMain.Size = new Size(824, 449);
			splitMain.SplitterDistance = 273;
			splitMain.TabIndex = 3;
			// 
			// frmMain
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(824, 473);
			Controls.Add(splitMain);
			Controls.Add(msMain);
			MainMenuStrip = msMain;
			Name = "frmMain";
			Text = "Binit";
			msMain.ResumeLayout(false);
			msMain.PerformLayout();
			splitMain.Panel1.ResumeLayout(false);
			splitMain.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)splitMain).EndInit();
			splitMain.ResumeLayout(false);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btnTest;
		private MenuStrip msMain;
		private ToolStripMenuItem fileToolStripMenuItem;
		private TreeView tvMain;
		private SplitContainer splitMain;
	}
}
