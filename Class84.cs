using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml;

internal static class Class84
{
	internal static readonly List<Class74> list_0;

	static Class84()
	{
		list_0 = new List<Class74>();
		string path = Path.Combine(Application.StartupPath, Path.Combine(Class68.string_10, "bookmarks.xml"));
		if (!File.Exists(path))
		{
			return;
		}
		string xml;
		try
		{
			xml = File.ReadAllText(path, Encoding.UTF8);
		}
		catch
		{
			return;
		}
		XmlDocument xmlDocument = new XmlDocument();
		xmlDocument.LoadXml(xml);
		XmlNodeList elementsByTagName = xmlDocument.GetElementsByTagName("bookmark");
		Class74 item = new Class74
		{
			string_0 = "Сайт iBClient",
			string_1 = "http://ibclient.my1.ru/"
		};
		list_0.Add(item);
		foreach (XmlNode item2 in elementsByTagName)
		{
			Class74 @class = new Class74();
			if (item2.Attributes != null && item2.Attributes["title"] != null)
			{
				@class.string_0 = item2.Attributes["title"].Value;
			}
			else
			{
				@class.string_0 = "Без названия";
			}
			if (item2.Attributes != null && item2.Attributes["url"] != null)
			{
				@class.string_1 = item2.Attributes["url"].Value;
				if (!@class.string_1.StartsWith("http://"))
				{
					@class.string_1 = "http://" + @class.string_1;
				}
			}
			else
			{
				@class.string_1 = Class68.string_8;
			}
			if (item2.Attributes != null && item2.Attributes["icon"] != null)
			{
				string text = Path.Combine(Application.StartupPath, Path.Combine(Class68.string_10, item2.Attributes["icon"].Value));
				if (File.Exists(text))
				{
					try
					{
						@class.image_0 = Image.FromFile(text);
					}
					catch (OutOfMemoryException)
					{
					}
				}
			}
			list_0.Add(@class);
		}
	}
}
