using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

internal sealed class FormAutoTrap : Form
{
	private TextBox textBox;

	private Button buttonContinue;

	private IContainer icontainer_0;

	internal FormAutoTrap(string string_0)
	{
		InitializeComponent();
		base.Icon = Class39.smethod_70();
		textBox.Text = string_0;
		textBox.Select(0, 0);
	}

	private void FormAutoTrap_Load(object sender, EventArgs e)
	{
		Text = Class72.class55_0.method_4();
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAutoTrap));
		this.textBox = new System.Windows.Forms.TextBox();
		this.buttonContinue = new System.Windows.Forms.Button();
		base.SuspendLayout();
		this.textBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.textBox.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
		this.textBox.Location = new System.Drawing.Point(0, 0);
		this.textBox.Multiline = true;
		this.textBox.Name = "textBox";
		this.textBox.ReadOnly = true;
		this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
		this.textBox.Size = new System.Drawing.Size(620, 334);
		this.textBox.TabIndex = 0;
		this.buttonContinue.DialogResult = System.Windows.Forms.DialogResult.OK;
		this.buttonContinue.Location = new System.Drawing.Point(234, 340);
		this.buttonContinue.Name = "buttonContinue";
		this.buttonContinue.Size = new System.Drawing.Size(150, 23);
		this.buttonContinue.TabIndex = 1;
		this.buttonContinue.Text = "Продолжить";
		this.buttonContinue.UseVisualStyleBackColor = true;
		base.AcceptButton = this.buttonContinue;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(620, 371);
		base.Controls.Add(this.buttonContinue);
		base.Controls.Add(this.textBox);
		this.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "FormAutoTrap";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		base.Load += new System.EventHandler(FormAutoTrap_Load);
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
