using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ABClient.AppControls;

[ToolboxBitmap(typeof(CollapsibleSplitter))]
public class CollapsibleSplitter : Splitter
{
	private readonly Color color_0 = smethod_0(SystemColors.Highlight, SystemColors.Window, 70);

	private Border3DStyle border3DStyle_0 = Border3DStyle.Flat;

	private Control control_0;

	private SplitterState splitterState_0;

	private bool bool_0;

	private bool bool_1;

	private Form form_0;

	private Rectangle rectangle_0;

	private SplitterVisualStyle splitterVisualStyle_0;

	[DefaultValue("False")]
	[Category("Collapsing Options")]
	[Description("The initial state of the Splitter. Set to True if the control to hide is not visible by default")]
	[Bindable(true)]
	public bool IsCollapsed
	{
		get
		{
			if (control_0 != null)
			{
				return !control_0.Visible;
			}
			return true;
		}
	}

	[DefaultValue("")]
	[Bindable(true)]
	[Category("Collapsing Options")]
	[Description("The System.Windows.Forms.Control that the splitter will collapse")]
	public Control ControlToHide
	{
		get
		{
			return control_0;
		}
		set
		{
			control_0 = value;
		}
	}

	[Bindable(true)]
	[DefaultValue("False")]
	[Description("When true the entire parent form will be expanded and collapsed, otherwise just the contol to expand will be changed")]
	[Category("Collapsing Options")]
	public bool ExpandParentForm
	{
		get
		{
			return bool_0;
		}
		set
		{
			bool_0 = value;
		}
	}

	[Description("The visual style that will be painted on the control")]
	[DefaultValue("VisualStyles.XP")]
	[Bindable(true)]
	[Category("Collapsing Options")]
	public SplitterVisualStyle VisualStyle
	{
		get
		{
			return splitterVisualStyle_0;
		}
		set
		{
			splitterVisualStyle_0 = value;
			Invalidate();
		}
	}

	[Bindable(true)]
	[Category("Collapsing Options")]
	[Description("An optional border style to paint on the control. Set to Flat for no border")]
	[DefaultValue("System.Windows.Forms.Border3DStyle.Flat")]
	public Border3DStyle BorderStyle3D
	{
		get
		{
			return border3DStyle_0;
		}
		set
		{
			border3DStyle_0 = value;
			Invalidate();
		}
	}

	public CollapsibleSplitter()
	{
		base.Click += CollapsibleSplitter_Click;
		base.Resize += CollapsibleSplitter_Resize;
		base.MouseLeave += CollapsibleSplitter_MouseLeave;
		base.MouseMove += CollapsibleSplitter_MouseMove;
	}

	public void ToggleState()
	{
		method_0();
	}

	protected override void OnHandleCreated(EventArgs eventArgs_0)
	{
		base.OnHandleCreated(eventArgs_0);
		form_0 = FindForm();
		if (control_0 != null)
		{
			splitterState_0 = (control_0.Visible ? SplitterState.Expanded : SplitterState.Collapsed);
		}
	}

	protected override void OnEnabledChanged(EventArgs eventArgs_0)
	{
		base.OnEnabledChanged(eventArgs_0);
		Invalidate();
	}

	protected override void OnMouseDown(MouseEventArgs mouseEventArgs_0)
	{
		if (control_0 != null && !bool_1 && control_0.Visible)
		{
			base.OnMouseDown(mouseEventArgs_0);
		}
	}

	protected override void OnPaint(PaintEventArgs paintEventArgs_0)
	{
		Graphics graphics = paintEventArgs_0.Graphics;
		Rectangle clientRectangle = base.ClientRectangle;
		graphics.FillRectangle(new SolidBrush(BackColor), clientRectangle);
		switch (Dock)
		{
		case DockStyle.Left:
		case DockStyle.Right:
			method_1(graphics, clientRectangle, paintEventArgs_0);
			break;
		case DockStyle.Top:
		case DockStyle.Bottom:
			method_2(graphics, clientRectangle, paintEventArgs_0);
			break;
		}
		graphics.Dispose();
	}

	private static Color smethod_0(Color color_1, Color color_2, int int_0)
	{
		Color color = Color.FromArgb(255, color_1);
		Color color2 = Color.FromArgb(255, color_2);
		float num = (int)color.R;
		float num2 = (int)color.G;
		float num3 = (int)color.B;
		float num4 = (int)color2.R;
		float num5 = (int)color2.G;
		float num6 = (int)color2.B;
		byte red = (byte)(num * (float)int_0 / 255f + num4 * ((float)(255 - int_0) / 255f));
		byte green = (byte)(num2 * (float)int_0 / 255f + num5 * ((float)(255 - int_0) / 255f));
		byte blue = (byte)(num3 * (float)int_0 / 255f + num6 * ((float)(255 - int_0) / 255f));
		return Color.FromArgb(255, red, green, blue);
	}

