using System;
using System.Text;
using ABClient.Helpers;

namespace ABClient.Lez;

[Serializable]
public class LezNode : ICloneable, IComparable
{
	public readonly int[] HitOps = new int[4];

	public readonly int[] HitCodes = new int[4];

	public int BlockCombo;

	public int BlockOp;

	public int BlockCode;

	public readonly bool[] MagicFlags = new bool[18];

	public readonly int[] MagicCodes = new int[18];

	private int _zScroll;

	private int _zRestore;

	private int _zMag;

	private int _zHit;

	private int _zBlock;

	private int method_0()
	{
		int num = 0;
		int[] hitOps = HitOps;
		for (int i = 0; i < hitOps.Length; i++)
		{
			if (hitOps[i] > 0)
			{
				num++;
			}
		}
		return num;
	}

	private int method_1()
	{
		if (BlockOp <= 0)
		{
			return 0;
		}
		return 1;
	}

	private int method_2()
	{
		int num = 0;
		bool[] magicFlags = MagicFlags;
		for (int i = 0; i < magicFlags.Length; i++)
		{
			if (magicFlags[i])
			{
				num++;
			}
		}
		return num;
	}

	public bool IsValid()
	{
		int num = method_0();
		int num2 = method_1();
		int num3 = method_2();
		if ((num > 0 && num3 > 0) || (num2 > 0 && num3 > 0) || (num > 0 && num2 > 0))
		{
			return true;
		}
		return num > 1;
	}

	public int Od(int[] posod)
	{
		int num = 0;
		int num2 = method_0();
		if (num2 > 0)
		{
			for (int i = 0; i < 4; i++)
			{
				if (HitOps[i] > 0)
				{
					num += posod[HitCodes[i]];
				}
			}
			int[] array = new int[6] { 0, 0, 25, 75, 150, 250 };
			num += array[num2];
		}
		if (method_1() > 0)
		{
			num += posod[BlockCode];
		}
		if (method_2() > 0)
		{
			for (int j = 0; j < MagicFlags.Length; j++)
			{
				if (MagicFlags[j])
				{
					num += posod[MagicCodes[j]];
				}
			}
		}
		return num;
	}

	public int Mana(int[] posma)
	{
		int num = 0;
		if (method_0() > 0)
		{
			for (int i = 0; i < 4; i++)
			{
				if (HitOps[i] > 0)
				{
					num += posma[HitCodes[i]];
				}
			}
		}
		if (method_1() > 0)
		{
			num += posma[BlockCode];
		}
		if (method_2() > 0)
		{
			for (int j = 0; j < MagicFlags.Length; j++)
			{
				if (MagicFlags[j])
				{
					num += posma[MagicCodes[j]];
				}
			}
		}
		return num;
	}

	private string method_3()
	{
		return string.Format($"{_zScroll}.{_zRestore}.{_zMag:D2}.{_zBlock}.{_zHit:D2}");
	}

	public void AddHit(int combo, int op, int code)
	{
		HitOps[combo] = op;
		HitCodes[combo] = code;
		if (LezSpell.IsPhHit(code))
		{
			_zHit += ((code == 0) ? 3 : 4);
		}
		else if (LezSpell.IsMagHit(code))
		{
			_zHit += ((code == 2) ? 10 : 12);
		}
		else
		{
			_zHit += 25;
		}
	}

	public string PrintHit(int[] posod, int[] posma)
	{
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < 4; i++)
		{
			if (HitOps[i] == 0)
			{
				stringBuilder.Append("[.]");
			}
			else
			{
				stringBuilder.AppendFormat("[" + LezSpellCollection.Spells[HitCodes[i]].Name + "]");
			}
		}
		return string.Format($"Hit = '{stringBuilder}' Od = {Od(posod)} Mana = {Mana(posma)} Z = {method_3()}");
	}

	public void AddBlock(int combo, int op, int code)
	{
		BlockCombo = combo;
		BlockOp = op;
		BlockCode = code;
		if (LezSpell.IsPhBlock(code))
		{
			_zBlock = LezSpellCollection.Spells[code].Name.Split('+').Length;
		}
		else if (LezSpell.IsMagBlock(code))
		{
			switch (code)
			{
			case 29:
				_zBlock = 1;
				break;
			case 30:
				_zBlock = 2;
				break;
			case 31:
				_zBlock = 3;
				break;
			}
		}
		else
		{
			_zMag += 4;
		}
	}

	public string PrintBlock(int[] posod, int[] posma)
	{
		return string.Format($"Block = '{LezSpellCollection.Spells[BlockCode].Name}' BlockCombo = {BlockCombo} BlockOp = {BlockOp} BlockCode = {BlockCode} Od = {Od(posod)} Mana = {Mana(posma)} Z = {method_3()}");
	}

	public void AddMagic(int op, int code, int zmag, int zrestore, int zscroll)
	{
		MagicFlags[op] = true;
		MagicCodes[op] = code;
		_zScroll += zscroll;
		_zRestore += zrestore;
		_zMag += zmag;
	}

	public string PrintMagic(int[] posod, int[] posma)
	{
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < MagicFlags.Length; i++)
		{
			if (!MagicFlags[i])
			{
				stringBuilder.Append("[.]");
			}
			else
			{
				stringBuilder.AppendFormat("[" + LezSpellCollection.Spells[MagicCodes[i]].Name + "]");
			}
		}
		return string.Format($"Magic = '{stringBuilder}' Od = {Od(posod)} Mana = {Mana(posma)} Z = {method_3()}");
	}

	public void AddCombination(LezNode other)
	{
		for (int i = 0; i < 4; i++)
		{
			if (other.HitOps[i] > 0)
			{
				HitOps[i] = other.HitOps[i];
				HitCodes[i] = other.HitCodes[i];
			}
		}
		if (other.BlockOp > 0)
		{
			BlockCombo = other.BlockCombo;
			BlockOp = other.BlockOp;
			BlockCode = other.BlockCode;
		}
		for (int j = 0; j < other.MagicFlags.Length; j++)
		{
			if (other.MagicFlags[j])
			{
				MagicFlags[j] = other.MagicFlags[j];
				MagicCodes[j] = other.MagicCodes[j];
			}
		}
		_zScroll += other._zScroll;
		_zRestore += other._zRestore;
		_zMag += other._zMag;
		_zHit += other._zHit;
		_zBlock += other._zBlock;
	}

	public string PrintCombination(int[] posod, int[] posma)
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append(PrintHit(posod, posma));
		stringBuilder.AppendLine();
		stringBuilder.Append(PrintBlock(posod, posma));
		stringBuilder.AppendLine();
		stringBuilder.Append(PrintMagic(posod, posma));
		return stringBuilder.ToString();
	}

	public bool HasNonPhBlock(LezBotsGroup foeGroup)
	{
		if (BlockOp > 0 && (LezSpell.IsMagBlock(BlockCode) || Array.IndexOf(foeGroup.SpellsBlocks, BlockCode) >= 0))
		{
			return true;
		}
		int num = 0;
		while (true)
		{
			if (num < MagicFlags.Length)
			{
				if (MagicFlags[num] && Array.IndexOf(foeGroup.SpellsBlocks, MagicCodes[num]) >= 0)
				{
					break;
				}
				num++;
				continue;
			}
			return false;
		}
		return true;
	}

	public object Clone()
	{
		return (LezNode)Misc.DeepClone(this);
	}

	public int CompareTo(object obj)
	{
		LezNode lezNode = (LezNode)obj;
		return string.Compare(method_3(), lezNode.method_3(), StringComparison.Ordinal);
	}
}
