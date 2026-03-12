using System;
using System.Runtime.CompilerServices;

namespace ABClient;

public class ChatUser
{
	private string string_0;

	private string string_1;

	private string string_2;

	private string string_3;

	private DateTime dateTime_0;

	public string Nick
	{
		[CompilerGenerated]
		get
		{
			return string_0;
		}
	}

	public string Sign
	{
		[CompilerGenerated]
		get
		{
			return string_1;
		}
	}

	public string Status
	{
		[CompilerGenerated]
		get
		{
			return string_2;
		}
	}

	public string Level
	{
		[CompilerGenerated]
		get
		{
			return string_3;
		}
	}

	public DateTime LastUpdated
	{
		[CompilerGenerated]
		get
		{
			return dateTime_0;
		}
	}

	public ChatUser(string nick, string level, string sign, string status)
	{
		method_0(nick);
		method_1(sign.Equals("none", StringComparison.OrdinalIgnoreCase) ? string.Empty : sign);
		method_2(status);
		method_3(level);
		method_4(DateTime.Now);
	}

	private void method_0(string string_4)
	{
		string_0 = string_4;
	}

	private void method_1(string string_4)
	{
		string_1 = string_4;
	}

	private void method_2(string string_4)
	{
		string_2 = string_4;
	}

	private void method_3(string string_4)
	{
		string_3 = string_4;
	}

	private void method_4(DateTime dateTime_1)
	{
		dateTime_0 = dateTime_1;
	}
}
