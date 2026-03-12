using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

internal sealed class FormPromptExit : Form
{
	private byte byte_0 = 10;

	private IContainer icontainer_0;

	private Button buttonOk;

	private Button buttonCancel;

	private Label label1;

	private CheckBox checkboxSkipPromptExit;

	private Timer timer_0;

	public FormPromptExit()
	{
		InitializeComponent();
		timer_0.Start();
	}

	public bool method_0()
	{
		return checkboxSkipPromptExit.Checked;
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		buttonOk.Text = "Да (" + byte_0 + " сек до выхода)";
		byte_0--;
		if (byte_0 == 0)
		{
			base.DialogResult = DialogResult.OK;
			Close();
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPromptExit));
		this.buttonOk = new System.Windows.Forms.Button();
		this.buttonCancel = new System.Windows.Forms.Button();
		this.label1 = new System.Windows.Forms.Label();
		this.checkboxSkipPromptExit = new System.Windows.Forms.CheckBox();
		this.timer_0 = new System.Windows.Forms.Timer(this.icontainer_0);
		base.SuspendLayout();
		this.buttonOk.AutoSize = true;
		this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
		this.buttonOk.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
		this.buttonOk.Location = new System.Drawing.Point(12, 86);
		this.buttonOk.Name = "buttonOk";
		this.buttonOk.Size = new System.Drawing.Size(222, 23);
		this.buttonOk.TabIndex = 1010;
		this.buttonOk.Text = "Да (10 сек до выхода)";
		this.buttonOk.UseVisualStyleBackColor = true;
		this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
		this.buttonCancel.Location = new System.Drawing.Point(240, 86);
		this.buttonCancel.Name = "buttonCancel";
		this.buttonCancel.Size = new System.Drawing.Size(91, 23);
		this.buttonCancel.TabIndex = 1011;
		this.buttonCancel.Text = "Отмена";
		this.buttonCancel.UseVisualStyleBackColor = true;
		this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.label1.BackColor = System.Drawing.Color.LemonChiffon;
		this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label1.Location = new System.Drawing.Point(12, 9);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(319, 26);
		this.label1.TabIndex = 1000;
		this.label1.Text = "Вы уверены что хотите покинуть игру?";
		this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.checkboxSkipPromptExit.AutoSize = true;
		this.checkboxSkipPromptExit.Location = new System.Drawing.Point(33, 51);
		this.checkboxSkipPromptExit.Name = "checkboxSkipPromptExit";
		this.checkboxSkipPromptExit.Size = new System.Drawing.Size(194, 17);
		this.checkboxSkipPromptExit.TabIndex = 1013;
		this.checkboxSkipPromptExit.Text = "Больше не задавать этот вопрос";
		this.checkboxSkipPromptExit.UseVisualStyleBackColor = true;
		this.timer_0.Interval = 1000;
		this.timer_0.Tick += new System.EventHandler(timer_0_Tick);
		base.AcceptButton = this.buttonOk;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.CancelButton = this.buttonCancel;
		base.ClientSize = new System.Drawing.Size(343, 117);
		base.Controls.Add(this.checkboxSkipPromptExit);
		base.Controls.Add(this.label1);
		base.Controls.Add(this.buttonOk);
		base.Controls.Add(this.buttonCancel);
		this.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "FormPromptExit";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Запрос на выход";
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
