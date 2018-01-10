/*
 * Created by SharpDevelop.
 * User: Administrator
 * Date: 2013/9/7
 * Time: 13:00
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace WindowMasker
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
			this.cmsMainFrom = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.tsmiExtendRight = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiResume = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.tsmiColor = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
			this.tsmiClose = new System.Windows.Forms.ToolStripMenuItem();
			this.colorDialog = new System.Windows.Forms.ColorDialog();
			this.cmsMainFrom.SuspendLayout();
			this.SuspendLayout();
			// 
			// cmsMainFrom
			// 
			this.cmsMainFrom.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.tsmiExtendRight,
									this.tsmiResume,
									this.toolStripMenuItem1,
									this.tsmiColor,
									this.toolStripMenuItem2,
									this.tsmiClose});
			this.cmsMainFrom.Name = "cmsMainFrom";
			this.cmsMainFrom.Size = new System.Drawing.Size(119, 104);
			this.cmsMainFrom.Opened += new System.EventHandler(this.CmsMainFromOpened);
			// 
			// tsmiExtendRight
			// 
			this.tsmiExtendRight.Name = "tsmiExtendRight";
			this.tsmiExtendRight.Size = new System.Drawing.Size(118, 22);
			this.tsmiExtendRight.Text = "向右展开";
			this.tsmiExtendRight.Click += new System.EventHandler(this.TsmiExtendRightClick);
			// 
			// tsmiResume
			// 
			this.tsmiResume.Name = "tsmiResume";
			this.tsmiResume.Size = new System.Drawing.Size(118, 22);
			this.tsmiResume.Text = "还原";
			this.tsmiResume.Click += new System.EventHandler(this.TsmiResumeClick);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(115, 6);
			// 
			// tsmiColor
			// 
			this.tsmiColor.Name = "tsmiColor";
			this.tsmiColor.Size = new System.Drawing.Size(118, 22);
			this.tsmiColor.Text = "颜色...";
			this.tsmiColor.Click += new System.EventHandler(this.TsmiColorClick);
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(115, 6);
			// 
			// tsmiClose
			// 
			this.tsmiClose.Name = "tsmiClose";
			this.tsmiClose.Size = new System.Drawing.Size(118, 22);
			this.tsmiClose.Text = "关闭";
			this.tsmiClose.Click += new System.EventHandler(this.TsmiCloseClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DimGray;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ClientSize = new System.Drawing.Size(85, 85);
			this.ContextMenuStrip = this.cmsMainFrom;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "WindowMasker";
			this.TopMost = true;
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainFormFormClosed);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainFormMouseDown);
			this.cmsMainFrom.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
		private System.Windows.Forms.ColorDialog colorDialog;
		private System.Windows.Forms.ToolStripMenuItem tsmiColor;
		private System.Windows.Forms.ToolStripMenuItem tsmiResume;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem tsmiExtendRight;
		private System.Windows.Forms.ToolStripMenuItem tsmiClose;
		private System.Windows.Forms.ContextMenuStrip cmsMainFrom;
	}
}
