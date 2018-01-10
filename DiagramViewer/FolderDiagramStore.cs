/*
 * Created by SharpDevelop.
 * User: DELL
 * Date: 2013-8-25
 * Time: 8:03
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
using System.Text.RegularExpressions;

namespace DiagramViewer
{
	/// <summary>
	/// Description of FolderDiagramStore.
	/// </summary>
	public class FolderDiagramStore : DiagramStore
	{
		string[] diagramFileNames;
		string rootFolderName;
		Regex regex;
		
		public FolderDiagramStore(string name, string fullFolderName)
		{
			this.Name = name;
			this.diagramFileNames = Directory.GetFiles(fullFolderName);
			this.rootFolderName = fullFolderName;
			this.regex = new Regex(@"\w\.jpg|\w\.jpeg|\w\.bmp|\w\.png|\w\.gif");
		}
		
		public FolderDiagramStore(string fullFolderName) : this("", fullFolderName)
		{}
		
		public override Image GetImageOnIndex(int index)
		{
			return new Bitmap(diagramFileNames[index]);
		}
		
		public override int Count {
			get { return diagramFileNames.Length; }
		}
		
		public override void FillTreeView(System.Windows.Forms.TreeView treeView)
		{
			treeView.Nodes.Add(Name, Name, 0, 0);
			if (!Directory.Exists(this.rootFolderName)) return;
			
			FillNodes(treeView.Nodes[0].Nodes, this.rootFolderName);
			//throw new NotImplementedException();
		}
		
		public override Image GetImageOnKey(string key)
		{
			return new Bitmap(key);
		}
		
		private void FillNodes(TreeNodeCollection treeNodes, string rootDirectory)
		{
			string[] directories = Directory.GetDirectories(rootDirectory);
			foreach(string directory in directories)
			{
				string shortDirName = GetName(directory);
				TreeNode node = new TreeNode(shortDirName, 0, 0);
				FillNodes(node.Nodes, directory);
				treeNodes.Add(node);
			}
			
			string[] files = Directory.GetFiles(rootDirectory);
			foreach(string file in files)
			{
				if (!regex.IsMatch(file.ToLower())) continue;
				
				string shortFileName = GetName(file);
				TreeNode node = new TreeNode(shortFileName, 1, 1);
				node.Name = file;
				node.Tag = "ImageNode";
				treeNodes.Add(node);
			}
		}
		private string GetName(string path)
		{
			string[] names = path.Trim().Split('\\');
			
			return names[names.Length-1];
		}
	}
}
