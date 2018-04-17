using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Text;
using System.Windows;
using System.Windows.Forms;


namespace RJO
{
	public partial class MainFrm : Form
	{


		ArrayList _PathNames = null;
		ArrayList _TempPathNames = null;

		public MainFrm()
		{
			InitializeComponent();
			_PathNames = new ArrayList();
			_TempPathNames = new ArrayList();
		}


		private void MainFrm_Resize(object sender, EventArgs e)
		{
			this.table.Size = this.Size;
		}

		private void DragEnterHandler(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop) )
				e.Effect = DragDropEffects.All;
			else
				e.Effect = DragDropEffects.None;
		}

		private void table_DragDrop(object sender, DragEventArgs e)
		{
			_PathNames.Clear();
			string[] s = (string[])e.Data.GetData(DataFormats.FileDrop, false);
			CreateFileList(s);
			AddFileInfoToTable();
		}

		private void CreateFileList(string[] s)
		{
			foreach (string filePath in s)
			{
				if (File.Exists(filePath))
				{
					_PathNames.Add(filePath);
				}
				else if (Directory.Exists(filePath))
				{
					_TempPathNames.Clear();
					// _TempPathNames is populated by FullDirList
					FullDirList(filePath, "*");
					_PathNames.AddRange(_TempPathNames);
					_TempPathNames.Clear();
				}
				else
				{
					MessageBox.Show( "A non-File, non--Folder was dropped" );
				}
			}
		}

		private void AddFileInfoToTable()
		{
			foreach (string filePath in _PathNames  )
			{
				// generate size
				var length = new System.IO.FileInfo(filePath).Length;

				string sizeColStr = String.Format("{0:#,##0}", length) + " bytes";

				// generate MD5

				string Md5String;

				System.Security.Cryptography.MD5 myMD5 = System.Security.Cryptography.MD5.Create();
				StringBuilder sb = new StringBuilder();

				using (FileStream fs = File.Open(filePath, FileMode.Open, FileAccess.Read))
				{
					foreach (byte b in myMD5.ComputeHash(fs))
						sb.Append(b.ToString("x2").ToLower());
				}
				Md5String = sb.ToString();

				// does not work for large files
				//using (var md5 = System.Security.Cryptography.MD5.Create())
				//{
				//	Md5String= BitConverter.ToString(md5.ComputeHash(File.ReadAllBytes(filePath))).Replace("-", "");
				//}


				// generate the row
				string[] row = { Md5String, sizeColStr, System.IO.Path.GetFileName(filePath), filePath };

				table.Rows.Add(row);
			}
		}


		void FullDirList(string dir, string searchPattern)
		{
			// Console.WriteLine("Directory {0}", dir.FullName);
			// list the files

			DirectoryInfo dirInf = new DirectoryInfo(dir);
			try
			{
				foreach (FileInfo f in dirInf.GetFiles(searchPattern))
				{
					_TempPathNames.Add(f.FullName);
				}
			}
			catch
			{
				Console.WriteLine("Directory {0}  \n could not be accessed!!!!", dirInf.FullName);
				return;  // We already got an error trying to access dir so don't try to access it again
			}

			// process each directory
			foreach (DirectoryInfo d in dirInf.GetDirectories())
			{
				FullDirList(d.FullName, searchPattern);
			}
		}


		private void table_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

	}
}