using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using ABClient.ExtMap;

internal static class Class77
{
	private static SortedDictionary<string, Class85> sortedDictionary_0;

	private static SortedDictionary<string, string> sortedDictionary_1;

	private static SortedDictionary<string, Cell> sortedDictionary_2;

	private static SortedDictionary<string, AbcCell> sortedDictionary_3;

	private static SortedDictionary<string, string> sortedDictionary_4;

	private static SortedList<string, string> sortedList_0;

	static Class77()
	{
		smethod_1(new SortedDictionary<string, Class85>());
		smethod_3(new SortedDictionary<string, string>());
		smethod_5(new SortedDictionary<string, Cell>());
		smethod_7(new SortedDictionary<string, AbcCell>());
		smethod_9(new SortedDictionary<string, string>());
		smethod_28("1", 952, 954);
		smethod_28("2", 982, 954);
		smethod_28("3", 1012, 954);
		smethod_28("13", 1042, 954);
		smethod_28("4", 952, 973);
		smethod_28("5", 982, 973);
		smethod_28("6", 1012, 973);
		smethod_28("14", 1042, 973);
		smethod_28("7", 952, 992);
		smethod_28("8", 982, 992);
		smethod_28("9", 1012, 992);
		smethod_28("15", 1042, 992);
		smethod_28("10", 952, 1011);
		smethod_28("11", 982, 1011);
		smethod_28("12", 1012, 1011);
		smethod_28("16", 1042, 1011);
		smethod_28("17", 922, 954);
		smethod_28("18", 922, 973);
		smethod_28("19", 922, 992);
		smethod_28("20", 922, 1011);
		smethod_28("21", 922, 1030);
		smethod_28("22", 922, 1049);
		smethod_28("23", 952, 1030);
		smethod_28("24", 952, 1049);
		smethod_28("25", 982, 1030);
		smethod_28("26", 982, 1049);
		smethod_28("27", 1012, 1030);
		smethod_28("28", 1012, 1049);
		smethod_28("29", 1042, 1030);
		smethod_28("30", 1042, 1049);
		smethod_28("31", 1072, 954);
		smethod_28("32", 1072, 973);
		smethod_28("33", 1072, 992);
		smethod_28("34", 1072, 1011);
		smethod_28("35", 1072, 1030);
		smethod_28("36", 1072, 1049);
		smethod_15();
		smethod_12();
		smethod_13();
		smethod_14();
	}

	internal static SortedDictionary<string, Class85> smethod_0()
	{
		return sortedDictionary_0;
	}

	private static void smethod_1(SortedDictionary<string, Class85> sortedDictionary_5)
	{
		sortedDictionary_0 = sortedDictionary_5;
	}

	internal static SortedDictionary<string, string> smethod_2()
	{
		return sortedDictionary_1;
	}

	private static void smethod_3(SortedDictionary<string, string> sortedDictionary_5)
	{
		sortedDictionary_1 = sortedDictionary_5;
	}

	internal static SortedDictionary<string, Cell> smethod_4()
	{
		return sortedDictionary_2;
	}

	private static void smethod_5(SortedDictionary<string, Cell> sortedDictionary_5)
	{
		sortedDictionary_2 = sortedDictionary_5;
	}

	internal static SortedDictionary<string, AbcCell> smethod_6()
	{
		return sortedDictionary_3;
	}

	private static void smethod_7(SortedDictionary<string, AbcCell> sortedDictionary_5)
	{
		sortedDictionary_3 = sortedDictionary_5;
	}

	internal static SortedDictionary<string, string> smethod_8()
	{
		return sortedDictionary_4;
	}

	private static void smethod_9(SortedDictionary<string, string> sortedDictionary_5)
	{
		sortedDictionary_4 = sortedDictionary_5;
	}

	internal static SortedList<string, string> smethod_10()
	{
		return sortedList_0;
	}

	private static void smethod_11(SortedList<string, string> sortedList_1)
	{
		sortedList_0 = sortedList_1;
	}

