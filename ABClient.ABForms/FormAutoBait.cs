using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ABClient.ABForms;

public class FormAutoBait : Form
{
	private IContainer icontainer_0;

	private Label label1;

	private TextBox textBoxNum;

	private Button buttonUse;

	public FormAutoBait()
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ABClient.ABForms.FormAutoBait));
		this.label1 = new System.Windows.Forms.Label();
		this.textBoxNum = new System.Windows.Forms.TextBox();
		this.buttonUse = new System.Windows.Forms.Button();
		base.SuspendLayout();
		this.label1.AutoSize = true;
		this.label1.Location = new System.Drawing.Point(12, 18);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(191, 13);
		this.label1.TabIndex = 0;
		this.label1.Text = "Введите количество использований";
		this.textBoxNum.Location = new System.Drawing.Point(209, 15);
		this.textBoxNum.Name = "textBoxNum";
		this.textBoxNum.Size = new System.Drawing.Size(49, 20);
		this.textBoxNum.TabIndex = 1;
		this.textBoxNum.Text = "9999";
		this.buttonUse.Location = new System.Drawing.Point(58, 51);
		this.buttonUse.Name = "buttonUse";
		this.buttonUse.Size = new System.Drawing.Size(162, 23);
		this.buttonUse.TabIndex = 2;
		this.buttonUse.Text = "Запустить приманки!";
		this.buttonUse.UseVisualStyleBackColor = true;
		base.AcceptButton = this.buttonUse;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(272, 86);
		base.Controls.Add(this.buttonUse);
		base.Controls.Add(this.textBoxNum);
		base.Controls.Add(this.label1);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "FormAutoBait";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Автоприманка ботов";
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
