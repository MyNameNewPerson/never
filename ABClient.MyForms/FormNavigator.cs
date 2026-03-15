using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using ABClient.AppControls;
using ABClient.ExtMap;

namespace ABClient.MyForms;

public class FormNavigator : Form
{
	private readonly AutoCompleteStringCollection autoCompleteStringCollection_0 = new AutoCompleteStringCollection();

	private string string_0;

	private readonly SortedDictionary<string, GroupCell> sortedDictionary_0;

	private readonly SortedDictionary<string, GroupCell> sortedDictionary_1;

	private readonly string[] string_1;

	private readonly string string_2;

	private IContainer icontainer_0;

	private Button buttonOk;

	private Button buttonCancel;

	private GroupBox groupBox1;

	private ExtendedWebBrowser browserMap_1;

	private Label label2;

	private TextBox textDest;

	private TextBox textTooltipSuggest;

	private GroupBox groupBox2;

	private Button buttonClearFavorites;

	private Button buttonSaveInFavorites;

	private GroupBox groupBox3;

	private Label label1;

	private Label labelJumps;

	private Label label3;

	private Label labelBotLevel;

	private Button buttonCalc;

	private TreeViewEx treeDest;

	private Label labelTied;

	private Label label4;

	private Button buttonDeleteFromFavorites;

	private Label label5;

	private Button button1;

	private TextBox autoForestCells;

	internal FormNavigator(string string_3, string string_4, string string_5, string string_6)
	{
		InitializeComponent();
		sortedDictionary_0 = new SortedDictionary<string, GroupCell>();
		sortedDictionary_1 = new SortedDictionary<string, GroupCell>();
		foreach (string key3 in Class77.smethod_4().Keys)
		{
			autoCompleteStringCollection_0.Add(key3);
			if (!Class77.smethod_4().TryGetValue(key3, out var value))
			{
				continue;
			}
			if (!string.IsNullOrEmpty(value.HerbGroup) && !value.HerbGroup.Trim().Equals("0"))
			{
				string[] array = value.HerbGroup.Split(',');
				for (int i = 0; i < array.Length; i++)
				{
					if (int.TryParse(array[i].Trim(), out var result))
					{
						GroupCell groupCell = new GroupCell("Травы", result);
						string key = groupCell.ToString();
						if (!sortedDictionary_0.ContainsKey(key))
						{
							sortedDictionary_0.Add(key, groupCell);
						}
						sortedDictionary_0[key].AddCell(key3);
					}
				}
			}
			if (value.MapBots == null || value.MapBots.Count <= 0)
			{
				continue;
			}
			foreach (MapBot mapBot in value.MapBots)
			{
				GroupCell groupCell2 = new GroupCell(level: mapBot.MaxLevel, name: mapBot.Name);
				string key2 = groupCell2.ToString();
				if (!sortedDictionary_1.ContainsKey(key2))
				{
					sortedDictionary_1.Add(key2, groupCell2);
				}
				sortedDictionary_1[key2].AddCell(key3);
			}
		}
		textDest.AutoCompleteCustomSource = autoCompleteStringCollection_0;
		string_0 = string_3;
		if (string.IsNullOrEmpty(string_0))
		{
			string_0 = Class72.class19_0.method_58();
		}
		textDest.Text = string_0;
		method_2();
		NavScriptManager objectForScripting = new NavScriptManager(this);
		browserMap_1.Name = "browserMap";
		browserMap_1.ScriptErrorsSuppressed = true;
		browserMap_1.ObjectForScripting = objectForScripting;
		PointToDest(new string[1] { string_0 });
		string_1 = null;
		string_2 = null;
		if (string_4 == null)
		{
			return;
		}
		string_2 = string_6;
		if (!(string_4 == "Природа"))
		{
			return;
		}
		List<string> list = new List<string>();
		foreach (string key4 in Class77.smethod_4().Keys)
		{
			if (Class77.smethod_4()[key4].Tooltip.Equals(string_5, StringComparison.OrdinalIgnoreCase))
			{
				list.Add(key4);
			}
		}
		string_1 = list.ToArray();
	}

