using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using Newtonsoft.Json.Linq;

namespace ABClient.Lez;

public class LezFight
{
	private readonly bool bool_0;

	private bool bool_1;

	private bool bool_2;

	private bool bool_3;

	private bool bool_4;

	private bool bool_5;

	private bool bool_6;

	private string string_0;

	private string string_1;

	private string string_2;

	private string[] string_3;

	private string[] string_4;

	private int int_0;

	private int int_1;

	private int int_2;

	private int int_3;

	private int int_4;

	private int int_5;

	private int int_6;

	private string string_5;

	private string string_6;

	private int int_7;

	private int int_8;

	public LezBotsGroup FoeGroup;

	private int int_9;

	private int int_10;

	private int int_11;

	private int int_12;

	private int[] int_13;

	private int[] int_14;

	private string[] string_7;

	private bool bool_7;

	private readonly List<int> list_0 = new List<int>();

	private readonly List<bool> list_1 = new List<bool>();

	private readonly List<int> list_2 = new List<int>();

	private readonly List<int>[] list_3 = new List<int>[4]
	{
		new List<int>(),
		new List<int>(),
		new List<int>(),
		new List<int>()
	};

	private readonly List<bool>[] list_4 = new List<bool>[4]
	{
		new List<bool>(),
		new List<bool>(),
		new List<bool>(),
		new List<bool>()
	};

	private readonly List<int> list_5 = new List<int>();

	private readonly List<bool> list_6 = new List<bool>();

	private readonly List<LezNode> list_7 = new List<LezNode>
	{
		new LezNode()
	};

	private readonly List<LezNode> list_8 = new List<LezNode>
	{
		new LezNode()
	};

	private readonly List<LezNode> list_9 = new List<LezNode>
	{
		new LezNode()
	};

	public readonly List<LezNode> LezCombinations = new List<LezNode>();

	public LezNode LezCombination;

	public string Result;

	public string Frame;

	public bool IsValid
	{
		[CompilerGenerated]
		get
		{
			return bool_0;
		}
	}

	public bool IsBoi
	{
		[CompilerGenerated]
		get
		{
			return bool_1;
		}
	}

	public bool IsWaitingForNextTurn
	{
		[CompilerGenerated]
		get
		{
			return bool_2;
		}
	}

	public bool DoStop
	{
		[CompilerGenerated]
		get
		{
			return bool_3;
		}
	}

	public bool DoExit
	{
		[CompilerGenerated]
		get
		{
			return bool_4;
		}
	}

	public bool IsLowHp
	{
		[CompilerGenerated]
		get
		{
			return bool_5;
		}
	}

	public bool IsLowMa
	{
		[CompilerGenerated]
		get
		{
			return bool_6;
		}
	}

	public string LogBoi
	{
		[CompilerGenerated]
		get
		{
			return string_0;
		}
	}

	public string FoeName
	{
		[CompilerGenerated]
		get
		{
			return string_1;
		}
	}

	public LezFight(string html)
	{
		bool_0 = method_8(html);
	}

	private void method_0(bool bool_8)
	{
		bool_1 = bool_8;
	}

	private void method_1(bool bool_8)
	{
		bool_2 = bool_8;
	}

	private void method_2(bool bool_8)
	{
		bool_3 = bool_8;
	}

	private void method_3(bool bool_8)
	{
		bool_4 = bool_8;
	}

	private void method_4(bool bool_8)
	{
		bool_5 = bool_8;
	}

	private void method_5(bool bool_8)
	{
		bool_6 = bool_8;
	}

	private void method_6(string string_8)
	{
		string_0 = string_8;
	}

	private void method_7(string string_8)
	{
		string_1 = string_8;
	}

	public void PrintDebug()
	{
		string text = "fight-debug.txt";
		if (string.IsNullOrEmpty(text))
		{
			return;
		}
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append(string_2);
		stringBuilder.AppendLine();
		stringBuilder.AppendFormat($"_currentHp = {int_1}, _maxHp = {int_2}");
		stringBuilder.AppendLine();
		stringBuilder.AppendFormat($"_currentMa = {int_3}, _maxMa = {int_4}");
		stringBuilder.AppendLine();
		stringBuilder.AppendFormat("_foeImage = " + string_5 + ", _foeName = " + string_6);
		stringBuilder.AppendLine();
		stringBuilder.AppendFormat($"_foeLevel = {int_7}, _foeGroupId = {int_8}");
		stringBuilder.AppendLine();
		stringBuilder.AppendFormat($"_foeGroup = {FoeGroup}");
		stringBuilder.AppendLine();
		stringBuilder.AppendFormat($"_magmax = {int_9}, _odmax = {int_10}, _hitval = {int_11}, _bs = {int_12}");
		stringBuilder.AppendLine();
		stringBuilder.AppendFormat($"_hits[{list_0.Count}] = ");
		foreach (int item in list_0)
		{
			stringBuilder.AppendFormat($" {item}({LezSpellCollection.PosType[item]},{LezSpellCollection.Spells[item].Name})");
		}
		stringBuilder.AppendLine();
		stringBuilder.Append("_ehits = ");
		foreach (bool item2 in list_1)
		{
			stringBuilder.AppendFormat($" {item2}");
		}
		stringBuilder.AppendLine();
		for (int i = 0; i < 4; i++)
		{
			stringBuilder.AppendFormat($"_blocks{i + 1}[{list_3[i].Count}] = ");
			foreach (int item3 in list_3[i])
			{
				stringBuilder.AppendFormat($" {item3}({LezSpellCollection.PosType[item3]},{LezSpellCollection.Spells[item3].Name})");
			}
			stringBuilder.AppendLine();
			stringBuilder.AppendFormat($"_eblocks{i + 1} = ");
			foreach (bool item4 in list_4[i])
			{
				stringBuilder.AppendFormat($" {item4}");
			}
			stringBuilder.AppendLine();
		}
		stringBuilder.AppendFormat($"_mags[{list_5.Count}] = ");
		foreach (int item5 in list_5)
		{
			stringBuilder.AppendFormat($" {item5}({LezSpellCollection.PosType[item5]},{LezSpellCollection.Spells[item5].Name})");
		}
		stringBuilder.AppendLine();
		stringBuilder.Append("_emagics = ");
		foreach (bool item6 in list_6)
		{
			stringBuilder.AppendFormat($" {item6}");
		}
		stringBuilder.AppendLine();
		stringBuilder.AppendFormat($"_lezHits.Count = {list_7.Count}");
		stringBuilder.AppendLine();
		foreach (LezNode item7 in list_7)
		{
			stringBuilder.Append(item7.PrintHit(int_13, int_14));
			stringBuilder.AppendLine();
		}
		stringBuilder.AppendFormat($"_lezBlocks.Count = {list_8.Count}");
		stringBuilder.AppendLine();
		foreach (LezNode item8 in list_8)
		{
			stringBuilder.Append(item8.PrintBlock(int_13, int_14));
			stringBuilder.AppendLine();
		}
		stringBuilder.AppendFormat($"_lezMagics.Count = {list_9.Count}");
		stringBuilder.AppendLine();
		foreach (LezNode item9 in list_9)
		{
			stringBuilder.Append(item9.PrintMagic(int_13, int_14));
			stringBuilder.AppendLine();
		}
		stringBuilder.AppendFormat($"_lezCombinations.Count = {LezCombinations.Count}");
		stringBuilder.AppendLine();
		int index = Class89.smethod_0(LezCombinations.Count);
		stringBuilder.Append(LezCombinations[index].PrintCombination(int_13, int_14));
		File.AppendAllText(text, stringBuilder.ToString());
	}

