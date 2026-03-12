using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

internal sealed class FormNewTab : Form
{
	private IContainer icontainer_0;

	private TextBox textAddress;

	private GroupBox groupBox1;

	private Button buttonOk;

	private Button buttonCancel;

	private RadioButton radioPInfo;

	private RadioButton radioForum;

	private RadioButton radioFightLog;

	private RadioButton radioUrl;

	private Label label;

	public FormNewTab()
	{
		InitializeComponent();
	}

	public string method_0()
	{
		string text = textAddress.Text;
		if (Uri.TryCreate(text, UriKind.Absolute, out var _))
		{
			return text;
		}
		if (radioPInfo.Checked)
		{
			return smethod_0(Class39.smethod_45(), text);
		}
		if (radioFightLog.Checked)
		{
			return smethod_0(Class39.smethod_38(), text);
		}
		if (radioForum.Checked)
		{
			return smethod_0(Class39.smethod_39(), text);
		}
		if (radioUrl.Checked)
		{
			return smethod_0("http://", text);
		}
		return text;
	}

	private static string smethod_0(string string_0, string string_1)
	{
		string_1 = string_0 + string_1;
		if (!Uri.TryCreate(string_1, UriKind.Absolute, out var _))
		{
			return null;
		}
		return string_1;
	}

	private void FormNewTab_Load(object sender, EventArgs e)
	{
		if (Clipboard.ContainsText(TextDataFormat.Text))
		{
			textAddress.Text = Clipboard.GetText(TextDataFormat.Text);
		}
	}

