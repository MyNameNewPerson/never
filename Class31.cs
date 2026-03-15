using System;
using System.Net;
using System.Windows.Forms;
using ABClient;
using ABClient.ABForms;

internal static class Class31
{
	[STAThread]
	internal static void Main()
	{
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(defaultValue: false);
		Class54.smethod_0();
		ServicePointManager.Expect100Continue = false;
		Class19 @class = Class14.smethod_0();
		if (@class == null)
		{
			return;
		}
		Class72.class19_0 = @class;
		Class72.class19_0.method_115(bool_55: true);
		Class71.smethod_0(Class72.class19_0.list_0.ToArray());
		Class72.class55_0.method_8(Class72.class19_0.method_30());
		ClearExplorerCacheForm clearExplorerCacheForm = new ClearExplorerCacheForm();
		Class72.smethod_1(clearExplorerCacheForm);
		using (clearExplorerCacheForm)
		{
			Class75.smethod_0();
			Class72.smethod_0().ShowDialog();
		}
		Class72.smethod_1(null);
		Class72.smethod_11(Class72.class19_0.method_40());
		ChatUsersManager.smethod_0();
		FeatureBrowserEmulation.smethod_0();
		Class45 class2 = new Class45();
		try
		{
			if (!class2.method_0())
			{
				MessageBox.Show(Class39.smethod_81(), Class72.class55_0.method_4(), MessageBoxButtons.OK, MessageBoxIcon.Hand);
				return;
			}
			Class72.formMain_0 = new FormMain();
			Application.Run(Class72.formMain_0);
			Class72.formMain_0 = null;
		}
		finally
		{
			((IDisposable)class2).Dispose();
		}
		ChatUsersManager.Save();
		if (!string.IsNullOrEmpty(Class72.smethod_6()))
		{
			MessageBox.Show(Class72.smethod_6(), Class72.class55_0.method_6(), MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}
	}
}
