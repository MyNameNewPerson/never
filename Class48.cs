using System.Net.Sockets;

internal sealed class Class48
{
	private readonly Socket socket_0;

	internal Class48(Socket socket_1)
	{
		socket_0 = socket_1;
		socket_0.NoDelay = true;
	}
}
