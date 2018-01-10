/*
 * Created by SharpDevelop.
 * User: DELL
 * Date: 2013-8-25
 * Time: 8:01
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;

namespace DiagramViewer
{
	/// <summary>
	/// Description of DiagramStore.
	/// </summary>
	public abstract class DiagramStore
	{
		int imageIndex;
		string name;
		
		public DiagramStore()
		{
		}
		
		public string Name
		{
			get { return name; }
			set { name = value; }
		}
		public override string ToString()
		{
			return Name;
		}
		public Image GetScaledImageOnKey(string key, float scale)
		{
			Image originalImage = GetImageOnKey(key);
			
			int scaledWidth = (int)(originalImage.Width*scale);
			int scaledHeight = (int)(originalImage.Height*scale);
			Image scaledImage = new Bitmap(scaledWidth, scaledHeight);
			
			Graphics graphics = Graphics.FromImage(scaledImage);
			graphics.DrawImage(originalImage, 0, 0, scaledImage.Width, scaledImage.Height);
			
			return scaledImage;
		}
		
		public int Index
		{
			get { return imageIndex; }
			set { imageIndex = value; }
		}
		public bool IsIndexOutOfBound()
		{
			return IsIndexLowOutOfBound() && IsIndexUpOutOfBound();
		}
		public bool IsIndexUpOutOfBound()
		{
			return Index >= Count;
		}
		public bool IsIndexLowOutOfBound()
		{
			return Index < 0;
		}
		
		
		public abstract Image GetImageOnIndex(int index);
		public abstract Image GetImageOnKey(string key);
		public abstract int Count {get;}
		public abstract void FillTreeView(System.Windows.Forms.TreeView treeView);
	}
}