	private static void smethod_12()
	{
		string path = Path.Combine(Application.StartupPath, "abcells.xml");
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
		try
		{
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml(xml);
			foreach (XmlNode item in xmlDocument.GetElementsByTagName("cell"))
			{
				if (item.Attributes == null)
				{
					continue;
				}
				AbcCell abcCell = new AbcCell();
				if (item.Attributes["regnum"] == null)
				{
					continue;
				}
				abcCell.RegNum = item.Attributes["regnum"].Value;
				if (item.Attributes["label"] != null)
				{
					abcCell.Label = item.Attributes["label"].Value;
					if (smethod_4().ContainsKey(abcCell.RegNum))
					{
						abcCell.Label.Equals(smethod_4()[abcCell.RegNum].Tooltip, StringComparison.CurrentCultureIgnoreCase);
					}
				}
				int result = 0;
				if (item.Attributes["cost"] != null && !int.TryParse(item.Attributes["cost"].Value, out result))
				{
					result = 0;
				}
				abcCell.Cost = result;
				if (abcCell.Cost == 0 && smethod_4().ContainsKey(abcCell.RegNum))
				{
					switch (smethod_4()[abcCell.RegNum].Cost)
					{
					case 21:
						abcCell.Cost = 30;
						break;
					case 28:
						abcCell.Cost = 40;
						break;
					case 43:
						abcCell.Cost = 60;
						break;
					}
				}
				DateTime result2 = DateTime.MinValue;
				if (item.Attributes["visited"] != null && !DateTime.TryParse(item.Attributes["visited"].Value, Class72.cultureInfo_1, DateTimeStyles.None, out result2))
				{
					result2 = DateTime.MinValue;
				}
				abcCell.Visited = result2;
				DateTime result3 = DateTime.MinValue;
				if (item.Attributes["verified"] != null && !DateTime.TryParse(item.Attributes["verified"].Value, Class72.cultureInfo_1, DateTimeStyles.None, out result3))
				{
					result3 = DateTime.MinValue;
				}
				abcCell.Verified = result3;
				smethod_6().Add(abcCell.RegNum, abcCell);
			}
		}
		catch
		{
		}
	}

	private static void smethod_13()
	{
		List<string> list = new List<string>();
		foreach (KeyValuePair<string, Cell> item in smethod_4())
		{
			if (!smethod_6().ContainsKey(item.Value.CellNumber))
			{
				list.Add(item.Value.CellNumber);
			}
		}
		foreach (string item2 in list)
		{
			smethod_4().Remove(item2);
		}
		foreach (KeyValuePair<string, AbcCell> item3 in smethod_6())
		{
			if (!smethod_4().ContainsKey(item3.Value.RegNum))
			{
				Cell cell = new Cell
				{
					CellNumber = item3.Value.RegNum,
					Name = item3.Value.Label
				};
				smethod_4().Add(cell.CellNumber, cell);
			}
		}
	}

	private static void smethod_14()
	{
		string path = Path.Combine(Application.StartupPath, "abteleports.xml");
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
		smethod_11(new SortedList<string, string>());
		XmlDocument xmlDocument = new XmlDocument();
		xmlDocument.LoadXml(xml);
		foreach (XmlNode item in xmlDocument.GetElementsByTagName("teleport"))
		{
			if (item.Attributes != null)
			{
				string value = item.Attributes["regnum"].Value;
				string value2 = item.Attributes["name"].Value;
				smethod_10().Add(value, value2);
			}
		}
	}

