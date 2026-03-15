internal sealed class Class5
{
	private string string_0;

	private string string_1;

	private string string_2;

	private string string_3;

	private string string_4;

	private string string_5;

	internal Class5(string string_6)
	{
		if (string_6.IndexOf("var mine = [") != -1)
		{
			method_1(Class12.smethod_1(string_6, "var mine = [\"", "\""));
			method_11(method_12());
			string[] array = Class12.smethod_1(string_6, "var pos = [", "];").Split(',');
			method_7(array[1]);
			method_9(array[0]);
			method_3(array[2]);
			method_5(Class12.smethod_1(string_6, "\"digg\",\"Начать добычу\",\"", "\""));
			if (Class72.class79_0 == null)
			{
				Class72.class79_0 = new Class79().method_0();
			}
		}
	}

	private string method_0()
	{
		return string_0;
	}

	private void method_1(string string_6)
	{
		string_0 = string_6;
	}

	internal string method_2()
	{
		return string_1;
	}

	private void method_3(string string_6)
	{
		string_1 = string_6;
	}

	internal string method_4()
	{
		return string_2;
	}

	private void method_5(string string_6)
	{
		string_2 = string_6;
	}

	internal string method_6()
	{
		return string_3;
	}

	private void method_7(string string_6)
	{
		string_3 = string_6;
	}

	internal string method_8()
	{
		return string_4;
	}

	private void method_9(string string_6)
	{
		string_4 = string_6;
	}

	internal string method_10()
	{
		return string_5;
	}

	private void method_11(string string_6)
	{
		string_5 = string_6;
	}

	private string method_12()
	{
		return method_0() switch
		{
			"Рудник Пыльный" => "3", 
			"Рудник Провал" => "2", 
			"Шахта в Деревне Подгорная" => "1", 
			_ => "0", 
		};
	}
}
