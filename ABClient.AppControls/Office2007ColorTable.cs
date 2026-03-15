using System.Drawing;
using System.Windows.Forms;

namespace ABClient.AppControls;

public class Office2007ColorTable : ProfessionalColorTable
{
	private static readonly Color color_0 = Color.FromArgb(250, 250, 250);

	private static readonly Color color_1 = Color.FromArgb(248, 181, 106);

	private static readonly Color color_2 = Color.FromArgb(255, 208, 134);

	private static readonly Color color_3 = Color.FromArgb(251, 140, 60);

	private static readonly Color color_4 = Color.FromArgb(255, 255, 222);

	private static readonly Color color_5 = Color.FromArgb(255, 203, 136);

	private static readonly Color color_6 = Color.FromArgb(255, 225, 172);

	private static readonly Color color_7 = Color.FromArgb(255, 213, 103);

	private static readonly Color color_8 = Color.FromArgb(255, 228, 145);

	private static readonly Color color_9 = Color.FromArgb(255, 227, 149);

	private static readonly Color color_10 = Color.FromArgb(111, 157, 217);

	private static readonly Color color_11 = Color.FromArgb(255, 255, 255);

	private static readonly Color color_12 = Color.FromArgb(233, 238, 238);

	private static readonly Color color_13 = Color.FromArgb(134, 134, 134);

	private static readonly Color color_14 = Color.FromArgb(167, 204, 251);

	private static readonly Color color_15 = Color.FromArgb(101, 147, 207);

	private static readonly Color color_16 = Color.FromArgb(167, 204, 251);

	private static readonly Color color_17 = Color.FromArgb(191, 219, 255);

	private static readonly Color color_18 = Color.FromArgb(154, 198, 255);

	private static readonly Color color_19 = Color.FromArgb(255, 255, 255);

	private static readonly Color color_20 = Color.FromArgb(215, 229, 247);

	private static readonly Color color_21 = Color.FromArgb(172, 201, 238);

	private static readonly Color color_22 = Color.FromArgb(111, 157, 217);

	private static readonly Color color_23 = Color.FromArgb(164, 195, 235);

	private static readonly Color color_24 = Color.FromArgb(227, 239, 255);

	private static readonly Color color_25 = Color.FromArgb(152, 186, 230);

	private static readonly Color color_26 = Color.FromArgb(222, 236, 255);

	private static readonly Color color_27 = Color.FromArgb(121, 153, 194);

	public override Color ButtonPressedGradientBegin => color_1;

	public override Color ButtonPressedGradientEnd => color_2;

	public override Color ButtonPressedGradientMiddle => color_3;

	public override Color ButtonSelectedGradientBegin => color_4;

	public override Color ButtonSelectedGradientEnd => color_5;

	public override Color ButtonSelectedGradientMiddle => color_6;

	public override Color ButtonSelectedHighlightBorder => color_27;

	public override Color CheckBackground => color_9;

	public override Color GripDark => color_10;

	public override Color GripLight => color_11;

	public override Color ImageMarginGradientBegin => color_12;

	public override Color MenuBorder => color_13;

	public override Color MenuItemPressedGradientBegin => color_24;

	public override Color MenuItemPressedGradientEnd => color_25;

	public override Color MenuItemPressedGradientMiddle => color_26;

	public override Color MenuItemSelectedGradientBegin => color_7;

	public override Color MenuItemSelectedGradientEnd => color_8;

	public override Color MenuStripGradientBegin => color_17;

	public override Color MenuStripGradientEnd => color_17;

	public override Color OverflowButtonGradientBegin => color_14;

	public override Color OverflowButtonGradientEnd => color_15;

	public override Color OverflowButtonGradientMiddle => color_16;

	public override Color RaftingContainerGradientBegin => color_17;

	public override Color RaftingContainerGradientEnd => color_17;

	public override Color SeparatorDark => color_18;

	public override Color SeparatorLight => color_19;

	public override Color StatusStripGradientBegin => color_20;

	public override Color StatusStripGradientEnd => color_21;

	public override Color ToolStripBorder => color_22;

	public override Color ToolStripContentPanelGradientBegin => color_23;

	public override Color ToolStripContentPanelGradientEnd => color_17;

	public override Color ToolStripDropDownBackground => color_0;

	public override Color ToolStripGradientBegin => color_24;

	public override Color ToolStripGradientEnd => color_25;

	public override Color ToolStripGradientMiddle => color_26;

	public override Color ToolStripPanelGradientBegin => color_17;

	public override Color ToolStripPanelGradientEnd => color_17;
}
