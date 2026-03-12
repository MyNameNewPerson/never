using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using ABClient;
using ABClient.Lez;
using ABClient.MyProfile;
using ABClient.Profile;

internal sealed class Class19 : IComparable
{
	private static readonly ReaderWriterLock readerWriterLock_0 = new ReaderWriterLock();

	internal readonly SortedDictionary<string, Class1> sortedDictionary_0 = new SortedDictionary<string, Class1>();

	internal readonly List<Class69> list_0 = new List<Class69>();

	private readonly List<string> list_1 = new List<string>();

	private readonly List<string> list_2 = new List<string>();

	private string string_0;

	private string string_1;

	internal Class17 class17_0;

	internal Struct14 struct14_0;

	internal TSplitter tsplitter_0;

	internal string[] string_2;

	internal Struct13 struct13_0;

	internal TNavigator tnavigator_0;

	internal string[] string_3;

	internal TimeSpan timeSpan_0;

	internal TSound tsound_0;

	internal Struct16 struct16_0;

	private string string_4;

	private string string_5;

	private string string_6;

	private string string_7;

	private bool bool_0;

	private bool bool_1;

	private string string_8;

	private string string_9;

	private bool bool_2;

	private string string_10;

	private string string_11;

	private string string_12;

	private int int_0;

	private int int_1;

	private string string_13;

	private int[] int_2;

	private string[] string_14;

	private string string_15;

	private string string_16;

	private string string_17;

	private bool[] bool_3;

	private bool bool_4;

	private bool bool_5;

	private string string_18;

	private int int_3;

	private bool bool_6;

	private bool bool_7;

	private bool bool_8;

	private string string_19;

	private string string_20;

	private Enum0 enum0_0;

	private int int_4;

	private int int_5;

	private bool bool_9;

	private bool bool_10;

	private bool bool_11;

	private bool bool_12;

	private bool bool_13;

	private bool bool_14;

	private bool bool_15;

	private bool bool_16;

	private bool bool_17;

	private bool bool_18;

	private bool bool_19;

	private int int_6;

	private string string_21;

	private bool bool_20;

	private bool bool_21;

	private bool bool_22;

	private int int_7;

	private bool bool_23;

	private bool bool_24;

	private bool bool_25;

	private bool bool_26;

	private string string_22;

	private SortedList<string, Class76> sortedList_0;

	private bool bool_27;

	private bool bool_28;

	private bool bool_29;

	private bool bool_30;

	private bool bool_31;

	private bool bool_32;

	private bool bool_33;

	private bool bool_34;

	private bool bool_35;

	private bool bool_36;

	private bool bool_37;

	private bool bool_38;

	private bool bool_39;

	private bool bool_40;

	private bool bool_41;

	private bool bool_42;

	private bool bool_43;

	private bool bool_44;

	private bool bool_45;

	private bool bool_46;

	private bool bool_47;

	private string string_23;

	private int int_8;

	internal bool bool_48 = true;

	internal bool bool_49;

	internal bool bool_50;

	internal int int_9 = 100;

	internal int int_10 = 100;

	internal bool bool_51;

	internal bool bool_52 = true;

	internal int int_11 = 50;

	internal int int_12 = 50;

	internal bool bool_53 = true;

	internal LezSayType lezSayType_0;

	internal List<LezBotsGroup> list_3 = new List<LezBotsGroup>
	{
		new LezBotsGroup(1, 0)
	};

	internal bool bool_54;

	private string string_24;

	private long long_0;

	private int int_13;

	private int int_14;

	private string string_25;

	private string string_26;

	private string string_27;

	internal Class19()
	{
		method_31(string.Empty);
		method_33(string.Empty);
		method_35(string.Empty);
		method_37(string.Empty);
		method_189(string.Empty);
		method_191(DateTime.Now.Ticks);
		method_39(bool_55: false);
		method_41(bool_55: true);
		method_43(string.Empty);
		method_45(string.Empty);
		method_47(bool_55: false);
		method_49(string.Empty);
		method_51(string.Empty);
		method_53(string.Empty);
		method_55(9);
		method_57(5);
		method_59(string.Empty);
		method_61(new int[4] { 80, 150, 500, 7000 });
		method_63(new string[4] { "Лечить легкую за [1]?", "Лечить среднюю за [2]?", "Лечить тяж за [3]?", "Лечить боевую за [4]?" });
		method_65("Лечу [1]/[2]/[3], боевая - [4]");
		method_67("Поздравляю, не болей");
		method_69("Выйди из боя!");
		method_71(new bool[4] { true, true, true, true });
		method_73(bool_55: true);
		method_75(bool_55: false);
		method_77("Меня нет около компьютера. Отвечу позже.");
		method_79(20);
		method_81(bool_55: false);
		method_83(bool_55: true);
		method_85(bool_55: true);
		method_87("Любая удочка");
		method_89(string.Empty);
		method_91((Enum0)511);
		method_93(0);
		method_95(8);
		method_99(bool_55: true);
		method_101(bool_55: false);
		method_105(bool_55: true);
		method_107(bool_55: true);
		method_109(bool_55: true);
		method_111(bool_55: true);
		struct14_0 = new Struct14
		{
			formWindowState_0 = FormWindowState.Normal,
			int_0 = 0,
			int_1 = 0,
			int_2 = 0,
			int_3 = 0
		};
		class17_0 = new Class17
		{
			long_0 = DateTime.Now.Ticks,
			int_0 = DateTime.Now.DayOfYear,
			string_0 = string.Empty,
			list_0 = new List<Class16>(),
			long_2 = 0L,
			int_1 = 0,
			long_1 = 0L,
			long_3 = 0L,
			int_2 = 0,
			int_3 = 0
		};
		tsplitter_0 = new TSplitter
		{
			Collapsed = false,
			Width = 200
		};
		struct13_0 = new Struct13
		{
			double_0 = 2000.0,
			double_1 = 9000.0,
			long_0 = 0L,
			string_0 = string.Empty
		};
		tnavigator_0 = new TNavigator
		{
			AllowTeleports = true
		};
		struct16_0 = new Struct16
		{
			int_0 = 600,
			string_0 = "; Эта закомментированная строчка рекламы будет пропускаться"
		};
		method_41(bool_55: true);
		method_121(string.Empty);
		string_2 = new string[0];
		method_123(bool_55: true);
		method_125(bool_55: true);
		string_3 = new string[0];
		timeSpan_0 = new TimeSpan(0L);
		tsound_0 = new TSound
		{
			Enabled = true,
			DoPlayAlarm = true,
			DoPlayAttack = true,
			DoPlayDigits = true,
			DoPlayRefresh = true,
			DoPlaySndMsg = true,
			DoPlayTimer = true,
			DoPlayActionEnd = true
		};
		method_145(bool_55: true);
		method_147(bool_55: true);
		method_149(bool_55: true);
		method_151(bool_55: false);
		method_153(bool_55: true);
		method_155(bool_55: true);
		method_157(bool_55: true);
		method_159(bool_55: true);
		method_161(bool_55: false);
		method_163(bool_55: true);
		method_165(bool_55: true);
		method_167(bool_55: true);
		method_169(bool_55: true);
		method_171(bool_55: true);
		method_173(bool_55: true);
		method_175(bool_55: true);
		method_177(bool_55: true);
		method_179(bool_55: true);
		method_181(bool_55: true);
		method_183(bool_55: true);
		method_127(bool_55: false);
		method_129(84);
		method_131(bool_55: false);
		method_133(bool_55: false);
		method_185(string.Empty);
		method_135(bool_55: true);
		method_137(bool_55: true);
		method_139(string.Empty);
		method_143(bool_55: false);
		method_103(bool_55: false);
		method_195(1);
		method_193(100000);
		method_197(string.Empty);
		method_199(string.Empty);
		method_201(string.Empty);
	}

	internal string method_0()
	{
		return Path.GetFileNameWithoutExtension(string_0);
	}

	public override string ToString()
	{
		return method_30();
	}

	public int CompareTo(object obj)
	{
		if (obj != null && obj is Class19)
		{
			Class19 @class = (Class19)obj;
			if (method_190() > @class.method_190())
			{
				return -1;
			}
			if (method_190() >= @class.method_190())
			{
				return 0;
			}
			return 1;
		}
		return -1;
	}

	internal void method_1(string string_28)
	{
		if (string.IsNullOrEmpty(string_28))
		{
			throw new ArgumentNullException("password");
		}
		method_33(Class87.smethod_1(method_34(), string_28));
		method_37(Class87.smethod_1(method_188(), string_28));
		method_43(string_28);
	}

	internal void method_2(string string_28)
	{
		if (string.IsNullOrEmpty(string_28))
		{
			throw new ArgumentNullException("password");
		}
		method_35(Class87.smethod_0(method_32(), string_28));
		method_189(Class87.smethod_0(method_36(), string_28));
		method_43(string_28);
		method_45(Class87.smethod_4(string_28));
	}

	internal string method_3()
	{
		DateTime value = new DateTime(method_190());
		TimeSpan timeSpan = DateTime.Now.Subtract(value);
		if (timeSpan.TotalMinutes < 5.0)
		{
			return "менее 5 минут назад";
		}
		if (timeSpan.TotalHours < 1.0)
		{
			if (timeSpan.Minutes < 21)
			{
				return timeSpan.Minutes + " минут назад";
			}
			switch (timeSpan.Minutes % 10)
			{
			case 1:
				return timeSpan.Minutes + " минута назад";
			case 2:
			case 3:
			case 4:
				return timeSpan.Minutes + " минуты назад";
			default:
				return timeSpan.Minutes + " минут назад";
			}
		}
		if (timeSpan.TotalHours < 2.0)
		{
			return "час назад";
		}
		if (timeSpan.TotalHours < 5.0)
		{
			return timeSpan.Hours + " часа назад";
		}
		if (timeSpan.TotalDays < 1.0)
		{
			return timeSpan.Hours + " часов назад";
		}
		if (timeSpan.TotalDays < 5.0)
		{
			return timeSpan.Days + " дня назад";
		}
		if (timeSpan.TotalDays < 21.0)
		{
			return timeSpan.Days + " дней назад";
		}
		switch (timeSpan.Days % 10)
		{
		case 1:
			return timeSpan.Days + " день назад";
		case 2:
		case 3:
		case 4:
			return timeSpan.Days + " дня назад";
		default:
			return timeSpan.Days + " дней назад";
		}
	}

	internal void method_4(string string_28)
	{
		list_2.Remove(string_28);
		list_2.Insert(0, string_28);
		if (list_2.Count > 20)
		{
			list_2.RemoveRange(20, list_2.Count - 20);
		}
		string_3 = list_2.ToArray();
	}

	internal void method_5(string string_28)
	{
		list_2.Remove(string_28);
		string_3 = list_2.ToArray();
	}

	internal void method_6()
	{
		list_2.Clear();
		string_3 = list_2.ToArray();
	}

	internal string method_7(string string_28)
	{
		if (string_28 == null)
		{
			throw new ArgumentNullException("str");
		}
		StringBuilder stringBuilder = new StringBuilder(string_28);
		stringBuilder.Replace("[1]", method_60()[0].ToString(CultureInfo.InvariantCulture));
		stringBuilder.Replace("[2]", method_60()[1].ToString(CultureInfo.InvariantCulture));
		stringBuilder.Replace("[3]", method_60()[2].ToString(CultureInfo.InvariantCulture));
		stringBuilder.Replace("[4]", method_60()[3].ToString(CultureInfo.InvariantCulture));
		return stringBuilder.ToString();
	}

