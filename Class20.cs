using System;
using System.Drawing;
using System.Runtime.InteropServices;

internal static class Class20
{
	internal struct Struct15 : IDisposable
	{
		private readonly int int_0;

		private readonly IntPtr intptr_0;

		private readonly IntPtr intptr_1;

		internal Struct15(int int_1, IntPtr intptr_2, IntPtr intptr_3)
		{
			int_0 = int_1;
			intptr_0 = intptr_2;
			intptr_1 = intptr_3;
		}

		public void Dispose()
		{
		}
	}

	[DllImport("wininet", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, SetLastError = true)]
	internal static extern IntPtr FindFirstUrlCacheEntryA([MarshalAs(UnmanagedType.LPWStr)] string string_0, IntPtr intptr_0, ref int int_0);

	[DllImport("wininet", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool FindNextUrlCacheEntryA(IntPtr intptr_0, IntPtr intptr_1, ref int int_0);

	[DllImport("wininet", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool DeleteUrlCacheEntry(IntPtr intptr_0);

	[DllImport("wininet")]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool InternetSetOption(IntPtr intptr_0, int int_0, IntPtr intptr_1, int int_1);

	[DllImport("ole32")]
	internal static extern int OleDraw(IntPtr intptr_0, int int_0, IntPtr intptr_1, ref Rectangle rectangle_0);

	[DllImport("user32")]
	internal static extern int FlashWindow(IntPtr intptr_0, int int_0);

	[DllImport("user32")]
	internal static extern IntPtr SendMessage(IntPtr intptr_0, int int_0, IntPtr intptr_1, IntPtr intptr_2);

	internal static bool smethod_0()
	{
		OperatingSystem oSVersion = Environment.OSVersion;
		if (oSVersion.Platform == PlatformID.Win32NT)
		{
			if (oSVersion.Version.Major <= 5)
			{
				if (oSVersion.Version.Major == 5)
				{
					return oSVersion.Version.Minor == 1;
				}
				return false;
			}
			return true;
		}
		return false;
	}

	internal static bool smethod_1()
	{
		OperatingSystem oSVersion = Environment.OSVersion;
		if (oSVersion.Platform == PlatformID.Win32NT)
		{
			return oSVersion.Version.Major >= 6;
		}
		return false;
	}
}
