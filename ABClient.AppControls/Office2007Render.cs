using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ABClient.AppControls;

public sealed class Office2007Render : ToolStripProfessionalRenderer
{
	private sealed class Class109
	{
		internal readonly Color color_0;

		internal readonly Color color_1;

		internal readonly Color color_2;

		internal readonly Color color_3;

		internal readonly Color color_4;

		internal readonly Color color_5;

		internal readonly Color color_6;

		internal readonly Color color_7;

		internal readonly Color color_8;

		internal readonly Color color_9;

		internal Class109(Color color_10, Color color_11, Color color_12, Color color_13, Color color_14, Color color_15, Color color_16, Color color_17, Color color_18, Color color_19)
		{
			color_0 = color_10;
			color_1 = color_11;
			color_2 = color_12;
			color_3 = color_13;
			color_4 = color_14;
			color_5 = color_15;
			color_6 = color_16;
			color_7 = color_17;
			color_8 = color_18;
			color_9 = color_19;
		}
	}

	private static readonly Blend blend_0 = new Blend
	{
		Positions = new float[6] { 0f, 0.25f, 0.25f, 0.57f, 0.86f, 1f },
		Factors = new float[6] { 0.1f, 0.6f, 1f, 0.4f, 0f, 0.95f }
	};

	private static readonly Color color_0 = Color.FromArgb(167, 167, 167);

	private static readonly Color color_1 = Color.FromArgb(21, 66, 139);

	private static readonly Color color_2 = Color.FromArgb(250, 250, 250);

	private static readonly Color color_3 = Color.FromArgb(248, 248, 248);

	private static readonly Color color_4 = Color.FromArgb(243, 243, 243);

	private static readonly Color color_5 = Color.FromArgb(255, 255, 251);

	private static readonly Color color_6 = Color.FromArgb(255, 249, 227);

	private static readonly Color color_7 = Color.FromArgb(255, 242, 201);

	private static readonly Color color_8 = Color.FromArgb(255, 248, 181);

	private static readonly Color color_9 = Color.FromArgb(255, 252, 229);

	private static readonly Color color_10 = Color.FromArgb(255, 235, 166);

	private static readonly Color color_11 = Color.FromArgb(255, 213, 103);

	private static readonly Color color_12 = Color.FromArgb(255, 228, 145);

	private static readonly Color color_13 = Color.FromArgb(160, 188, 228);

	private static readonly Color color_14 = Color.FromArgb(121, 153, 194);

	private static readonly Color color_15 = Color.FromArgb(233, 168, 97);

	private static readonly Color color_16 = Color.FromArgb(247, 164, 39);

	private static readonly Color color_17 = Color.FromArgb(246, 156, 24);

	private static readonly Color color_18 = Color.FromArgb(253, 173, 17);

	private static readonly Color color_19 = Color.FromArgb(254, 185, 108);

	private static readonly Color color_20 = Color.FromArgb(253, 164, 97);

	private static readonly Color color_21 = Color.FromArgb(252, 143, 61);

	private static readonly Color color_22 = Color.FromArgb(255, 208, 134);

	private static readonly Color color_23 = Color.FromArgb(249, 192, 103);

	private static readonly Color color_24 = Color.FromArgb(250, 195, 93);

	private static readonly Color color_25 = Color.FromArgb(248, 190, 81);

	private static readonly Color color_26 = Color.FromArgb(255, 208, 49);

	private static readonly Color color_27 = Color.FromArgb(254, 214, 168);

	private static readonly Color color_28 = Color.FromArgb(252, 180, 100);

	private static readonly Color color_29 = Color.FromArgb(252, 161, 54);

	private static readonly Color color_30 = Color.FromArgb(254, 238, 170);

	private static readonly Color color_31 = Color.FromArgb(249, 202, 113);

	private static readonly Color color_32 = Color.FromArgb(250, 205, 103);

	private static readonly Color color_33 = Color.FromArgb(248, 200, 91);

	private static readonly Color color_34 = Color.FromArgb(255, 218, 59);

	private static readonly Color color_35 = Color.FromArgb(254, 185, 108);

	private static readonly Color color_36 = Color.FromArgb(252, 161, 54);

	private static readonly Color color_37 = Color.FromArgb(254, 238, 170);

	private static readonly Color color_38 = color_0;

	private static readonly Color color_39 = color_1;

	private static readonly Color color_40 = color_1;

	private static readonly Color color_41 = color_1;

	private static readonly Color color_42 = color_0;

	private static readonly Color color_43 = Color.FromArgb(106, 126, 197);

	private static readonly Color color_44 = Color.FromArgb(64, 70, 90);

	private static readonly Color color_45 = Color.FromArgb(245, 245, 245);

	private static readonly Color color_46 = Color.FromArgb(197, 197, 197);

	private static readonly Color color_47 = color_2;

	private static readonly Color color_48 = Color.FromArgb(242, 149, 54);

	private static readonly Color color_49 = Color.FromArgb(66, 75, 138);

	private static readonly Color color_50 = Color.FromArgb(86, 125, 176);

	private static readonly Color color_51 = Color.White;

	private static readonly Color color_52 = Color.FromArgb(114, 152, 204);

	private static readonly Color color_53 = color_3;

	private static readonly Class109 class109_0 = new Class109(color_5, color_6, color_7, color_8, color_9, color_10, color_11, color_12, Color.FromArgb(217, 203, 150), Color.FromArgb(192, 167, 118));

	private static readonly Class109 class109_1 = new Class109(color_2, color_4, Color.FromArgb(236, 236, 236), Color.FromArgb(230, 230, 230), color_4, Color.FromArgb(224, 224, 224), Color.FromArgb(200, 200, 200), Color.FromArgb(210, 210, 210), Color.FromArgb(212, 212, 212), Color.FromArgb(195, 195, 195));

	private static readonly Class109 class109_2 = new Class109(color_5, color_6, color_7, color_8, color_9, color_10, color_11, color_12, color_13, color_14);

	private static readonly Class109 class109_3 = new Class109(color_15, color_16, color_17, color_18, color_19, color_20, color_21, color_22, color_13, color_14);

