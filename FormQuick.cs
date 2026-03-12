using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ABClient.ABForms;

internal sealed class FormQuick : Form
{
	private IContainer icontainer_0;

	private TextBox textBoxNick;

	private Button buttonHitSimple;

	private Button buttonHitBlood;

	private Button buttonHitUltimate;

	private ToolTip toolTip_0;

	private Button buttonHitClosedUltimate;

	private Button buttonFistSimple;

	private Button buttonFistClosed;

	private Button buttonPoison;

	private Button buttonStrong;

	private Button buttonInvisible;

	private Button buttonFog;

	private CheckBox checkBoxClose;

	private Button buttonClosed;

	private Button buttonPortal;

	private Button buttonVsergard;

	private Button buttonExtraStrong;

	internal FormQuick(string string_0)
	{
		InitializeComponent();
		if (!string.IsNullOrEmpty(string_0))
		{
			textBoxNick.Text = string_0;
		}
	}

	private void FormQuick_Load(object sender, EventArgs e)
	{
		toolTip_0.SetToolTip(buttonHitSimple, "Обычное нападение");
		toolTip_0.SetToolTip(buttonHitBlood, "Кровавое нападение");
		toolTip_0.SetToolTip(buttonHitUltimate, "Боевое нападение");
		toolTip_0.SetToolTip(buttonHitClosedUltimate, "Закрытое боевое нападение");
		toolTip_0.SetToolTip(buttonClosed, "Закрытое нападение");
		toolTip_0.SetToolTip(buttonFistSimple, "Кулачное нападение");
		toolTip_0.SetToolTip(buttonFistClosed, "Закрытое кулачное нападение");
		toolTip_0.SetToolTip(buttonPortal, "Портал");
		toolTip_0.SetToolTip(buttonVsergard, "Проклятие Всергарда");
		toolTip_0.SetToolTip(buttonFog, "Свиток Искажающего Тумана");
		toolTip_0.SetToolTip(buttonPoison, "Яд");
		toolTip_0.SetToolTip(buttonStrong, "Зелье Сильной Спины");
		toolTip_0.SetToolTip(buttonExtraStrong, "Превосходное Зелье Сильной Спины");
		toolTip_0.SetToolTip(buttonInvisible, "Зелье Невидимости");
	}

	private void buttonHitSimple_Click(object sender, EventArgs e)
	{
		FormMain.smethod_5(textBoxNick.Text.Trim());
		method_0();
	}

	private void buttonHitBlood_Click(object sender, EventArgs e)
	{
		FormMain.smethod_6(textBoxNick.Text.Trim());
		method_0();
	}

	private void buttonHitUltimate_Click(object sender, EventArgs e)
	{
		FormMain.smethod_7(textBoxNick.Text.Trim());
		method_0();
	}

	private void buttonHitClosedUltimate_Click(object sender, EventArgs e)
	{
		FormMain.smethod_9(textBoxNick.Text.Trim());
		method_0();
	}

	private void buttonFistSimple_Click(object sender, EventArgs e)
	{
		FormMain.smethod_16(textBoxNick.Text.Trim());
		method_0();
	}

	private void buttonFistClosed_Click(object sender, EventArgs e)
	{
		FormMain.smethod_18(textBoxNick.Text.Trim());
		method_0();
	}

	private void buttonClosed_Click(object sender, EventArgs e)
	{
		FormMain.smethod_11(textBoxNick.Text.Trim());
		method_0();
	}

	private void buttonFog_Click(object sender, EventArgs e)
	{
		FormMain.smethod_20(textBoxNick.Text.Trim());
		method_0();
	}

	private void buttonPoison_Click(object sender, EventArgs e)
	{
		FormMain.smethod_25(textBoxNick.Text.Trim());
		method_0();
	}

	private void buttonStrong_Click(object sender, EventArgs e)
	{
		FormMain.smethod_27(textBoxNick.Text.Trim());
		method_0();
	}

	private void buttonInvisible_Click(object sender, EventArgs e)
	{
		FormMain.smethod_31(textBoxNick.Text.Trim());
		method_0();
	}

	private void method_0()
	{
		if (checkBoxClose.Checked)
		{
			Close();
		}
	}

	private void buttonPortal_Click(object sender, EventArgs e)
	{
		FormMain.smethod_13(textBoxNick.Text.Trim());
		method_0();
	}

