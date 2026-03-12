using System;
using System.Collections.Generic;

internal sealed class Class29
{
	internal bool bool_0;

	internal string string_0;

	internal string string_1;

	internal bool bool_1;

	internal bool bool_2;

	internal bool bool_3;

	internal string string_2;

	internal string string_3;

	private readonly List<string> list_0 = new List<string>();

	private readonly List<string> list_1 = new List<string>();

	internal Class29(string string_4)
	{
		bool_0 = false;
		Class72.smethod_69(string.Empty);
		Class72.smethod_71(string.Empty);
		Class72.smethod_73(string.Empty);
		Class72.smethod_75(string.Empty);
		string text = Class12.smethod_1(string_4, "slots_inv(", ");");
		if (string.IsNullOrEmpty(text))
		{
			string text2 = Class12.smethod_1(string_4, "slots_pla(", ");");
			if (string.IsNullOrEmpty(text2))
			{
				return;
			}
			string[] array = text2.Split(',');
			if (array.Length < 5)
			{
				return;
			}
			string[] array2 = array[2].Split('@');
			if (array2.Length < 13)
			{
				return;
			}
			string[] array3 = array[3].Split('@');
			if (array3.Length < 13)
			{
				return;
			}
			string[] array4 = array2[2].Split(':');
			if (array4.Length < 2)
			{
				return;
			}
			string_2 = array4[1];
			bool_1 = string_2.StartsWith("Слот", StringComparison.OrdinalIgnoreCase);
			string text3 = string.Empty;
			string text4 = string.Empty;
			if (!bool_1)
			{
				text3 = array3[2];
				text4 = array4[2].Split(new char[1] { '|' }, StringSplitOptions.None)[7];
			}
			string[] array5 = array2[12].Split(':');
			if (array5.Length >= 2)
			{
				string_3 = array5[1];
				bool_2 = string_3.StartsWith("Слот", StringComparison.OrdinalIgnoreCase);
				string text5 = string.Empty;
				string text6 = string.Empty;
				if (!bool_2)
				{
					text5 = array3[12];
					text6 = array5[2].Split(new char[1] { '|' }, StringSplitOptions.None)[7];
				}
				if (!bool_1)
				{
					list_0.Add(string_2);
					list_1.Add(text3 + "/" + text4);
				}
				if (!bool_2)
				{
					list_0.Add(string_3);
					list_1.Add(text5 + "/" + text6);
				}
				bool_0 = true;
			}
			return;
		}
		string[] array6 = text.Split(',');
		if (array6.Length < 6)
		{
			return;
		}
		string[] array7 = array6[2].Split('@');
		if (array7.Length < 13)
		{
			return;
		}
		string[] array8 = array6[3].Split('@');
		if (array8.Length < 3)
		{
			return;
		}
		string_0 = array8[2];
		string[] array9 = array6[4].Split('@');
		if (array9.Length < 3)
		{
			return;
		}
		string_1 = array9[2];
		string[] array10 = array6[5].Split(new char[1] { '@' }, StringSplitOptions.None);
		if (array10.Length < 13)
		{
			return;
		}
		string[] array11 = array7[2].Split(':');
		if (array11.Length < 2)
		{
			return;
		}
		string_2 = array11[1];
		bool_1 = string_2.StartsWith("Слот", StringComparison.OrdinalIgnoreCase);
		string text7 = string.Empty;
		string text8 = string.Empty;
		if (!bool_1)
		{
			text7 = array10[2];
			text8 = array11[2].Split(new char[1] { '|' }, StringSplitOptions.None)[7];
		}
		string[] array12 = array7[12].Split(':');
		if (array12.Length >= 2)
		{
			string_3 = array12[1];
			bool_2 = string_3.StartsWith("Слот", StringComparison.OrdinalIgnoreCase);
			string text9 = string.Empty;
			string text10 = string.Empty;
			if (!bool_2)
			{
				text9 = array10[12];
				text10 = array12[2].Split(new char[1] { '|' }, StringSplitOptions.None)[7];
			}
			if (!bool_1)
			{
				list_0.Add(string_2);
				list_1.Add(text7 + "/" + text8);
			}
			if (!bool_2)
			{
				list_0.Add(string_3);
				list_1.Add(text9 + "/" + text10);
			}
			bool_0 = true;
		}
	}

