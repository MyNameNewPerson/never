using System;
using System.Globalization;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Threading;

internal sealed class Class45 : IDisposable
{
	private int int_0;

	private Socket socket_0;

	private static IPEndPoint ipendPoint_0;

	private static string string_0;

	internal static IPEndPoint smethod_0()
	{
		return ipendPoint_0;
	}

	private static void smethod_1(IPEndPoint ipendPoint_1)
	{
		ipendPoint_0 = ipendPoint_1;
	}

	internal static string smethod_2()
	{
		return string_0;
	}

	private static void smethod_3(string string_1)
	{
		string_0 = string_1;
	}

	public void Dispose()
	{
		if (socket_0 != null)
		{
			try
			{
				socket_0.LingerState = new LingerOption(enable: true, 0);
				socket_0.Close();
			}
			catch
			{
			}
		}
	}

	internal bool method_0()
	{
		int_0 = 8052;
		while (socket_0 == null)
		{
			try
			{
				if (Socket.OSSupportsIPv6)
				{
					socket_0 = new Socket(AddressFamily.InterNetworkV6, SocketType.Stream, ProtocolType.Tcp);
					if (Environment.OSVersion.Version.Major > 5)
					{
						socket_0.SetSocketOption(SocketOptionLevel.IPv6, SocketOptionName.IPv6Only, 0);
					}
					socket_0.Bind(new IPEndPoint(IPAddress.IPv6Any, int_0));
				}
				else
				{
					socket_0 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
					socket_0.Bind(new IPEndPoint(IPAddress.Any, int_0));
				}
				socket_0.Listen(50);
			}
			catch (SocketException)
			{
				socket_0 = null;
				int_0++;
			}
		}
		smethod_1(null);
		Class72.webProxy_0 = null;
		if (Class72.class19_0.method_46())
		{
			Class72.webProxy_0 = new WebProxy(new Uri("http://" + Class72.class19_0.method_48()));
			smethod_1(Class49.smethod_0(Class72.class19_0.method_48()));
			if (!string.IsNullOrEmpty(Class72.class19_0.method_50()) && !string.IsNullOrEmpty(Class72.class19_0.method_52()))
			{
				string s = string.Format(CultureInfo.InvariantCulture, "{0}:{1}", new object[2]
				{
					Class72.class19_0.method_50(),
					Class72.class19_0.method_52()
				});
				string text = Convert.ToBase64String(Class72.encoding_0.GetBytes(s));
				smethod_3(string.Format(CultureInfo.InvariantCulture, "Basic {0}", new object[1] { text }));
				Class72.webProxy_0.UseDefaultCredentials = false;
				Class72.webProxy_0.Credentials = new NetworkCredential(Class72.class19_0.method_50(), Class72.class19_0.method_52());
			}
		}
		try
		{
			socket_0.BeginAccept(method_1, socket_0);
		}
		catch (Exception)
		{
			socket_0 = null;
			return false;
		}
		smethod_4(string.Format(CultureInfo.InvariantCulture, "localhost:{0}", new object[1] { int_0 }));
		return true;
	}

	private static void smethod_4(string string_1)
	{
		using Class20.Struct15 @struct = new Class20.Struct15(3, Marshal.StringToHGlobalAnsi(string_1), Marshal.StringToHGlobalAnsi("local"));
		IntPtr intPtr = Marshal.AllocCoTaskMem(Marshal.SizeOf((object)@struct));
		Marshal.StructureToPtr((object)@struct, intPtr, fDeleteOld: true);
		Class20.InternetSetOption(IntPtr.Zero, 38, intPtr, Marshal.SizeOf((object)@struct));
	}

	private void method_1(IAsyncResult iasyncResult_0)
	{
		try
		{
			ThreadPool.UnsafeQueueUserWorkItem(Class47.smethod_0, socket_0.EndAccept(iasyncResult_0));
			socket_0.BeginAccept(method_1, socket_0);
		}
		catch (ObjectDisposedException)
		{
		}
		catch (SocketException)
		{
		}
		try
		{
			socket_0.BeginAccept(method_1, null);
		}
		catch (ObjectDisposedException)
		{
		}
		catch (SocketException)
		{
		}
	}
}
