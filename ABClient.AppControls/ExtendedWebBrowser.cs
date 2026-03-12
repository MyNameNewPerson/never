using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Threading;
using System.Windows.Forms;

namespace ABClient.AppControls;

[ToolboxBitmap(typeof(ExtendedWebBrowser))]
public class ExtendedWebBrowser : WebBrowser
{
	[ComImport]
	[TypeLibType(TypeLibTypeFlags.FHidden)]
	[Guid("34A715A0-6587-11D0-924A-0020AFC7AC4D")]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
	private interface IDWebBrowserEvents2
	{
		[DispId(250)]
		void BeforeNavigate2([In][MarshalAs(UnmanagedType.IDispatch)] object pointerDisp, [In] ref object url, [In] ref object flags, [In] ref object targetFrameName, [In] ref object postData, [In] ref object headers, [In][Out] ref bool cancel);

		[DispId(273)]
		void NewWindow3([In][MarshalAs(UnmanagedType.IDispatch)] object pointerDisp, [In][Out] ref bool cancel, [In] ref object flags, [In] ref object urlcontext, [In] ref object url);
	}

	public sealed class WebBrowserExtendedEvents : StandardOleMarshalObject, IDWebBrowserEvents2
	{
		private readonly ExtendedWebBrowser extendedWebBrowser_0;

		public WebBrowserExtendedEvents(ExtendedWebBrowser extbrowser)
		{
			extendedWebBrowser_0 = extbrowser;
		}

		public void BeforeNavigate2(object pointerDisp, ref object url, ref object flags, ref object targetFrameName, ref object postData, ref object headers, ref bool cancel)
		{
			extendedWebBrowser_0.OnBeforeNavigate((string)url, (string)targetFrameName, out cancel);
		}

		public void NewWindow3(object pointerDisp, ref bool cancel, ref object flags, ref object urlcontext, ref object url)
		{
			extendedWebBrowser_0.OnBeforeNewWindow((string)url, out cancel);
		}
	}

	private AxHost.ConnectionPointCookie connectionPointCookie_0;

	private WebBrowserExtendedEvents webBrowserExtendedEvents_0;

	private EventHandler<WebBrowserExtendedNavigatingEventArgs> eventHandler_0;

	private EventHandler<WebBrowserExtendedNavigatingEventArgs> eventHandler_1;

	internal void method_0(EventHandler<WebBrowserExtendedNavigatingEventArgs> eventHandler_2)
	{
		EventHandler<WebBrowserExtendedNavigatingEventArgs> eventHandler = eventHandler_0;
		EventHandler<WebBrowserExtendedNavigatingEventArgs> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<WebBrowserExtendedNavigatingEventArgs> value = (EventHandler<WebBrowserExtendedNavigatingEventArgs>)Delegate.Combine(eventHandler2, eventHandler_2);
			eventHandler = Interlocked.CompareExchange(ref eventHandler_0, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	internal void method_1(EventHandler<WebBrowserExtendedNavigatingEventArgs> eventHandler_2)
	{
		EventHandler<WebBrowserExtendedNavigatingEventArgs> eventHandler = eventHandler_0;
		EventHandler<WebBrowserExtendedNavigatingEventArgs> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<WebBrowserExtendedNavigatingEventArgs> value = (EventHandler<WebBrowserExtendedNavigatingEventArgs>)Delegate.Remove(eventHandler2, eventHandler_2);
			eventHandler = Interlocked.CompareExchange(ref eventHandler_0, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	internal void method_2(EventHandler<WebBrowserExtendedNavigatingEventArgs> eventHandler_2)
	{
		EventHandler<WebBrowserExtendedNavigatingEventArgs> eventHandler = eventHandler_1;
		EventHandler<WebBrowserExtendedNavigatingEventArgs> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<WebBrowserExtendedNavigatingEventArgs> value = (EventHandler<WebBrowserExtendedNavigatingEventArgs>)Delegate.Combine(eventHandler2, eventHandler_2);
			eventHandler = Interlocked.CompareExchange(ref eventHandler_1, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	internal void method_3(EventHandler<WebBrowserExtendedNavigatingEventArgs> eventHandler_2)
	{
		EventHandler<WebBrowserExtendedNavigatingEventArgs> eventHandler = eventHandler_1;
		EventHandler<WebBrowserExtendedNavigatingEventArgs> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<WebBrowserExtendedNavigatingEventArgs> value = (EventHandler<WebBrowserExtendedNavigatingEventArgs>)Delegate.Remove(eventHandler2, eventHandler_2);
			eventHandler = Interlocked.CompareExchange(ref eventHandler_1, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	[PermissionSet(SecurityAction.LinkDemand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\"/>\r\n")]
	protected override void CreateSink()
	{
		base.CreateSink();
		webBrowserExtendedEvents_0 = new WebBrowserExtendedEvents(this);
		connectionPointCookie_0 = new AxHost.ConnectionPointCookie(base.ActiveXInstance, webBrowserExtendedEvents_0, typeof(IDWebBrowserEvents2));
	}

	[PermissionSet(SecurityAction.LinkDemand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\"/>\r\n")]
	protected override void DetachSink()
	{
		if (connectionPointCookie_0 != null)
		{
			connectionPointCookie_0.Disconnect();
			connectionPointCookie_0 = null;
		}
		base.DetachSink();
	}

	protected void OnBeforeNewWindow(string address, out bool cancel)
	{
		EventHandler<WebBrowserExtendedNavigatingEventArgs> eventHandler = eventHandler_1;
		WebBrowserExtendedNavigatingEventArgs e = new WebBrowserExtendedNavigatingEventArgs(address, null);
		eventHandler?.Invoke(this, e);
		cancel = e.Cancel;
	}

	protected void OnBeforeNavigate(string address, string frame, out bool cancel)
	{
		EventHandler<WebBrowserExtendedNavigatingEventArgs> eventHandler = eventHandler_0;
		WebBrowserExtendedNavigatingEventArgs e = new WebBrowserExtendedNavigatingEventArgs(address, frame);
		eventHandler?.Invoke(this, e);
		cancel = e.Cancel;
	}
}
