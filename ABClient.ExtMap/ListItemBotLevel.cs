using System.Runtime.CompilerServices;

namespace ABClient.ExtMap;

public class ListItemBotLevel
{
	private int int_0;

	private string string_0;

	public int BotLevelValue
	{
		[CompilerGenerated]
		get
		{
			return int_0;
		}
	}

	public string BotLevel
	{
		[CompilerGenerated]
		get
		{
			return string_0;
		}
	}

	public ListItemBotLevel(string level, int levelvalue)
	{
		method_1(level);
		method_0(levelvalue);
	}

	private void method_0(int int_1)
	{
		int_0 = int_1;
	}

	private void method_1(string string_1)
	{
		string_0 = string_1;
	}
}
