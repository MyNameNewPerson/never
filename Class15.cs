using System.Xml;

internal sealed class Class15
{
	private readonly int[] int_0 = new int[4] { 10, 15, 25, 600 };

	private bool bool_0 = true;

	private int[] int_1;

	private string[] string_0;

	private string string_1;

	private string string_2;

	private string string_3;

	private bool[] bool_1;

	private bool bool_2;

	internal Class15()
	{
		method_1(new int[4] { 10, 15, 25, 600 });
		method_3(new string[4] { "Лечить легкую за [1]?", "Лечить среднюю за [2]?", "Лечить тяж за [3]?", "Лечить боевую за [4]?" });
		method_5("Лечу [1]/[2]/[3], боевые - [4]");
		method_7("Поздравляю, не болей");
		method_9("Выйди из боя!");
		method_11(new bool[4] { true, true, true, true });
		method_13(bool_0);
	}

	internal int[] method_0()
	{
		return int_1;
	}

	internal void method_1(int[] int_2)
	{
		int_1 = int_2;
	}

	internal string[] method_2()
	{
		return string_0;
	}

	internal void method_3(string[] string_4)
	{
		string_0 = string_4;
	}

	internal string method_4()
	{
		return string_1;
	}

	internal void method_5(string string_4)
	{
		string_1 = string_4;
	}

	internal string method_6()
	{
		return string_2;
	}

	internal void method_7(string string_4)
	{
		string_2 = string_4;
	}

	internal string method_8()
	{
		return string_3;
	}

	internal void method_9(string string_4)
	{
		string_3 = string_4;
	}

	internal bool[] method_10()
	{
		return bool_1;
	}

	internal void method_11(bool[] bool_3)
	{
		bool_1 = bool_3;
	}

	internal bool method_12()
	{
		return bool_2;
	}

	internal void method_13(bool bool_3)
	{
		bool_2 = bool_3;
	}

	internal void method_14(XmlWriter xmlWriter_0)
	{
		xmlWriter_0.WriteStartElement("cure");
		for (int i = 0; i < 4; i++)
		{
			if (method_0()[i] != int_0[i])
			{
				xmlWriter_0.WriteStartAttribute("nv" + (i + 1));
				xmlWriter_0.WriteValue(method_0()[i]);
				xmlWriter_0.WriteEndAttribute();
			}
		}
		for (int j = 0; j < 4; j++)
		{
			if (!string.IsNullOrEmpty(method_2()[j]))
			{
				xmlWriter_0.WriteStartAttribute("cask" + (j + 1));
				xmlWriter_0.WriteString(method_2()[j]);
				xmlWriter_0.WriteEndAttribute();
			}
		}
		if (!string.IsNullOrEmpty(method_4()))
		{
			xmlWriter_0.WriteStartAttribute("cadv");
			xmlWriter_0.WriteString(method_4());
			xmlWriter_0.WriteEndAttribute();
		}
		if (!string.IsNullOrEmpty(method_6()))
		{
			xmlWriter_0.WriteStartAttribute("cafter");
			xmlWriter_0.WriteString(method_6());
			xmlWriter_0.WriteEndAttribute();
		}
		if (!string.IsNullOrEmpty(method_8()))
		{
			xmlWriter_0.WriteStartAttribute("cboi");
			xmlWriter_0.WriteString(method_8());
			xmlWriter_0.WriteEndAttribute();
		}
		for (int k = 0; k < 4; k++)
		{
			if (!method_10()[k])
			{
				xmlWriter_0.WriteStartAttribute("e" + (k + 1));
				xmlWriter_0.WriteValue(value: false);
				xmlWriter_0.WriteEndAttribute();
			}
		}
		if (method_12() != bool_0)
		{
			xmlWriter_0.WriteStartAttribute("d04");
			xmlWriter_0.WriteValue(method_12());
			xmlWriter_0.WriteEndAttribute();
		}
		xmlWriter_0.WriteEndElement();
	}

	internal void method_15(XmlReader xmlReader_0)
	{
		for (int i = 0; i < 4; i++)
		{
			if (!int.TryParse(xmlReader_0["nv" + (i + 1)], out var result))
			{
				result = int_0[i];
			}
			method_0()[i] = result;
			if (xmlReader_0["cask" + (i + 1)] != null)
			{
				method_2()[i] = xmlReader_0["cask" + (i + 1)];
			}
			if (!bool.TryParse(xmlReader_0["e" + (i + 1)], out var result2))
			{
				result2 = true;
			}
			method_10()[i] = result2;
		}
		if (xmlReader_0["cadv"] != null)
		{
			method_5(xmlReader_0["cadv"]);
		}
		if (xmlReader_0["cafter"] != null)
		{
			method_7(xmlReader_0["cafter"]);
		}
		if (xmlReader_0["cboi"] != null)
		{
			method_9(xmlReader_0["cboi"]);
		}
		if (xmlReader_0["d04"] != null)
		{
			if (!bool.TryParse(xmlReader_0["d04"], out var result3))
			{
				result3 = bool_0;
			}
			method_13(result3);
		}
		if (method_0()[0] < 5 || method_0()[0] > 50)
		{
			method_0()[0] = int_0[0];
		}
		if (method_0()[1] < 8 || method_0()[1] > 100)
		{
			method_0()[1] = int_0[1];
		}
		if (method_0()[2] < 11 || method_0()[2] > 150)
		{
			method_0()[2] = int_0[2];
		}
		if (method_0()[3] < 296 || method_0()[3] > 900)
		{
			method_0()[3] = int_0[3];
		}
	}
}
