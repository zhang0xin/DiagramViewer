/*
 * Created by SharpDevelop.
 * User: Administrator
 * Date: 2012-2-18
 * Time: 9:46
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;
using System.Reflection;
using System.Xml.Serialization;

namespace DiagramViewer
{
	/// <summary>
	/// Description of ConfigLoader.
	/// </summary>
	public class ConfigManager
	{
		static ConfigManager()
		{
		}
		
		public static void SaveToFileForSingleton<T>(string fileName)
		{
			SaveToFileForSingleton(typeof(T), fileName);
		}
		
		public static void SaveToFileForSingleton(Type type, string fileName)
		{
			FileStream stream = 
				new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.ReadWrite);
			SaveToFileForSingleton(type, stream);
			stream.Close();
		}
		
		public static void SaveToStreamForSingleton<T>(Stream stream)
		{
			SaveToFileForSingleton(typeof(T), stream);
		}
		
		public static void SaveToFileForSingleton(Type type, Stream stream)
		{
			object obj = GetInstanceField(type).GetValue(null);
			SaveToStream(stream, obj);
		}
		
		public static void SaveToFile(string fileName, object obj)
		{
			FileStream stream = 
				new FileStream(fileName, FileMode.Create, FileAccess.ReadWrite);
			SaveToStream(stream, obj);
			stream.Close();
		}
		
		public static void SaveToStream(Stream stream, object obj)
		{
			serializer = new XmlSerializer(obj.GetType());
			
			StreamWriter writer = new StreamWriter(stream);
			serializer.Serialize(writer, obj);
			writer.Close();
		}
		
		public static void LoadFromFileForSingleton<T>(string fileName)
		{
			LoadFromFileForSingleton(typeof(T), fileName);
		}
		
		public static void LoadFromFileForSingleton(Type type, string fileName)
		{
			FileStream stream = 
				new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.Read);
			
			LoadFromStreamForSingleton(type, stream);
			stream.Close();
		}
		
		public static void LoadFromStreamForSingleton<T>(Stream stream)
		{
			LoadFromStreamForSingleton(typeof(T), stream);
		}
		
		public static void LoadFromStreamForSingleton(Type type, Stream stream)
		{
			object obj;
			LoadFromStream(type, stream, out obj);
			GetInstanceField(type).SetValue(null, obj);
		}
		
		public static void LoadFromFile<T>(string fileName, T targetObj)
		{
			T sourceObj;
			LoadFromFile<T>(fileName, out sourceObj);
			
			CopyFieldValue(sourceObj, targetObj);
		}	
				
		public static void LoadFromFile<T>(string fileName, out T obj)
		{
			object objTemp;
			LoadFromFile(typeof(T), fileName, out objTemp);
			obj = (T)objTemp;
		}
				
		public static void LoadFromFile(Type type, string fileName, out object obj)
		{
			FileStream stream = 
				new FileStream(fileName, FileMode.Open, FileAccess.ReadWrite, FileShare.Read, 10000);
			LoadFromStream(type, stream, out obj);
			stream.Close();
		}
		
		public static void LoadFromStream<T>(Stream stream, out T obj)
		{
			object objTemp; 
			LoadFromStream(typeof(T), stream, out objTemp);
			obj = (T)objTemp;
		}
		
		public static void LoadFromStream(Type type, Stream stream, out object obj)
		{
//			Debug.WriteLine(type.ToString() + "{");
//			ElapsedTime.Start();
			
			serializer = new XmlSerializer(type);
			obj = serializer.Deserialize(stream);
			stream.Close();
			
//			DateTime end = DateTime.Now;
//			Debug.WriteLine(type.ToString() + "}: " + ElapsedTime.ElapsedSecends());
		}
		
		private static void CopyFieldValue(object sourceObj, object targetObj)
		{
			Type sourceType = sourceObj.GetType();
			Type targetType = targetObj.GetType();
			
			if (sourceType != targetType)
				throw new Exception("source type must same with target type.");
			
			FieldInfo[] fields = sourceType.GetFields(
				BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
			foreach(FieldInfo field in fields)
			{
				object value = field.GetValue(sourceObj);
				field.SetValue(targetObj, value);
			}
		}
				
		private static FieldInfo GetInstanceField(Type type)
		{
			FieldInfo field = type.GetField("instance", BindingFlags.Static | BindingFlags.NonPublic);
			if (field == null)
				throw new Exception("未找到Singleton模式中的instance变量。");
			return field;
		}
		
		private static XmlSerializer serializer;
	}
}
