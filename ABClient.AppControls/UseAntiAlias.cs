using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace ABClient.AppControls;

public sealed class UseAntiAlias : IDisposable
{
	private readonly Graphics graphics_0;

	private readonly SmoothingMode smoothingMode_0;

	public UseAntiAlias(Graphics graphics)
	{
		graphics_0 = graphics;
		smoothingMode_0 = graphics_0.SmoothingMode;
		graphics_0.SmoothingMode = SmoothingMode.AntiAlias;
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
			graphics_0.SmoothingMode = smoothingMode_0;
		}
	}
}
