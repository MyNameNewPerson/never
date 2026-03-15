internal sealed class Class78
{
	internal string string_0;

	internal string string_1;

	internal string string_2;

	internal string string_3;

	public Class78(string string_4, string string_5)
	{
		string_0 = string_4;
		string_1 = string_5;
	}

	public Class78(string string_4)
	{
		string[] array = string_4.Split('-');
		string_0 = array[0];
		string_1 = array[1];
	}

	internal string method_0()
	{
		return string_0 + "-" + string_1;
	}
}
