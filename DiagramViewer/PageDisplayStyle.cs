/*
 * Created by SharpDevelop.
 * User: Administrator
 * Date: 2013/8/24
 * Time: 17:27
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;

namespace DiagramViewer
{
	/// <summary>
	/// Description of PageDisplayStyle.
	/// </summary>
	public class PageDisplayStyle : DisplayStyle
	{
		private int _barX;
		private Image _tempImage;
		private string _currentImageKey;
		
		public PageDisplayStyle(DiagramStore diagramStore, int canvasWidth, int canvasHeight) 
			: base(diagramStore, canvasWidth, canvasHeight)
		{
			_barX = 0;
		}

		public override void GoToDiagramOnKey(string key)
		{
			_barX = 0;
			if (_tempImage != null) _tempImage.Dispose();
			_tempImage = _diagramStore.GetScaledImageOnKey(key, Scale);
			_currentImageKey = key;
		}
		public override void GoForward()
		{
			if (_tempImage == null) return;
			
			if (_barX >= _tempImage.Width)
			{
				_diagramStore.Index ++;
				_barX = 0;
				
				if (_diagramStore.IsIndexUpOutOfBound())
					_diagramStore.Index = 0;
				
				TriggerOnPageEnd();
			}
			
			_barX += Settings.Instance.MoveSpeed;
		}
		public override void GoBack()
		{
			if (_barX <= 0) 
			{
				_barX = 0;
				return;
			}
			
			_barX -= Settings.Instance.MoveSpeed;
		}
		public override System.Drawing.Image GetDispalyImage()
		{
			_canvasGraphics.Clear(Settings.Instance.BackColor);
			
			if (_tempImage != null)
			{
				_canvasGraphics.DrawImage(_tempImage, 0, 0);
				_canvasGraphics.FillRectangle(
					new SolidBrush(Settings.Instance.BackColor), 
					_barX, 0, _tempImage.Width, _tempImage.Height);
				
				_canvasGraphics.DrawLine(new Pen(Color.Blue), _barX,0, _barX, _tempImage.Height);
			}
			return _canvas;
		}
		
		public override void Reset()
		{
			_barX = 0;
		}
		
		public override float Scale {
			get { return base.Scale; }
			set 
			{ 
				base.Scale = value; 
				_tempImage = _diagramStore.GetScaledImageOnKey(_currentImageKey, Scale);
			}
		}
	}
}