	internal bool method_8(string string_28)
	{
		if (string.IsNullOrEmpty(string_28))
		{
			throw new ArgumentNullException("fileName");
		}
		string_0 = string_28;
		if (!File.Exists(string_0))
		{
			return false;
		}
		XmlReaderSettings settings = new XmlReaderSettings
		{
			IgnoreComments = true,
			IgnoreWhitespace = true,
			ConformanceLevel = ConformanceLevel.Auto
		};
		list_3.Clear();
		XmlReader xmlReader = null;
		try
		{
			xmlReader = XmlReader.Create(string_0, settings);
			while (xmlReader.Read())
			{
				if (xmlReader.NodeType == XmlNodeType.Element)
				{
					method_9(xmlReader);
				}
			}
		}
		catch (IOException ex)
		{
			smethod_0(ex.Message);
		}
		catch (ArgumentNullException ex2)
		{
			smethod_0(ex2.Message);
		}
		catch (InvalidOperationException ex3)
		{
			smethod_0(ex3.Message);
		}
		catch (ArgumentException ex4)
		{
			smethod_0(ex4.Message);
		}
		catch (NotSupportedException ex5)
		{
			smethod_0(ex5.Message);
		}
		catch (UnauthorizedAccessException ex6)
		{
			smethod_0(ex6.Message);
		}
		catch (XmlException ex7)
		{
			smethod_0(ex7.Message);
		}
		finally
		{
			xmlReader?.Close();
		}
		string_2 = list_1.ToArray();
		list_1.Clear();
		string_3 = list_2.ToArray();
		if (method_140() == null)
		{
			method_141(new SortedList<string, Class76>());
		}
		if (list_3.Count == 0)
		{
			list_3.Add(new LezBotsGroup(1, 0));
		}
		return true;
	}

	private static void smethod_0(string string_28)
	{
		if (string.IsNullOrEmpty(string_28))
		{
			throw new ArgumentNullException("message");
		}
		MessageBox.Show(string_28, "Ошибка загрузки профайла", MessageBoxButtons.OK, MessageBoxIcon.Hand);
	}

