using System;
using System.Drawing;
using System.Windows.Forms;

namespace ABClient.AppControls;

public class TreeViewEx : TreeView
{
	public TreeViewEx()
	{
		SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, value: true);
		if (!Class20.smethod_1())
		{
			SetStyle(ControlStyles.UserPaint, value: true);
		}
	}

	private void method_0()
	{
		int num = 0;
		if (DoubleBuffered)
		{
			num |= 4;
		}
		if (num != 0)
		{
			Class20.SendMessage(base.Handle, 4396, (IntPtr)4, (IntPtr)num);
		}
	}

	protected override void OnHandleCreated(EventArgs eventArgs_0)
	{
		base.OnHandleCreated(eventArgs_0);
		method_0();
		if (!Class20.smethod_0())
		{
			Class20.SendMessage(base.Handle, 4381, IntPtr.Zero, (IntPtr)ColorTranslator.ToWin32(BackColor));
		}
	}

	protected override void OnPaint(PaintEventArgs paintEventArgs_0)
	{
		if (GetStyle(ControlStyles.UserPaint))
		{
			Message m = new Message
			{
				HWnd = base.Handle,
				Msg = 792,
				WParam = paintEventArgs_0.Graphics.GetHdc(),
				LParam = (IntPtr)4
			};
			DefWndProc(ref m);
			paintEventArgs_0.Graphics.ReleaseHdc(m.WParam);
		}
		base.OnPaint(paintEventArgs_0);
	}
}
