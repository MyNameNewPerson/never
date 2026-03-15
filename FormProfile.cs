using System;
using System.ComponentModel;
using System.Drawing;
using System.Net;
using System.Windows.Forms;

internal sealed class FormProfile : Form
{
	private readonly string string_0;

	private bool bool_0;

	private Class19 class19_0;

	private IContainer icontainer_0;

	private GroupBox groupBox2;

	private TextBox textProxyPassword;

	private Label label4;

	private TextBox textProxyUsername;

	private Label label3;

	private TextBox textProxyAddress;

	private Label label2;

	private CheckBox checkUseProxy;

	private GroupBox groupBox1;

	private CheckBox checkVisiblePasswords;

	private CheckBox checkAutoLogon;

	private Label labelFlashPassword;

	private TextBox textFlashPassword;

	private Button buttonCancel;

	private Button buttonOk;

	private TextBox textPassword;

	private Label labelPassword;

	private Label label1;

	private TextBox textUsername;

	private LinkLabel linkDetectProxy;

	private LinkLabel linkPasswordProtected;

	internal FormProfile(Class19 class19_1)
	{
		InitializeComponent();
		if (class19_1 == null)
		{
			string_0 = "Новый персонаж";
			method_1(new Class19());
			return;
		}
		string_0 = class19_1.method_30();
		method_1(class19_1);
		textUsername.Text = class19_1.method_30();
		textPassword.Text = class19_1.method_32();
		textFlashPassword.Text = class19_1.method_36();
		checkAutoLogon.Checked = class19_1.method_38();
		checkUseProxy.Checked = class19_1.method_46();
		textProxyAddress.Text = class19_1.method_48();
		textProxyUsername.Text = class19_1.method_50();
		textProxyPassword.Text = class19_1.method_52();
		if (!string.IsNullOrEmpty(class19_1.method_44()))
		{
			bool_0 = true;
			linkPasswordProtected.Text = "Держать пароли открытыми (не рекомендуется)";
		}
		buttonOk.Text = "Сохранить";
		method_2();
	}

	internal Class19 method_0()
	{
		return class19_0;
	}

	private void method_1(Class19 class19_1)
	{
		class19_0 = class19_1;
	}

	private void FormProfile_Load(object sender, EventArgs e)
	{
		Text = string_0;
	}

	private void textUsername_TextChanged(object sender, EventArgs e)
	{
		method_2();
	}

	private void textPassword_TextChanged(object sender, EventArgs e)
	{
		method_2();
	}

	private void linkDetectProxy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Uri proxy = WebRequest.DefaultWebProxy.GetProxy(new Uri(Class68.string_8));
		if (Class68.string_8.Equals(proxy.OriginalString))
		{
			MessageBox.Show("Настройки прокси можно определить только если они явно прописаны в Internet Explorer", "Попытка определения прокси", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			checkUseProxy.Checked = false;
			textProxyAddress.Enabled = false;
			textProxyAddress.Text = string.Empty;
			textProxyUsername.Enabled = false;
			textProxyPassword.Enabled = false;
		}
		else
		{
			checkUseProxy.Checked = true;
			textProxyAddress.Enabled = true;
			textProxyAddress.Text = proxy.Authority;
			textProxyUsername.Enabled = true;
			textProxyPassword.Enabled = true;
		}
		textProxyUsername.Text = string.Empty;
		textProxyPassword.Text = string.Empty;
	}

	private void checkVisiblePasswords_CheckedChanged(object sender, EventArgs e)
	{
		bool useSystemPasswordChar = !checkVisiblePasswords.Checked;
		textPassword.UseSystemPasswordChar = useSystemPasswordChar;
		textFlashPassword.UseSystemPasswordChar = useSystemPasswordChar;
		textProxyPassword.UseSystemPasswordChar = useSystemPasswordChar;
	}

	private void checkUseProxy_CheckedChanged(object sender, EventArgs e)
	{
		bool enabled = checkUseProxy.Checked;
		textProxyAddress.Enabled = enabled;
		textProxyUsername.Enabled = enabled;
		textProxyPassword.Enabled = enabled;
		method_2();
	}

	private void textProxyAddress_TextChanged(object sender, EventArgs e)
	{
		method_2();
	}

