using System;
using System.Collections;
using System.Reflection;

[DefaultMember("Item")]
internal class Class35
{
	private string string_0;

	private ArrayList arrayList_0;

	internal Class35()
	{
		method_1("HTTP/1.1");
		method_3(new ArrayList());
	}

	internal string method_0()
	{
		return string_0;
	}

	internal void method_1(string string_1)
	{
		string_0 = string_1;
	}

	internal ArrayList method_2()
	{
		return arrayList_0;
	}

	internal void method_3(ArrayList arrayList_1)
	{
		arrayList_0 = arrayList_1;
	}

	internal Class38 method_4(int int_0)
	{
		return (Class38)method_2()[int_0];
	}

	internal string method_5(string string_1)
	{
		int num = 0;
		while (true)
		{
			if (num < method_2().Count)
			{
				if (string.Compare(((Class38)method_2()[num]).method_0(), string_1, StringComparison.OrdinalIgnoreCase) == 0)
				{
					break;
				}
				num++;
				continue;
			}
			return string.Empty;
		}
		return ((Class38)method_2()[num]).method_2();
	}

	internal void method_6(string string_1, string string_2)
	{
		bool flag = false;
		for (int i = 0; i < method_2().Count; i++)
		{
			if (string.Compare(((Class38)method_2()[i]).method_0(), string_1, StringComparison.OrdinalIgnoreCase) == 0)
			{
				((Class38)method_2()[i]).method_3(string_2);
				flag = true;
				break;
			}
		}
		if (!flag)
		{
			method_7(string_1, string_2);
		}
	}

	internal void method_7(string string_1, string string_2)
	{
		Class38 @class = new Class38();
		@class.method_1(string_1);
		@class.method_3(string_2);
		Class38 value = @class;
		method_2().Add(value);
	}

	internal int method_8()
	{
		return method_2().Count;
	}

	internal bool method_9(string string_1)
	{
		int num = 0;
		while (true)
		{
			if (num < method_2().Count)
			{
				if (string.Compare(((Class38)method_2()[num]).method_0(), string_1, StringComparison.OrdinalIgnoreCase) == 0)
				{
					break;
				}
				num++;
				continue;
			}
			return false;
		}
		return true;
	}

	internal bool method_10(string string_1, string string_2)
	{
		int num = 0;
		while (true)
		{
			if (num < method_2().Count)
			{
				if (string.Compare(((Class38)method_2()[num]).method_0(), string_1, StringComparison.OrdinalIgnoreCase) == 0 && ((Class38)method_2()[num]).method_2().IndexOf(string_2, StringComparison.OrdinalIgnoreCase) > -1)
				{
					break;
				}
				num++;
				continue;
			}
			return false;
		}
		return true;
	}

	internal bool method_11(string string_1, string string_2)
	{
		int num = 0;
		while (true)
		{
			if (num < method_2().Count)
			{
				if (string.Compare(((Class38)method_2()[num]).method_0(), string_1, StringComparison.OrdinalIgnoreCase) == 0 && string.Compare(((Class38)method_2()[num]).method_2(), string_2, StringComparison.OrdinalIgnoreCase) == 0)
				{
					break;
				}
				num++;
				continue;
			}
			return false;
		}
		return true;
	}

	internal void method_12(string string_1)
	{
		for (int num = method_2().Count - 1; num >= 0; num--)
		{
			if (string.Compare(((Class38)method_2()[num]).method_0(), string_1, StringComparison.OrdinalIgnoreCase) == 0)
			{
				method_2().RemoveAt(num);
			}
		}
	}

	internal void method_13(string string_1, string string_2)
	{
		for (int i = 0; i < method_2().Count; i++)
		{
			if (string.Equals(((Class38)method_2()[i]).method_0(), string_1, StringComparison.OrdinalIgnoreCase))
			{
				((Class38)method_2()[i]).method_1(string_2);
			}
		}
	}
}
