using System;
using System.Windows.Forms;

namespace ABClient.AppControls;

public class ListBoxEx : ListBox
{
	protected override void Sort()
	{
		method_0(0, base.Items.Count - 1);
	}

	public void ManualSort()
	{
		Sort();
	}

	private void method_0(int int_0, int int_1)
	{
		if (int_1 > int_0)
		{
			int num = method_1(int_0, int_1, int_0);
			method_0(int_0, num - 1);
			method_0(num + 1, int_1);
		}
	}

	private int method_1(int int_0, int int_1, int int_2)
	{
		IComparable comparable = (IComparable)base.Items[int_2];
		method_2(int_2, int_1);
		int num = int_0;
		for (int i = int_0; i < int_1; i++)
		{
			if (comparable.CompareTo(base.Items[i]) >= 0)
			{
				method_2(i, num);
				num++;
			}
		}
		method_2(num, int_1);
		return num;
	}

	private void method_2(int int_0, int int_1)
	{
		object value = base.Items[int_0];
		base.Items[int_0] = base.Items[int_1];
		base.Items[int_1] = value;
	}
}
