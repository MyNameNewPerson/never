using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ABClient.Forms;

public class FormGroup : Form
{
	private IContainer icontainer_0;

	private Label label2;

	private TextBox textBox;

	private Button buttonOk;

	private Button buttonCancel;

	public string GroupName => textBox.Text.Trim();

	public FormGroup(string nick)
	{
		InitializeComponent();
		textBox.Text = nick;
	}

	private void textBox_TextChanged(object sender, EventArgs e)
	{
		buttonOk.Enabled = !string.IsNullOrEmpty(textBox.Text.Trim());
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ABClient.Forms.FormGroup));
		this.label2 = new System.Windows.Forms.Label();
		this.textBox = new System.Windows.Forms.TextBox();
		this.buttonOk = new System.Windows.Forms.Button();
		this.buttonCancel = new System.Windows.Forms.Button();
		base.SuspendLayout();
		this.label2.AutoSize = true;
		this.label2.Location = new System.Drawing.Point(12, 9);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(123, 13);
		this.label2.TabIndex = 1008;
		this.label2.Text = "Имя группы контактов";
		this.textBox.Location = new System.Drawing.Point(12, 25);
		this.textBox.Name = "textBox";
		this.textBox.Size = new System.Drawing.Size(236, 21);
		this.textBox.TabIndex = 0;
		this.textBox.TextChanged += new System.EventHandler(textBox_TextChanged);
		this.buttonOk.AutoSize = true;
		this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
		this.buttonOk.Enabled = false;
		this.buttonOk.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
		this.buttonOk.Location = new System.Drawing.Point(72, 70);
		this.buttonOk.Name = "buttonOk";
		this.buttonOk.Size = new System.Drawing.Size(85, 23);
		this.buttonOk.TabIndex = 1009;
		this.buttonOk.Text = "Ввод";
		this.buttonOk.UseVisualStyleBackColor = true;
		this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
		this.buttonCancel.Location = new System.Drawing.Point(163, 70);
		this.buttonCancel.Name = "buttonCancel";
		this.buttonCancel.Size = new System.Drawing.Size(85, 23);
		this.buttonCancel.TabIndex = 1010;
		this.buttonCancel.Text = "Отмена";
		this.buttonCancel.UseVisualStyleBackColor = true;
		base.AcceptButton = this.buttonOk;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.CancelButton = this.buttonCancel;
		base.ClientSize = new System.Drawing.Size(260, 103);
		base.Controls.Add(this.label2);
		base.Controls.Add(this.textBox);
		base.Controls.Add(this.buttonOk);
		base.Controls.Add(this.buttonCancel);
		this.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "FormGroup";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Группа контактов";
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
