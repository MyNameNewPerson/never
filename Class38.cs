using System;
using System.Globalization;

internal sealed class Class38 : ICloneable
{
	private string string_0;

	private string string_1;

	internal string method_0()
	{
		return string_0;
	}

	internal void method_1(string string_2)
	{
		string_0 = string_2;
	}

	internal string method_2()
	{
		return string_1;
	}

	internal void method_3(string string_2)
	{
		string_1 = string_2;
	}

	public object Clone()
	{
		return MemberwiseClone();
	}

	public override string ToString()
	{
		return string.Format(CultureInfo.InvariantCulture, "{0}: {1}", new object[2]
		{
			method_0(),
			method_2()
		});
	}
}
