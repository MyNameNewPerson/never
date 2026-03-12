using System;
using System.Globalization;
using System.IO;
using System.Net.Sockets;
using System.Reflection;
using System.Text;

[DefaultMember("Item")]
internal sealed class Class24
{
	private readonly Class47 class47_0;

	private int int_0;

	private int int_1;

	private MemoryStream memoryStream_0;

	private string string_0;

	private Class36 class36_0;

	private Socket socket_0;

	internal Class24(Class47 class47_1)
	{
		class47_0 = class47_1;
		memoryStream_0 = new MemoryStream(2048);
	}

	internal Class36 method_0()
	{
		return class36_0;
	}

	private void method_1(Class36 class36_1)
	{
		class36_0 = class36_1;
	}

	internal Socket method_2()
	{
		return socket_0;
	}

	internal void method_3(Socket socket_1)
	{
		socket_0 = socket_1;
	}

	internal string method_4()
	{
		if (method_0() == null)
		{
			return string.Empty;
		}
		return method_0().method_5("Host");
	}

	internal void method_5(string string_1, string string_2)
	{
		if (method_0() != null)
		{
			method_0().method_6(string_1, string_2);
		}
	}

	internal void method_6(int int_2, string string_1, string string_2)
	{
		if (int_2 >= 400 && string_2.Length < 512)
		{
			string_2 = string_2.PadRight(512, ' ');
		}
		class47_0.method_11(Encoding.UTF8.GetBytes(string_2));
		Class46 @class = class47_0.method_4();
		Class37 class2 = new Class37();
		class2.method_15(int_2);
		class2.method_17(string.Format(CultureInfo.InvariantCulture, "{0} {1}", new object[2] { int_2, string_1 }));
		@class.method_5(class2);
		class47_0.method_4().method_4().method_7("Content-Type", "text/html");
		class47_0.method_4().method_4().method_7("Connection", "close");
		class47_0.method_15(bool_4: false);
		if (!string.IsNullOrEmpty(class47_0.method_12()))
		{
			_ = "http://" + class47_0.method_12();
			try
			{
			}
			catch (InvalidOperationException)
			{
			}
		}
		StringBuilder stringBuilder = new StringBuilder(Class7.smethod_1() + "Connection error<br><br><span class=\"gray\">");
		stringBuilder.Append(int_2);
		stringBuilder.Append(' ');
		stringBuilder.AppendLine(string_1);
		stringBuilder.Append(string_2);
		stringBuilder.Append("</span></body></html>");
		if (!string.IsNullOrEmpty(class47_0.method_12()) && (class47_0.method_12().Equals("www.neverlands.ru/") || class47_0.method_12().StartsWith("www.neverlands.ru/index.cgi") || class47_0.method_12().StartsWith("www.neverlands.ru/game.php") || class47_0.method_12().StartsWith("www.neverlands.ru/main.php")))
		{
			Class72.smethod_17(stringBuilder.ToString());
		}
		int_2 = 200;
		string_1 = "OK";
		class47_0.method_11(Encoding.UTF8.GetBytes(stringBuilder.ToString()));
		Class46 class3 = class47_0.method_4();
		class2 = new Class37();
		class2.method_15(200);
		class2.method_17(string.Format(CultureInfo.InvariantCulture, "{0} {1}", new object[2] { 200, string_1 }));
		class3.method_5(class2);
		class47_0.method_4().method_4().method_7("Content-Type", "text/html");
		class47_0.method_4().method_4().method_7("Connection", "close");
		class47_0.method_15(bool_4: false);
	}

	internal bool method_7()
	{
		if (memoryStream_0 != null && method_2() != null)
		{
			int num = 0;
			bool flag = false;
			bool flag2 = false;
			byte[] array = new byte[8192];
			do
			{
				try
				{
					num = method_2().Receive(array);
				}
				catch (Exception)
				{
					flag = true;
				}
				if (num <= 0)
				{
					flag2 = true;
				}
				else if (memoryStream_0.Length == 0L)
				{
					int i;
					for (i = 0; i < num && (array[i] == 13 || array[i] == 10); i++)
					{
					}
					memoryStream_0.Write(array, i, num - i);
				}
				else
				{
					memoryStream_0.Write(array, 0, num);
				}
			}
			while (!flag2 && !flag && !method_10());
			array = null;
			if (flag)
			{
				return false;
			}
			if (method_0() == null)
			{
				return false;
			}
			if (string_0 != null)
			{
				if (method_0().method_9("Host") && !Class49.smethod_3(string_0, method_0().method_5("Host"), 80))
				{
					method_0().method_6("Host", string_0);
				}
				else if (!method_0().method_9("Host"))
				{
					method_0().method_6("Host", string_0);
				}
			}
			return method_0().method_9("Host");
		}
		return false;
	}

