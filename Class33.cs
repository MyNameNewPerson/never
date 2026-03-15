using System;
using System.Net;

internal sealed class Class33
{
	private int int_0;

	private IPHostEntry iphostEntry_0;

	internal Class33(IPHostEntry iphostEntry_1)
	{
		method_3(iphostEntry_1);
		method_1(Environment.TickCount);
	}

	internal int method_0()
	{
		return int_0;
	}

	private void method_1(int int_1)
	{
		int_0 = int_1;
	}

	internal IPHostEntry method_2()
	{
		return iphostEntry_0;
	}

	private void method_3(IPHostEntry iphostEntry_1)
	{
		iphostEntry_0 = iphostEntry_1;
	}
}
