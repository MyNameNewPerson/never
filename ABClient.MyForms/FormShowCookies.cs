using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ABClient.MyForms;

public class FormShowCookies : Form
{
	private IContainer icontainer_0;

	private TextBox textBoxCookies;

	private Button buttonCopyToClipboard;

	private Button buttonOk;

	public FormShowCookies()
	{
		InitializeComponent();
	}

	private void FormShowCookies_Load(object sender, EventArgs e)
	{
		textBoxCookies.Text = Class32.smethod_1("www.neverlands.ru");
		method_0();
	}

	private void buttonOk_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void method_0()
	{
		try
		{
			Clipboard.SetText(textBoxCookies.Text);
		}
		catch (ExternalException)
		{
		}
	}

	private void buttonCopyToClipboard_Click(object sender, EventArgs e)
	{
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ABClient.MyForms.FormShowCookies));
		this.textBoxCookies = new System.Windows.Forms.TextBox();
		this.buttonCopyToClipboard = new System.Windows.Forms.Button();
		this.buttonOk = new System.Windows.Forms.Button();
		base.SuspendLayout();
		this.textBoxCookies.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.textBoxCookies.Location = new System.Drawing.Point(12, 12);
		this.textBoxCookies.Multiline = true;
		this.textBoxCookies.Name = "textBoxCookies";
		this.textBoxCookies.ReadOnly = true;
		this.textBoxCookies.Size = new System.Drawing.Size(317, 138);
		this.textBoxCookies.TabIndex = 0;
		this.buttonCopyToClipboard.Location = new System.Drawing.Point(47, 169);
		this.buttonCopyToClipboard.Name = "buttonCopyToClipboard";
		this.buttonCopyToClipboard.Size = new System.Drawing.Size(165, 23);
		this.buttonCopyToClipboard.TabIndex = 1;
		this.buttonCopyToClipboard.Text = "Копировать в клипборд";
		this.buttonCopyToClipboard.UseVisualStyleBackColor = true;
		this.buttonCopyToClipboard.Click += new System.EventHandler(buttonCopyToClipboard_Click);
		this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
		this.buttonOk.Location = new System.Drawing.Point(218, 169);
		this.buttonOk.Name = "buttonOk";
		this.buttonOk.Size = new System.Drawing.Size(75, 23);
		this.buttonOk.TabIndex = 2;
		this.buttonOk.Text = "Ok";
		this.buttonOk.UseVisualStyleBackColor = true;
		this.buttonOk.Click += new System.EventHandler(buttonOk_Click);
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(341, 204);
		base.Controls.Add(this.buttonOk);
		base.Controls.Add(this.buttonCopyToClipboard);
		base.Controls.Add(this.textBoxCookies);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "FormShowCookies";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Куки игры";
		base.Load += new System.EventHandler(FormShowCookies_Load);
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
