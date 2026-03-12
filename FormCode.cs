using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

internal sealed class FormCode : Form
{
	private IContainer icontainer_0;

	private Button btnRefresh;

	private Button btnMaximize;

	private Button btnEnter;

	private TextBox textCode;

	private PictureBox pictureBox;

	public FormCode()
	{
		InitializeComponent();
		method_1();
	}

	internal string method_0()
	{
		return textCode.Text;
	}

	private void btnRefresh_Click(object sender, EventArgs e)
	{
		method_1();
	}

	private void method_1()
	{
		if (Class72.smethod_24() == null)
		{
			return;
		}
		MemoryStream memoryStream = new MemoryStream(Class72.smethod_24());
		try
		{
			pictureBox.Image = Image.FromStream(memoryStream);
		}
		finally
		{
			((IDisposable)memoryStream).Dispose();
		}
	}

	private void btnMaximize_Click(object sender, EventArgs e)
	{
		base.DialogResult = DialogResult.Yes;
		Close();
	}

	private void btnEnter_Click(object sender, EventArgs e)
	{
		base.DialogResult = DialogResult.OK;
		Close();
	}

	private void FormCode_Load(object sender, EventArgs e)
	{
		Activate();
	}

	private void textCode_TextChanged(object sender, EventArgs e)
	{
		if (int.TryParse(textCode.Text, out var result))
		{
			if (result >= 0 && result <= 99999)
			{
				btnEnter.Enabled = true;
			}
			else
			{
				btnEnter.Enabled = false;
			}
		}
		else
		{
			btnEnter.Enabled = false;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCode));
		this.btnRefresh = new System.Windows.Forms.Button();
		this.btnMaximize = new System.Windows.Forms.Button();
		this.btnEnter = new System.Windows.Forms.Button();
		this.textCode = new System.Windows.Forms.TextBox();
		this.pictureBox = new System.Windows.Forms.PictureBox();
		((System.ComponentModel.ISupportInitialize)this.pictureBox).BeginInit();
		base.SuspendLayout();
		this.btnRefresh.AutoSize = true;
		this.btnRefresh.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		this.btnRefresh.FlatAppearance.BorderSize = 0;
		this.btnRefresh.Image = Class39.smethod_30();
		this.btnRefresh.Location = new System.Drawing.Point(7, 83);
		this.btnRefresh.Name = "btnRefresh";
		this.btnRefresh.Size = new System.Drawing.Size(22, 22);
		this.btnRefresh.TabIndex = 3;
		this.btnRefresh.UseVisualStyleBackColor = true;
		this.btnRefresh.Click += new System.EventHandler(btnRefresh_Click);
		this.btnMaximize.AutoSize = true;
		this.btnMaximize.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		this.btnMaximize.Image = Class39.smethod_22();
		this.btnMaximize.Location = new System.Drawing.Point(119, 83);
		this.btnMaximize.Name = "btnMaximize";
		this.btnMaximize.Size = new System.Drawing.Size(22, 22);
		this.btnMaximize.TabIndex = 2;
		this.btnMaximize.UseVisualStyleBackColor = true;
		this.btnMaximize.Click += new System.EventHandler(btnMaximize_Click);
		this.btnEnter.AutoSize = true;
		this.btnEnter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		this.btnEnter.DialogResult = System.Windows.Forms.DialogResult.OK;
		this.btnEnter.Enabled = false;
		this.btnEnter.Image = Class39.smethod_36();
		this.btnEnter.Location = new System.Drawing.Point(88, 83);
		this.btnEnter.Name = "btnEnter";
		this.btnEnter.Size = new System.Drawing.Size(22, 22);
		this.btnEnter.TabIndex = 1;
		this.btnEnter.UseVisualStyleBackColor = true;
		this.btnEnter.Click += new System.EventHandler(btnEnter_Click);
		this.textCode.Location = new System.Drawing.Point(36, 84);
		this.textCode.Name = "textCode";
		this.textCode.Size = new System.Drawing.Size(46, 22);
		this.textCode.TabIndex = 0;
		this.textCode.TextChanged += new System.EventHandler(textCode_TextChanged);
		this.pictureBox.Location = new System.Drawing.Point(7, 13);
		this.pictureBox.Name = "pictureBox";
		this.pictureBox.Size = new System.Drawing.Size(134, 60);
		this.pictureBox.TabIndex = 4;
		this.pictureBox.TabStop = false;
		base.AcceptButton = this.btnEnter;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 14f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.AutoSize = true;
		base.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		base.ClientSize = new System.Drawing.Size(149, 111);
		base.Controls.Add(this.pictureBox);
		base.Controls.Add(this.textCode);
		base.Controls.Add(this.btnEnter);
		base.Controls.Add(this.btnMaximize);
		base.Controls.Add(this.btnRefresh);
		this.Font = new System.Drawing.Font("Tahoma", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "FormCode";
		base.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
		this.Text = "Ручной ввод кода";
		base.TopMost = true;
		base.Load += new System.EventHandler(FormCode_Load);
		((System.ComponentModel.ISupportInitialize)this.pictureBox).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
