using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Threading;

internal static class Class34
{
	private static readonly Dictionary<string, Class33> dictionary_0 = new Dictionary<string, Class33>();

	private static readonly ReaderWriterLock readerWriterLock_0 = new ReaderWriterLock();

	internal static IPAddress smethod_0(string string_0, bool bool_0)
	{
		IPAddress iPAddress = Class49.smethod_1(string_0);
		if (iPAddress == null)
		{
			IPHostEntry iPHostEntry = null;
			if (bool_0 && dictionary_0.TryGetValue(string_0, out var value))
			{
				if (value.method_0() > Environment.TickCount - 60000)
				{
					iPHostEntry = value.method_2();
				}
				else
				{
					try
					{
						readerWriterLock_0.AcquireWriterLock(5000);
						try
						{
							dictionary_0.Remove(string_0);
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
			if (iPHostEntry == null)
			{
				iPHostEntry = Dns.GetHostEntry(string_0);
				try
				{
					readerWriterLock_0.AcquireWriterLock(5000);
					try
					{
						if (!dictionary_0.ContainsKey(string_0))
						{
							dictionary_0.Add(string_0, new Class33(iPHostEntry));
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
			iPAddress = iPHostEntry.AddressList[0];
			if (iPAddress.AddressFamily != AddressFamily.InterNetworkV6)
			{
				return iPAddress;
			}
			for (int i = 1; i < iPHostEntry.AddressList.Length; i++)
			{
				if (iPHostEntry.AddressList[i].AddressFamily == AddressFamily.InterNetwork)
				{
					return iPHostEntry.AddressList[i];
				}
			}
		}
		return iPAddress;
	}
}
