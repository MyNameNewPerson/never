using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using ABClient.APIForms;
using ABClient.AppControls;
using ABClient.ExtMap;
using ABClient.Lez;
using ABClient.MyForms;
using ABClient.PostFilter;

namespace ABClient.ABForms;

internal sealed class FormMain : Form
{
	private sealed class Class92
	{
		public FormMain formMain_0;

		public string string_0;

		public string string_1;

		public int int_0;

		internal void method_0()
		{
			formMain_0.method_19(string_0, string_1, int_0);
		}
	}

	private sealed class Class93
	{
		public FormMain formMain_0;

		public string string_0;

		internal void method_0()
		{
			formMain_0.method_63(string_0);
		}
	}

	private sealed class Class94
	{
		public FormMain formMain_0;

		public string string_0;

		internal void method_0()
		{
			formMain_0.method_79(string_0);
		}
	}

	private sealed class Class95
	{
		public FormMain formMain_0;

		public string string_0;

		internal void method_0()
		{
			formMain_0.method_88(string_0);
		}
	}

	private sealed class Class96
	{
		public FormMain formMain_0;

		public string string_0;

		internal void method_0()
		{
			formMain_0.method_80(string_0);
		}
	}

	private sealed class Class97
	{
		public FormMain formMain_0;

		public string string_0;

		internal void method_0()
		{
			formMain_0.method_105(string_0);
		}
	}

	private sealed class Class98
	{
		public FormMain formMain_0;

		public string string_0;

		internal void method_0()
		{
			formMain_0.method_123(string_0);
		}
	}

	private sealed class Class99
	{
		public FormMain formMain_0;

		public long long_0;

		internal void method_0()
		{
			formMain_0.method_131(long_0);
		}
	}

	private sealed class Class100
	{
		public FormMain formMain_0;

		public int int_0;

		internal void method_0()
		{
			formMain_0.method_132(int_0);
		}
	}

	private sealed class Class101
	{
		internal string string_0;

		internal string string_1;
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		public static EventHandler _003C_003E9__616_0;

		internal void method_0(object sender, EventArgs e)
		{
			Class72.class19_0.method_121(((TextBox)sender).Text);
		}
	}

	private static readonly ReaderWriterLock readerWriterLock_0;

	private static readonly ReaderWriterLock readerWriterLock_1;

	internal static readonly ReaderWriterLock readerWriterLock_2;

	private static readonly ReaderWriterLock readerWriterLock_3;

	private FormWindowState formWindowState_0;

	private StatusStrip statusStrip;

	private CollapsibleSplitter collapsibleSplitter;

	private Panel panelRight;

	private TabControl tabControlLeft;

	private TabPage tabPageGame;

	private ToolStripDropDownButton dropdownCurrentStat;

	private ToolStripMenuItem menuitemStatItem0;

	private ToolStripButton toolStripButton1;

	private ToolStripMenuItem toolStripMenuItem2;

	private ToolStripMenuItem menuitemStatItem1;

	private MenuStrip menuStrip;

	private ToolStripMenuItem menuitemGame;

	private ToolStripMenuItem menuitemGameExit;

	private ToolStrip toolbarGame;

	private IContainer icontainer_0;

	private ImageList imageList_0;

	private ToolStripMenuItem menuitemStatEdit;

	private ToolStripStatusLabel statuslabelActivity;

	private SaveFileDialog saveFileDialog_0;

	private ImageList imageList_1;

	private ToolStripMenuItem menuitemTabs;

	private ToolStripMenuItem menuitemOpenForum;

	private ToolStripStatusLabel labelAddress;

	private ToolStripMenuItem menuitemOpenTab;

	private ToolStripMenuItem menuitemOpenNotepad;

	private ToolStripButton buttonGameScreen;

	private ToolStripButton buttonGameLogOn;

	private ToolStripMenuItem menuitemGameLogOn;

	private ToolStripMenuItem menuitemSystem;

	private ToolStripSeparator toolStripSeparator3;

	private ToolStripMenuItem menuitemAbout;

	private ToolStripStatusLabel statuslabelLocation;

	private System.Windows.Forms.Timer timer_0;

	private ToolStripButton buttonAutoboi;

	private ToolStripSeparator toolStripSeparator4;

	private ToolStripMenuItem menuitemCommands;

	private ToolStripMenuItem menuitemClanPrivate;

	private ToolStripStatusLabel statuslabelTied;

	private ToolStripMenuItem menuitemStatItem2;

	private ToolStripMenuItem menuitemStatItem3;

	private ToolStripButton buttonDrink;

	private ToolStripSeparator toolStripSeparator6;

	private ToolStripButton buttonNavigator;

	private ImageList imageList_2;

	private NotifyIcon notifyIcon_0;

	private System.Windows.Forms.Timer timer_1;

	private ContextMenuStrip cmTray;

	private ToolStripMenuItem menuitemRestoreWindow;

	private ToolStripMenuItem menuitemTrayQuit;

	private ToolStripButton buttonAutoFish;

	private ToolStripButton buttonWalkers;

	private ToolStripMenuItem miRemoveGroup;

	private ToolStripMenuItem cmtsDeleteContact;

	private ToolStripMenuItem cmtsContactPrivate;

	internal ContextMenuStrip CmPerson;

	internal ImageList imageList_3;

	internal ContextMenuStrip CmGroup;

	private ToolStripDropDownButton dropdownPv;

	private ToolStripButton buttonAutoAdv;

	private ToolStripStatusLabel statuslabelAutoAdv;

	private ToolStripMenuItem menuitemStatItem4;

	private ToolStripMenuItem menuitemMinimize;

	private ToolStripDropDownButton dropdownTimers;

	private ToolStripStatusLabel statuslabelClock;

	private System.Windows.Forms.Timer timer_2;

	private ToolStripMenuItem menuitemNewTimer;

	private ToolStripStatusLabel toolStripStatusLabel1;

	private ToolStripDropDownButton dropdownTravm;

	private ToolStripMenuItem toolStripMenuItem_0;

	private ToolStripMenuItem toolStripMenuItem_1;

	private ToolStripMenuItem toolStripMenuItem_2;

	private ToolStripSeparator toolStripSeparator13;

	private ToolStripMenuItem toolStripMenuItem_3;

	private ToolStripMenuItem toolStripMenuItem_4;

	private ToolStripMenuItem toolStripMenuItem_5;

	private ToolStripSeparator toolStripSeparator14;

	private ToolStripMenuItem toolStripMenuItem_6;

	private ToolStripMenuItem toolStripMenuItem_7;

	private ToolStripSeparator toolStripSeparator15;

	private ToolStripSeparator toolStripSeparator16;

	private ToolStripButton buttonAutoAnswer;

	private ToolStripMenuItem menuitemTools;

	private ToolStripMenuItem menuitemFishAdvisor;

	private ToolStripButton buttonSilence;

	private ToolStripSeparator toolStripSeparator5;

	private Panel panelGame;

	private ExtendedWebBrowser browserGame;

	private ToolStripSeparator toolStripSeparator10;

	private ToolStripSeparator toolStripSeparator12;

	private ToolStripMenuItem miFastEnabled;

	private ToolStripMenuItem miFastTeleport;

	private ToolStripMenuItem miFastElxVosst;

	private ToolStripMenuItem miFastF3;

	private ToolStripMenuItem miFastF4;

	private ToolStripMenuItem miFastF12;

	private ToolStripMenuItem miFastSvitFog;

	private ToolStripMenuItem miFastF9;

	private ToolStripMenuItem miFastF10;

	private ToolStripMenuItem menuitemSettingsGeneral;

	private ToolStripSeparator toolStripSeparator17;

	private ToolStripSeparator toolStripSeparator11;

	private ToolStripMenuItem miQuick;

	private ToolStripSeparator toolStripSeparator19;

	private ToolStripMenuItem cmtsContactQuick;

	private ToolStripSeparator toolStripSeparator20;

	private ToolStripMenuItem miWearAfter;

	private ToolStripMenuItem miFastSviRass;

	private ToolStripMenuItem miQuickCancel;

	private ToolStripMenuItem cmtsClassNeutral;

	private ToolStripMenuItem cmtsClassFoe;

	private ToolStripMenuItem cmtsClassFriend;

	private ToolStripSeparator toolStripSeparator9;

	private ToolStripMenuItem miSetGroupNeutral;

	private ToolStripMenuItem miSetGroupFoe;

	private ToolStripMenuItem miSetGroupFriend;

	private ToolStripSeparator toolStripSeparator21;

	private ToolStripButton buttonAutoRefresh;

	private ToolStripButton buttonWaitOpen;

	private ToolStripButton buttonOpenNevid;

	private ToolStripSeparator toolStripSeparator23;

	private ToolStripSeparator toolStripSeparator18;

	private ToolStripMenuItem cmtsToolId0;

	private ToolStripMenuItem cmtsToolId1;

	private ToolStripMenuItem cmtsToolId2;

	private ToolStripMenuItem cmtsToolId3;

	private ToolStripMenuItem cmtsToolId4;

	private ToolStripMenuItem miSetGroupToolId0;

	private ToolStripMenuItem miSetGroupToolId1;

	private ToolStripMenuItem miSetGroupToolId2;

	private ToolStripMenuItem miSetGroupToolId3;

	private ToolStripMenuItem miSetGroupToolId4;

	private ToolStripSeparator toolStripSeparator24;

	private ToolStripSplitButton buttonAutoAttack;

	private ToolStripMenuItem miAutoAttack0;

	private ToolStripMenuItem miAutoAttack1;

	private ToolStripMenuItem miAutoAttack2;

	private ToolStripMenuItem miAutoAttack3;

	private ToolStripMenuItem miAutoAttack4;

	private System.Windows.Forms.Timer timer_3;

	private ToolStripMenuItem menuitemOpenTodayChat;

	private ToolStripMenuItem miFastDarkTeleport;

	private ToolStripMenuItem miFastDarkFog;

	private ToolStripButton buttonPerenap;

	private ToolStripButton buttonSelfNevid;

	private ToolStripSeparator toolStripSeparator2;

	private ToolStripMenuItem menuitemDoSearchBox;

	private ToolStripSeparator toolStripSeparator7;

	private ToolStripMenuItem menuitemDoResetVisitedCells;

	private System.Windows.Forms.Timer timer_4;

	private ToolStripMenuItem miFastSviSelfRass;

	private ToolStripButton buttonFury;

	private ToolStripMenuItem menuitemSettingsAb;

	private ToolStripStatusLabel statuslabelNumberOfThreads;

	private ToolStripSeparator toolStripSeparator22;

	private ToolStripButton buttonAutoSkin;

	private ToolStripMenuItem mapScanToolStripMenuItem;

	private TabControl tabControlRight;

	private TabPage tabPageContacts;

	private TreeViewEx treeContacts;

	private CollapsibleSplitter collapsibleSplitterContacts;

	private TextBox tbContactDetails;

	private ToolStrip toolStrip3;

	private ToolStripButton tsContactTrace;

	private ToolStripSeparator toolStripSeparator8;

	private ToolStripButton tsDeleteContact;

	private ToolStripButton tsContactPrivate;

	private TabPage tabPageTextLog;

	private Panel panelTexLog;

	private TextBox textboxTexLog;

	private ToolStrip toolStrip1;

	private ToolStripButton buttonDoTexLog;

	private ToolStripButton buttonClearTexLog;

	private ToolStripMenuItem menuitemCheckCell;

	private ToolStripMenuItem menuitemShowCookies;

	private ToolStripMenuItem menuitemMainFrameInspector;

	private ToolStripMenuItem menuitemCacheRefresh;

	private System.Windows.Forms.Timer timer_5;

	private ToolStripDropDownButton ClanKaznaViewButton;

	private ToolStripMenuItem ClanKaznaViewAll;

	private ToolStripMenuItem ClanKaznaViewRAR;

	private ToolStripMenuItem ClanKaznaViewART;

	private ToolStripSeparator toolStripSeparator1;

	private ToolStripMenuItem menuItemTurotor;

	private ToolStripSeparator toolStripSeparator25;

	private ToolStripButton buttonAutoDNV;

	private System.Windows.Forms.Timer timer_6;

	private ToolStripButton CraftButton;

	private ToolStripMenuItem checkLicToolStripMenuItem;

	private ToolStripButton buttonAutoMine;

	private ToolStripDropDownButton dropDownMineStat;

	private ToolStripStatusLabel toolStripStatusLabel2;

	private ToolStripMenuItem miAutoAttack5;

	private ToolStripMenuItem miAutoAttack6;

	private ToolStripMenuItem cmtsFightLog;

	private ToolStripSeparator toolStripSeparator26;

	private ToolStripButton buttonFriendsInvis;

	private ToolStripButton buttonLocationCure;

	private TabPage tabPageComplects;

	private GroupBox groupBoxCreate;

	private Label label1;

	private TextBox textBoxComplectName;

	private Button buttonCreateStart;

	private Button buttonCreateFinish;

	private ListBox listBoxComplects;

	private CheckBox checkBoxWear;

	private Button buttonGet;

	private Button buttonDelete;

	private CheckBox checkLocCureOnlyFriends;

	private ToolStripButton buttonDisableSysMsg;

	private ToolStripMenuItem menuItemResetPlants;

	private ToolStripButton CraftAllButton;

	private ToolStripMenuItem aPIToolStripMenuItem;

	private ToolStripMenuItem ForpostBuildingsToolStripMenuItem;

	private TabPage tabPageMine;

	private Button button4;

	private GroupBox groupBox1;

	private Button button3;

	private Button button2;

	private Button button1;

	private TabPage tabPageDrinkSets;

	private GroupBox groupBox2;

	private TextBox DrinkSetName;

	private Button DrinkSetAddButton;

	private ComboBox DrinkSetItemsMenu;

	private NumericUpDown DrinkSetItemUsesAmount;

	private Label label2;

	private Button DrinkSetItemAddButton;

	private ListBox DrinkSetsNames;

	private TextBox DrinkSetComposition;

	private Button DrinkSetDelete;

	private Button DrinkSetUse;

	private Button DrinkSetSave;

	private ToolStripButton autoForestButton;

	private System.Windows.Forms.Timer timer_7;

	private GroupBox groupBox3;

	private Button FortBuffsSave;

	private TextBox FortBuffsCells;

	private Button FortBuffsCollect;

	private ToolStripDropDownButton teleportDropDown;

	private ToolStripMenuItem tpLocation1;

	private ToolStripMenuItem tpLocation2;

	private ToolStripMenuItem tpLocation3;

	private ToolStripMenuItem tpLocation4;

	private ToolStripMenuItem tpLocation5;

	private ToolStripMenuItem tpLocation6;

	private ToolStripMenuItem tpLocation7;

	private ToolStripMenuItem tpLocation8;

	private ToolStripMenuItem tpLocation9;

	private ToolStripMenuItem tpLocation10;

	private ToolStripMenuItem tpLocation11;

	private ToolStripMenuItem tpLocation12;

	private ToolStripMenuItem CityHallMenuItem;

	private ToolStripButton MakeEnemyContactsNeutralButton;

	private int int_0;

	private readonly Icon[] icon_0 = new Icon[2];

	private DateTime dateTime_0 = DateTime.Now;

	internal FormMain()
	{
		InitializeComponent();
		method_116();
	}

	static FormMain()
	{
		readerWriterLock_0 = new ReaderWriterLock();
		readerWriterLock_1 = new ReaderWriterLock();
		readerWriterLock_2 = new ReaderWriterLock();
		readerWriterLock_3 = new ReaderWriterLock();
	}

	private void miAutoAttack6_Click(object sender, EventArgs e)
	{
		if (!int.TryParse((string)((ToolStripMenuItem)sender).Tag, out var result))
		{
			result = 0;
		}
		Class72.smethod_143(result);
		buttonAutoAttack.Text = ((ToolStripMenuItem)sender).Text;
		buttonAutoAttack.ToolTipText = ((ToolStripMenuItem)sender).ToolTipText;
		buttonAutoAttack.Image = ((ToolStripMenuItem)sender).Image;
		if (result != 0)
		{
			buttonWalkers.Checked = true;
			method_38(bool_0: true);
		}
	}

	internal void method_0(string string_0, string string_1, bool bool_0)
	{
		Class72.string_31 = string_0;
		Class72.string_32 = string_1;
		Class72.bool_26 = bool_0;
		try
		{
			if (Class72.formMain_0 != null)
			{
				Class72.formMain_0.BeginInvoke(new Delegate20(Class72.formMain_0.method_110), new object[0]);
			}
		}
		catch (InvalidOperationException)
		{
		}
	}

	internal void method_1(string string_0, string string_1)
	{
		Class72.string_36 = string_0;
		Class72.string_37 = string_1;
		foreach (ShopEntry item in Class72.list_0)
		{
			if ((!string.IsNullOrEmpty(item.Name) && item.Name.Equals(string_0, StringComparison.CurrentCultureIgnoreCase)) || (!string.IsNullOrEmpty(item.Price) && item.Price.Equals(string_1, StringComparison.CurrentCultureIgnoreCase)))
			{
				method_63("Сдаём " + item.Name + " за " + item.Price + " NV...");
				break;
			}
		}
	}

	internal void method_2(string string_0, string string_1, string string_2, string string_3)
	{
		Class72.string_36 = string_0;
		Class72.string_37 = string_1;
		Class72.string_39 = string_3;
		Class72.string_40 = string_2;
		foreach (ShopEntry item in Class72.list_0)
		{
			if ((!string.IsNullOrEmpty(item.Name) && item.Name.Equals(string_0, StringComparison.CurrentCultureIgnoreCase)) || (!string.IsNullOrEmpty(item.Price) && item.Price.Equals(string_1, StringComparison.CurrentCultureIgnoreCase)))
			{
				method_63("Выставляем " + string_0 + " за " + string_3 + " NV...");
				break;
			}
		}
	}

	private static void smethod_0()
	{
		ThreadPool.QueueUserWorkItem(smethod_2, null);
	}

	private static int[] smethod_1(string string_0)
	{
		int[] array = new int[4];
		string text = Class12.smethod_1(string_0, "var eff = [[", "]];");
		if (string.IsNullOrEmpty(text))
		{
			return array;
		}
		string[] array2 = text.Split(new string[1] { "],[" }, StringSplitOptions.RemoveEmptyEntries);
		if (array2.Length == 0)
		{
			return array;
		}
		string[] array3 = array2;
		for (int i = 0; i < array3.Length; i++)
		{
			string[] array4 = array3[i].Split(',');
			if (array4.Length == 2)
			{
				switch (array4[0])
				{
				case "24":
					array[0]++;
					break;
				case "4":
					array[1]++;
					break;
				case "3":
					array[2]++;
					break;
				case "2":
					array[3]++;
					break;
				}
			}
		}
		return array;
	}

	private static void smethod_2(object object_0)
	{
		if (string.IsNullOrEmpty(Class72.class19_0.method_30()))
		{
			return;
		}
		string text = Class21.smethod_0(Class72.class19_0.method_30());
		if (string.IsNullOrEmpty(text))
		{
			return;
		}
		int[] array = smethod_1(text);
		if (array[0] <= Class72.smethod_146()[0] && array[1] <= Class72.smethod_146()[1] && array[2] <= Class72.smethod_146()[2] && array[3] <= Class72.smethod_146()[3])
		{
			return;
		}
		Class72.smethod_147(array);
		try
		{
			if (Class72.formMain_0 != null)
			{
				Class72.formMain_0.BeginInvoke(new Delegate20(Class72.formMain_0.method_110), new object[0]);
			}
		}
		catch (InvalidOperationException)
		{
		}
	}

	internal void method_3()
	{
		string text = textBoxComplectName.Text.Trim();
		if (string.IsNullOrEmpty(text))
		{
			method_63("<span style='color:red'>Создание комплекта не завершено. Введите имя комплекта.</span>");
			return;
		}
		if (string.IsNullOrEmpty(Class72.string_45))
		{
			method_63("<span style='color:red'>Создание комплекта не завершено. Не выбрано ни одной вещи.</span>");
			return;
		}
		if (Class72.dictionary_2.ContainsKey(text))
		{
			method_63("<span style='color:red'>Создание комплекта не завершено. Комплект с таким именем уже существует.</span>");
			return;
		}
		textBoxComplectName.Clear();
		Class72.dictionary_2.Add(text, Class72.string_45);
		List<string> dataSource = new List<string>(Class72.dictionary_2.Keys);
		listBoxComplects.DataSource = dataSource;
		method_7();
		Class72.string_45 = string.Empty;
		Class72.bool_45 = false;
		buttonCreateFinish.Enabled = false;
		buttonCreateStart.Enabled = true;
	}

	internal void method_4()
	{
		object selectedItem = listBoxComplects.SelectedItem;
		if (selectedItem == null)
		{
			method_63("<span style='color:red'>Выберите комплект.</span>");
			return;
		}
		if (checkBoxWear.Checked)
		{
			Class72.string_33 = selectedItem.ToString();
		}
		Class72.string_46 = Class72.dictionary_2[selectedItem.ToString()];
		smethod_56();
	}

	internal void method_5()
	{
		object selectedItem = listBoxComplects.SelectedItem;
		if (selectedItem == null)
		{
			method_63("<span style='color:red'>Выберите комплект для удаления.</span>");
			return;
		}
		string key = selectedItem.ToString();
		Class72.dictionary_2.Remove(key);
		List<string> dataSource = new List<string>(Class72.dictionary_2.Keys);
		listBoxComplects.DataSource = dataSource;
		method_7();
	}

	internal void method_6()
	{
		try
		{
			if (!File.Exists("complects.xml"))
			{
				return;
			}
			string xml;
			try
			{
				xml = File.ReadAllText("complects.xml", Encoding.UTF8);
			}
			catch
			{
				return;
			}
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml(xml);
			foreach (XmlNode item in xmlDocument.GetElementsByTagName("complect"))
			{
				if (item.Attributes != null)
				{
					string value = item.Attributes["name"].Value;
					string value2 = item.Attributes["ids"].Value;
					Class72.dictionary_2.Add(value, value2);
				}
			}
			List<string> dataSource = new List<string>(Class72.dictionary_2.Keys);
			listBoxComplects.DataSource = dataSource;
		}
		catch
		{
		}
	}

	internal void method_7()
	{
		try
		{
			XmlWriterSettings settings = new XmlWriterSettings
			{
				Indent = true
			};
			MemoryStream memoryStream = new MemoryStream();
			XmlWriter xmlWriter = XmlWriter.Create(memoryStream, settings);
			xmlWriter.WriteStartDocument();
			xmlWriter.WriteStartElement("complects");
			foreach (KeyValuePair<string, string> item in Class72.dictionary_2)
			{
				xmlWriter.WriteStartElement("complect");
				xmlWriter.WriteStartAttribute("name");
				xmlWriter.WriteString(item.Key);
				xmlWriter.WriteEndAttribute();
				xmlWriter.WriteStartAttribute("ids");
				xmlWriter.WriteString(item.Value);
				xmlWriter.WriteEndAttribute();
				xmlWriter.WriteEndElement();
			}
			xmlWriter.WriteEndElement();
			xmlWriter.WriteEndDocument();
			xmlWriter.Flush();
			try
			{
				FileStream fileStream = new FileStream("complects.xml", FileMode.Create);
				memoryStream.WriteTo(fileStream);
				fileStream.Close();
				memoryStream.Close();
			}
			catch
			{
			}
		}
		catch
		{
		}
	}

	internal void method_8()
	{
		string text = DrinkSetName.Text.Trim();
		if (string.IsNullOrEmpty(text))
		{
			method_11("Невозможно создать сет с пустым именем. Введите имя сета в поле над кнопкой.");
			return;
		}
		if (Class72.dictionary_4.ContainsKey(text))
		{
			method_11("Сет с таким именем уже существует. Используйте другое имя.");
			return;
		}
		DrinkSetName.Clear();
		Class72.dictionary_4.Add(text, string.Empty);
		method_9();
		method_17();
	}

	internal void method_9()
	{
		DrinkSetsNames.DataSource = new List<string>(Class72.dictionary_4.Keys);
	}

	internal void method_10()
	{
		string key = DrinkSetsNames.SelectedItem.ToString();
		DrinkSetComposition.Text = (Class72.dictionary_4.ContainsKey(key) ? Class72.dictionary_4[key] : string.Empty);
	}

	internal void method_11(string string_0)
	{
		method_63("<span style='color:red'>[ERROR]</span> " + string_0);
	}

	internal void method_12()
	{
		string text = DrinkSetsNames.SelectedItem.ToString();
		if (string.IsNullOrEmpty(text))
		{
			method_11("Для добавления элемента в сет, выберите имя сета из поля ниже.");
			return;
		}
		string text2 = DrinkSetItemsMenu.Text;
		if (string.IsNullOrEmpty(text2))
		{
			method_11("Для добавления элемента в сет, выберите имя элемента из выпадающего списка.");
			return;
		}
		int num = (int)DrinkSetItemUsesAmount.Value;
		if (num >= 1 && num <= 99)
		{
			string text3 = Class72.dictionary_4[text];
			if (!string.IsNullOrEmpty(text3))
			{
				text3 += "|";
			}
			text3 += $"{text2}:{num}";
			Class72.dictionary_4[text] = text3;
			method_10();
			method_17();
		}
		else
		{
			method_11("Для добавления элемента в сет, укажите количество использований от 1 до 99.");
		}
	}

	internal void method_13()
	{
		string text = DrinkSetsNames.SelectedItem.ToString();
		if (string.IsNullOrEmpty(text))
		{
			method_11("Выберите имя сета чтобы сохранить список элементов.");
			return;
		}
		Class72.dictionary_4[text] = DrinkSetComposition.Text;
		method_17();
	}

	internal void method_14()
	{
		string text = DrinkSetsNames.SelectedItem.ToString();
		if (string.IsNullOrEmpty(text))
		{
			method_11("Выберите имя сета чтобы удалить.");
			return;
		}
		Class72.dictionary_4.Remove(text);
		method_9();
		method_17();
	}

	internal void method_15()
	{
		string text = DrinkSetsNames.SelectedItem.ToString();
		if (string.IsNullOrEmpty(text))
		{
			method_11("Выберите имя сета чтобы использовать.");
			return;
		}
		Class72.string_53 = Class72.dictionary_4[text];
		smethod_56();
	}

	internal void method_16()
	{
		try
		{
			if (!File.Exists("drinkSets.xml"))
			{
				return;
			}
			string xml;
			try
			{
				xml = File.ReadAllText("drinkSets.xml", Encoding.UTF8);
			}
			catch
			{
				return;
			}
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml(xml);
			foreach (XmlNode item in xmlDocument.GetElementsByTagName("drinkSet"))
			{
				if (item.Attributes != null)
				{
					string value = item.Attributes["name"].Value;
					string value2 = item.Attributes["composition"].Value;
					Class72.dictionary_4.Add(value, value2);
				}
			}
			TextBox fortBuffsCells = FortBuffsCells;
			XmlNode xmlNode2 = xmlDocument.GetElementsByTagName("fortBuffsCells")[0];
			object obj2;
			if (xmlNode2 == null)
			{
				obj2 = null;
			}
			else
			{
				obj2 = xmlNode2.InnerText;
				if (obj2 != null)
				{
					goto IL_00e2;
				}
			}
			obj2 = string.Empty;
			goto IL_00e2;
			IL_00e2:
			fortBuffsCells.Text = (string)obj2;
			method_9();
		}
		catch
		{
		}
	}

	internal void method_17()
	{
		try
		{
			XmlWriterSettings settings = new XmlWriterSettings
			{
				Indent = true
			};
			MemoryStream memoryStream = new MemoryStream();
			XmlWriter xmlWriter = XmlWriter.Create(memoryStream, settings);
			xmlWriter.WriteStartDocument();
			xmlWriter.WriteStartElement("drinkSets");
			foreach (KeyValuePair<string, string> item in Class72.dictionary_4)
			{
				xmlWriter.WriteStartElement("drinkSet");
				xmlWriter.WriteStartAttribute("name");
				xmlWriter.WriteString(item.Key);
				xmlWriter.WriteEndAttribute();
				xmlWriter.WriteStartAttribute("composition");
				xmlWriter.WriteString(item.Value);
				xmlWriter.WriteEndAttribute();
				xmlWriter.WriteEndElement();
			}
			xmlWriter.WriteStartElement("fortBuffsCells");
			xmlWriter.WriteValue(FortBuffsCells.Text.Trim());
			xmlWriter.WriteEndElement();
			xmlWriter.WriteEndElement();
			xmlWriter.WriteEndDocument();
			xmlWriter.Flush();
			FileStream fileStream = new FileStream("drinkSets.xml", FileMode.Create);
			memoryStream.WriteTo(fileStream);
			fileStream.Close();
			memoryStream.Close();
		}
		catch
		{
		}
	}

	internal void method_18()
	{
		Class72.string_54 = FortBuffsCells.Text.Trim();
		Class72.string_55 = "MoveToFort";
		smethod_56();
	}

	private void method_19(string string_0, string string_1, int int_1)
	{
		Class92 @class = new Class92();
		@class.formMain_0 = this;
		@class.string_0 = string_0;
		@class.string_1 = string_1;
		@class.int_0 = int_1;
		if (base.InvokeRequired)
		{
			BeginInvoke(new MethodInvoker(@class.method_0));
			return;
		}
		Class72.bool_21 = true;
		Class72.string_29 = @class.string_0;
		Class72.string_30 = @class.string_1;
		Class72.int_8 = @class.int_0;
	}

	internal void method_20()
	{
		if (base.InvokeRequired)
		{
			BeginInvoke(new MethodInvoker(method_20));
			return;
		}
		if (Class72.string_29 == "i_svi_213.gif")
		{
			buttonFriendsInvis.Checked = false;
		}
		Class72.bool_21 = false;
		Class72.string_30 = null;
		Class72.string_29 = null;
		Class72.int_8 = 0;
		Class72.bool_22 = false;
		Class72.bool_23 = false;
		if (Class72.bool_24)
		{
			Class72.bool_25 = true;
		}
	}

	private static void smethod_3(object object_0)
	{
		Class101 @class = (Class101)object_0;
		string text = smethod_37(@class.string_0);
		string text2 = Class21.smethod_3(Class21.smethod_2(text));
		if (string.IsNullOrEmpty(text2))
		{
			Class72.formMain_0.method_63("Ошибка анализа инфы атакуемого.");
			return;
		}
		string text3 = Class12.smethod_1(text2, "\n3|", "\n4|");
		if (string.IsNullOrEmpty(text3))
		{
			Class72.formMain_0.method_63("Ошибка анализа инфы атакуемого.");
			return;
		}
		string text4 = text3.Split('|')[14];
		if (text4.Equals("0", StringComparison.Ordinal))
		{
			text4 = string.Empty;
		}
		if (!string.IsNullOrEmpty(text4))
		{
			int num = 0;
			Stopwatch stopwatch = new Stopwatch();
			stopwatch.Start();
			Class72.bool_25 = false;
			while (!Class72.bool_25)
			{
				Class72.bool_24 = true;
				text2 = Class21.smethod_1(text4);
				if (string.IsNullOrEmpty(text2))
				{
					continue;
				}
				num++;
				string text5 = Class12.smethod_1(text2, "var off = ", ";");
				if (string.IsNullOrEmpty(text5))
				{
					continue;
				}
				if (text5.Equals("1") || (text2.IndexOf("нападение бота", StringComparison.CurrentCultureIgnoreCase) == -1 && text2.IndexOf("закрытый бой", StringComparison.CurrentCultureIgnoreCase) == -1 && text2.IndexOf("закрытое нападение", StringComparison.CurrentCultureIgnoreCase) == -1 && text2.IndexOf("закрытое кулачное нападение", StringComparison.CurrentCultureIgnoreCase) == -1 && text2.IndexOf("закрытое боевое нападение", StringComparison.CurrentCultureIgnoreCase) == -1 && !Class72.smethod_138()))
				{
					break;
				}
				if (num == 1)
				{
					if (Class72.formMain_0 != null)
					{
						Class72.formMain_0.method_63("Ожидание окончания боя (отмена: меню/быстрые действия/отмена).");
					}
				}
				else if (num % 100 == 0 && Class72.formMain_0 != null)
				{
					Class72.formMain_0.method_63($"Ожидание окончания боя (запросов: {num}, средн: {stopwatch.ElapsedMilliseconds / num}мс)");
				}
			}
		}
		Class72.bool_24 = false;
		if (Class72.bool_25)
		{
			Class72.bool_25 = false;
			if (Class72.formMain_0 != null)
			{
				Class72.formMain_0.method_63("Ожидание окончания боя прекращено.");
			}
		}
		else if (Class72.formMain_0 != null)
		{
			Class72.formMain_0.method_19(@class.string_1, text, (!Class72.bool_32) ? 1 : int.MaxValue);
			smethod_56();
		}
	}

	private static void smethod_4(object object_0)
	{
		Class101 @class = (Class101)object_0;
		string text = smethod_37(@class.string_0);
		string string_ = Class21.smethod_2(text);
		int num = 0;
		Stopwatch stopwatch = new Stopwatch();
		stopwatch.Start();
		Class72.bool_25 = false;
		while (!Class72.bool_25)
		{
			Class72.bool_24 = true;
			string text2 = Class21.smethod_3(string_);
			if (!string.IsNullOrEmpty(text2))
			{
				string text3 = Class12.smethod_1(text2, "\n3|", "\n4|");
				if (!string.IsNullOrEmpty(text3))
				{
					string text4 = text3.Split('|')[14];
					if (text4.Equals("0", StringComparison.Ordinal))
					{
						text4 = string.Empty;
					}
					num++;
					if (num == 1)
					{
						if (Class72.formMain_0 != null)
						{
							Class72.formMain_0.method_63("Ожидание окончания боя (отмена: меню/быстрые действия/отмена).");
						}
					}
					else if (num % 100 == 0 && Class72.formMain_0 != null)
					{
						Class72.formMain_0.method_63($"Ожидание окончания боя (запросов: {num}, средн: {stopwatch.ElapsedMilliseconds / num}мс)");
					}
					if (string.IsNullOrEmpty(text4))
					{
						break;
					}
					continue;
				}
				Class72.formMain_0.method_63("Ошибка анализа инфы атакуемого.");
				return;
			}
			Class72.formMain_0.method_63("Ошибка анализа инфы атакуемого.");
			return;
		}
		Class72.bool_24 = false;
		if (Class72.bool_25)
		{
			Class72.bool_25 = false;
			if (Class72.formMain_0 != null)
			{
				Class72.formMain_0.method_63("Ожидание окончания боя прекращено.");
			}
		}
		else if (Class72.formMain_0 != null)
		{
			Class72.formMain_0.method_19(@class.string_1, text, (!Class72.bool_32) ? 1 : int.MaxValue);
			smethod_56();
		}
	}

	internal static void smethod_5(string string_0)
	{
		new Thread(smethod_3).Start(new Class101
		{
			string_0 = string_0,
			string_1 = "i_svi_001.gif"
		});
	}

	internal static void smethod_6(string string_0)
	{
		new Thread(smethod_3).Start(new Class101
		{
			string_0 = string_0,
			string_1 = "i_svi_002.gif"
		});
	}

	internal static void smethod_7(string string_0)
	{
		new Thread(smethod_3).Start(new Class101
		{
			string_0 = string_0,
			string_1 = "i_w28_26.gif"
		});
	}

	internal static void smethod_8(string string_0)
	{
		if (Class72.formMain_0 != null)
		{
			Class72.formMain_0.method_19("i_w28_26.gif", string_0, (!Class72.bool_32) ? 1 : int.MaxValue);
			smethod_56();
		}
	}

	internal static void smethod_9(string string_0)
	{
		new Thread(smethod_3).Start(new Class101
		{
			string_0 = string_0,
			string_1 = "i_w28_26X.gif"
		});
	}

	internal static void smethod_10(string string_0)
	{
		if (Class72.formMain_0 != null)
		{
			Class72.formMain_0.method_19("i_w28_26X.gif", string_0, (!Class72.bool_32) ? 1 : int.MaxValue);
			smethod_56();
		}
	}

	internal static void smethod_11(string string_0)
	{
		new Thread(smethod_3).Start(new Class101
		{
			string_0 = string_0,
			string_1 = "i_svi_205.gif"
		});
	}

	internal static void smethod_12(string string_0)
	{
		if (Class72.formMain_0 != null)
		{
			Class72.formMain_0.method_19("i_svi_205.gif", string_0, (!Class72.bool_32) ? 1 : int.MaxValue);
			smethod_56();
		}
	}

	internal static void smethod_13(string string_0)
	{
		new Thread(smethod_4).Start(new Class101
		{
			string_0 = string_0,
			string_1 = "i_w28_86.gif"
		});
	}

	internal static void smethod_14(string string_0)
	{
		if (Class72.formMain_0 != null)
		{
			Class72.formMain_0.method_19("i_w28_86.gif", string_0, (!Class72.bool_32) ? 1 : int.MaxValue);
			smethod_56();
		}
	}

	internal static void smethod_15(string string_0)
	{
		new Thread(smethod_3).Start(new Class101
		{
			string_0 = string_0,
			string_1 = "vsergard"
		});
	}

	internal static void smethod_16(string string_0)
	{
		new Thread(smethod_3).Start(new Class101
		{
			string_0 = string_0,
			string_1 = "i_w28_24.gif"
		});
	}

	internal static void smethod_17(string string_0)
	{
		if (Class72.formMain_0 != null)
		{
			Class72.formMain_0.method_19("i_w28_24.gif", string_0, (!Class72.bool_32) ? 1 : int.MaxValue);
			smethod_56();
		}
	}

	internal static void smethod_18(string string_0)
	{
		new Thread(smethod_3).Start(new Class101
		{
			string_0 = string_0,
			string_1 = "i_w28_25.gif"
		});
	}

	internal static void smethod_19(string string_0)
	{
		if (Class72.formMain_0 != null)
		{
			Class72.formMain_0.method_19("i_w28_25.gif", string_0, (!Class72.bool_32) ? 1 : int.MaxValue);
			smethod_56();
		}
	}

	internal static void smethod_20(string string_0)
	{
		if (Class72.formMain_0 != null)
		{
			Class72.formMain_0.method_19("i_svi_213.gif", smethod_37(string_0), 1);
			smethod_56();
		}
	}

	internal static void smethod_21(string string_0)
	{
		if (Class72.formMain_0 != null)
		{
			Class72.formMain_0.method_19("i_w28_27.gif", smethod_37(string_0), 1);
			smethod_56();
		}
	}

	internal static void smethod_22(string string_0)
	{
		new Thread(smethod_3).Start(new Class101
		{
			string_0 = string_0,
			string_1 = "Тотем"
		});
	}

	internal void method_21()
	{
		if (base.InvokeRequired)
		{
			BeginInvoke(new MethodInvoker(method_21));
		}
		else if (Class72.formMain_0 != null)
		{
			Class72.formMain_0.method_19("i_w28_28.gif", "клетке", 1);
			smethod_56();
		}
	}

	internal static void smethod_23(string string_0)
	{
		if (Class72.formMain_0 != null)
		{
			Class72.formMain_0.method_19("Яд", smethod_37(string_0), 1);
			smethod_56();
		}
	}

	internal static void smethod_24(string string_0)
	{
		if (Class72.formMain_0 != null)
		{
			Class72.formMain_0.method_19("Призыв Импа-вредителя", smethod_37(string_0), 5);
			smethod_56();
		}
	}

	internal static void smethod_25(string string_0)
	{
		new Thread(smethod_3).Start(new Class101
		{
			string_0 = smethod_37(string_0),
			string_1 = "Яд"
		});
	}

	internal static void smethod_26(string string_0)
	{
		if (Class72.formMain_0 != null)
		{
			Class72.formMain_0.method_19("Зелье Сильной Спины", smethod_37(string_0), (!Class72.bool_32) ? 1 : 5);
			smethod_56();
		}
	}

	internal static void smethod_27(string string_0)
	{
		new Thread(smethod_3).Start(new Class101
		{
			string_0 = smethod_37(string_0),
			string_1 = "Зелье Сильной Спины"
		});
	}

	internal static void smethod_28(string string_0)
	{
		if (Class72.formMain_0 != null)
		{
			Class72.formMain_0.method_19("Превосходное Зелье Сильной Спины", smethod_37(string_0), (!Class72.bool_32) ? 1 : 5);
			smethod_56();
		}
	}

	internal static void smethod_29(string string_0)
	{
		new Thread(smethod_3).Start(new Class101
		{
			string_0 = smethod_37(string_0),
			string_1 = "Превосходное Зелье Сильной Спины"
		});
	}

	internal static void smethod_30(string string_0)
	{
		if (Class72.formMain_0 != null)
		{
			Class72.formMain_0.method_19("Зелье Невидимости", smethod_37(string_0), 1);
			smethod_56();
		}
	}

	internal static void smethod_31(string string_0)
	{
		new Thread(smethod_3).Start(new Class101
		{
			string_0 = smethod_37(string_0),
			string_1 = "Зелье Невидимости"
		});
	}

	private static void smethod_32()
	{
		if (Class72.formMain_0 != null)
		{
			Class72.formMain_0.method_19("Зелье Блаженства", Class72.class19_0.method_30(), 1);
			smethod_56();
		}
	}

	private static void smethod_33()
	{
		if (Class72.formMain_0 != null)
		{
			Class72.formMain_0.method_19("Эликсир Блаженства", Class72.class19_0.method_30(), 1);
			smethod_56();
		}
	}

	private static void smethod_34()
	{
		if (Class72.formMain_0 != null)
		{
			Class72.formMain_0.method_19("Эликсир Мгновенного Исцеления", Class72.class19_0.method_30(), 1);
			smethod_56();
		}
	}

	private static void smethod_35()
	{
		if (Class72.formMain_0 != null)
		{
			Class72.formMain_0.method_19("Эликсир Восстановления", Class72.class19_0.method_30(), 1);
			smethod_56();
		}
	}

	private static void smethod_36()
	{
		if (Class72.formMain_0 != null)
		{
			Class72.formMain_0.method_19("Приманку Для Ботов", Class72.class19_0.method_30(), (!Class72.bool_32) ? 1 : int.MaxValue);
		}
		Class72.class19_0.struct13_0.long_0 = 0L;
		if (Class72.formMain_0 != null)
		{
			Class72.formMain_0.method_60((Enum4)1);
		}
		smethod_56();
	}

	private static string smethod_37(string string_0)
	{
		return string_0.Replace("<i>", string.Empty).Replace("</i>", string.Empty).Trim();
	}

	internal static string smethod_38()
	{
		smethod_62();
		if (Class72.smethod_36() && Class72.smethod_42() > 0)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendFormat("Пункт назначения: <font color=#FFFF00>{0}</font>", Class72.smethod_40());
			stringBuilder.AppendFormat("<br>Еще переходов: <font color=#FFFF00>{0}</font>", Class72.smethod_42());
			if (Class72.bool_34)
			{
				stringBuilder.AppendFormat("<br>Ищем клад...");
			}
			return stringBuilder.ToString();
		}
		return "Перемещаемся на соседнюю клетку...";
	}

	internal void method_22()
	{
		if (base.InvokeRequired)
		{
			BeginInvoke(new MethodInvoker(method_22));
			return;
		}
		if (Class72.class19_0.method_124())
		{
			method_93("Ожидаем хода противника");
		}
		if (Class72.smethod_144() == null || (Class72.smethod_144() != null && !Class72.smethod_144().IsAlive))
		{
			Class72.smethod_145(new Thread(smethod_40));
			Class72.smethod_144().Start();
		}
	}

	private static void smethod_39()
	{
		if (Class72.smethod_144() != null)
		{
			Class72.smethod_137(bool_54: false);
			while (Class72.smethod_144() != null && Class72.smethod_144().IsAlive)
			{
				Class72.smethod_144().Join(50);
			}
			Class72.smethod_145(null);
		}
	}

	private static void smethod_40(object object_0)
	{
		DateTime now = DateTime.Now;
		int num = -1;
		while (Class72.smethod_136())
		{
			TimeSpan timeSpan = DateTime.Now.Subtract(now);
			if (timeSpan.Seconds % 30 == 0 && num != timeSpan.Seconds)
			{
				num = timeSpan.Seconds;
				if (Class72.formMain_0 != null)
				{
					Class72.formMain_0.method_63($"Ожидаем хода противника... <b>{timeSpan.Minutes}:{timeSpan.Seconds:00}</b>");
				}
			}
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("http://www.neverlands.ru/main.php");
			httpWebRequest.Method = "GET";
			httpWebRequest.Proxy = Class72.webProxy_0;
			string value = Class32.smethod_1("www.neverlands.ru");
			httpWebRequest.Headers.Add("Cookie", value);
			string text = null;
			try
			{
				IdleManager.AddActivity();
				Stream responseStream = httpWebRequest.GetResponse().GetResponseStream();
				if (responseStream != null)
				{
					text = new StreamReader(responseStream, Class72.encoding_0).ReadToEnd();
				}
			}
			catch
			{
				text = null;
			}
			finally
			{
				IdleManager.RemoveActivity();
			}
			if (string.IsNullOrEmpty(text) || !smethod_42(text))
			{
				break;
			}
		}
		if (Class72.smethod_136() && Class72.formMain_0 != null)
		{
			try
			{
				if (Class72.formMain_0 != null)
				{
					Class72.formMain_0.BeginInvoke(new Delegate20(Class72.formMain_0.method_110), new object[0]);
				}
			}
			catch (InvalidOperationException)
			{
			}
		}
		Class72.smethod_145(null);
	}

	private static string[] smethod_41(string string_0, string string_1, int int_1)
	{
		if (string_0 == null)
		{
			throw new ArgumentNullException("html");
		}
		if (string_1 == null)
		{
			throw new ArgumentNullException("sarg");
		}
		if (string_0.IndexOf(string_1, StringComparison.OrdinalIgnoreCase) == -1)
		{
			return null;
		}
		string text = Class12.smethod_1(string_0, string_1, "]");
		if (text == null)
		{
			return null;
		}
		string[] array = text.Split(',');
		if (array.Length >= int_1)
		{
			return array;
		}
		return null;
	}

	private static bool smethod_42(string string_0)
	{
		string[] array = smethod_41(string_0, "var fight_ty = [", 0);
		if (array == null)
		{
			return false;
		}
		if (array[3].Length >= 1 && array[3][0] == '1')
		{
			return false;
		}
		if (!array[4].Equals("3"))
		{
			return false;
		}
		if (array[6].Length > 2)
		{
			return false;
		}
		return true;
	}

	internal static void smethod_43(string string_0)
	{
		if (string_0 != null)
		{
			long ticks = DateTime.Now.Subtract(Class72.class19_0.timeSpan_0).Ticks;
			if (Class72.class19_0.sortedDictionary_0.ContainsKey(Class72.class19_0.method_58()))
			{
				Class72.class19_0.sortedDictionary_0[Class72.class19_0.method_58()].string_1 = string_0;
				Class72.class19_0.sortedDictionary_0[Class72.class19_0.method_58()].long_0 = ticks;
				return;
			}
			Class1 value = new Class1
			{
				string_0 = Class72.class19_0.method_58(),
				string_1 = string_0,
				long_0 = ticks
			};
			Class72.class19_0.sortedDictionary_0.Add(Class72.class19_0.method_58(), value);
		}
	}

	internal static void smethod_44()
	{
		DateTime dateTime_ = DateTime.Now.Subtract(Class72.class19_0.timeSpan_0);
		int num = smethod_45(dateTime_);
		string string_ = Class72.string_51;
		int num2 = 0;
		int num3 = (Class72.string_52.Equals("4") ? 1 : 4);
		int num4 = 60;
		if (Class72.dictionary_3.ContainsKey(string_))
		{
			num2 = Class72.dictionary_3[string_];
			Class72.dictionary_3[string_] += num3;
		}
		else
		{
			Class72.dictionary_3.Add(string_, num3);
		}
		string text;
		if (Class72.string_52.Equals("4"))
		{
			text = $"[<a href='#' onclick='window.external.MoveTo(\"{Class72.class19_0.method_58()}\")'>{Class72.class19_0.method_58()}</a>] Срезано: &laquo;<b>{string_}</b>&raquo; [{num2}<b>+{num3}</b>]. ";
			uint num5 = Class0.smethod_0(string_);
			if (num5 <= 1927039028)
			{
				if (num5 <= 1044116108)
				{
					if (num5 <= 217929516)
					{
						if (num5 != 151684528)
						{
							if (num5 == 217929516 && string_ == "Цветки кипариса")
							{
								goto IL_03bd;
							}
						}
						else if (string_ == "Инжир")
						{
							goto IL_03bd;
						}
					}
					else if (num5 != 910965738)
					{
						if (num5 != 1033386424)
						{
							if (num5 == 1044116108 && string_ == "Прагениана")
							{
								goto IL_03bd;
							}
						}
						else if (string_ == "Дягиль")
						{
							goto IL_03bd;
						}
					}
					else if (string_ == "Рапонтикум")
					{
						goto IL_03bd;
					}
				}
				else if (num5 <= 1255550700)
				{
					if (num5 != 1119535188)
					{
						if (num5 == 1255550700 && string_ == "Каперс")
						{
							goto IL_03bd;
						}
					}
					else if (string_ == "Кора березы")
					{
						goto IL_03bd;
					}
				}
				else if (num5 != 1304671960)
				{
					if (num5 != 1566967563)
					{
						if (num5 == 1927039028 && string_ == "Ландыш")
						{
							goto IL_03bd;
						}
					}
					else if (string_ == "Гравилат")
					{
						goto IL_03bd;
					}
				}
				else if (string_ == "Камелия")
				{
					goto IL_03bd;
				}
			}
			else if (num5 <= 2305104759u)
			{
				if (num5 <= 2189554449u)
				{
					if (num5 != 2172818307u)
					{
						if (num5 == 2189554449u && string_ == "Алоэ")
						{
							goto IL_03bd;
						}
					}
					else if (string_ == "Береза")
					{
						goto IL_03bd;
					}
				}
				else if (num5 != 2211696747u)
				{
					if (num5 != 2297216382u)
					{
						if (num5 == 2305104759u && string_ == "Лимон")
						{
							goto IL_03bd;
						}
					}
					else if (string_ == "Смертоцвет")
					{
						goto IL_03bd;
					}
				}
				else if (string_ == "Кора дуба")
				{
					goto IL_03bd;
				}
			}
			else if (num5 <= 2788022626u)
			{
				if (num5 != 2446826885u)
				{
					if (num5 != 2652961907u)
					{
						if (num5 == 2788022626u && string_ == "Кентарийская дикая роза")
						{
							goto IL_03bd;
						}
					}
					else if (string_ == "Брусника")
					{
						goto IL_03bd;
					}
				}
				else if (string_ == "Секуринега")
				{
					goto IL_03bd;
				}
			}
			else if (num5 != 3148189344u)
			{
				if (num5 != 3419760803u)
				{
					if (num5 == 3629890403u && string_ == "Дуб")
					{
						goto IL_03bd;
					}
				}
				else if (string_ == "Дурман")
				{
					goto IL_03bd;
				}
			}
			else if (string_ == "Айва")
			{
				goto IL_03bd;
			}
		}
		else
		{
			text = (text = $"[<a href='#' onclick='window.external.MoveTo(\"{Class72.class19_0.method_58()}\")'>{Class72.class19_0.method_58()}</a>] Срублено: &laquo;<b>{string_}</b>&raquo; [{num2}<b>+{num3}</b>]. ");
			uint num5 = Class0.smethod_0(string_);
			if (num5 <= 2052395718)
			{
				if (num5 <= 945096719)
				{
					if (num5 <= 292348349)
					{
						if (num5 <= 258497261)
						{
							if (num5 != 10211147)
							{
								if (num5 == 258497261 && string_ == "Ива")
								{
									goto IL_093b;
								}
							}
							else if (string_ == "Кипарис")
							{
								goto IL_093b;
							}
						}
						else if (num5 != 260324242)
						{
							if (num5 == 292348349 && string_ == "Платан остролистый")
							{
								goto IL_093b;
							}
						}
						else if (string_ == "Тис")
						{
							goto IL_08a8;
						}
					}
					else if (num5 <= 490005804)
					{
						if (num5 != 463233807)
						{
							if (num5 == 490005804 && string_ == "Ююба")
							{
								goto IL_08a8;
							}
						}
						else if (string_ == "Песчаная колючка")
						{
							goto IL_093b;
						}
					}
					else if (num5 != 865855179)
					{
						if (num5 != 918777861)
						{
							if (num5 == 945096719 && string_ == "Хурма")
							{
								goto IL_0925;
							}
						}
						else if (string_ == "Фиговое дерево")
						{
							goto IL_093b;
						}
					}
					else if (string_ == "Тигровое дерево")
					{
						goto IL_093b;
					}
				}
				else if (num5 <= 1186197678)
				{
					if (num5 <= 1116643707)
					{
						if (num5 != 996292199)
						{
							if (num5 == 1116643707 && string_ == "Тополь")
							{
								goto IL_08a8;
							}
						}
						else if (string_ == "Ель")
						{
							goto IL_093b;
						}
					}
					else if (num5 != 1173457909)
					{
						if (num5 == 1186197678 && string_ == "Серебристый тополь")
						{
							goto IL_0925;
						}
					}
					else if (string_ == "Бук")
					{
						goto IL_093b;
					}
				}
				else if (num5 <= 1487542701)
				{
					if (num5 != 1370371211)
					{
						if (num5 == 1487542701 && string_ == "Осина")
						{
							goto IL_093b;
						}
					}
					else if (string_ == "Ольха")
					{
						goto IL_093b;
					}
				}
				else if (num5 != 1890373054)
				{
					if (num5 != 1930534705)
					{
						if (num5 == 2052395718 && string_ == "Дифенбахия")
						{
							goto IL_093b;
						}
					}
					else if (string_ == "Липа")
					{
						goto IL_08a8;
					}
				}
				else if (string_ == "Мангровое дерево")
				{
					goto IL_0925;
				}
			}
			else if (num5 <= 2939039638u)
			{
				if (num5 <= 2324968307u)
				{
					if (num5 <= 2172818307u)
					{
						if (num5 != 2056946811)
						{
							if (num5 == 2172818307u && string_ == "Береза")
							{
								goto IL_093b;
							}
						}
						else if (string_ == "Вяз")
						{
							goto IL_08a8;
						}
					}
					else if (num5 != 2314391573u)
					{
						if (num5 == 2324968307u && string_ == "Сандал огненный")
						{
							goto IL_0925;
						}
					}
					else if (string_ == "Медный кактус")
					{
						goto IL_093b;
					}
				}
				else if (num5 <= 2401642547u)
				{
					if (num5 != 2391967672u)
					{
						if (num5 == 2401642547u && string_ == "Камфорное дерево")
						{
							goto IL_093b;
						}
					}
					else if (string_ == "Сосна")
					{
						goto IL_093b;
					}
				}
				else if (num5 != 2403866557u)
				{
					if (num5 != 2856915831u)
					{
						if (num5 == 2939039638u && string_ == "Бамбук")
						{
							goto IL_093b;
						}
					}
					else if (string_ == "Жимолость южная")
					{
						goto IL_093b;
					}
				}
				else if (string_ == "Сассафрас совиный")
				{
					goto IL_0925;
				}
			}
			else if (num5 <= 3694442302u)
			{
				if (num5 <= 3273343167u)
				{
					if (num5 != 3084827203u)
					{
						if (num5 == 3273343167u && string_ == "Секвойя")
						{
							goto IL_08a8;
						}
					}
					else if (string_ == "Драцена")
					{
						goto IL_093b;
					}
				}
				else if (num5 != 3546237158u)
				{
					if (num5 != 3577059879u)
					{
						if (num5 == 3694442302u && string_ == "Красное дерево")
						{
							goto IL_0925;
						}
					}
					else if (string_ == "Мамонтовое дерево")
					{
						num4 = 120;
					}
				}
				else if (string_ == "Эвкалипт")
				{
					goto IL_08a8;
				}
			}
			else if (num5 <= 3882723958u)
			{
				if (num5 != 3756510583u)
				{
					if (num5 == 3882723958u && string_ == "Амирис")
					{
						goto IL_093b;
					}
				}
				else if (string_ == "Чёрный кедр")
				{
					goto IL_0925;
				}
			}
			else if (num5 != 3885691259u)
			{
				if (num5 != 3900431210u)
				{
					if (num5 == 4189415982u && string_ == "Падуб")
					{
						goto IL_093b;
					}
				}
				else if (string_ == "Тайпал")
				{
					goto IL_0925;
				}
			}
			else if (string_ == "Орешник")
			{
				goto IL_093b;
			}
		}
		goto IL_093f;
		IL_093f:
		int num6 = smethod_45(dateTime_.AddMinutes(num4));
		if (num != num6)
		{
			text += "Таймер не установлен, смена трав близка.";
		}
		else
		{
			Class71.smethod_1(new Class69
			{
				string_0 = $"{string_} вырастет на {Class72.class19_0.method_58()}",
				dateTime_0 = DateTime.Now.AddMinutes(num4),
				bool_1 = true
			});
			try
			{
				if (Class72.formMain_0 != null)
				{
					Class72.formMain_0.BeginInvoke(new Delegate32(Class72.formMain_0.method_162), new object[0]);
				}
			}
			catch (InvalidOperationException)
			{
			}
			Class72.class19_0.method_20();
			text += $"Таймер установлен на <b>{num4}</b> минут.";
		}
		try
		{
			if (Class72.formMain_0 != null)
			{
				Class72.formMain_0.BeginInvoke(new Delegate7(Class72.formMain_0.method_100), text);
			}
		}
		catch (InvalidOperationException)
		{
		}
		Class72.string_51 = string.Empty;
		Class72.string_52 = string.Empty;
		return;
		IL_08a8:
		num4 = 40;
		goto IL_093f;
		IL_0925:
		num4 = 180;
		goto IL_093f;
		IL_03bd:
		num4 = 120;
		goto IL_093f;
		IL_093b:
		num4 = 30;
		goto IL_093f;
	}

	private static int smethod_45(DateTime dateTime_1)
	{
		DateTime dateTime = new DateTime(dateTime_1.Year, dateTime_1.Month, dateTime_1.Day, 0, 50, 0);
		DateTime dateTime2 = new DateTime(dateTime_1.Year, dateTime_1.Month, dateTime_1.Day, 6, 50, 0);
		DateTime dateTime3 = new DateTime(dateTime_1.Year, dateTime_1.Month, dateTime_1.Day, 12, 50, 0);
		DateTime dateTime4 = new DateTime(dateTime_1.Year, dateTime_1.Month, dateTime_1.Day, 18, 50, 0);
		if (!(dateTime_1 < dateTime) && !(dateTime_1 >= dateTime4))
		{
			if (dateTime_1 >= dateTime && dateTime_1 < dateTime2)
			{
				return 1;
			}
			if (dateTime_1 >= dateTime2 && dateTime_1 < dateTime3)
			{
				return 2;
			}
			if (dateTime_1 >= dateTime3 && dateTime_1 < dateTime4)
			{
				return 3;
			}
			return 0;
		}
		return 4;
	}

	internal string method_23()
	{
		return statuslabelClock.Text;
	}

	internal static void smethod_46()
	{
		FormFishAdvisor formFishAdvisor = new FormFishAdvisor();
		try
		{
			formFishAdvisor.ShowDialog();
		}
		finally
		{
			((IDisposable)formFishAdvisor).Dispose();
		}
	}

	private void FormMain_Load(object sender, EventArgs e)
	{
		method_117();
	}

	private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
	{
		e.Cancel = !method_121();
	}

	private void FormMain_Resize(object sender, EventArgs e)
	{
		method_130();
	}

	private void timer_1_Tick(object sender, EventArgs e)
	{
		method_168();
	}

	private void notifyIcon_0_MouseDoubleClick(object sender, MouseEventArgs e)
	{
		method_169();
	}

	private void buttonDoTexLog_Click(object sender, EventArgs e)
	{
		Class72.class19_0.method_117(buttonDoTexLog.Checked);
	}

	private void buttonClearTexLog_Click(object sender, EventArgs e)
	{
		textboxTexLog.Text = string.Empty;
	}

	private void menuitemStatItem4_Click(object sender, EventArgs e)
	{
		method_133((string)((ToolStripItem)sender).Tag);
	}

	private void menuitemStatEdit_Click(object sender, EventArgs e)
	{
		method_139();
	}

	private void collapsibleSplitter_MouseClick(object sender, MouseEventArgs e)
	{
		tabControlLeft.Refresh();
		tabControlRight.Refresh();
	}

	private void menuitemGameLogOn_Click(object sender, EventArgs e)
	{
		method_120();
	}

	private void menuitemGameExit_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void menuitemOpenForum_Click(object sender, EventArgs e)
	{
		method_152();
	}

	private void menuitemOpenTodayChat_Click(object sender, EventArgs e)
	{
		method_153();
	}

	private void menuitemOpenNotepad_Click(object sender, EventArgs e)
	{
		method_155();
	}

	private void menuitemOpenTab_Click(object sender, EventArgs e)
	{
		method_156();
	}

	private void method_24(object sender, EventArgs e)
	{
		method_154((string)((ToolStripMenuItem)sender).Tag);
	}

	private void menuitemSettingsGeneral_Click(object sender, EventArgs e)
	{
		method_126();
	}

	private void menuitemClanPrivate_Click(object sender, EventArgs e)
	{
		method_112("%clan%");
	}

	private void menuitemMinimize_Click(object sender, EventArgs e)
	{
		base.WindowState = FormWindowState.Minimized;
	}

	private void menuitemCacheRefresh_Click(object sender, EventArgs e)
	{
		Class72.smethod_13(menuitemCacheRefresh.Checked);
		if (Class72.smethod_12())
		{
			Class22.smethod_3();
		}
	}

	private void menuitemAbout_Click(object sender, EventArgs e)
	{
		FormAbout formAbout = new FormAbout();
		try
		{
			formAbout.ShowDialog();
		}
		finally
		{
			((IDisposable)formAbout).Dispose();
		}
	}

	private void menuitemFishAdvisor_Click(object sender, EventArgs e)
	{
		smethod_46();
	}

	private void tabControlLeft_SelectedIndexChanged(object sender, EventArgs e)
	{
		method_145();
	}

	private void tabControlLeft_MouseDoubleClick(object sender, MouseEventArgs e)
	{
		method_157(e);
	}

	private void method_25(object sender, WebBrowserExtendedNavigatingEventArgs e)
	{
		method_142(e.Address);
		e.Cancel = true;
	}

	private static void smethod_47(object sender, WebBrowserDocumentCompletedEventArgs e)
	{
		if (e == null)
		{
			throw new ArgumentNullException("e");
		}
		smethod_78(sender);
	}

	private void buttonAutoboi_Click(object sender, EventArgs e)
	{
		method_61();
	}

	private void buttonNavigator_Click(object sender, EventArgs e)
	{
		method_122(Class72.class19_0.method_58());
	}

	private void buttonDrink_Click(object sender, EventArgs e)
	{
		Class72.smethod_31(buttonDrink.Checked);
		if (Class72.smethod_30())
		{
			Class72.formMain_0.BeginInvoke(new Delegate20(Class72.formMain_0.method_110), new object[0]);
		}
	}

	private void buttonAutoAnswer_Click(object sender, EventArgs e)
	{
		Class72.class19_0.method_75(buttonAutoAnswer.Checked);
	}

	private void buttonAutoFish_Click(object sender, EventArgs e)
	{
		Class72.class19_0.method_101(buttonAutoFish.Checked);
		Class72.class19_0.method_20();
		if (Class72.class19_0.method_100())
		{
			Class72.smethod_63(bool_54: true);
			Class72.smethod_65(bool_54: false);
			Class72.smethod_67(Class72.class19_0.method_92() == 0);
			Class72.class19_0.bool_48 = true;
			Class72.smethod_69(string.Empty);
			Class72.smethod_73(string.Empty);
			Class72.smethod_71(string.Empty);
			Class72.smethod_75(string.Empty);
			Class72.smethod_81(string.Empty);
			Class72.smethod_83(0.0);
			Class72.smethod_85(bool_54: false);
			Class72.formMain_0.BeginInvoke(new Delegate20(Class72.formMain_0.method_110), new object[0]);
		}
	}

	private void buttonAutoSkin_Click(object sender, EventArgs e)
	{
		Class72.class19_0.method_103(buttonAutoSkin.Checked);
		Class72.class19_0.method_20();
		if (Class72.class19_0.method_102())
		{
			Class72.smethod_51(bool_54: true);
			Class72.smethod_61(bool_54: true);
			Class72.smethod_53(0);
			Class72.smethod_55(bool_54: true);
			Class72.smethod_57(bool_54: false);
			Class72.formMain_0.BeginInvoke(new Delegate20(Class72.formMain_0.method_110), new object[0]);
		}
	}

	private void buttonAutoAdv_Click(object sender, EventArgs e)
	{
		Class72.smethod_109(buttonAutoAdv.Checked);
		statuslabelAutoAdv.Enabled = buttonAutoAdv.Checked;
	}

	private void buttonSilence_Click(object sender, EventArgs e)
	{
		Class72.class19_0.tsound_0.Enabled = !buttonSilence.Checked;
		Class72.class19_0.method_20();
	}

	private void buttonGameLogOn_Click(object sender, EventArgs e)
	{
		method_120();
	}

	private static void smethod_48(object sender, EventArgs e)
	{
		smethod_74(sender);
	}

	private static void smethod_49(object sender, EventArgs e)
	{
		smethod_75(sender);
	}

	private void method_26(object sender, EventArgs e)
	{
		smethod_77(sender);
	}

	private void method_27(object sender, EventArgs e)
	{
		method_148(sender);
	}

	private void method_28(object sender, EventArgs e)
	{
		method_149(sender);
	}

	private void method_29(object sender, EventArgs e)
	{
		smethod_79(sender);
	}

	private void method_30(object sender, EventArgs e)
	{
		smethod_80(sender);
	}

	private void method_31(object sender, EventArgs e)
	{
		method_150(sender);
	}

	private void buttonGameScreen_Click(object sender, EventArgs e)
	{
		method_151(sender);
	}

	private void method_32(object sender, EventArgs e)
	{
		method_146();
	}

	private void treeContacts_AfterCheck(object sender, TreeViewEventArgs e)
	{
		ContactsManager.smethod_13(treeContacts, e.Node);
	}

	private void treeContacts_AfterSelect(object sender, TreeViewEventArgs e)
	{
		method_67(e.Node);
	}

	private void treeContacts_DoubleClick(object sender, EventArgs e)
	{
		method_69();
	}

	private void treeContacts_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
	{
		treeContacts.SelectedNode = e.Node;
	}

	private void tbContactDetails_TextChanged(object sender, EventArgs e)
	{
		method_68();
	}

	private void tsDeleteContact_Click(object sender, EventArgs e)
	{
		method_66();
	}

	private void tsContactPrivate_Click(object sender, EventArgs e)
	{
		method_73();
	}

	private void miRemoveGroup_Click(object sender, EventArgs e)
	{
		string name = treeContacts.SelectedNode.Name;
		ContactsManager.smethod_12(treeContacts, name);
	}

	private void cmtsDeleteContact_Click(object sender, EventArgs e)
	{
		method_66();
	}

	private void cmtsContactPrivate_Click(object sender, EventArgs e)
	{
		method_73();
	}

	private void cmtsContactQuick_Click(object sender, EventArgs e)
	{
		method_71();
	}

	private void statuslabelAutoAdv_Click(object sender, EventArgs e)
	{
		if (MessageBox.Show("Бросить рекламу в чат досрочно?", "Автореклама", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
		{
			Class72.smethod_111(DateTime.Now);
		}
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		method_160();
	}

	private void timer_2_Tick(object sender, EventArgs e)
	{
		method_161();
	}

	private void menuitemNewTimer_Click(object sender, EventArgs e)
	{
		FormNewTimer formNewTimer = new FormNewTimer();
		try
		{
			if (formNewTimer.ShowDialog() == DialogResult.OK)
			{
				method_162();
			}
		}
		finally
		{
			((IDisposable)formNewTimer).Dispose();
		}
	}

	private void method_33(object sender, EventArgs e)
	{
		int int_ = (int)((ToolStripMenuItem)sender).Tag;
		method_163(int_);
	}

	internal void method_34(object sender, EventArgs e)
	{
		string text = ((ToolStripMenuItem)sender).Text;
		method_111("%<" + text + "> ");
	}

	internal void method_35(object sender, EventArgs e)
	{
		string text = (string)((ToolStripMenuItem)sender).Tag;
		method_111("%<" + text + "> ");
	}

	internal void method_36(object sender, EventArgs e)
	{
		string text = (string)((ToolStripMenuItem)sender).Tag;
		method_144((Enum2)2, Class39.smethod_45() + text, bool_0: false);
	}

	internal static void smethod_50(object sender, EventArgs e)
	{
		string text = (string)((ToolStripMenuItem)sender).Tag;
		Class8.smethod_4("%<" + text + "> " + Class72.class19_0.method_7(Class72.class19_0.method_64()));
	}

	internal static void smethod_51(object sender, EventArgs e)
	{
		string[] array = ((string)((ToolStripMenuItem)sender).Tag).Split(':');
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < array.Length; i++)
		{
			stringBuilder.Append("%<");
			stringBuilder.Append(array[i]);
			stringBuilder.Append("> ");
		}
		stringBuilder.Append(Class72.class19_0.method_7(Class72.class19_0.method_64()));
		Class8.smethod_4(stringBuilder.ToString());
	}

	internal static void smethod_52(object sender, EventArgs e)
	{
		Class8.smethod_4(Class72.class19_0.method_7(Class72.class19_0.method_64()));
	}

	internal static void smethod_53(object sender, EventArgs e)
	{
		string[] array = ((string)((ToolStripMenuItem)sender).Tag).Split(':');
		StringBuilder stringBuilder = new StringBuilder();
		if (!int.TryParse(array[0], out var result))
		{
			result = 1;
		}
		for (int i = 1; i < array.Length; i++)
		{
			stringBuilder.Append("%<");
			stringBuilder.Append(array[i]);
			stringBuilder.Append("> ");
		}
		stringBuilder.Append(Class72.class19_0.method_7(Class72.class19_0.method_62()[result - 1]));
		Class8.smethod_4(stringBuilder.ToString());
	}

	internal static void smethod_54(object sender, EventArgs e)
	{
		string[] array = ((string)((ToolStripMenuItem)sender).Tag).Split(':');
		string[] array2 = new string[4] { "легкую", "среднюю", "тяжелую", "боевую" };
		if (int.TryParse(array[1], out var result) && result >= 1 && result <= 4 && MessageBox.Show("Лечить " + array2[result - 1] + " у " + array[0] + " ?", "Быстрое лечение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
		{
			Class72.smethod_115(bool_54: true);
			Class72.smethod_117(array[0]);
			Class72.smethod_119(array[1]);
			Class72.formMain_0.BeginInvoke(new Delegate20(Class72.formMain_0.method_110), new object[0]);
		}
	}

	private void menuitemRestoreWindow_Click(object sender, EventArgs e)
	{
		method_169();
	}

	private void menuitemTrayQuit_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void miFastEnabled_CheckStateChanged(object sender, EventArgs e)
	{
		method_37();
	}

	private void method_37()
	{
		miFastTeleport.Enabled = miFastEnabled.Checked;
		miFastElxVosst.Enabled = miFastEnabled.Checked;
		miFastF3.Enabled = miFastEnabled.Checked;
		miFastF4.Enabled = miFastEnabled.Checked;
		miFastF12.Enabled = miFastEnabled.Checked;
		miFastSvitFog.Enabled = miFastEnabled.Checked;
		miFastF9.Enabled = miFastEnabled.Checked;
		miFastF10.Enabled = miFastEnabled.Checked;
	}

	private void miFastElxVosst_Click(object sender, EventArgs e)
	{
		smethod_35();
	}

	private void miFastF3_Click(object sender, EventArgs e)
	{
		smethod_34();
	}

	private void miFastF4_Click(object sender, EventArgs e)
	{
		smethod_36();
	}

	private void miFastF12_Click(object sender, EventArgs e)
	{
		smethod_30(Class72.class19_0.method_30());
	}

	private void miFastF9_Click(object sender, EventArgs e)
	{
		smethod_32();
	}

	private void miFastF10_Click(object sender, EventArgs e)
	{
		smethod_33();
	}

	private void miQuick_Click(object sender, EventArgs e)
	{
		smethod_55(Class72.class19_0.method_30());
	}

	internal static void smethod_55(string string_0)
	{
		new FormQuick(string_0).Show();
	}

	internal static void smethod_56()
	{
		Class72.formMain_0.BeginInvoke(new Delegate20(Class72.formMain_0.method_110), new object[0]);
	}

	private void miFastSvitFog_Click(object sender, EventArgs e)
	{
		Class72.formMain_0.method_19("i_svi_213.gif", Class72.class19_0.method_30(), 1);
		smethod_56();
	}

	private void miFastSviRass_Click(object sender, EventArgs e)
	{
		method_19("i_w28_28.gif", "клетке", 1);
		smethod_56();
	}

	private void miFastSviSelfRass_Click(object sender, EventArgs e)
	{
		method_19("i_w28_23.gif", "себя", 1);
		smethod_56();
	}

	private void miFastDarkTeleport_Click(object sender, EventArgs e)
	{
		Class72.bool_22 = true;
		method_63("Заказано применение сумеречного телепорта в случайную локацию");
		smethod_56();
	}

	private void miFastDarkFog_Click(object sender, EventArgs e)
	{
		Class72.bool_23 = true;
		method_63("Заказано применение сумеречного тумана на себя");
		smethod_56();
	}

	private void miFastTeleport_Click(object sender, EventArgs e)
	{
		method_63("Заказано применение телепорта в случайную локацию");
		Class72.formMain_0.method_19("i_w28_22.gif", Class72.class19_0.method_30(), 1);
		smethod_56();
	}

	private void miQuickCancel_Click(object sender, EventArgs e)
	{
		method_63("Быстрое действие отменено");
		method_20();
	}

	private void buttonAutoRefresh_Click(object sender, EventArgs e)
	{
		Class72.smethod_137(buttonAutoRefresh.Checked);
		Class72.formMain_0.BeginInvoke(new Delegate20(Class72.formMain_0.method_110), new object[0]);
	}

	private void buttonWaitOpen_Click(object sender, EventArgs e)
	{
		Class72.smethod_139(buttonWaitOpen.Checked);
		smethod_56();
	}

	private void menuitemShowCookies_Click(object sender, EventArgs e)
	{
		FormShowCookies formShowCookies = new FormShowCookies();
		try
		{
			formShowCookies.ShowDialog();
		}
		finally
		{
			((IDisposable)formShowCookies).Dispose();
		}
	}

	private void timer_3_Tick(object sender, EventArgs e)
	{
		smethod_0();
	}

	private void menuitemMainFrameInspector_Click(object sender, EventArgs e)
	{
		if (Class72.class19_0.method_30() != Class68.string_1)
		{
			return;
		}
		HtmlWindow htmlWindow = method_106("main_top");
		if (htmlWindow == null)
		{
			return;
		}
		try
		{
			if (!(htmlWindow.Document == null))
			{
				HtmlElement body = htmlWindow.Document.Body;
				if (body != null)
				{
					string innerHtml = body.InnerHtml;
					File.WriteAllText("main_top.html", innerHtml);
				}
			}
		}
		catch
		{
		}
	}

	private void buttonPerenap_Click(object sender, EventArgs e)
	{
		Class72.bool_32 = buttonPerenap.Checked;
		Class72.formMain_0.method_63(Class72.bool_32 ? "Включен <b>режим перенападения</b>. В этом режиме любое совершенное нападение будет повторяться, приманка будет использоваться непрерывно, будет наливаться сразу 5 спин - до отмены через меню: Команды-Отмена." : "<b>Режим перенападения</b> отключен. Любое нападение или использование приманки будет одиночным.");
	}

	private void method_38(bool bool_0)
	{
		Class72.smethod_89(bool_0);
		timer_0.Interval = (Class72.smethod_88() ? 1000 : 10000);
		Class72.smethod_91(string.Empty);
		Class72.smethod_93(string.Empty);
	}

	private void buttonWalkers_Click(object sender, EventArgs e)
	{
		method_38(buttonWalkers.Checked);
	}

	private void buttonOpenNevid_Click(object sender, EventArgs e)
	{
		Class72.smethod_141(buttonOpenNevid.Checked);
		if (buttonOpenNevid.Checked)
		{
			buttonWalkers.Checked = true;
			method_38(bool_0: true);
		}
	}

	private void buttonSelfNevid_Click(object sender, EventArgs e)
	{
		Class72.bool_30 = buttonSelfNevid.Checked;
		if (buttonSelfNevid.Checked)
		{
			buttonWalkers.Checked = true;
			method_38(bool_0: true);
		}
		smethod_56();
	}

	internal void method_39()
	{
		if (base.InvokeRequired)
		{
			BeginInvoke(new MethodInvoker(method_39));
			return;
		}
		buttonSelfNevid.Checked = false;
		Class72.bool_30 = false;
		Class72.bool_31 = false;
		Class72.int_9 = 0;
	}

	private void menuitemDoSearchBox_Click(object sender, EventArgs e)
	{
		if (!menuitemDoSearchBox.Checked)
		{
			method_40();
			return;
		}
		using FormTreasure formTreasure = new FormTreasure();
		formTreasure.ShowDialog();
	}

	internal void method_40()
	{
		menuitemDoSearchBox.Checked = false;
		Class72.bool_34 = false;
	}

	internal void method_41()
	{
		menuitemDoSearchBox.Checked = true;
		Class72.bool_34 = true;
	}

	private void menuitemDoResetVisitedCells_Click(object sender, EventArgs e)
	{
		Class77.smethod_31();
		smethod_56();
	}

	private static DateTime smethod_57(double double_0)
	{
		return new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc).AddSeconds(double_0).ToLocalTime();
	}

	private static void smethod_58()
	{
		Class72.formMain_0.groupBoxCreate.Visible = true;
		Class72.formMain_0.listBoxComplects.Visible = true;
		Class72.formMain_0.buttonGet.Visible = true;
		Class72.formMain_0.checkBoxWear.Visible = true;
		Class72.formMain_0.buttonDelete.Visible = true;
		Class72.formMain_0.checkLocCureOnlyFriends.Visible = true;
		Class72.formMain_0.checkLocCureOnlyFriends.Checked = true;
	}

	private void timer_4_Tick(object sender, EventArgs e)
	{
		timer_4.Stop();
		Class72.dateTime_13 = DateTime.Now;
		Class10.smethod_4();
		_ = Class72.string_47;
		if (Class72.string_47 == Class68.string_4)
		{
			method_63($"Ваша лицензия закончится <b>{Class72.dateTime_13 = DateTime.Now.AddYears(40)}</b>");
			Class72.string_47 = Class68.string_3;
			Class72.dateTime_13 = DateTime.Now.AddYears(40);
			smethod_58();
		}
		if (Class72.string_47 == "BLAZE" || Class72.string_47 == "LS" || Class72.string_47 == "VIP")
		{
			smethod_58();
		}
	}

	private void buttonFury_Click(object sender, EventArgs e)
	{
		Class72.bool_33 = buttonFury.Checked;
		Class72.formMain_0.method_63(Class72.bool_33 ? "Включен <b>режим свитка осады</b>. В этом режиме в бою против босса первым ударом будет <b>Снежок</b> или <b>Свиток Удар Ярости</b>, после чего отключится автобой. <b><font color=red>Не забудьте надеть свиток!</font></b>" : "<b>Режим свитка осады</b> отключен.");
	}

	private void menuitemSettingsAb_Click(object sender, EventArgs e)
	{
		method_127();
	}

	public void method_42(string string_0)
	{
		method_109("http://www.neverlands.ru/exit.php");
		while (browserGame.ReadyState != WebBrowserReadyState.Complete)
		{
			Application.DoEvents();
		}
		Class54.smethod_1();
		Class72.smethod_7(string_0);
		Class72.smethod_11(bool_54: false);
		Close();
	}

	private void menuitemCheckCell_Click(object sender, EventArgs e)
	{
		bool flag = false;
		AbcCell abcCell = Class77.smethod_6()[Class72.string_4];
		abcCell.Verified = DateTime.Now;
		if (string.Compare(Class72.smethod_134(), abcCell.Label, StringComparison.Ordinal) != 0)
		{
			method_63("Название исправлено. Было: [" + abcCell.Label + "], стало [" + Class72.smethod_134() + "]");
			abcCell.Label = Class72.smethod_134();
			flag = true;
		}
		string text = Class12.smethod_1(Class72.smethod_16(), "var map = [", "];");
		if (!string.IsNullOrEmpty(text))
		{
			string[] array = text.Split(',');
			if (array.Length >= 2)
			{
				int.TryParse(array[2], out var result);
				if (result > 0 && result != abcCell.Cost)
				{
					method_63($"Длительность перехода исправлена. Была: [{abcCell.Cost}], стала [{result}]");
					abcCell.Cost = result;
					flag = true;
				}
			}
		}
		if (flag)
		{
			Class77.smethod_16();
			Class72.formMain_0.BeginInvoke(new Delegate20(Class72.formMain_0.method_110), new object[0]);
		}
		else
		{
			method_63("Клетка [" + abcCell.RegNum + "] проверена");
		}
	}

	private void mapScanToolStripMenuItem_Click(object sender, EventArgs e)
	{
		ThreadPool.QueueUserWorkItem(method_43);
	}

	private void method_43(object object_0)
	{
		method_63("Сканирование карты начато...");
		foreach (KeyValuePair<string, Class85> item in Class77.smethod_0())
		{
			Class85 value = item.Value;
			string requestUriString = $"http://www.neverlands.ru/ch.php?lo=1&r=m_{value.method_0()}_{value.method_2()}";
			while (true)
			{
				try
				{
					while (true)
					{
						HttpWebRequest obj = (HttpWebRequest)WebRequest.Create(requestUriString);
						obj.Method = "GET";
						obj.Proxy = Class72.webProxy_0;
						string value2 = Class32.smethod_1("www.neverlands.ru");
						obj.Headers.Add("Cookie", value2);
						Stream responseStream = obj.GetResponse().GetResponseStream();
						if (responseStream == null)
						{
							break;
						}
						string text = new StreamReader(responseStream, Class72.encoding_0).ReadToEnd();
						if (string.IsNullOrEmpty(text))
						{
							continue;
						}
						string text2 = Class12.smethod_1(text, "<font class=placename><b>", "</b></font></a>");
						if (string.IsNullOrEmpty(text2))
						{
							if (Class77.smethod_6().ContainsKey(value.method_4()))
							{
								AbcCell abcCell = Class77.smethod_6()[value.method_4()];
								method_63("Клетка " + value.method_4() + " (" + abcCell.Label + ") удалена");
								Class77.smethod_6().Remove(value.method_4());
							}
							break;
						}
						text2 = text2.Replace("<br>", " ");
						if (Class77.smethod_6().ContainsKey(value.method_4()))
						{
							AbcCell abcCell2 = Class77.smethod_6()[value.method_4()];
							if (!abcCell2.Label.Equals(text2))
							{
								method_63(value.method_4() + ": " + text2 + " (было " + abcCell2.Label + ")");
								abcCell2.Label = text2;
							}
						}
						else
						{
							method_63("Клетка " + value.method_4() + " (" + text2 + ") добавлена");
							AbcCell abcCell3 = new AbcCell
							{
								RegNum = value.method_4(),
								Label = text2,
								Cost = 30
							};
							Class77.smethod_6().Add(abcCell3.RegNum, abcCell3);
						}
						break;
					}
				}
				catch
				{
					continue;
				}
				break;
			}
		}
		Class77.smethod_16();
		method_63("Сканирование карты закончено!");
	}

	private void timer_5_Tick(object sender, EventArgs e)
	{
		ContactsManager.Pulse();
	}

	private void ClanKaznaViewART_Click(object sender, EventArgs e)
	{
		if (!int.TryParse((string)((ToolStripMenuItem)sender).Tag, out var result))
		{
			result = 0;
		}
		Class72.int_13 = result;
		ClanKaznaViewButton.Text = ((ToolStripMenuItem)sender).Text;
	}

	private void menuItemTurotor_Click(object sender, EventArgs e)
	{
		if (!menuItemTurotor.Checked)
		{
			method_44();
			return;
		}
		using FormTurotor formTurotor = new FormTurotor();
		formTurotor.ShowDialog();
	}

	internal void method_44()
	{
		menuItemTurotor.Checked = false;
		Class72.bool_36 = false;
		Class72.string_41 = null;
		Class72.string_42 = null;
	}

	internal bool method_45()
	{
		return menuItemTurotor.Checked;
	}

	private void buttonAutoDNV_Click(object sender, EventArgs e)
	{
		Class72.bool_38 = buttonAutoDNV.Checked;
		timer_6.Enabled = buttonAutoDNV.Checked;
		if (Class72.bool_38)
		{
			timer_6.Interval = Class72.class19_0.method_194() * 60000;
			Class72.formMain_0.BeginInvoke(new Delegate20(Class72.formMain_0.method_110), new object[0]);
		}
	}

	private void timer_6_Tick(object sender, EventArgs e)
	{
		Class72.bool_38 = true;
		Class72.formMain_0.BeginInvoke(new Delegate20(Class72.formMain_0.method_110), new object[0]);
	}

	private void CraftButton_Click(object sender, EventArgs e)
	{
		Class72.bool_39 = CraftButton.Checked;
		Class72.formMain_0.BeginInvoke(new Delegate20(Class72.formMain_0.method_110), new object[0]);
	}

	internal void method_46()
	{
		CraftButton.Checked = false;
		Class72.bool_39 = false;
		Class72.string_43 = null;
		Class72.string_44 = null;
	}

	private void checkLicToolStripMenuItem_Click(object sender, EventArgs e)
	{
		method_63("Ваша лицензия закончится <b>" + Class72.dateTime_13.ToString() + "</b>");
	}

	private void method_47(object sender, EventArgs e)
	{
		dropDownMineStat.DropDownItems.Clear();
		dropDownMineStat.Enabled = false;
	}

	private void method_48(object sender, EventArgs e)
	{
		string text = string.Empty;
		for (int i = 0; i < dropDownMineStat.DropDownItems.Count; i++)
		{
			string text2 = dropDownMineStat.DropDownItems[i].Text;
			if (text2 != "Очистить" && text2 != "Скопировать" && !string.IsNullOrEmpty(text2))
			{
				if (i > 0)
				{
					text += ", ";
				}
				text += text2;
			}
		}
		Clipboard.SetText(text);
	}

	private void buttonAutoMine_Click(object sender, EventArgs e)
	{
		Class72.bool_41 = buttonAutoMine.Checked;
		if (Class72.bool_41)
		{
			Class72.formMain_0.BeginInvoke(new Delegate20(Class72.formMain_0.method_110), new object[0]);
		}
	}

	internal void method_49()
	{
		buttonAutoMine.Checked = false;
		Class72.bool_41 = false;
		Class72.bool_42 = false;
		Class72.bool_43 = false;
	}

	internal void method_50(string[] string_0)
	{
		dropDownMineStat.Enabled = true;
		SortedDictionary<string, ToolStripItem> sortedDictionary = new SortedDictionary<string, ToolStripItem>();
		for (int i = 0; i < dropDownMineStat.DropDownItems.Count; i++)
		{
			string text = dropDownMineStat.DropDownItems[i].Text;
			if (text != "Очистить" && text != "Скопировать" && !string.IsNullOrEmpty(text))
			{
				sortedDictionary.Add(text, dropDownMineStat.DropDownItems[i]);
			}
		}
		dropDownMineStat.DropDownItems.Clear();
		for (int j = 0; j < string_0.Length; j++)
		{
			string text2 = string_0[j].Split('(')[0].Trim();
			float num = float.Parse(Class12.smethod_1(string_0[j], "(", ")"), CultureInfo.InvariantCulture);
			foreach (KeyValuePair<string, ToolStripItem> item in sortedDictionary)
			{
				if (item.Key.Contains(text2))
				{
					float num2 = float.Parse(Class12.smethod_1(item.Key, "(", " кг.)"));
					num += num2;
					sortedDictionary.Remove(item.Key);
					break;
				}
			}
			string key = text2 + ": (" + num + " кг.)";
			ToolStripMenuItem value = new ToolStripMenuItem(key);
			sortedDictionary.Add(key, value);
		}
		ToolStripMenuItem[] array = new ToolStripMenuItem[sortedDictionary.Count];
		SortedDictionary<string, ToolStripItem>.ValueCollection values = sortedDictionary.Values;
		ToolStripItem[] array2 = array;
		values.CopyTo(array2, 0);
		ToolStripItemCollection dropDownItems = dropDownMineStat.DropDownItems;
		array2 = array;
		dropDownItems.AddRange(array2);
		dropDownMineStat.DropDownItems.Add(new ToolStripSeparator());
		ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem("Скопировать");
		toolStripMenuItem.Click += method_48;
		dropDownMineStat.DropDownItems.Add(toolStripMenuItem);
		ToolStripMenuItem toolStripMenuItem2 = new ToolStripMenuItem("Очистить");
		toolStripMenuItem2.Click += method_47;
		dropDownMineStat.DropDownItems.Add(toolStripMenuItem2);
	}

	private void cmtsFightLog_Click(object sender, EventArgs e)
	{
		method_70();
	}

	private void buttonFriendsInvis_Click(object sender, EventArgs e)
	{
		if (buttonFriendsInvis.Checked)
		{
			buttonWalkers.Checked = true;
			method_38(bool_0: true);
		}
		smethod_56();
	}

	internal bool method_51()
	{
		return buttonFriendsInvis.Checked;
	}

	private void buttonLocationCure_Click(object sender, EventArgs e)
	{
		if (buttonLocationCure.Checked)
		{
			buttonWalkers.Checked = true;
			method_38(bool_0: true);
			string text = string.Empty;
			string[] array = new string[4] { "лёгких", "средних", "тяжёлых", "боевых" };
			for (int i = 0; i < Class72.class19_0.method_70().Length; i++)
			{
				if (Class72.class19_0.method_70()[i])
				{
					if (text != string.Empty)
					{
						text += ", ";
					}
					text += array[i];
				}
			}
			if (text == string.Empty)
			{
				method_63("Не выбрано ни одного вида травм. Откройте настройки и укажите травмы для лечения.");
			}
			else
			{
				method_63("Включено автолечение <b>" + text + "</b> травм на локации.");
			}
		}
		smethod_56();
	}

	internal bool method_52()
	{
		return buttonLocationCure.Checked;
	}

	internal bool method_53()
	{
		return checkLocCureOnlyFriends.Checked;
	}

	private void buttonCreateStart_Click(object sender, EventArgs e)
	{
		Class72.bool_45 = true;
		buttonCreateFinish.Enabled = true;
		buttonCreateStart.Enabled = false;
		method_63("Запущен режим создания комплекта. Соберите необходимые вещи из казны клана.");
	}

	private void buttonCreateFinish_Click(object sender, EventArgs e)
	{
		method_3();
	}

	private void buttonDelete_Click(object sender, EventArgs e)
	{
		method_5();
	}

	private void buttonGet_Click(object sender, EventArgs e)
	{
		method_4();
	}

	private void tabControlRight_Selecting(object sender, TabControlCancelEventArgs e)
	{
		if (e.TabPage.Name == "tabPageComplects" && (Class72.string_47 == Class68.string_3 || Class72.string_47 == Class68.string_2))
		{
			e.Cancel = true;
		}
		if (e.TabPage.Name == "tabPageTextLog" && Class72.class19_0.method_30() != Class68.string_1)
		{
			e.Cancel = true;
		}
	}

	private void buttonDisableSysMsg_Click(object sender, EventArgs e)
	{
		Class72.bool_47 = !buttonDisableSysMsg.Checked;
	}

	private void menuItemResetPlants_Click(object sender, EventArgs e)
	{
		Class72.class19_0.sortedDictionary_0.Clear();
	}

	private void CraftAllButton_Click(object sender, EventArgs e)
	{
		Class72.bool_40 = CraftAllButton.Checked;
	}

	private void method_54(object sender, EventArgs e)
	{
		Class72.smethod_35(bool_54: true);
		Class72.formMain_0.BeginInvoke(new Delegate20(Class72.formMain_0.method_110), new object[0]);
	}

	private void ForpostBuildingsToolStripMenuItem_Click(object sender, EventArgs e)
	{
		new ForpostBuildings().Show();
	}

	private void button1_Click(object sender, EventArgs e)
	{
		Class72.class79_0?.method_4("1");
	}

	private void button2_Click(object sender, EventArgs e)
	{
		Class72.class79_0?.method_4("0");
	}

	private void button3_Click(object sender, EventArgs e)
	{
		Class72.class79_0?.method_4("-1");
	}

	private void button4_Click(object sender, EventArgs e)
	{
		Class72.class79_0?.method_5();
	}

	private void DrinkSetAddButton_Click(object sender, EventArgs e)
	{
		method_8();
	}

	private void DrinkSetItemAddButton_Click(object sender, EventArgs e)
	{
		method_12();
	}

	private void DrinkSetsNames_SelectedIndexChanged(object sender, EventArgs e)
	{
		method_10();
	}

	private void DrinkSetUse_Click(object sender, EventArgs e)
	{
		method_15();
	}

	private void DrinkSetSave_Click(object sender, EventArgs e)
	{
		method_13();
	}

	private void DrinkSetDelete_Click(object sender, EventArgs e)
	{
		method_14();
	}

	internal bool method_55()
	{
		return autoForestButton.Checked;
	}

	internal void method_56()
	{
		autoForestButton.Checked = false;
		Class72.bool_51 = false;
		Class72.bool_52 = false;
	}

	private void timer_7_Tick(object sender, EventArgs e)
	{
		Class77.smethod_16();
		Class77.smethod_33();
		Class72.class19_0.method_20();
	}

	private void FortBuffsSave_Click(object sender, EventArgs e)
	{
		method_17();
	}

	private void FortBuffsCollect_Click(object sender, EventArgs e)
	{
		method_18();
	}

	private void tpLocation12_Click(object sender, EventArgs e)
	{
		Class72.int_18 = int.Parse((string)((ToolStripMenuItem)sender).Tag);
		Class72.formMain_0.method_19("i_w28_22.gif", Class72.class19_0.method_30(), 1);
		smethod_56();
	}

	private void CityHallMenuItem_Click(object sender, EventArgs e)
	{
		new CityHall().Show();
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ABClient.ABForms.FormMain));
		this.CmPerson = new System.Windows.Forms.ContextMenuStrip(this.icontainer_0);
		this.cmtsFightLog = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripSeparator26 = new System.Windows.Forms.ToolStripSeparator();
		this.cmtsClassNeutral = new System.Windows.Forms.ToolStripMenuItem();
		this.cmtsClassFoe = new System.Windows.Forms.ToolStripMenuItem();
		this.cmtsClassFriend = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripSeparator18 = new System.Windows.Forms.ToolStripSeparator();
		this.cmtsToolId0 = new System.Windows.Forms.ToolStripMenuItem();
		this.cmtsToolId1 = new System.Windows.Forms.ToolStripMenuItem();
		this.cmtsToolId2 = new System.Windows.Forms.ToolStripMenuItem();
		this.cmtsToolId3 = new System.Windows.Forms.ToolStripMenuItem();
		this.cmtsToolId4 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
		this.cmtsDeleteContact = new System.Windows.Forms.ToolStripMenuItem();
		this.cmtsContactPrivate = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripSeparator19 = new System.Windows.Forms.ToolStripSeparator();
		this.cmtsContactQuick = new System.Windows.Forms.ToolStripMenuItem();
		this.statusStrip = new System.Windows.Forms.StatusStrip();
		this.dropdownCurrentStat = new System.Windows.Forms.ToolStripDropDownButton();
		this.menuitemStatEdit = new System.Windows.Forms.ToolStripMenuItem();
		this.menuitemStatItem0 = new System.Windows.Forms.ToolStripMenuItem();
		this.menuitemStatItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.menuitemStatItem2 = new System.Windows.Forms.ToolStripMenuItem();
		this.menuitemStatItem3 = new System.Windows.Forms.ToolStripMenuItem();
		this.menuitemStatItem4 = new System.Windows.Forms.ToolStripMenuItem();
		this.statuslabelActivity = new System.Windows.Forms.ToolStripStatusLabel();
		this.statuslabelNumberOfThreads = new System.Windows.Forms.ToolStripStatusLabel();
		this.statuslabelLocation = new System.Windows.Forms.ToolStripStatusLabel();
		this.dropdownPv = new System.Windows.Forms.ToolStripDropDownButton();
		this.statuslabelTied = new System.Windows.Forms.ToolStripStatusLabel();
		this.dropdownTravm = new System.Windows.Forms.ToolStripDropDownButton();
		this.toolStripMenuItem_0 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_1 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripSeparator13 = new System.Windows.Forms.ToolStripSeparator();
		this.toolStripMenuItem_2 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_3 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_4 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_5 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripSeparator14 = new System.Windows.Forms.ToolStripSeparator();
		this.toolStripMenuItem_6 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_7 = new System.Windows.Forms.ToolStripMenuItem();
		this.statuslabelAutoAdv = new System.Windows.Forms.ToolStripStatusLabel();
		this.statuslabelClock = new System.Windows.Forms.ToolStripStatusLabel();
		this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
		this.dropdownTimers = new System.Windows.Forms.ToolStripDropDownButton();
		this.menuitemNewTimer = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
		this.dropDownMineStat = new System.Windows.Forms.ToolStripDropDownButton();
		this.labelAddress = new System.Windows.Forms.ToolStripStatusLabel();
		this.panelRight = new System.Windows.Forms.Panel();
		this.tabControlRight = new System.Windows.Forms.TabControl();
		this.tabPageContacts = new System.Windows.Forms.TabPage();
		this.treeContacts = new ABClient.AppControls.TreeViewEx();
		this.imageList_3 = new System.Windows.Forms.ImageList(this.icontainer_0);
		this.collapsibleSplitterContacts = new ABClient.AppControls.CollapsibleSplitter();
		this.tbContactDetails = new System.Windows.Forms.TextBox();
		this.toolStrip3 = new System.Windows.Forms.ToolStrip();
		this.tsContactTrace = new System.Windows.Forms.ToolStripButton();
		this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
		this.tsDeleteContact = new System.Windows.Forms.ToolStripButton();
		this.tsContactPrivate = new System.Windows.Forms.ToolStripButton();
		this.MakeEnemyContactsNeutralButton = new System.Windows.Forms.ToolStripButton();
		this.tabPageMine = new System.Windows.Forms.TabPage();
		this.button4 = new System.Windows.Forms.Button();
		this.groupBox1 = new System.Windows.Forms.GroupBox();
		this.button3 = new System.Windows.Forms.Button();
		this.button2 = new System.Windows.Forms.Button();
		this.button1 = new System.Windows.Forms.Button();
		this.tabPageComplects = new System.Windows.Forms.TabPage();
		this.checkLocCureOnlyFriends = new System.Windows.Forms.CheckBox();
		this.buttonDelete = new System.Windows.Forms.Button();
		this.checkBoxWear = new System.Windows.Forms.CheckBox();
		this.buttonGet = new System.Windows.Forms.Button();
		this.listBoxComplects = new System.Windows.Forms.ListBox();
		this.groupBoxCreate = new System.Windows.Forms.GroupBox();
		this.label1 = new System.Windows.Forms.Label();
		this.textBoxComplectName = new System.Windows.Forms.TextBox();
		this.buttonCreateStart = new System.Windows.Forms.Button();
		this.buttonCreateFinish = new System.Windows.Forms.Button();
		this.tabPageTextLog = new System.Windows.Forms.TabPage();
		this.panelTexLog = new System.Windows.Forms.Panel();
		this.textboxTexLog = new System.Windows.Forms.TextBox();
		this.toolStrip1 = new System.Windows.Forms.ToolStrip();
		this.buttonDoTexLog = new System.Windows.Forms.ToolStripButton();
		this.buttonClearTexLog = new System.Windows.Forms.ToolStripButton();
		this.tabPageDrinkSets = new System.Windows.Forms.TabPage();
		this.groupBox3 = new System.Windows.Forms.GroupBox();
		this.FortBuffsCollect = new System.Windows.Forms.Button();
		this.FortBuffsSave = new System.Windows.Forms.Button();
		this.FortBuffsCells = new System.Windows.Forms.TextBox();
		this.groupBox2 = new System.Windows.Forms.GroupBox();
		this.DrinkSetSave = new System.Windows.Forms.Button();
		this.DrinkSetDelete = new System.Windows.Forms.Button();
		this.DrinkSetUse = new System.Windows.Forms.Button();
		this.DrinkSetComposition = new System.Windows.Forms.TextBox();
		this.DrinkSetsNames = new System.Windows.Forms.ListBox();
		this.DrinkSetItemAddButton = new System.Windows.Forms.Button();
		this.DrinkSetItemUsesAmount = new System.Windows.Forms.NumericUpDown();
		this.label2 = new System.Windows.Forms.Label();
		this.DrinkSetItemsMenu = new System.Windows.Forms.ComboBox();
		this.DrinkSetAddButton = new System.Windows.Forms.Button();
		this.DrinkSetName = new System.Windows.Forms.TextBox();
		this.tabControlLeft = new System.Windows.Forms.TabControl();
		this.tabPageGame = new System.Windows.Forms.TabPage();
		this.panelGame = new System.Windows.Forms.Panel();
		this.browserGame = new ABClient.AppControls.ExtendedWebBrowser();
		this.toolbarGame = new System.Windows.Forms.ToolStrip();
		this.buttonAutoboi = new System.Windows.Forms.ToolStripButton();
		this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
		this.buttonFury = new System.Windows.Forms.ToolStripButton();
		this.buttonAutoRefresh = new System.Windows.Forms.ToolStripButton();
		this.buttonWaitOpen = new System.Windows.Forms.ToolStripButton();
		this.buttonPerenap = new System.Windows.Forms.ToolStripButton();
		this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
		this.buttonWalkers = new System.Windows.Forms.ToolStripButton();
		this.buttonOpenNevid = new System.Windows.Forms.ToolStripButton();
		this.buttonSelfNevid = new System.Windows.Forms.ToolStripButton();
		this.buttonFriendsInvis = new System.Windows.Forms.ToolStripButton();
		this.buttonLocationCure = new System.Windows.Forms.ToolStripButton();
		this.buttonAutoAttack = new System.Windows.Forms.ToolStripSplitButton();
		this.miAutoAttack0 = new System.Windows.Forms.ToolStripMenuItem();
		this.miAutoAttack1 = new System.Windows.Forms.ToolStripMenuItem();
		this.miAutoAttack2 = new System.Windows.Forms.ToolStripMenuItem();
		this.miAutoAttack3 = new System.Windows.Forms.ToolStripMenuItem();
		this.miAutoAttack4 = new System.Windows.Forms.ToolStripMenuItem();
		this.miAutoAttack5 = new System.Windows.Forms.ToolStripMenuItem();
		this.miAutoAttack6 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripSeparator23 = new System.Windows.Forms.ToolStripSeparator();
		this.buttonNavigator = new System.Windows.Forms.ToolStripButton();
		this.teleportDropDown = new System.Windows.Forms.ToolStripDropDownButton();
		this.tpLocation1 = new System.Windows.Forms.ToolStripMenuItem();
		this.tpLocation2 = new System.Windows.Forms.ToolStripMenuItem();
		this.tpLocation3 = new System.Windows.Forms.ToolStripMenuItem();
		this.tpLocation4 = new System.Windows.Forms.ToolStripMenuItem();
		this.tpLocation5 = new System.Windows.Forms.ToolStripMenuItem();
		this.tpLocation6 = new System.Windows.Forms.ToolStripMenuItem();
		this.tpLocation7 = new System.Windows.Forms.ToolStripMenuItem();
		this.tpLocation8 = new System.Windows.Forms.ToolStripMenuItem();
		this.tpLocation9 = new System.Windows.Forms.ToolStripMenuItem();
		this.tpLocation10 = new System.Windows.Forms.ToolStripMenuItem();
		this.tpLocation11 = new System.Windows.Forms.ToolStripMenuItem();
		this.tpLocation12 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripSeparator15 = new System.Windows.Forms.ToolStripSeparator();
		this.buttonSilence = new System.Windows.Forms.ToolStripButton();
		this.buttonDisableSysMsg = new System.Windows.Forms.ToolStripButton();
		this.buttonAutoAnswer = new System.Windows.Forms.ToolStripButton();
		this.buttonDrink = new System.Windows.Forms.ToolStripButton();
		this.buttonAutoAdv = new System.Windows.Forms.ToolStripButton();
		this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
		this.buttonAutoFish = new System.Windows.Forms.ToolStripButton();
		this.buttonAutoSkin = new System.Windows.Forms.ToolStripButton();
		this.buttonAutoMine = new System.Windows.Forms.ToolStripButton();
		this.CraftButton = new System.Windows.Forms.ToolStripButton();
		this.CraftAllButton = new System.Windows.Forms.ToolStripButton();
		this.autoForestButton = new System.Windows.Forms.ToolStripButton();
		this.toolStripSeparator22 = new System.Windows.Forms.ToolStripSeparator();
		this.buttonAutoDNV = new System.Windows.Forms.ToolStripButton();
		this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
		this.ClanKaznaViewButton = new System.Windows.Forms.ToolStripDropDownButton();
		this.ClanKaznaViewAll = new System.Windows.Forms.ToolStripMenuItem();
		this.ClanKaznaViewRAR = new System.Windows.Forms.ToolStripMenuItem();
		this.ClanKaznaViewART = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
		this.buttonGameLogOn = new System.Windows.Forms.ToolStripButton();
		this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
		this.buttonGameScreen = new System.Windows.Forms.ToolStripButton();
		this.imageList_1 = new System.Windows.Forms.ImageList(this.icontainer_0);
		this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
		this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
		this.menuStrip = new System.Windows.Forms.MenuStrip();
		this.menuitemGame = new System.Windows.Forms.ToolStripMenuItem();
		this.menuitemSettingsAb = new System.Windows.Forms.ToolStripMenuItem();
		this.menuitemSettingsGeneral = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripSeparator17 = new System.Windows.Forms.ToolStripSeparator();
		this.menuitemGameLogOn = new System.Windows.Forms.ToolStripMenuItem();
		this.menuitemGameExit = new System.Windows.Forms.ToolStripMenuItem();
		this.menuitemTabs = new System.Windows.Forms.ToolStripMenuItem();
		this.menuitemOpenTab = new System.Windows.Forms.ToolStripMenuItem();
		this.menuitemOpenForum = new System.Windows.Forms.ToolStripMenuItem();
		this.menuitemOpenTodayChat = new System.Windows.Forms.ToolStripMenuItem();
		this.menuitemOpenNotepad = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripSeparator16 = new System.Windows.Forms.ToolStripSeparator();
		this.aPIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.ForpostBuildingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.CityHallMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.menuitemTools = new System.Windows.Forms.ToolStripMenuItem();
		this.menuitemDoSearchBox = new System.Windows.Forms.ToolStripMenuItem();
		this.menuitemDoResetVisitedCells = new System.Windows.Forms.ToolStripMenuItem();
		this.menuItemResetPlants = new System.Windows.Forms.ToolStripMenuItem();
		this.mapScanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.menuitemCheckCell = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
		this.menuItemTurotor = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripSeparator25 = new System.Windows.Forms.ToolStripSeparator();
		this.menuitemFishAdvisor = new System.Windows.Forms.ToolStripMenuItem();
		this.menuitemCommands = new System.Windows.Forms.ToolStripMenuItem();
		this.miWearAfter = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
		this.miFastEnabled = new System.Windows.Forms.ToolStripMenuItem();
		this.miFastTeleport = new System.Windows.Forms.ToolStripMenuItem();
		this.miFastDarkTeleport = new System.Windows.Forms.ToolStripMenuItem();
		this.miFastSviRass = new System.Windows.Forms.ToolStripMenuItem();
		this.miFastSviSelfRass = new System.Windows.Forms.ToolStripMenuItem();
		this.miFastF3 = new System.Windows.Forms.ToolStripMenuItem();
		this.miFastF4 = new System.Windows.Forms.ToolStripMenuItem();
		this.miFastElxVosst = new System.Windows.Forms.ToolStripMenuItem();
		this.miFastSvitFog = new System.Windows.Forms.ToolStripMenuItem();
		this.miFastDarkFog = new System.Windows.Forms.ToolStripMenuItem();
		this.miFastF9 = new System.Windows.Forms.ToolStripMenuItem();
		this.miFastF10 = new System.Windows.Forms.ToolStripMenuItem();
		this.miFastF12 = new System.Windows.Forms.ToolStripMenuItem();
		this.miQuick = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
		this.menuitemClanPrivate = new System.Windows.Forms.ToolStripMenuItem();
		this.menuitemMinimize = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripSeparator20 = new System.Windows.Forms.ToolStripSeparator();
		this.miQuickCancel = new System.Windows.Forms.ToolStripMenuItem();
		this.menuitemSystem = new System.Windows.Forms.ToolStripMenuItem();
		this.menuitemShowCookies = new System.Windows.Forms.ToolStripMenuItem();
		this.menuitemMainFrameInspector = new System.Windows.Forms.ToolStripMenuItem();
		this.menuitemCacheRefresh = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
		this.checkLicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.menuitemAbout = new System.Windows.Forms.ToolStripMenuItem();
		this.imageList_0 = new System.Windows.Forms.ImageList(this.icontainer_0);
		this.saveFileDialog_0 = new System.Windows.Forms.SaveFileDialog();
		this.timer_0 = new System.Windows.Forms.Timer(this.icontainer_0);
		this.imageList_2 = new System.Windows.Forms.ImageList(this.icontainer_0);
		this.notifyIcon_0 = new System.Windows.Forms.NotifyIcon(this.icontainer_0);
		this.cmTray = new System.Windows.Forms.ContextMenuStrip(this.icontainer_0);
		this.menuitemRestoreWindow = new System.Windows.Forms.ToolStripMenuItem();
		this.menuitemTrayQuit = new System.Windows.Forms.ToolStripMenuItem();
		this.timer_1 = new System.Windows.Forms.Timer(this.icontainer_0);
		this.CmGroup = new System.Windows.Forms.ContextMenuStrip(this.icontainer_0);
		this.miSetGroupNeutral = new System.Windows.Forms.ToolStripMenuItem();
		this.miSetGroupFoe = new System.Windows.Forms.ToolStripMenuItem();
		this.miSetGroupFriend = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripSeparator21 = new System.Windows.Forms.ToolStripSeparator();
		this.miSetGroupToolId0 = new System.Windows.Forms.ToolStripMenuItem();
		this.miSetGroupToolId1 = new System.Windows.Forms.ToolStripMenuItem();
		this.miSetGroupToolId2 = new System.Windows.Forms.ToolStripMenuItem();
		this.miSetGroupToolId3 = new System.Windows.Forms.ToolStripMenuItem();
		this.miSetGroupToolId4 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripSeparator24 = new System.Windows.Forms.ToolStripSeparator();
		this.miRemoveGroup = new System.Windows.Forms.ToolStripMenuItem();
		this.timer_2 = new System.Windows.Forms.Timer(this.icontainer_0);
		this.timer_3 = new System.Windows.Forms.Timer(this.icontainer_0);
		this.timer_4 = new System.Windows.Forms.Timer(this.icontainer_0);
		this.timer_5 = new System.Windows.Forms.Timer(this.icontainer_0);
		this.timer_6 = new System.Windows.Forms.Timer(this.icontainer_0);
		this.timer_7 = new System.Windows.Forms.Timer(this.icontainer_0);
		this.collapsibleSplitter = new ABClient.AppControls.CollapsibleSplitter();
		this.CmPerson.SuspendLayout();
		this.statusStrip.SuspendLayout();
		this.panelRight.SuspendLayout();
		this.tabControlRight.SuspendLayout();
		this.tabPageContacts.SuspendLayout();
		this.toolStrip3.SuspendLayout();
		this.tabPageMine.SuspendLayout();
		this.groupBox1.SuspendLayout();
		this.tabPageComplects.SuspendLayout();
		this.groupBoxCreate.SuspendLayout();
		this.tabPageTextLog.SuspendLayout();
		this.panelTexLog.SuspendLayout();
		this.toolStrip1.SuspendLayout();
		this.tabPageDrinkSets.SuspendLayout();
		this.groupBox3.SuspendLayout();
		this.groupBox2.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.DrinkSetItemUsesAmount).BeginInit();
		this.tabControlLeft.SuspendLayout();
		this.tabPageGame.SuspendLayout();
		this.panelGame.SuspendLayout();
		this.toolbarGame.SuspendLayout();
		this.menuStrip.SuspendLayout();
		this.cmTray.SuspendLayout();
		this.CmGroup.SuspendLayout();
		base.SuspendLayout();
		this.CmPerson.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
		this.CmPerson.Items.AddRange(new System.Windows.Forms.ToolStripItem[16]
		{
			this.cmtsFightLog, this.toolStripSeparator26, this.cmtsClassNeutral, this.cmtsClassFoe, this.cmtsClassFriend, this.toolStripSeparator18, this.cmtsToolId0, this.cmtsToolId1, this.cmtsToolId2, this.cmtsToolId3,
			this.cmtsToolId4, this.toolStripSeparator9, this.cmtsDeleteContact, this.cmtsContactPrivate, this.toolStripSeparator19, this.cmtsContactQuick
		});
		this.CmPerson.Name = "CmPerson";
		this.CmPerson.Size = new System.Drawing.Size(222, 292);
		this.cmtsFightLog.Enabled = false;
		this.cmtsFightLog.Name = "cmtsFightLog";
		this.cmtsFightLog.Size = new System.Drawing.Size(221, 22);
		this.cmtsFightLog.Text = "Лог боя";
		this.cmtsFightLog.Click += new System.EventHandler(cmtsFightLog_Click);
		this.toolStripSeparator26.Name = "toolStripSeparator26";
		this.toolStripSeparator26.Size = new System.Drawing.Size(218, 6);
		this.cmtsClassNeutral.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
		this.cmtsClassNeutral.Name = "cmtsClassNeutral";
		this.cmtsClassNeutral.Size = new System.Drawing.Size(221, 22);
		this.cmtsClassNeutral.Text = "Нейтрал";
		this.cmtsClassNeutral.Click += new System.EventHandler(cmtsClassNeutral_Click);
		this.cmtsClassFoe.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
		this.cmtsClassFoe.ForeColor = System.Drawing.Color.DarkRed;
		this.cmtsClassFoe.Name = "cmtsClassFoe";
		this.cmtsClassFoe.Size = new System.Drawing.Size(221, 22);
		this.cmtsClassFoe.Text = "Враг";
		this.cmtsClassFoe.Click += new System.EventHandler(cmtsClassFoe_Click);
		this.cmtsClassFriend.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
		this.cmtsClassFriend.ForeColor = System.Drawing.Color.DarkGreen;
		this.cmtsClassFriend.Name = "cmtsClassFriend";
		this.cmtsClassFriend.Size = new System.Drawing.Size(221, 22);
		this.cmtsClassFriend.Text = "Друг";
		this.cmtsClassFriend.Click += new System.EventHandler(cmtsClassFriend_Click);
		this.toolStripSeparator18.Name = "toolStripSeparator18";
		this.toolStripSeparator18.Size = new System.Drawing.Size(218, 6);
		this.cmtsToolId0.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
		this.cmtsToolId0.Name = "cmtsToolId0";
		this.cmtsToolId0.Size = new System.Drawing.Size(221, 22);
		this.cmtsToolId0.Text = "Как на тулбаре";
		this.cmtsToolId0.Click += new System.EventHandler(cmtsToolId0_Click);
		this.cmtsToolId1.Name = "cmtsToolId1";
		this.cmtsToolId1.Size = new System.Drawing.Size(221, 22);
		this.cmtsToolId1.Text = "Боевая нападалка";
		this.cmtsToolId1.Click += new System.EventHandler(cmtsToolId1_Click);
		this.cmtsToolId2.Name = "cmtsToolId2";
		this.cmtsToolId2.Size = new System.Drawing.Size(221, 22);
		this.cmtsToolId2.Text = "Закрытая боевая нападалка";
		this.cmtsToolId2.Click += new System.EventHandler(cmtsToolId2_Click);
		this.cmtsToolId3.Name = "cmtsToolId3";
		this.cmtsToolId3.Size = new System.Drawing.Size(221, 22);
		this.cmtsToolId3.Text = "Кулачка";
		this.cmtsToolId3.Click += new System.EventHandler(cmtsToolId3_Click);
		this.cmtsToolId4.Name = "cmtsToolId4";
		this.cmtsToolId4.Size = new System.Drawing.Size(221, 22);
		this.cmtsToolId4.Text = "Закрытая кулачка";
		this.cmtsToolId4.Click += new System.EventHandler(cmtsToolId4_Click);
		this.toolStripSeparator9.Name = "toolStripSeparator9";
		this.toolStripSeparator9.Size = new System.Drawing.Size(218, 6);
		this.cmtsDeleteContact.Name = "cmtsDeleteContact";
		this.cmtsDeleteContact.Size = new System.Drawing.Size(221, 22);
		this.cmtsDeleteContact.Text = "Удалить контакт";
		this.cmtsDeleteContact.Click += new System.EventHandler(cmtsDeleteContact_Click);
		this.cmtsContactPrivate.Name = "cmtsContactPrivate";
		this.cmtsContactPrivate.Size = new System.Drawing.Size(221, 22);
		this.cmtsContactPrivate.Text = "Написать в приват";
		this.cmtsContactPrivate.Click += new System.EventHandler(cmtsContactPrivate_Click);
		this.toolStripSeparator19.Name = "toolStripSeparator19";
		this.toolStripSeparator19.Size = new System.Drawing.Size(218, 6);
		this.cmtsContactQuick.Name = "cmtsContactQuick";
		this.cmtsContactQuick.Size = new System.Drawing.Size(221, 22);
		this.cmtsContactQuick.Text = "Быстрые действия...";
		this.cmtsContactQuick.Click += new System.EventHandler(cmtsContactQuick_Click);
		this.statusStrip.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
		this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[14]
		{
			this.dropdownCurrentStat, this.statuslabelActivity, this.statuslabelNumberOfThreads, this.statuslabelLocation, this.dropdownPv, this.statuslabelTied, this.dropdownTravm, this.statuslabelAutoAdv, this.statuslabelClock, this.toolStripStatusLabel1,
			this.dropdownTimers, this.toolStripStatusLabel2, this.dropDownMineStat, this.labelAddress
		});
		this.statusStrip.Location = new System.Drawing.Point(0, 800);
		this.statusStrip.Name = "statusStrip";
		this.statusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
		this.statusStrip.Size = new System.Drawing.Size(1315, 25);
		this.statusStrip.TabIndex = 2;
		this.statusStrip.Text = "statusStrip1";
		this.dropdownCurrentStat.AutoSize = false;
		this.dropdownCurrentStat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
		this.dropdownCurrentStat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[6] { this.menuitemStatEdit, this.menuitemStatItem0, this.menuitemStatItem1, this.menuitemStatItem2, this.menuitemStatItem3, this.menuitemStatItem4 });
		this.dropdownCurrentStat.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.dropdownCurrentStat.Name = "dropdownCurrentStat";
		this.dropdownCurrentStat.Size = new System.Drawing.Size(240, 23);
		this.dropdownCurrentStat.Text = "Загружается статистика...";
		this.dropdownCurrentStat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.menuitemStatEdit.Name = "menuitemStatEdit";
		this.menuitemStatEdit.Size = new System.Drawing.Size(220, 22);
		this.menuitemStatEdit.Text = "Вывод и сброс статистики...";
		this.menuitemStatEdit.Click += new System.EventHandler(menuitemStatEdit_Click);
		this.menuitemStatItem0.Name = "menuitemStatItem0";
		this.menuitemStatItem0.Size = new System.Drawing.Size(220, 22);
		this.menuitemStatItem0.Tag = "0";
		this.menuitemStatItem0.Text = "Использовано трафика:";
		this.menuitemStatItem0.Click += new System.EventHandler(menuitemStatItem4_Click);
		this.menuitemStatItem1.Name = "menuitemStatItem1";
		this.menuitemStatItem1.Size = new System.Drawing.Size(220, 22);
		this.menuitemStatItem1.Tag = "1";
		this.menuitemStatItem1.Text = "Сэкономлено трафика:";
		this.menuitemStatItem1.Click += new System.EventHandler(menuitemStatItem4_Click);
		this.menuitemStatItem2.Name = "menuitemStatItem2";
		this.menuitemStatItem2.Size = new System.Drawing.Size(220, 22);
		this.menuitemStatItem2.Tag = "2";
		this.menuitemStatItem2.Text = "Получено опыта:";
		this.menuitemStatItem2.Click += new System.EventHandler(menuitemStatItem4_Click);
		this.menuitemStatItem3.Name = "menuitemStatItem3";
		this.menuitemStatItem3.Size = new System.Drawing.Size(220, 22);
		this.menuitemStatItem3.Tag = "3";
		this.menuitemStatItem3.Text = "Выбито с ботов:";
		this.menuitemStatItem3.Click += new System.EventHandler(menuitemStatItem4_Click);
		this.menuitemStatItem4.Name = "menuitemStatItem4";
		this.menuitemStatItem4.Size = new System.Drawing.Size(220, 22);
		this.menuitemStatItem4.Tag = "4";
		this.menuitemStatItem4.Text = "Заработано на рыбалке:";
		this.menuitemStatItem4.Click += new System.EventHandler(menuitemStatItem4_Click);
		this.statuslabelActivity.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
		this.statuslabelActivity.Image = (System.Drawing.Image)resources.GetObject("statuslabelActivity.Image");
		this.statuslabelActivity.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
		this.statuslabelActivity.Name = "statuslabelActivity";
		this.statuslabelActivity.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
		this.statuslabelActivity.Size = new System.Drawing.Size(22, 20);
		this.statuslabelActivity.ToolTipText = "Сетевая активность";
		this.statuslabelNumberOfThreads.AutoSize = false;
		this.statuslabelNumberOfThreads.Name = "statuslabelNumberOfThreads";
		this.statuslabelNumberOfThreads.Size = new System.Drawing.Size(14, 20);
		this.statuslabelNumberOfThreads.Text = "0";
		this.statuslabelNumberOfThreads.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.statuslabelLocation.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
		this.statuslabelLocation.Image = (System.Drawing.Image)resources.GetObject("statuslabelLocation.Image");
		this.statuslabelLocation.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.statuslabelLocation.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
		this.statuslabelLocation.Name = "statuslabelLocation";
		this.statuslabelLocation.Size = new System.Drawing.Size(55, 20);
		this.statuslabelLocation.Text = "0-000";
		this.statuslabelLocation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.dropdownPv.Enabled = false;
		this.dropdownPv.Image = (System.Drawing.Image)resources.GetObject("dropdownPv.Image");
		this.dropdownPv.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.dropdownPv.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
		this.dropdownPv.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.dropdownPv.Name = "dropdownPv";
		this.dropdownPv.Size = new System.Drawing.Size(28, 23);
		this.dropdownPv.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.statuslabelTied.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
		this.statuslabelTied.Name = "statuslabelTied";
		this.statuslabelTied.Size = new System.Drawing.Size(88, 20);
		this.statuslabelTied.Text = "Усталость: 0%";
		this.statuslabelTied.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.dropdownTravm.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[1] { this.toolStripMenuItem_0 });
		this.dropdownTravm.Enabled = false;
		this.dropdownTravm.Image = Class39.smethod_7();
		this.dropdownTravm.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.dropdownTravm.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
		this.dropdownTravm.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.dropdownTravm.Name = "dropdownTravm";
		this.dropdownTravm.Size = new System.Drawing.Size(28, 23);
		this.dropdownTravm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.toolStripMenuItem_0.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[9] { this.toolStripMenuItem_1, this.toolStripSeparator13, this.toolStripMenuItem_2, this.toolStripMenuItem_3, this.toolStripMenuItem_4, this.toolStripMenuItem_5, this.toolStripSeparator14, this.toolStripMenuItem_6, this.toolStripMenuItem_7 });
		this.toolStripMenuItem_0.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
		this.toolStripMenuItem_0.Image = Class39.smethod_5();
		this.toolStripMenuItem_0.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
		this.toolStripMenuItem_0.Name = "человек3ToolStripMenuItem";
		this.toolStripMenuItem_0.Size = new System.Drawing.Size(171, 22);
		this.toolStripMenuItem_0.Text = "Человек [3]: 1/-/-/-";
		this.toolStripMenuItem_1.Image = Class39.smethod_28();
		this.toolStripMenuItem_1.Name = "человек3ToolStripMenuItem1";
		this.toolStripMenuItem_1.Size = new System.Drawing.Size(201, 22);
		this.toolStripMenuItem_1.Text = "Человек [3]";
		this.toolStripSeparator13.Name = "toolStripSeparator13";
		this.toolStripSeparator13.Size = new System.Drawing.Size(198, 6);
		this.toolStripMenuItem_2.Image = Class39.smethod_5();
		this.toolStripMenuItem_2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
		this.toolStripMenuItem_2.Name = "лечитьЛегкуюТравмуToolStripMenuItem";
		this.toolStripMenuItem_2.Size = new System.Drawing.Size(201, 22);
		this.toolStripMenuItem_2.Text = "Лечить легкую травму";
		this.toolStripMenuItem_3.Image = Class39.smethod_6();
		this.toolStripMenuItem_3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
		this.toolStripMenuItem_3.Name = "лечитьСреднююТравмуToolStripMenuItem";
		this.toolStripMenuItem_3.Size = new System.Drawing.Size(201, 22);
		this.toolStripMenuItem_3.Text = "Лечить среднюю травму";
		this.toolStripMenuItem_4.Image = Class39.smethod_7();
		this.toolStripMenuItem_4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
		this.toolStripMenuItem_4.Name = "лечитьТяжелуюТравмуToolStripMenuItem";
		this.toolStripMenuItem_4.Size = new System.Drawing.Size(201, 22);
		this.toolStripMenuItem_4.Text = "Лечить тяжелую травму";
		this.toolStripMenuItem_5.Image = Class39.smethod_8();
		this.toolStripMenuItem_5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
		this.toolStripMenuItem_5.Name = "лечитьБоевуюТравмуToolStripMenuItem";
		this.toolStripMenuItem_5.Size = new System.Drawing.Size(201, 22);
		this.toolStripMenuItem_5.Text = "Лечить боевую травму";
		this.toolStripSeparator14.Name = "toolStripSeparator14";
		this.toolStripSeparator14.Size = new System.Drawing.Size(198, 6);
		this.toolStripMenuItem_6.Name = "отправитьРекламуToolStripMenuItem";
		this.toolStripMenuItem_6.Size = new System.Drawing.Size(201, 22);
		this.toolStripMenuItem_6.Text = "Отправить рекламу";
		this.toolStripMenuItem_7.Image = Class39.smethod_18();
		this.toolStripMenuItem_7.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.toolStripMenuItem_7.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
		this.toolStripMenuItem_7.Name = "открытьИнфуToolStripMenuItem";
		this.toolStripMenuItem_7.Size = new System.Drawing.Size(201, 22);
		this.toolStripMenuItem_7.Text = "Открыть инфу";
		this.statuslabelAutoAdv.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
		this.statuslabelAutoAdv.Enabled = false;
		this.statuslabelAutoAdv.Image = Class39.smethod_28();
		this.statuslabelAutoAdv.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.statuslabelAutoAdv.Name = "statuslabelAutoAdv";
		this.statuslabelAutoAdv.Size = new System.Drawing.Size(49, 20);
		this.statuslabelAutoAdv.Text = "0:00";
		this.statuslabelAutoAdv.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.statuslabelAutoAdv.Click += new System.EventHandler(statuslabelAutoAdv_Click);
		this.statuslabelClock.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
		this.statuslabelClock.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
		this.statuslabelClock.Name = "statuslabelClock";
		this.statuslabelClock.Size = new System.Drawing.Size(55, 20);
		this.statuslabelClock.Text = "00:00:00";
		this.statuslabelClock.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
		this.statuslabelClock.ToolTipText = "Точное серверное время";
		this.toolStripStatusLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
		this.toolStripStatusLabel1.Image = (System.Drawing.Image)resources.GetObject("toolStripStatusLabel1.Image");
		this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
		this.toolStripStatusLabel1.Size = new System.Drawing.Size(16, 20);
		this.toolStripStatusLabel1.Text = "Таймеры";
		this.dropdownTimers.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
		this.dropdownTimers.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[1] { this.menuitemNewTimer });
		this.dropdownTimers.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.dropdownTimers.Name = "dropdownTimers";
		this.dropdownTimers.Size = new System.Drawing.Size(148, 23);
		this.dropdownTimers.Text = "Загружаются таймеры...";
		this.dropdownTimers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.menuitemNewTimer.Image = (System.Drawing.Image)resources.GetObject("menuitemNewTimer.Image");
		this.menuitemNewTimer.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
		this.menuitemNewTimer.Name = "menuitemNewTimer";
		this.menuitemNewTimer.Size = new System.Drawing.Size(158, 22);
		this.menuitemNewTimer.Text = "Новый таймер...";
		this.menuitemNewTimer.Click += new System.EventHandler(menuitemNewTimer_Click);
		this.toolStripStatusLabel2.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
		this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
		this.toolStripStatusLabel2.Size = new System.Drawing.Size(4, 20);
		this.dropDownMineStat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
		this.dropDownMineStat.Enabled = false;
		this.dropDownMineStat.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.dropDownMineStat.Name = "dropDownMineStat";
		this.dropDownMineStat.Size = new System.Drawing.Size(54, 23);
		this.dropDownMineStat.Text = "Шахта";
		this.dropDownMineStat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.labelAddress.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
		this.labelAddress.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
		this.labelAddress.Name = "labelAddress";
		this.labelAddress.Size = new System.Drawing.Size(69, 20);
		this.labelAddress.Text = "Загрузка...";
		this.labelAddress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.panelRight.Controls.Add(this.tabControlRight);
		this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
		this.panelRight.Location = new System.Drawing.Point(1065, 24);
		this.panelRight.Name = "panelRight";
		this.panelRight.Size = new System.Drawing.Size(250, 776);
		this.panelRight.TabIndex = 9;
		this.tabControlRight.Controls.Add(this.tabPageContacts);
		this.tabControlRight.Controls.Add(this.tabPageMine);
		this.tabControlRight.Controls.Add(this.tabPageComplects);
		this.tabControlRight.Controls.Add(this.tabPageTextLog);
		this.tabControlRight.Controls.Add(this.tabPageDrinkSets);
		this.tabControlRight.Dock = System.Windows.Forms.DockStyle.Fill;
		this.tabControlRight.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
		this.tabControlRight.Location = new System.Drawing.Point(0, 0);
		this.tabControlRight.Multiline = true;
		this.tabControlRight.Name = "tabControlRight";
		this.tabControlRight.SelectedIndex = 0;
		this.tabControlRight.ShowToolTips = true;
		this.tabControlRight.Size = new System.Drawing.Size(250, 776);
		this.tabControlRight.TabIndex = 0;
		this.tabControlRight.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(tabControlRight_Selecting);
		this.tabPageContacts.Controls.Add(this.treeContacts);
		this.tabPageContacts.Controls.Add(this.collapsibleSplitterContacts);
		this.tabPageContacts.Controls.Add(this.tbContactDetails);
		this.tabPageContacts.Controls.Add(this.toolStrip3);
		this.tabPageContacts.Location = new System.Drawing.Point(4, 40);
		this.tabPageContacts.Name = "tabPageContacts";
		this.tabPageContacts.Padding = new System.Windows.Forms.Padding(3);
		this.tabPageContacts.Size = new System.Drawing.Size(242, 732);
		this.tabPageContacts.TabIndex = 2;
		this.tabPageContacts.Text = "Контакты";
		this.tabPageContacts.UseVisualStyleBackColor = true;
		this.treeContacts.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.treeContacts.CheckBoxes = true;
		this.treeContacts.Cursor = System.Windows.Forms.Cursors.Default;
		this.treeContacts.Dock = System.Windows.Forms.DockStyle.Fill;
		this.treeContacts.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
		this.treeContacts.FullRowSelect = true;
		this.treeContacts.HideSelection = false;
		this.treeContacts.ImageIndex = 0;
		this.treeContacts.ImageList = this.imageList_3;
		this.treeContacts.Location = new System.Drawing.Point(3, 28);
		this.treeContacts.Name = "treeContacts";
		this.treeContacts.SelectedImageIndex = 0;
		this.treeContacts.ShowNodeToolTips = true;
		this.treeContacts.Size = new System.Drawing.Size(236, 572);
		this.treeContacts.TabIndex = 3;
		this.treeContacts.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(treeContacts_AfterCheck);
		this.treeContacts.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(treeContacts_AfterSelect);
		this.treeContacts.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(treeContacts_NodeMouseClick);
		this.treeContacts.DoubleClick += new System.EventHandler(treeContacts_DoubleClick);
		this.imageList_3.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("ImageListContacts.ImageStream");
		this.imageList_3.TransparentColor = System.Drawing.Color.Transparent;
		this.imageList_3.Images.SetKeyName(0, "enemies");
		this.imageList_3.Images.SetKeyName(1, "clan");
		this.imageList_3.Images.SetKeyName(2, "friends");
		this.imageList_3.Images.SetKeyName(3, "doctors");
		this.imageList_3.Images.SetKeyName(4, "gods");
		this.imageList_3.Images.SetKeyName(5, "weapon");
		this.imageList_3.Images.SetKeyName(6, "nego");
		this.imageList_3.Images.SetKeyName(7, "neutral");
		this.imageList_3.Images.SetKeyName(8, "none");
		this.imageList_3.Images.SetKeyName(9, "molch");
		this.imageList_3.Images.SetKeyName(10, "alch");
		this.imageList_3.Images.SetKeyName(11, "rent");
		this.imageList_3.Images.SetKeyName(12, "dealers");
		this.imageList_3.Images.SetKeyName(13, "pv");
		this.imageList_3.Images.SetKeyName(14, "injury0");
		this.imageList_3.Images.SetKeyName(15, "injury1");
		this.imageList_3.Images.SetKeyName(16, "injury2");
		this.imageList_3.Images.SetKeyName(17, "injury3");
		this.imageList_3.Images.SetKeyName(18, "injury4");
		this.collapsibleSplitterContacts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.collapsibleSplitterContacts.BorderStyle3D = System.Windows.Forms.Border3DStyle.Flat;
		this.collapsibleSplitterContacts.ControlToHide = this.tbContactDetails;
		this.collapsibleSplitterContacts.Cursor = System.Windows.Forms.Cursors.HSplit;
		this.collapsibleSplitterContacts.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.collapsibleSplitterContacts.ExpandParentForm = false;
		this.collapsibleSplitterContacts.Location = new System.Drawing.Point(3, 600);
		this.collapsibleSplitterContacts.Name = "collapsibleSplitterContacts";
		this.collapsibleSplitterContacts.Size = new System.Drawing.Size(236, 8);
		this.collapsibleSplitterContacts.TabIndex = 4;
		this.collapsibleSplitterContacts.TabStop = false;
		this.collapsibleSplitterContacts.VisualStyle = ABClient.AppControls.SplitterVisualStyle.XP;
		this.tbContactDetails.BackColor = System.Drawing.Color.AliceBlue;
		this.tbContactDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.tbContactDetails.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.tbContactDetails.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
		this.tbContactDetails.Location = new System.Drawing.Point(3, 608);
		this.tbContactDetails.Multiline = true;
		this.tbContactDetails.Name = "tbContactDetails";
		this.tbContactDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
		this.tbContactDetails.Size = new System.Drawing.Size(236, 121);
		this.tbContactDetails.TabIndex = 2;
		this.tbContactDetails.TextChanged += new System.EventHandler(tbContactDetails_TextChanged);
		this.toolStrip3.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
		this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[5] { this.tsContactTrace, this.toolStripSeparator8, this.tsDeleteContact, this.tsContactPrivate, this.MakeEnemyContactsNeutralButton });
		this.toolStrip3.Location = new System.Drawing.Point(3, 3);
		this.toolStrip3.Name = "toolStrip3";
		this.toolStrip3.Size = new System.Drawing.Size(236, 25);
		this.toolStrip3.TabIndex = 0;
		this.toolStrip3.Text = "toolStrip3";
		this.tsContactTrace.CheckOnClick = true;
		this.tsContactTrace.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
		this.tsContactTrace.Image = Class39.smethod_35();
		this.tsContactTrace.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.tsContactTrace.Name = "tsContactTrace";
		this.tsContactTrace.Size = new System.Drawing.Size(23, 22);
		this.tsContactTrace.Tag = string.Empty;
		this.tsContactTrace.ToolTipText = "Слежение за контактами";
		this.tsContactTrace.Click += new System.EventHandler(tsContactTrace_Click);
		this.toolStripSeparator8.Name = "toolStripSeparator8";
		this.toolStripSeparator8.Size = new System.Drawing.Size(6, 25);
		this.tsDeleteContact.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
		this.tsDeleteContact.Image = (System.Drawing.Image)resources.GetObject("tsDeleteContact.Image");
		this.tsDeleteContact.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.tsDeleteContact.Name = "tsDeleteContact";
		this.tsDeleteContact.Size = new System.Drawing.Size(23, 22);
		this.tsDeleteContact.ToolTipText = "Удалить контакт";
		this.tsDeleteContact.Click += new System.EventHandler(tsDeleteContact_Click);
		this.tsContactPrivate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
		this.tsContactPrivate.Image = Class39.smethod_28();
		this.tsContactPrivate.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.tsContactPrivate.Name = "tsContactPrivate";
		this.tsContactPrivate.Size = new System.Drawing.Size(23, 22);
		this.tsContactPrivate.ToolTipText = "Написать в приват";
		this.tsContactPrivate.Click += new System.EventHandler(tsContactPrivate_Click);
		this.MakeEnemyContactsNeutralButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
		this.MakeEnemyContactsNeutralButton.Image = Class39.smethod_78();
		this.MakeEnemyContactsNeutralButton.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.MakeEnemyContactsNeutralButton.Name = "MakeEnemyContactsNeutralButton";
		this.MakeEnemyContactsNeutralButton.Size = new System.Drawing.Size(23, 22);
		this.MakeEnemyContactsNeutralButton.Click += new System.EventHandler(MakeEnemyContactsNeutralButton_Click);
		this.tabPageMine.Controls.Add(this.button4);
		this.tabPageMine.Controls.Add(this.groupBox1);
		this.tabPageMine.Location = new System.Drawing.Point(4, 40);
		this.tabPageMine.Name = "tabPageMine";
		this.tabPageMine.Padding = new System.Windows.Forms.Padding(3);
		this.tabPageMine.Size = new System.Drawing.Size(242, 732);
		this.tabPageMine.TabIndex = 4;
		this.tabPageMine.Text = "Шахта";
		this.tabPageMine.UseVisualStyleBackColor = true;
		this.button4.Location = new System.Drawing.Point(12, 119);
		this.button4.Name = "button4";
		this.button4.Size = new System.Drawing.Size(171, 23);
		this.button4.TabIndex = 1;
		this.button4.Text = "Сбросить все отметки";
		this.button4.UseVisualStyleBackColor = true;
		this.button4.Click += new System.EventHandler(button4_Click);
		this.groupBox1.Controls.Add(this.button3);
		this.groupBox1.Controls.Add(this.button2);
		this.groupBox1.Controls.Add(this.button1);
		this.groupBox1.Location = new System.Drawing.Point(6, 6);
		this.groupBox1.Name = "groupBox1";
		this.groupBox1.Size = new System.Drawing.Size(183, 107);
		this.groupBox1.TabIndex = 0;
		this.groupBox1.TabStop = false;
		this.groupBox1.Text = "Отметить текущую клетку";
		this.button3.Location = new System.Drawing.Point(6, 78);
		this.button3.Name = "button3";
		this.button3.Size = new System.Drawing.Size(171, 23);
		this.button3.TabIndex = 2;
		this.button3.Text = "Плохая";
		this.button3.UseVisualStyleBackColor = true;
		this.button3.Click += new System.EventHandler(button3_Click);
		this.button2.Location = new System.Drawing.Point(6, 49);
		this.button2.Name = "button2";
		this.button2.Size = new System.Drawing.Size(171, 23);
		this.button2.TabIndex = 1;
		this.button2.Text = "Нейтральная";
		this.button2.UseVisualStyleBackColor = true;
		this.button2.Click += new System.EventHandler(button2_Click);
		this.button1.Location = new System.Drawing.Point(6, 20);
		this.button1.Name = "button1";
		this.button1.Size = new System.Drawing.Size(171, 23);
		this.button1.TabIndex = 0;
		this.button1.Text = "Хорошая";
		this.button1.UseVisualStyleBackColor = true;
		this.button1.Click += new System.EventHandler(button1_Click);
		this.tabPageComplects.Controls.Add(this.checkLocCureOnlyFriends);
		this.tabPageComplects.Controls.Add(this.buttonDelete);
		this.tabPageComplects.Controls.Add(this.checkBoxWear);
		this.tabPageComplects.Controls.Add(this.buttonGet);
		this.tabPageComplects.Controls.Add(this.listBoxComplects);
		this.tabPageComplects.Controls.Add(this.groupBoxCreate);
		this.tabPageComplects.Location = new System.Drawing.Point(4, 40);
		this.tabPageComplects.Name = "tabPageComplects";
		this.tabPageComplects.Size = new System.Drawing.Size(242, 732);
		this.tabPageComplects.TabIndex = 3;
		this.tabPageComplects.Text = "Тех. инфо";
		this.tabPageComplects.UseVisualStyleBackColor = true;
		this.checkLocCureOnlyFriends.AutoSize = true;
		this.checkLocCureOnlyFriends.Location = new System.Drawing.Point(11, 418);
		this.checkLocCureOnlyFriends.Name = "checkLocCureOnlyFriends";
		this.checkLocCureOnlyFriends.Size = new System.Drawing.Size(158, 17);
		this.checkLocCureOnlyFriends.TabIndex = 7;
		this.checkLocCureOnlyFriends.Text = "Лечить только друзей";
		this.checkLocCureOnlyFriends.UseVisualStyleBackColor = true;
		this.checkLocCureOnlyFriends.Visible = false;
		this.buttonDelete.Location = new System.Drawing.Point(11, 378);
		this.buttonDelete.Name = "buttonDelete";
		this.buttonDelete.Size = new System.Drawing.Size(159, 23);
		this.buttonDelete.TabIndex = 6;
		this.buttonDelete.Text = "Удалить комплект";
		this.buttonDelete.UseVisualStyleBackColor = true;
		this.buttonDelete.Visible = false;
		this.buttonDelete.Click += new System.EventHandler(buttonDelete_Click);
		this.checkBoxWear.AutoSize = true;
		this.checkBoxWear.Checked = true;
		this.checkBoxWear.CheckState = System.Windows.Forms.CheckState.Checked;
		this.checkBoxWear.Location = new System.Drawing.Point(35, 355);
		this.checkBoxWear.Name = "checkBoxWear";
		this.checkBoxWear.Size = new System.Drawing.Size(115, 17);
		this.checkBoxWear.TabIndex = 5;
		this.checkBoxWear.Text = "и сразу надеть";
		this.checkBoxWear.UseVisualStyleBackColor = true;
		this.checkBoxWear.Visible = false;
		this.buttonGet.Location = new System.Drawing.Point(11, 326);
		this.buttonGet.Name = "buttonGet";
		this.buttonGet.Size = new System.Drawing.Size(159, 23);
		this.buttonGet.TabIndex = 4;
		this.buttonGet.Text = "Собрать комплект";
		this.buttonGet.UseVisualStyleBackColor = true;
		this.buttonGet.Visible = false;
		this.buttonGet.Click += new System.EventHandler(buttonGet_Click);
		this.listBoxComplects.FormattingEnabled = true;
		this.listBoxComplects.Location = new System.Drawing.Point(11, 117);
		this.listBoxComplects.Name = "listBoxComplects";
		this.listBoxComplects.Size = new System.Drawing.Size(159, 199);
		this.listBoxComplects.TabIndex = 3;
		this.listBoxComplects.Visible = false;
		this.groupBoxCreate.AutoSize = true;
		this.groupBoxCreate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		this.groupBoxCreate.Controls.Add(this.label1);
		this.groupBoxCreate.Controls.Add(this.textBoxComplectName);
		this.groupBoxCreate.Controls.Add(this.buttonCreateStart);
		this.groupBoxCreate.Controls.Add(this.buttonCreateFinish);
		this.groupBoxCreate.Location = new System.Drawing.Point(11, 4);
		this.groupBoxCreate.Name = "groupBoxCreate";
		this.groupBoxCreate.Size = new System.Drawing.Size(159, 107);
		this.groupBoxCreate.TabIndex = 2;
		this.groupBoxCreate.TabStop = false;
		this.groupBoxCreate.Text = "Создание комплекта";
		this.groupBoxCreate.Visible = false;
		this.label1.AutoSize = true;
		this.label1.Location = new System.Drawing.Point(7, 50);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(132, 13);
		this.label1.TabIndex = 3;
		this.label1.Text = "Название комплекта:";
		this.textBoxComplectName.Location = new System.Drawing.Point(6, 66);
		this.textBoxComplectName.Name = "textBoxComplectName";
		this.textBoxComplectName.Size = new System.Drawing.Size(147, 21);
		this.textBoxComplectName.TabIndex = 2;
		this.buttonCreateStart.AutoSize = true;
		this.buttonCreateStart.Location = new System.Drawing.Point(6, 20);
		this.buttonCreateStart.Name = "buttonCreateStart";
		this.buttonCreateStart.Size = new System.Drawing.Size(60, 23);
		this.buttonCreateStart.TabIndex = 0;
		this.buttonCreateStart.Text = "Начать";
		this.buttonCreateStart.UseVisualStyleBackColor = true;
		this.buttonCreateStart.Click += new System.EventHandler(buttonCreateStart_Click);
		this.buttonCreateFinish.AutoSize = true;
		this.buttonCreateFinish.Enabled = false;
		this.buttonCreateFinish.Location = new System.Drawing.Point(72, 20);
		this.buttonCreateFinish.Name = "buttonCreateFinish";
		this.buttonCreateFinish.Size = new System.Drawing.Size(81, 23);
		this.buttonCreateFinish.TabIndex = 1;
		this.buttonCreateFinish.Text = "Завершить";
		this.buttonCreateFinish.UseVisualStyleBackColor = true;
		this.buttonCreateFinish.Click += new System.EventHandler(buttonCreateFinish_Click);
		this.tabPageTextLog.Controls.Add(this.panelTexLog);
		this.tabPageTextLog.Controls.Add(this.toolStrip1);
		this.tabPageTextLog.Location = new System.Drawing.Point(4, 40);
		this.tabPageTextLog.Name = "tabPageTextLog";
		this.tabPageTextLog.Padding = new System.Windows.Forms.Padding(3);
		this.tabPageTextLog.Size = new System.Drawing.Size(242, 732);
		this.tabPageTextLog.TabIndex = 1;
		this.tabPageTextLog.Text = "Тех. лог";
		this.tabPageTextLog.UseVisualStyleBackColor = true;
		this.panelTexLog.Controls.Add(this.textboxTexLog);
		this.panelTexLog.Dock = System.Windows.Forms.DockStyle.Fill;
		this.panelTexLog.Location = new System.Drawing.Point(3, 28);
		this.panelTexLog.Name = "panelTexLog";
		this.panelTexLog.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
		this.panelTexLog.Size = new System.Drawing.Size(236, 701);
		this.panelTexLog.TabIndex = 1;
		this.textboxTexLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.textboxTexLog.Dock = System.Windows.Forms.DockStyle.Fill;
		this.textboxTexLog.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
		this.textboxTexLog.Location = new System.Drawing.Point(0, 3);
		this.textboxTexLog.Multiline = true;
		this.textboxTexLog.Name = "textboxTexLog";
		this.textboxTexLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
		this.textboxTexLog.Size = new System.Drawing.Size(236, 698);
		this.textboxTexLog.TabIndex = 0;
		this.toolStrip1.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
		this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[2] { this.buttonDoTexLog, this.buttonClearTexLog });
		this.toolStrip1.Location = new System.Drawing.Point(3, 3);
		this.toolStrip1.Name = "toolStrip1";
		this.toolStrip1.Size = new System.Drawing.Size(236, 25);
		this.toolStrip1.TabIndex = 0;
		this.toolStrip1.Text = "toolStrip1";
		this.buttonDoTexLog.CheckOnClick = true;
		this.buttonDoTexLog.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
		this.buttonDoTexLog.Image = (System.Drawing.Image)resources.GetObject("buttonDoTexLog.Image");
		this.buttonDoTexLog.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.buttonDoTexLog.Name = "buttonDoTexLog";
		this.buttonDoTexLog.Size = new System.Drawing.Size(23, 22);
		this.buttonDoTexLog.ToolTipText = "Выводить события";
		this.buttonDoTexLog.Click += new System.EventHandler(buttonDoTexLog_Click);
		this.buttonClearTexLog.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
		this.buttonClearTexLog.Image = (System.Drawing.Image)resources.GetObject("buttonClearTexLog.Image");
		this.buttonClearTexLog.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.buttonClearTexLog.Name = "buttonClearTexLog";
		this.buttonClearTexLog.Size = new System.Drawing.Size(23, 22);
		this.buttonClearTexLog.ToolTipText = "Очистить журнал событий";
		this.buttonClearTexLog.Click += new System.EventHandler(buttonClearTexLog_Click);
		this.tabPageDrinkSets.Controls.Add(this.groupBox3);
		this.tabPageDrinkSets.Controls.Add(this.groupBox2);
		this.tabPageDrinkSets.Location = new System.Drawing.Point(4, 40);
		this.tabPageDrinkSets.Name = "tabPageDrinkSets";
		this.tabPageDrinkSets.Padding = new System.Windows.Forms.Padding(3);
		this.tabPageDrinkSets.Size = new System.Drawing.Size(242, 732);
		this.tabPageDrinkSets.TabIndex = 5;
		this.tabPageDrinkSets.Text = "Упивка";
		this.tabPageDrinkSets.UseVisualStyleBackColor = true;
		this.groupBox3.Controls.Add(this.FortBuffsCollect);
		this.groupBox3.Controls.Add(this.FortBuffsSave);
		this.groupBox3.Controls.Add(this.FortBuffsCells);
		this.groupBox3.Location = new System.Drawing.Point(8, 626);
		this.groupBox3.Name = "groupBox3";
		this.groupBox3.Size = new System.Drawing.Size(226, 100);
		this.groupBox3.TabIndex = 1;
		this.groupBox3.TabStop = false;
		this.groupBox3.Text = "Форты";
		this.FortBuffsCollect.Location = new System.Drawing.Point(7, 72);
		this.FortBuffsCollect.Name = "FortBuffsCollect";
		this.FortBuffsCollect.Size = new System.Drawing.Size(214, 23);
		this.FortBuffsCollect.TabIndex = 1028;
		this.FortBuffsCollect.Text = "Собрать бафы";
		this.FortBuffsCollect.UseVisualStyleBackColor = true;
		this.FortBuffsCollect.Click += new System.EventHandler(FortBuffsCollect_Click);
		this.FortBuffsSave.Location = new System.Drawing.Point(7, 47);
		this.FortBuffsSave.Name = "FortBuffsSave";
		this.FortBuffsSave.Size = new System.Drawing.Size(214, 23);
		this.FortBuffsSave.TabIndex = 1027;
		this.FortBuffsSave.Text = "Сохранить";
		this.FortBuffsSave.UseVisualStyleBackColor = true;
		this.FortBuffsSave.Click += new System.EventHandler(FortBuffsSave_Click);
		this.FortBuffsCells.Location = new System.Drawing.Point(7, 20);
		this.FortBuffsCells.Name = "FortBuffsCells";
		this.FortBuffsCells.Size = new System.Drawing.Size(214, 21);
		this.FortBuffsCells.TabIndex = 1027;
		this.groupBox2.Controls.Add(this.DrinkSetSave);
		this.groupBox2.Controls.Add(this.DrinkSetDelete);
		this.groupBox2.Controls.Add(this.DrinkSetUse);
		this.groupBox2.Controls.Add(this.DrinkSetComposition);
		this.groupBox2.Controls.Add(this.DrinkSetsNames);
		this.groupBox2.Controls.Add(this.DrinkSetItemAddButton);
		this.groupBox2.Controls.Add(this.DrinkSetItemUsesAmount);
		this.groupBox2.Controls.Add(this.label2);
		this.groupBox2.Controls.Add(this.DrinkSetItemsMenu);
		this.groupBox2.Controls.Add(this.DrinkSetAddButton);
		this.groupBox2.Controls.Add(this.DrinkSetName);
		this.groupBox2.Location = new System.Drawing.Point(8, 4);
		this.groupBox2.Name = "groupBox2";
		this.groupBox2.Size = new System.Drawing.Size(227, 616);
		this.groupBox2.TabIndex = 0;
		this.groupBox2.TabStop = false;
		this.groupBox2.Text = "Сеты упивки";
		this.DrinkSetSave.Location = new System.Drawing.Point(9, 587);
		this.DrinkSetSave.Name = "DrinkSetSave";
		this.DrinkSetSave.Size = new System.Drawing.Size(131, 23);
		this.DrinkSetSave.TabIndex = 1026;
		this.DrinkSetSave.Text = "Сохранить";
		this.DrinkSetSave.UseVisualStyleBackColor = true;
		this.DrinkSetSave.Click += new System.EventHandler(DrinkSetSave_Click);
		this.DrinkSetDelete.Location = new System.Drawing.Point(146, 587);
		this.DrinkSetDelete.Name = "DrinkSetDelete";
		this.DrinkSetDelete.Size = new System.Drawing.Size(75, 23);
		this.DrinkSetDelete.TabIndex = 1025;
		this.DrinkSetDelete.Text = "Удалить";
		this.DrinkSetDelete.UseVisualStyleBackColor = true;
		this.DrinkSetDelete.Click += new System.EventHandler(DrinkSetDelete_Click);
		this.DrinkSetUse.Location = new System.Drawing.Point(9, 558);
		this.DrinkSetUse.Name = "DrinkSetUse";
		this.DrinkSetUse.Size = new System.Drawing.Size(212, 23);
		this.DrinkSetUse.TabIndex = 1024;
		this.DrinkSetUse.Text = "Использовать";
		this.DrinkSetUse.UseVisualStyleBackColor = true;
		this.DrinkSetUse.Click += new System.EventHandler(DrinkSetUse_Click);
		this.DrinkSetComposition.Location = new System.Drawing.Point(9, 418);
		this.DrinkSetComposition.Multiline = true;
		this.DrinkSetComposition.Name = "DrinkSetComposition";
		this.DrinkSetComposition.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
		this.DrinkSetComposition.Size = new System.Drawing.Size(212, 133);
		this.DrinkSetComposition.TabIndex = 1023;
		this.DrinkSetsNames.FormattingEnabled = true;
		this.DrinkSetsNames.Location = new System.Drawing.Point(9, 161);
		this.DrinkSetsNames.Name = "DrinkSetsNames";
		this.DrinkSetsNames.ScrollAlwaysVisible = true;
		this.DrinkSetsNames.Size = new System.Drawing.Size(212, 251);
		this.DrinkSetsNames.TabIndex = 1022;
		this.DrinkSetsNames.SelectedIndexChanged += new System.EventHandler(DrinkSetsNames_SelectedIndexChanged);
		this.DrinkSetItemAddButton.Location = new System.Drawing.Point(7, 131);
		this.DrinkSetItemAddButton.Name = "DrinkSetItemAddButton";
		this.DrinkSetItemAddButton.Size = new System.Drawing.Size(214, 23);
		this.DrinkSetItemAddButton.TabIndex = 1021;
		this.DrinkSetItemAddButton.Text = "Добавить новый элемент";
		this.DrinkSetItemAddButton.UseVisualStyleBackColor = true;
		this.DrinkSetItemAddButton.Click += new System.EventHandler(DrinkSetItemAddButton_Click);
		this.DrinkSetItemUsesAmount.Location = new System.Drawing.Point(177, 104);
		this.DrinkSetItemUsesAmount.Maximum = new decimal(new int[4] { 99, 0, 0, 0 });
		this.DrinkSetItemUsesAmount.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
		this.DrinkSetItemUsesAmount.Name = "DrinkSetItemUsesAmount";
		this.DrinkSetItemUsesAmount.Size = new System.Drawing.Size(44, 21);
		this.DrinkSetItemUsesAmount.TabIndex = 1020;
		this.DrinkSetItemUsesAmount.Value = new decimal(new int[4] { 1, 0, 0, 0 });
		this.label2.AutoSize = true;
		this.label2.Location = new System.Drawing.Point(6, 106);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(167, 13);
		this.label2.TabIndex = 1019;
		this.label2.Text = "Количество использований:";
		this.DrinkSetItemsMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.DrinkSetItemsMenu.FormattingEnabled = true;
		this.DrinkSetItemsMenu.Items.AddRange(new object[89]
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
			"Филе по-Альвийски",
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
			"Секретное Зелье"
		});
		this.DrinkSetItemsMenu.Location = new System.Drawing.Point(7, 78);
		this.DrinkSetItemsMenu.Name = "DrinkSetItemsMenu";
		this.DrinkSetItemsMenu.Size = new System.Drawing.Size(214, 21);
		this.DrinkSetItemsMenu.TabIndex = 1018;
		this.DrinkSetAddButton.Location = new System.Drawing.Point(7, 49);
		this.DrinkSetAddButton.Name = "DrinkSetAddButton";
		this.DrinkSetAddButton.Size = new System.Drawing.Size(214, 23);
		this.DrinkSetAddButton.TabIndex = 1;
		this.DrinkSetAddButton.Text = "Добавить новый сет";
		this.DrinkSetAddButton.UseVisualStyleBackColor = true;
		this.DrinkSetAddButton.Click += new System.EventHandler(DrinkSetAddButton_Click);
		this.DrinkSetName.Location = new System.Drawing.Point(7, 21);
		this.DrinkSetName.Name = "DrinkSetName";
		this.DrinkSetName.Size = new System.Drawing.Size(214, 21);
		this.DrinkSetName.TabIndex = 0;
		this.tabControlLeft.Controls.Add(this.tabPageGame);
		this.tabControlLeft.Dock = System.Windows.Forms.DockStyle.Fill;
		this.tabControlLeft.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
		this.tabControlLeft.ImageList = this.imageList_1;
		this.tabControlLeft.Location = new System.Drawing.Point(0, 24);
		this.tabControlLeft.Multiline = true;
		this.tabControlLeft.Name = "tabControlLeft";
		this.tabControlLeft.SelectedIndex = 0;
		this.tabControlLeft.Size = new System.Drawing.Size(1057, 776);
		this.tabControlLeft.TabIndex = 10;
		this.tabControlLeft.SelectedIndexChanged += new System.EventHandler(tabControlLeft_SelectedIndexChanged);
		this.tabControlLeft.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(tabControlLeft_MouseDoubleClick);
		this.tabPageGame.Controls.Add(this.panelGame);
		this.tabPageGame.Controls.Add(this.toolbarGame);
		this.tabPageGame.Location = new System.Drawing.Point(4, 23);
		this.tabPageGame.Name = "tabPageGame";
		this.tabPageGame.Padding = new System.Windows.Forms.Padding(3);
		this.tabPageGame.Size = new System.Drawing.Size(1049, 749);
		this.tabPageGame.TabIndex = 0;
		this.tabPageGame.Text = "Ник";
		this.tabPageGame.UseVisualStyleBackColor = true;
		this.panelGame.Controls.Add(this.browserGame);
		this.panelGame.Dock = System.Windows.Forms.DockStyle.Fill;
		this.panelGame.Location = new System.Drawing.Point(3, 31);
		this.panelGame.Name = "panelGame";
		this.panelGame.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
		this.panelGame.Size = new System.Drawing.Size(1043, 715);
		this.panelGame.TabIndex = 1;
		this.browserGame.Dock = System.Windows.Forms.DockStyle.Fill;
		this.browserGame.Location = new System.Drawing.Point(0, 3);
		this.browserGame.MinimumSize = new System.Drawing.Size(20, 20);
		this.browserGame.Name = "browserGame";
		this.browserGame.Size = new System.Drawing.Size(1043, 712);
		this.browserGame.TabIndex = 0;
		this.browserGame.WebBrowserShortcutsEnabled = false;
		this.toolbarGame.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
		this.toolbarGame.Items.AddRange(new System.Windows.Forms.ToolStripItem[37]
		{
			this.buttonAutoboi, this.toolStripSeparator2, this.buttonFury, this.buttonAutoRefresh, this.buttonWaitOpen, this.buttonPerenap, this.toolStripSeparator4, this.buttonWalkers, this.buttonOpenNevid, this.buttonSelfNevid,
			this.buttonFriendsInvis, this.buttonLocationCure, this.buttonAutoAttack, this.toolStripSeparator23, this.buttonNavigator, this.teleportDropDown, this.toolStripSeparator15, this.buttonSilence, this.buttonDisableSysMsg, this.buttonAutoAnswer,
			this.buttonDrink, this.buttonAutoAdv, this.toolStripSeparator6, this.buttonAutoFish, this.buttonAutoSkin, this.buttonAutoMine, this.CraftButton, this.CraftAllButton, this.autoForestButton, this.toolStripSeparator22,
			this.buttonAutoDNV, this.toolStripSeparator10, this.ClanKaznaViewButton, this.toolStripSeparator5, this.buttonGameLogOn, this.toolStripSeparator1, this.buttonGameScreen
		});
		this.toolbarGame.Location = new System.Drawing.Point(3, 3);
		this.toolbarGame.Name = "toolbarGame";
		this.toolbarGame.Size = new System.Drawing.Size(1043, 28);
		this.toolbarGame.TabIndex = 0;
		this.toolbarGame.Text = "toolStrip1";
		this.buttonAutoboi.AutoSize = false;
		this.buttonAutoboi.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
		this.buttonAutoboi.Image = (System.Drawing.Image)resources.GetObject("buttonAutoboi.Image");
		this.buttonAutoboi.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.buttonAutoboi.Name = "buttonAutoboi";
		this.buttonAutoboi.Size = new System.Drawing.Size(150, 22);
		this.buttonAutoboi.Text = "Останов лечения (0:00:00)";
		this.buttonAutoboi.Click += new System.EventHandler(buttonAutoboi_Click);
		this.toolStripSeparator2.Name = "toolStripSeparator2";
		this.toolStripSeparator2.Size = new System.Drawing.Size(6, 28);
		this.buttonFury.CheckOnClick = true;
		this.buttonFury.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
		this.buttonFury.Image = Class39.smethod_17();
		this.buttonFury.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
		this.buttonFury.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.buttonFury.Name = "buttonFury";
		this.buttonFury.Size = new System.Drawing.Size(23, 25);
		this.buttonFury.ToolTipText = "Снежок или ярость (первый удар на осаде)";
		this.buttonFury.Click += new System.EventHandler(buttonFury_Click);
		this.buttonAutoRefresh.CheckOnClick = true;
		this.buttonAutoRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
		this.buttonAutoRefresh.Image = Class39.smethod_21();
		this.buttonAutoRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.buttonAutoRefresh.Name = "buttonAutoRefresh";
		this.buttonAutoRefresh.Size = new System.Drawing.Size(23, 25);
		this.buttonAutoRefresh.ToolTipText = "Автообновление боя при ожидании хода противника";
		this.buttonAutoRefresh.Click += new System.EventHandler(buttonAutoRefresh_Click);
		this.buttonWaitOpen.CheckOnClick = true;
		this.buttonWaitOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
		this.buttonWaitOpen.Image = Class39.smethod_34();
		this.buttonWaitOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.buttonWaitOpen.Name = "buttonWaitOpen";
		this.buttonWaitOpen.Size = new System.Drawing.Size(23, 25);
		this.buttonWaitOpen.Text = "toolStripButton2";
		this.buttonWaitOpen.ToolTipText = "Ожидание окончания открытого боя";
		this.buttonWaitOpen.Click += new System.EventHandler(buttonWaitOpen_Click);
		this.buttonPerenap.CheckOnClick = true;
		this.buttonPerenap.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
		this.buttonPerenap.Image = Class39.smethod_26();
		this.buttonPerenap.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.buttonPerenap.Name = "buttonPerenap";
		this.buttonPerenap.Size = new System.Drawing.Size(23, 25);
		this.buttonPerenap.ToolTipText = "Перенападение/автоприманка";
		this.buttonPerenap.Click += new System.EventHandler(buttonPerenap_Click);
		this.toolStripSeparator4.Name = "toolStripSeparator4";
		this.toolStripSeparator4.Size = new System.Drawing.Size(6, 28);
		this.buttonWalkers.CheckOnClick = true;
		this.buttonWalkers.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
		this.buttonWalkers.Image = Class39.smethod_35();
		this.buttonWalkers.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.buttonWalkers.Name = "buttonWalkers";
		this.buttonWalkers.Size = new System.Drawing.Size(23, 25);
		this.buttonWalkers.ToolTipText = "Слежение за составом локации";
		this.buttonWalkers.Click += new System.EventHandler(buttonWalkers_Click);
		this.buttonOpenNevid.CheckOnClick = true;
		this.buttonOpenNevid.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
		this.buttonOpenNevid.Image = Class39.smethod_25();
		this.buttonOpenNevid.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.buttonOpenNevid.Name = "buttonOpenNevid";
		this.buttonOpenNevid.Size = new System.Drawing.Size(23, 25);
		this.buttonOpenNevid.Text = "toolStripButton2";
		this.buttonOpenNevid.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.buttonOpenNevid.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
		this.buttonOpenNevid.ToolTipText = "Автоматическое развеивание невидимки";
		this.buttonOpenNevid.Click += new System.EventHandler(buttonOpenNevid_Click);
		this.buttonSelfNevid.CheckOnClick = true;
		this.buttonSelfNevid.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
		this.buttonSelfNevid.Image = Class39.smethod_31();
		this.buttonSelfNevid.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.buttonSelfNevid.Name = "buttonSelfNevid";
		this.buttonSelfNevid.Size = new System.Drawing.Size(23, 25);
		this.buttonSelfNevid.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.buttonSelfNevid.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
		this.buttonSelfNevid.ToolTipText = "Автоматическое наложение невида на себя";
		this.buttonSelfNevid.Click += new System.EventHandler(buttonSelfNevid_Click);
		this.buttonFriendsInvis.CheckOnClick = true;
		this.buttonFriendsInvis.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
		this.buttonFriendsInvis.Image = Class39.smethod_76();
		this.buttonFriendsInvis.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.buttonFriendsInvis.Name = "buttonFriendsInvis";
		this.buttonFriendsInvis.Size = new System.Drawing.Size(23, 25);
		this.buttonFriendsInvis.ToolTipText = "Автоматическое наложение тумана на друзей";
		this.buttonFriendsInvis.Click += new System.EventHandler(buttonFriendsInvis_Click);
		this.buttonLocationCure.CheckOnClick = true;
		this.buttonLocationCure.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
		this.buttonLocationCure.Image = Class39.smethod_3();
		this.buttonLocationCure.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.buttonLocationCure.Name = "buttonLocationCure";
		this.buttonLocationCure.Size = new System.Drawing.Size(23, 25);
		this.buttonLocationCure.Text = "Автолечение на клетке";
		this.buttonLocationCure.Click += new System.EventHandler(buttonLocationCure_Click);
		this.buttonAutoAttack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
		this.buttonAutoAttack.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[7] { this.miAutoAttack0, this.miAutoAttack1, this.miAutoAttack2, this.miAutoAttack3, this.miAutoAttack4, this.miAutoAttack5, this.miAutoAttack6 });
		this.buttonAutoAttack.Image = Class39.smethod_56();
		this.buttonAutoAttack.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
		this.buttonAutoAttack.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.buttonAutoAttack.Name = "buttonAutoAttack";
		this.buttonAutoAttack.Size = new System.Drawing.Size(58, 25);
		this.buttonAutoAttack.Text = "Автонападение отключено";
		this.miAutoAttack0.Image = Class39.smethod_56();
		this.miAutoAttack0.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
		this.miAutoAttack0.Name = "miAutoAttack0";
		this.miAutoAttack0.Size = new System.Drawing.Size(283, 28);
		this.miAutoAttack0.Text = "Автонападение отключено";
		this.miAutoAttack0.ToolTipText = "Автонападение отключено";
		this.miAutoAttack0.Click += new System.EventHandler(miAutoAttack6_Click);
		this.miAutoAttack1.Image = Class39.smethod_66();
		this.miAutoAttack1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
		this.miAutoAttack1.Name = "miAutoAttack1";
		this.miAutoAttack1.Size = new System.Drawing.Size(283, 28);
		this.miAutoAttack1.Tag = "1";
		this.miAutoAttack1.Text = "Использовать боевые";
		this.miAutoAttack1.ToolTipText = "Использовать боевые";
		this.miAutoAttack1.Click += new System.EventHandler(miAutoAttack6_Click);
		this.miAutoAttack2.Image = Class39.smethod_67();
		this.miAutoAttack2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
		this.miAutoAttack2.Name = "miAutoAttack2";
		this.miAutoAttack2.Size = new System.Drawing.Size(283, 28);
		this.miAutoAttack2.Tag = "2";
		this.miAutoAttack2.Text = "Использовать закрытые боевые";
		this.miAutoAttack2.ToolTipText = "Использовать закрытые боевые";
		this.miAutoAttack2.Click += new System.EventHandler(miAutoAttack6_Click);
		this.miAutoAttack3.Image = Class39.smethod_64();
		this.miAutoAttack3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
		this.miAutoAttack3.Name = "miAutoAttack3";
		this.miAutoAttack3.Size = new System.Drawing.Size(283, 28);
		this.miAutoAttack3.Tag = "3";
		this.miAutoAttack3.Text = "Использовать кулачки";
		this.miAutoAttack3.ToolTipText = "Использовать кулачки";
		this.miAutoAttack3.Click += new System.EventHandler(miAutoAttack6_Click);
		this.miAutoAttack4.Image = Class39.smethod_65();
		this.miAutoAttack4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
		this.miAutoAttack4.Name = "miAutoAttack4";
		this.miAutoAttack4.Size = new System.Drawing.Size(283, 28);
		this.miAutoAttack4.Tag = "4";
		this.miAutoAttack4.Text = "Использовать закрытые кулачки";
		this.miAutoAttack4.ToolTipText = "Использовать закрытые кулачки";
		this.miAutoAttack4.Click += new System.EventHandler(miAutoAttack6_Click);
		this.miAutoAttack5.Image = Class39.smethod_59();
		this.miAutoAttack5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
		this.miAutoAttack5.Name = "miAutoAttack5";
		this.miAutoAttack5.Size = new System.Drawing.Size(283, 28);
		this.miAutoAttack5.Tag = "5";
		this.miAutoAttack5.Text = "Использовать закрытые нападалки";
		this.miAutoAttack5.ToolTipText = "Использовать закрытые нападалки";
		this.miAutoAttack5.Click += new System.EventHandler(miAutoAttack6_Click);
		this.miAutoAttack6.Image = Class39.smethod_68();
		this.miAutoAttack6.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
		this.miAutoAttack6.Name = "miAutoAttack6";
		this.miAutoAttack6.Size = new System.Drawing.Size(283, 28);
		this.miAutoAttack6.Tag = "6";
		this.miAutoAttack6.Text = "Использовать портал";
		this.miAutoAttack6.ToolTipText = "Использовать портал";
		this.miAutoAttack6.Click += new System.EventHandler(miAutoAttack6_Click);
		this.toolStripSeparator23.Name = "toolStripSeparator23";
		this.toolStripSeparator23.Size = new System.Drawing.Size(6, 28);
		this.buttonNavigator.Image = Class39.smethod_24();
		this.buttonNavigator.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.buttonNavigator.Name = "buttonNavigator";
		this.buttonNavigator.Size = new System.Drawing.Size(81, 25);
		this.buttonNavigator.Text = "Навигатор";
		this.buttonNavigator.ToolTipText = "Навигатор по природе";
		this.buttonNavigator.Click += new System.EventHandler(buttonNavigator_Click);
		this.teleportDropDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
		this.teleportDropDown.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[12]
		{
			this.tpLocation1, this.tpLocation2, this.tpLocation3, this.tpLocation4, this.tpLocation5, this.tpLocation6, this.tpLocation7, this.tpLocation8, this.tpLocation9, this.tpLocation10,
			this.tpLocation11, this.tpLocation12
		});
		this.teleportDropDown.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.teleportDropDown.Name = "teleportDropDown";
		this.teleportDropDown.Size = new System.Drawing.Size(33, 25);
		this.teleportDropDown.Text = "ТП";
		this.teleportDropDown.ToolTipText = "Телепортация в определённую локацию";
		this.tpLocation1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
		this.tpLocation1.Name = "tpLocation1";
		this.tpLocation1.Size = new System.Drawing.Size(253, 22);
		this.tpLocation1.Tag = "1";
		this.tpLocation1.Text = "Город Форпост";
		this.tpLocation1.Click += new System.EventHandler(tpLocation12_Click);
		this.tpLocation2.Name = "tpLocation2";
		this.tpLocation2.Size = new System.Drawing.Size(253, 22);
		this.tpLocation2.Tag = "2";
		this.tpLocation2.Text = "Город Октал";
		this.tpLocation2.Click += new System.EventHandler(tpLocation12_Click);
		this.tpLocation3.Name = "tpLocation3";
		this.tpLocation3.Size = new System.Drawing.Size(253, 22);
		this.tpLocation3.Tag = "3";
		this.tpLocation3.Text = "Деревня Подгорная";
		this.tpLocation3.Click += new System.EventHandler(tpLocation12_Click);
		this.tpLocation4.Name = "tpLocation4";
		this.tpLocation4.Size = new System.Drawing.Size(253, 22);
		this.tpLocation4.Tag = "4";
		this.tpLocation4.Text = "Окрестность Фейдана, Телепорт";
		this.tpLocation4.Click += new System.EventHandler(tpLocation12_Click);
		this.tpLocation5.Name = "tpLocation5";
		this.tpLocation5.Size = new System.Drawing.Size(253, 22);
		this.tpLocation5.Tag = "5";
		this.tpLocation5.Text = "Окрестность Октала, Телепорт";
		this.tpLocation5.Click += new System.EventHandler(tpLocation12_Click);
		this.tpLocation6.Name = "tpLocation6";
		this.tpLocation6.Size = new System.Drawing.Size(253, 22);
		this.tpLocation6.Tag = "6";
		this.tpLocation6.Text = "Окрестности Эринграда, Телепорт";
		this.tpLocation6.Click += new System.EventHandler(tpLocation12_Click);
		this.tpLocation7.Name = "tpLocation7";
		this.tpLocation7.Size = new System.Drawing.Size(253, 22);
		this.tpLocation7.Tag = "7";
		this.tpLocation7.Text = "Окрестность Форпоста, Телепорт";
		this.tpLocation7.Click += new System.EventHandler(tpLocation12_Click);
		this.tpLocation8.Name = "tpLocation8";
		this.tpLocation8.Size = new System.Drawing.Size(253, 22);
		this.tpLocation8.Tag = "8";
		this.tpLocation8.Text = "Пустыня Самум-Бейт, Телепорт";
		this.tpLocation8.Click += new System.EventHandler(tpLocation12_Click);
		this.tpLocation9.Name = "tpLocation9";
		this.tpLocation9.Size = new System.Drawing.Size(253, 22);
		this.tpLocation9.Tag = "9";
		this.tpLocation9.Text = "Северский Тракт, Телепорт";
		this.tpLocation9.Click += new System.EventHandler(tpLocation12_Click);
		this.tpLocation10.Name = "tpLocation10";
		this.tpLocation10.Size = new System.Drawing.Size(253, 22);
		this.tpLocation10.Tag = "10";
		this.tpLocation10.Text = "Восточные Леса, Телепорт";
		this.tpLocation10.Click += new System.EventHandler(tpLocation12_Click);
		this.tpLocation11.Name = "tpLocation11";
		this.tpLocation11.Size = new System.Drawing.Size(253, 22);
		this.tpLocation11.Tag = "11";
		this.tpLocation11.Text = "Окрестности Кенджии, Телепорт";
		this.tpLocation11.Click += new System.EventHandler(tpLocation12_Click);
		this.tpLocation12.Name = "tpLocation12";
		this.tpLocation12.Size = new System.Drawing.Size(253, 22);
		this.tpLocation12.Tag = "12";
		this.tpLocation12.Text = "Ущелье Эль-Тэр, Телепорт";
		this.tpLocation12.Click += new System.EventHandler(tpLocation12_Click);
		this.toolStripSeparator15.Name = "toolStripSeparator15";
		this.toolStripSeparator15.Size = new System.Drawing.Size(6, 28);
		this.buttonSilence.CheckOnClick = true;
		this.buttonSilence.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
		this.buttonSilence.Image = Class39.smethod_32();
		this.buttonSilence.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.buttonSilence.Name = "buttonSilence";
		this.buttonSilence.Size = new System.Drawing.Size(23, 25);
		this.buttonSilence.ToolTipText = "Запрет звуков в клиенте";
		this.buttonSilence.Click += new System.EventHandler(buttonSilence_Click);
		this.buttonDisableSysMsg.CheckOnClick = true;
		this.buttonDisableSysMsg.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
		this.buttonDisableSysMsg.Image = Class39.smethod_52();
		this.buttonDisableSysMsg.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.buttonDisableSysMsg.Name = "buttonDisableSysMsg";
		this.buttonDisableSysMsg.Size = new System.Drawing.Size(23, 25);
		this.buttonDisableSysMsg.Text = "toolStripButton2";
		this.buttonDisableSysMsg.ToolTipText = "Запрет системных сообщений клиента";
		this.buttonDisableSysMsg.Click += new System.EventHandler(buttonDisableSysMsg_Click);
		this.buttonAutoAnswer.CheckOnClick = true;
		this.buttonAutoAnswer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
		this.buttonAutoAnswer.Image = Class39.smethod_9();
		this.buttonAutoAnswer.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.buttonAutoAnswer.Name = "buttonAutoAnswer";
		this.buttonAutoAnswer.Size = new System.Drawing.Size(23, 25);
		this.buttonAutoAnswer.ToolTipText = "Автоответчик";
		this.buttonAutoAnswer.Click += new System.EventHandler(buttonAutoAnswer_Click);
		this.buttonDrink.CheckOnClick = true;
		this.buttonDrink.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
		this.buttonDrink.Image = (System.Drawing.Image)resources.GetObject("buttonDrink.Image");
		this.buttonDrink.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.buttonDrink.Name = "buttonDrink";
		this.buttonDrink.Size = new System.Drawing.Size(23, 25);
		this.buttonDrink.ToolTipText = "Автопитье до нуля усталости";
		this.buttonDrink.Click += new System.EventHandler(buttonDrink_Click);
		this.buttonAutoAdv.CheckOnClick = true;
		this.buttonAutoAdv.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
		this.buttonAutoAdv.Image = Class39.smethod_28();
		this.buttonAutoAdv.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.buttonAutoAdv.Name = "buttonAutoAdv";
		this.buttonAutoAdv.Size = new System.Drawing.Size(23, 25);
		this.buttonAutoAdv.ToolTipText = "Автореклама в чат";
		this.buttonAutoAdv.Click += new System.EventHandler(buttonAutoAdv_Click);
		this.toolStripSeparator6.Name = "toolStripSeparator6";
		this.toolStripSeparator6.Size = new System.Drawing.Size(6, 28);
		this.buttonAutoFish.CheckOnClick = true;
		this.buttonAutoFish.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
		this.buttonAutoFish.Image = (System.Drawing.Image)resources.GetObject("buttonAutoFish.Image");
		this.buttonAutoFish.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.buttonAutoFish.Name = "buttonAutoFish";
		this.buttonAutoFish.Size = new System.Drawing.Size(23, 25);
		this.buttonAutoFish.Text = "Авторыбалка";
		this.buttonAutoFish.ToolTipText = "Авторыбалка";
		this.buttonAutoFish.Click += new System.EventHandler(buttonAutoFish_Click);
		this.buttonAutoSkin.CheckOnClick = true;
		this.buttonAutoSkin.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
		this.buttonAutoSkin.Image = (System.Drawing.Image)resources.GetObject("buttonAutoSkin.Image");
		this.buttonAutoSkin.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.buttonAutoSkin.Name = "buttonAutoSkin";
		this.buttonAutoSkin.Size = new System.Drawing.Size(23, 25);
		this.buttonAutoSkin.Text = "Авторазделка";
		this.buttonAutoSkin.ToolTipText = "Авторазделка";
		this.buttonAutoSkin.Click += new System.EventHandler(buttonAutoSkin_Click);
		this.buttonAutoMine.CheckOnClick = true;
		this.buttonAutoMine.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
		this.buttonAutoMine.Image = (System.Drawing.Image)resources.GetObject("buttonAutoMine.Image");
		this.buttonAutoMine.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.buttonAutoMine.Name = "buttonAutoMine";
		this.buttonAutoMine.Size = new System.Drawing.Size(23, 25);
		this.buttonAutoMine.Text = "toolStripButton2";
		this.buttonAutoMine.ToolTipText = "Автошахта";
		this.buttonAutoMine.Click += new System.EventHandler(buttonAutoMine_Click);
		this.CraftButton.CheckOnClick = true;
		this.CraftButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
		this.CraftButton.Image = (System.Drawing.Image)resources.GetObject("CraftButton.Image");
		this.CraftButton.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.CraftButton.Name = "CraftButton";
		this.CraftButton.Size = new System.Drawing.Size(44, 25);
		this.CraftButton.Text = "Крафт";
		this.CraftButton.ToolTipText = "Профы";
		this.CraftButton.Click += new System.EventHandler(CraftButton_Click);
		this.CraftAllButton.CheckOnClick = true;
		this.CraftAllButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
		this.CraftAllButton.Image = (System.Drawing.Image)resources.GetObject("CraftAllButton.Image");
		this.CraftAllButton.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.CraftAllButton.Name = "CraftAllButton";
		this.CraftAllButton.Size = new System.Drawing.Size(23, 25);
		this.CraftAllButton.ToolTipText = "Создавать все доступные продукты";
		this.CraftAllButton.Click += new System.EventHandler(CraftAllButton_Click);
		this.autoForestButton.CheckOnClick = true;
		this.autoForestButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
		this.autoForestButton.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.autoForestButton.Name = "autoForestButton";
		this.autoForestButton.Size = new System.Drawing.Size(29, 25);
		this.autoForestButton.Text = "Лес";
		this.autoForestButton.ToolTipText = "Авто Лес";
		this.toolStripSeparator22.Name = "toolStripSeparator22";
		this.toolStripSeparator22.Size = new System.Drawing.Size(6, 28);
		this.buttonAutoDNV.CheckOnClick = true;
		this.buttonAutoDNV.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
		this.buttonAutoDNV.Image = (System.Drawing.Image)resources.GetObject("buttonAutoDNV.Image");
		this.buttonAutoDNV.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.buttonAutoDNV.Name = "buttonAutoDNV";
		this.buttonAutoDNV.Size = new System.Drawing.Size(23, 25);
		this.buttonAutoDNV.Text = "Биржа DNV";
		this.buttonAutoDNV.Click += new System.EventHandler(buttonAutoDNV_Click);
		this.toolStripSeparator10.Name = "toolStripSeparator10";
		this.toolStripSeparator10.Size = new System.Drawing.Size(6, 28);
		this.ClanKaznaViewButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
		this.ClanKaznaViewButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[3] { this.ClanKaznaViewAll, this.ClanKaznaViewRAR, this.ClanKaznaViewART });
		this.ClanKaznaViewButton.Image = (System.Drawing.Image)resources.GetObject("ClanKaznaViewButton.Image");
		this.ClanKaznaViewButton.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.ClanKaznaViewButton.Name = "ClanKaznaViewButton";
		this.ClanKaznaViewButton.Size = new System.Drawing.Size(37, 25);
		this.ClanKaznaViewButton.Text = "Все";
		this.ClanKaznaViewButton.ToolTipText = "Режим отображения вещей в клан-казне";
		this.ClanKaznaViewAll.Name = "ClanKaznaViewAll";
		this.ClanKaznaViewAll.Size = new System.Drawing.Size(101, 22);
		this.ClanKaznaViewAll.Tag = "0";
		this.ClanKaznaViewAll.Text = "Все";
		this.ClanKaznaViewAll.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
		this.ClanKaznaViewAll.ToolTipText = "Отображать все вещи";
		this.ClanKaznaViewAll.Click += new System.EventHandler(ClanKaznaViewART_Click);
		this.ClanKaznaViewRAR.Name = "ClanKaznaViewRAR";
		this.ClanKaznaViewRAR.Size = new System.Drawing.Size(101, 22);
		this.ClanKaznaViewRAR.Tag = "1";
		this.ClanKaznaViewRAR.Text = "Рары";
		this.ClanKaznaViewRAR.ToolTipText = "Отображать только раритеты";
		this.ClanKaznaViewRAR.Click += new System.EventHandler(ClanKaznaViewART_Click);
		this.ClanKaznaViewART.Name = "ClanKaznaViewART";
		this.ClanKaznaViewART.Size = new System.Drawing.Size(101, 22);
		this.ClanKaznaViewART.Tag = "2";
		this.ClanKaznaViewART.Text = "Арты";
		this.ClanKaznaViewART.ToolTipText = "Отображать только артефакты";
		this.ClanKaznaViewART.Click += new System.EventHandler(ClanKaznaViewART_Click);
		this.toolStripSeparator5.Name = "toolStripSeparator5";
		this.toolStripSeparator5.Size = new System.Drawing.Size(6, 28);
		this.buttonGameLogOn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
		this.buttonGameLogOn.Image = Class39.smethod_30();
		this.buttonGameLogOn.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.buttonGameLogOn.Name = "buttonGameLogOn";
		this.buttonGameLogOn.Size = new System.Drawing.Size(23, 25);
		this.buttonGameLogOn.Text = "Перезаход";
		this.buttonGameLogOn.ToolTipText = "Перезаход в игру";
		this.buttonGameLogOn.Click += new System.EventHandler(buttonGameLogOn_Click);
		this.toolStripSeparator1.Name = "toolStripSeparator1";
		this.toolStripSeparator1.Size = new System.Drawing.Size(6, 28);
		this.buttonGameScreen.Image = Class39.smethod_11();
		this.buttonGameScreen.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.buttonGameScreen.Name = "buttonGameScreen";
		this.buttonGameScreen.Size = new System.Drawing.Size(23, 25);
		this.buttonGameScreen.ToolTipText = "Снимок игрового экрана";
		this.buttonGameScreen.Click += new System.EventHandler(buttonGameScreen_Click);
		this.imageList_1.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("ic6x16.ImageStream");
		this.imageList_1.TransparentColor = System.Drawing.Color.Transparent;
		this.imageList_1.Images.SetKeyName(0, "16x6-info.gif");
		this.imageList_1.Images.SetKeyName(1, "16x6-notepad.png");
		this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
		this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.toolStripButton1.Name = "toolStripButton1";
		this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
		this.toolStripButton1.Text = "toolStripButton1";
		this.toolStripMenuItem2.Name = "toolStripMenuItem2";
		this.toolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
		this.toolStripMenuItem2.Text = "123";
		this.menuStrip.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
		this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[6] { this.menuitemGame, this.menuitemTabs, this.aPIToolStripMenuItem, this.menuitemTools, this.menuitemCommands, this.menuitemSystem });
		this.menuStrip.Location = new System.Drawing.Point(0, 0);
		this.menuStrip.Name = "menuStrip";
		this.menuStrip.Size = new System.Drawing.Size(1315, 24);
		this.menuStrip.TabIndex = 11;
		this.menuStrip.Text = "menuStrip1";
		this.menuitemGame.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[5] { this.menuitemSettingsAb, this.menuitemSettingsGeneral, this.toolStripSeparator17, this.menuitemGameLogOn, this.menuitemGameExit });
		this.menuitemGame.Name = "menuitemGame";
		this.menuitemGame.Size = new System.Drawing.Size(43, 20);
		this.menuitemGame.Text = "Игра";
		this.menuitemSettingsAb.Image = (System.Drawing.Image)resources.GetObject("menuitemSettingsAb.Image");
		this.menuitemSettingsAb.Name = "menuitemSettingsAb";
		this.menuitemSettingsAb.Size = new System.Drawing.Size(173, 22);
		this.menuitemSettingsAb.Text = "Настройки автобоя";
		this.menuitemSettingsAb.Click += new System.EventHandler(menuitemSettingsAb_Click);
		this.menuitemSettingsGeneral.Image = (System.Drawing.Image)resources.GetObject("menuitemSettingsGeneral.Image");
		this.menuitemSettingsGeneral.Name = "menuitemSettingsGeneral";
		this.menuitemSettingsGeneral.Size = new System.Drawing.Size(173, 22);
		this.menuitemSettingsGeneral.Text = "Настройки клиента";
		this.menuitemSettingsGeneral.Click += new System.EventHandler(menuitemSettingsGeneral_Click);
		this.toolStripSeparator17.Name = "toolStripSeparator17";
		this.toolStripSeparator17.Size = new System.Drawing.Size(170, 6);
		this.menuitemGameLogOn.Image = Class39.smethod_30();
		this.menuitemGameLogOn.Name = "menuitemGameLogOn";
		this.menuitemGameLogOn.Size = new System.Drawing.Size(173, 22);
		this.menuitemGameLogOn.Text = "Перезаход в игру";
		this.menuitemGameLogOn.Click += new System.EventHandler(menuitemGameLogOn_Click);
		this.menuitemGameExit.Image = (System.Drawing.Image)resources.GetObject("menuitemGameExit.Image");
		this.menuitemGameExit.Name = "menuitemGameExit";
		this.menuitemGameExit.Size = new System.Drawing.Size(173, 22);
		this.menuitemGameExit.Text = "Выход из игры";
		this.menuitemGameExit.Click += new System.EventHandler(menuitemGameExit_Click);
		this.menuitemTabs.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[5] { this.menuitemOpenTab, this.menuitemOpenForum, this.menuitemOpenTodayChat, this.menuitemOpenNotepad, this.toolStripSeparator16 });
		this.menuitemTabs.Name = "menuitemTabs";
		this.menuitemTabs.Size = new System.Drawing.Size(68, 20);
		this.menuitemTabs.Text = "Закладки";
		this.menuitemOpenTab.Name = "menuitemOpenTab";
		this.menuitemOpenTab.ShortcutKeys = System.Windows.Forms.Keys.N | System.Windows.Forms.Keys.Control;
		this.menuitemOpenTab.Size = new System.Drawing.Size(211, 22);
		this.menuitemOpenTab.Text = "Открыть новую";
		this.menuitemOpenTab.Click += new System.EventHandler(menuitemOpenTab_Click);
		this.menuitemOpenForum.Name = "menuitemOpenForum";
		this.menuitemOpenForum.Size = new System.Drawing.Size(211, 22);
		this.menuitemOpenForum.Text = "Открыть форум";
		this.menuitemOpenForum.Click += new System.EventHandler(menuitemOpenForum_Click);
		this.menuitemOpenTodayChat.Name = "menuitemOpenTodayChat";
		this.menuitemOpenTodayChat.Size = new System.Drawing.Size(211, 22);
		this.menuitemOpenTodayChat.Text = "Открыть сегодняшний чат";
		this.menuitemOpenTodayChat.Click += new System.EventHandler(menuitemOpenTodayChat_Click);
		this.menuitemOpenNotepad.Name = "menuitemOpenNotepad";
		this.menuitemOpenNotepad.Size = new System.Drawing.Size(211, 22);
		this.menuitemOpenNotepad.Text = "Открыть блокнот";
		this.menuitemOpenNotepad.Click += new System.EventHandler(menuitemOpenNotepad_Click);
		this.toolStripSeparator16.Name = "toolStripSeparator16";
		this.toolStripSeparator16.Size = new System.Drawing.Size(208, 6);
		this.aPIToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[2] { this.ForpostBuildingsToolStripMenuItem, this.CityHallMenuItem });
		this.aPIToolStripMenuItem.Name = "aPIToolStripMenuItem";
		this.aPIToolStripMenuItem.Size = new System.Drawing.Size(36, 20);
		this.aPIToolStripMenuItem.Text = "API";
		this.ForpostBuildingsToolStripMenuItem.Name = "ForpostBuildingsToolStripMenuItem";
		this.ForpostBuildingsToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
		this.ForpostBuildingsToolStripMenuItem.Text = "Разрушенные здания Форпоста";
		this.ForpostBuildingsToolStripMenuItem.Click += new System.EventHandler(ForpostBuildingsToolStripMenuItem_Click);
		this.CityHallMenuItem.Name = "CityHallMenuItem";
		this.CityHallMenuItem.Size = new System.Drawing.Size(234, 22);
		this.CityHallMenuItem.Text = "Ратуша";
		this.CityHallMenuItem.Click += new System.EventHandler(CityHallMenuItem_Click);
		this.menuitemTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[9] { this.menuitemDoSearchBox, this.menuitemDoResetVisitedCells, this.menuItemResetPlants, this.mapScanToolStripMenuItem, this.menuitemCheckCell, this.toolStripSeparator7, this.menuItemTurotor, this.toolStripSeparator25, this.menuitemFishAdvisor });
		this.menuitemTools.Name = "menuitemTools";
		this.menuitemTools.Size = new System.Drawing.Size(87, 20);
		this.menuitemTools.Text = "Инструменты";
		this.menuitemDoSearchBox.CheckOnClick = true;
		this.menuitemDoSearchBox.Name = "menuitemDoSearchBox";
		this.menuitemDoSearchBox.Size = new System.Drawing.Size(229, 22);
		this.menuitemDoSearchBox.Text = "Поиск клада";
		this.menuitemDoSearchBox.Click += new System.EventHandler(menuitemDoSearchBox_Click);
		this.menuitemDoResetVisitedCells.Name = "menuitemDoResetVisitedCells";
		this.menuitemDoResetVisitedCells.Size = new System.Drawing.Size(229, 22);
		this.menuitemDoResetVisitedCells.Text = "Сброс посещенных локаций";
		this.menuitemDoResetVisitedCells.Click += new System.EventHandler(menuitemDoResetVisitedCells_Click);
		this.menuItemResetPlants.Name = "menuItemResetPlants";
		this.menuItemResetPlants.Size = new System.Drawing.Size(229, 22);
		this.menuItemResetPlants.Text = "Сброс трав и деревьев";
		this.menuItemResetPlants.Click += new System.EventHandler(menuItemResetPlants_Click);
		this.mapScanToolStripMenuItem.Name = "mapScanToolStripMenuItem";
		this.mapScanToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
		this.mapScanToolStripMenuItem.Text = "Сканирование карты";
		this.mapScanToolStripMenuItem.Click += new System.EventHandler(mapScanToolStripMenuItem_Click);
		this.menuitemCheckCell.Name = "menuitemCheckCell";
		this.menuitemCheckCell.ShortcutKeys = System.Windows.Forms.Keys.D1 | System.Windows.Forms.Keys.Alt;
		this.menuitemCheckCell.Size = new System.Drawing.Size(229, 22);
		this.menuitemCheckCell.Text = "Проверка клетки";
		this.menuitemCheckCell.Click += new System.EventHandler(menuitemCheckCell_Click);
		this.toolStripSeparator7.Name = "toolStripSeparator7";
		this.toolStripSeparator7.Size = new System.Drawing.Size(226, 6);
		this.menuItemTurotor.CheckOnClick = true;
		this.menuItemTurotor.Name = "menuItemTurotor";
		this.menuItemTurotor.Size = new System.Drawing.Size(229, 22);
		this.menuItemTurotor.Text = "Остров Туротор / Гиблая Топь";
		this.menuItemTurotor.Click += new System.EventHandler(menuItemTurotor_Click);
		this.toolStripSeparator25.Name = "toolStripSeparator25";
		this.toolStripSeparator25.Size = new System.Drawing.Size(226, 6);
		this.menuitemFishAdvisor.Name = "menuitemFishAdvisor";
		this.menuitemFishAdvisor.Size = new System.Drawing.Size(229, 22);
		this.menuitemFishAdvisor.Text = "Советник рыбака";
		this.menuitemFishAdvisor.Click += new System.EventHandler(menuitemFishAdvisor_Click);
		this.menuitemCommands.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[21]
		{
			this.miWearAfter, this.toolStripSeparator11, this.miFastEnabled, this.miFastTeleport, this.miFastDarkTeleport, this.miFastSviRass, this.miFastSviSelfRass, this.miFastF3, this.miFastF4, this.miFastElxVosst,
			this.miFastSvitFog, this.miFastDarkFog, this.miFastF9, this.miFastF10, this.miFastF12, this.miQuick, this.toolStripSeparator12, this.menuitemClanPrivate, this.menuitemMinimize, this.toolStripSeparator20,
			this.miQuickCancel
		});
		this.menuitemCommands.Name = "menuitemCommands";
		this.menuitemCommands.Size = new System.Drawing.Size(65, 20);
		this.menuitemCommands.Text = "Команды";
		this.miWearAfter.Name = "miWearAfter";
		this.miWearAfter.Size = new System.Drawing.Size(258, 22);
		this.miWearAfter.Text = "Надеть комплект после боя";
		this.toolStripSeparator11.Name = "toolStripSeparator11";
		this.toolStripSeparator11.Size = new System.Drawing.Size(255, 6);
		this.miFastEnabled.Checked = true;
		this.miFastEnabled.CheckOnClick = true;
		this.miFastEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
		this.miFastEnabled.Name = "miFastEnabled";
		this.miFastEnabled.Size = new System.Drawing.Size(258, 22);
		this.miFastEnabled.Text = "Быстрые команды разрешены";
		this.miFastEnabled.CheckStateChanged += new System.EventHandler(miFastEnabled_CheckStateChanged);
		this.miFastTeleport.Name = "miFastTeleport";
		this.miFastTeleport.ShortcutKeys = System.Windows.Forms.Keys.F1;
		this.miFastTeleport.Size = new System.Drawing.Size(258, 22);
		this.miFastTeleport.Text = "Телепорт";
		this.miFastTeleport.Click += new System.EventHandler(miFastTeleport_Click);
		this.miFastDarkTeleport.Name = "miFastDarkTeleport";
		this.miFastDarkTeleport.ShortcutKeys = System.Windows.Forms.Keys.F1 | System.Windows.Forms.Keys.Control;
		this.miFastDarkTeleport.Size = new System.Drawing.Size(258, 22);
		this.miFastDarkTeleport.Text = "Сумеречный телепорт";
		this.miFastDarkTeleport.Click += new System.EventHandler(miFastDarkTeleport_Click);
		this.miFastSviRass.Name = "miFastSviRass";
		this.miFastSviRass.ShortcutKeys = System.Windows.Forms.Keys.F2;
		this.miFastSviRass.Size = new System.Drawing.Size(258, 22);
		this.miFastSviRass.Text = "Свиток обнаружения";
		this.miFastSviRass.Click += new System.EventHandler(miFastSviRass_Click);
		this.miFastSviSelfRass.Name = "miFastSviSelfRass";
		this.miFastSviSelfRass.ShortcutKeys = System.Windows.Forms.Keys.F2 | System.Windows.Forms.Keys.Control;
		this.miFastSviSelfRass.Size = new System.Drawing.Size(258, 22);
		this.miFastSviSelfRass.Text = "Свиток рассеивания";
		this.miFastSviSelfRass.Click += new System.EventHandler(miFastSviSelfRass_Click);
		this.miFastF3.Name = "miFastF3";
		this.miFastF3.ShortcutKeys = System.Windows.Forms.Keys.F3;
		this.miFastF3.Size = new System.Drawing.Size(258, 22);
		this.miFastF3.Text = "Эликсир мгновенного исцеления";
		this.miFastF3.Click += new System.EventHandler(miFastF3_Click);
		this.miFastF4.Name = "miFastF4";
		this.miFastF4.ShortcutKeys = System.Windows.Forms.Keys.F4;
		this.miFastF4.Size = new System.Drawing.Size(258, 22);
		this.miFastF4.Text = "Приманка для ботов";
		this.miFastF4.Click += new System.EventHandler(miFastF4_Click);
		this.miFastElxVosst.Name = "miFastElxVosst";
		this.miFastElxVosst.ShortcutKeys = System.Windows.Forms.Keys.F7;
		this.miFastElxVosst.Size = new System.Drawing.Size(258, 22);
		this.miFastElxVosst.Text = "Эликсир восстановления";
		this.miFastElxVosst.Click += new System.EventHandler(miFastElxVosst_Click);
		this.miFastSvitFog.Name = "miFastSvitFog";
		this.miFastSvitFog.ShortcutKeys = System.Windows.Forms.Keys.F8;
		this.miFastSvitFog.Size = new System.Drawing.Size(258, 22);
		this.miFastSvitFog.Text = "Свиток тумана";
		this.miFastSvitFog.Click += new System.EventHandler(miFastSvitFog_Click);
		this.miFastDarkFog.Name = "miFastDarkFog";
		this.miFastDarkFog.ShortcutKeys = System.Windows.Forms.Keys.F8 | System.Windows.Forms.Keys.Control;
		this.miFastDarkFog.Size = new System.Drawing.Size(258, 22);
		this.miFastDarkFog.Text = "Сумеречный туман";
		this.miFastDarkFog.Click += new System.EventHandler(miFastDarkFog_Click);
		this.miFastF9.Name = "miFastF9";
		this.miFastF9.ShortcutKeys = System.Windows.Forms.Keys.F9;
		this.miFastF9.Size = new System.Drawing.Size(258, 22);
		this.miFastF9.Text = "Зелье блаженства";
		this.miFastF9.Click += new System.EventHandler(miFastF9_Click);
		this.miFastF10.Name = "miFastF10";
		this.miFastF10.ShortcutKeys = System.Windows.Forms.Keys.F10;
		this.miFastF10.Size = new System.Drawing.Size(258, 22);
		this.miFastF10.Text = "Эликсир блаженства";
		this.miFastF10.Click += new System.EventHandler(miFastF10_Click);
		this.miFastF12.Name = "miFastF12";
		this.miFastF12.ShortcutKeys = System.Windows.Forms.Keys.F12;
		this.miFastF12.Size = new System.Drawing.Size(258, 22);
		this.miFastF12.Text = "Зелье Невидимости";
		this.miFastF12.Click += new System.EventHandler(miFastF12_Click);
		this.miQuick.Name = "miQuick";
		this.miQuick.Size = new System.Drawing.Size(258, 22);
		this.miQuick.Text = "Быстрые действия";
		this.miQuick.Click += new System.EventHandler(miQuick_Click);
		this.toolStripSeparator12.Name = "toolStripSeparator12";
		this.toolStripSeparator12.Size = new System.Drawing.Size(255, 6);
		this.menuitemClanPrivate.Name = "menuitemClanPrivate";
		this.menuitemClanPrivate.ShortcutKeys = System.Windows.Forms.Keys.S | System.Windows.Forms.Keys.Control;
		this.menuitemClanPrivate.Size = new System.Drawing.Size(258, 22);
		this.menuitemClanPrivate.Text = "Клан-приват";
		this.menuitemClanPrivate.Click += new System.EventHandler(menuitemClanPrivate_Click);
		this.menuitemMinimize.Name = "menuitemMinimize";
		this.menuitemMinimize.ShortcutKeys = System.Windows.Forms.Keys.F11;
		this.menuitemMinimize.Size = new System.Drawing.Size(258, 22);
		this.menuitemMinimize.Text = "Свернуть";
		this.menuitemMinimize.Click += new System.EventHandler(menuitemMinimize_Click);
		this.toolStripSeparator20.Name = "toolStripSeparator20";
		this.toolStripSeparator20.Size = new System.Drawing.Size(255, 6);
		this.miQuickCancel.Name = "miQuickCancel";
		this.miQuickCancel.ShortcutKeys = System.Windows.Forms.Keys.F6 | System.Windows.Forms.Keys.Alt;
		this.miQuickCancel.Size = new System.Drawing.Size(258, 22);
		this.miQuickCancel.Text = "Отмена";
		this.miQuickCancel.Click += new System.EventHandler(miQuickCancel_Click);
		this.menuitemSystem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[6] { this.menuitemShowCookies, this.menuitemMainFrameInspector, this.menuitemCacheRefresh, this.toolStripSeparator3, this.checkLicToolStripMenuItem, this.menuitemAbout });
		this.menuitemSystem.Name = "menuitemSystem";
		this.menuitemSystem.Size = new System.Drawing.Size(61, 20);
		this.menuitemSystem.Text = "Система";
		this.menuitemShowCookies.Name = "menuitemShowCookies";
		this.menuitemShowCookies.Size = new System.Drawing.Size(198, 22);
		this.menuitemShowCookies.Text = "Cookies";
		this.menuitemShowCookies.Click += new System.EventHandler(menuitemShowCookies_Click);
		this.menuitemMainFrameInspector.Name = "menuitemMainFrameInspector";
		this.menuitemMainFrameInspector.Size = new System.Drawing.Size(198, 22);
		this.menuitemMainFrameInspector.Text = "Инспектор фрейма";
		this.menuitemMainFrameInspector.Click += new System.EventHandler(menuitemMainFrameInspector_Click);
		this.menuitemCacheRefresh.CheckOnClick = true;
		this.menuitemCacheRefresh.Name = "menuitemCacheRefresh";
		this.menuitemCacheRefresh.Size = new System.Drawing.Size(198, 22);
		this.menuitemCacheRefresh.Text = "Режим обновления кеша";
		this.menuitemCacheRefresh.ToolTipText = "Имеет смысл включить ненадолго при изменениях на сервере игры, чтобы клиент обновил закешированные файлы.";
		this.menuitemCacheRefresh.Click += new System.EventHandler(menuitemCacheRefresh_Click);
		this.toolStripSeparator3.Name = "toolStripSeparator3";
		this.toolStripSeparator3.Size = new System.Drawing.Size(195, 6);
		this.checkLicToolStripMenuItem.Name = "checkLicToolStripMenuItem";
		this.checkLicToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
		this.checkLicToolStripMenuItem.Text = "Проверить лицензию";
		this.checkLicToolStripMenuItem.Click += new System.EventHandler(checkLicToolStripMenuItem_Click);
		this.menuitemAbout.Name = "menuitemAbout";
		this.menuitemAbout.Size = new System.Drawing.Size(198, 22);
		this.menuitemAbout.Text = "О клиенте";
		this.menuitemAbout.Click += new System.EventHandler(menuitemAbout_Click);
		this.imageList_0.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("imagelistDownload.ImageStream");
		this.imageList_0.TransparentColor = System.Drawing.Color.Transparent;
		this.imageList_0.Images.SetKeyName(0, "16x16-icoff.gif");
		this.imageList_0.Images.SetKeyName(1, "16x16-icon.gif");
		this.saveFileDialog_0.DefaultExt = "jpg";
		this.saveFileDialog_0.Filter = "Снимки экрана|*.jpg|Все файлы|*.*";
		this.saveFileDialog_0.RestoreDirectory = true;
		this.saveFileDialog_0.Title = "Сохранение снимка экрана";
		this.timer_0.Enabled = true;
		this.timer_0.Interval = 10000;
		this.timer_0.Tick += new System.EventHandler(timer_0_Tick);
		this.imageList_2.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("trayImages.ImageStream");
		this.imageList_2.TransparentColor = System.Drawing.Color.Transparent;
		this.imageList_2.Images.SetKeyName(0, "icontray1.gif");
		this.imageList_2.Images.SetKeyName(1, "icontray2.gif");
		this.notifyIcon_0.ContextMenuStrip = this.cmTray;
		this.notifyIcon_0.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(notifyIcon_0_MouseDoubleClick);
		this.cmTray.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
		this.cmTray.Items.AddRange(new System.Windows.Forms.ToolStripItem[2] { this.menuitemRestoreWindow, this.menuitemTrayQuit });
		this.cmTray.Name = "cmTray";
		this.cmTray.Size = new System.Drawing.Size(173, 48);
		this.menuitemRestoreWindow.Name = "menuitemRestoreWindow";
		this.menuitemRestoreWindow.Size = new System.Drawing.Size(172, 22);
		this.menuitemRestoreWindow.Text = "Развернуть клиент";
		this.menuitemRestoreWindow.Click += new System.EventHandler(menuitemRestoreWindow_Click);
		this.menuitemTrayQuit.Image = Class39.smethod_13();
		this.menuitemTrayQuit.Name = "menuitemTrayQuit";
		this.menuitemTrayQuit.Size = new System.Drawing.Size(172, 22);
		this.menuitemTrayQuit.Text = "Завершить работу";
		this.menuitemTrayQuit.Click += new System.EventHandler(menuitemTrayQuit_Click);
		this.timer_1.Interval = 300;
		this.timer_1.Tick += new System.EventHandler(timer_1_Tick);
		this.CmGroup.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
		this.CmGroup.Items.AddRange(new System.Windows.Forms.ToolStripItem[11]
		{
			this.miSetGroupNeutral, this.miSetGroupFoe, this.miSetGroupFriend, this.toolStripSeparator21, this.miSetGroupToolId0, this.miSetGroupToolId1, this.miSetGroupToolId2, this.miSetGroupToolId3, this.miSetGroupToolId4, this.toolStripSeparator24,
			this.miRemoveGroup
		});
		this.CmGroup.Name = "CmGroup";
		this.CmGroup.Size = new System.Drawing.Size(304, 214);
		this.miSetGroupNeutral.Name = "miSetGroupNeutral";
		this.miSetGroupNeutral.Size = new System.Drawing.Size(303, 22);
		this.miSetGroupNeutral.Text = "Сделать группу нейтральной";
		this.miSetGroupNeutral.Click += new System.EventHandler(miSetGroupNeutral_Click);
		this.miSetGroupFoe.Name = "miSetGroupFoe";
		this.miSetGroupFoe.Size = new System.Drawing.Size(303, 22);
		this.miSetGroupFoe.Text = "Сделать группу вражеской";
		this.miSetGroupFoe.Click += new System.EventHandler(miSetGroupFoe_Click);
		this.miSetGroupFriend.Name = "miSetGroupFriend";
		this.miSetGroupFriend.Size = new System.Drawing.Size(303, 22);
		this.miSetGroupFriend.Text = "Сделать группу дружественной";
		this.miSetGroupFriend.Click += new System.EventHandler(miSetGroupFriend_Click);
		this.toolStripSeparator21.Name = "toolStripSeparator21";
		this.toolStripSeparator21.Size = new System.Drawing.Size(300, 6);
		this.miSetGroupToolId0.Name = "miSetGroupToolId0";
		this.miSetGroupToolId0.Size = new System.Drawing.Size(303, 22);
		this.miSetGroupToolId0.Text = "Применять ко всем нападалку по умолчанию";
		this.miSetGroupToolId0.Click += new System.EventHandler(miSetGroupToolId0_Click);
		this.miSetGroupToolId1.Name = "miSetGroupToolId1";
		this.miSetGroupToolId1.Size = new System.Drawing.Size(303, 22);
		this.miSetGroupToolId1.Text = "Применять ко всем боевое";
		this.miSetGroupToolId1.Click += new System.EventHandler(miSetGroupToolId1_Click);
		this.miSetGroupToolId2.Name = "miSetGroupToolId2";
		this.miSetGroupToolId2.Size = new System.Drawing.Size(303, 22);
		this.miSetGroupToolId2.Text = "Применять ко всем закрытое боевое";
		this.miSetGroupToolId2.Click += new System.EventHandler(miSetGroupToolId2_Click);
		this.miSetGroupToolId3.Name = "miSetGroupToolId3";
		this.miSetGroupToolId3.Size = new System.Drawing.Size(303, 22);
		this.miSetGroupToolId3.Text = "Применять ко всем кулачку";
		this.miSetGroupToolId3.Click += new System.EventHandler(miSetGroupToolId3_Click);
		this.miSetGroupToolId4.Name = "miSetGroupToolId4";
		this.miSetGroupToolId4.Size = new System.Drawing.Size(303, 22);
		this.miSetGroupToolId4.Text = "Применять ко всем закрытую кулачку";
		this.miSetGroupToolId4.Click += new System.EventHandler(miSetGroupToolId4_Click);
		this.toolStripSeparator24.Name = "toolStripSeparator24";
		this.toolStripSeparator24.Size = new System.Drawing.Size(300, 6);
		this.miRemoveGroup.Name = "miRemoveGroup";
		this.miRemoveGroup.Size = new System.Drawing.Size(303, 22);
		this.miRemoveGroup.Text = "Удалить группу";
		this.miRemoveGroup.Click += new System.EventHandler(miRemoveGroup_Click);
		this.timer_2.Enabled = true;
		this.timer_2.Interval = 1000;
		this.timer_2.Tick += new System.EventHandler(timer_2_Tick);
		this.timer_3.Enabled = true;
		this.timer_3.Interval = 60000;
		this.timer_3.Tick += new System.EventHandler(timer_3_Tick);
		this.timer_4.Enabled = true;
		this.timer_4.Interval = 5000;
		this.timer_4.Tick += new System.EventHandler(timer_4_Tick);
		this.timer_5.Enabled = true;
		this.timer_5.Interval = 500;
		this.timer_5.Tick += new System.EventHandler(timer_5_Tick);
		this.timer_6.Interval = 10000;
		this.timer_6.Tick += new System.EventHandler(timer_6_Tick);
		this.timer_7.Enabled = true;
		this.timer_7.Interval = 600000;
		this.timer_7.Tick += new System.EventHandler(timer_7_Tick);
		this.collapsibleSplitter.BorderStyle3D = System.Windows.Forms.Border3DStyle.Flat;
		this.collapsibleSplitter.ControlToHide = this.panelRight;
		this.collapsibleSplitter.Dock = System.Windows.Forms.DockStyle.Right;
		this.collapsibleSplitter.ExpandParentForm = false;
		this.collapsibleSplitter.Location = new System.Drawing.Point(1057, 24);
		this.collapsibleSplitter.Name = "collapsibleSplitter";
		this.collapsibleSplitter.Size = new System.Drawing.Size(8, 776);
		this.collapsibleSplitter.TabIndex = 8;
		this.collapsibleSplitter.TabStop = false;
		this.collapsibleSplitter.VisualStyle = ABClient.AppControls.SplitterVisualStyle.XP;
		this.collapsibleSplitter.MouseClick += new System.Windows.Forms.MouseEventHandler(collapsibleSplitter_MouseClick);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(1315, 825);
		base.Controls.Add(this.tabControlLeft);
		base.Controls.Add(this.collapsibleSplitter);
		base.Controls.Add(this.panelRight);
		base.Controls.Add(this.statusStrip);
		base.Controls.Add(this.menuStrip);
		this.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
		base.Icon = Class39.smethod_70();
		base.MainMenuStrip = this.menuStrip;
		base.Name = "FormMain";
		base.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
		base.FormClosing += new System.Windows.Forms.FormClosingEventHandler(FormMain_FormClosing);
		base.Load += new System.EventHandler(FormMain_Load);
		this.CmPerson.ResumeLayout(false);
		this.statusStrip.ResumeLayout(false);
		this.statusStrip.PerformLayout();
		this.panelRight.ResumeLayout(false);
		this.tabControlRight.ResumeLayout(false);
		this.tabPageContacts.ResumeLayout(false);
		this.tabPageContacts.PerformLayout();
		this.toolStrip3.ResumeLayout(false);
		this.toolStrip3.PerformLayout();
		this.tabPageMine.ResumeLayout(false);
		this.groupBox1.ResumeLayout(false);
		this.tabPageComplects.ResumeLayout(false);
		this.tabPageComplects.PerformLayout();
		this.groupBoxCreate.ResumeLayout(false);
		this.groupBoxCreate.PerformLayout();
		this.tabPageTextLog.ResumeLayout(false);
		this.tabPageTextLog.PerformLayout();
		this.panelTexLog.ResumeLayout(false);
		this.panelTexLog.PerformLayout();
		this.toolStrip1.ResumeLayout(false);
		this.toolStrip1.PerformLayout();
		this.tabPageDrinkSets.ResumeLayout(false);
		this.groupBox3.ResumeLayout(false);
		this.groupBox3.PerformLayout();
		this.groupBox2.ResumeLayout(false);
		this.groupBox2.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.DrinkSetItemUsesAmount).EndInit();
		this.tabControlLeft.ResumeLayout(false);
		this.tabPageGame.ResumeLayout(false);
		this.tabPageGame.PerformLayout();
		this.panelGame.ResumeLayout(false);
		this.toolbarGame.ResumeLayout(false);
		this.toolbarGame.PerformLayout();
		this.menuStrip.ResumeLayout(false);
		this.menuStrip.PerformLayout();
		this.cmTray.ResumeLayout(false);
		this.CmGroup.ResumeLayout(false);
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	internal void method_57()
	{
		if (string.IsNullOrEmpty(Class72.smethod_16()))
		{
			return;
		}
		LezFight lezFight = new LezFight(Class72.smethod_16());
		if (lezFight.IsValid)
		{
			if (lezFight.LezCombinations.Count > 0 && lezFight.LezCombination != null)
			{
				HtmlWindow htmlWindow = method_106("main_top");
				if (htmlWindow == null || htmlWindow.Document == null)
				{
					return;
				}
				for (int i = 0; i < lezFight.LezCombination.MagicFlags.Length; i++)
				{
					HtmlElement elementById = htmlWindow.Document.GetElementById($"m{i}");
					if (elementById != null)
					{
						elementById.SetAttribute("bgColor", lezFight.LezCombination.MagicFlags[i] ? "#cc0000" : "#cccccc");
					}
				}
				for (int j = 0; j < 4; j++)
				{
					HtmlElement elementById2 = htmlWindow.Document.GetElementById($"u{j}");
					if (elementById2 != null)
					{
						elementById2.SetAttribute("SelectedIndex", lezFight.LezCombination.HitOps[j].ToString());
						elementById2.InvokeMember("onChange");
					}
					if (LezSpell.IsMagHit(lezFight.LezCombination.HitCodes[j]))
					{
						elementById2 = htmlWindow.Document.GetElementById($"mbu{j}");
						if (elementById2 != null)
						{
							elementById2.SetAttribute("Value", lezFight.FoeGroup.MagHits.ToString());
						}
					}
				}
				for (int k = 0; k < 4; k++)
				{
					HtmlElement elementById3 = htmlWindow.Document.GetElementById($"b{k}");
					if (elementById3 != null)
					{
						elementById3.SetAttribute("SelectedIndex", "0");
						elementById3.InvokeMember("onChange");
					}
				}
				HtmlElement elementById4 = htmlWindow.Document.GetElementById($"b{lezFight.LezCombination.BlockCombo}");
				if (elementById4 != null)
				{
					elementById4.SetAttribute("SelectedIndex", lezFight.LezCombination.BlockOp.ToString());
					elementById4.InvokeMember("onChange");
				}
			}
			else
			{
				method_63("Не выбрано ни одной правильной комбинации ударов/блоков/абилок. Измените настройки автобоя.");
			}
		}
		else
		{
			method_63("Фрейм боя содержит ошибки, либо мы не в бою.");
		}
	}

	internal void method_58()
	{
		if (string.IsNullOrEmpty(Class72.smethod_16()))
		{
			return;
		}
		LezFight lezFight = new LezFight(Class72.smethod_16());
		if (lezFight.IsValid)
		{
			if (lezFight.LezCombinations.Count > 0 && lezFight.LezCombination != null)
			{
				HtmlWindow htmlWindow = method_106("main_top");
				if (!(htmlWindow == null) && !(htmlWindow.Document == null))
				{
					Class72.dateTime_0 = DateTime.Now;
					htmlWindow.Document.InvokeScript("AutoSubmit", new object[1] { lezFight.Result });
				}
			}
			else
			{
				method_63("Не выбрано ни одной правильной комбинации ударов/блоков/абилок. Измените настройки автобоя.");
			}
		}
		else
		{
			method_63("Фрейм боя содержит ошибки либо, мы не в бою.");
		}
	}

	internal void method_59()
	{
		method_60((Enum4)1);
		try
		{
			if (Class72.formMain_0 != null)
			{
				Class72.formMain_0.BeginInvoke(new Delegate20(Class72.formMain_0.method_110), new object[0]);
			}
		}
		catch (InvalidOperationException)
		{
		}
	}

	private void method_60(Enum4 enum4_0)
	{
		Class72.smethod_19(enum4_0);
		string text = string.Empty;
		switch (enum4_0)
		{
		case (Enum4)0:
			text = "Включение автобоя";
			Class72.class19_0.bool_48 = false;
			break;
		case (Enum4)1:
			text = "Отключение автобоя";
			Class72.class19_0.bool_48 = true;
			break;
		case (Enum4)2:
		{
			TimeSpan timeSpan_ = TimeSpan.FromTicks(Class72.class19_0.struct13_0.long_0 - DateTime.Now.Ticks);
			text = "Останов лечения " + Class4.smethod_1(timeSpan_);
			break;
		}
		case (Enum4)3:
		{
			string text2 = Class4.smethod_1(TimeSpan.FromTicks(Class72.class19_0.struct13_0.long_0 - DateTime.Now.Ticks));
			text = "Останов ожидания " + text2;
			break;
		}
		}
		buttonAutoboi.Text = text;
	}

	private void method_61()
	{
		switch (Class72.smethod_18())
		{
		case (Enum4)1:
		case (Enum4)2:
		case (Enum4)3:
			method_60((Enum4)0);
			Class72.class19_0.struct13_0.long_0 = 0L;
			Class72.class19_0.bool_48 = false;
			Class72.class19_0.method_20();
			if (Class72.bool_21 && Class72.string_29.Equals("Приманку Для Ботов", StringComparison.CurrentCultureIgnoreCase))
			{
				method_20();
			}
			break;
		case (Enum4)0:
			method_60((Enum4)1);
			Class72.class19_0.bool_48 = true;
			Class72.class19_0.method_20();
			try
			{
				if (Class72.formMain_0 != null)
				{
					Class72.formMain_0.BeginInvoke(new Delegate20(Class72.formMain_0.method_110), new object[0]);
				}
				break;
			}
			catch (InvalidOperationException)
			{
				break;
			}
		}
	}

	internal static void smethod_59()
	{
		Class8.smethod_1(DateTime.Now);
		Class8.smethod_3(bool_1: false);
	}

	internal static string smethod_60(string string_0)
	{
		if (!string_0.Contains("Установка любого образа в Доме Дилеров в автоматическом режиме") && !string_0.Contains("Удобные способы пополнения Вашего лицевого счета (DNV)") && !string_0.Contains("Актуальные курсы пополнения игрового счета (DNV)") && !string_0.Contains("В ДД заработал раздел Специальные акции!") && !string_0.Contains("Получить ответы на интересующие Вас вопросы по различным аспектам") && !string_0.Contains("Набор в Институт Власти:") && !string_0.Contains("В Лотерейном Доме Октала с понедельника") && !string_0.Contains("Моментальный способ пополнения Вашего лицевого счета (DNV)"))
		{
			DateTime dateTime = ((Class72.class19_0.timeSpan_0 != TimeSpan.MinValue) ? DateTime.Now.Subtract(Class72.class19_0.timeSpan_0) : DateTime.Now);
			return $"<font class=chattime>&nbsp;{dateTime.Hour:00}:{dateTime.Minute:00}:{dateTime.Second:00}&nbsp;</font>{string_0}";
		}
		return string.Empty;
	}

	internal static string smethod_61(string string_0)
	{
		if (string_0.Contains("font class=massm"))
		{
			string_0 = smethod_60(string_0);
		}
		if (string.IsNullOrEmpty(string_0))
		{
			return string_0;
		}
		string text = Class12.smethod_1(string_0, "Получено <font color=#CC0000>боевого</font> опыта: <b><font color=#CC0000>", "</font></b>.");
		if (!string.IsNullOrEmpty(text) && long.TryParse(text, out var result))
		{
			try
			{
				if (Class72.formMain_0 != null)
				{
					Class72.formMain_0.BeginInvoke(new Delegate38(Class72.formMain_0.method_84), result);
				}
			}
			catch (InvalidOperationException)
			{
			}
		}
		string text2 = Class12.smethod_1(string_0, "Результат обыска бота: <B>", "</B>.");
		if (!string.IsNullOrEmpty(text2))
		{
			string text3 = Class12.smethod_1(string_0, "<font class=chattime>&nbsp;", "&nbsp;</font> <font color=000000><B><font color=#CC0000>Внимание!</font> Системная информация.</B> Результат обыска бота: ");
			if (!string.IsNullOrEmpty(text3))
			{
				List<string> list = new List<string>();
				foreach (Match item in Regex.Matches(text2, "«([^»]+)»"))
				{
					list.Add(item.ToString().Trim('«', '»'));
				}
				if (list.Count > 0)
				{
					try
					{
						if (Class72.formMain_0 != null)
						{
							Class72.formMain_0.BeginInvoke(new Delegate30(Class72.formMain_0.method_85), text3, list);
						}
					}
					catch (InvalidOperationException)
					{
					}
				}
			}
		}
		if (string_0.IndexOf("<font color=#000000><b>Системная информация.</b></font> Поединок завершён.", StringComparison.OrdinalIgnoreCase) != -1)
		{
			if (!string.IsNullOrEmpty(Class72.string_1) && !string.IsNullOrEmpty(Class72.string_2) && !string.IsNullOrEmpty(Class72.string_3) && !string.IsNullOrEmpty(Class72.smethod_22()))
			{
				string newValue = "Бой" + Class72.string_3 + " против " + Class72.string_2 + " завершен (<a href=http://www.neverlands.ru/logs.fcg?fid=" + Class72.string_1 + " onclick=\"window.open(this.href);\">лог</a> боя). Нанесено урона: <FONT color=#339900><b>" + Class72.smethod_22() + "</b></FONT>";
				string_0 = string_0.Replace("Поединок завершён", newValue);
				int num = string_0.IndexOf("Получено <font color=#004BBB>магического", StringComparison.OrdinalIgnoreCase);
				if (num != -1)
				{
					int num2 = string_0.IndexOf("</font></b>.", num, StringComparison.OrdinalIgnoreCase);
					if (num2 != -1)
					{
						string_0 = string_0.Remove(num, num2 + 12 - num);
					}
				}
				_ = "Бой против " + Class72.string_2 + " завершен (" + Class72.string_1 + ")";
				try
				{
				}
				catch (InvalidOperationException)
				{
				}
				Class72.string_1 = string.Empty;
				Class72.string_2 = string.Empty;
			}
		}
		else
		{
			int num3 = string_0.IndexOf("\">" + Class72.class19_0.method_30() + "</SPAN>", StringComparison.OrdinalIgnoreCase);
			if (num3 != -1)
			{
				string text4 = Class12.smethod_1(string_0, "<SPAN title=\"", "\">").TrimStart('%');
				if (!text4.Equals(Class72.class19_0.method_30(), StringComparison.OrdinalIgnoreCase))
				{
					Class18.smethod_2();
					bool flag = string_0.IndexOf(" > clan: ", StringComparison.OrdinalIgnoreCase) != -1;
					if (Class72.class19_0.method_74())
					{
						string text5 = "%<" + text4 + "> " + Class73.smethod_1();
						if (flag)
						{
							text5 = text5.Insert(0, "%clan%");
						}
						Class8.smethod_4(text5);
					}
				}
			}
			if (Class72.class19_0.method_112())
			{
				num3 = string_0.IndexOf("</SPAN>", StringComparison.OrdinalIgnoreCase);
				if (num3 != -1)
				{
					int num4 = string_0.LastIndexOf('>', num3);
					if (num4 != -1)
					{
						string userNick = string_0.Substring(num4 + 1, num3 - num4 - 1);
						if (ChatUsersManager.Exists(userNick))
						{
							int num5 = string_0.LastIndexOf('<', num4);
							if (num5 != -1)
							{
								ChatUser userData = ChatUsersManager.GetUserData(userNick);
								if (!string.IsNullOrEmpty(userData.Level))
								{
									string_0 = string_0.Insert(num3 + 7, "&nbsp;[" + userData.Level + "]<a href=\"http://www.neverlands.ru/pinfo.cgi?" + userData.Nick + "\" onclick=\"window.open(this.href);\"><img src=http://image.neverlands.ru/chat/info.gif width=11 height=12 border=0 align=bottom></a>");
								}
								StringBuilder stringBuilder = new StringBuilder();
								if (!string.IsNullOrEmpty(userData.Sign))
								{
									stringBuilder.Append("<img src=http://image.neverlands.ru/signs/");
									stringBuilder.Append(userData.Sign);
									stringBuilder.Append(" width=15 height=12 align=bottom title=\"");
									stringBuilder.Append(userData.Status);
									stringBuilder.Append("\">&nbsp;");
								}
								string_0 = string_0.Insert(num5, stringBuilder.ToString());
							}
						}
					}
				}
			}
		}
		if (string_0.IndexOf("clan:", StringComparison.OrdinalIgnoreCase) != -1)
		{
			string_0 = string_0.Replace("<SPAN title=\"%", "<SPAN title=\"%%");
		}
		while (true)
		{
			int num6 = string_0.IndexOf("[[[", StringComparison.Ordinal);
			if (num6 == -1)
			{
				break;
			}
			int num7 = string_0.IndexOf("]]]", num6, StringComparison.Ordinal);
			if (num7 == -1)
			{
				break;
			}
			string text6 = string_0.Substring(num6 + 3, num7 - num6 - 3);
			string text7 = string.Empty;
			if (!text6.Contains(":"))
			{
				text7 = "<a href=http://www.neverlands.ru/logs.fcg?fid=" + text6 + " onclick=\"window.open(this.href);\">Лог боя</a>";
			}
			string_0 = string_0.Substring(0, num6) + text7 + string_0.Substring(num7 + 3);
		}
		Class8.smethod_6(string_0);
		return string_0 + "<BR>";
	}

	internal void method_62(string string_0)
	{
		if (!string.IsNullOrEmpty(string_0))
		{
			string text = Class7.smethod_0() + "<FONT color=#000000> " + string_0 + "</FONT><BR>";
			if (Class72.class19_0.timeSpan_0 != TimeSpan.MinValue)
			{
				DateTime dateTime = DateTime.Now.Subtract(Class72.class19_0.timeSpan_0);
				string text2 = $"{dateTime.Hour:00}:{dateTime.Minute:00}:{dateTime.Second:00}";
				text = "<font class=chattime>&nbsp;" + text2 + "&nbsp;</font>" + text;
			}
			method_114(text);
		}
	}

	internal void method_63(string string_0)
	{
		Class93 @class = new Class93();
		@class.formMain_0 = this;
		@class.string_0 = string_0;
		if (base.InvokeRequired)
		{
			BeginInvoke(new MethodInvoker(@class.method_0));
		}
		else if (!string.IsNullOrEmpty(@class.string_0))
		{
			string text = Class7.smethod_0() + "<FONT color=#000000> " + @class.string_0 + "</FONT><BR>";
			if (Class72.class19_0.timeSpan_0 != TimeSpan.MinValue)
			{
				DateTime dateTime = DateTime.Now.Subtract(Class72.class19_0.timeSpan_0);
				string text2 = $"{dateTime.Hour:00}:{dateTime.Minute:00}:{dateTime.Second:00}";
				text = "<font class=chattime>&nbsp;" + text2 + "&nbsp;</font>" + text;
			}
			method_114(text);
		}
	}

	private static void smethod_62()
	{
		ThreadPool.QueueUserWorkItem(smethod_63, null);
	}

	private static void smethod_63(object object_0)
	{
		Class72.smethod_29(DateTime.Now);
		if (string.IsNullOrEmpty(Class72.string_49))
		{
			Class72.string_49 = Class21.smethod_2(Class72.class19_0.method_30());
		}
		if (string.IsNullOrEmpty(Class72.string_49))
		{
			return;
		}
		string text = Class21.smethod_3(Class72.string_49);
		if (string.IsNullOrEmpty(text))
		{
			return;
		}
		string text2 = Class12.smethod_1(text, "\n2|", "\n3|");
		string text3 = Class12.smethod_1(text, "\n3|", "\n4|");
		string text4 = Class12.smethod_1(text, "\n4|", "\n");
		if (string.IsNullOrEmpty(text4) || string.IsNullOrEmpty(text3))
		{
			return;
		}
		string[] array = text4.Split('|');
		string text5 = text3.Split('|')[13];
		if (!string.IsNullOrEmpty(text2))
		{
			string[] array2 = text2.Split('@');
			Array.Clear(Class72.smethod_146(), 0, Class72.smethod_146().Length);
			for (int i = 0; i < array2.Length; i++)
			{
				string[] array3 = array2[i].Split('.');
				if (array3.Length > 4)
				{
					switch (array3[0])
					{
					case "24":
						Class72.smethod_146()[0]++;
						break;
					case "4":
						Class72.smethod_146()[1]++;
						break;
					case "3":
						Class72.smethod_146()[2]++;
						break;
					case "2":
						Class72.smethod_146()[3]++;
						break;
					}
				}
			}
			if (Class72.smethod_146()[0] > 0)
			{
				if (DateTime.Now.Subtract(Class72.smethod_148()).TotalMinutes > 10.0)
				{
					Class72.smethod_149(DateTime.Now);
					Class72.formMain_0.method_63("У вас отравление. Почему бы не включить автолечение в настройках?");
				}
			}
			else if ((Class72.smethod_146()[1] > 0 || Class72.smethod_146()[2] > 0 || Class72.smethod_146()[3] > 0) && DateTime.Now.Subtract(Class72.smethod_148()).TotalMinutes > 10.0)
			{
				Class72.smethod_149(DateTime.Now);
				Class72.formMain_0.method_63("У вас небоевая травма. Почему бы не включить автолечение в настройках?");
			}
		}
		if (array.Length <= 4)
		{
			return;
		}
		int result;
		if (!string.IsNullOrEmpty(text5) && !(text5 == "Неизвестно"))
		{
			if (int.TryParse(array[4], out result))
			{
				result = 100 - result;
			}
		}
		else
		{
			result = Class72.smethod_26() + 2;
		}
		try
		{
			Class72.formMain_0.BeginInvoke(new Delegate31(Class72.formMain_0.method_92), result);
		}
		catch
		{
		}
	}

	private void tsContactTrace_Click(object sender, EventArgs e)
	{
		Class72.class19_0.method_143(tsContactTrace.Checked);
	}

	internal void method_64(string string_0)
	{
		ContactsManager.smethod_2(treeContacts, string_0);
	}

	private void method_65(string string_0)
	{
		ContactsManager.smethod_2(treeContacts, string_0);
	}

	private void method_66()
	{
		TreeNode selectedNode = treeContacts.SelectedNode;
		if (selectedNode.Tag != null)
		{
			ContactsManager.smethod_11(treeContacts, selectedNode);
		}
	}

	private void method_67(TreeNode treeNode_0)
	{
		if (treeNode_0.Tag == null)
		{
			tsDeleteContact.Enabled = false;
			tsContactPrivate.Enabled = false;
			cmtsDeleteContact.Enabled = false;
			cmtsContactPrivate.Enabled = false;
			tbContactDetails.Text = string.Empty;
			miRemoveGroup.Enabled = true;
			return;
		}
		Class76 @class = (Class76)treeNode_0.Tag;
		tbContactDetails.Text = @class.method_4();
		tsDeleteContact.Enabled = true;
		cmtsDeleteContact.Enabled = true;
		tsContactPrivate.Enabled = true;
		cmtsContactPrivate.Enabled = true;
		cmtsFightLog.Enabled = !string.IsNullOrEmpty(@class.method_40());
		cmtsClassNeutral.Checked = false;
		cmtsClassFoe.Checked = false;
		cmtsClassFriend.Checked = false;
		switch (@class.method_8())
		{
		default:
			cmtsClassNeutral.Checked = true;
			break;
		case 0:
			cmtsClassNeutral.Checked = true;
			break;
		case 1:
			cmtsClassFoe.Checked = true;
			break;
		case 2:
			cmtsClassFriend.Checked = true;
			break;
		}
		cmtsToolId0.Checked = false;
		cmtsToolId1.Checked = false;
		cmtsToolId2.Checked = false;
		cmtsToolId3.Checked = false;
		cmtsToolId4.Checked = false;
		switch (@class.method_10())
		{
		default:
			cmtsToolId0.Checked = true;
			break;
		case 0:
			cmtsToolId0.Checked = true;
			break;
		case 1:
			cmtsToolId1.Checked = true;
			break;
		case 2:
			cmtsToolId2.Checked = true;
			break;
		case 3:
			cmtsToolId3.Checked = true;
			break;
		case 4:
			cmtsToolId4.Checked = true;
			break;
		}
	}

	private void method_68()
	{
		TreeNode selectedNode = treeContacts.SelectedNode;
		if (selectedNode != null && selectedNode.Tag != null)
		{
			Class76 obj = (Class76)selectedNode.Tag;
			obj.method_5(tbContactDetails.Text ?? string.Empty);
			ContactsManager.smethod_10(obj, obj.method_4());
		}
	}

	private void method_69()
	{
		Class76 @class = method_72();
		if (@class != null && !string.IsNullOrEmpty(@class.method_0()))
		{
			method_144((Enum2)2, Class39.smethod_45() + @class.method_0(), bool_0: false);
		}
	}

	private void method_70()
	{
		Class76 @class = method_72();
		if (@class != null && !string.IsNullOrEmpty(@class.method_40()))
		{
			method_144((Enum2)5, Class39.smethod_38() + @class.method_40(), bool_0: false);
		}
	}

	private void method_71()
	{
		Class76 @class = method_72();
		if (@class != null && !string.IsNullOrEmpty(@class.method_0()))
		{
			new FormQuick(@class.method_0()).Show();
		}
	}

	private Class76 method_72()
	{
		if (treeContacts == null)
		{
			return null;
		}
		if (treeContacts.SelectedNode == null)
		{
			return null;
		}
		return (Class76)treeContacts.SelectedNode.Tag;
	}

	private void method_73()
	{
		if (treeContacts != null)
		{
			TreeNode selectedNode = treeContacts.SelectedNode;
			if (selectedNode.Tag == null)
			{
				return;
			}
			Class76 @class = (Class76)selectedNode.Tag;
			method_111("%<" + @class.method_0() + "> ");
		}
		tabControlLeft.SelectedIndex = 0;
	}

	private void method_74(int int_1)
	{
		TreeNode selectedNode = treeContacts.SelectedNode;
		Class76 @class = (Class76)selectedNode.Tag;
		if (@class == null)
		{
			return;
		}
		@class.method_9(int_1);
		if (Class72.class19_0.method_140().ContainsKey(@class.method_0().ToLower()))
		{
			Class72.class19_0.method_140()[@class.method_0().ToLower()].method_9(int_1);
			if (selectedNode.Checked)
			{
				selectedNode.ForeColor = ContactsManager.smethod_7(@class.method_8(), @class.method_36());
				method_67(selectedNode);
			}
		}
	}

	private void cmtsClassNeutral_Click(object sender, EventArgs e)
	{
		method_74(0);
	}

	private void cmtsClassFoe_Click(object sender, EventArgs e)
	{
		method_74(1);
	}

	private void cmtsClassFriend_Click(object sender, EventArgs e)
	{
		method_74(2);
	}

	private void method_75(int int_1)
	{
		TreeNode selectedNode = treeContacts.SelectedNode;
		Class76 @class = (Class76)selectedNode.Tag;
		if (@class != null && Class72.class19_0.method_140().ContainsKey(@class.method_0().ToLower()))
		{
			Class72.class19_0.method_140()[@class.method_0().ToLower()].method_11(int_1);
			method_67(selectedNode);
		}
	}

	private void cmtsToolId0_Click(object sender, EventArgs e)
	{
		method_75(0);
	}

	private void cmtsToolId1_Click(object sender, EventArgs e)
	{
		method_75(1);
	}

	private void cmtsToolId2_Click(object sender, EventArgs e)
	{
		method_75(2);
	}

	private void cmtsToolId3_Click(object sender, EventArgs e)
	{
		method_75(3);
	}

	private void cmtsToolId4_Click(object sender, EventArgs e)
	{
		method_75(4);
	}

	private void method_76(int int_1)
	{
		TreeNode selectedNode = treeContacts.SelectedNode;
		if (selectedNode.Tag != null)
		{
			return;
		}
		foreach (TreeNode node in selectedNode.Nodes)
		{
			Class76 @class = (Class76)node.Tag;
			if (@class != null && Class72.class19_0.method_140().ContainsKey(@class.method_0().ToLower()))
			{
				Class72.class19_0.method_140()[@class.method_0().ToLower()].method_9(int_1);
				if (node.Checked)
				{
					node.ForeColor = ContactsManager.smethod_7(@class.method_8(), @class.method_36());
				}
			}
		}
	}

	private void MakeEnemyContactsNeutralButton_Click(object sender, EventArgs e)
	{
		foreach (KeyValuePair<string, Class76> item in Class72.class19_0.method_140())
		{
			Class76 value = item.Value;
			if (value.method_8().Equals(1))
			{
				value.method_9(0);
				ContactsManager.smethod_15(treeContacts, value).ForeColor = ContactsManager.smethod_7(value.method_8(), value.method_36());
			}
		}
	}

	private void miSetGroupNeutral_Click(object sender, EventArgs e)
	{
		method_76(0);
	}

	private void miSetGroupFoe_Click(object sender, EventArgs e)
	{
		method_76(1);
	}

	private void miSetGroupFriend_Click(object sender, EventArgs e)
	{
		method_76(2);
	}

	private void method_77(int int_1)
	{
		TreeNode selectedNode = treeContacts.SelectedNode;
		if (selectedNode.Tag != null)
		{
			return;
		}
		foreach (TreeNode node in selectedNode.Nodes)
		{
			Class76 @class = (Class76)node.Tag;
			if (@class != null && Class72.class19_0.method_140().ContainsKey(@class.method_0().ToLower()))
			{
				Class72.class19_0.method_140()[@class.method_0().ToLower()].method_11(int_1);
			}
		}
	}

	private void miSetGroupToolId0_Click(object sender, EventArgs e)
	{
		method_77(0);
	}

	private void miSetGroupToolId1_Click(object sender, EventArgs e)
	{
		method_77(1);
	}

	private void miSetGroupToolId2_Click(object sender, EventArgs e)
	{
		method_77(2);
	}

	private void miSetGroupToolId3_Click(object sender, EventArgs e)
	{
		method_77(3);
	}

	private void miSetGroupToolId4_Click(object sender, EventArgs e)
	{
		method_77(4);
	}

	internal static void smethod_64()
	{
		if (!Class72.class19_0.method_82())
		{
			return;
		}
		try
		{
			if (Class72.formMain_0 != null)
			{
				Class72.formMain_0.BeginInvoke(new Delegate15(Class72.formMain_0.method_96), new object[0]);
			}
		}
		catch (InvalidOperationException)
		{
		}
	}

	internal static string smethod_65(string string_0, int int_1)
	{
		if (!Class72.smethod_124() && int_1 > 4)
		{
			if (string_0.Equals("Хлеб", StringComparison.OrdinalIgnoreCase) && (Class72.class19_0.method_90() & (Enum0)1) != 0)
			{
				Class72.smethod_125(bool_54: true);
				Class72.smethod_127(string_0);
				Class72.smethod_129(int_1);
				return " CHECKED";
			}
			if (string_0.Equals("Червяк", StringComparison.OrdinalIgnoreCase) && (Class72.class19_0.method_90() & (Enum0)2) != 0)
			{
				Class72.smethod_125(bool_54: true);
				Class72.smethod_127(string_0);
				Class72.smethod_129(int_1);
				return " CHECKED";
			}
			if (string_0.Equals("Крупный червяк", StringComparison.OrdinalIgnoreCase) && (Class72.class19_0.method_90() & (Enum0)4) != 0)
			{
				Class72.smethod_125(bool_54: true);
				Class72.smethod_127(string_0);
				Class72.smethod_129(int_1);
				return " CHECKED";
			}
			if (string_0.Equals("Опарыш", StringComparison.OrdinalIgnoreCase) && (Class72.class19_0.method_90() & (Enum0)8) != 0)
			{
				Class72.smethod_125(bool_54: true);
				Class72.smethod_127(string_0);
				Class72.smethod_129(int_1);
				return " CHECKED";
			}
			if (string_0.Equals("Мотыль", StringComparison.OrdinalIgnoreCase) && (Class72.class19_0.method_90() & (Enum0)16) != 0)
			{
				Class72.smethod_125(bool_54: true);
				Class72.smethod_127(string_0);
				Class72.smethod_129(int_1);
				return " CHECKED";
			}
			if (string_0.Equals("Блесна", StringComparison.OrdinalIgnoreCase) && (Class72.class19_0.method_90() & (Enum0)32) != 0)
			{
				Class72.smethod_125(bool_54: true);
				Class72.smethod_127(string_0);
				Class72.smethod_129(int_1);
				return " CHECKED";
			}
			if (string_0.Equals("Донка", StringComparison.OrdinalIgnoreCase) && (Class72.class19_0.method_90() & (Enum0)64) != 0)
			{
				Class72.smethod_125(bool_54: true);
				Class72.smethod_127(string_0);
				Class72.smethod_129(int_1);
				return " CHECKED";
			}
			if (string_0.Equals("Мормышка", StringComparison.OrdinalIgnoreCase) && (Class72.class19_0.method_90() & (Enum0)128) != 0)
			{
				Class72.smethod_125(bool_54: true);
				Class72.smethod_127(string_0);
				Class72.smethod_129(int_1);
				return " CHECKED";
			}
			if (string_0.Equals("Заговоренная блесна", StringComparison.OrdinalIgnoreCase) && (Class72.class19_0.method_90() & (Enum0)256) != 0)
			{
				Class72.smethod_125(bool_54: true);
				Class72.smethod_127(string_0);
				Class72.smethod_129(int_1);
				return " CHECKED";
			}
			return string.Empty;
		}
		return string.Empty;
	}

	internal static bool smethod_66(int int_1, int int_2)
	{
		string key = Class77.smethod_30(int_1, int_2);
		if (!Class77.smethod_0().ContainsKey(key))
		{
			return false;
		}
		string text = Class77.smethod_0()[key].method_4();
		if (text == null)
		{
			return false;
		}
		return Class77.smethod_4().ContainsKey(text);
	}

	internal static string smethod_67(int int_1, int int_2)
	{
		string text = Class77.smethod_30(int_1, int_2);
		if (text == null)
		{
			return string.Empty;
		}
		if (Class77.smethod_0().TryGetValue(text, out var _))
		{
			return Class77.smethod_0()[text].method_4();
		}
		return string.Empty;
	}

	internal static void smethod_68(int int_1, int int_2)
	{
		string text = Class77.smethod_30(int_1, int_2);
		if (text != null && Class77.smethod_0().TryGetValue(text, out var _))
		{
			string key = Class77.smethod_0()[text].method_4();
			if (Class77.smethod_6().TryGetValue(key, out var value2))
			{
				value2.Visited = ((Class72.class19_0.timeSpan_0 == TimeSpan.MinValue) ? DateTime.Now : DateTime.Now.Subtract(Class72.class19_0.timeSpan_0));
			}
		}
	}

	internal void method_78(DateTime dateTime_1)
	{
		Class72.smethod_133(dateTime_1);
	}

	internal void method_79(string string_0)
	{
		Class94 @class = new Class94();
		@class.formMain_0 = this;
		@class.string_0 = string_0;
		if (base.InvokeRequired)
		{
			BeginInvoke(new MethodInvoker(@class.method_0));
			return;
		}
		try
		{
			readerWriterLock_1.AcquireWriterLock(5000);
			try
			{
				labelAddress.Text = Class6.smethod_0(@class.string_0);
			}
			finally
			{
				readerWriterLock_1.ReleaseWriterLock();
			}
		}
		catch (ApplicationException)
		{
		}
	}

	internal void method_80(string string_0)
	{
		Class96 @class = new Class96();
		@class.formMain_0 = this;
		@class.string_0 = string_0;
		if (base.InvokeRequired)
		{
			BeginInvoke(new MethodInvoker(@class.method_0));
			return;
		}
		try
		{
			readerWriterLock_1.AcquireWriterLock(5000);
			try
			{
				string text = Class6.smethod_1(@class.string_0);
				labelAddress.Text = text;
			}
			finally
			{
				readerWriterLock_1.ReleaseWriterLock();
			}
		}
		catch (ApplicationException)
		{
		}
	}

	internal void method_81(int int_1)
	{
		int index = ((int_1 > 0) ? 1 : 0);
		statuslabelActivity.Image = imageList_0.Images[index];
		statuslabelNumberOfThreads.Text = ((int_1 > 9) ? 9 : int_1).ToString();
	}

	internal void method_82(string string_0)
	{
		method_83(string_0);
	}

	internal void method_83(string string_0)
	{
		if (Class72.class19_0.method_116() && !(Class72.class19_0.method_30() != Class68.string_1))
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendFormat(CultureInfo.InvariantCulture, "{0:00}:{1:00}:{2:00}  {3}", DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second, string_0);
			stringBuilder.AppendLine();
			stringBuilder.Append(textboxTexLog.Text);
			while (stringBuilder.Length > 16384)
			{
				stringBuilder.Length = 16384;
			}
			textboxTexLog.Text = stringBuilder.ToString();
		}
	}

	private void method_84(long long_0)
	{
		Interlocked.Add(ref Class72.class19_0.class17_0.long_3, long_0);
		method_136();
	}

	private void method_85(string string_0, List<string> list_0)
	{
		if (Class72.class19_0.method_124())
		{
			StringBuilder stringBuilder = new StringBuilder();
			foreach (string item2 in list_0)
			{
				if (stringBuilder.Length > 0)
				{
					stringBuilder.Append(", ");
				}
				stringBuilder.Append(item2);
			}
			method_93(stringBuilder.ToString());
		}
		foreach (string item3 in list_0)
		{
			string text = $"{string_0} {item3}";
			string[] array = Class72.class19_0.class17_0.string_0.Split('|');
			int i;
			for (i = 0; i < array.Length && !text.Equals(array[i], StringComparison.OrdinalIgnoreCase); i++)
			{
			}
			if (i != array.Length)
			{
				continue;
			}
			if (item3.EndsWith("NV", StringComparison.OrdinalIgnoreCase))
			{
				if (int.TryParse(item3.Substring(0, item3.Length - 3), out var result))
				{
					Interlocked.Add(ref Class72.class19_0.class17_0.int_2, result);
					method_137();
				}
				continue;
			}
			StringBuilder stringBuilder2 = new StringBuilder(Class72.class19_0.class17_0.string_0);
			if (stringBuilder2.Length > 0)
			{
				stringBuilder2.Append('|');
			}
			stringBuilder2.Append(text);
			Class72.class19_0.class17_0.string_0 = stringBuilder2.ToString();
			Class16 item = new Class16
			{
				string_0 = item3,
				int_0 = 1
			};
			bool flag = false;
			for (int j = 0; j < Class72.class19_0.class17_0.list_0.Count; j++)
			{
				int num = string.Compare(item3, Class72.class19_0.class17_0.list_0[j].string_0, StringComparison.Ordinal);
				if (num != 0)
				{
					if (num < 0)
					{
						Class72.class19_0.class17_0.list_0.Insert(j, item);
						flag = true;
						break;
					}
					continue;
				}
				Class72.class19_0.class17_0.list_0[j].int_0++;
				flag = true;
				break;
			}
			if (!flag)
			{
				Class72.class19_0.class17_0.list_0.Add(item);
			}
		}
	}

	internal void method_86(int int_1)
	{
		Interlocked.Add(ref Class72.class19_0.class17_0.int_3, int_1);
		method_138();
	}

	internal void method_87(string string_0)
	{
		Class72.smethod_7(string_0);
		Class72.smethod_11(bool_54: false);
		Close();
	}

	internal void method_88(string string_0)
	{
		Class95 @class = new Class95();
		@class.formMain_0 = this;
		@class.string_0 = string_0;
		if (base.InvokeRequired)
		{
			BeginInvoke(new MethodInvoker(@class.method_0));
			return;
		}
		Class72.string_4 = (string.IsNullOrEmpty(@class.string_0) ? "?-???" : @class.string_0);
		statuslabelLocation.Text = Class72.string_4;
		if (Class77.smethod_6().ContainsKey(Class72.string_4))
		{
			Class77.smethod_6()[Class72.string_4].Visited = DateTime.Now;
		}
	}

	internal void method_89()
	{
		Class72.class19_0.bool_48 = false;
		method_60((Enum4)0);
	}

	internal void method_90(string string_0)
	{
		if (!Class72.smethod_2())
		{
			Class72.smethod_3(bool_54: true);
			method_83(string_0);
		}
	}

	internal void method_91()
	{
		if (Class72.smethod_18() != 0)
		{
			method_60((Enum4)1);
		}
	}

	internal void method_92(int int_1)
	{
		Class72.smethod_27((int_1 >= 0) ? int_1 : 0);
		StringBuilder stringBuilder = new StringBuilder("Усталость: ");
		stringBuilder.Append(Class72.smethod_26());
		stringBuilder.Append('%');
		statuslabelTied.Text = stringBuilder.ToString();
		Class72.smethod_29(DateTime.Now);
		Class72.smethod_33(bool_54: false);
		if (Class72.smethod_26() <= 0)
		{
			Class72.smethod_31(bool_54: false);
			Class72.smethod_85(bool_54: false);
			buttonDrink.Checked = false;
		}
	}

	internal static void smethod_69()
	{
		smethod_62();
	}

	internal void method_93(string string_0)
	{
		try
		{
			readerWriterLock_3.AcquireWriterLock(5000);
			try
			{
				notifyIcon_0.ShowBalloonTip(10000, Class72.class55_0.method_4(), string_0, ToolTipIcon.None);
			}
			finally
			{
				readerWriterLock_3.ReleaseWriterLock();
			}
		}
		catch (ApplicationException)
		{
		}
	}

	internal void method_94(string string_0)
	{
		method_167(string_0);
	}

	internal void method_95()
	{
		buttonNavigator.Checked = false;
		menuitemDoSearchBox.Checked = false;
		Class72.bool_34 = false;
		Class72.smethod_37(bool_54: false);
		Class72.bool_44 = false;
		Class72.bool_43 = false;
	}

	internal void method_96()
	{
		buttonAutoFish.Checked = false;
		Class72.class19_0.method_101(bool_55: false);
		Class72.class19_0.method_20();
	}

	internal void method_97(string[] string_0)
	{
		StringBuilder stringBuilder = new StringBuilder();
		miWearAfter.DropDownItems.Clear();
		int num = 0;
		Keys[] array = new Keys[10]
		{
			Keys.D1 | Keys.Control,
			Keys.D2 | Keys.Control,
			Keys.D3 | Keys.Control,
			Keys.D4 | Keys.Control,
			Keys.D5 | Keys.Control,
			Keys.D6 | Keys.Control,
			Keys.D7 | Keys.Control,
			Keys.D8 | Keys.Control,
			Keys.D9 | Keys.Control,
			Keys.D0 | Keys.Control
		};
		foreach (string value in string_0)
		{
			ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem(value);
			if (num < array.Length)
			{
				toolStripMenuItem.ShortcutKeys = array[num];
			}
			num++;
			toolStripMenuItem.Click += method_98;
			miWearAfter.DropDownItems.Add(toolStripMenuItem);
			if (stringBuilder.Length > 0)
			{
				stringBuilder.Append('|');
			}
			stringBuilder.Append(value);
		}
		Class72.class19_0.method_185(stringBuilder.ToString());
	}

	private void method_98(object sender, EventArgs e)
	{
		string text = ((ToolStripMenuItem)sender).Text;
		foreach (ToolStripMenuItem dropDownItem in miWearAfter.DropDownItems)
		{
			if (dropDownItem.Text.Equals(text))
			{
				if (!dropDownItem.Checked)
				{
					dropDownItem.Checked = true;
					Class72.string_33 = text;
					try
					{
						if (Class72.formMain_0 != null)
						{
							Class72.formMain_0.BeginInvoke(new Delegate7(Class72.formMain_0.method_100), $"Заказано надевание комплекта ({text})");
						}
					}
					catch (InvalidOperationException)
					{
					}
					try
					{
						if (Class72.formMain_0 != null)
						{
							Class72.formMain_0.BeginInvoke(new Delegate20(Class72.formMain_0.method_110), new object[0]);
						}
					}
					catch (InvalidOperationException)
					{
					}
					continue;
				}
				dropDownItem.Checked = false;
				try
				{
					if (Class72.formMain_0 != null)
					{
						Class72.formMain_0.BeginInvoke(new Delegate7(Class72.formMain_0.method_100), $"Надевание комплекта '{text}' отменено");
					}
				}
				catch (InvalidOperationException)
				{
				}
				Class72.string_33 = string.Empty;
			}
			else
			{
				dropDownItem.Checked = false;
			}
		}
	}

	internal void method_99(ToolStripItem[] toolStripItem_0, string string_0, ToolStripItem[] toolStripItem_1)
	{
		dropdownPv.DropDownItems.Clear();
		dropdownPv.Text = ((toolStripItem_0.Length == 0) ? string.Empty : ("ПВ: " + toolStripItem_0.Length));
		if (toolStripItem_0.Length != 0)
		{
			dropdownPv.DropDownItems.AddRange(toolStripItem_0);
			dropdownPv.Enabled = true;
		}
		else
		{
			dropdownPv.Enabled = false;
		}
		dropdownTravm.DropDownItems.Clear();
		dropdownTravm.Text = string_0;
		if (toolStripItem_1.Length != 0)
		{
			dropdownTravm.DropDownItems.AddRange(toolStripItem_1);
			dropdownTravm.Enabled = true;
		}
		else
		{
			dropdownTravm.Enabled = false;
		}
	}

	internal void method_100(string string_0)
	{
		method_62(string_0);
	}

	internal void method_101(Class76 class76_0)
	{
		ContactsManager.smethod_8(treeContacts, class76_0);
	}

	internal void method_102(string string_0, string string_1)
	{
		if (!string_0.Equals(Class72.class19_0.method_30(), StringComparison.OrdinalIgnoreCase))
		{
			return;
		}
		int num = 0;
		int num2 = 0;
		uint num3 = Class0.smethod_0(string_1);
		if (num3 <= 2429118811u)
		{
			if (num3 <= 1228032671)
			{
				if (num3 <= 449568891)
				{
					if (num3 <= 360004320)
					{
						if (num3 != 47635349)
						{
							if (num3 != 63144885)
							{
								if (num3 == 360004320 && string_1 == "Превосходное Зелье Недосягаемости")
								{
									goto IL_063c;
								}
							}
							else if (string_1 == "Зелье Скорости")
							{
								num = 1;
							}
						}
						else if (string_1 == "Превосходное Зелье Гения")
						{
							goto IL_063c;
						}
					}
					else if (num3 != 396950090)
					{
						if (num3 != 446680559)
						{
							if (num3 == 449568891 && string_1 == "Зелье Жизни")
							{
								goto IL_063c;
							}
						}
						else if (string_1 == "Превосходное Зелье Ореола")
						{
							goto IL_063c;
						}
					}
					else if (string_1 == "Превосходное Зелье Ловких Ударов")
					{
						goto IL_063c;
					}
				}
				else if (num3 <= 1067905636)
				{
					if (num3 != 558645810)
					{
						if (num3 != 902080332)
						{
							if (num3 == 1067905636 && string_1 == "Превосходное Зелье Стойкости")
							{
								goto IL_063c;
							}
						}
						else if (string_1 == "Зелье Просветления")
						{
							num = 5;
						}
					}
					else if (string_1 == "Зелье Точного Попадания")
					{
						goto IL_063c;
					}
				}
				else if (num3 != 1173367137)
				{
					if (num3 != 1192497576)
					{
						if (num3 == 1228032671 && string_1 == "Превосходное Зелье Скорости")
						{
							num2 = 90;
						}
					}
					else if (string_1 == "Превосходное Зелье Мужества")
					{
						goto IL_063c;
					}
				}
				else if (string_1 == "Превосходное Зелье Человек-Гора")
				{
					goto IL_063c;
				}
			}
			else if (num3 <= 1837336682)
			{
				if (num3 <= 1601947396)
				{
					if (num3 != 1441811502)
					{
						if (num3 != 1546644912)
						{
							if (num3 == 1601947396 && string_1 == "Зелье Загрубелой Кожи")
							{
								goto IL_063c;
							}
						}
						else if (string_1 == "Зелье Медитации")
						{
							goto IL_064d;
						}
					}
					else if (string_1 == "Зелье Мужества")
					{
						goto IL_0586;
					}
				}
				else if (num3 != 1665782505)
				{
					if (num3 != 1680370730)
					{
						if (num3 == 1837336682 && string_1 == "Превосходное Зелье Точности")
						{
							goto IL_063c;
						}
					}
					else if (string_1 == "Зелье Невидимости")
					{
						goto IL_063c;
					}
				}
				else if (string_1 == "Зелье Боевой Славы")
				{
					goto IL_0586;
				}
			}
			else if (num3 <= 2175056014u)
			{
				if (num3 != 1898187131)
				{
					if (num3 != 2026751319)
					{
						if (num3 == 2175056014u && string_1 == "Зелье Секрет Волшебника")
						{
							goto IL_0586;
						}
					}
					else if (string_1 == "Зелье Сокрушительных Ударов")
					{
						goto IL_063c;
					}
				}
				else if (string_1 == "Зелье Соколиный Взор")
				{
					goto IL_063c;
				}
			}
			else if (num3 != 2355351133u)
			{
				if (num3 != 2384603612u)
				{
					if (num3 == 2429118811u && string_1 == "Превосходное Зелье Сильной Спины")
					{
						goto IL_052d;
					}
				}
				else if (string_1 == "Превосходное Зелье Сокрушения")
				{
					goto IL_063c;
				}
			}
			else if (string_1 == "Превосходное Зелье Волшебства")
			{
				goto IL_063c;
			}
		}
		else if (num3 <= 3500561370u)
		{
			if (num3 <= 3148254162u)
			{
				if (num3 <= 2708348024u)
				{
					if (num3 != 2557041854u)
					{
						if (num3 != 2565130601u)
						{
							if (num3 == 2708348024u && string_1 == "Зелье Иммунитета")
							{
								num = 10;
							}
						}
						else if (string_1 == "Превосходное Зелье Удачи")
						{
							goto IL_063c;
						}
					}
					else if (string_1 == "Превосходное Зелье Медитации")
					{
						num = 6;
					}
				}
				else if (num3 != 2891769043u)
				{
					if (num3 != 2907296056u)
					{
						if (num3 == 3148254162u && string_1 == "Превосходное Зелье Силы")
						{
							goto IL_063c;
						}
					}
					else if (string_1 == "Зелье Ловких Ударов")
					{
						goto IL_0586;
					}
				}
				else if (string_1 == "Зелье Удачи")
				{
					goto IL_063c;
				}
			}
			else if (num3 <= 3198464074u)
			{
				if (num3 != 3152929863u)
				{
					if (num3 != 3158440362u)
					{
						if (num3 == 3198464074u && string_1 == "Секретное Зелье")
						{
							goto IL_0586;
						}
					}
					else if (string_1 == "Зелье Недосягаемости")
					{
						goto IL_063c;
					}
				}
				else if (string_1 == "Превосходное Зелье Колкости")
				{
					goto IL_063c;
				}
			}
			else if (num3 != 3255221338u)
			{
				if (num3 != 3486881711u)
				{
					if (num3 == 3500561370u && string_1 == "Зелье Стойкости")
					{
						goto IL_063c;
					}
				}
				else if (string_1 == "Зелье Огненного Ореола")
				{
					goto IL_063c;
				}
			}
			else if (string_1 == "Превосходное Зелье Панциря")
			{
				goto IL_063c;
			}
		}
		else if (num3 <= 3940853091u)
		{
			if (num3 <= 3727919101u)
			{
				if (num3 != 3519672240u)
				{
					if (num3 != 3635257885u)
					{
						if (num3 == 3727919101u && string_1 == "Зелье Сильной Спины")
						{
							goto IL_052d;
						}
					}
					else if (string_1 == "Зелье Колкости")
					{
						goto IL_0586;
					}
				}
				else if (string_1 == "Зелье Панциря")
				{
					goto IL_0586;
				}
			}
			else if (num3 != 3843666607u)
			{
				if (num3 != 3935753758u)
				{
					if (num3 == 3940853091u && string_1 == "Зелье Человек-гора")
					{
						goto IL_0586;
					}
				}
				else if (string_1 == "Зелье Подвижности")
				{
					goto IL_063c;
				}
			}
			else if (string_1 == "Зелье Гения")
			{
				goto IL_063c;
			}
		}
		else if (num3 <= 4096147657u)
		{
			if (num3 != 4039845384u)
			{
				if (num3 != 4066425915u)
				{
					if (num3 == 4096147657u && string_1 == "Превосходное Зелье Жизни")
					{
						goto IL_063c;
					}
				}
				else if (string_1 == "Превосходное Зелье Ловкости")
				{
					goto IL_063c;
				}
			}
			else if (string_1 == "Зелье Силы")
			{
				goto IL_063c;
			}
		}
		else if (num3 != 4118987183u)
		{
			if (num3 != 4123533089u)
			{
				if (num3 == 4208435379u && string_1 == "Превосходное Зелье Боевой Славы")
				{
					goto IL_063c;
				}
			}
			else if (string_1 == "Зелье Ловкости")
			{
				goto IL_063c;
			}
		}
		else if (string_1 == "Зелье Метаболизма")
		{
			goto IL_064d;
		}
		goto IL_064f;
		IL_052d:
		num = 20;
		goto IL_064f;
		IL_063c:
		num = 3;
		goto IL_064f;
		IL_064d:
		num = 4;
		goto IL_064f;
		IL_0586:
		num = 2;
		goto IL_064f;
		IL_064f:
		if (num2 == 0)
		{
			num2 = num * 60;
		}
		if (num2 != 0)
		{
			Class71.smethod_1(new Class69
			{
				string_0 = $"Действует {string_1}",
				dateTime_0 = DateTime.Now.AddMinutes(num2)
			});
			method_162();
		}
	}

	internal void method_103()
	{
		buttonNavigator.Checked = false;
		Class72.smethod_37(bool_54: false);
		Class72.bool_44 = false;
	}

	internal void method_104()
	{
		if (base.InvokeRequired)
		{
			BeginInvoke(new MethodInvoker(method_104));
		}
		else
		{
			smethod_62();
		}
	}

	internal void method_105(string string_0)
	{
		Class97 @class = new Class97();
		@class.formMain_0 = this;
		@class.string_0 = string_0;
		if (base.InvokeRequired)
		{
			BeginInvoke(new MethodInvoker(@class.method_0));
			return;
		}
		try
		{
			readerWriterLock_3.AcquireWriterLock(5000);
			try
			{
				notifyIcon_0.ShowBalloonTip(10000, Class72.class55_0.method_4(), @class.string_0, ToolTipIcon.None);
			}
			finally
			{
				readerWriterLock_3.ReleaseWriterLock();
			}
		}
		catch (ApplicationException)
		{
		}
	}

	internal static string smethod_70(string string_0, double double_0, int int_1, double double_1, double double_2, int int_2, double double_3)
	{
		StringBuilder stringBuilder = new StringBuilder("<FONT class=hpfont>: ");
		stringBuilder.Append("[<font color=#bb0000>");
		stringBuilder.AppendFormat("<b>{0}</b>", (int)double_0);
		stringBuilder.Append('/');
		stringBuilder.AppendFormat("<b>{0}</b>", int_1);
		int num = (int)Math.Round(((double)int_1 - double_0) * double_1 / (double)int_1);
		if (num > 0)
		{
			stringBuilder.AppendFormat(" (<b>{0:00}:{1:00}:{2:00}</b>)", num / 3600, num / 60 % 60, num % 60);
		}
		stringBuilder.Append("</font>]");
		stringBuilder.Append(" | ");
		stringBuilder.Append("[<font color=#336699>");
		stringBuilder.AppendFormat("<b>{0}</b>", (int)double_2);
		stringBuilder.Append('/');
		stringBuilder.AppendFormat("<b>{0}</b>", int_2);
		num = (int)Math.Round(((double)int_2 - double_2) * double_3 / (double)int_2);
		if (num > 0)
		{
			stringBuilder.AppendFormat(" (<b>{0:00}:{1:00}:{2:00}</b>)", num / 3600, num / 60 % 60, num % 60);
		}
		stringBuilder.Append("</font>]</font>");
		return stringBuilder.ToString();
	}

	private HtmlWindow method_106(string string_0)
	{
		try
		{
			return browserGame?.Document?.Window?.Frames?[string_0];
		}
		catch (ArgumentException)
		{
			return null;
		}
		catch (Exception)
		{
			return null;
		}
	}

	private void method_107(string string_0, string string_1)
	{
		HtmlWindow htmlWindow = method_106(string_0);
		if (htmlWindow != null)
		{
			try
			{
				htmlWindow.Navigate(string_1);
			}
			catch (Exception)
			{
			}
		}
	}

	internal void method_108()
	{
		method_107("ch_list", "http://www.neverlands.ru/ch.php?lo=1");
	}

	internal void method_109(string string_0)
	{
		method_107("main_top", string_0);
	}

	internal void method_110()
	{
		method_109("http://www.neverlands.ru/main.php");
	}

	private void method_111(string string_0)
	{
		if (string.IsNullOrEmpty(string_0))
		{
			return;
		}
		try
		{
			HtmlElement htmlElement = method_106("ch_buttons")?.Document?.GetElementById("text");
			if (!(htmlElement == null))
			{
				htmlElement.SetAttribute("value", string_0);
				htmlElement.Focus();
			}
		}
		catch
		{
		}
	}

	private void method_112(string string_0)
	{
		if (string.IsNullOrEmpty(string_0))
		{
			return;
		}
		try
		{
			HtmlElement htmlElement = method_106("ch_buttons")?.Document?.GetElementById("text");
			string attribute = htmlElement.GetAttribute("value");
			if (!(htmlElement == null) && !attribute.StartsWith(string_0, StringComparison.OrdinalIgnoreCase))
			{
				htmlElement.SetAttribute("value", string_0 + attribute);
				htmlElement.Focus();
			}
		}
		catch
		{
		}
	}

	internal void method_113(string string_0)
	{
		HtmlWindow htmlWindow = method_106("ch_buttons");
		if (string.IsNullOrEmpty(string_0))
		{
			return;
		}
		try
		{
			HtmlElement htmlElement = htmlWindow?.Document?.GetElementById("text");
			HtmlElement htmlElement2 = htmlWindow?.Document?.GetElementById("butinp");
			if (!(htmlElement == null) && !(htmlElement2 == null))
			{
				htmlElement.SetAttribute("value", string_0);
				htmlElement2.InvokeMember("onClick");
				htmlElement.SetAttribute("value", string.Empty);
			}
		}
		catch
		{
		}
	}

	private void method_114(string string_0)
	{
		HtmlWindow htmlWindow = method_106("chmain");
		if (string.IsNullOrEmpty(string_0) || !Class72.bool_47)
		{
			return;
		}
		try
		{
			HtmlElement htmlElement = htmlWindow?.Document?.GetElementById("msg");
			if (htmlElement == null)
			{
				return;
			}
			htmlElement.InnerHtml += string_0;
			htmlWindow.ScrollTo(new Point(0, 65535));
		}
		catch
		{
		}
		string_0 = string_0.Replace("<BR>", string.Empty);
		Class8.smethod_6(string_0);
	}

	private string method_115()
	{
		try
		{
			if (browserGame.ReadyState == WebBrowserReadyState.Uninitialized)
			{
				return null;
			}
		}
		catch
		{
			return null;
		}
		HtmlWindow htmlWindow = method_106("chmain");
		try
		{
			return htmlWindow?.Document?.GetElementById("msg")?.InnerHtml;
		}
		catch
		{
		}
		return null;
	}

	private void method_116()
	{
		method_128();
		ToolStripManager.Renderer = new Office2007Render();
	}

	private void method_117()
	{
		method_83(Class68.string_0 + " начал работу");
		method_119();
		Text = Class72.class55_0.method_6();
		foreach (Class74 item in Class84.list_0)
		{
			ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem
			{
				Name = Guid.NewGuid().ToString(),
				Size = new Size(207, 22),
				Tag = item.string_1,
				Text = item.string_0,
				ImageScaling = ToolStripItemImageScaling.None,
				ToolTipText = item.string_1
			};
			if (item.image_0 != null)
			{
				toolStripMenuItem.Image = item.image_0;
			}
			toolStripMenuItem.Click += method_24;
			menuitemTabs.DropDownItems.Add(toolStripMenuItem);
		}
		if (!string.IsNullOrEmpty(Class72.class19_0.method_184()))
		{
			string[] string_ = Class72.class19_0.method_184().Split('|');
			method_97(string_);
		}
		method_6();
		method_16();
		method_120();
	}

	private void method_118()
	{
		if (tabControlRight != null)
		{
			Class72.class19_0.method_119((byte)tabControlRight.SelectedIndex);
		}
		Class72.class19_0.tsplitter_0.Collapsed = collapsibleSplitter.IsCollapsed;
		Class72.class19_0.tsplitter_0.Width = panelRight.Width;
	}

	private void method_119()
	{
		method_60(Class72.class19_0.bool_48 ? ((Enum4)1) : ((Enum4)0));
		Class72.smethod_137(bool_54: false);
		buttonAutoRefresh.Checked = false;
		buttonAutoAnswer.Checked = Class72.class19_0.method_74();
		buttonDoTexLog.Checked = Class72.class19_0.method_116();
		buttonAutoFish.Checked = Class72.class19_0.method_100();
		if (Class72.class19_0.method_100())
		{
			Class72.smethod_33(bool_54: true);
			Class72.smethod_35(bool_54: true);
		}
		buttonAutoSkin.Checked = Class72.class19_0.method_102();
		if (Class72.class19_0.method_102())
		{
			Class72.smethod_33(bool_54: true);
			Class72.smethod_35(bool_54: true);
			Class72.smethod_51(bool_54: true);
			Class72.smethod_61(bool_54: true);
			Class72.smethod_53(0);
			Class72.smethod_55(bool_54: true);
			Class72.smethod_57(bool_54: false);
		}
		buttonSilence.Checked = !Class72.class19_0.tsound_0.Enabled;
		if (Class72.class19_0.method_118() < tabControlRight.TabCount)
		{
			tabControlRight.SelectedIndex = Class72.class19_0.method_118();
		}
		method_135();
		panelRight.Width = Class72.class19_0.tsplitter_0.Width;
		if (Class72.class19_0.tsplitter_0.Collapsed)
		{
			collapsibleSplitter.ToggleState();
		}
		method_159();
		method_88(Class72.class19_0.method_58());
		Class72.smethod_27(0);
		Class72.smethod_29(DateTime.MinValue);
		tsContactTrace.Checked = Class72.class19_0.method_142();
		ContactsManager.Init(treeContacts);
		Class40.smethod_0();
		Class72.smethod_111(DateTime.Now);
	}

	private void method_120()
	{
		Class72.dateTime_11 = DateTime.Now.AddSeconds(30.0);
		Class72.smethod_49(method_115());
		method_118();
		Class72.smethod_15(DateTime.Now);
		Class72.smethod_5(DateTime.Now);
		Class72.dateTime_9 = DateTime.Now;
		method_141();
	}

	private bool method_121()
	{
		if (Class72.smethod_10())
		{
			FormPromptExit formPromptExit = new FormPromptExit();
			try
			{
				if (formPromptExit.ShowDialog() != DialogResult.OK)
				{
					return false;
				}
				Class72.class19_0.method_41(!formPromptExit.method_0());
			}
			finally
			{
				((IDisposable)formPromptExit).Dispose();
			}
		}
		Class40.smethod_1();
		smethod_39();
		method_129();
		method_118();
		method_158();
		Class77.smethod_16();
		Class77.smethod_33();
		Class72.class19_0.method_20();
		return true;
	}

	internal void method_122(string string_0)
	{
		if (string.IsNullOrEmpty(string_0))
		{
			MessageBox.Show("Местоположение неизвестно." + Environment.NewLine + "Сначала посмотрите на карту!", Class72.class55_0.method_4(), MessageBoxButtons.OK, MessageBoxIcon.Hand);
			return;
		}
		if (buttonNavigator.Checked)
		{
			buttonNavigator.Checked = false;
			Class72.smethod_37(bool_54: false);
			Class72.bool_44 = false;
			try
			{
				if (Class72.formMain_0 != null)
				{
					Class72.formMain_0.BeginInvoke(new Delegate20(Class72.formMain_0.method_110), new object[0]);
				}
				return;
			}
			catch (InvalidOperationException)
			{
				return;
			}
		}
		FormNavigator formNavigator = new FormNavigator(string_0, null, null, null);
		try
		{
			if (formNavigator.ShowDialog() != DialogResult.OK)
			{
				return;
			}
			buttonNavigator.Checked = true;
			try
			{
				if (Class72.formMain_0 != null)
				{
					Class72.formMain_0.BeginInvoke(new Delegate20(Class72.formMain_0.method_110), new object[0]);
				}
			}
			catch (InvalidOperationException)
			{
			}
		}
		finally
		{
			((IDisposable)formNavigator).Dispose();
		}
	}

	internal void method_123(string string_0)
	{
		Class98 @class = new Class98();
		@class.formMain_0 = this;
		@class.string_0 = string_0;
		if (base.InvokeRequired)
		{
			BeginInvoke(new MethodInvoker(@class.method_0));
		}
		else
		{
			method_124(@class.string_0);
		}
	}

	internal void method_124(string string_0)
	{
		buttonNavigator.Checked = true;
		Class72.smethod_37(bool_54: true);
		Class72.smethod_41(string_0);
		MapPath mapPath = new MapPath(Class72.class19_0.method_58(), new string[1] { string_0 });
		if (!mapPath.PathExists)
		{
			buttonNavigator.Checked = false;
			Class72.smethod_37(bool_54: false);
			Class72.formMain_0.method_63("Невозможно построить маршрут от <b>" + Class72.class19_0.method_58() + "</b> до <b>" + string_0 + "</b>. Навигатор отключен.");
			Class72.formMain_0.BeginInvoke(new Delegate20(Class72.formMain_0.method_110), new object[0]);
		}
		Class72.smethod_47(mapPath);
		try
		{
			if (Class72.formMain_0 != null)
			{
				Class72.formMain_0.BeginInvoke(new Delegate20(Class72.formMain_0.method_110), new object[0]);
			}
		}
		catch (InvalidOperationException)
		{
		}
	}

	internal static string smethod_71()
	{
		int[] array = new int[8] { 0, 0, -1, 1, -1, 1, -1, 1 };
		int[] array2 = new int[8] { -1, 1, 0, 0, -1, -1, 1, 1 };
		Hashtable hashtable = new Hashtable();
		StringCollection stringCollection = new StringCollection();
		hashtable.Clear();
		hashtable.Add(Class72.class19_0.method_58(), 0);
		stringCollection.Clear();
		stringCollection.Add(Class72.class19_0.method_58());
		int num = 0;
		StringCollection stringCollection2 = new StringCollection();
		while (stringCollection.Count > 0)
		{
			StringEnumerator enumerator = stringCollection.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					string current = enumerator.Current;
					if (!Class77.smethod_4().TryGetValue(current, out var _))
					{
						continue;
					}
					for (int i = 0; i < 8; i++)
					{
						string text = Class77.smethod_27(current, array[i], array2[i]);
						if (!string.IsNullOrEmpty(text) && !hashtable.ContainsKey(text))
						{
							hashtable.Add(text, num + 1);
							stringCollection2.Add(text);
							if (!(DateTime.Now.Subtract(Class77.smethod_6()[text].Visited).TotalDays < 1.0))
							{
								return text;
							}
						}
					}
				}
			}
			finally
			{
				if (enumerator is IDisposable disposable)
				{
					disposable.Dispose();
				}
			}
			stringCollection.Clear();
			enumerator = stringCollection2.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					string current2 = enumerator.Current;
					stringCollection.Add(current2);
				}
			}
			finally
			{
				if (enumerator is IDisposable disposable2)
				{
					disposable2.Dispose();
				}
			}
			stringCollection2.Clear();
			num++;
		}
		return null;
	}

	internal void method_125(string string_0, string string_1)
	{
		buttonNavigator.Checked = true;
		Class72.bool_44 = true;
		Class72.class78_0 = new Class78(string_0, string_1);
		Class80 @class = new Class80(string_0, string_1);
		if (!@class.method_0())
		{
			buttonNavigator.Checked = false;
			Class72.bool_44 = false;
		}
		Class72.class80_0 = @class;
		Class72.formMain_0.BeginInvoke(new Delegate20(Class72.formMain_0.method_110), new object[0]);
	}

	private void method_126()
	{
		FormSettingsGeneral formSettingsGeneral = new FormSettingsGeneral();
		try
		{
			if (formSettingsGeneral.ShowDialog() != DialogResult.OK)
			{
				return;
			}
			Class72.smethod_105(null);
			buttonAutoAnswer.Checked = Class72.class19_0.method_74();
			buttonSilence.Checked = !Class72.class19_0.tsound_0.Enabled;
			Text = Class72.class55_0.method_6();
			try
			{
				if (Class72.formMain_0 != null)
				{
					Class72.formMain_0.BeginInvoke(new Delegate20(Class72.formMain_0.method_110), new object[0]);
				}
			}
			catch (InvalidOperationException)
			{
			}
		}
		finally
		{
			((IDisposable)formSettingsGeneral).Dispose();
		}
	}

	private void method_127()
	{
		FormSettingsAb formSettingsAb = new FormSettingsAb(Class72.class19_0.list_3);
		try
		{
			if (formSettingsAb.ShowDialog() != DialogResult.OK)
			{
				return;
			}
			try
			{
				method_60(Class72.class19_0.bool_48 ? ((Enum4)1) : ((Enum4)0));
				if (Class72.formMain_0 != null)
				{
					Class72.formMain_0.BeginInvoke(new Delegate20(Class72.formMain_0.method_110), new object[0]);
				}
			}
			catch (InvalidOperationException)
			{
			}
		}
		finally
		{
			((IDisposable)formSettingsAb).Dispose();
		}
	}

	private void method_128()
	{
		if (Class72.class19_0.struct14_0.int_2 > 0 && Class72.class19_0.struct14_0.int_3 > 0)
		{
			base.Left = Class72.class19_0.struct14_0.int_0;
			base.Top = Class72.class19_0.struct14_0.int_1;
			base.Width = Class72.class19_0.struct14_0.int_2;
			base.Height = Class72.class19_0.struct14_0.int_3;
		}
		else
		{
			base.Left = 15;
			base.Top = 15;
			base.Width = Screen.PrimaryScreen.WorkingArea.Width - 30;
			base.Height = Screen.PrimaryScreen.WorkingArea.Height - 30;
		}
		base.WindowState = Class72.class19_0.struct14_0.formWindowState_0;
		if (base.WindowState != FormWindowState.Minimized)
		{
			formWindowState_0 = base.WindowState;
		}
		base.Resize += FormMain_Resize;
	}

	private void method_129()
	{
		if (base.WindowState == FormWindowState.Normal)
		{
			Class72.class19_0.struct14_0.int_0 = base.Left;
			Class72.class19_0.struct14_0.int_1 = base.Top;
			Class72.class19_0.struct14_0.int_2 = base.Width;
			Class72.class19_0.struct14_0.int_3 = base.Height;
		}
		Class72.class19_0.struct14_0.formWindowState_0 = base.WindowState;
	}

	private void method_130()
	{
		if (base.WindowState != formWindowState_0 && base.WindowState != FormWindowState.Minimized)
		{
			formWindowState_0 = base.WindowState;
		}
		if (base.WindowState == FormWindowState.Minimized && Class72.class19_0.method_122())
		{
			Hide();
			method_165();
		}
		else
		{
			method_129();
		}
	}

	internal void method_131(long long_0)
	{
		Class99 @class = new Class99();
		@class.formMain_0 = this;
		@class.long_0 = long_0;
		if (base.InvokeRequired)
		{
			BeginInvoke(new MethodInvoker(@class.method_0));
			return;
		}
		try
		{
			readerWriterLock_0.AcquireWriterLock(5000);
			try
			{
				Class72.class19_0.class17_0.long_1 += @class.long_0;
			}
			finally
			{
				readerWriterLock_0.ReleaseWriterLock();
			}
		}
		catch (ApplicationException)
		{
		}
		menuitemStatItem0.Text = "Использовано трафика: " + smethod_72(Class72.class19_0.class17_0.long_1);
		method_134();
	}

	internal void method_132(int int_1)
	{
		Class100 @class = new Class100();
		@class.formMain_0 = this;
		@class.int_0 = int_1;
		if (base.InvokeRequired)
		{
			BeginInvoke(new MethodInvoker(@class.method_0));
			return;
		}
		try
		{
			readerWriterLock_0.AcquireWriterLock(5000);
			try
			{
				Class72.class19_0.class17_0.long_2 += @class.int_0;
			}
			finally
			{
				readerWriterLock_0.ReleaseWriterLock();
			}
		}
		catch (ApplicationException)
		{
		}
		menuitemStatItem1.Text = "Сэкономлено трафика: " + smethod_72(Class72.class19_0.class17_0.long_2);
		method_134();
	}

	private static string smethod_72(long long_0)
	{
		string result = long_0.ToString(Class72.cultureInfo_0) + " байт";
		if (long_0 >= 1024L)
		{
			double num = (double)long_0 / 1024.0;
			result = num.ToString("0.0", Class72.cultureInfo_0) + " Кбайт";
			if (num >= 1024.0)
			{
				result = (num / 1024.0).ToString("0.00", Class72.cultureInfo_0) + " Мбайт";
			}
		}
		return result;
	}

	private void method_133(string string_0)
	{
		if (byte.TryParse(string_0, out var result))
		{
			Class72.class19_0.class17_0.int_1 = result;
			Class72.class19_0.method_20();
			method_134();
		}
	}

	private static void smethod_73()
	{
		try
		{
			readerWriterLock_0.AcquireWriterLock(5000);
			try
			{
				Class72.class19_0.class17_0.long_0 = DateTime.Now.Ticks;
				Class72.class19_0.class17_0.int_0 = DateTime.Now.DayOfYear;
				Class72.class19_0.class17_0.long_1 = 0L;
				Class72.class19_0.class17_0.long_2 = 0L;
				Class72.class19_0.class17_0.string_0 = string.Empty;
				Class72.class19_0.class17_0.list_0.Clear();
				Class72.class19_0.class17_0.long_3 = 0L;
				Class72.class19_0.class17_0.int_2 = 0;
				Class72.class19_0.class17_0.int_3 = 0;
			}
			finally
			{
				readerWriterLock_0.ReleaseWriterLock();
			}
		}
		catch (ApplicationException)
		{
		}
	}

	private void method_134()
	{
		switch (Class72.class19_0.class17_0.int_1)
		{
		case 0:
			dropdownCurrentStat.Text = menuitemStatItem0.Text;
			break;
		case 1:
			dropdownCurrentStat.Text = menuitemStatItem1.Text;
			break;
		case 2:
			dropdownCurrentStat.Text = menuitemStatItem2.Text;
			break;
		case 3:
			dropdownCurrentStat.Text = menuitemStatItem3.Text;
			break;
		case 4:
			dropdownCurrentStat.Text = menuitemStatItem4.Text;
			break;
		}
		if (DateTime.Now.DayOfYear != Class72.class19_0.class17_0.int_0)
		{
			if (Class72.class19_0.class17_0.bool_1)
			{
				method_140();
			}
			if (Class72.class19_0.class17_0.bool_0)
			{
				smethod_73();
				method_135();
			}
		}
	}

	private void method_135()
	{
		method_131(0L);
		method_132(0);
		method_136();
		method_137();
		method_138();
	}

	private void method_136()
	{
		menuitemStatItem2.Text = $"Получено опыта: {Class72.class19_0.class17_0.long_3}";
		method_134();
	}

	private void method_137()
	{
		menuitemStatItem3.Text = $"Выбито с ботов: {Class72.class19_0.class17_0.int_2} NV";
		method_134();
	}

	private void method_138()
	{
		menuitemStatItem4.Text = $"Заработано на рыбалке: {Class72.class19_0.class17_0.int_3} NV";
		method_134();
	}

	private void method_139()
	{
		StringBuilder stringBuilder = new StringBuilder("Статистика за ");
		stringBuilder.Append(Class4.smethod_0(Class72.class19_0.class17_0.long_0));
		stringBuilder.AppendLine(":");
		stringBuilder.AppendLine(menuitemStatItem0.Text);
		stringBuilder.AppendLine(menuitemStatItem1.Text);
		stringBuilder.AppendLine(menuitemStatItem2.Text);
		stringBuilder.AppendLine(menuitemStatItem3.Text);
		stringBuilder.AppendLine(menuitemStatItem4.Text);
		if (Class72.class19_0.class17_0.list_0.Count == 0)
		{
			stringBuilder.Append("Вещей не найдено");
		}
		else
		{
			stringBuilder.AppendLine("Найдены вещи:");
			for (int i = 0; i < Class72.class19_0.class17_0.list_0.Count; i++)
			{
				stringBuilder.Append(Class72.class19_0.class17_0.list_0[i].string_0);
				if (Class72.class19_0.class17_0.list_0[i].int_0 > 1)
				{
					stringBuilder.AppendFormat(" ({0} шт.)", Class72.class19_0.class17_0.list_0[i].int_0);
				}
				stringBuilder.AppendLine();
			}
		}
		FormStatEdit formStatEdit = new FormStatEdit(stringBuilder.ToString());
		try
		{
			if (formStatEdit.ShowDialog() == DialogResult.OK)
			{
				smethod_73();
				method_135();
			}
		}
		finally
		{
			((IDisposable)formStatEdit).Dispose();
		}
	}

	private void method_140()
	{
		string text = Class72.class19_0.method_30();
		char[] invalidFileNameChars = Path.GetInvalidFileNameChars();
		foreach (char c in invalidFileNameChars)
		{
			text = text.Replace(c.ToString(), string.Empty);
		}
		string text2 = Path.Combine(Application.StartupPath, Path.Combine(Class68.string_13, text));
		if (!Directory.Exists(text2))
		{
			Directory.CreateDirectory(text2);
		}
		DateTime dateTime = DateTime.Now.AddDays(-1.0);
		string newLine = Environment.NewLine;
		string path = string.Format(CultureInfo.InvariantCulture, "{0:00}-{1:00}-{2:00}.txt", new object[3] { dateTime.Year, dateTime.Month, dateTime.Day });
		text2 = Path.Combine(text2, path);
		string text3 = menuitemStatItem2.Text + newLine + menuitemStatItem3.Text + newLine + menuitemStatItem4.Text + newLine;
		if (Class72.class19_0.class17_0.list_0.Count == 0)
		{
			text3 = text3 + "Вещей не найдено" + newLine;
		}
		else
		{
			text3 = text3 + "Найдены вещи:" + newLine;
			for (int j = 0; j < Class72.class19_0.class17_0.list_0.Count; j++)
			{
				text3 += Class72.class19_0.class17_0.list_0[j].string_0;
				if (Class72.class19_0.class17_0.list_0[j].int_0 > 1)
				{
					text3 += $" ({Class72.class19_0.class17_0.list_0[j].int_0} шт.)";
				}
				text3 += newLine;
			}
		}
		TextWriter textWriter = null;
		try
		{
			textWriter = new StreamWriter(text2, append: false, Class91.encoding_0, 1024);
			textWriter.Write(text3);
		}
		finally
		{
			textWriter?.Close();
		}
	}

	private void method_141()
	{
		if (tabControlLeft == null || tabControlLeft.TabPages.Count == 0)
		{
			return;
		}
		TabPage tabPage = tabControlLeft.TabPages[0];
		tabPage.Text = Class72.class19_0.method_30();
		Class42 tag;
		if (tabPage.Tag == null)
		{
			Class42 @class = new Class42();
			@class.method_1((Enum2)0);
			@class.method_5(browserGame);
			tag = @class;
			tabPage.Tag = tag;
		}
		browserGame.method_3(method_25);
		panelGame.Controls.Remove(browserGame);
		browserGame.Dispose();
		browserGame = null;
		Class32.smethod_2();
		browserGame = new ExtendedWebBrowser
		{
			Dock = DockStyle.Fill,
			Name = "browserGame",
			ScriptErrorsSuppressed = true,
			TabIndex = 0,
			ObjectForScripting = new ScriptManager()
		};
		browserGame.method_2(method_25);
		panelGame.Controls.Add(browserGame);
		tag = (Class42)tabPage.Tag;
		tag.method_5(browserGame);
		tabPage.Tag = tag;
		buttonGameScreen.Tag = browserGame;
		if (browserGame != null && !browserGame.IsDisposed)
		{
			browserGame.Navigate(Class39.smethod_42());
			while (browserGame != null && !browserGame.IsDisposed && browserGame.ReadyState != WebBrowserReadyState.Complete)
			{
				Application.DoEvents();
			}
		}
	}

	internal void method_142(string string_0)
	{
		if (!string.IsNullOrEmpty(string_0))
		{
			method_143(string_0, bool_0: false);
		}
	}

	private void method_143(string string_0, bool bool_0)
	{
		if (!string_0.Equals(Class39.smethod_40(), StringComparison.OrdinalIgnoreCase) && !string_0.StartsWith(Class39.smethod_41(), StringComparison.OrdinalIgnoreCase))
		{
			if (string_0.StartsWith(Class39.smethod_39(), StringComparison.OrdinalIgnoreCase))
			{
				method_144((Enum2)1, string_0, bool_0);
			}
			else if (string_0.StartsWith(Class39.smethod_45(), StringComparison.OrdinalIgnoreCase))
			{
				method_144((Enum2)2, string_0, bool_0);
			}
			else if (string_0.StartsWith(Class39.smethod_46(), StringComparison.OrdinalIgnoreCase))
			{
				method_144((Enum2)3, string_0, bool_0);
			}
			else if (string_0.StartsWith(Class39.smethod_44(), StringComparison.OrdinalIgnoreCase))
			{
				method_144((Enum2)4, string_0, bool_0);
			}
			else if (string_0.StartsWith(Class39.smethod_38(), StringComparison.OrdinalIgnoreCase))
			{
				method_144((Enum2)5, string_0, bool_0);
			}
			else if (string_0.StartsWith("http://www.neverlands.ru/ch.php?lo=1&r=", StringComparison.OrdinalIgnoreCase))
			{
				method_144((Enum2)6, string_0, bool_0);
			}
			else if (string_0.Equals(Class39.smethod_43(), StringComparison.OrdinalIgnoreCase))
			{
				method_144((Enum2)200, string_0, bool_0);
			}
			else if (string_0.Equals(Class39.smethod_47(), StringComparison.OrdinalIgnoreCase))
			{
				method_144((Enum2)7, string_0, bool_0);
			}
			else
			{
				method_144((Enum2)100, string_0, bool_0);
			}
		}
	}

	private void method_144(Enum2 enum2_0, string string_0, bool bool_0)
	{
		if (!string.IsNullOrEmpty(string_0))
		{
			for (int i = 1; i < tabControlLeft.TabPages.Count; i++)
			{
				if (string_0.Equals(method_147(i), StringComparison.OrdinalIgnoreCase))
				{
					if (!bool_0)
					{
						tabControlLeft.SelectedIndex = i;
					}
					return;
				}
			}
		}
		Class42 @class = new Class42();
		@class.method_1(enum2_0);
		@class.method_9(string_0);
		@class.method_13(string_0);
		@class.method_11(bool_0);
		Class42 class2 = @class;
		TabPage tabPage = new TabPage();
		ExtendedWebBrowser extendedWebBrowser = null;
		TextBox textBox = null;
		if (class2.method_0() != (Enum2)200)
		{
			extendedWebBrowser = new ExtendedWebBrowser
			{
				Dock = DockStyle.Fill,
				ScriptErrorsSuppressed = true,
				ObjectForScripting = new ScriptManager()
			};
			extendedWebBrowser.method_2(method_25);
			class2.method_5(extendedWebBrowser);
		}
		else
		{
			textBox = new TextBox
			{
				BorderStyle = BorderStyle.None,
				Dock = DockStyle.Fill,
				Font = new Font("Courier New", 9f, FontStyle.Regular, GraphicsUnit.Point, 204),
				Multiline = true,
				ScrollBars = ScrollBars.Both
			};
			textBox.Leave += _003C_003Ec._003C_003E9.method_0;
			textBox.Text = Class72.class19_0.method_120();
			textBox.SelectionStart = textBox.Text.Length;
			textBox.SelectionLength = 1;
			class2.method_7(textBox);
		}
		Panel panel = new Panel();
		if (extendedWebBrowser != null)
		{
			panel.Controls.Add(extendedWebBrowser);
		}
		else
		{
			panel.Controls.Add(textBox);
		}
		panel.Dock = DockStyle.Fill;
		panel.Location = new Point(3, 28);
		panel.Name = Guid.NewGuid().ToString();
		panel.Padding = new Padding(0, 3, 0, 0);
		panel.Size = new Size(666, 461);
		ToolStripButton toolStripButton = null;
		if (class2.method_0() == (Enum2)1 || class2.method_0() == (Enum2)5 || class2.method_0() == (Enum2)100)
		{
			toolStripButton = new ToolStripButton
			{
				Image = Class39.smethod_10(),
				ImageTransparentColor = Color.Magenta,
				Name = Guid.NewGuid().ToString(),
				Size = new Size(58, 22),
				Text = "Назад",
				ToolTipText = "Возврат на предыдущую страницу",
				Tag = extendedWebBrowser
			};
			toolStripButton.Click += smethod_48;
		}
		ToolStripButton toolStripButton2 = null;
		if (class2.method_0() != (Enum2)200 && class2.method_0() != (Enum2)7)
		{
			toolStripButton2 = new ToolStripButton
			{
				Image = Class39.smethod_30(),
				ImageTransparentColor = Color.Magenta,
				Name = Guid.NewGuid().ToString(),
				Size = new Size(77, 22),
				Text = "Обновить",
				ToolTipText = "Обновление текущей страницы",
				Tag = extendedWebBrowser
			};
			toolStripButton2.Click += smethod_49;
		}
		ToolStripButton toolStripButton3 = null;
		if (class2.method_0() == (Enum2)7)
		{
			toolStripButton3 = new ToolStripButton
			{
				Image = Class39.smethod_30(),
				ImageTransparentColor = Color.Magenta,
				Name = Guid.NewGuid().ToString(),
				Size = new Size(77, 22),
				Text = "Перечитать",
				ToolTipText = "Обновление сегодняшнего чата",
				Tag = extendedWebBrowser
			};
			toolStripButton3.Click += method_26;
		}
		ToolStripButton toolStripButton4 = new ToolStripButton
		{
			Image = Class39.smethod_13(),
			ImageTransparentColor = Color.Magenta,
			Name = Guid.NewGuid().ToString(),
			Size = new Size(71, 22),
			Text = "Закрыть",
			ToolTipText = "Закрытие этой закладки",
			Tag = tabPage
		};
		toolStripButton4.Click += method_27;
		ToolStripSeparator toolStripSeparator = null;
		if (class2.method_0() != (Enum2)200)
		{
			toolStripSeparator = new ToolStripSeparator
			{
				Name = Guid.NewGuid().ToString(),
				Size = new Size(6, 25)
			};
		}
		ToolStripButton toolStripButton5 = null;
		if ((class2.method_0() == (Enum2)2 || class2.method_0() == (Enum2)3) && !string.IsNullOrEmpty(string_0))
		{
			string tag = ((class2.method_0() == (Enum2)2) ? Class4.smethod_2(string_0.Substring(Class39.smethod_45().Length)) : Class4.smethod_2(string_0.Substring(Class39.smethod_46().Length)));
			toolStripButton5 = new ToolStripButton
			{
				Image = Class39.smethod_14(),
				ImageTransparentColor = Color.Magenta,
				Name = Guid.NewGuid().ToString(),
				Size = new Size(64, 22),
				Text = "Компас",
				ToolTipText = "Поиск точного положения на природе",
				Tag = tag,
				Enabled = true
			};
			toolStripButton5.Click += method_29;
		}
		ToolStripButton toolStripButton6 = null;
		if ((class2.method_0() == (Enum2)2 || class2.method_0() == (Enum2)3) && !string.IsNullOrEmpty(string_0))
		{
			string tag2 = ((class2.method_0() == (Enum2)2) ? Class4.smethod_2(string_0.Substring(Class39.smethod_45().Length)) : Class4.smethod_2(string_0.Substring(Class39.smethod_46().Length)));
			toolStripButton6 = new ToolStripButton
			{
				Image = Class39.smethod_28(),
				ImageTransparentColor = Color.Magenta,
				Name = Guid.NewGuid().ToString(),
				Size = new Size(64, 22),
				Text = "Приват",
				ToolTipText = "Обратиться в приват",
				Tag = tag2
			};
			toolStripButton6.Click += method_28;
		}
		ToolStripButton toolStripButton7 = null;
		if ((class2.method_0() == (Enum2)2 || class2.method_0() == (Enum2)3) && !string.IsNullOrEmpty(string_0))
		{
			string tag3 = ((class2.method_0() == (Enum2)2) ? Class4.smethod_2(string_0.Substring(Class39.smethod_45().Length)) : Class4.smethod_2(string_0.Substring(Class39.smethod_46().Length)));
			toolStripButton7 = new ToolStripButton
			{
				Image = Class39.smethod_27(),
				ImageTransparentColor = Color.Magenta,
				Name = Guid.NewGuid().ToString(),
				Size = new Size(64, 22),
				Text = "В контакты",
				ToolTipText = "Добавить в контакты",
				Tag = tag3
			};
			toolStripButton7.Click += method_31;
		}
		ToolStripButton toolStripButton8 = null;
		if ((class2.method_0() == (Enum2)2 || class2.method_0() == (Enum2)3) && !string.IsNullOrEmpty(string_0))
		{
			string tag4 = ((class2.method_0() == (Enum2)2) ? Class4.smethod_2(string_0.Substring(Class39.smethod_45().Length)) : Class4.smethod_2(string_0.Substring(Class39.smethod_46().Length)));
			toolStripButton8 = new ToolStripButton
			{
				Image = Class39.smethod_27(),
				ImageTransparentColor = Color.Magenta,
				Name = Guid.NewGuid().ToString(),
				Size = new Size(64, 22),
				Text = "Весь клан",
				ToolTipText = "Добавление всего клана в контакты",
				Tag = tag4,
				Enabled = true
			};
			toolStripButton8.Click += method_30;
		}
		ToolStripButton toolStripButton9 = null;
		if (class2.method_0() != (Enum2)200 && class2.method_0() != (Enum2)7)
		{
			toolStripButton9 = new ToolStripButton
			{
				Image = Class39.smethod_11(),
				ImageTransparentColor = Color.Magenta,
				Name = Guid.NewGuid().ToString(),
				Size = new Size(64, 22),
				Text = "Снимок",
				ToolTipText = "Снимок текущей закладки",
				Tag = extendedWebBrowser
			};
			toolStripButton9.Click += buttonGameScreen_Click;
		}
		ToolStripSeparator toolStripSeparator2 = null;
		if (class2.method_0() != (Enum2)200 && class2.method_0() != (Enum2)7)
		{
			toolStripSeparator2 = new ToolStripSeparator
			{
				Name = Guid.NewGuid().ToString(),
				Size = new Size(6, 25)
			};
		}
		ToolStripButton toolStripButton10 = null;
		if (class2.method_0() != (Enum2)200 && class2.method_0() != (Enum2)7)
		{
			toolStripButton10 = new ToolStripButton
			{
				DisplayStyle = ToolStripItemDisplayStyle.Image,
				Image = Class39.smethod_15(),
				ImageTransparentColor = Color.Magenta,
				Name = Guid.NewGuid().ToString(),
				Size = new Size(23, 22),
				ToolTipText = "Копировать адрес в клипборд"
			};
			toolStripButton10.Click += method_32;
		}
		ToolStripStatusLabel toolStripStatusLabel = null;
		if (class2.method_0() != (Enum2)200 && class2.method_0() != (Enum2)7)
		{
			toolStripStatusLabel = new ToolStripStatusLabel
			{
				Enabled = false,
				Name = Guid.NewGuid().ToString(),
				Size = new Size(65, 22),
				Text = class2.method_12(),
				TextAlign = ContentAlignment.MiddleLeft,
				DisplayStyle = ToolStripItemDisplayStyle.Text
			};
		}
		if (extendedWebBrowser != null)
		{
			extendedWebBrowser.Tag = toolStripStatusLabel;
			extendedWebBrowser.DocumentCompleted += smethod_47;
		}
		ToolStrip toolStrip = new ToolStrip();
		switch (class2.method_0())
		{
		case (Enum2)200:
			toolStrip.Items.AddRange(new ToolStripItem[1] { toolStripButton4 });
			break;
		case (Enum2)2:
		case (Enum2)3:
			toolStrip.Items.AddRange(new ToolStripItem[11]
			{
				toolStripButton2, toolStripButton4, toolStripSeparator, toolStripButton5, toolStripButton6, toolStripButton7, toolStripButton8, toolStripButton9, toolStripSeparator2, toolStripButton10,
				toolStripStatusLabel
			});
			break;
		case (Enum2)1:
		case (Enum2)5:
		case (Enum2)100:
			toolStrip.Items.AddRange(new ToolStripItem[8] { toolStripButton, toolStripButton2, toolStripButton4, toolStripSeparator, toolStripButton9, toolStripSeparator2, toolStripButton10, toolStripStatusLabel });
			break;
		case (Enum2)4:
		case (Enum2)6:
			toolStrip.Items.AddRange(new ToolStripItem[7] { toolStripButton2, toolStripButton4, toolStripSeparator, toolStripButton9, toolStripSeparator2, toolStripButton10, toolStripStatusLabel });
			break;
		case (Enum2)7:
			toolStrip.Items.AddRange(new ToolStripItem[2] { toolStripButton3, toolStripButton4 });
			break;
		}
		toolStrip.Location = new Point(3, 3);
		toolStrip.Name = Guid.NewGuid().ToString();
		toolStrip.Size = new Size(666, 25);
		tabPage.Controls.Add(panel);
		tabPage.Controls.Add(toolStrip);
		tabPage.Name = Guid.NewGuid().ToString();
		tabPage.Location = new Point(4, 23);
		tabPage.Size = new Size(672, 492);
		tabPage.Padding = new Padding(3);
		tabPage.UseVisualStyleBackColor = true;
		switch (enum2_0)
		{
		case (Enum2)200:
			tabPage.Text = "Блокнот";
			tabPage.ImageIndex = 1;
			break;
		case (Enum2)100:
			if (string_0 != null)
			{
				tabPage.Text = new Uri(string_0).DnsSafeHost;
			}
			break;
		case (Enum2)1:
			tabPage.Text = "Форум";
			break;
		case (Enum2)2:
			if (string_0 != null)
			{
				tabPage.Text = Class4.smethod_2(string_0.Substring(Class39.smethod_45().Length));
				string_0 = Class4.smethod_4(Class39.smethod_45() + tabPage.Text);
			}
			tabPage.ImageIndex = 0;
			break;
		case (Enum2)3:
			if (string_0 != null)
			{
				tabPage.Text = Class4.smethod_2(string_0.Substring(Class39.smethod_46().Length));
				string_0 = Class4.smethod_4(Class39.smethod_46() + tabPage.Text);
			}
			tabPage.ImageIndex = 0;
			break;
		case (Enum2)4:
			if (string_0 != null)
			{
				tabPage.Text = "Бот " + string_0.Substring(Class39.smethod_44().Length);
			}
			tabPage.ImageIndex = 0;
			break;
		case (Enum2)5:
			if (string_0 != null)
			{
				string text = string_0.Substring(Class39.smethod_38().Length);
				int num = text.IndexOf('&');
				if (num != -1)
				{
					text = text.Substring(0, num);
				}
				tabPage.Text = "Бой " + text;
			}
			break;
		case (Enum2)6:
			if (string_0 != null)
			{
				tabPage.Text = "Комната " + string_0.Substring(39);
			}
			break;
		case (Enum2)7:
			tabPage.Text = "Сегодняшний чат";
			break;
		}
		if (string_0.Contains("ibclient.my1.ru"))
		{
			tabPage.Text = "Сайт iBClient";
		}
		if (enum2_0 != 0 && enum2_0 != (Enum2)200 && enum2_0 != (Enum2)7 && !bool_0)
		{
			class2.method_4().Navigate(string_0);
		}
		if (enum2_0 == (Enum2)7 && !bool_0)
		{
			smethod_77(toolStripButton3);
		}
		class2.method_9(string_0);
		tabPage.Tag = class2;
		if (enum2_0 == (Enum2)2 && tabPage.Text.Equals(Class72.class19_0.method_30(), StringComparison.OrdinalIgnoreCase))
		{
			tabControlLeft.TabPages.Insert(1, tabPage);
		}
		else
		{
			tabControlLeft.TabPages.Add(tabPage);
		}
		if (!bool_0)
		{
			method_158();
			tabControlLeft.SelectedTab = tabPage;
		}
	}

	private void method_145()
	{
		if (tabControlLeft.SelectedIndex == -1)
		{
			return;
		}
		object tag = tabControlLeft.TabPages[tabControlLeft.SelectedIndex].Tag;
		if (tag == null)
		{
			return;
		}
		Class42 @class = (Class42)tag;
		if (@class.method_0() == (Enum2)0 || @class.method_0() == (Enum2)200)
		{
			return;
		}
		if (@class.method_0() == (Enum2)7)
		{
			smethod_76(@class.method_4());
		}
		if (@class.method_10())
		{
			@class.method_11(bool_1: false);
			tabControlLeft.TabPages[tabControlLeft.SelectedIndex].Tag = @class;
			if (@class.method_0() != (Enum2)7)
			{
				@class.method_4().Navigate(@class.method_8());
			}
		}
	}

	private void method_146()
	{
		string value = method_147(tabControlLeft.SelectedIndex);
		if (!string.IsNullOrEmpty(value))
		{
			try
			{
				Clipboard.SetText(value);
			}
			catch (ExternalException)
			{
			}
		}
	}

	private string method_147(int int_1)
	{
		Class42 @class = (Class42)tabControlLeft.TabPages[int_1].Tag;
		if (@class.method_0() == (Enum2)200)
		{
			return Class39.smethod_43();
		}
		if (@class.method_0() == (Enum2)7)
		{
			return Class39.smethod_47();
		}
		if (@class.method_0() != (Enum2)2 && @class.method_0() != (Enum2)3)
		{
			WebBrowser webBrowser = @class.method_4();
			if (webBrowser != null && webBrowser.Url != null)
			{
				return webBrowser.Url.ToString();
			}
			return @class.method_12();
		}
		return @class.method_12();
	}

	private static void smethod_74(object object_0)
	{
		((ExtendedWebBrowser)((ToolStripButton)object_0).Tag).GoBack();
	}

	private static void smethod_75(object object_0)
	{
		((ExtendedWebBrowser)((ToolStripButton)object_0).Tag).Refresh(WebBrowserRefreshOption.Completely);
	}

	private static void smethod_76(WebBrowser webBrowser_0)
	{
		string text = Class8.smethod_8();
		if (!File.Exists(text))
		{
			return;
		}
		try
		{
			webBrowser_0.Url = new Uri("file:///" + text);
			while (webBrowser_0.ReadyState != WebBrowserReadyState.Complete)
			{
				Application.DoEvents();
			}
			if (webBrowser_0.Document?.Window != null && webBrowser_0.Document.Body != null)
			{
				webBrowser_0.Document.Window.ScrollTo(0, webBrowser_0.Document.Body.ScrollRectangle.Height);
			}
		}
		catch (ObjectDisposedException)
		{
		}
	}

	private static void smethod_77(object object_0)
	{
		smethod_76((ExtendedWebBrowser)((ToolStripButton)object_0).Tag);
	}

	private void method_148(object object_0)
	{
		TabPage tabPage = (TabPage)((ToolStripButton)object_0).Tag;
		tabControlLeft.TabPages.Remove(tabPage);
		tabPage.Dispose();
		method_158();
	}

	private static void smethod_78(object object_0)
	{
		ExtendedWebBrowser extendedWebBrowser = (ExtendedWebBrowser)object_0;
		((ToolStripLabel)extendedWebBrowser.Tag).Text = extendedWebBrowser.Url.AbsoluteUri;
	}

	private static void smethod_79(object object_0)
	{
		string string_ = (string)((ToolStripButton)object_0).Tag;
		if (Class72.formCompas_0 != null)
		{
			FormCompas.smethod_1(string_);
			Class72.formCompas_0.Focus();
		}
		else
		{
			Class72.formCompas_0 = new FormCompas(string_);
			Class72.formCompas_0.Show();
		}
	}

	private static void smethod_80(object object_0)
	{
		string string_ = (string)((ToolStripButton)object_0).Tag;
		if (Class72.formAddClan_0 != null)
		{
			Class72.formAddClan_0.method_0(string_);
			Class72.formAddClan_0.Focus();
		}
		else
		{
			Class72.formAddClan_0 = new FormAddClan(string_);
			Class72.formAddClan_0.Show();
		}
	}

	private void method_149(object object_0)
	{
		string text = (string)((ToolStripButton)object_0).Tag;
		if (!(browserGame.Document == null))
		{
			tabControlLeft.SelectedIndex = 0;
			method_111("%<" + text + "> ");
		}
	}

	private void method_150(object object_0)
	{
		string string_ = (string)((ToolStripButton)object_0).Tag;
		method_65(string_);
		if (collapsibleSplitter.IsCollapsed)
		{
			collapsibleSplitter.ToggleState();
		}
		tabControlRight.SelectedIndex = 0;
	}

	private void method_151(object object_0)
	{
		ExtendedWebBrowser extendedWebBrowser = (ExtendedWebBrowser)((ToolStripButton)object_0).Tag;
		Rectangle rectangle_ = new Rectangle(0, 0, extendedWebBrowser.ClientRectangle.Width, extendedWebBrowser.ClientRectangle.Height);
		Bitmap bitmap = new Bitmap(extendedWebBrowser.ClientRectangle.Width, extendedWebBrowser.ClientRectangle.Height);
		try
		{
			using (Graphics graphics = Graphics.FromImage(bitmap))
			{
				IntPtr hdc = graphics.GetHdc();
				IntPtr iUnknownForObject = Marshal.GetIUnknownForObject(extendedWebBrowser.ActiveXInstance);
				Class9.OleDraw(iUnknownForObject, 1, hdc, ref rectangle_);
				Marshal.Release(iUnknownForObject);
				graphics.ReleaseHdc(hdc);
			}
			string text = Path.Combine(Application.StartupPath, "Screenshots");
			if (!Directory.Exists(text))
			{
				Directory.CreateDirectory(text);
			}
			saveFileDialog_0.InitialDirectory = text;
			if (saveFileDialog_0.ShowDialog() == DialogResult.OK)
			{
				bitmap.Save(saveFileDialog_0.FileName, ImageFormat.Jpeg);
			}
		}
		finally
		{
			((IDisposable)bitmap).Dispose();
		}
	}

	private void method_152()
	{
		method_144((Enum2)1, Class39.smethod_39(), bool_0: false);
	}

	private void method_153()
	{
		method_144((Enum2)7, Class39.smethod_47(), bool_0: false);
	}

	private void method_154(string string_0)
	{
		method_144((Enum2)100, string_0, bool_0: false);
	}

	private void method_155()
	{
		method_144((Enum2)200, Class39.smethod_43(), bool_0: false);
	}

	private void method_156()
	{
		FormNewTab formNewTab = new FormNewTab();
		try
		{
			if (formNewTab.ShowDialog() == DialogResult.OK)
			{
				method_142(formNewTab.method_0());
			}
		}
		finally
		{
			((IDisposable)formNewTab).Dispose();
		}
	}

	private void method_157(MouseEventArgs mouseEventArgs_0)
	{
		if (mouseEventArgs_0.Button == MouseButtons.Left)
		{
			Struct17 struct17_ = new Struct17(mouseEventArgs_0.X, mouseEventArgs_0.Y);
			IntPtr intPtr = Class9.SendMessage(tabControlLeft.Handle, 4877, IntPtr.Zero, ref struct17_);
			if (intPtr.ToInt32() > 0 && tabControlLeft.TabPages.Count > intPtr.ToInt32())
			{
				TabPage tabPage = tabControlLeft.TabPages[intPtr.ToInt32()];
				tabControlLeft.TabPages.Remove(tabPage);
				tabPage.Dispose();
				method_158();
			}
		}
	}

	private void method_158()
	{
		List<string> list = new List<string>();
		for (int i = 1; i < tabControlLeft.TabCount; i++)
		{
			list.Add(method_147(i));
		}
		Class72.class19_0.string_2 = list.ToArray();
	}

	private void method_159()
	{
		for (int i = 0; i < Class72.class19_0.string_2.Length; i++)
		{
			method_143(Class72.class19_0.string_2[i], bool_0: true);
		}
	}

	private void method_160()
	{
		if (!Class72.smethod_2() && !(DateTime.Now > Class72.dateTime_11))
		{
			if (Class72.class19_0.method_102() && DateTime.Now.Subtract(Class72.smethod_58()).TotalMinutes > 1.0)
			{
				Class72.smethod_59(DateTime.Now);
				Class72.smethod_55(bool_54: true);
			}
			if (!string.IsNullOrEmpty(Class72.smethod_120()))
			{
				if (browserGame.Document != null && !string.IsNullOrEmpty(Class72.class19_0.method_66()))
				{
					Class8.smethod_4("%<" + Class72.smethod_120() + "> " + Class72.class19_0.method_66());
				}
				Class72.smethod_121(string.Empty);
			}
			else if (!string.IsNullOrEmpty(Class72.smethod_122()))
			{
				if (browserGame.Document != null && !string.IsNullOrEmpty(Class72.smethod_122()))
				{
					Class8.smethod_4("%<" + Class72.smethod_122() + "> " + Class72.class19_0.method_68());
				}
				Class72.smethod_123(string.Empty);
			}
			if (Class72.smethod_108())
			{
				if (DateTime.Now > Class72.smethod_110())
				{
					statuslabelAutoAdv.Text = "0:00";
					Class72.smethod_111(DateTime.Now.AddSeconds(Class72.class19_0.struct16_0.int_0));
					if (Class72.smethod_104() == null)
					{
						Class72.smethod_105(Class12.smethod_3(Class72.class19_0.struct16_0.string_0));
						Class72.smethod_107(0);
					}
					if (Class72.smethod_104() != null)
					{
						if (Class72.smethod_106() < Class72.smethod_104().Length)
						{
							Class8.smethod_4(Class72.smethod_104()[Class72.smethod_106()]);
						}
						Class72.smethod_107(Class72.smethod_106() + 1);
						if (Class72.smethod_106() >= Class72.smethod_104().Length)
						{
							Class72.smethod_105(null);
						}
					}
				}
				else
				{
					TimeSpan timeSpan = Class72.smethod_110().Subtract(DateTime.Now);
					statuslabelAutoAdv.Text = timeSpan.Minutes + ":" + timeSpan.Seconds.ToString("00");
				}
			}
			if (DateTime.Now.Subtract(Class72.smethod_28()).TotalSeconds > 200.0)
			{
				smethod_69();
			}
			method_60(Class72.smethod_18());
			if (DateTime.Now.Ticks < Class72.class19_0.struct13_0.long_0)
			{
				if (Class72.smethod_18() != (Enum4)3)
				{
					return;
				}
				if (!string.IsNullOrEmpty(Class72.smethod_6()))
				{
					Class72.smethod_11(bool_54: false);
					Close();
				}
				else
				{
					if (!(DateTime.Now.Subtract(Class72.smethod_14()).TotalSeconds > 28.0))
					{
						return;
					}
					try
					{
						if (Class72.formMain_0 != null)
						{
							Class72.formMain_0.BeginInvoke(new Delegate20(Class72.formMain_0.method_110), new object[0]);
						}
					}
					catch (InvalidOperationException)
					{
					}
					string text = Class4.smethod_1(new TimeSpan(Class72.class19_0.struct13_0.long_0 - DateTime.Now.Ticks));
					method_62(string.Format(CultureInfo.InvariantCulture, "До таймаута боя: <b>{0}</b>", new object[1] { text }));
				}
			}
			else if (string.IsNullOrEmpty(Class72.string_0))
			{
				if (DateTime.Now.Subtract(Class72.dateTime_9).TotalMinutes > 4.0)
				{
					Class72.dateTime_9 = DateTime.Now;
					method_110();
				}
			}
			else
			{
				if (Class72.string_0.IndexOf("????", StringComparison.Ordinal) != -1 || !Class72.class19_0.bool_48)
				{
					return;
				}
				Class72.class19_0.struct13_0.long_0 = 0L;
				if (Class72.string_0.Length > 5)
				{
					method_83("Завершение боя");
					if (Class72.string_0 != null && Class72.string_0.IndexOf("=00000&", StringComparison.Ordinal) == -1)
					{
						method_109(Class72.string_0);
					}
				}
				if (Class72.class19_0.method_124() && notifyIcon_0.Visible)
				{
					try
					{
						readerWriterLock_3.AcquireWriterLock(5000);
						try
						{
							notifyIcon_0.Visible = false;
							notifyIcon_0.Visible = true;
						}
						finally
						{
							readerWriterLock_3.ReleaseWriterLock();
						}
					}
					catch (ApplicationException)
					{
					}
				}
				Class72.string_0 = string.Empty;
				method_60(Class72.class19_0.bool_48 ? ((Enum4)1) : ((Enum4)0));
			}
		}
		else
		{
			Class72.smethod_3(bool_54: false);
			method_120();
		}
	}

	private void method_161()
	{
		DateTime dateTime = ((Class72.class19_0.timeSpan_0 == TimeSpan.MinValue) ? DateTime.Now : DateTime.Now.Subtract(Class72.class19_0.timeSpan_0));
		statuslabelClock.Text = dateTime.Hour.ToString("00") + ":" + dateTime.Minute.ToString("00") + ":" + dateTime.Second.ToString("00");
		if (dateTime.Second == 0)
		{
			if (dateTime.Minute == 50 && (dateTime.Hour == 0 || dateTime.Hour == 6 || dateTime.Hour == 12 || dateTime.Hour == 18))
			{
				Class72.class19_0.sortedDictionary_0.Clear();
			}
			if (method_45() && !string.IsNullOrEmpty(Class72.string_42) && dateTime.Minute == 0 && (dateTime.Hour == Class72.int_14 || dateTime.Hour == Class72.int_15))
			{
				method_123(Class12.smethod_5() ? Class72.string_42 : Class72.string_41);
			}
		}
		string text = Class8.smethod_5();
		if (!string.IsNullOrEmpty(text))
		{
			method_113(text);
		}
		method_162();
	}

	private void method_162()
	{
		Class69[] array;
		int num;
		while (true)
		{
			array = Class71.smethod_2();
			num = 0;
			while (true)
			{
				if (num < array.Length)
				{
					if (!(DateTime.Now <= array[num].dateTime_0))
					{
						break;
					}
					num++;
					continue;
				}
				if (dropdownTimers == null)
				{
					return;
				}
				bool flag = true;
				if (array.Length == dropdownTimers.DropDownItems.Count - 1)
				{
					flag = false;
				}
				else
				{
					while (dropdownTimers.DropDownItems.Count > 1)
					{
						dropdownTimers.DropDownItems.RemoveAt(1);
					}
				}
				if (array.Length == 0)
				{
					dropdownTimers.Text = "Таймеры";
					return;
				}
				dropdownTimers.Text = array[0].ToString();
				for (int i = 0; i < array.Length; i++)
				{
					if (flag)
					{
						ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem(array[i].ToString())
						{
							Tag = i
						};
						if (array[i].bool_1)
						{
							toolStripMenuItem.Image = Class39.smethod_4();
							toolStripMenuItem.ImageAlign = ContentAlignment.MiddleCenter;
							toolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
						}
						toolStripMenuItem.Click += method_33;
						dropdownTimers.DropDownItems.Add(toolStripMenuItem);
					}
					else
					{
						dropdownTimers.DropDownItems[i + 1].Text = array[i].ToString();
						dropdownTimers.DropDownItems[i + 1].Tag = i;
						if (array[i].bool_1)
						{
							dropdownTimers.DropDownItems[i + 1].Image = Class39.smethod_4();
							dropdownTimers.DropDownItems[i + 1].ImageAlign = ContentAlignment.MiddleCenter;
							dropdownTimers.DropDownItems[i + 1].ImageScaling = ToolStripItemImageScaling.None;
						}
						else
						{
							dropdownTimers.DropDownItems[i + 1].Image = null;
						}
					}
				}
				return;
			}
			if (Class72.bool_21)
			{
				return;
			}
			if (string.IsNullOrEmpty(array[num].string_1))
			{
				string string_ = array[num].string_2;
				if (string.IsNullOrEmpty(string_))
				{
					string string_2 = array[num].string_3;
					if (string.IsNullOrEmpty(string_2))
					{
						if (array[num].bool_1)
						{
							break;
						}
						Class71.smethod_3(num);
						Class18.smethod_6();
						continue;
					}
					Class72.string_33 = string_2;
					Class71.smethod_3(num);
					Class18.smethod_6();
					smethod_56();
					return;
				}
				if (array[num].bool_0)
				{
					Class69 class69_ = new Class69
					{
						dateTime_0 = array[num].dateTime_0.AddDays(1.0),
						string_0 = array[num].string_0,
						string_2 = array[num].string_2,
						bool_0 = true
					};
					Class71.smethod_3(num);
					Class71.smethod_1(class69_);
				}
				else
				{
					Class71.smethod_3(num);
				}
				Class18.smethod_6();
				method_124(string_);
				return;
			}
			method_19(array[num].string_1, Class72.class19_0.method_30(), array[num].int_0);
			if (array[num].bool_0)
			{
				Class69 class69_2 = new Class69
				{
					dateTime_0 = array[num].dateTime_0.AddSeconds(array[num].int_1),
					string_0 = array[num].string_0,
					string_1 = array[num].string_1,
					int_0 = array[num].int_0,
					bool_0 = true,
					int_1 = array[num].int_1,
					bool_2 = array[num].bool_2
				};
				Class71.smethod_3(num);
				Class71.smethod_1(class69_2);
			}
			else
			{
				Class71.smethod_3(num);
			}
			Class18.smethod_6();
			smethod_56();
			return;
		}
		string[] array2 = array[num].string_0.Split(new string[1] { " вырастет на " }, StringSplitOptions.RemoveEmptyEntries);
		method_63("Растение <b>" + array2[0] + "</b> выросло на <a href='#' onclick='window.external.MoveTo(\"" + array2[1] + "\")'>" + array2[1] + "</a>");
		Class71.smethod_3(num);
		Class18.smethod_6();
	}

	private void method_163(int int_1)
	{
		if (MessageBox.Show("Удалить таймер?", "Удаление таймера", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
		{
			Class71.smethod_3(int_1);
			method_162();
		}
	}

	internal bool method_164()
	{
		if (notifyIcon_0.Text.IndexOf("Ввод цифр", StringComparison.OrdinalIgnoreCase) == -1)
		{
			return false;
		}
		return DateTime.Now.Subtract(dateTime_0).TotalMinutes > 1.0;
	}

	private void method_165()
	{
		for (int i = 0; i < 2; i++)
		{
			if (icon_0[i] == null)
			{
				Bitmap bitmap = new Bitmap(imageList_2.Images[i]);
				icon_0[i] = Icon.FromHandle(bitmap.GetHicon());
			}
		}
		notifyIcon_0.Text = Class72.class19_0.method_30();
		method_166(0);
		notifyIcon_0.Visible = true;
	}

	private void method_166(int int_1)
	{
		notifyIcon_0.Icon = icon_0[int_1];
	}

	private void method_167(string string_0)
	{
		if (!timer_1.Enabled && notifyIcon_0.Visible)
		{
			if (string_0.Equals("Ввод цифр", StringComparison.OrdinalIgnoreCase))
			{
				dateTime_0 = DateTime.Now;
			}
			notifyIcon_0.Text = Class72.class19_0.method_30() + ": " + string_0;
			int_0 = 0;
			timer_1.Start();
		}
	}

	private void method_168()
	{
		int_0 = 1 - int_0;
		method_166(int_0);
	}

	private void method_169()
	{
		timer_1.Stop();
		Show();
		base.WindowState = formWindowState_0;
		notifyIcon_0.Visible = false;
	}
}