	private static void smethod_0(TreeNode treeNode_0, string string_3)
	{
		string string_4 = string_3 + " " + Class77.smethod_4()[string_3].Tooltip;
		smethod_2(treeNode_0, string_4, string_3);
	}

	private static void smethod_1(TreeNode treeNode_0, GroupCell groupCell_0)
	{
		if (groupCell_0.Cells.Count == 0)
		{
			return;
		}
		string arg = groupCell_0.ToString();
		string cells = groupCell_0.GetCells();
		string string_ = ((groupCell_0.Cells.Count == 1) ? cells : groupCell_0.GetCells());
		string string_2 = $"{arg} ({groupCell_0.Cells.Count}шт)";
		TreeNode treeNode_1 = smethod_2(treeNode_0, string_2, string_);
		foreach (string key in groupCell_0.Cells.Keys)
		{
			smethod_0(treeNode_1, key);
		}
	}

	private void method_0(string string_3)
	{
		StringBuilder stringBuilder = new StringBuilder("<HTML>");
		stringBuilder.AppendLine();
		stringBuilder.AppendLine("<HEAD>");
		stringBuilder.AppendLine("<META Http-Equiv=\"Content-Type\" Content=\"text/html; charset=windows-1251\">");
		stringBuilder.AppendLine("<LINK href=\"http://www.neverlands.ru/css/main.css\" rel=\"STYLESHEET\" type=\"text/css\">");
		stringBuilder.AppendLine("</HEAD>");
		stringBuilder.AppendLine("<BODY leftmargin=0 topmargin=0 bottommargin=0 rightmargin=0>");
		stringBuilder.AppendLine("<SCRIPT language=\"JavaScript\">");
		stringBuilder.AppendLine(Class39.smethod_80());
		string key = Class77.smethod_2()[string_3];
		Class85 @class = Class77.smethod_0()[key];
		stringBuilder.AppendFormat("showMap({0}, {1});", @class.method_0(), @class.method_2());
		stringBuilder.AppendLine();
		stringBuilder.AppendLine("</SCRIPT>");
		stringBuilder.AppendLine("</BODY>");
		stringBuilder.AppendLine("</HTML>");
		browserMap_1.DocumentText = stringBuilder.ToString();
		while (browserMap_1.ReadyState != WebBrowserReadyState.Complete)
		{
			Application.DoEvents();
		}
	}

	private void buttonOk_Click(object sender, EventArgs e)
	{
		Class72.smethod_41(string_0);
		Class72.smethod_37(bool_54: true);
	}

	private void FormNavigator_Load(object sender, EventArgs e)
	{
		if (string_2 != null)
		{
			Text = "Возможное местонахождение " + string_2;
		}
		PointToDest(string_1 ?? new string[1] { string_0 });
	}

	public void PointToDest(IList<string> dest)
	{
		try
		{
			MapPath mapPath = new MapPath(Class72.class19_0.method_58(), dest);
			if (mapPath.PathExists)
			{
				Text = "Маршрут до " + mapPath.Destination;
				textDest.Text = mapPath.Destination;
				string_0 = mapPath.Destination;
				labelJumps.Text = mapPath.Jumps.ToString();
				labelBotLevel.Text = mapPath.BotLevel.ToString();
				labelTied.Text = $"~{Class72.smethod_26() + mapPath.Jumps * 2}%";
				method_0(string_0);
				buttonOk.Enabled = true;
			}
			else
			{
				Text = "Навигатор";
				labelJumps.Text = "-";
				labelBotLevel.Text = "-";
				labelTied.Text = "-";
				method_0(Class72.class19_0.method_58());
				buttonOk.Enabled = false;
			}
		}
		catch (NullReferenceException)
		{
		}
	}