	private void CollapsibleSplitter_Resize(object sender, EventArgs e)
	{
		Invalidate();
	}

	private void CollapsibleSplitter_MouseMove(object sender, MouseEventArgs e)
	{
		if (e.X >= rectangle_0.X && e.X <= rectangle_0.X + rectangle_0.Width && e.Y >= rectangle_0.Y && e.Y <= rectangle_0.Y + rectangle_0.Height)
		{
			if (!bool_1)
			{
				bool_1 = true;
				Cursor = Cursors.Hand;
				Invalidate();
			}
			return;
		}
		if (bool_1)
		{
			bool_1 = false;
			Invalidate();
		}
		Cursor = Cursors.Default;
		if (control_0 != null)
		{
			if (!control_0.Visible)
			{
				Cursor = Cursors.Default;
			}
			else if (Dock != DockStyle.Left && Dock != DockStyle.Right)
			{
				Cursor = Cursors.HSplit;
			}
			else
			{
				Cursor = Cursors.VSplit;
			}
		}
	}

	private void CollapsibleSplitter_MouseLeave(object sender, EventArgs e)
	{
		bool_1 = false;
		Invalidate();
	}

	private void CollapsibleSplitter_Click(object sender, EventArgs e)
	{
		if (control_0 != null && bool_1 && splitterState_0 != SplitterState.Collapsing && splitterState_0 != SplitterState.Expanding)
		{
			method_0();
		}
	}

	private void method_0()
	{
		if (splitterState_0 == SplitterState.Collapsing || splitterState_0 == SplitterState.Expanding)
		{
			return;
		}
		if (control_0.Visible)
		{
			splitterState_0 = SplitterState.Collapsed;
			control_0.Visible = false;
			if (bool_0 && form_0 != null)
			{
				if (Dock != DockStyle.Left && Dock != DockStyle.Right)
				{
					form_0.Height -= control_0.Height;
				}
				else
				{
					form_0.Width -= control_0.Width;
				}
			}
			return;
		}
		splitterState_0 = SplitterState.Expanded;
		control_0.Visible = true;
		if (bool_0 && form_0 != null)
		{
			if (Dock != DockStyle.Left && Dock != DockStyle.Right)
			{
				form_0.Height += control_0.Height;
			}
			else
			{
				form_0.Width += control_0.Width;
			}
		}
	}

