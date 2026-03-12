using System;
using System.Text;

internal sealed class Class3 : ICloneable, IComparable
{
	private string string_0;

	private string string_1;

	private string string_2;

	private string string_3;

	private string string_4;

	internal int int_0;

	internal int int_1;

	internal int int_2;

	internal int int_3;

	internal string string_5;

	internal bool bool_0;

	internal DateTime dateTime_0;

	internal int int_4;

	private readonly string string_6;

	private readonly int int_5;

	private readonly string string_7 = string.Empty;

	private readonly string string_8;

	private readonly int int_6;

	private readonly bool bool_1;

	internal Class3(string string_9)
	{
		method_1(Class12.smethod_1(string_9, "<font class=nickname><b> ", "</b>") ?? string.Empty);
		method_3(Class12.smethod_1(string_9, "Гравировка: ", "<br>") ?? string.Empty);
		method_5(Class12.smethod_1(string_9, "Цена: <b>", " NV</b>") ?? string.Empty);
		method_7(Class12.smethod_1(string_9, "<input type=button class=invbut onclick=\"location='", "'\" value=\"Надеть\">") ?? string.Empty);
		method_9(Class12.smethod_1(string_9, "if(top.DeleteTrue('" + method_0() + "')) { location='", "'") ?? string.Empty);
		string_8 = Class12.smethod_1(string_9, "Долговечность: <b>", "</b>") ?? string.Empty;
		string_6 = Class12.smethod_1(string_9, " src=http://", " ") ?? string.Empty;
		string_5 = string_9;
		int_4 = 1;
		string[] array = string_8.Split('/');
		if (array.Length == 2)
		{
			if (!int.TryParse(array[0], out int_0))
			{
				int_0 = 0;
			}
			if (!int.TryParse(array[1], out int_1))
			{
				int_1 = 0;
			}
		}
		int_2 = int_0;
		int_3 = int_1;
		string text = Class12.smethod_1(string_9, "<br>Уровень: <b>", "</b>") ?? string.Empty;
		if (!string.IsNullOrEmpty(text) && !int.TryParse(text, out int_5))
		{
			int_5 = 0;
		}
		string text2 = Class12.smethod_1(string_9, "<font color=#cc0000>Срок годности: ", "</font>");
		if (!string.IsNullOrEmpty(text2))
		{
			bool_1 = true;
			string[] array2 = text2.Split('.', ' ', ':');
			if (array2.Length > 4 && int.TryParse(array2[0], out var result) && int.TryParse(array2[1], out var result2) && int.TryParse(array2[2], out var result3) && int.TryParse(array2[3], out var result4) && int.TryParse(array2[4], out var result5))
			{
				dateTime_0 = new DateTime(result3, result2, result, result4, result5, 0);
				if (Class72.smethod_132() > dateTime_0)
				{
					bool_0 = true;
				}
			}
		}
		string text3 = "<font color=#000000>требования</font></div></td></tr><tr><td bgcolor=#FCFAF3><img src=http://image.neverlands.ru/1x1.gif width=5 height=1></td><td bgcolor=#FCFAF3 width=50%><font class=nickname><b> " + method_0() + "</b><br><font class=weaponch>";
		string text4 = Class12.smethod_1(string_9, text3, "<br></td><td bgcolor=#FCFAF3><img src=http://image.neverlands.ru/1x1.gif width=5 height=1></td></tr></table>");
		if (!string.IsNullOrEmpty(text4))
		{
			string[] array3 = text4.Split(new string[2] { "<br>", "</td><td bgcolor=#FCFAF3><img src=http://image.neverlands.ru/1x1.gif width=5 height=1></td><td bgcolor=#B9A05C><img src=http://image.neverlands.ru/1x1.gif width=1 height=1></td><td bgcolor=#FCFAF3><img src=http://image.neverlands.ru/1x1.gif width=5 height=1></td><td bgcolor=#FCFAF3 width=50%><font class=weaponch>" }, StringSplitOptions.RemoveEmptyEntries);
			if (array3.Length > 1)
			{
				StringBuilder stringBuilder = new StringBuilder();
				for (int i = 1; i < array3.Length; i++)
				{
					if (array3[i].IndexOf("Цена: <b>", StringComparison.CurrentCultureIgnoreCase) == -1 && array3[i].IndexOf("Материал: <b>", StringComparison.CurrentCultureIgnoreCase) == -1 && array3[i].IndexOf("Долговечность: <b>", StringComparison.CurrentCultureIgnoreCase) == -1)
					{
						if (stringBuilder.Length > 0)
						{
							stringBuilder.Append('|');
						}
						stringBuilder.Append(array3[i]);
					}
				}
				string_7 = stringBuilder.ToString();
			}
		}
		int num = 0;
		while (num != -1)
		{
			num = string_9.IndexOf("<input type=button", num, StringComparison.CurrentCultureIgnoreCase);
			if (num != -1)
			{
				int_6++;
				num += 18;
			}
		}
	}

	internal string method_0()
	{
		return string_0;
	}

	private void method_1(string string_9)
	{
		string_0 = string_9;
	}

	internal string method_2()
	{
		return string_1;
	}

	private void method_3(string string_9)
	{
		string_1 = string_9;
	}