	private void method_9(XmlReader xmlReader_0)
	{
		string name = xmlReader_0.Name;
		switch (Class0.smethod_0(name))
		{
		case 219531110u:
			if (name == "autowearcomplect")
			{
				xmlReader_0.Read();
				method_139(xmlReader_0.ReadContentAsString());
			}
			break;
		case 73179668u:
			if (name == "anticaptchakey")
			{
				xmlReader_0.Read();
				method_199(xmlReader_0.ReadContentAsString());
			}
			break;
		case 45849662u:
			if (name == "navigator")
			{
				tnavigator_0.AllowTeleports = xmlReader_0["allowteleports"] == null || Convert.ToBoolean(xmlReader_0["allowteleports"], CultureInfo.InvariantCulture);
			}
			break;
		case 328746714u:
		{
			if (!(name == "herbcell"))
			{
				break;
			}
			Class1 class2 = new Class1();
			string text7 = xmlReader_0["location"] ?? string.Empty;
			if (string.IsNullOrEmpty(text7))
			{
				break;
			}
			class2.string_0 = text7;
			string text8 = xmlReader_0["herbs"] ?? string.Empty;
			if (!string.IsNullOrEmpty(text7))
			{
				class2.string_1 = text8;
			}
			string s = xmlReader_0["lastview"] ?? string.Empty;
			if (!string.IsNullOrEmpty(text7) && long.TryParse(s, out var result7) && timeSpan_0 != TimeSpan.MinValue && result7 < DateTime.Now.Subtract(timeSpan_0).Ticks)
			{
				class2.long_0 = result7;
				if (TimeSpan.FromTicks(DateTime.Now.Subtract(timeSpan_0).Ticks - result7).TotalHours < 6.0 && !sortedDictionary_0.ContainsKey(text7))
				{
					sortedDictionary_0.Add(text7, class2);
				}
			}
			break;
		}
		case 235771284u:
			if (name == "sound")
			{
				tsound_0.Enabled = xmlReader_0["enabled"] == null || Convert.ToBoolean(xmlReader_0["enabled"], CultureInfo.InvariantCulture);
				tsound_0.DoPlayAlarm = xmlReader_0["alarm"] == null || Convert.ToBoolean(xmlReader_0["alarm"], CultureInfo.InvariantCulture);
				tsound_0.DoPlayAttack = xmlReader_0["attack"] == null || Convert.ToBoolean(xmlReader_0["attack"], CultureInfo.InvariantCulture);
				tsound_0.DoPlayDigits = xmlReader_0["digits"] == null || Convert.ToBoolean(xmlReader_0["digits"], CultureInfo.InvariantCulture);
				tsound_0.DoPlayRefresh = xmlReader_0["refresh"] == null || Convert.ToBoolean(xmlReader_0["refresh"], CultureInfo.InvariantCulture);
				tsound_0.DoPlaySndMsg = xmlReader_0["sndmsg"] == null || Convert.ToBoolean(xmlReader_0["sndmsg"], CultureInfo.InvariantCulture);
				tsound_0.DoPlayTimer = xmlReader_0["timer"] == null || Convert.ToBoolean(xmlReader_0["timer"], CultureInfo.InvariantCulture);
				tsound_0.DoPlayActionEnd = xmlReader_0["actionEnd"] == null || Convert.ToBoolean(xmlReader_0["actionEnd"], CultureInfo.InvariantCulture);
			}
			break;
		case 635154918u:
			if (name == "showtraybaloons")
			{
				xmlReader_0.Read();
				method_125(xmlReader_0.ReadContentAsBoolean());
			}
			break;
		case 372761901u:
			if (name == "apptimer")
			{
				Class69 @class = new Class69();
				string text = xmlReader_0["triggertime"];
				if (text != null && long.TryParse(text, out var result))
				{
					@class.dateTime_0 = DateTime.FromBinary(result);
				}
				@class.string_0 = xmlReader_0["description"] ?? string.Empty;
				@class.string_3 = xmlReader_0["complect"] ?? string.Empty;
				@class.string_1 = xmlReader_0["potion"] ?? string.Empty;
				string text2 = xmlReader_0["drinkcount"];
				if (text2 != null && int.TryParse(text2, out var result2))
				{
					@class.int_0 = result2;
				}
				string text3 = xmlReader_0["isrecur"];
				if (text3 != null && bool.TryParse(text3, out var result3))
				{
					@class.bool_0 = result3;
				}
				string text4 = xmlReader_0["isherb"];
				if (text4 != null && bool.TryParse(text4, out var result4))
				{
					@class.bool_1 = result4;
				}
				string text5 = xmlReader_0["isisland"];
				if (text5 != null && bool.TryParse(text5, out var result5))
				{
					@class.bool_2 = result5;
				}
				string text6 = xmlReader_0["everyminutes"];
				if (text6 != null && int.TryParse(text6, out var result6))
				{
					@class.int_1 = result6;
				}
				@class.string_2 = xmlReader_0["destination"] ?? string.Empty;
				list_0.Add(@class);
			}
			break;
		case 1179735265u:
			if (name == "docontacttrace")
			{
				xmlReader_0.Read();
				method_143(xmlReader_0.ReadContentAsBoolean());
			}
			break;
		case 934784183u:
			if (name == "mapset")
			{
				method_12(xmlReader_0);
			}
			break;
		case 645810194u:
			if (name == "showoverwarning")
			{
				xmlReader_0.Read();
				method_133(xmlReader_0.ReadContentAsBoolean());
			}
			break;
		case 1297235587u:
			if (name == "LezDoDrinkMa")
			{
				xmlReader_0.Read();
				bool_52 = xmlReader_0.ReadContentAsBoolean();
			}
			break;
		case 1243126923u:
			if (name == "dostopondig")
			{
				xmlReader_0.Read();
				method_183(xmlReader_0.ReadContentAsBoolean());
			}
			break;
		case 1406916175u:
			if (name == "autoadv")
			{
				struct16_0.int_0 = ((xmlReader_0["sec"] != null) ? Convert.ToInt32(xmlReader_0["sec"], CultureInfo.InvariantCulture) : 600);
				struct16_0.string_0 = Class11.smethod_3(xmlReader_0["phraz"] ?? string.Empty);
			}
			break;
		case 1345696626u:
			if (name == "notepad")
			{
				xmlReader_0.Read();
				method_121(Class11.smethod_3(xmlReader_0.ReadContentAsString()));
			}
			break;
		case 1462320915u:
			if (name == "removebuildingimages")
			{
				method_18(xmlReader_0);
			}
			break;
		case 1452259336u:
			if (name == "LezDoWinTimeout")
			{
				xmlReader_0.Read();
				bool_53 = xmlReader_0.ReadContentAsBoolean();
			}
			break;
		case 1420371012u:
			if (name == "dotray")
			{
				xmlReader_0.Read();
				method_123(xmlReader_0.ReadContentAsBoolean());
			}
			break;
		case 1518288945u:
			if (name == "ContactsToClan")
			{
				xmlReader_0.Read();
				bool_54 = xmlReader_0.ReadContentAsBoolean();
			}
			break;
		case 1516183277u:
			if (name == "LezDoDrinkHp")
			{
				xmlReader_0.Read();
				bool_51 = xmlReader_0.ReadContentAsBoolean();
			}
			break;
		case 1565298446u:
			if (name == "dnvnvlimit")
			{
				xmlReader_0.Read();
				method_193(xmlReader_0.ReadContentAsInt());
			}
			break;
		case 1539948879u:
			if (name == "SkinAuto")
			{
				xmlReader_0.Read();
				method_103(xmlReader_0.ReadContentAsBoolean());
			}
			break;
		case 1640191549u:
			if (name == "LezBotsGroup")
			{
				LezBotsGroup lezBotsGroup = new LezBotsGroup(1, 0);
				int.TryParse(xmlReader_0["Id"] ?? "0", out lezBotsGroup.Id);
				int.TryParse(xmlReader_0["MinimalLevel"] ?? "0", out lezBotsGroup.MinimalLevel);
				bool.TryParse(xmlReader_0["DoRestoreHp"] ?? "true", out lezBotsGroup.DoRestoreHp);
				bool.TryParse(xmlReader_0["DoRestoreMa"] ?? "true", out lezBotsGroup.DoRestoreMa);
				int.TryParse(xmlReader_0["RestoreHp"] ?? "50", out lezBotsGroup.RestoreHp);
				int.TryParse(xmlReader_0["RestoreMa"] ?? "50", out lezBotsGroup.RestoreMa);
				bool.TryParse(xmlReader_0["DoAbilBlocks"] ?? "true", out lezBotsGroup.DoAbilBlocks);
				bool.TryParse(xmlReader_0["DoAbilHits"] ?? "true", out lezBotsGroup.DoAbilHits);
				bool.TryParse(xmlReader_0["DoMagHits"] ?? "true", out lezBotsGroup.DoMagHits);
				int.TryParse(xmlReader_0["MagHits"] ?? "5", out lezBotsGroup.MagHits);
				bool.TryParse(xmlReader_0["DoMagBlocks"] ?? "false", out lezBotsGroup.DoMagBlocks);
				bool.TryParse(xmlReader_0["DoHits"] ?? "true", out lezBotsGroup.DoHits);
				bool.TryParse(xmlReader_0["DoBlocks"] ?? "true", out lezBotsGroup.DoBlocks);
				bool.TryParse(xmlReader_0["DoMiscAbils"] ?? "true", out lezBotsGroup.DoMiscAbils);
				lezBotsGroup.SpellsHits = LezSpellCollection.SpellsFromString(xmlReader_0["SpellsHits"] ?? string.Empty);
				lezBotsGroup.SpellsBlocks = LezSpellCollection.SpellsFromString(xmlReader_0["SpellsBlocks"] ?? string.Empty);
				lezBotsGroup.SpellsRestoreHp = LezSpellCollection.SpellsFromString(xmlReader_0["SpellsRestoreHp"] ?? string.Empty);
				lezBotsGroup.SpellsRestoreMa = LezSpellCollection.SpellsFromString(xmlReader_0["SpellsRestoreMa"] ?? string.Empty);
				lezBotsGroup.SpellsMisc = LezSpellCollection.SpellsFromString(xmlReader_0["SpellsMisc"] ?? string.Empty);
				bool.TryParse(xmlReader_0["DoStopNow"] ?? "false", out lezBotsGroup.DoStopNow);
				bool.TryParse(xmlReader_0["DoStopLowHp"] ?? "false", out lezBotsGroup.DoStopLowHp);
				bool.TryParse(xmlReader_0["DoStopLowMa"] ?? "false", out lezBotsGroup.DoStopLowMa);
				int.TryParse(xmlReader_0["StopLowHp"] ?? "25", out lezBotsGroup.StopLowHp);
				int.TryParse(xmlReader_0["StopLowMa"] ?? "25", out lezBotsGroup.StopLowMa);
				bool.TryParse(xmlReader_0["DoExit"] ?? "false", out lezBotsGroup.DoExit);
				bool.TryParse(xmlReader_0["DoExitDoExitRisky"] ?? "true", out lezBotsGroup.DoExitRisky);
				list_3.Add(lezBotsGroup);
			}
			break;
		case 1618501362u:
			if (name == "user")
			{
				method_10(xmlReader_0);
			}
			break;
		case 2069523199u:
			if (name == "autodrinkblazorder")
			{
				xmlReader_0.Read();
				method_187(xmlReader_0.ReadContentAsInt());
				if (method_186() < 0 || method_186() > 1)
				{
					method_187(0);
				}
			}
			break;
		case 1735721852u:
			if (name == "LezDoAutoboi")
			{
				xmlReader_0.Read();
				bool_48 = xmlReader_0.ReadContentAsBoolean();
			}
			break;
		case 2344162032u:
			if (name == "cure")
			{
				method_13(xmlReader_0);
			}
			break;
		case 2107770459u:
			if (name == "proxy")
			{
				method_11(xmlReader_0);
			}
			break;
		case 2481552184u:
			if (name == "inv")
			{
				method_145(xmlReader_0["doInvPack"] == null || Convert.ToBoolean(xmlReader_0["doInvPack"]));
				method_147(xmlReader_0["doInvPackDolg"] == null || Convert.ToBoolean(xmlReader_0["doInvPackDolg"]));
				method_149(xmlReader_0["doSummDolg"] == null || Convert.ToBoolean(xmlReader_0["doSummDolg"]));
			}
			break;
		case 2445859947u:
			if (name == "dnvfrequency")
			{
				xmlReader_0.Read();
				method_195(xmlReader_0.ReadContentAsInt());
			}
			break;
		case 2708649949u:
			if (name == "window")
			{
				struct14_0.formWindowState_0 = FormWindowState.Normal;
				string value = xmlReader_0["state"] ?? string.Empty;
				try
				{
					struct14_0.formWindowState_0 = (FormWindowState)Enum.Parse(typeof(FormWindowState), value);
				}
				catch (ArgumentException)
				{
				}
				struct14_0.int_0 = ((xmlReader_0["left"] != null) ? Convert.ToInt32(xmlReader_0["left"], CultureInfo.InvariantCulture) : 0);
				struct14_0.int_1 = ((xmlReader_0["top"] != null) ? Convert.ToInt32(xmlReader_0["top"], CultureInfo.InvariantCulture) : 0);
				struct14_0.int_2 = ((xmlReader_0["width"] != null) ? Convert.ToInt32(xmlReader_0["width"], CultureInfo.InvariantCulture) : 0);
				struct14_0.int_3 = ((xmlReader_0["height"] != null) ? Convert.ToInt32(xmlReader_0["height"], CultureInfo.InvariantCulture) : 0);
			}
			break;
		case 2679393754u:
			if (name == "dopromptexit")
			{
				xmlReader_0.Read();
				method_41(xmlReader_0.ReadContentAsBoolean());
			}
			break;
		case 2566336076u:
			if (name == "tab")
			{
				xmlReader_0.Read();
				list_1.Add(xmlReader_0.ReadContentAsString());
			}
			break;
		case 2797743142u:
			if (name == "splitter")
			{
				tsplitter_0.Collapsed = xmlReader_0["collapsed"] != null && Convert.ToBoolean(xmlReader_0["collapsed"], CultureInfo.InvariantCulture);
				tsplitter_0.Width = ((xmlReader_0["width"] == null) ? 200 : Convert.ToInt32(xmlReader_0["width"], CultureInfo.InvariantCulture));
			}
			break;
		case 2722888107u:
			if (name == "chat")
			{
				method_16(xmlReader_0);
			}
			break;
		case 2865675760u:
			if (name == "autoanswer")
			{
				method_14(xmlReader_0);
			}
			break;
		case 2845063486u:
			if (name == "LezDoWaitMa")
			{
				xmlReader_0.Read();
				bool_50 = xmlReader_0.ReadContentAsBoolean();
			}
			break;
		case 2895940796u:
			if (name == "LezDoWaitHp")
			{
				xmlReader_0.Read();
				bool_49 = xmlReader_0.ReadContentAsBoolean();
			}
			break;
		case 2889338768u:
			if (name == "autofish")
			{
				method_15(xmlReader_0);
			}
			break;
		case 3112627837u:
			if (name == "contactentry")
			{
				if (!int.TryParse(xmlReader_0["classid"] ?? string.Empty, out var result8))
				{
					result8 = 0;
				}
				if (!int.TryParse(xmlReader_0["toolid"] ?? string.Empty, out var result9))
				{
					result9 = 0;
				}
				Class76 class3 = new Class76(xmlReader_0["name"] ?? string.Empty, xmlReader_0["id"] ?? string.Empty, result8, result9, xmlReader_0["sign"] ?? string.Empty, xmlReader_0["clan"] ?? string.Empty, xmlReader_0["align"] ?? string.Empty, Class11.smethod_3(xmlReader_0["comments"] ?? string.Empty), xmlReader_0["tracing"] == null || Convert.ToBoolean(xmlReader_0["tracing"], CultureInfo.InvariantCulture), xmlReader_0["level"] ?? string.Empty);
				if (method_140() == null)
				{
					method_141(new SortedList<string, Class76>());
				}
				if (!method_140().ContainsKey(class3.method_0().ToLower()))
				{
					method_140().Add(class3.method_0().ToLower(), class3);
				}
			}
			break;
		case 2946569472u:
			if (name == "highlightresources")
			{
				xmlReader_0.Read();
				method_197(xmlReader_0.ReadContentAsString());
			}
			break;
		case 3203418485u:
			if (name == "pers")
			{
				struct13_0.double_0 = ((xmlReader_0["inthp"] != null) ? Convert.ToDouble(xmlReader_0["inthp"], CultureInfo.InvariantCulture) : 2000.0);
				struct13_0.double_1 = ((xmlReader_0["intma"] != null) ? Convert.ToDouble(xmlReader_0["intma"], CultureInfo.InvariantCulture) : 9000.0);
				struct13_0.long_0 = ((xmlReader_0["ready"] != null) ? Convert.ToInt64(xmlReader_0["ready"], CultureInfo.InvariantCulture) : 0L);
				struct13_0.string_0 = xmlReader_0["logready"] ?? string.Empty;
			}
			break;
		case 3182463664u:
			if (name == "autoforestcells")
			{
				xmlReader_0.Read();
				method_201(xmlReader_0.ReadContentAsString());
			}
			break;
		case 3379424283u:
			if (name == "itemdrop")
			{
				Class16 item = new Class16
				{
					string_0 = (xmlReader_0["name"] ?? string.Empty),
					int_0 = ((xmlReader_0["count"] == null) ? 1 : Convert.ToInt32(xmlReader_0["count"]))
				};
				class17_0.list_0.Add(item);
			}
			break;
		case 3272727017u:
			if (name == "favlocation")
			{
				xmlReader_0.Read();
				list_2.Add(xmlReader_0.ReadContentAsString());
			}
			break;
		case 3400111249u:
			if (name == "LezWaitHp")
			{
				xmlReader_0.Read();
				int_9 = xmlReader_0.ReadContentAsInt();
			}
			break;
		case 3396316223u:
			if (name == "dorob")
			{
				xmlReader_0.Read();
				method_135(xmlReader_0.ReadContentAsBoolean());
			}
			break;
		case 3385062321u:
			if (name == "dotexlog")
			{
				xmlReader_0.Read();
				method_117(xmlReader_0.ReadContentAsBoolean());
			}
			break;
		case 3450885391u:
			if (name == "LezWaitMa")
			{
				xmlReader_0.Read();
				int_10 = xmlReader_0.ReadContentAsInt();
			}
			break;
		case 3423496402u:
			if (name == "fastactions")
			{
				method_151(xmlReader_0["simple"] != null && Convert.ToBoolean(xmlReader_0["simple"], CultureInfo.InvariantCulture));
				method_153(xmlReader_0["blood"] == null || Convert.ToBoolean(xmlReader_0["blood"], CultureInfo.InvariantCulture));
				method_155(xmlReader_0["ultimate"] == null || Convert.ToBoolean(xmlReader_0["ultimate"], CultureInfo.InvariantCulture));
				method_157(xmlReader_0["closedultimate"] == null || Convert.ToBoolean(xmlReader_0["closedultimate"], CultureInfo.InvariantCulture));
				method_159(xmlReader_0["closed"] == null || Convert.ToBoolean(xmlReader_0["closed"], CultureInfo.InvariantCulture));
				method_161(xmlReader_0["fist"] != null && Convert.ToBoolean(xmlReader_0["fist"], CultureInfo.InvariantCulture));
				method_163(xmlReader_0["closedfist"] == null || Convert.ToBoolean(xmlReader_0["closedfist"], CultureInfo.InvariantCulture));
				method_165(xmlReader_0["opennevid"] == null || Convert.ToBoolean(xmlReader_0["opennevid"], CultureInfo.InvariantCulture));
				method_167(xmlReader_0["poison"] == null || Convert.ToBoolean(xmlReader_0["poison"], CultureInfo.InvariantCulture));
				method_169(xmlReader_0["imp"] == null || Convert.ToBoolean(xmlReader_0["imp"], CultureInfo.InvariantCulture));
				method_171(xmlReader_0["strong"] == null || Convert.ToBoolean(xmlReader_0["strong"], CultureInfo.InvariantCulture));
				method_173(xmlReader_0["nevid"] == null || Convert.ToBoolean(xmlReader_0["nevid"], CultureInfo.InvariantCulture));
				method_175(xmlReader_0["fog"] == null || Convert.ToBoolean(xmlReader_0["fog"], CultureInfo.InvariantCulture));
				method_177(xmlReader_0["zas"] == null || Convert.ToBoolean(xmlReader_0["zas"], CultureInfo.InvariantCulture));
				method_179(xmlReader_0["portal"] == null || Convert.ToBoolean(xmlReader_0["portal"], CultureInfo.InvariantCulture));
				method_181(xmlReader_0["totem"] == null || Convert.ToBoolean(xmlReader_0["totem"], CultureInfo.InvariantCulture));
			}
			break;
		case 3658943597u:
			if (name == "autodrinkblaz")
			{
				method_127(xmlReader_0["do"] != null && Convert.ToBoolean(xmlReader_0["do"], CultureInfo.InvariantCulture));
				method_129((xmlReader_0["tied"] != null) ? Convert.ToInt32(xmlReader_0["tied"], CultureInfo.InvariantCulture) : 84);
				method_131(xmlReader_0["food"] != null && Convert.ToBoolean(xmlReader_0["food"], CultureInfo.InvariantCulture));
			}
			break;
		case 3543872151u:
			if (name == "stat")
			{
				class17_0.string_0 = xmlReader_0["drop"] ?? string.Empty;
				class17_0.long_0 = ((xmlReader_0["lastreset"] == null) ? 0L : Convert.ToInt64(xmlReader_0["lastreset"]));
				class17_0.int_0 = ((xmlReader_0["lastupdateday"] == null) ? DateTime.Now.DayOfYear : Convert.ToInt32(xmlReader_0["lastupdateday"]));
				class17_0.bool_0 = xmlReader_0["reset"] != null && Convert.ToBoolean(xmlReader_0["reset"]);
				class17_0.bool_1 = xmlReader_0["savetofile"] != null && Convert.ToBoolean(xmlReader_0["savetofile"]);
				class17_0.long_2 = ((xmlReader_0["savedtraffic"] == null) ? 0L : Convert.ToInt64(xmlReader_0["savedtraffic"]));
				class17_0.int_1 = ((xmlReader_0["show"] != null) ? Convert.ToInt32(xmlReader_0["show"]) : 0);
				class17_0.long_1 = ((xmlReader_0["traffic"] == null) ? 0L : Convert.ToInt64(xmlReader_0["traffic"]));
				class17_0.long_3 = ((xmlReader_0["xp"] == null) ? 0L : Convert.ToInt64(xmlReader_0["xp"]));
				class17_0.int_2 = ((xmlReader_0["nv"] != null) ? Convert.ToInt32(xmlReader_0["nv"]) : 0);
				class17_0.int_3 = ((xmlReader_0["fishnv"] != null) ? Convert.ToInt32(xmlReader_0["fishnv"]) : 0);
			}
			break;
		case 3759757516u:
			if (name == "selectedrightpanel")
			{
				xmlReader_0.Read();
				method_119(xmlReader_0.ReadContentAsInt());
			}
			break;
		case 3705026834u:
			if (name == "LezDrinkHp")
			{
				xmlReader_0.Read();
				int_11 = xmlReader_0.ReadContentAsInt();
			}
			break;
		case 3894076784u:
			if (name == "lightforum")
			{
				method_17(xmlReader_0);
			}
			break;
		case 3780749654u:
			if (name == "doautocure")
			{
				xmlReader_0.Read();
				method_137(xmlReader_0.ReadContentAsBoolean());
			}
			break;
		case 3923871356u:
			if (name == "LezDrinkMa")
			{
				xmlReader_0.Read();
				int_12 = xmlReader_0.ReadContentAsInt();
			}
			break;
		case 3921085219u:
			if (name == "LezSay")
			{
				xmlReader_0.Read();
				lezSayType_0 = (LezSayType)Enum.Parse(typeof(LezSayType), xmlReader_0.ReadContentAsString());
			}
			break;
		case 4059656342u:
			if (name == "dohttplog")
			{
				xmlReader_0.Read();
				method_115(xmlReader_0.ReadContentAsBoolean());
			}
			break;
		case 3991693699u:
			if (name == "complects")
			{
				xmlReader_0.Read();
				method_185(xmlReader_0.ReadContentAsString());
			}
			break;
		}
	}

