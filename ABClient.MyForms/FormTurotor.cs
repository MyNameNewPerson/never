using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ABClient.MyForms;

public class FormTurotor : Form
{
	private IContainer icontainer_0;

	private Label label1;

	private ComboBox comboBoxLocations;

	private Button buttonGo;

	private Button buttonCancel;

	private GroupBox groupBox1;

	private Label label5;

	private ComboBox comboBoxLocationsSecondary;

	private NumericUpDown IntervalEnd;

	private Label label4;

	private NumericUpDown IntervalStart;

	private Label label3;

	public FormTurotor()
	{
		InitializeComponent();
	}

	private void buttonCancel_Click(object sender, EventArgs e)
	{
		Class72.formMain_0.method_44();
	}

	private void buttonGo_Click(object sender, EventArgs e)
	{
		string text = comboBoxLocations.Text;
		string text2 = comboBoxLocationsSecondary.Text;
		int num = (int)IntervalStart.Value;
		int num2 = (int)IntervalEnd.Value;
		if (!string.IsNullOrEmpty(text))
		{
			text = text.Substring(0, 6);
			if (!string.IsNullOrEmpty(text2) && text[0] == text2[0] && num != num2 && num > -1 && num < 24 && num2 > -1 && num2 < 24)
			{
				Class72.string_42 = text2.Substring(0, 6);
				Class72.int_14 = num;
				Class72.int_15 = num2;
			}
			Class72.bool_37 = text.StartsWith("11");
			Class72.bool_36 = !Class72.smethod_134().Contains("Туротор") && !Class72.smethod_134().Contains("Гиблая Топь");
			Class72.string_41 = text;
			string text3 = (Class72.bool_37 ? "Остров Туротор" : "Гиблая Топь");
			string text4 = (string.IsNullOrEmpty(Class72.string_42) ? string.Empty : $"В интервале с <b>{num}:00</b> до <b>{num2}:00</b> на <b>{comboBoxLocationsSecondary.Text}</b>.");
			Class72.formMain_0.method_63("Включено авто использование свитка телепорта в локацию <b>" + text3 + "</b> на <b>" + comboBoxLocations.Text + "</b>. " + text4);
			method_0();
			Close();
		}
	}

