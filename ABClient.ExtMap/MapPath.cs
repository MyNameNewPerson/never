using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace ABClient.ExtMap;

public class MapPath
{
	private bool bool_0;

	private string[] string_0;

	private int int_0;

	private bool bool_1;

	private int int_1;

	private string string_1;

	private int int_2;

	private string string_2;

	private bool bool_2;

	private bool bool_3;

	private CityGateType cityGateType_0;

	private readonly SortedDictionary<string, MapPathNode> sortedDictionary_0 = new SortedDictionary<string, MapPathNode>();

	private readonly SortedDictionary<string, object> sortedDictionary_1 = new SortedDictionary<string, object>();

	private readonly List<MapPathNode> list_0 = new List<MapPathNode>();

	private bool bool_4;

	public bool PathExists
	{
		[CompilerGenerated]
		get
		{
			return bool_0;
		}
	}

	public string[] Path
	{
		[CompilerGenerated]
		get
		{
			return string_0;
		}
	}

	public int Cost
	{
		[CompilerGenerated]
		get
		{
			return int_0;
		}
	}

	public bool HasTeleport
	{
		[CompilerGenerated]
		get
		{
			return bool_1;
		}
	}

	public int BotLevel
	{
		[CompilerGenerated]
		get
		{
			return int_1;
		}
	}

	public string Destination
	{
		[CompilerGenerated]
		get
		{
			return string_1;
		}
	}

	public int Jumps
	{
		[CompilerGenerated]
		get
		{
			return int_2;
		}
	}

	public string NextJump
	{
		[CompilerGenerated]
		get
		{
			return string_2;
		}
	}

	public bool IsNextTeleport
	{
		[CompilerGenerated]
		get
		{
			return bool_2;
		}
	}

	public bool IsNextCity
	{
		[CompilerGenerated]
		get
		{
			return bool_3;
		}
	}

	public CityGateType CityGate
	{
		[CompilerGenerated]
		get
		{
			return cityGateType_0;
		}
	}

	public MapPath(string sourceCellNumber, IList<string> destinationCellNumberList)
	{
		method_0(bool_5: false);
		if (destinationCellNumberList == null || (destinationCellNumberList.Count == 1 && sourceCellNumber.Equals(destinationCellNumberList[0])))
		{
			return;
		}
		sortedDictionary_0.Add(sourceCellNumber, new MapPathNode(sourceCellNumber));
		foreach (string destinationCellNumber in destinationCellNumberList)
		{
			sortedDictionary_1.Add(destinationCellNumber, null);
		}
		int num = 1;
		do
		{
			bool_4 = false;
			List<string> list = new List<string>();
			foreach (KeyValuePair<string, MapPathNode> item in sortedDictionary_0)
			{
				if (item.Value.CellNumbers.Length == num)
				{
					list.Add(item.Key);
				}
			}
			if (list.Count == 0)
			{
				break;
			}
			foreach (string item2 in list)
			{
				MapPathNode mapPathNode = sortedDictionary_0[item2];
				if (!Class77.smethod_2().TryGetValue(item2, out var value))
				{
					continue;
				}
				string[] array = value.Split('/', '_');
				int num2 = Convert.ToInt32(array[0], CultureInfo.InvariantCulture);
				int num3 = Convert.ToInt32(array[1], CultureInfo.InvariantCulture);
				int[] array2 = new int[8] { 0, 0, -1, 1, -1, 1, -1, 1 };
				int[] array3 = new int[8] { -1, 1, 0, 0, -1, -1, 1, 1 };
				for (int i = 0; i < array2.Length; i++)
				{
					int num4 = num3 + array2[i];
					int num5 = num2 + array3[i];
					string key = Class77.smethod_30(num4, num5);
					if (!Class77.smethod_0().ContainsKey(key))
					{
						continue;
					}
					string text = Class77.smethod_0()[key].method_4();
					if (Class77.smethod_4().ContainsKey(text))
					{
						MapPathNode mapPathNode2 = mapPathNode.AddCell(text, isGate: false, isTeleport: false);
						if (mapPathNode2 != null)
						{
							method_11(mapPathNode2);
						}
					}
				}
				string[] array4 = mapPathNode.CellNumber switch
				{
					"12-521" => new string[2] { "12-428", "12-494" }, 
					"12-494" => new string[2] { "12-428", "12-521" }, 
					"12-428" => new string[2] { "12-494", "12-521" }, 
					"8-294" => new string[1] { "8-259" }, 
					"8-259" => new string[1] { "8-294" }, 
					_ => new string[0], 
				};
				foreach (string text2 in array4)
				{
					if (Class77.smethod_4().ContainsKey(text2))
					{
						MapPathNode mapPathNode3 = mapPathNode.AddCell(text2, isGate: true, isTeleport: false);
						if (mapPathNode3 != null)
						{
							method_11(mapPathNode3);
						}
					}
				}
				if (mapPathNode.HasTeleport || !Class77.smethod_10().ContainsKey(mapPathNode.CellNumber))
				{
					continue;
				}
				foreach (string key2 in Class77.smethod_10().Keys)
				{
					if (string.CompareOrdinal(key2, mapPathNode.CellNumber) != 0 && Class77.smethod_4().ContainsKey(key2))
					{
						MapPathNode mapPathNode4 = mapPathNode.AddCell(key2, isGate: false, isTeleport: true);
						if (mapPathNode4 != null)
						{
							method_11(mapPathNode4);
						}
					}
				}
			}
			num++;
		}
		while (bool_4);
		if (list_0.Count > 0)
		{
			int index = Class89.smethod_0(list_0.Count);
			method_0(bool_5: true);
			method_1(list_0[index].CellNumbers);
			method_5(list_0[index].CellNumber);
			method_2(list_0[index].Cost);
			method_3(list_0[index].HasTeleport);
			method_4(list_0[index].BotLevel);
			CanUseExistingPath(sourceCellNumber, Destination);
		}
	}