	private void method_10(XmlReader xmlReader_0)
	{
		method_31(xmlReader_0["name"] ?? string.Empty);
		method_33(xmlReader_0["password"] ?? string.Empty);
		method_37(xmlReader_0["flash"] ?? string.Empty);
		method_35(xmlReader_0["encryptedpassword"] ?? string.Empty);
		method_189(xmlReader_0["encryptedflash"] ?? string.Empty);
		method_45(xmlReader_0["hash"] ?? string.Empty);
		if (!long.TryParse(xmlReader_0["lastlogon"], out var result))
		{
			result = DateTime.Now.Ticks;
		}
		method_191(result);
		if (!bool.TryParse(xmlReader_0["autologon"], out var result2))
		{
			result2 = false;
		}
		method_39(result2);
		if (!bool.TryParse(xmlReader_0["dopromptexit"], out var result3))
		{
			result3 = true;
		}
		method_41(result3);
	}

	private void method_11(XmlReader xmlReader_0)
	{
		if (!bool.TryParse(xmlReader_0["active"], out var result))
		{
			result = false;
		}
		method_47(result);
		method_49(xmlReader_0["address"] ?? string.Empty);
		method_51(xmlReader_0["username"] ?? string.Empty);
		method_53(xmlReader_0["password"] ?? string.Empty);
	}

	private void method_12(XmlReader xmlReader_0)
	{
		if (!int.TryParse(xmlReader_0["bigwidth"], out var result))
		{
			result = 9;
		}
		if (result % 2 == 0)
		{
			result = 9;
		}
		method_55((result < 3 || result > 19) ? 9 : result);
		if (!int.TryParse(xmlReader_0["bigheight"], out var result2))
		{
			result2 = 5;
		}
		if (result2 % 2 == 0)
		{
			result2 = 5;
		}
		method_57((result2 < 3 || result2 > 19) ? 5 : result2);
		method_59(xmlReader_0["location"] ?? string.Empty);
	}

	private void method_13(XmlReader xmlReader_0)
	{
		if (!int.TryParse(xmlReader_0["nv1"], out var result))
		{
			result = 80;
		}
		if (result < 5 || result > 80)
		{
			result = 80;
		}
		method_60()[0] = result;
		if (!int.TryParse(xmlReader_0["nv2"], out var result2))
		{
			result2 = 150;
		}
		if (result2 < 8 || result2 > 150)
		{
			result2 = 150;
		}
		method_60()[1] = result2;
		if (!int.TryParse(xmlReader_0["nv3"], out var result3))
		{
			result3 = 500;
		}
		if (result3 < 11 || result3 > 500)
		{
			result3 = 500;
		}
		method_60()[2] = result3;
		if (!int.TryParse(xmlReader_0["nv4"], out var result4))
		{
			result4 = 7000;
		}
		if (result4 < 300 || result4 > 7000)
		{
			result4 = 7000;
		}
		method_60()[3] = result4;
		method_62()[0] = xmlReader_0["cask1"] ?? "Лечить легкую за [1]?";
		method_62()[1] = xmlReader_0["cask2"] ?? "Лечить среднюю за [2]?";
		method_62()[2] = xmlReader_0["cask3"] ?? "Лечить тяж за [3]?";
		method_62()[3] = xmlReader_0["cask4"] ?? "Лечить боевую за [4]?";
		if (!bool.TryParse(xmlReader_0["e1"], out var result5))
		{
			result5 = true;
		}
		method_70()[0] = result5;
		if (!bool.TryParse(xmlReader_0["e2"], out var result6))
		{
			result6 = true;
		}
		method_70()[1] = result6;
		if (!bool.TryParse(xmlReader_0["e3"], out var result7))
		{
			result7 = true;
		}
		method_70()[2] = result7;
		if (!bool.TryParse(xmlReader_0["e4"], out var result8))
		{
			result8 = true;
		}
		method_70()[3] = result8;
		method_65(xmlReader_0["cadv"] ?? string.Empty);
		method_67(xmlReader_0["cafter"] ?? string.Empty);
		method_69(xmlReader_0["cboi"] ?? string.Empty);
		if (!bool.TryParse(xmlReader_0["d04"], out var result9))
		{
			result9 = true;
		}
		method_73(result9);
	}

	private void method_14(XmlReader xmlReader_0)
	{
		if (!bool.TryParse(xmlReader_0["active"], out var result))
		{
			result = false;
		}
		method_75(result);
		if (xmlReader_0["answers"] != null)
		{
			method_77(xmlReader_0["answers"]);
		}
		Class73.smethod_0(method_76());
	}

	private void method_15(XmlReader xmlReader_0)
	{
		if (!int.TryParse(xmlReader_0["tiedhigh"], out var result))
		{
			result = 20;
		}
		method_79(result);
		if (!bool.TryParse(xmlReader_0["tiedzero"], out var result2))
		{
			result2 = false;
		}
		method_81(result2);
		if (!bool.TryParse(xmlReader_0["stopoverw"], out var result3))
		{
			result3 = true;
		}
		method_83(result3);
		if (!bool.TryParse(xmlReader_0["autowear"], out var result4))
		{
			result4 = true;
		}
		method_85(result4);
		method_87(xmlReader_0["hand1"] ?? "Любая удочка");
		method_89(xmlReader_0["hand2"] ?? string.Empty);
		method_91((!int.TryParse(xmlReader_0["enabledprims"], out var result5)) ? ((Enum0)511) : ((Enum0)result5));
		if (!int.TryParse(xmlReader_0["um"], out var result6))
		{
			result6 = 0;
		}
		method_93(result6);
		if (!int.TryParse(xmlReader_0["maxlevelbots"], out var result7))
		{
			result7 = 8;
		}
		method_95(result7);
		if (!bool.TryParse(xmlReader_0["chatreportcolor"], out var result8))
		{
			result8 = true;
		}
		method_99(result8);
		if (!bool.TryParse(xmlReader_0["auto"], out var result9))
		{
			result9 = false;
		}
		method_101(result9);
	}

	private void method_16(XmlReader xmlReader_0)
	{
		if (!bool.TryParse(xmlReader_0["keepgame"], out var result))
		{
			result = true;
		}
		method_107(result);
		method_107(xmlReader_0["keeplog"] == null || Convert.ToBoolean(xmlReader_0["keeplog"], CultureInfo.InvariantCulture));
		method_105(xmlReader_0["keepgame"] == null || Convert.ToBoolean(xmlReader_0["keepgame"], CultureInfo.InvariantCulture));
		if (!bool.TryParse(xmlReader_0["dolevels"], out var result2))
		{
			result2 = true;
		}
		method_113(result2);
	}

	private void method_17(XmlReader xmlReader_0)
	{
		xmlReader_0.Read();
		method_109(xmlReader_0.ReadContentAsBoolean());
	}

	private void method_18(XmlReader xmlReader_0)
	{
		xmlReader_0.Read();
		method_111(xmlReader_0.ReadContentAsBoolean());
	}

