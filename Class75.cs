using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Threading;

internal static class Class75
{
	[StructLayout(LayoutKind.Explicit)]
	public struct Struct18
	{
		[FieldOffset(0)]
		public uint uint_0;

		[FieldOffset(0)]
		public uint uint_1;
	}

	public struct Struct19
	{
		public uint uint_0;

		public IntPtr intptr_0;

		public IntPtr intptr_1;

		public uint uint_1;

		public uint uint_2;

		public uint uint_3;

		public uint uint_4;

		public uint uint_5;

		public System.Runtime.InteropServices.ComTypes.FILETIME filetime_0;

		public System.Runtime.InteropServices.ComTypes.FILETIME filetime_1;

		public System.Runtime.InteropServices.ComTypes.FILETIME filetime_2;

		public System.Runtime.InteropServices.ComTypes.FILETIME filetime_3;

		public IntPtr intptr_2;

		public uint uint_6;

		public IntPtr intptr_3;

		public Struct18 struct18_0;
	}

	[DllImport("wininet", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, SetLastError = true)]
	public static extern IntPtr FindFirstUrlCacheGroup(int int_0, int int_1, IntPtr intptr_0, int int_2, ref long long_0, IntPtr intptr_1);

	[DllImport("wininet", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, SetLastError = true)]
	public static extern bool FindNextUrlCacheGroup(IntPtr intptr_0, ref long long_0, IntPtr intptr_1);

	[DllImport("wininet", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, SetLastError = true)]
	public static extern bool DeleteUrlCacheGroup(long long_0, int int_0, IntPtr intptr_0);

	[DllImport("wininet", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, SetLastError = true)]
	public static extern IntPtr FindFirstUrlCacheEntryA([MarshalAs(UnmanagedType.LPTStr)] string string_0, IntPtr intptr_0, ref int int_0);

	[DllImport("wininet", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, SetLastError = true)]
	public static extern bool FindNextUrlCacheEntryA(IntPtr intptr_0, IntPtr intptr_1, ref int int_0);

	[DllImport("wininet", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, SetLastError = true)]
	public static extern bool DeleteUrlCacheEntryA(IntPtr intptr_0);

	internal static void smethod_0()
	{
		ThreadPool.QueueUserWorkItem(smethod_1);
	}

	private static void smethod_1(object object_0)
	{
		Thread.CurrentThread.Name = "ClearCacheAsync";
		Thread.Sleep(500);
		long long_ = 0L;
		IntPtr intPtr = FindFirstUrlCacheGroup(0, 0, IntPtr.Zero, 0, ref long_, IntPtr.Zero);
		if (intPtr != IntPtr.Zero)
		{
			do
			{
				DeleteUrlCacheGroup(long_, 2, IntPtr.Zero);
			}
			while (FindNextUrlCacheGroup(intPtr, ref long_, IntPtr.Zero));
		}
		int int_ = 0;
		FindFirstUrlCacheEntryA(null, IntPtr.Zero, ref int_);
		if (Marshal.GetLastWin32Error() == 122)
		{
			int num = int_;
			IntPtr intPtr2 = Marshal.AllocHGlobal(num);
			intPtr = FindFirstUrlCacheEntryA(null, intPtr2, ref int_);
			if (intPtr != IntPtr.Zero)
			{
				bool flag;
				do
				{
					Struct19 @struct = (Struct19)Marshal.PtrToStructure(intPtr2, typeof(Struct19));
					int_ = num;
					string text = Marshal.PtrToStringAnsi(@struct.intptr_0);
					try
					{
						Class72.smethod_0().BeginInvoke(new Delegate4(Class72.smethod_0().method_3), text);
					}
					catch (InvalidOperationException)
					{
					}
					DeleteUrlCacheEntryA(@struct.intptr_0);
					if (!(flag = FindNextUrlCacheEntryA(intPtr, intPtr2, ref int_)) && Marshal.GetLastWin32Error() == 122)
					{
						num = int_;
						intPtr2 = Marshal.ReAllocHGlobal(intPtr2, (IntPtr)num);
						flag = FindNextUrlCacheEntryA(intPtr, intPtr2, ref int_);
					}
				}
				while (flag && Class72.smethod_0().method_0());
			}
			Marshal.FreeHGlobal(intPtr2);
		}
		try
		{
			if (Class72.smethod_0() != null)
			{
				Class72.smethod_0().Invoke(new Delegate3(Class72.smethod_0().method_2));
			}
		}
		catch (InvalidOperationException)
		{
		}
	}
}
