using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Windows.Forms;

internal static class Class22
{
	private static readonly ReaderWriterLock readerWriterLock_0 = new ReaderWriterLock();

	private static readonly string string_0 = Path.Combine(Application.StartupPath, Class68.string_9);

	private static readonly SortedDictionary<string, byte[]> sortedDictionary_0 = new SortedDictionary<string, byte[]>();

	private static string smethod_0(string string_1)
	{
		string text = string_1.ToLower();
		if (text.StartsWith("http://"))
		{
			text = text.Substring(7);
		}
		int num = text.LastIndexOf('?');
		if (num != -1)
		{
			text = text.Substring(0, num);
		}
		return text;
	}

	internal static byte[] smethod_1(string string_1, bool bool_0)
	{
		if (string.IsNullOrEmpty(string_1))
		{
			return null;
		}
		string text = smethod_0(string_1);
		if (!sortedDictionary_0.TryGetValue(text, out var value))
		{
			return smethod_4(text, bool_0);
		}
		return value;
	}

	internal static void smethod_2(string string_1, byte[] byte_0, bool bool_0)
	{
		if (string.IsNullOrEmpty(string_1) || byte_0 == null || byte_0.Length == 0)
		{
			return;
		}
		string text = smethod_0(string_1);
		smethod_5(text, byte_0);
		if (!bool_0)
		{
			return;
		}
		try
		{
			string text2 = Path.Combine(string_0, text.Replace('/', '\\'));
			string path = text2.Substring(0, text2.LastIndexOf('\\'));
			if (!Directory.Exists(path))
			{
				Directory.CreateDirectory(path);
			}
			File.WriteAllBytes(text2, byte_0);
		}
		catch (Exception)
		{
		}
	}

	internal static void smethod_3()
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

	private static byte[] smethod_4(string string_1, bool bool_0)
	{
		if (string.IsNullOrEmpty(string_1) || bool_0)
		{
			return null;
		}
		if (string_1.IndexOf(".js", StringComparison.InvariantCultureIgnoreCase) != -1)
		{
			return null;
		}
		try
		{
			string path = Path.Combine(string_0, string_1.Replace('/', '\\'));
			if (!File.Exists(path))
			{
				return null;
			}
			return File.ReadAllBytes(path);
		}
		catch (Exception)
		{
			return null;
		}
	}

	private static void smethod_5(string string_1, byte[] byte_0)
	{
		if (string.IsNullOrEmpty(string_1) || byte_0 == null || byte_0.Length == 0)
		{
			return;
		}
		try
		{
			readerWriterLock_0.AcquireWriterLock(5000);
			try
			{
				if (sortedDictionary_0.ContainsKey(string_1))
				{
					sortedDictionary_0[string_1] = byte_0;
				}
				else
				{
					sortedDictionary_0.Add(string_1, byte_0);
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
}