	private static void smethod_15()
	{
		string path = Path.Combine(Application.StartupPath, "map.xml");
		if (!File.Exists(path))
		{
			return;
		}
		XmlDocument xmlDocument = new XmlDocument();
		xmlDocument.LoadXml(File.ReadAllText(path));
		foreach (XmlNode item in xmlDocument.GetElementsByTagName("cell"))
		{
			if (item.Attributes != null)
			{
				Cell cell = new Cell();
				cell.CellNumber = item.Attributes["cellNumber"].Value.Trim();
				int.TryParse(item.Attributes["cost"].Value.Trim(), out var result);
				cell.Cost = result;
				bool.TryParse(item.Attributes["hasFish"].Value.Trim(), out var result2);
				cell.HasFish = result2;
				bool.TryParse(item.Attributes["hasWater"].Value.Trim(), out var result3);
				cell.HasWater = result3;
				cell.HerbGroup = item.Attributes["herbGroup"].Value.Trim();
				cell.Name = item.Attributes["name"].Value.Trim();
				cell.Tooltip = item.Attributes["tooltip"].Value.Trim();
				cell.Updated = item.Attributes["updated"].Value.Trim();
				cell.NameUpdated = item.Attributes["nameUpdated"].Value.Trim();
				cell.CostUpdated = item.Attributes["costUpdated"].Value.Trim();
				smethod_4().Add(cell.CellNumber, cell);
			}
		}
		foreach (XmlNode item2 in xmlDocument.GetElementsByTagName("bots"))
		{
			if (item2.Attributes == null)
			{
				continue;
			}
			string name = item2.Attributes["name"].Value.Trim();
			int.TryParse(item2.Attributes["minLevel"].Value, out var result4);
			int.TryParse(item2.Attributes["maxLevel"].Value, out var result5);
			string value = item2.Attributes["c"].Value;
			string value2 = item2.Attributes["d"].Value;
			MapBot mapBot = new MapBot(name, result4, result5, value, value2);
			XmlNode parentNode = item2.ParentNode;
			if (parentNode != null)
			{
				string text = Cell.NormalizeRegNum(parentNode.Attributes["cellNumber"].Value.Trim());
				if (!smethod_4().ContainsKey(text))
				{
					throw new Exception(text);
				}
				smethod_4()[text].AddMapBot(mapBot);
			}
		}
	}

	public static void smethod_16()
	{
		XmlWriterSettings settings = new XmlWriterSettings
		{
			Indent = true
		};
		MemoryStream memoryStream = new MemoryStream();
		XmlWriter xmlWriter = XmlWriter.Create(memoryStream, settings);
		xmlWriter.WriteStartDocument();
		xmlWriter.WriteStartElement("cells");
		foreach (KeyValuePair<string, AbcCell> item in smethod_6())
		{
			xmlWriter.WriteStartElement("cell");
			xmlWriter.WriteStartAttribute("regnum");
			xmlWriter.WriteString(item.Value.RegNum);
			xmlWriter.WriteEndAttribute();
			xmlWriter.WriteStartAttribute("label");
			xmlWriter.WriteString(item.Value.Label);
			xmlWriter.WriteEndAttribute();
			xmlWriter.WriteStartAttribute("cost");
			xmlWriter.WriteValue(item.Value.Cost);
			xmlWriter.WriteEndAttribute();
			xmlWriter.WriteStartAttribute("visited");
			xmlWriter.WriteString(item.Value.Visited.ToString(Class72.cultureInfo_1));
			xmlWriter.WriteEndAttribute();
			xmlWriter.WriteStartAttribute("verified");
			xmlWriter.WriteString(item.Value.Verified.ToString(Class72.cultureInfo_1));
			xmlWriter.WriteEndAttribute();
			xmlWriter.WriteEndElement();
		}
		xmlWriter.WriteEndElement();
		xmlWriter.WriteEndDocument();
		xmlWriter.Flush();
		FileStream fileStream = new FileStream("abcells_new.xml", FileMode.Create);
		memoryStream.WriteTo(fileStream);
		fileStream.Close();
		memoryStream.Close();
		try
		{
			File.Delete("abcells.xml");
			File.Move("abcells_new.xml", "abcells.xml");
		}
		catch (IOException)
		{
		}
	}

	internal static bool smethod_17(string string_0)
	{
		if (Class72.class19_0.sortedDictionary_0.TryGetValue(string_0, out var value) && !string.IsNullOrEmpty(Class72.class19_0.method_196()))
		{
			string[] array = Class72.class19_0.method_196().Split(',');
			foreach (string text in array)
			{
				if (value.string_1.Contains(text.Trim()))
				{
					return true;
				}
			}
		}
		return false;
	}

