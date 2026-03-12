using System;
using System.ComponentModel;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

internal sealed class FormNewTimer : Form
{
	private readonly AutoCompleteStringCollection autoCompleteStringCollection_0 = new AutoCompleteStringCollection();

	private IContainer icontainer_0;

	private Label label1;

	private Button buttonOk;

	private Button buttonCancel;

	private ComboBox comboPotion;

	private Label label4;

	private Label label5;

	private Label label7;

	private TextBox textCell;

	private TextBox textName;

	private GroupBox groupBox1;

	private RadioButton radioNone;

	private RadioButton radioPotion;

	private RadioButton radioDestination;

	private TextBox textDrinkCount;

	private CheckBox checkRecur;

	private NumericUpDown numTriggerHour;

	private NumericUpDown numTriggerMin;

	private RadioButton radioComplect;

	private TextBox textComplect;

	private NumericUpDown numTriggerSec;

	private NumericUpDown RepeatSeconds;

	private NumericUpDown RepeatMinutes;

	private NumericUpDown RepeatHours;

	private Label label2;

	internal FormNewTimer()
	{
		InitializeComponent();
		comboPotion.SelectedIndex = 0;
		foreach (string key in Class77.smethod_4().Keys)
		{
			autoCompleteStringCollection_0.Add(key);
		}
		textCell.AutoCompleteCustomSource = autoCompleteStringCollection_0;
	}

	private void buttonOk_Click(object sender, EventArgs e)
	{
		Class69 @class = new Class69();
		@class.string_0 = textName.Text.Trim();
		if (!int.TryParse(numTriggerHour.Text.Trim(), out var result) || result < 0)
		{
			result = 0;
		}
		if (!int.TryParse(numTriggerMin.Text.Trim(), out var result2) || result2 < 0 || result2 > 59)
		{
			result2 = 0;
		}
		if (!int.TryParse(numTriggerSec.Text.Trim(), out var result3) || result3 < 0 || result3 > 59)
		{
			result3 = 0;
		}
		@class.dateTime_0 = DateTime.Now.AddSeconds(result3 + result2 * 60 + result * 3600);
		if (radioPotion.Checked)
		{
			if (comboPotion.SelectedIndex < 1)
			{
				return;
			}
			string text = comboPotion.Text.Trim();
			if (text.StartsWith("-----"))
			{
				return;
			}
			@class.string_1 = text;
			if (string.IsNullOrEmpty(@class.string_0))
			{
				@class.string_0 = "Используем " + @class.string_1;
			}
			if (!int.TryParse(textDrinkCount.Text.Trim(), out var result4) || result4 < 1)
			{
				result4 = 1;
			}
			@class.int_0 = result4;
			@class.bool_0 = checkRecur.Checked;
			if (@class.bool_0)
			{
				if (!int.TryParse(RepeatHours.Text.Trim(), out var result5) || result5 < 0)
				{
					result5 = 0;
				}
				if (!int.TryParse(RepeatMinutes.Text.Trim(), out var result6) || result6 < 0 || result6 > 59)
				{
					result6 = 0;
				}
				if (!int.TryParse(RepeatSeconds.Text.Trim(), out var result7) || result7 < 0 || result7 > 59)
				{
					result7 = 0;
				}
				@class.int_1 = result7 + result6 * 60 + result5 * 3600;
			}
		}
		if (radioDestination.Checked)
		{
			string text2 = textCell.Text.Trim();
			if (string.IsNullOrEmpty(text2))
			{
				return;
			}
			@class.string_2 = text2;
			if (string.IsNullOrEmpty(@class.string_0))
			{
				@class.string_0 = "Идем на " + text2;
			}
			@class.bool_0 = checkRecur.Checked;
		}
		if (radioComplect.Checked)
		{
			string text3 = textComplect.Text.Trim();
			if (string.IsNullOrEmpty(text3))
			{
				return;
			}
			@class.string_3 = text3;
			if (string.IsNullOrEmpty(@class.string_0))
			{
				@class.string_0 = "Надеваем комплект {complect}";
			}
		}
		Class71.smethod_1(@class);
	}

	private void textCell_TextChanged(object sender, EventArgs e)
	{
		bool flag;
		try
		{
			flag = new Regex("\\d{1,2}-\\d{3}").Match(textCell.Text).Success && Class77.smethod_4().ContainsKey(textCell.Text);
		}
		catch
		{
			flag = false;
		}
		textCell.BackColor = (flag ? SystemColors.Window : Color.Pink);
	}

