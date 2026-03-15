using System;
using System.IO;
using System.Security.Cryptography;

internal static class Class87
{
	internal static string smethod_0(string string_0, string string_1)
	{
		if (string_0 == null)
		{
			throw new ArgumentNullException("str");
		}
		if (string_1 == null)
		{
			throw new ArgumentNullException("password");
		}
		return Convert.ToBase64String(smethod_2(Class91.encoding_0.GetBytes(string_0), string_1));
	}

	internal static string smethod_1(string string_0, string string_1)
	{
		if (string_0 == null)
		{
			throw new ArgumentNullException("str");
		}
		if (string_1 == null)
		{
			throw new ArgumentNullException("password");
		}
		byte[] bytes = smethod_3(Convert.FromBase64String(string_0), string_1);
		return Class91.encoding_0.GetString(bytes);
	}

	internal static byte[] smethod_2(byte[] byte_0, string string_0)
	{
		if (byte_0 == null)
		{
			throw new ArgumentNullException("array");
		}
		if (string_0 == null)
		{
			throw new ArgumentNullException("password");
		}
		Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(string_0, Class68.byte_0);
		return smethod_5(byte_0, rfc2898DeriveBytes.GetBytes(16), rfc2898DeriveBytes.GetBytes(8));
	}

	internal static byte[] smethod_3(byte[] byte_0, string string_0)
	{
		try
		{
			Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(string_0, Class68.byte_0);
			return smethod_6(byte_0, rfc2898DeriveBytes.GetBytes(16), rfc2898DeriveBytes.GetBytes(8));
		}
		catch (CryptographicException)
		{
			return null;
		}
	}

	internal static string smethod_4(string string_0)
	{
		if (string_0 == null)
		{
			throw new ArgumentNullException("password");
		}
		byte[] bytes = Class91.encoding_0.GetBytes(Class68.string_5 + string_0);
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		try
		{
			return Convert.ToBase64String(mD5CryptoServiceProvider.ComputeHash(bytes));
		}
		finally
		{
			((IDisposable)mD5CryptoServiceProvider).Dispose();
		}
	}

	private static byte[] smethod_5(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		if (byte_0 == null)
		{
			throw new ArgumentNullException("clearData");
		}
		if (byte_1 == null)
		{
			throw new ArgumentNullException("key");
		}
		if (byte_2 == null)
		{
			throw new ArgumentNullException("iv");
		}
		using MemoryStream memoryStream = new MemoryStream();
		using (TripleDES tripleDES = TripleDES.Create())
		{
			tripleDES.Key = byte_1;
			tripleDES.IV = byte_2;
			CryptoStream cryptoStream = new CryptoStream(memoryStream, tripleDES.CreateEncryptor(), CryptoStreamMode.Write);
			try
			{
				cryptoStream.Write(byte_0, 0, byte_0.Length);
			}
			finally
			{
				((IDisposable)cryptoStream).Dispose();
			}
		}
		return memoryStream.ToArray();
	}

	private static byte[] smethod_6(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		if (byte_0 == null)
		{
			throw new ArgumentNullException("cipherData");
		}
		if (byte_1 == null)
		{
			throw new ArgumentNullException("key");
		}
		if (byte_2 == null)
		{
			throw new ArgumentNullException("iv");
		}
		using MemoryStream memoryStream = new MemoryStream();
		using (TripleDES tripleDES = TripleDES.Create())
		{
			tripleDES.Key = byte_1;
			tripleDES.IV = byte_2;
			CryptoStream cryptoStream = new CryptoStream(memoryStream, tripleDES.CreateDecryptor(), CryptoStreamMode.Write);
			try
			{
				cryptoStream.Write(byte_0, 0, byte_0.Length);
			}
			finally
			{
				((IDisposable)cryptoStream).Dispose();
			}
		}
		return memoryStream.ToArray();
	}
}
