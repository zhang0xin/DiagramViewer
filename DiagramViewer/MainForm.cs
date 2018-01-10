/*
 * Created by SharpDevelop.
 * User: Administrator
 * Date: 2013/8/24
 * Time: 10:14
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.IO;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using System.Net;

namespace DiagramViewer
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		bool timerStarted = false;
		DisplayStyle displayStyle;
		Graphics panelGraphics;
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//	
			Settings.Instance.Load();
			
			panelGraphics = plCanvas.CreateGraphics();
			plCanvas.BackColor = Settings.Instance.BackColor;
			
			
		}
		
		void TsbPlayAndStopClick(object sender, EventArgs e)
		{
			if (timerStarted)
			{
				timer.Stop();
				timerStarted = !timerStarted; 
			}
			else
			{
				timer.Start();
				timerStarted = !timerStarted; 
			}
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			displayStyle = new PageDisplayStyle(
				null,
				plCanvas.Width, 
				plCanvas.Height
			);
			displayStyle.PageEnd += delegate 
			{  
				NextImage();
				DrawImage();
			};
			
			InitListTypeItem();
		}
		
		void InitListTypeItem()
		{
			List<DiagramStore> diagramStoreList = new List<DiagramStore>();
			diagramStoreList.Add(new FolderDiagramStore(
				"图形目录", 
				Settings.Instance.DiagramDirectory));
			diagramStoreList.Add(new InternetCachedDiagramStore(
				"新浪实时分时图",
				"http://image.sinajs.cn/newchart/min/n/{0}.gif",
				ReadStockNames(), 
				Settings.Instance.DiagramDirectory + "新浪实时分时图" + "（缓存）"));
			diagramStoreList.Add(new InternetCachedDiagramStore(
				"新浪实时日K图",
				"http://image.sinajs.cn/newchart/daily/n/{0}.gif",
				ReadStockNames(), 
				Settings.Instance.DiagramDirectory + "新浪实时日K图" + "（缓存）"));
			diagramStoreList.Add(new InternetCachedDiagramStore(
				"新浪实时周K图",
				"http://image.sinajs.cn/newchart/weekly/n/{0}.gif",
				ReadStockNames(), 
				Settings.Instance.DiagramDirectory + "新浪实时周K图" + "（缓存）"));
			diagramStoreList.Add(new InternetCachedDiagramStore(
				"新浪实时月K图",
				"http://image.sinajs.cn/newchart/monthly/n/{0}.gif",
				ReadStockNames(), 
				Settings.Instance.DiagramDirectory + "新浪实时月K图" + "（缓存）"));

			cbListType.DataSource = diagramStoreList;
			//cbListType.SelectedIndex = 0;
		}
		
		void MainFormKeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Left)
			{
				displayStyle.GoBack();
				DrawImage();
			}
			else if (e.KeyCode == Keys.Right)
			{
				displayStyle.GoForward();
				DrawImage();
			}
			
		}
		
		void MainFormSizeChanged(object sender, EventArgs e)
		{
			
		}

		string[] ReadStockNames()
		{
			List<string> stocks = new List<string>();
			
			TextReader reader = new StreamReader(Settings.Instance.StockListFile);
			string line;
			while((line = reader.ReadLine()) != null)
			{
				if (string.IsNullOrEmpty(line.Trim())) continue;
				stocks.Add(line);
			}
			reader.Close();
			
			return stocks.ToArray();
		}
		string[] ReadUris()
		{
			List<string> uris = new List<string>();
			
			TextReader reader = new StreamReader(Settings.Instance.StockListFile);
			string line;
			while((line = reader.ReadLine()) != null)
			{
				uris.Add(string.Format("http://image.sinajs.cn/newchart/min/n/{0}.gif", line));
			}
			reader.Close();
			
			return uris.ToArray();
		}
		
		void TsbDownloadDiagramClick(object sender, EventArgs e)
		{
			Form frm = new DownloadStockDataForm();
			frm.Show();
		}
		
		void PlCanvasMouseDown(object sender, MouseEventArgs e)
		{
			
		}
		
		void PlCanvasPaint(object sender, PaintEventArgs e)
		{
			DrawImage();
		}
		
		void TsbRestartClick(object sender, EventArgs e)
		{
			displayStyle.Reset();
			DrawImage();
		}
		
		void TspSettingsClick(object sender, EventArgs e)
		{
			Form frm = new SettingsFrom();
			frm.Show();
		}
		
		void TimerTick(object sender, EventArgs e)
		{
			displayStyle.GoForward();
			DrawImage();
		}
		
		void TsbPreviousClick(object sender, EventArgs e)
		{
			PrevImage();
			DrawImage();
		}
		
		void TsbNextClick(object sender, EventArgs e)
		{
			NextImage();
			DrawImage();
		}
		
		void NextImage()
		{
			if (tvCategory.SelectedNode == null) tvCategory.SelectedNode = tvCategory.Nodes[0];
			
			if (tvCategory.SelectedNode.NextNode != null)
				tvCategory.SelectedNode = tvCategory.SelectedNode.NextNode;
		}
		void PrevImage()
		{
			if (tvCategory.SelectedNode == null) tvCategory.SelectedNode = tvCategory.Nodes[0];
			
			if (tvCategory.SelectedNode.PrevNode != null)
				tvCategory.SelectedNode = tvCategory.SelectedNode.PrevNode;
		}
		
		void TsbZoomInClick(object sender, EventArgs e)
		{
			displayStyle.Scale += 0.25F;
			DrawImage();
		}
		
		void TsbZoomOutClick(object sender, EventArgs e)
		{
			displayStyle.Scale -= 0.25F;
			DrawImage();
		}
		
		void TsbSpeedDownClick(object sender, EventArgs e)
		{
			if (Settings.Instance.MoveSpeed>1)
			{
				Settings.Instance.MoveSpeed--;
			}
		}
		
		void TsbSpeedUpClick(object sender, EventArgs e)
		{
			Settings.Instance.MoveSpeed++;
		}
		
		void TstbPageIndexKeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				//displayStyle.GoToDiagramOnId(int.Parse(tstbPageIndex.Text)-1);
				DrawImage();
			}
		}
		void DrawImage()
		{
			panelGraphics.DrawImage(displayStyle.GetDispalyImage(), 0, 0);
		}
		
		void MainFormFormClosed(object sender, FormClosedEventArgs e)
		{
			Settings.Instance.Save();
		}
		
		void PlCanvasClick(object sender, EventArgs e)
		{
			this.plCanvas.Focus();
		}
		
		void CbListTypeSelectedIndexChanged(object sender, EventArgs e)
		{
			DiagramStore diagramStore = cbListType.SelectedItem as DiagramStore;
			displayStyle.DisplayDiagramStore = diagramStore;
			
			tvCategory.Nodes.Clear();
			displayStyle.DisplayDiagramStore.FillTreeView(tvCategory);
		}
		
		void TvCategoryAfterSelect(object sender, TreeViewEventArgs e)
		{
			if (e.Node.Tag + "" == "ImageNode")
			{
				tsslSelectItemPath.Text = tvCategory.SelectedNode.FullPath;
				displayStyle.GoToDiagramOnKey(tvCategory.SelectedNode.Name);
				panelGraphics.DrawImage(displayStyle.GetDispalyImage(), 0, 0);
			}
		}
		
		void PlCanvasSizeChanged(object sender, EventArgs e)
		{
			displayStyle.Resize(plCanvas.Width, plCanvas.Height);
			panelGraphics = plCanvas.CreateGraphics();
			DrawImage();
		}
	}	
}
