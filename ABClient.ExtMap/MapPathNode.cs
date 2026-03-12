using System;

namespace ABClient.ExtMap;

[Serializable]
public class MapPathNode : IComparable
{
	public string[] CellNumbers { get; }

	public int[] Costs { get; }

	public bool HasTeleport { get; }

	public int BotLevel { get; }

	public int Jumps { get; }

	public string CellNumber
	{
		get
		{
			if (CellNumbers.Length != 0)
			{
				return CellNumbers[CellNumbers.Length - 1];
			}
			return null;
		}
	}

	public int Cost
	{
		get
		{
			if (Costs.Length != 0)
			{
				return Costs[Costs.Length - 1];
			}
			return 0;
		}
	}

	private MapPathNode()
	{
	}

	public MapPathNode(string sourceCellNumber)
	{
		method_0(new string[1] { sourceCellNumber });
		method_2(bool_0: false);
		method_3(0);
		method_4(0);
		if (Class77.smethod_4().TryGetValue(sourceCellNumber, out var value))
		{
			method_1(new int[1]);
			method_3(value.MaxBotLevel);
		}
	}

	private void method_0(string[] string_0)
	{
		CellNumbers = string_0;
	}

	private void method_1(int[] int_0)
	{
		Costs = int_0;
	}

	private void method_2(bool bool_0)
	{
		HasTeleport = bool_0;
	}

	private void method_3(int int_0)
	{
		BotLevel = int_0;
	}

	private void method_4(int int_0)
	{
		Jumps = int_0;
	}

	public MapPathNode AddCell(string cellNumber, bool isGate, bool isTeleport)
	{
		if (Array.IndexOf(CellNumbers, cellNumber) >= 0)
		{
			return null;
		}
		int num = Cost;
		int num2 = Jumps;
		Cell value;
		if (!isGate && !isTeleport)
		{
			if (!Class77.smethod_4().TryGetValue(CellNumber, out value))
			{
				return null;
			}
			num += value.Cost;
			num2++;
		}
		bool bool_ = HasTeleport || isTeleport;
		if (!Class77.smethod_4().TryGetValue(cellNumber, out value))
		{
			return null;
		}
		int int_ = Math.Max(BotLevel, value.MaxBotLevel);
		MapPathNode mapPathNode = new MapPathNode();
		mapPathNode.method_0(new string[CellNumbers.Length + 1]);
		mapPathNode.method_1(new int[Costs.Length + 1]);
		MapPathNode mapPathNode2 = mapPathNode;
		Array.Copy(CellNumbers, mapPathNode2.CellNumbers, CellNumbers.Length);
		Array.Copy(Costs, mapPathNode2.Costs, Costs.Length);
		mapPathNode2.CellNumbers[CellNumbers.Length] = cellNumber;
		mapPathNode2.Costs[Costs.Length] = num;
		mapPathNode2.method_2(bool_);
		mapPathNode2.method_3(int_);
		mapPathNode2.method_4(num2);
		return mapPathNode2;
	}

	public int CompareTo(object obj)
	{
		MapPathNode mapPathNode = (MapPathNode)obj;
		int num = Cost.CompareTo(mapPathNode.Cost);
		if (num != 0)
		{
			return num;
		}
		num = CellNumbers.Length.CompareTo(mapPathNode.CellNumbers.Length);
		if (num != 0)
		{
			return num;
		}
		num = BotLevel.CompareTo(mapPathNode.BotLevel);
		if (num != 0)
		{
			return num;
		}
		return HasTeleport.CompareTo(mapPathNode.HasTeleport);
	}
}
