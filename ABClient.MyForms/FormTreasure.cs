using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ABClient.MyForms;

public class FormTreasure : Form
{
	private IContainer icontainer_0;

	private CheckBox checkBoxAutoDigging;

	private CheckBox checkBox2;

	private CheckBox checkBox3;

	private CheckBox checkBox4;

	private GroupBox groupBox1;

	private Button buttonGo;

	private Button buttonCancel;

	private ComboBox comboBox1;

	private Label label1;

	public FormTreasure()
	{
		InitializeComponent();
		string[] array = Class72.class19_0.method_184().Split('|');
		if (array.Length != 0)
		{
			ComboBox.ObjectCollection items = comboBox1.Items;
			object[] items2 = array;
			items.AddRange(items2);
		}
		else
		{
			comboBox1.Enabled = false;
		}
	}

	private void buttonGo_Click(object sender, EventArgs e)
	{
		Class72.bool_48 = checkBoxAutoDigging.Checked;
		try
		{
			Class72.string_48 = comboBox1.SelectedItem.ToString();
		}
		catch
		{
			Class72.string_48 = string.Empty;
		}
		if (checkBoxAutoDigging.Checked)
		{
			if (!checkBox2.Checked && !checkBox3.Checked && !checkBox4.Checked)
			{
				Class72.formMain_0.method_63("Ни одной лопаты не выбрано. Автокопание кладов не запущено.");
				Class72.bool_48 = false;
			}
			Class72.bool_50[0] = checkBox2.Checked;
			Class72.bool_50[1] = checkBox3.Checked;
			Class72.bool_50[2] = checkBox4.Checked;
		}
		Class72.formMain_0.method_41();
		Class72.formMain_0.BeginInvoke(new Delegate20(Class72.formMain_0.method_110), new object[0]);
		Close();
	}

	private void buttonCancel_Click(object sender, EventArgs e)
	{
		Class72.formMain_0.method_40();
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ABClient.MyForms.FormTreasure));
		this.checkBoxAutoDigging = new System.Windows.Forms.CheckBox();
		this.checkBox2 = new System.Windows.Forms.CheckBox();
		this.checkBox3 = new System.Windows.Forms.CheckBox();
		this.checkBox4 = new System.Windows.Forms.CheckBox();
		this.groupBox1 = new System.Windows.Forms.GroupBox();
		this.buttonGo = new System.Windows.Forms.Button();
		this.buttonCancel = new System.Windows.Forms.Button();
		this.comboBox1 = new System.Windows.Forms.ComboBox();
		this.label1 = new System.Windows.Forms.Label();
		this.groupBox1.SuspendLayout();
		base.SuspendLayout();
		this.checkBoxAutoDigging.AutoSize = true;
		this.checkBoxAutoDigging.Checked = true;
		this.checkBoxAutoDigging.CheckState = System.Windows.Forms.CheckState.Checked;
		this.checkBoxAutoDigging.Location = new System.Drawing.Point(13, 13);
		this.checkBoxAutoDigging.Name = "checkBoxAutoDigging";
		this.checkBoxAutoDigging.Size = new System.Drawing.Size(170, 17);
		this.checkBoxAutoDigging.TabIndex = 0;
		this.checkBoxAutoDigging.Text = "Автоматически выкапывать";
		this.checkBoxAutoDigging.UseVisualStyleBackColor = true;
		this.checkBox2.AutoSize = true;
		this.checkBox2.Checked = true;
		this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
		this.checkBox2.Location = new System.Drawing.Point(6, 19);
		this.checkBox2.Name = "checkBox2";
		this.checkBox2.Size = new System.Drawing.Size(143, 17);
		this.checkBox2.TabIndex = 1;
		this.checkBox2.Text = "Лопата кладоискателя";
		this.checkBox2.UseVisualStyleBackColor = true;
		this.checkBox3.AutoSize = true;
		this.checkBox3.Checked = true;
		this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
		this.checkBox3.Location = new System.Drawing.Point(6, 42);
		this.checkBox3.Name = "checkBox3";
		this.checkBox3.Size = new System.Drawing.Size(118, 17);
		this.checkBox3.TabIndex = 2;
		this.checkBox3.Text = "Лопата археолога";
		this.checkBox3.UseVisualStyleBackColor = true;
		this.checkBox4.AutoSize = true;
		this.checkBox4.Checked = true;
		this.checkBox4.CheckState = System.Windows.Forms.CheckState.Checked;
		this.checkBox4.Location = new System.Drawing.Point(6, 65);
		this.checkBox4.Name = "checkBox4";
		this.checkBox4.Size = new System.Drawing.Size(119, 17);
		this.checkBox4.TabIndex = 3;
		this.checkBox4.Text = "Походная лопатка";
		this.checkBox4.UseVisualStyleBackColor = true;
		this.groupBox1.Controls.Add(this.checkBox2);
		this.groupBox1.Controls.Add(this.checkBox4);
		this.groupBox1.Controls.Add(this.checkBox3);
		this.groupBox1.Location = new System.Drawing.Point(13, 37);
		this.groupBox1.Name = "groupBox1";
		this.groupBox1.Size = new System.Drawing.Size(170, 90);
		this.groupBox1.TabIndex = 4;
		this.groupBox1.TabStop = false;
		this.groupBox1.Text = "Использовать лопаты";
		this.buttonGo.Location = new System.Drawing.Point(11, 177);
		this.buttonGo.Name = "buttonGo";
		this.buttonGo.Size = new System.Drawing.Size(90, 23);
		this.buttonGo.TabIndex = 5;
		this.buttonGo.Text = "Запустить";
		this.buttonGo.UseVisualStyleBackColor = true;
		this.buttonGo.Click += new System.EventHandler(buttonGo_Click);
		this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
		this.buttonCancel.Location = new System.Drawing.Point(107, 177);
		this.buttonCancel.Name = "buttonCancel";
		this.buttonCancel.Size = new System.Drawing.Size(75, 23);
		this.buttonCancel.TabIndex = 6;
		this.buttonCancel.Text = "Отмена";
		this.buttonCancel.UseVisualStyleBackColor = true;
		this.buttonCancel.Click += new System.EventHandler(buttonCancel_Click);
		this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.comboBox1.FormattingEnabled = true;
		this.comboBox1.Location = new System.Drawing.Point(13, 147);
		this.comboBox1.Name = "comboBox1";
		this.comboBox1.Size = new System.Drawing.Size(169, 21);
		this.comboBox1.TabIndex = 7;
		this.label1.AutoSize = true;
		this.label1.Location = new System.Drawing.Point(16, 131);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(163, 13);
		this.label1.TabIndex = 8;
		this.label1.Text = "Комплект после выкапывания";
		base.AcceptButton = this.buttonGo;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.CancelButton = this.buttonCancel;
		base.ClientSize = new System.Drawing.Size(194, 211);
		base.ControlBox = false;
		base.Controls.Add(this.label1);
		base.Controls.Add(this.comboBox1);
		base.Controls.Add(this.buttonCancel);
		base.Controls.Add(this.buttonGo);
		base.Controls.Add(this.groupBox1);
		base.Controls.Add(this.checkBoxAutoDigging);
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.MaximizeBox = false;
		this.MaximumSize = new System.Drawing.Size(210, 250);
		base.MinimizeBox = false;
		this.MinimumSize = new System.Drawing.Size(210, 250);
		base.Name = "FormTreasure";
		base.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Поиск клада";
		this.groupBox1.ResumeLayout(false);
		this.groupBox1.PerformLayout();
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
