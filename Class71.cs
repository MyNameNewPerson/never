using System;
using System.Collections.Generic;
using System.Threading;

internal static class Class71
{
	private static readonly List<Class69> list_0 = new List<Class69>();

	private static readonly ReaderWriterLock readerWriterLock_0 = new ReaderWriterLock();

	internal static void smethod_0(IEnumerable<Class69> ienumerable_0)
	{
		list_0.Clear();
		foreach (Class69 item in ienumerable_0)
		{
			smethod_1(item);
		}
	}

	internal static void smethod_1(Class69 class69_0)
	{
		try
		{
			readerWriterLock_0.AcquireWriterLock(5000);
			try
			{
				if (class69_0.dateTime_0 < DateTime.Now)
				{
					return;
				}
				if (list_0.Count == 0)
				{
					class69_0.int_2 = 1;
					list_0.Add(class69_0);
					return;
				}
				int num = 0;
				foreach (Class69 item in list_0)
				{
					if (item.int_2 > num)
					{
						num = item.int_2;
					}
				}
				class69_0.int_2 = num + 1;
				int num2 = list_0.Count - 1;
				if (class69_0.dateTime_0 > list_0[num2].dateTime_0)
				{
					list_0.Add(class69_0);
					return;
				}
				bool flag = false;
				int num3 = num2 - 1;
				while (num3 >= 0)
				{
					if (!(class69_0.dateTime_0 > list_0[num3].dateTime_0))
					{
						num3--;
						continue;
					}
					list_0.Insert(num3 + 1, class69_0);
					flag = true;
					break;
				}
				if (!flag)
				{
					list_0.Insert(0, class69_0);
				}
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

	internal static Class69[] smethod_2()
	{
		return list_0.ToArray();
	}

	internal static void smethod_3(int int_0)
	{
		try
		{
			readerWriterLock_0.AcquireWriterLock(5000);
			try
			{
				if (int_0 >= 0 && int_0 < list_0.Count)
				{
					list_0.RemoveAt(int_0);
				}
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

	internal static void smethod_4()
	{
		try
		{
			readerWriterLock_0.AcquireWriterLock(5000);
			try
			{
				int num = 0;
				int num2 = -1;
				for (int i = 0; i < list_0.Count; i++)
				{
					Class69 @class = list_0[i];
					if (@class.int_2 > num)
					{
						num = @class.int_2;
						num2 = i;
					}
				}
				if (num2 >= 0)
				{
					smethod_3(num2);
				}
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
}
