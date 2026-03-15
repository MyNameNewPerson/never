using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using ABClient.AppControls;

namespace ABClient;

public static class ContactsManager
{
	private static int int_0 = 0;

	public static readonly ReaderWriterLock Rwl = new ReaderWriterLock();

	public static void Init(TreeViewEx tree)
	{
		try
		{
			Rwl.AcquireWriterLock(5000);
			try
			{
				tree.BeginUpdate();
				tree.Nodes.Clear();
				foreach (KeyValuePair<string, Class76> item in Class72.class19_0.method_140())
				{
					smethod_1(tree, item.Value);
				}
				tree.EndUpdate();
			}
			finally
			{
				Rwl.ReleaseWriterLock();
			}
		}
		catch (ApplicationException)
		{
		}
	}

	public static void Pulse()
	{
		if (!Class72.class19_0.method_142() || Class72.class19_0.method_140().Count == 0)
		{
			return;
		}
		bool flag = false;
		foreach (Class76 value2 in Class72.class19_0.method_140().Values)
		{
			if (value2.method_6())
			{
				flag = true;
				break;
			}
		}
		if (!flag)
		{
			return;
		}
		string text = string.Empty;
		while (string.IsNullOrEmpty(text))
		{
			if (int_0 >= Class72.class19_0.method_140().Count)
			{
				int_0 = 0;
			}
			string text2 = Class72.class19_0.method_140().Keys[int_0];
			if (Class72.class19_0.method_140().TryGetValue(text2, out var value) && value.method_6())
			{
				text = text2;
			}
			else
			{
				int_0++;
			}
		}
		ThreadPool.QueueUserWorkItem(smethod_0, text);
	}

	private static void smethod_0(object object_0)
	{
		int_0++;
		if (Class72.class19_0.method_140().TryGetValue((string)object_0, out var value))
		{
			if (string.IsNullOrEmpty(value.method_2()))
			{
				value.method_3(Class21.smethod_2(value.method_0()));
			}
			value.method_47(Class21.smethod_3(value.method_2()));
		}
	}

	private static void smethod_1(TreeView treeView_0, Class76 class76_0)
	{
		try
		{
			Rwl.AcquireWriterLock(5000);
			try
			{
				TreeNode treeNode = smethod_3(class76_0);
				string text = class76_0.method_16();
				if (string.IsNullOrEmpty(text))
				{
					treeView_0.Nodes.Add(treeNode);
					return;
				}
				if (!treeView_0.Nodes.ContainsKey(text))
				{
					TreeNode treeNode2 = smethod_4(text, class76_0);
					treeView_0.Nodes.Insert(0, treeNode2);
					treeNode2.Nodes.Add(treeNode);
					Class72.class19_0.method_140()[class76_0.method_0().ToLower()].method_25(text);
					smethod_9(treeNode2);
					return;
				}
				TreeNode treeNode3 = treeView_0.Nodes[text];
				treeNode3.Nodes.Add(treeNode);
				if (treeNode.Checked && !treeNode3.Checked)
				{
					treeNode3.Checked = true;
				}
				Class72.class19_0.method_140()[class76_0.method_0().ToLower()].method_25(text);
				smethod_9(treeNode3);
			}
			finally
			{
				Rwl.ReleaseWriterLock();
			}
		}
		catch (ApplicationException)
		{
		}
	}

	internal static void smethod_2(TreeViewEx treeViewEx_0, string string_0)
	{
		try
		{
			Rwl.AcquireWriterLock(5000);
			try
			{
				string string_1 = Class21.smethod_2(string_0);
				Class76 @class = new Class76(string_0, string_1, 0, 0, string.Empty, bool_5: true);
				if (!Class72.class19_0.method_140().ContainsKey(string_0.ToLower()))
				{
					Class72.class19_0.method_140().Add(string_0.ToLower(), @class);
					smethod_1(treeViewEx_0, @class);
				}
			}
			finally
			{
				Rwl.ReleaseWriterLock();
			}
		}
		catch (ApplicationException)
		{
		}
	}

	private static TreeNode smethod_3(Class76 class76_0)
	{
		TreeNode obj = new TreeNode
		{
			Name = class76_0.method_22(),
			Text = class76_0.ToString(),
			ContextMenuStrip = Class72.formMain_0.CmPerson,
			Checked = class76_0.method_6(),
			ForeColor = Color.SteelBlue,
			Tag = class76_0
		};
		string imageKey = (obj.SelectedImageKey = smethod_14(class76_0));
		obj.ImageKey = imageKey;
		return obj;
	}

