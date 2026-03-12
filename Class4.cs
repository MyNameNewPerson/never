using System;
using System.Globalization;
using System.Text;
using System.Web;

internal static class Class4
{
	internal static string smethod_0(long long_0)
	{
		DateTime dateTime = DateTime.FromBinary(long_0);
		TimeSpan timeSpan = DateTime.Now - dateTime;
		StringBuilder stringBuilder = new StringBuilder();
		if (timeSpan.Days > 0)
		{
			stringBuilder.AppendFormat("{0}д ", timeSpan.Days);
		}
		if (timeSpan.Hours > 0)
		{
			stringBuilder.AppendFormat("{0}ч ", timeSpan.Hours);
		}
		stringBuilder.AppendFormat("{0}мин", timeSpan.Minutes);
		return stringBuilder.ToString();
	}

	internal static string smethod_1(TimeSpan timeSpan_0)
	{
		if (!(timeSpan_0.TotalHours >= 1.0))
		{
			if (!(timeSpan_0.TotalMinutes >= 1.0))
			{
				return string.Format(CultureInfo.InvariantCulture, "(0:{0:00})", new object[1] { timeSpan_0.Seconds });
			}
			return string.Format(CultureInfo.InvariantCulture, "({0}:{1:00})", new object[2] { timeSpan_0.Minutes, timeSpan_0.Seconds });
		}
		return string.Format(CultureInfo.InvariantCulture, "({0}:{1:00}:{2:00})", new object[3] { timeSpan_0.Hours, timeSpan_0.Minutes, timeSpan_0.Seconds });
	}

	internal static string smethod_2(string string_0)
	{
		if (string_0 == null)
		{
			return null;
		}
		StringBuilder stringBuilder = new StringBuilder(HttpUtility.UrlDecode(string_0.Replace('+', ' '), Class91.encoding_0));
		stringBuilder.Replace("|", " ");
		stringBuilder.Replace("%20", " ");
		stringBuilder.Replace("%2B", "+");
		stringBuilder.Replace("%23", "#");
		stringBuilder.Replace("%3D", "=");
		return stringBuilder.ToString();
	}

	internal static string smethod_3(string string_0)
	{
		if (string_0 == null)
		{
			return null;
		}
		string str = string_0.Replace('+', '|');
		str = HttpUtility.UrlEncode(str, Class91.encoding_0);
		if (str == null)
		{
			return null;
		}
		str = str.Replace("+", "%20");
		return str.Replace("%7c", "%2b");
	}

	internal static string smethod_4(string string_0)
	{
		if (string_0.StartsWith(Class39.smethod_45(), StringComparison.OrdinalIgnoreCase))
		{
			return Class39.smethod_45() + smethod_3(string_0.Substring(Class39.smethod_45().Length));
		}
		if (string_0.StartsWith(Class39.smethod_46(), StringComparison.OrdinalIgnoreCase))
		{
			return Class39.smethod_46() + smethod_3(string_0.Substring(Class39.smethod_46().Length));
		}
		if (string_0.StartsWith("http://neverlands.ru/pinfo.cgi?", StringComparison.OrdinalIgnoreCase))
		{
			return "http://neverlands.ru/pinfo.cgi?" + smethod_3(string_0.Substring(31));
		}
		if (string_0.StartsWith("http://www.neverlands.ru/modules/api/getid.cgi?", StringComparison.OrdinalIgnoreCase))
		{
			return "http://www.neverlands.ru/modules/api/getid.cgi?" + smethod_3(string_0.Substring(47));
		}
		return string_0;
	}

	internal static string smethod_5(int int_0)
	{
		return "(" + int_0 / 60 + ":" + (int_0 % 60).ToString("00") + ":00)";
	}
}
