using System;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;

internal static class Class21
{
	internal static string smethod_0(string string_0)
	{
		return smethod_8(Class4.smethod_4("http://neverlands.ru/pinfo.cgi?" + string_0));
	}

	internal static string smethod_1(string string_0)
	{
		return smethod_8(Class4.smethod_4("http://neverlands.ru/logs.fcg?fid=" + string_0));
	}

	internal static string smethod_2(string string_0)
	{
		string text2;
		do
		{
			string text = smethod_8(Class4.smethod_4("http://www.neverlands.ru/modules/api/getid.cgi?" + string_0));
			text2 = ((text == null) ? null : text.Split('|')[0]);
		}
		while (string.IsNullOrEmpty(text2));
		return text2;
	}

	internal static string smethod_3(string string_0)
	{
		string text;
		while (true)
		{
			text = smethod_8(Class4.smethod_4("http://www.neverlands.ru/modules/api/info.cgi?playerid=" + string_0 + "&info=1&hmu=1&slots=1&effects=1"));
			if (!string.IsNullOrEmpty(text))
			{
				break;
			}
			Thread.Sleep(1000);
		}
		return text;
	}

	internal static string smethod_4()
	{
		return smethod_8(Class4.smethod_4("http://service.neverlands.ru/info/city_city1.txt"));
	}

	internal static string smethod_5(int int_0)
	{
		return smethod_8(Class4.smethod_4($"http://service.neverlands.ru/info/cityhall_{int_0}.txt"));
	}

	internal static string smethod_6()
	{
		return smethod_8(Class4.smethod_4("http://service.neverlands.ru/info/clans.txt"));
	}

	internal static string smethod_7(string string_0)
	{
		string text;
		do
		{
			text = smethod_2(string_0);
		}
		while (string.IsNullOrEmpty(text));
		string text3;
		while (true)
		{
			string text2 = smethod_3(text);
			if (!string.IsNullOrEmpty(text2))
			{
				text3 = Class12.smethod_1(text2, "\n3|", "\n4|");
				if (!string.IsNullOrEmpty(text3))
				{
					break;
				}
			}
		}
		string text4 = text3.Split('|')[14];
		if (!text4.Equals("0", StringComparison.Ordinal))
		{
			return text4;
		}
		return string.Empty;
	}

	private static string smethod_8(string string_0)
	{
		try
		{
			WebRequest webRequest = WebRequest.Create(string_0);
			webRequest.Proxy = Class72.webProxy_0;
			webRequest.Method = "GET";
			webRequest.Headers.Add(HttpRequestHeader.Cookie, Class32.smethod_1("www.neverlands.ru"));
			StreamReader streamReader = new StreamReader(webRequest.GetResponse().GetResponseStream(), Encoding.GetEncoding(1251));
			string result = streamReader.ReadToEnd();
			streamReader.Close();
			return result;
		}
		catch
		{
			return null;
		}
	}
}