	private static TreeNode smethod_4(string string_0, Class76 class76_0)
	{
		TreeNode obj = new TreeNode
		{
			Name = string_0,
			Text = string_0,
			ContextMenuStrip = Class72.formMain_0.CmGroup,
			Checked = class76_0.method_6(),
			ForeColor = Color.Black,
			Tag = null
		};
		string imageKey = (obj.SelectedImageKey = smethod_14(class76_0));
		obj.ImageKey = imageKey;
		return obj;
	}

	internal static int smethod_5(string string_0)
	{
		if (!Class72.class19_0.method_140().ContainsKey(string_0.ToLower()))
		{
			return -1;
		}
		return Class72.class19_0.method_140()[string_0.ToLower()].method_8();
	}

	internal static int smethod_6(string string_0)
	{
		if (!Class72.class19_0.method_140().ContainsKey(string_0.ToLower()))
		{
			return -1;
		}
		return Class72.class19_0.method_140()[string_0.ToLower()].method_10();
	}

	internal static Color smethod_7(int int_1, bool bool_0)
	{
		switch (int_1)
		{
		default:
			return Color.Black;
		case 0:
			if (!bool_0)
			{
				return Color.LightGray;
			}
			return Color.Black;
		case 1:
			if (!bool_0)
			{
				return Color.LightPink;
			}
			return Color.DarkRed;
		case 2:
			if (!bool_0)
			{
				return Color.MediumAquamarine;
			}
			return Color.DarkGreen;
		}
	}

	internal static void smethod_8(TreeViewEx treeViewEx_0, Class76 class76_0)
	{
		try
		{
			Rwl.AcquireWriterLock(5000);
			try
			{
				if (Class72.class19_0.method_140().ContainsKey(class76_0.method_0().ToLower()) && !Class72.class19_0.method_140()[class76_0.method_0().ToLower()].method_6())
				{
					return;
				}
				TreeNode treeNode = smethod_15(treeViewEx_0, class76_0);
				if (treeNode == null)
				{
					return;
				}
				treeNode.Text = class76_0.ToString();
				if (!string.IsNullOrEmpty(class76_0.method_40()))
				{
					treeNode.Text += " [В бою]";
				}
				treeNode.ForeColor = smethod_7(class76_0.method_8(), class76_0.method_36());
				string imageKey = (treeNode.SelectedImageKey = smethod_14(class76_0));
				treeNode.ImageKey = imageKey;
				treeNode.ToolTipText = class76_0.method_20();
				string text2 = class76_0.method_16();
				if (!text2.Equals(class76_0.method_24(), StringComparison.OrdinalIgnoreCase))
				{
					if (string.IsNullOrEmpty(class76_0.method_24()))
					{
						treeViewEx_0.Nodes.Remove(treeNode);
					}
					else if (treeViewEx_0.Nodes.ContainsKey(class76_0.method_24()))
					{
						TreeNode treeNode2 = treeViewEx_0.Nodes[class76_0.method_24()];
						treeNode2.Nodes.Remove(treeNode);
						smethod_9(treeNode2);
					}
					if (string.IsNullOrEmpty(text2))
					{
						treeViewEx_0.Nodes.Add(treeNode);
					}
					else if (!treeViewEx_0.Nodes.ContainsKey(text2))
					{
						TreeNode treeNode3 = smethod_4(text2, class76_0);
						treeViewEx_0.Nodes.Insert(0, treeNode3);
						treeNode3.Nodes.Add(treeNode);
						smethod_9(treeNode3);
						if (Class72.class19_0.method_140().ContainsKey(class76_0.method_0().ToLower()))
						{
							Class72.class19_0.method_140()[class76_0.method_0().ToLower()].method_25(text2);
						}
					}
					else
					{
						treeViewEx_0.Nodes[text2].Nodes.Add(treeNode);
						if (Class72.class19_0.method_140().ContainsKey(class76_0.method_0().ToLower()))
						{
							Class72.class19_0.method_140()[class76_0.method_0().ToLower()].method_25(text2);
						}
					}
				}
				if (!string.IsNullOrEmpty(text2) && treeViewEx_0.Nodes.ContainsKey(text2))
				{
					smethod_9(treeViewEx_0.Nodes[text2]);
				}
			}
			finally
			{
				Rwl.ReleaseWriterLock();
			}
		}
		catch (ApplicationException)
		{
		}
	}

