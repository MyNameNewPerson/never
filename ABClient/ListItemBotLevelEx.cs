using System.Globalization;
using System.Runtime.CompilerServices;

namespace ABClient;

public class ListItemBotLevelEx
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

	public ListItemBotLevelEx(int levelvalue)
	{
		method_1(string.Format(CultureInfo.InvariantCulture, "[{0}] и слабее", new object[1] { levelvalue }));
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
