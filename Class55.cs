using System.Globalization;

internal sealed class Class55
{
	private string string_0;

	private string string_1;

	private string string_2;

	private string string_3;

	internal Class55(string string_4, string string_5)
	{
		method_1(string_4);
		int num = string_5.LastIndexOf('.');
		method_3((num != -1) ? string_5.Substring(0, num) : string_5);
		method_5(string.Format(CultureInfo.InvariantCulture, "{0} {1}", new object[2]
		{
			string_4,
			method_2()
		}));
	}

	internal string method_0()
	{
		return string_0;
	}

	private void method_1(string string_4)
	{
		string_0 = string_4;
	}

	internal string method_2()
	{
		return string_1;
	}

	private void method_3(string string_4)
	{
		string_1 = string_4;
	}

	internal string method_4()
	{
		return string_2;
	}

	private void method_5(string string_4)
	{
		string_2 = string_4;
	}

	internal string method_6()
	{
		return string_3;
	}

	private void method_7(string string_4)
	{
		string_3 = string_4;
	}

	internal void method_8(string string_4)
	{
		method_7(string.Format(CultureInfo.InvariantCulture, "{0} - {1}", new object[2]
		{
			string_4,
			method_4()
		}));
	}
}