	private bool method_8(string string_8)
	{
		string_2 = string_8;
		Class72.string_0 = string.Empty;
		string_3 = smethod_4(string_8, "var fight_ty = [", 0);
		if (string_3 == null)
		{
			return false;
		}
		if (string_3.Length <= 8)
		{
			return false;
		}
		method_6(smethod_5(string_3[8]));
		int.TryParse(string_3[2], out int_0);
		if (!LogBoi.Equals(Class72.string_1, StringComparison.Ordinal))
		{
			smethod_6(string_2, LogBoi, string_3[2]);
		}
		method_0(string_3[3].Length >= 1 && string_3[3][0] == '1');
		string[] array = smethod_4(string_8, "var param_ow = [", 0);
		if (array == null)
		{
			return false;
		}
		if (!double.TryParse(smethod_5(array[1]), NumberStyles.Any, CultureInfo.InvariantCulture, out var result))
		{
			return false;
		}
		int_1 = (int)result;
		if (int_1 < 0)
		{
			int_1 = 0;
		}
		if (!double.TryParse(smethod_5(array[2]), NumberStyles.Any, CultureInfo.InvariantCulture, out result))
		{
			return false;
		}
		int_2 = (int)result;
		if (int_2 < 0)
		{
			int_2 = 0;
		}
		if (!double.TryParse(smethod_5(array[3]), NumberStyles.Any, CultureInfo.InvariantCulture, out result))
		{
			return false;
		}
		int_3 = (int)result;
		if (int_3 < 0)
		{
			int_3 = 0;
		}
		if (!double.TryParse(smethod_5(array[4]), NumberStyles.Any, CultureInfo.InvariantCulture, out result))
		{
			return false;
		}
		int_4 = (int)result;
		if (int_4 < 0)
		{
			int_4 = 0;
		}
		int_5 = ((int_2 > 0) ? ((int)((double)int_1 * 100.0 / (double)int_2)) : 0);
		int_6 = ((int_4 > 0) ? ((int)((double)int_3 * 100.0 / (double)int_4)) : 0);
		method_16();
		string text = Class12.smethod_1(string_2, "var logs = ", ";");
		if (!string.IsNullOrEmpty(text))
		{
			string value = string.Format("\"" + Class72.class19_0.method_30() + "\",");
			foreach (JToken item3 in (IEnumerable<JToken>)JObject.Parse("{\"j\":" + text + "}").First)
			{
				foreach (JToken item4 in (IEnumerable<JToken>)item3)
				{
					if (item4.Type != JTokenType.Array)
					{
						continue;
					}
					string text2 = item4.ToString();
					if (text2.IndexOf(value, StringComparison.CurrentCultureIgnoreCase) != -1)
					{
						if (text2.IndexOf("\"Свиток Удар Ярости\",", StringComparison.CurrentCultureIgnoreCase) != -1 && text2.IndexOf("ударом ярости\",", StringComparison.CurrentCultureIgnoreCase) != -1)
						{
							bool_7 = true;
							break;
						}
						if (text2.IndexOf("\"Снежок\",", StringComparison.CurrentCultureIgnoreCase) != -1 && text2.IndexOf("снежком\",", StringComparison.CurrentCultureIgnoreCase) != -1)
						{
							bool_7 = true;
							break;
						}
					}
				}
			}
		}
		if (!IsBoi)
		{
			return method_15();
		}
		if (Class72.bool_33 && bool_7)
		{
			bool_7 = false;
			try
			{
				if (Class72.formMain_0 != null)
				{
					Class72.formMain_0.BeginInvoke(new Delegate29(Class72.formMain_0.method_89), new object[0]);
				}
			}
			catch (InvalidOperationException)
			{
			}
			Thread.Sleep(500);
		}
		string[] array2 = smethod_4(string_8, "var stand_in = [", 0);
		if (array2 == null)
		{
			return false;
		}
		string[] array3 = smethod_4(string_8, "var magic_in = [", 0);
		if (array3 == null)
		{
			return false;
		}
		string[] array4 = smethod_4(string_8, "var param_en = [", 0);
		if (array4 == null)
		{
			return false;
		}
		string[] array5 = smethod_4(string_8, "var slots_en = [", 0);
		if (array5 == null)
		{
			return false;
		}
		string[] array6 = smethod_4(string_8, "var fight_pm = [", 0);
		if (array6 == null)
		{
			return false;
		}
		string[] array7 = smethod_4(string_8, "var alchemy = [", 0);
		method_7(array4[0].Substring(1, array4[0].Length - 2));
		if (string.IsNullOrEmpty(FoeName))
		{
			method_7(array4[0].Substring(1, array4[0].Length - 2));
		}
		string_6 = FoeName;
		if (array4[5].Length < 3 || !int.TryParse(smethod_5(array4[5]), out int_7))
		{
			int_7 = 33;
		}
		string_5 = smethod_5(array5[0]);
		if (!string_5.StartsWith("bot", StringComparison.OrdinalIgnoreCase) && !string_5.StartsWith("_xneto", StringComparison.OrdinalIgnoreCase) && !string_5.StartsWith("_xsilf", StringComparison.OrdinalIgnoreCase))
		{
			string_6 = "Человек";
		}
		int_8 = 0;
		for (int i = 0; i < Class72.class19_0.list_3.Count; i++)
		{
			LezBotsGroup lezBotsGroup = Class72.class19_0.list_3[i];
			switch (lezBotsGroup.Id)
			{
			case 10:
				if (string_6.Equals("Человек", StringComparison.CurrentCultureIgnoreCase) && int_7 >= lezBotsGroup.MinimalLevel)
				{
					int_8 = lezBotsGroup.Id;
				}
				break;
			case 1:
				int_8 = lezBotsGroup.Id;
				break;
			default:
				if (string_6.Equals(LezBotsClassCollection.GetClass(lezBotsGroup.Id).Name, StringComparison.CurrentCultureIgnoreCase) && int_7 >= lezBotsGroup.MinimalLevel)
				{
					int_8 = lezBotsGroup.Id;
				}
				break;
			case 118:
				if (string_6.Contains("Элементаль") && int_7 >= lezBotsGroup.MinimalLevel)
				{
					int_8 = lezBotsGroup.Id;
				}
				break;
			case 21:
				if (smethod_3(string_6))
				{
					int_8 = lezBotsGroup.Id;
				}
				break;
			case 20:
				if (!string_6.Equals("Человек", StringComparison.CurrentCultureIgnoreCase) && int_7 >= lezBotsGroup.MinimalLevel)
				{
					int_8 = lezBotsGroup.Id;
				}
				break;
			}
			if (int_8 != 0)
			{
				FoeGroup = (LezBotsGroup)lezBotsGroup.Clone();
				break;
			}
		}
		if (!int.TryParse(array6[0], out int_9))
		{
			return false;
		}
		if (!int.TryParse(array6[1], out int_10))
		{
			return false;
		}
		if (!int.TryParse(array6[2], out int_11))
		{
			return false;
		}
		int_13 = new int[LezSpellCollection.Od.Length];
		Array.Copy(LezSpellCollection.Od, int_13, LezSpellCollection.Od.Length);
		int_13[0] = int_11;
		int_13[1] = int_11 + 20;
		int_14 = new int[LezSpellCollection.PosMana.Length];
		Array.Copy(LezSpellCollection.PosMana, int_14, LezSpellCollection.PosMana.Length);
		int_14[2] = FoeGroup.MagHits;
		int_14[3] = FoeGroup.MagHits;
		List<int> list = new List<int> { 0, 1 };
		string[] array8 = array2;
		for (int j = 0; j < array8.Length; j++)
		{
			if (int.TryParse(array8[j], out var result2))
			{
				list.Add(result2);
			}
		}
		method_9(0, list);
		List<int> list2 = new List<int>();
		array8 = array3;
		for (int j = 0; j < array8.Length; j++)
		{
			if (int.TryParse(array8[j], out var result3))
			{
				list2.Add(result3);
			}
		}
		if (list2.Count > 0)
		{
			method_9(1, list2);
		}
		switch (array6[3])
		{
		default:
			int_12 = 0;
			break;
		case "90":
			int_12 = 3;
			break;
		case "70":
			int_12 = 2;
			break;
		case "40":
			int_12 = 1;
			break;
		case "0":
			int_12 = 0;
			break;
		}
		string[] array9 = new string[4] { "4:5:6@7:8:9@10:11@12:13", "14:15@16:17@18:19@20:21", "22:23@24@25@26", "27@28" };
		string_7 = array9[int_12].Split('@');
		for (int k = 0; k < 4 && k < string_7.Length; k++)
		{
			string[] array10 = string_7[k].Split(':');
			List<int> list3 = new List<int>();
			for (int l = 0; l < array10.Length; l++)
			{
				int item = Convert.ToInt32(array10[l]);
				list3.Add(item);
			}
			list_3[k].AddRange(list3);
			list_3[k].AddRange(list_2);
			for (int m = 0; m < list_3[k].Count; m++)
			{
				list_4[k].Add(method_12(list_3[k][m]));
			}
		}
		for (int n = 0; n < list_0.Count; n++)
		{
			list_1.Add(method_11(list_0[n]));
		}
		for (int num = 0; num < 4; num++)
		{
			for (int num2 = 1; num2 <= list_0.Count; num2++)
			{
				if (list_1[num2 - 1])
				{
					LezNode lezNode = new LezNode();
					int code = list_0[num2 - 1];
					lezNode.AddHit(num, num2, code);
					if (lezNode.Od(int_13) <= int_10 && lezNode.Mana(int_14) <= int_3)
					{
						list_7.Add(lezNode);
					}
				}
			}
		}
		for (int num3 = 0; num3 < 3; num3++)
		{
			for (int num4 = 1; num4 <= list_0.Count; num4++)
			{
				if (!list_1[num4 - 1])
				{
					continue;
				}
				LezNode lezNode2 = new LezNode();
				int code2 = list_0[num4 - 1];
				lezNode2.AddHit(num3, num4, code2);
				if (lezNode2.Od(int_13) > int_10 || lezNode2.Mana(int_14) > int_3)
				{
					continue;
				}
				for (int num5 = num3 + 1; num5 < 4; num5++)
				{
					if (num5 - num3 == 3)
					{
						continue;
					}
					for (int num6 = 1; num6 <= list_0.Count; num6++)
					{
						if (list_1[num6 - 1])
						{
							LezNode lezNode3 = (LezNode)lezNode2.Clone();
							int code3 = list_0[num6 - 1];
							lezNode3.AddHit(num5, num6, code3);
							if (lezNode3.Od(int_13) <= int_10 && lezNode3.Mana(int_14) <= int_3)
							{
								list_7.Add(lezNode3);
							}
						}
					}
				}
			}
		}
		for (int num7 = 0; num7 < 2; num7++)
		{
			for (int num8 = 1; num8 <= list_0.Count; num8++)
			{
				if (!list_1[num8 - 1])
				{
					continue;
				}
				LezNode lezNode4 = new LezNode();
				int code4 = list_0[num8 - 1];
				lezNode4.AddHit(num7, num8, code4);
				if (lezNode4.Od(int_13) > int_10 || lezNode4.Mana(int_14) > int_3)
				{
					continue;
				}
				int num9 = num7 + 1;
				for (int num10 = 1; num10 <= list_0.Count; num10++)
				{
					if (!list_1[num10 - 1])
					{
						continue;
					}
					LezNode lezNode5 = (LezNode)lezNode4.Clone();
					int code5 = list_0[num10 - 1];
					lezNode5.AddHit(num9, num10, code5);
					if (lezNode5.Od(int_13) > int_10 || lezNode5.Mana(int_14) > int_3)
					{
						continue;
					}
					int combo = num9 + 1;
					for (int num11 = 1; num11 <= list_0.Count; num11++)
					{
						if (list_1[num11 - 1])
						{
							LezNode lezNode6 = (LezNode)lezNode5.Clone();
							int code6 = list_0[num11 - 1];
							lezNode6.AddHit(combo, num11, code6);
							if (lezNode6.Od(int_13) <= int_10 && lezNode6.Mana(int_14) <= int_3)
							{
								list_7.Add(lezNode6);
							}
						}
					}
				}
			}
		}
		for (int num12 = 0; num12 < 4; num12++)
		{
			for (int num13 = 1; num13 <= list_3[num12].Count; num13++)
			{
				if (!list_4[num12][num13 - 1])
				{
					continue;
				}
				LezNode lezNode7 = new LezNode();
				int code7 = list_3[num12][num13 - 1];
				if (num12 <= 0 || LezSpell.IsPhBlock(code7))
				{
					lezNode7.AddBlock(num12, num13, code7);
					if (lezNode7.Od(int_13) <= int_10 && lezNode7.Mana(int_14) <= int_3)
					{
						list_8.Add(lezNode7);
					}
				}
			}
		}
		int num14 = method_10();
		if (num14 > 0)
		{
			for (int num15 = 0; num15 < list_5.Count; num15++)
			{
				if (list_6[num15])
				{
					int num16 = list_5[num15];
					LezNode lezNode8 = new LezNode();
					lezNode8.AddMagic(num15, num16, smethod_0(FoeGroup, num16), smethod_1(FoeGroup, num16), smethod_2(num16));
					if (lezNode8.Od(int_13) <= int_10 && lezNode8.Mana(int_14) <= int_3)
					{
						list_9.Add(lezNode8);
					}
				}
			}
		}
		if (num14 > 1)
		{
			for (int num17 = 0; num17 < list_5.Count - 1; num17++)
			{
				if (!list_6[num17])
				{
					continue;
				}
				int num18 = list_5[num17];
				LezNode lezNode9 = new LezNode();
				lezNode9.AddMagic(num17, num18, smethod_0(FoeGroup, num18), smethod_1(FoeGroup, num18), smethod_2(num18));
				if (lezNode9.Od(int_13) > int_10 || lezNode9.Mana(int_14) > int_3)
				{
					continue;
				}
				for (int num19 = num17 + 1; num19 < list_5.Count; num19++)
				{
					if (!list_6[num19])
					{
						continue;
					}
					int num20 = list_5[num19];
					if ((num18 != 388 || Array.IndexOf(FoeGroup.SpellsRestoreHp, num20) < 0) && (num20 != 388 || Array.IndexOf(FoeGroup.SpellsRestoreHp, num18) < 0) && (Array.IndexOf(FoeGroup.SpellsBlocks, num18) < 0 || Array.IndexOf(FoeGroup.SpellsBlocks, num20) < 0))
					{
						LezNode lezNode10 = (LezNode)lezNode9.Clone();
						lezNode10.AddMagic(num19, num20, smethod_0(FoeGroup, num20), smethod_1(FoeGroup, num20), smethod_2(num20));
						if (lezNode10.Od(int_13) <= int_10 && lezNode10.Mana(int_14) <= int_3)
						{
							list_9.Add(lezNode10);
						}
					}
				}
			}
		}
		if (num14 > 2)
		{
			for (int num21 = 0; num21 < list_5.Count - 2; num21++)
			{
				if (!list_6[num21])
				{
					continue;
				}
				int num22 = list_5[num21];
				LezNode lezNode11 = new LezNode();
				lezNode11.AddMagic(num21, num22, smethod_0(FoeGroup, num22), smethod_1(FoeGroup, num22), smethod_2(num22));
				if (lezNode11.Od(int_13) > int_10 || lezNode11.Mana(int_14) > int_3)
				{
					continue;
				}
				for (int num23 = num21 + 1; num23 < list_5.Count - 1; num23++)
				{
					if (!list_6[num23])
					{
						continue;
					}
					int num24 = list_5[num23];
					if ((num22 == 388 && Array.IndexOf(FoeGroup.SpellsRestoreHp, num24) >= 0) || (num24 == 388 && Array.IndexOf(FoeGroup.SpellsRestoreHp, num22) >= 0) || (Array.IndexOf(FoeGroup.SpellsBlocks, num22) >= 0 && Array.IndexOf(FoeGroup.SpellsBlocks, num24) >= 0))
					{
						continue;
					}
					LezNode lezNode12 = (LezNode)lezNode11.Clone();
					lezNode12.AddMagic(num23, num24, smethod_0(FoeGroup, num24), smethod_1(FoeGroup, num24), smethod_2(num24));
					if (lezNode12.Od(int_13) > int_10 || lezNode12.Mana(int_14) > int_3)
					{
						continue;
					}
					for (int num25 = num23 + 1; num25 < list_5.Count; num25++)
					{
						if (!list_6[num25])
						{
							continue;
						}
						int num26 = list_5[num25];
						if ((num22 != 388 || Array.IndexOf(FoeGroup.SpellsRestoreHp, num26) < 0) && (num24 != 388 || Array.IndexOf(FoeGroup.SpellsRestoreHp, num26) < 0) && (num26 != 388 || Array.IndexOf(FoeGroup.SpellsRestoreHp, num22) < 0) && (num26 != 388 || Array.IndexOf(FoeGroup.SpellsRestoreHp, num24) < 0) && (Array.IndexOf(FoeGroup.SpellsBlocks, num22) < 0 || Array.IndexOf(FoeGroup.SpellsBlocks, num26) < 0) && (Array.IndexOf(FoeGroup.SpellsBlocks, num24) < 0 || Array.IndexOf(FoeGroup.SpellsBlocks, num26) < 0))
						{
							LezNode lezNode13 = (LezNode)lezNode12.Clone();
							lezNode13.AddMagic(num25, num26, smethod_0(FoeGroup, num26), smethod_1(FoeGroup, num26), smethod_2(num26));
							if (lezNode13.Od(int_13) <= int_10 && lezNode13.Mana(int_14) <= int_3)
							{
								list_9.Add(lezNode13);
							}
						}
					}
				}
			}
		}
		for (int num27 = 0; num27 < list_7.Count; num27++)
		{
			LezNode lezNode14 = new LezNode();
			lezNode14.AddCombination(list_7[num27]);
			for (int num28 = 0; num28 < list_8.Count; num28++)
			{
				bool flag = list_8[num28].HasNonPhBlock(FoeGroup);
				LezNode lezNode15 = (LezNode)lezNode14.Clone();
				lezNode15.AddCombination(list_8[num28]);
				if (lezNode15.Od(int_13) > int_10 || lezNode15.Mana(int_14) > int_3)
				{
					continue;
				}
				for (int num29 = 0; num29 < list_9.Count; num29++)
				{
					if (flag && list_9[num29].HasNonPhBlock(FoeGroup))
					{
						continue;
					}
					LezNode lezNode16 = (LezNode)lezNode15.Clone();
					lezNode16.AddCombination(list_9[num29]);
					if (lezNode16.Od(int_13) > int_10 || lezNode16.Mana(int_14) > int_3)
					{
						continue;
					}
					List<int> list4 = new List<int>();
					HashSet<int> hashSet = new HashSet<int>(LezSpellCollection.Hits);
					int[] hitCodes = lezNode16.HitCodes;
					foreach (int item2 in hitCodes)
					{
						if (hashSet.Contains(item2) && !list4.Contains(item2))
						{
							list4.Add(item2);
						}
					}
					if (list4.Count > 1 || !lezNode16.IsValid())
					{
						continue;
					}
					if (LezCombinations.Count == 0)
					{
						LezCombinations.Add(lezNode16);
						continue;
					}
					int num30 = lezNode16.CompareTo(LezCombinations[0]);
					if (num30 >= 0)
					{
						if (num30 > 0)
						{
							LezCombinations.Clear();
						}
						LezCombinations.Add(lezNode16);
					}
				}
			}
		}
		method_2(FoeGroup.DoStopNow);
		method_4(FoeGroup.DoStopLowHp && int_5 <= FoeGroup.StopLowHp);
		method_5(FoeGroup.DoStopLowMa && int_6 <= FoeGroup.StopLowMa);
		method_3(FoeGroup.DoExitRisky && int_0 >= 80 && string_6.Equals("Человек"));
		if (LezCombinations.Count > 0)
		{
			int index = Class89.smethod_0(LezCombinations.Count);
			LezCombination = LezCombinations[index];
			StringBuilder stringBuilder = new StringBuilder();
			for (int num31 = 0; num31 < 4; num31++)
			{
				if (LezCombination.HitOps[num31] > 0)
				{
					int num32 = LezCombination.HitCodes[num31];
					stringBuilder.Append(num31);
					stringBuilder.Append('_');
					stringBuilder.Append(num32);
					stringBuilder.Append('_');
					stringBuilder.Append(int_14[num32]);
					stringBuilder.Append('@');
				}
			}
			StringBuilder stringBuilder2 = new StringBuilder();
			if (LezCombination.BlockOp > 0)
			{
				stringBuilder2.Append(LezCombination.BlockCombo);
				stringBuilder2.Append('_');
				stringBuilder2.Append(LezCombination.BlockCode);
				stringBuilder2.Append('_');
				stringBuilder2.Append(int_14[LezCombination.BlockCode]);
				stringBuilder2.Append('@');
			}
			StringBuilder stringBuilder3 = new StringBuilder();
			for (int num33 = 0; num33 < LezCombination.MagicFlags.Length; num33++)
			{
				if (!LezCombination.MagicFlags[num33])
				{
					continue;
				}
				int num34 = LezCombination.MagicCodes[num33];
				int num35 = LezSpellCollection.PosType[num34];
				if (num35 > 2)
				{
					stringBuilder3.Append(num34);
					if (num35 > 3)
					{
						stringBuilder3.Append('_');
						stringBuilder3.Append(array7[num33]);
					}
					stringBuilder3.Append('@');
				}
			}
			string value2 = array4[0].Substring(1, array4[0].Length - 2);
			if (array4[5].Length < 3 || !int.TryParse(smethod_5(array4[5]), out var result4))
			{
				result4 = -1;
			}
			if (Class72.class19_0.method_124())
			{
				StringBuilder stringBuilder4 = new StringBuilder();
				if (result4 == -1)
				{
					stringBuilder4.Append("Невидимка");
				}
				else
				{
					stringBuilder4.Append(smethod_5(array4[0]));
					stringBuilder4.Append(" [");
					stringBuilder4.Append(smethod_5(array4[5]));
					stringBuilder4.Append("] [");
					stringBuilder4.Append(smethod_5(array4[1]));
					stringBuilder4.Append('/');
					stringBuilder4.Append(smethod_5(array4[2]));
					stringBuilder4.Append(" | ");
					stringBuilder4.Append(smethod_5(array4[3]));
					stringBuilder4.Append('/');
					stringBuilder4.Append(smethod_5(array4[4]));
					stringBuilder4.Append(']');
				}
				try
				{
					if (Class72.formMain_0 != null)
					{
						Class72.formMain_0.BeginInvoke(new Delegate33(Class72.formMain_0.method_93), stringBuilder4.ToString());
					}
				}
				catch (InvalidOperationException)
				{
				}
			}
			StringBuilder stringBuilder5 = new StringBuilder();
			string value3 = smethod_5(array6[4]);
			string value4 = smethod_5(array4[5]);
			stringBuilder5.Append(value3);
			stringBuilder5.Append('|');
			stringBuilder5.Append(array6[5]);
			stringBuilder5.Append('|');
			stringBuilder5.Append(array6[6]);
			stringBuilder5.Append('|');
			stringBuilder5.Append(array6[7]);
			stringBuilder5.Append('|');
			stringBuilder5.Append(value4);
			stringBuilder5.Append('|');
			stringBuilder5.Append(string_3[2]);
			stringBuilder5.Append('|');
			stringBuilder5.Append(stringBuilder);
			stringBuilder5.Append('|');
			stringBuilder5.Append(stringBuilder2);
			stringBuilder5.Append('|');
			stringBuilder5.Append(stringBuilder3);
			Result = stringBuilder5.ToString();
			StringBuilder stringBuilder6 = new StringBuilder();
			stringBuilder6.Append(Class7.smethod_1());
			stringBuilder6.Append("<b>");
			stringBuilder6.Append(array[0].Substring(1, array[0].Length - 2));
			stringBuilder6.Append("</b> [");
			stringBuilder6.Append(array[5].Substring(1, array[5].Length - 2));
			stringBuilder6.Append("] [<font color=#bb0000><b>");
			stringBuilder6.Append(array[1].Substring(1, array[1].Length - 2));
			stringBuilder6.Append("</b>/<b>");
			stringBuilder6.Append(array[2].Substring(1, array[2].Length - 2));
			stringBuilder6.Append("</b></font> | <font color=#336699><b>");
			stringBuilder6.Append(array[3].Substring(1, array[3].Length - 2));
			stringBuilder6.Append("</b>/<b>");
			stringBuilder6.Append(array[4].Substring(1, array[4].Length - 2));
			stringBuilder6.Append("</b></font>] : <b>");
			if (result4 == -1)
			{
				stringBuilder6.Append("Невидимка</b>");
			}
			else
			{
				stringBuilder6.Append(value2);
				stringBuilder6.Append("</b> [");
				stringBuilder6.Append(result4);
				stringBuilder6.Append("] [<font color=#bb0000><b>");
				stringBuilder6.Append(smethod_5(array4[1]));
				stringBuilder6.Append("</b>/<b>");
				stringBuilder6.Append(smethod_5(array4[2]));
				stringBuilder6.Append("</b></font> | <font color=#336699><b>");
				stringBuilder6.Append(smethod_5(array4[3]));
				stringBuilder6.Append("</b>/<b>");
				stringBuilder6.Append(smethod_5(array4[4]));
				stringBuilder6.Append("</b></font>]");
			}
			stringBuilder6.Append("<form action=\"main.php\" method=POST name=ff id=form_main>");
			stringBuilder6.Append("<input name=post_id type=hidden value=\"");
			stringBuilder6.Append(7);
			stringBuilder6.Append("\">");
			stringBuilder6.Append("<input name=vcode type=hidden value=\"");
			stringBuilder6.Append(value3);
			stringBuilder6.Append("\">");
			stringBuilder6.Append("<input name=enemy type=hidden value=\"");
			stringBuilder6.Append(array6[5]);
			stringBuilder6.Append("\">");
			stringBuilder6.Append("<input name=group type=hidden value=\"");
			stringBuilder6.Append(array6[6]);
			stringBuilder6.Append("\">");
			stringBuilder6.Append("<input name=inf_bot type=hidden value=\"");
			stringBuilder6.Append(array6[7]);
			stringBuilder6.Append("\">");
			stringBuilder6.Append("<input name=inf_zb type=hidden value=\"");
			stringBuilder6.Append(array6[10]);
			stringBuilder6.Append("\">");
			stringBuilder6.Append("<input name=lev_bot type=hidden value=\"");
			stringBuilder6.Append(value4);
			stringBuilder6.Append("\">");
			stringBuilder6.Append("<input name=ftr type=hidden value=\"");
			stringBuilder6.Append(string_3[2]);
			stringBuilder6.Append("\">");
			stringBuilder6.Append("<input name=inu type=hidden value=\"");
			stringBuilder6.Append(stringBuilder);
			stringBuilder6.Append("\">");
			stringBuilder6.Append("<input name=inb type=hidden value=\"");
			stringBuilder6.Append(stringBuilder2);
			stringBuilder6.Append("\">");
			stringBuilder6.Append("<input name=ina type=hidden value=\"");
			stringBuilder6.Append(stringBuilder3);
			stringBuilder6.Append("\">");
			stringBuilder6.Append("</form><script language=\"JavaScript\">document.ff.submit();</script></body></html>");
			Frame = stringBuilder6.ToString();
			return true;
		}
		if (Class72.class19_0.bool_48)
		{
			try
			{
				if (Class72.formMain_0 != null)
				{
					Class72.formMain_0.BeginInvoke(new Delegate36(Class72.formMain_0.method_62), "Настройки автобоя противоречивы. Автобой остановлен.");
				}
			}
			catch (InvalidOperationException)
			{
			}
			try
			{
				if (Class72.formMain_0 != null)
				{
					Class72.formMain_0.BeginInvoke(new Delegate29(Class72.formMain_0.method_89), new object[0]);
				}
			}
			catch (InvalidOperationException)
			{
			}
			Thread.Sleep(500);
		}
		return true;
	}

