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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
			btnTest = new Button();
			msMain = new MenuStrip();
			fileToolStripMenuItem = new ToolStripMenuItem();
			chooseDirectoryToolStripMenuItem = new ToolStripMenuItem();
			toolStripMenuItem1 = new ToolStripSeparator();
			compileToolStripMenuItem = new ToolStripMenuItem();
			toolStripMenuItem2 = new ToolStripSeparator();
			exitToolStripMenuItem = new ToolStripMenuItem();
			tvMain = new TreeView();
			splitMain = new SplitContainer();
			splitContainer1 = new SplitContainer();
			tvBin = new TreeView();
			btnDecompile = new Button();
			btnCompile = new Button();
			txtName = new TextBox();
			msMain.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)splitMain).BeginInit();
			splitMain.Panel1.SuspendLayout();
			splitMain.Panel2.SuspendLayout();
			splitMain.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
			splitContainer1.Panel1.SuspendLayout();
			splitContainer1.Panel2.SuspendLayout();
			splitContainer1.SuspendLayout();
			SuspendLayout();
			// 
			// btnTest
			// 
			btnTest.Dock = DockStyle.Bottom;
			btnTest.Location = new Point(0, 401);
			btnTest.Name = "btnTest";
			btnTest.Size = new Size(92, 44);
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
			fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { chooseDirectoryToolStripMenuItem, toolStripMenuItem1, compileToolStripMenuItem, toolStripMenuItem2, exitToolStripMenuItem });
			fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			fileToolStripMenuItem.Size = new Size(37, 20);
			fileToolStripMenuItem.Text = "File";
			// 
			// chooseDirectoryToolStripMenuItem
			// 
			chooseDirectoryToolStripMenuItem.Name = "chooseDirectoryToolStripMenuItem";
			chooseDirectoryToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
			chooseDirectoryToolStripMenuItem.Size = new Size(239, 22);
			chooseDirectoryToolStripMenuItem.Text = "Choose Input Directory";
			// 
			// toolStripMenuItem1
			// 
			toolStripMenuItem1.Name = "toolStripMenuItem1";
			toolStripMenuItem1.Size = new Size(236, 6);
			// 
			// compileToolStripMenuItem
			// 
			compileToolStripMenuItem.Name = "compileToolStripMenuItem";
			compileToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
			compileToolStripMenuItem.Size = new Size(239, 22);
			compileToolStripMenuItem.Text = "Compile";
			// 
			// toolStripMenuItem2
			// 
			toolStripMenuItem2.Name = "toolStripMenuItem2";
			toolStripMenuItem2.Size = new Size(236, 6);
			// 
			// exitToolStripMenuItem
			// 
			exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			exitToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.F4;
			exitToolStripMenuItem.Size = new Size(239, 22);
			exitToolStripMenuItem.Text = "Exit";
			// 
			// tvMain
			// 
			tvMain.Dock = DockStyle.Fill;
			tvMain.Location = new Point(0, 0);
			tvMain.Name = "tvMain";
			tvMain.Size = new Size(342, 445);
			tvMain.TabIndex = 2;
			tvMain.AfterSelect += tvMain_AfterSelect;
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
			splitMain.Panel1.Controls.Add(splitContainer1);
			// 
			// splitMain.Panel2
			// 
			splitMain.Panel2.Controls.Add(btnDecompile);
			splitMain.Panel2.Controls.Add(btnCompile);
			splitMain.Panel2.Controls.Add(txtName);
			splitMain.Panel2.Controls.Add(btnTest);
			splitMain.Size = new Size(824, 449);
			splitMain.SplitterDistance = 724;
			splitMain.TabIndex = 3;
			// 
			// splitContainer1
			// 
			splitContainer1.BorderStyle = BorderStyle.Fixed3D;
			splitContainer1.Dock = DockStyle.Fill;
			splitContainer1.Location = new Point(0, 0);
			splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			splitContainer1.Panel1.Controls.Add(tvMain);
			// 
			// splitContainer1.Panel2
			// 
			splitContainer1.Panel2.Controls.Add(tvBin);
			splitContainer1.Size = new Size(724, 449);
			splitContainer1.SplitterDistance = 346;
			splitContainer1.TabIndex = 4;
			// 
			// tvBin
			// 
			tvBin.Dock = DockStyle.Fill;
			tvBin.Location = new Point(0, 0);
			tvBin.Name = "tvBin";
			tvBin.Size = new Size(370, 445);
			tvBin.TabIndex = 3;
			// 
			// btnDecompile
			// 
			btnDecompile.Dock = DockStyle.Bottom;
			btnDecompile.Location = new Point(0, 281);
			btnDecompile.Name = "btnDecompile";
			btnDecompile.Size = new Size(92, 46);
			btnDecompile.TabIndex = 4;
			btnDecompile.Text = "Decompile BIN";
			btnDecompile.UseVisualStyleBackColor = true;
			btnDecompile.Click += btnDecompile_Click;
			// 
			// btnCompile
			// 
			btnCompile.Dock = DockStyle.Bottom;
			btnCompile.Location = new Point(0, 327);
			btnCompile.Name = "btnCompile";
			btnCompile.Size = new Size(92, 51);
			btnCompile.TabIndex = 2;
			btnCompile.Text = "Build BIN From Input";
			btnCompile.UseVisualStyleBackColor = true;
			btnCompile.Click += btnCompile_Click;
			// 
			// txtName
			// 
			txtName.Dock = DockStyle.Bottom;
			txtName.Location = new Point(0, 378);
			txtName.Name = "txtName";
			txtName.Size = new Size(92, 23);
			txtName.TabIndex = 3;
			// 
			// frmMain
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(824, 473);
			Controls.Add(splitMain);
			Controls.Add(msMain);
			Icon = (Icon)resources.GetObject("$this.Icon");
			MainMenuStrip = msMain;
			Name = "frmMain";
			Text = "Binit";
			Load += frmMain_Load;
			msMain.ResumeLayout(false);
			msMain.PerformLayout();
			splitMain.Panel1.ResumeLayout(false);
			splitMain.Panel2.ResumeLayout(false);
			splitMain.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)splitMain).EndInit();
			splitMain.ResumeLayout(false);
			splitContainer1.Panel1.ResumeLayout(false);
			splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
			splitContainer1.ResumeLayout(false);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btnTest;
		private MenuStrip msMain;
		private ToolStripMenuItem fileToolStripMenuItem;
		private TreeView tvMain;
		private SplitContainer splitMain;
		private Button btnCompile;
		private TextBox txtName;
		private ToolStripMenuItem chooseDirectoryToolStripMenuItem;
		private ToolStripSeparator toolStripMenuItem1;
		private ToolStripMenuItem exitToolStripMenuItem;
		private ToolStripSeparator toolStripMenuItem2;
		private ToolStripMenuItem compileToolStripMenuItem;
		private SplitContainer splitContainer1;
		private TreeView tvBin;
		private Button btnDecompile;
	}
}
