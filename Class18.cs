using System;
using System.IO;
using System.Media;
using System.Windows.Forms;

internal static class Class18
{
	private static readonly SoundPlayer soundPlayer_0 = new SoundPlayer();

	private static readonly string string_0 = Path.Combine(Application.StartupPath, Class68.string_11 + "/digits.wav");

	private static DateTime dateTime_0 = DateTime.MinValue;

	private static readonly string string_1 = Path.Combine(Application.StartupPath, Class68.string_11 + "/attack.wav");

	private static DateTime dateTime_1 = DateTime.MinValue;

	private static readonly string string_2 = Path.Combine(Application.StartupPath, Class68.string_11 + "/sndmsg.wav");

	private static DateTime dateTime_2 = DateTime.MinValue;

	private static readonly string string_3 = Path.Combine(Application.StartupPath, Class68.string_11 + "/refresh.wav");

	private static DateTime dateTime_3 = DateTime.MinValue;

	private static readonly string string_4 = Path.Combine(Application.StartupPath, Class68.string_11 + "/alarm.wav");

	private static DateTime dateTime_4 = DateTime.MinValue;

	private static readonly string string_5 = Path.Combine(Application.StartupPath, Class68.string_11 + "/timer.wav");

	private static DateTime dateTime_5 = DateTime.MinValue;

	private static readonly string string_6 = Path.Combine(Application.StartupPath, Class68.string_11 + "/bear.wav");

	private static DateTime dateTime_6 = DateTime.MinValue;

	internal static void smethod_0()
	{
		if (File.Exists(string_0) && Class72.class19_0.tsound_0.DoPlayDigits && !(DateTime.Now.Subtract(dateTime_0).TotalSeconds <= 5.0))
		{
			dateTime_0 = DateTime.Now;
			smethod_8(string_0);
		}
	}

	internal static void smethod_1()
	{
		if (File.Exists(string_1) && Class72.class19_0.tsound_0.DoPlayAttack && !(DateTime.Now.Subtract(dateTime_1).TotalSeconds <= 5.0))
		{
			dateTime_1 = DateTime.Now;
			smethod_8(string_1);
		}
	}

	internal static void smethod_2()
	{
		if (File.Exists(string_2) && Class72.class19_0.tsound_0.DoPlaySndMsg && !(DateTime.Now.Subtract(dateTime_2).TotalSeconds <= 5.0))
		{
			dateTime_2 = DateTime.Now;
			smethod_8(string_2);
		}
	}

	internal static void smethod_3()
	{
		if (File.Exists(string_3) && Class72.class19_0.tsound_0.DoPlayRefresh && !(DateTime.Now.Subtract(dateTime_3).TotalSeconds <= 5.0))
		{
			dateTime_3 = DateTime.Now;
			smethod_8(string_3);
		}
	}

	internal static void smethod_4()
	{
		if (File.Exists(string_3) && Class72.class19_0.tsound_0.DoPlayActionEnd)
		{
			smethod_8(string_3);
		}
	}

	internal static void smethod_5()
	{
		if (File.Exists(string_4) && Class72.class19_0.tsound_0.DoPlayAlarm && !(DateTime.Now.Subtract(dateTime_4).TotalSeconds <= 5.0))
		{
			dateTime_4 = DateTime.Now;
			smethod_8(string_4);
		}
	}

	internal static void smethod_6()
	{
		if (File.Exists(string_5) && Class72.class19_0.tsound_0.DoPlayTimer && !(DateTime.Now.Subtract(dateTime_5).TotalSeconds <= 5.0))
		{
			dateTime_5 = DateTime.Now;
			smethod_8(string_5);
		}
	}

	internal static void smethod_7()
	{
		if (File.Exists(string_6) && !(DateTime.Now.Subtract(dateTime_6).TotalSeconds <= 5.0))
		{
			dateTime_6 = DateTime.Now;
			smethod_8(string_6);
		}
	}

	private static void smethod_8(string string_7)
	{
		if (!Class72.class19_0.tsound_0.Enabled)
		{
			return;
		}
		try
		{
			soundPlayer_0.SoundLocation = string_7;
			soundPlayer_0.Play();
		}
		catch (Exception)
		{
			MessageBox.Show("Ошибка проигрывания " + string_7, Class72.class55_0.method_6(), MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}
	}
}
