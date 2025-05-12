namespace jsb_binit
{
	public partial class frmMain : Form
	{
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
			DirectoryInfo inputDir = new DirectoryInfo("D:\\Data\\binit\\input");

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
	}

	
}
