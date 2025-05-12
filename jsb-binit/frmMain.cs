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
					tvMain.Nodes[0].Nodes.Add(file.Name);
				}
			}

			tvMain.ExpandAll();
		}

		private void ClearTree()
		{
			tvMain.Nodes.Clear();
		}

		private void tvMain_AfterSelect(object sender, TreeViewEventArgs e)
		{
			//GetFileData(tvMain.SelectedNode);
		}

		private void GetFileData(TreeNode tn)
		{
			//byte[] currentFileData = File.ReadAllBytes(inputDir + "\\" + tn.Text);
			//txtData.Text = Encoding.ASCII.GetString(currentFileData);
		}

		private void btnCompile_Click(object sender, EventArgs e)
		{
			CompileDirectory();
		}

		private void CompileDirectory()
		{
			//Byte arrays for building .bin file
			byte[] fHeader = Encoding.ASCII.GetBytes("JSB>BN01");   //File header data
			byte[] fFileCount = BitConverter.GetBytes(tvMain.Nodes[0].Nodes.Count);   //File header data
			byte[] currentFileName;     //File name
			byte[] fileNameLength = new byte[8];      //File name length
			byte[] currentFileData;     //File data
			byte[] fileDataSize;        //File data length

			//Write file header data BEFORE adding the files themselves
			using (var fStreamH = new FileStream(outputDir + outputFileName, FileMode.Create))
			{
				fStreamH.Write(fHeader, 0, 8);
			}

			//Write file count
			using (var fStreamH = new FileStream(outputDir + outputFileName, FileMode.Append))
			{
				fStreamH.Write(fFileCount, 0, 4);
			}

			foreach (TreeNode tn in tvMain.Nodes[0].Nodes)
			{
				//Get file name
				string fname = tn.Text;
				currentFileName = System.Text.Encoding.ASCII.GetBytes(fname);
				int fnamelength = currentFileName.Length;
				fileNameLength = BitConverter.GetBytes(fnamelength);

				//Get file data
				currentFileData = File.ReadAllBytes(inputDir + "\\" + tn.Text);  //File data byte array
				int fileDataLength = currentFileData.Length;                            //File data length
				fileDataSize = BitConverter.GetBytes(fileDataLength);

				using (var fStream = new FileStream(outputDir + outputFileName, FileMode.Append))
				{
					fStream.Write(fileNameLength, 0, 4);
					fStream.Write(currentFileName, 0, fnamelength);
					fStream.Write(fileDataSize, 0, 4);  //Write file data length
					fStream.Write(currentFileData, 0, fileDataLength);  //Write file data
				}

				//File.WriteAllBytes(outputDir + outputFileName, fileDataSize);
				//File.WriteAllBytes(outputDir + outputFileName, currentFileData);	//Write file data
			}
		}

		private void DecompileBIN()
		{
			byte[] bnHead = new byte[8];    //Header
			byte[] bnVersion = new byte[4];     //JSB Binary Version - this program is designed to read 'BN01' version binaries
			byte[] bnFileCount = new byte[4];	//File count for this binary

			using (FileStream fstream = new FileStream("D:\\Data\\binit\\binit.bin", FileMode.Open))
			{
				fstream.Read(bnHead,0,8);
				tvBin.Nodes[0].Nodes.Add(Encoding.ASCII.GetString(bnHead));		//Read header
				
				tvBin.ExpandAll();
			}
		}

		private void InitDirectoryTree()
		{
			tvMain.Nodes.Clear();
			tvMain.Nodes.Add("D:\\Data\\binit\\input");
		}

		private void InitBINTree()
		{
			tvBin.Nodes.Clear();
			tvBin.Nodes.Add("untitled.bin");
		}

		private void PopulateDirectoryTree()
		{
			DisplayInputFiles();
		}

		private void PopulateBINTree()
		{
			DecompileBIN();
		}

		private void frmMain_Load(object sender, EventArgs e)
		{
			InitDirectoryTree();
			InitBINTree();
			PopulateDirectoryTree();
		}

		private void btnDecompile_Click(object sender, EventArgs e)
		{
			PopulateBINTree();
		}
	}


}
