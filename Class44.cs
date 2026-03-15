using System;

internal static class Class44
{
	internal static Class37 smethod_0(string string_0)
	{
		int num = string_0.IndexOf("\r\n\r\n", StringComparison.Ordinal);
		if (num < 1)
		{
			num = string_0.Length;
		}
		if (num >= 1)
		{
			string[] array = string_0.Substring(0, num).Replace("\r\n", "\n").Split('\n');
			if (array.Length < 1)
			{
				return null;
			}
			Class37 @class = new Class37();
			int num2 = array[0].IndexOf(' ');
			if (num2 > 0)
			{
				@class.method_1(array[0].Substring(0, num2).ToUpperInvariant());
				array[0] = array[0].Substring(num2 + 1).Trim();
				if (string.Compare(@class.method_0(), 0, "HTTP/", 0, 5, StringComparison.OrdinalIgnoreCase) != 0)
				{
					return null;
				}
				@class.method_17(array[0]);
				num2 = array[0].IndexOf(' ');
				int result;
				if (num2 > 0)
				{
					if (!int.TryParse(array[0].Substring(0, num2).Trim(), out result))
					{
						return null;
					}
				}
				else if (!int.TryParse(array[0].Trim(), out result))
				{
					return null;
				}
				@class.method_15(result);
				for (int i = 1; i < array.Length; i++)
				{
					num2 = array[i].IndexOf(':');
					if (num2 > 0 && num2 <= array[i].Length - 1)
					{
						@class.method_7(array[i].Substring(0, num2), array[i].Substring(num2 + 1).Trim());
					}
				}
				return @class;
			}
		}
		return null;
	}
}