	private void method_9(int int_15, IEnumerable<int> ienumerable_0)
	{
		foreach (int item in ienumerable_0)
		{
			switch (LezSpellCollection.PosType[item])
			{
			case 1:
				list_0.Add(item);
				if (int_15 == 1)
				{
					list_5.Add(item);
					list_6.Add(item: false);
				}
				break;
			case 2:
				list_2.Add(item);
				if (int_15 == 1)
				{
					list_5.Add(item);
					list_6.Add(item: false);
				}
				break;
			case 3:
			case 4:
				list_5.Add(item);
				list_6.Add(method_13(item));
				break;
			}
		}
	}

	private int method_10()
	{
		int num = 0;
		foreach (bool item in list_6)
		{
			if (item)
			{
				num++;
			}
		}
		return num;
	}

	private bool method_11(int int_15)
	{
		if (LezSpell.IsPhHit(int_15) && FoeGroup.DoHits)
		{
			return true;
		}
		if (LezSpell.IsMagHit(int_15) && FoeGroup.DoMagHits)
		{
			return true;
		}
		if (Array.IndexOf(FoeGroup.SpellsHits, int_15) >= 0 && FoeGroup.DoAbilHits)
		{
			return true;
		}
		return false;
	}

	private bool method_12(int int_15)
	{
		if (LezSpell.IsPhBlock(int_15) && FoeGroup.DoBlocks)
		{
			return true;
		}
		if (LezSpell.IsMagBlock(int_15) && FoeGroup.DoMagBlocks)
		{
			return true;
		}
		if (Array.IndexOf(FoeGroup.SpellsBlocks, int_15) >= 0 && FoeGroup.DoAbilBlocks)
		{
			return true;
		}
		return false;
	}

