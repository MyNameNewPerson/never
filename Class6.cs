using System;
using System.Collections;
using System.Threading;

internal static class Class6
{
	private static readonly Hashtable hashtable_0 = new Hashtable();

	private static readonly ReaderWriterLock readerWriterLock_0 = new ReaderWriterLock();

	internal static string smethod_0(string string_0)
	{
		try
		{
			readerWriterLock_0.AcquireWriterLock(5000);
			try
			{
				if (!hashtable_0.ContainsKey(string_0))
				{
					hashtable_0.Add(string_0, string.Empty);
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
		return string_0;
	}

	internal static string smethod_1(string string_0)
	{
		string result = string.Empty;
		try
		{
			readerWriterLock_0.AcquireWriterLock(5000);
			try
			{
				if (hashtable_0.ContainsKey(string_0))
				{
					hashtable_0.Remove(string_0);
				}
				if (hashtable_0.Count > 0)
				{
					IEnumerator enumerator = hashtable_0.Keys.GetEnumerator();
					enumerator.MoveNext();
					result = enumerator.Current as string;
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
		return result;
	}
}
