/*
 * Created by SharpDevelop.
 * User: Administrator
 * Date: 2013/8/24
 * Time: 10:16
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;
using System.Drawing;
using System.Xml.Serialization;
using System.Windows.Forms;

namespace DiagramViewer
{
	/// <summary>
	/// Description of Settings.
	/// </summary>
	public class Settings
	{
		static string settingsFileName = "settings.xml";
		
		#region code for singleton
		static Settings()
		{
			instance = new Settings();
		}
		public static Settings Instance
		{
			get { return instance; }
		}
		private static Settings instance;
		#endregion
		
		public Settings()
		{
			this.Scale = 1;
			this.DiagramDirectory = @"Diagrams\";
			this.StockListFile = @"stock.txt";
			this.MoveSpeed = 1;
			this.BackColor = Color.Black;
		}
		
		public void Save()
		{
			ConfigManager.SaveToFileForSingleton<Settings>(settingsFileName);
		}
		public void Load()
		{
			if (File.Exists(settingsFileName))
			{
				ConfigManager.LoadFromFileForSingleton<Settings>(settingsFileName);
			}
			else
			{
				Save();
			}
		}
		
		private float _scale;
		public float Scale
		{
			get { return _scale; }
			set { _scale = value; }
		}
		
		private Color _backColor;
		[XmlIgnore]
		public Color BackColor
		{
			get { return _backColor; }
			set { _backColor = value; }
		}
		[XmlElement("BackColor")]
		public string _BackColor
		{
			get { return ColorTranslator.ToHtml(_backColor); }
			set { _backColor = ColorTranslator.FromHtml(value); }
		}
		
		private int _moveSpeed;
		public int MoveSpeed
		{
			get { return _moveSpeed; }
			set { _moveSpeed = value; }
		}
		
		private string _diagramDirectory; 
		public string DiagramDirectory
		{
			get { return _diagramDirectory; }
			set 
			{
				if (Directory.Exists(value))
					_diagramDirectory = value; 
				else
					throw new Exception("路径不存在:"+value);
			}
		}
		
		private string _stockListFile;
		public string StockListFile
		{
			get {return _stockListFile; }
			set {_stockListFile = value; }
		}
	}
}
