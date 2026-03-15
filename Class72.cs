using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using ABClient.ABForms;
using ABClient.ExtMap;
using ABClient.PostFilter;

internal static class Class72
{
	internal static readonly Class55 class55_0;

	internal static readonly Encoding encoding_0;

	internal static readonly CultureInfo cultureInfo_0;

	internal static readonly CultureInfo cultureInfo_1;

	internal static Class19 class19_0;

	internal static WebProxy webProxy_0;

	internal static FormMain formMain_0;

	internal static string string_0;

	internal static string string_1;

	internal static string string_2;

	internal static string string_3;

	internal static DateTime dateTime_0;

	internal static string string_4;

	private static ClearExplorerCacheForm clearExplorerCacheForm_0;

	private static bool bool_0;

	private static DateTime dateTime_1;

	private static string string_5;

	private static bool bool_1;

	private static bool bool_2;

	private static bool bool_3;

	private static DateTime dateTime_2;

	private static string string_6;

	private static Enum4 enum4_0;

	private static string string_7;

	private static string string_8;

	private static byte[] byte_0;

	private static int int_0;

	private static DateTime dateTime_3;

	private static bool bool_4;

	private static bool bool_5;

	private static bool bool_6;

	private static bool bool_7;

	private static string string_9;

	private static string string_10;

	private static int int_1;

	private static CityGateType cityGateType_0;

	private static MapPath mapPath_0;

	private static string string_11;

	private static bool bool_8;

	private static int int_2;

	private static bool bool_9;

	private static bool bool_10;

	private static DateTime dateTime_4;

	private static bool bool_11;

	internal static readonly Dictionary<string, double> dictionary_0;

	private static bool bool_12;

	private static bool bool_13;

	private static bool bool_14;

	private static string string_12;

	private static string string_13;

	private static string string_14;

	private static string string_15;

	private static string string_16;

	private static string string_17;

	private static string string_18;

	private static double double_0;

	private static bool bool_15;

	private static bool bool_16;

	private static bool bool_17;

	private static string string_19;

	private static string string_20;

	private static Dictionary<string, string> dictionary_1;

	private static int int_3;

	private static int int_4;

	private static string string_21;

	private static string string_22;

	private static string[] string_23;

	private static int int_5;

	private static bool bool_18;

	private static DateTime dateTime_5;

	private static int int_6;

	private static bool bool_19;

	private static string string_24;

	private static string string_25;

	private static string string_26;

	private static string string_27;

	private static bool bool_20;

	private static string string_28;

	private static int int_7;

	private static DateTime dateTime_6;

	private static DateTime dateTime_7;

	internal static FormCompas formCompas_0;

	internal static FormAddClan formAddClan_0;

	internal static bool bool_21;

	internal static string string_29;

	internal static string string_30;

	internal static int int_8;

	internal static bool bool_22;

	internal static bool bool_23;

	internal static bool bool_24;

	internal static bool bool_25;

	internal static string string_31;

	internal static string string_32;

	internal static bool bool_26;

	internal static string string_33;

	private static string string_34;

	private static bool bool_27;

	private static bool bool_28;

	private static bool bool_29;

	internal static bool bool_30;

	internal static bool bool_31;

	internal static string string_35;

	internal static int int_9;

	private static int int_10;

	private static Thread thread_0;

	private static int[] int_11;

	private static DateTime dateTime_8;

	internal static DateTime dateTime_9;

	internal static bool bool_32;

	internal static bool bool_33;

	internal static DateTime dateTime_10;

	internal static DateTime dateTime_11;

	internal static bool bool_34;

	internal static bool bool_35;

	internal static int int_12;

	internal static readonly List<ShopEntry> list_0;

	internal static string string_36;

	internal static string string_37;

	internal static string string_38;

	internal static string string_39;

	internal static string string_40;

	internal static DateTime dateTime_12;

	internal static DateTime dateTime_13;