	private void method_19()
	{
		method_191(DateTime.Now.Ticks);
		XmlWriterSettings settings = new XmlWriterSettings
		{
			Indent = true,
			Encoding = Encoding.UTF8
		};
		XmlWriter xmlWriter = null;
		try
		{
			if (string.IsNullOrEmpty(string_0))
			{
				do
				{
					string_0 = Path.Combine(Application.StartupPath, Path.GetFileNameWithoutExtension(Path.GetRandomFileName()) + Class68.string_6);
				}
				while (File.Exists(string_0));
			}
			if (string.IsNullOrEmpty(string_1))
			{
				string_1 = Path.ChangeExtension(string_0, ".temprofile");
			}
			xmlWriter = XmlWriter.Create(string_1, settings);
			xmlWriter.WriteStartDocument();
			xmlWriter.WriteStartElement("profile");
			method_21(xmlWriter);
			method_22(xmlWriter);
			method_23(xmlWriter);
			method_24(xmlWriter);
			method_25(xmlWriter);
			method_26(xmlWriter);
			method_27(xmlWriter);
			method_28(xmlWriter);
			method_29(xmlWriter);
			xmlWriter.WriteStartElement("window");
			string text = struct14_0.formWindowState_0.ToString();
			xmlWriter.WriteStartAttribute("state");
			xmlWriter.WriteString(text);
			xmlWriter.WriteEndAttribute();
			xmlWriter.WriteStartAttribute("left");
			xmlWriter.WriteValue(struct14_0.int_0);
			xmlWriter.WriteEndAttribute();
			xmlWriter.WriteStartAttribute("top");
			xmlWriter.WriteValue(struct14_0.int_1);
			xmlWriter.WriteEndAttribute();
			xmlWriter.WriteStartAttribute("width");
			xmlWriter.WriteValue(struct14_0.int_2);
			xmlWriter.WriteEndAttribute();
			xmlWriter.WriteStartAttribute("height");
			xmlWriter.WriteValue(struct14_0.int_3);
			xmlWriter.WriteEndAttribute();
			xmlWriter.WriteEndElement();
			xmlWriter.WriteStartElement("stat");
			xmlWriter.WriteStartAttribute("show");
			xmlWriter.WriteValue(class17_0.int_1);
			xmlWriter.WriteEndAttribute();
			xmlWriter.WriteStartAttribute("lastreset");
			xmlWriter.WriteValue(class17_0.long_0);
			xmlWriter.WriteEndAttribute();
			xmlWriter.WriteStartAttribute("lastupdateday");
			xmlWriter.WriteValue(class17_0.int_0);
			xmlWriter.WriteEndAttribute();
			xmlWriter.WriteStartAttribute("reset");
			xmlWriter.WriteValue(class17_0.bool_0);
			xmlWriter.WriteEndAttribute();
			xmlWriter.WriteStartAttribute("savetofile");
			xmlWriter.WriteValue(class17_0.bool_1);
			xmlWriter.WriteEndAttribute();
			xmlWriter.WriteStartAttribute("traffic");
			xmlWriter.WriteValue(class17_0.long_1);
			xmlWriter.WriteEndAttribute();
			xmlWriter.WriteStartAttribute("savedtraffic");
			xmlWriter.WriteValue(class17_0.long_2);
			xmlWriter.WriteEndAttribute();
			xmlWriter.WriteStartAttribute("drop");
			xmlWriter.WriteString(class17_0.string_0 ?? string.Empty);
			xmlWriter.WriteEndAttribute();
			xmlWriter.WriteStartAttribute("xp");
			xmlWriter.WriteValue(class17_0.long_3);
			xmlWriter.WriteEndAttribute();
			xmlWriter.WriteStartAttribute("nv");
			xmlWriter.WriteValue(class17_0.int_2);
			xmlWriter.WriteEndAttribute();
			xmlWriter.WriteStartAttribute("fishnv");
			xmlWriter.WriteValue(class17_0.int_3);
			xmlWriter.WriteEndAttribute();
			xmlWriter.WriteEndElement();
			xmlWriter.WriteStartElement("itemdrops");
			for (int i = 0; i < class17_0.list_0.Count; i++)
			{
				xmlWriter.WriteStartElement("itemdrop");
				xmlWriter.WriteStartAttribute("name");
				xmlWriter.WriteString(class17_0.list_0[i].string_0);
				xmlWriter.WriteEndAttribute();
				if (class17_0.list_0[i].int_0 > 1)
				{
					xmlWriter.WriteStartAttribute("count");
					xmlWriter.WriteValue(class17_0.list_0[i].int_0);
					xmlWriter.WriteEndAttribute();
				}
				xmlWriter.WriteEndElement();
			}
			xmlWriter.WriteEndElement();
			xmlWriter.WriteStartElement("splitter");
			xmlWriter.WriteStartAttribute("width");
			xmlWriter.WriteValue(tsplitter_0.Width);
			xmlWriter.WriteEndAttribute();
			xmlWriter.WriteStartAttribute("collapsed");
			xmlWriter.WriteValue(tsplitter_0.Collapsed);
			xmlWriter.WriteEndAttribute();
			xmlWriter.WriteEndElement();
			xmlWriter.WriteStartElement("dopromptexit");
			xmlWriter.WriteValue(method_40());
			xmlWriter.WriteEndElement();
			xmlWriter.WriteStartElement("showoverwarning");
			xmlWriter.WriteValue(method_132());
			xmlWriter.WriteEndElement();
			xmlWriter.WriteStartElement("dohttplog");
			xmlWriter.WriteValue(method_114());
			xmlWriter.WriteEndElement();
			xmlWriter.WriteStartElement("dotexlog");
			xmlWriter.WriteValue(method_116());
			xmlWriter.WriteEndElement();
			xmlWriter.WriteStartElement("selectedrightpanel");
			xmlWriter.WriteValue(method_118());
			xmlWriter.WriteEndElement();
			xmlWriter.WriteStartElement("notepad");
			xmlWriter.WriteString(Class11.smethod_2(method_120() ?? string.Empty));
			xmlWriter.WriteEndElement();
			xmlWriter.WriteStartElement("tabs");
			for (int j = 0; j < string_2.Length; j++)
			{
				xmlWriter.WriteStartElement("tab");
				xmlWriter.WriteString(string_2[j] ?? string.Empty);
				xmlWriter.WriteEndElement();
			}
			xmlWriter.WriteEndElement();
			xmlWriter.WriteStartElement("favlocations");
			for (int k = 0; k < string_3.Length; k++)
			{
				xmlWriter.WriteStartElement("favlocation");
				xmlWriter.WriteString(string_3[k] ?? string.Empty);
				xmlWriter.WriteEndElement();
			}
			xmlWriter.WriteEndElement();
			xmlWriter.WriteStartElement("dotray");
			xmlWriter.WriteValue(method_122());
			xmlWriter.WriteEndElement();
			xmlWriter.WriteStartElement("showtraybaloons");
			xmlWriter.WriteValue(method_124());
			xmlWriter.WriteEndElement();
			xmlWriter.WriteStartElement("complects");
			xmlWriter.WriteString(method_184());
			xmlWriter.WriteEndElement();
			xmlWriter.WriteStartElement("pers");
			xmlWriter.WriteStartAttribute("inthp");
			xmlWriter.WriteValue(struct13_0.double_0);
			xmlWriter.WriteEndAttribute();
			xmlWriter.WriteStartAttribute("intma");
			xmlWriter.WriteValue(struct13_0.double_1);
			xmlWriter.WriteEndAttribute();
			xmlWriter.WriteStartAttribute("ready");
			xmlWriter.WriteValue(struct13_0.long_0);
			xmlWriter.WriteEndAttribute();
			xmlWriter.WriteStartAttribute("logready");
			xmlWriter.WriteString(struct13_0.string_0 ?? string.Empty);
			xmlWriter.WriteEndAttribute();
			xmlWriter.WriteEndElement();
			xmlWriter.WriteStartElement("autodrinkblaz");
			xmlWriter.WriteStartAttribute("do");
			xmlWriter.WriteValue(method_126());
			xmlWriter.WriteEndAttribute();
			xmlWriter.WriteStartAttribute("tied");
			xmlWriter.WriteValue(method_128());
			xmlWriter.WriteEndAttribute();
			xmlWriter.WriteStartAttribute("food");
			xmlWriter.WriteValue(method_130());
			xmlWriter.WriteEndAttribute();
			xmlWriter.WriteEndElement();
			xmlWriter.WriteStartElement("navigator");
			xmlWriter.WriteStartAttribute("allowteleports");
			xmlWriter.WriteValue(tnavigator_0.AllowTeleports);
			xmlWriter.WriteEndAttribute();
			xmlWriter.WriteEndElement();
			if (sortedDictionary_0.Count > 0)
			{
				xmlWriter.WriteStartElement("herbcells");
				KeyValuePair<string, Class1>[] array = new KeyValuePair<string, Class1>[sortedDictionary_0.Count];
				sortedDictionary_0.CopyTo(array, 0);
				for (int l = 0; l < array.Length; l++)
				{
					xmlWriter.WriteStartElement("herbcell");
					xmlWriter.WriteStartAttribute("location");
					xmlWriter.WriteString(array[l].Value.string_0);
					xmlWriter.WriteEndAttribute();
					xmlWriter.WriteStartAttribute("herbs");
					xmlWriter.WriteString(array[l].Value.string_1);
					xmlWriter.WriteEndAttribute();
					xmlWriter.WriteStartAttribute("lastview");
					xmlWriter.WriteValue(array[l].Value.long_0);
					xmlWriter.WriteEndAttribute();
					xmlWriter.WriteEndElement();
				}
				xmlWriter.WriteEndElement();
			}
			xmlWriter.WriteStartElement("dorob");
			xmlWriter.WriteValue(method_134());
			xmlWriter.WriteEndElement();
			xmlWriter.WriteStartElement("doautocure");
			xmlWriter.WriteValue(method_136());
			xmlWriter.WriteEndElement();
			xmlWriter.WriteStartElement("autowearcomplect");
			xmlWriter.WriteString(method_138());
			xmlWriter.WriteEndElement();
			xmlWriter.WriteStartElement("dostopondig");
			xmlWriter.WriteValue(method_182());
			xmlWriter.WriteEndElement();
			xmlWriter.WriteStartElement("autodrinkblazorder");
			xmlWriter.WriteValue(method_186());
			xmlWriter.WriteEndElement();
			xmlWriter.WriteStartElement("contacts");
			try
			{
				ContactsManager.Rwl.AcquireWriterLock(5000);
				try
				{
					if (method_140() == null)
					{
						method_141(new SortedList<string, Class76>());
					}
					foreach (KeyValuePair<string, Class76> item in method_140())
					{
						xmlWriter.WriteStartElement("contactentry");
						xmlWriter.WriteStartAttribute("name");
						xmlWriter.WriteString(item.Value.method_0() ?? string.Empty);
						xmlWriter.WriteEndAttribute();
						xmlWriter.WriteStartAttribute("id");
						xmlWriter.WriteString(item.Value.method_2() ?? string.Empty);
						xmlWriter.WriteEndAttribute();
						xmlWriter.WriteStartAttribute("classid");
						xmlWriter.WriteValue(item.Value.method_8());
						xmlWriter.WriteEndAttribute();
						xmlWriter.WriteStartAttribute("toolid");
						xmlWriter.WriteValue(item.Value.method_10());
						xmlWriter.WriteEndAttribute();
						xmlWriter.WriteStartAttribute("sign");
						xmlWriter.WriteString(item.Value.method_12() ?? string.Empty);
						xmlWriter.WriteEndAttribute();
						xmlWriter.WriteStartAttribute("clan");
						xmlWriter.WriteString(item.Value.method_16() ?? string.Empty);
						xmlWriter.WriteEndAttribute();
						xmlWriter.WriteStartAttribute("align");
						xmlWriter.WriteString(item.Value.method_14() ?? string.Empty);
						xmlWriter.WriteEndAttribute();
						xmlWriter.WriteStartAttribute("comments");
						xmlWriter.WriteString(Class11.smethod_2(item.Value.method_4() ?? string.Empty));
						xmlWriter.WriteEndAttribute();
						xmlWriter.WriteStartAttribute("tracing");
						xmlWriter.WriteValue(item.Value.method_6());
						xmlWriter.WriteEndAttribute();
						xmlWriter.WriteStartAttribute("level");
						xmlWriter.WriteString(item.Value.method_18() ?? string.Empty);
						xmlWriter.WriteEndAttribute();
						xmlWriter.WriteEndElement();
					}
				}
				finally
				{
					ContactsManager.Rwl.ReleaseWriterLock();
				}
			}
			catch (ApplicationException)
			{
			}
			xmlWriter.WriteEndElement();
			xmlWriter.WriteStartElement("apptimers");
			Class69[] array2 = Class71.smethod_2();
			foreach (Class69 @class in array2)
			{
				xmlWriter.WriteStartElement("apptimer");
				xmlWriter.WriteStartAttribute("triggertime");
				xmlWriter.WriteValue(@class.dateTime_0.ToBinary());
				xmlWriter.WriteEndAttribute();
				if (!string.IsNullOrEmpty(@class.string_0))
				{
					xmlWriter.WriteStartAttribute("description");
					xmlWriter.WriteString(@class.string_0);
					xmlWriter.WriteEndAttribute();
				}
				if (!string.IsNullOrEmpty(@class.string_3))
				{
					xmlWriter.WriteStartAttribute("complect");
					xmlWriter.WriteString(@class.string_3);
					xmlWriter.WriteEndAttribute();
				}
				if (!string.IsNullOrEmpty(@class.string_1))
				{
					xmlWriter.WriteStartAttribute("potion");
					xmlWriter.WriteString(@class.string_1);
					xmlWriter.WriteEndAttribute();
				}
				if (@class.int_0 > 0)
				{
					xmlWriter.WriteStartAttribute("drinkcount");
					xmlWriter.WriteValue(@class.int_0);
					xmlWriter.WriteEndAttribute();
				}
				if (@class.bool_0)
				{
					xmlWriter.WriteStartAttribute("isrecur");
					xmlWriter.WriteValue(@class.bool_0);
					xmlWriter.WriteEndAttribute();
				}
				if (@class.int_1 > 0)
				{
					xmlWriter.WriteStartAttribute("everyminutes");
					xmlWriter.WriteValue(@class.int_1);
					xmlWriter.WriteEndAttribute();
				}
				if (!string.IsNullOrEmpty(@class.string_2))
				{
					xmlWriter.WriteStartAttribute("destination");
					xmlWriter.WriteString(@class.string_2);
					xmlWriter.WriteEndAttribute();
				}
				if (@class.bool_1)
				{
					xmlWriter.WriteStartAttribute("isherb");
					xmlWriter.WriteValue(@class.bool_1);
					xmlWriter.WriteEndAttribute();
				}
				if (@class.bool_2)
				{
					xmlWriter.WriteStartAttribute("isisland");
					xmlWriter.WriteValue(@class.bool_2);
					xmlWriter.WriteEndAttribute();
				}
				xmlWriter.WriteEndElement();
			}
			xmlWriter.WriteEndElement();
			xmlWriter.WriteStartElement("sound");
			xmlWriter.WriteStartAttribute("enabled");
			xmlWriter.WriteValue(tsound_0.Enabled);
			xmlWriter.WriteEndAttribute();
			xmlWriter.WriteStartAttribute("alarm");
			xmlWriter.WriteValue(tsound_0.DoPlayAlarm);
			xmlWriter.WriteEndAttribute();
			xmlWriter.WriteStartAttribute("attack");
			xmlWriter.WriteValue(tsound_0.DoPlayAttack);
			xmlWriter.WriteEndAttribute();
			xmlWriter.WriteStartAttribute("digits");
			xmlWriter.WriteValue(tsound_0.DoPlayDigits);
			xmlWriter.WriteEndAttribute();
			xmlWriter.WriteStartAttribute("refresh");
			xmlWriter.WriteValue(tsound_0.DoPlayRefresh);
			xmlWriter.WriteEndAttribute();
			xmlWriter.WriteStartAttribute("sndmsg");
			xmlWriter.WriteValue(tsound_0.DoPlaySndMsg);
			xmlWriter.WriteEndAttribute();
			xmlWriter.WriteStartAttribute("timer");
			xmlWriter.WriteValue(tsound_0.DoPlayTimer);
			xmlWriter.WriteEndAttribute();
			xmlWriter.WriteStartAttribute("actionEnd");
			xmlWriter.WriteValue(tsound_0.DoPlayActionEnd);
			xmlWriter.WriteEndAttribute();
			xmlWriter.WriteEndElement();
			xmlWriter.WriteStartElement("autoadv");
			xmlWriter.WriteStartAttribute("sec");
			xmlWriter.WriteValue(struct16_0.int_0);
			xmlWriter.WriteEndAttribute();
			xmlWriter.WriteStartAttribute("phraz");
			xmlWriter.WriteString(Class11.smethod_2(struct16_0.string_0 ?? string.Empty));
			xmlWriter.WriteEndAttribute();
			xmlWriter.WriteEndElement();
			xmlWriter.WriteStartElement("inv");
			xmlWriter.WriteStartAttribute("doInvPack");
			xmlWriter.WriteValue(method_144());
			xmlWriter.WriteEndAttribute();
			xmlWriter.WriteStartAttribute("doSummDolg");
			xmlWriter.WriteValue(method_148());
			xmlWriter.WriteEndAttribute();
			xmlWriter.WriteStartAttribute("doInvPackDolg");
			xmlWriter.WriteValue(method_146());
			xmlWriter.WriteEndAttribute();
			xmlWriter.WriteEndElement();
			xmlWriter.WriteStartElement("fastactions");
			xmlWriter.WriteStartAttribute("simple");
			xmlWriter.WriteValue(method_150());
			xmlWriter.WriteEndAttribute();
			xmlWriter.WriteStartAttribute("blood");
			xmlWriter.WriteValue(method_152());
			xmlWriter.WriteEndAttribute();
			xmlWriter.WriteStartAttribute("ultimate");
			xmlWriter.WriteValue(method_154());
			xmlWriter.WriteEndAttribute();
			xmlWriter.WriteStartAttribute("closedultimate");
			xmlWriter.WriteValue(method_156());
			xmlWriter.WriteEndAttribute();
			xmlWriter.WriteStartAttribute("closed");
			xmlWriter.WriteValue(method_158());
			xmlWriter.WriteEndAttribute();
			xmlWriter.WriteStartAttribute("fist");
			xmlWriter.WriteValue(method_160());
			xmlWriter.WriteEndAttribute();
			xmlWriter.WriteStartAttribute("closedfist");
			xmlWriter.WriteValue(method_162());
			xmlWriter.WriteEndAttribute();
			xmlWriter.WriteStartAttribute("opennevid");
			xmlWriter.WriteValue(method_164());
			xmlWriter.WriteEndAttribute();
			xmlWriter.WriteStartAttribute("poison");
			xmlWriter.WriteValue(method_166());
			xmlWriter.WriteEndAttribute();
			xmlWriter.WriteStartAttribute("imp");
			xmlWriter.WriteValue(method_168());
			xmlWriter.WriteEndAttribute();
			xmlWriter.WriteStartAttribute("strong");
			xmlWriter.WriteValue(method_170());
			xmlWriter.WriteEndAttribute();
			xmlWriter.WriteStartAttribute("nevid");
			xmlWriter.WriteValue(method_172());
			xmlWriter.WriteEndAttribute();
			xmlWriter.WriteStartAttribute("fog");
			xmlWriter.WriteValue(method_174());
			xmlWriter.WriteEndAttribute();
			xmlWriter.WriteStartAttribute("zas");
			xmlWriter.WriteValue(method_176());
			xmlWriter.WriteEndAttribute();
			xmlWriter.WriteStartAttribute("portal");
			xmlWriter.WriteValue(method_178());
			xmlWriter.WriteEndAttribute();
			xmlWriter.WriteStartAttribute("totem");
			xmlWriter.WriteValue(method_180());
			xmlWriter.WriteEndAttribute();
			xmlWriter.WriteEndElement();
			xmlWriter.WriteStartElement("LezDoAutoboi");
			xmlWriter.WriteValue(bool_48);
			xmlWriter.WriteEndElement();
			xmlWriter.WriteStartElement("LezDoWaitHp");
			xmlWriter.WriteValue(bool_49);
			xmlWriter.WriteEndElement();
			xmlWriter.WriteStartElement("LezDoWaitMa");
			xmlWriter.WriteValue(bool_50);
			xmlWriter.WriteEndElement();
			xmlWriter.WriteStartElement("LezWaitHp");
			xmlWriter.WriteValue(int_9);
			xmlWriter.WriteEndElement();
			xmlWriter.WriteStartElement("LezWaitMa");
			xmlWriter.WriteValue(int_10);
			xmlWriter.WriteEndElement();
			xmlWriter.WriteStartElement("LezDoDrinkHp");
			xmlWriter.WriteValue(bool_51);
			xmlWriter.WriteEndElement();
			xmlWriter.WriteStartElement("LezDoDrinkMa");
			xmlWriter.WriteValue(bool_52);
			xmlWriter.WriteEndElement();
			xmlWriter.WriteStartElement("LezDrinkHp");
			xmlWriter.WriteValue(int_11);
			xmlWriter.WriteEndElement();
			xmlWriter.WriteStartElement("LezDrinkMa");
			xmlWriter.WriteValue(int_12);
			xmlWriter.WriteEndElement();
			xmlWriter.WriteStartElement("LezDoWinTimeout");
			xmlWriter.WriteValue(bool_53);
			xmlWriter.WriteEndElement();
			xmlWriter.WriteStartElement("LezSay");
			xmlWriter.WriteString(lezSayType_0.ToString());
			xmlWriter.WriteEndElement();
			if (Class72.class19_0 != null && Class72.class19_0.list_3 != null)
			{
				xmlWriter.WriteStartElement("LezBotsGroups");
				foreach (LezBotsGroup item2 in Class72.class19_0.list_3)
				{
					xmlWriter.WriteStartElement("LezBotsGroup");
					xmlWriter.WriteStartAttribute("Id");
					xmlWriter.WriteValue(item2.Id);
					xmlWriter.WriteEndAttribute();
					xmlWriter.WriteStartAttribute("MinimalLevel");
					xmlWriter.WriteValue(item2.MinimalLevel);
					xmlWriter.WriteEndAttribute();
					xmlWriter.WriteStartAttribute("DoRestoreHp");
					xmlWriter.WriteValue(item2.DoRestoreHp);
					xmlWriter.WriteEndAttribute();
					xmlWriter.WriteStartAttribute("DoRestoreMa");
					xmlWriter.WriteValue(item2.DoRestoreMa);
					xmlWriter.WriteEndAttribute();
					xmlWriter.WriteStartAttribute("RestoreHp");
					xmlWriter.WriteValue(item2.RestoreHp);
					xmlWriter.WriteEndAttribute();
					xmlWriter.WriteStartAttribute("RestoreMa");
					xmlWriter.WriteValue(item2.RestoreMa);
					xmlWriter.WriteEndAttribute();
					xmlWriter.WriteStartAttribute("DoAbilBlocks");
					xmlWriter.WriteValue(item2.DoAbilBlocks);
					xmlWriter.WriteEndAttribute();
					xmlWriter.WriteStartAttribute("DoAbilHits");
					xmlWriter.WriteValue(item2.DoAbilHits);
					xmlWriter.WriteEndAttribute();
					xmlWriter.WriteStartAttribute("DoMagHits");
					xmlWriter.WriteValue(item2.DoMagHits);
					xmlWriter.WriteEndAttribute();
					xmlWriter.WriteStartAttribute("MagHits");
					xmlWriter.WriteValue(item2.MagHits);
					xmlWriter.WriteEndAttribute();
					xmlWriter.WriteStartAttribute("DoMagBlocks");
					xmlWriter.WriteValue(item2.DoMagBlocks);
					xmlWriter.WriteEndAttribute();
					xmlWriter.WriteStartAttribute("DoHits");
					xmlWriter.WriteValue(item2.DoHits);
					xmlWriter.WriteEndAttribute();
					xmlWriter.WriteStartAttribute("DoBlocks");
					xmlWriter.WriteValue(item2.DoBlocks);
					xmlWriter.WriteEndAttribute();
					xmlWriter.WriteStartAttribute("DoMiscAbils");
					xmlWriter.WriteValue(item2.DoMiscAbils);
					xmlWriter.WriteEndAttribute();
					xmlWriter.WriteStartAttribute("SpellsHits");
					xmlWriter.WriteValue(LezSpellCollection.SpellsToString(item2.SpellsHits));
					xmlWriter.WriteEndAttribute();
					xmlWriter.WriteStartAttribute("SpellsBlocks");
					xmlWriter.WriteValue(LezSpellCollection.SpellsToString(item2.SpellsBlocks));
					xmlWriter.WriteEndAttribute();
					xmlWriter.WriteStartAttribute("SpellsRestoreHp");
					xmlWriter.WriteValue(LezSpellCollection.SpellsToString(item2.SpellsRestoreHp));
					xmlWriter.WriteEndAttribute();
					xmlWriter.WriteStartAttribute("SpellsRestoreMa");
					xmlWriter.WriteValue(LezSpellCollection.SpellsToString(item2.SpellsRestoreMa));
					xmlWriter.WriteEndAttribute();
					xmlWriter.WriteStartAttribute("SpellsMisc");
					xmlWriter.WriteValue(LezSpellCollection.SpellsToString(item2.SpellsMisc));
					xmlWriter.WriteEndAttribute();
					xmlWriter.WriteStartAttribute("DoStopNow");
					xmlWriter.WriteValue(item2.DoStopNow);
					xmlWriter.WriteEndAttribute();
					xmlWriter.WriteStartAttribute("DoStopLowHp");
					xmlWriter.WriteValue(item2.DoStopLowHp);
					xmlWriter.WriteEndAttribute();
					xmlWriter.WriteStartAttribute("DoStopLowMa");
					xmlWriter.WriteValue(item2.DoStopLowMa);
					xmlWriter.WriteEndAttribute();
					xmlWriter.WriteStartAttribute("StopLowHp");
					xmlWriter.WriteValue(item2.StopLowHp);
					xmlWriter.WriteEndAttribute();
					xmlWriter.WriteStartAttribute("StopLowMa");
					xmlWriter.WriteValue(item2.StopLowMa);
					xmlWriter.WriteEndAttribute();
					xmlWriter.WriteStartAttribute("DoExit");
					xmlWriter.WriteValue(item2.DoExit);
					xmlWriter.WriteEndAttribute();
					xmlWriter.WriteStartAttribute("DoExitDoExitRisky");
					xmlWriter.WriteValue(item2.DoExitRisky);
					xmlWriter.WriteEndAttribute();
					xmlWriter.WriteEndElement();
				}
				xmlWriter.WriteEndElement();
			}
			xmlWriter.WriteStartElement("docontacttrace");
			xmlWriter.WriteValue(method_142());
			xmlWriter.WriteEndElement();
			xmlWriter.WriteStartElement("ContactsToClan");
			xmlWriter.WriteValue(bool_54);
			xmlWriter.WriteEndElement();
			xmlWriter.WriteStartElement("SkinAuto");
			xmlWriter.WriteValue(method_102());
			xmlWriter.WriteEndElement();
			xmlWriter.WriteStartElement("dnvfrequency");
			xmlWriter.WriteValue(method_194());
			xmlWriter.WriteEndElement();
			xmlWriter.WriteStartElement("dnvnvlimit");
			xmlWriter.WriteValue(method_192());
			xmlWriter.WriteEndElement();
			xmlWriter.WriteStartElement("highlightresources");
			xmlWriter.WriteString(method_196());
			xmlWriter.WriteEndElement();
			xmlWriter.WriteStartElement("anticaptchakey");
			xmlWriter.WriteString(method_198());
			xmlWriter.WriteEndElement();
			xmlWriter.WriteStartElement("autoforestcells");
			xmlWriter.WriteString(method_200());
			xmlWriter.WriteEndElement();
			xmlWriter.WriteEndElement();
			xmlWriter.WriteEndDocument();
			xmlWriter.Flush();
			xmlWriter.Close();
			xmlWriter = null;
			if (File.Exists(string_0))
			{
				File.Delete(string_0);
			}
			File.Move(string_1, string_0);
		}
		catch (IOException ex2)
		{
			smethod_1(ex2.Message);
		}
		catch (ArgumentNullException ex3)
		{
			smethod_1(ex3.Message);
		}
		catch (InvalidOperationException ex4)
		{
			smethod_1(ex4.Message);
		}
		catch (ArgumentException ex5)
		{
			smethod_1(ex5.Message);
		}
		catch (NotSupportedException ex6)
		{
			smethod_1(ex6.Message);
		}
		catch (UnauthorizedAccessException ex7)
		{
			smethod_1(ex7.Message);
		}
		finally
		{
			xmlWriter?.Close();
		}
	}

