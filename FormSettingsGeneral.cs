using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

internal sealed class FormSettingsGeneral : Form
{
	private IContainer icontainer_0;

	private Button buttonOk;

	private Button buttonCancel;

	private TabControl tabControlSettings;

	private TabPage tabPage1;

	private GroupBox groupBox22;

	private TextBox textAutoWearComplect;

	private CheckBox checkDoAutoCure;

	private CheckBox checkDoStopOnDig;

	private CheckBox checkDoRob;

	private CheckBox checkShowOverWarning;

	private GroupBox groupBoxDoAutoDrinkBlaz;

	private ComboBox comboBoxDoAutoDrinkBlaz;

	private TextBox textBoxAutoDrinkBlazTied;

	private CheckBox checkBoxDoAutoDrinkBlaz;

	private GroupBox groupBox25;

	private CheckBox checkDoShowFastAttackTotem;

	private CheckBox checkDoShowFastAttackClosed;

	private CheckBox checkDoShowFastAttackZas;

	private CheckBox checkDoShowFastAttackFog;

	private CheckBox checkDoShowFastAttackClosedUltimate;

	private CheckBox checkDoShowFastAttackNevid;

	private CheckBox checkDoShowFastAttackStrong;

	private CheckBox checkDoShowFastAttackPoison;

	private CheckBox checkDoShowFastAttackOpenNevid;

	private CheckBox checkDoShowFastAttackClosedFist;

	private CheckBox checkDoShowFastAttackFist;

	private CheckBox checkDoShowFastAttackUltimate;

	private CheckBox checkDoShowFastAttackBlood;

	private CheckBox checkDoShowFastAttack;

	private GroupBox groupBox24;

	private CheckBox checkDoInvPackDolg;

	private CheckBox checkDoInvPack;

	private CheckBox checkLightForum;

	private GroupBox groupBox10;

	private CheckBox checkboxShowTrayBaloons;

	private CheckBox checkboxDoTray;

	private CheckBox checkboxDoPromptExit;

	private TabPage tabPage2;

	private GroupBox groupBox14;

	private CheckBox checkStatReset;

	private CheckBox checkDoChatLevels;

	private GroupBox groupBox1;

	private CheckBox checkboxDoKeepChatGame;

	private CheckBox checkboxDoKeepChatLog;

	private TabPage tabPage3;

	private GroupBox groupBox20;

	private FlowLayoutPanel flowLayoutPanel5;

	private Label label18;

	private NumericUpDown numBigMapWidth;

	private Label label25;

	private NumericUpDown numBigMapHeight;

	private Label label2;

	private TabPage tabPage5;

	private CheckBox checkboxFishChatReportColor;

	private GroupBox groupBox13;

	private CheckBox checkFishTiedZero;

	private FlowLayoutPanel flowLayoutPanel6;

	private Label label13;

	private NumericUpDown numFishTiedHigh;

	private GroupBox groupBox12;

	private CheckBox checkPrimMorm;

	private CheckBox checkPrimHiFlight;

	private CheckBox checkPrimDonka;

	private CheckBox checkPrimLight;

	private CheckBox checkPrimFly;

	private CheckBox checkPrimStink;

	private CheckBox checkPrimBigWorm;

	private CheckBox checkPrimWorm;

	private CheckBox checkPrimBread;

	private GroupBox groupBox11;

	private ComboBox comboFishHand2;

	private ComboBox comboFishHand1;

	private CheckBox checkFishAutoWear;

	private CheckBox checkboxStopOverW;

	private TabPage tabPage7;

	private TextBox textPhraz;

	private FlowLayoutPanel flowLayoutPanel4;

	private Label label8;

	private NumericUpDown numAdvMin;

	private Label label1;

	private NumericUpDown numAdvSec;

	private Label label4;

	private TabPage tabPage9;

	private CheckBox checkAutoAnswer;

	private Label label14;

	private TextBox textAutoAnswer;

	private Label label15;

	private TabPage tabPage8;

	private CheckBox checkD04;

	private GroupBox groupBox21;

	private CheckBox checkE4;

	private CheckBox checkE3;

	private CheckBox checkE2;

	private CheckBox checkE1;

	private Label label23;

	private TextBox textCureBoi;

	private TextBox textCureAfter;

	private TextBox textCureAdv;

	private Label label22;

	private GroupBox groupBox18;

	private TextBox textCureAsk4;

	private TextBox textCureAsk3;

	private TextBox textCureAsk2;

	private TextBox textCureAsk1;

	private GroupBox groupBox17;

	private NumericUpDown numCureNV4;

	private NumericUpDown numCureNV3;

	private NumericUpDown numCureNV2;

	private NumericUpDown numCureNV1;

	private Label label16;

	private TabPage tabPage6;

	private CheckBox checkDoPlayTimer;

	private CheckBox checkDoPlayAlarm;

	private CheckBox checkDoPlayRefresh;

	private CheckBox checkDoPlaySndMsg;

	private CheckBox checkDoPlayAttack;

	private CheckBox checkDoPlayDigits;

	private CheckBox checkUseSounds;

	private CheckBox RemoveBuildingImagesCheckbox;

	private TabPage tabPage4;

	private GroupBox groupBox2;

	private NumericUpDown DNVNVLimit;

	private Label label26;

	private NumericUpDown DNVFrequency;

	private Label label24;

	private CheckBox checkDoShowFastAttackPortal;

	private CheckBox contactsToClan;

	private CheckBox checkDoSummDolg;

	private CheckBox checkStatSaveToFile;

	private GroupBox groupBox3;

	private Label label3;

	private TextBox textHighlightResources;

	private TextBox antiCaptchaKey;

	private Label label5;

	private Label label6;

	private TextBox autoForestCells;

	private CheckBox checkDoPlayActionEnd;

	private CheckBox FoodCheckBox;

	private CheckBox checkDoShowFastAttackImp;

	internal FormSettingsGeneral()
	{
		InitializeComponent();
		checkBoxDoAutoDrinkBlaz.Checked = Class72.class19_0.method_126();
		FoodCheckBox.Checked = Class72.class19_0.method_130();
		textBoxAutoDrinkBlazTied.Text = Class72.class19_0.method_128().ToString(CultureInfo.InvariantCulture);
		checkboxDoPromptExit.Checked = Class72.class19_0.method_40();
		checkboxDoTray.Checked = Class72.class19_0.method_122();
		checkboxShowTrayBaloons.Checked = Class72.class19_0.method_124();
		checkboxDoKeepChatGame.Checked = Class72.class19_0.method_104();
		checkboxDoKeepChatLog.Checked = Class72.class19_0.method_106();
		checkDoChatLevels.Checked = Class72.class19_0.method_112();
		checkStatReset.Checked = Class72.class19_0.class17_0.bool_0;
		checkStatSaveToFile.Checked = Class72.class19_0.class17_0.bool_1;
		numCureNV1.Value = Class72.class19_0.method_60()[0];
		numCureNV2.Value = Class72.class19_0.method_60()[1];
		numCureNV3.Value = Class72.class19_0.method_60()[2];
		numCureNV4.Value = Class72.class19_0.method_60()[3];
		textCureAsk1.Text = Class72.class19_0.method_62()[0];
		textCureAsk2.Text = Class72.class19_0.method_62()[1];
		textCureAsk3.Text = Class72.class19_0.method_62()[2];
		textCureAsk4.Text = Class72.class19_0.method_62()[3];
		textCureAdv.Text = Class72.class19_0.method_64();
		textCureAfter.Text = Class72.class19_0.method_66();
		textCureBoi.Text = Class72.class19_0.method_68();
		checkE1.Checked = Class72.class19_0.method_70()[0];
		checkE2.Checked = Class72.class19_0.method_70()[1];
		checkE3.Checked = Class72.class19_0.method_70()[2];
		checkE4.Checked = Class72.class19_0.method_70()[3];
		checkD04.Checked = Class72.class19_0.method_72();
		numBigMapWidth.Maximum = 19m;
		numBigMapWidth.Minimum = 3m;
		numBigMapWidth.Value = Class72.class19_0.method_54();
		numBigMapHeight.Maximum = 19m;
		numBigMapHeight.Minimum = 3m;
		numBigMapHeight.Value = Class72.class19_0.method_56();
		numFishTiedHigh.Value = Class72.class19_0.method_78();
		checkFishTiedZero.Checked = Class72.class19_0.method_80();
		checkboxStopOverW.Checked = Class72.class19_0.method_82();
		checkUseSounds.Checked = Class72.class19_0.tsound_0.Enabled;
		checkDoPlayDigits.Checked = Class72.class19_0.tsound_0.DoPlayDigits;
		checkDoPlayAttack.Checked = Class72.class19_0.tsound_0.DoPlayAttack;
		checkDoPlaySndMsg.Checked = Class72.class19_0.tsound_0.DoPlaySndMsg;
		checkDoPlayRefresh.Checked = Class72.class19_0.tsound_0.DoPlayRefresh;
		checkDoPlayAlarm.Checked = Class72.class19_0.tsound_0.DoPlayAlarm;
		checkDoPlayTimer.Checked = Class72.class19_0.tsound_0.DoPlayTimer;
		checkDoPlayActionEnd.Checked = Class72.class19_0.tsound_0.DoPlayActionEnd;
		numAdvMin.Value = (int)((decimal)Class72.class19_0.struct16_0.int_0 / 60m);
		numAdvSec.Value = Class72.class19_0.struct16_0.int_0 % 60;
		textPhraz.Text = Class72.class19_0.struct16_0.string_0;
		checkFishAutoWear.Checked = Class72.class19_0.method_84();
		for (int i = 0; i < comboFishHand1.Items.Count; i++)
		{
			if (Class72.class19_0.method_86().Equals((string)comboFishHand1.Items[i], StringComparison.OrdinalIgnoreCase))
			{
				comboFishHand1.SelectedIndex = i;
				break;
			}
		}
		if (comboFishHand1.SelectedIndex == -1)
		{
			comboFishHand1.SelectedIndex = 0;
		}
		for (int j = 0; j < comboFishHand2.Items.Count; j++)
		{
			if (Class72.class19_0.method_88().Equals((string)comboFishHand2.Items[j], StringComparison.OrdinalIgnoreCase))
			{
				comboFishHand2.SelectedIndex = j;
				break;
			}
		}
		if (comboFishHand2.SelectedIndex == -1)
		{
			comboFishHand2.SelectedIndex = 0;
		}
		checkPrimBread.Checked = (Class72.class19_0.method_90() & (Enum0)1) != 0;
		checkPrimWorm.Checked = (Class72.class19_0.method_90() & (Enum0)2) != 0;
		checkPrimBigWorm.Checked = (Class72.class19_0.method_90() & (Enum0)4) != 0;
		checkPrimStink.Checked = (Class72.class19_0.method_90() & (Enum0)8) != 0;
		checkPrimFly.Checked = (Class72.class19_0.method_90() & (Enum0)16) != 0;
		checkPrimLight.Checked = (Class72.class19_0.method_90() & (Enum0)32) != 0;
		checkPrimMorm.Checked = (Class72.class19_0.method_90() & (Enum0)128) != 0;
		checkPrimHiFlight.Checked = (Class72.class19_0.method_90() & (Enum0)256) != 0;
		checkPrimDonka.Checked = (Class72.class19_0.method_90() & (Enum0)64) != 0;
		checkboxFishChatReportColor.Checked = Class72.class19_0.method_98();
		checkAutoAnswer.Checked = Class72.class19_0.method_74();
		textAutoAnswer.Text = Class72.class19_0.method_76().Replace("[BR]", Environment.NewLine);
		checkLightForum.Checked = Class72.class19_0.method_108();
		RemoveBuildingImagesCheckbox.Checked = Class72.class19_0.method_110();
		checkDoInvPack.Checked = Class72.class19_0.method_144();
		checkDoInvPackDolg.Checked = Class72.class19_0.method_146();
		checkDoSummDolg.Checked = Class72.class19_0.method_148();
		checkDoShowFastAttack.Checked = Class72.class19_0.method_150();
		checkDoShowFastAttackBlood.Checked = Class72.class19_0.method_152();
		checkDoShowFastAttackUltimate.Checked = Class72.class19_0.method_154();
		checkDoShowFastAttackClosedUltimate.Checked = Class72.class19_0.method_156();
		checkDoShowFastAttackClosed.Checked = Class72.class19_0.method_158();
		checkDoShowFastAttackFist.Checked = Class72.class19_0.method_160();
		checkDoShowFastAttackClosedFist.Checked = Class72.class19_0.method_162();
		checkDoShowFastAttackOpenNevid.Checked = Class72.class19_0.method_164();
		checkDoShowFastAttackPoison.Checked = Class72.class19_0.method_166();
		checkDoShowFastAttackImp.Checked = Class72.class19_0.method_168();
		checkDoShowFastAttackStrong.Checked = Class72.class19_0.method_170();
		checkDoShowFastAttackNevid.Checked = Class72.class19_0.method_172();
		checkDoShowFastAttackFog.Checked = Class72.class19_0.method_174();
		checkDoShowFastAttackZas.Checked = Class72.class19_0.method_176();
		checkDoShowFastAttackPortal.Checked = Class72.class19_0.method_178();
		checkDoShowFastAttackTotem.Checked = Class72.class19_0.method_180();
		checkShowOverWarning.Checked = Class72.class19_0.method_132();
		checkDoStopOnDig.Checked = Class72.class19_0.method_182();
		checkDoRob.Checked = Class72.class19_0.method_134();
		checkDoAutoCure.Checked = Class72.class19_0.method_136();
		textAutoWearComplect.Text = Class72.class19_0.method_138() ?? string.Empty;
		comboBoxDoAutoDrinkBlaz.SelectedIndex = Class72.class19_0.method_186();
		contactsToClan.Checked = Class72.class19_0.bool_54;
		DNVFrequency.Value = Class72.class19_0.method_194();
		DNVNVLimit.Value = Class72.class19_0.method_192();
		textHighlightResources.Text = Class72.class19_0.method_196();
		autoForestCells.Text = Class72.class19_0.method_200();
		antiCaptchaKey.Text = Class72.class19_0.method_198();
	}

