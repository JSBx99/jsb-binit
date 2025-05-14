using jsb_binit.Properties;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

namespace jsb_binit
{
	public partial class frmMain : Form
	{
		DirectoryInfo inputDir = new DirectoryInfo(Properties.Settings.Default.InputDirectory);
		String UserInputDir = "C:\\";
		String UserOutputDir = "C:\\";
		String decompDir = "C:\\";
		String outputFileName = "untitled.bin";
		bool IsBINLoaded = false;

		//Some vars
		string fPath = "C:\\";

		public frmMain()
		{
			InitializeComponent();
		}

		private void tvMain_AfterSelect(object sender, TreeViewEventArgs e)
		{
			//GetFileData(tvMain.SelectedNode);
		}

		//--- BUTTONS ---

		private void btnCompile_Click(object sender, EventArgs e)
		{
			CompileDirectory();
		}

		private void btnChangeInput_Click(object sender, EventArgs e)
		{
			ChangeInputDirectory();
		}

		private void btnUnload_Click(object sender, EventArgs e)
		{
			UnloadBIN();
		}

		private void btnLoad_Click(object sender, EventArgs e)
		{
			using (var ofd = new OpenFileDialog())
			{
				if (ofd.ShowDialog() == DialogResult.OK)
				{
					fPath = ofd.FileName;
				}
				else
				{
					return;
				}
			}

			UnloadBIN();
			LoadBIN(fPath);
		}

		//--- MENU BAR STUFF ---

		private void compileToolStripMenuItem_Click(object sender, EventArgs e)
		{
			CompileDirectory();
		}

