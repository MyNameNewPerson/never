using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

internal sealed class FormAbout : Form
{
	private IContainer icontainer_0;

	private Button buttonOk;

	private Label label1;

	internal FormAbout()
	{
		InitializeComponent();
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
		this.buttonOk = new System.Windows.Forms.Button();
		this.label1 = new System.Windows.Forms.Label();
		base.SuspendLayout();
		this.buttonOk.AutoSize = true;
		this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
		this.buttonOk.Location = new System.Drawing.Point(51, 103);
		this.buttonOk.Name = "buttonOk";
		this.buttonOk.Size = new System.Drawing.Size(121, 23);
		this.buttonOk.TabIndex = 1008;
		this.buttonOk.Text = "Продолжить";
		this.buttonOk.UseVisualStyleBackColor = true;
		this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label1.Font = new System.Drawing.Font("Verdana", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
		this.label1.Location = new System.Drawing.Point(0, 0);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(223, 133);
		this.label1.TabIndex = 1011;
		this.label1.Text = "iBClient\r\n\r\nhttp://ibclient.my1.ru/\r\nE-mail: ibclient@yandex.ru\r\nSkype: iBClient Developer (live:mol62.mm)";
		this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		base.AcceptButton = this.buttonOk;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(223, 133);
		base.Controls.Add(this.label1);
		base.Controls.Add(this.buttonOk);
		this.DoubleBuffered = true;
		this.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "FormAbout";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "О клиенте";
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