	private static void smethod_9(TreeNode treeNode_0)
	{
		int num = 0;
		int num2 = 0;
		int[] array = new int[3];
		foreach (TreeNode node in treeNode_0.Nodes)
		{
			Class76 @class = (Class76)node.Tag;
			if (@class == null)
			{
				continue;
			}
			if (@class.method_8() >= 0 && @class.method_8() <= 2)
			{
				array[@class.method_8()]++;
			}
			if (@class.method_6())
			{
				num++;
				if (@class.method_36())
				{
					num2++;
				}
			}
		}
		treeNode_0.Text = ((num == 0) ? treeNode_0.Name : $"{treeNode_0.Name} ({num2}/{num})");
		if (!treeNode_0.Checked)
		{
			treeNode_0.ForeColor = Color.SteelBlue;
		}
		else if (array[0] > 0 && array[1] == 0 && array[2] == 0)
		{
			treeNode_0.ForeColor = smethod_7(0, num2 > 0);
		}
		else if (array[0] == 0 && array[1] > 0 && array[2] == 0)
		{
			treeNode_0.ForeColor = smethod_7(1, num2 > 0);
		}
		else if (array[0] == 0 && array[1] == 0 && array[2] > 0)
		{
			treeNode_0.ForeColor = smethod_7(2, num2 > 0);
		}
		else
		{
			treeNode_0.ForeColor = ((num2 > 0) ? Color.Black : Color.LightGray);
		}
	}

	internal static void smethod_10(Class76 class76_0, string string_0)
	{
		if (Class72.class19_0.method_140().ContainsKey(class76_0.method_0().ToLower()))
		{
			Class72.class19_0.method_140()[class76_0.method_0().ToLower()].method_5(string_0);
		}
	}

	internal static void smethod_11(TreeViewEx treeViewEx_0, TreeNode treeNode_0)
	{
		try
		{
			Rwl.AcquireWriterLock(5000);
			try
			{
				Class76 @class = (Class76)treeNode_0.Tag;
				treeNode_0.Remove();
				if (!string.IsNullOrEmpty(@class.method_24()) && treeViewEx_0.Nodes.ContainsKey(@class.method_24()))
				{
					smethod_9(treeViewEx_0.Nodes[@class.method_24()]);
				}
				if (Class72.class19_0.method_140().ContainsKey(@class.method_0().ToLower()))
				{
					Class72.class19_0.method_140().Remove(@class.method_0().ToLower());
				}
				Class72.class19_0.method_20();
			}
			finally
			{
				Rwl.ReleaseWriterLock();
			}
		}
		catch (ApplicationException)
		{
		}
	}

	internal static void smethod_12(TreeViewEx treeViewEx_0, string string_0)
	{
		try
		{
			Rwl.AcquireWriterLock(5000);
			try
			{
				if (!treeViewEx_0.Nodes.ContainsKey(string_0))
				{
					return;
				}
				TreeNode treeNode = treeViewEx_0.Nodes[string_0];
				treeViewEx_0.BeginUpdate();
				for (int num = treeNode.Nodes.Count - 1; num >= 0; num--)
				{
					TreeNode treeNode2 = treeNode.Nodes[num];
					Class76 @class = (Class76)treeNode2.Tag;
					treeNode2.Remove();
					if (Class72.class19_0.method_140().ContainsKey(@class.method_0().ToLower()))
					{
						Class72.class19_0.method_140().Remove(@class.method_0().ToLower());
					}
				}
				treeNode.Remove();
				treeViewEx_0.EndUpdate();
				Class72.class19_0.method_20();
			}
			finally
			{
				Rwl.ReleaseWriterLock();
			}
		}
		catch (ApplicationException)
		{
		}
	}

