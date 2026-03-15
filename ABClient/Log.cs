using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace ABClient;

public static class Log
{
	private static readonly string string_0 = Path.Combine(Application.StartupPath, "DebugLogs");

	private static readonly ReaderWriterLock readerWriterLock_0 = new ReaderWriterLock();

	private static string smethod_0()
	{
		string path = $"{Class72.class19_0.method_30()}-{DateTime.Now.Year:D4}-{DateTime.Now.Month:D2}-{DateTime.Now.Day:D2}.txt";
		return Path.Combine(string_0, path);
	}

	public static void Write(string address, string html)
	{
	}

	public static void Write(string message)
	{
	}
}