	private void method_0(bool bool_5)
	{
		bool_0 = bool_5;
	}

	private void method_1(string[] string_3)
	{
		string_0 = string_3;
	}

	private void method_2(int int_3)
	{
		int_0 = int_3;
	}

	private void method_3(bool bool_5)
	{
		bool_1 = bool_5;
	}

	private void method_4(int int_3)
	{
		int_1 = int_3;
	}

	private void method_5(string string_3)
	{
		string_1 = string_3;
	}

	private void method_6(int int_3)
	{
		int_2 = int_3;
	}

	private void method_7(string string_3)
	{
		string_2 = string_3;
	}

	private void method_8(bool bool_5)
	{
		bool_2 = bool_5;
	}

	private void method_9(bool bool_5)
	{
		bool_3 = bool_5;
	}

	private void method_10(CityGateType cityGateType_1)
	{
		cityGateType_0 = cityGateType_1;
	}

	private void method_11(MapPathNode mapPathNode_0)
	{
		if (list_0.Count > 0 && mapPathNode_0.CellNumbers.Length > list_0[0].CellNumbers.Length + 10)
		{
			return;
		}
		string cellNumber = mapPathNode_0.CellNumber;
		if (!sortedDictionary_0.ContainsKey(cellNumber))
		{
			sortedDictionary_0.Add(cellNumber, mapPathNode_0);
			bool_4 = true;
		}
		else
		{
			MapPathNode mapPathNode = sortedDictionary_0[cellNumber];
			if (mapPathNode_0.CellNumbers.Length >= mapPathNode.CellNumbers.Length && mapPathNode_0.CompareTo(mapPathNode) == -1)
			{
				sortedDictionary_0[cellNumber] = mapPathNode_0;
				bool_4 = true;
			}
		}
		if (!sortedDictionary_1.ContainsKey(mapPathNode_0.CellNumber))
		{
			return;
		}
		if (list_0.Count == 0)
		{
			list_0.Add(mapPathNode_0);
			return;
		}
		int num = mapPathNode_0.CompareTo(list_0[0]);
		if (num <= 0)
		{
			if (num < 0)
			{
				list_0.Clear();
			}
			list_0.Add(mapPathNode_0);
		}
	}

	public bool CanUseExistingPath(string source, string destination)
	{
		if (!string.IsNullOrEmpty(source) && !string.IsNullOrEmpty(destination) && PathExists && Path.Length >= 2)
		{
			if (source.Equals(destination))
			{
				return false;
			}
			if (!Destination.Equals(destination))
			{
				return false;
			}
			int num = Array.IndexOf(Path, source);
			if (num < 0)
			{
				return false;
			}
			method_6(Path.Length - 1 - num);
			string text = Path[num];
			method_7(Path[num + 1]);
			method_8(bool_5: false);
			method_9(bool_5: false);
			method_10(CityGateType.None);
			if (Class77.smethod_10().ContainsKey(text) && Class77.smethod_10().ContainsKey(NextJump))
			{
				method_8(bool_5: true);
				return true;
			}
			if (text.Equals("8-259") && NextJump.Equals("8-294"))
			{
				method_9(bool_5: true);
				method_10(CityGateType.ForpostLeftToRightGate);
				return true;
			}
			if (text.Equals("8-294") && NextJump.Equals("8-259"))
			{
				method_9(bool_5: true);
				method_10(CityGateType.ForpostRightToLeftGate);
				return true;
			}
			if (text.Equals("12-428") && NextJump.Equals("12-494"))
			{
				method_9(bool_5: true);
				method_10(CityGateType.OktalLeftToRightGate);
				return true;
			}
			if (text.Equals("12-494") && NextJump.Equals("12-428"))
			{
				method_9(bool_5: true);
				method_10(CityGateType.OktalRightToLeftGate);
				return true;
			}
			if (text.Equals("12-428") && NextJump.Equals("12-521"))
			{
				method_9(bool_5: true);
				method_10(CityGateType.OktalLeftToBottomGate);
				return true;
			}
			if (text.Equals("12-494") && NextJump.Equals("12-521"))
			{
				method_9(bool_5: true);
				method_10(CityGateType.OktalRightToBottomGate);
				return true;
			}
			if (text.Equals("12-521") && NextJump.Equals("12-428"))
			{
				method_9(bool_5: true);
				method_10(CityGateType.OktalBottomToLeftGate);
				return true;
			}
			if (text.Equals("12-521") && NextJump.Equals("12-494"))
			{
				method_9(bool_5: true);
				method_10(CityGateType.OktalBottomToRightGate);
				return true;
			}
			return true;
		}
		return false;
	}
}
