/*
 * Created by SharpDevelop.
 * User: Administrator
 * Date: 2013/8/24
 * Time: 19:02
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace DiagramViewer
{
	partial class DownloadStockDataForm
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
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.tbStockListFile = new System.Windows.Forms.TextBox();
			this.tbImageStoreDirectory = new System.Windows.Forms.TextBox();
			this.btnStartDownload = new System.Windows.Forms.Button();
			this.pbDownload = new System.Windows.Forms.ProgressBar();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 139F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
			this.tableLayoutPanel1.Controls.Add(this.button1, 2, 1);
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.button2, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.tbStockListFile, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.tbImageStoreDirectory, 1, 1);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 25);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(298, 79);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(237, 33);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(58, 23);
			this.button1.TabIndex = 5;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(89, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "股票代码列表：";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(3, 30);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(69, 23);
			this.label2.TabIndex = 3;
			this.label2.Text = "存放路径：";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(237, 3);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(58, 23);
			this.button2.TabIndex = 2;
			this.button2.Text = "button2";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// tbStockListFile
			// 
			this.tbStockListFile.Location = new System.Drawing.Point(98, 3);
			this.tbStockListFile.Name = "tbStockListFile";
			this.tbStockListFile.Size = new System.Drawing.Size(123, 21);
			this.tbStockListFile.TabIndex = 4;
			// 
			// tbImageStoreDirectory
			// 
			this.tbImageStoreDirectory.Location = new System.Drawing.Point(98, 33);
			this.tbImageStoreDirectory.Name = "tbImageStoreDirectory";
			this.tbImageStoreDirectory.Size = new System.Drawing.Size(123, 21);
			this.tbImageStoreDirectory.TabIndex = 1;
			// 
			// btnStartDownload
			// 
			this.btnStartDownload.Location = new System.Drawing.Point(225, 150);
			this.btnStartDownload.Name = "btnStartDownload";
			this.btnStartDownload.Size = new System.Drawing.Size(75, 23);
			this.btnStartDownload.TabIndex = 1;
			this.btnStartDownload.Text = "开始下载";
			this.btnStartDownload.UseVisualStyleBackColor = true;
			this.btnStartDownload.Click += new System.EventHandler(this.BtnStartDownloadClick);
			// 
			// pbDownload
			// 
			this.pbDownload.Location = new System.Drawing.Point(5, 119);
			this.pbDownload.Name = "pbDownload";
			this.pbDownload.Size = new System.Drawing.Size(295, 23);
			this.pbDownload.TabIndex = 2;
			// 
			// DownloadStockDataForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(312, 185);
			this.Controls.Add(this.pbDownload);
			this.Controls.Add(this.btnStartDownload);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "DownloadStockDataForm";
			this.Text = "DownloadStockDataForm";
			this.Load += new System.EventHandler(this.DownloadStockDataFormLoad);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.ProgressBar pbDownload;
		private System.Windows.Forms.TextBox tbImageStoreDirectory;
		private System.Windows.Forms.TextBox tbStockListFile;
		private System.Windows.Forms.Button btnStartDownload;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
	}
}