	internal static int int_13;

	internal static string string_41;

	internal static string string_42;

	internal static bool bool_36;

	internal static bool bool_37;

	internal static int int_14;

	internal static int int_15;

	internal static bool bool_38;

	internal static bool bool_39;

	internal static bool bool_40;

	internal static string string_43;

	internal static string string_44;

	internal static bool bool_41;

	internal static bool bool_42;

	internal static bool bool_43;

	internal static Class5 class5_0;

	internal static Class79 class79_0;

	internal static bool bool_44;

	internal static Class78 class78_0;

	internal static Class80 class80_0;

	internal static bool bool_45;

	internal static string string_45;

	internal static string string_46;

	internal static Dictionary<string, string> dictionary_2;

	internal static string string_47;

	internal static bool bool_46;

	internal static bool bool_47;

	internal static bool bool_48;

	internal static bool bool_49;

	internal static bool[] bool_50;

	internal static string string_48;

	internal static string string_49;

	internal static string string_50;

	internal static bool bool_51;

	internal static bool bool_52;

	internal static string string_51;

	internal static string string_52;

	internal static Dictionary<string, int> dictionary_3;

	internal static int int_16;

	internal static int int_17;

	internal static Dictionary<string, string> dictionary_4;

	internal static string string_53;

	internal static string string_54;

	internal static string string_55;

	internal static bool bool_53;

	internal static int int_18;

	static Class72()
	{
		class55_0 = new Class55(Class68.string_0, Application.ProductVersion);
		encoding_0 = Encoding.GetEncoding(1251);
		cultureInfo_0 = CultureInfo.GetCultureInfo("ru-RU");
		cultureInfo_1 = CultureInfo.GetCultureInfo("en-US");
		dictionary_0 = new Dictionary<string, double>();
		bool_35 = false;
		list_0 = new List<ShopEntry>();
		dateTime_12 = DateTime.MinValue;
		dateTime_13 = DateTime.MinValue;
		int_13 = 0;
		bool_36 = false;
		bool_37 = true;
		bool_41 = false;
		bool_42 = false;
		bool_43 = false;
		class79_0 = null;
		bool_44 = false;
		bool_45 = false;
		string_45 = string.Empty;
		string_46 = string.Empty;
		dictionary_2 = new Dictionary<string, string>();
		string_47 = Class68.string_2;
		bool_46 = true;
		bool_47 = true;
		bool_48 = true;
		bool_50 = new bool[3] { true, true, true };
		string_49 = string.Empty;
		string_50 = null;
		string_51 = string.Empty;
		string_52 = string.Empty;
		dictionary_3 = new Dictionary<string, int>();
		int_16 = 0;
		int_17 = 0;
		dictionary_4 = new Dictionary<string, string>();
		string_53 = string.Empty;
		string_54 = string.Empty;
		string_55 = string.Empty;
		bool_53 = false;
		int_18 = 0;
		smethod_95(new Dictionary<string, string>());
		smethod_101(string.Empty);
		smethod_103(string.Empty);
		smethod_147(new int[4]);
		dateTime_10 = DateTime.MinValue;
		dateTime_11 = DateTime.Now.AddMinutes(5.0);
	}

	internal static ClearExplorerCacheForm smethod_0()
	{
		return clearExplorerCacheForm_0;
	}

	internal static void smethod_1(ClearExplorerCacheForm clearExplorerCacheForm_1)
	{
		clearExplorerCacheForm_0 = clearExplorerCacheForm_1;
	}

	internal static bool smethod_2()
	{
		return bool_0;
	}

	internal static void smethod_3(bool bool_54)
	{
		bool_0 = bool_54;
	}

	internal static DateTime smethod_4()
	{
		return dateTime_1;
	}

	internal static void smethod_5(DateTime dateTime_14)
	{
		dateTime_1 = dateTime_14;
	}

