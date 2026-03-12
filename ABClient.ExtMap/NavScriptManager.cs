using System.Runtime.InteropServices;
using ABClient.ABForms;
using ABClient.MyForms;

namespace ABClient.ExtMap;

[ComVisible(true)]
public class NavScriptManager
{
	private readonly FormNavigator formNavigator_0;

	public NavScriptManager(FormNavigator form)
	{
		formNavigator_0 = form;
	}

	public void MoveTo(string dest)
	{
		formNavigator_0.PointToDest(new string[1] { dest });
	}

	public bool IsCellExists(int int_0, int int_1)
	{
		return FormMain.smethod_66(int_0, int_1);
	}

	public bool IsCellInPath(int int_0, int int_1)
	{
		return Class77.smethod_32(int_0, int_1);
	}

	public string GenMoveLink(int int_0, int int_1)
	{
		return FormMain.smethod_67(int_0, int_1);
	}

	public string CellDivText(int int_0, int int_1, int scale, string link, bool showmove, bool isframe)
	{
		return Class77.smethod_18(int_0, int_1, scale, link, showmove, isframe);
	}

	public string CellAltText(int int_0, int int_1, int scale)
	{
		return Class77.smethod_19(int_0, int_1, scale);
	}
}
