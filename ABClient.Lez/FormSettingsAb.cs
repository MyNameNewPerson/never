using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ABClient.Helpers;
using ABClient.MyProfile;

namespace ABClient.Lez;

public class FormSettingsAb : Form
{
	private readonly List<LezBotsGroup> list_0;

	private readonly BindingSource bindingSource_0 = new BindingSource();

	private IContainer icontainer_0;

	private TabControl tabControlGeneral;

	private TabPage tabPageGeneral;

	private TabPage tabRotation;

	private TabPage tabPageAbilities;

	private TabPage tabPageStop;

	private TabControl tabControl1;

	private TabPage tabPageMagHit;

	private TabPage tabPageMagBlock;

	private TabPage tabPageMagHp;

	private TabPage tabPageMagMa;

	private TabPage tabPageOthers;

	private Button buttonOk;

	private Button buttonCancel;

	private Button buttonApply;

	private TabPage tabPageGroups;

	private GroupBox groupBox2;

	private CheckBox checkDoAutoboi;

	private GroupBox groupBox3;

	private LinkLabel linkWaitMa;

	private CheckBox checkDoWaitMa;

	private LinkLabel linkWaitHp;

	private CheckBox checkDoWaitHp;

	private GroupBox groupBox15;

	private GroupBox groupBox1;

	private Button buttonDeleteGroup;

	private Button buttonCreateGroup;

	private ComboBox comboNewGroup;

	private LinkLabel linkMagHits;

	private LinkLabel linkNewGroupLevel;

	private GroupBox groupBox9;

	private LinkLabel linkStopLowHp;

	private LinkLabel linkStopLowMa;

	private ListView listSpellsHits;

	private ListBox listGroups;

	private CheckBox checkDoStopLowMa;

	private CheckBox checkDoStopLowHp;

	private CheckBox checkDoWinTimeout;

	private RadioButton radioSayNo;

	private RadioButton radioSayClan;

	private LinkLabel linkRestoreHp;

	private LinkLabel linkRestoreMa;

	private CheckBox checkDoRestoreMa;

	private CheckBox checkDoRestoreHp;

	private CheckBox checkDoAbilBlocks;

	private CheckBox checkDoAbilHits;

	private CheckBox checkDoMagHits;

	private CheckBox checkDoHits;

	private CheckBox checkDoMiscAbils;

	private CheckBox checkDoExit;

	private CheckBox checkDoStopNow;

	private ListView listSpellsBlocks;

	private ListView listSpellsRestoreHp;

	private ListView listSpellsRestoreMa;

	private ListView listSpellsMisc;

	private CheckBox checkDoMagBlocks;

	private CheckBox checkDoBlocks;

	private Button buttonFullMa;

	private Button buttonFullHp;

	private CheckBox checkDoExitRisky;

	private GroupBox groupBox4;

	private LinkLabel linkDrinkMa;

	private CheckBox checkDoDrinkMa;

	private LinkLabel linkDrinkHp;

	private CheckBox checkDoDrinkHp;

	private PictureBox pictureBox1;

	public FormSettingsAb(List<LezBotsGroup> lezBotsGroupCollection)
	{
		InitializeComponent();
		list_0 = (List<LezBotsGroup>)Misc.DeepClone(lezBotsGroupCollection);
		bindingSource_0.DataSource = list_0;
		comboNewGroup.DataSource = LezBotsClassCollection.ListForComboBox();
		comboNewGroup.DisplayMember = "Plural";
	}

	private void FormSettingsAb_Load(object sender, EventArgs e)
	{
		method_1();
	}

	private void buttonCancel_Click(object sender, EventArgs e)
	{
		base.DialogResult = DialogResult.Cancel;
		Close();
	}

	private void method_0()
	{
		LezBotsGroup lezBotsGroup_ = (LezBotsGroup)listGroups.SelectedItem;
		method_4(lezBotsGroup_);
		method_2();
	}

	private void buttonApply_Click(object sender, EventArgs e)
	{
		method_0();
	}

	private void buttonOk_Click(object sender, EventArgs e)
	{
		base.DialogResult = DialogResult.OK;
		method_0();
		Close();
	}

	private void method_1()
	{
		listGroups.DataSource = bindingSource_0;
		listGroups.SelectedIndex = bindingSource_0.Count - 1;
		checkDoAutoboi.Checked = Class72.class19_0.bool_48;
		CheckBox checkBox = checkDoWaitHp;
		bool flag = (linkWaitHp.Enabled = Class72.class19_0.bool_49);
		checkBox.Checked = flag;
		CheckBox checkBox2 = checkDoWaitMa;
		flag = (linkWaitMa.Enabled = Class72.class19_0.bool_50);
		checkBox2.Checked = flag;
		method_5(Class72.class19_0.int_9);
		method_6(Class72.class19_0.int_10);
		CheckBox checkBox3 = checkDoDrinkHp;
		flag = (linkDrinkHp.Enabled = Class72.class19_0.bool_51);
		checkBox3.Checked = flag;
		CheckBox checkBox4 = checkDoDrinkMa;
		flag = (linkDrinkMa.Enabled = Class72.class19_0.bool_52);
		checkBox4.Checked = flag;
		method_7(Class72.class19_0.int_11);
		method_8(Class72.class19_0.int_12);
		checkDoWinTimeout.Checked = Class72.class19_0.bool_53;
		switch (Class72.class19_0.lezSayType_0)
		{
		case LezSayType.Clan:
			radioSayClan.Checked = true;
			break;
		case LezSayType.No:
			radioSayNo.Checked = true;
			break;
		}
		method_9(0);
		LezBotsGroup lezBotsGroup_ = (LezBotsGroup)listGroups.SelectedItem;
		method_3(lezBotsGroup_);
	}

	private void method_2()
	{
		Class72.class19_0.bool_48 = checkDoAutoboi.Checked;
		Class72.class19_0.bool_49 = checkDoWaitHp.Checked;
		Class72.class19_0.bool_50 = checkDoWaitMa.Checked;
		Class72.class19_0.int_9 = (int)linkWaitHp.Tag;
		Class72.class19_0.int_10 = (int)linkWaitMa.Tag;
		Class72.class19_0.bool_51 = checkDoDrinkHp.Checked;
		Class72.class19_0.bool_52 = checkDoDrinkMa.Checked;
		Class72.class19_0.int_11 = (int)linkDrinkHp.Tag;
		Class72.class19_0.int_12 = (int)linkDrinkMa.Tag;
		Class72.class19_0.bool_53 = checkDoWinTimeout.Checked;
		if (radioSayNo.Checked)
		{
			Class72.class19_0.lezSayType_0 = LezSayType.No;
		}
		if (radioSayClan.Checked)
		{
			Class72.class19_0.lezSayType_0 = LezSayType.Clan;
		}
		Class72.class19_0.list_3 = (List<LezBotsGroup>)Misc.DeepClone(list_0);
	}

	private void method_3(LezBotsGroup lezBotsGroup_0)
	{
		CheckBox checkBox = checkDoRestoreHp;
		bool flag = (linkRestoreHp.Enabled = lezBotsGroup_0.DoRestoreHp);
		checkBox.Checked = flag;
		CheckBox checkBox2 = checkDoRestoreMa;
		flag = (linkRestoreMa.Enabled = lezBotsGroup_0.DoRestoreMa);
		checkBox2.Checked = flag;
		method_10(lezBotsGroup_0.RestoreHp);
		method_11(lezBotsGroup_0.RestoreMa);
		checkDoAbilBlocks.Checked = lezBotsGroup_0.DoAbilBlocks;
		checkDoAbilHits.Checked = lezBotsGroup_0.DoAbilHits;
		CheckBox checkBox3 = checkDoMagHits;
		flag = (linkMagHits.Enabled = lezBotsGroup_0.DoMagHits);
		checkBox3.Checked = flag;
		method_12(lezBotsGroup_0.MagHits);
		checkDoMagBlocks.Checked = lezBotsGroup_0.DoMagBlocks;
		checkDoHits.Checked = lezBotsGroup_0.DoHits;
		checkDoBlocks.Checked = lezBotsGroup_0.DoBlocks;
		checkDoMiscAbils.Checked = lezBotsGroup_0.DoMiscAbils;
		smethod_0(listSpellsHits, lezBotsGroup_0.SpellsHits, LezSpellCollection.Hits);
		smethod_0(listSpellsBlocks, lezBotsGroup_0.SpellsBlocks, LezSpellCollection.Blocks);
		smethod_0(listSpellsRestoreHp, lezBotsGroup_0.SpellsRestoreHp, LezSpellCollection.RestoreHp);
		smethod_0(listSpellsRestoreMa, lezBotsGroup_0.SpellsRestoreMa, LezSpellCollection.RestoreMa);
		smethod_0(listSpellsMisc, lezBotsGroup_0.SpellsMisc, LezSpellCollection.Misc);
		checkDoStopNow.Checked = lezBotsGroup_0.DoStopNow;
		CheckBox checkBox4 = checkDoStopLowHp;
		flag = (linkStopLowHp.Enabled = lezBotsGroup_0.DoStopLowHp);
		checkBox4.Checked = flag;
		CheckBox checkBox5 = checkDoStopLowMa;
		flag = (linkStopLowMa.Enabled = lezBotsGroup_0.DoStopLowMa);
		checkBox5.Checked = flag;
		method_13(lezBotsGroup_0.StopLowHp);
		method_14(lezBotsGroup_0.StopLowMa);
		checkDoExit.Checked = lezBotsGroup_0.DoExit;
		checkDoExitRisky.Checked = lezBotsGroup_0.DoExitRisky;
	}

