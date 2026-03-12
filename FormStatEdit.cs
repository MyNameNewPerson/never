using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

internal sealed class FormStatEdit : Form
{
	private IContainer icontainer_0;

	private Button buttonReset;

	private Button buttonContinue;

	private TextBox textBox;

	internal FormStatEdit(string string_0)
	{
		InitializeComponent();
		textBox.Text = string_0;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStatEdit));
		this.buttonReset = new System.Windows.Forms.Button();
		this.buttonContinue = new System.Windows.Forms.Button();
		this.textBox = new System.Windows.Forms.TextBox();
		base.SuspendLayout();
		this.buttonReset.AutoSize = true;
		this.buttonReset.DialogResult = System.Windows.Forms.DialogResult.OK;
		this.buttonReset.Location = new System.Drawing.Point(108, 206);
		this.buttonReset.Name = "buttonReset";
		this.buttonReset.Size = new System.Drawing.Size(125, 23);
		this.buttonReset.TabIndex = 1007;
		this.buttonReset.Text = "Сброс статистики";
		this.buttonReset.UseVisualStyleBackColor = true;
		this.buttonContinue.DialogResult = System.Windows.Forms.DialogResult.Cancel;
		this.buttonContinue.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
		this.buttonContinue.Location = new System.Drawing.Point(239, 206);
		this.buttonContinue.Name = "buttonContinue";
		this.buttonContinue.Size = new System.Drawing.Size(107, 23);
		this.buttonContinue.TabIndex = 1008;
		this.buttonContinue.Text = "Продолжить";
		this.buttonContinue.UseVisualStyleBackColor = true;
		this.textBox.Location = new System.Drawing.Point(13, 12);
		this.textBox.Multiline = true;
		this.textBox.Name = "textBox";
		this.textBox.ReadOnly = true;
		this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
		this.textBox.Size = new System.Drawing.Size(333, 179);
		this.textBox.TabIndex = 1011;
		base.AcceptButton = this.buttonReset;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.CancelButton = this.buttonContinue;
		base.ClientSize = new System.Drawing.Size(358, 237);
		base.Controls.Add(this.textBox);
		base.Controls.Add(this.buttonReset);
		base.Controls.Add(this.buttonContinue);
		this.DoubleBuffered = true;
		this.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "FormStatEdit";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Статистика";
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