	internal static string smethod_18(int int_0, int int_1, int int_2, string string_0, bool bool_0, bool bool_1)
	{
		string text = smethod_30(int_0, int_1);
		if (text == null)
		{
			return string.Empty;
		}
		if (!smethod_0().TryGetValue(text, out var value))
		{
			return string.Empty;
		}
		string text2 = value.method_4();
		if (text2 == null)
		{
			return string.Empty;
		}
		if (!smethod_4().TryGetValue(text2, out var value2))
		{
			return string.Empty;
		}
		string text3 = string.Empty;
		string text4 = string.Empty;
		if (smethod_17(value2.CellNumber))
		{
			text3 = "border:1px solid yellow;";
		}
		if (bool_1 || bool_0)
		{
			text3 = "border:1px solid red;";
		}
		if (bool_0)
		{
			text4 = "id=\"movingcell\" ";
		}
		else if (Class72.smethod_36() && Class72.smethod_46() != null && Class72.smethod_46().Path.Length != 0 && Array.IndexOf(Class72.smethod_46().Path, text2) >= 0)
		{
			text3 = "border:1px solid red;";
		}
		string text5 = smethod_24(value2.Cost);
		string text6 = value2.Tooltip;
		if (text6.IndexOf(',') != -1)
		{
			text6 = text6.Split(',')[1];
		}
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append("<div " + text4 + " style=\"position:relative; left:2px; top:2px; width:90px; height:90px; " + text3 + " padding:2px; text-shadow:1px 1px 1px, -1px -1px 1px, -1px 1px 1px, 1px -1px 1px; font-family:Tahoma; font-size:9px; font-weight:bold; text-decoration:none;\">");
		stringBuilder.Append("<span style=\"font-size:11px; color:" + text5 + "\">" + text2 + "</span>");
		stringBuilder.Append("<br><span style=\"color:#C0C0C0\">" + text6 + "</span>");
		if (value2.HasFish)
		{
			stringBuilder.Append("<br><span style=\"color:#33CCFF\">Рыба</span>");
		}
		else if (value2.HasWater)
		{
			stringBuilder.Append("<br><span style=\"color:#33CCFF\">Вода</span>");
		}
		if (!string.IsNullOrEmpty(value2.BotsTooltip))
		{
			stringBuilder.Append($"<br><span style=\"color:#88BBDD\">Боты {value2.MinBotLevel}");
			if (value2.MaxBotLevel > value2.MinBotLevel)
			{
				stringBuilder.Append($"-{value2.MaxBotLevel}");
			}
			stringBuilder.Append("</span>");
		}
		if (!string.IsNullOrEmpty(value2.HerbGroup) && !value2.HerbGroup.Equals("0"))
		{
			if (Class72.class19_0.sortedDictionary_0.TryGetValue(value2.CellNumber, out var value3))
			{
				stringBuilder.AppendLine();
				TimeSpan timeSpan = TimeSpan.FromTicks(DateTime.Now.Subtract(Class72.class19_0.timeSpan_0).Ticks - value3.long_0);
				stringBuilder.Append("<br><span style=\"color:#");
				if (timeSpan.TotalHours < 1.0)
				{
					stringBuilder.Append("00CC00");
				}
				else if (timeSpan.TotalHours < 2.0)
				{
					stringBuilder.Append("009900");
				}
				else if (timeSpan.TotalHours < 3.0)
				{
					stringBuilder.Append("006600");
				}
				else
				{
					stringBuilder.Append((timeSpan.TotalHours < 6.0) ? "003300" : "999999");
				}
				stringBuilder.Append("\">Травы ");
				stringBuilder.Append(value2.HerbGroup);
				if (timeSpan.TotalHours < 6.0)
				{
					TimeSpan timeSpan2 = TimeSpan.FromTicks(value3.long_0);
					stringBuilder.Append(" (");
					stringBuilder.Append(timeSpan2.Hours);
					stringBuilder.Append(':');
					stringBuilder.AppendFormat("{0:00}", timeSpan2.Minutes);
					stringBuilder.Append(')');
				}
				stringBuilder.Append("</span>");
			}
			else
			{
				stringBuilder.Append("<br><span style=\"color:#999999\">Травы " + value2.HerbGroup + "</span>");
			}
		}
		if (smethod_6().TryGetValue(text2, out var value4))
		{
			TimeSpan timeSpan3 = DateTime.Now.Subtract(Class72.class19_0.timeSpan_0).Subtract(value4.Visited);
			if (timeSpan3.TotalDays < 1.0)
			{
				string arg = smethod_25(timeSpan3.TotalHours);
				stringBuilder.Append($"<br><span style=\"color:{arg}\">{value4.Visited.Hour:D2}:{value4.Visited.Minute:D2}</span>");
			}
		}
		stringBuilder.Append("</div>");
		return stringBuilder.ToString();
	}

