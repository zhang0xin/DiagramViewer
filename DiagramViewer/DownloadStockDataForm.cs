/*
 * Created by SharpDevelop.
 * User: Administrator
 * Date: 2013/8/24
 * Time: 19:02
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using System.Net;

namespace DiagramViewer
{
	/// <summary>
	/// Description of DownloadStockDataForm.
	/// </summary>
	public partial class DownloadStockDataForm : Form
	{
		public DownloadStockDataForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void DownloadStockDataFormLoad(object sender, EventArgs e)
		{
			tbStockListFile.Text = Settings.Instance.StockListFile;
			tbImageStoreDirectory.Text = @"Diagrams\新浪网站\";
			
		}
		
		void BtnStartDownloadClick(object sender, EventArgs e)
		{
			TextReader reader = new StreamReader(tbStockListFile.Text);
			WebClient wc = new WebClient();
			int i = 0;
			
			string line;
			while((line = reader.ReadLine()) != null)
			{
				wc.DownloadFile(
					string.Format("http://image.sinajs.cn/newchart/min/n/{0}.gif", line), 
					string.Format(tbImageStoreDirectory.Text+"{0}.gif", line)
				);
				i++;
				System.Threading.Thread.Sleep(1000);
				//pbDownload.Value = i/10;
				if (i==100) break;
			}
			
			reader.Close();
		}
	}
}
