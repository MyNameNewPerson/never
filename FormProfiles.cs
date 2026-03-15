using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

internal sealed class FormProfiles : Form
{
	private Class19 class19_0;

	private IContainer icontainer_0;

	private GroupBox groupBox1;

	private Button buttonCancel;

	private Button buttonOk;

	private ComboBox comboConfigs;

	private LinkLabel linkEdit;

	private LinkLabel linkCreateNewProfile;

	private Label labelLastLogOn;

	internal FormProfiles(Class19[] class19_1)
	{
		if (class19_1 == null || class19_1.Length == 0)
		{
			throw new ArgumentNullException("arrayConfig");
		}
		InitializeComponent();
		comboConfigs.Items.AddRange(class19_1);
		comboConfigs.SelectedIndex = 0;
	}

	internal Class19 method_0()
	{
		return class19_0;
	}

	private void method_1(Class19 class19_1)
	{
		class19_0 = class19_1;
	}

	private void comboConfigs_SelectedIndexChanged(object sender, EventArgs e)
	{
		method_1((Class19)comboConfigs.Items[comboConfigs.SelectedIndex]);
		labelLastLogOn.Text = "Последний вход в игру: " + method_0().method_3();
	}

	private void linkCreateNewProfile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Class19 @class = Class14.smethod_1();
		if (@class != null)
		{
			method_1(@class);
			base.DialogResult = DialogResult.OK;
			Close();
		}
	}

	private void linkEdit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Class19 @class = Class14.smethod_3(method_0());
		if (@class != null)
		{
			comboConfigs.Items[comboConfigs.SelectedIndex] = @class;
			comboConfigs.Refresh();
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProfiles));
		this.groupBox1 = new System.Windows.Forms.GroupBox();
		this.labelLastLogOn = new System.Windows.Forms.Label();
		this.linkEdit = new System.Windows.Forms.LinkLabel();
		this.comboConfigs = new System.Windows.Forms.ComboBox();
		this.buttonCancel = new System.Windows.Forms.Button();
		this.buttonOk = new System.Windows.Forms.Button();
		this.linkCreateNewProfile = new System.Windows.Forms.LinkLabel();
		this.groupBox1.SuspendLayout();
		base.SuspendLayout();
		this.groupBox1.Controls.Add(this.labelLastLogOn);
		this.groupBox1.Controls.Add(this.linkEdit);
		this.groupBox1.Controls.Add(this.comboConfigs);
		this.groupBox1.Location = new System.Drawing.Point(13, 13);
		this.groupBox1.Name = "groupBox1";
		this.groupBox1.Size = new System.Drawing.Size(321, 77);
		this.groupBox1.TabIndex = 0;
		this.groupBox1.TabStop = false;
		this.groupBox1.Text = "Выберите профиль";
		this.labelLastLogOn.AutoSize = true;
		this.labelLastLogOn.Location = new System.Drawing.Point(7, 49);
		this.labelLastLogOn.Name = "labelLastLogOn";
		this.labelLastLogOn.Size = new System.Drawing.Size(129, 13);
		this.labelLastLogOn.TabIndex = 2;
		this.labelLastLogOn.Text = "Последний вход в игру:";
		this.linkEdit.AutoSize = true;
		this.linkEdit.Location = new System.Drawing.Point(251, 24);
		this.linkEdit.Name = "linkEdit";
		this.linkEdit.Size = new System.Drawing.Size(64, 13);
		this.linkEdit.TabIndex = 1;
		this.linkEdit.TabStop = true;
		this.linkEdit.Text = "Параметры";
		this.linkEdit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkEdit_LinkClicked);
		this.comboConfigs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.comboConfigs.FormattingEnabled = true;
		this.comboConfigs.Location = new System.Drawing.Point(7, 21);
		this.comboConfigs.Name = "comboConfigs";
		this.comboConfigs.Size = new System.Drawing.Size(238, 21);
		this.comboConfigs.TabIndex = 0;
		this.comboConfigs.SelectedIndexChanged += new System.EventHandler(comboConfigs_SelectedIndexChanged);
		this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
		this.buttonCancel.Location = new System.Drawing.Point(259, 129);
		this.buttonCancel.Name = "buttonCancel";
		this.buttonCancel.Size = new System.Drawing.Size(75, 23);
		this.buttonCancel.TabIndex = 13;
		this.buttonCancel.Text = "Отмена";
		this.buttonCancel.UseVisualStyleBackColor = true;
		this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
		this.buttonOk.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
		this.buttonOk.Location = new System.Drawing.Point(12, 129);
		this.buttonOk.Name = "buttonOk";
		this.buttonOk.Size = new System.Drawing.Size(241, 23);
		this.buttonOk.TabIndex = 12;
		this.buttonOk.Text = "Вход в игру";
		this.buttonOk.UseVisualStyleBackColor = true;
		this.linkCreateNewProfile.AutoSize = true;
		this.linkCreateNewProfile.Location = new System.Drawing.Point(197, 103);
		this.linkCreateNewProfile.Name = "linkCreateNewProfile";
		this.linkCreateNewProfile.Size = new System.Drawing.Size(132, 13);
		this.linkCreateNewProfile.TabIndex = 14;
		this.linkCreateNewProfile.TabStop = true;
		this.linkCreateNewProfile.Text = "Создать новый профиль";
		this.linkCreateNewProfile.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkCreateNewProfile_LinkClicked);
		base.AcceptButton = this.buttonOk;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.CancelButton = this.buttonCancel;
		base.ClientSize = new System.Drawing.Size(346, 167);
		base.Controls.Add(this.linkCreateNewProfile);
		base.Controls.Add(this.buttonCancel);
		base.Controls.Add(this.buttonOk);
		base.Controls.Add(this.groupBox1);
		this.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.Name = "FormProfiles";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Вход в игру";
		this.groupBox1.ResumeLayout(false);
		this.groupBox1.PerformLayout();
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