	private TreeNode method_1(string string_3)
	{
		TreeNode treeNode = new TreeNode
		{
			Text = string_3,
			ForeColor = Color.DarkCyan,
			Tag = null
		};
		treeDest.Nodes.Add(treeNode);
		return treeNode;
	}

	private static TreeNode smethod_2(TreeNode treeNode_0, string string_3, string string_4)
	{
		TreeNode treeNode = new TreeNode
		{
			Text = string_3,
			ForeColor = Color.Black,
			Tag = string_4
		};
		treeNode_0.Nodes.Add(treeNode);
		return treeNode;
	}

	private void method_2()
	{
		treeDest.BeginUpdate();
		treeDest.Nodes.Clear();
		TreeNode treeNode_;
		if (Class72.class19_0.string_3 != null && Class72.class19_0.string_3.Length != 0)
		{
			treeNode_ = method_1("Запомненные локации");
			string[] string_ = Class72.class19_0.string_3;
			foreach (string text in string_)
			{
				if (Class77.smethod_4().TryGetValue(text, out var _))
				{
					smethod_0(treeNode_, text);
				}
			}
		}
		treeNode_ = method_1("Города");
		smethod_0(treeNode_, "8-259");
		smethod_0(treeNode_, "8-294");
		smethod_0(treeNode_, "8-197");
		smethod_0(treeNode_, "12-428");
		smethod_0(treeNode_, "12-494");
		smethod_0(treeNode_, "12-521");
		treeNode_ = method_1("Объекты");
		smethod_0(treeNode_, "8-227");
		smethod_0(treeNode_, "2-482");
		smethod_0(treeNode_, "9-494");
		smethod_0(treeNode_, "26-430");
		smethod_0(treeNode_, "33-184");
		smethod_0(treeNode_, "12-168");
		treeNode_ = method_1("Причалы");
		smethod_0(treeNode_, "8-141");
		smethod_0(treeNode_, "8-529");
		treeNode_ = method_1("Лесопилки");
		smethod_0(treeNode_, "27-120");
		smethod_0(treeNode_, "34-002");
		smethod_0(treeNode_, "4-269");
		smethod_0(treeNode_, "4-512");
		smethod_0(treeNode_, "8-012");
		treeNode_ = method_1("Плавильни");
		smethod_0(treeNode_, "1-475");
		smethod_0(treeNode_, "5-221");
		smethod_0(treeNode_, "8-165");
		smethod_0(treeNode_, "8-238");
		if (sortedDictionary_0.Count > 0)
		{
			treeNode_ = method_1("Травы");
			foreach (GroupCell value2 in sortedDictionary_0.Values)
			{
				smethod_1(treeNode_, value2);
			}
		}
		treeNode_ = method_1("Ресурсы охотников");
		method_3(treeNode_, "Крысиные хвосты (0+)", "крысы");
		method_3(treeNode_, "Крысиные лапы (15+)", "крысы");
		method_3(treeNode_, "Мясо кабана (50+)", "кабаны");
		method_3(treeNode_, "Шкуры кабана (65+)", "кабаны");
		method_3(treeNode_, "Клык кабана (80+)", "кабаны");
		method_3(treeNode_, "Копыта (100+)", "кабаны");
		method_3(treeNode_, "Кости скелетов (120+)", "скелеты");
		method_3(treeNode_, "Черепа (130+)", "скелеты");
		method_3(treeNode_, "Зубы (150+)", "скелеты");
		method_3(treeNode_, "Трупный яд (180+)", "зомби");
		method_3(treeNode_, "Костный мозг (200+)", "зомби");
		method_3(treeNode_, "Гниль (220+)", "зомби");
		method_3(treeNode_, "Паучьи лапы (235+)", "пауки");
		method_3(treeNode_, "Хитиновые панцири (250+)", "пауки");
		method_3(treeNode_, "Паутина (260+)", "пауки");
		method_3(treeNode_, "Жвала (280+)", "пауки");
		method_3(treeNode_, "Паучьи яйца (300+)", "пауки");
		method_3(treeNode_, "Ядовитые железы (320+)", "пауки");
		method_3(treeNode_, "Крысиные глаза (350+)", "крысы");
		method_3(treeNode_, "Медвежье мясо (400+)", "медведи");
		method_3(treeNode_, "Шкуры медведей (500+)", "медведи");
		method_3(treeNode_, "Медвежий жир (600+)", "медведи");
		method_3(treeNode_, "Клыки (700+)", "медведи");
		treeNode_ = method_1("Шахты");
		smethod_0(treeNode_, "1-446");
		smethod_0(treeNode_, "5-250");
		smethod_0(treeNode_, "8-167");
		treeNode_ = method_1("Водоёмы");
		foreach (KeyValuePair<string, Cell> item in Class77.smethod_4())
		{
			if (item.Value.HasFish)
			{
				smethod_0(treeNode_, item.Key);
			}
		}
		treeNode_ = method_1("Телепорты");
		foreach (KeyValuePair<string, string> item2 in Class77.smethod_10())
		{
			smethod_0(treeNode_, item2.Key);
		}
		if (sortedDictionary_1.Count > 0)
		{
			treeNode_ = method_1("Боты");
			foreach (GroupCell value3 in sortedDictionary_1.Values)
			{
				smethod_1(treeNode_, value3);
			}
		}
		treeNode_ = method_1("Замки");
		foreach (KeyValuePair<string, Cell> item3 in Class77.smethod_4())
		{
			if (item3.Value.Tooltip.IndexOf("замок", StringComparison.CurrentCultureIgnoreCase) >= 0)
			{
				smethod_0(treeNode_, item3.Key);
			}
		}
		treeNode_ = method_1("Форты группы 1");
		foreach (KeyValuePair<string, Cell> item4 in Class77.smethod_4())
		{
			if (item4.Value.Name.IndexOf("ФортGA", StringComparison.CurrentCultureIgnoreCase) >= 0)
			{
				smethod_0(treeNode_, item4.Key);
			}
		}
		treeNode_ = method_1("Форты группы 2");
		foreach (KeyValuePair<string, Cell> item5 in Class77.smethod_4())
		{
			if (item5.Value.Name.IndexOf("ФортGB", StringComparison.CurrentCultureIgnoreCase) >= 0)
			{
				smethod_0(treeNode_, item5.Key);
			}
		}
		treeNode_ = method_1("Форты группы 3");
		foreach (KeyValuePair<string, Cell> item6 in Class77.smethod_4())
		{
			if (item6.Value.Name.IndexOf("ФортGC", StringComparison.CurrentCultureIgnoreCase) >= 0)
			{
				smethod_0(treeNode_, item6.Key);
			}
		}
		treeDest.EndUpdate();
		if (treeDest.Nodes.Count > 0)
		{
			treeDest.Nodes[0].Expand();
		}
	}

