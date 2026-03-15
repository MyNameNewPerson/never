using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

internal sealed class FormAskPassword : Form
{
	private readonly string string_0;

	private IContainer icontainer_0;

	private CheckBox checkVisiblePassword;

	private Button buttonCancel;

	private Button buttonOk;

	private TextBox textPassword;

	internal FormAskPassword(string string_1)
	{
		if (string.IsNullOrEmpty(string_1))
		{
			throw new ArgumentNullException("hashPassword");
		}
		InitializeComponent();
		string_0 = string_1;
	}

	internal string method_0()
	{
		return textPassword.Text;
	}

	private void checkVisiblePassword_CheckedChanged(object sender, EventArgs e)
	{
		textPassword.UseSystemPasswordChar = !checkVisiblePassword.Checked;
	}

	private void textPassword_TextChanged(object sender, EventArgs e)
	{
		bool enabled = Class87.smethod_4(textPassword.Text).Equals(string_0);
		buttonOk.Enabled = enabled;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAskPassword));
		this.checkVisiblePassword = new System.Windows.Forms.CheckBox();
		this.buttonCancel = new System.Windows.Forms.Button();
		this.buttonOk = new System.Windows.Forms.Button();
		this.textPassword = new System.Windows.Forms.TextBox();
		base.SuspendLayout();
		this.checkVisiblePassword.AutoSize = true;
		this.checkVisiblePassword.Location = new System.Drawing.Point(19, 39);
		this.checkVisiblePassword.Name = "checkVisiblePassword";
		this.checkVisiblePassword.Size = new System.Drawing.Size(110, 17);
		this.checkVisiblePassword.TabIndex = 1;
		this.checkVisiblePassword.Text = "Видимый пароль";
		this.checkVisiblePassword.UseVisualStyleBackColor = true;
		this.checkVisiblePassword.CheckedChanged += new System.EventHandler(checkVisiblePassword_CheckedChanged);
		this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
		this.buttonCancel.Location = new System.Drawing.Point(129, 72);
		this.buttonCancel.Name = "buttonCancel";
		this.buttonCancel.Size = new System.Drawing.Size(75, 23);
		this.buttonCancel.TabIndex = 3;
		this.buttonCancel.Text = "Отмена";
		this.buttonCancel.UseVisualStyleBackColor = true;
		this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
		this.buttonOk.Enabled = false;
		this.buttonOk.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
		this.buttonOk.Location = new System.Drawing.Point(12, 72);
		this.buttonOk.Name = "buttonOk";
		this.buttonOk.Size = new System.Drawing.Size(111, 23);
		this.buttonOk.TabIndex = 2;
		this.buttonOk.Text = "Ввод";
		this.buttonOk.UseVisualStyleBackColor = true;
		this.textPassword.Location = new System.Drawing.Point(12, 12);
		this.textPassword.Name = "textPassword";
		this.textPassword.Size = new System.Drawing.Size(192, 21);
		this.textPassword.TabIndex = 0;
		this.textPassword.UseSystemPasswordChar = true;
		this.textPassword.TextChanged += new System.EventHandler(textPassword_TextChanged);
		base.AcceptButton = this.buttonOk;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.CancelButton = this.buttonCancel;
		base.ClientSize = new System.Drawing.Size(216, 109);
		base.Controls.Add(this.checkVisiblePassword);
		base.Controls.Add(this.buttonCancel);
		base.Controls.Add(this.buttonOk);
		base.Controls.Add(this.textPassword);
		this.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "FormAskPassword";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Введите пароль";
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
