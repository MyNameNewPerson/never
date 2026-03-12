using System;

internal static class Class73
{
	private static int int_0;

	private static int[] int_1;

	private static string[] string_0;

	internal static void smethod_0(string string_1)
	{
		if (string_1 == null)
		{
			throw new ArgumentNullException("answers");
		}
		string_0 = string_1.Split(new string[1] { "[BR]" }, StringSplitOptions.RemoveEmptyEntries);
	}

	internal static string smethod_1()
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
}
