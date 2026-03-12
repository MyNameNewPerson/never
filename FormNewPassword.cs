using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

internal sealed class FormNewPassword : Form
{
	private TextBox textPassword1;

	private Button buttonOk;

	private Button buttonCancel;

	private CheckBox checkVisiblePassword;

	private TextBox textPassword2;

	private Label label1;

	private Label label2;

	private IContainer icontainer_0;

	internal FormNewPassword()
	{
		InitializeComponent();
	}

	internal string method_0()
	{
		return textPassword1.Text;
	}

	private void checkVisiblePassword_CheckedChanged(object sender, EventArgs e)
	{
		textPassword1.UseSystemPasswordChar = !checkVisiblePassword.Checked;
		textPassword2.UseSystemPasswordChar = textPassword1.UseSystemPasswordChar;
	}

	private void textPassword2_TextChanged(object sender, EventArgs e)
	{
		buttonOk.Enabled = textPassword1.Text.Equals(textPassword2.Text, StringComparison.Ordinal);
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNewPassword));
		this.textPassword1 = new System.Windows.Forms.TextBox();
		this.buttonOk = new System.Windows.Forms.Button();
		this.buttonCancel = new System.Windows.Forms.Button();
		this.checkVisiblePassword = new System.Windows.Forms.CheckBox();
		this.textPassword2 = new System.Windows.Forms.TextBox();
		this.label1 = new System.Windows.Forms.Label();
		this.label2 = new System.Windows.Forms.Label();
		base.SuspendLayout();
		this.textPassword1.Location = new System.Drawing.Point(8, 28);
		this.textPassword1.Name = "textPassword1";
		this.textPassword1.Size = new System.Drawing.Size(120, 21);
		this.textPassword1.TabIndex = 0;
		this.textPassword1.UseSystemPasswordChar = true;
		this.textPassword1.TextChanged += new System.EventHandler(textPassword2_TextChanged);
		this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
		this.buttonOk.Enabled = false;
		this.buttonOk.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
		this.buttonOk.Location = new System.Drawing.Point(62, 87);
		this.buttonOk.Name = "buttonOk";
		this.buttonOk.Size = new System.Drawing.Size(111, 23);
		this.buttonOk.TabIndex = 3;
		this.buttonOk.Text = "Ввод";
		this.buttonOk.UseVisualStyleBackColor = true;
		this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
		this.buttonCancel.Location = new System.Drawing.Point(179, 87);
		this.buttonCancel.Name = "buttonCancel";
		this.buttonCancel.Size = new System.Drawing.Size(75, 23);
		this.buttonCancel.TabIndex = 4;
		this.buttonCancel.Text = "Отмена";
		this.buttonCancel.UseVisualStyleBackColor = true;
		this.checkVisiblePassword.AutoSize = true;
		this.checkVisiblePassword.Location = new System.Drawing.Point(15, 55);
		this.checkVisiblePassword.Name = "checkVisiblePassword";
		this.checkVisiblePassword.Size = new System.Drawing.Size(110, 17);
		this.checkVisiblePassword.TabIndex = 2;
		this.checkVisiblePassword.Text = "Видимые пароли";
		this.checkVisiblePassword.UseVisualStyleBackColor = true;
		this.checkVisiblePassword.CheckedChanged += new System.EventHandler(checkVisiblePassword_CheckedChanged);
		this.textPassword2.Location = new System.Drawing.Point(134, 28);
		this.textPassword2.Name = "textPassword2";
		this.textPassword2.Size = new System.Drawing.Size(120, 21);
		this.textPassword2.TabIndex = 1;
		this.textPassword2.UseSystemPasswordChar = true;
		this.textPassword2.TextChanged += new System.EventHandler(textPassword2_TextChanged);
		this.label1.AutoSize = true;
		this.label1.Location = new System.Drawing.Point(12, 9);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(44, 13);
		this.label1.TabIndex = 5;
		this.label1.Text = "Пароль";
		this.label2.AutoSize = true;
		this.label2.Location = new System.Drawing.Point(140, 9);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(83, 13);
		this.label2.TabIndex = 6;
		this.label2.Text = "Повтор пароля";
		base.AcceptButton = this.buttonOk;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.CancelButton = this.buttonCancel;
		base.ClientSize = new System.Drawing.Size(262, 119);
		base.Controls.Add(this.label2);
		base.Controls.Add(this.label1);
		base.Controls.Add(this.textPassword2);
		base.Controls.Add(this.checkVisiblePassword);
		base.Controls.Add(this.buttonCancel);
		base.Controls.Add(this.buttonOk);
		base.Controls.Add(this.textPassword1);
		this.DoubleBuffered = true;
		this.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "FormNewPassword";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Новый пароль шифрования";
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