	private void radioDestination_CheckedChanged(object sender, EventArgs e)
	{
		if (radioNone.Checked || radioComplect.Checked)
		{
			comboPotion.Enabled = false;
			textDrinkCount.Enabled = false;
			checkRecur.Enabled = false;
		}
		if (radioNone.Checked || radioPotion.Checked || radioComplect.Checked)
		{
			textCell.Enabled = false;
		}
		if (radioNone.Checked || radioPotion.Checked || radioDestination.Checked)
		{
			textComplect.Enabled = false;
		}
		if (radioPotion.Checked)
		{
			comboPotion.Enabled = true;
			textDrinkCount.Enabled = true;
			checkRecur.Enabled = true;
		}
		if (radioDestination.Checked)
		{
			textCell.Enabled = true;
			checkRecur.Enabled = true;
			comboPotion.Enabled = false;
			textDrinkCount.Enabled = false;
		}
		if (radioComplect.Checked)
		{
			textComplect.Enabled = true;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNewTimer));
		this.label1 = new System.Windows.Forms.Label();
		this.buttonOk = new System.Windows.Forms.Button();
		this.buttonCancel = new System.Windows.Forms.Button();
		this.comboPotion = new System.Windows.Forms.ComboBox();
		this.label4 = new System.Windows.Forms.Label();
		this.label5 = new System.Windows.Forms.Label();
		this.label7 = new System.Windows.Forms.Label();
		this.textCell = new System.Windows.Forms.TextBox();
		this.textName = new System.Windows.Forms.TextBox();
		this.groupBox1 = new System.Windows.Forms.GroupBox();
		this.RepeatSeconds = new System.Windows.Forms.NumericUpDown();
		this.RepeatMinutes = new System.Windows.Forms.NumericUpDown();
		this.RepeatHours = new System.Windows.Forms.NumericUpDown();
		this.label2 = new System.Windows.Forms.Label();
		this.checkRecur = new System.Windows.Forms.CheckBox();
		this.textDrinkCount = new System.Windows.Forms.TextBox();
		this.radioNone = new System.Windows.Forms.RadioButton();
		this.radioPotion = new System.Windows.Forms.RadioButton();
		this.radioDestination = new System.Windows.Forms.RadioButton();
		this.numTriggerHour = new System.Windows.Forms.NumericUpDown();
		this.numTriggerMin = new System.Windows.Forms.NumericUpDown();
		this.radioComplect = new System.Windows.Forms.RadioButton();
		this.textComplect = new System.Windows.Forms.TextBox();
		this.numTriggerSec = new System.Windows.Forms.NumericUpDown();
		this.groupBox1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.RepeatSeconds).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.RepeatMinutes).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.RepeatHours).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.numTriggerHour).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.numTriggerMin).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.numTriggerSec).BeginInit();
		base.SuspendLayout();
		this.label1.AutoSize = true;
		this.label1.BackColor = System.Drawing.Color.Transparent;
		this.label1.Location = new System.Drawing.Point(12, 9);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(71, 13);
		this.label1.TabIndex = 9;
		this.label1.Text = "Имя таймера";
		this.buttonOk.AutoSize = true;
		this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
		this.buttonOk.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
		this.buttonOk.Location = new System.Drawing.Point(132, 290);
		this.buttonOk.Name = "buttonOk";
		this.buttonOk.Size = new System.Drawing.Size(122, 23);
		this.buttonOk.TabIndex = 1014;
		this.buttonOk.Text = "Ввод";
		this.buttonOk.UseVisualStyleBackColor = true;
		this.buttonOk.Click += new System.EventHandler(buttonOk_Click);
		this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
		this.buttonCancel.Location = new System.Drawing.Point(260, 290);
		this.buttonCancel.Name = "buttonCancel";
		this.buttonCancel.Size = new System.Drawing.Size(85, 23);
		this.buttonCancel.TabIndex = 1015;
		this.buttonCancel.Text = "Отмена";
		this.buttonCancel.UseVisualStyleBackColor = true;
		this.comboPotion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.comboPotion.Enabled = false;
		this.comboPotion.FormattingEnabled = true;
		this.comboPotion.Items.AddRange(new object[112]
		{
			string.Empty,
			"------------ЕДА------------",
			"Рыбная похлебка",
			"Рыбный суп-пюре",
			"Запеченная рыба",
			"Рыбные палочки",
			"Рыбная солянка",
			"Суши",
			"Рыбный салат",
			"Жареная рыба с красной икрой",
			"Вяленая рыба с белым соусом",
			"Паштет с овощами",
			"Рыбная паста по-Кентарийски",
			"Паста из раковых шеек с мясом",
			"Бифштекс от элементаля",
			"Тушеное мясо с гарниром",
			"Жаркое по-Кардиффски",
			"Рыбное филе по-Альвийски",
			"Фаршированная форель",
			"--------АЛКОГОЛЬ--------",
			"Самогон",
			"Анисовая водка",
			"Баалгорский травяной настой",
			"Фейданский бренди",
			"Жихорийский шнапс",
			"Коньяк Дубовый",
			"Цветочный пунш",
			"Фаросское вино",
			"--------ЭЛИКСИРЫ--------",
			"Пирог с бананами",
			"Яблочный пирог",
			"Молодильное яблочко",
			"Чашу Айрис",
			"Дар Иланы",
			"Эликсир Быстроты",
			"Зелье Кровожадности",
			"Эликсир из Подснежника",
			"Ледяной эликсир I",
			"Ледяной эликсир II",
			"----------СВИТКИ----------",
			"Свиток Величия",
			"Свиток Каменной Кожи",
			"Свиток Слеза Создателя",
			"Свиток Гнев Локара",
			"Свиток Берсерка",
			"Свиток Благословения",
			"Свиток Проклятия",
			"Свиток Магии Воды",
			"Свиток Магии Воздуха",
			"Свиток Магии Земли",
			"Свиток Магии Огня",
			"Свиток Сопротивления Огню",
			"Свиток Сопротивления Земле",
			"Свиток Сопротивления Воздуху",
			"Свиток Сопротивления Воде",
			"Свиток Помощника",
			"Призыв Импа-вредителя",
			"Свиток Очищения",
			"-----------ЗЕЛЬЯ-----------",
			"Зелье Метаболизма",
			"Зелье Блаженства",
			"Зелье Сильной Спины",
			"Зелье Просветления",
			"Зелье Сокрушительных Ударов",
			"Зелье Стойкости",
			"Зелье Недосягаемости",
			"Зелье Точного Попадания",
			"Зелье Ловких Ударов",
			"Зелье Мужества",
			"Зелье Жизни",
			"Зелье Лечения",
			"Зелье Восстановления Маны",
			"Зелье Энергии",
			"Зелье Удачи",
			"Зелье Силы",
			"Зелье Ловкости",
			"Зелье Гения",
			"Зелье Боевой Славы",
			"Зелье Невидимости",
			"Зелье Секрет Волшебника",
			"Зелье Медитации",
			"Зелье Иммунитета",
			"Зелье Лечения Отравлений",
			"Зелье Огненного Ореола",
			"Зелье Колкости",
			"Зелье Загрубелой Кожи",
			"Зелье Панциря",
			"Зелье Человек-гора",
			"Зелье Скорости",
			"Зелье подвижности",
			"Зелье Соколиный взор",
			"Секретное Зелье",
			"Превосходное Зелье Сильной Спины",
			"Превосходное Зелье Сокрушения",
			"Превосходное Зелье Стойкости",
			"Превосходное Зелье Недосягаемости",
			"Превосходное Зелье Точности",
			"Превосходное Зелье Ловких Ударов",
			"Превосходное Зелье Мужества",
			"Превосходное Зелье Жизни",
			"Превосходное Зелье Удачи",
			"Превосходное Зелье Силы",
			"Превосходное Зелье Ловкости",
			"Превосходное Зелье Гения",
			"Превосходное Зелье Боевой Славы",
			"Превосходное Зелье Волшебства",
			"Превосходное Зелье Медитации",
			"Превосходное Зелье Ореола",
			"Превосходное Зелье Колкости",
			"Превосходное Зелье Панциря",
			"Превосходное Зелье Человек-Гора",
			"Превосходное Зелье Скорости"
		});
		this.comboPotion.Location = new System.Drawing.Point(11, 35);
		this.comboPotion.Name = "comboPotion";
		this.comboPotion.Size = new System.Drawing.Size(314, 21);
		this.comboPotion.TabIndex = 1017;
		this.label4.AutoSize = true;
		this.label4.BackColor = System.Drawing.Color.Transparent;
		this.label4.Location = new System.Drawing.Point(8, 19);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(99, 13);
		this.label4.TabIndex = 1018;
		this.label4.Text = "Выберите эффект";
		this.label5.AutoSize = true;
		this.label5.BackColor = System.Drawing.Color.Transparent;
		this.label5.Location = new System.Drawing.Point(16, 65);
		this.label5.Name = "label5";
		this.label5.Size = new System.Drawing.Size(146, 13);
		this.label5.TabIndex = 1020;
		this.label5.Text = "Количество использований";
		this.label7.AutoSize = true;
		this.label7.Location = new System.Drawing.Point(124, 56);
		this.label7.Name = "label7";
		this.label7.Size = new System.Drawing.Size(94, 13);
		this.label7.TabIndex = 1021;
		this.label7.Text = "Сработает через";
		this.textCell.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
		this.textCell.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
		this.textCell.Enabled = false;
		this.textCell.Location = new System.Drawing.Point(132, 97);
		this.textCell.Name = "textCell";
		this.textCell.Size = new System.Drawing.Size(69, 21);
		this.textCell.TabIndex = 1024;
		this.textCell.TextChanged += new System.EventHandler(textCell_TextChanged);
		this.textName.Location = new System.Drawing.Point(12, 25);
		this.textName.Name = "textName";
		this.textName.Size = new System.Drawing.Size(341, 21);
		this.textName.TabIndex = 1025;
		this.groupBox1.Controls.Add(this.RepeatSeconds);
		this.groupBox1.Controls.Add(this.RepeatMinutes);
		this.groupBox1.Controls.Add(this.RepeatHours);
		this.groupBox1.Controls.Add(this.label2);
		this.groupBox1.Controls.Add(this.checkRecur);
		this.groupBox1.Controls.Add(this.textDrinkCount);
		this.groupBox1.Controls.Add(this.label4);
		this.groupBox1.Controls.Add(this.comboPotion);
		this.groupBox1.Controls.Add(this.label5);
		this.groupBox1.Location = new System.Drawing.Point(12, 148);
		this.groupBox1.Name = "groupBox1";
		this.groupBox1.Size = new System.Drawing.Size(341, 136);
		this.groupBox1.TabIndex = 1029;
		this.groupBox1.TabStop = false;
		this.groupBox1.Text = "Эффекты";
		this.RepeatSeconds.Location = new System.Drawing.Point(203, 109);
		this.RepeatSeconds.Maximum = new decimal(new int[4] { 59, 0, 0, 0 });
		this.RepeatSeconds.Name = "RepeatSeconds";
		this.RepeatSeconds.Size = new System.Drawing.Size(45, 21);
		this.RepeatSeconds.TabIndex = 1041;
		this.RepeatMinutes.Location = new System.Drawing.Point(152, 109);
		this.RepeatMinutes.Maximum = new decimal(new int[4] { 59, 0, 0, 0 });
		this.RepeatMinutes.Name = "RepeatMinutes";
		this.RepeatMinutes.Size = new System.Drawing.Size(45, 21);
		this.RepeatMinutes.TabIndex = 1040;
		this.RepeatHours.Location = new System.Drawing.Point(101, 109);
		this.RepeatHours.Maximum = new decimal(new int[4] { 999, 0, 0, 0 });
		this.RepeatHours.Name = "RepeatHours";
		this.RepeatHours.Size = new System.Drawing.Size(45, 21);
		this.RepeatHours.TabIndex = 1039;
		this.label2.AutoSize = true;
		this.label2.Location = new System.Drawing.Point(19, 113);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(76, 13);
		this.label2.TabIndex = 1037;
		this.label2.Text = "Повтор через";
		this.checkRecur.AutoSize = true;
		this.checkRecur.Enabled = false;
		this.checkRecur.Location = new System.Drawing.Point(19, 89);
		this.checkRecur.Name = "checkRecur";
		this.checkRecur.Size = new System.Drawing.Size(172, 17);
		this.checkRecur.TabIndex = 1036;
		this.checkRecur.Text = "Циклическое использование";
		this.checkRecur.UseVisualStyleBackColor = true;
		this.textDrinkCount.Enabled = false;
		this.textDrinkCount.Location = new System.Drawing.Point(168, 62);
		this.textDrinkCount.Name = "textDrinkCount";
		this.textDrinkCount.Size = new System.Drawing.Size(33, 21);
		this.textDrinkCount.TabIndex = 1021;
		this.textDrinkCount.Text = "1";
		this.radioNone.AutoSize = true;
		this.radioNone.Checked = true;
		this.radioNone.Location = new System.Drawing.Point(12, 52);
		this.radioNone.Name = "radioNone";
		this.radioNone.Size = new System.Drawing.Size(100, 17);
		this.radioNone.TabIndex = 1030;
		this.radioNone.TabStop = true;
		this.radioNone.Text = "Просто таймер";
		this.radioNone.UseVisualStyleBackColor = true;
		this.radioNone.CheckedChanged += new System.EventHandler(radioDestination_CheckedChanged);
		this.radioPotion.AutoSize = true;
		this.radioPotion.Location = new System.Drawing.Point(12, 75);
		this.radioPotion.Name = "radioPotion";
		this.radioPotion.Size = new System.Drawing.Size(178, 17);
		this.radioPotion.TabIndex = 1031;
		this.radioPotion.Text = "Эффект (зелье, эликсир и тд)";
		this.radioPotion.UseVisualStyleBackColor = true;
		this.radioPotion.CheckedChanged += new System.EventHandler(radioDestination_CheckedChanged);
		this.radioDestination.AutoSize = true;
		this.radioDestination.Location = new System.Drawing.Point(12, 98);
		this.radioDestination.Name = "radioDestination";
		this.radioDestination.Size = new System.Drawing.Size(95, 17);
		this.radioDestination.TabIndex = 1032;
		this.radioDestination.Text = "Перемещение";
		this.radioDestination.UseVisualStyleBackColor = true;
		this.radioDestination.CheckedChanged += new System.EventHandler(radioDestination_CheckedChanged);
		this.numTriggerHour.Location = new System.Drawing.Point(220, 54);
		this.numTriggerHour.Maximum = new decimal(new int[4] { 999, 0, 0, 0 });
		this.numTriggerHour.Name = "numTriggerHour";
		this.numTriggerHour.Size = new System.Drawing.Size(45, 21);
		this.numTriggerHour.TabIndex = 1034;
		this.numTriggerMin.Location = new System.Drawing.Point(266, 54);
		this.numTriggerMin.Maximum = new decimal(new int[4] { 59, 0, 0, 0 });
		this.numTriggerMin.Name = "numTriggerMin";
		this.numTriggerMin.Size = new System.Drawing.Size(45, 21);
		this.numTriggerMin.TabIndex = 1035;
		this.radioComplect.AutoSize = true;
		this.radioComplect.Location = new System.Drawing.Point(12, 121);
		this.radioComplect.Name = "radioComplect";
		this.radioComplect.Size = new System.Drawing.Size(114, 17);
		this.radioComplect.TabIndex = 1036;
		this.radioComplect.Text = "Надеть комплект";
		this.radioComplect.UseVisualStyleBackColor = true;
		this.textComplect.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
		this.textComplect.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
		this.textComplect.Enabled = false;
		this.textComplect.Location = new System.Drawing.Point(132, 121);
		this.textComplect.Name = "textComplect";
		this.textComplect.Size = new System.Drawing.Size(69, 21);
		this.textComplect.TabIndex = 1037;
		this.numTriggerSec.Location = new System.Drawing.Point(312, 54);
		this.numTriggerSec.Maximum = new decimal(new int[4] { 59, 0, 0, 0 });
		this.numTriggerSec.Name = "numTriggerSec";
		this.numTriggerSec.Size = new System.Drawing.Size(45, 21);
		this.numTriggerSec.TabIndex = 1038;
		base.AcceptButton = this.buttonOk;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.CancelButton = this.buttonCancel;
		base.ClientSize = new System.Drawing.Size(369, 325);
		base.Controls.Add(this.numTriggerSec);
		base.Controls.Add(this.textComplect);
		base.Controls.Add(this.radioComplect);
		base.Controls.Add(this.numTriggerMin);
		base.Controls.Add(this.textCell);
		base.Controls.Add(this.numTriggerHour);
		base.Controls.Add(this.radioDestination);
		base.Controls.Add(this.radioPotion);
		base.Controls.Add(this.radioNone);
		base.Controls.Add(this.groupBox1);
		base.Controls.Add(this.textName);
		base.Controls.Add(this.label7);
		base.Controls.Add(this.buttonOk);
		base.Controls.Add(this.buttonCancel);
		base.Controls.Add(this.label1);
		this.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "FormNewTimer";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Новый таймер";
		this.groupBox1.ResumeLayout(false);
		this.groupBox1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.RepeatSeconds).EndInit();
		((System.ComponentModel.ISupportInitialize)this.RepeatMinutes).EndInit();
		((System.ComponentModel.ISupportInitialize)this.RepeatHours).EndInit();
		((System.ComponentModel.ISupportInitialize)this.numTriggerHour).EndInit();
		((System.ComponentModel.ISupportInitialize)this.numTriggerMin).EndInit();
		((System.ComponentModel.ISupportInitialize)this.numTriggerSec).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
