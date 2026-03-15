using System;
using System.Threading;

namespace ABClient;

public static class IdleManager
{
	private static int int_0;

	private static readonly ReaderWriterLock readerWriterLock_0 = new ReaderWriterLock();

	public static void AddActivity()
	{
		try
		{
			readerWriterLock_0.AcquireWriterLock(5000);
			try
			{
				int_0++;
				smethod_0();
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

	public static void RemoveActivity()
	{
		try
		{
			readerWriterLock_0.AcquireWriterLock(5000);
			try
			{
				int_0--;
				smethod_0();
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

	private static void smethod_0()
	{
		try
		{
			if (Class72.formMain_0 != null)
			{
				Class72.formMain_0.BeginInvoke(new Delegate22(Class72.formMain_0.method_81), int_0);
			}
		}
		catch (InvalidOperationException)
		{
		}
	}
}