	internal static string smethod_6()
	{
		return string_5;
	}

	internal static void smethod_7(string string_56)
	{
		string_5 = string_56;
	}

	internal static bool smethod_8()
	{
		return bool_1;
	}

	internal static void smethod_9(bool bool_54)
	{
		bool_1 = bool_54;
	}

	internal static bool smethod_10()
	{
		return bool_2;
	}

	internal static void smethod_11(bool bool_54)
	{
		bool_2 = bool_54;
	}

	internal static bool smethod_12()
	{
		return bool_3;
	}

	internal static void smethod_13(bool bool_54)
	{
		bool_3 = bool_54;
	}

	internal static DateTime smethod_14()
	{
		return dateTime_2;
	}

	internal static void smethod_15(DateTime dateTime_14)
	{
		dateTime_2 = dateTime_14;
	}

	internal static string smethod_16()
	{
		return string_6;
	}

	internal static void smethod_17(string string_56)
	{
		string_6 = string_56;
	}

	internal static Enum4 smethod_18()
	{
		return enum4_0;
	}

	internal static void smethod_19(Enum4 enum4_1)
	{
		enum4_0 = enum4_1;
	}

	internal static string smethod_20()
	{
		return string_7;
	}

	internal static void smethod_21(string string_56)
	{
		string_7 = string_56;
	}

	internal static string smethod_22()
	{
		return string_8;
	}

	internal static void smethod_23(string string_56)
	{
		string_8 = string_56;
	}

	internal static byte[] smethod_24()
	{
		return byte_0;
	}

	internal static void smethod_25(byte[] byte_1)
	{
		byte_0 = byte_1;
	}

	internal static int smethod_26()
	{
		return int_0;
	}

	internal static void smethod_27(int int_19)
	{
		int_0 = int_19;
	}

	internal static DateTime smethod_28()
	{
		return dateTime_3;
	}

	internal static void smethod_29(DateTime dateTime_14)
	{
		dateTime_3 = dateTime_14;
	}

	internal static bool smethod_30()
	{
		return bool_4;
	}

	internal static void smethod_31(bool bool_54)
	{
		bool_4 = bool_54;
	}

	internal static bool smethod_32()
	{
		return bool_5;
	}

	internal static void smethod_33(bool bool_54)
	{
		bool_5 = bool_54;
	}

	internal static bool smethod_34()
	{
		return bool_6;
	}

	internal static void smethod_35(bool bool_54)
	{
		bool_6 = bool_54;
	}

	internal static bool smethod_36()
	{
		return bool_7;
	}

	internal static void smethod_37(bool bool_54)
	{
		bool_7 = bool_54;
	}

	internal static string smethod_38()
	{
		return string_9;
	}

	internal static void smethod_39(string string_56)
	{
		string_9 = string_56;
	}

	internal static string smethod_40()
	{
		return string_10;
	}

	internal static void smethod_41(string string_56)
	{
		string_10 = string_56;
	}

	internal static int smethod_42()
	{
		return int_1;
	}

	internal static void smethod_43(int int_19)
	{
		int_1 = int_19;
	}

	internal static CityGateType smethod_44()
	{
		return cityGateType_0;
	}

	internal static void smethod_45(CityGateType cityGateType_1)
	{
		cityGateType_0 = cityGateType_1;
	}

	internal static MapPath smethod_46()
	{
		return mapPath_0;
	}

	internal static void smethod_47(MapPath mapPath_1)
	{
		mapPath_0 = mapPath_1;
	}

	internal static string smethod_48()
	{
		return string_11;
	}

	internal static void smethod_49(string string_56)
	{
		string_11 = string_56;
	}

	internal static bool smethod_50()
	{
		return bool_8;
	}

	internal static void smethod_51(bool bool_54)
	{
		bool_8 = bool_54;
	}

	internal static int smethod_52()
	{
		return int_2;
	}