	private void textAddress_TextChanged(object sender, EventArgs e)
	{
		string text = textAddress.Text;
		Uri result;
		long result2;
		if (text.StartsWith(Class39.smethod_45()) && text.Length > Class39.smethod_45().Length)
		{
			radioPInfo.Checked = true;
			buttonOk.Enabled = true;
		}
		else if (text.StartsWith(Class39.smethod_46()) && text.Length > Class39.smethod_46().Length)
		{
			radioPInfo.Checked = true;
			buttonOk.Enabled = true;
		}
		else if (text.StartsWith(Class39.smethod_44()) && text.Length > Class39.smethod_44().Length)
		{
			radioPInfo.Checked = true;
			buttonOk.Enabled = true;
		}
		else if (text.StartsWith(Class39.smethod_38()) && text.Length > Class39.smethod_38().Length)
		{
			radioFightLog.Checked = true;
			buttonOk.Enabled = true;
		}
		else if (text.StartsWith(Class39.smethod_39()) && text.Length >= Class39.smethod_39().Length)
		{
			radioForum.Checked = true;
			buttonOk.Enabled = true;
		}
		else if (Uri.TryCreate(text, UriKind.Absolute, out result))
		{
			radioUrl.Checked = true;
			buttonOk.Enabled = true;
		}
		else if (long.TryParse(text, out result2))
		{
			radioFightLog.Checked = true;
			buttonOk.Enabled = true;
		}
		else if (!string.IsNullOrEmpty(text) && text.IndexOf(' ') == -1 && text.IndexOf('.') != -1)
		{
			radioUrl.Checked = true;
			buttonOk.Enabled = true;
		}
		else if (!string.IsNullOrEmpty(text) && text.IndexOf("  ", StringComparison.Ordinal) == -1 && text.Length < 40)
		{
			radioPInfo.Checked = true;
			buttonOk.Enabled = true;
		}
		else
		{
			buttonOk.Enabled = false;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNewTab));
		this.textAddress = new System.Windows.Forms.TextBox();
		this.groupBox1 = new System.Windows.Forms.GroupBox();
		this.radioUrl = new System.Windows.Forms.RadioButton();
		this.radioForum = new System.Windows.Forms.RadioButton();
		this.radioFightLog = new System.Windows.Forms.RadioButton();
		this.radioPInfo = new System.Windows.Forms.RadioButton();
		this.buttonOk = new System.Windows.Forms.Button();
		this.buttonCancel = new System.Windows.Forms.Button();
		this.label = new System.Windows.Forms.Label();
		this.groupBox1.SuspendLayout();
		base.SuspendLayout();
		this.textAddress.Location = new System.Drawing.Point(12, 24);
		this.textAddress.Name = "textAddress";
		this.textAddress.Size = new System.Drawing.Size(524, 21);
		this.textAddress.TabIndex = 0;
		this.textAddress.TextChanged += new System.EventHandler(textAddress_TextChanged);
		this.groupBox1.Controls.Add(this.radioUrl);
		this.groupBox1.Controls.Add(this.radioForum);
		this.groupBox1.Controls.Add(this.radioFightLog);
		this.groupBox1.Controls.Add(this.radioPInfo);
		this.groupBox1.Location = new System.Drawing.Point(12, 51);
		this.groupBox1.Name = "groupBox1";
		this.groupBox1.Size = new System.Drawing.Size(161, 106);
		this.groupBox1.TabIndex = 4;
		this.groupBox1.TabStop = false;
		this.groupBox1.Text = "Считать ссылку...";
		this.radioUrl.AutoSize = true;
		this.radioUrl.Location = new System.Drawing.Point(6, 80);
		this.radioUrl.Name = "radioUrl";
		this.radioUrl.Size = new System.Drawing.Size(60, 17);
		this.radioUrl.TabIndex = 4;
		this.radioUrl.TabStop = true;
		this.radioUrl.Text = "сайтом";
		this.radioUrl.UseVisualStyleBackColor = true;
		this.radioForum.AutoSize = true;
		this.radioForum.Location = new System.Drawing.Point(6, 60);
		this.radioForum.Name = "radioForum";
		this.radioForum.Size = new System.Drawing.Size(69, 17);
		this.radioForum.TabIndex = 3;
		this.radioForum.TabStop = true;
		this.radioForum.Text = "форумом";
		this.radioForum.UseVisualStyleBackColor = true;
		this.radioFightLog.AutoSize = true;
		this.radioFightLog.Location = new System.Drawing.Point(6, 40);
		this.radioFightLog.Name = "radioFightLog";
		this.radioFightLog.Size = new System.Drawing.Size(75, 17);
		this.radioFightLog.TabIndex = 2;
		this.radioFightLog.TabStop = true;
		this.radioFightLog.Text = "логом боя";
		this.radioFightLog.UseVisualStyleBackColor = true;
		this.radioPInfo.AutoSize = true;
		this.radioPInfo.Location = new System.Drawing.Point(6, 20);
		this.radioPInfo.Name = "radioPInfo";
		this.radioPInfo.Size = new System.Drawing.Size(89, 17);
		this.radioPInfo.TabIndex = 1;
		this.radioPInfo.TabStop = true;
		this.radioPInfo.Text = "инфой перса";
		this.radioPInfo.UseVisualStyleBackColor = true;
		this.buttonOk.AutoSize = true;
		this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
		this.buttonOk.Enabled = false;
		this.buttonOk.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
		this.buttonOk.Location = new System.Drawing.Point(300, 181);
		this.buttonOk.Name = "buttonOk";
		this.buttonOk.Size = new System.Drawing.Size(137, 23);
		this.buttonOk.TabIndex = 1007;
		this.buttonOk.Text = "Ввод";
		this.buttonOk.UseVisualStyleBackColor = true;
		this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
		this.buttonCancel.Location = new System.Drawing.Point(443, 181);
		this.buttonCancel.Name = "buttonCancel";
		this.buttonCancel.Size = new System.Drawing.Size(85, 23);
		this.buttonCancel.TabIndex = 1008;
		this.buttonCancel.Text = "Отмена";
		this.buttonCancel.UseVisualStyleBackColor = true;
		this.label.AutoSize = true;
		this.label.Location = new System.Drawing.Point(15, 7);
		this.label.Name = "label";
		this.label.Size = new System.Drawing.Size(89, 13);
		this.label.TabIndex = 1010;
		this.label.Text = "Введите ссылку";
		base.AcceptButton = this.buttonOk;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.CancelButton = this.buttonCancel;
		base.ClientSize = new System.Drawing.Size(548, 209);
		base.Controls.Add(this.label);
		base.Controls.Add(this.buttonOk);
		base.Controls.Add(this.buttonCancel);
		base.Controls.Add(this.groupBox1);
		base.Controls.Add(this.textAddress);
		this.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.Name = "FormNewTab";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Открыть новую вкладку";
		base.Load += new System.EventHandler(FormNewTab_Load);
		this.groupBox1.ResumeLayout(false);
		this.groupBox1.PerformLayout();
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
