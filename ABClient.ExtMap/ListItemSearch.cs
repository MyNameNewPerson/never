using System.Runtime.CompilerServices;

namespace ABClient.ExtMap;

public class ListItemSearch
{
	private string string_0;

	private int int_0;

	private string string_1;

	public string RegNum
	{
		[CompilerGenerated]
		get
		{
			return string_0;
		}
	}

	public int Jumps
	{
		[CompilerGenerated]
		get
		{
			return int_0;
		}
	}

	public string Html
	{
		[CompilerGenerated]
		get
		{
			return string_1;
		}
	}

	public ListItemSearch(string regnum, int jumps, string html)
	{
		method_0(regnum);
		method_1(jumps);
		method_2(html);
	}

	private void method_0(string string_2)
	{
		string_0 = string_2;
	}

	private void method_1(int int_1)
	{
		int_0 = int_1;
	}

	private void method_2(string string_2)
	{
		string_1 = string_2;
	}

	public override string ToString()
	{
		return RegNum + " (шагов: " + Jumps + ")";
	}
}
