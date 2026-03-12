using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using ABClient.ABForms;
using ABClient.AntiCaptcha;

namespace ABClient;

[ComVisible(true)]
public sealed class ScriptManager
{
	public string MapText()
	{
		return FormMain.smethod_38();
	}

	public void FishOverload()
	{
		FormMain.smethod_64();
	}

	public bool IsAutoFish()
	{
		return Class72.class19_0.method_100();
	}

	public void SetAutoFishMassa(string massa)
	{
		Class72.smethod_81(massa);
	}

	public string CheckPri(string namePri, int myst)
	{
		return FormMain.smethod_65(namePri, myst);
	}

	public string CellDivText(int int_0, int int_1, int scale, string link, bool showmove, bool isframe)
	{
		return Class77.smethod_18(int_0, int_1, scale, link, showmove, isframe);
	}

	public string CellAltText(int int_0, int int_1, int scale)
	{
		return Class77.smethod_19(int_0, int_1, scale);
	}

	public bool IsCellExists(int int_0, int int_1)
	{
		return FormMain.smethod_66(int_0, int_1);
	}

	public bool IsCellInPath(int int_0, int int_1)
	{
		return Class77.smethod_32(int_0, int_1);
	}

	public string GenMoveLink(int int_0, int int_1)
	{
		return FormMain.smethod_67(int_0, int_1);
	}

	public void MakeVisit(int int_0, int int_1)
	{
		FormMain.smethod_68(int_0, int_1);
	}

	public int GetHalfMapWidth()
	{
		if (!Class72.bool_34)
		{
			return (Class72.class19_0.method_54() - 1) / 2;
		}
		return 1;
	}

	public int GetHalfMapHeight()
	{
		if (!Class72.bool_34)
		{
			return (Class72.class19_0.method_56() - 1) / 2;
		}
		return 1;
	}

	public void AutoSelect()
	{
		if (Class72.formMain_0 != null)
		{
			Class72.formMain_0.method_57();
		}
	}

	public void AutoTurn()
	{
		if (Class72.formMain_0 != null)
		{
			Class72.formMain_0.method_58();
		}
	}

	public void AutoBoi()
	{
		if (Class72.formMain_0 != null)
		{
			Class72.formMain_0.method_59();
		}
	}

	public void MoveTo(string dest)
	{
		if (Class72.formMain_0 != null)
		{
			Class72.formMain_0.method_124(dest);
		}
	}

	public void ResetLastBoiTimer()
	{
		Class72.dateTime_0 = DateTime.Now;
	}

	public void TraceDrinkPotion(string wnickname, string wnametxt)
	{
		if (Class72.formMain_0 != null)
		{
			Class72.formMain_0.method_102(wnickname, wnametxt);
		}
	}

	public void ChatUpdated()
	{
		if (Class72.formMain_0 != null)
		{
			FormMain.smethod_59();
		}
	}

	public string ChatFilter(string message)
	{
		return FormMain.smethod_61(message);
	}

	public string XodButtonElapsedTime()
	{
		return string.Format(CultureInfo.InvariantCulture, " ход {0} ", new object[1] { Class4.smethod_1(DateTime.Now.Subtract(Class72.dateTime_0)) });
	}

	public string CheckQuick(string nick, string str)
	{
		if (!nick.Equals(Class72.class19_0.method_30(), StringComparison.OrdinalIgnoreCase))
		{
			return str;
		}
		return string.Empty;
	}

	public void Quick(string nick)
	{
		if (Class72.formMain_0 != null)
		{
			FormMain.smethod_55(nick);
		}
	}

	public void FastAttack(string nick)
	{
		if (Class72.formMain_0 != null)
		{
			FormMain.smethod_5(nick);
		}
	}

	public string CheckFastAttack(string nick, string str)
	{
		if (nick.Equals(Class72.class19_0.method_30(), StringComparison.OrdinalIgnoreCase))
		{
			return string.Empty;
		}
		if (!Class72.class19_0.method_150())
		{
			return string.Empty;
		}
		return str;
	}

	public void FastAttackBlood(string nick)
	{
		if (Class72.formMain_0 != null)
		{
			FormMain.smethod_6(nick);
		}
	}

	public string CheckFastAttackBlood(string nick, string str)
	{
		if (nick.Equals(Class72.class19_0.method_30(), StringComparison.OrdinalIgnoreCase))
		{
			return string.Empty;
		}
		if (!Class72.class19_0.method_152())
		{
			return string.Empty;
		}
		return str;
	}

	public void FastAttackUltimate(string nick)
	{
		if (Class72.formMain_0 != null)
		{
			FormMain.smethod_7(nick);
		}
	}

	public void FastAttackClosedUltimate(string nick)
	{
		if (Class72.formMain_0 != null)
		{
			FormMain.smethod_9(nick);
		}
	}

