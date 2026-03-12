using System;
using System.Collections.Specialized;
using System.Globalization;
using System.IO;
using System.Text;
using System.Windows.Forms;

internal static class Class8
{
	private static readonly StringCollection stringCollection_0;

	private static readonly StringBuilder stringBuilder_0;

	private static readonly string string_0;

	private static DateTime dateTime_0;

	private static bool bool_0;

	static Class8()
	{
		stringCollection_0 = new StringCollection();
		stringBuilder_0 = new StringBuilder();
		smethod_1(DateTime.Now);
		string text = Class72.class19_0.method_30();
		char[] invalidFileNameChars = Path.GetInvalidFileNameChars();
		foreach (char c in invalidFileNameChars)
		{
			text = text.Replace(c.ToString(), string.Empty);
		}
		string_0 = Path.Combine(Application.StartupPath, Path.Combine(Class68.string_12, text));
	}

	private static DateTime smethod_0()
	{
		return dateTime_0;
	}

	internal static void smethod_1(DateTime dateTime_1)
	{
		dateTime_0 = dateTime_1;
	}

	private static bool smethod_2()
	{
		return bool_0;
	}

	internal static void smethod_3(bool bool_1)
	{
		bool_0 = bool_1;
	}

	internal static void smethod_4(string string_1)
	{
		if (string.IsNullOrEmpty(string_1) || stringCollection_0.SyncRoot == null)
		{
			return;
		}
		lock (stringCollection_0.SyncRoot)
		{
			stringCollection_0.Add(string_1);
		}
	}

	internal static string smethod_5()
	{
		if (!smethod_2() && DateTime.Now.Subtract(smethod_0()).TotalSeconds >= 3.0)
		{
			if (stringCollection_0.SyncRoot != null)
			{
				lock (stringCollection_0.SyncRoot)
				{
					if (stringCollection_0.Count == 0)
					{
						return string.Empty;
					}
					string result = stringCollection_0[0];
					stringCollection_0.RemoveAt(0);
					smethod_1(DateTime.Now);
					return result;
				}
			}
			return string.Empty;
		}
		return string.Empty;
	}

	internal static void smethod_6(string string_1)
	{
		if (string.IsNullOrEmpty(string_1))
		{
			return;
		}
		if (stringBuilder_0.Length > 0)
		{
			stringBuilder_0.Append("<br>");
		}
		stringBuilder_0.Append(string_1);
		if (!Class72.class19_0.method_106())
		{
			return;
		}
		TextWriter textWriter = null;
		try
		{
			if (!Directory.Exists(string_0))
			{
				Directory.CreateDirectory(string_0);
			}
			string path = smethod_8();
			if (!File.Exists(path))
			{
				textWriter = new StreamWriter(path, append: false, Class91.encoding_0, 1024);
				textWriter.WriteLine("<HTML><META Content=\"text/html; Charset=windows-1251\" Http-Equiv=Content-type><HEAD><LINK href=\"http://www.neverlands.ru/ch/chat.css\" rel=STYLESHEET type=text/css></HEAD><BODY LeftMargin=2 TopMargin=2 RightMargin=2 MarginHeight=2 MarginWidth=2 BgColor=#F5F5F5>");
			}
			else
			{
				textWriter = new StreamWriter(path, append: true, Class91.encoding_0, 1024);
			}
			textWriter.WriteLine("<br>");
			textWriter.Write(string_1);
		}
		catch (IOException ex)
		{
			smethod_7(ex.Message);
		}
		catch (ArgumentNullException ex2)
		{
			smethod_7(ex2.Message);
		}
		catch (InvalidOperationException ex3)
		{
			smethod_7(ex3.Message);
		}
		catch (ArgumentException ex4)
		{
			smethod_7(ex4.Message);
		}
		catch (NotSupportedException ex5)
		{
			smethod_7(ex5.Message);
		}
		catch (UnauthorizedAccessException ex6)
		{
			smethod_7(ex6.Message);
		}
		finally
		{
			textWriter?.Close();
		}
	}

	private static void smethod_7(string string_1)
	{
		MessageBox.Show(string_1, "Ошибка сохранения чата", MessageBoxButtons.OK, MessageBoxIcon.Hand);
	}

	internal static string smethod_8()
	{
		string path = string.Format(CultureInfo.InvariantCulture, "{0:00}-{1:00}-{2:00}.html", new object[3]
		{
			DateTime.Now.Year,
			DateTime.Now.Month,
			DateTime.Now.Day
		});
		return Path.Combine(string_0, path);
	}
}
