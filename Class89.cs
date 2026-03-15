using System;

internal static class Class89
{
	private static readonly Random random_0 = new Random();

	internal static int smethod_0(int int_0)
	{
		return random_0.Next(int_0);
	}

	internal static int smethod_1(int int_0, int int_1)
	{
		return random_0.Next(int_0, int_1);
	}
}
