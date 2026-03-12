using System.Runtime.CompilerServices;

namespace ABClient.Lez;

public class LezBotsClass
{
	private readonly int int_0;

	private readonly string string_0;

	private readonly string string_1;

	public int Id
	{
		[CompilerGenerated]
		get
		{
			return int_0;
		}
	}

	public string Name
	{
		[CompilerGenerated]
		get
		{
			return string_0;
		}
	}

	public string Plural
	{
		[CompilerGenerated]
		get
		{
			return string_1;
		}
	}

	public LezBotsClass(int id, string name, string plural)
	{
		int_0 = id;
		string_0 = name;
		string_1 = plural;
	}
}