	private bool method_13(int int_15)
	{
		if (Array.IndexOf(FoeGroup.SpellsRestoreHp, int_15) >= 0)
		{
			if (FoeGroup.DoRestoreHp && (int)((double)int_1 * 100.0 / (double)int_2) <= FoeGroup.RestoreHp)
			{
				return true;
			}
			return false;
		}
		if (Array.IndexOf(FoeGroup.SpellsRestoreMa, int_15) >= 0)
		{
			if (FoeGroup.DoRestoreMa && (int)((double)int_3 * 100.0 / (double)int_4) <= FoeGroup.RestoreMa)
			{
				return true;
			}
			return false;
		}
		if (Array.IndexOf(FoeGroup.SpellsBlocks, int_15) >= 0)
		{
			if (FoeGroup.DoAbilBlocks)
			{
				return true;
			}
			return false;
		}
		if (Array.IndexOf(FoeGroup.SpellsHits, int_15) >= 0)
		{
			if (FoeGroup.DoAbilHits)
			{
				return true;
			}
			return false;
		}
		if (Array.IndexOf(FoeGroup.SpellsMisc, int_15) >= 0)
		{
			if (FoeGroup.DoMiscAbils)
			{
				return true;
			}
			return false;
		}
		if (LezSpell.IsScrollHit(int_15))
		{
			if (Class72.bool_33 && smethod_3(string_6))
			{
				return true;
			}
			return false;
		}
		if (int_15 != 328 && int_15 != 330)
		{
			return false;
		}
		return method_14();
	}

