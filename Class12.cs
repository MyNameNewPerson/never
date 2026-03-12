using System;
using System.Collections.Generic;

internal static class Class12
{
	internal static string smethod_0(string string_0, string string_1, string string_2, string string_3)
	{
		int num = string_0.IndexOf(string_1, StringComparison.OrdinalIgnoreCase);
		if (num == -1)
		{
			return string_0;
		}
		int num2 = string_0.IndexOf(string_2, num + string_1.Length, StringComparison.OrdinalIgnoreCase);
		if (num2 != -1)
		{
			return string_0.Substring(0, num + string_1.Length) + string_3 + string_0.Substring(num2);
		}
		return string_0;
	}

	internal static string smethod_1(string string_0, string string_1, string string_2)
	{
		int num = string_0.IndexOf(string_1, StringComparison.OrdinalIgnoreCase);
		if (num == -1)
		{
			return null;
		}
		int num2 = string_0.IndexOf(string_2, num + string_1.Length, StringComparison.OrdinalIgnoreCase);
		if (num2 != -1)
		{
			return string_0.Substring(num + string_1.Length, num2 - num - string_1.Length);
		}
		return null;
	}

	internal static string[] smethod_2(string string_0)
	{
		List<string> list = new List<string>();
		int num = 0;
		do
		{
			int num2 = num;
			if (string_0[num2] != '\'')
			{
				int num3 = string_0.IndexOf(',', num2 + 1);
				if (num3 == -1)
				{
					num3 = string_0.Length;
				}
				string item = string_0.Substring(num2, num3 - num2);
				list.Add(item);
				num = num3 + 1;
				continue;
			}
			int num4 = string_0.IndexOf('\'', num2 + 1);
			if (num4 == -1)
			{
				break;
			}
			string item2 = string_0.Substring(num2 + 1, num4 - num2 - 1);
			list.Add(item2);
			num = num4 + 1;
			if (num < string_0.Length)
			{
				if (string_0[num] != ',')
				{
					break;
				}
				num++;
			}
		}
		while (num < string_0.Length);
		return list.ToArray();
	}

	internal static string[] smethod_3(string string_0)
	{
		string[] array = string_0.Split(new string[1] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
		List<string> list = new List<string>();
		for (int i = 0; i < array.Length; i++)
		{
			if (!string.IsNullOrEmpty(array[i]) && array[i][0] != ';')
			{
				list.Add(array[i]);
			}
		}
		if (list.Count == 0)
		{
			return null;
		}
		List<string> list2 = new List<string>();
		while (list.Count > 0)
		{
			int index = Class89.smethod_0(list.Count);
			list2.Add(list[index]);
			list.RemoveAt(index);
		}
		return list2.ToArray();
	}

	internal static List<List<string>> smethod_4(string string_0)
	{
		if (!string.IsNullOrEmpty(string_0) && string_0.Length >= 2)
		{
			List<List<string>> list = new List<List<string>>();
			int num = 0;
			int num2 = -1;
			while (num < string_0.Length)
			{
				if (string_0[num] != '[')
				{
					num2 = string_0.IndexOf(',', num + 1);
				}
				else
				{
					num2 = string_0.IndexOf(']', num + 1);
					if (num2 != -1)
					{
						num2++;
					}
				}
				if (num2 == -1)
				{
					num2 = string_0.Length;
				}
				string text = string_0.Substring(num, num2 - num);
				List<string> list2 = new List<string>();
				if (text.Length > 0)
				{
					if (text[0] != '[')
					{
						text = text.Trim(' ', '"', '\'');
						list2.Add(text);
					}
					else
					{
						text = text.Trim(' ', '[', ']');
						string[] array = text.Split(',');
						for (int i = 0; i < array.Length; i++)
						{
							string item = array[i].Trim(' ', '"', '\'');
							list2.Add(item);
						}
					}
				}
				list.Add(list2);
				num = num2 + 1;
			}
			return list;
		}
		return null;
	}

	internal static bool smethod_5()
	{
		int int_ = Class72.int_14;
		int int_2 = Class72.int_15;
		int num = ((Class72.class19_0.timeSpan_0 == TimeSpan.MinValue) ? DateTime.Now.Hour : DateTime.Now.Subtract(Class72.class19_0.timeSpan_0).Hour);
		bool flag;
		if (((flag = int_ > int_2) && (num >= int_ || num < int_2)) || (!flag && num >= int_ && num < int_2))
		{
			return true;
		}
		return false;
	}
}