	private void method_4(LezBotsGroup lezBotsGroup_0)
	{
		lezBotsGroup_0.DoRestoreHp = checkDoRestoreHp.Checked;
		lezBotsGroup_0.DoRestoreMa = checkDoRestoreMa.Checked;
		lezBotsGroup_0.RestoreHp = (int)linkRestoreHp.Tag;
		lezBotsGroup_0.RestoreMa = (int)linkRestoreMa.Tag;
		lezBotsGroup_0.DoAbilBlocks = checkDoAbilBlocks.Checked;
		lezBotsGroup_0.DoAbilHits = checkDoAbilHits.Checked;
		lezBotsGroup_0.DoMagHits = checkDoMagHits.Checked;
		lezBotsGroup_0.DoMagBlocks = checkDoMagBlocks.Checked;
		lezBotsGroup_0.MagHits = (int)linkMagHits.Tag;
		lezBotsGroup_0.DoHits = checkDoHits.Checked;
		lezBotsGroup_0.DoBlocks = checkDoBlocks.Checked;
		lezBotsGroup_0.DoMiscAbils = checkDoMiscAbils.Checked;
		smethod_1(listSpellsHits, out lezBotsGroup_0.SpellsHits);
		smethod_1(listSpellsBlocks, out lezBotsGroup_0.SpellsBlocks);
		smethod_1(listSpellsRestoreHp, out lezBotsGroup_0.SpellsRestoreHp);
		smethod_1(listSpellsRestoreMa, out lezBotsGroup_0.SpellsRestoreMa);
		smethod_1(listSpellsMisc, out lezBotsGroup_0.SpellsMisc);
		lezBotsGroup_0.DoStopNow = checkDoStopNow.Checked;
		lezBotsGroup_0.DoStopLowHp = checkDoStopLowHp.Checked;
		lezBotsGroup_0.DoStopLowMa = checkDoStopLowMa.Checked;
		lezBotsGroup_0.StopLowHp = (int)linkStopLowHp.Tag;
		lezBotsGroup_0.StopLowMa = (int)linkStopLowMa.Tag;
		lezBotsGroup_0.DoExit = checkDoExit.Checked;
		lezBotsGroup_0.DoExitRisky = checkDoExitRisky.Checked;
	}

	private void listGroups_SelectedIndexChanged(object sender, EventArgs e)
	{
		LezBotsGroup lezBotsGroup = (LezBotsGroup)bindingSource_0[listGroups.SelectedIndex];
		buttonDeleteGroup.Enabled = lezBotsGroup.Id != 1 || lezBotsGroup.MinimalLevel != 0;
		LezBotsGroup lezBotsGroup_ = (LezBotsGroup)listGroups.SelectedItem;
		method_3(lezBotsGroup_);
	}

	private void tabControlGeneral_SelectedIndexChanged(object sender, EventArgs e)
	{
		string text;
		switch (tabControlGeneral.SelectedIndex)
		{
		default:
		{
			string text2 = listGroups.SelectedItem.ToString();
			text = string.Format("Настройки группы \"" + text2 + "\"");
			break;
		}
		case 1:
			text = "Настройки групп автобоя";
			break;
		case 0:
			text = "Общие настройки";
			break;
		}
		Text = text;
	}

	private void checkDoWaitHp_CheckedChanged(object sender, EventArgs e)
	{
		linkWaitHp.Enabled = checkDoWaitHp.Checked;
	}

	private void checkDoWaitMa_CheckedChanged(object sender, EventArgs e)
	{
		linkWaitMa.Enabled = checkDoWaitMa.Checked;
	}

	private void checkDoDrinkHp_CheckedChanged(object sender, EventArgs e)
	{
		linkDrinkHp.Enabled = checkDoDrinkHp.Checked;
	}

	private void checkDoDrinkMa_CheckedChanged(object sender, EventArgs e)
	{
		linkDrinkMa.Enabled = checkDoDrinkMa.Checked;
	}

	private void method_5(int int_0)
	{
		linkWaitHp.Tag = int_0;
		linkWaitHp.Text = string.Format($"Пока здоровье не станет {int_0}%");
	}

	private void method_6(int int_0)
	{
		linkWaitMa.Tag = int_0;
		linkWaitMa.Text = string.Format($"Пока мана не станет {int_0}%");
	}

	private void method_7(int int_0)
	{
		linkDrinkHp.Tag = int_0;
		linkDrinkHp.Text = string.Format($"Если здоровье упало ниже {int_0}%");
	}

	private void method_8(int int_0)
	{
		linkDrinkMa.Tag = int_0;
		linkDrinkMa.Text = string.Format($"Если мана упала ниже {int_0}%");
	}

