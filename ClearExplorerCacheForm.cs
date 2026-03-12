using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

internal sealed class ClearExplorerCacheForm : Form
{
	private bool bool_0;

	private Label labelText;

	private IContainer icontainer_0;

	private Button buttonCancel;

	internal ClearExplorerCacheForm()
	{
		InitializeComponent();
		method_1(bool_1: true);
	}

	internal bool method_0()
	{
		return bool_0;
	}

	private void method_1(bool bool_1)
	{
		bool_0 = bool_1;
	}

	internal void method_2()
	{
		Close();
	}

	internal void method_3(string string_0)
	{
		labelText.Text = string_0;
	}

	private void buttonCancel_Click(object sender, EventArgs e)
	{
		method_1(bool_1: false);
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClearExplorerCacheForm));
		this.labelText = new System.Windows.Forms.Label();
		this.buttonCancel = new System.Windows.Forms.Button();
		base.SuspendLayout();
		this.labelText.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
		this.labelText.Location = new System.Drawing.Point(12, 11);
		this.labelText.Name = "labelText";
		this.labelText.Size = new System.Drawing.Size(370, 23);
		this.labelText.TabIndex = 0;
		this.labelText.Text = "Очистка...";
		this.labelText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
		this.buttonCancel.Location = new System.Drawing.Point(147, 41);
		this.buttonCancel.Name = "buttonCancel";
		this.buttonCancel.Size = new System.Drawing.Size(101, 23);
		this.buttonCancel.TabIndex = 3;
		this.buttonCancel.Text = "Пропустить";
		this.buttonCancel.UseVisualStyleBackColor = true;
		this.buttonCancel.Click += new System.EventHandler(buttonCancel_Click);
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.CancelButton = this.buttonCancel;
		base.ClientSize = new System.Drawing.Size(395, 75);
		base.ControlBox = false;
		base.Controls.Add(this.buttonCancel);
		base.Controls.Add(this.labelText);
		this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
		this.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.Name = "ClearExplorerCacheForm";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Удаление скриптов игры из кеша IE";
		base.ResumeLayout(false);
	}
}
