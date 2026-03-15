using System.Runtime.CompilerServices;

namespace ABClient.ExtMap;

public class ListItemPosition
{
	private string string_0;

	private string string_1;

	public string Code
	{
		[CompilerGenerated]
		get
		{
			return string_0;
		}
	}

	public string Name
	{
		[CompilerGenerated]
		get
		{
			return string_1;
		}
	}

	public ListItemPosition(string name, string code)
	{
		method_1(name);
		method_0(code);
	}

	private void method_0(string string_2)
	{
		string_0 = string_2;
	}

	private void method_1(string string_2)
	{
		string_1 = string_2;
	}
}
