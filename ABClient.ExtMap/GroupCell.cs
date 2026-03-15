using System;
using System.Collections.Generic;
using System.Text;

namespace ABClient.ExtMap;

public class GroupCell : IComparable
{
	public readonly string Name;

	public readonly int Level;

	public readonly SortedList<string, object> Cells;

	public GroupCell(string name)
	{
		Name = name;
		Level = -1;
		Cells = new SortedList<string, object>();
	}

	public GroupCell(string name, int level)
	{
		Name = name;
		Level = level;
		Cells = new SortedList<string, object>();
	}

	public override string ToString()
	{
		if (Level >= 0)
		{
			return $"{Name} {Level:D2}";
		}
		return Name;
	}

	public int CompareTo(object obj)
	{
		GroupCell groupCell = (GroupCell)obj;
		int num = string.Compare(Name, groupCell.Name, StringComparison.CurrentCultureIgnoreCase);
		if (num != 0)
		{
			return num;
		}
		return Level.CompareTo(groupCell.Level);
	}

	public void AddCell(string cellNumber)
	{
		if (!Cells.ContainsKey(cellNumber))
		{
			Cells.Add(cellNumber, null);
		}
	}

	public string GetCells()
	{
		StringBuilder stringBuilder = new StringBuilder();
		foreach (string key in Cells.Keys)
		{
			if (stringBuilder.Length > 0)
			{
				stringBuilder.Append('|');
			}
			stringBuilder.Append(key);
		}
		return stringBuilder.ToString();
	}
}