	internal byte[] method_8()
	{
		byte[] array;
		try
		{
			array = new byte[memoryStream_0.Length - int_1];
			memoryStream_0.Position = int_1;
			memoryStream_0.Read(array, 0, array.Length);
		}
		catch (OutOfMemoryException)
		{
			array = Encoding.ASCII.GetBytes("Out of memory");
		}
		memoryStream_0.Dispose();
		memoryStream_0 = null;
		return array;
	}

	private bool method_9()
	{
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

	private bool method_10()
	{
		if (method_0() == null)
		{
			if (!method_9())
			{
				return false;
			}
			if (!method_11())
			{
				if (method_0() == null)
				{
					Class36 @class = new Class36();
					@class.method_15("BAD");
					method_1(@class);
					method_0().method_6("Host", "BAD-REQUEST");
					method_0().method_18("/BAD_REQUEST");
				}
				method_6(400, "Bad Request", "Request Header parsing failed.");
				return true;
			}
		}
		if (method_0() == null)
		{
			return false;
		}
		if (method_0().method_11("Transfer-encoding", "chunked"))
		{
			return Class49.smethod_2(memoryStream_0, int_1);
		}
		if (method_0().method_9("Content-Length"))
		{
			try
			{
				if (long.TryParse(method_0().method_5("Content-Length"), NumberStyles.Integer, NumberFormatInfo.InvariantInfo, out var result) && result >= 0L)
				{
					if (result == 0L && "GET" != method_0().method_14())
					{
						method_6(400, "Bad Request", "This HTTP method requires a request body.");
					}
					return memoryStream_0.Length >= int_1 + result;
				}
				method_6(400, "Bad Request", "Request Content-Length header parsing failed.");
				return true;
			}
			catch
			{
				method_6(400, "Bad Request", "Unknown error: Check content length header.");
				return false;
			}
		}
		if ("GET" != method_0().method_14())
		{
			method_6(411, "Bad Request", "This HTTP method requires a request body.");
		}
		return true;
	}

	private bool method_11()
	{
		if (memoryStream_0 != null && int_1 >= 4)
		{
			method_1(new Class36());
			byte[] buffer = memoryStream_0.GetBuffer();
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			do
			{
				switch (buffer[num4])
				{
				case 10:
					num = num4 + 1;
					break;
				case 32:
					if (num2 == 0)
					{
						num2 = num4 + 1;
					}
					else if (num3 == 0)
					{
						num3 = num4 - num2;
					}
					break;
				}
				num4++;
			}
			while (num == 0);
			if (num2 >= 1 && num3 >= 1)
			{
				method_0().method_15(Encoding.ASCII.GetString(buffer, 0, num2 - 1).ToUpper());
				method_0().method_1(Encoding.ASCII.GetString(buffer, num2 + num3 + 1, num - num3 - num2 - 2).Trim().ToUpper());
				int num5 = 0;
				if (num3 > 7 && buffer[num2 + 4] == 58 && buffer[num2 + 5] == 47 && buffer[num2 + 6] == 47)
				{
					num5 = num2 + 6;
					num2 += 7;
					num3 -= 7;
				}
				else if (num3 > 8 && buffer[num2 + 5] == 58 && buffer[num2 + 6] == 47 && buffer[num2 + 7] == 47)
				{
					num5 = num2 + 7;
					num2 += 8;
					num3 -= 8;
				}
				else if (num3 > 6 && buffer[num2 + 3] == 58 && buffer[num2 + 4] == 47 && buffer[num2 + 5] == 47)
				{
					num5 = num2 + 5;
					num2 += 6;
					num3 -= 6;
				}
				if (num5 > 0)
				{
					while (num3 > 0 && buffer[num2] != 47)
					{
						num2++;
						num3--;
					}
					if (num3 == 0)
					{
						num2 = num5;
						num3 = 1;
					}
					int num6 = num5 + 1;
					int num7 = num2 - num6;
					if (num7 > 0)
					{
						string_0 = Class72.encoding_0.GetString(buffer, num6, num7);
					}
				}
				byte[] array = new byte[num3];
				Array.Copy(buffer, num2, array, 0, num3);
				method_0().method_16(array);
				string text = Class72.encoding_0.GetString(buffer, num, int_1 - num).Trim();
				if (text.Length >= 1)
				{
					string[] array2 = text.Replace("\r\n", "\n").Split('\n');
					for (int i = 0; i < array2.Length; i++)
					{
						int num8 = array2[i].IndexOf(':');
						if (num8 > 0 && num8 <= array2[i].Length - 1)
						{
							try
							{
								string string_ = array2[i].Substring(0, num8);
								string string_2 = array2[i].Substring(num8 + 1).Trim();
								method_0().method_7(string_, string_2);
							}
							catch (Exception)
							{
								method_1(null);
								return false;
							}
						}
					}
				}
				return true;
			}
			return false;
		}
		return false;
	}
}
