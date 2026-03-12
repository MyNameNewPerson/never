using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

internal sealed class FormAutoLogon : Form
{
	private int int_0 = 3;

	private Label labelUsername;

	private Label label2;

	private Button buttonCancel;

	private Button buttonOk;

	private Timer timer_0;

	private IContainer icontainer_0;

	internal FormAutoLogon(string string_0)
	{
		InitializeComponent();
		labelUsername.Text = string_0;
		timer_0.Start();
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		int_0--;
		if (int_0 == 0)
		{
			base.DialogResult = DialogResult.OK;
			Close();
		}
		else
		{
			buttonOk.Text = "Автовход через " + int_0 + " сек";
		}
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAutoLogon));
		this.labelUsername = new System.Windows.Forms.Label();
		this.label2 = new System.Windows.Forms.Label();
		this.buttonCancel = new System.Windows.Forms.Button();
		this.buttonOk = new System.Windows.Forms.Button();
		this.timer_0 = new System.Windows.Forms.Timer(this.icontainer_0);
		base.SuspendLayout();
		this.labelUsername.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
		this.labelUsername.Location = new System.Drawing.Point(12, 9);
		this.labelUsername.Name = "labelUsername";
		this.labelUsername.Size = new System.Drawing.Size(283, 20);
		this.labelUsername.TabIndex = 0;
		this.labelUsername.Text = "label1";
		this.labelUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label2.Location = new System.Drawing.Point(12, 29);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(283, 23);
		this.label2.TabIndex = 1;
		this.label2.Text = "входит в игру";
		this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
		this.buttonCancel.Location = new System.Drawing.Point(218, 68);
		this.buttonCancel.Name = "buttonCancel";
		this.buttonCancel.Size = new System.Drawing.Size(77, 23);
		this.buttonCancel.TabIndex = 6;
		this.buttonCancel.Text = "Отмена";
		this.buttonCancel.UseVisualStyleBackColor = true;
		this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
		this.buttonOk.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
		this.buttonOk.Location = new System.Drawing.Point(12, 68);
		this.buttonOk.Name = "buttonOk";
		this.buttonOk.Size = new System.Drawing.Size(200, 23);
		this.buttonOk.TabIndex = 5;
		this.buttonOk.Text = "Автовход через 3 сек";
		this.buttonOk.UseVisualStyleBackColor = true;
		this.timer_0.Interval = 1000;
		this.timer_0.Tick += new System.EventHandler(timer_0_Tick);
		base.AcceptButton = this.buttonOk;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.CancelButton = this.buttonCancel;
		base.ClientSize = new System.Drawing.Size(307, 107);
		base.Controls.Add(this.buttonCancel);
		base.Controls.Add(this.buttonOk);
		base.Controls.Add(this.label2);
		base.Controls.Add(this.labelUsername);
		this.DoubleBuffered = true;
		this.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "FormAutoLogon";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Автовход в игру";
		base.ResumeLayout(false);
	}
}