	private static int smethod_0(LezBotsGroup lezBotsGroup_0, int int_15)
	{
		if (Array.IndexOf(lezBotsGroup_0.SpellsBlocks, int_15) >= 0)
		{
			return 4;
		}
		if (Array.IndexOf(lezBotsGroup_0.SpellsHits, int_15) >= 0)
		{
			return 2;
		}
		if (Array.IndexOf(lezBotsGroup_0.SpellsMisc, int_15) >= 0)
		{
			return 1;
		}
		return 0;
	}

	private static int smethod_1(LezBotsGroup lezBotsGroup_0, int int_15)
	{
		if (int_15 == 388)
		{
			return 3;
		}
		if (Array.IndexOf(lezBotsGroup_0.SpellsRestoreHp, int_15) >= 0)
		{
			return 2;
		}
		if (Array.IndexOf(lezBotsGroup_0.SpellsRestoreMa, int_15) >= 0)
		{
			return 1;
		}
		return 0;
	}

	private static int smethod_2(int int_15)
	{
		switch (int_15)
		{
		case 338:
			return 2;
		case 277:
			return 1;
		default:
			return 0;
		case 328:
		case 330:
			return 3;
		}
	}

	private static bool smethod_3(string string_8)
	{
		if (!string_8.Equals("Королева Змей", StringComparison.CurrentCultureIgnoreCase) && !string_8.Equals("Хранитель Леса", StringComparison.CurrentCultureIgnoreCase) && !string_8.Equals("Громлех Синезубый", StringComparison.CurrentCultureIgnoreCase) && !string_8.Equals("Выползень", StringComparison.CurrentCultureIgnoreCase) && !string_8.Equals("Озлобленный Дух", StringComparison.CurrentCultureIgnoreCase) && !string_8.Equals("Кхалганский Налетчик", StringComparison.CurrentCultureIgnoreCase) && !string_8.Equals("Подручный Атамана", StringComparison.CurrentCultureIgnoreCase) && !string_8.Equals("Прислужник Локара", StringComparison.CurrentCultureIgnoreCase))
		{
			return string_8.Equals("Друид-отступник", StringComparison.CurrentCultureIgnoreCase);
		}
		return true;
	}