	internal void method_20()
	{
		try
		{
			readerWriterLock_0.AcquireWriterLock(5000);
			try
			{
				method_19();
			}
			finally
			{
				readerWriterLock_0.ReleaseWriterLock();
			}
		}
		catch (ApplicationException)
		{
		}
	}

	private static void smethod_1(string string_28)
	{
		MessageBox.Show(string_28, "Ошибка сохранения профайла", MessageBoxButtons.OK, MessageBoxIcon.Hand);
	}

	private void method_21(XmlWriter xmlWriter_0)
	{
		xmlWriter_0.WriteStartElement("user");
		if (!string.IsNullOrEmpty(method_30()))
		{
			xmlWriter_0.WriteStartAttribute("name");
			xmlWriter_0.WriteString(method_30());
			xmlWriter_0.WriteEndAttribute();
		}
		if (string.IsNullOrEmpty(method_44()))
		{
			if (!string.IsNullOrEmpty(method_32()))
			{
				xmlWriter_0.WriteStartAttribute("password");
				xmlWriter_0.WriteString(method_32());
				xmlWriter_0.WriteEndAttribute();
			}
			if (!string.IsNullOrEmpty(method_36()))
			{
				xmlWriter_0.WriteStartAttribute("flash");
				xmlWriter_0.WriteString(method_36());
				xmlWriter_0.WriteEndAttribute();
			}
		}
		else
		{
			xmlWriter_0.WriteStartAttribute("hash");
			xmlWriter_0.WriteString(method_44());
			xmlWriter_0.WriteEndAttribute();
			if (!string.IsNullOrEmpty(method_34()))
			{
				xmlWriter_0.WriteStartAttribute("encryptedpassword");
				xmlWriter_0.WriteString(method_34());
				xmlWriter_0.WriteEndAttribute();
			}
			if (!string.IsNullOrEmpty(method_188()))
			{
				xmlWriter_0.WriteStartAttribute("encryptedflash");
				xmlWriter_0.WriteString(method_188());
				xmlWriter_0.WriteEndAttribute();
			}
		}
		if (method_38())
		{
			xmlWriter_0.WriteStartAttribute("autologon");
			xmlWriter_0.WriteValue(method_38());
			xmlWriter_0.WriteEndAttribute();
		}
		if (!method_40())
		{
			xmlWriter_0.WriteStartAttribute("dopromptexit");
			xmlWriter_0.WriteValue(method_40());
			xmlWriter_0.WriteEndAttribute();
		}
		xmlWriter_0.WriteStartAttribute("lastlogon");
		xmlWriter_0.WriteValue(method_190());
		xmlWriter_0.WriteEndAttribute();
		xmlWriter_0.WriteEndElement();
	}

