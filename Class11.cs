using System;
using System.IO;
using System.IO.Compression;
using System.Text;

internal static class Class11
{
	public static byte[] smethod_0(byte[] byte_0)
	{
		MemoryStream memoryStream = new MemoryStream();
		try
		{
			GZipStream gZipStream = new GZipStream(memoryStream, CompressionMode.Compress);
			try
			{
				gZipStream.Write(byte_0, 0, byte_0.Length);
			}
			finally
			{
				((IDisposable)gZipStream).Dispose();
			}
			return memoryStream.ToArray();
		}
		finally
		{
			((IDisposable)memoryStream).Dispose();
		}
	}

	public static byte[] smethod_1(byte[] byte_0)
	{
		MemoryStream memoryStream = new MemoryStream(byte_0);
		try
		{
			MemoryStream memoryStream2 = new MemoryStream();
			try
			{
				GZipStream gZipStream = new GZipStream(memoryStream, CompressionMode.Decompress);
				try
				{
					byte[] array = new byte[32768];
					int count;
					while ((count = gZipStream.Read(array, 0, array.Length)) > 0)
					{
						memoryStream2.Write(array, 0, count);
					}
				}
				finally
				{
					((IDisposable)gZipStream).Dispose();
				}
				return memoryStream2.ToArray();
			}
			finally
			{
				((IDisposable)memoryStream2).Dispose();
			}
		}
		finally
		{
			((IDisposable)memoryStream).Dispose();
		}
	}

	public static string smethod_2(string string_0)
	{
		return Convert.ToBase64String(smethod_0(Encoding.UTF8.GetBytes(string_0)));
	}

	public static string smethod_3(string string_0)
	{
		byte[] bytes = smethod_1(Convert.FromBase64String(string_0));
		return Encoding.UTF8.GetString(bytes);
	}
}
