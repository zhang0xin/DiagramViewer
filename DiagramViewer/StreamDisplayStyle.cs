/*
 * Created by SharpDevelop.
 * User: Administrator
 * Date: 2013/8/24
 * Time: 15:02
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;
using System.Drawing;

namespace DiagramViewer
{
	/// <summary>
	/// Description of StreamDisplayStyle.
	/// </summary> 
	public class StreamDisplayStyle2 : DisplayStyle
	{
		private Image currentImage;
		private Image previousImage;
		
		private int movedX;
		private int splitWidth = 100;
		
		public StreamDisplayStyle2(string directory, DiagramStore diagramStore, int canvasWidth, int canvasHeight) 
			: base(directory, diagramStore, canvasWidth, canvasHeight)
		{
			currentImage = _diagramStore.GetImage(_diagramStore.Index);
			previousImage = new Bitmap(currentImage.Width, currentImage.Height);
		}
		
		public override Image GetDispalyImage()
		{
			canvasGraphics.Clear(Settings.Singleton.BackColor);
			if (previousImage != null)
				canvasGraphics.DrawImage(previousImage, movedX+(currentImage.Width+splitWidth)*_diagramStore.Index, 0);
			if (currentImage != null)
				canvasGraphics.DrawImage(
					currentImage, movedX+(currentImage.Width+splitWidth)*(_diagramStore.Index + 1), 0);
			
			return canvas;
		}
		
		public override void GoForward()
		{
			movedX -= Settings.Singleton.MoveSpeed;
			
			ChangeDisplayImage();
		}
		
		public override void GoBack()
		{
			movedX += Settings.Singleton.MoveSpeed;
			
			ChangeDisplayImage();
		}
		
		public void ChangeDisplayImage()
		{
			int newImageIndex = -movedX/(currentImage.Width+splitWidth);
			
			if (_diagramStore.Index == newImageIndex) return;
			
			_diagramStore.Index = newImageIndex;
			
			if (currentImage != null) currentImage.Dispose();
			if (_diagramStore.Index >= 0 && _diagramStore.Index<_diagramStore.Count)
			{
				currentImage = new Bitmap(_diagramStore.GetImage(_diagramStore.Index));
			}
			else
			{
				Image tempImage = new Bitmap(_diagramStore.GetImage(0));
				currentImage = new Bitmap(tempImage.Width, tempImage.Height);
			}
			
			if (_diagramStore.Index-1 >= 0 && _diagramStore.Index-1<_diagramStore.Count)
			{
				if (previousImage != null) previousImage.Dispose();
				previousImage = _diagramStore.GetImage(_diagramStore.Index-1);
			}
			else
			{
				Image tempImage = _diagramStore.GetImage(0); 
				previousImage = new Bitmap(tempImage.Width, tempImage.Height);
			}
			
		}
	}
}