	private void buttonOk_Click(object sender, EventArgs e)
	{
		Class72.class19_0.method_127(checkBoxDoAutoDrinkBlaz.Checked);
		Class72.class19_0.method_131(FoodCheckBox.Checked);
		if (!int.TryParse(textBoxAutoDrinkBlazTied.Text, out var result))
		{
			result = 84;
		}
		Class72.class19_0.method_129(result);
		Class72.class19_0.method_41(checkboxDoPromptExit.Checked);
		Class72.class19_0.method_123(checkboxDoTray.Checked);
		Class72.class19_0.method_125(checkboxShowTrayBaloons.Checked);
		Class72.class19_0.method_105(checkboxDoKeepChatGame.Checked);
		Class72.class19_0.method_107(checkboxDoKeepChatLog.Checked);
		Class72.class19_0.method_113(checkDoChatLevels.Checked);
		Class72.class19_0.method_135(checkDoRob.Checked);
		if (!Class72.class19_0.class17_0.bool_0 && checkStatReset.Checked)
		{
			Class72.class19_0.class17_0.int_0 = DateTime.Now.DayOfYear;
		}
		Class72.class19_0.class17_0.bool_0 = checkStatReset.Checked;
		Class72.class19_0.class17_0.bool_1 = checkStatSaveToFile.Checked;
		Class72.class19_0.method_60()[0] = (int)numCureNV1.Value;
		Class72.class19_0.method_60()[1] = (int)numCureNV2.Value;
		Class72.class19_0.method_60()[2] = (int)numCureNV3.Value;
		Class72.class19_0.method_60()[3] = (int)numCureNV4.Value;
		Class72.class19_0.method_62()[0] = textCureAsk1.Text;
		Class72.class19_0.method_62()[1] = textCureAsk2.Text;
		Class72.class19_0.method_62()[2] = textCureAsk3.Text;
		Class72.class19_0.method_62()[3] = textCureAsk4.Text;
		Class72.class19_0.method_65(textCureAdv.Text);
		Class72.class19_0.method_67(textCureAfter.Text);
		Class72.class19_0.method_69(textCureBoi.Text);
		Class72.class19_0.method_70()[0] = checkE1.Checked;
		Class72.class19_0.method_70()[1] = checkE2.Checked;
		Class72.class19_0.method_70()[2] = checkE3.Checked;
		Class72.class19_0.method_70()[3] = checkE4.Checked;
		Class72.class19_0.method_73(checkD04.Checked);
		Class72.class19_0.method_55((int)numBigMapWidth.Value);
		Class72.class19_0.method_57((int)numBigMapHeight.Value);
		Class72.class19_0.method_83(checkboxStopOverW.Checked);
		Class72.class19_0.tsound_0.Enabled = checkUseSounds.Checked;
		Class72.class19_0.tsound_0.DoPlayDigits = checkDoPlayDigits.Checked;
		Class72.class19_0.tsound_0.DoPlayAttack = checkDoPlayAttack.Checked;
		Class72.class19_0.tsound_0.DoPlaySndMsg = checkDoPlaySndMsg.Checked;
		Class72.class19_0.tsound_0.DoPlayRefresh = checkDoPlayRefresh.Checked;
		Class72.class19_0.tsound_0.DoPlayAlarm = checkDoPlayAlarm.Checked;
		Class72.class19_0.tsound_0.DoPlayTimer = checkDoPlayTimer.Checked;
		Class72.class19_0.tsound_0.DoPlayActionEnd = checkDoPlayActionEnd.Checked;
		Class72.class19_0.struct16_0.string_0 = textPhraz.Text;
		Class72.class19_0.struct16_0.int_0 = (int)(numAdvMin.Value * 60m + numAdvSec.Value);
		if (Class72.class19_0.struct16_0.int_0 < 30)
		{
			Class72.class19_0.struct16_0.int_0 = 600;
		}
		Class72.class19_0.method_85(checkFishAutoWear.Checked);
		Class72.class19_0.method_87((string)comboFishHand1.SelectedItem);
		Class72.class19_0.method_89((string)comboFishHand2.SelectedItem);
		Class72.class19_0.method_79((int)numFishTiedHigh.Value);
		Class72.class19_0.method_81(checkFishTiedZero.Checked);
		Class72.class19_0.method_91((Enum0)0);
		if (checkPrimBread.Checked)
		{
			Class19 class19_ = Class72.class19_0;
			class19_.method_91(class19_.method_90() + 1);
		}
		if (checkPrimWorm.Checked)
		{
			Class19 class19_2 = Class72.class19_0;
			class19_2.method_91(class19_2.method_90() + 2);
		}
		if (checkPrimBigWorm.Checked)
		{
			Class19 class19_3 = Class72.class19_0;
			class19_3.method_91(class19_3.method_90() + 4);
		}
		if (checkPrimStink.Checked)
		{
			Class19 class19_4 = Class72.class19_0;
			class19_4.method_91(class19_4.method_90() + 8);
		}
		if (checkPrimFly.Checked)
		{
			Class19 class19_5 = Class72.class19_0;
			class19_5.method_91(class19_5.method_90() + 16);
		}
		if (checkPrimLight.Checked)
		{
			Class19 class19_6 = Class72.class19_0;
			class19_6.method_91(class19_6.method_90() + 32);
		}
		if (checkPrimDonka.Checked)
		{
			Class19 class19_7 = Class72.class19_0;
			class19_7.method_91(class19_7.method_90() + 64);
		}
		if (checkPrimMorm.Checked)
		{
			Class19 class19_8 = Class72.class19_0;
			class19_8.method_91(class19_8.method_90() + 128);
		}
		if (checkPrimHiFlight.Checked)
		{
			Class19 class19_9 = Class72.class19_0;
			class19_9.method_91(class19_9.method_90() + 256);
		}
		Class72.class19_0.method_99(checkboxFishChatReportColor.Checked);
		Class72.class19_0.method_75(checkAutoAnswer.Checked);
		Class72.class19_0.method_77(textAutoAnswer.Text.Trim().Replace(Environment.NewLine, "[BR]"));
		Class73.smethod_0(Class72.class19_0.method_76());
		Class72.class19_0.method_109(checkLightForum.Checked);
		Class72.class19_0.method_111(RemoveBuildingImagesCheckbox.Checked);
		Class72.class19_0.method_145(checkDoInvPack.Checked);
		Class72.class19_0.method_147(checkDoInvPackDolg.Checked);
		Class72.class19_0.method_149(checkDoSummDolg.Checked);
		Class72.class19_0.method_151(checkDoShowFastAttack.Checked);
		Class72.class19_0.method_153(checkDoShowFastAttackBlood.Checked);
		Class72.class19_0.method_155(checkDoShowFastAttackUltimate.Checked);
		Class72.class19_0.method_157(checkDoShowFastAttackClosedUltimate.Checked);
		Class72.class19_0.method_159(checkDoShowFastAttackClosed.Checked);
		Class72.class19_0.method_161(checkDoShowFastAttackFist.Checked);
		Class72.class19_0.method_163(checkDoShowFastAttackClosedFist.Checked);
		Class72.class19_0.method_165(checkDoShowFastAttackOpenNevid.Checked);
		Class72.class19_0.method_167(checkDoShowFastAttackPoison.Checked);
		Class72.class19_0.method_169(checkDoShowFastAttackImp.Checked);
		Class72.class19_0.method_171(checkDoShowFastAttackStrong.Checked);
		Class72.class19_0.method_173(checkDoShowFastAttackNevid.Checked);
		Class72.class19_0.method_175(checkDoShowFastAttackFog.Checked);
		Class72.class19_0.method_177(checkDoShowFastAttackZas.Checked);
		Class72.class19_0.method_179(checkDoShowFastAttackPortal.Checked);
		Class72.class19_0.method_181(checkDoShowFastAttackTotem.Checked);
		Class72.class19_0.method_133(checkShowOverWarning.Checked);
		Class72.class19_0.method_183(checkDoStopOnDig.Checked);
		Class72.class19_0.method_137(checkDoAutoCure.Checked);
		Class72.class19_0.method_139(textAutoWearComplect.Text);
		Class72.class19_0.method_187(comboBoxDoAutoDrinkBlaz.SelectedIndex);
		Class72.class19_0.bool_54 = contactsToClan.Checked;
		Class72.class19_0.method_195((int)DNVFrequency.Value);
		Class72.class19_0.method_193((int)DNVNVLimit.Value);
		Class72.class19_0.method_197(textHighlightResources.Text);
		Class72.class19_0.method_201(autoForestCells.Text);
		Class72.class19_0.method_199(antiCaptchaKey.Text);
		Class72.class19_0.method_20();
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSettingsGeneral));
		this.buttonOk = new System.Windows.Forms.Button();
		this.buttonCancel = new System.Windows.Forms.Button();
		this.tabPage6 = new System.Windows.Forms.TabPage();
		this.checkDoPlayActionEnd = new System.Windows.Forms.CheckBox();
		this.checkDoPlayTimer = new System.Windows.Forms.CheckBox();
		this.checkDoPlayAlarm = new System.Windows.Forms.CheckBox();
		this.checkDoPlayRefresh = new System.Windows.Forms.CheckBox();
		this.checkDoPlaySndMsg = new System.Windows.Forms.CheckBox();
		this.checkDoPlayAttack = new System.Windows.Forms.CheckBox();
		this.checkDoPlayDigits = new System.Windows.Forms.CheckBox();
		this.checkUseSounds = new System.Windows.Forms.CheckBox();
		this.tabPage8 = new System.Windows.Forms.TabPage();
		this.checkD04 = new System.Windows.Forms.CheckBox();
		this.groupBox21 = new System.Windows.Forms.GroupBox();
		this.checkE4 = new System.Windows.Forms.CheckBox();
		this.checkE3 = new System.Windows.Forms.CheckBox();
		this.checkE2 = new System.Windows.Forms.CheckBox();
		this.checkE1 = new System.Windows.Forms.CheckBox();
		this.label23 = new System.Windows.Forms.Label();
		this.textCureBoi = new System.Windows.Forms.TextBox();
		this.textCureAfter = new System.Windows.Forms.TextBox();
		this.textCureAdv = new System.Windows.Forms.TextBox();
		this.label22 = new System.Windows.Forms.Label();
		this.groupBox18 = new System.Windows.Forms.GroupBox();
		this.textCureAsk4 = new System.Windows.Forms.TextBox();
		this.textCureAsk3 = new System.Windows.Forms.TextBox();
		this.textCureAsk2 = new System.Windows.Forms.TextBox();
		this.textCureAsk1 = new System.Windows.Forms.TextBox();
		this.groupBox17 = new System.Windows.Forms.GroupBox();
		this.numCureNV4 = new System.Windows.Forms.NumericUpDown();
		this.numCureNV3 = new System.Windows.Forms.NumericUpDown();
		this.numCureNV2 = new System.Windows.Forms.NumericUpDown();
		this.numCureNV1 = new System.Windows.Forms.NumericUpDown();
		this.label16 = new System.Windows.Forms.Label();
		this.tabPage9 = new System.Windows.Forms.TabPage();
		this.checkAutoAnswer = new System.Windows.Forms.CheckBox();
		this.label14 = new System.Windows.Forms.Label();
		this.textAutoAnswer = new System.Windows.Forms.TextBox();
		this.label15 = new System.Windows.Forms.Label();
		this.tabPage7 = new System.Windows.Forms.TabPage();
		this.textPhraz = new System.Windows.Forms.TextBox();
		this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
		this.label8 = new System.Windows.Forms.Label();
		this.numAdvMin = new System.Windows.Forms.NumericUpDown();
		this.label1 = new System.Windows.Forms.Label();
		this.numAdvSec = new System.Windows.Forms.NumericUpDown();
		this.label4 = new System.Windows.Forms.Label();
		this.tabPage5 = new System.Windows.Forms.TabPage();
		this.checkboxFishChatReportColor = new System.Windows.Forms.CheckBox();
		this.groupBox13 = new System.Windows.Forms.GroupBox();
		this.checkFishTiedZero = new System.Windows.Forms.CheckBox();
		this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
		this.label13 = new System.Windows.Forms.Label();
		this.numFishTiedHigh = new System.Windows.Forms.NumericUpDown();
		this.groupBox12 = new System.Windows.Forms.GroupBox();
		this.checkPrimMorm = new System.Windows.Forms.CheckBox();
		this.checkPrimHiFlight = new System.Windows.Forms.CheckBox();
		this.checkPrimDonka = new System.Windows.Forms.CheckBox();
		this.checkPrimLight = new System.Windows.Forms.CheckBox();
		this.checkPrimFly = new System.Windows.Forms.CheckBox();
		this.checkPrimStink = new System.Windows.Forms.CheckBox();
		this.checkPrimBigWorm = new System.Windows.Forms.CheckBox();
		this.checkPrimWorm = new System.Windows.Forms.CheckBox();
		this.checkPrimBread = new System.Windows.Forms.CheckBox();
		this.groupBox11 = new System.Windows.Forms.GroupBox();
		this.comboFishHand2 = new System.Windows.Forms.ComboBox();
		this.comboFishHand1 = new System.Windows.Forms.ComboBox();
		this.checkFishAutoWear = new System.Windows.Forms.CheckBox();
		this.checkboxStopOverW = new System.Windows.Forms.CheckBox();
		this.tabPage3 = new System.Windows.Forms.TabPage();
		this.autoForestCells = new System.Windows.Forms.TextBox();
		this.label6 = new System.Windows.Forms.Label();
		this.antiCaptchaKey = new System.Windows.Forms.TextBox();
		this.label5 = new System.Windows.Forms.Label();
		this.groupBox3 = new System.Windows.Forms.GroupBox();
		this.label3 = new System.Windows.Forms.Label();
		this.textHighlightResources = new System.Windows.Forms.TextBox();
		this.groupBox20 = new System.Windows.Forms.GroupBox();
		this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
		this.label18 = new System.Windows.Forms.Label();
		this.numBigMapWidth = new System.Windows.Forms.NumericUpDown();
		this.label25 = new System.Windows.Forms.Label();
		this.numBigMapHeight = new System.Windows.Forms.NumericUpDown();
		this.label2 = new System.Windows.Forms.Label();
		this.tabPage2 = new System.Windows.Forms.TabPage();
		this.groupBox14 = new System.Windows.Forms.GroupBox();
		this.checkStatSaveToFile = new System.Windows.Forms.CheckBox();
		this.checkStatReset = new System.Windows.Forms.CheckBox();
		this.checkDoChatLevels = new System.Windows.Forms.CheckBox();
		this.groupBox1 = new System.Windows.Forms.GroupBox();
		this.checkboxDoKeepChatGame = new System.Windows.Forms.CheckBox();
		this.checkboxDoKeepChatLog = new System.Windows.Forms.CheckBox();
		this.tabPage1 = new System.Windows.Forms.TabPage();
		this.contactsToClan = new System.Windows.Forms.CheckBox();
		this.RemoveBuildingImagesCheckbox = new System.Windows.Forms.CheckBox();
		this.groupBox22 = new System.Windows.Forms.GroupBox();
		this.textAutoWearComplect = new System.Windows.Forms.TextBox();
		this.checkDoAutoCure = new System.Windows.Forms.CheckBox();
		this.checkDoStopOnDig = new System.Windows.Forms.CheckBox();
		this.checkDoRob = new System.Windows.Forms.CheckBox();
		this.checkShowOverWarning = new System.Windows.Forms.CheckBox();
		this.groupBoxDoAutoDrinkBlaz = new System.Windows.Forms.GroupBox();
		this.FoodCheckBox = new System.Windows.Forms.CheckBox();
		this.comboBoxDoAutoDrinkBlaz = new System.Windows.Forms.ComboBox();
		this.textBoxAutoDrinkBlazTied = new System.Windows.Forms.TextBox();
		this.checkBoxDoAutoDrinkBlaz = new System.Windows.Forms.CheckBox();
		this.groupBox25 = new System.Windows.Forms.GroupBox();
		this.checkDoShowFastAttackImp = new System.Windows.Forms.CheckBox();
		this.checkDoShowFastAttackPortal = new System.Windows.Forms.CheckBox();
		this.checkDoShowFastAttackTotem = new System.Windows.Forms.CheckBox();
		this.checkDoShowFastAttackClosed = new System.Windows.Forms.CheckBox();
		this.checkDoShowFastAttackZas = new System.Windows.Forms.CheckBox();
		this.checkDoShowFastAttackFog = new System.Windows.Forms.CheckBox();
		this.checkDoShowFastAttackClosedUltimate = new System.Windows.Forms.CheckBox();
		this.checkDoShowFastAttackNevid = new System.Windows.Forms.CheckBox();
		this.checkDoShowFastAttackStrong = new System.Windows.Forms.CheckBox();
		this.checkDoShowFastAttackPoison = new System.Windows.Forms.CheckBox();
		this.checkDoShowFastAttackOpenNevid = new System.Windows.Forms.CheckBox();
		this.checkDoShowFastAttackClosedFist = new System.Windows.Forms.CheckBox();
		this.checkDoShowFastAttackFist = new System.Windows.Forms.CheckBox();
		this.checkDoShowFastAttackUltimate = new System.Windows.Forms.CheckBox();
		this.checkDoShowFastAttackBlood = new System.Windows.Forms.CheckBox();
		this.checkDoShowFastAttack = new System.Windows.Forms.CheckBox();
		this.groupBox24 = new System.Windows.Forms.GroupBox();
		this.checkDoSummDolg = new System.Windows.Forms.CheckBox();
		this.checkDoInvPackDolg = new System.Windows.Forms.CheckBox();
		this.checkDoInvPack = new System.Windows.Forms.CheckBox();
		this.checkLightForum = new System.Windows.Forms.CheckBox();
		this.groupBox10 = new System.Windows.Forms.GroupBox();
		this.checkboxShowTrayBaloons = new System.Windows.Forms.CheckBox();
		this.checkboxDoTray = new System.Windows.Forms.CheckBox();
		this.checkboxDoPromptExit = new System.Windows.Forms.CheckBox();
		this.tabControlSettings = new System.Windows.Forms.TabControl();
		this.tabPage4 = new System.Windows.Forms.TabPage();
		this.groupBox2 = new System.Windows.Forms.GroupBox();
		this.DNVNVLimit = new System.Windows.Forms.NumericUpDown();
		this.label26 = new System.Windows.Forms.Label();
		this.DNVFrequency = new System.Windows.Forms.NumericUpDown();
		this.label24 = new System.Windows.Forms.Label();
		this.tabPage6.SuspendLayout();
		this.tabPage8.SuspendLayout();
		this.groupBox21.SuspendLayout();
		this.groupBox18.SuspendLayout();
		this.groupBox17.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.numCureNV4).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.numCureNV3).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.numCureNV2).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.numCureNV1).BeginInit();
		this.tabPage9.SuspendLayout();
		this.tabPage7.SuspendLayout();
		this.flowLayoutPanel4.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.numAdvMin).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.numAdvSec).BeginInit();
		this.tabPage5.SuspendLayout();
		this.groupBox13.SuspendLayout();
		this.flowLayoutPanel6.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.numFishTiedHigh).BeginInit();
		this.groupBox12.SuspendLayout();
		this.groupBox11.SuspendLayout();
		this.tabPage3.SuspendLayout();
		this.groupBox3.SuspendLayout();
		this.groupBox20.SuspendLayout();
		this.flowLayoutPanel5.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.numBigMapWidth).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.numBigMapHeight).BeginInit();
		this.tabPage2.SuspendLayout();
		this.groupBox14.SuspendLayout();
		this.groupBox1.SuspendLayout();
		this.tabPage1.SuspendLayout();
		this.groupBox22.SuspendLayout();
		this.groupBoxDoAutoDrinkBlaz.SuspendLayout();
		this.groupBox25.SuspendLayout();
		this.groupBox24.SuspendLayout();
		this.groupBox10.SuspendLayout();
		this.tabControlSettings.SuspendLayout();
		this.tabPage4.SuspendLayout();
		this.groupBox2.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.DNVNVLimit).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.DNVFrequency).BeginInit();
		base.SuspendLayout();
		this.buttonOk.AutoSize = true;
		this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
		this.buttonOk.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
		this.buttonOk.Location = new System.Drawing.Point(396, 488);
		this.buttonOk.Name = "buttonOk";
		this.buttonOk.Size = new System.Drawing.Size(111, 23);
		this.buttonOk.TabIndex = 1007;
		this.buttonOk.Text = "Ввод";
		this.buttonOk.UseVisualStyleBackColor = true;
		this.buttonOk.Click += new System.EventHandler(buttonOk_Click);
		this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
		this.buttonCancel.Location = new System.Drawing.Point(513, 488);
		this.buttonCancel.Name = "buttonCancel";
		this.buttonCancel.Size = new System.Drawing.Size(85, 23);
		this.buttonCancel.TabIndex = 1008;
		this.buttonCancel.Text = "Отмена";
		this.buttonCancel.UseVisualStyleBackColor = true;
		this.tabPage6.Controls.Add(this.checkDoPlayActionEnd);
		this.tabPage6.Controls.Add(this.checkDoPlayTimer);
		this.tabPage6.Controls.Add(this.checkDoPlayAlarm);
		this.tabPage6.Controls.Add(this.checkDoPlayRefresh);
		this.tabPage6.Controls.Add(this.checkDoPlaySndMsg);
		this.tabPage6.Controls.Add(this.checkDoPlayAttack);
		this.tabPage6.Controls.Add(this.checkDoPlayDigits);
		this.tabPage6.Controls.Add(this.checkUseSounds);
		this.tabPage6.Location = new System.Drawing.Point(4, 22);
		this.tabPage6.Name = "tabPage6";
		this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
		this.tabPage6.Size = new System.Drawing.Size(594, 433);
		this.tabPage6.TabIndex = 5;
		this.tabPage6.Text = "Звуки";
		this.tabPage6.UseVisualStyleBackColor = true;
		this.checkDoPlayActionEnd.AutoSize = true;
		this.checkDoPlayActionEnd.Location = new System.Drawing.Point(16, 146);
		this.checkDoPlayActionEnd.Name = "checkDoPlayActionEnd";
		this.checkDoPlayActionEnd.Size = new System.Drawing.Size(259, 17);
		this.checkDoPlayActionEnd.TabIndex = 19;
		this.checkDoPlayActionEnd.Text = "Сигнал при завершении действия на природе";
		this.checkDoPlayActionEnd.TextAlign = System.Drawing.ContentAlignment.TopRight;
		this.checkDoPlayActionEnd.UseVisualStyleBackColor = true;
		this.checkDoPlayTimer.AutoSize = true;
		this.checkDoPlayTimer.Location = new System.Drawing.Point(16, 128);
		this.checkDoPlayTimer.Name = "checkDoPlayTimer";
		this.checkDoPlayTimer.Size = new System.Drawing.Size(204, 17);
		this.checkDoPlayTimer.TabIndex = 18;
		this.checkDoPlayTimer.Text = "Сигнал при срабатывании таймера";
		this.checkDoPlayTimer.TextAlign = System.Drawing.ContentAlignment.TopRight;
		this.checkDoPlayTimer.UseVisualStyleBackColor = true;
		this.checkDoPlayAlarm.AutoSize = true;
		this.checkDoPlayAlarm.Location = new System.Drawing.Point(16, 111);
		this.checkDoPlayAlarm.Name = "checkDoPlayAlarm";
		this.checkDoPlayAlarm.Size = new System.Drawing.Size(231, 17);
		this.checkDoPlayAlarm.TabIndex = 17;
		this.checkDoPlayAlarm.Text = "Сигнал при появлении людей на клетке";
		this.checkDoPlayAlarm.TextAlign = System.Drawing.ContentAlignment.TopRight;
		this.checkDoPlayAlarm.UseVisualStyleBackColor = true;
		this.checkDoPlayRefresh.AutoSize = true;
		this.checkDoPlayRefresh.Location = new System.Drawing.Point(16, 94);
		this.checkDoPlayRefresh.Name = "checkDoPlayRefresh";
		this.checkDoPlayRefresh.Size = new System.Drawing.Size(230, 17);
		this.checkDoPlayRefresh.TabIndex = 16;
		this.checkDoPlayRefresh.Text = "Сигнал при изменении верхнего фрейма";
		this.checkDoPlayRefresh.UseVisualStyleBackColor = true;
		this.checkDoPlaySndMsg.AutoSize = true;
		this.checkDoPlaySndMsg.Location = new System.Drawing.Point(16, 77);
		this.checkDoPlaySndMsg.Name = "checkDoPlaySndMsg";
		this.checkDoPlaySndMsg.Size = new System.Drawing.Size(179, 17);
		this.checkDoPlaySndMsg.TabIndex = 15;
		this.checkDoPlaySndMsg.Text = "Сигнал при обращении в чате";
		this.checkDoPlaySndMsg.UseVisualStyleBackColor = true;
		this.checkDoPlayAttack.AutoSize = true;
		this.checkDoPlayAttack.Location = new System.Drawing.Point(16, 60);
		this.checkDoPlayAttack.Name = "checkDoPlayAttack";
		this.checkDoPlayAttack.Size = new System.Drawing.Size(141, 17);
		this.checkDoPlayAttack.TabIndex = 14;
		this.checkDoPlayAttack.Text = "Сигнал при нападении";
		this.checkDoPlayAttack.UseVisualStyleBackColor = true;
		this.checkDoPlayDigits.AutoSize = true;
		this.checkDoPlayDigits.Location = new System.Drawing.Point(16, 43);
		this.checkDoPlayDigits.Name = "checkDoPlayDigits";
		this.checkDoPlayDigits.Size = new System.Drawing.Size(188, 17);
		this.checkDoPlayDigits.TabIndex = 13;
		this.checkDoPlayDigits.Text = "Сигнал на появившихся цифрах";
		this.checkDoPlayDigits.UseVisualStyleBackColor = true;
		this.checkUseSounds.AutoSize = true;
		this.checkUseSounds.Location = new System.Drawing.Point(16, 17);
		this.checkUseSounds.Name = "checkUseSounds";
		this.checkUseSounds.Size = new System.Drawing.Size(129, 17);
		this.checkUseSounds.TabIndex = 12;
		this.checkUseSounds.Text = "Использовать звуки";
		this.checkUseSounds.UseVisualStyleBackColor = true;
		this.tabPage8.Controls.Add(this.checkD04);
		this.tabPage8.Controls.Add(this.groupBox21);
		this.tabPage8.Controls.Add(this.label23);
		this.tabPage8.Controls.Add(this.textCureBoi);
		this.tabPage8.Controls.Add(this.textCureAfter);
		this.tabPage8.Controls.Add(this.textCureAdv);
		this.tabPage8.Controls.Add(this.label22);
		this.tabPage8.Controls.Add(this.groupBox18);
		this.tabPage8.Controls.Add(this.groupBox17);
		this.tabPage8.Controls.Add(this.label16);
		this.tabPage8.Location = new System.Drawing.Point(4, 22);
		this.tabPage8.Name = "tabPage8";
		this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
		this.tabPage8.Size = new System.Drawing.Size(594, 433);
		this.tabPage8.TabIndex = 7;
		this.tabPage8.Text = "Лечение";
		this.tabPage8.UseVisualStyleBackColor = true;
		this.checkD04.AutoSize = true;
		this.checkD04.Location = new System.Drawing.Point(21, 143);
		this.checkD04.Name = "checkD04";
		this.checkD04.Size = new System.Drawing.Size(212, 17);
		this.checkD04.TabIndex = 9;
		this.checkD04.Text = "Не работать с игроками 0-4 уровней";
		this.checkD04.UseVisualStyleBackColor = true;
		this.groupBox21.Controls.Add(this.checkE4);
		this.groupBox21.Controls.Add(this.checkE3);
		this.groupBox21.Controls.Add(this.checkE2);
		this.groupBox21.Controls.Add(this.checkE1);
		this.groupBox21.Location = new System.Drawing.Point(15, 5);
		this.groupBox21.Name = "groupBox21";
		this.groupBox21.Size = new System.Drawing.Size(88, 135);
		this.groupBox21.TabIndex = 8;
		this.groupBox21.TabStop = false;
		this.groupBox21.Text = "Вид травмы";
		this.checkE4.AutoSize = true;
		this.checkE4.Location = new System.Drawing.Point(6, 104);
		this.checkE4.Name = "checkE4";
		this.checkE4.Size = new System.Drawing.Size(62, 17);
		this.checkE4.TabIndex = 3;
		this.checkE4.Text = "Боевая";
		this.checkE4.UseVisualStyleBackColor = true;
		this.checkE3.AutoSize = true;
		this.checkE3.Location = new System.Drawing.Point(6, 78);
		this.checkE3.Name = "checkE3";
		this.checkE3.Size = new System.Drawing.Size(70, 17);
		this.checkE3.TabIndex = 2;
		this.checkE3.Text = "Тяжелая";
		this.checkE3.UseVisualStyleBackColor = true;
		this.checkE2.AutoSize = true;
		this.checkE2.Location = new System.Drawing.Point(6, 53);
		this.checkE2.Name = "checkE2";
		this.checkE2.Size = new System.Drawing.Size(70, 17);
		this.checkE2.TabIndex = 1;
		this.checkE2.Text = "Средняя";
		this.checkE2.UseVisualStyleBackColor = true;
		this.checkE1.AutoSize = true;
		this.checkE1.Location = new System.Drawing.Point(6, 26);
		this.checkE1.Name = "checkE1";
		this.checkE1.Size = new System.Drawing.Size(62, 17);
		this.checkE1.TabIndex = 0;
		this.checkE1.Text = "Легкая";
		this.checkE1.UseVisualStyleBackColor = true;
		this.label23.AutoSize = true;
		this.label23.Location = new System.Drawing.Point(12, 221);
		this.label23.Name = "label23";
		this.label23.Size = new System.Drawing.Size(63, 13);
		this.label23.TabIndex = 7;
		this.label23.Text = "Если в бою";
		this.textCureBoi.Location = new System.Drawing.Point(109, 218);
		this.textCureBoi.Name = "textCureBoi";
		this.textCureBoi.Size = new System.Drawing.Size(473, 21);
		this.textCureBoi.TabIndex = 6;
		this.textCureAfter.Location = new System.Drawing.Point(109, 191);
		this.textCureAfter.Name = "textCureAfter";
		this.textCureAfter.Size = new System.Drawing.Size(473, 21);
		this.textCureAfter.TabIndex = 4;
		this.textCureAdv.Location = new System.Drawing.Point(109, 164);
		this.textCureAdv.Name = "textCureAdv";
		this.textCureAdv.Size = new System.Drawing.Size(473, 21);
		this.textCureAdv.TabIndex = 0;
		this.label22.AutoSize = true;
		this.label22.Location = new System.Drawing.Point(12, 194);
		this.label22.Name = "label22";
		this.label22.Size = new System.Drawing.Size(82, 13);
		this.label22.TabIndex = 5;
		this.label22.Text = "После лечения";
		this.groupBox18.Controls.Add(this.textCureAsk4);
		this.groupBox18.Controls.Add(this.textCureAsk3);
		this.groupBox18.Controls.Add(this.textCureAsk2);
		this.groupBox18.Controls.Add(this.textCureAsk1);
		this.groupBox18.Location = new System.Drawing.Point(207, 6);
		this.groupBox18.Name = "groupBox18";
		this.groupBox18.Size = new System.Drawing.Size(228, 135);
		this.groupBox18.TabIndex = 3;
		this.groupBox18.TabStop = false;
		this.groupBox18.Text = "Вопрос";
		this.textCureAsk4.Location = new System.Drawing.Point(6, 102);
		this.textCureAsk4.Name = "textCureAsk4";
		this.textCureAsk4.Size = new System.Drawing.Size(216, 21);
		this.textCureAsk4.TabIndex = 3;
		this.textCureAsk3.Location = new System.Drawing.Point(6, 76);
		this.textCureAsk3.Name = "textCureAsk3";
		this.textCureAsk3.Size = new System.Drawing.Size(216, 21);
		this.textCureAsk3.TabIndex = 2;
		this.textCureAsk2.Location = new System.Drawing.Point(6, 51);
		this.textCureAsk2.Name = "textCureAsk2";
		this.textCureAsk2.Size = new System.Drawing.Size(216, 21);
		this.textCureAsk2.TabIndex = 1;
		this.textCureAsk1.Location = new System.Drawing.Point(6, 24);
		this.textCureAsk1.Name = "textCureAsk1";
		this.textCureAsk1.Size = new System.Drawing.Size(216, 21);
		this.textCureAsk1.TabIndex = 0;
		this.groupBox17.Controls.Add(this.numCureNV4);
		this.groupBox17.Controls.Add(this.numCureNV3);
		this.groupBox17.Controls.Add(this.numCureNV2);
		this.groupBox17.Controls.Add(this.numCureNV1);
		this.groupBox17.Location = new System.Drawing.Point(109, 5);
		this.groupBox17.Name = "groupBox17";
		this.groupBox17.Size = new System.Drawing.Size(92, 135);
		this.groupBox17.TabIndex = 2;
		this.groupBox17.TabStop = false;
		this.groupBox17.Text = "Цена лечения";
		this.numCureNV4.AutoSize = true;
		this.numCureNV4.Increment = new decimal(new int[4] { 10, 0, 0, 0 });
		this.numCureNV4.InterceptArrowKeys = false;
		this.numCureNV4.Location = new System.Drawing.Point(6, 104);
		this.numCureNV4.Maximum = new decimal(new int[4] { 7000, 0, 0, 0 });
		this.numCureNV4.Minimum = new decimal(new int[4] { 296, 0, 0, 0 });
		this.numCureNV4.Name = "numCureNV4";
		this.numCureNV4.ReadOnly = true;
		this.numCureNV4.Size = new System.Drawing.Size(47, 21);
		this.numCureNV4.TabIndex = 11;
		this.numCureNV4.Value = new decimal(new int[4] { 7000, 0, 0, 0 });
		this.numCureNV3.AutoSize = true;
		this.numCureNV3.InterceptArrowKeys = false;
		this.numCureNV3.Location = new System.Drawing.Point(6, 77);
		this.numCureNV3.Maximum = new decimal(new int[4] { 500, 0, 0, 0 });
		this.numCureNV3.Minimum = new decimal(new int[4] { 11, 0, 0, 0 });
		this.numCureNV3.Name = "numCureNV3";
		this.numCureNV3.ReadOnly = true;
		this.numCureNV3.Size = new System.Drawing.Size(45, 21);
		this.numCureNV3.TabIndex = 9;
		this.numCureNV3.Value = new decimal(new int[4] { 500, 0, 0, 0 });
		this.numCureNV2.AutoSize = true;
		this.numCureNV2.InterceptArrowKeys = false;
		this.numCureNV2.Location = new System.Drawing.Point(6, 52);
		this.numCureNV2.Maximum = new decimal(new int[4] { 150, 0, 0, 0 });
		this.numCureNV2.Minimum = new decimal(new int[4] { 8, 0, 0, 0 });
		this.numCureNV2.Name = "numCureNV2";
		this.numCureNV2.ReadOnly = true;
		this.numCureNV2.Size = new System.Drawing.Size(45, 21);
		this.numCureNV2.TabIndex = 7;
		this.numCureNV2.Value = new decimal(new int[4] { 150, 0, 0, 0 });
		this.numCureNV1.AutoSize = true;
		this.numCureNV1.InterceptArrowKeys = false;
		this.numCureNV1.Location = new System.Drawing.Point(6, 25);
		this.numCureNV1.Maximum = new decimal(new int[4] { 80, 0, 0, 0 });
		this.numCureNV1.Minimum = new decimal(new int[4] { 5, 0, 0, 0 });
		this.numCureNV1.Name = "numCureNV1";
		this.numCureNV1.ReadOnly = true;
		this.numCureNV1.Size = new System.Drawing.Size(39, 21);
		this.numCureNV1.TabIndex = 5;
		this.numCureNV1.Value = new decimal(new int[4] { 80, 0, 0, 0 });
		this.label16.AutoSize = true;
		this.label16.Location = new System.Drawing.Point(12, 167);
		this.label16.Name = "label16";
		this.label16.Size = new System.Drawing.Size(94, 13);
		this.label16.TabIndex = 1;
		this.label16.Text = "Реклама лечения";
		this.tabPage9.Controls.Add(this.checkAutoAnswer);
		this.tabPage9.Controls.Add(this.label14);
		this.tabPage9.Controls.Add(this.textAutoAnswer);
		this.tabPage9.Controls.Add(this.label15);
		this.tabPage9.Location = new System.Drawing.Point(4, 22);
		this.tabPage9.Name = "tabPage9";
		this.tabPage9.Padding = new System.Windows.Forms.Padding(3);
		this.tabPage9.Size = new System.Drawing.Size(594, 433);
		this.tabPage9.TabIndex = 8;
		this.tabPage9.Text = "Автоответ";
		this.tabPage9.UseVisualStyleBackColor = true;
		this.checkAutoAnswer.AutoSize = true;
		this.checkAutoAnswer.Location = new System.Drawing.Point(22, 16);
		this.checkAutoAnswer.Name = "checkAutoAnswer";
		this.checkAutoAnswer.Size = new System.Drawing.Size(131, 17);
		this.checkAutoAnswer.TabIndex = 10;
		this.checkAutoAnswer.Text = "Работает автоответ";
		this.checkAutoAnswer.UseVisualStyleBackColor = true;
		this.label14.AutoSize = true;
		this.label14.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
		this.label14.Location = new System.Drawing.Point(19, 402);
		this.label14.Name = "label14";
		this.label14.Size = new System.Drawing.Size(367, 13);
		this.label14.TabIndex = 9;
		this.label14.Text = "* при ответе выбирается случайная строчка; повторения избегаются";
		this.textAutoAnswer.AcceptsReturn = true;
		this.textAutoAnswer.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.textAutoAnswer.Location = new System.Drawing.Point(6, 70);
		this.textAutoAnswer.Multiline = true;
		this.textAutoAnswer.Name = "textAutoAnswer";
		this.textAutoAnswer.ScrollBars = System.Windows.Forms.ScrollBars.Both;
		this.textAutoAnswer.Size = new System.Drawing.Size(582, 319);
		this.textAutoAnswer.TabIndex = 8;
		this.textAutoAnswer.Text = "Всем превед!\r\nФраза #2\r\nФраза #3\r\nФраза #4\r\nФраза #5\r\nФраза #6\r\nФраза #7\r\nФраза #8\r\nФраза #9";
		this.textAutoAnswer.WordWrap = false;
		this.label15.AutoSize = true;
		this.label15.Location = new System.Drawing.Point(19, 45);
		this.label15.Name = "label15";
		this.label15.Size = new System.Drawing.Size(196, 13);
		this.label15.TabIndex = 7;
		this.label15.Text = "Фразы автоответа (строчка - фраза)";
		this.tabPage7.Controls.Add(this.textPhraz);
		this.tabPage7.Controls.Add(this.flowLayoutPanel4);
		this.tabPage7.Location = new System.Drawing.Point(4, 22);
		this.tabPage7.Name = "tabPage7";
		this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
		this.tabPage7.Size = new System.Drawing.Size(594, 433);
		this.tabPage7.TabIndex = 6;
		this.tabPage7.Text = "Автореклама";
		this.tabPage7.UseVisualStyleBackColor = true;
		this.textPhraz.AcceptsReturn = true;
		this.textPhraz.Location = new System.Drawing.Point(6, 43);
		this.textPhraz.Multiline = true;
		this.textPhraz.Name = "textPhraz";
		this.textPhraz.ScrollBars = System.Windows.Forms.ScrollBars.Both;
		this.textPhraz.Size = new System.Drawing.Size(582, 384);
		this.textPhraz.TabIndex = 1013;
		this.textPhraz.WordWrap = false;
		this.flowLayoutPanel4.Controls.Add(this.label8);
		this.flowLayoutPanel4.Controls.Add(this.numAdvMin);
		this.flowLayoutPanel4.Controls.Add(this.label1);
		this.flowLayoutPanel4.Controls.Add(this.numAdvSec);
		this.flowLayoutPanel4.Controls.Add(this.label4);
		this.flowLayoutPanel4.Location = new System.Drawing.Point(6, 6);
		this.flowLayoutPanel4.Name = "flowLayoutPanel4";
		this.flowLayoutPanel4.Size = new System.Drawing.Size(582, 30);
		this.flowLayoutPanel4.TabIndex = 1012;
		this.label8.AutoSize = true;
		this.label8.Location = new System.Drawing.Point(3, 6);
		this.label8.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
		this.label8.Name = "label8";
		this.label8.Size = new System.Drawing.Size(188, 13);
		this.label8.TabIndex = 1016;
		this.label8.Text = "Отправлять в чат рекламу каждые";
		this.numAdvMin.AutoSize = true;
		this.numAdvMin.InterceptArrowKeys = false;
		this.numAdvMin.Location = new System.Drawing.Point(197, 3);
		this.numAdvMin.Maximum = new decimal(new int[4] { 59, 0, 0, 0 });
		this.numAdvMin.Name = "numAdvMin";
		this.numAdvMin.ReadOnly = true;
		this.numAdvMin.Size = new System.Drawing.Size(35, 21);
		this.numAdvMin.TabIndex = 1012;
		this.numAdvMin.Value = new decimal(new int[4] { 9, 0, 0, 0 });
		this.label1.AutoSize = true;
		this.label1.Location = new System.Drawing.Point(238, 6);
		this.label1.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(25, 13);
		this.label1.TabIndex = 1013;
		this.label1.Text = "мин";
		this.numAdvSec.AutoSize = true;
		this.numAdvSec.InterceptArrowKeys = false;
		this.numAdvSec.Location = new System.Drawing.Point(269, 3);
		this.numAdvSec.Maximum = new decimal(new int[4] { 59, 0, 0, 0 });
		this.numAdvSec.Name = "numAdvSec";
		this.numAdvSec.ReadOnly = true;
		this.numAdvSec.Size = new System.Drawing.Size(35, 21);
		this.numAdvSec.TabIndex = 1014;
		this.numAdvSec.Value = new decimal(new int[4] { 5, 0, 0, 0 });
		this.label4.AutoSize = true;
		this.label4.Location = new System.Drawing.Point(310, 6);
		this.label4.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(24, 13);
		this.label4.TabIndex = 1015;
		this.label4.Text = "сек";
		this.tabPage5.Controls.Add(this.checkboxFishChatReportColor);
		this.tabPage5.Controls.Add(this.groupBox13);
		this.tabPage5.Controls.Add(this.groupBox12);
		this.tabPage5.Controls.Add(this.groupBox11);
		this.tabPage5.Controls.Add(this.checkboxStopOverW);
		this.tabPage5.Location = new System.Drawing.Point(4, 22);
		this.tabPage5.Name = "tabPage5";
		this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
		this.tabPage5.Size = new System.Drawing.Size(594, 433);
		this.tabPage5.TabIndex = 4;
		this.tabPage5.Text = "Авторыбалка";
		this.tabPage5.UseVisualStyleBackColor = true;
		this.checkboxFishChatReportColor.AutoSize = true;
		this.checkboxFishChatReportColor.Location = new System.Drawing.Point(282, 133);
		this.checkboxFishChatReportColor.Name = "checkboxFishChatReportColor";
		this.checkboxFishChatReportColor.Size = new System.Drawing.Size(222, 17);
		this.checkboxFishChatReportColor.TabIndex = 1031;
		this.checkboxFishChatReportColor.Text = "Выводить результаты улова в приват";
		this.checkboxFishChatReportColor.UseVisualStyleBackColor = true;
		this.groupBox13.Controls.Add(this.checkFishTiedZero);
		this.groupBox13.Controls.Add(this.flowLayoutPanel6);
		this.groupBox13.Location = new System.Drawing.Point(276, 14);
		this.groupBox13.Name = "groupBox13";
		this.groupBox13.Size = new System.Drawing.Size(237, 80);
		this.groupBox13.TabIndex = 1029;
		this.groupBox13.TabStop = false;
		this.groupBox13.Text = "Автопитье";
		this.checkFishTiedZero.AutoSize = true;
		this.checkFishTiedZero.Location = new System.Drawing.Point(12, 57);
		this.checkFishTiedZero.Name = "checkFishTiedZero";
		this.checkFishTiedZero.Size = new System.Drawing.Size(149, 17);
		this.checkFishTiedZero.TabIndex = 1030;
		this.checkFishTiedZero.Text = "Пить до нуля усталости";
		this.checkFishTiedZero.UseVisualStyleBackColor = true;
		this.flowLayoutPanel6.Controls.Add(this.label13);
		this.flowLayoutPanel6.Controls.Add(this.numFishTiedHigh);
		this.flowLayoutPanel6.Location = new System.Drawing.Point(6, 21);
		this.flowLayoutPanel6.Name = "flowLayoutPanel6";
		this.flowLayoutPanel6.Size = new System.Drawing.Size(225, 30);
		this.flowLayoutPanel6.TabIndex = 0;
		this.label13.AutoSize = true;
		this.label13.Location = new System.Drawing.Point(3, 6);
		this.label13.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
		this.label13.Name = "label13";
		this.label13.Size = new System.Drawing.Size(169, 13);
		this.label13.TabIndex = 3;
		this.label13.Text = "Глоток, если усталость больше";
		this.numFishTiedHigh.AutoSize = true;
		this.numFishTiedHigh.InterceptArrowKeys = false;
		this.numFishTiedHigh.Location = new System.Drawing.Point(178, 3);
		this.numFishTiedHigh.Maximum = new decimal(new int[4] { 99, 0, 0, 0 });
		this.numFishTiedHigh.Name = "numFishTiedHigh";
		this.numFishTiedHigh.ReadOnly = true;
		this.numFishTiedHigh.Size = new System.Drawing.Size(35, 21);
		this.numFishTiedHigh.TabIndex = 4;
		this.numFishTiedHigh.Value = new decimal(new int[4] { 60, 0, 0, 0 });
		this.groupBox12.Controls.Add(this.checkPrimMorm);
		this.groupBox12.Controls.Add(this.checkPrimHiFlight);
		this.groupBox12.Controls.Add(this.checkPrimDonka);
		this.groupBox12.Controls.Add(this.checkPrimLight);
		this.groupBox12.Controls.Add(this.checkPrimFly);
		this.groupBox12.Controls.Add(this.checkPrimStink);
		this.groupBox12.Controls.Add(this.checkPrimBigWorm);
		this.groupBox12.Controls.Add(this.checkPrimWorm);
		this.groupBox12.Controls.Add(this.checkPrimBread);
		this.groupBox12.Location = new System.Drawing.Point(15, 133);
		this.groupBox12.Name = "groupBox12";
		this.groupBox12.Size = new System.Drawing.Size(246, 135);
		this.groupBox12.TabIndex = 1028;
		this.groupBox12.TabStop = false;
		this.groupBox12.Text = "Используемая приманка";
		this.checkPrimMorm.AutoSize = true;
		this.checkPrimMorm.Location = new System.Drawing.Point(146, 83);
		this.checkPrimMorm.Name = "checkPrimMorm";
		this.checkPrimMorm.Size = new System.Drawing.Size(80, 17);
		this.checkPrimMorm.TabIndex = 8;
		this.checkPrimMorm.Text = "Мормышка";
		this.checkPrimMorm.UseVisualStyleBackColor = true;
		this.checkPrimHiFlight.AutoSize = true;
		this.checkPrimHiFlight.Location = new System.Drawing.Point(13, 102);
		this.checkPrimHiFlight.Name = "checkPrimHiFlight";
		this.checkPrimHiFlight.Size = new System.Drawing.Size(135, 17);
		this.checkPrimHiFlight.TabIndex = 7;
		this.checkPrimHiFlight.Text = "Заговоренная блесна";
		this.checkPrimHiFlight.UseVisualStyleBackColor = true;
		this.checkPrimDonka.AutoSize = true;
		this.checkPrimDonka.Location = new System.Drawing.Point(13, 83);
		this.checkPrimDonka.Name = "checkPrimDonka";
		this.checkPrimDonka.Size = new System.Drawing.Size(58, 17);
		this.checkPrimDonka.TabIndex = 6;
		this.checkPrimDonka.Text = "Донка";
		this.checkPrimDonka.UseVisualStyleBackColor = true;
		this.checkPrimLight.AutoSize = true;
		this.checkPrimLight.Location = new System.Drawing.Point(146, 64);
		this.checkPrimLight.Name = "checkPrimLight";
		this.checkPrimLight.Size = new System.Drawing.Size(61, 17);
		this.checkPrimLight.TabIndex = 5;
		this.checkPrimLight.Text = "Блесна";
		this.checkPrimLight.UseVisualStyleBackColor = true;
		this.checkPrimFly.AutoSize = true;
		this.checkPrimFly.Location = new System.Drawing.Point(146, 45);
		this.checkPrimFly.Name = "checkPrimFly";
		this.checkPrimFly.Size = new System.Drawing.Size(66, 17);
		this.checkPrimFly.TabIndex = 4;
		this.checkPrimFly.Text = "Мотыль";
		this.checkPrimFly.UseVisualStyleBackColor = true;
		this.checkPrimStink.AutoSize = true;
		this.checkPrimStink.Location = new System.Drawing.Point(146, 26);
		this.checkPrimStink.Name = "checkPrimStink";
		this.checkPrimStink.Size = new System.Drawing.Size(68, 17);
		this.checkPrimStink.TabIndex = 3;
		this.checkPrimStink.Text = "Опарыш";
		this.checkPrimStink.UseVisualStyleBackColor = true;
		this.checkPrimBigWorm.AutoSize = true;
		this.checkPrimBigWorm.Location = new System.Drawing.Point(13, 64);
		this.checkPrimBigWorm.Name = "checkPrimBigWorm";
		this.checkPrimBigWorm.Size = new System.Drawing.Size(110, 17);
		this.checkPrimBigWorm.TabIndex = 2;
		this.checkPrimBigWorm.Text = "Крупный червяк";
		this.checkPrimBigWorm.UseVisualStyleBackColor = true;
		this.checkPrimWorm.AutoSize = true;
		this.checkPrimWorm.Location = new System.Drawing.Point(13, 45);
		this.checkPrimWorm.Name = "checkPrimWorm";
		this.checkPrimWorm.Size = new System.Drawing.Size(63, 17);
		this.checkPrimWorm.TabIndex = 1;
		this.checkPrimWorm.Text = "Червяк";
		this.checkPrimWorm.UseVisualStyleBackColor = true;
		this.checkPrimBread.AutoSize = true;
		this.checkPrimBread.Location = new System.Drawing.Point(13, 26);
		this.checkPrimBread.Name = "checkPrimBread";
		this.checkPrimBread.Size = new System.Drawing.Size(50, 17);
		this.checkPrimBread.TabIndex = 0;
		this.checkPrimBread.Text = "Хлеб";
		this.checkPrimBread.UseVisualStyleBackColor = true;
		this.groupBox11.Controls.Add(this.comboFishHand2);
		this.groupBox11.Controls.Add(this.comboFishHand1);
		this.groupBox11.Controls.Add(this.checkFishAutoWear);
		this.groupBox11.Location = new System.Drawing.Point(15, 14);
		this.groupBox11.Name = "groupBox11";
		this.groupBox11.Size = new System.Drawing.Size(246, 113);
		this.groupBox11.TabIndex = 1027;
		this.groupBox11.TabStop = false;
		this.groupBox11.Text = "Автонадевание удочки";
		this.comboFishHand2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.comboFishHand2.FormattingEnabled = true;
		this.comboFishHand2.Items.AddRange(new object[11]
		{
			"Нет", "Любая удочка", "Ореховая Удочка", "Ивовая Удочка", "Бамбуковая Удочка", "Бамбуковая 2-х коленная Удочка", "Бамбуковая 3-х коленная Удочка", "Телескопическая Удочка", "Телескопическая Облегченная Удочка", "Телескопический Спиннинг",
			"Сачок"
		});
		this.comboFishHand2.Location = new System.Drawing.Point(7, 71);
		this.comboFishHand2.Name = "comboFishHand2";
		this.comboFishHand2.Size = new System.Drawing.Size(230, 21);
		this.comboFishHand2.TabIndex = 2;
		this.comboFishHand1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.comboFishHand1.FormattingEnabled = true;
		this.comboFishHand1.Items.AddRange(new object[11]
		{
			"Нет", "Любая удочка", "Ореховая Удочка", "Ивовая Удочка", "Бамбуковая Удочка", "Бамбуковая 2-х коленная Удочка", "Бамбуковая 3-х коленная Удочка", "Телескопическая Удочка", "Телескопическая Облегченная Удочка", "Телескопический Спиннинг",
			"Сачок"
		});
		this.comboFishHand1.Location = new System.Drawing.Point(7, 44);
		this.comboFishHand1.Name = "comboFishHand1";
		this.comboFishHand1.Size = new System.Drawing.Size(230, 21);
		this.comboFishHand1.TabIndex = 1;
		this.checkFishAutoWear.AutoSize = true;
		this.checkFishAutoWear.Location = new System.Drawing.Point(13, 20);
		this.checkFishAutoWear.Name = "checkFishAutoWear";
		this.checkFishAutoWear.Size = new System.Drawing.Size(220, 17);
		this.checkFishAutoWear.TabIndex = 0;
		this.checkFishAutoWear.Text = "Выполнять автонадевание (обе руки)";
		this.checkFishAutoWear.UseVisualStyleBackColor = true;
		this.checkboxStopOverW.AutoSize = true;
		this.checkboxStopOverW.Location = new System.Drawing.Point(282, 110);
		this.checkboxStopOverW.Name = "checkboxStopOverW";
		this.checkboxStopOverW.Size = new System.Drawing.Size(213, 17);
		this.checkboxStopOverW.TabIndex = 1026;
		this.checkboxStopOverW.Text = "Прекращать рыбалку при перегрузе";
		this.checkboxStopOverW.UseVisualStyleBackColor = true;
		this.tabPage3.Controls.Add(this.autoForestCells);
		this.tabPage3.Controls.Add(this.label6);
		this.tabPage3.Controls.Add(this.antiCaptchaKey);
		this.tabPage3.Controls.Add(this.label5);
		this.tabPage3.Controls.Add(this.groupBox3);
		this.tabPage3.Controls.Add(this.groupBox20);
		this.tabPage3.Location = new System.Drawing.Point(4, 22);
		this.tabPage3.Name = "tabPage3";
		this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
		this.tabPage3.Size = new System.Drawing.Size(594, 433);
		this.tabPage3.TabIndex = 2;
		this.tabPage3.Text = "Карта";
		this.tabPage3.UseVisualStyleBackColor = true;
		this.autoForestCells.AcceptsReturn = true;
		this.autoForestCells.Location = new System.Drawing.Point(9, 277);
		this.autoForestCells.Multiline = true;
		this.autoForestCells.Name = "autoForestCells";
		this.autoForestCells.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
		this.autoForestCells.Size = new System.Drawing.Size(567, 93);
		this.autoForestCells.TabIndex = 2;
		this.label6.AutoSize = true;
		this.label6.Location = new System.Drawing.Point(6, 261);
		this.label6.Name = "label6";
		this.label6.Size = new System.Drawing.Size(360, 13);
		this.label6.TabIndex = 1028;
		this.label6.Text = "Список клеток для перехода (вводить через запятую без пробелов)";
		this.antiCaptchaKey.Location = new System.Drawing.Point(191, 233);
		this.antiCaptchaKey.Name = "antiCaptchaKey";
		this.antiCaptchaKey.Size = new System.Drawing.Size(385, 21);
		this.antiCaptchaKey.TabIndex = 1027;
		this.label5.AutoSize = true;
		this.label5.Location = new System.Drawing.Point(6, 236);
		this.label5.Name = "label5";
		this.label5.Size = new System.Drawing.Size(179, 13);
		this.label5.TabIndex = 1026;
		this.label5.Text = "Ключ учетной записи AntiCaptcha";
		this.groupBox3.Controls.Add(this.label3);
		this.groupBox3.Controls.Add(this.textHighlightResources);
		this.groupBox3.Location = new System.Drawing.Point(6, 73);
		this.groupBox3.Name = "groupBox3";
		this.groupBox3.Size = new System.Drawing.Size(576, 156);
		this.groupBox3.TabIndex = 1025;
		this.groupBox3.TabStop = false;
		this.groupBox3.Text = "Окно ресурсов на природе";
		this.label3.AutoSize = true;
		this.label3.Location = new System.Drawing.Point(9, 17);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(543, 13);
		this.label3.TabIndex = 1;
		this.label3.Text = "Введите через запятую список ресурсов, которые будут подсвечиваться при оглядывании на природе:";
		this.textHighlightResources.AcceptsReturn = true;
		this.textHighlightResources.Location = new System.Drawing.Point(6, 33);
		this.textHighlightResources.Multiline = true;
		this.textHighlightResources.Name = "textHighlightResources";
		this.textHighlightResources.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
		this.textHighlightResources.Size = new System.Drawing.Size(564, 117);
		this.textHighlightResources.TabIndex = 0;
		this.groupBox20.Controls.Add(this.flowLayoutPanel5);
		this.groupBox20.Location = new System.Drawing.Point(6, 6);
		this.groupBox20.Name = "groupBox20";
		this.groupBox20.Size = new System.Drawing.Size(381, 61);
		this.groupBox20.TabIndex = 1024;
		this.groupBox20.TabStop = false;
		this.groupBox20.Text = "Расширенная карта природы";
		this.flowLayoutPanel5.Controls.Add(this.label18);
		this.flowLayoutPanel5.Controls.Add(this.numBigMapWidth);
		this.flowLayoutPanel5.Controls.Add(this.label25);
		this.flowLayoutPanel5.Controls.Add(this.numBigMapHeight);
		this.flowLayoutPanel5.Controls.Add(this.label2);
		this.flowLayoutPanel5.Location = new System.Drawing.Point(6, 19);
		this.flowLayoutPanel5.Name = "flowLayoutPanel5";
		this.flowLayoutPanel5.Size = new System.Drawing.Size(367, 30);
		this.flowLayoutPanel5.TabIndex = 1018;
		this.label18.AutoSize = true;
		this.label18.Location = new System.Drawing.Point(3, 6);
		this.label18.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
		this.label18.Name = "label18";
		this.label18.Size = new System.Drawing.Size(85, 13);
		this.label18.TabIndex = 0;
		this.label18.Text = "Размеры карты";
		this.numBigMapWidth.AutoSize = true;
		this.numBigMapWidth.Increment = new decimal(new int[4] { 2, 0, 0, 0 });
		this.numBigMapWidth.InterceptArrowKeys = false;
		this.numBigMapWidth.Location = new System.Drawing.Point(94, 3);
		this.numBigMapWidth.Maximum = new decimal(new int[4] { 19, 0, 0, 0 });
		this.numBigMapWidth.Minimum = new decimal(new int[4] { 3, 0, 0, 0 });
		this.numBigMapWidth.Name = "numBigMapWidth";
		this.numBigMapWidth.ReadOnly = true;
		this.numBigMapWidth.Size = new System.Drawing.Size(35, 21);
		this.numBigMapWidth.TabIndex = 2;
		this.numBigMapWidth.Value = new decimal(new int[4] { 9, 0, 0, 0 });
		this.label25.AutoSize = true;
		this.label25.Location = new System.Drawing.Point(135, 6);
		this.label25.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
		this.label25.Name = "label25";
		this.label25.Size = new System.Drawing.Size(19, 13);
		this.label25.TabIndex = 3;
		this.label25.Text = "на";
		this.numBigMapHeight.AutoSize = true;
		this.numBigMapHeight.Increment = new decimal(new int[4] { 2, 0, 0, 0 });
		this.numBigMapHeight.InterceptArrowKeys = false;
		this.numBigMapHeight.Location = new System.Drawing.Point(160, 3);
		this.numBigMapHeight.Maximum = new decimal(new int[4] { 19, 0, 0, 0 });
		this.numBigMapHeight.Minimum = new decimal(new int[4] { 3, 0, 0, 0 });
		this.numBigMapHeight.Name = "numBigMapHeight";
		this.numBigMapHeight.ReadOnly = true;
		this.numBigMapHeight.Size = new System.Drawing.Size(35, 21);
		this.numBigMapHeight.TabIndex = 4;
		this.numBigMapHeight.Value = new decimal(new int[4] { 5, 0, 0, 0 });
		this.label2.AutoSize = true;
		this.label2.Location = new System.Drawing.Point(201, 6);
		this.label2.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(43, 13);
		this.label2.TabIndex = 5;
		this.label2.Text = "клеток";
		this.tabPage2.Controls.Add(this.groupBox14);
		this.tabPage2.Controls.Add(this.checkDoChatLevels);
		this.tabPage2.Controls.Add(this.groupBox1);
		this.tabPage2.Location = new System.Drawing.Point(4, 22);
		this.tabPage2.Name = "tabPage2";
		this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
		this.tabPage2.Size = new System.Drawing.Size(594, 433);
		this.tabPage2.TabIndex = 1;
		this.tabPage2.Text = "Чат";
		this.tabPage2.UseVisualStyleBackColor = true;
		this.groupBox14.Controls.Add(this.checkStatSaveToFile);
		this.groupBox14.Controls.Add(this.checkStatReset);
		this.groupBox14.Location = new System.Drawing.Point(220, 6);
		this.groupBox14.Name = "groupBox14";
		this.groupBox14.Size = new System.Drawing.Size(190, 66);
		this.groupBox14.TabIndex = 1033;
		this.groupBox14.TabStop = false;
		this.groupBox14.Text = "Статистика";
		this.checkStatSaveToFile.AutoSize = true;
		this.checkStatSaveToFile.Location = new System.Drawing.Point(6, 43);
		this.checkStatSaveToFile.Name = "checkStatSaveToFile";
		this.checkStatSaveToFile.Size = new System.Drawing.Size(173, 17);
		this.checkStatSaveToFile.TabIndex = 1;
		this.checkStatSaveToFile.Text = "Сохранять в файл в полночь";
		this.checkStatSaveToFile.UseVisualStyleBackColor = true;
		this.checkStatReset.AutoSize = true;
		this.checkStatReset.Location = new System.Drawing.Point(6, 20);
		this.checkStatReset.Name = "checkStatReset";
		this.checkStatReset.Size = new System.Drawing.Size(171, 17);
		this.checkStatReset.TabIndex = 0;
		this.checkStatReset.Text = "Сброс статистики в полночь";
		this.checkStatReset.UseVisualStyleBackColor = true;
		this.checkDoChatLevels.AutoSize = true;
		this.checkDoChatLevels.Location = new System.Drawing.Point(12, 78);
		this.checkDoChatLevels.Name = "checkDoChatLevels";
		this.checkDoChatLevels.Size = new System.Drawing.Size(309, 17);
		this.checkDoChatLevels.TabIndex = 1025;
		this.checkDoChatLevels.Text = "Отображать значок клана и уровни персонажей в чате";
		this.checkDoChatLevels.UseVisualStyleBackColor = true;
		this.groupBox1.Controls.Add(this.checkboxDoKeepChatGame);
		this.groupBox1.Controls.Add(this.checkboxDoKeepChatLog);
		this.groupBox1.Location = new System.Drawing.Point(6, 6);
		this.groupBox1.Name = "groupBox1";
		this.groupBox1.Size = new System.Drawing.Size(208, 66);
		this.groupBox1.TabIndex = 1016;
		this.groupBox1.TabStop = false;
		this.groupBox1.Text = "Сохранение";
		this.checkboxDoKeepChatGame.AutoSize = true;
		this.checkboxDoKeepChatGame.Location = new System.Drawing.Point(6, 20);
		this.checkboxDoKeepChatGame.Name = "checkboxDoKeepChatGame";
		this.checkboxDoKeepChatGame.Size = new System.Drawing.Size(192, 17);
		this.checkboxDoKeepChatGame.TabIndex = 1012;
		this.checkboxDoKeepChatGame.Text = "Сохранять чат при перезаходах";
		this.checkboxDoKeepChatGame.UseVisualStyleBackColor = true;
		this.checkboxDoKeepChatLog.AutoSize = true;
		this.checkboxDoKeepChatLog.Location = new System.Drawing.Point(6, 43);
		this.checkboxDoKeepChatLog.Name = "checkboxDoKeepChatLog";
		this.checkboxDoKeepChatLog.Size = new System.Drawing.Size(140, 17);
		this.checkboxDoKeepChatLog.TabIndex = 1015;
		this.checkboxDoKeepChatLog.Text = "Сохранять чат в файл";
		this.checkboxDoKeepChatLog.UseVisualStyleBackColor = true;
		this.tabPage1.Controls.Add(this.contactsToClan);
		this.tabPage1.Controls.Add(this.RemoveBuildingImagesCheckbox);
		this.tabPage1.Controls.Add(this.groupBox22);
		this.tabPage1.Controls.Add(this.checkDoStopOnDig);
		this.tabPage1.Controls.Add(this.checkDoRob);
		this.tabPage1.Controls.Add(this.checkShowOverWarning);
		this.tabPage1.Controls.Add(this.groupBoxDoAutoDrinkBlaz);
		this.tabPage1.Controls.Add(this.groupBox25);
		this.tabPage1.Controls.Add(this.groupBox24);
		this.tabPage1.Controls.Add(this.checkLightForum);
		this.tabPage1.Controls.Add(this.groupBox10);
		this.tabPage1.Controls.Add(this.checkboxDoPromptExit);
		this.tabPage1.Location = new System.Drawing.Point(4, 22);
		this.tabPage1.Name = "tabPage1";
		this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
		this.tabPage1.Size = new System.Drawing.Size(594, 433);
		this.tabPage1.TabIndex = 0;
		this.tabPage1.Text = "Общие";
		this.tabPage1.UseVisualStyleBackColor = true;
		this.contactsToClan.AutoSize = true;
		this.contactsToClan.Location = new System.Drawing.Point(12, 338);
		this.contactsToClan.Name = "contactsToClan";
		this.contactsToClan.Size = new System.Drawing.Size(232, 17);
		this.contactsToClan.TabIndex = 1027;
		this.contactsToClan.Text = "Выводить слежение за контактами в КП";
		this.contactsToClan.UseVisualStyleBackColor = true;
		this.RemoveBuildingImagesCheckbox.AutoSize = true;
		this.RemoveBuildingImagesCheckbox.Location = new System.Drawing.Point(293, 340);
		this.RemoveBuildingImagesCheckbox.Name = "RemoveBuildingImagesCheckbox";
		this.RemoveBuildingImagesCheckbox.Size = new System.Drawing.Size(165, 17);
		this.RemoveBuildingImagesCheckbox.TabIndex = 1026;
		this.RemoveBuildingImagesCheckbox.Text = "Вырезать картинки зданий";
		this.RemoveBuildingImagesCheckbox.UseVisualStyleBackColor = true;
		this.groupBox22.Controls.Add(this.textAutoWearComplect);
		this.groupBox22.Controls.Add(this.checkDoAutoCure);
		this.groupBox22.Location = new System.Drawing.Point(6, 279);
		this.groupBox22.Name = "groupBox22";
		this.groupBox22.Size = new System.Drawing.Size(267, 53);
		this.groupBox22.TabIndex = 1021;
		this.groupBox22.TabStop = false;
		this.groupBox22.Text = "Автолечение своего персонажа";
		this.textAutoWearComplect.Location = new System.Drawing.Point(142, 19);
		this.textAutoWearComplect.Name = "textAutoWearComplect";
		this.textAutoWearComplect.Size = new System.Drawing.Size(113, 21);
		this.textAutoWearComplect.TabIndex = 1;
		this.checkDoAutoCure.AutoSize = true;
		this.checkDoAutoCure.Location = new System.Drawing.Point(7, 21);
		this.checkDoAutoCure.Name = "checkDoAutoCure";
		this.checkDoAutoCure.Size = new System.Drawing.Size(133, 17);
		this.checkDoAutoCure.TabIndex = 0;
		this.checkDoAutoCure.Text = "Лечиться, комплект:";
		this.checkDoAutoCure.UseVisualStyleBackColor = true;
		this.checkDoStopOnDig.AutoSize = true;
		this.checkDoStopOnDig.Location = new System.Drawing.Point(293, 377);
		this.checkDoStopOnDig.Name = "checkDoStopOnDig";
		this.checkDoStopOnDig.Size = new System.Drawing.Size(165, 17);
		this.checkDoStopOnDig.TabIndex = 1024;
		this.checkDoStopOnDig.Text = "Останавливаться на кладе";
		this.checkDoStopOnDig.UseVisualStyleBackColor = true;
		this.checkDoRob.AutoSize = true;
		this.checkDoRob.Location = new System.Drawing.Point(293, 359);
		this.checkDoRob.Name = "checkDoRob";
		this.checkDoRob.Size = new System.Drawing.Size(127, 17);
		this.checkDoRob.TabIndex = 1023;
		this.checkDoRob.Text = "Воровать после боя";
		this.checkDoRob.UseVisualStyleBackColor = true;
		this.checkShowOverWarning.AutoSize = true;
		this.checkShowOverWarning.Location = new System.Drawing.Point(293, 413);
		this.checkShowOverWarning.Name = "checkShowOverWarning";
		this.checkShowOverWarning.Size = new System.Drawing.Size(211, 17);
		this.checkShowOverWarning.TabIndex = 1021;
		this.checkShowOverWarning.Text = "Показывать сообщение о перегрузе";
		this.checkShowOverWarning.UseVisualStyleBackColor = true;
		this.groupBoxDoAutoDrinkBlaz.Controls.Add(this.FoodCheckBox);
		this.groupBoxDoAutoDrinkBlaz.Controls.Add(this.comboBoxDoAutoDrinkBlaz);
		this.groupBoxDoAutoDrinkBlaz.Controls.Add(this.textBoxAutoDrinkBlazTied);
		this.groupBoxDoAutoDrinkBlaz.Controls.Add(this.checkBoxDoAutoDrinkBlaz);
		this.groupBoxDoAutoDrinkBlaz.Location = new System.Drawing.Point(6, 168);
		this.groupBoxDoAutoDrinkBlaz.Name = "groupBoxDoAutoDrinkBlaz";
		this.groupBoxDoAutoDrinkBlaz.Size = new System.Drawing.Size(267, 109);
		this.groupBoxDoAutoDrinkBlaz.TabIndex = 1020;
		this.groupBoxDoAutoDrinkBlaz.TabStop = false;
		this.groupBoxDoAutoDrinkBlaz.Text = "Автопитье блажа";
		this.FoodCheckBox.AutoSize = true;
		this.FoodCheckBox.Location = new System.Drawing.Point(7, 20);
		this.FoodCheckBox.Name = "FoodCheckBox";
		this.FoodCheckBox.Size = new System.Drawing.Size(217, 17);
		this.FoodCheckBox.TabIndex = 3;
		this.FoodCheckBox.Text = "Рыбная похлёбка при 50% усталости";
		this.FoodCheckBox.UseVisualStyleBackColor = true;
		this.comboBoxDoAutoDrinkBlaz.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.comboBoxDoAutoDrinkBlaz.FormattingEnabled = true;
		this.comboBoxDoAutoDrinkBlaz.Items.AddRange(new object[2] { "ищем зелье, потом эликсир", "ищем эликсир, потом зелье" });
		this.comboBoxDoAutoDrinkBlaz.Location = new System.Drawing.Point(7, 76);
		this.comboBoxDoAutoDrinkBlaz.Name = "comboBoxDoAutoDrinkBlaz";
		this.comboBoxDoAutoDrinkBlaz.Size = new System.Drawing.Size(248, 21);
		this.comboBoxDoAutoDrinkBlaz.TabIndex = 2;
		this.textBoxAutoDrinkBlazTied.Location = new System.Drawing.Point(178, 45);
		this.textBoxAutoDrinkBlazTied.Name = "textBoxAutoDrinkBlazTied";
		this.textBoxAutoDrinkBlazTied.Size = new System.Drawing.Size(48, 21);
		this.textBoxAutoDrinkBlazTied.TabIndex = 1;
		this.checkBoxDoAutoDrinkBlaz.AutoSize = true;
		this.checkBoxDoAutoDrinkBlaz.Location = new System.Drawing.Point(7, 47);
		this.checkBoxDoAutoDrinkBlaz.Name = "checkBoxDoAutoDrinkBlaz";
		this.checkBoxDoAutoDrinkBlaz.Size = new System.Drawing.Size(165, 17);
		this.checkBoxDoAutoDrinkBlaz.TabIndex = 0;
		this.checkBoxDoAutoDrinkBlaz.Text = "Пить блаж, если усталость";
		this.checkBoxDoAutoDrinkBlaz.UseVisualStyleBackColor = true;
		this.groupBox25.Controls.Add(this.checkDoShowFastAttackImp);
		this.groupBox25.Controls.Add(this.checkDoShowFastAttackPortal);
		this.groupBox25.Controls.Add(this.checkDoShowFastAttackTotem);
		this.groupBox25.Controls.Add(this.checkDoShowFastAttackClosed);
		this.groupBox25.Controls.Add(this.checkDoShowFastAttackZas);
		this.groupBox25.Controls.Add(this.checkDoShowFastAttackFog);
		this.groupBox25.Controls.Add(this.checkDoShowFastAttackClosedUltimate);
		this.groupBox25.Controls.Add(this.checkDoShowFastAttackNevid);
		this.groupBox25.Controls.Add(this.checkDoShowFastAttackStrong);
		this.groupBox25.Controls.Add(this.checkDoShowFastAttackPoison);
		this.groupBox25.Controls.Add(this.checkDoShowFastAttackOpenNevid);
		this.groupBox25.Controls.Add(this.checkDoShowFastAttackClosedFist);
		this.groupBox25.Controls.Add(this.checkDoShowFastAttackFist);
		this.groupBox25.Controls.Add(this.checkDoShowFastAttackUltimate);
		this.groupBox25.Controls.Add(this.checkDoShowFastAttackBlood);
		this.groupBox25.Controls.Add(this.checkDoShowFastAttack);
		this.groupBox25.Location = new System.Drawing.Point(280, 13);
		this.groupBox25.Name = "groupBox25";
		this.groupBox25.Size = new System.Drawing.Size(302, 306);
		this.groupBox25.TabIndex = 1019;
		this.groupBox25.TabStop = false;
		this.groupBox25.Text = "Быстрые действия в списке локации";
		this.checkDoShowFastAttackImp.AutoSize = true;
		this.checkDoShowFastAttackImp.Location = new System.Drawing.Point(59, 171);
		this.checkDoShowFastAttackImp.Name = "checkDoShowFastAttackImp";
		this.checkDoShowFastAttackImp.Size = new System.Drawing.Size(104, 17);
		this.checkDoShowFastAttackImp.TabIndex = 1036;
		this.checkDoShowFastAttackImp.Text = "Имп-вредитель";
		this.checkDoShowFastAttackImp.UseVisualStyleBackColor = true;
		this.checkDoShowFastAttackPortal.AutoSize = true;
		this.checkDoShowFastAttackPortal.Location = new System.Drawing.Point(13, 285);
		this.checkDoShowFastAttackPortal.Name = "checkDoShowFastAttackPortal";
		this.checkDoShowFastAttackPortal.Size = new System.Drawing.Size(63, 17);
		this.checkDoShowFastAttackPortal.TabIndex = 1035;
		this.checkDoShowFastAttackPortal.Text = "Портал";
		this.checkDoShowFastAttackPortal.UseVisualStyleBackColor = true;
		this.checkDoShowFastAttackTotem.AutoSize = true;
		this.checkDoShowFastAttackTotem.Location = new System.Drawing.Point(13, 266);
		this.checkDoShowFastAttackTotem.Name = "checkDoShowFastAttackTotem";
		this.checkDoShowFastAttackTotem.Size = new System.Drawing.Size(56, 17);
		this.checkDoShowFastAttackTotem.TabIndex = 1034;
		this.checkDoShowFastAttackTotem.Text = "Тотем";
		this.checkDoShowFastAttackTotem.UseVisualStyleBackColor = true;
		this.checkDoShowFastAttackClosed.AutoSize = true;
		this.checkDoShowFastAttackClosed.Location = new System.Drawing.Point(13, 95);
		this.checkDoShowFastAttackClosed.Name = "checkDoShowFastAttackClosed";
		this.checkDoShowFastAttackClosed.Size = new System.Drawing.Size(134, 17);
		this.checkDoShowFastAttackClosed.TabIndex = 1033;
		this.checkDoShowFastAttackClosed.Text = "Закрытое нападение";
		this.checkDoShowFastAttackClosed.UseVisualStyleBackColor = true;
		this.checkDoShowFastAttackZas.AutoSize = true;
		this.checkDoShowFastAttackZas.Location = new System.Drawing.Point(13, 247);
		this.checkDoShowFastAttackZas.Name = "checkDoShowFastAttackZas";
		this.checkDoShowFastAttackZas.Size = new System.Drawing.Size(106, 17);
		this.checkDoShowFastAttackZas.TabIndex = 1032;
		this.checkDoShowFastAttackZas.Text = "Свиток защиты";
		this.checkDoShowFastAttackZas.UseVisualStyleBackColor = true;
		this.checkDoShowFastAttackFog.AutoSize = true;
		this.checkDoShowFastAttackFog.Location = new System.Drawing.Point(13, 228);
		this.checkDoShowFastAttackFog.Name = "checkDoShowFastAttackFog";
		this.checkDoShowFastAttackFog.Size = new System.Drawing.Size(177, 17);
		this.checkDoShowFastAttackFog.TabIndex = 1031;
		this.checkDoShowFastAttackFog.Text = "Свиток искажающего тумана";
		this.checkDoShowFastAttackFog.UseVisualStyleBackColor = true;
		this.checkDoShowFastAttackClosedUltimate.AutoSize = true;
		this.checkDoShowFastAttackClosedUltimate.Location = new System.Drawing.Point(13, 76);
		this.checkDoShowFastAttackClosedUltimate.Name = "checkDoShowFastAttackClosedUltimate";
		this.checkDoShowFastAttackClosedUltimate.Size = new System.Drawing.Size(173, 17);
		this.checkDoShowFastAttackClosedUltimate.TabIndex = 1030;
		this.checkDoShowFastAttackClosedUltimate.Text = "Закрытое боевое нападение";
		this.checkDoShowFastAttackClosedUltimate.UseVisualStyleBackColor = true;
		this.checkDoShowFastAttackNevid.AutoSize = true;
		this.checkDoShowFastAttackNevid.Location = new System.Drawing.Point(13, 209);
		this.checkDoShowFastAttackNevid.Name = "checkDoShowFastAttackNevid";
		this.checkDoShowFastAttackNevid.Size = new System.Drawing.Size(125, 17);
		this.checkDoShowFastAttackNevid.TabIndex = 1029;
		this.checkDoShowFastAttackNevid.Text = "Зелье невидимости";
		this.checkDoShowFastAttackNevid.UseVisualStyleBackColor = true;
		this.checkDoShowFastAttackStrong.AutoSize = true;
		this.checkDoShowFastAttackStrong.Location = new System.Drawing.Point(13, 190);
		this.checkDoShowFastAttackStrong.Name = "checkDoShowFastAttackStrong";
		this.checkDoShowFastAttackStrong.Size = new System.Drawing.Size(134, 17);
		this.checkDoShowFastAttackStrong.TabIndex = 1028;
		this.checkDoShowFastAttackStrong.Text = "Зелье сильной спины";
		this.checkDoShowFastAttackStrong.UseVisualStyleBackColor = true;
		this.checkDoShowFastAttackPoison.AutoSize = true;
		this.checkDoShowFastAttackPoison.Location = new System.Drawing.Point(13, 171);
		this.checkDoShowFastAttackPoison.Name = "checkDoShowFastAttackPoison";
		this.checkDoShowFastAttackPoison.Size = new System.Drawing.Size(40, 17);
		this.checkDoShowFastAttackPoison.TabIndex = 1027;
		this.checkDoShowFastAttackPoison.Text = "Яд";
		this.checkDoShowFastAttackPoison.UseVisualStyleBackColor = true;
		this.checkDoShowFastAttackOpenNevid.AutoSize = true;
		this.checkDoShowFastAttackOpenNevid.Location = new System.Drawing.Point(13, 152);
		this.checkDoShowFastAttackOpenNevid.Name = "checkDoShowFastAttackOpenNevid";
		this.checkDoShowFastAttackOpenNevid.Size = new System.Drawing.Size(134, 17);
		this.checkDoShowFastAttackOpenNevid.TabIndex = 1025;
		this.checkDoShowFastAttackOpenNevid.Text = "Свиток обнаружения";
		this.checkDoShowFastAttackOpenNevid.UseVisualStyleBackColor = true;
		this.checkDoShowFastAttackClosedFist.AutoSize = true;
		this.checkDoShowFastAttackClosedFist.Location = new System.Drawing.Point(13, 133);
		this.checkDoShowFastAttackClosedFist.Name = "checkDoShowFastAttackClosedFist";
		this.checkDoShowFastAttackClosedFist.Size = new System.Drawing.Size(185, 17);
		this.checkDoShowFastAttackClosedFist.TabIndex = 1024;
		this.checkDoShowFastAttackClosedFist.Text = "Закрытое кулачное нападение";
		this.checkDoShowFastAttackClosedFist.UseVisualStyleBackColor = true;
		this.checkDoShowFastAttackFist.AutoSize = true;
		this.checkDoShowFastAttackFist.Location = new System.Drawing.Point(13, 114);
		this.checkDoShowFastAttackFist.Name = "checkDoShowFastAttackFist";
		this.checkDoShowFastAttackFist.Size = new System.Drawing.Size(133, 17);
		this.checkDoShowFastAttackFist.TabIndex = 1023;
		this.checkDoShowFastAttackFist.Text = "Кулачное нападение";
		this.checkDoShowFastAttackFist.UseVisualStyleBackColor = true;
		this.checkDoShowFastAttackUltimate.AutoSize = true;
		this.checkDoShowFastAttackUltimate.Location = new System.Drawing.Point(13, 57);
		this.checkDoShowFastAttackUltimate.Name = "checkDoShowFastAttackUltimate";
		this.checkDoShowFastAttackUltimate.Size = new System.Drawing.Size(120, 17);
		this.checkDoShowFastAttackUltimate.TabIndex = 1022;
		this.checkDoShowFastAttackUltimate.Text = "Боевое нападение";
		this.checkDoShowFastAttackUltimate.UseVisualStyleBackColor = true;
		this.checkDoShowFastAttackBlood.AutoSize = true;
		this.checkDoShowFastAttackBlood.Location = new System.Drawing.Point(13, 38);
		this.checkDoShowFastAttackBlood.Name = "checkDoShowFastAttackBlood";
		this.checkDoShowFastAttackBlood.Size = new System.Drawing.Size(133, 17);
		this.checkDoShowFastAttackBlood.TabIndex = 1021;
		this.checkDoShowFastAttackBlood.Text = "Кровавое нападение";
		this.checkDoShowFastAttackBlood.UseVisualStyleBackColor = true;
		this.checkDoShowFastAttack.AutoSize = true;
		this.checkDoShowFastAttack.Location = new System.Drawing.Point(13, 20);
		this.checkDoShowFastAttack.Name = "checkDoShowFastAttack";
		this.checkDoShowFastAttack.Size = new System.Drawing.Size(130, 17);
		this.checkDoShowFastAttack.TabIndex = 1020;
		this.checkDoShowFastAttack.Text = "Обычное нападение";
		this.checkDoShowFastAttack.UseVisualStyleBackColor = true;
		this.groupBox24.Controls.Add(this.checkDoSummDolg);
		this.groupBox24.Controls.Add(this.checkDoInvPackDolg);
		this.groupBox24.Controls.Add(this.checkDoInvPack);
		this.groupBox24.Location = new System.Drawing.Point(6, 79);
		this.groupBox24.Name = "groupBox24";
		this.groupBox24.Size = new System.Drawing.Size(267, 84);
		this.groupBox24.TabIndex = 1014;
		this.groupBox24.TabStop = false;
		this.groupBox24.Text = "Инвентарь";
		this.checkDoSummDolg.AutoSize = true;
		this.checkDoSummDolg.Location = new System.Drawing.Point(6, 56);
		this.checkDoSummDolg.Name = "checkDoSummDolg";
		this.checkDoSummDolg.Size = new System.Drawing.Size(173, 17);
		this.checkDoSummDolg.TabIndex = 1015;
		this.checkDoSummDolg.Text = "Суммировать долговечность";
		this.checkDoSummDolg.UseVisualStyleBackColor = true;
		this.checkDoInvPackDolg.AutoSize = true;
		this.checkDoInvPackDolg.Location = new System.Drawing.Point(6, 38);
		this.checkDoInvPackDolg.Name = "checkDoInvPackDolg";
		this.checkDoInvPackDolg.Size = new System.Drawing.Size(189, 17);
		this.checkDoInvPackDolg.TabIndex = 1013;
		this.checkDoInvPackDolg.Text = "Даже с разной долговечностью";
		this.checkDoInvPackDolg.UseVisualStyleBackColor = true;
		this.checkDoInvPack.AutoSize = true;
		this.checkDoInvPack.Location = new System.Drawing.Point(6, 20);
		this.checkDoInvPack.Name = "checkDoInvPack";
		this.checkDoInvPack.Size = new System.Drawing.Size(210, 17);
		this.checkDoInvPack.TabIndex = 1012;
		this.checkDoInvPack.Text = "Объединять одинаковые предметы";
		this.checkDoInvPack.UseVisualStyleBackColor = true;
		this.checkLightForum.AutoSize = true;
		this.checkLightForum.Location = new System.Drawing.Point(293, 395);
		this.checkLightForum.Name = "checkLightForum";
		this.checkLightForum.Size = new System.Drawing.Size(182, 17);
		this.checkLightForum.TabIndex = 1016;
		this.checkLightForum.Text = "Вырезать аватарки на форуме";
		this.checkLightForum.UseVisualStyleBackColor = true;
		this.groupBox10.Controls.Add(this.checkboxShowTrayBaloons);
		this.groupBox10.Controls.Add(this.checkboxDoTray);
		this.groupBox10.Location = new System.Drawing.Point(6, 13);
		this.groupBox10.Name = "groupBox10";
		this.groupBox10.Size = new System.Drawing.Size(267, 64);
		this.groupBox10.TabIndex = 1013;
		this.groupBox10.TabStop = false;
		this.groupBox10.Text = "Трей";
		this.checkboxShowTrayBaloons.AutoSize = true;
		this.checkboxShowTrayBaloons.Location = new System.Drawing.Point(6, 38);
		this.checkboxShowTrayBaloons.Name = "checkboxShowTrayBaloons";
		this.checkboxShowTrayBaloons.Size = new System.Drawing.Size(213, 17);
		this.checkboxShowTrayBaloons.TabIndex = 1013;
		this.checkboxShowTrayBaloons.Text = "Всплывающие баллоны над иконкой";
		this.checkboxShowTrayBaloons.UseVisualStyleBackColor = true;
		this.checkboxDoTray.AutoSize = true;
		this.checkboxDoTray.Location = new System.Drawing.Point(6, 20);
		this.checkboxDoTray.Name = "checkboxDoTray";
		this.checkboxDoTray.Size = new System.Drawing.Size(186, 17);
		this.checkboxDoTray.TabIndex = 1012;
		this.checkboxDoTray.Text = "Минимизировать клиент в трей";
		this.checkboxDoTray.UseVisualStyleBackColor = true;
		this.checkboxDoPromptExit.AutoSize = true;
		this.checkboxDoPromptExit.Location = new System.Drawing.Point(293, 322);
		this.checkboxDoPromptExit.Name = "checkboxDoPromptExit";
		this.checkboxDoPromptExit.Size = new System.Drawing.Size(267, 17);
		this.checkboxDoPromptExit.TabIndex = 1010;
		this.checkboxDoPromptExit.Text = "Спрашивать подтверждение о выходе из игры";
		this.checkboxDoPromptExit.UseVisualStyleBackColor = true;
		this.tabControlSettings.Controls.Add(this.tabPage1);
		this.tabControlSettings.Controls.Add(this.tabPage2);
		this.tabControlSettings.Controls.Add(this.tabPage3);
		this.tabControlSettings.Controls.Add(this.tabPage5);
		this.tabControlSettings.Controls.Add(this.tabPage7);
		this.tabControlSettings.Controls.Add(this.tabPage9);
		this.tabControlSettings.Controls.Add(this.tabPage8);
		this.tabControlSettings.Controls.Add(this.tabPage6);
		this.tabControlSettings.Controls.Add(this.tabPage4);
		this.tabControlSettings.Location = new System.Drawing.Point(12, 12);
		this.tabControlSettings.Name = "tabControlSettings";
		this.tabControlSettings.SelectedIndex = 0;
		this.tabControlSettings.Size = new System.Drawing.Size(602, 459);
		this.tabControlSettings.TabIndex = 1016;
		this.tabPage4.Controls.Add(this.groupBox2);
		this.tabPage4.Location = new System.Drawing.Point(4, 22);
		this.tabPage4.Name = "tabPage4";
		this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
		this.tabPage4.Size = new System.Drawing.Size(594, 433);
		this.tabPage4.TabIndex = 9;
		this.tabPage4.Text = "Другое";
		this.tabPage4.UseVisualStyleBackColor = true;
		this.groupBox2.Controls.Add(this.DNVNVLimit);
		this.groupBox2.Controls.Add(this.label26);
		this.groupBox2.Controls.Add(this.DNVFrequency);
		this.groupBox2.Controls.Add(this.label24);
		this.groupBox2.Location = new System.Drawing.Point(6, 6);
		this.groupBox2.Name = "groupBox2";
		this.groupBox2.Size = new System.Drawing.Size(233, 79);
		this.groupBox2.TabIndex = 0;
		this.groupBox2.TabStop = false;
		this.groupBox2.Text = "Биржа DNV";
		this.DNVNVLimit.Increment = new decimal(new int[4] { 5000, 0, 0, 0 });
		this.DNVNVLimit.Location = new System.Drawing.Point(150, 49);
		this.DNVNVLimit.Maximum = new decimal(new int[4] { 10000000, 0, 0, 0 });
		this.DNVNVLimit.Minimum = new decimal(new int[4] { 5000, 0, 0, 0 });
		this.DNVNVLimit.Name = "DNVNVLimit";
		this.DNVNVLimit.Size = new System.Drawing.Size(71, 21);
		this.DNVNVLimit.TabIndex = 4;
		this.DNVNVLimit.Value = new decimal(new int[4] { 5000, 0, 0, 0 });
		this.label26.AutoSize = true;
		this.label26.Location = new System.Drawing.Point(6, 51);
		this.label26.Name = "label26";
		this.label26.Size = new System.Drawing.Size(137, 13);
		this.label26.TabIndex = 3;
		this.label26.Text = "Максимальная сумма в NV";
		this.DNVFrequency.Location = new System.Drawing.Point(179, 19);
		this.DNVFrequency.Maximum = new decimal(new int[4] { 59, 0, 0, 0 });
		this.DNVFrequency.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
		this.DNVFrequency.Name = "DNVFrequency";
		this.DNVFrequency.Size = new System.Drawing.Size(42, 21);
		this.DNVFrequency.TabIndex = 2;
		this.DNVFrequency.Value = new decimal(new int[4] { 1, 0, 0, 0 });
		this.label24.AutoSize = true;
		this.label24.Location = new System.Drawing.Point(7, 21);
		this.label24.Name = "label24";
		this.label24.Size = new System.Drawing.Size(166, 13);
		this.label24.TabIndex = 0;
		this.label24.Text = "Частота обновления в минутах";
		base.AcceptButton = this.buttonOk;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.CancelButton = this.buttonCancel;
		base.ClientSize = new System.Drawing.Size(626, 523);
		base.Controls.Add(this.tabControlSettings);
		base.Controls.Add(this.buttonOk);
		base.Controls.Add(this.buttonCancel);
		this.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "FormSettingsGeneral";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Настройки";
		this.tabPage6.ResumeLayout(false);
		this.tabPage6.PerformLayout();
		this.tabPage8.ResumeLayout(false);
		this.tabPage8.PerformLayout();
		this.groupBox21.ResumeLayout(false);
		this.groupBox21.PerformLayout();
		this.groupBox18.ResumeLayout(false);
		this.groupBox18.PerformLayout();
		this.groupBox17.ResumeLayout(false);
		this.groupBox17.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.numCureNV4).EndInit();
		((System.ComponentModel.ISupportInitialize)this.numCureNV3).EndInit();
		((System.ComponentModel.ISupportInitialize)this.numCureNV2).EndInit();
		((System.ComponentModel.ISupportInitialize)this.numCureNV1).EndInit();
		this.tabPage9.ResumeLayout(false);
		this.tabPage9.PerformLayout();
		this.tabPage7.ResumeLayout(false);
		this.tabPage7.PerformLayout();
		this.flowLayoutPanel4.ResumeLayout(false);
		this.flowLayoutPanel4.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.numAdvMin).EndInit();
		((System.ComponentModel.ISupportInitialize)this.numAdvSec).EndInit();
		this.tabPage5.ResumeLayout(false);
		this.tabPage5.PerformLayout();
		this.groupBox13.ResumeLayout(false);
		this.groupBox13.PerformLayout();
		this.flowLayoutPanel6.ResumeLayout(false);
		this.flowLayoutPanel6.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.numFishTiedHigh).EndInit();
		this.groupBox12.ResumeLayout(false);
		this.groupBox12.PerformLayout();
		this.groupBox11.ResumeLayout(false);
		this.groupBox11.PerformLayout();
		this.tabPage3.ResumeLayout(false);
		this.tabPage3.PerformLayout();
		this.groupBox3.ResumeLayout(false);
		this.groupBox3.PerformLayout();
		this.groupBox20.ResumeLayout(false);
		this.flowLayoutPanel5.ResumeLayout(false);
		this.flowLayoutPanel5.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.numBigMapWidth).EndInit();
		((System.ComponentModel.ISupportInitialize)this.numBigMapHeight).EndInit();
		this.tabPage2.ResumeLayout(false);
		this.tabPage2.PerformLayout();
		this.groupBox14.ResumeLayout(false);
		this.groupBox14.PerformLayout();
		this.groupBox1.ResumeLayout(false);
		this.groupBox1.PerformLayout();
		this.tabPage1.ResumeLayout(false);
		this.tabPage1.PerformLayout();
		this.groupBox22.ResumeLayout(false);
		this.groupBox22.PerformLayout();
		this.groupBoxDoAutoDrinkBlaz.ResumeLayout(false);
		this.groupBoxDoAutoDrinkBlaz.PerformLayout();
		this.groupBox25.ResumeLayout(false);
		this.groupBox25.PerformLayout();
		this.groupBox24.ResumeLayout(false);
		this.groupBox24.PerformLayout();
		this.groupBox10.ResumeLayout(false);
		this.groupBox10.PerformLayout();
		this.tabControlSettings.ResumeLayout(false);
		this.tabPage4.ResumeLayout(false);
		this.groupBox2.ResumeLayout(false);
		this.groupBox2.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.DNVNVLimit).EndInit();
		((System.ComponentModel.ISupportInitialize)this.DNVFrequency).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