	private void buttonVsergard_Click(object sender, EventArgs e)
	{
		FormMain.smethod_15(textBoxNick.Text.Trim());
		method_0();
	}

	private void buttonExtraStrong_Click(object sender, EventArgs e)
	{
		FormMain.smethod_29(textBoxNick.Text.Trim());
		method_0();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	private void InitializeComponent()
	{
		this.icontainer_0 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQuick));
		this.textBoxNick = new System.Windows.Forms.TextBox();
		this.buttonHitSimple = new System.Windows.Forms.Button();
		this.buttonHitBlood = new System.Windows.Forms.Button();
		this.buttonHitUltimate = new System.Windows.Forms.Button();
		this.toolTip_0 = new System.Windows.Forms.ToolTip(this.icontainer_0);
		this.buttonHitClosedUltimate = new System.Windows.Forms.Button();
		this.buttonFistSimple = new System.Windows.Forms.Button();
		this.buttonFistClosed = new System.Windows.Forms.Button();
		this.buttonPoison = new System.Windows.Forms.Button();
		this.buttonStrong = new System.Windows.Forms.Button();
		this.buttonInvisible = new System.Windows.Forms.Button();
		this.buttonFog = new System.Windows.Forms.Button();
		this.checkBoxClose = new System.Windows.Forms.CheckBox();
		this.buttonClosed = new System.Windows.Forms.Button();
		this.buttonPortal = new System.Windows.Forms.Button();
		this.buttonVsergard = new System.Windows.Forms.Button();
		this.buttonExtraStrong = new System.Windows.Forms.Button();
		base.SuspendLayout();
		this.textBoxNick.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
		this.textBoxNick.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
		this.textBoxNick.Location = new System.Drawing.Point(13, 13);
		this.textBoxNick.Name = "textBoxNick";
		this.textBoxNick.Size = new System.Drawing.Size(155, 21);
		this.textBoxNick.TabIndex = 0;
		this.buttonHitSimple.AutoSize = true;
		this.buttonHitSimple.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		this.buttonHitSimple.Cursor = System.Windows.Forms.Cursors.Hand;
		this.buttonHitSimple.Image = Class39.smethod_57();
		this.buttonHitSimple.Location = new System.Drawing.Point(12, 68);
		this.buttonHitSimple.Name = "buttonHitSimple";
		this.buttonHitSimple.Size = new System.Drawing.Size(48, 27);
		this.buttonHitSimple.TabIndex = 1;
		this.buttonHitSimple.UseVisualStyleBackColor = true;
		this.buttonHitSimple.Click += new System.EventHandler(buttonHitSimple_Click);
		this.buttonHitBlood.AutoSize = true;
		this.buttonHitBlood.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		this.buttonHitBlood.Cursor = System.Windows.Forms.Cursors.Hand;
		this.buttonHitBlood.Image = Class39.smethod_58();
		this.buttonHitBlood.Location = new System.Drawing.Point(66, 68);
		this.buttonHitBlood.Name = "buttonHitBlood";
		this.buttonHitBlood.Size = new System.Drawing.Size(48, 27);
		this.buttonHitBlood.TabIndex = 2;
		this.buttonHitBlood.UseVisualStyleBackColor = true;
		this.buttonHitBlood.Click += new System.EventHandler(buttonHitBlood_Click);
		this.buttonHitUltimate.AutoSize = true;
		this.buttonHitUltimate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		this.buttonHitUltimate.Cursor = System.Windows.Forms.Cursors.Hand;
		this.buttonHitUltimate.Image = Class39.smethod_66();
		this.buttonHitUltimate.Location = new System.Drawing.Point(120, 68);
		this.buttonHitUltimate.Name = "buttonHitUltimate";
		this.buttonHitUltimate.Size = new System.Drawing.Size(48, 27);
		this.buttonHitUltimate.TabIndex = 3;
		this.buttonHitUltimate.UseVisualStyleBackColor = true;
		this.buttonHitUltimate.Click += new System.EventHandler(buttonHitUltimate_Click);
		this.buttonHitClosedUltimate.AutoSize = true;
		this.buttonHitClosedUltimate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		this.buttonHitClosedUltimate.Cursor = System.Windows.Forms.Cursors.Hand;
		this.buttonHitClosedUltimate.Image = Class39.smethod_67();
		this.buttonHitClosedUltimate.Location = new System.Drawing.Point(120, 101);
		this.buttonHitClosedUltimate.Name = "buttonHitClosedUltimate";
		this.buttonHitClosedUltimate.Size = new System.Drawing.Size(48, 27);
		this.buttonHitClosedUltimate.TabIndex = 4;
		this.buttonHitClosedUltimate.UseVisualStyleBackColor = true;
		this.buttonHitClosedUltimate.Click += new System.EventHandler(buttonHitClosedUltimate_Click);
		this.buttonFistSimple.AutoSize = true;
		this.buttonFistSimple.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		this.buttonFistSimple.Cursor = System.Windows.Forms.Cursors.Hand;
		this.buttonFistSimple.Image = Class39.smethod_64();
		this.buttonFistSimple.Location = new System.Drawing.Point(12, 101);
		this.buttonFistSimple.Name = "buttonFistSimple";
		this.buttonFistSimple.Size = new System.Drawing.Size(48, 27);
		this.buttonFistSimple.TabIndex = 5;
		this.buttonFistSimple.UseVisualStyleBackColor = true;
		this.buttonFistSimple.Click += new System.EventHandler(buttonFistSimple_Click);
		this.buttonFistClosed.AutoSize = true;
		this.buttonFistClosed.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		this.buttonFistClosed.Cursor = System.Windows.Forms.Cursors.Hand;
		this.buttonFistClosed.Image = Class39.smethod_65();
		this.buttonFistClosed.Location = new System.Drawing.Point(66, 101);
		this.buttonFistClosed.Name = "buttonFistClosed";
		this.buttonFistClosed.Size = new System.Drawing.Size(48, 27);
		this.buttonFistClosed.TabIndex = 6;
		this.buttonFistClosed.UseVisualStyleBackColor = true;
		this.buttonFistClosed.Click += new System.EventHandler(buttonFistClosed_Click);
		this.buttonPoison.AutoSize = true;
		this.buttonPoison.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		this.buttonPoison.Cursor = System.Windows.Forms.Cursors.Hand;
		this.buttonPoison.Image = Class39.smethod_61();
		this.buttonPoison.Location = new System.Drawing.Point(66, 168);
		this.buttonPoison.Name = "buttonPoison";
		this.buttonPoison.Size = new System.Drawing.Size(26, 26);
		this.buttonPoison.TabIndex = 7;
		this.buttonPoison.UseVisualStyleBackColor = true;
		this.buttonPoison.Click += new System.EventHandler(buttonPoison_Click);
		this.buttonStrong.AutoSize = true;
		this.buttonStrong.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		this.buttonStrong.Cursor = System.Windows.Forms.Cursors.Hand;
		this.buttonStrong.Image = Class39.smethod_62();
		this.buttonStrong.Location = new System.Drawing.Point(91, 168);
		this.buttonStrong.Name = "buttonStrong";
		this.buttonStrong.Size = new System.Drawing.Size(26, 26);
		this.buttonStrong.TabIndex = 8;
		this.buttonStrong.UseVisualStyleBackColor = true;
		this.buttonStrong.Click += new System.EventHandler(buttonStrong_Click);
		this.buttonInvisible.AutoSize = true;
		this.buttonInvisible.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		this.buttonInvisible.Cursor = System.Windows.Forms.Cursors.Hand;
		this.buttonInvisible.Image = Class39.smethod_63();
		this.buttonInvisible.Location = new System.Drawing.Point(141, 168);
		this.buttonInvisible.Name = "buttonInvisible";
		this.buttonInvisible.Size = new System.Drawing.Size(26, 26);
		this.buttonInvisible.TabIndex = 9;
		this.buttonInvisible.UseVisualStyleBackColor = true;
		this.buttonInvisible.Click += new System.EventHandler(buttonInvisible_Click);
		this.buttonFog.AutoSize = true;
		this.buttonFog.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		this.buttonFog.Cursor = System.Windows.Forms.Cursors.Hand;
		this.buttonFog.Image = Class39.smethod_60();
		this.buttonFog.Location = new System.Drawing.Point(12, 168);
		this.buttonFog.Name = "buttonFog";
		this.buttonFog.Size = new System.Drawing.Size(48, 27);
		this.buttonFog.TabIndex = 10;
		this.buttonFog.UseVisualStyleBackColor = true;
		this.buttonFog.Click += new System.EventHandler(buttonFog_Click);
		this.checkBoxClose.AutoSize = true;
		this.checkBoxClose.Checked = true;
		this.checkBoxClose.CheckState = System.Windows.Forms.CheckState.Checked;
		this.checkBoxClose.Location = new System.Drawing.Point(23, 43);
		this.checkBoxClose.Name = "checkBoxClose";
		this.checkBoxClose.Size = new System.Drawing.Size(139, 17);
		this.checkBoxClose.TabIndex = 11;
		this.checkBoxClose.Text = "Как нажали - закрыть";
		this.checkBoxClose.UseVisualStyleBackColor = true;
		this.buttonClosed.AutoSize = true;
		this.buttonClosed.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		this.buttonClosed.Cursor = System.Windows.Forms.Cursors.Hand;
		this.buttonClosed.Image = Class39.smethod_59();
		this.buttonClosed.Location = new System.Drawing.Point(12, 134);
		this.buttonClosed.Name = "buttonClosed";
		this.buttonClosed.Size = new System.Drawing.Size(48, 27);
		this.buttonClosed.TabIndex = 12;
		this.buttonClosed.UseVisualStyleBackColor = true;
		this.buttonClosed.Click += new System.EventHandler(buttonClosed_Click);
		this.buttonPortal.AutoSize = true;
		this.buttonPortal.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		this.buttonPortal.Cursor = System.Windows.Forms.Cursors.Hand;
		this.buttonPortal.Image = Class39.smethod_68();
		this.buttonPortal.Location = new System.Drawing.Point(120, 134);
		this.buttonPortal.Name = "buttonPortal";
		this.buttonPortal.Size = new System.Drawing.Size(48, 27);
		this.buttonPortal.TabIndex = 13;
		this.buttonPortal.UseVisualStyleBackColor = true;
		this.buttonPortal.Click += new System.EventHandler(buttonPortal_Click);
		this.buttonVsergard.AutoSize = true;
		this.buttonVsergard.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		this.buttonVsergard.Cursor = System.Windows.Forms.Cursors.Hand;
		this.buttonVsergard.Image = Class39.smethod_85();
		this.buttonVsergard.Location = new System.Drawing.Point(66, 134);
		this.buttonVsergard.Name = "buttonVsergard";
		this.buttonVsergard.Size = new System.Drawing.Size(48, 27);
		this.buttonVsergard.TabIndex = 14;
		this.buttonVsergard.UseVisualStyleBackColor = true;
		this.buttonVsergard.Click += new System.EventHandler(buttonVsergard_Click);
		this.buttonExtraStrong.AutoSize = true;
		this.buttonExtraStrong.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		this.buttonExtraStrong.Cursor = System.Windows.Forms.Cursors.Hand;
		this.buttonExtraStrong.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
		this.buttonExtraStrong.Image = Class39.smethod_62();
		this.buttonExtraStrong.Location = new System.Drawing.Point(116, 168);
		this.buttonExtraStrong.Name = "buttonExtraStrong";
		this.buttonExtraStrong.Size = new System.Drawing.Size(26, 26);
		this.buttonExtraStrong.TabIndex = 15;
		this.buttonExtraStrong.UseVisualStyleBackColor = true;
		this.buttonExtraStrong.Click += new System.EventHandler(buttonExtraStrong_Click);
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(184, 203);
		base.Controls.Add(this.buttonExtraStrong);
		base.Controls.Add(this.buttonVsergard);
		base.Controls.Add(this.buttonPortal);
		base.Controls.Add(this.buttonClosed);
		base.Controls.Add(this.checkBoxClose);
		base.Controls.Add(this.buttonFog);
		base.Controls.Add(this.buttonInvisible);
		base.Controls.Add(this.buttonStrong);
		base.Controls.Add(this.buttonPoison);
		base.Controls.Add(this.buttonFistClosed);
		base.Controls.Add(this.buttonFistSimple);
		base.Controls.Add(this.buttonHitClosedUltimate);
		base.Controls.Add(this.buttonHitUltimate);
		base.Controls.Add(this.buttonHitBlood);
		base.Controls.Add(this.buttonHitSimple);
		base.Controls.Add(this.textBoxNick);
		this.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "FormQuick";
		this.Text = "FormQuick";
		base.TopMost = true;
		base.Load += new System.EventHandler(FormQuick_Load);
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