	private void linkWaitHp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		FormEnterInt formEnterInt = new FormEnterInt("Здоровье", (int)((LinkLabel)sender).Tag, 0, 100);
		try
		{
			if (formEnterInt.ShowDialog() == DialogResult.OK)
			{
				method_5(formEnterInt.method_0());
			}
		}
		finally
		{
			((IDisposable)formEnterInt).Dispose();
		}
	}

	private void linkWaitMa_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		FormEnterInt formEnterInt = new FormEnterInt("Мана", (int)((LinkLabel)sender).Tag, 0, 100);
		try
		{
			if (formEnterInt.ShowDialog() == DialogResult.OK)
			{
				method_6(formEnterInt.method_0());
			}
		}
		finally
		{
			((IDisposable)formEnterInt).Dispose();
		}
	}

	private void linkDrinkHp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		FormEnterInt formEnterInt = new FormEnterInt("Здоровье", (int)((LinkLabel)sender).Tag, 0, 100);
		try
		{
			if (formEnterInt.ShowDialog() == DialogResult.OK)
			{
				method_7(formEnterInt.method_0());
			}
		}
		finally
		{
			((IDisposable)formEnterInt).Dispose();
		}
	}

	private void linkDrinkMa_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		FormEnterInt formEnterInt = new FormEnterInt("Мана", (int)((LinkLabel)sender).Tag, 0, 100);
		try
		{
			if (formEnterInt.ShowDialog() == DialogResult.OK)
			{
				method_8(formEnterInt.method_0());
			}
		}
		finally
		{
			((IDisposable)formEnterInt).Dispose();
		}
	}

	private void method_9(int int_0)
	{
		linkNewGroupLevel.Tag = int_0;
		linkNewGroupLevel.Text = string.Format($"с {int_0}-го уровня");
	}

	private void linkNewGroupLevel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		FormEnterInt formEnterInt = new FormEnterInt("Уровень", (int)((LinkLabel)sender).Tag, 0, 33);
		try
		{
			if (formEnterInt.ShowDialog() == DialogResult.OK)
			{
				method_9(formEnterInt.method_0());
			}
		}
		finally
		{
			((IDisposable)formEnterInt).Dispose();
		}
	}

	private void buttonCreateGroup_Click(object sender, EventArgs e)
	{
		LezBotsGroup lezBotsGroup = new LezBotsGroup(1, 0);
		int id = ((LezBotsClass)comboNewGroup.SelectedItem).Id;
		int minimalLevel = (int)linkNewGroupLevel.Tag;
		lezBotsGroup.Change(id, minimalLevel);
		for (int i = 0; i < bindingSource_0.Count; i++)
		{
			LezBotsGroup obj = (LezBotsGroup)bindingSource_0[i];
			switch (lezBotsGroup.CompareTo(obj))
			{
			case -1:
				bindingSource_0.Insert(i, lezBotsGroup);
				return;
			case 0:
				return;
			}
		}
	}

	private void buttonDeleteGroup_Click(object sender, EventArgs e)
	{
		LezBotsGroup lezBotsGroup = (LezBotsGroup)bindingSource_0[listGroups.SelectedIndex];
		if (lezBotsGroup.Id != 1 || lezBotsGroup.MinimalLevel != 0)
		{
			bindingSource_0.RemoveAt(listGroups.SelectedIndex);
			listGroups.SelectedIndex = bindingSource_0.Count - 1;
			lezBotsGroup = (LezBotsGroup)bindingSource_0[listGroups.SelectedIndex];
			method_3(lezBotsGroup);
		}
	}

	private void method_10(int int_0)
	{
		linkRestoreHp.Tag = int_0;
		linkRestoreHp.Text = string.Format($"Восстанавливать жизнь, если она упала до {int_0}% или ниже");
	}

	private void method_11(int int_0)
	{
		linkRestoreMa.Tag = int_0;
		linkRestoreMa.Text = string.Format($"Восстанавливать ману, если она упала до {int_0}% или ниже");
	}

	private void method_12(int int_0)
	{
		linkMagHits.Tag = int_0;
		linkMagHits.Text = string.Format($"Ставить магические удары по {int_0} маны");
	}

	private void checkDoRestoreHp_CheckedChanged(object sender, EventArgs e)
	{
		linkRestoreHp.Enabled = checkDoRestoreHp.Checked;
	}

	private void checkDoRestoreMa_CheckedChanged(object sender, EventArgs e)
	{
		linkRestoreMa.Enabled = checkDoRestoreMa.Checked;
	}

	private void checkDoMagHits_CheckedChanged(object sender, EventArgs e)
	{
		linkMagHits.Enabled = checkDoMagHits.Checked;
	}

	private void linkRestoreHp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		FormEnterInt formEnterInt = new FormEnterInt("Здоровье", (int)((LinkLabel)sender).Tag, 0, 100);
		try
		{
			if (formEnterInt.ShowDialog() == DialogResult.OK)
			{
				method_10(formEnterInt.method_0());
			}
		}
		finally
		{
			((IDisposable)formEnterInt).Dispose();
		}
	}

	private void linkRestoreMa_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		FormEnterInt formEnterInt = new FormEnterInt("Мана", (int)((LinkLabel)sender).Tag, 0, 100);
		try
		{
			if (formEnterInt.ShowDialog() == DialogResult.OK)
			{
				method_11(formEnterInt.method_0());
			}
		}
		finally
		{
			((IDisposable)formEnterInt).Dispose();
		}
	}

	private void linkMagHits_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		FormEnterInt formEnterInt = new FormEnterInt("Удар", (int)((LinkLabel)sender).Tag, 5, 1000);
		try
		{
			if (formEnterInt.ShowDialog() == DialogResult.OK)
			{
				method_12(formEnterInt.method_0());
			}
		}
		finally
		{
			((IDisposable)formEnterInt).Dispose();
		}
	}

	private static void smethod_0(ListView listView_0, int[] int_0, IEnumerable<int> ienumerable_0)
	{
		listView_0.HeaderStyle = ColumnHeaderStyle.Nonclickable;
		listView_0.View = View.Details;
		listView_0.Columns.Clear();
		listView_0.Columns.Add("Код");
		listView_0.Columns.Add("Название");
		listView_0.Columns.Add("ОД");
		listView_0.Columns.Add("Мана");
		listView_0.Columns.Add("Тип");
		listView_0.Items.Clear();
		foreach (int item in ienumerable_0)
		{
			ListViewItem value = new ListViewItem(new string[5]
			{
				item.ToString(),
				LezSpellCollection.Spells[item].Name,
				LezSpellCollection.Od[item].ToString(),
				LezSpellCollection.PosMana[item].ToString(),
				LezSpellCollection.PosType[item].ToString()
			})
			{
				Checked = (Array.IndexOf(int_0, item) > -1)
			};
			listView_0.Items.Add(value);
		}
		listView_0.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
	}

	private static void smethod_1(ListView listView_0, out int[] int_0)
	{
		List<int> list = new List<int>();
		foreach (object item in listView_0.Items)
		{
			if (((ListViewItem)item).Checked)
			{
				list.Add(Convert.ToInt32(((ListViewItem)item).SubItems[0].Text));
			}
		}
		int_0 = list.ToArray();
	}

	private void method_13(int int_0)
	{
		linkStopLowHp.Tag = int_0;
		linkStopLowHp.Text = string.Format($"Остановить бой, если жизнь упала до {int_0}% или ниже");
	}

	private void method_14(int int_0)
	{
		linkStopLowMa.Tag = int_0;
		linkStopLowMa.Text = string.Format($"Остановить бой, если мана упала до {int_0}% или ниже");
	}

	private void checkDoStopLowHp_CheckedChanged(object sender, EventArgs e)
	{
		linkStopLowHp.Enabled = checkDoStopLowHp.Checked;
	}

	private void checkDoStopLowMa_CheckedChanged(object sender, EventArgs e)
	{
		linkStopLowMa.Enabled = checkDoStopLowMa.Checked;
	}

	private void linkStopLowHp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		FormEnterInt formEnterInt = new FormEnterInt("Здоровье", (int)((LinkLabel)sender).Tag, 0, 100);
		try
		{
			if (formEnterInt.ShowDialog() == DialogResult.OK)
			{
				method_13(formEnterInt.method_0());
			}
		}
		finally
		{
			((IDisposable)formEnterInt).Dispose();
		}
	}

	private void linkStopLowMa_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		FormEnterInt formEnterInt = new FormEnterInt("Мана", (int)((LinkLabel)sender).Tag, 0, 100);
		try
		{
			if (formEnterInt.ShowDialog() == DialogResult.OK)
			{
				method_14(formEnterInt.method_0());
			}
		}
		finally
		{
			((IDisposable)formEnterInt).Dispose();
		}
	}

	private void buttonFullHp_Click(object sender, EventArgs e)
	{
		checkDoRestoreHp.Checked = true;
		method_10(100);
	}

	private void buttonFullMa_Click(object sender, EventArgs e)
	{
		checkDoRestoreMa.Checked = true;
		method_11(100);
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ABClient.Lez.FormSettingsAb));
		this.tabControlGeneral = new System.Windows.Forms.TabControl();
		this.tabPageGeneral = new System.Windows.Forms.TabPage();
		this.groupBox4 = new System.Windows.Forms.GroupBox();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.linkDrinkMa = new System.Windows.Forms.LinkLabel();
		this.checkDoDrinkMa = new System.Windows.Forms.CheckBox();
		this.linkDrinkHp = new System.Windows.Forms.LinkLabel();
		this.checkDoDrinkHp = new System.Windows.Forms.CheckBox();
		this.groupBox9 = new System.Windows.Forms.GroupBox();
		this.radioSayNo = new System.Windows.Forms.RadioButton();
		this.radioSayClan = new System.Windows.Forms.RadioButton();
		this.groupBox15 = new System.Windows.Forms.GroupBox();
		this.checkDoWinTimeout = new System.Windows.Forms.CheckBox();
		this.groupBox3 = new System.Windows.Forms.GroupBox();
		this.linkWaitMa = new System.Windows.Forms.LinkLabel();
		this.checkDoWaitMa = new System.Windows.Forms.CheckBox();
		this.linkWaitHp = new System.Windows.Forms.LinkLabel();
		this.checkDoWaitHp = new System.Windows.Forms.CheckBox();
		this.groupBox2 = new System.Windows.Forms.GroupBox();
		this.checkDoAutoboi = new System.Windows.Forms.CheckBox();
		this.tabPageGroups = new System.Windows.Forms.TabPage();
		this.buttonDeleteGroup = new System.Windows.Forms.Button();
		this.groupBox1 = new System.Windows.Forms.GroupBox();
		this.linkNewGroupLevel = new System.Windows.Forms.LinkLabel();
		this.buttonCreateGroup = new System.Windows.Forms.Button();
		this.comboNewGroup = new System.Windows.Forms.ComboBox();
		this.tabRotation = new System.Windows.Forms.TabPage();
		this.buttonFullMa = new System.Windows.Forms.Button();
		this.buttonFullHp = new System.Windows.Forms.Button();
		this.checkDoBlocks = new System.Windows.Forms.CheckBox();
		this.checkDoMagBlocks = new System.Windows.Forms.CheckBox();
		this.checkDoMiscAbils = new System.Windows.Forms.CheckBox();
		this.checkDoHits = new System.Windows.Forms.CheckBox();
		this.checkDoMagHits = new System.Windows.Forms.CheckBox();
		this.linkMagHits = new System.Windows.Forms.LinkLabel();
		this.checkDoAbilHits = new System.Windows.Forms.CheckBox();
		this.checkDoRestoreMa = new System.Windows.Forms.CheckBox();
		this.checkDoRestoreHp = new System.Windows.Forms.CheckBox();
		this.checkDoAbilBlocks = new System.Windows.Forms.CheckBox();
		this.linkRestoreMa = new System.Windows.Forms.LinkLabel();
		this.linkRestoreHp = new System.Windows.Forms.LinkLabel();
		this.tabPageAbilities = new System.Windows.Forms.TabPage();
		this.tabControl1 = new System.Windows.Forms.TabControl();
		this.tabPageMagHit = new System.Windows.Forms.TabPage();
		this.listSpellsHits = new System.Windows.Forms.ListView();
		this.tabPageMagBlock = new System.Windows.Forms.TabPage();
		this.listSpellsBlocks = new System.Windows.Forms.ListView();
		this.tabPageMagHp = new System.Windows.Forms.TabPage();
		this.listSpellsRestoreHp = new System.Windows.Forms.ListView();
		this.tabPageMagMa = new System.Windows.Forms.TabPage();
		this.listSpellsRestoreMa = new System.Windows.Forms.ListView();
		this.tabPageOthers = new System.Windows.Forms.TabPage();
		this.listSpellsMisc = new System.Windows.Forms.ListView();
		this.tabPageStop = new System.Windows.Forms.TabPage();
		this.checkDoExitRisky = new System.Windows.Forms.CheckBox();
		this.checkDoExit = new System.Windows.Forms.CheckBox();
		this.checkDoStopNow = new System.Windows.Forms.CheckBox();
		this.checkDoStopLowMa = new System.Windows.Forms.CheckBox();
		this.checkDoStopLowHp = new System.Windows.Forms.CheckBox();
		this.linkStopLowMa = new System.Windows.Forms.LinkLabel();
		this.linkStopLowHp = new System.Windows.Forms.LinkLabel();
		this.buttonOk = new System.Windows.Forms.Button();
		this.buttonCancel = new System.Windows.Forms.Button();
		this.buttonApply = new System.Windows.Forms.Button();
		this.listGroups = new System.Windows.Forms.ListBox();
		this.tabControlGeneral.SuspendLayout();
		this.tabPageGeneral.SuspendLayout();
		this.groupBox4.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		this.groupBox9.SuspendLayout();
		this.groupBox15.SuspendLayout();
		this.groupBox3.SuspendLayout();
		this.groupBox2.SuspendLayout();
		this.tabPageGroups.SuspendLayout();
		this.groupBox1.SuspendLayout();
		this.tabRotation.SuspendLayout();
		this.tabPageAbilities.SuspendLayout();
		this.tabControl1.SuspendLayout();
		this.tabPageMagHit.SuspendLayout();
		this.tabPageMagBlock.SuspendLayout();
		this.tabPageMagHp.SuspendLayout();
		this.tabPageMagMa.SuspendLayout();
		this.tabPageOthers.SuspendLayout();
		this.tabPageStop.SuspendLayout();
		base.SuspendLayout();
		this.tabControlGeneral.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.tabControlGeneral.Controls.Add(this.tabPageGeneral);
		this.tabControlGeneral.Controls.Add(this.tabPageGroups);
		this.tabControlGeneral.Controls.Add(this.tabRotation);
		this.tabControlGeneral.Controls.Add(this.tabPageAbilities);
		this.tabControlGeneral.Controls.Add(this.tabPageStop);
		this.tabControlGeneral.Location = new System.Drawing.Point(173, 12);
		this.tabControlGeneral.Name = "tabControlGeneral";
		this.tabControlGeneral.SelectedIndex = 0;
		this.tabControlGeneral.Size = new System.Drawing.Size(484, 309);
		this.tabControlGeneral.TabIndex = 1;
		this.tabControlGeneral.SelectedIndexChanged += new System.EventHandler(tabControlGeneral_SelectedIndexChanged);
		this.tabPageGeneral.Controls.Add(this.groupBox4);
		this.tabPageGeneral.Controls.Add(this.groupBox9);
		this.tabPageGeneral.Controls.Add(this.groupBox15);
		this.tabPageGeneral.Controls.Add(this.groupBox3);
		this.tabPageGeneral.Controls.Add(this.groupBox2);
		this.tabPageGeneral.Location = new System.Drawing.Point(4, 22);
		this.tabPageGeneral.Name = "tabPageGeneral";
		this.tabPageGeneral.Padding = new System.Windows.Forms.Padding(3);
		this.tabPageGeneral.Size = new System.Drawing.Size(476, 283);
		this.tabPageGeneral.TabIndex = 0;
		this.tabPageGeneral.Text = "Общие";
		this.tabPageGeneral.UseVisualStyleBackColor = true;
		this.groupBox4.Controls.Add(this.pictureBox1);
		this.groupBox4.Controls.Add(this.linkDrinkMa);
		this.groupBox4.Controls.Add(this.checkDoDrinkMa);
		this.groupBox4.Controls.Add(this.linkDrinkHp);
		this.groupBox4.Controls.Add(this.checkDoDrinkHp);
		this.groupBox4.Location = new System.Drawing.Point(166, 74);
		this.groupBox4.Name = "groupBox4";
		this.groupBox4.Size = new System.Drawing.Size(304, 62);
		this.groupBox4.TabIndex = 4;
		this.groupBox4.TabStop = false;
		this.groupBox4.Text = "Пить Эликсир восстановления вне боя";
		this.pictureBox1.ErrorImage = null;
		this.pictureBox1.Image = Class39.smethod_69();
		this.pictureBox1.Location = new System.Drawing.Point(16, 21);
		this.pictureBox1.Name = "pictureBox1";
		this.pictureBox1.Size = new System.Drawing.Size(30, 30);
		this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
		this.pictureBox1.TabIndex = 4;
		this.pictureBox1.TabStop = false;
		this.linkDrinkMa.AutoSize = true;
		this.linkDrinkMa.Location = new System.Drawing.Point(122, 37);
		this.linkDrinkMa.Name = "linkDrinkMa";
		this.linkDrinkMa.Size = new System.Drawing.Size(145, 13);
		this.linkDrinkMa.TabIndex = 3;
		this.linkDrinkMa.TabStop = true;
		this.linkDrinkMa.Text = "Если мана упала ниже 50%";
		this.linkDrinkMa.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkDrinkMa_LinkClicked);
		this.checkDoDrinkMa.AutoSize = true;
		this.checkDoDrinkMa.Location = new System.Drawing.Point(101, 37);
		this.checkDoDrinkMa.Name = "checkDoDrinkMa";
		this.checkDoDrinkMa.Size = new System.Drawing.Size(15, 14);
		this.checkDoDrinkMa.TabIndex = 2;
		this.checkDoDrinkMa.UseVisualStyleBackColor = true;
		this.checkDoDrinkMa.CheckedChanged += new System.EventHandler(checkDoDrinkMa_CheckedChanged);
		this.linkDrinkHp.AutoSize = true;
		this.linkDrinkHp.Location = new System.Drawing.Point(122, 20);
		this.linkDrinkHp.Name = "linkDrinkHp";
		this.linkDrinkHp.Size = new System.Drawing.Size(169, 13);
		this.linkDrinkHp.TabIndex = 1;
		this.linkDrinkHp.TabStop = true;
		this.linkDrinkHp.Text = "Если здоровье упало ниже 50%";
		this.linkDrinkHp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkDrinkHp_LinkClicked);
		this.checkDoDrinkHp.AutoSize = true;
		this.checkDoDrinkHp.Location = new System.Drawing.Point(101, 20);
		this.checkDoDrinkHp.Name = "checkDoDrinkHp";
		this.checkDoDrinkHp.Size = new System.Drawing.Size(15, 14);
		this.checkDoDrinkHp.TabIndex = 0;
		this.checkDoDrinkHp.UseVisualStyleBackColor = true;
		this.checkDoDrinkHp.CheckedChanged += new System.EventHandler(checkDoDrinkHp_CheckedChanged);
		this.groupBox9.Controls.Add(this.radioSayNo);
		this.groupBox9.Controls.Add(this.radioSayClan);
		this.groupBox9.Location = new System.Drawing.Point(6, 74);
		this.groupBox9.Name = "groupBox9";
		this.groupBox9.Size = new System.Drawing.Size(154, 62);
		this.groupBox9.TabIndex = 17;
		this.groupBox9.TabStop = false;
		this.groupBox9.Text = "Сообщение о нападении";
		this.radioSayNo.AutoSize = true;
		this.radioSayNo.Location = new System.Drawing.Point(6, 20);
		this.radioSayNo.Name = "radioSayNo";
		this.radioSayNo.Size = new System.Drawing.Size(91, 17);
		this.radioSayNo.TabIndex = 18;
		this.radioSayNo.TabStop = true;
		this.radioSayNo.Text = "Не сообщать";
		this.radioSayNo.UseVisualStyleBackColor = true;
		this.radioSayClan.AutoSize = true;
		this.radioSayClan.Location = new System.Drawing.Point(6, 37);
		this.radioSayClan.Name = "radioSayClan";
		this.radioSayClan.Size = new System.Drawing.Size(80, 17);
		this.radioSayClan.TabIndex = 20;
		this.radioSayClan.TabStop = true;
		this.radioSayClan.Text = "В клан-чат";
		this.radioSayClan.UseVisualStyleBackColor = true;
		this.groupBox15.Controls.Add(this.checkDoWinTimeout);
		this.groupBox15.Location = new System.Drawing.Point(350, 6);
		this.groupBox15.Name = "groupBox15";
		this.groupBox15.Size = new System.Drawing.Size(120, 62);
		this.groupBox15.TabIndex = 16;
		this.groupBox15.TabStop = false;
		this.groupBox15.Text = "При таймауте";
		this.checkDoWinTimeout.AutoSize = true;
		this.checkDoWinTimeout.Location = new System.Drawing.Point(6, 20);
		this.checkDoWinTimeout.Name = "checkDoWinTimeout";
		this.checkDoWinTimeout.Size = new System.Drawing.Size(109, 17);
		this.checkDoWinTimeout.TabIndex = 0;
		this.checkDoWinTimeout.Text = "Ставить победу";
		this.checkDoWinTimeout.UseVisualStyleBackColor = true;
		this.groupBox3.Controls.Add(this.linkWaitMa);
		this.groupBox3.Controls.Add(this.checkDoWaitMa);
		this.groupBox3.Controls.Add(this.linkWaitHp);
		this.groupBox3.Controls.Add(this.checkDoWaitHp);
		this.groupBox3.Location = new System.Drawing.Point(130, 6);
		this.groupBox3.Name = "groupBox3";
		this.groupBox3.Size = new System.Drawing.Size(214, 62);
		this.groupBox3.TabIndex = 2;
		this.groupBox3.TabStop = false;
		this.groupBox3.Text = "Ждать, не выходя из боя";
		this.linkWaitMa.AutoSize = true;
		this.linkWaitMa.Location = new System.Drawing.Point(28, 38);
		this.linkWaitMa.Name = "linkWaitMa";
		this.linkWaitMa.Size = new System.Drawing.Size(144, 13);
		this.linkWaitMa.TabIndex = 3;
		this.linkWaitMa.TabStop = true;
		this.linkWaitMa.Text = "Пока мана не станет 100%";
		this.linkWaitMa.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkWaitMa_LinkClicked);
		this.checkDoWaitMa.AutoSize = true;
		this.checkDoWaitMa.Location = new System.Drawing.Point(7, 38);
		this.checkDoWaitMa.Name = "checkDoWaitMa";
		this.checkDoWaitMa.Size = new System.Drawing.Size(15, 14);
		this.checkDoWaitMa.TabIndex = 2;
		this.checkDoWaitMa.UseVisualStyleBackColor = true;
		this.checkDoWaitMa.CheckedChanged += new System.EventHandler(checkDoWaitMa_CheckedChanged);
		this.linkWaitHp.AutoSize = true;
		this.linkWaitHp.Location = new System.Drawing.Point(28, 21);
		this.linkWaitHp.Name = "linkWaitHp";
		this.linkWaitHp.Size = new System.Drawing.Size(168, 13);
		this.linkWaitHp.TabIndex = 1;
		this.linkWaitHp.TabStop = true;
		this.linkWaitHp.Text = "Пока здоровье не станет 100%";
		this.linkWaitHp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkWaitHp_LinkClicked);
		this.checkDoWaitHp.AutoSize = true;
		this.checkDoWaitHp.Location = new System.Drawing.Point(7, 21);
		this.checkDoWaitHp.Name = "checkDoWaitHp";
		this.checkDoWaitHp.Size = new System.Drawing.Size(15, 14);
		this.checkDoWaitHp.TabIndex = 0;
		this.checkDoWaitHp.UseVisualStyleBackColor = true;
		this.checkDoWaitHp.CheckedChanged += new System.EventHandler(checkDoWaitHp_CheckedChanged);
		this.groupBox2.Controls.Add(this.checkDoAutoboi);
		this.groupBox2.Location = new System.Drawing.Point(6, 6);
		this.groupBox2.Name = "groupBox2";
		this.groupBox2.Size = new System.Drawing.Size(118, 62);
		this.groupBox2.TabIndex = 1;
		this.groupBox2.TabStop = false;
		this.groupBox2.Text = "Общие настройки";
		this.checkDoAutoboi.AutoSize = true;
		this.checkDoAutoboi.Location = new System.Drawing.Point(6, 20);
		this.checkDoAutoboi.Name = "checkDoAutoboi";
		this.checkDoAutoboi.Size = new System.Drawing.Size(69, 17);
		this.checkDoAutoboi.TabIndex = 0;
		this.checkDoAutoboi.Text = "Автобой";
		this.checkDoAutoboi.UseVisualStyleBackColor = true;
		this.tabPageGroups.Controls.Add(this.buttonDeleteGroup);
		this.tabPageGroups.Controls.Add(this.groupBox1);
		this.tabPageGroups.Location = new System.Drawing.Point(4, 22);
		this.tabPageGroups.Name = "tabPageGroups";
		this.tabPageGroups.Size = new System.Drawing.Size(476, 283);
		this.tabPageGroups.TabIndex = 5;
		this.tabPageGroups.Text = "Группы";
		this.tabPageGroups.UseVisualStyleBackColor = true;
		this.buttonDeleteGroup.Location = new System.Drawing.Point(173, 190);
		this.buttonDeleteGroup.Name = "buttonDeleteGroup";
		this.buttonDeleteGroup.Size = new System.Drawing.Size(115, 23);
		this.buttonDeleteGroup.TabIndex = 2;
		this.buttonDeleteGroup.Text = "Удалить группу";
		this.buttonDeleteGroup.UseVisualStyleBackColor = true;
		this.buttonDeleteGroup.Click += new System.EventHandler(buttonDeleteGroup_Click);
		this.groupBox1.Controls.Add(this.linkNewGroupLevel);
		this.groupBox1.Controls.Add(this.buttonCreateGroup);
		this.groupBox1.Controls.Add(this.comboNewGroup);
		this.groupBox1.Location = new System.Drawing.Point(12, 13);
		this.groupBox1.Name = "groupBox1";
		this.groupBox1.Size = new System.Drawing.Size(448, 71);
		this.groupBox1.TabIndex = 0;
		this.groupBox1.TabStop = false;
		this.groupBox1.Text = "Создание группы";
		this.linkNewGroupLevel.AutoSize = true;
		this.linkNewGroupLevel.Location = new System.Drawing.Point(161, 30);
		this.linkNewGroupLevel.Name = "linkNewGroupLevel";
		this.linkNewGroupLevel.Size = new System.Drawing.Size(75, 13);
		this.linkNewGroupLevel.TabIndex = 8;
		this.linkNewGroupLevel.TabStop = true;
		this.linkNewGroupLevel.Text = "с 0-го уровня";
		this.linkNewGroupLevel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkNewGroupLevel_LinkClicked);
		this.buttonCreateGroup.Location = new System.Drawing.Point(309, 25);
		this.buttonCreateGroup.Name = "buttonCreateGroup";
		this.buttonCreateGroup.Size = new System.Drawing.Size(115, 23);
		this.buttonCreateGroup.TabIndex = 1;
		this.buttonCreateGroup.Text = "Создать группу";
		this.buttonCreateGroup.UseVisualStyleBackColor = true;
		this.buttonCreateGroup.Click += new System.EventHandler(buttonCreateGroup_Click);
		this.comboNewGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.comboNewGroup.FormattingEnabled = true;
		this.comboNewGroup.Location = new System.Drawing.Point(14, 27);
		this.comboNewGroup.Name = "comboNewGroup";
		this.comboNewGroup.Size = new System.Drawing.Size(140, 21);
		this.comboNewGroup.TabIndex = 0;
		this.tabRotation.Controls.Add(this.buttonFullMa);
		this.tabRotation.Controls.Add(this.buttonFullHp);
		this.tabRotation.Controls.Add(this.checkDoBlocks);
		this.tabRotation.Controls.Add(this.checkDoMagBlocks);
		this.tabRotation.Controls.Add(this.checkDoMiscAbils);
		this.tabRotation.Controls.Add(this.checkDoHits);
		this.tabRotation.Controls.Add(this.checkDoMagHits);
		this.tabRotation.Controls.Add(this.linkMagHits);
		this.tabRotation.Controls.Add(this.checkDoAbilHits);
		this.tabRotation.Controls.Add(this.checkDoRestoreMa);
		this.tabRotation.Controls.Add(this.checkDoRestoreHp);
		this.tabRotation.Controls.Add(this.checkDoAbilBlocks);
		this.tabRotation.Controls.Add(this.linkRestoreMa);
		this.tabRotation.Controls.Add(this.linkRestoreHp);
		this.tabRotation.Location = new System.Drawing.Point(4, 22);
		this.tabRotation.Name = "tabRotation";
		this.tabRotation.Padding = new System.Windows.Forms.Padding(3);
		this.tabRotation.Size = new System.Drawing.Size(476, 283);
		this.tabRotation.TabIndex = 1;
		this.tabRotation.Text = "Ротация";
		this.tabRotation.UseVisualStyleBackColor = true;
		this.buttonFullMa.Location = new System.Drawing.Point(357, 33);
		this.buttonFullMa.Name = "buttonFullMa";
		this.buttonFullMa.Size = new System.Drawing.Size(112, 23);
		this.buttonFullMa.TabIndex = 28;
		this.buttonFullMa.Text = "мана каждый ход";
		this.buttonFullMa.UseVisualStyleBackColor = true;
		this.buttonFullMa.Click += new System.EventHandler(buttonFullMa_Click);
		this.buttonFullHp.Location = new System.Drawing.Point(357, 7);
		this.buttonFullHp.Name = "buttonFullHp";
		this.buttonFullHp.Size = new System.Drawing.Size(112, 23);
		this.buttonFullHp.TabIndex = 27;
		this.buttonFullHp.Text = "жизнь каждый ход";
		this.buttonFullHp.UseVisualStyleBackColor = true;
		this.buttonFullHp.Click += new System.EventHandler(buttonFullHp_Click);
		this.checkDoBlocks.AutoSize = true;
		this.checkDoBlocks.Location = new System.Drawing.Point(13, 192);
		this.checkDoBlocks.Name = "checkDoBlocks";
		this.checkDoBlocks.Size = new System.Drawing.Size(165, 17);
		this.checkDoBlocks.TabIndex = 26;
		this.checkDoBlocks.Text = "Ставить физические блоки";
		this.checkDoBlocks.UseVisualStyleBackColor = true;
		this.checkDoMagBlocks.AutoSize = true;
		this.checkDoMagBlocks.Location = new System.Drawing.Point(13, 169);
		this.checkDoMagBlocks.Name = "checkDoMagBlocks";
		this.checkDoMagBlocks.Size = new System.Drawing.Size(163, 17);
		this.checkDoMagBlocks.TabIndex = 25;
		this.checkDoMagBlocks.Text = "Ставить магические блоки";
		this.checkDoMagBlocks.UseVisualStyleBackColor = true;
		this.checkDoMiscAbils.AutoSize = true;
		this.checkDoMiscAbils.Location = new System.Drawing.Point(13, 103);
		this.checkDoMiscAbils.Name = "checkDoMiscAbils";
		this.checkDoMiscAbils.Size = new System.Drawing.Size(194, 17);
		this.checkDoMiscAbils.TabIndex = 24;
		this.checkDoMiscAbils.Text = "Использовать остальные абилки";
		this.checkDoMiscAbils.UseVisualStyleBackColor = true;
		this.checkDoHits.AutoSize = true;
		this.checkDoHits.Location = new System.Drawing.Point(13, 146);
		this.checkDoHits.Name = "checkDoHits";
		this.checkDoHits.Size = new System.Drawing.Size(173, 17);
		this.checkDoHits.TabIndex = 22;
		this.checkDoHits.Text = "Наносить физические удары";
		this.checkDoHits.UseVisualStyleBackColor = true;
		this.checkDoMagHits.AutoSize = true;
		this.checkDoMagHits.Location = new System.Drawing.Point(13, 126);
		this.checkDoMagHits.Name = "checkDoMagHits";
		this.checkDoMagHits.Size = new System.Drawing.Size(15, 14);
		this.checkDoMagHits.TabIndex = 21;
		this.checkDoMagHits.UseVisualStyleBackColor = true;
		this.checkDoMagHits.CheckedChanged += new System.EventHandler(checkDoMagHits_CheckedChanged);
		this.linkMagHits.AutoSize = true;
		this.linkMagHits.Location = new System.Drawing.Point(29, 126);
		this.linkMagHits.Name = "linkMagHits";
		this.linkMagHits.Size = new System.Drawing.Size(171, 13);
		this.linkMagHits.TabIndex = 11;
		this.linkMagHits.TabStop = true;
		this.linkMagHits.Text = "Ставить магические удары по 5";
		this.linkMagHits.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkMagHits_LinkClicked);
		this.checkDoAbilHits.AutoSize = true;
		this.checkDoAbilHits.Location = new System.Drawing.Point(13, 80);
		this.checkDoAbilHits.Name = "checkDoAbilHits";
		this.checkDoAbilHits.Size = new System.Drawing.Size(169, 17);
		this.checkDoAbilHits.TabIndex = 20;
		this.checkDoAbilHits.Text = "Наносить абилочные удары";
		this.checkDoAbilHits.UseVisualStyleBackColor = true;
		this.checkDoRestoreMa.AutoSize = true;
		this.checkDoRestoreMa.Location = new System.Drawing.Point(13, 37);
		this.checkDoRestoreMa.Name = "checkDoRestoreMa";
		this.checkDoRestoreMa.Size = new System.Drawing.Size(15, 14);
		this.checkDoRestoreMa.TabIndex = 19;
		this.checkDoRestoreMa.UseVisualStyleBackColor = true;
		this.checkDoRestoreMa.CheckedChanged += new System.EventHandler(checkDoRestoreMa_CheckedChanged);
		this.checkDoRestoreHp.AutoSize = true;
		this.checkDoRestoreHp.Location = new System.Drawing.Point(13, 16);
		this.checkDoRestoreHp.Name = "checkDoRestoreHp";
		this.checkDoRestoreHp.Size = new System.Drawing.Size(15, 14);
		this.checkDoRestoreHp.TabIndex = 18;
		this.checkDoRestoreHp.UseVisualStyleBackColor = true;
		this.checkDoRestoreHp.CheckedChanged += new System.EventHandler(checkDoRestoreHp_CheckedChanged);
		this.checkDoAbilBlocks.AutoSize = true;
		this.checkDoAbilBlocks.Location = new System.Drawing.Point(13, 57);
		this.checkDoAbilBlocks.Name = "checkDoAbilBlocks";
		this.checkDoAbilBlocks.Size = new System.Drawing.Size(161, 17);
		this.checkDoAbilBlocks.TabIndex = 17;
		this.checkDoAbilBlocks.Text = "Ставить абилочные блоки";
		this.checkDoAbilBlocks.UseVisualStyleBackColor = true;
		this.linkRestoreMa.AutoSize = true;
		this.linkRestoreMa.Location = new System.Drawing.Point(29, 37);
		this.linkRestoreMa.Name = "linkRestoreMa";
		this.linkRestoreMa.Size = new System.Drawing.Size(282, 13);
		this.linkRestoreMa.TabIndex = 16;
		this.linkRestoreMa.TabStop = true;
		this.linkRestoreMa.Text = "Восстанавливать ману, если она ниже или равна 80%";
		this.linkRestoreMa.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkRestoreMa_LinkClicked);
		this.linkRestoreHp.AutoSize = true;
		this.linkRestoreHp.Location = new System.Drawing.Point(29, 16);
		this.linkRestoreHp.Name = "linkRestoreHp";
		this.linkRestoreHp.Size = new System.Drawing.Size(322, 13);
		this.linkRestoreHp.TabIndex = 15;
		this.linkRestoreHp.TabStop = true;
		this.linkRestoreHp.Text = "Восстанавливать жизнь, если она упала ниже или равна 80%";
		this.linkRestoreHp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkRestoreHp_LinkClicked);
		this.tabPageAbilities.Controls.Add(this.tabControl1);
		this.tabPageAbilities.Location = new System.Drawing.Point(4, 22);
		this.tabPageAbilities.Name = "tabPageAbilities";
		this.tabPageAbilities.Size = new System.Drawing.Size(476, 283);
		this.tabPageAbilities.TabIndex = 2;
		this.tabPageAbilities.Text = "Абилки";
		this.tabPageAbilities.UseVisualStyleBackColor = true;
		this.tabControl1.Controls.Add(this.tabPageMagHit);
		this.tabControl1.Controls.Add(this.tabPageMagBlock);
		this.tabControl1.Controls.Add(this.tabPageMagHp);
		this.tabControl1.Controls.Add(this.tabPageMagMa);
		this.tabControl1.Controls.Add(this.tabPageOthers);
		this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.tabControl1.Location = new System.Drawing.Point(0, 0);
		this.tabControl1.Name = "tabControl1";
		this.tabControl1.SelectedIndex = 0;
		this.tabControl1.Size = new System.Drawing.Size(476, 283);
		this.tabControl1.TabIndex = 0;
		this.tabPageMagHit.Controls.Add(this.listSpellsHits);
		this.tabPageMagHit.Location = new System.Drawing.Point(4, 22);
		this.tabPageMagHit.Name = "tabPageMagHit";
		this.tabPageMagHit.Padding = new System.Windows.Forms.Padding(3);
		this.tabPageMagHit.Size = new System.Drawing.Size(468, 257);
		this.tabPageMagHit.TabIndex = 0;
		this.tabPageMagHit.Text = "Удар";
		this.tabPageMagHit.UseVisualStyleBackColor = true;
		this.listSpellsHits.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.listSpellsHits.CheckBoxes = true;
		this.listSpellsHits.FullRowSelect = true;
		this.listSpellsHits.GridLines = true;
		this.listSpellsHits.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
		this.listSpellsHits.Location = new System.Drawing.Point(3, 3);
		this.listSpellsHits.Name = "listSpellsHits";
		this.listSpellsHits.Size = new System.Drawing.Size(300, 250);
		this.listSpellsHits.TabIndex = 0;
		this.listSpellsHits.UseCompatibleStateImageBehavior = false;
		this.listSpellsHits.View = System.Windows.Forms.View.Details;
		this.tabPageMagBlock.Controls.Add(this.listSpellsBlocks);
		this.tabPageMagBlock.Location = new System.Drawing.Point(4, 22);
		this.tabPageMagBlock.Name = "tabPageMagBlock";
		this.tabPageMagBlock.Padding = new System.Windows.Forms.Padding(3);
		this.tabPageMagBlock.Size = new System.Drawing.Size(468, 257);
		this.tabPageMagBlock.TabIndex = 1;
		this.tabPageMagBlock.Text = "Блок";
		this.tabPageMagBlock.UseVisualStyleBackColor = true;
		this.listSpellsBlocks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.listSpellsBlocks.CheckBoxes = true;
		this.listSpellsBlocks.FullRowSelect = true;
		this.listSpellsBlocks.GridLines = true;
		this.listSpellsBlocks.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
		this.listSpellsBlocks.Location = new System.Drawing.Point(3, 3);
		this.listSpellsBlocks.Name = "listSpellsBlocks";
		this.listSpellsBlocks.Size = new System.Drawing.Size(300, 250);
		this.listSpellsBlocks.TabIndex = 1;
		this.listSpellsBlocks.UseCompatibleStateImageBehavior = false;
		this.listSpellsBlocks.View = System.Windows.Forms.View.Details;
		this.tabPageMagHp.Controls.Add(this.listSpellsRestoreHp);
		this.tabPageMagHp.Location = new System.Drawing.Point(4, 22);
		this.tabPageMagHp.Name = "tabPageMagHp";
		this.tabPageMagHp.Size = new System.Drawing.Size(468, 257);
		this.tabPageMagHp.TabIndex = 2;
		this.tabPageMagHp.Text = "Жизнь";
		this.tabPageMagHp.UseVisualStyleBackColor = true;
		this.listSpellsRestoreHp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.listSpellsRestoreHp.CheckBoxes = true;
		this.listSpellsRestoreHp.FullRowSelect = true;
		this.listSpellsRestoreHp.GridLines = true;
		this.listSpellsRestoreHp.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
		this.listSpellsRestoreHp.Location = new System.Drawing.Point(3, 3);
		this.listSpellsRestoreHp.Name = "listSpellsRestoreHp";
		this.listSpellsRestoreHp.Size = new System.Drawing.Size(300, 250);
		this.listSpellsRestoreHp.TabIndex = 1;
		this.listSpellsRestoreHp.UseCompatibleStateImageBehavior = false;
		this.listSpellsRestoreHp.View = System.Windows.Forms.View.Details;
		this.tabPageMagMa.Controls.Add(this.listSpellsRestoreMa);
		this.tabPageMagMa.Location = new System.Drawing.Point(4, 22);
		this.tabPageMagMa.Name = "tabPageMagMa";
		this.tabPageMagMa.Size = new System.Drawing.Size(468, 257);
		this.tabPageMagMa.TabIndex = 3;
		this.tabPageMagMa.Text = "Мана";
		this.tabPageMagMa.UseVisualStyleBackColor = true;
		this.listSpellsRestoreMa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.listSpellsRestoreMa.CheckBoxes = true;
		this.listSpellsRestoreMa.FullRowSelect = true;
		this.listSpellsRestoreMa.GridLines = true;
		this.listSpellsRestoreMa.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
		this.listSpellsRestoreMa.Location = new System.Drawing.Point(3, 3);
		this.listSpellsRestoreMa.Name = "listSpellsRestoreMa";
		this.listSpellsRestoreMa.Size = new System.Drawing.Size(300, 250);
		this.listSpellsRestoreMa.TabIndex = 1;
		this.listSpellsRestoreMa.UseCompatibleStateImageBehavior = false;
		this.listSpellsRestoreMa.View = System.Windows.Forms.View.Details;
		this.tabPageOthers.Controls.Add(this.listSpellsMisc);
		this.tabPageOthers.Location = new System.Drawing.Point(4, 22);
		this.tabPageOthers.Name = "tabPageOthers";
		this.tabPageOthers.Size = new System.Drawing.Size(468, 257);
		this.tabPageOthers.TabIndex = 4;
		this.tabPageOthers.Text = "Другое";
		this.tabPageOthers.UseVisualStyleBackColor = true;
		this.listSpellsMisc.CheckBoxes = true;
		this.listSpellsMisc.FullRowSelect = true;
		this.listSpellsMisc.GridLines = true;
		this.listSpellsMisc.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
		this.listSpellsMisc.Location = new System.Drawing.Point(3, 3);
		this.listSpellsMisc.Name = "listSpellsMisc";
		this.listSpellsMisc.Size = new System.Drawing.Size(300, 250);
		this.listSpellsMisc.TabIndex = 1;
		this.listSpellsMisc.UseCompatibleStateImageBehavior = false;
		this.listSpellsMisc.View = System.Windows.Forms.View.Details;
		this.tabPageStop.Controls.Add(this.checkDoExitRisky);
		this.tabPageStop.Controls.Add(this.checkDoExit);
		this.tabPageStop.Controls.Add(this.checkDoStopNow);
		this.tabPageStop.Controls.Add(this.checkDoStopLowMa);
		this.tabPageStop.Controls.Add(this.checkDoStopLowHp);
		this.tabPageStop.Controls.Add(this.linkStopLowMa);
		this.tabPageStop.Controls.Add(this.linkStopLowHp);
		this.tabPageStop.Location = new System.Drawing.Point(4, 22);
		this.tabPageStop.Name = "tabPageStop";
		this.tabPageStop.Size = new System.Drawing.Size(476, 283);
		this.tabPageStop.TabIndex = 4;
		this.tabPageStop.Text = "Останов боя";
		this.tabPageStop.UseVisualStyleBackColor = true;
		this.checkDoExitRisky.AutoSize = true;
		this.checkDoExitRisky.Location = new System.Drawing.Point(17, 127);
		this.checkDoExitRisky.Name = "checkDoExitRisky";
		this.checkDoExitRisky.Size = new System.Drawing.Size(376, 17);
		this.checkDoExitRisky.TabIndex = 14;
		this.checkDoExitRisky.Text = "Выйти из игры, если бой кровавый или боевой (только с человеком)";
		this.checkDoExitRisky.UseVisualStyleBackColor = true;
		this.checkDoExit.AutoSize = true;
		this.checkDoExit.Location = new System.Drawing.Point(17, 104);
		this.checkDoExit.Name = "checkDoExit";
		this.checkDoExit.Size = new System.Drawing.Size(213, 17);
		this.checkDoExit.TabIndex = 13;
		this.checkDoExit.Text = "Если бой остановлен, выйти из игры";
		this.checkDoExit.UseVisualStyleBackColor = true;
		this.checkDoStopNow.AutoSize = true;
		this.checkDoStopNow.Location = new System.Drawing.Point(17, 18);
		this.checkDoStopNow.Name = "checkDoStopNow";
		this.checkDoStopNow.Size = new System.Drawing.Size(139, 17);
		this.checkDoStopNow.TabIndex = 12;
		this.checkDoStopNow.Text = "Остановить бой сразу";
		this.checkDoStopNow.UseVisualStyleBackColor = true;
		this.checkDoStopLowMa.AutoSize = true;
		this.checkDoStopLowMa.Location = new System.Drawing.Point(17, 72);
		this.checkDoStopLowMa.Name = "checkDoStopLowMa";
		this.checkDoStopLowMa.Size = new System.Drawing.Size(15, 14);
		this.checkDoStopLowMa.TabIndex = 11;
		this.checkDoStopLowMa.UseVisualStyleBackColor = true;
		this.checkDoStopLowMa.CheckedChanged += new System.EventHandler(checkDoStopLowMa_CheckedChanged);
		this.checkDoStopLowHp.AutoSize = true;
		this.checkDoStopLowHp.Location = new System.Drawing.Point(17, 50);
		this.checkDoStopLowHp.Name = "checkDoStopLowHp";
		this.checkDoStopLowHp.Size = new System.Drawing.Size(15, 14);
		this.checkDoStopLowHp.TabIndex = 10;
		this.checkDoStopLowHp.UseVisualStyleBackColor = true;
		this.checkDoStopLowHp.CheckedChanged += new System.EventHandler(checkDoStopLowHp_CheckedChanged);
		this.linkStopLowMa.AutoSize = true;
		this.linkStopLowMa.Location = new System.Drawing.Point(34, 72);
		this.linkStopLowMa.Name = "linkStopLowMa";
		this.linkStopLowMa.Size = new System.Drawing.Size(238, 13);
		this.linkStopLowMa.TabIndex = 6;
		this.linkStopLowMa.TabStop = true;
		this.linkStopLowMa.Text = "Остановить бой, если мана до 50% или ниже";
		this.linkStopLowMa.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkStopLowMa_LinkClicked);
		this.linkStopLowHp.AutoSize = true;
		this.linkStopLowHp.Location = new System.Drawing.Point(34, 50);
		this.linkStopLowHp.Name = "linkStopLowHp";
		this.linkStopLowHp.Size = new System.Drawing.Size(278, 13);
		this.linkStopLowHp.TabIndex = 5;
		this.linkStopLowHp.TabStop = true;
		this.linkStopLowHp.Text = "Остановить бой, если жизнь упала до 50% или ниже";
		this.linkStopLowHp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkStopLowHp_LinkClicked);
		this.buttonOk.Location = new System.Drawing.Point(417, 327);
		this.buttonOk.Name = "buttonOk";
		this.buttonOk.Size = new System.Drawing.Size(75, 23);
		this.buttonOk.TabIndex = 2;
		this.buttonOk.Text = "Ok";
		this.buttonOk.UseVisualStyleBackColor = true;
		this.buttonOk.Click += new System.EventHandler(buttonOk_Click);
		this.buttonCancel.Location = new System.Drawing.Point(498, 327);
		this.buttonCancel.Name = "buttonCancel";
		this.buttonCancel.Size = new System.Drawing.Size(75, 23);
		this.buttonCancel.TabIndex = 3;
		this.buttonCancel.Text = "Отмена";
		this.buttonCancel.UseVisualStyleBackColor = true;
		this.buttonCancel.Click += new System.EventHandler(buttonCancel_Click);
		this.buttonApply.Location = new System.Drawing.Point(579, 327);
		this.buttonApply.Name = "buttonApply";
		this.buttonApply.Size = new System.Drawing.Size(75, 23);
		this.buttonApply.TabIndex = 4;
		this.buttonApply.Text = "Запомнить";
		this.buttonApply.UseVisualStyleBackColor = true;
		this.buttonApply.Click += new System.EventHandler(buttonApply_Click);
		this.listGroups.Dock = System.Windows.Forms.DockStyle.Left;
		this.listGroups.FormattingEnabled = true;
		this.listGroups.Location = new System.Drawing.Point(0, 0);
		this.listGroups.Name = "listGroups";
		this.listGroups.Size = new System.Drawing.Size(167, 358);
		this.listGroups.TabIndex = 5;
		this.listGroups.SelectedIndexChanged += new System.EventHandler(listGroups_SelectedIndexChanged);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(662, 358);
		base.Controls.Add(this.listGroups);
		base.Controls.Add(this.buttonApply);
		base.Controls.Add(this.buttonCancel);
		base.Controls.Add(this.buttonOk);
		base.Controls.Add(this.tabControlGeneral);
		this.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "FormSettingsAb";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Настройки автобоя";
		base.Load += new System.EventHandler(FormSettingsAb_Load);
		this.tabControlGeneral.ResumeLayout(false);
		this.tabPageGeneral.ResumeLayout(false);
		this.groupBox4.ResumeLayout(false);
		this.groupBox4.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		this.groupBox9.ResumeLayout(false);
		this.groupBox9.PerformLayout();
		this.groupBox15.ResumeLayout(false);
		this.groupBox15.PerformLayout();
		this.groupBox3.ResumeLayout(false);
		this.groupBox3.PerformLayout();
		this.groupBox2.ResumeLayout(false);
		this.groupBox2.PerformLayout();
		this.tabPageGroups.ResumeLayout(false);
		this.groupBox1.ResumeLayout(false);
		this.groupBox1.PerformLayout();
		this.tabRotation.ResumeLayout(false);
		this.tabRotation.PerformLayout();
		this.tabPageAbilities.ResumeLayout(false);
		this.tabControl1.ResumeLayout(false);
		this.tabPageMagHit.ResumeLayout(false);
		this.tabPageMagBlock.ResumeLayout(false);
		this.tabPageMagHp.ResumeLayout(false);
		this.tabPageMagMa.ResumeLayout(false);
		this.tabPageOthers.ResumeLayout(false);
		this.tabPageStop.ResumeLayout(false);
		this.tabPageStop.PerformLayout();
		base.ResumeLayout(false);
	}
}
