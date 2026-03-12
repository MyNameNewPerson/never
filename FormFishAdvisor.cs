using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using ABClient;

internal sealed class FormFishAdvisor : Form
{
	private readonly ArrayList arrayList_0 = new ArrayList();

	private readonly List<Class86> list_0 = new List<Class86>();

	private int int_0;

	private IContainer icontainer_0;

	private Label label1;

	private TextBox textFishUm;

	private Label label2;

	private ComboBox comboHandleBots;

	private Button buttonCalc;

	private ListView listView;

	private Button buttonOk;

	private ColumnHeader columnHeader_0;

	private ColumnHeader columnHeader_1;

	private ColumnHeader columnHeader_2;

	private ColumnHeader columnHeader_3;

	private ErrorProvider errorProvider_0;

	internal FormFishAdvisor()
	{
		InitializeComponent();
		int_0 = Class72.class19_0.method_92();
		textFishUm.Text = int_0.ToString(CultureInfo.InvariantCulture);
		arrayList_0.Add(new ListItemBotLevelEx(8));
		arrayList_0.Add(new ListItemBotLevelEx(9));
		arrayList_0.Add(new ListItemBotLevelEx(12));
		arrayList_0.Add(new ListItemBotLevelEx(15));
		arrayList_0.Add(new ListItemBotLevelEx(19));
		comboHandleBots.DataSource = arrayList_0;
		comboHandleBots.DisplayMember = "BotLevel";
		comboHandleBots.ValueMember = "BotLevelValue";
		comboHandleBots.SelectedValue = Class72.class19_0.method_94();
		if (comboHandleBots.SelectedIndex == -1)
		{
			comboHandleBots.SelectedIndex = 0;
		}
		list_0.Add(new Class86(-42, 0, "8-224", 12, "Гобл 8-12", "Верхоплавка на хлеб"));
		list_0.Add(new Class86(-42, 0, "8-384", 8, "Гобл 4-8", "Верхоплавка на хлеб"));
		list_0.Add(new Class86(-42, 0, "12-208", 15, "Орки 15", "Верхоплавка на хлеб"));
		list_0.Add(new Class86(60, 20, "8-224", 12, "Гобл 8-12", "Красноперка на мотыля"));
		list_0.Add(new Class86(60, 20, "8-384", 8, "Гобл 4-8", "Красноперка на мотыля"));
		list_0.Add(new Class86(177, 30, "8-224", 12, "Гобл 8-12", "Бычок на опарыш"));
		list_0.Add(new Class86(177, 30, "8-384", 8, "Гобл 4-8", "Бычок на опарыш"));
		list_0.Add(new Class86(177, 30, "7-552", 19, "Огры 19", "Бычок на опарыш"));
		list_0.Add(new Class86(311, 40, "8-224", 12, "Гобл 8-12", "Ёрш на червяка"));
		list_0.Add(new Class86(311, 40, "8-384", 8, "Гобл 4-8", "Ёрш на червяка"));
		list_0.Add(new Class86(311, 40, "8-413", 8, "Гобл 4-8", "Ёрш на червяка"));
		list_0.Add(new Class86(311, 40, "8-414", 8, "Гобл 4-8", "Ёрш на червяка"));
		list_0.Add(new Class86(311, 40, "7-552", 19, "Огры 19", "Ёрш на червяка"));
		list_0.Add(new Class86(466, 60, "8-326", 9, "Гобл 5-9", "Плотва на червяка"));
		list_0.Add(new Class86(466, 60, "8-358", 9, "Гобл 5-9", "Плотва на червяка"));
		list_0.Add(new Class86(644, 80, "8-437", 9, "Гобл 7-9", "Пескарь на хлеб"));
		list_0.Add(new Class86(644, 80, "8-467", 9, "Гобл 7-9", "Пескарь на хлеб"));
		list_0.Add(new Class86(848, 95, "8-326", 9, "Гобл 5-9", "Карась на хлеб"));
		list_0.Add(new Class86(848, 95, "8-358", 9, "Гобл 5-9", "Карась на хлеб"));
		list_0.Add(new Class86(848, 95, "7-552", 19, "Огры 19", "Карась на хлеб"));
		list_0.Add(new Class86(1084, 120, "8-326", 9, "Гобл 5-9", "Подлещик на крупного червяка"));
		list_0.Add(new Class86(1084, 120, "8-358", 9, "Гобл 5-9", "Подлещик на крупного червяка"));
		list_0.Add(new Class86(1354, 140, "8-437", 9, "Гобл 7-9", "Карп на крупного червяка"));
		list_0.Add(new Class86(1354, 140, "8-467", 9, "Гобл 7-9", "Карп на крупного червяка"));
		list_0.Add(new Class86(1354, 140, "12-208", 15, "Орки 15", "Карп на крупного червяка"));
		list_0.Add(new Class86(1675, 180, "8-326", 9, "Гобл 5-9", "Окунь на мотыля с сачком"));
		list_0.Add(new Class86(1675, 180, "8-358", 9, "Гобл 5-9", "Окунь на мотыля с сачком"));
		list_0.Add(new Class86(2142, 210, "8-384", 8, "Гобл 4-8", "Лещ на донку с сачком"));
		list_0.Add(new Class86(2142, 210, "8-413", 8, "Гобл 4-8", "Лещ на донку с сачком"));
		list_0.Add(new Class86(2142, 210, "8-414", 8, "Гобл 4-8", "Лещ на донку с сачком"));
		list_0.Add(new Class86(2142, 210, "8-437", 9, "Гобл 7-9", "Лещ на донку с сачком"));
		list_0.Add(new Class86(2142, 210, "8-467", 9, "Гобл 7-9", "Лещ на донку с сачком"));
		list_0.Add(new Class86(2679, 250, "8-384", 8, "Гобл 4-8", "Голавль на крупного червяка с сачком"));
		list_0.Add(new Class86(2679, 250, "8-413", 8, "Гобл 4-8", "Голавль на крупного червяка с сачком"));
		list_0.Add(new Class86(2679, 250, "8-414", 8, "Гобл 4-8", "Голавль на крупного червяка с сачком"));
		list_0.Add(new Class86(2679, 250, "7-552", 19, "Огры 19", "Голавль на крупного червяка с сачком"));
		list_0.Add(new Class86(3297, 370, "8-224", 12, "Гобл 8-12", "Налим на донку с сачком"));
		list_0.Add(new Class86(4008, 450, "8-326", 9, "Гобл 5-9", "Язь на мормышку с сачком"));
		list_0.Add(new Class86(4008, 450, "7-552", 19, "Огры 19", "Язь на мормышку с сачком"));
		list_0.Add(new Class86(4008, 450, "12-208", 15, "Орки 15", "Язь на мормышку с сачком"));
		list_0.Add(new Class86(4825, 500, "8-326", 9, "Гобл 5-9", "Щука на блесну с сачком"));
		list_0.Add(new Class86(4825, 500, "8-437", 9, "Гобл 7-9", "Щука на блесну с сачком"));
		list_0.Add(new Class86(4825, 500, "8-467", 9, "Гобл 7-9", "Щука на блесну с сачком"));
		list_0.Add(new Class86(4825, 500, "8-358", 9, "Гобл 5-9", "Щука на блесну с сачком"));
		list_0.Add(new Class86(4825, 500, "7-552", 19, "Огры 19", "Щука на блесну с сачком"));
		list_0.Add(new Class86(5765, 600, "8-437", 9, "Гобл 7-9", "Линь на мормышку с сачком"));
		list_0.Add(new Class86(5765, 600, "8-467", 9, "Гобл 7-9", "Линь на мормышку с сачком"));
		list_0.Add(new Class86(5765, 600, "8-358", 9, "Гобл 5-9", "Линь на мормышку с сачком"));
		list_0.Add(new Class86(5765, 600, "12-208", 15, "Орки 15", "Линь на мормышку с сачком"));
		list_0.Add(new Class86(6846, 700, "8-437", 9, "Гобл 7-9", "Судак на червяка с сачком"));
		list_0.Add(new Class86(6846, 700, "8-467", 9, "Гобл 7-9", "Судак на червяка с сачком"));
		list_0.Add(new Class86(8089, 800, "8-358", 9, "Гобл 5-9", "Сом на заговоренную блесну с сачком"));
		list_0.Add(new Class86(9518, 1000, "8-384", 8, "Гобл 4-8", "Форель на блесну с сачком"));
		list_0.Add(new Class86(9518, 1000, "8-413", 8, "Гобл 4-8", "Форель на блесну с сачком"));
		list_0.Add(new Class86(9518, 1000, "8-414", 8, "Гобл 4-8", "Форель на блесну с сачком"));
		list_0.Add(new Class86(9518, 1000, "12-208", 15, "Орки 15", "Форель на блесну с сачком"));
	}