	internal string method_4()
	{
		return string_2;
	}

	private void method_5(string string_9)
	{
		string_2 = string_9;
	}

	internal string method_6()
	{
		return string_3;
	}

	private void method_7(string string_9)
	{
		string_3 = string_9;
	}

	internal string method_8()
	{
		return string_4;
	}

	private void method_9(string string_9)
	{
		string_4 = string_9;
	}

	public int CompareTo(object obj)
	{
		if (!(obj is Class3))
		{
			return 1;
		}
		Class3 @class = (Class3)obj;
		int num = string.Compare(method_0(), @class.method_0(), StringComparison.Ordinal);
		if (num == 0 && (!method_0().Contains("Лотерейный билет") || !@class.method_0().Contains("Лотерейный билет")))
		{
			num = string.Compare(string_6, @class.string_6, StringComparison.Ordinal);
			if (num != 0)
			{
				return num;
			}
			if ((!bool_1 && @class.bool_1) || (bool_1 && !@class.bool_1))
			{
				return @class.bool_1.CompareTo(bool_1);
			}
			if (bool_1 && @class.bool_1 && ((!bool_0 && @class.bool_0) || (bool_0 && !@class.bool_0)))
			{
				return bool_0.CompareTo(@class.bool_0);
			}
			num = int_5.CompareTo(@class.int_5);
			if (num != 0)
			{
				return num;
			}
			num = int_6.CompareTo(@class.int_6);
			if (num != 0)
			{
				return num;
			}
			if (!Class72.class19_0.method_146())
			{
				bool flag = int_0 == int_1;
				bool value = @class.int_0 == @class.int_1;
				num = flag.CompareTo(value);
				if (num != 0)
				{
					return num;
				}
				num = int_0.CompareTo(@class.int_0);
				if (num != 0)
				{
					return num;
				}
				num = int_1.CompareTo(@class.int_1);
				if (num != 0)
				{
					return num;
				}
			}
			num = string.Compare(string_7, @class.string_7, StringComparison.Ordinal);
			if (num != 0)
			{
				return num;
			}
			return 0;
		}
		return num;
	}

	public object Clone()
	{
		return MemberwiseClone();
	}

	internal bool method_10()
	{
		if (bool_1)
		{
			return bool_0;
		}
		return false;
	}

	internal string method_11()
	{
		string text = string_5;
		if (method_10())
		{
			text = text.Replace("bgcolor=#F5F5F5", "bgcolor=#F5E5E5").Replace("bgcolor=#FFFFFF", "bgcolor=#F5E5E5").Replace("bgcolor=#FCFAF3", "bgcolor=#F5E5E5")
				.Replace("bgcolor=#D8CDAF", "bgcolor=#F5D5D5");
			int num = text.IndexOf("<font class=nickname><b> ", StringComparison.Ordinal);
			if (num != -1)
			{
				text = text.Insert(num, "<font class=nickname><font color=#cc0000><b>ПРОСРОЧЕНО!</b></font></font> ");
			}
		}
		if (Class72.class19_0.method_148())
		{
			string text2 = Class12.smethod_1(text, "Долговечность: <b>", "</b>");
			text = text.Replace("Долговечность: <b>" + text2 + "</b>", $"Долговечность: <b>{int_2}/{int_3}</b>");
		}
		if (int_4 > 1)
		{
			int num2 = text.IndexOf("<font class=nickname><b> ", StringComparison.CurrentCultureIgnoreCase);
			if (num2 != -1)
			{
				num2 = text.IndexOf("</b>", num2, StringComparison.CurrentCultureIgnoreCase);
				if (num2 != -1)
				{
					return text.Insert(num2, $" ({int_4} шт.)");
				}
			}
		}
		return text;
	}

	internal void method_12()
	{
		if (int_4 != 1 && !string.IsNullOrEmpty(method_0()))
		{
			int num = string_5.IndexOf("<input type=image src=http://image.neverlands.ru/del.gif width=14 height=14 border=0 onclick=\"javascript: if(top.DeleteTrue('", StringComparison.CurrentCultureIgnoreCase);
			if (num != -1)
			{
				string_5 = string_5.Insert(num, " <input type=image src=http://image.neverlands.ru/del.gif width=14 height=14 border=1 title=\"Выбросить всю пачку\" onclick=\"javascript: if(top.DeleteTrue('Пачку " + method_0() + "')) { window.external.StartBulkDrop('" + method_0() + "', '" + method_4() + "', " + bool_0.ToString().ToLower() + "); }\" value=\"X\">&nbsp;");
			}
		}
	}

	internal int method_13(Class3 class3_0)
	{
		if (class3_0 == null)
		{
			return 0;
		}
		bool flag = int_0 == int_1;
		bool value = class3_0.int_0 == class3_0.int_1;
		int num = flag.CompareTo(value);
		if (num != 0)
		{
			return num;
		}
		num = int_0.CompareTo(class3_0.int_0);
		if (num != 0)
		{
			return num;
		}
		return int_1.CompareTo(class3_0.int_1);
	}

	internal int method_14(Class3 class3_0)
	{
		if (class3_0 != null && bool_1 && class3_0.bool_1)
		{
			return dateTime_0.CompareTo(class3_0.dateTime_0);
		}
		return 0;
	}
}
