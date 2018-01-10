/*
 * Created by SharpDevelop.
 * User: Administrator
 * Date: 2013/8/24
 * Time: 10:18
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace DiagramViewer
{
	/// <summary>
	/// Description of SettingsFrom.
	/// </summary>
	public partial class SettingsFrom : Form
	{
		public SettingsFrom()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void SettingsFromLoad(object sender, EventArgs e)
		{
			pgSettings.SelectedObject = Settings.Instance;
		}
		
		void BtnCloseClick(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
