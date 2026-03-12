using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

internal sealed class FormEnterInt : Form
{
	private readonly string string_0;

	private int int_0;

	private readonly int int_1;

	private readonly int int_2;

	private IContainer icontainer_0;

	private Button buttonOk;

	private Button buttonCancel;

	private Label labelDescription;

	private TextBox textBox;

	private ErrorProvider errorProvider_0;

	public FormEnterInt(string string_1, int int_3, int int_4, int int_5)
	{
		InitializeComponent();
		base.Left = Control.MousePosition.X;
		base.Top = Control.MousePosition.Y;
		string_0 = string_1;
		int_0 = int_3;
		int_1 = int_4;
		int_2 = int_5;
		labelDescription.Text = "Введите значение от " + int_1 + " до " + int_2;
		textBox.Text = int_0.ToString(CultureInfo.InvariantCulture);
	}

	public int method_0()
	{
		return int_0;
	}

	private void FormEnterInt_Load(object sender, EventArgs e)
	{
		Text = string_0;
	}

	private void textBox_Validating(object sender, CancelEventArgs e)
	{
		if (!method_1(textBox.Text, out var string_))
		{
			e.Cancel = true;
			textBox.Select(0, textBox.Text.Length);
			errorProvider_0.SetError(textBox, string_);
		}
	}

	private void textBox_Validated(object sender, EventArgs e)
	{
		errorProvider_0.SetError(textBox, string.Empty);
	}

	private bool method_1(string string_1, out string string_2)
	{
		if (string_1.Length == 0)
		{
			string_2 = "Значение не должно быть пустым";
			return false;
		}
		if (!int.TryParse(string_1.Trim(), out int_0))
		{
			string_2 = "Значение должно быть целым числом";
			return false;
		}
		if (int_0 < int_1)
		{
			string_2 = "Значение должно быть больше " + int_1;
			return false;
		}
		if (int_0 > int_2)
		{
			string_2 = "Значение должно быть меньше " + int_2;
			return false;
		}
		string_2 = string.Empty;
		return true;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEnterInt));
		this.buttonOk = new System.Windows.Forms.Button();
		this.buttonCancel = new System.Windows.Forms.Button();
		this.labelDescription = new System.Windows.Forms.Label();
		this.textBox = new System.Windows.Forms.TextBox();
		this.errorProvider_0 = new System.Windows.Forms.ErrorProvider(this.icontainer_0);
		((System.ComponentModel.ISupportInitialize)this.errorProvider_0).BeginInit();
		base.SuspendLayout();
		this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
		this.buttonOk.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
		this.buttonOk.Location = new System.Drawing.Point(12, 57);
		this.buttonOk.Name = "buttonOk";
		this.buttonOk.Size = new System.Drawing.Size(99, 23);
		this.buttonOk.TabIndex = 1001;
		this.buttonOk.Text = "Ввод";
		this.buttonOk.UseVisualStyleBackColor = true;
		this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
		this.buttonCancel.Location = new System.Drawing.Point(117, 57);
		this.buttonCancel.Name = "buttonCancel";
		this.buttonCancel.Size = new System.Drawing.Size(81, 23);
		this.buttonCancel.TabIndex = 1002;
		this.buttonCancel.Text = "Отмена";
		this.buttonCancel.UseVisualStyleBackColor = true;
		this.labelDescription.AutoSize = true;
		this.labelDescription.Location = new System.Drawing.Point(13, 13);
		this.labelDescription.Name = "labelDescription";
		this.labelDescription.Size = new System.Drawing.Size(35, 13);
		this.labelDescription.TabIndex = 1004;
		this.labelDescription.Text = "label2";
		this.textBox.Location = new System.Drawing.Point(12, 30);
		this.textBox.Name = "textBox";
		this.textBox.Size = new System.Drawing.Size(186, 21);
		this.textBox.TabIndex = 1005;
		this.textBox.Validating += new System.ComponentModel.CancelEventHandler(textBox_Validating);
		this.textBox.Validated += new System.EventHandler(textBox_Validated);
		this.errorProvider_0.ContainerControl = this;
		base.AcceptButton = this.buttonOk;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.CancelButton = this.buttonCancel;
		base.ClientSize = new System.Drawing.Size(210, 88);
		base.Controls.Add(this.textBox);
		base.Controls.Add(this.labelDescription);
		base.Controls.Add(this.buttonOk);
		base.Controls.Add(this.buttonCancel);
		this.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "FormEnterInt";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		base.Load += new System.EventHandler(FormEnterInt_Load);
		((System.ComponentModel.ISupportInitialize)this.errorProvider_0).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