	private static readonly Class109 class109_4 = new Class109(color_23, color_24, color_25, color_26, color_27, color_28, color_29, color_30, color_13, color_14);

	private static readonly Class109 class109_5 = new Class109(color_31, color_32, color_33, color_34, color_35, color_20, color_36, color_37, color_13, color_14);

	internal Office2007Render()
		: base(new Office2007ColorTable())
	{
	}

	protected override void OnRenderArrow(ToolStripArrowRenderEventArgs toolStripArrowRenderEventArgs_0)
	{
		if (toolStripArrowRenderEventArgs_0.ArrowRectangle.Width <= 0 || toolStripArrowRenderEventArgs_0.ArrowRectangle.Height <= 0)
		{
			return;
		}
		using GraphicsPath graphicsPath = smethod_15(toolStripArrowRenderEventArgs_0.Item, toolStripArrowRenderEventArgs_0.ArrowRectangle, toolStripArrowRenderEventArgs_0.Direction);
		RectangleF bounds = graphicsPath.GetBounds();
		bounds.Inflate(1f, 1f);
		Color color = (toolStripArrowRenderEventArgs_0.Item.Enabled ? color_43 : color_42);
		Color color2 = (toolStripArrowRenderEventArgs_0.Item.Enabled ? color_44 : color_42);
		float angle = 0f;
		switch (toolStripArrowRenderEventArgs_0.Direction)
		{
		case ArrowDirection.Up:
			angle = 270f;
			break;
		case ArrowDirection.Left:
			angle = 180f;
			break;
		case ArrowDirection.Down:
			angle = 90f;
			break;
		case ArrowDirection.Right:
			angle = 0f;
			break;
		}
		LinearGradientBrush linearGradientBrush = new LinearGradientBrush(bounds, color, color2, angle);
		try
		{
			toolStripArrowRenderEventArgs_0.Graphics.FillPath(linearGradientBrush, graphicsPath);
		}
		finally
		{
			((IDisposable)linearGradientBrush).Dispose();
		}
	}

	protected override void OnRenderButtonBackground(ToolStripItemRenderEventArgs toolStripItemRenderEventArgs_0)
	{
		ToolStripButton toolStripButton = (ToolStripButton)toolStripItemRenderEventArgs_0.Item;
		if (toolStripButton.Selected || toolStripButton.Pressed || toolStripButton.Checked)
		{
			smethod_2(toolStripItemRenderEventArgs_0.Graphics, toolStripButton, toolStripItemRenderEventArgs_0.ToolStrip);
		}
	}

	protected override void OnRenderDropDownButtonBackground(ToolStripItemRenderEventArgs toolStripItemRenderEventArgs_0)
	{
		if (toolStripItemRenderEventArgs_0.Item.Selected || toolStripItemRenderEventArgs_0.Item.Pressed)
		{
			method_0(toolStripItemRenderEventArgs_0.Graphics, toolStripItemRenderEventArgs_0.Item, toolStripItemRenderEventArgs_0.ToolStrip);
		}
	}

	protected override void OnRenderItemCheck(ToolStripItemImageRenderEventArgs toolStripItemImageRenderEventArgs_0)
	{
		Rectangle imageRectangle = toolStripItemImageRenderEventArgs_0.ImageRectangle;
		imageRectangle.Inflate(1, 1);
		if (imageRectangle.Top > 1)
		{
			int num = imageRectangle.Top - 1;
			imageRectangle.Y -= num;
			imageRectangle.Height += num;
		}
		if (imageRectangle.Height <= toolStripItemImageRenderEventArgs_0.Item.Bounds.Height - 2)
		{
			int num2 = toolStripItemImageRenderEventArgs_0.Item.Bounds.Height - 2 - imageRectangle.Height;
			imageRectangle.Height += num2;
		}
		UseAntiAlias useAntiAlias = new UseAntiAlias(toolStripItemImageRenderEventArgs_0.Graphics);
		try
		{
			using GraphicsPath path = smethod_10(imageRectangle, 1.2f);
			SolidBrush solidBrush = new SolidBrush(base.ColorTable.CheckBackground);
			try
			{
				toolStripItemImageRenderEventArgs_0.Graphics.FillPath(solidBrush, path);
			}
			finally
			{
				((IDisposable)solidBrush).Dispose();
			}
			Pen pen = new Pen(color_48);
			try
			{
				toolStripItemImageRenderEventArgs_0.Graphics.DrawPath(pen, path);
			}
			finally
			{
				((IDisposable)pen).Dispose();
			}
			if (toolStripItemImageRenderEventArgs_0.Image == null)
			{
				return;
			}
			CheckState checkState = CheckState.Unchecked;
			if (toolStripItemImageRenderEventArgs_0.Item is ToolStripMenuItem)
			{
				checkState = ((ToolStripMenuItem)toolStripItemImageRenderEventArgs_0.Item).CheckState;
			}
			switch (checkState)
			{
			case CheckState.Indeterminate:
			{
				using GraphicsPath path3 = smethod_17(imageRectangle);
				SolidBrush solidBrush2 = new SolidBrush(color_49);
				try
				{
					toolStripItemImageRenderEventArgs_0.Graphics.FillPath(solidBrush2, path3);
					break;
				}
				finally
				{
					((IDisposable)solidBrush2).Dispose();
				}
			}
			case CheckState.Checked:
			{
				using GraphicsPath path2 = smethod_16(imageRectangle);
				Pen pen2 = new Pen(color_49, 1.6f);
				try
				{
					toolStripItemImageRenderEventArgs_0.Graphics.DrawPath(pen2, path2);
					break;
				}
				finally
				{
					((IDisposable)pen2).Dispose();
				}
			}
			}
		}
		finally
		{
			((IDisposable)useAntiAlias).Dispose();
		}
	}