	private void method_3(TreeNode treeNode_0, string string_3, string string_4)
	{
		List<string> list = new List<string>();
		foreach (string key in Class77.smethod_4().Keys)
		{
			Cell cell = Class77.smethod_4()[key];
			if (cell.IsBot(string_4))
			{
				list.Add(cell.CellNumber);
			}
		}
		GroupCell groupCell = new GroupCell(string_3);
		foreach (string item in list)
		{
			groupCell.AddCell(item);
		}
		smethod_1(treeNode_0, groupCell);
	}

	private void method_4(string string_3)
	{
		treeDest.BeginUpdate();
		treeDest.Nodes.Clear();
		SortedDictionary<string, List<string>> sortedDictionary = new SortedDictionary<string, List<string>>();
		foreach (string key in Class77.smethod_4().Keys)
		{
			Cell cell = Class77.smethod_4()[key];
			if (cell.Tooltip.IndexOf(string_3, StringComparison.CurrentCultureIgnoreCase) >= 0)
			{
				if (!sortedDictionary.ContainsKey(cell.Tooltip))
				{
					sortedDictionary.Add(cell.Tooltip, new List<string> { cell.CellNumber });
				}
				else
				{
					sortedDictionary[cell.Tooltip].Add(cell.CellNumber);
				}
			}
		}
		if (sortedDictionary.Count > 0)
		{
			TreeNode treeNode_ = method_1("Подходящие названия");
			foreach (KeyValuePair<string, List<string>> item in sortedDictionary)
			{
				if (item.Value.Count == 1)
				{
					smethod_0(treeNode_, item.Value[0]);
					continue;
				}
				GroupCell groupCell = new GroupCell(item.Key);
				foreach (string item2 in item.Value)
				{
					groupCell.AddCell(item2);
				}
				smethod_1(treeNode_, groupCell);
			}
		}
		treeDest.EndUpdate();
		if (treeDest.Nodes.Count > 0)
		{
			treeDest.Nodes[0].Expand();
		}
	}

