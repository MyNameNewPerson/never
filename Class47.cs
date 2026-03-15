using System;
using System.Globalization;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using ABClient;

internal sealed class Class47
{
	private Class47 class47_0;

	private bool bool_0;

	private bool bool_1;

	private bool bool_2;

	private Class24 class24_0;

	private byte[] byte_0;

	private Class46 class46_0;

	private bool bool_3;

	private byte[] byte_1;

	private Class47(Socket socket_0, Socket socket_1, bool bool_4)
	{
		method_7(bool_4: true);
		Class24 @class = new Class24(this);
		@class.method_3(socket_0);
		method_1(@class);
		Class46 class2 = new Class46(this);
		class2.method_1(socket_1);
		class2.method_3(bool_4);
		method_5(class2);
	}

	internal Class24 method_0()
	{
		return class24_0;
	}

	private void method_1(Class24 class24_1)
	{
		class24_0 = class24_1;
	}

	internal byte[] method_2()
	{
		return byte_0;
	}

	private void method_3(byte[] byte_2)
	{
		byte_0 = byte_2;
	}

	internal Class46 method_4()
	{
		return class46_0;
	}

	private void method_5(Class46 class46_1)
	{
		class46_0 = class46_1;
	}

	internal bool method_6()
	{
		return bool_3;
	}

	private void method_7(bool bool_4)
	{
		bool_3 = bool_4;
	}

	internal string method_8()
	{
		if (method_0().method_0() == null)
		{
			return string.Empty;
		}
		return method_0().method_4();
	}

	internal int method_9()
	{
		int int_ = 80;
		Class49.smethod_4(method_0().method_4(), out var _, ref int_);
		return int_;
	}

	private byte[] method_10()
	{
		return byte_1;
	}

	internal void method_11(byte[] byte_2)
	{
		byte_1 = byte_2;
	}

	internal string method_12()
	{
		return method_8() + method_13();
	}

	private string method_13()
	{
		if (method_0().method_0() == null)
		{
			return string.Empty;
		}
		return method_0().method_0().method_17();
	}

	public override string ToString()
	{
		return method_18(bool_4: false);
	}

	internal static void smethod_0(object object_0)
	{
		try
		{
			Socket obj = (Socket)object_0;
			obj.NoDelay = true;
			new Class47(obj, null, bool_4: false).method_14(null);
		}
		catch
		{
		}
	}

