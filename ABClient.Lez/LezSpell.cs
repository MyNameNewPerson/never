namespace ABClient.Lez;

public class LezSpell
{
	private readonly int int_0;

	public readonly string Name;

	public LezSpell(int id, string name)
	{
		int_0 = id;
		Name = name;
	}

	public static bool IsPhBlock(int code)
	{
		if (code >= 4)
		{
			return code <= 28;
		}
		return false;
	}

	public static bool IsMagBlock(int code)
	{
		if (code >= 29)
		{
			return code <= 31;
		}
		return false;
	}

	public static bool IsPhHit(int code)
	{
		if (code >= 0)
		{
			return code <= 1;
		}
		return false;
	}

	public static bool IsMagHit(int code)
	{
		if (code >= 2)
		{
			return code <= 3;
		}
		return false;
	}

	public static bool IsScrollHit(int code)
	{
		if (code != 277)
		{
			return code == 338;
		}
		return true;
	}
}
