using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml;

internal sealed class Class79 : Dictionary<string, Dictionary<string, Class78>>
{
	internal Class79 method_0()
	{
		string path = Path.Combine(Application.StartupPath, "map_mines.xml");
		if (!File.Exists(path))
		{
			return null;
		}
		Class79 @class = new Class79();
		XmlDocument xmlDocument = new XmlDocument();
		xmlDocument.LoadXml(File.ReadAllText(path));
		foreach (XmlNode item in xmlDocument.GetElementsByTagName("mine"))
		{
			if (item.Attributes == null)
			{
				continue;
			}
			string value = item.Attributes["mineid"].Value;
			string value2 = item.Attributes["level"].Value;
			Dictionary<string, Class78> dictionary = new Dictionary<string, Class78>();
			foreach (XmlNode childNode in item.ChildNodes)
			{
				Class78 class2 = new Class78(childNode.Attributes["x"].Value, childNode.Attributes["y"].Value)
				{
					string_2 = childNode.Attributes["img"].Value
				};
				try
				{
					class2.string_3 = childNode.Attributes["usefull"].Value;
				}
				catch
				{
					class2.string_3 = "0";
				}
				dictionary.Add(class2.string_0 + "-" + class2.string_1, class2);
			}
			@class.Add(value + "-" + value2, dictionary);
		}
		return @class;
	}

	internal Class78 method_1(string string_0, string string_1)
	{
		return Class72.class79_0[Class72.class5_0.method_10() + "-" + Class72.class5_0.method_2()][string_0 + "-" + string_1];
	}

	internal string method_2(string string_0, string string_1, string string_2)
	{
		string text = string.Empty;
		string empty = string.Empty;
		string text2 = string.Empty;
		string text3 = string.Empty;
		Class78 @class = Class72.class79_0.method_1(string_0, string_1);
		if (Class72.bool_44 && Class72.class80_0 != null && Class72.class80_0.method_2().Length != 0)
		{
			Class78 class2 = Class72.class80_0.method_13(@class);
			if (class2 != null)
			{
				switch (Class72.class80_0.method_12(@class, class2))
				{
				case "down":
					text2 = "<div style=\"position:absolute; top:63px; left:63px; width:4px; height:130px; background-color:#F5F5CE; z-index:1;\"></div>";
					break;
				case "up":
					text2 = "<div style=\"position:absolute; bottom:63px; left:63px; width:4px; height:130px; background-color:#F5F5CE; z-index:1;\"></div>";
					break;
				case "right":
					text2 = "<div style=\"position:absolute; top:63px; left:63px; width:130px; height:4px; background-color:#F5F5CE; z-index:1;\"></div>";
					break;
				case "left":
					text2 = "<div style=\"position:absolute; top:63px; right:63px; width:130px; height:4px; background-color:#F5F5CE; z-index:1;\"></div>";
					break;
				}
			}
			if (string_0 == Class72.class78_0.string_0 && string_1 == Class72.class78_0.string_1)
			{
				text = "<div style=\"box-shadow:0px 0px 0px 4px #F5F5CE inset; height:130px;\"></div>";
			}
		}
		if (string_0 == Class72.class5_0.method_6() && string_1 == Class72.class5_0.method_8())
		{
			text = "<div style=\"box-shadow:0px 0px 0px 4px #CC4031 inset;height: 130px;\"></div>";
		}
		if (@class.string_3 == "1")
		{
			text3 = " background: green; opacity: 0.3;";
		}
		if (@class.string_3 == "-1")
		{
			text3 = " background: red; opacity: 0.3;";
		}
		empty = "<div style=\"position:absolute; left:2px; top:2px; width:126px; height:126px; box-sizing:border-box;" + text3 + "\"></div>";
		empty += text2;
		empty = empty + "<span style=\"color:white; font-weight:bold; font-size:10px; text-shadow:black 1px 1px 0, black -1px -1px 0, black -1px 1px 0, black 1px -1px 0; position:absolute; top:50px; width:130px; text-align:center; z-index:2;\">" + string_0 + "x" + string_1 + "<br>Ур. " + string_2 + "</span>";
		return empty + text;
	}

	internal string method_3()
	{
		Class72.formMain_0.method_104();
		if (Class72.bool_44 && Class72.class80_0.method_6() > 0)
		{
			return "Пункт назначения: " + Class72.class78_0.string_0 + "x" + Class72.class78_0.string_1 + "<br>Ещё переходов: " + Class72.class80_0.method_6();
		}
		return string.Empty;
	}

	internal void method_4(string string_0)
	{
		string text = Class72.class5_0.method_10();
		string text2 = Class72.class5_0.method_2();
		string text3 = Class72.class5_0.method_6();
		string text4 = Class72.class5_0.method_8();
		Class72.class79_0[text + "-" + text2][text3 + "-" + text4].string_3 = string_0;
		Class72.formMain_0.BeginInvoke(new Delegate20(Class72.formMain_0.method_110), new object[0]);
	}

	internal void method_5()
	{
		foreach (KeyValuePair<string, Class78> item in Class72.class79_0[Class72.class5_0.method_10() + "-" + Class72.class5_0.method_2()])
		{
			item.Value.string_3 = "0";
		}
		Class72.formMain_0.BeginInvoke(new Delegate20(Class72.formMain_0.method_110), new object[0]);
	}
}
