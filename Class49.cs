using System;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Text;

internal static class Class49
{
	internal static IPEndPoint smethod_0(string string_0)
	{
		if (string_0 != null && !string.IsNullOrEmpty(string_0.Trim()))
		{
			if (string_0.IndexOf(';') > -1)
			{
				string_0 = string_0.Substring(0, string_0.IndexOf(';'));
			}
			try
			{
				int int_ = 80;
				smethod_4(string_0, out var string_1, ref int_);
				return new IPEndPoint(Class34.smethod_0(string_1, bool_0: true), int_);
			}
			catch (Exception)
			{
				return null;
			}
		}
		return null;
	}

	internal static IPAddress smethod_1(string string_0)
	{
		int num = 0;
		while (true)
		{
			if (num < string_0.Length)
			{
				if (string_0[num] != '.' && string_0[num] != ':' && (string_0[num] < '0' || string_0[num] > '9') && (string_0[num] < 'A' || string_0[num] > 'F') && (string_0[num] < 'a' || string_0[num] > 'f'))
				{
					break;
				}
				num++;
				continue;
			}
			try
			{
				return IPAddress.Parse(string_0);
			}
			catch
			{
				return null;
			}
		}
		return null;
	}

	internal static bool smethod_2(MemoryStream memoryStream_0, int int_0)
	{
		int num = int_0;
		while (true)
		{
			if (num < memoryStream_0.Length)
			{
				memoryStream_0.Position = num;
				byte[] array = new byte[32];
				memoryStream_0.Read(array, 0, array.Length);
				string text = Encoding.ASCII.GetString(array);
				int num2 = text.IndexOf("\r\n", StringComparison.Ordinal);
				if (num2 <= -1)
				{
					break;
				}
				num += num2 + 2;
				text = text.Substring(0, num2);
				num2 = text.IndexOf(';');
				if (num2 > -1)
				{
					text = text.Substring(0, num2);
				}
				int result = 0;
				if (int.TryParse(text, NumberStyles.HexNumber, NumberFormatInfo.InvariantInfo, out result))
				{
					if (result != 0)
					{
						num += result + 2;
						continue;
					}
					memoryStream_0.Position = memoryStream_0.Length;
					return true;
				}
				return true;
			}
			memoryStream_0.Position = memoryStream_0.Length;
			return false;
		}
		return false;
	}

	internal static bool smethod_3(string string_0, string string_1, int int_0)
	{
		if (string.Equals(string_0, string_1, StringComparison.OrdinalIgnoreCase))
		{
			return true;
		}
		if (!string_0.Contains(":"))
		{
			string_0 = string.Format(CultureInfo.InvariantCulture, "{0}:{1}", new object[2] { string_0, int_0 });
		}
		if (!string_1.Contains(":"))
		{
			string_1 = string.Format(CultureInfo.InvariantCulture, "{0}:{1}", new object[2] { string_1, int_0 });
		}
		return string.Equals(string_0, string_1, StringComparison.OrdinalIgnoreCase);
	}

	internal static void smethod_4(string string_0, out string string_1, ref int int_0)
	{
		int num = string_0.LastIndexOf(':');
		if (num > -1 && num > string_0.LastIndexOf(']'))
		{
			if (!int.TryParse(string_0.Substring(num + 1), NumberStyles.Integer, NumberFormatInfo.InvariantInfo, out int_0))
			{
				int_0 = -1;
			}
			string_1 = string_0.Substring(0, num);
		}
		else
		{
			string_1 = string_0;
		}
		if (string_1.StartsWith("[", StringComparison.Ordinal) && string_1.EndsWith("]", StringComparison.Ordinal))
		{
			string_1 = string_1.Substring(1, string_1.Length - 2);
		}
	}

	internal static byte[] smethod_5(byte[] byte_0)
	{
		if (byte_0 != null && byte_0.Length != 0)
		{
			MemoryStream memoryStream = new MemoryStream(byte_0.Length);
			try
			{
				int num = 0;
				bool flag = false;
				byte[] array = new byte[32];
				while (!flag && num < byte_0.Length - 3)
				{
					Array.Copy(byte_0, num, array, 0, Math.Min(array.Length, byte_0.Length - num));
					string text = Class72.encoding_0.GetString(array, 0, Math.Min(array.Length, byte_0.Length - num));
					int num2 = text.IndexOf("\r\n", StringComparison.Ordinal);
					if (num2 > -1)
					{
						num += num2 + 2;
						text = text.Substring(0, num2);
						num2 = text.IndexOf(';');
						if (num2 > -1)
						{
							text = text.Substring(0, num2);
						}
						int num3 = int.Parse(text, NumberStyles.HexNumber);
						if (num3 == 0)
						{
							flag = true;
							continue;
						}
						if (byte_0.Length >= num3 + num)
						{
							memoryStream.Write(byte_0, num, num3);
							num += num3 + 2;
							continue;
						}
						return new byte[0];
					}
					return byte_0;
				}
				byte[] array2 = new byte[memoryStream.Length];
				memoryStream.Position = 0L;
				memoryStream.Read(array2, 0, (int)memoryStream.Length);
				return array2;
			}
			finally
			{
				((IDisposable)memoryStream).Dispose();
			}
		}
		return new byte[0];
	}

	internal static byte[] smethod_6(byte[] byte_0)
	{
		if (byte_0 != null && byte_0.Length != 0)
		{
			try
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
			catch (Exception)
			{
				return null;
			}
		}
		return null;
	}

	internal static byte[] smethod_7(byte[] byte_0)
	{
		if (byte_0 != null && byte_0.Length != 0)
		{
			try
			{
				MemoryStream memoryStream = new MemoryStream(byte_0);
				try
				{
					MemoryStream memoryStream2 = new MemoryStream();
					try
					{
						DeflateStream deflateStream = new DeflateStream(memoryStream, CompressionMode.Decompress);
						try
						{
							byte[] array = new byte[32768];
							int count;
							while ((count = deflateStream.Read(array, 0, array.Length)) > 0)
							{
								memoryStream2.Write(array, 0, count);
							}
						}
						finally
						{
							((IDisposable)deflateStream).Dispose();
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
			catch (Exception)
			{
				return null;
			}
		}
		return null;
	}
}