	public string CheckFastAttackUltimate(string nick, string str)
	{
		if (nick.Equals(Class72.class19_0.method_30(), StringComparison.OrdinalIgnoreCase))
		{
			return string.Empty;
		}
		if (!Class72.class19_0.method_154())
		{
			return string.Empty;
		}
		return str;
	}

	public string CheckFastAttackClosedUltimate(string nick, string str)
	{
		if (nick.Equals(Class72.class19_0.method_30(), StringComparison.OrdinalIgnoreCase))
		{
			return string.Empty;
		}
		if (!Class72.class19_0.method_156())
		{
			return string.Empty;
		}
		return str;
	}

	public void FastAttackClosed(string nick)
	{
		if (Class72.formMain_0 != null)
		{
			FormMain.smethod_11(nick);
		}
	}

	public string CheckFastAttackClosed(string nick, string str)
	{
		if (nick.Equals(Class72.class19_0.method_30(), StringComparison.OrdinalIgnoreCase))
		{
			return string.Empty;
		}
		if (!Class72.class19_0.method_158())
		{
			return string.Empty;
		}
		return str;
	}

	public void FastAttackFist(string nick)
	{
		if (Class72.formMain_0 != null)
		{
			FormMain.smethod_16(nick);
		}
	}

	public string CheckFastAttackFist(string nick, string str)
	{
		if (nick.Equals(Class72.class19_0.method_30(), StringComparison.OrdinalIgnoreCase))
		{
			return string.Empty;
		}
		if (!Class72.class19_0.method_160())
		{
			return string.Empty;
		}
		return str;
	}

	public void FastAttackClosedFist(string nick)
	{
		if (Class72.formMain_0 != null)
		{
			FormMain.smethod_18(nick);
		}
	}

	public string CheckFastAttackClosedFist(string nick, string str)
	{
		if (nick.Equals(Class72.class19_0.method_30(), StringComparison.OrdinalIgnoreCase))
		{
			return string.Empty;
		}
		if (!Class72.class19_0.method_162())
		{
			return string.Empty;
		}
		return str;
	}

	public void FastAttackOpenNevid()
	{
		if (Class72.formMain_0 != null)
		{
			Class72.formMain_0.method_21();
		}
	}

	public string CheckFastAttackOpenNevid(string str)
	{
		if (!Class72.class19_0.method_164())
		{
			return string.Empty;
		}
		return str;
	}

	public string CheckFastAttackPoison(string nick, string str)
	{
		if (nick.Equals(Class72.class19_0.method_30(), StringComparison.OrdinalIgnoreCase))
		{
			return string.Empty;
		}
		if (!Class72.class19_0.method_166())
		{
			return string.Empty;
		}
		return str;
	}

	public string CheckFastAttackImp(string nick, string str)
	{
		if (nick.Equals(Class72.class19_0.method_30(), StringComparison.OrdinalIgnoreCase))
		{
			return string.Empty;
		}
		if (!Class72.class19_0.method_168())
		{
			return string.Empty;
		}
		return str;
	}

	public string CheckFastAttackStrong(string nick, string str)
	{
		if (nick.Equals(Class72.class19_0.method_30(), StringComparison.OrdinalIgnoreCase))
		{
			return string.Empty;
		}
		if (!Class72.class19_0.method_170())
		{
			return string.Empty;
		}
		return str;
	}

	public string CheckFastAttackNevid(string nick, string str)
	{
		if (nick.Equals(Class72.class19_0.method_30(), StringComparison.OrdinalIgnoreCase))
		{
			return string.Empty;
		}
		if (!Class72.class19_0.method_172())
		{
			return string.Empty;
		}
		return str;
	}

	public string CheckFastAttackFog(string nick, string str)
	{
		if (nick.Equals(Class72.class19_0.method_30(), StringComparison.OrdinalIgnoreCase))
		{
			return string.Empty;
		}
		if (!Class72.class19_0.method_174())
		{
			return string.Empty;
		}
		return str;
	}

	public string CheckFastAttackZas(string nick, string str)
	{
		if (nick.Equals(Class72.class19_0.method_30(), StringComparison.OrdinalIgnoreCase))
		{
			return string.Empty;
		}
		if (!Class72.class19_0.method_176())
		{
			return string.Empty;
		}
		return str;
	}

	public string CheckFastAttackPortal(string nick, string str)
	{
		if (nick.Equals(Class72.class19_0.method_30(), StringComparison.OrdinalIgnoreCase))
		{
			return string.Empty;
		}
		if (!Class72.class19_0.method_178())
		{
			return string.Empty;
		}
		return str;
	}

	public string CheckFastAttackTotem(string nick, string str)
	{
		if (nick.Equals(Class72.class19_0.method_30(), StringComparison.OrdinalIgnoreCase))
		{
			return string.Empty;
		}
		if (!Class72.class19_0.method_180())
		{
			return string.Empty;
		}
		return str;
	}