	private void textDest_TextChanged(object sender, EventArgs e)
	{
		bool flag;
		try
		{
			flag = new Regex("\\d{1,2}-\\d{3}").Match(textDest.Text).Success && Class77.smethod_4().ContainsKey(textDest.Text);
		}
		catch
		{
			flag = false;
		}
		textDest.BackColor = (flag ? SystemColors.Window : Color.Pink);
		buttonCalc.Enabled = flag;
	}

	private void textTooltipSuggest_TextChanged(object sender, EventArgs e)
	{
		if (textTooltipSuggest.Text.Length < 1)
		{
			method_2();
		}
		else
		{
			method_4(textTooltipSuggest.Text);
		}
	}

	private void buttonSaveInFavorites_Click(object sender, EventArgs e)
	{
		Class72.class19_0.method_4(string_0);
		method_2();
	}

	private void buttonClearFavorites_Click(object sender, EventArgs e)
	{
		Class72.class19_0.method_6();
		method_2();
	}

	private void buttonCalc_Click(object sender, EventArgs e)
	{
		PointToDest(new string[1] { textDest.Text });
	}

	private void treeDest_AfterSelect(object sender, TreeViewEventArgs e)
	{
		if (treeDest.Nodes.Count != 0)
		{
			object tag = treeDest.SelectedNode.Tag;
			if (tag != null)
			{
				string[] dest = ((string)tag).Split('|');
				PointToDest(dest);
			}
		}
	}

	private void buttonDeleteFromFavorites_Click(object sender, EventArgs e)
	{
		Class72.class19_0.method_5(string_0);
		method_2();
	}