		private void decompileToolStripMenuItem_Click(object sender, EventArgs e)
		{
			DecompileBIN();
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		//--- FUNCTIONS ---

		private void CompileDirectory()
		{
			//Byte arrays for building .bin file
			byte[] fHeader = Encoding.ASCII.GetBytes("JSB>BN01");   //File header data
			byte[] fFileCount = BitConverter.GetBytes(tvMain.Nodes[0].Nodes.Count);   //File header data
			byte[] currentFileName;     //File name
			byte[] fileNameLength = new byte[8];      //File name length
			byte[] currentFileData;     //File data
			byte[] fileDataSize;        //File data length

			//Use save file dialog to choose where to output bin file
			using (SaveFileDialog sfd = new SaveFileDialog())
			{
				//Set dialog parameters
				sfd.Filter = "Binary File|*.bin|JSB Version (BN01) Binary|*.bn1";

				if (sfd.ShowDialog() == DialogResult.OK)
				{
					outputFileName = sfd.FileName;
				}
				else
				{
					return;
				}
			}

			//Write file header data BEFORE adding the files themselves
			using (var fStreamH = new FileStream(outputFileName, FileMode.Create))
			{
				fStreamH.Write(fHeader, 0, 8);
			}

			//Write file count
			using (var fStreamH = new FileStream(outputFileName, FileMode.Append))
			{
				fStreamH.Write(fFileCount, 0, 4);
			}

			//Load bin in the tree view
			LoadBIN(outputFileName);

			foreach (TreeNode tn in tvMain.Nodes[0].Nodes)
			{
				//Get file name
				string fname = tn.Text;
				currentFileName = System.Text.Encoding.ASCII.GetBytes(fname);
				int fnamelength = currentFileName.Length;
				fileNameLength = BitConverter.GetBytes(fnamelength);

				//Get file data
				currentFileData = File.ReadAllBytes(UserInputDir + "\\" + tn.Text);  //File data byte array
				int fileDataLength = currentFileData.Length;                            //File data length
				fileDataSize = BitConverter.GetBytes(fileDataLength);

				using (var fStream = new FileStream(outputFileName, FileMode.Append))
				{
					fStream.Write(fileNameLength, 0, 4);
					fStream.Write(currentFileName, 0, fnamelength);
					fStream.Write(fileDataSize, 0, 4);  //Write file data length
					fStream.Write(currentFileData, 0, fileDataLength);  //Write file data
				}

				//Add a tree node to the bin tree view for this file
				tvBin.Nodes[0].Nodes.Add(tn.Text);
				tvBin.ExpandAll();

				//Clear out garbage to free up memory
				GC.Collect();
			}

		}

		private void DecompileBIN()
		{
			byte[] bnHead = new byte[4];    //Header
			byte[] bnVersion = new byte[4];     //JSB Binary Version - this program is designed to read 'BN01' version binaries
			byte[] bnFileCount = new byte[4];   //File count for this binary
			byte[] bnFileNameLength = new byte[4];  //File name length used for each file inside the bin
			byte[] bnFileName = new byte[0];
			byte[] bnFileDataLength = new byte[4];
			byte[] bnFileData = new byte[0];

			//Get bin file path from the tree node
			fPath = tvBin.Nodes[0].Text;

			//Prompt user to select folder to dump bin contents
			using (var fbd = new FolderBrowserDialog())
			{
				if (fbd.ShowDialog() == DialogResult.OK)
				{
					decompDir = fbd.SelectedPath + "\\";
				}
				else
				{
					return;
				}
			}

			//Read bytes from the bin file using binary reader and file stream
			using (BinaryReader breader = new BinaryReader(new FileStream(fPath, FileMode.Open)))
			{
				//Read first 4 bytes (JSB>)
				breader.BaseStream.Seek(0, SeekOrigin.Begin);
				breader.Read(bnHead, 0, 4);
				//Convert bytes into string
				string sbnHead = BitConverter.ToString(bnHead);

				//Read next 4 bytes (BNXX) where BN=Binary and XX=Binary version
				breader.BaseStream.Seek(4, SeekOrigin.Begin);
				breader.Read(bnVersion, 0, 4);
				//Convert bytes to string
				string sbnVersion = BitConverter.ToString(bnVersion);

				//Read next 4 bytes (XX-XX-XX-XX) where XX-XX-XX-XX=Number of files in the bin
				breader.BaseStream.Seek(8, SeekOrigin.Begin);
				breader.Read(bnFileCount, 0, 4);
				//Convert bytes to int
				int ibnFileCount = BitConverter.ToInt32(bnFileCount);

				//Some vars for the loop
				int fileListOffset = 12;    //Offset where the header ends and the list of files starts
				int getCurrentOffset = fileListOffset;
				int fileNameLength = 0;
				int fileDataLength = 0;

				//Set progress bar max to the number of files in the bin
				pbMain.Maximum = ibnFileCount;



				//Loop to unpack each file
				for (int i = 0; i < ibnFileCount; i++)
				{
					//Get file name length
					breader.BaseStream.Seek(getCurrentOffset, SeekOrigin.Begin);
					breader.Read(bnFileNameLength, 0, 4);
					fileNameLength = BitConverter.ToInt32(bnFileNameLength);
					getCurrentOffset += 4;  //Move offset to read from to start of file name

					//Read file name and store it as a string
					breader.BaseStream.Seek(getCurrentOffset, SeekOrigin.Begin);
					Array.Resize(ref bnFileName, fileNameLength);   //Resize file name array to be the correct length of the file name
					breader.Read(bnFileName, 0, fileNameLength);
					string sbnFileName = Encoding.ASCII.GetString(bnFileName);
					getCurrentOffset += fileNameLength;

					//Get file data length
					breader.BaseStream.Seek(getCurrentOffset, SeekOrigin.Begin);
					breader.Read(bnFileDataLength, 0, 4);
					fileDataLength = BitConverter.ToInt32(bnFileDataLength);
					getCurrentOffset += 4;  //Move offset to read from to start of file data

					//Read file data
					breader.BaseStream.Seek(getCurrentOffset, SeekOrigin.Begin);
					Array.Resize(ref bnFileData, fileDataLength);   //Resize file data array to be the correct length of the file name
					breader.Read(bnFileData, 0, fileDataLength);
					getCurrentOffset += fileDataLength;

					System.Diagnostics.Debug.WriteLine(decompDir + sbnFileName);

					//Create the file in the output folder with its data
					using (var fStream = new FileStream(decompDir + sbnFileName, FileMode.Create))
					{
						//Create data
						fStream.Write(bnFileData, 0, fileDataLength);
					}

					//Update progress bar
					pbMain.Value = i + 1;

					//Update status textbox
					txtStatus.Text = "Unpacking: " + sbnFileName + " (" + (i + 1) + "/" + ibnFileCount + ")";
				}

				//Clear out garbage to free up memory
				GC.Collect();

				tvBin.ExpandAll();

				//Set progress bar back to 0
				pbMain.Value = 0;

				//Set status text to complete
				txtStatus.Text = "Unpacking complete!";
			}
		}

		private void GetBINFileNames(string filePath)
		{
			byte[] bnFileCount = new byte[4];   //File count for this binary
			byte[] bnFileNameLength = new byte[4];  //File name length used for each file inside the bin
			byte[] bnFileName = new byte[0];
			byte[] bnFileDataLength = new byte[4];

			//Read bytes from the bin file using binary reader and file stream
			using (BinaryReader breader = new BinaryReader(new FileStream(filePath, FileMode.Open)))
			{
				//Read next 4 bytes (XX-XX-XX-XX) where XX-XX-XX-XX=Number of files in the bin
				breader.BaseStream.Seek(8, SeekOrigin.Begin);
				breader.Read(bnFileCount, 0, 4);
				//Convert bytes to int
				int ibnFileCount = BitConverter.ToInt32(bnFileCount);

				//Some vars for the loop
				int fileListOffset = 12;    //Offset where the header ends and the list of files starts
				int getCurrentOffset = fileListOffset;
				int fileNameLength = 0;
				int fileDataLength = 0;

				//Set progress bar max to the number of files in the bin
				pbMain.Maximum = ibnFileCount;

				//Loop to unpack each file
				for (int i = 0; i < ibnFileCount; i++)
				{
					//Get file name length
					breader.BaseStream.Seek(getCurrentOffset, SeekOrigin.Begin);
					breader.Read(bnFileNameLength, 0, 4);
					fileNameLength = BitConverter.ToInt32(bnFileNameLength);
					getCurrentOffset += 4;  //Move offset to read from to start of file name

					//Read file name and store it as a string
					breader.BaseStream.Seek(getCurrentOffset, SeekOrigin.Begin);
					Array.Resize(ref bnFileName, fileNameLength);   //Resize file name array to be the correct length of the file name
					breader.Read(bnFileName, 0, fileNameLength);
					string sbnFileName = Encoding.ASCII.GetString(bnFileName);
					getCurrentOffset += fileNameLength;

					//Get file data length
					breader.BaseStream.Seek(getCurrentOffset, SeekOrigin.Begin);
					breader.Read(bnFileDataLength, 0, 4);
					fileDataLength = BitConverter.ToInt32(bnFileDataLength);
					getCurrentOffset += (4 + fileDataLength);  //Move offset to read from to start of file data

					//Update progress bar
					pbMain.Value = i + 1;

					//Update status textbox
					txtStatus.Text = "Loading: " + sbnFileName + " (" + (i + 1) + "/" + ibnFileCount + ")";
				}

				//Clear out garbage to free up memory
				GC.Collect();

				tvBin.ExpandAll();

				//Set progress bar back to 0
				pbMain.Value = 0;

				//Set status text to complete
				txtStatus.Text = "BIN load complete!";
			}
		}

		private void InitDirectoryTree()
		{
			tvMain.Nodes.Clear();
			tvMain.Nodes.Add(Properties.Settings.Default.InputDirectory);
		}

		private void UpdateDirectoryTree(string dir)
		{
			tvMain.Nodes.Clear();
			tvMain.Nodes.Add(dir);
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

		private void frmMain_Load(object sender, EventArgs e)
		{
			InitDirectoryTree();
			InitBINTree();
			PopulateDirectoryTree();
			LoadUserSettings();
			UnloadBIN();
		}

		private void LoadUserSettings()
		{
			UserInputDir = Properties.Settings.Default.InputDirectory;
			UserOutputDir = Properties.Settings.Default.OutputDirectory;

			txtInputDirectory.Text = UserInputDir;
			txtBINDirectory.Text = UserOutputDir;
		}

		private void btnDecompile_Click(object sender, EventArgs e)
		{
			DecompileBIN();
		}

		private void chooseDirectoryToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ChangeInputDirectory();
		}

		private void ChangeInputDirectory()
		{
			using (var fbd = new FolderBrowserDialog())
			{
				if (fbd.ShowDialog() == DialogResult.OK)
				{
					DialogResult fbresult = fbd.ShowDialog();
					inputDir = new DirectoryInfo(fbd.SelectedPath);
					UpdateDirectoryTree(fbd.SelectedPath);
					txtInputDirectory.Text = fbd.SelectedPath;
					SetUserInputDirectory(fbd.SelectedPath);
					DisplayInputFiles();
					btnCompile.Enabled = true;
				}
				else
				{
					return;
				}
			}
		}

		private void SetUserInputDirectory(string s)
		{
			Properties.Settings.Default.InputDirectory = s;
			Properties.Settings.Default.Save();
			LoadUserSettings();
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

		private void UnloadBIN()
		{
			txtBINDirectory.Clear();
			tvBin.Nodes.Clear();
			btnDecompile.Enabled = false;
			decompileToolStripMenuItem.Enabled = false;
		}

		private void LoadBIN(string s)
		{
			txtBINDirectory.Text = s;
			tvBin.Nodes.Add(s);
			btnDecompile.Enabled = true;
			decompileToolStripMenuItem.Enabled = true;
			GetBINFileNames(s);
		}

		private void compileToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			CompileDirectory();
		}

		private void decompileToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			DecompileBIN();
		}
	}
}
