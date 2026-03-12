using System;
using System.Drawing;
using System.Drawing.Drawing2D;

internal sealed class Class70 : IDisposable
{
	private readonly Graphics graphics_0;

	private readonly Region region_0;

	internal Class70(Graphics graphics_1, GraphicsPath graphicsPath_0)
	{
		graphics_0 = graphics_1;
		region_0 = graphics_1.Clip;
		Region region = region_0.Clone();
		region.Intersect(graphicsPath_0);
		graphics_0.Clip = region;
	}

	public void Dispose()
	{
		method_0(bool_0: true);
		GC.SuppressFinalize(this);
	}

	private void method_0(bool bool_0)
	{
		if (bool_0)
		{
			graphics_0.Clip = region_0;
		}
	}
}
