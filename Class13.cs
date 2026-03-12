using System;
using System.Xml;

internal sealed class Class13
{
	private int int_0;

	private int[] int_1;

	private string[] string_0;

	private string string_1;

	private bool bool_0;

	internal Class13()
	{
		method_4("Меня нет около компьютера. Отвечу позже.");
	}

	internal string method_0()
	{
		return string_1;
	}

	private void method_1(string string_2)
	{
		string_1 = string_2;
	}

	internal bool method_2()
	{
		return bool_0;
	}

	internal void method_3(bool bool_1)
	{
		bool_0 = bool_1;
	}

	internal void method_4(string string_2)
	{
		if (string_2 == null)
		{
			throw new ArgumentNullException("answers");
		}
		method_1(string_2);
		string_0 = string_2.Split(new string[1] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
	}

	internal string method_5()
	{
		if (string_0 != null && string_0.Length != 0)
		{
			if (int_1 == null || int_1.Length != string_0.Length)
			{
				int_1 = new int[string_0.Length];
				for (int i = 0; i < int_1.Length; i++)
				{
					int_1[i] = i;
				}
				for (int j = 0; j < int_1.Length; j++)
				{
					int num = Class89.smethod_0(int_1.Length);
					int num2 = int_1[j];
					int_1[j] = int_1[num];
					int_1[num] = num2;
				}
				int_0 = -1;
			}
			int_0++;
			if (int_0 == int_1.Length)
			{
				int_0 = 0;
			}
			return string_0[int_1[int_0]];
		}
		return string.Empty;
	}

	internal void method_6(XmlWriter xmlWriter_0)
	{
		xmlWriter_0.WriteStartElement("autoanswer");
		if (method_2())
		{
			xmlWriter_0.WriteStartAttribute("active");
			xmlWriter_0.WriteValue(method_2());
			xmlWriter_0.WriteEndAttribute();
		}
		xmlWriter_0.WriteStartAttribute("answers");
		xmlWriter_0.WriteString(method_0().Replace(Environment.NewLine, "[BR]"));
		xmlWriter_0.WriteEndAttribute();
		xmlWriter_0.WriteEndElement();
	}

	internal void method_7(XmlReader xmlReader_0)
	{
		if (xmlReader_0["active"] != null)
		{
			if (!bool.TryParse(xmlReader_0["active"], out var result))
			{
				result = false;
			}
			method_3(result);
		}
		if (xmlReader_0["answers"] != null)
		{
			method_4(xmlReader_0["answers"].Replace("[BR]", Environment.NewLine));
		}
	}
}