	internal static void smethod_53(int int_19)
	{
		int_2 = int_19;
	}

	internal static bool smethod_54()
	{
		return bool_9;
	}

	internal static void smethod_55(bool bool_54)
	{
		bool_9 = bool_54;
	}

	internal static bool smethod_56()
	{
		return bool_10;
	}

	internal static void smethod_57(bool bool_54)
	{
		bool_10 = bool_54;
	}

	internal static DateTime smethod_58()
	{
		return dateTime_4;
	}

	internal static void smethod_59(DateTime dateTime_14)
	{
		dateTime_4 = dateTime_14;
	}

	internal static bool smethod_60()
	{
		return bool_11;
	}

	internal static void smethod_61(bool bool_54)
	{
		bool_11 = bool_54;
	}

	internal static bool smethod_62()
	{
		return bool_12;
	}

	internal static void smethod_63(bool bool_54)
	{
		bool_12 = bool_54;
	}

	internal static bool smethod_64()
	{
		return bool_13;
	}

	internal static void smethod_65(bool bool_54)
	{
		bool_13 = bool_54;
	}

	internal static bool smethod_66()
	{
		return bool_14;
	}

	internal static void smethod_67(bool bool_54)
	{
		bool_14 = bool_54;
	}

	internal static string smethod_68()
	{
		return string_12;
	}

	internal static void smethod_69(string string_56)
	{
		string_12 = string_56;
	}

	internal static string smethod_70()
	{
		return string_13;
	}

	internal static void smethod_71(string string_56)
	{
		string_13 = string_56;
	}

	internal static string smethod_72()
	{
		return string_14;
	}

	internal static void smethod_73(string string_56)
	{
		string_14 = string_56;
	}

	internal static string smethod_74()
	{
		return string_15;
	}

	internal static void smethod_75(string string_56)
	{
		string_15 = string_56;
	}

	internal static string smethod_76()
	{
		return string_16;
	}

	internal static void smethod_77(string string_56)
	{
		string_16 = string_56;
	}

	internal static string smethod_78()
	{
		return string_17;
	}

	internal static void smethod_79(string string_56)
	{
		string_17 = string_56;
	}

	internal static string smethod_80()
	{
		return string_18;
	}

	internal static void smethod_81(string string_56)
	{
		string_18 = string_56;
	}

	internal static double smethod_82()
	{
		return double_0;
	}

	internal static void smethod_83(double double_1)
	{
		double_0 = double_1;
	}

	internal static bool smethod_84()
	{
		return bool_15;
	}

	internal static void smethod_85(bool bool_54)
	{
		bool_15 = bool_54;
	}

	internal static bool smethod_86()
	{
		return bool_16;
	}

	internal static void smethod_87(bool bool_54)
	{
		bool_16 = bool_54;
	}

	internal static bool smethod_88()
	{
		return bool_17;
	}

	internal static void smethod_89(bool bool_54)
	{
		bool_17 = bool_54;
	}

	internal static string smethod_90()
	{
		return string_19;
	}

	internal static void smethod_91(string string_56)
	{
		string_19 = string_56;
	}

	internal static string smethod_92()
	{
		return string_20;
	}

	internal static void smethod_93(string string_56)
	{
		string_20 = string_56;
	}

	internal static Dictionary<string, string> smethod_94()
	{
		return dictionary_1;
	}

	internal static void smethod_95(Dictionary<string, string> dictionary_5)
	{
		dictionary_1 = dictionary_5;
	}

	internal static int smethod_96()
	{
		return int_3;
	}

	internal static void smethod_97(int int_19)
	{
		int_3 = int_19;
	}

	internal static int smethod_98()
	{
		return int_4;
	}

	internal static void smethod_99(int int_19)
	{
		int_4 = int_19;
	}

	internal static string smethod_100()
	{
		return string_21;
	}

	internal static void smethod_101(string string_56)
	{
		string_21 = string_56;
	}

