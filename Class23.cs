using System.Net;
using System.Net.Sockets;

internal sealed class Class23
{
	private readonly Socket socket_0;

	internal Class23(Socket socket_1)
	{
		socket_0 = socket_1;
		socket_0.NoDelay = true;
	}

	internal IPAddress method_0()
	{
		try
		{
			if (socket_0 != null && socket_0.RemoteEndPoint != null)
			{
				return ((IPEndPoint)socket_0.RemoteEndPoint).Address;
			}
			return new IPAddress(0L);
		}
		catch
		{
			return new IPAddress(0L);
		}
	}

	public int method_1()
	{
		try
		{
			if (socket_0 != null && socket_0.RemoteEndPoint != null)
			{
				return ((IPEndPoint)socket_0.RemoteEndPoint).Port;
			}
			return 0;
		}
		catch
		{
			return 0;
		}
	}

	internal void method_2()
	{
		socket_0.ReceiveTimeout = 60000;
	}
}
