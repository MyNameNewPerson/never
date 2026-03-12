using System;
using System.Globalization;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Text;
using System.Web;

[DefaultMember("Item")]
internal sealed class Class46
{
	private readonly Class47 class47_0;

	private bool bool_0;

	private long long_0;

	private int int_0;

	private int int_1;

	private MemoryStream memoryStream_0;

	private Socket socket_0;

	private bool bool_1;

	private Class37 class37_0;

	internal Class46(Class47 class47_1)
	{
		class47_0 = class47_1;
		memoryStream_0 = new MemoryStream(32768);
	}

	internal Class46(Class47 class47_1, string string_0)
	{
		class47_0 = class47_1;
		method_5(Class44.smethod_0(string_0));
	}

	internal Socket method_0()
	{
		return socket_0;
	}

	internal void method_1(Socket socket_1)
	{
		socket_0 = socket_1;
	}

	internal bool method_2()
	{
		return bool_1;
	}

	internal void method_3(bool bool_2)
	{
		bool_1 = bool_2;
	}

	internal Class37 method_4()
	{
		return class37_0;
	}

	internal void method_5(Class37 class37_1)
	{
		class37_0 = class37_1;
	}

	internal void method_6(string string_0, string string_1)
	{
		if (method_4() != null)
		{
			method_4().method_6(string_0, string_1);
		}
	}

	internal void method_7(byte[] byte_0)
	{
		method_4().method_15(200);
		method_4().method_17("200 OK without Headers");
		method_4().method_6("Content-Length", byte_0.LongLength.ToString(CultureInfo.InvariantCulture));
		class47_0.method_11(byte_0);
	}