	private void method_14(object object_0)
	{
		bool flag = false;
		bool flag2 = false;
		bool flag3 = false;
		if (method_0() != null && method_4() != null)
		{
			if (!method_0().method_7())
			{
				method_21();
				return;
			}
			method_3(method_0().method_8());
			method_19();
			if (method_12().StartsWith("www.neverlands.ru/cgi-bin/go.cgi?uid=", StringComparison.OrdinalIgnoreCase))
			{
				flag = true;
				method_5(new Class46(this, "HTTP/1.1 304 Not Modified\r\nServer: Cache\r\n\r\n"));
			}
			else if (!method_12().Contains("top.list.ru") && !method_12().Contains("counter.yadro.ru"))
			{
				if (!string.IsNullOrEmpty(Class45.smethod_2()))
				{
					method_0().method_0().method_7("Proxy-Authorization", Class45.smethod_2());
				}
				if (bool_0)
				{
					if (method_0().method_0().method_9("If-Modified-Since"))
					{
						method_0().method_0().method_12("If-Modified-Since");
					}
					if (method_0().method_0().method_9("If-None-Match"))
					{
						method_0().method_0().method_12("If-None-Match");
					}
				}
				else
				{
					if (method_0().method_0().method_9("If-Modified-Since") || method_0().method_0().method_9("If-None-Match"))
					{
						flag = true;
						method_5(new Class46(this, "HTTP/1.1 304 Not Modified\r\nServer: Cache\r\n\r\n"));
						goto IL_02e4;
					}
					flag3 = true;
				}
				method_0().method_0().method_12("Cookie");
				string text = Class32.smethod_1(method_8());
				if (!string.IsNullOrEmpty(text))
				{
					method_0().method_0().method_7("Cookie", text);
				}
				if (bool_1)
				{
					byte[] array = Class22.smethod_1(method_12(), Class72.smethod_12());
					if (array != null)
					{
						if (flag3)
						{
							try
							{
								if (Class72.formMain_0 != null)
								{
									Class72.formMain_0.method_132(array.Length);
								}
							}
							catch (InvalidOperationException)
							{
							}
						}
						flag = true;
						method_5(new Class46(this, "HTTP/1.1 200 OK\r\nServer: Cache\r\n\r\n"));
						if (bool_0)
						{
							bool_0 = false;
							byte[] array2 = Class30.smethod_9("http://" + method_12(), array);
							method_4().method_7(array2);
						}
						else
						{
							method_4().method_7(array);
						}
						bool_1 = false;
						goto IL_02e4;
					}
				}
				IdleManager.AddActivity();
				try
				{
					if (Class72.formMain_0 != null)
					{
						Class72.formMain_0.method_79(method_12());
					}
				}
				catch (InvalidOperationException)
				{
				}
				if (flag = method_4().method_9(0))
				{
					flag = method_4().method_8();
				}
				if (!flag)
				{
					method_21();
				}
				else
				{
					method_11(method_4().method_10());
				}
				try
				{
					if (Class72.formMain_0 != null)
					{
						Class72.formMain_0.method_80(method_12());
					}
				}
				catch (InvalidOperationException)
				{
				}
				IdleManager.RemoveActivity();
			}
			else
			{
				flag = true;
				method_5(new Class46(this, "HTTP/1.1 304 Not Modified\r\nServer: Cache\r\n\r\n"));
			}
		}
		goto IL_02e4;
		IL_02e4:
		method_20();
		if (method_4() != null)
		{
			if (method_12().StartsWith("www.neverlands.ru/main.php", StringComparison.OrdinalIgnoreCase) && method_4().method_4().method_9("Date") && DateTime.TryParse(method_4().method_4().method_5("Date"), Class72.cultureInfo_1, DateTimeStyles.None, out var result))
			{
				try
				{
					if (Class72.formMain_0 != null)
					{
						Class72.formMain_0.BeginInvoke(new Delegate23(Class72.formMain_0.method_78), result);
					}
				}
				catch (InvalidOperationException)
				{
				}
			}
			for (int i = 0; i < method_4().method_4().method_8(); i++)
			{
				if (method_4().method_4().method_4(i).method_0()
					.Equals("Set-Cookie", StringComparison.OrdinalIgnoreCase))
				{
					Class32.smethod_0(method_8(), method_4().method_4().method_4(i).method_2());
				}
			}
			method_4().method_4().method_12("Set-Cookie");
			if (method_4() != null && method_4().method_4() != null && method_4().method_4().method_14() == 200)
			{
				if (method_12().StartsWith("www.neverlands.ru/modules/code/code.php?", StringComparison.OrdinalIgnoreCase))
				{
					Class72.smethod_25(method_10());
				}
				else
				{
					if (bool_1)
					{
						Class22.smethod_2(method_12(), method_10(), bool_2);
					}
					if (bool_0 && method_10() != null)
					{
						byte[] array3 = Class30.smethod_9("http://" + method_12(), method_10());
						method_4().method_7(array3);
					}
				}
			}
			else if (method_4() != null && method_4().method_4() != null && ((method_4().method_4().method_14() >= 400) & (method_4().method_4().method_14() != 404)) && bool_0)
			{
				StringBuilder stringBuilder = new StringBuilder(Class7.smethod_1() + "Отказ сервера <br><br><span class=\"gray\">");
				stringBuilder.AppendLine(method_4().method_4().method_16());
				stringBuilder.Append("</span></body></html>");
				method_4().method_7(Encoding.UTF8.GetBytes(stringBuilder.ToString()));
				Class46 @class = method_4();
				Class37 class2 = new Class37();
				class2.method_15(200);
				class2.method_17("OK");
				@class.method_5(class2);
			}
		}
		bool flag4 = false;
		if (!method_6())
		{
			flag4 = true;
		}
		if (method_4() != null && method_4().method_4() != null)
		{
			if ((method_4().method_4().method_14() == 401 && string.Compare(method_4().method_4().method_5("WWW-Authenticate"), 0, "N", 0, 1, StringComparison.OrdinalIgnoreCase) == 0) || (method_4().method_4().method_14() == 407 && string.Compare(method_4().method_4().method_5("Proxy-Authenticate"), 0, "N", 0, 1, StringComparison.OrdinalIgnoreCase) == 0))
			{
				flag2 = method_22(407 == method_4().method_4().method_14());
			}
			else if (method_4().method_0() != null)
			{
				if ((method_4().method_4().method_11("Connection", "close") || !method_4().method_0().Connected || method_4().method_4().method_0() != "HTTP/1.1") && method_4().method_0().Connected)
				{
					try
					{
						if (method_4().method_0() != null)
						{
							method_4().method_0().Shutdown(SocketShutdown.Both);
							method_4().method_0().Close();
						}
					}
					catch (Exception)
					{
					}
					method_4().method_1(null);
				}
				method_4().method_1(null);
			}
		}
		if (!flag4 && flag)
		{
			method_15(flag2);
		}
		if (method_0() != null && method_0().method_2() != null && flag4)
		{
			if (method_4() != null && method_4().method_4() != null && (flag2 || (!method_4().method_4().method_11("Connection", "close") && !method_0().method_0().method_11("Connection", "close") && (method_4().method_4().method_0() == "HTTP/1.1" || method_4().method_4().method_10("Connection", "Keep-Alive")))))
			{
				if (!flag2)
				{
					Thread.Sleep(25);
				}
				if (flag2 || 0 < method_0().method_2().Available)
				{
					class47_0 = (flag2 ? new Class47(method_0().method_2(), method_4().method_0(), method_4().method_2()) : new Class47(method_0().method_2(), null, bool_4: false));
					method_0().method_3(null);
					goto IL_0875;
				}
			}
			try
			{
				if (method_0().method_2() != null)
				{
					method_0().method_2().Shutdown(SocketShutdown.Both);
					method_0().method_2().Close();
				}
			}
			catch (Exception)
			{
			}
			method_0().method_3(null);
		}
		goto IL_0875;
		IL_0875:
		if (class47_0 != null)
		{
			class47_0.method_14(null);
		}
	}