	private void method_22(XmlWriter xmlWriter_0)
	{
		xmlWriter_0.WriteStartElement("proxy");
		if (method_46())
		{
			xmlWriter_0.WriteStartAttribute("active");
			xmlWriter_0.WriteValue(method_46());
			xmlWriter_0.WriteEndAttribute();
		}
		if (!string.IsNullOrEmpty(method_48()))
		{
			xmlWriter_0.WriteStartAttribute("address");
			xmlWriter_0.WriteString(method_48());
			xmlWriter_0.WriteEndAttribute();
		}
		if (!string.IsNullOrEmpty(method_50()))
		{
			xmlWriter_0.WriteStartAttribute("username");
			xmlWriter_0.WriteString(method_50());
			xmlWriter_0.WriteEndAttribute();
		}
		if (!string.IsNullOrEmpty(method_52()))
		{
			xmlWriter_0.WriteStartAttribute("password");
			xmlWriter_0.WriteString(method_52());
			xmlWriter_0.WriteEndAttribute();
		}
		xmlWriter_0.WriteEndElement();
	}

	private void method_23(XmlWriter xmlWriter_0)
	{
		xmlWriter_0.WriteStartElement("mapset");
		if (method_54() != 9)
		{
			xmlWriter_0.WriteStartAttribute("bigwidth");
			xmlWriter_0.WriteValue(method_54());
			xmlWriter_0.WriteEndAttribute();
		}
		if (method_56() != 5)
		{
			xmlWriter_0.WriteStartAttribute("bigheight");
			xmlWriter_0.WriteValue(method_56());
			xmlWriter_0.WriteEndAttribute();
		}
		if (!string.IsNullOrEmpty(method_58()))
		{
			xmlWriter_0.WriteStartAttribute("location");
			xmlWriter_0.WriteString(method_58());
			xmlWriter_0.WriteEndAttribute();
		}
		xmlWriter_0.WriteEndElement();
	}

	private void method_24(XmlWriter xmlWriter_0)
	{
		xmlWriter_0.WriteStartElement("cure");
		if (method_60()[0] != 80)
		{
			xmlWriter_0.WriteStartAttribute("nv1");
			xmlWriter_0.WriteValue(method_60()[0]);
			xmlWriter_0.WriteEndAttribute();
		}
		if (method_60()[1] != 150)
		{
			xmlWriter_0.WriteStartAttribute("nv2");
			xmlWriter_0.WriteValue(method_60()[1]);
			xmlWriter_0.WriteEndAttribute();
		}
		if (method_60()[2] != 500)
		{
			xmlWriter_0.WriteStartAttribute("nv3");
			xmlWriter_0.WriteValue(method_60()[2]);
			xmlWriter_0.WriteEndAttribute();
		}
		if (method_60()[3] != 7000)
		{
			xmlWriter_0.WriteStartAttribute("nv4");
			xmlWriter_0.WriteValue(method_60()[3]);
			xmlWriter_0.WriteEndAttribute();
		}
		if (!string.IsNullOrEmpty(method_62()[0]))
		{
			xmlWriter_0.WriteStartAttribute("cask1");
			xmlWriter_0.WriteString(method_62()[0]);
			xmlWriter_0.WriteEndAttribute();
		}
		if (!string.IsNullOrEmpty(method_62()[1]))
		{
			xmlWriter_0.WriteStartAttribute("cask2");
			xmlWriter_0.WriteString(method_62()[1]);
			xmlWriter_0.WriteEndAttribute();
		}
		if (!string.IsNullOrEmpty(method_62()[2]))
		{
			xmlWriter_0.WriteStartAttribute("cask3");
			xmlWriter_0.WriteString(method_62()[2]);
			xmlWriter_0.WriteEndAttribute();
		}
		if (!string.IsNullOrEmpty(method_62()[3]))
		{
			xmlWriter_0.WriteStartAttribute("cask4");
			xmlWriter_0.WriteString(method_62()[3]);
			xmlWriter_0.WriteEndAttribute();
		}
		if (!string.IsNullOrEmpty(method_64()))
		{
			xmlWriter_0.WriteStartAttribute("cadv");
			xmlWriter_0.WriteString(method_64());
			xmlWriter_0.WriteEndAttribute();
		}
		if (!string.IsNullOrEmpty(method_66()))
		{
			xmlWriter_0.WriteStartAttribute("cafter");
			xmlWriter_0.WriteString(method_66());
			xmlWriter_0.WriteEndAttribute();
		}
		if (!string.IsNullOrEmpty(method_68()))
		{
			xmlWriter_0.WriteStartAttribute("cboi");
			xmlWriter_0.WriteString(method_68());
			xmlWriter_0.WriteEndAttribute();
		}
		if (!method_70()[0])
		{
			xmlWriter_0.WriteStartAttribute("e1");
			xmlWriter_0.WriteValue(method_70()[0]);
			xmlWriter_0.WriteEndAttribute();
		}
		if (!method_70()[1])
		{
			xmlWriter_0.WriteStartAttribute("e2");
			xmlWriter_0.WriteValue(method_70()[1]);
			xmlWriter_0.WriteEndAttribute();
		}
		if (!method_70()[2])
		{
			xmlWriter_0.WriteStartAttribute("e3");
			xmlWriter_0.WriteValue(method_70()[2]);
			xmlWriter_0.WriteEndAttribute();
		}
		if (!method_70()[3])
		{
			xmlWriter_0.WriteStartAttribute("e4");
			xmlWriter_0.WriteValue(method_70()[3]);
			xmlWriter_0.WriteEndAttribute();
		}
		if (!method_72())
		{
			xmlWriter_0.WriteStartAttribute("d04");
			xmlWriter_0.WriteValue(method_72());
			xmlWriter_0.WriteEndAttribute();
		}
		xmlWriter_0.WriteEndElement();
	}

	private void method_25(XmlWriter xmlWriter_0)
	{
		xmlWriter_0.WriteStartElement("autoanswer");
		xmlWriter_0.WriteStartAttribute("active");
		xmlWriter_0.WriteValue(method_74());
		xmlWriter_0.WriteEndAttribute();
		xmlWriter_0.WriteStartAttribute("answers");
		xmlWriter_0.WriteString(method_76());
		xmlWriter_0.WriteEndAttribute();
		xmlWriter_0.WriteEndElement();
	}

	private void method_26(XmlWriter xmlWriter_0)
	{
		xmlWriter_0.WriteStartElement("autofish");
		xmlWriter_0.WriteStartAttribute("tiedhigh");
		xmlWriter_0.WriteValue(method_78());
		xmlWriter_0.WriteEndAttribute();
		xmlWriter_0.WriteStartAttribute("tiedzero");
		xmlWriter_0.WriteValue(method_80());
		xmlWriter_0.WriteEndAttribute();
		xmlWriter_0.WriteStartAttribute("stopoverw");
		xmlWriter_0.WriteValue(method_82());
		xmlWriter_0.WriteEndAttribute();
		xmlWriter_0.WriteStartAttribute("autowear");
		xmlWriter_0.WriteValue(method_84());
		xmlWriter_0.WriteEndAttribute();
		xmlWriter_0.WriteStartAttribute("hand1");
		xmlWriter_0.WriteString(method_86());
		xmlWriter_0.WriteEndAttribute();
		xmlWriter_0.WriteStartAttribute("hand2");
		xmlWriter_0.WriteString(method_88());
		xmlWriter_0.WriteEndAttribute();
		xmlWriter_0.WriteStartAttribute("enabledprims");
		xmlWriter_0.WriteValue((int)method_90());
		xmlWriter_0.WriteEndAttribute();
		xmlWriter_0.WriteStartAttribute("um");
		xmlWriter_0.WriteValue(method_92());
		xmlWriter_0.WriteEndAttribute();
		if (method_94() != 8)
		{
			xmlWriter_0.WriteStartAttribute("maxlevelbots");
			xmlWriter_0.WriteValue(method_94());
			xmlWriter_0.WriteEndAttribute();
		}
		if (!method_98())
		{
			xmlWriter_0.WriteStartAttribute("chatreportcolor");
			xmlWriter_0.WriteValue(method_98());
			xmlWriter_0.WriteEndAttribute();
		}
		if (method_100())
		{
			xmlWriter_0.WriteStartAttribute("auto");
			xmlWriter_0.WriteValue(method_100());
			xmlWriter_0.WriteEndAttribute();
		}
		xmlWriter_0.WriteEndElement();
	}

	private void method_27(XmlWriter xmlWriter_0)
	{
		xmlWriter_0.WriteStartElement("chat");
		if (!method_104())
		{
			xmlWriter_0.WriteStartAttribute("keepgame");
			xmlWriter_0.WriteValue(method_104());
			xmlWriter_0.WriteEndAttribute();
		}
		if (!method_106())
		{
			xmlWriter_0.WriteStartAttribute("keeplog");
			xmlWriter_0.WriteValue(method_106());
			xmlWriter_0.WriteEndAttribute();
		}
		if (!method_112())
		{
			xmlWriter_0.WriteStartAttribute("dolevels");
			xmlWriter_0.WriteValue(method_112());
			xmlWriter_0.WriteEndAttribute();
		}
		xmlWriter_0.WriteEndElement();
	}

	private void method_28(XmlWriter xmlWriter_0)
	{
		xmlWriter_0.WriteStartElement("lightforum");
		xmlWriter_0.WriteValue(method_108());
		xmlWriter_0.WriteEndElement();
	}

