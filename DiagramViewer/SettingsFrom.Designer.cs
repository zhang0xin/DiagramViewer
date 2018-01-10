/*
 * Created by SharpDevelop.
 * User: Administrator
 * Date: 2013/8/24
 * Time: 10:18
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace DiagramViewer
{
	partial class SettingsFrom
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
			this.pgSettings = new System.Windows.Forms.PropertyGrid();
			this.btnClose = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// pgSettings
			// 
			this.pgSettings.Location = new System.Drawing.Point(12, 12);
			this.pgSettings.Name = "pgSettings";
			this.pgSettings.Size = new System.Drawing.Size(308, 302);
			this.pgSettings.TabIndex = 8;
			// 
			// btnClose
			// 
			this.btnClose.Location = new System.Drawing.Point(245, 332);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(75, 23);
			this.btnClose.TabIndex = 9;
			this.btnClose.Text = "关闭";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.BtnCloseClick);
			// 
			// SettingsFrom
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(332, 367);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.pgSettings);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SettingsFrom";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SettingsFrom";
			this.Load += new System.EventHandler(this.SettingsFromLoad);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.PropertyGrid pgSettings;
	}
}