	private void method_1(Graphics graphics_0, Rectangle rectangle_1, PaintEventArgs paintEventArgs_0)
	{
		rectangle_0 = new Rectangle(rectangle_1.X, rectangle_1.Y + (rectangle_1.Height - 115) / 2, 8, 115);
		base.Width = 8;
		graphics_0.FillRectangle(bool_1 ? new SolidBrush(color_0) : new SolidBrush(BackColor), new Rectangle(rectangle_0.X + 1, rectangle_0.Y, 6, 115));
		graphics_0.DrawLine(new Pen(SystemColors.ControlDark, 1f), rectangle_0.X + 1, rectangle_0.Y, rectangle_0.X + rectangle_0.Width - 2, rectangle_0.Y);
		graphics_0.DrawLine(new Pen(SystemColors.ControlDark, 1f), rectangle_0.X + 1, rectangle_0.Y + rectangle_0.Height, rectangle_0.X + rectangle_0.Width - 2, rectangle_0.Y + rectangle_0.Height);
		if (base.Enabled)
		{
			graphics_0.FillPolygon(new SolidBrush(SystemColors.ControlDarkDark), method_3(rectangle_0.X + 2, rectangle_0.Y + 3));
			graphics_0.FillPolygon(new SolidBrush(SystemColors.ControlDarkDark), method_3(rectangle_0.X + 2, rectangle_0.Y + rectangle_0.Height - 9));
		}
		int num = rectangle_0.X + 3;
		int num2 = rectangle_0.Y + 14;
		switch (splitterVisualStyle_0)
		{
		case SplitterVisualStyle.NonMicrosoft:
		{
			for (int k = 0; k < 30; k++)
			{
				graphics_0.DrawLine(new Pen(SystemColors.ControlLightLight), num, num2 + k * 3, num + 1, num2 + 1 + k * 3);
				graphics_0.DrawLine(new Pen(SystemColors.ControlDarkDark), num + 1, num2 + 1 + k * 3, num + 2, num2 + 2 + k * 3);
				graphics_0.DrawLine(bool_1 ? new Pen(color_0) : new Pen(BackColor), num + 2, num2 + 1 + k * 3, num + 2, num2 + 2 + k * 3);
			}
			break;
		}
		case SplitterVisualStyle.XP:
		{
			for (int j = 0; j < 18; j++)
			{
				graphics_0.DrawRectangle(new Pen(SystemColors.ControlLight), num, num2 + j * 5, 2, 2);
				graphics_0.DrawRectangle(new Pen(SystemColors.ControlLightLight), num + 1, num2 + 1 + j * 5, 1, 1);
				graphics_0.DrawRectangle(new Pen(SystemColors.ControlDarkDark), num, num2 + j * 5, 1, 1);
				graphics_0.DrawLine(new Pen(SystemColors.ControlDark), num, num2 + j * 5, num, num2 + j * 5 + 1);
				graphics_0.DrawLine(new Pen(SystemColors.ControlDark), num, num2 + j * 5, num + 1, num2 + j * 5);
			}
			break;
		}
		case SplitterVisualStyle.Win9X:
			graphics_0.DrawLine(new Pen(SystemColors.ControlLightLight), num, num2, num + 2, num2);
			graphics_0.DrawLine(new Pen(SystemColors.ControlLightLight), num, num2, num, num2 + 90);
			graphics_0.DrawLine(new Pen(SystemColors.ControlDark), num + 2, num2, num + 2, num2 + 90);
			graphics_0.DrawLine(new Pen(SystemColors.ControlDark), num, num2 + 90, num + 2, num2 + 90);
			break;
		case SplitterVisualStyle.DoubleDots:
		{
			int num3;
			for (num3 = 0; num3 < 30; num3++)
			{
				graphics_0.DrawRectangle(new Pen(SystemColors.ControlLightLight), num, num2 + 1 + num3 * 3, 1, 1);
				graphics_0.DrawRectangle(new Pen(SystemColors.ControlDark), num - 1, num2 + num3 * 3, 1, 1);
				num3++;
				graphics_0.DrawRectangle(new Pen(SystemColors.ControlLightLight), num + 2, num2 + 1 + num3 * 3, 1, 1);
				graphics_0.DrawRectangle(new Pen(SystemColors.ControlDark), num + 1, num2 + num3 * 3, 1, 1);
			}
			break;
		}
		case SplitterVisualStyle.Lines:
		{
			for (int i = 0; i < 44; i++)
			{
				graphics_0.DrawLine(new Pen(SystemColors.ControlDark), num, num2 + i * 2, num + 2, num2 + i * 2);
			}
			break;
		}
		}
		if (border3DStyle_0 != Border3DStyle.Flat)
		{
			ControlPaint.DrawBorder3D(paintEventArgs_0.Graphics, base.ClientRectangle, border3DStyle_0, Border3DSide.Left);
			ControlPaint.DrawBorder3D(paintEventArgs_0.Graphics, base.ClientRectangle, border3DStyle_0, Border3DSide.Right);
		}
	}