	public void FastAttackPoison(string nick)
	{
		if (Class72.formMain_0 != null)
		{
			FormMain.smethod_23(nick);
		}
	}

	public void FastAttackImp(string nick)
	{
		if (Class72.formMain_0 != null)
		{
			FormMain.smethod_24(nick);
		}
	}

	public void FastAttackStrong(string nick)
	{
		if (Class72.formMain_0 != null)
		{
			FormMain.smethod_26(nick);
		}
	}

	public void FastAttackExtraStrong(string nick)
	{
		if (Class72.formMain_0 != null)
		{
			FormMain.smethod_28(nick);
		}
	}

	public void FastAttackNevid(string nick)
	{
		if (Class72.formMain_0 != null)
		{
			FormMain.smethod_30(nick);
		}
	}

	public void FastAttackFog(string nick)
	{
		if (Class72.formMain_0 != null)
		{
			FormMain.smethod_20(nick);
		}
	}

	public void FastAttackZas(string nick)
	{
		if (Class72.formMain_0 != null)
		{
			FormMain.smethod_21(nick);
		}
	}

	public void FastAttackPortal(string nick)
	{
		if (Class72.formMain_0 != null)
		{
			FormMain.smethod_13(nick);
		}
	}

	public void FastAttackTotem(string nick)
	{
		if (Class72.formMain_0 != null)
		{
			FormMain.smethod_22(nick);
		}
	}

	public int GetClassIdOfContact(string nick)
	{
		return ContactsManager.smethod_5(nick);
	}

	public void HerbsList(string list)
	{
		Class72.bool_53 = true;
		FormMain.smethod_43(list);
	}

	public void TraceCut()
	{
		if (!string.IsNullOrEmpty(Class72.string_51) && !string.IsNullOrEmpty(Class72.string_52))
		{
			FormMain.smethod_44();
		}
	}

	public void SetLastHerb(string name, string type)
	{
		Class72.string_51 = name;
		Class72.string_52 = type;
	}

	public bool ShowOverWarning()
	{
		if (Class72.class19_0 != null)
		{
			return Class72.class19_0.method_132();
		}
		return false;
	}

	public void StartBulkOldSell(string name, string price)
	{
		Class72.formMain_0.method_1(name, price);
	}

	public void StartMarketPut(string name, string itemPrice, string itemDolg, string putPrice)
	{
		Class72.formMain_0.method_2(name, itemPrice, itemDolg, putPrice);
	}

	public void StartBulkDrop(string thing, string price, bool isExpired)
	{
		if (Class72.formMain_0 != null)
		{
			Class72.formMain_0.method_0(thing, price, isExpired);
		}
	}

	public void SetNeverTimer(int msec)
	{
		Class72.dateTime_12 = DateTime.Now.AddMilliseconds(msec);
		if (msec <= 0)
		{
			if (!Class72.smethod_30() && (!Class72.smethod_36() || Class72.smethod_38() == Class72.smethod_40()) && (!Class72.smethod_36() || !Class72.bool_53))
			{
				Class18.smethod_4();
			}
			Class72.bool_53 = false;
		}
	}

	public string ShowHpMaTimers(string inner, double curHP, int maxHP, double intHP, double curMA, int maxMA, double intMA)
	{
		return FormMain.smethod_70(inner, curHP, maxHP, intHP, curMA, maxMA, intMA);
	}

	public int GetItemID()
	{
		if (!string.IsNullOrEmpty(Class72.string_36) && int.TryParse(Class72.string_38.Split(',')[0].Trim(' '), out var result))
		{
			string string_ = (string.IsNullOrEmpty(Class72.string_39) ? ("Сдаём " + Class72.string_36 + " за " + Class72.string_37 + " NV...") : ("Выставляем " + Class72.string_36 + " за " + Class72.string_39 + " NV..."));
			Class72.formMain_0.method_63(string_);
			return result;
		}
		return 0;
	}

	public string GetItemVcode()
	{
		if (string.IsNullOrEmpty(Class72.string_36))
		{
			return string.Empty;
		}
		string[] array = Class72.string_38.Split(',');
		return array[array.Length - 1].Trim(' ', '\'');
	}

	public string GetItemPrice()
	{
		if (!string.IsNullOrEmpty(Class72.string_36) && !string.IsNullOrEmpty(Class72.string_39))
		{
			return Class72.string_39;
		}
		return string.Empty;
	}

	public string getCellImg(string string_0, string string_1)
	{
		return Class72.class79_0.method_1(string_0, string_1).string_2;
	}

	public void mineMoveTo(string string_0, string string_1)
	{
		Class72.formMain_0.method_125(string_0, string_1);
	}

