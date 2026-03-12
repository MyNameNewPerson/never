using System;
using System.Drawing;
using System.Runtime.InteropServices;

internal sealed class Class9
{
	[StructLayout(LayoutKind.Explicit, Size = 80)]
	internal struct Struct11
	{
		[FieldOffset(12)]
		internal uint uint_0;

		[FieldOffset(4)]
		internal IntPtr intptr_0;
	}

	internal struct Struct12 : IDisposable
	{
		private readonly int int_0;

		private readonly IntPtr intptr_0;

		private readonly IntPtr intptr_1;

		internal Struct12(int int_1, IntPtr intptr_2, IntPtr intptr_3)
		{
			int_0 = int_1;
			intptr_0 = intptr_2;
			intptr_1 = intptr_3;
		}

		public void Dispose()
		{
		}
	}

	[DllImport("ole32.dll")]
	internal static extern IntPtr OleDraw(IntPtr intptr_0, int int_0, IntPtr intptr_1, ref Rectangle rectangle_0);

	[DllImport("user32.dll")]
	internal static extern IntPtr FlashWindow(IntPtr intptr_0, bool bool_0);

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	internal static extern IntPtr SendMessage(IntPtr intptr_0, int int_0, IntPtr intptr_1, ref Struct17 struct17_0);

	[DllImport("wininet.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto)]
	internal static extern IntPtr FindFirstUrlCacheEntryA([MarshalAs(UnmanagedType.LPTStr)] string string_0, IntPtr intptr_0, ref int int_0);

	[DllImport("wininet.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto)]
	internal static extern IntPtr DeleteUrlCacheEntryA(IntPtr intptr_0);

	[DllImport("wininet.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, SetLastError = true)]
	internal static extern bool FindNextUrlCacheEntryA(IntPtr intptr_0, IntPtr intptr_1, ref int int_0);

	[DllImport("wininet.dll")]
	internal static extern IntPtr InternetSetOption(IntPtr intptr_0, int int_0, IntPtr intptr_1, int int_1);
}
