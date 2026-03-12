using System;
using System.Drawing;
using System.Drawing.Text;

namespace ABClient.AppControls;

public sealed class UseClearTypeGridFit : IDisposable
{
	private readonly Graphics graphics_0;

	private readonly TextRenderingHint textRenderingHint_0;

	public UseClearTypeGridFit(Graphics graphics)
	{
		graphics_0 = graphics;
		textRenderingHint_0 = graphics_0.TextRenderingHint;
		graphics_0.TextRenderingHint = TextRenderingHint.SystemDefault;
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
			graphics_0.TextRenderingHint = textRenderingHint_0;
		}
	}
}