	private void button1_Click(object sender, EventArgs e)
	{
		if (!string.IsNullOrEmpty(autoForestCells.Text))
		{
			autoForestCells.Text += ",";
		}
		if (!string.IsNullOrEmpty(textDest.Text))
		{
			autoForestCells.Text += textDest.Text;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ABClient.MyForms.FormNavigator));
		this.buttonOk = new System.Windows.Forms.Button();
		this.buttonCancel = new System.Windows.Forms.Button();
		this.groupBox1 = new System.Windows.Forms.GroupBox();
		this.buttonCalc = new System.Windows.Forms.Button();
		this.textTooltipSuggest = new System.Windows.Forms.TextBox();
		this.treeDest = new ABClient.AppControls.TreeViewEx();
		this.textDest = new System.Windows.Forms.TextBox();
		this.label2 = new System.Windows.Forms.Label();
		this.groupBox2 = new System.Windows.Forms.GroupBox();
		this.buttonDeleteFromFavorites = new System.Windows.Forms.Button();
		this.buttonClearFavorites = new System.Windows.Forms.Button();
		this.buttonSaveInFavorites = new System.Windows.Forms.Button();
		this.groupBox3 = new System.Windows.Forms.GroupBox();
		this.labelTied = new System.Windows.Forms.Label();
		this.label4 = new System.Windows.Forms.Label();
		this.labelBotLevel = new System.Windows.Forms.Label();
		this.labelJumps = new System.Windows.Forms.Label();
		this.label3 = new System.Windows.Forms.Label();
		this.label1 = new System.Windows.Forms.Label();
		this.browserMap_1 = new ABClient.AppControls.ExtendedWebBrowser();
		this.label5 = new System.Windows.Forms.Label();
		this.button1 = new System.Windows.Forms.Button();
		this.autoForestCells = new System.Windows.Forms.TextBox();
		this.groupBox1.SuspendLayout();
		this.groupBox2.SuspendLayout();
		this.groupBox3.SuspendLayout();
		base.SuspendLayout();
		this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
		this.buttonOk.Enabled = false;
		this.buttonOk.Font = new System.Drawing.Font("Tahoma", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
		this.buttonOk.Location = new System.Drawing.Point(391, 490);
		this.buttonOk.Name = "buttonOk";
		this.buttonOk.Size = new System.Drawing.Size(192, 32);
		this.buttonOk.TabIndex = 1003;
		this.buttonOk.Text = "В путь!";
		this.buttonOk.UseVisualStyleBackColor = true;
		this.buttonOk.Click += new System.EventHandler(buttonOk_Click);
		this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
		this.buttonCancel.Location = new System.Drawing.Point(589, 490);
		this.buttonCancel.Name = "buttonCancel";
		this.buttonCancel.Size = new System.Drawing.Size(106, 32);
		this.buttonCancel.TabIndex = 1004;
		this.buttonCancel.Text = "Отмена";
		this.buttonCancel.UseVisualStyleBackColor = true;
		this.groupBox1.BackColor = System.Drawing.Color.Transparent;
		this.groupBox1.Controls.Add(this.buttonCalc);
		this.groupBox1.Controls.Add(this.textTooltipSuggest);
		this.groupBox1.Controls.Add(this.treeDest);
		this.groupBox1.Controls.Add(this.textDest);
		this.groupBox1.Location = new System.Drawing.Point(12, 12);
		this.groupBox1.Name = "groupBox1";
		this.groupBox1.Size = new System.Drawing.Size(361, 510);
		this.groupBox1.TabIndex = 1005;
		this.groupBox1.TabStop = false;
		this.groupBox1.Text = "Куда";
		this.buttonCalc.Location = new System.Drawing.Point(81, 15);
		this.buttonCalc.Name = "buttonCalc";
		this.buttonCalc.Size = new System.Drawing.Size(75, 23);
		this.buttonCalc.TabIndex = 1026;
		this.buttonCalc.Text = "проложить";
		this.buttonCalc.UseVisualStyleBackColor = true;
		this.buttonCalc.Click += new System.EventHandler(buttonCalc_Click);
		this.textTooltipSuggest.Location = new System.Drawing.Point(162, 17);
		this.textTooltipSuggest.Name = "textTooltipSuggest";
		this.textTooltipSuggest.Size = new System.Drawing.Size(191, 21);
		this.textTooltipSuggest.TabIndex = 1025;
		this.textTooltipSuggest.TextChanged += new System.EventHandler(textTooltipSuggest_TextChanged);
		this.treeDest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.treeDest.FullRowSelect = true;
		this.treeDest.Location = new System.Drawing.Point(9, 44);
		this.treeDest.Name = "treeDest";
		this.treeDest.Size = new System.Drawing.Size(344, 460);
		this.treeDest.TabIndex = 1027;
		this.treeDest.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(treeDest_AfterSelect);
		this.textDest.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
		this.textDest.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
		this.textDest.Location = new System.Drawing.Point(9, 17);
		this.textDest.Name = "textDest";
		this.textDest.Size = new System.Drawing.Size(66, 21);
		this.textDest.TabIndex = 5;
		this.textDest.TextChanged += new System.EventHandler(textDest_TextChanged);
		this.label2.Location = new System.Drawing.Point(11, 59);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(300, 20);
		this.label2.TabIndex = 1019;
		this.label2.Text = "Можно перемещаться, кликая по клеткам карты";
		this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.groupBox2.Controls.Add(this.buttonDeleteFromFavorites);
		this.groupBox2.Controls.Add(this.buttonClearFavorites);
		this.groupBox2.Controls.Add(this.buttonSaveInFavorites);
		this.groupBox2.Location = new System.Drawing.Point(380, 12);
		this.groupBox2.Name = "groupBox2";
		this.groupBox2.Size = new System.Drawing.Size(323, 74);
		this.groupBox2.TabIndex = 1020;
		this.groupBox2.TabStop = false;
		this.groupBox2.Text = "Запомненные локации";
		this.buttonDeleteFromFavorites.Location = new System.Drawing.Point(11, 44);
		this.buttonDeleteFromFavorites.Name = "buttonDeleteFromFavorites";
		this.buttonDeleteFromFavorites.Size = new System.Drawing.Size(169, 23);
		this.buttonDeleteFromFavorites.TabIndex = 2;
		this.buttonDeleteFromFavorites.Text = "Удалить из списка";
		this.buttonDeleteFromFavorites.UseVisualStyleBackColor = true;
		this.buttonDeleteFromFavorites.Click += new System.EventHandler(buttonDeleteFromFavorites_Click);
		this.buttonClearFavorites.Location = new System.Drawing.Point(186, 15);
		this.buttonClearFavorites.Name = "buttonClearFavorites";
		this.buttonClearFavorites.Size = new System.Drawing.Size(131, 23);
		this.buttonClearFavorites.TabIndex = 1;
		this.buttonClearFavorites.Text = "Очистить список";
		this.buttonClearFavorites.UseVisualStyleBackColor = true;
		this.buttonClearFavorites.Click += new System.EventHandler(buttonClearFavorites_Click);
		this.buttonSaveInFavorites.Location = new System.Drawing.Point(11, 15);
		this.buttonSaveInFavorites.Name = "buttonSaveInFavorites";
		this.buttonSaveInFavorites.Size = new System.Drawing.Size(169, 23);
		this.buttonSaveInFavorites.TabIndex = 0;
		this.buttonSaveInFavorites.Text = "Сохранить в списке";
		this.buttonSaveInFavorites.UseVisualStyleBackColor = true;
		this.buttonSaveInFavorites.Click += new System.EventHandler(buttonSaveInFavorites_Click);
		this.groupBox3.Controls.Add(this.labelTied);
		this.groupBox3.Controls.Add(this.label4);
		this.groupBox3.Controls.Add(this.labelBotLevel);
		this.groupBox3.Controls.Add(this.labelJumps);
		this.groupBox3.Controls.Add(this.label3);
		this.groupBox3.Controls.Add(this.label1);
		this.groupBox3.Controls.Add(this.browserMap_1);
		this.groupBox3.Controls.Add(this.label2);
		this.groupBox3.Location = new System.Drawing.Point(379, 92);
		this.groupBox3.Name = "groupBox3";
		this.groupBox3.Size = new System.Drawing.Size(323, 392);
		this.groupBox3.TabIndex = 1021;
		this.groupBox3.TabStop = false;
		this.groupBox3.Text = "Маршрут";
		this.labelTied.AutoSize = true;
		this.labelTied.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
		this.labelTied.Location = new System.Drawing.Point(246, 21);
		this.labelTied.Name = "labelTied";
		this.labelTied.Size = new System.Drawing.Size(14, 13);
		this.labelTied.TabIndex = 1025;
		this.labelTied.Text = "0";
		this.label4.AutoSize = true;
		this.label4.Location = new System.Drawing.Point(184, 21);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(64, 13);
		this.label4.TabIndex = 1024;
		this.label4.Text = "Усталость:";
		this.labelBotLevel.AutoSize = true;
		this.labelBotLevel.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
		this.labelBotLevel.Location = new System.Drawing.Point(102, 38);
		this.labelBotLevel.Name = "labelBotLevel";
		this.labelBotLevel.Size = new System.Drawing.Size(14, 13);
		this.labelBotLevel.TabIndex = 1023;
		this.labelBotLevel.Text = "0";
		this.labelJumps.AutoSize = true;
		this.labelJumps.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
		this.labelJumps.Location = new System.Drawing.Point(121, 21);
		this.labelJumps.Name = "labelJumps";
		this.labelJumps.Size = new System.Drawing.Size(14, 13);
		this.labelJumps.TabIndex = 1022;
		this.labelJumps.Text = "0";
		this.label3.AutoSize = true;
		this.label3.Location = new System.Drawing.Point(17, 38);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(87, 13);
		this.label3.TabIndex = 1021;
		this.label3.Text = "Уровень ботов:";
		this.label1.AutoSize = true;
		this.label1.Location = new System.Drawing.Point(18, 21);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(104, 13);
		this.label1.TabIndex = 1020;
		this.label1.Text = "Кол-во переходов:";
		this.browserMap_1.Location = new System.Drawing.Point(11, 82);
		this.browserMap_1.MinimumSize = new System.Drawing.Size(20, 20);
		this.browserMap_1.Name = "browserMap";
		this.browserMap_1.ScrollBarsEnabled = false;
		this.browserMap_1.Size = new System.Drawing.Size(300, 300);
		this.browserMap_1.TabIndex = 1017;
		this.browserMap_1.WebBrowserShortcutsEnabled = false;
		this.label5.AutoSize = true;
		this.label5.Location = new System.Drawing.Point(12, 534);
		this.label5.Name = "label5";
		this.label5.Size = new System.Drawing.Size(154, 13);
		this.label5.TabIndex = 1022;
		this.label5.Text = "Список клеток для автолеса";
		this.button1.Location = new System.Drawing.Point(390, 529);
		this.button1.Name = "button1";
		this.button1.Size = new System.Drawing.Size(305, 23);
		this.button1.TabIndex = 1023;
		this.button1.Text = "Добавить клетку к маршруту автолеса";
		this.button1.UseVisualStyleBackColor = true;
		this.button1.Click += new System.EventHandler(button1_Click);
		this.autoForestCells.Location = new System.Drawing.Point(15, 555);
		this.autoForestCells.Multiline = true;
		this.autoForestCells.Name = "autoForestCells";
		this.autoForestCells.ReadOnly = true;
		this.autoForestCells.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
		this.autoForestCells.Size = new System.Drawing.Size(680, 39);
		this.autoForestCells.TabIndex = 1024;
		base.AcceptButton = this.buttonOk;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		base.CancelButton = this.buttonCancel;
		base.ClientSize = new System.Drawing.Size(714, 606);
		base.Controls.Add(this.autoForestCells);
		base.Controls.Add(this.button1);
		base.Controls.Add(this.label5);
		base.Controls.Add(this.groupBox3);
		base.Controls.Add(this.groupBox2);
		base.Controls.Add(this.groupBox1);
		base.Controls.Add(this.buttonOk);
		base.Controls.Add(this.buttonCancel);
		this.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "FormNavigator";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Навигатор";
		base.Load += new System.EventHandler(FormNavigator_Load);
		this.groupBox1.ResumeLayout(false);
		this.groupBox1.PerformLayout();
		this.groupBox2.ResumeLayout(false);
		this.groupBox3.ResumeLayout(false);
		this.groupBox3.PerformLayout();
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
