using System;

internal sealed class Class83
{
	private Class78[] class78_0;

	private Class78 class78_1;

	private Class83()
	{
	}

	public Class83(string string_0, Class78 class78_2)
	{
		method_1(new Class78[1]
		{
			new Class78(string_0)
		});
		method_3(class78_2);
	}

	public Class78[] method_0()
	{
		return class78_0;
	}

	private void method_1(Class78[] class78_2)
	{
		class78_0 = class78_2;
	}

	public Class78 method_2()
	{
		return class78_1;
	}

	private void method_3(Class78 class78_2)
	{
		class78_1 = class78_2;
	}

	public string method_4()
	{
		if (method_0().Length != 0)
		{
			return method_0()[method_0().Length - 1].method_0();
		}
		return null;
	}

	public Class83 method_5(string string_0, Class78 class78_2)
	{
		if (Array.IndexOf(method_0(), string_0) >= 0)
		{
			return null;
		}
		Class83 @class = new Class83();
		@class.method_1(new Class78[method_0().Length + 1]);
		@class.method_3(class78_2);
		Class83 class2 = @class;
		Array.Copy(method_0(), class2.method_0(), method_0().Length);
		class2.method_0()[method_0().Length] = new Class78(string_0);
		return class2;
	}
}
