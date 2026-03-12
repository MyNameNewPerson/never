using System;

internal sealed class Class86 : IComparable
{
	private int int_0;

	private int int_1;

	private string string_0;

	private int int_2;

	private string string_1;

	private string string_2;

	internal Class86(int int_3, int int_4, string string_3, int int_5, string string_4, string string_5)
	{
		method_1(int_3);
		method_3(int_4);
		method_5(string_3);
		method_7(int_5);
		method_9(string_4);
		method_11(string_5);
	}

	internal int method_0()
	{
		return int_0;
	}

	private void method_1(int int_3)
	{
		int_0 = int_3;
	}

	internal int method_2()
	{
		return int_1;
	}

	private void method_3(int int_3)
	{
		int_1 = int_3;
	}

	internal string method_4()
	{
		return string_0;
	}

	private void method_5(string string_3)
	{
		string_0 = string_3;
	}

	internal int method_6()
	{
		return int_2;
	}

	private void method_7(int int_3)
	{
		int_2 = int_3;
	}

	internal string method_8()
	{
		return string_1;
	}

	private void method_9(string string_3)
	{
		string_1 = string_3;
	}

	internal string method_10()
	{
		return string_2;
	}

	private void method_11(string string_3)
	{
		string_2 = string_3;
	}

	public int CompareTo(object obj)
	{
		if (obj != null && obj is Class86)
		{
			Class86 @class = (Class86)obj;
			if (method_0() > @class.method_0())
			{
				return -1;
			}
			if (method_0() >= @class.method_0())
			{
				return 0;
			}
			return 1;
		}
		return -1;
	}
}
