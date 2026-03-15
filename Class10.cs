using System;
using System.Globalization;
using System.Net;
using System.Security.Cryptography;
using System.Text;

internal sealed class Class10
{
	private static string smethod_0(string string_0)
	{
		RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider();
		rSACryptoServiceProvider.FromXmlString("<RSAKeyValue><Modulus>6knmoWs2EgajX4O8bZJvEyNM7PzQtyb+p5x2477uCaflBaezu28xJudojEpVDfxV4Ngq6wowlKftOZ34SH7RLxErviRrw/0pBce1G20r5gg4tZfCqvZyApAXa+Xdis4NTVusHVsPwssUUmRUkuZurw7zby5lUxtZ/LG/jLapG1c=</Modulus><Exponent>AQAB</Exponent><P>9f5Chxb7nm4jxTkGVg6h689ZYA3v615sup2oLKgQjSBPdqqxCTCtrZFNhEaKwTg0kf0IDAy+F11Oid8LeAs1kQ==</P><Q>89HAbGsiJNrWfSL/oafGgbtht+0aAThexW6NVkqQPs9e41++GgBgVvzFj8Yhv47dMXTcsEAO50DvsjYd2N6uZw==</Q><DP>APy3OaGO+vDINfdnnhrK7Y5Udn031EL5vrn5Pcyi3F4f04MV2MqYN9UYcYpy7hmSpG9Wg+3dKWzXbtg1TJMG8Q==</DP><DQ>IqW+42lB+9zBOB0eGHnAArV/CGUAGgZJqWKxYP7Niq9rO4JigE1nY1UeOfUc3JzPn/SMW9tugrw+k6OPED9spw==</DQ><InverseQ>g0ATw/Ksm2kfKKcNEYs60UXlFI+KCKo5j0S8aFmd/9uQq5edMjnby7pbyLyQVHQ06737yIPYtfR/4LV38dvoQw==</InverseQ><D>Hbzkm7+OfOo/yWtguu230I+N/5S1b1HxR9gZ1R2SfEJF1Rpsu1FJRV1hDVGQCzbotaHqjKvd77iC6WnOLnF+XoNc5t02AwXclMnHvWwLzjYYeC/I6H1mSE5uheg3Vh2PofOkkIcB6yM5vgaUIb/sbxA68JY726YBBJNN3dD33PE=</D></RSAKeyValue>");
		try
		{
			return Encoding.UTF8.GetString(rSACryptoServiceProvider.Decrypt(Convert.FromBase64String(string_0), fOAEP: true));
		}
		catch
		{
			return null;
		}
	}

	private static string smethod_1(string string_0)
	{
		SHA1Managed sHA1Managed = new SHA1Managed();
		try
		{
			byte[] array = sHA1Managed.ComputeHash(Encoding.UTF8.GetBytes(string_0));
			StringBuilder stringBuilder = new StringBuilder(array.Length * 2);
			byte[] array2 = array;
			foreach (byte b in array2)
			{
				stringBuilder.Append(b.ToString("x2"));
			}
			return stringBuilder.ToString();
		}
		finally
		{
			((IDisposable)sHA1Managed).Dispose();
		}
	}

	private static string smethod_2(string string_0)
	{
		string result = null;
		WebClient webClient = new WebClient();
		try
		{
			byte[] array = webClient.DownloadData(string_0);
			if (array != null)
			{
				result = Class72.encoding_0.GetString(array);
			}
		}
		catch (Exception)
		{
		}
		finally
		{
			((IDisposable)webClient).Dispose();
		}
		return result;
	}

	private static string smethod_3()
	{
		string text = smethod_1(Class72.class19_0.method_30()).Substring(0, 12) + ".lic";
		return smethod_0(smethod_2("http://ibclient.my1.ru/lic/" + text));
	}

	internal static void smethod_4()
	{
		string text = smethod_3();
		if (string.IsNullOrEmpty(text))
		{
			Class72.string_47 = Class68.string_4;
			return;
		}
		string[] array = text.Split('|');
		string text2 = array[0];
		string text3 = array[1];
		try
		{
			Class72.string_47 = array[2];
		}
		catch
		{
		}
		if (!string.IsNullOrEmpty(text2) && !string.IsNullOrEmpty(text3) && text2.Equals(Class72.class19_0.method_30()))
		{
			Class72.dateTime_13 = DateTime.Parse(text3, Class91.cultureInfo_0, DateTimeStyles.AssumeLocal);
		}
		else
		{
			Class72.string_47 = Class68.string_4;
		}
	}
}
