using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;
using ABClient;

internal sealed class Class76
{
	private string string_0;

	private string string_1;

	private string string_2;

	private bool bool_0;

	private int int_0;

	private int int_1;

	private string string_3;

	private string string_4;

	private string string_5;

	private string string_6;

	private string string_7;

	private string string_8;

	private string string_9;

	private int int_2;

	private int[] int_3;

	private string[] string_10;

	private string[] string_11;

	private bool bool_1;

	private bool bool_2;

	private int int_4;

	private string string_12;

	private bool bool_3;

	private string[] string_13;

	private bool bool_4;

	internal Class76(string string_14, string string_15, int int_5, int int_6, string string_16, bool bool_5)
	{
		method_1(string_14.Trim());
		method_3(string_15);
		method_9(int_5);
		method_11(int_6);
		method_5(string_16);
		method_7(bool_5);
		method_13(string.Empty);
		method_15(string.Empty);
		method_17(string.Empty);
		method_19(string.Empty);
		method_21(string.Empty);
		method_46();
	}

	internal Class76(string string_14, string string_15, int int_5, int int_6, string string_16, string string_17, string string_18, string string_19, bool bool_5, string string_20)
	{
		method_1(string_14.Trim());
		method_3(string_15);
		method_9(int_5);
		method_11(int_6);
		method_13(string_16);
		method_15(string_18);
		method_17(string_17);
		method_5(string_19);
		method_7(bool_5);
		method_19(string_20);
		method_46();
	}

	internal string method_0()
	{
		return string_0;
	}

	private void method_1(string string_14)
	{
		string_0 = string_14;
	}

	internal string method_2()
	{
		return string_1;
	}

	internal void method_3(string string_14)
	{
		string_1 = string_14;
	}

	internal string method_4()
	{
		return string_2;
	}

	internal void method_5(string string_14)
	{
		string_2 = string_14;
	}

	internal bool method_6()
	{
		return bool_0;
	}

	internal void method_7(bool bool_5)
	{
		bool_0 = bool_5;
	}

	internal int method_8()
	{
		return int_0;
	}

	internal void method_9(int int_5)
	{
		int_0 = int_5;
	}

	internal int method_10()
	{
		return int_1;
	}

	internal void method_11(int int_5)
	{
		int_1 = int_5;
	}

	internal string method_12()
	{
		return string_3;
	}

	private void method_13(string string_14)
	{
		string_3 = string_14;
	}

	internal string method_14()
	{
		return string_4;
	}

	private void method_15(string string_14)
	{
		string_4 = string_14;
	}

	internal string method_16()
	{
		return string_5;
	}

	private void method_17(string string_14)
	{
		string_5 = string_14;
	}

	internal string method_18()
	{
		return string_6;
	}

	private void method_19(string string_14)
	{
		string_6 = string_14;
	}

	internal string method_20()
	{
		return string_7;
	}

	private void method_21(string string_14)
	{
		string_7 = string_14;
	}

	internal string method_22()
	{
		return string_8;
	}

	private void method_23(string string_14)
	{
		string_8 = string_14;
	}

	internal string method_24()
	{
		return string_9;
	}

	internal void method_25(string string_14)
	{
		string_9 = string_14;
	}

	private int method_26()
	{
		return int_2;
	}

	private void method_27(int int_5)
	{
		int_2 = int_5;
	}

	internal int[] method_28()
	{
		return int_3;
	}

	private void method_29(int[] int_5)
	{
		int_3 = int_5;
	}

	internal string[] method_30()
	{
		return string_10;
	}

	internal void method_31(string[] string_14)
	{
		string_10 = string_14;
	}

	internal string[] method_32()
	{
		return string_11;
	}

	internal void method_33(string[] string_14)
	{
		string_11 = string_14;
	}

	internal bool method_34()
	{
		return bool_1;
	}

	private void method_35(bool bool_5)
	{
		bool_1 = bool_5;
	}

	internal bool method_36()
	{
		return bool_2;
	}

	private void method_37(bool bool_5)
	{
		bool_2 = bool_5;
	}

	private int method_38()
	{
		return int_4;
	}

	private void method_39(int int_5)
	{
		int_4 = int_5;
	}

	internal string method_40()
	{
		return string_12;
	}

