/*
 * Created by SharpDevelop.
 * User: DELL
 * Date: 2013-8-25
 * Time: 9:20
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;
using System.Drawing;
using System.Net;

namespace DiagramViewer
{
	/// <summary>
	/// Description of InternetDiagramStore.
	/// </summary>
	public class InternetDiagramStore : DiagramStore
	{
		WebClient _webClient;
		string[] _diagramUris;
		public InternetDiagramStore(string[] diagramUris)
		{
			_diagramUris = diagramUris;
			_webClient = new WebClient();
		}
		
		public override Image GetImageOnIndex(int index)
		{
			string uri = _diagramUris[index];
			byte[] imageData = _webClient.DownloadData(uri);
			MemoryStream stream = new MemoryStream(imageData);
			return new Bitmap(stream);
		}
		
		public override int Count {
			get { return _diagramUris.Length; }
		}
		
		public override void FillTreeView(System.Windows.Forms.TreeView treeView)
		{
			throw new NotImplementedException();
		}
		
		public override Image GetImageOnKey(string key)
		{
			throw new NotImplementedException();
		}
	}
}
