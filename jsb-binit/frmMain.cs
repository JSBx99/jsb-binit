using System.Text;

namespace jsb_binit
{
	public partial class frmMain : Form
	{
		DirectoryInfo inputDir = new DirectoryInfo("D:\\Data\\binit\\input");
		String outputDir = "D:\\Data\\binit\\";
		String outputFileName = "binit.bin";

		public frmMain()
		{
			InitializeComponent();
		}

		private void btnTest_Click(object sender, EventArgs e)
		{
			ClearTree();
			DisplayInputFiles();
		}

		private void DisplayInputFiles()
		{


			foreach (FileInfo file in inputDir.GetFiles())
			{
				if (file.Exists)
				{
					tvMain.Nodes.Add(file.Name);
				}
			}
		}

		private void ClearTree()
		{
			tvMain.Nodes.Clear();
		}

		private void tvMain_AfterSelect(object sender, TreeViewEventArgs e)
		{
			GetFileData(tvMain.SelectedNode);
		}

		private void GetFileData(TreeNode tn)
		{
			byte[] currentFileData = File.ReadAllBytes(inputDir + "\\" + tn.Text);
			txtData.Text = Encoding.ASCII.GetString(currentFileData);
		}

		private void btnCompile_Click(object sender, EventArgs e)
		{
			CompileDirectory();
		}

		private void CompileDirectory()
		{		
			foreach (TreeNode tn in tvMain.Nodes)
			{
				byte[] currentFileData = File.ReadAllBytes(inputDir + "\\" + tn.Text);
				File.WriteAllBytes(outputDir + outputFileName, currentFileData);
			}
		}
	}


}