	protected override void OnRenderItemText(ToolStripItemTextRenderEventArgs toolStripItemTextRenderEventArgs_0)
	{
		if (!toolStripItemTextRenderEventArgs_0.Item.Enabled)
		{
			toolStripItemTextRenderEventArgs_0.TextColor = color_38;
		}
		else if (toolStripItemTextRenderEventArgs_0.ToolStrip is MenuStrip && !toolStripItemTextRenderEventArgs_0.Item.Pressed && !toolStripItemTextRenderEventArgs_0.Item.Selected)
		{
			toolStripItemTextRenderEventArgs_0.TextColor = color_39;
		}
		else if (toolStripItemTextRenderEventArgs_0.ToolStrip is StatusStrip && !toolStripItemTextRenderEventArgs_0.Item.Pressed && !toolStripItemTextRenderEventArgs_0.Item.Selected)
		{
			toolStripItemTextRenderEventArgs_0.TextColor = color_40;
		}
		else
		{
			toolStripItemTextRenderEventArgs_0.TextColor = color_41;
		}
		UseClearTypeGridFit useClearTypeGridFit = new UseClearTypeGridFit(toolStripItemTextRenderEventArgs_0.Graphics);
		try
		{
			base.OnRenderItemText(toolStripItemTextRenderEventArgs_0);
		}
		finally
		{
			((IDisposable)useClearTypeGridFit).Dispose();
		}
	}

	protected override void OnRenderItemImage(ToolStripItemImageRenderEventArgs toolStripItemImageRenderEventArgs_0)
	{
		if (!(toolStripItemImageRenderEventArgs_0.ToolStrip is ContextMenuStrip) && !(toolStripItemImageRenderEventArgs_0.ToolStrip is ToolStripDropDownMenu))
		{
			base.OnRenderItemImage(toolStripItemImageRenderEventArgs_0);
		}
		else if (toolStripItemImageRenderEventArgs_0.Image != null)
		{
			if (toolStripItemImageRenderEventArgs_0.Item.Enabled)
			{
				toolStripItemImageRenderEventArgs_0.Graphics.DrawImage(toolStripItemImageRenderEventArgs_0.Image, toolStripItemImageRenderEventArgs_0.ImageRectangle);
			}
			else
			{
				ControlPaint.DrawImageDisabled(toolStripItemImageRenderEventArgs_0.Graphics, toolStripItemImageRenderEventArgs_0.Image, toolStripItemImageRenderEventArgs_0.ImageRectangle.X, toolStripItemImageRenderEventArgs_0.ImageRectangle.Y, Color.Transparent);
			}
		}
	}

	protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs toolStripItemRenderEventArgs_0)
	{
		if (!(toolStripItemRenderEventArgs_0.ToolStrip is MenuStrip) && !(toolStripItemRenderEventArgs_0.ToolStrip is ContextMenuStrip) && !(toolStripItemRenderEventArgs_0.ToolStrip is ToolStripDropDownMenu))
		{
			base.OnRenderMenuItemBackground(toolStripItemRenderEventArgs_0);
		}
		else if (toolStripItemRenderEventArgs_0.Item.Pressed && toolStripItemRenderEventArgs_0.ToolStrip is MenuStrip)
		{
			method_2(toolStripItemRenderEventArgs_0.Graphics, toolStripItemRenderEventArgs_0.Item);
		}
		else
		{
			if (!toolStripItemRenderEventArgs_0.Item.Selected)
			{
				return;
			}
			if (toolStripItemRenderEventArgs_0.Item.Enabled)
			{
				if (toolStripItemRenderEventArgs_0.ToolStrip is MenuStrip)
				{
					smethod_0(toolStripItemRenderEventArgs_0.Graphics, toolStripItemRenderEventArgs_0.Item, class109_2);
				}
				else
				{
					smethod_3(toolStripItemRenderEventArgs_0.Graphics, toolStripItemRenderEventArgs_0.Item, class109_0);
				}
				return;
			}
			Point pt = toolStripItemRenderEventArgs_0.ToolStrip.PointToClient(Control.MousePosition);
			if (!toolStripItemRenderEventArgs_0.Item.Bounds.Contains(pt))
			{
				if (toolStripItemRenderEventArgs_0.ToolStrip is MenuStrip)
				{
					smethod_0(toolStripItemRenderEventArgs_0.Graphics, toolStripItemRenderEventArgs_0.Item, class109_1);
				}
				else
				{
					smethod_3(toolStripItemRenderEventArgs_0.Graphics, toolStripItemRenderEventArgs_0.Item, class109_1);
				}
			}
		}
	}

	protected override void OnRenderSplitButtonBackground(ToolStripItemRenderEventArgs toolStripItemRenderEventArgs_0)
	{
		if (!toolStripItemRenderEventArgs_0.Item.Selected && !toolStripItemRenderEventArgs_0.Item.Pressed)
		{
			base.OnRenderSplitButtonBackground(toolStripItemRenderEventArgs_0);
			return;
		}
		ToolStripSplitButton toolStripSplitButton = (ToolStripSplitButton)toolStripItemRenderEventArgs_0.Item;
		method_1(toolStripItemRenderEventArgs_0.Graphics, toolStripSplitButton, toolStripItemRenderEventArgs_0.ToolStrip);
		Rectangle dropDownButtonBounds = toolStripSplitButton.DropDownButtonBounds;
		OnRenderArrow(new ToolStripArrowRenderEventArgs(toolStripItemRenderEventArgs_0.Graphics, toolStripSplitButton, dropDownButtonBounds, SystemColors.ControlText, ArrowDirection.Down));
	}

	protected override void OnRenderStatusStripSizingGrip(ToolStripRenderEventArgs toolStripRenderEventArgs_0)
	{
		SolidBrush solidBrush = new SolidBrush(color_52);
		try
		{
			SolidBrush solidBrush2 = new SolidBrush(color_53);
			try
			{
				bool flag = toolStripRenderEventArgs_0.ToolStrip.RightToLeft == RightToLeft.Yes;
				int num = toolStripRenderEventArgs_0.AffectedBounds.Bottom - 6 + 1;
				for (int num2 = 3; num2 >= 1; num2--)
				{
					int num3 = (flag ? (toolStripRenderEventArgs_0.AffectedBounds.Left + 1) : (toolStripRenderEventArgs_0.AffectedBounds.Right - 6 + 1));
					for (int i = 0; i < num2; i++)
					{
						smethod_7(toolStripRenderEventArgs_0.Graphics, num3, num, solidBrush, solidBrush2);
						num3 -= (flag ? (-4) : 4);
					}
					num -= 4;
				}
			}
			finally
			{
				((IDisposable)solidBrush2).Dispose();
			}
		}
		finally
		{
			((IDisposable)solidBrush).Dispose();
		}
	}

	protected override void OnRenderToolStripContentPanelBackground(ToolStripContentPanelRenderEventArgs toolStripContentPanelRenderEventArgs_0)
	{
		base.OnRenderToolStripContentPanelBackground(toolStripContentPanelRenderEventArgs_0);
		if (toolStripContentPanelRenderEventArgs_0.ToolStripContentPanel.Width > 0 && toolStripContentPanelRenderEventArgs_0.ToolStripContentPanel.Height > 0)
		{
			LinearGradientBrush linearGradientBrush = new LinearGradientBrush(toolStripContentPanelRenderEventArgs_0.ToolStripContentPanel.ClientRectangle, base.ColorTable.ToolStripContentPanelGradientEnd, base.ColorTable.ToolStripContentPanelGradientBegin, 90f);
			try
			{
				toolStripContentPanelRenderEventArgs_0.Graphics.FillRectangle(linearGradientBrush, toolStripContentPanelRenderEventArgs_0.ToolStripContentPanel.ClientRectangle);
			}
			finally
			{
				((IDisposable)linearGradientBrush).Dispose();
			}
		}
	}

	protected override void OnRenderSeparator(ToolStripSeparatorRenderEventArgs toolStripSeparatorRenderEventArgs_0)
	{
		if (!(toolStripSeparatorRenderEventArgs_0.ToolStrip is ContextMenuStrip) && !(toolStripSeparatorRenderEventArgs_0.ToolStrip is ToolStripDropDownMenu))
		{
			if (toolStripSeparatorRenderEventArgs_0.ToolStrip is StatusStrip)
			{
				Pen pen = new Pen(base.ColorTable.SeparatorLight);
				try
				{
					Pen pen2 = new Pen(base.ColorTable.SeparatorDark);
					try
					{
						smethod_8(toolStripSeparatorRenderEventArgs_0.Graphics, toolStripSeparatorRenderEventArgs_0.Vertical, toolStripSeparatorRenderEventArgs_0.Item.Bounds, pen, pen2, 0, bool_1: false);
						return;
					}
					finally
					{
						((IDisposable)pen2).Dispose();
					}
				}
				finally
				{
					((IDisposable)pen).Dispose();
				}
			}
			base.OnRenderSeparator(toolStripSeparatorRenderEventArgs_0);
			return;
		}
		Pen pen3 = new Pen(color_45);
		try
		{
			Pen pen4 = new Pen(color_46);
			try
			{
				smethod_8(toolStripSeparatorRenderEventArgs_0.Graphics, toolStripSeparatorRenderEventArgs_0.Vertical, toolStripSeparatorRenderEventArgs_0.Item.Bounds, pen3, pen4, 31, toolStripSeparatorRenderEventArgs_0.ToolStrip.RightToLeft == RightToLeft.Yes);
			}
			finally
			{
				((IDisposable)pen4).Dispose();
			}
		}
		finally
		{
			((IDisposable)pen3).Dispose();
		}
	}

	protected override void OnRenderToolStripBackground(ToolStripRenderEventArgs toolStripRenderEventArgs_0)
	{
		if (!(toolStripRenderEventArgs_0.ToolStrip is ContextMenuStrip) && !(toolStripRenderEventArgs_0.ToolStrip is ToolStripDropDownMenu))
		{
			if (toolStripRenderEventArgs_0.ToolStrip is StatusStrip)
			{
				RectangleF rect = new RectangleF(0f, 1.5f, toolStripRenderEventArgs_0.ToolStrip.Width, toolStripRenderEventArgs_0.ToolStrip.Height - 2);
				if (rect.Width > 0f && rect.Height > 0f)
				{
					LinearGradientBrush linearGradientBrush = new LinearGradientBrush(rect, base.ColorTable.StatusStripGradientBegin, base.ColorTable.StatusStripGradientEnd, 90f);
					try
					{
						linearGradientBrush.Blend = blend_0;
						toolStripRenderEventArgs_0.Graphics.FillRectangle(linearGradientBrush, rect);
						return;
					}
					finally
					{
						((IDisposable)linearGradientBrush).Dispose();
					}
				}
			}
			else
			{
				base.OnRenderToolStripBackground(toolStripRenderEventArgs_0);
			}
			return;
		}
		using GraphicsPath path = smethod_10(toolStripRenderEventArgs_0.AffectedBounds, 0f);
		using GraphicsPath graphicsPath_ = smethod_13(toolStripRenderEventArgs_0.AffectedBounds, 0f);
		Class70 @class = new Class70(toolStripRenderEventArgs_0.Graphics, graphicsPath_);
		try
		{
			SolidBrush solidBrush = new SolidBrush(color_47);
			try
			{
				toolStripRenderEventArgs_0.Graphics.FillPath(solidBrush, path);
			}
			finally
			{
				((IDisposable)solidBrush).Dispose();
			}
		}
		finally
		{
			((IDisposable)@class).Dispose();
		}
	}

	protected override void OnRenderImageMargin(ToolStripRenderEventArgs toolStripRenderEventArgs_0)
	{
		if (!(toolStripRenderEventArgs_0.ToolStrip is ContextMenuStrip) && !(toolStripRenderEventArgs_0.ToolStrip is ToolStripDropDownMenu))
		{
			base.OnRenderImageMargin(toolStripRenderEventArgs_0);
			return;
		}
		Rectangle affectedBounds = toolStripRenderEventArgs_0.AffectedBounds;
		bool flag = toolStripRenderEventArgs_0.ToolStrip.RightToLeft == RightToLeft.Yes;
		affectedBounds.Y += 2;
		affectedBounds.Height -= 4;
		if (!flag)
		{
			affectedBounds.X += 2;
		}
		else
		{
			affectedBounds.X++;
		}
		SolidBrush solidBrush = new SolidBrush(base.ColorTable.ImageMarginGradientBegin);
		try
		{
			toolStripRenderEventArgs_0.Graphics.FillRectangle(solidBrush, affectedBounds);
		}
		finally
		{
			((IDisposable)solidBrush).Dispose();
		}
		Pen pen = new Pen(color_45);
		try
		{
			Pen pen2 = new Pen(color_46);
			try
			{
				if (!flag)
				{
					toolStripRenderEventArgs_0.Graphics.DrawLine(pen, affectedBounds.Right, affectedBounds.Top, affectedBounds.Right, affectedBounds.Bottom);
					toolStripRenderEventArgs_0.Graphics.DrawLine(pen2, affectedBounds.Right - 1, affectedBounds.Top, affectedBounds.Right - 1, affectedBounds.Bottom);
				}
				else
				{
					toolStripRenderEventArgs_0.Graphics.DrawLine(pen, affectedBounds.Left - 1, affectedBounds.Top, affectedBounds.Left - 1, affectedBounds.Bottom);
					toolStripRenderEventArgs_0.Graphics.DrawLine(pen2, affectedBounds.Left, affectedBounds.Top, affectedBounds.Left, affectedBounds.Bottom);
				}
			}
			finally
			{
				((IDisposable)pen2).Dispose();
			}
		}
		finally
		{
			((IDisposable)pen).Dispose();
		}
	}

	protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs toolStripRenderEventArgs_0)
	{
		if (!(toolStripRenderEventArgs_0.ToolStrip is ContextMenuStrip) && !(toolStripRenderEventArgs_0.ToolStrip is ToolStripDropDownMenu))
		{
			if (toolStripRenderEventArgs_0.ToolStrip is StatusStrip)
			{
				Pen pen = new Pen(color_50);
				try
				{
					Pen pen2 = new Pen(color_51);
					try
					{
						toolStripRenderEventArgs_0.Graphics.DrawLine(pen, 0, 0, toolStripRenderEventArgs_0.ToolStrip.Width, 0);
						toolStripRenderEventArgs_0.Graphics.DrawLine(pen2, 0, 1, toolStripRenderEventArgs_0.ToolStrip.Width, 1);
						return;
					}
					finally
					{
						((IDisposable)pen2).Dispose();
					}
				}
				finally
				{
					((IDisposable)pen).Dispose();
				}
			}
			base.OnRenderToolStripBorder(toolStripRenderEventArgs_0);
			return;
		}
		if (!toolStripRenderEventArgs_0.ConnectedArea.IsEmpty)
		{
			SolidBrush solidBrush = new SolidBrush(color_47);
			try
			{
				toolStripRenderEventArgs_0.Graphics.FillRectangle(solidBrush, toolStripRenderEventArgs_0.ConnectedArea);
			}
			finally
			{
				((IDisposable)solidBrush).Dispose();
			}
		}
		using GraphicsPath path = smethod_9(toolStripRenderEventArgs_0.AffectedBounds, toolStripRenderEventArgs_0.ConnectedArea, 0f);
		using GraphicsPath path2 = smethod_12(toolStripRenderEventArgs_0.AffectedBounds, toolStripRenderEventArgs_0.ConnectedArea, 0f);
		using GraphicsPath graphicsPath_ = smethod_14(toolStripRenderEventArgs_0.AffectedBounds, toolStripRenderEventArgs_0.ConnectedArea, 0f);
		Pen pen3 = new Pen(base.ColorTable.MenuBorder);
		try
		{
			Pen pen4 = new Pen(color_45);
			try
			{
				Class70 @class = new Class70(toolStripRenderEventArgs_0.Graphics, graphicsPath_);
				try
				{
					UseAntiAlias useAntiAlias = new UseAntiAlias(toolStripRenderEventArgs_0.Graphics);
					try
					{
						toolStripRenderEventArgs_0.Graphics.DrawPath(pen4, path2);
						toolStripRenderEventArgs_0.Graphics.DrawPath(pen3, path);
					}
					finally
					{
						((IDisposable)useAntiAlias).Dispose();
					}
					toolStripRenderEventArgs_0.Graphics.DrawLine(pen3, toolStripRenderEventArgs_0.AffectedBounds.Right, toolStripRenderEventArgs_0.AffectedBounds.Bottom, toolStripRenderEventArgs_0.AffectedBounds.Right - 1, toolStripRenderEventArgs_0.AffectedBounds.Bottom - 1);
				}
				finally
				{
					((IDisposable)@class).Dispose();
				}
			}
			finally
			{
				((IDisposable)pen4).Dispose();
			}
		}
		finally
		{
			((IDisposable)pen3).Dispose();
		}
	}

	private static void smethod_0(Graphics graphics_0, ToolStripItem toolStripItem_0, Class109 class109_6)
	{
		smethod_4(graphics_0, new Rectangle(Point.Empty, toolStripItem_0.Bounds.Size), class109_6);
	}

	private static void smethod_1(Graphics graphics_0, ToolStripSplitButton toolStripSplitButton_0, Class109 class109_6, Class109 class109_7, Class109 class109_8)
	{
		Rectangle rectangle = new Rectangle(Point.Empty, toolStripSplitButton_0.Bounds.Size);
		Rectangle dropDownButtonBounds = toolStripSplitButton_0.DropDownButtonBounds;
		if (rectangle.Width <= 0 || dropDownButtonBounds.Width <= 0 || rectangle.Height <= 0 || dropDownButtonBounds.Height <= 0)
		{
			return;
		}
		Rectangle rectangle_ = rectangle;
		int num;
		if (dropDownButtonBounds.X > 0)
		{
			rectangle_.Width = dropDownButtonBounds.Left;
			dropDownButtonBounds.X--;
			dropDownButtonBounds.Width++;
			num = dropDownButtonBounds.X;
		}
		else
		{
			rectangle_.Width -= dropDownButtonBounds.Width - 2;
			rectangle_.X = dropDownButtonBounds.Right - 1;
			dropDownButtonBounds.Width++;
			num = dropDownButtonBounds.Right - 1;
		}
		using (smethod_10(rectangle, 1.2f))
		{
			smethod_5(graphics_0, rectangle_, class109_6);
			smethod_5(graphics_0, dropDownButtonBounds, class109_7);
			LinearGradientBrush linearGradientBrush = new LinearGradientBrush(new Rectangle(rectangle.X + num, rectangle.Top, 1, rectangle.Height + 1), class109_8.color_8, class109_8.color_9, 90f);
			try
			{
				linearGradientBrush.SetSigmaBellShape(0.5f);
				Pen pen = new Pen(linearGradientBrush);
				try
				{
					graphics_0.DrawLine(pen, rectangle.X + num, rectangle.Top + 1, rectangle.X + num, rectangle.Bottom - 1);
				}
				finally
				{
					((IDisposable)pen).Dispose();
				}
			}
			finally
			{
				((IDisposable)linearGradientBrush).Dispose();
			}
			smethod_6(graphics_0, rectangle, class109_6);
		}
	}

	private static void smethod_2(Graphics graphics_0, ToolStripButton toolStripButton_0, Control control_0)
	{
		if (toolStripButton_0.Enabled)
		{
			if (toolStripButton_0.Checked)
			{
				if (toolStripButton_0.Pressed)
				{
					smethod_0(graphics_0, toolStripButton_0, class109_3);
				}
				else if (toolStripButton_0.Selected)
				{
					smethod_0(graphics_0, toolStripButton_0, class109_5);
				}
				else
				{
					smethod_0(graphics_0, toolStripButton_0, class109_4);
				}
			}
			else if (toolStripButton_0.Pressed)
			{
				smethod_0(graphics_0, toolStripButton_0, class109_3);
			}
			else if (toolStripButton_0.Selected)
			{
				smethod_0(graphics_0, toolStripButton_0, class109_2);
			}
		}
		else if (toolStripButton_0.Selected)
		{
			Point pt = control_0.PointToClient(Control.MousePosition);
			if (!toolStripButton_0.Bounds.Contains(pt))
			{
				smethod_0(graphics_0, toolStripButton_0, class109_1);
			}
		}
	}

	private static void smethod_3(Graphics graphics_0, ToolStripItem toolStripItem_0, Class109 class109_6)
	{
		Rectangle rectangle_ = new Rectangle(2, 0, toolStripItem_0.Bounds.Width - 3, toolStripItem_0.Bounds.Height);
		smethod_4(graphics_0, rectangle_, class109_6);
	}

	private static void smethod_4(Graphics graphics_0, Rectangle rectangle_0, Class109 class109_6)
	{
		if (rectangle_0.Width > 0 && rectangle_0.Height > 0)
		{
			smethod_5(graphics_0, rectangle_0, class109_6);
			smethod_6(graphics_0, rectangle_0, class109_6);
		}
	}

	private static void smethod_5(Graphics graphics_0, Rectangle rectangle_0, Class109 class109_6)
	{
		rectangle_0.Inflate(-1, -1);
		int num = rectangle_0.Height / 2;
		Rectangle rectangle = new Rectangle(rectangle_0.X, rectangle_0.Y, rectangle_0.Width, num);
		Rectangle rectangle2 = new Rectangle(rectangle_0.X, rectangle_0.Y + num, rectangle_0.Width, rectangle_0.Height - num);
		Rectangle rect = rectangle;
		Rectangle rect2 = rectangle2;
		rect.Inflate(1, 1);
		rect2.Inflate(1, 1);
		LinearGradientBrush linearGradientBrush = new LinearGradientBrush(rect, class109_6.color_0, class109_6.color_1, 90f);
		try
		{
			LinearGradientBrush linearGradientBrush2 = new LinearGradientBrush(rect2, class109_6.color_2, class109_6.color_3, 90f);
			try
			{
				graphics_0.FillRectangle(linearGradientBrush, rectangle);
				graphics_0.FillRectangle(linearGradientBrush2, rectangle2);
			}
			finally
			{
				((IDisposable)linearGradientBrush2).Dispose();
			}
		}
		finally
		{
			((IDisposable)linearGradientBrush).Dispose();
		}
		num = rectangle_0.Height / 2;
		rectangle = new Rectangle(rectangle_0.X, rectangle_0.Y, rectangle_0.Width, num);
		rectangle2 = new Rectangle(rectangle_0.X, rectangle_0.Y + num, rectangle_0.Width, rectangle_0.Height - num);
		rect = rectangle;
		rect2 = rectangle2;
		rect.Inflate(1, 1);
		rect2.Inflate(1, 1);
		LinearGradientBrush linearGradientBrush3 = new LinearGradientBrush(rect, class109_6.color_4, class109_6.color_5, 90f);
		try
		{
			LinearGradientBrush linearGradientBrush4 = new LinearGradientBrush(rect2, class109_6.color_6, class109_6.color_7, 90f);
			try
			{
				rectangle_0.Inflate(-1, -1);
				num = rectangle_0.Height / 2;
				rectangle = new Rectangle(rectangle_0.X, rectangle_0.Y, rectangle_0.Width, num);
				rectangle2 = new Rectangle(rectangle_0.X, rectangle_0.Y + num, rectangle_0.Width, rectangle_0.Height - num);
				graphics_0.FillRectangle(linearGradientBrush3, rectangle);
				graphics_0.FillRectangle(linearGradientBrush4, rectangle2);
			}
			finally
			{
				((IDisposable)linearGradientBrush4).Dispose();
			}
		}
		finally
		{
			((IDisposable)linearGradientBrush3).Dispose();
		}
	}

	private static void smethod_6(Graphics graphics_0, Rectangle rectangle_0, Class109 class109_6)
	{
		UseAntiAlias useAntiAlias = new UseAntiAlias(graphics_0);
		try
		{
			Rectangle rect = rectangle_0;
			rect.Inflate(1, 1);
			LinearGradientBrush linearGradientBrush = new LinearGradientBrush(rect, class109_6.color_8, class109_6.color_9, 90f);
			try
			{
				linearGradientBrush.SetSigmaBellShape(0.5f);
				Pen pen = new Pen(linearGradientBrush);
				try
				{
					using GraphicsPath path = smethod_10(rectangle_0, 1.2f);
					graphics_0.DrawPath(pen, path);
				}
				finally
				{
					((IDisposable)pen).Dispose();
				}
			}
			finally
			{
				((IDisposable)linearGradientBrush).Dispose();
			}
		}
		finally
		{
			((IDisposable)useAntiAlias).Dispose();
		}
	}

	private static void smethod_7(Graphics graphics_0, int int_0, int int_1, Brush brush_0, Brush brush_1)
	{
		graphics_0.FillRectangle(brush_1, int_0 + 1, int_1 + 1, 2, 2);
		graphics_0.FillRectangle(brush_0, int_0, int_1, 2, 2);
	}

	private static void smethod_8(Graphics graphics_0, bool bool_0, Rectangle rectangle_0, Pen pen_0, Pen pen_1, int int_0, bool bool_1)
	{
		if (bool_0)
		{
			int num = rectangle_0.Width / 2;
			int y = rectangle_0.Y;
			int bottom = rectangle_0.Bottom;
			graphics_0.DrawLine(pen_1, num, y, num, bottom);
			graphics_0.DrawLine(pen_0, num + 1, y, num + 1, bottom);
		}
		else
		{
			int num2 = rectangle_0.Height / 2;
			int x = rectangle_0.X + ((!bool_1) ? int_0 : 0);
			int x2 = rectangle_0.Right - (bool_1 ? int_0 : 0);
			graphics_0.DrawLine(pen_1, x, num2, x2, num2);
			graphics_0.DrawLine(pen_0, x, num2 + 1, x2, num2 + 1);
		}
	}

	private static GraphicsPath smethod_9(Rectangle rectangle_0, Rectangle rectangle_1, float float_0)
	{
		if (rectangle_1.IsEmpty)
		{
			return smethod_10(rectangle_0, float_0);
		}
		rectangle_0.Width--;
		rectangle_0.Height--;
		List<PointF> list = new List<PointF>();
		float x = rectangle_0.X;
		float num = rectangle_0.Y;
		float x2 = rectangle_0.Right;
		float y = rectangle_0.Bottom;
		float num2 = (float)rectangle_0.X + float_0;
		float num3 = (float)rectangle_0.Right - float_0;
		float y2 = (float)rectangle_0.Y + float_0;
		float y3 = (float)rectangle_0.Bottom - float_0;
		float num4 = ((float_0 == 0f) ? 1f : float_0);
		if (rectangle_0.Y >= rectangle_1.Top && rectangle_0.Y <= rectangle_1.Bottom)
		{
			float num5 = (float)(rectangle_1.X - 1) - float_0;
			float num6 = (float)rectangle_1.Right + float_0;
			if (num2 <= num5)
			{
				list.Add(new PointF(num2, num));
				list.Add(new PointF(num5, num));
				list.Add(new PointF(num5 + float_0, num - num4));
			}
			else
			{
				num5 = rectangle_1.X - 1;
				list.Add(new PointF(num5, num));
				list.Add(new PointF(num5, num - num4));
			}
			if (num3 > num6)
			{
				list.Add(new PointF(num6 - float_0, num - num4));
				list.Add(new PointF(num6, num));
				list.Add(new PointF(num3, num));
			}
			else
			{
				num6 = rectangle_1.Right;
				list.Add(new PointF(num6, num - num4));
				list.Add(new PointF(num6, num));
			}
		}
		else
		{
			list.Add(new PointF(num2, num));
			list.Add(new PointF(num3, num));
		}
		list.Add(new PointF(x2, y2));
		list.Add(new PointF(x2, y3));
		list.Add(new PointF(num3, y));
		list.Add(new PointF(num2, y));
		list.Add(new PointF(x, y3));
		list.Add(new PointF(x, y2));
		GraphicsPath graphicsPath = new GraphicsPath();
		for (int i = 1; i < list.Count; i++)
		{
			graphicsPath.AddLine(list[i - 1], list[i]);
		}
		graphicsPath.AddLine(list[list.Count - 1], list[0]);
		return graphicsPath;
	}

	private static GraphicsPath smethod_10(Rectangle rectangle_0, float float_0)
	{
		rectangle_0.Width--;
		rectangle_0.Height--;
		GraphicsPath graphicsPath = new GraphicsPath();
		graphicsPath.AddLine((float)rectangle_0.Left + float_0, rectangle_0.Top, (float)rectangle_0.Right - float_0, rectangle_0.Top);
		graphicsPath.AddLine((float)rectangle_0.Right - float_0, rectangle_0.Top, rectangle_0.Right, (float)rectangle_0.Top + float_0);
		graphicsPath.AddLine(rectangle_0.Right, (float)rectangle_0.Top + float_0, rectangle_0.Right, (float)rectangle_0.Bottom - float_0);
		graphicsPath.AddLine(rectangle_0.Right, (float)rectangle_0.Bottom - float_0, (float)rectangle_0.Right - float_0, rectangle_0.Bottom);
		graphicsPath.AddLine((float)rectangle_0.Right - float_0, rectangle_0.Bottom, (float)rectangle_0.Left + float_0, rectangle_0.Bottom);
		graphicsPath.AddLine((float)rectangle_0.Left + float_0, rectangle_0.Bottom, rectangle_0.Left, (float)rectangle_0.Bottom - float_0);
		graphicsPath.AddLine(rectangle_0.Left, (float)rectangle_0.Bottom - float_0, rectangle_0.Left, (float)rectangle_0.Top + float_0);
		graphicsPath.AddLine(rectangle_0.Left, (float)rectangle_0.Top + float_0, (float)rectangle_0.Left + float_0, rectangle_0.Top);
		return graphicsPath;
	}

	private static GraphicsPath smethod_11(Rectangle rectangle_0, float float_0)
	{
		rectangle_0.Inflate(-1, -1);
		return smethod_10(rectangle_0, float_0);
	}

	private static GraphicsPath smethod_12(Rectangle rectangle_0, Rectangle rectangle_1, float float_0)
	{
		rectangle_0.Inflate(-1, -1);
		return smethod_9(rectangle_0, rectangle_1, float_0);
	}

	private static GraphicsPath smethod_13(Rectangle rectangle_0, float float_0)
	{
		rectangle_0.Width++;
		rectangle_0.Height++;
		return smethod_10(rectangle_0, float_0);
	}

	private static GraphicsPath smethod_14(Rectangle rectangle_0, Rectangle rectangle_1, float float_0)
	{
		rectangle_0.Width++;
		rectangle_0.Height++;
		return smethod_9(rectangle_0, rectangle_1, float_0);
	}

	private static GraphicsPath smethod_15(ToolStripItem toolStripItem_0, Rectangle rectangle_0, ArrowDirection arrowDirection_0)
	{
		int num;
		int num2;
		if (arrowDirection_0 != ArrowDirection.Left && arrowDirection_0 != ArrowDirection.Right)
		{
			num = rectangle_0.X + rectangle_0.Width / 2;
			num2 = rectangle_0.Bottom - (rectangle_0.Height - 3) / 2;
			if (toolStripItem_0 is ToolStripDropDownButton && toolStripItem_0.RightToLeft == RightToLeft.Yes)
			{
				num++;
			}
		}
		else
		{
			num = rectangle_0.Right - (rectangle_0.Width - 4) / 2;
			num2 = rectangle_0.Y + rectangle_0.Height / 2;
		}
		GraphicsPath graphicsPath = new GraphicsPath();
		switch (arrowDirection_0)
		{
		case ArrowDirection.Up:
			graphicsPath.AddLine((float)num + 3f, num2, (float)num - 3f, num2);
			graphicsPath.AddLine((float)num - 3f, num2, num, (float)num2 - 4f);
			graphicsPath.AddLine(num, (float)num2 - 4f, (float)num + 3f, num2);
			break;
		case ArrowDirection.Left:
			graphicsPath.AddLine(num - 4, num2, num, num2 - 4);
			graphicsPath.AddLine(num, num2 - 4, num, num2 + 4);
			graphicsPath.AddLine(num, num2 + 4, num - 4, num2);
			break;
		case ArrowDirection.Down:
			graphicsPath.AddLine((float)num + 3f, (float)num2 - 3f, (float)num - 2f, (float)num2 - 3f);
			graphicsPath.AddLine((float)num - 2f, (float)num2 - 3f, num, num2);
			graphicsPath.AddLine(num, num2, (float)num + 3f, (float)num2 - 3f);
			break;
		case ArrowDirection.Right:
			graphicsPath.AddLine(num, num2, num - 4, num2 - 4);
			graphicsPath.AddLine(num - 4, num2 - 4, num - 4, num2 + 4);
			graphicsPath.AddLine(num - 4, num2 + 4, num, num2);
			break;
		}
		return graphicsPath;
	}

	private static GraphicsPath smethod_16(Rectangle rectangle_0)
	{
		int num = rectangle_0.X + rectangle_0.Width / 2;
		int num2 = rectangle_0.Y + rectangle_0.Height / 2;
		GraphicsPath graphicsPath = new GraphicsPath();
		graphicsPath.AddLine(num - 4, num2, num - 2, num2 + 4);
		graphicsPath.AddLine(num - 2, num2 + 4, num + 3, num2 - 5);
		return graphicsPath;
	}

	private static GraphicsPath smethod_17(Rectangle rectangle_0)
	{
		int num = rectangle_0.X + rectangle_0.Width / 2;
		int num2 = rectangle_0.Y + rectangle_0.Height / 2;
		GraphicsPath graphicsPath = new GraphicsPath();
		graphicsPath.AddLine(num - 3, num2, num, num2 - 3);
		graphicsPath.AddLine(num, num2 - 3, num + 3, num2);
		graphicsPath.AddLine(num + 3, num2, num, num2 + 3);
		graphicsPath.AddLine(num, num2 + 3, num - 3, num2);
		return graphicsPath;
	}

	private void method_0(Graphics graphics_0, ToolStripItem toolStripItem_0, Control control_0)
	{
		if (!toolStripItem_0.Selected && !toolStripItem_0.Pressed)
		{
			return;
		}
		if (toolStripItem_0.Enabled)
		{
			if (toolStripItem_0.Pressed)
			{
				method_2(graphics_0, toolStripItem_0);
			}
			else
			{
				smethod_0(graphics_0, toolStripItem_0, class109_2);
			}
			return;
		}
		Point pt = control_0.PointToClient(Control.MousePosition);
		if (!toolStripItem_0.Bounds.Contains(pt))
		{
			smethod_0(graphics_0, toolStripItem_0, class109_1);
		}
	}

	private void method_1(Graphics graphics_0, ToolStripSplitButton toolStripSplitButton_0, Control control_0)
	{
		if (!toolStripSplitButton_0.Selected && !toolStripSplitButton_0.Pressed)
		{
			return;
		}
		if (toolStripSplitButton_0.Enabled)
		{
			if (!toolStripSplitButton_0.Pressed && toolStripSplitButton_0.ButtonPressed)
			{
				smethod_1(graphics_0, toolStripSplitButton_0, class109_3, class109_2, class109_0);
			}
			else if (toolStripSplitButton_0.Pressed && !toolStripSplitButton_0.ButtonPressed)
			{
				method_2(graphics_0, toolStripSplitButton_0);
			}
			else
			{
				smethod_1(graphics_0, toolStripSplitButton_0, class109_2, class109_2, class109_0);
			}
		}
		else
		{
			Point pt = control_0.PointToClient(Control.MousePosition);
			if (!toolStripSplitButton_0.Bounds.Contains(pt))
			{
				smethod_0(graphics_0, toolStripSplitButton_0, class109_1);
			}
		}
	}

	private void method_2(Graphics graphics_0, ToolStripItem toolStripItem_0)
	{
		Rectangle rectangle_ = new Rectangle(Point.Empty, toolStripItem_0.Bounds.Size);
		using GraphicsPath path = smethod_10(rectangle_, 1f);
		using (smethod_11(rectangle_, 1f))
		{
			using GraphicsPath graphicsPath_ = smethod_13(rectangle_, 1f);
			Class70 @class = new Class70(graphics_0, graphicsPath_);
			try
			{
				SolidBrush solidBrush = new SolidBrush(color_45);
				try
				{
					graphics_0.FillPath(solidBrush, path);
				}
				finally
				{
					((IDisposable)solidBrush).Dispose();
				}
				Pen pen = new Pen(base.ColorTable.MenuBorder);
				try
				{
					graphics_0.DrawPath(pen, path);
				}
				finally
				{
					((IDisposable)pen).Dispose();
				}
			}
			finally
			{
				((IDisposable)@class).Dispose();
			}
		}
	}
}
