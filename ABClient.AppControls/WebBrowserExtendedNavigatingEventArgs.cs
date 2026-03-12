using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ABClient.AppControls;

public sealed class WebBrowserExtendedNavigatingEventArgs : CancelEventArgs
{
	private string string_0;

	private string string_1;

	public string Address
	{
		[CompilerGenerated]
		get
		{
			return string_0;
		}
	}

	public string Frame
	{
		[CompilerGenerated]
		get
		{
			return string_1;
		}
	}

	public WebBrowserExtendedNavigatingEventArgs(string address, string frame)
	{
		method_0(address);
		method_1(frame);
	}

	private void method_0(string string_2)
	{
		string_0 = string_2;
	}

	private void method_1(string string_2)
	{
		string_1 = string_2;
	}
}