	private void FormFishAdvisor_Validating(object sender, CancelEventArgs e)
	{
		bool flag;
		if (!(flag = !int.TryParse(textFishUm.Text.Trim(), out int_0)) && int_0 < 0)
		{
			flag = true;
		}
		if (flag)
		{
			e.Cancel = true;
			textFishUm.Select(0, textFishUm.Text.Length);
			errorProvider_0.SetError(textFishUm, "Умение рыбалки - это целое число больше нуля, например, 65");
		}
		else
		{
			errorProvider_0.SetError(textFishUm, string.Empty);
		}
	}

	private void buttonCalc_Click(object sender, EventArgs e)
	{
		if (!int.TryParse(textFishUm.Text.Trim(), out int_0))
		{
			return;
		}
		int num = (int)comboHandleBots.SelectedValue;
		Class72.class19_0.method_95(num);
		List<Class86> list = new List<Class86>();
		foreach (Class86 item in list_0)
		{
			if (item.method_2() <= int_0 && item.method_6() <= num)
			{
				list.Add(item);
			}
		}
		list.Sort();
		Color backColor = Color.FromArgb(240, 240, 240);
		int num2 = 0;
		listView.BeginUpdate();
		listView.Items.Clear();
		foreach (Class86 item2 in list)
		{
			ListViewItem listViewItem = new ListViewItem(item2.method_0().ToString(CultureInfo.InvariantCulture) + " NV");
			listViewItem.SubItems.Add(item2.method_4());
			listViewItem.SubItems.Add(item2.method_8());
			listViewItem.SubItems.Add(item2.method_10() + " (" + item2.method_2() + ")");
			if (num2 % 2 == 1)
			{
				listViewItem.BackColor = backColor;
				listViewItem.UseItemStyleForSubItems = true;
			}
			listView.Items.Add(listViewItem);
			num2++;
		}
		listView.EndUpdate();
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFishAdvisor));
		this.label1 = new System.Windows.Forms.Label();
		this.textFishUm = new System.Windows.Forms.TextBox();
		this.label2 = new System.Windows.Forms.Label();
		this.comboHandleBots = new System.Windows.Forms.ComboBox();
		this.buttonCalc = new System.Windows.Forms.Button();
		this.listView = new System.Windows.Forms.ListView();
		this.columnHeader_0 = new System.Windows.Forms.ColumnHeader();
		this.columnHeader_1 = new System.Windows.Forms.ColumnHeader();
		this.columnHeader_3 = new System.Windows.Forms.ColumnHeader();
		this.columnHeader_2 = new System.Windows.Forms.ColumnHeader();
		this.buttonOk = new System.Windows.Forms.Button();
		this.errorProvider_0 = new System.Windows.Forms.ErrorProvider(this.icontainer_0);
		((System.ComponentModel.ISupportInitialize)this.errorProvider_0).BeginInit();
		base.SuspendLayout();
		this.label1.AutoSize = true;
		this.label1.Location = new System.Drawing.Point(15, 13);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(91, 13);
		this.label1.TabIndex = 0;
		this.label1.Text = "Умение рыбалки";
		this.textFishUm.Location = new System.Drawing.Point(12, 29);
		this.textFishUm.Name = "textFishUm";
		this.textFishUm.Size = new System.Drawing.Size(101, 21);
		this.textFishUm.TabIndex = 1;
		this.textFishUm.Validating += new System.ComponentModel.CancelEventHandler(FormFishAdvisor_Validating);
		this.label2.AutoSize = true;
		this.label2.Location = new System.Drawing.Point(145, 13);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(120, 13);
		this.label2.TabIndex = 2;
		this.label2.Text = "Убиваемые Вами боты";
		this.comboHandleBots.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.comboHandleBots.FormattingEnabled = true;
		this.comboHandleBots.Location = new System.Drawing.Point(142, 29);
		this.comboHandleBots.Name = "comboHandleBots";
		this.comboHandleBots.Size = new System.Drawing.Size(181, 21);
		this.comboHandleBots.TabIndex = 3;
		this.buttonCalc.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
		this.buttonCalc.Location = new System.Drawing.Point(136, 74);
		this.buttonCalc.Name = "buttonCalc";
		this.buttonCalc.Size = new System.Drawing.Size(272, 23);
		this.buttonCalc.TabIndex = 4;
		this.buttonCalc.Text = "Посоветовать, где и что ловить";
		this.buttonCalc.UseVisualStyleBackColor = true;
		this.buttonCalc.Click += new System.EventHandler(buttonCalc_Click);
		this.listView.Activation = System.Windows.Forms.ItemActivation.OneClick;
		this.listView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[4] { this.columnHeader_0, this.columnHeader_1, this.columnHeader_3, this.columnHeader_2 });
		this.listView.GridLines = true;
		this.listView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
		this.listView.LabelWrap = false;
		this.listView.Location = new System.Drawing.Point(12, 103);
		this.listView.Name = "listView";
		this.listView.ShowGroups = false;
		this.listView.Size = new System.Drawing.Size(521, 168);
		this.listView.TabIndex = 5;
		this.listView.UseCompatibleStateImageBehavior = false;
		this.listView.View = System.Windows.Forms.View.Details;
		this.columnHeader_0.Text = "Прибыль";
		this.columnHeader_0.Width = 58;
		this.columnHeader_1.Text = "Клетка";
		this.columnHeader_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.columnHeader_1.Width = 50;
		this.columnHeader_3.Text = "Боты";
		this.columnHeader_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.columnHeader_3.Width = 75;
		this.columnHeader_2.Text = "Инструкция";
		this.columnHeader_2.Width = 297;
		this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
		this.buttonOk.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
		this.buttonOk.Location = new System.Drawing.Point(374, 277);
		this.buttonOk.Name = "buttonOk";
		this.buttonOk.Size = new System.Drawing.Size(159, 23);
		this.buttonOk.TabIndex = 6;
		this.buttonOk.Text = "Закрыть";
		this.buttonOk.UseVisualStyleBackColor = true;
		this.errorProvider_0.ContainerControl = this;
		base.AcceptButton = this.buttonOk;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.CancelButton = this.buttonOk;
		base.ClientSize = new System.Drawing.Size(545, 312);
		base.Controls.Add(this.buttonOk);
		base.Controls.Add(this.listView);
		base.Controls.Add(this.buttonCalc);
		base.Controls.Add(this.comboHandleBots);
		base.Controls.Add(this.label2);
		base.Controls.Add(this.textFishUm);
		base.Controls.Add(this.label1);
		this.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "FormFishAdvisor";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Советник рыбака";
		base.Validating += new System.ComponentModel.CancelEventHandler(FormFishAdvisor_Validating);
		((System.ComponentModel.ISupportInitialize)this.errorProvider_0).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
