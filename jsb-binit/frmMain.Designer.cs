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
			msMain = new MenuStrip();
			fileToolStripMenuItem = new ToolStripMenuItem();
			chooseDirectoryToolStripMenuItem = new ToolStripMenuItem();
			chooseOutputDirectoryToolStripMenuItem = new ToolStripMenuItem();
			toolStripMenuItem1 = new ToolStripSeparator();
			compileToolStripMenuItem = new ToolStripMenuItem();
			decompileToolStripMenuItem = new ToolStripMenuItem();
			toolStripMenuItem2 = new ToolStripSeparator();
			exitToolStripMenuItem = new ToolStripMenuItem();
			ofd = new OpenFileDialog();
			fbd = new FolderBrowserDialog();
			splitMain = new SplitContainer();
			splitContainer1 = new SplitContainer();
			tableLayoutPanel1 = new TableLayoutPanel();
			btnChangeInput = new Button();
			tvMain = new TreeView();
			txtInputDirectory = new TextBox();
			tableLayoutPanel2 = new TableLayoutPanel();
			tvBin = new TreeView();
			btnUnload = new Button();
			txtBINDirectory = new TextBox();
			btnCompile = new Button();
			btnDecompile = new Button();
			txtStatus = new TextBox();
			pbMain = new ProgressBar();
			btnTest = new Button();
			msMain.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)splitMain).BeginInit();
			splitMain.Panel1.SuspendLayout();
			splitMain.Panel2.SuspendLayout();
			splitMain.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
			splitContainer1.Panel1.SuspendLayout();
			splitContainer1.Panel2.SuspendLayout();
			splitContainer1.SuspendLayout();
			tableLayoutPanel1.SuspendLayout();
			tableLayoutPanel2.SuspendLayout();
			SuspendLayout();
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
			fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { chooseDirectoryToolStripMenuItem, chooseOutputDirectoryToolStripMenuItem, toolStripMenuItem1, compileToolStripMenuItem, decompileToolStripMenuItem, toolStripMenuItem2, exitToolStripMenuItem });
			fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			fileToolStripMenuItem.Size = new Size(37, 20);
			fileToolStripMenuItem.Text = "File";
			// 
			// chooseDirectoryToolStripMenuItem
			// 
			chooseDirectoryToolStripMenuItem.Name = "chooseDirectoryToolStripMenuItem";
			chooseDirectoryToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
			chooseDirectoryToolStripMenuItem.Size = new Size(279, 22);
			chooseDirectoryToolStripMenuItem.Text = "Change Input Directory";
			chooseDirectoryToolStripMenuItem.Click += chooseDirectoryToolStripMenuItem_Click;
			// 
			// chooseOutputDirectoryToolStripMenuItem
			// 
			chooseOutputDirectoryToolStripMenuItem.Name = "chooseOutputDirectoryToolStripMenuItem";
			chooseOutputDirectoryToolStripMenuItem.Size = new Size(279, 22);
			chooseOutputDirectoryToolStripMenuItem.Text = "Change Output Directory";
			// 
			// toolStripMenuItem1
			// 
			toolStripMenuItem1.Name = "toolStripMenuItem1";
			toolStripMenuItem1.Size = new Size(276, 6);
			// 
			// compileToolStripMenuItem
			// 
			compileToolStripMenuItem.Name = "compileToolStripMenuItem";
			compileToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
			compileToolStripMenuItem.Size = new Size(279, 22);
			compileToolStripMenuItem.Text = "Compile BIN From Input Folder";
			// 
			// decompileToolStripMenuItem
			// 
			decompileToolStripMenuItem.Name = "decompileToolStripMenuItem";
			decompileToolStripMenuItem.Size = new Size(279, 22);
			decompileToolStripMenuItem.Text = "Unpack BIN To Folder...";
			// 
			// toolStripMenuItem2
			// 
			toolStripMenuItem2.Name = "toolStripMenuItem2";
			toolStripMenuItem2.Size = new Size(276, 6);
			// 
			// exitToolStripMenuItem
			// 
			exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			exitToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.F4;
			exitToolStripMenuItem.Size = new Size(279, 22);
			exitToolStripMenuItem.Text = "Exit";
			// 
			// ofd
			// 
			ofd.FileName = "openFileDialog1";
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
			splitMain.Panel2.Controls.Add(btnCompile);
			splitMain.Panel2.Controls.Add(btnDecompile);
			splitMain.Panel2.Controls.Add(txtStatus);
			splitMain.Panel2.Controls.Add(pbMain);
			splitMain.Panel2.Controls.Add(btnTest);
			splitMain.Panel2.Paint += splitMain_Panel2_Paint;
			splitMain.Size = new Size(824, 449);
			splitMain.SplitterDistance = 719;
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
			splitContainer1.Panel1.Controls.Add(tableLayoutPanel1);
			// 
			// splitContainer1.Panel2
			// 
			splitContainer1.Panel2.Controls.Add(tableLayoutPanel2);
			splitContainer1.Size = new Size(719, 449);
			splitContainer1.SplitterDistance = 340;
			splitContainer1.TabIndex = 4;
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.ColumnCount = 2;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
			tableLayoutPanel1.Controls.Add(btnChangeInput, 1, 1);
			tableLayoutPanel1.Controls.Add(tvMain, 0, 0);
			tableLayoutPanel1.Controls.Add(txtInputDirectory, 0, 1);
			tableLayoutPanel1.Dock = DockStyle.Fill;
			tableLayoutPanel1.Location = new Point(0, 0);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 2;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
			tableLayoutPanel1.Size = new Size(336, 445);
			tableLayoutPanel1.TabIndex = 0;
			// 
			// btnChangeInput
			// 
			btnChangeInput.Dock = DockStyle.Fill;
			btnChangeInput.Location = new Point(238, 418);
			btnChangeInput.Name = "btnChangeInput";
			btnChangeInput.Size = new Size(95, 24);
			btnChangeInput.TabIndex = 6;
			btnChangeInput.Text = "Change Input Directory...";
			btnChangeInput.UseVisualStyleBackColor = true;
			btnChangeInput.Click += btnChangeInput_Click;
			// 
			// tvMain
			// 
			tableLayoutPanel1.SetColumnSpan(tvMain, 2);
			tvMain.Dock = DockStyle.Fill;
			tvMain.Location = new Point(3, 3);
			tvMain.Name = "tvMain";
			tvMain.Size = new Size(330, 409);
			tvMain.TabIndex = 2;
			tvMain.AfterSelect += tvMain_AfterSelect;
			// 
			// txtInputDirectory
			// 
			txtInputDirectory.Dock = DockStyle.Fill;
			txtInputDirectory.Enabled = false;
			txtInputDirectory.Location = new Point(3, 418);
			txtInputDirectory.Name = "txtInputDirectory";
			txtInputDirectory.Size = new Size(229, 23);
			txtInputDirectory.TabIndex = 3;
			// 
			// tableLayoutPanel2
			// 
			tableLayoutPanel2.ColumnCount = 2;
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
			tableLayoutPanel2.Controls.Add(tvBin, 0, 0);
			tableLayoutPanel2.Controls.Add(btnUnload, 1, 1);
			tableLayoutPanel2.Controls.Add(txtBINDirectory, 0, 1);
			tableLayoutPanel2.Dock = DockStyle.Fill;
			tableLayoutPanel2.Location = new Point(0, 0);
			tableLayoutPanel2.Name = "tableLayoutPanel2";
			tableLayoutPanel2.RowCount = 2;
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
			tableLayoutPanel2.Size = new Size(371, 445);
			tableLayoutPanel2.TabIndex = 0;
			// 
			// tvBin
			// 
			tableLayoutPanel2.SetColumnSpan(tvBin, 2);
			tvBin.Dock = DockStyle.Fill;
			tvBin.Location = new Point(3, 3);
			tvBin.Name = "tvBin";
			tvBin.Size = new Size(365, 409);
			tvBin.TabIndex = 3;
			// 
			// btnUnload
			// 
			btnUnload.Dock = DockStyle.Fill;
			btnUnload.Location = new Point(262, 418);
			btnUnload.Name = "btnUnload";
			btnUnload.Size = new Size(106, 24);
			btnUnload.TabIndex = 7;
			btnUnload.Text = "Unload BIN";
			btnUnload.UseVisualStyleBackColor = true;
			btnUnload.Click += btnUnload_Click;
			// 
			// txtBINDirectory
			// 
			txtBINDirectory.Dock = DockStyle.Fill;
			txtBINDirectory.Enabled = false;
			txtBINDirectory.Location = new Point(3, 418);
			txtBINDirectory.Name = "txtBINDirectory";
			txtBINDirectory.Size = new Size(253, 23);
			txtBINDirectory.TabIndex = 4;
			// 
			// btnCompile
			// 
			btnCompile.Dock = DockStyle.Bottom;
			btnCompile.Location = new Point(0, 235);
			btnCompile.Name = "btnCompile";
			btnCompile.Size = new Size(97, 60);
			btnCompile.TabIndex = 2;
			btnCompile.Text = "Compile BIN From Input Folder";
			btnCompile.UseVisualStyleBackColor = true;
			btnCompile.Click += btnCompile_Click;
			// 
			// btnDecompile
			// 
			btnDecompile.Dock = DockStyle.Bottom;
			btnDecompile.Location = new Point(0, 295);
			btnDecompile.Name = "btnDecompile";
			btnDecompile.Size = new Size(97, 60);
			btnDecompile.TabIndex = 4;
			btnDecompile.Text = "Unpack BIN To Folder...";
			btnDecompile.UseVisualStyleBackColor = true;
			btnDecompile.Click += btnDecompile_Click;
			// 
			// txtStatus
			// 
			txtStatus.Dock = DockStyle.Bottom;
			txtStatus.Enabled = false;
			txtStatus.Location = new Point(0, 355);
			txtStatus.Name = "txtStatus";
			txtStatus.Size = new Size(97, 23);
			txtStatus.TabIndex = 3;
			// 
			// pbMain
			// 
			pbMain.Dock = DockStyle.Bottom;
			pbMain.Location = new Point(0, 378);
			pbMain.Name = "pbMain";
			pbMain.Size = new Size(97, 23);
			pbMain.TabIndex = 5;
			// 
			// btnTest
			// 
			btnTest.Dock = DockStyle.Bottom;
			btnTest.Location = new Point(0, 401);
			btnTest.Name = "btnTest";
			btnTest.Size = new Size(97, 44);
			btnTest.TabIndex = 0;
			btnTest.Text = "Debug Button";
			btnTest.UseVisualStyleBackColor = true;
			btnTest.Visible = false;
			btnTest.Click += btnTest_Click;
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
			tableLayoutPanel1.ResumeLayout(false);
			tableLayoutPanel1.PerformLayout();
			tableLayoutPanel2.ResumeLayout(false);
			tableLayoutPanel2.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private MenuStrip msMain;
		private ToolStripMenuItem fileToolStripMenuItem;
		private ToolStripMenuItem chooseDirectoryToolStripMenuItem;
		private ToolStripSeparator toolStripMenuItem1;
		private ToolStripMenuItem exitToolStripMenuItem;
		private ToolStripSeparator toolStripMenuItem2;
		private ToolStripMenuItem compileToolStripMenuItem;
		private OpenFileDialog ofd;
		private FolderBrowserDialog fbd;
		private ToolStripMenuItem chooseOutputDirectoryToolStripMenuItem;
		private ToolStripMenuItem decompileToolStripMenuItem;
		private SplitContainer splitMain;
		private SplitContainer splitContainer1;
		private TableLayoutPanel tableLayoutPanel1;
		private TreeView tvMain;
		private TextBox txtInputDirectory;
		private TableLayoutPanel tableLayoutPanel2;
		private TreeView tvBin;
		private TextBox txtBINDirectory;
		private Button btnChangeInput;
		private Button btnCompile;
		private Button btnUnload;
		private Button btnDecompile;
		private TextBox txtStatus;
		private ProgressBar pbMain;
		private Button btnTest;
	}
}
