/*
 * Created by SharpDevelop.
 * User: Administrator
 * Date: 2013/9/3
 * Time: 22:12
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using System.Net;
using System.Net.NetworkInformation;

namespace DiagramViewer
{
	/// <summary>
	/// Description of InternetCachedDiagramStore.
	/// </summary>
	public class InternetCachedDiagramStore : DiagramStore
	{
		WebClient _webClient;
		string[] _fileNames;
		string _formatUri;
		string _catchedFolder;
		
		public InternetCachedDiagramStore(
			string name, string formatUri, string[] fileNames, string catchedFolder)
		{
			this.Name = name;
			_fileNames = fileNames;
			_formatUri = formatUri;
			_catchedFolder = catchedFolder + "\\" + GetTodayDateString();
			if (!Directory.Exists(_catchedFolder)) Directory.CreateDirectory(_catchedFolder);
			
			_webClient = new WebClient();
		}
		
		public InternetCachedDiagramStore(string formatUri, string[] fileNames, string catchedFolder) 
			: this("", formatUri, fileNames, catchedFolder)
		{}
		
		public override Image GetImageOnIndex(int index)
		{
			string uri = string.Format(_formatUri, _fileNames[index]);
			string fileName = _catchedFolder + "//" + _fileNames[index] + ".gif";
			
			_webClient.DownloadFile(uri, fileName);
			return new Bitmap(fileName);
		}
		
		public override Image GetImageOnKey(string key)
		{
			string uri = string.Format(_formatUri, key);
			string fileName = _catchedFolder + "\\" + key + ".gif";
			Bitmap image = new Bitmap(1,1);
			
			if (!CheckInternetConnect())
			{
				MessageBox.Show("网络连接不可用。");
				
				if (File.Exists(fileName)) 
					image = new Bitmap(fileName);
			}
			else
			{
				try
				{
					_webClient.DownloadFile(uri, fileName);
					image = new Bitmap(fileName);
				}
				catch (Exception ex)
				{
					MessageBox.Show("网络获取图形失败。\n" + ex.Message);
				}
			}
				
			return image;
		}
		
		private string GetTodayDateString()
		{
			return string.Format("{0:D4}_{1:D2}_{2:D2}", DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
		}
		
		public bool CheckInternetConnect()
		{
			Ping ping = new Ping();
			PingReply pingReply = ping.Send("218.30.13.36", 1); //sina ip

			return pingReply.Status == IPStatus.Success;
		}
		
		public override int Count {
			get { return _fileNames.Length; }
		}
		
		public override void FillTreeView(System.Windows.Forms.TreeView treeView)
		{
			treeView.Nodes.Add(Name, Name, 0, 0);
			
			foreach(string fileName in _fileNames)
			{
				TreeNode node = new TreeNode(fileName, 1, 1);
				node.Tag = "ImageNode";
				node.Name = fileName;
				treeView.Nodes[0].Nodes.Add(node);
			}
		}
	}
}
