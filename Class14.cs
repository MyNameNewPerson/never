using System;
using System.Collections.Generic;
using System.IO;
using System.Security;
using System.Windows.Forms;

internal static class Class14
{
	internal static Class19 smethod_0()
	{
		try
		{
			FileInfo[] files = new DirectoryInfo(Application.StartupPath).GetFiles("*" + Class68.string_6, SearchOption.TopDirectoryOnly);
			if (files.Length == 0)
			{
				return smethod_1();
			}
			List<Class19> list = new List<Class19>(files.Length);
			FileInfo[] array = files;
			foreach (FileInfo fileInfo in array)
			{
				Class19 @class = new Class19();
				if (@class.method_8(fileInfo.FullName))
				{
					list.Add(@class);
				}
			}
			if (list.Count == 0)
			{
				return smethod_1();
			}
			list.Sort();
			Class19 class2 = list[0];
			if (class2.method_38() && !string.IsNullOrEmpty(class2.method_30()) && !string.IsNullOrEmpty(class2.method_32()))
			{
				FormAutoLogon formAutoLogon = new FormAutoLogon(class2.method_30());
				try
				{
					if (formAutoLogon.ShowDialog() == DialogResult.OK)
					{
						return class2;
					}
				}
				finally
				{
					((IDisposable)formAutoLogon).Dispose();
				}
			}
			Class19 class3 = smethod_5(list.ToArray());
			return (class3 == null) ? null : smethod_2(class3);
		}
		catch (ArgumentNullException ex)
		{
			smethod_4(ex.Message);
		}
		catch (SecurityException ex2)
		{
			smethod_4(ex2.Message);
		}
		catch (ArgumentException ex3)
		{
			smethod_4(ex3.Message);
		}
		catch (PathTooLongException ex4)
		{
			smethod_4(ex4.Message);
		}
		catch (DirectoryNotFoundException ex5)
		{
			smethod_4(ex5.Message);
		}
		catch (IOException ex6)
		{
			smethod_4(ex6.Message);
		}
		return null;
	}

	internal static Class19 smethod_1()
	{
		FormProfile formProfile = new FormProfile(null);
		try
		{
			if (formProfile.ShowDialog() == DialogResult.OK)
			{
				formProfile.method_0().method_20();
				return formProfile.method_0();
			}
			return null;
		}
		finally
		{
			((IDisposable)formProfile).Dispose();
		}
	}

	internal static Class19 smethod_2(Class19 class19_0)
	{
		if (class19_0 == null)
		{
			throw new ArgumentNullException("userConfig");
		}
		if (string.IsNullOrEmpty(class19_0.method_32()))
		{
			FormAskPassword formAskPassword = new FormAskPassword(class19_0.method_44());
			try
			{
				if (formAskPassword.ShowDialog() != DialogResult.OK)
				{
					return null;
				}
				class19_0.method_1(formAskPassword.method_0());
			}
			finally
			{
				((IDisposable)formAskPassword).Dispose();
			}
		}
		return class19_0;
	}

	internal static Class19 smethod_3(Class19 class19_0)
	{
		if (class19_0 == null)
		{
			throw new ArgumentNullException("userConfig");
		}
		class19_0 = smethod_2(class19_0);
		if (class19_0 == null)
		{
			return null;
		}
		FormProfile formProfile = new FormProfile(class19_0);
		try
		{
			if (formProfile.ShowDialog() == DialogResult.OK)
			{
				formProfile.method_0().method_20();
				return formProfile.method_0();
			}
			return null;
		}
		finally
		{
			((IDisposable)formProfile).Dispose();
		}
	}

	private static void smethod_4(string string_0)
	{
		if (string.IsNullOrEmpty(string_0))
		{
			throw new ArgumentNullException("message");
		}
		MessageBox.Show(string_0, "Ошибка работы с профайлами", MessageBoxButtons.OK, MessageBoxIcon.Hand);
	}

	private static Class19 smethod_5(Class19[] class19_0)
	{
		FormProfiles formProfiles = new FormProfiles(class19_0);
		try
		{
			if (formProfiles.ShowDialog() == DialogResult.OK)
			{
				return formProfiles.method_0();
			}
		}
		finally
		{
			((IDisposable)formProfiles).Dispose();
		}
		return null;
	}
}
