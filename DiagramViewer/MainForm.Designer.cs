/*
 * Created by SharpDevelop.
 * User: Administrator
 * Date: 2013/8/24
 * Time: 10:14
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace DiagramViewer
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.tsbPlayAndStop = new System.Windows.Forms.ToolStripButton();
			this.tsbRestart = new System.Windows.Forms.ToolStripButton();
			this.tsbPrevious = new System.Windows.Forms.ToolStripButton();
			this.tsbNext = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.tsbSpeedDown = new System.Windows.Forms.ToolStripButton();
			this.tsbSpeedUp = new System.Windows.Forms.ToolStripButton();
			this.tsbZoomIn = new System.Windows.Forms.ToolStripButton();
			this.tsbZoomOut = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.tspSettings = new System.Windows.Forms.ToolStripButton();
			this.timer = new System.Windows.Forms.Timer(this.components);
			this.imageList = new System.Windows.Forms.ImageList(this.components);
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.tsslSelectItemPath = new System.Windows.Forms.ToolStripStatusLabel();
			this.plCanvas = new System.Windows.Forms.Panel();
			this.cbListType = new System.Windows.Forms.ComboBox();
			this.tvCategory = new System.Windows.Forms.TreeView();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.toolStrip1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.tsbPlayAndStop,
									this.tsbRestart,
									this.tsbPrevious,
									this.tsbNext,
									this.toolStripSeparator1,
									this.tsbSpeedDown,
									this.tsbSpeedUp,
									this.tsbZoomIn,
									this.tsbZoomOut,
									this.toolStripSeparator2,
									this.tspSettings});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(739, 25);
			this.toolStrip1.TabIndex = 0;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// tsbPlayAndStop
			// 
			this.tsbPlayAndStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbPlayAndStop.Image = ((System.Drawing.Image)(resources.GetObject("tsbPlayAndStop.Image")));
			this.tsbPlayAndStop.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbPlayAndStop.Name = "tsbPlayAndStop";
			this.tsbPlayAndStop.Size = new System.Drawing.Size(23, 22);
			this.tsbPlayAndStop.Text = "播放/停止";
			this.tsbPlayAndStop.Click += new System.EventHandler(this.TsbPlayAndStopClick);
			// 
			// tsbRestart
			// 
			this.tsbRestart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbRestart.Image = ((System.Drawing.Image)(resources.GetObject("tsbRestart.Image")));
			this.tsbRestart.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbRestart.Name = "tsbRestart";
			this.tsbRestart.Size = new System.Drawing.Size(23, 22);
			this.tsbRestart.Text = "重新开始";
			this.tsbRestart.Click += new System.EventHandler(this.TsbRestartClick);
			// 
			// tsbPrevious
			// 
			this.tsbPrevious.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbPrevious.Image = ((System.Drawing.Image)(resources.GetObject("tsbPrevious.Image")));
			this.tsbPrevious.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbPrevious.Name = "tsbPrevious";
			this.tsbPrevious.Size = new System.Drawing.Size(23, 22);
			this.tsbPrevious.Text = "上一张";
			this.tsbPrevious.Click += new System.EventHandler(this.TsbPreviousClick);
			// 
			// tsbNext
			// 
			this.tsbNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbNext.Image = ((System.Drawing.Image)(resources.GetObject("tsbNext.Image")));
			this.tsbNext.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbNext.Name = "tsbNext";
			this.tsbNext.Size = new System.Drawing.Size(23, 22);
			this.tsbNext.Text = "下一张";
			this.tsbNext.Click += new System.EventHandler(this.TsbNextClick);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// tsbSpeedDown
			// 
			this.tsbSpeedDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbSpeedDown.Image = ((System.Drawing.Image)(resources.GetObject("tsbSpeedDown.Image")));
			this.tsbSpeedDown.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbSpeedDown.Name = "tsbSpeedDown";
			this.tsbSpeedDown.Size = new System.Drawing.Size(23, 22);
			this.tsbSpeedDown.Text = "减速";
			this.tsbSpeedDown.Click += new System.EventHandler(this.TsbSpeedDownClick);
			// 
			// tsbSpeedUp
			// 
			this.tsbSpeedUp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbSpeedUp.Image = ((System.Drawing.Image)(resources.GetObject("tsbSpeedUp.Image")));
			this.tsbSpeedUp.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbSpeedUp.Name = "tsbSpeedUp";
			this.tsbSpeedUp.Size = new System.Drawing.Size(23, 22);
			this.tsbSpeedUp.Text = "加速";
			this.tsbSpeedUp.Click += new System.EventHandler(this.TsbSpeedUpClick);
			// 
			// tsbZoomIn
			// 
			this.tsbZoomIn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbZoomIn.Image = ((System.Drawing.Image)(resources.GetObject("tsbZoomIn.Image")));
			this.tsbZoomIn.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbZoomIn.Name = "tsbZoomIn";
			this.tsbZoomIn.Size = new System.Drawing.Size(23, 22);
			this.tsbZoomIn.Text = "放大";
			this.tsbZoomIn.Click += new System.EventHandler(this.TsbZoomInClick);
			// 
			// tsbZoomOut
			// 
			this.tsbZoomOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbZoomOut.Image = ((System.Drawing.Image)(resources.GetObject("tsbZoomOut.Image")));
			this.tsbZoomOut.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbZoomOut.Name = "tsbZoomOut";
			this.tsbZoomOut.Size = new System.Drawing.Size(23, 22);
			this.tsbZoomOut.Text = "缩小";
			this.tsbZoomOut.Click += new System.EventHandler(this.TsbZoomOutClick);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// tspSettings
			// 
			this.tspSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tspSettings.Image = ((System.Drawing.Image)(resources.GetObject("tspSettings.Image")));
			this.tspSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tspSettings.Name = "tspSettings";
			this.tspSettings.Size = new System.Drawing.Size(23, 22);
			this.tspSettings.Text = "设置";
			this.tspSettings.Click += new System.EventHandler(this.TspSettingsClick);
			// 
			// timer
			// 
			this.timer.Tick += new System.EventHandler(this.TimerTick);
			// 
			// imageList
			// 
			this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
			this.imageList.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList.Images.SetKeyName(0, "1092887.gif");
			this.imageList.Images.SetKeyName(1, "1092888.gif");
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.tsslSelectItemPath});
			this.statusStrip1.Location = new System.Drawing.Point(0, 475);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(739, 22);
			this.statusStrip1.TabIndex = 3;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// tsslSelectItemPath
			// 
			this.tsslSelectItemPath.Name = "tsslSelectItemPath";
			this.tsslSelectItemPath.Size = new System.Drawing.Size(0, 17);
			// 
			// plCanvas
			// 
			this.plCanvas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.plCanvas.Dock = System.Windows.Forms.DockStyle.Fill;
			this.plCanvas.Location = new System.Drawing.Point(0, 0);
			this.plCanvas.Name = "plCanvas";
			this.plCanvas.Size = new System.Drawing.Size(553, 450);
			this.plCanvas.TabIndex = 1;
			this.plCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.PlCanvasPaint);
			this.plCanvas.Click += new System.EventHandler(this.PlCanvasClick);
			this.plCanvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PlCanvasMouseDown);
			this.plCanvas.SizeChanged += new System.EventHandler(this.PlCanvasSizeChanged);
			// 
			// cbListType
			// 
			this.cbListType.Dock = System.Windows.Forms.DockStyle.Top;
			this.cbListType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbListType.FormattingEnabled = true;
			this.cbListType.Location = new System.Drawing.Point(0, 0);
			this.cbListType.Name = "cbListType";
			this.cbListType.Size = new System.Drawing.Size(182, 20);
			this.cbListType.TabIndex = 3;
			this.cbListType.SelectedIndexChanged += new System.EventHandler(this.CbListTypeSelectedIndexChanged);
			// 
			// tvCategory
			// 
			this.tvCategory.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tvCategory.ImageIndex = 0;
			this.tvCategory.ImageList = this.imageList;
			this.tvCategory.ItemHeight = 32;
			this.tvCategory.Location = new System.Drawing.Point(0, 20);
			this.tvCategory.Name = "tvCategory";
			this.tvCategory.SelectedImageIndex = 0;
			this.tvCategory.ShowPlusMinus = false;
			this.tvCategory.ShowRootLines = false;
			this.tvCategory.Size = new System.Drawing.Size(182, 430);
			this.tvCategory.TabIndex = 3;
			this.tvCategory.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TvCategoryAfterSelect);
			// 
			// splitContainer1
			// 
			this.splitContainer1.Cursor = System.Windows.Forms.Cursors.Default;
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 25);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.tvCategory);
			this.splitContainer1.Panel1.Controls.Add(this.cbListType);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.plCanvas);
			this.splitContainer1.Size = new System.Drawing.Size(739, 450);
			this.splitContainer1.SplitterDistance = 182;
			this.splitContainer1.TabIndex = 2;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(739, 497);
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.toolStrip1);
			this.KeyPreview = true;
			this.Name = "MainForm";
			this.Text = "DiagramViewer";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.SizeChanged += new System.EventHandler(this.MainFormSizeChanged);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainFormFormClosed);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainFormKeyDown);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripStatusLabel tsslSelectItemPath;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ImageList imageList;
		private System.Windows.Forms.TreeView tvCategory;
		private System.Windows.Forms.ComboBox cbListType;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.ToolStripButton tsbSpeedUp;
		private System.Windows.Forms.ToolStripButton tsbSpeedDown;
		private System.Windows.Forms.ToolStripButton tsbZoomOut;
		private System.Windows.Forms.ToolStripButton tsbZoomIn;
		private System.Windows.Forms.ToolStripButton tsbNext;
		private System.Windows.Forms.ToolStripButton tsbPrevious;
		private System.Windows.Forms.Timer timer;
		private System.Windows.Forms.ToolStripButton tsbRestart;
		private System.Windows.Forms.Panel plCanvas;
		private System.Windows.Forms.ToolStripButton tspSettings;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton tsbPlayAndStop;
		private System.Windows.Forms.ToolStrip toolStrip1;
	}
}