	private void method_29(XmlWriter xmlWriter_0)
	{
		xmlWriter_0.WriteStartElement("removebuildingimages");
		xmlWriter_0.WriteValue(method_110());
		xmlWriter_0.WriteEndElement();
	}

	internal string method_30()
	{
		return string_4;
	}

	internal void method_31(string string_28)
	{
		string_4 = string_28;
	}

	internal string method_32()
	{
		return string_5;
	}

	internal void method_33(string string_28)
	{
		string_5 = string_28;
	}

	private string method_34()
	{
		return string_6;
	}

	private void method_35(string string_28)
	{
		string_6 = string_28;
	}

	internal string method_36()
	{
		return string_7;
	}

	internal void method_37(string string_28)
	{
		string_7 = string_28;
	}

	internal bool method_38()
	{
		return bool_0;
	}

	internal void method_39(bool bool_55)
	{
		bool_0 = bool_55;
	}

	internal bool method_40()
	{
		return bool_1;
	}

	internal void method_41(bool bool_55)
	{
		bool_1 = bool_55;
	}

	internal string method_42()
	{
		return string_8;
	}

	private void method_43(string string_28)
	{
		string_8 = string_28;
	}

	internal string method_44()
	{
		return string_9;
	}

	internal void method_45(string string_28)
	{
		string_9 = string_28;
	}

	internal bool method_46()
	{
		return bool_2;
	}

	internal void method_47(bool bool_55)
	{
		bool_2 = bool_55;
	}

	internal string method_48()
	{
		return string_10;
	}

	internal void method_49(string string_28)
	{
		string_10 = string_28;
	}

	internal string method_50()
	{
		return string_11;
	}

	internal void method_51(string string_28)
	{
		string_11 = string_28;
	}

	internal string method_52()
	{
		return string_12;
	}

	internal void method_53(string string_28)
	{
		string_12 = string_28;
	}

	internal int method_54()
	{
		return int_0;
	}

	internal void method_55(int int_15)
	{
		int_0 = int_15;
	}

	internal int method_56()
	{
		return int_1;
	}

	internal void method_57(int int_15)
	{
		int_1 = int_15;
	}

	internal string method_58()
	{
		return string_13;
	}

	internal void method_59(string string_28)
	{
		string_13 = string_28;
	}

	internal int[] method_60()
	{
		return int_2;
	}

	private void method_61(int[] int_15)
	{
		int_2 = int_15;
	}

	internal string[] method_62()
	{
		return string_14;
	}

	private void method_63(string[] string_28)
	{
		string_14 = string_28;
	}

	internal string method_64()
	{
		return string_15;
	}

	internal void method_65(string string_28)
	{
		string_15 = string_28;
	}

	internal string method_66()
	{
		return string_16;
	}

	internal void method_67(string string_28)
	{
		string_16 = string_28;
	}

	internal string method_68()
	{
		return string_17;
	}

	internal void method_69(string string_28)
	{
		string_17 = string_28;
	}

	internal bool[] method_70()
	{
		return bool_3;
	}

	private void method_71(bool[] bool_55)
	{
		bool_3 = bool_55;
	}

	internal bool method_72()
	{
		return bool_4;
	}

	internal void method_73(bool bool_55)
	{
		bool_4 = bool_55;
	}

	internal bool method_74()
	{
		return bool_5;
	}

	internal void method_75(bool bool_55)
	{
		bool_5 = bool_55;
	}

	internal string method_76()
	{
		return string_18;
	}

	internal void method_77(string string_28)
	{
		string_18 = string_28;
	}

	internal int method_78()
	{
		return int_3;
	}

	internal void method_79(int int_15)
	{
		int_3 = int_15;
	}

	internal bool method_80()
	{
		return bool_6;
	}

	internal void method_81(bool bool_55)
	{
		bool_6 = bool_55;
	}

	internal bool method_82()
	{
		return bool_7;
	}

	internal void method_83(bool bool_55)
	{
		bool_7 = bool_55;
	}

	internal bool method_84()
	{
		return bool_8;
	}

	internal void method_85(bool bool_55)
	{
		bool_8 = bool_55;
	}

	internal string method_86()
	{
		return string_19;
	}

	internal void method_87(string string_28)
	{
		string_19 = string_28;
	}

	internal string method_88()
	{
		return string_20;
	}

	internal void method_89(string string_28)
	{
		string_20 = string_28;
	}

	internal Enum0 method_90()
	{
		return enum0_0;
	}

	internal void method_91(Enum0 enum0_1)
	{
		enum0_0 = enum0_1;
	}

	internal int method_92()
	{
		return int_4;
	}

	internal void method_93(int int_15)
	{
		int_4 = int_15;
	}

	internal int method_94()
	{
		return int_5;
	}

	internal void method_95(int int_15)
	{
		int_5 = int_15;
	}

	internal bool method_96()
	{
		return bool_9;
	}

	internal void method_97(bool bool_55)
	{
		bool_9 = bool_55;
	}

	internal bool method_98()
	{
		return bool_10;
	}

	internal void method_99(bool bool_55)
	{
		bool_10 = bool_55;
	}

	internal bool method_100()
	{
		return bool_11;
	}

	internal void method_101(bool bool_55)
	{
		bool_11 = bool_55;
	}

	internal bool method_102()
	{
		return bool_12;
	}

	internal void method_103(bool bool_55)
	{
		bool_12 = bool_55;
	}

	internal bool method_104()
	{
		return bool_13;
	}

	internal void method_105(bool bool_55)
	{
		bool_13 = bool_55;
	}

	internal bool method_106()
	{
		return bool_14;
	}

	internal void method_107(bool bool_55)
	{
		bool_14 = bool_55;
	}

	internal bool method_108()
	{
		return bool_15;
	}

	internal void method_109(bool bool_55)
	{
		bool_15 = bool_55;
	}

	internal bool method_110()
	{
		return bool_16;
	}

	internal void method_111(bool bool_55)
	{
		bool_16 = bool_55;
	}

	internal bool method_112()
	{
		return bool_17;
	}

	internal void method_113(bool bool_55)
	{
		bool_17 = bool_55;
	}

	internal bool method_114()
	{
		return bool_18;
	}

	internal void method_115(bool bool_55)
	{
		bool_18 = bool_55;
	}

	internal bool method_116()
	{
		return bool_19;
	}

	internal void method_117(bool bool_55)
	{
		bool_19 = bool_55;
	}

	internal int method_118()
	{
		return int_6;
	}

	internal void method_119(int int_15)
	{
		int_6 = int_15;
	}

	internal string method_120()
	{
		return string_21;
	}

	internal void method_121(string string_28)
	{
		string_21 = string_28;
	}

	internal bool method_122()
	{
		return bool_20;
	}

	internal void method_123(bool bool_55)
	{
		bool_20 = bool_55;
	}

	internal bool method_124()
	{
		return bool_21;
	}

	internal void method_125(bool bool_55)
	{
		bool_21 = bool_55;
	}

	internal bool method_126()
	{
		return bool_22;
	}

	internal void method_127(bool bool_55)
	{
		bool_22 = bool_55;
	}

	internal int method_128()
	{
		return int_7;
	}

	internal void method_129(int int_15)
	{
		int_7 = int_15;
	}

	internal bool method_130()
	{
		return bool_23;
	}

	internal void method_131(bool bool_55)
	{
		bool_23 = bool_55;
	}

	internal bool method_132()
	{
		return bool_24;
	}

	internal void method_133(bool bool_55)
	{
		bool_24 = bool_55;
	}

	internal bool method_134()
	{
		return bool_25;
	}

	internal void method_135(bool bool_55)
	{
		bool_25 = bool_55;
	}

	internal bool method_136()
	{
		return bool_26;
	}

	internal void method_137(bool bool_55)
	{
		bool_26 = bool_55;
	}

	internal string method_138()
	{
		return string_22;
	}

	internal void method_139(string string_28)
	{
		string_22 = string_28;
	}

	internal SortedList<string, Class76> method_140()
	{
		return sortedList_0;
	}

	private void method_141(SortedList<string, Class76> sortedList_1)
	{
		sortedList_0 = sortedList_1;
	}

	internal bool method_142()
	{
		return bool_27;
	}

	internal void method_143(bool bool_55)
	{
		bool_27 = bool_55;
	}

	internal bool method_144()
	{
		return bool_28;
	}

	internal void method_145(bool bool_55)
	{
		bool_28 = bool_55;
	}

	internal bool method_146()
	{
		return bool_29;
	}

	internal void method_147(bool bool_55)
	{
		bool_29 = bool_55;
	}

	internal bool method_148()
	{
		return bool_30;
	}

	internal void method_149(bool bool_55)
	{
		bool_30 = bool_55;
	}

	internal bool method_150()
	{
		return bool_31;
	}

	internal void method_151(bool bool_55)
	{
		bool_31 = bool_55;
	}

	internal bool method_152()
	{
		return bool_32;
	}

	internal void method_153(bool bool_55)
	{
		bool_32 = bool_55;
	}

	internal bool method_154()
	{
		return bool_33;
	}

	internal void method_155(bool bool_55)
	{
		bool_33 = bool_55;
	}

	internal bool method_156()
	{
		return bool_34;
	}

	internal void method_157(bool bool_55)
	{
		bool_34 = bool_55;
	}

	internal bool method_158()
	{
		return bool_35;
	}

	internal void method_159(bool bool_55)
	{
		bool_35 = bool_55;
	}

	internal bool method_160()
	{
		return bool_36;
	}

	internal void method_161(bool bool_55)
	{
		bool_36 = bool_55;
	}

	internal bool method_162()
	{
		return bool_37;
	}

	internal void method_163(bool bool_55)
	{
		bool_37 = bool_55;
	}

	internal bool method_164()
	{
		return bool_38;
	}

	internal void method_165(bool bool_55)
	{
		bool_38 = bool_55;
	}

	internal bool method_166()
	{
		return bool_39;
	}

	internal void method_167(bool bool_55)
	{
		bool_39 = bool_55;
	}

	internal bool method_168()
	{
		return bool_40;
	}

	internal void method_169(bool bool_55)
	{
		bool_40 = bool_55;
	}

	internal bool method_170()
	{
		return bool_41;
	}

	internal void method_171(bool bool_55)
	{
		bool_41 = bool_55;
	}

	internal bool method_172()
	{
		return bool_42;
	}

	internal void method_173(bool bool_55)
	{
		bool_42 = bool_55;
	}

	internal bool method_174()
	{
		return bool_43;
	}

	internal void method_175(bool bool_55)
	{
		bool_43 = bool_55;
	}

	internal bool method_176()
	{
		return bool_44;
	}

	internal void method_177(bool bool_55)
	{
		bool_44 = bool_55;
	}

	internal bool method_178()
	{
		return bool_45;
	}

	internal void method_179(bool bool_55)
	{
		bool_45 = bool_55;
	}

	internal bool method_180()
	{
		return bool_46;
	}

	internal void method_181(bool bool_55)
	{
		bool_46 = bool_55;
	}

	internal bool method_182()
	{
		return bool_47;
	}

	internal void method_183(bool bool_55)
	{
		bool_47 = bool_55;
	}

	internal string method_184()
	{
		return string_23;
	}

	internal void method_185(string string_28)
	{
		string_23 = string_28;
	}

	internal int method_186()
	{
		return int_8;
	}

	internal void method_187(int int_15)
	{
		int_8 = int_15;
	}

	private string method_188()
	{
		return string_24;
	}

	private void method_189(string string_28)
	{
		string_24 = string_28;
	}

	private long method_190()
	{
		return long_0;
	}

	private void method_191(long long_1)
	{
		long_0 = long_1;
	}

	internal int method_192()
	{
		return int_13;
	}

	internal void method_193(int int_15)
	{
		int_13 = int_15;
	}

	internal int method_194()
	{
		return int_14;
	}

	internal void method_195(int int_15)
	{
		int_14 = int_15;
	}

	internal string method_196()
	{
		return string_25;
	}

	internal void method_197(string string_28)
	{
		string_25 = string_28;
	}

	internal string method_198()
	{
		return string_26;
	}

	internal void method_199(string string_28)
	{
		string_26 = string_28;
	}

	internal string method_200()
	{
		return string_27;
	}

	internal void method_201(string string_28)
	{
		string_27 = string_28;
	}
}