	internal bool method_15(bool bool_4)
	{
		bool result = false;
		try
		{
			if (method_0().method_2() != null && method_0().method_2().Connected)
			{
				string s = method_4().method_4().method_18(bool_0: true, bool_1: true);
				method_0().method_2().Send(Class72.encoding_0.GetBytes(s));
				if (method_10() != null)
				{
					method_0().method_2().Send(method_10());
				}
				if (bool_4 || (!method_4().method_4().method_11("Connection", "close") && !method_0().method_0().method_11("Connection", "close") && (method_4().method_4().method_0() == "HTTP/1.1" || method_4().method_4().method_10("Connection", "Keep-Alive"))))
				{
					if (!bool_4)
					{
						Thread.Sleep(25);
					}
					if (bool_4 || 0 < method_0().method_2().Available)
					{
						class47_0 = (bool_4 ? new Class47(method_0().method_2(), method_4().method_0(), method_4().method_2()) : new Class47(method_0().method_2(), null, bool_4: false));
						method_0().method_3(null);
						return true;
					}
				}
				try
				{
					if (method_0().method_2() != null)
					{
						method_0().method_2().Shutdown(SocketShutdown.Both);
						method_0().method_2().Close();
					}
				}
				catch (Exception)
				{
				}
				method_0().method_3(null);
				result = true;
			}
			else
			{
				method_0().method_3(null);
			}
		}
		catch (SocketException ex2)
		{
			if (ex2.SocketErrorCode != SocketError.ConnectionReset)
			{
				method_0().method_6(400, "Bad Request", string.Format(CultureInfo.InvariantCulture, "Return response failed.\n{0}", new object[1] { ex2.Message }));
			}
		}
		return result;
	}

	private void method_16()
	{
		if (method_4() != null && method_4().method_4() != null && (method_4().method_4().method_9("Transfer-Encoding") || method_4().method_4().method_9("Content-Encoding")))
		{
			if (method_4().method_4().method_10("Transfer-Encoding", "chunked"))
			{
				method_11(Class49.smethod_5(method_10()));
			}
			if (method_4().method_4().method_10("Transfer-Encoding", "gzip") || method_4().method_4().method_10("Content-Encoding", "gzip"))
			{
				method_11(Class49.smethod_6(method_10()));
			}
			if (method_4().method_4().method_10("Transfer-Encoding", "deflate") || method_4().method_4().method_10("Content-Encoding", "deflate"))
			{
				method_11(Class49.smethod_7(method_10()));
			}
			method_4().method_4().method_12("Transfer-Encoding");
			method_4().method_4().method_12("Content-Encoding");
			method_4().method_6("Content-Length", (method_10() == null) ? "0" : method_10().LongLength.ToString(CultureInfo.InvariantCulture));
		}
	}