	internal static string smethod_19(int int_0, int int_1, int int_2)
	{
		string text = smethod_30(int_0, int_1);
		if (text == null)
		{
			return string.Empty;
		}
		if (!smethod_0().TryGetValue(text, out var value))
		{
			return string.Empty;
		}
		string key = value.method_4();
		if (!smethod_4().TryGetValue(key, out var value2))
		{
			return string.Empty;
		}
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append(value2.Tooltip);
		if (!string.IsNullOrEmpty(value2.BotsTooltip))
		{
			stringBuilder.AppendLine();
			stringBuilder.Append(value2.BotsTooltip);
		}
		if (Class72.class19_0.sortedDictionary_0.TryGetValue(key, out var value3))
		{
			stringBuilder.AppendLine();
			TimeSpan timeSpan = TimeSpan.FromTicks(DateTime.Now.Subtract(Class72.class19_0.timeSpan_0).Ticks - value3.long_0);
			stringBuilder.Append("(осмотрено ");
			if (timeSpan.TotalMinutes < 1.0)
			{
				stringBuilder.Append("только что");
			}
			else
			{
				if (timeSpan.Hours > 0)
				{
					stringBuilder.AppendFormat("{0} час ", timeSpan.Hours);
				}
				stringBuilder.AppendFormat("{0} мин", timeSpan.Minutes);
				stringBuilder.Append(" назад");
			}
			stringBuilder.Append(')');
			string[] array = value3.string_1.Split(new char[1] { '|' }, StringSplitOptions.RemoveEmptyEntries);
			if (array[0] == "Нет растительности")
			{
				stringBuilder.AppendLine();
				stringBuilder.Append("Нет растительности");
			}
			else
			{
				for (int i = 0; i < array.Length; i++)
				{
					stringBuilder.AppendLine();
					string[] array2 = array[i].Split(':');
					if (array2.Length == 3)
					{
						stringBuilder.Append(array2[0] + " [" + array2[1] + "/" + array2[2] + "]");
					}
				}
			}
		}
		if (value2.Cost > 0)
		{
			stringBuilder.AppendLine();
			stringBuilder.Append($"Время: {value2.Cost}");
		}
		return stringBuilder.ToString();
	}

	private static byte smethod_20(byte byte_0, byte byte_1, double double_0)
	{
		return (byte)((double)(int)byte_0 * (1.0 - double_0) + (double)(int)byte_1 * double_0);
	}

	private static Color smethod_21(Color color_0, Color color_1, double double_0)
	{
		return Color.FromArgb(smethod_20(color_0.R, color_1.R, double_0), smethod_20(color_0.G, color_1.G, double_0), smethod_20(color_0.B, color_1.B, double_0));
	}

	private static Color smethod_22(int int_0)
	{
		if (int_0 == 0)
		{
			return Color.DarkGray;
		}
		if (int_0 <= 30)
		{
			return Color.LightGreen;
		}
		if (int_0 <= 40)
		{
			return Color.Yellow;
		}
		if (int_0 >= 60)
		{
			return Color.Red;
		}
		return Color.Black;
	}

	private static Color smethod_23(double double_0)
	{
		if (double_0 < 0.0)
		{
			return Color.LightGreen;
		}
		if (double_0 < 1.0)
		{
			double double_1 = double_0 / 1.0;
			return smethod_21(Color.LightGreen, Color.Yellow, double_1);
		}
		if (double_0 < 6.0)
		{
			double double_2 = (double_0 - 1.0) / 5.0;
			return smethod_21(Color.Yellow, Color.Red, double_2);
		}
		return Color.Red;
	}

	private static string smethod_24(int int_0)
	{
		return ColorTranslator.ToHtml(smethod_22(int_0));
	}

	private static string smethod_25(double double_0)
	{
		return ColorTranslator.ToHtml(smethod_23(double_0));
	}

	internal static string smethod_26(int int_0, int int_1)
	{
		string key = smethod_30(int_0, int_1);
		if (!smethod_0().ContainsKey(key))
		{
			return string.Empty;
		}
		return smethod_0()[key].method_4();
	}

	internal static string smethod_27(string string_0, int int_0, int int_1)
	{
		if (!smethod_2().ContainsKey(string_0))
		{
			return null;
		}
		string[] array = smethod_2()[string_0].Split('/', '_');
		string key = smethod_30(int_1: Convert.ToInt32(array[0], CultureInfo.InvariantCulture) + int_1, int_0: Convert.ToInt32(array[1], CultureInfo.InvariantCulture) + int_0);
		if (!smethod_0().ContainsKey(key))
		{
			return null;
		}
		string text = smethod_0()[key].method_4();
		if (smethod_4().ContainsKey(text))
		{
			return text;
		}
		return null;
	}

