using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace ABClient.ExtMap;

public class Cell
{
	private int int_0;

	private int int_1;

	public readonly List<MapBot> MapBots = new List<MapBot>();

	private int int_2;

	private string string_0;

	private int int_3;

	private int int_4;

	private string string_1;

	private bool bool_0;

	private bool bool_1;

	private string string_2;

	private string string_3;

	private string string_4;

	private string string_5;

	private string string_6;

	public string CellNumber
	{
		get
		{
			return string.Format($"{int_0}-{int_1:D3}");
		}
		set
		{
			if (!string.IsNullOrEmpty(value))
			{
				string[] array = value.Split('-');
				if (array.Length == 2 && int.TryParse(array[0], out var result) && int.TryParse(array[1], out var result2))
				{
					int_0 = result;
					int_1 = result2;
				}
			}
		}
	}

	public bool HasFish
	{
		[CompilerGenerated]
		get
		{
			return bool_0;
		}
		[CompilerGenerated]
		set
		{
			bool_0 = value;
		}
	}

	public bool HasWater
	{
		[CompilerGenerated]
		get
		{
			return bool_1;
		}
		[CompilerGenerated]
		set
		{
			bool_1 = value;
		}
	}

	public string HerbGroup
	{
		[CompilerGenerated]
		get
		{
			return string_2;
		}
		[CompilerGenerated]
		set
		{
			string_2 = value;
		}
	}

	public string Name
	{
		[CompilerGenerated]
		get
		{
			return string_3;
		}
		[CompilerGenerated]
		set
		{
			string_3 = value;
		}
	}

	public string Updated
	{
		[CompilerGenerated]
		get
		{
			return string_4;
		}
		[CompilerGenerated]
		set
		{
			string_4 = value;
		}
	}

	public string NameUpdated
	{
		[CompilerGenerated]
		get
		{
			return string_5;
		}
		[CompilerGenerated]
		set
		{
			string_5 = value;
		}
	}

	public string CostUpdated
	{
		[CompilerGenerated]
		get
		{
			return string_6;
		}
		[CompilerGenerated]
		set
		{
			string_6 = value;
		}
	}

	public string Tooltip
	{
		get
		{
			if (Class77.smethod_6().ContainsKey(CellNumber))
			{
				return Class77.smethod_6()[CellNumber].Label;
			}
			return string_0;
		}
		set
		{
			string_0 = value;
		}
	}

	public int Cost
	{
		get
		{
			if (Class77.smethod_6().ContainsKey(CellNumber))
			{
				return Class77.smethod_6()[CellNumber].Cost;
			}
			return int_2;
		}
		set
		{
			int_2 = value;
		}
	}

	public string BotsTooltip => string_1;

	public int MinBotLevel => int_3;

	public int MaxBotLevel => int_4;

	public override string ToString()
	{
		return CellNumber;
	}

	public void AddMapBot(MapBot mapBot)
	{
		MapBots.Add(mapBot);
		StringBuilder stringBuilder = new StringBuilder();
		int_3 = 0;
		int_4 = 0;
		foreach (MapBot mapBot2 in MapBots)
		{
			if (stringBuilder.Length > 0)
			{
				stringBuilder.AppendLine();
				int_3 = Math.Min(int_3, mapBot2.MinLevel);
				int_4 = Math.Max(int_4, mapBot2.MaxLevel);
			}
			else
			{
				int_3 = mapBot2.MinLevel;
				int_4 = mapBot2.MaxLevel;
			}
			stringBuilder.AppendFormat("{0} {1}-{2}", mapBot2.Name, mapBot2.MinLevel, mapBot2.MaxLevel);
		}
		string_1 = stringBuilder.ToString();
	}

	public bool IsBot(string pattern)
	{
		foreach (MapBot mapBot in MapBots)
		{
			if (mapBot.Name.IndexOf(pattern, StringComparison.CurrentCultureIgnoreCase) >= 0)
			{
				return true;
			}
		}
		return false;
	}

	public static string NormalizeRegNum(string regnum)
	{
		if (string.IsNullOrEmpty(regnum))
		{
			return null;
		}
		string[] array = regnum.Split('-');
		if (array.Length != 2)
		{
			return null;
		}
		if (!int.TryParse(array[0], out var result))
		{
			return null;
		}
		if (!int.TryParse(array[1], out var result2))
		{
			return null;
		}
		return string.Format($"{result}-{result2:D3}");
	}
}