	private bool method_14()
	{
		if (string_2.IndexOf("\"Королева Змей\"", StringComparison.CurrentCultureIgnoreCase) == -1 && string_2.IndexOf("\"Хранитель Леса\"", StringComparison.CurrentCultureIgnoreCase) == -1 && string_2.IndexOf("\"Громлех Синезубый\"", StringComparison.CurrentCultureIgnoreCase) == -1 && string_2.IndexOf("\"Выползень\"", StringComparison.CurrentCultureIgnoreCase) == -1 && string_2.IndexOf("\"Озлобленный Дух\"", StringComparison.CurrentCultureIgnoreCase) == -1 && string_2.IndexOf("\"Кхалганский Налетчик\"", StringComparison.CurrentCultureIgnoreCase) == -1 && string_2.IndexOf("\"Подручный Атамана\"", StringComparison.CurrentCultureIgnoreCase) == -1 && string_2.IndexOf("\"Прислужник Локара\"", StringComparison.CurrentCultureIgnoreCase) == -1)
		{
			return string_2.IndexOf("\"Друид-отступник\"", StringComparison.CurrentCultureIgnoreCase) != -1;
		}
		return true;
	}

	private bool method_15()
	{
		switch (string_3[4])
		{
		case "7":
			if (Class72.class19_0.method_124())
			{
				try
				{
					if (Class72.formMain_0 != null)
					{
						Class72.formMain_0.BeginInvoke(new Delegate33(Class72.formMain_0.method_93), "Завершить");
					}
				}
				catch (InvalidOperationException)
				{
				}
			}
			Class72.string_0 = "http://www.neverlands.ru/main.php?get_id=61&act=5&st=" + smethod_5(string_3[4]) + "&vcode=" + smethod_5(string_3[5]);
			break;
		case "5":
			if (Class72.class19_0.method_124())
			{
				try
				{
					if (Class72.formMain_0 != null)
					{
						Class72.formMain_0.BeginInvoke(new Delegate33(Class72.formMain_0.method_93), "Завершить");
					}
				}
				catch (InvalidOperationException)
				{
				}
			}
			Class72.string_0 = "http://www.neverlands.ru/main.php?get_id=61&act=5&vcode=" + smethod_5(string_3[5]);
			break;
		case "4":
			if (!Class72.class19_0.method_124())
			{
				break;
			}
			try
			{
				if (Class72.formMain_0 != null)
				{
					Class72.formMain_0.BeginInvoke(new Delegate33(Class72.formMain_0.method_93), "Ждем окончания боя");
				}
			}
			catch (InvalidOperationException)
			{
			}
			break;
		case "3":
			if (string_3[6].Length > 2)
			{
				if (Class72.class19_0.bool_53)
				{
					if (Class72.class19_0.method_124())
					{
						try
						{
							if (Class72.formMain_0 != null)
							{
								Class72.formMain_0.BeginInvoke(new Delegate33(Class72.formMain_0.method_93), "Победа по таймауту");
							}
						}
						catch (InvalidOperationException)
						{
						}
					}
					Class72.string_0 = "http://www.neverlands.ru/main.php?get_id=61&act=6&mode=1&gr=" + smethod_5(string_3[7]) + "&vcode=" + smethod_5(string_3[6]);
					break;
				}
				if (Class72.class19_0.method_124())
				{
					try
					{
						if (Class72.formMain_0 != null)
						{
							Class72.formMain_0.BeginInvoke(new Delegate33(Class72.formMain_0.method_93), "Ничья по таймауту");
						}
					}
					catch (InvalidOperationException)
					{
					}
				}
				Class72.string_0 = "http://www.neverlands.ru/main.php?get_id=61&act=6&mode=0&gr=" + smethod_5(string_3[7]) + "&vcode=" + smethod_5(string_3[6]);
				break;
			}
			method_1(bool_8: true);
			Class72.smethod_7(string.Empty);
			if (Class72.smethod_136())
			{
				if (Class72.formMain_0 != null)
				{
					Class72.formMain_0.method_22();
				}
				StringBuilder stringBuilder = new StringBuilder(Class7.smethod_1());
				stringBuilder.AppendLine("Ожидаем хода противника... <span id='wt'>00:00:00</span>");
				stringBuilder.AppendLine("<script language=\"JavaScript\">");
				stringBuilder.AppendLine("var block = document.getElementById('wt');");
				stringBuilder.AppendLine("wtimer(0, block);");
				stringBuilder.AppendLine("function wtimer(sec, block){");
				stringBuilder.AppendLine("  var time = sec;");
				stringBuilder.AppendLine("  var minutes = parseInt(time / 60);");
				stringBuilder.AppendLine("  if (minutes < 1) minutes = 0;");
				stringBuilder.AppendLine("  time = parseInt(time - minutes * 60);");
				stringBuilder.AppendLine("  if (minutes < 10) minutes = '0' + minutes;");
				stringBuilder.AppendLine("  var seconds = time;");
				stringBuilder.AppendLine("  if (seconds < 10) seconds = '0' + seconds;");
				stringBuilder.AppendLine("  block.innerHTML = minutes + ':' + seconds;");
				stringBuilder.AppendLine("  sec++;");
				stringBuilder.AppendLine("  setTimeout(function(){ wtimer(sec, block); }, 1000);");
				stringBuilder.AppendLine("}");
				stringBuilder.Append("</script></body></html>");
				Frame = stringBuilder.ToString();
			}
			break;
		case "2":
			string_4 = smethod_4(string_2, "var fexp = [", 0);
			if (string_4 == null)
			{
				return false;
			}
			if (string_4[4].Length > 2)
			{
				if (string_4[6].Equals("0", StringComparison.Ordinal))
				{
					Class72.string_0 = "http://www.neverlands.ru/main.php?code=" + (string.IsNullOrEmpty(Class72.string_50) ? "????" : Class72.string_50) + "&get_id=61&act=7&fexp=" + smethod_5(string_4[0]) + "&fres=" + smethod_5(string_4[1]) + "&vcode=" + smethod_5(string_4[3]) + "&min1=" + smethod_5(string_4[8]) + "&max1=" + smethod_5(string_4[9]) + "&min2=" + smethod_5(string_4[10]) + "&max2=" + smethod_5(string_4[11]) + "&sum1=" + smethod_5(string_4[12]) + "&sum2=" + smethod_5(string_4[13]) + "&ftype=" + smethod_5(string_4[5]);
				}
				break;
			}
			if (Class72.class19_0.method_124())
			{
				try
				{
					if (Class72.formMain_0 != null)
					{
						Class72.formMain_0.BeginInvoke(new Delegate33(Class72.formMain_0.method_93), "Завершаем бой");
					}
				}
				catch (InvalidOperationException)
				{
				}
			}
			Class72.string_0 = "http://www.neverlands.ru/main.php?get_id=61&act=7&fexp=" + smethod_5(string_4[0]) + "&fres=" + smethod_5(string_4[1]) + "&vcode=" + smethod_5(string_4[3]) + "&ftype=" + smethod_5(string_4[5]) + "&min1=" + smethod_5(string_4[8]) + "&max1=" + smethod_5(string_4[9]) + "&min2=" + smethod_5(string_4[10]) + "&max2=" + smethod_5(string_4[11]) + "&sum1=" + smethod_5(string_4[12]) + "&sum2=" + smethod_5(string_4[13]);
			break;
		}
		if (!LogBoi.Equals(Class72.smethod_20(), StringComparison.Ordinal))
		{
			string[] array = smethod_4(string_2, "var list = [[", 0);
			if (array != null)
			{
				int num = 0;
				for (int i = 6; i <= 10; i++)
				{
					num += Convert.ToInt32(array[i]);
				}
				Class72.smethod_23(num.ToString(CultureInfo.InvariantCulture));
				Class72.smethod_21(LogBoi);
			}
		}
		return true;
	}

