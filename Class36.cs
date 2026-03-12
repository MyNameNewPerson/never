using System;
using System.Collections;
using System.Globalization;
using System.IO;
using System.Text;

internal sealed class Class36 : Class35, ICloneable
{
	private string string_1;

	private byte[] byte_0;

	private string string_2;

	internal Class36()
	{
		method_15(string.Empty);
		string_1 = string.Empty;
	}

	internal string method_14()
	{
		return string_2;
	}

	internal void method_15(string string_3)
	{
		string_2 = string_3;
	}

	internal void method_16(byte[] byte_1)
	{
		byte_0 = (byte[])byte_1.Clone();
		string_1 = Class72.encoding_0.GetString(byte_0);
	}

	internal string method_17()
	{
		return string_1;
	}

	internal void method_18(string string_3)
	{
		string_1 = string_3;
		byte_0 = Class72.encoding_0.GetBytes(string_1);
	}

	public object Clone()
	{
		Class36 @class = (Class36)MemberwiseClone();
		@class.method_3(new ArrayList(method_2().Count));
		foreach (Class38 item in method_2())
		{
			@class.method_2().Add(item.Clone());
		}
		return @class;
	}

	public override string ToString()
	{
		return method_21(bool_0: true, bool_1: false, bool_2: false);
	}

	internal byte[] method_19(bool bool_0, bool bool_1, bool bool_2)
	{
		if (!bool_0)
		{
			return Class72.encoding_0.GetBytes(method_21(bool_0: false, bool_1, bool_2: false));
		}
		MemoryStream memoryStream = new MemoryStream();
		byte[] bytes = Encoding.ASCII.GetBytes(method_14() + " ");
		byte[] bytes2 = Encoding.ASCII.GetBytes(" " + method_0() + "\r\n");
		byte[] bytes3 = Class72.encoding_0.GetBytes(method_21(bool_0: false, bool_1, bool_2: false));
		memoryStream.Write(bytes, 0, bytes.Length);
		if (bool_2 && !string.Equals("CONNECT", method_14(), StringComparison.OrdinalIgnoreCase))
		{
			byte[] bytes4 = Class72.encoding_0.GetBytes("http://" + method_5("Host"));
			memoryStream.Write(bytes4, 0, bytes4.Length);
		}
		memoryStream.Write(byte_0, 0, byte_0.Length);
		memoryStream.Write(bytes2, 0, bytes2.Length);
		memoryStream.Write(bytes3, 0, bytes3.Length);
		return memoryStream.ToArray();
	}

	internal string method_20(bool bool_0, bool bool_1)
	{
		return method_21(bool_0, bool_1, bool_2: false);
	}

	private string method_21(bool bool_0, bool bool_1, bool bool_2)
	{
		StringBuilder stringBuilder = new StringBuilder(256);
		if (bool_0)
		{
			if (bool_2)
			{
				stringBuilder.AppendFormat(CultureInfo.InvariantCulture, "{0} http://{1}{2} {3}\r\n", method_14(), method_5("Host"), method_17(), method_0());
			}
			else
			{
				stringBuilder.AppendFormat(CultureInfo.InvariantCulture, "{0} {1} {2}\r\n", new object[3]
				{
					method_14(),
					method_17(),
					method_0()
				});
			}
		}
		for (int i = 0; i < method_2().Count; i++)
		{
			stringBuilder.Append(((Class38)method_2()[i]).method_0() + ": " + ((Class38)method_2()[i]).method_2() + "\r\n");
		}
		if (bool_1)
		{
			stringBuilder.Append("\r\n");
		}
		return stringBuilder.ToString();
	}
}