	private void method_0()
	{
		bool flag = false;
		Class69[] array = Class71.smethod_2();
		for (int i = 0; i < array.Length; i++)
		{
			if (array[i].bool_2)
			{
				flag = true;
				break;
			}
		}
		if (!flag)
		{
			string text = (Class72.bool_37 ? "Остров Туротор" : "Гиблая Топь");
			Class71.smethod_1(new Class69
			{
				string_0 = "Использован Телепорт (" + text + ")",
				dateTime_0 = DateTime.Now.AddSeconds(1.0),
				string_1 = "Телепорт (" + text + ")",
				int_0 = 1,
				bool_0 = true,
				bool_2 = true,
				int_1 = (Class72.bool_37 ? 28800 : 14400)
			});
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ABClient.MyForms.FormTurotor));
		this.label1 = new System.Windows.Forms.Label();
		this.comboBoxLocations = new System.Windows.Forms.ComboBox();
		this.buttonGo = new System.Windows.Forms.Button();
		this.buttonCancel = new System.Windows.Forms.Button();
		this.groupBox1 = new System.Windows.Forms.GroupBox();
		this.label5 = new System.Windows.Forms.Label();
		this.comboBoxLocationsSecondary = new System.Windows.Forms.ComboBox();
		this.IntervalEnd = new System.Windows.Forms.NumericUpDown();
		this.label4 = new System.Windows.Forms.Label();
		this.IntervalStart = new System.Windows.Forms.NumericUpDown();
		this.label3 = new System.Windows.Forms.Label();
		this.groupBox1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.IntervalEnd).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.IntervalStart).BeginInit();
		base.SuspendLayout();
		this.label1.AutoSize = true;
		this.label1.Location = new System.Drawing.Point(11, 13);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(60, 13);
		this.label1.TabIndex = 0;
		this.label1.Text = "Куда идти:";
		this.comboBoxLocations.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.comboBoxLocations.FormattingEnabled = true;
		this.comboBoxLocations.Items.AddRange(new object[9] { "11-458 Огры [20]", "11-457 Огры-берсерки [21]", "11-456 Огры-берсерки [22]", "11-488 Огры-берсерки [23]", "11-487 Огры-берсерки [24]", "28-462 Огры-защитники [25]", "28-463 Огры-защитники [26]", "28-464 Огры-защитники [27]", "28-465 Огры-защитники [28]" });
		this.comboBoxLocations.Location = new System.Drawing.Point(77, 10);
		this.comboBoxLocations.Name = "comboBoxLocations";
		this.comboBoxLocations.Size = new System.Drawing.Size(239, 21);
		this.comboBoxLocations.TabIndex = 1;
		this.buttonGo.Location = new System.Drawing.Point(10, 123);
		this.buttonGo.Name = "buttonGo";
		this.buttonGo.Size = new System.Drawing.Size(174, 23);
		this.buttonGo.TabIndex = 4;
		this.buttonGo.Text = "Запустить";
		this.buttonGo.UseVisualStyleBackColor = true;
		this.buttonGo.Click += new System.EventHandler(buttonGo_Click);
		this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
		this.buttonCancel.Location = new System.Drawing.Point(190, 123);
		this.buttonCancel.Name = "buttonCancel";
		this.buttonCancel.Size = new System.Drawing.Size(126, 23);
		this.buttonCancel.TabIndex = 5;
		this.buttonCancel.Text = "Отмена";
		this.buttonCancel.UseVisualStyleBackColor = true;
		this.buttonCancel.Click += new System.EventHandler(buttonCancel_Click);
		this.groupBox1.Controls.Add(this.label5);
		this.groupBox1.Controls.Add(this.comboBoxLocationsSecondary);
		this.groupBox1.Controls.Add(this.IntervalEnd);
		this.groupBox1.Controls.Add(this.label4);
		this.groupBox1.Controls.Add(this.IntervalStart);
		this.groupBox1.Controls.Add(this.label3);
		this.groupBox1.Location = new System.Drawing.Point(5, 37);
		this.groupBox1.Name = "groupBox1";
		this.groupBox1.Size = new System.Drawing.Size(317, 80);
		this.groupBox1.TabIndex = 6;
		this.groupBox1.TabStop = false;
		this.groupBox1.Text = "Дополнительные условия";
		this.label5.AutoSize = true;
		this.label5.Location = new System.Drawing.Point(6, 49);
		this.label5.Name = "label5";
		this.label5.Size = new System.Drawing.Size(60, 13);
		this.label5.TabIndex = 7;
		this.label5.Text = "Куда идти:";
		this.comboBoxLocationsSecondary.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.comboBoxLocationsSecondary.FormattingEnabled = true;
		this.comboBoxLocationsSecondary.Items.AddRange(new object[9] { "11-458 Огры [20]", "11-457 Огры-берсерки [21]", "11-456 Огры-берсерки [22]", "11-488 Огры-берсерки [23]", "11-487 Огры-берсерки [24]", "28-462 Огры-защитники [25]", "28-463 Огры-защитники [26]", "28-464 Огры-защитники [27]", "28-465 Огры-защитники [28]" });
		this.comboBoxLocationsSecondary.Location = new System.Drawing.Point(72, 46);
		this.comboBoxLocationsSecondary.Name = "comboBoxLocationsSecondary";
		this.comboBoxLocationsSecondary.Size = new System.Drawing.Size(239, 21);
		this.comboBoxLocationsSecondary.TabIndex = 7;
		this.IntervalEnd.Location = new System.Drawing.Point(216, 20);
		this.IntervalEnd.Maximum = new decimal(new int[4] { 23, 0, 0, 0 });
		this.IntervalEnd.Name = "IntervalEnd";
		this.IntervalEnd.Size = new System.Drawing.Size(50, 20);
		this.IntervalEnd.TabIndex = 9;
		this.label4.AutoSize = true;
		this.label4.Location = new System.Drawing.Point(191, 22);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(19, 13);
		this.label4.TabIndex = 7;
		this.label4.Text = "до";
		this.IntervalStart.Location = new System.Drawing.Point(135, 20);
		this.IntervalStart.Maximum = new decimal(new int[4] { 23, 0, 0, 0 });
		this.IntervalStart.Name = "IntervalStart";
		this.IntervalStart.Size = new System.Drawing.Size(50, 20);
		this.IntervalStart.TabIndex = 8;
		this.label3.AutoSize = true;
		this.label3.Location = new System.Drawing.Point(6, 22);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(123, 13);
		this.label3.TabIndex = 7;
		this.label3.Text = "Временной интервал с";
		base.AcceptButton = this.buttonGo;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.CancelButton = this.buttonCancel;
		base.ClientSize = new System.Drawing.Size(334, 161);
		base.ControlBox = false;
		base.Controls.Add(this.groupBox1);
		base.Controls.Add(this.buttonCancel);
		base.Controls.Add(this.buttonGo);
		base.Controls.Add(this.comboBoxLocations);
		base.Controls.Add(this.label1);
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.MaximizeBox = false;
		this.MaximumSize = new System.Drawing.Size(350, 200);
		base.MinimizeBox = false;
		this.MinimumSize = new System.Drawing.Size(350, 200);
		base.Name = "FormTurotor";
		base.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Остров Туротор / Гиблая Топь";
		this.groupBox1.ResumeLayout(false);
		this.groupBox1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.IntervalEnd).EndInit();
		((System.ComponentModel.ISupportInitialize)this.IntervalStart).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
