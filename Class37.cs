using System;
using System.Collections;
using System.Text;

internal sealed class Class37 : Class35, ICloneable
{
	private int int_0;

	private string string_1;

	internal Class37()
	{
		method_17(string.Empty);
	}

	internal int method_14()
	{
		return int_0;
	}

	internal void method_15(int int_1)
	{
		int_0 = int_1;
	}

	internal string method_16()
	{
		return string_1;
	}

	internal void method_17(string string_2)
	{
		string_1 = string_2;
	}

	public object Clone()
	{
		Class37 @class = (Class37)MemberwiseClone();
		@class.method_3(new ArrayList(method_2().Count));
		foreach (Class38 item in method_2())
		{
			@class.method_2().Add(item.Clone());
		}
		return @class;
	}

	public override string ToString()
	{
		return method_18(bool_0: true, bool_1: false);
	}

	internal string method_18(bool bool_0, bool bool_1)
	{
		StringBuilder stringBuilder = new StringBuilder(256);
		if (bool_0)
		{
			stringBuilder.AppendFormat("HTTP/1.1 {0}\r\n", method_16());
		}
		for (int i = 0; i < method_2().Count; i++)
		{
			stringBuilder.Append(((Class38)method_2()[i]).method_0() + ": " + ((Class38)method_2()[i]).method_2() + "\r\n");
		}
		if (bool_1)
		{
			stringBuilder.Append("\r\n");
		}
		return stringBuilder.ToString();
	}
}
