using System;
using System.Collections.Generic;
using System.Globalization;

internal sealed class Class80
{
	private sealed class Class81
	{
		public string string_0;

		internal bool method_0(Class78 class78_0)
		{
			return class78_0.method_0().Equals(string_0);
		}
	}

	private sealed class Class82
	{
		public Class78 class78_0;

		public Class78 class78_1;

		internal bool method_0(Class78 class78_2)
		{
			return class78_2.method_0().Equals(class78_0.method_0());
		}

		internal bool method_1(Class78 class78_2)
		{
			return class78_2.method_0().Equals(class78_1.method_0());
		}
	}

	private bool bool_0;

	private Class78[] class78_0;

	private Class78 class78_1;

	private int int_0;

	private string string_0;

	private readonly SortedDictionary<string, Class83> sortedDictionary_0 = new SortedDictionary<string, Class83>();

	private readonly List<Class83> list_0 = new List<Class83>();

	private bool bool_1;

	private string string_1;

	public Class80(string string_2, string string_3)
	{
		string text = Class72.class5_0.method_6();
		string text2 = Class72.class5_0.method_8();
		string_1 = string_2 + "-" + string_3;
		if (string.IsNullOrEmpty(text) || string.IsNullOrEmpty(text2) || string.IsNullOrEmpty(string_2) || string.IsNullOrEmpty(string_3) || (text.Equals(string_2) && text2.Equals(string_3)))
		{
			return;
		}
		string text3 = text + "-" + text2;
		Class78 class78_ = Class72.class79_0.method_1(text, text2);
		int num = 1;
		sortedDictionary_0.Add(text3, new Class83(text3, class78_));
		do
		{
			bool_1 = false;
			List<string> list = new List<string>();
			foreach (KeyValuePair<string, Class83> item in sortedDictionary_0)
			{
				if (item.Value.method_0().Length == num)
				{
					list.Add(item.Key);
				}
			}
			if (list.Count == 0)
			{
				break;
			}
			foreach (string item2 in list)
			{
				Class83 @class = sortedDictionary_0[item2];
				int num2 = Convert.ToInt32(@class.method_2().string_0, CultureInfo.InvariantCulture);
				int num3 = Convert.ToInt32(@class.method_2().string_1, CultureInfo.InvariantCulture);
				string text4 = @class.method_2().string_2.Split('_')[0];
				int[] array = new int[4] { 0, 1, 0, -1 };
				int[] array2 = new int[4] { -1, 0, 1, 0 };
				for (int i = 0; i < array.Length; i++)
				{
					int num4 = num2 + array[i];
					int num5 = num3 + array2[i];
					if ((i != 0 || text4.IndexOf('t') != -1) && (i != 1 || text4.IndexOf('r') != -1) && (i != 2 || text4.IndexOf('b') != -1) && (i != 3 || text4.IndexOf('l') != -1) && num4 >= 0 && num4 <= 20 && num5 >= 0 && num5 <= 20)
					{
						Class78 class2 = Class72.class79_0.method_1(num4.ToString(), num5.ToString());
						Class83 class3 = @class.method_5(class2.method_0(), class2);
						if (class3 != null)
						{
							method_10(class3);
						}
					}
				}
			}
			num++;
		}
		while (bool_1);
		if (list_0.Count > 0)
		{
			int index = Class89.smethod_0(list_0.Count);
			method_1(bool_2: true);
			method_3(list_0[index].method_0());
			method_5(new Class78(list_0[index].method_4()));
			method_11(text3, method_4());
		}
	}

	public bool method_0()
	{
		return bool_0;
	}

	private void method_1(bool bool_2)
	{
		bool_0 = bool_2;
	}

	public Class78[] method_2()
	{
		return class78_0;
	}

	private void method_3(Class78[] class78_2)
	{
		class78_0 = class78_2;
	}

	public Class78 method_4()
	{
		return class78_1;
	}

	private void method_5(Class78 class78_2)
	{
		class78_1 = class78_2;
	}

	public int method_6()
	{
		return int_0;
	}

	private void method_7(int int_1)
	{
		int_0 = int_1;
	}

	public string method_8()
	{
		return string_0;
	}

	private void method_9(string string_2)
	{
		string_0 = string_2;
	}

	private void method_10(Class83 class83_0)
	{
		if (list_0.Count > 0 && class83_0.method_0().Length > list_0[0].method_0().Length + 10)
		{
			return;
		}
		string key = class83_0.method_4();
		if (!sortedDictionary_0.ContainsKey(key))
		{
			sortedDictionary_0.Add(key, class83_0);
			bool_1 = true;
		}
		else
		{
			Class83 @class = sortedDictionary_0[key];
			if (class83_0.method_0().Length >= @class.method_0().Length && class83_0.method_0().Length.CompareTo(@class.method_0().Length) == -1)
			{
				sortedDictionary_0[key] = class83_0;
				bool_1 = true;
			}
		}
		if (!class83_0.method_4().Equals(string_1))
		{
			return;
		}
		if (list_0.Count == 0)
		{
			list_0.Add(class83_0);
			return;
		}
		int num = class83_0.method_0().Length.CompareTo(list_0[0].method_0().Length);
		if (num <= 0)
		{
			if (num < 0)
			{
				list_0.Clear();
			}
			list_0.Add(class83_0);
		}
	}

	public bool method_11(string string_2, Class78 class78_2)
	{
		Class81 @class = new Class81();
		@class.string_0 = string_2;
		if (!string.IsNullOrEmpty(@class.string_0) && class78_2 != null && method_0() && method_2().Length >= 2)
		{
			if (@class.string_0.Equals(class78_2.method_0()))
			{
				return false;
			}
			if (!method_4().method_0().Equals(class78_2.method_0()))
			{
				return false;
			}
			int num = Array.FindIndex(method_2(), @class.method_0);
			if (num < 0)
			{
				return false;
			}
			Class78 class78_3 = method_2()[num + 1];
			method_9(method_12(new Class78(@class.string_0), class78_3));
			method_7(method_2().Length - 1 - num);
			return true;
		}
		return false;
	}

	public string method_12(Class78 class78_2, Class78 class78_3)
	{
		int num = int.Parse(class78_2.string_0);
		int num2 = int.Parse(class78_2.string_1);
		int num3 = int.Parse(class78_3.string_0);
		int num4 = int.Parse(class78_3.string_1);
		if (num - num3 == 1)
		{
			return "left";
		}
		if (num - num3 == -1)
		{
			return "right";
		}
		if (num2 - num4 == 1)
		{
			return "up";
		}
		if (num2 - num4 == -1)
		{
			return "down";
		}
		return null;
	}

	public Class78 method_13(Class78 class78_2)
	{
		Class82 @class = new Class82();
		@class.class78_1 = class78_2;
		@class.class78_0 = Class72.class79_0.method_1(Class72.class5_0.method_6(), Class72.class5_0.method_8());
		int num = Array.FindIndex(method_2(), @class.method_0);
		int num2 = Array.FindIndex(method_2(), @class.method_1);
		if (num2 != -1 && num2 + 1 < method_2().Length && num2 >= num)
		{
			return method_2()[num2 + 1];
		}
		return null;
	}
}