	private static string[] smethod_4(string string_8, string string_9, int int_15)
	{
		if (string_8 != null && string_9 != null)
		{
			if (string_8.IndexOf(string_9, StringComparison.OrdinalIgnoreCase) == -1)
			{
				return null;
			}
			string text = Class12.smethod_1(string_8, string_9, "]");
			if (text == null)
			{
				return null;
			}
			string[] array = text.Split(',');
			if (array.Length >= int_15)
			{
				return array;
			}
			return null;
		}
		return null;
	}

	private static string smethod_5(string string_8)
	{
		return string_8.Trim('"');
	}

	private static void smethod_6(string string_8, string string_9, string string_10)
	{
		Class72.string_1 = string_9;
		Class72.string_2 = string.Empty;
		Class72.dateTime_0 = DateTime.Now;
		Class72.string_3 = string.Empty;
		string text = string.Empty;
		string text2 = string.Empty;
		switch (string_10)
		{
		case "110":
			text = "0";
			text2 = "травма";
			break;
		case "80":
		case "100":
			text = "1";
			text2 = "оч. высокий";
			break;
		case "50":
			text = "2";
			text2 = "высокий";
			break;
		case "30":
			text = "3";
			text2 = "средний";
			break;
		case "10":
			text = "4";
			text2 = "низкий";
			break;
		}
		if (!string.IsNullOrEmpty(text))
		{
			Class72.string_3 = "<img src=http://image.neverlands.ru/gameplay/injury" + text + ".gif alt=\"% травматичности: " + text2 + "\" width=17 height=17 align=absmiddle>";
		}
		string text3 = Class12.smethod_1(string_8, "var logs = ", ";");
		if (text3 == null)
		{
			return;
		}
		string[] array = text3.Split(new string[2] { "\"Бой между\"", "\" начался" }, StringSplitOptions.None);
		if (array.Length != 3)
		{
			return;
		}
		string[] array2 = array[1].Split(new string[1] { "\" и\"" }, StringSplitOptions.None);
		if (array2.Length != 2)
		{
			return;
		}
		int num = 0;
		StringBuilder stringBuilder = new StringBuilder();
		while (true)
		{
			stringBuilder.Length = 0;
			int num2 = -1;
			while (true)
			{
				int num3 = array2[num].IndexOf('[', num2 + 1);
				if (num3 != -1)
				{
					num2 = array2[num].IndexOf(']', num3 + 1);
					if (num2 == -1)
					{
						goto IL_0260;
					}
					string[] array3 = array2[num].Substring(num3 + 1, num2 - num3 - 1).Split(new char[1] { ',' }, StringSplitOptions.None);
					string text4 = string.Empty;
					string value;
					if (array3.Length == 6)
					{
						text4 = array3[2].Substring(1, array3[2].Length - 2);
						value = text4 + "[" + array3[3] + "]";
					}
					else
					{
						value = "невидимки";
					}
					if (text4.Equals(Class72.class19_0.method_30(), StringComparison.OrdinalIgnoreCase))
					{
						break;
					}
					if (stringBuilder.Length != 0)
					{
						stringBuilder.Append(", ");
					}
					stringBuilder.Append(value);
				}
				if (num3 != -1)
				{
					continue;
				}
				goto IL_0260;
				IL_0260:
				Class72.string_2 = stringBuilder.ToString();
				try
				{
					return;
				}
				catch (InvalidOperationException)
				{
					return;
				}
			}
			num = 1;
		}
	}