	public string getMineCellHTML(string string_0, string string_1, string lvl)
	{
		return Class72.class79_0.method_2(string_0, string_1, lvl);
	}

	public string getMoveText()
	{
		return Class72.class79_0.method_3();
	}

	public string getLotteryRandom(int amount, int max)
	{
		List<string> list = new List<string>();
		while (list.Count < amount)
		{
			string item = Class89.smethod_1(1, max + 1).ToString();
			if (!list.Contains(item))
			{
				list.Add(item);
			}
		}
		return "[" + string.Join(",", list.ToArray()) + "]";
	}

	public bool isHighlighted(string resource)
	{
		string[] array = Class72.class19_0.method_196().Split(',');
		int num = 0;
		while (true)
		{
			if (num < array.Length)
			{
				if (array[num].Trim() == resource)
				{
					break;
				}
				num++;
				continue;
			}
			return false;
		}
		return true;
	}

	public bool DoHerbAutoCut()
	{
		if (Class72.formMain_0.method_55())
		{
			return !Class72.smethod_36();
		}
		return false;
	}

	public void AntiCaptchaStart()
	{
		new Thread(method_0).Start();
	}

	private void method_0()
	{
		Class72.string_50 = null;
		Class50 @class = new Class50();
		if (!@class.method_6())
		{
			DebugHelper.Out("API v2 send failed. " + @class.method_0());
			return;
		}
		if (!@class.method_7(120, 0))
		{
			DebugHelper.Out("Could not solve the captcha.");
			return;
		}
		Class72.string_50 = @class.method_10().Text;
		Class72.smethod_25(null);
		Class72.formMain_0.method_63("Result: " + Class72.string_50);
	}

	public string GetCaptchaCode()
	{
		return Class72.string_50;
	}

	public void ClearCaptchaCode()
	{
		Class72.string_50 = null;
	}

	public void ProcessEmptyCell()
	{
		if (!string.IsNullOrEmpty(Class72.class19_0.method_200()) && !Class72.bool_52 && !Class72.bool_51)
		{
			string[] array = Class72.class19_0.method_200().Split(',');
			int num = Array.IndexOf(array, Class72.string_4);
			do
			{
				num = ((num >= 0 && num + 1 != array.Length) ? (num + 1) : 0);
			}
			while (Class72.class19_0.sortedDictionary_0.ContainsKey(array[num]) && !Class77.smethod_17(array[num]));
			Class72.formMain_0.method_123(array[num]);
		}
	}

	public void UseCureElixir()
	{
		if (!Class72.bool_21)
		{
			Class72.bool_21 = true;
			Class72.string_29 = "Эликсир Мгновенного Исцеления";
			Class72.string_30 = Class72.class19_0.method_30();
			Class72.int_8 = 1;
			Class72.formMain_0.BeginInvoke(new Delegate20(Class72.formMain_0.method_110), new object[0]);
		}
	}

	public void WearTool(string toolID)
	{
		if (toolID == "4")
		{
			Class72.bool_52 = true;
		}
		else
		{
			Class72.bool_51 = true;
		}
	}

	public void CopyNickMethod(object nick)
	{
		Clipboard.SetText((string)nick);
	}

	public void CopyNick(string nick)
	{
		Thread thread = new Thread(CopyNickMethod);
		thread.SetApartmentState(ApartmentState.STA);
		thread.IsBackground = false;
		thread.Start(nick);
	}

	public void DwarfCraftSetCategory(int category)
	{
		Class72.int_16 = category;
	}

	public int DwarfCraftGetCategory()
	{
		if (!Class72.bool_39)
		{
			return 0;
		}
		return Class72.int_16;
	}

	public void DwarfCraftSetId(int id)
	{
		Class72.int_17 = id;
	}

	public int DwarfCraftGetId()
	{
		if (!Class72.bool_39)
		{
			return 0;
		}
		return Class72.int_17;
	}

	public string GetFortBuffsState()
	{
		return Class72.string_55;
	}

	public void LeaveFort()
	{
		Class72.string_55 = "LeaveFort";
	}

	public void MoveToFort()
	{
		Class72.string_55 = "MoveToFort";
	}

	public void TellBuffTaken()
	{
		string text = ((Class72.class19_0.timeSpan_0 != TimeSpan.MinValue) ? DateTime.Now.Subtract(Class72.class19_0.timeSpan_0) : DateTime.Now).AddMinutes(30.0).ToString("HH:mm:ss");
		Class72.formMain_0.BeginInvoke(new Delegate37(Class72.formMain_0.method_113), "%clan% Я беру бафф в локации " + Class72.smethod_134() + ". Снова будет доступен в " + text + ".");
	}

	public void SetTirednessToMax()
	{
		Class72.smethod_27(100);
		Class72.formMain_0.BeginInvoke(new Delegate20(Class72.formMain_0.method_110), new object[0]);
	}
}