	internal static string smethod_102()
	{
		return string_22;
	}

	internal static void smethod_103(string string_56)
	{
		string_22 = string_56;
	}

	internal static string[] smethod_104()
	{
		return string_23;
	}

	internal static void smethod_105(string[] string_56)
	{
		string_23 = string_56;
	}

	internal static int smethod_106()
	{
		return int_5;
	}

	internal static void smethod_107(int int_19)
	{
		int_5 = int_19;
	}

	internal static bool smethod_108()
	{
		return bool_18;
	}

	internal static void smethod_109(bool bool_54)
	{
		bool_18 = bool_54;
	}

	internal static DateTime smethod_110()
	{
		return dateTime_5;
	}

	internal static void smethod_111(DateTime dateTime_14)
	{
		dateTime_5 = dateTime_14;
	}

	internal static int smethod_112()
	{
		return int_6;
	}

	internal static void smethod_113(int int_19)
	{
		int_6 = int_19;
	}

	internal static bool smethod_114()
	{
		return bool_19;
	}

	internal static void smethod_115(bool bool_54)
	{
		bool_19 = bool_54;
	}

	internal static string smethod_116()
	{
		return string_24;
	}

	internal static void smethod_117(string string_56)
	{
		string_24 = string_56;
	}

	internal static string smethod_118()
	{
		return string_25;
	}

	internal static void smethod_119(string string_56)
	{
		string_25 = string_56;
	}

	internal static string smethod_120()
	{
		return string_26;
	}

	internal static void smethod_121(string string_56)
	{
		string_26 = string_56;
	}

	internal static string smethod_122()
	{
		return string_27;
	}

	internal static void smethod_123(string string_56)
	{
		string_27 = string_56;
	}

	internal static bool smethod_124()
	{
		return bool_20;
	}

	internal static void smethod_125(bool bool_54)
	{
		bool_20 = bool_54;
	}

	internal static string smethod_126()
	{
		return string_28;
	}

	internal static void smethod_127(string string_56)
	{
		string_28 = string_56;
	}

	internal static int smethod_128()
	{
		return int_7;
	}

	internal static void smethod_129(int int_19)
	{
		int_7 = int_19;
	}

	internal static DateTime smethod_130()
	{
		return dateTime_6;
	}

	internal static void smethod_131(DateTime dateTime_14)
	{
		dateTime_6 = dateTime_14;
	}

	internal static DateTime smethod_132()
	{
		return dateTime_7;
	}

	internal static void smethod_133(DateTime dateTime_14)
	{
		dateTime_7 = dateTime_14;
	}

	internal static string smethod_134()
	{
		return string_34;
	}

	internal static void smethod_135(string string_56)
	{
		string_34 = string_56;
	}

	internal static bool smethod_136()
	{
		return bool_27;
	}

	internal static void smethod_137(bool bool_54)
	{
		bool_27 = bool_54;
	}

	internal static bool smethod_138()
	{
		return bool_28;
	}

	internal static void smethod_139(bool bool_54)
	{
		bool_28 = bool_54;
	}

	internal static bool smethod_140()
	{
		return bool_29;
	}

	internal static void smethod_141(bool bool_54)
	{
		bool_29 = bool_54;
	}

	internal static int smethod_142()
	{
		return int_10;
	}

	internal static void smethod_143(int int_19)
	{
		int_10 = int_19;
	}

	internal static Thread smethod_144()
	{
		return thread_0;
	}

	internal static void smethod_145(Thread thread_1)
	{
		thread_0 = thread_1;
	}

	internal static int[] smethod_146()
	{
		return int_11;
	}

	internal static void smethod_147(int[] int_19)
	{
		int_11 = int_19;
	}

	internal static DateTime smethod_148()
	{
		return dateTime_8;
	}

	internal static void smethod_149(DateTime dateTime_14)
	{
		dateTime_8 = dateTime_14;
	}
}