	internal bool method_0()
	{
		bool result = false;
		bool_3 = false;
		if (Class72.class19_0.method_84() && !Class72.class19_0.method_86().Equals("нет", StringComparison.OrdinalIgnoreCase))
		{
			if (Class72.class19_0.method_86().Equals("Любая удочка", StringComparison.OrdinalIgnoreCase))
			{
				if (list_0.Count > 0 && (list_0[0].IndexOf("удочка", StringComparison.CurrentCultureIgnoreCase) != -1 || list_0[0].IndexOf("спиннинг", StringComparison.CurrentCultureIgnoreCase) != -1))
				{
					result = true;
					Class72.smethod_69(list_0[0]);
					Class72.smethod_73(list_1[0]);
					list_0.RemoveAt(0);
					list_1.RemoveAt(0);
				}
				else if (list_0.Count > 1 && (list_0[1].IndexOf("удочка", StringComparison.CurrentCultureIgnoreCase) != -1 || list_0[0].IndexOf("спиннинг", StringComparison.CurrentCultureIgnoreCase) != -1))
				{
					result = true;
					bool_3 = true;
					Class72.smethod_69(list_0[1]);
					Class72.smethod_73(list_1[1]);
					list_0.RemoveAt(1);
					list_1.RemoveAt(1);
				}
			}
			else if (list_0.Count > 0 && list_0[0].IndexOf(Class72.class19_0.method_86(), StringComparison.CurrentCultureIgnoreCase) >= 0)
			{
				result = true;
				Class72.smethod_69(list_0[0]);
				Class72.smethod_73(list_1[0]);
				list_0.RemoveAt(0);
				list_1.RemoveAt(0);
			}
			else if (list_0.Count > 1 && list_0[1].IndexOf(Class72.class19_0.method_86(), StringComparison.CurrentCultureIgnoreCase) >= 0)
			{
				result = true;
				bool_3 = true;
				Class72.smethod_69(list_0[1]);
				Class72.smethod_73(list_1[1]);
				list_0.RemoveAt(1);
				list_1.RemoveAt(1);
			}
		}
		else
		{
			result = true;
		}
		return result;
	}

	internal bool method_1()
	{
		bool result = false;
		if (Class72.class19_0.method_84() && !Class72.class19_0.method_88().Equals("нет", StringComparison.OrdinalIgnoreCase))
		{
			if (Class72.class19_0.method_88().Equals("Любая удочка", StringComparison.OrdinalIgnoreCase))
			{
				if (list_0.Count > 0 && (list_0[0].IndexOf("удочка", StringComparison.CurrentCultureIgnoreCase) != -1 || list_0[0].IndexOf("спиннинг", StringComparison.CurrentCultureIgnoreCase) != -1))
				{
					Class72.smethod_71(list_0[0]);
					Class72.smethod_75(list_1[0]);
					result = true;
				}
				else if (list_0.Count > 1 && (list_0[1].IndexOf("удочка", StringComparison.CurrentCultureIgnoreCase) != -1 || list_0[0].IndexOf("спиннинг", StringComparison.CurrentCultureIgnoreCase) != -1))
				{
					Class72.smethod_71(list_0[1]);
					Class72.smethod_75(list_1[1]);
					result = true;
				}
			}
			else if (list_0.Count > 0 && list_0[0].IndexOf(Class72.class19_0.method_88(), StringComparison.CurrentCultureIgnoreCase) >= 0)
			{
				Class72.smethod_71(list_0[0]);
				Class72.smethod_75(list_1[0]);
				result = true;
			}
			else if (list_0.Count > 1 && list_0[1].IndexOf(Class72.class19_0.method_88(), StringComparison.CurrentCultureIgnoreCase) >= 0)
			{
				Class72.smethod_71(list_0[1]);
				Class72.smethod_75(list_1[1]);
				result = true;
			}
		}
		else
		{
			result = true;
		}
		return result;
	}

	internal bool method_2(string[] string_4)
	{
		for (int i = 0; i < list_0.Count; i++)
		{
			for (int j = 0; j < string_4.Length; j++)
			{
				if (list_0[i].IndexOf(string_4[j], StringComparison.CurrentCultureIgnoreCase) >= 0)
				{
					return true;
				}
			}
		}
		return false;
	}
}