	internal static void smethod_13(TreeView treeView_0, TreeNode treeNode_0)
	{
		try
		{
			Rwl.AcquireWriterLock(5000);
			try
			{
				if (treeNode_0.Tag == null)
				{
					foreach (TreeNode node in treeNode_0.Nodes)
					{
						node.Checked = treeNode_0.Checked;
					}
					return;
				}
				Class76 @class = (Class76)treeNode_0.Tag;
				if (Class72.class19_0.method_140().ContainsKey(@class.method_0().ToLower()))
				{
					Class72.class19_0.method_140()[@class.method_0().ToLower()].method_7(treeNode_0.Checked);
				}
				if (!string.IsNullOrEmpty(@class.method_24()) && treeView_0.Nodes.ContainsKey(@class.method_24()))
				{
					smethod_9(treeView_0.Nodes[@class.method_24()]);
				}
				if (!treeNode_0.Checked)
				{
					treeNode_0.ForeColor = Color.SteelBlue;
				}
			}
			finally
			{
				Rwl.ReleaseWriterLock();
			}
		}
		catch (ApplicationException)
		{
		}
	}

	private static string smethod_14(Class76 class76_0)
	{
		if (class76_0.method_28()[3] > 0)
		{
			return "injury0";
		}
		if (class76_0.method_28()[2] > 0)
		{
			return "injury1";
		}
		if (class76_0.method_28()[1] > 0)
		{
			return "injury4";
		}
		if (class76_0.method_28()[0] > 0)
		{
			return "injury4";
		}
		if (class76_0.method_34())
		{
			return "molch";
		}
		if (string.IsNullOrEmpty(class76_0.method_12()))
		{
			return "neutral";
		}
		if (string.CompareOrdinal(class76_0.method_12(), "none") == 0)
		{
			if (string.IsNullOrEmpty(class76_0.method_14()))
			{
				return "neutral";
			}
			string text = string.Empty;
			string text2 = class76_0.method_14();
			switch (Class0.smethod_0(text2))
			{
			case 822911587u:
				if (text2 == "4")
				{
					text = "chaoss.gif";
				}
				break;
			case 806133968u:
				if (text2 == "5")
				{
					text = "light.gif";
				}
				break;
			case 856466825u:
				if (text2 == "6")
				{
					text = "dark.gif";
				}
				break;
			case 839689206u:
				if (text2 == "7")
				{
					text = "sumer.gif";
				}
				break;
			case 906799682u:
				if (text2 == "3")
				{
					text = "sumers.gif";
				}
				break;
			case 873244444u:
				if (text2 == "1")
				{
					text = "darks.gif";
				}
				break;
			case 1024243015u:
				if (text2 == "8")
				{
					text = "chaos.gif";
				}
				break;
			case 1007465396u:
				if (text2 == "9")
				{
					text = "angel.gif";
				}
				break;
			case 923577301u:
				if (text2 == "2")
				{
					text = "lights.gif";
				}
				break;
			}
			if (string.IsNullOrEmpty(text))
			{
				return "none";
			}
			if (Class72.formMain_0.imageList_3.Images.ContainsKey(text))
			{
				return text;
			}
			string text3 = Path.Combine(Application.StartupPath, Class68.string_9 + "\\image.neverlands.ru\\signs\\" + text);
			if (!File.Exists(text3))
			{
				return "neutral";
			}
			try
			{
				Class72.formMain_0.imageList_3.Images.Add(text, Image.FromFile(text3));
				return text;
			}
			catch
			{
				return "neutral";
			}
		}
		if (Class72.formMain_0.imageList_3.Images.ContainsKey(class76_0.method_12()))
		{
			return class76_0.method_12();
		}
		string text4 = Path.Combine(Application.StartupPath, Class68.string_9 + "\\image.neverlands.ru\\signs\\" + class76_0.method_12());
		if (!File.Exists(text4))
		{
			return "neutral";
		}
		try
		{
			Class72.formMain_0.imageList_3.Images.Add(class76_0.method_12(), Image.FromFile(text4));
		}
		catch
		{
			return "neutral";
		}
		return class76_0.method_12();
	}

	internal static TreeNode smethod_15(TreeView treeView_0, Class76 class76_0)
	{
		if (treeView_0.Nodes.ContainsKey(class76_0.method_22()))
		{
			return treeView_0.Nodes[class76_0.method_22()];
		}
		if (treeView_0.Nodes.ContainsKey(class76_0.method_24()))
		{
			TreeNode treeNode = treeView_0.Nodes[class76_0.method_24()];
			if (treeNode.Nodes.ContainsKey(class76_0.method_22()))
			{
				return treeNode.Nodes[class76_0.method_22()];
			}
		}
		return null;
	}
}