	private void method_2(Graphics graphics_0, Rectangle rectangle_1, PaintEventArgs paintEventArgs_0)
	{
		rectangle_0 = new Rectangle(rectangle_1.X + (rectangle_1.Width - 115) / 2, rectangle_1.Y, 115, 8);
		base.Height = 8;
		graphics_0.FillRectangle(bool_1 ? new SolidBrush(color_0) : new SolidBrush(BackColor), new Rectangle(rectangle_0.X, rectangle_0.Y + 1, 115, 6));
		graphics_0.DrawLine(new Pen(SystemColors.ControlDark, 1f), rectangle_0.X, rectangle_0.Y + 1, rectangle_0.X, rectangle_0.Y + rectangle_0.Height - 2);
		graphics_0.DrawLine(new Pen(SystemColors.ControlDark, 1f), rectangle_0.X + rectangle_0.Width, rectangle_0.Y + 1, rectangle_0.X + rectangle_0.Width, rectangle_0.Y + rectangle_0.Height - 2);
		if (base.Enabled)
		{
			graphics_0.FillPolygon(new SolidBrush(SystemColors.ControlDarkDark), method_3(rectangle_0.X + 3, rectangle_0.Y + 2));
			graphics_0.FillPolygon(new SolidBrush(SystemColors.ControlDarkDark), method_3(rectangle_0.X + rectangle_0.Width - 9, rectangle_0.Y + 2));
		}
		int num = rectangle_0.X + 14;
		int num2 = rectangle_0.Y + 3;
		switch (splitterVisualStyle_0)
		{
		case SplitterVisualStyle.NonMicrosoft:
		{
			for (int k = 0; k < 30; k++)
			{
				graphics_0.DrawLine(new Pen(SystemColors.ControlLightLight), num + k * 3, num2, num + 1 + k * 3, num2 + 1);
				graphics_0.DrawLine(new Pen(SystemColors.ControlDarkDark), num + 1 + k * 3, num2 + 1, num + 2 + k * 3, num2 + 2);
				graphics_0.DrawLine(bool_1 ? new Pen(color_0) : new Pen(BackColor), num + 1 + k * 3, num2 + 2, num + 2 + k * 3, num2 + 2);
			}
			break;
		}
		case SplitterVisualStyle.XP:
		{
			for (int j = 0; j < 18; j++)
			{
				graphics_0.DrawRectangle(new Pen(SystemColors.ControlLight), num + j * 5, num2, 2, 2);
				graphics_0.DrawRectangle(new Pen(SystemColors.ControlLightLight), num + 1 + j * 5, num2 + 1, 1, 1);
				graphics_0.DrawRectangle(new Pen(SystemColors.ControlDarkDark), num + j * 5, num2, 1, 1);
				graphics_0.DrawLine(new Pen(SystemColors.ControlDark), num + j * 5, num2, num + j * 5 + 1, num2);
				graphics_0.DrawLine(new Pen(SystemColors.ControlDark), num + j * 5, num2, num + j * 5, num2 + 1);
			}
			break;
		}
		case SplitterVisualStyle.Win9X:
			graphics_0.DrawLine(new Pen(SystemColors.ControlLightLight), num, num2, num, num2 + 2);
			graphics_0.DrawLine(new Pen(SystemColors.ControlLightLight), num, num2, num + 88, num2);
			graphics_0.DrawLine(new Pen(SystemColors.ControlDark), num, num2 + 2, num + 88, num2 + 2);
			graphics_0.DrawLine(new Pen(SystemColors.ControlDark), num + 88, num2, num + 88, num2 + 2);
			break;
		case SplitterVisualStyle.DoubleDots:
		{
			int num3;
			for (num3 = 0; num3 < 30; num3++)
			{
				graphics_0.DrawRectangle(new Pen(SystemColors.ControlLightLight), num + 1 + num3 * 3, num2, 1, 1);
				graphics_0.DrawRectangle(new Pen(SystemColors.ControlDark), num + num3 * 3, num2 - 1, 1, 1);
				num3++;
				graphics_0.DrawRectangle(new Pen(SystemColors.ControlLightLight), num + 1 + num3 * 3, num2 + 2, 1, 1);
				graphics_0.DrawRectangle(new Pen(SystemColors.ControlDark), num + num3 * 3, num2 + 1, 1, 1);
			}
			break;
		}
		case SplitterVisualStyle.Lines:
		{
			for (int i = 0; i < 44; i++)
			{
				graphics_0.DrawLine(new Pen(SystemColors.ControlDark), num + i * 2, num2, num + i * 2, num2 + 2);
			}
			break;
		}
		}
		if (border3DStyle_0 != Border3DStyle.Flat)
		{
			ControlPaint.DrawBorder3D(paintEventArgs_0.Graphics, base.ClientRectangle, border3DStyle_0, Border3DSide.Top);
			ControlPaint.DrawBorder3D(paintEventArgs_0.Graphics, base.ClientRectangle, border3DStyle_0, Border3DSide.Bottom);
		}
	}

	private Point[] method_3(int int_0, int int_1)
	{
		Point[] array = new Point[3];
		if (control_0 != null)
		{
			if ((Dock == DockStyle.Right && control_0.Visible) || (Dock == DockStyle.Left && !control_0.Visible))
			{
				array[0] = new Point(int_0, int_1);
				array[1] = new Point(int_0 + 3, int_1 + 3);
				array[2] = new Point(int_0, int_1 + 6);
			}
			else if ((Dock == DockStyle.Right && !control_0.Visible) || (Dock == DockStyle.Left && control_0.Visible))
			{
				array[0] = new Point(int_0 + 3, int_1);
				array[1] = new Point(int_0, int_1 + 3);
				array[2] = new Point(int_0 + 3, int_1 + 6);
			}
			else if ((Dock == DockStyle.Top && control_0.Visible) || (Dock == DockStyle.Bottom && !control_0.Visible))
			{
				array[0] = new Point(int_0 + 3, int_1);
				array[1] = new Point(int_0 + 6, int_1 + 4);
				array[2] = new Point(int_0, int_1 + 4);
			}
			else if ((Dock == DockStyle.Top && !control_0.Visible) || (Dock == DockStyle.Bottom && control_0.Visible))
			{
				array[0] = new Point(int_0, int_1);
				array[1] = new Point(int_0 + 6, int_1);
				array[2] = new Point(int_0 + 3, int_1 + 3);
			}
		}
		return array;
	}
}