	internal bool method_8()
	{
		bool flag = false;
		bool flag2 = false;
		bool flag3 = !class47_0.method_6();
		bool flag4 = true;
		byte[] buffer = new byte[32768];
		do
		{
			try
			{
				if (flag4 && method_4() != null)
				{
					flag4 = false;
					flag3 = !class47_0.method_6();
				}
				int num = method_0().Receive(buffer);
				if (num <= 0)
				{
					flag = true;
					continue;
				}
				memoryStream_0.Write(buffer, 0, num);
				if (flag3)
				{
					method_15();
				}
			}
			catch (Exception)
			{
				flag2 = true;
			}
		}
		while (!flag && !method_14() && !flag2);
		if (memoryStream_0.Length == 0L)
		{
			flag2 = true;
		}
		else
		{
			try
			{
				if (Class72.formMain_0 != null)
				{
					Class72.formMain_0.method_131(memoryStream_0.Length);
				}
			}
			catch (InvalidOperationException)
			{
			}
		}
		if (method_4() == null && !flag2)
		{
			Class37 @class = new Class37();
			@class.method_15(200);
			@class.method_17("200 This buggy server did not return headers");
			method_5(@class);
			int_1 = 0;
			return true;
		}
		if (method_4() != null && Class72.class19_0.method_114())
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append(method_4());
			try
			{
			}
			catch (InvalidOperationException)
			{
			}
		}
		return !flag2;
	}

	internal bool method_9(int int_2)
	{
		if (int_2 > 2)
		{
			return false;
		}
		if (method_0() == null && !method_11())
		{
			return false;
		}
		try
		{
			if (!method_2())
			{
				class47_0.method_0().method_0().method_13("Proxy-Connection", "Connection");
			}
			if (!class47_0.method_0().method_0().method_9("Accept-encoding"))
			{
				class47_0.method_0().method_0().method_7("Accept-encoding", "gzip");
			}
			byte[] array = class47_0.method_0().method_0().method_19(bool_0: true, bool_1: true, method_2());
			if (Class72.class19_0.method_114())
			{
				StringBuilder stringBuilder = new StringBuilder();
				stringBuilder.Append(Class72.encoding_0.GetString(array));
				if (class47_0.method_2() != null)
				{
					stringBuilder.AppendLine(Class72.encoding_0.GetString(class47_0.method_2()));
				}
				try
				{
				}
				catch (InvalidOperationException)
				{
				}
			}
			if (method_0() != null && class47_0 != null && class47_0.method_2() != null)
			{
				method_0().Send(array);
				method_0().Send(class47_0.method_2());
			}
		}
		catch (SocketException)
		{
			method_1(null);
			return method_9(int_2 + 1);
		}
		return true;
	}

	internal byte[] method_10()
	{
		byte[] array;
		try
		{
			array = new byte[memoryStream_0.Length - int_1];
		}
		catch (OutOfMemoryException)
		{
			array = Encoding.ASCII.GetBytes("Out of memory");
		}
		memoryStream_0.Position = int_1;
		memoryStream_0.Read(array, 0, array.Length);
		memoryStream_0.Dispose();
		memoryStream_0 = null;
		return array;
	}

	private bool method_11()
	{
		int num = class47_0.method_9();
		Class49.smethod_4(class47_0.method_8(), out var string_, ref num);
		IPEndPoint iPEndPoint = Class45.smethod_0();
		if (iPEndPoint != null)
		{
			method_3(bool_2: true);
		}
		else
		{
			IPAddress address;
			try
			{
				address = Class34.smethod_0(string_, bool_0: true);
			}
			catch
			{
				class47_0.method_0().method_6(502, "DNS Lookup Failed", "DNS Lookup for " + HttpUtility.HtmlEncode(string_) + " failed.");
				return false;
			}
			if (num < 0 || num > 65535)
			{
				class47_0.method_0().method_6(502, "Invalid Request", "HTTP Request specified an invalid port number.");
				return false;
			}
			iPEndPoint = new IPEndPoint(address, num);
		}
		try
		{
			Socket socket_ = new Socket(iPEndPoint.AddressFamily, SocketType.Stream, ProtocolType.Tcp)
			{
				NoDelay = true,
				ReceiveTimeout = 10000,
				SendTimeout = 10000
			};
			method_1(socket_);
			method_0().Connect(iPEndPoint);
			return true;
		}
		catch (Exception ex)
		{
			if (method_2())
			{
				class47_0.method_0().method_6(502, "Gateway Connection Failed", string.Format(CultureInfo.InvariantCulture, "Connection to Gateway failed.<BR>Exception Text: {0}", new object[1] { ex.Message }));
			}
			else
			{
				class47_0.method_0().method_6(502, "Connection Failed", string.Format(CultureInfo.InvariantCulture, "Connection to {0} failed.<BR>Exception Text: {1}", new object[2]
				{
					HttpUtility.HtmlEncode(string_),
					ex.Message
				}));
			}
			return false;
		}
	}

	private void method_12()
	{
		method_5(null);
		byte[] array = new byte[memoryStream_0.Length - int_1];
		memoryStream_0.Position = int_1;
		memoryStream_0.Read(array, 0, array.Length);
		memoryStream_0.Dispose();
		memoryStream_0 = new MemoryStream(array.Length);
		memoryStream_0.Write(array, 0, array.Length);
		int_1 = 0;
		int_0 = 0;
	}

	private bool method_13()
	{
		if (int_1 > 0)
		{
			return true;
		}
		if (memoryStream_0 == null)
		{
			return false;
		}
		byte[] buffer = memoryStream_0.GetBuffer();
		long length = memoryStream_0.Length;
		while (true)
		{
			bool flag = false;
			while (int_0 < length - 1L)
			{
				int_0++;
				if (10 == buffer[int_0 - 1])
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				break;
			}
			if (13 != buffer[int_0] && 10 != buffer[int_0])
			{
				int_0++;
				continue;
			}
			if (10 == buffer[int_0])
			{
				int_1 = int_0 + 1;
				return true;
			}
			int_0++;
			if (int_0 < length && 10 == buffer[int_0])
			{
				int_1 = int_0 + 1;
				return true;
			}
			if (int_0 > 3)
			{
				int_0 -= 4;
			}
			else
			{
				int_0 = 0;
			}
			break;
		}
		return false;
	}

	private bool method_14()
	{
		if (method_4() == null)
		{
			if (!method_13())
			{
				return false;
			}
			if (!method_16())
			{
				class47_0.method_0().method_6(500, "Bad Response", "Response Header parsing failed. This can be caused by an illegal HTTP response earlier on this socket, like a 304 response which contains a body.");
				return true;
			}
		}
		if (method_4() != null)
		{
			if ((method_4() == null || method_4().method_14() != 100) && method_4() != null && method_4().method_14() > 99 && method_4().method_14() < 200)
			{
				method_12();
				return method_14();
			}
			if (class47_0.method_0().method_0().method_14() == "HEAD")
			{
				return true;
			}
			if (method_4() != null && (method_4().method_14() == 204 || method_4().method_14() == 205 || method_4().method_14() == 304))
			{
				return true;
			}
			if (method_4() != null && method_4().method_11("Transfer-encoding", "chunked"))
			{
				return Class49.smethod_2(memoryStream_0, int_1);
			}
			if (method_4() != null && method_4().method_9("Content-Length"))
			{
				if (long.TryParse(method_4().method_5("Content-Length"), NumberStyles.Integer, NumberFormatInfo.InvariantInfo, out var result) && result >= 0L)
				{
					return memoryStream_0.Length >= int_1 + result;
				}
				return true;
			}
		}
		return false;
	}

	private void method_15()
	{
		if (class47_0.method_0() == null || class47_0.method_0().method_2() == null || (!bool_0 && !method_13()))
		{
			return;
		}
		while (!bool_0 && method_13())
		{
			if (!method_16())
			{
				return;
			}
			if (method_4().method_14() > 99 && method_4().method_14() < 200)
			{
				method_12();
				continue;
			}
			if ((401 == method_4().method_14() && method_4().method_5("WWW-Authenticate").StartsWith("N", StringComparison.OrdinalIgnoreCase)) || (407 == method_4().method_14() && method_4().method_5("Proxy-Authenticate").StartsWith("N", StringComparison.OrdinalIgnoreCase)))
			{
				method_4().method_6("Proxy-Support", "Session-Based-Authentication");
			}
			class47_0.method_0().method_2().Send(Class72.encoding_0.GetBytes(method_4().method_18(bool_0: true, bool_1: true)));
			bool_0 = true;
			long_0 = int_1;
			break;
		}
		byte[] buffer = memoryStream_0.GetBuffer();
		if (buffer != null)
		{
			int num = (int)long_0;
			int num2 = (int)(memoryStream_0.Length - long_0);
			if (num + num2 > buffer.LongLength)
			{
				num2 = buffer.Length - num;
			}
			if (num2 >= 1)
			{
				class47_0.method_0().method_2().Send(buffer, num, num2, SocketFlags.None);
			}
		}
		long_0 = memoryStream_0.Length;
	}

	private bool method_16()
	{
		if (memoryStream_0 != null && int_1 >= 4)
		{
			method_5(new Class37());
			byte[] buffer = memoryStream_0.GetBuffer();
			string text = Class72.encoding_0.GetString(buffer, 0, int_1).Trim();
			if (string.IsNullOrEmpty(text))
			{
				method_5(null);
				return false;
			}
			string[] array = text.Replace("\r\n", "\n").Split('\n');
			if (array.Length >= 1)
			{
				int num = array[0].IndexOf(' ');
				if (num > 0)
				{
					method_4().method_1(array[0].Substring(0, num).ToUpper());
					array[0] = array[0].Substring(num + 1).Trim();
					if (!method_4().method_0().StartsWith("HTTP/", StringComparison.OrdinalIgnoreCase))
					{
						return false;
					}
					method_4().method_17(array[0]);
					num = array[0].IndexOf(' ');
					int result;
					bool num2 = ((num > 0) ? int.TryParse(array[0].Substring(0, num).Trim(), NumberStyles.Integer, NumberFormatInfo.InvariantInfo, out result) : int.TryParse(array[0].Trim(), NumberStyles.Integer, NumberFormatInfo.InvariantInfo, out result));
					method_4().method_15(result);
					if (!num2)
					{
						return false;
					}
					for (int i = 1; i < array.Length; i++)
					{
						num = array[i].IndexOf(':');
						if (num > 0 && num <= array[i].Length - 1)
						{
							try
							{
								method_4().method_7(array[i].Substring(0, num), array[i].Substring(num + 1).Trim());
							}
							catch
							{
								return false;
							}
						}
					}
					return true;
				}
			}
		}
		return false;
	}
}
