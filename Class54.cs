using System;
using System.Diagnostics;
using System.Globalization;
using System.Text;
using System.Threading;
using System.Windows.Forms;

internal static class Class54
{
	internal static void smethod_0()
	{
		if (!Debugger.IsAttached)
		{
			Application.ThreadException -= smethod_2;
			Application.ThreadException += smethod_2;
			AppDomain.CurrentDomain.UnhandledException -= smethod_3;
			AppDomain.CurrentDomain.UnhandledException += smethod_3;
		}
	}

	internal static void smethod_1()
	{
		if (!Debugger.IsAttached)
		{
			Application.ThreadException -= smethod_2;
			AppDomain.CurrentDomain.UnhandledException -= smethod_3;
		}
	}

	private static void smethod_2(object sender, ThreadExceptionEventArgs e)
	{
		smethod_4(e.Exception);
	}

	private static void smethod_3(object sender, UnhandledExceptionEventArgs e)
	{
		smethod_4((Exception)e.ExceptionObject);
	}

	private static void smethod_4(Exception exception_0)
	{
		string string_;
		try
		{
			string_ = smethod_6(exception_0);
		}
		catch (Exception ex)
		{
			string_ = string.Format(CultureInfo.InvariantCulture, "Error '{0}' while generating exception string", new object[1] { ex.Message });
		}
		FormAutoTrap formAutoTrap = new FormAutoTrap(string_);
		try
		{
			formAutoTrap.ShowDialog();
		}
		finally
		{
			((IDisposable)formAutoTrap).Dispose();
		}
		smethod_5();
		Application.Exit();
	}

	private static void smethod_5()
	{
		Process.GetCurrentProcess().Kill();
	}

	private static string smethod_6(Exception exception_0)
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendLine(Class72.class55_0.method_4());
		stringBuilder.AppendLine(Class72.class19_0.method_30());
		stringBuilder.AppendLine(Application.StartupPath);
		stringBuilder.AppendLine();
		stringBuilder.AppendLine(exception_0.ToString());
		return stringBuilder.ToString();
	}
}
