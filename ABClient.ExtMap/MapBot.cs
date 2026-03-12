using System.Runtime.CompilerServices;

namespace ABClient.ExtMap;

public class MapBot
{
	private string string_0;

	private int int_0;

	private int int_1;

	private string string_1;

	private string string_2;

	public string Name
	{
		[CompilerGenerated]
		get
		{
			return string_0;
		}
	}

	public int MinLevel
	{
		[CompilerGenerated]
		get
		{
			return int_0;
		}
	}

	public int MaxLevel
	{
		[CompilerGenerated]
		get
		{
			return int_1;
		}
	}

	public string String_0
	{
		[CompilerGenerated]
		get
		{
			return string_1;
		}
	}

	public string String_1
	{
		[CompilerGenerated]
		get
		{
			return string_2;
		}
	}

	public MapBot(string name, int minLevel, int maxLevel, string string_3, string string_4)
	{
		method_0(name);
		method_1(minLevel);
		method_2(maxLevel);
		method_3(string_3);
		method_4(string_4);
	}

	private void method_0(string string_3)
	{
		string_0 = string_3;
	}

	private void method_1(int int_2)
	{
		int_0 = int_2;
	}

	private void method_2(int int_2)
	{
		int_1 = int_2;
	}

	private void method_3(string string_3)
	{
		string_1 = string_3;
	}

	private void method_4(string string_3)
	{
		string_2 = string_3;
	}
}
