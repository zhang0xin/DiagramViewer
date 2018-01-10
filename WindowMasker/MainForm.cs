/*
 * Created by SharpDevelop.
 * User: Administrator
 * Date: 2013/9/7
 * Time: 13:00
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace WindowMasker
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		int speed = 1;
		bool isExtend = false;
		Rectangle originalBounds;
		Hotkey hotkeyLeft;
		Hotkey hotkeyRight;
		Image backImage;
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			originalBounds = this.Bounds;
			this.TransparencyKey = Color.Blue;
			backImage = this.BackgroundImage;
			
			AddKeyEvent();
		}
		
		void AddKeyEvent()
		{
			hotkeyLeft = new Hotkey(this.Handle);
			hotkeyLeft.RegisterHotkey(Keys.Left, Hotkey.KeyFlags.MOD_NONE);
			hotkeyLeft.OnHotkey += delegate 
			{
				if (!isExtend) return;
				this.Bounds = new Rectangle(this.Left-speed, this.Top, this.Width+speed, this.Height);
			};
			
			hotkeyRight = new Hotkey(this.Handle);
			hotkeyRight.RegisterHotkey(Keys.Right, Hotkey.KeyFlags.MOD_NONE);
			hotkeyRight.OnHotkey += delegate 
			{
				if (!isExtend) return;
				this.Bounds = new Rectangle(this.Left+speed, this.Top, this.Width-speed, this.Height);
			};
		}
		void MainFormLoad(object sender, EventArgs e)
		{
			this.Bounds = new Rectangle(this.Left, this.Top, originalBounds.Width, originalBounds.Height);
			originalBounds = this.Bounds;
		}
		
		void MainFormFormClosed(object sender, FormClosedEventArgs e)
		{
			hotkeyLeft.UnregisterHotkeys();
			hotkeyRight.UnregisterHotkeys();
		}
		
		void TsmiCloseClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void TsmiExtendRightClick(object sender, EventArgs e)
		{
			ExtendForm();
		}
		void ExtendForm()
		{
			this.Visible = false;
			
			isExtend = true;
			this.originalBounds = new Rectangle(new Point(this.Left,this.Top), originalBounds.Size);
			this.Bounds = new Rectangle(
				this.Left, 0, 
				Screen.PrimaryScreen.Bounds.Width-this.Left, 
				Screen.PrimaryScreen.Bounds.Height);
			this.BackgroundImage = null;
			
			this.Visible = true;
		}
		
		DateTime lastMouseDown = DateTime.MinValue;
		void MainFormMouseDown(object sender, MouseEventArgs e)
		{
			ReleaseCapture();
			PostMessage((int)this.Handle, 0x0112, 0xf017, 0);
			
			System.Diagnostics.Debug.WriteLine((DateTime.Now-lastMouseDown).Ticks + "");
			if ((DateTime.Now-lastMouseDown)< new TimeSpan(3000000)) //3000000单位是毫微秒
			{
				OnMainFormDoubleClick();
			}
			lastMouseDown = DateTime.Now;
		}
		[DllImport("user32")]
		private static extern bool ReleaseCapture();
		[DllImport("user32")]
		private static extern bool PostMessage(int hWnd, int Mwg, int wParam, int lParam);
		
		void TsmiResumeClick(object sender, EventArgs e)
		{
			ResumeForm();
		}
		void ResumeForm()
		{
			this.Visible = false;
			
			isExtend = false;
			this.Bounds = originalBounds;
			this.BackgroundImage = backImage;
			this.TransparencyKey = Color.Blue;
			
			this.Visible = true;
		}
		
		void TsmiColorClick(object sender, EventArgs e)
		{
			colorDialog.Color = this.BackColor;
			if (colorDialog.ShowDialog() == DialogResult.OK)
			{
				this.BackColor = colorDialog.Color;
			}
		}
		
		void CmsMainFromOpened(object sender, EventArgs e)
		{
			if (isExtend)
			{
				tsmiResume.Enabled = true;
				tsmiExtendRight.Enabled = false;
			}
			else
			{
				tsmiResume.Enabled = false;
				tsmiExtendRight.Enabled = true;
			}
		}
		
		void OnMainFormDoubleClick()
		{
			if (isExtend) ResumeForm();
			else ExtendForm();
		}
	}
}
