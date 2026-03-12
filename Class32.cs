using System;
using System.Collections.Generic;
using System.Threading;
using System.Web;

internal static class Class32
{
	private static readonly SortedDictionary<string, Class25> sortedDictionary_0 = new SortedDictionary<string, Class25>();

	private static readonly ReaderWriterLock readerWriterLock_0 = new ReaderWriterLock();

	internal static void smethod_0(string string_0, string string_1)
	{
		if (string_0.Equals("www.neverlands.ru", StringComparison.OrdinalIgnoreCase) && string_1.StartsWith("NeverNick=", StringComparison.OrdinalIgnoreCase))
		{
			string text = HttpUtility.UrlDecode(string_1.Substring(10), Class91.encoding_0);
			if (!text.Equals(Class72.class19_0.method_30(), StringComparison.OrdinalIgnoreCase))
			{
				throw new Exception("Неверное имя или пароль.");
			}
			Class72.class19_0.method_31(text);
		}
		int num = string_1.IndexOf('=');
		if (num == -1)
		{
			return;
		}
		string text2 = string_1.Substring(0, num);
		if (string.IsNullOrEmpty(text2))
		{
			return;
		}
		int num2 = string_1.IndexOf(';', num);
		string text3 = ((num2 == -1) ? string_1.Substring(num + 1) : string_1.Substring(num + 1, num2 - num - 1));
		if (string.IsNullOrEmpty(text3))
		{
			return;
		}
		try
		{
			readerWriterLock_0.AcquireWriterLock(5000);
			try
			{
				if (sortedDictionary_0.TryGetValue(string_0, out var value))
				{
					value.method_0(text2, text3);
					sortedDictionary_0[string_0] = value;
				}
				else
				{
					value = new Class25();
					value.method_0(text2, text3);
					sortedDictionary_0.Add(string_0, value);
				}
			}
			finally
			{
				readerWriterLock_0.ReleaseWriterLock();
			}
		}
		catch (ApplicationException)
		{
		}
	}

	internal static string smethod_1(string string_0)
	{
		if (string_0.Equals("forum.neverlands.ru", StringComparison.OrdinalIgnoreCase))
		{
			string_0 = "www.neverlands.ru";
		}
		if (!sortedDictionary_0.TryGetValue(string_0, out var value))
		{
			return null;
		}
		return value.ToString();
	}

	internal static void smethod_2()
	{
		try
		{
			readerWriterLock_0.AcquireWriterLock(5000);
			try
			{
				sortedDictionary_0.Clear();
			}
			finally
			{
				readerWriterLock_0.ReleaseWriterLock();
			}
		}
		catch (ApplicationException)
		{
		}
	}
}
