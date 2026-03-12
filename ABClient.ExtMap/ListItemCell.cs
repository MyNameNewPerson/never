using System.Runtime.CompilerServices;

namespace ABClient.ExtMap;

public class ListItemCell
{
	private string string_0;

	private string string_1;

	public string Description
	{
		[CompilerGenerated]
		get
		{
			return string_0;
		}
	}

	public string RegNum
	{
		[CompilerGenerated]
		get
		{
			return string_1;
		}
	}

	public ListItemCell(string adescription, string aregnum)
	{
		method_0(adescription);
		method_1(aregnum);
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
