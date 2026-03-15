using System;
using System.Threading;
using ABClient.MyProfile;

internal static class Class43
{
	private static string string_0 = string.Empty;

	internal static void smethod_0(string string_1)
	{
		ThreadPool.UnsafeQueueUserWorkItem(smethod_1, string_1);
	}

	private static void smethod_1(object object_0)
	{
		if (Class72.class19_0.lezSayType_0 == LezSayType.No)
		{
			return;
		}
		string text = (string)object_0;
		string text2 = Class12.smethod_1(text, "var fight_ty = [", "];");
		if (string.IsNullOrEmpty(text2))
		{
			return;
		}
		string[] array = text2.Split(',');
		if (array.Length < 9)
		{
			return;
		}
		string text3 = array[8].Trim('"');
		if (text3.Equals(string_0))
		{
			return;
		}
		string_0 = text3;
		string text4 = Class12.smethod_1(text, " начался (", ")") ?? "обычное нападение";
		if (!text4.Equals("нападение бота", StringComparison.OrdinalIgnoreCase) && !text4.Equals("приманка", StringComparison.OrdinalIgnoreCase))
		{
			string text5 = Class12.smethod_1(text, "var lives_g1 = [", "];");
			string text6 = Class12.smethod_1(text, "var lives_g2 = [", "];");
			if (!string.IsNullOrEmpty(text5) && !string.IsNullOrEmpty(text6))
			{
				bool flag;
				array = ((flag = text5.Contains(Class72.class19_0.method_30())) ? text6.Split(',') : text5.Split(','));
				string text7 = ((array.Length <= 2 || array[0].Equals("[4")) ? "невидимка" : array[1].Trim('"'));
				string text8 = (flag ? "я нападаю на" : "на меня напал");
				string text9 = "%clan% " + text8 + " " + text7 + ", клетка " + Class72.class19_0.method_58() + ", [[[" + string_0 + "]]] (" + text4 + ")";
				Class72.formMain_0.BeginInvoke(new Delegate37(Class72.formMain_0.method_113), text9);
			}
		}
	}
}