	private static void smethod_28(string string_0, int int_0, int int_1)
	{
		int num = 1;
		int num2 = int_0 + 29;
		int num3 = int_1 + 18;
		for (int i = int_1; i <= num3; i++)
		{
			for (int j = int_0; j <= num2; j++)
			{
				string text = smethod_30(j, i);
				string text2 = smethod_29(string_0, num);
				Class85 @class = new Class85();
				@class.method_5(text2);
				@class.method_1(j);
				@class.method_3(i);
				Class85 value = @class;
				smethod_0().Add(text, value);
				smethod_2().Add(text2, text);
				num++;
			}
		}
	}

	public static string smethod_29(string string_0, IFormattable iformattable_0)
	{
		return string_0 + "-" + iformattable_0.ToString("000", CultureInfo.InvariantCulture);
	}

	public static string smethod_30(int int_0, int int_1)
	{
		return string.Format(CultureInfo.InvariantCulture, "{0}/{1}_{2}", new object[3] { int_1, int_0, int_1 });
	}

	internal static void smethod_31()
	{
		foreach (KeyValuePair<string, AbcCell> item in smethod_6())
		{
			item.Value.Visited = DateTime.MinValue;
		}
	}

	internal static bool smethod_32(int int_0, int int_1)
	{
		string key = smethod_30(int_0, int_1);
		if (!smethod_0().ContainsKey(key))
		{
			return false;
		}
		string text = smethod_0()[key].method_4();
		if (text == null)
		{
			return false;
		}
		if (Class72.smethod_36() && Class72.smethod_46() != null && Class72.smethod_46().Path.Length != 0)
		{
			return Array.IndexOf(Class72.smethod_46().Path, text) >= 0;
		}
		return false;
	}

	public static void smethod_33()
	{
		if (Class72.class79_0 == null)
		{
			return;
		}
		XmlWriterSettings settings = new XmlWriterSettings
		{
			Indent = true
		};
		MemoryStream memoryStream = new MemoryStream();
		XmlWriter xmlWriter = XmlWriter.Create(memoryStream, settings);
		xmlWriter.WriteStartDocument();
		xmlWriter.WriteStartElement("mines");
		foreach (KeyValuePair<string, Dictionary<string, Class78>> item in Class72.class79_0)
		{
			string[] array = item.Key.Split('-');
			string text = array[0];
			string text2 = array[1];
			xmlWriter.WriteStartElement("mine");
			xmlWriter.WriteStartAttribute("mineid");
			xmlWriter.WriteString(text);
			xmlWriter.WriteEndAttribute();
			xmlWriter.WriteStartAttribute("level");
			xmlWriter.WriteString(text2);
			xmlWriter.WriteEndAttribute();
			foreach (KeyValuePair<string, Class78> item2 in item.Value)
			{
				xmlWriter.WriteStartElement("cell");
				xmlWriter.WriteStartAttribute("x");
				xmlWriter.WriteString(item2.Value.string_0);
				xmlWriter.WriteEndAttribute();
				xmlWriter.WriteStartAttribute("y");
				xmlWriter.WriteString(item2.Value.string_1);
				xmlWriter.WriteEndAttribute();
				xmlWriter.WriteStartAttribute("img");
				xmlWriter.WriteString(item2.Value.string_2);
				xmlWriter.WriteEndAttribute();
				xmlWriter.WriteStartAttribute("usefull");
				xmlWriter.WriteString(item2.Value.string_3);
				xmlWriter.WriteEndAttribute();
				xmlWriter.WriteEndElement();
			}
			xmlWriter.WriteEndElement();
		}
		xmlWriter.WriteEndElement();
		xmlWriter.WriteEndDocument();
		xmlWriter.Flush();
		FileStream fileStream = new FileStream("map_mines_new.xml", FileMode.Create);
		memoryStream.WriteTo(fileStream);
		fileStream.Close();
		memoryStream.Close();
		try
		{
			File.Delete("map_mines.xml");
			File.Move("map_mines_new.xml", "map_mines.xml");
		}
		catch (IOException)
		{
		}
	}
}