	public long CalcRestoreAfterBoi()
	{
		Class72.class19_0.struct13_0.string_0 = LogBoi;
		double num = 0.0;
		if (Class72.class19_0.bool_49 && int_5 < Class72.class19_0.int_9)
		{
			num = (double)((int)((double)(Class72.class19_0.int_9 * int_2) / 100.0) - int_1) * Class72.class19_0.struct13_0.double_0 / (double)int_2;
		}
		if (Class72.class19_0.bool_50 && int_6 < Class72.class19_0.int_10)
		{
			double num2 = (double)((int)((double)(Class72.class19_0.int_10 * int_4) / 100.0) - int_3) * Class72.class19_0.struct13_0.double_0 / (double)int_4;
			if (num2 > num)
			{
				num = num2;
			}
		}
		if (!(num < 1.0))
		{
			return DateTime.Now.AddSeconds(num).Ticks;
		}
		return 0L;
	}

	private void method_16()
	{
		string text = Class12.smethod_1(string_2, "var logs = [", "];");
		if (string.IsNullOrEmpty(text))
		{
			return;
		}
		int num = text.IndexOf(']');
		if (num == -1)
		{
			return;
		}
		num = text.IndexOf(']', num + 1);
		if (num == -1)
		{
			return;
		}
		int num2 = text.LastIndexOf('[', num);
		if (num2 == -1)
		{
			return;
		}
		string[] array = text.Substring(num2 + 1, num - num2 - 1).Split(',');
		if (array.Length == 4 && array[0].Equals("8", StringComparison.Ordinal))
		{
			Class72.smethod_61(bool_54: true);
			if (!array[3].Equals("0", StringComparison.Ordinal))
			{
				Class72.smethod_51(bool_54: true);
			}
		}
	}
}