	private void linkPasswordProtected_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		if (!bool_0)
		{
			FormNewPassword formNewPassword = new FormNewPassword();
			try
			{
				if (formNewPassword.ShowDialog() == DialogResult.OK)
				{
					method_0().method_33(textPassword.Text.Trim());
					method_0().method_37(textFlashPassword.Text.Trim());
					method_0().method_2(formNewPassword.method_0());
					bool_0 = true;
					linkPasswordProtected.Text = "Держать пароли открытыми (не рекомендуется)";
					checkAutoLogon.Enabled = false;
					checkAutoLogon.Checked = false;
				}
				return;
			}
			finally
			{
				((IDisposable)formNewPassword).Dispose();
			}
		}
		method_0().method_1(method_0().method_42());
		method_0().method_45(string.Empty);
		bool_0 = false;
		linkPasswordProtected.Text = "Зашифровать пароли (рекомендуется)";
		checkAutoLogon.Enabled = true;
		checkAutoLogon.Checked = false;
	}

	private void buttonOk_Click(object sender, EventArgs e)
	{
		method_0().method_31(textUsername.Text.Trim());
		method_0().method_33(textPassword.Text.Trim());
		method_0().method_37(textFlashPassword.Text.Trim());
		method_0().method_39(checkAutoLogon.Checked);
		method_0().method_47(checkUseProxy.Checked);
		method_0().method_49(textProxyAddress.Text.Trim());
		method_0().method_51(textProxyUsername.Text.Trim());
		method_0().method_53(textProxyPassword.Text.Trim());
	}

	private void method_2()
	{
		bool flag = !string.IsNullOrEmpty(textUsername.Text.Trim()) && !string.IsNullOrEmpty(textPassword.Text.Trim());
		linkPasswordProtected.Enabled = flag;
		checkAutoLogon.Enabled = flag && !bool_0;
		bool flag2 = !checkUseProxy.Checked || (checkUseProxy.Checked && !string.IsNullOrEmpty(textProxyAddress.Text.Trim()));
		buttonOk.Enabled = flag && flag2;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProfile));
		this.groupBox2 = new System.Windows.Forms.GroupBox();
		this.linkDetectProxy = new System.Windows.Forms.LinkLabel();
		this.textProxyPassword = new System.Windows.Forms.TextBox();
		this.label4 = new System.Windows.Forms.Label();
		this.textProxyUsername = new System.Windows.Forms.TextBox();
		this.label3 = new System.Windows.Forms.Label();
		this.textProxyAddress = new System.Windows.Forms.TextBox();
		this.label2 = new System.Windows.Forms.Label();
		this.checkUseProxy = new System.Windows.Forms.CheckBox();
		this.groupBox1 = new System.Windows.Forms.GroupBox();
		this.linkPasswordProtected = new System.Windows.Forms.LinkLabel();
		this.checkVisiblePasswords = new System.Windows.Forms.CheckBox();
		this.checkAutoLogon = new System.Windows.Forms.CheckBox();
		this.labelFlashPassword = new System.Windows.Forms.Label();
		this.textFlashPassword = new System.Windows.Forms.TextBox();
		this.buttonCancel = new System.Windows.Forms.Button();
		this.buttonOk = new System.Windows.Forms.Button();
		this.textPassword = new System.Windows.Forms.TextBox();
		this.labelPassword = new System.Windows.Forms.Label();
		this.label1 = new System.Windows.Forms.Label();
		this.textUsername = new System.Windows.Forms.TextBox();
		this.groupBox2.SuspendLayout();
		this.groupBox1.SuspendLayout();
		base.SuspendLayout();
		this.groupBox2.Controls.Add(this.linkDetectProxy);
		this.groupBox2.Controls.Add(this.textProxyPassword);
		this.groupBox2.Controls.Add(this.label4);
		this.groupBox2.Controls.Add(this.textProxyUsername);
		this.groupBox2.Controls.Add(this.label3);
		this.groupBox2.Controls.Add(this.textProxyAddress);
		this.groupBox2.Controls.Add(this.label2);
		this.groupBox2.Controls.Add(this.checkUseProxy);
		this.groupBox2.Location = new System.Drawing.Point(11, 196);
		this.groupBox2.Name = "groupBox2";
		this.groupBox2.Size = new System.Drawing.Size(280, 140);
		this.groupBox2.TabIndex = 19;
		this.groupBox2.TabStop = false;
		this.groupBox2.Text = "Настройки прокси";
		this.linkDetectProxy.AutoSize = true;
		this.linkDetectProxy.Location = new System.Drawing.Point(161, 21);
		this.linkDetectProxy.Name = "linkDetectProxy";
		this.linkDetectProxy.Size = new System.Drawing.Size(108, 13);
		this.linkDetectProxy.TabIndex = 10;
		this.linkDetectProxy.TabStop = true;
		this.linkDetectProxy.Text = "Определить прокси";
		this.linkDetectProxy.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkDetectProxy_LinkClicked);
		this.textProxyPassword.Enabled = false;
		this.textProxyPassword.Location = new System.Drawing.Point(155, 106);
		this.textProxyPassword.Name = "textProxyPassword";
		this.textProxyPassword.Size = new System.Drawing.Size(119, 21);
		this.textProxyPassword.TabIndex = 9;
		this.label4.AutoSize = true;
		this.label4.Location = new System.Drawing.Point(158, 89);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(44, 13);
		this.label4.TabIndex = 6;
		this.label4.Text = "Пароль";
		this.textProxyUsername.Enabled = false;
		this.textProxyUsername.Location = new System.Drawing.Point(7, 106);
		this.textProxyUsername.Name = "textProxyUsername";
		this.textProxyUsername.Size = new System.Drawing.Size(141, 21);
		this.textProxyUsername.TabIndex = 8;
		this.label3.AutoSize = true;
		this.label3.Location = new System.Drawing.Point(10, 89);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(97, 13);
		this.label3.TabIndex = 4;
		this.label3.Text = "Логин (если есть)";
		this.textProxyAddress.Enabled = false;
		this.textProxyAddress.Location = new System.Drawing.Point(7, 61);
		this.textProxyAddress.Name = "textProxyAddress";
		this.textProxyAddress.Size = new System.Drawing.Size(267, 21);
		this.textProxyAddress.TabIndex = 7;
		this.textProxyAddress.TextChanged += new System.EventHandler(textProxyAddress_TextChanged);
		this.label2.AutoSize = true;
		this.label2.Location = new System.Drawing.Point(10, 44);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(212, 13);
		this.label2.TabIndex = 1;
		this.label2.Text = "Адрес прокси (например, localhost:3128)";
		this.checkUseProxy.AutoSize = true;
		this.checkUseProxy.Location = new System.Drawing.Point(7, 20);
		this.checkUseProxy.Name = "checkUseProxy";
		this.checkUseProxy.Size = new System.Drawing.Size(132, 17);
		this.checkUseProxy.TabIndex = 6;
		this.checkUseProxy.Text = "Работа через прокси";
		this.checkUseProxy.UseVisualStyleBackColor = true;
		this.checkUseProxy.CheckedChanged += new System.EventHandler(checkUseProxy_CheckedChanged);
		this.groupBox1.Controls.Add(this.linkPasswordProtected);
		this.groupBox1.Controls.Add(this.checkVisiblePasswords);
		this.groupBox1.Controls.Add(this.checkAutoLogon);
		this.groupBox1.Location = new System.Drawing.Point(11, 97);
		this.groupBox1.Name = "groupBox1";
		this.groupBox1.Size = new System.Drawing.Size(280, 91);
		this.groupBox1.TabIndex = 18;
		this.groupBox1.TabStop = false;
		this.groupBox1.Text = "Настройки паролей";
		this.linkPasswordProtected.AutoSize = true;
		this.linkPasswordProtected.Enabled = false;
		this.linkPasswordProtected.Location = new System.Drawing.Point(7, 21);
		this.linkPasswordProtected.Name = "linkPasswordProtected";
		this.linkPasswordProtected.Size = new System.Drawing.Size(205, 13);
		this.linkPasswordProtected.TabIndex = 6;
		this.linkPasswordProtected.TabStop = true;
		this.linkPasswordProtected.Text = "Зашифровать пароли (рекомендуется)";
		this.linkPasswordProtected.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkPasswordProtected_LinkClicked);
		this.checkVisiblePasswords.AutoSize = true;
		this.checkVisiblePasswords.Location = new System.Drawing.Point(7, 68);
		this.checkVisiblePasswords.Name = "checkVisiblePasswords";
		this.checkVisiblePasswords.Size = new System.Drawing.Size(110, 17);
		this.checkVisiblePasswords.TabIndex = 5;
		this.checkVisiblePasswords.Text = "Видимые пароли";
		this.checkVisiblePasswords.UseVisualStyleBackColor = true;
		this.checkVisiblePasswords.CheckedChanged += new System.EventHandler(checkVisiblePasswords_CheckedChanged);
		this.checkAutoLogon.AutoSize = true;
		this.checkAutoLogon.Enabled = false;
		this.checkAutoLogon.Location = new System.Drawing.Point(7, 45);
		this.checkAutoLogon.Name = "checkAutoLogon";
		this.checkAutoLogon.Size = new System.Drawing.Size(262, 17);
		this.checkAutoLogon.TabIndex = 4;
		this.checkAutoLogon.Text = "Автовход в игру (если пароли не шифрованы)";
		this.checkAutoLogon.UseVisualStyleBackColor = true;
		this.labelFlashPassword.AutoSize = true;
		this.labelFlashPassword.Location = new System.Drawing.Point(11, 70);
		this.labelFlashPassword.Name = "labelFlashPassword";
		this.labelFlashPassword.Size = new System.Drawing.Size(79, 13);
		this.labelFlashPassword.TabIndex = 17;
		this.labelFlashPassword.Text = "Флеш-пароль:";
		this.textFlashPassword.Location = new System.Drawing.Point(149, 67);
		this.textFlashPassword.Name = "textFlashPassword";
		this.textFlashPassword.Size = new System.Drawing.Size(142, 21);
		this.textFlashPassword.TabIndex = 2;
		this.textFlashPassword.UseSystemPasswordChar = true;
		this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
		this.buttonCancel.Location = new System.Drawing.Point(216, 346);
		this.buttonCancel.Name = "buttonCancel";
		this.buttonCancel.Size = new System.Drawing.Size(75, 23);
		this.buttonCancel.TabIndex = 11;
		this.buttonCancel.Text = "Отмена";
		this.buttonCancel.UseVisualStyleBackColor = true;
		this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
		this.buttonOk.Enabled = false;
		this.buttonOk.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
		this.buttonOk.Location = new System.Drawing.Point(11, 346);
		this.buttonOk.Name = "buttonOk";
		this.buttonOk.Size = new System.Drawing.Size(199, 23);
		this.buttonOk.TabIndex = 10;
		this.buttonOk.Text = "Вход в игру";
		this.buttonOk.UseVisualStyleBackColor = true;
		this.buttonOk.Click += new System.EventHandler(buttonOk_Click);
		this.textPassword.Location = new System.Drawing.Point(149, 39);
		this.textPassword.Name = "textPassword";
		this.textPassword.Size = new System.Drawing.Size(142, 21);
		this.textPassword.TabIndex = 1;
		this.textPassword.UseSystemPasswordChar = true;
		this.textPassword.TextChanged += new System.EventHandler(textPassword_TextChanged);
		this.labelPassword.AutoSize = true;
		this.labelPassword.Location = new System.Drawing.Point(11, 42);
		this.labelPassword.Name = "labelPassword";
		this.labelPassword.Size = new System.Drawing.Size(92, 13);
		this.labelPassword.TabIndex = 16;
		this.labelPassword.Text = "Игровой пароль:";
		this.label1.AutoSize = true;
		this.label1.Location = new System.Drawing.Point(11, 15);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(88, 13);
		this.label1.TabIndex = 14;
		this.label1.Text = "Ник персонажа:";
		this.textUsername.Location = new System.Drawing.Point(149, 12);
		this.textUsername.Name = "textUsername";
		this.textUsername.Size = new System.Drawing.Size(142, 21);
		this.textUsername.TabIndex = 0;
		this.textUsername.TextChanged += new System.EventHandler(textUsername_TextChanged);
		base.AcceptButton = this.buttonOk;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.CancelButton = this.buttonCancel;
		base.ClientSize = new System.Drawing.Size(306, 379);
		base.Controls.Add(this.textUsername);
		base.Controls.Add(this.groupBox2);
		base.Controls.Add(this.groupBox1);
		base.Controls.Add(this.labelFlashPassword);
		base.Controls.Add(this.textFlashPassword);
		base.Controls.Add(this.buttonCancel);
		base.Controls.Add(this.buttonOk);
		base.Controls.Add(this.textPassword);
		base.Controls.Add(this.labelPassword);
		base.Controls.Add(this.label1);
		this.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "FormProfile";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Создание нового профиля";
		base.Load += new System.EventHandler(FormProfile_Load);
		this.groupBox2.ResumeLayout(false);
		this.groupBox2.PerformLayout();
		this.groupBox1.ResumeLayout(false);
		this.groupBox1.PerformLayout();
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
