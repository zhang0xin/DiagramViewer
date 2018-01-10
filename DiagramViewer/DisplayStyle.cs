/*
 * Created by SharpDevelop.
 * User: Administrator
 * Date: 2013/8/24
 * Time: 17:23
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;
using System.Drawing;

namespace DiagramViewer
{
	/// <summary>
	/// Description of DisplayStyle.
	/// </summary>
	public abstract class DisplayStyle
	{
		protected DiagramStore _diagramStore;
		
		protected Bitmap _canvas;
		protected Graphics _canvasGraphics;
		public delegate void OnPageEnd();
		public event OnPageEnd PageEnd;
		
		public DisplayStyle(DiagramStore diagramStore, int canvasWidth, int canvasHeight)
		{
			_diagramStore = diagramStore;
			
			_canvas = new Bitmap(canvasWidth, canvasHeight);
			_canvasGraphics = Graphics.FromImage(_canvas);
		}
		
		public abstract void GoToDiagramOnKey(string key);
		public virtual void GoForward()
		{}
		public virtual void GoBack()
		{}
		public void TriggerOnPageEnd()
		{
			if (PageEnd != null) PageEnd();
		}
		public virtual Image GetDispalyImage()
		{
			throw new NotImplementedException();
		}
		public virtual void Resize(int width, int height)
		{
			if (width == 0 && height == 0) return;
			_canvas = new Bitmap(width, width);
			_canvasGraphics = Graphics.FromImage(_canvas);
		}
		public virtual void Reset()
		{
			throw new NotImplementedException();
		}
		public int ImageCount
		{
			get { return _diagramStore.Count; }
		}
		public int ImageIndex
		{
			get { return _diagramStore.Index; }
			//set { _diagramStore.Index = value; }
		}
		
		
		public virtual float Scale
		{
			get {return Settings.Instance.Scale; }
			set { Settings.Instance.Scale = value; }
		}
		
		public DiagramStore DisplayDiagramStore
		{
			get { return _diagramStore; }
			set { _diagramStore = value; }
		}
	}
}
