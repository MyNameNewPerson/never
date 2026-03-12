using System;
using System.Diagnostics;
using System.Windows.Forms;
using Microsoft.Win32;

namespace ABClient;

public static class FeatureBrowserEmulation
{
	internal static void smethod_0()
	{
		string name = Process.GetCurrentProcess().ProcessName + ".exe";
		WebBrowser webBrowser = new WebBrowser();
		int major;
		try
		{
			major = webBrowser.Version.Major;
		}
		finally
		{
			((IDisposable)webBrowser).Dispose();
		}
		int num = ((major >= 11) ? 11001 : (major switch
		{
			10 => 10001, 
			9 => 9999, 
			8 => 8888, 
			_ => 7000, 
		}));
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\Wow6432Node\\Microsoft\\Internet Explorer\\Main\\FeatureControl\\FEATURE_BROWSER_EMULATION", RegistryKeyPermissionCheck.ReadWriteSubTree) ?? Registry.CurrentUser.CreateSubKey("Software\\Wow6432Node\\Microsoft\\Internet Explorer\\Main\\FeatureControl\\FEATURE_BROWSER_EMULATION");
			if (registryKey != null)
			{
				registryKey.SetValue(name, num, RegistryValueKind.DWord);
				registryKey.Close();
			}
		}
		catch
		{
		}
		try
		{
			RegistryKey registryKey2 = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Internet Explorer\\Main\\FeatureControl\\FEATURE_BROWSER_EMULATION", RegistryKeyPermissionCheck.ReadWriteSubTree) ?? Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Internet Explorer\\Main\\FeatureControl\\FEATURE_BROWSER_EMULATION");
			if (registryKey2 != null)
			{
				registryKey2.SetValue(name, num, RegistryValueKind.DWord);
				registryKey2.Close();
			}
		}
		catch
		{
		}
	}
}