	private void method_17()
	{
		if (method_0() == null || method_0().method_0() == null || (!method_0().method_0().method_9("Transfer-Encoding") && !method_0().method_0().method_9("Content-Encoding")))
		{
			return;
		}
		try
		{
			if (method_2() != null && method_2().LongLength > 0L)
			{
				if (method_0().method_0().method_10("Transfer-Encoding", "chunked"))
				{
					method_3(Class49.smethod_5(method_2()));
				}
				if (method_0().method_0().method_10("Transfer-Encoding", "gzip") || method_0().method_0().method_10("Content-Encoding", "gzip"))
				{
					method_3(Class49.smethod_6(method_2()));
				}
				if (method_0().method_0().method_10("Transfer-Encoding", "deflate") || method_0().method_0().method_10("Content-Encoding", "deflate"))
				{
					method_3(Class49.smethod_7(method_2()));
				}
			}
			method_0().method_0().method_12("Transfer-Encoding");
			method_0().method_0().method_12("Content-Encoding");
			method_0().method_5("Content-Length", (method_2() == null) ? "0" : method_2().LongLength.ToString(CultureInfo.InvariantCulture));
		}
		catch (Exception)
		{
		}
	}

	private string method_18(bool bool_4)
	{
		string text;
		if (!bool_4)
		{
			text = method_0().method_0().method_20(bool_0: true, bool_1: true);
			if (method_2() != null)
			{
				text += Encoding.UTF8.GetString(method_2());
			}
			if (method_4() != null && method_4().method_4() != null)
			{
				text = text + "\r\n" + method_4().method_4().method_18(bool_0: true, bool_1: true);
				if (method_10() != null)
				{
					text += Encoding.UTF8.GetString(method_10());
				}
			}
			return text;
		}
		text = method_0().method_0().ToString();
		if (method_4() != null && method_4().method_4() != null)
		{
			text = text + "\r\n" + method_4().method_4();
		}
		return text;
	}

	private void method_19()
	{
		if (method_8().Equals("neverlands.ru", StringComparison.OrdinalIgnoreCase) || method_8().EndsWith(".neverlands.ru", StringComparison.OrdinalIgnoreCase))
		{
			bool_2 = true;
		}
		string text = method_12();
		if (!text.EndsWith(".gif", StringComparison.OrdinalIgnoreCase) && !text.EndsWith(".jpg", StringComparison.OrdinalIgnoreCase) && !text.EndsWith(".jpeg", StringComparison.OrdinalIgnoreCase) && !text.EndsWith(".png", StringComparison.OrdinalIgnoreCase) && !text.EndsWith(".swf", StringComparison.OrdinalIgnoreCase) && !text.EndsWith(".ico", StringComparison.OrdinalIgnoreCase))
		{
			if (text.EndsWith(".css", StringComparison.OrdinalIgnoreCase))
			{
				bool_1 = false;
			}
			else
			{
				if (text.IndexOf(".js", StringComparison.OrdinalIgnoreCase) != -1)
				{
					bool_1 = true;
				}
				if (bool_2)
				{
					bool_0 = true;
				}
			}
		}
		else
		{
			bool_1 = true;
		}
		method_17();
	}

	private void method_20()
	{
		method_16();
	}

	private void method_21()
	{
		if (method_0() != null && method_0().method_2() != null && method_0().method_2().Connected)
		{
			try
			{
				if (method_0().method_2() != null)
				{
					method_0().method_2().Shutdown(SocketShutdown.Both);
					method_0().method_2().Close();
				}
			}
			catch (Exception)
			{
			}
			method_0().method_3(null);
		}
		if (method_4() == null || method_4().method_0() == null || !method_4().method_0().Connected)
		{
			return;
		}
		try
		{
			if (method_4().method_0() != null)
			{
				method_4().method_0().Shutdown(SocketShutdown.Both);
				method_4().method_0().Close();
			}
		}
		catch (Exception)
		{
		}
		method_4().method_1(null);
	}

	private bool method_22(bool bool_4)
	{
		method_4().method_4().method_6("Proxy-Support", "Session-Based-Authentication");
		if (bool_4)
		{
			if (string.IsNullOrEmpty(method_0().method_0().method_5("Proxy-Authorization")))
			{
				return false;
			}
			if (!method_4().method_4().method_9("Proxy-Authenticate") || method_4().method_4().method_5("Proxy-Authenticate").Length < 6)
			{
				return false;
			}
		}
		else
		{
			if (string.IsNullOrEmpty(method_0().method_0().method_5("Authorization")))
			{
				return false;
			}
			if (!method_4().method_4().method_9("WWW-Authenticate") || method_4().method_4().method_5("WWW-Authenticate").Length < 6)
			{
				return false;
			}
		}
		return true;
	}
}