	internal void method_41(string string_14)
	{
		string_12 = string_14;
	}

	private bool method_42()
	{
		return bool_3;
	}

	private void method_43(bool bool_5)
	{
		bool_3 = bool_5;
	}

	private string[] method_44()
	{
		return string_13;
	}

	private void method_45(string[] string_14)
	{
		string_13 = string_14;
	}

	private void method_46()
	{
		method_25(string.Empty);
		method_21(string.Empty);
		method_27(0);
		method_29(new int[4]);
		method_39(0);
		method_41(string.Empty);
		bool_4 = true;
		method_23(Guid.NewGuid().ToString());
	}

	public override string ToString()
	{
		if (!string.IsNullOrEmpty(method_18()))
		{
			return string.Format(CultureInfo.InvariantCulture, "{0} [{1}]", new object[2]
			{
				method_0(),
				method_18()
			});
		}
		return method_0();
	}

	internal void method_47(string string_14)
	{
		_ = DateTime.Now;
		if (string.IsNullOrEmpty(string_14))
		{
			return;
		}
		string text = Class12.smethod_1(string_14, "1|", "\n2|");
		string text2 = Class12.smethod_1(string_14, "\n3|", "\n4|");
		string text3 = Class12.smethod_1(string_14, "\n4|", "\n");
		if (string.IsNullOrEmpty(text2) || string.IsNullOrEmpty(text3) || string.IsNullOrEmpty(text))
		{
			return;
		}
		string[] array = text.Split('@');
		string[] array2 = Class12.smethod_1(string_14, "\n2|", "\n3|").Split('@');
		string[] array3 = text2.Split('|');
		if (int.TryParse(text3.Split('|')[4], out var result))
		{
			result = 100 - result;
		}
		string string_15 = array3[0];
		string string_16 = array3[1];
		string string_17 = array3[2];
		string string_18 = array3[4];
		string string_19 = array3[5];
		bool flag = array3[10] != "0";
		bool flag2 = array3[12] == "1";
		string text4 = array3[13];
		string text5 = ((array3[14] == "0") ? string.Empty : array3[14]);
		int num = 0;
		int[] array4 = new int[4];
		List<string> list = new List<string>();
		List<string> list2 = new List<string>();
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < array2.Length; i++)
		{
			string[] array5 = array2[i].Split('.');
			if (array5.Length >= 4)
			{
				string text6 = array5[0];
				string text7 = array5[1];
				stringBuilder.AppendFormat("&nbsp;<img src=http://image.neverlands.ru/pinfo/eff_{0}.gif width=15 height=15 align=absmiddle title=\"{1}\">", text6, text7);
				int num2 = int.Parse(array5[2]);
				switch (text6)
				{
				default:
					list.Add(text6);
					list2.Add(text7);
					break;
				case "4":
					num += num2;
					array4[0] = num2;
					break;
				case "3":
					num += num2;
					array4[1] = num2;
					break;
				case "2":
					num += num2;
					array4[2] = num2;
					break;
				case "1":
					num += num2;
					array4[3] = num2;
					break;
				}
			}
		}
		string[] array6 = text4.Split(new string[1] { " [" }, StringSplitOptions.RemoveEmptyEntries);
		if (array6.Length == 2)
		{
			array6[1] = array6[1].Substring(0, array6[1].Length - 1);
			if (array6[1].IndexOf(array6[0], StringComparison.OrdinalIgnoreCase) != -1 || array6[1].Contains(","))
			{
				text4 = array6[1];
			}
		}
		method_1(string_15);
		method_19(string_16);
		method_15(string_17);
		method_13(string_18);
		method_17(string_19);
		StringBuilder stringBuilder2 = new StringBuilder();
		string text8 = smethod_1(this) + stringBuilder;
		if (!bool_4 && method_36() != flag2)
		{
			if (stringBuilder2.Length > 0)
			{
				stringBuilder2.Append(',');
			}
			if (flag2)
			{
				stringBuilder2.AppendFormat(" появляется в <font color=\"#3F7F62\">{0}</font>", text4);
			}
			else
			{
				stringBuilder2.AppendFormat(" выходит из игры в <font color=\"#3F7F62\">{0}</font>", method_20());
			}
		}
		if (method_8() != 2 && !bool_4)
		{
			StringBuilder stringBuilder3 = new StringBuilder();
			int num3 = 0;
			if (array != null && method_44() != null && array.Length == method_44().Length)
			{
				for (int j = 0; j < array.Length; j++)
				{
					string[] array7 = method_44()[j].Split(':');
					if (array7.Length < 2)
					{
						continue;
					}
					string[] array8 = array[j].Split(':');
					if (array8.Length < 2)
					{
						continue;
					}
					string text9 = array7[0];
					string text10 = array8[0];
					string text11 = array7[1];
					string value = array8[1];
					if (!text9.Equals(text10, StringComparison.CurrentCultureIgnoreCase) || !text11.Equals(value, StringComparison.CurrentCultureIgnoreCase))
					{
						stringBuilder3.Append((stringBuilder3.Length > 0) ? ", " : " ");
						if (text10.StartsWith("sl_"))
						{
							stringBuilder3.Append("снимает");
							stringBuilder3.Append(" &laquo;");
							stringBuilder3.Append(text11);
						}
						else
						{
							stringBuilder3.Append("надевает");
							stringBuilder3.Append(" &laquo;");
							stringBuilder3.Append(value);
						}
						stringBuilder3.Append("&raquo;");
						num3++;
					}
				}
			}
			if (stringBuilder3.Length > 0)
			{
				if (stringBuilder2.Length > 0)
				{
					stringBuilder2.Append(',');
				}
				stringBuilder2.Append((num3 > 3) ? " переодевается" : stringBuilder3.ToString());
			}
		}
		if (method_8() != 2)
		{
			if (!bool_4 && flag2 && method_36() && method_20() != text4 && !string.IsNullOrEmpty(text4))
			{
				if (stringBuilder2.Length > 0)
				{
					stringBuilder2.Append(',');
				}
				if (method_38() != result)
				{
					stringBuilder2.AppendFormat(" переходит в <font color=\"#3F7F62\">{0}</font> (Усталость: <b>{1}</b>)", text4, result);
				}
				else
				{
					stringBuilder2.AppendFormat(" переходит в <font color=\"#3F7F62\">{0}</font>", text4);
				}
			}
			else if (!bool_4 && flag2 && method_36() && method_20() == text4 && method_38() < result && !string.IsNullOrEmpty(text4))
			{
				if (stringBuilder2.Length > 0)
				{
					stringBuilder2.Append(',');
				}
				stringBuilder2.AppendFormat(" усталость {0}&rarr;<b>{1}</b> в <font color=\"#3F7F62\">{2}</font>", method_38(), result, text4);
			}
		}
		if (!bool_4 && flag2 && ((string.IsNullOrEmpty(method_40()) && !string.IsNullOrEmpty(text5)) || (!string.IsNullOrEmpty(method_40()) && !string.IsNullOrEmpty(text5) && !method_40().Equals(text5, StringComparison.Ordinal))))
		{
			method_43(bool_5: false);
			string text12 = Class21.smethod_1(text5);
			if (text12.IndexOf("(нападение бота)", StringComparison.OrdinalIgnoreCase) != -1 || text12.IndexOf("var logs = [];", StringComparison.OrdinalIgnoreCase) != -1)
			{
				method_43(bool_5: true);
			}
			if (!method_42())
			{
				if (stringBuilder2.Length > 0)
				{
					stringBuilder2.Append(',');
				}
				string text13 = Class12.smethod_1(text12, " начался (", ")") ?? "обычное нападение";
				if (text12.IndexOf("Бой (жертвенный)", StringComparison.OrdinalIgnoreCase) != -1)
				{
					text13 = "жертвенный бой";
				}
				string text14 = Class12.smethod_1(text12, "var lives_g1 = [", "];");
				if (!string.IsNullOrEmpty(text14))
				{
					string[] array9 = text14.Split(',');
					string text15 = ((array9.Length <= 2 || text14.StartsWith("[4")) ? "невидимка" : array9[1].Trim('"'));
					string text16 = Class12.smethod_1(text12, "var lives_g2 = [", "];");
					if (!string.IsNullOrEmpty(text16))
					{
						array9 = text16.Split(',');
						string string_20 = ((array9.Length <= 2 || text16.StartsWith("[4")) ? "невидимка" : array9[1].Trim('"'));
						if (text16.IndexOf(method_0(), StringComparison.Ordinal) == -1)
						{
							stringBuilder2.AppendFormat(" <a href=http://www.neverlands.ru/logs.fcg?fid={0} onclick=\"window.open(this.href);\">нападает</a> на {1} ({2})", text5, smethod_0(string_20), text13);
						}
						else if (text15.Equals("невидимка", StringComparison.OrdinalIgnoreCase))
						{
							stringBuilder2.AppendFormat(" <a href=http://www.neverlands.ru/logs.fcg?fid={0} onclick=\"window.open(this.href);\">атакован</a> невидимкой ({1})", text5, text13);
						}
						else
						{
							stringBuilder2.AppendFormat(" <a href=http://www.neverlands.ru/logs.fcg?fid={0} onclick=\"window.open(this.href);\">атакован</a> {1} ({2})", text5, smethod_0(text15), text13);
						}
					}
				}
			}
		}
		if (!bool_4 && method_34() != flag)
		{
			if (stringBuilder2.Length > 0)
			{
				stringBuilder2.Append(',');
			}
			stringBuilder2.AppendFormat(flag ? " получает молчанку" : " выходит из молчания");
		}
		if (!bool_4 && method_26() > 0 && num == 0)
		{
			if (stringBuilder2.Length > 0)
			{
				stringBuilder2.Append(',');
			}
			stringBuilder2.AppendFormat(" излечивается от всех травм");
		}
		if (!bool_4 && method_26() > 0 && num > 0 && num < method_26())
		{
			if (stringBuilder2.Length > 0)
			{
				stringBuilder2.Append(',');
			}
			stringBuilder2.AppendFormat(" излечивается (травм стало: {0})", num);
		}
		if (!bool_4 && num > method_26())
		{
			if (stringBuilder2.Length > 0)
			{
				stringBuilder2.Append(',');
			}
			if (num - method_26() > 1)
			{
				stringBuilder2.AppendFormat(" получает несколько травм");
			}
			else
			{
				string arg = "никакую";
				if (array4[3] > method_28()[3])
				{
					arg = "боевую";
				}
				else if (array4[2] > method_28()[2])
				{
					arg = "тяжелую";
				}
				else if (array4[1] > method_28()[1])
				{
					arg = "среднюю";
				}
				else if (array4[0] > method_28()[0])
				{
					arg = "легкую";
				}
				stringBuilder2.AppendFormat(" получает {0} травму (травм стало: {1})", arg, num);
			}
		}
		if (method_8() != 2 && !bool_4)
		{
			StringBuilder stringBuilder4 = new StringBuilder();
			for (int k = 0; k < list.Count; k++)
			{
				if (Array.IndexOf(method_30(), list[k]) < 0)
				{
					if (stringBuilder4.Length == 0)
					{
						stringBuilder4.Append(" получает");
					}
					stringBuilder4.Append("&nbsp;<img src=http://image.neverlands.ru/pinfo/eff_" + list[k] + ".gif width=15 height=15 align=absmiddle title=\"" + list2[k] + "\">&nbsp;" + list2[k]);
				}
			}
			if (stringBuilder4.Length > 0)
			{
				if (stringBuilder2.Length > 0)
				{
					stringBuilder2.Append(',');
				}
				stringBuilder2.Append(stringBuilder4);
			}
			StringBuilder stringBuilder5 = new StringBuilder();
			for (int l = 0; l < method_30().Length; l++)
			{
				if (!list.Contains(method_30()[l]))
				{
					if (stringBuilder5.Length == 0)
					{
						stringBuilder5.Append(" теряет");
					}
					stringBuilder5.Append("&nbsp;<img src=http://image.neverlands.ru/pinfo/eff_" + method_30()[l] + ".gif width=15 height=15 align=absmiddle title=\"" + method_32()[l] + "\">&nbsp;" + method_32()[l]);
				}
			}
			if (stringBuilder5.Length > 0)
			{
				if (stringBuilder2.Length > 0)
				{
					stringBuilder2.Append(',');
				}
				stringBuilder2.Append(stringBuilder5);
			}
		}
		method_33(list2.ToArray());
		method_31(list.ToArray());
		method_37(flag2);
		method_21(text4);
		method_39(result);
		method_41(text5);
		method_45(array);
		method_35(flag);
		method_27(num);
		method_29(array4);
		bool_4 = false;
		if (stringBuilder2.Length > 0)
		{
			string text17 = text8 + stringBuilder2;
			try
			{
				if (Class72.formMain_0 != null)
				{
					Class72.formMain_0.BeginInvoke(new Delegate7(Class72.formMain_0.method_100), text17);
					if (Class72.class19_0.bool_54)
					{
						string text18 = "%clan% " + Regex.Replace(text17.Replace("&nbsp;", " ").Replace("&laquo;", "\"").Replace("&raquo;", "\""), "<[^>]+>", string.Empty).Replace("&rarr;", "->");
						Class72.formMain_0.BeginInvoke(new Delegate37(Class72.formMain_0.method_113), text18);
					}
				}
			}
			catch (InvalidOperationException)
			{
			}
		}
		try
		{
			if (Class72.formMain_0 != null)
			{
				Class72.formMain_0.BeginInvoke(new Delegate10(Class72.formMain_0.method_101), this);
			}
		}
		catch (InvalidOperationException)
		{
		}
	}

	private static string smethod_0(string string_14)
	{
		string value = Class21.smethod_3(Class21.smethod_2(string_14));
		if (string.IsNullOrEmpty(value))
		{
			return "Аноним";
		}
		string text = Class12.smethod_1(value, "\n3|", "\n4|");
		if (string.IsNullOrEmpty(text))
		{
			return "Аноним";
		}
		string[] array = Class12.smethod_1(value, "\n2|", "\n3|").Split('@');
		string[] array2 = text.Split('|');
		string_14 = array2[0];
		string text2 = array2[1];
		string text3 = array2[2];
		string text4 = array2[4];
		string text5 = array2[5];
		string text6 = string_14.Replace("+", "%2B");
		string text7 = "#000000";
		switch (ContactsManager.smethod_5(string_14))
		{
		case 2:
			text7 = "#0B610B";
			break;
		case 1:
			text7 = "#8A0808";
			break;
		}
		string text8 = "<font color=\"" + text7 + "\">" + string_14 + "</font>";
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < array.Length; i++)
		{
			string[] array3 = array[i].Split('.');
			if (array3.Length >= 4)
			{
				string arg = array3[0];
				string arg2 = array3[1];
				stringBuilder.AppendFormat("&nbsp;<img src=http://image.neverlands.ru/pinfo/eff_{0}.gif width=15 height=15 align=absmiddle title=\"{1}\">", arg, arg2);
			}
		}
		string text9 = string.Empty;
		string text10 = string.Empty;
		switch (Class0.smethod_0(text3))
		{
		case 822911587u:
			if (text3 == "4")
			{
				text9 = "chaoss.gif";
				text10 = "Дети Хаоса";
			}
			break;
		case 806133968u:
			if (text3 == "5")
			{
				text9 = "light.gif";
				text10 = "Истинный Свет";
			}
			break;
		case 856466825u:
			if (text3 == "6")
			{
				text9 = "dark.gif";
				text10 = "Истинная Тьма";
			}
			break;
		case 839689206u:
			if (text3 == "7")
			{
				text9 = "sumer.gif";
				text10 = "Нейтральные Сумерки";
			}
			break;
		case 906799682u:
			if (text3 == "3")
			{
				text9 = "sumers.gif";
				text10 = "Дети Сумерек";
			}
			break;
		case 873244444u:
			if (text3 == "1")
			{
				text9 = "darks.gif";
				text10 = "Дети Тьмы";
			}
			break;
		case 1024243015u:
			if (text3 == "8")
			{
				text9 = "chaos.gif";
				text10 = "Абсолютный Хаос";
			}
			break;
		case 1007465396u:
			if (text3 == "9")
			{
				text9 = "angel.gif";
				text10 = "Ангел";
			}
			break;
		case 923577301u:
			if (text3 == "2")
			{
				text9 = "lights.gif";
				text10 = "Дети Света";
			}
			break;
		}
		text3 = (string.IsNullOrEmpty(text9) ? string.Empty : ("<img src=http://image.neverlands.ru/signs/" + text9 + " width=15 height=12 align=absmiddle border=0 title=\"" + text10 + "\">&nbsp;"));
		string text11 = string.Empty;
		if (!string.IsNullOrEmpty(text5))
		{
			text11 = "<img src=http://image.neverlands.ru/signs/" + text4 + " width=15 height=12 align=absmiddle title=\"" + text5 + "\">&nbsp;";
		}
		return "<a href=\"#\" onclick=\"top.say_private('" + string_14 + "');\"><img src=http://image.neverlands.ru/chat/private.gif width=11 height=12 border=0 align=absmiddle></a>&nbsp;" + text3 + text11 + "<a class=\"activenick\" href=\"#\" onclick=\"top.say_to('" + string_14 + "');\"><font class=nickname><b>" + text8 + "</b></a>[" + text2 + "]</font><a href=\"http://www.neverlands.ru/pinfo.cgi?" + text6 + "\" onclick=\"window.open(this.href);\"><img src=http://image.neverlands.ru/chat/info.gif width=11 height=12 border=0 align=absmiddle></a>";
	}

	private static string smethod_1(Class76 class76_0)
	{
		string text = class76_0.method_0().Replace("+", "%2B");
		string text2 = "#000000";
		switch (class76_0.method_8())
		{
		case 2:
			text2 = "#0B610B";
			break;
		case 1:
			text2 = "#8A0808";
			break;
		}
		string text3 = "<font color=\"" + text2 + "\">" + class76_0.method_0() + "</font>";
		string text4 = string.Empty;
		string text5 = string.Empty;
		string text6 = class76_0.method_14();
		switch (Class0.smethod_0(text6))
		{
		case 822911587u:
			if (text6 == "4")
			{
				text4 = "chaoss.gif";
				text5 = "Дети Хаоса";
			}
			break;
		case 806133968u:
			if (text6 == "5")
			{
				text4 = "light.gif";
				text5 = "Истинный Свет";
			}
			break;
		case 856466825u:
			if (text6 == "6")
			{
				text4 = "dark.gif";
				text5 = "Истинная Тьма";
			}
			break;
		case 839689206u:
			if (text6 == "7")
			{
				text4 = "sumer.gif";
				text5 = "Нейтральные Сумерки";
			}
			break;
		case 906799682u:
			if (text6 == "3")
			{
				text4 = "sumers.gif";
				text5 = "Дети Сумерек";
			}
			break;
		case 873244444u:
			if (text6 == "1")
			{
				text4 = "darks.gif";
				text5 = "Дети Тьмы";
			}
			break;
		case 1024243015u:
			if (text6 == "8")
			{
				text4 = "chaos.gif";
				text5 = "Абсолютный Хаос";
			}
			break;
		case 1007465396u:
			if (text6 == "9")
			{
				text4 = "angel.gif";
				text5 = "Ангел";
			}
			break;
		case 923577301u:
			if (text6 == "2")
			{
				text4 = "lights.gif";
				text5 = "Дети Света";
			}
			break;
		}
		string text7 = (string.IsNullOrEmpty(text4) ? string.Empty : ("<img src=http://image.neverlands.ru/signs/" + text4 + " width=15 height=12 align=absmiddle border=0 title=\"" + text5 + "\">&nbsp;"));
		string text8 = string.Empty;
		if (!string.IsNullOrEmpty(class76_0.method_16()))
		{
			text8 = "<img src=http://image.neverlands.ru/signs/" + class76_0.method_12() + " width=15 height=12 align=absmiddle title=\"" + class76_0.method_16() + "\">&nbsp;";
		}
		return "<a href=\"#\" onclick=\"top.say_private('" + class76_0.method_0() + "');\"><img src=http://image.neverlands.ru/chat/private.gif width=11 height=12 border=0 align=absmiddle></a>&nbsp;" + text7 + text8 + "<a class=\"activenick\" href=\"#\" onclick=\"top.say_to('" + class76_0.method_0() + "');\"><font class=nickname><b>" + text3 + "</b></a>[" + class76_0.method_18() + "]</font><a href=\"http://www.neverlands.ru/pinfo.cgi?" + text + "\" onclick=\"window.open(this.href);\"><img src=http://image.neverlands.ru/chat/info.gif width=11 height=12 border=0 align=absmiddle></a>";
	}
}
