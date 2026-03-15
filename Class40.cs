using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using ABClient;
using ABClient.ABForms;

internal static class Class40
{
	private sealed class Class41
	{
		internal int int_0;

		internal string string_0;

		internal string string_1;

		internal string string_2;

		internal string string_3;
	}

	private static Thread thread_0;

	private static readonly AutoResetEvent autoResetEvent_0 = new AutoResetEvent(initialState: false);

	private static bool bool_0;

	private static string string_0 = string.Empty;

	private static readonly SortedList<string, DateTime> sortedList_0 = new SortedList<string, DateTime>();

	internal static List<string> list_0 = new List<string>();

	internal static void smethod_0()
	{
		if (thread_0 == null)
		{
			thread_0 = new Thread(smethod_4)
			{
				Name = "RoomAsync"
			};
			thread_0.Start();
		}
	}

	internal static void smethod_1()
	{
		if (thread_0 != null)
		{
			bool_0 = true;
			autoResetEvent_0.Set();
			while (thread_0.IsAlive)
			{
				thread_0.Join(50);
			}
			thread_0 = null;
		}
	}

	internal static void smethod_2(string string_1)
	{
		string key = string_1.ToLower();
		if (!sortedList_0.ContainsKey(key))
		{
			sortedList_0.Add(key, DateTime.Now);
		}
	}

	private static bool smethod_3(string string_1)
	{
		string key = string_1.ToLower();
		if (!sortedList_0.ContainsKey(key))
		{
			return false;
		}
		if (DateTime.Now.Subtract(sortedList_0[key]).TotalSeconds > 10.0)
		{
			sortedList_0.Remove(key);
			return false;
		}
		return true;
	}

	private static void smethod_4(object object_0)
	{
		while (!bool_0)
		{
			if (Class72.smethod_88())
			{
				try
				{
					IdleManager.AddActivity();
					HttpWebRequest obj = (HttpWebRequest)WebRequest.Create("http://neverlands.ru/ch.php?lo=1&");
					obj.Method = "GET";
					obj.Proxy = Class72.webProxy_0;
					string value = Class32.smethod_1("www.neverlands.ru");
					obj.Headers.Add("Cookie", value);
					Stream responseStream = obj.GetResponse().GetResponseStream();
					if (responseStream != null)
					{
						StreamReader streamReader = new StreamReader(responseStream, Class72.encoding_0);
						try
						{
							string string_ = streamReader.ReadToEnd();
							string text = Class12.smethod_1(string_, "</b></font></a> [ ", " ]");
							string text2 = Class12.smethod_1(string_, "var ChatListU = new Array(", ");");
							string strA = "[" + text + "] " + text2;
							if (string.Compare(strA, string_0, StringComparison.Ordinal) != 0)
							{
								smethod_5(string_);
								string_0 = strA;
								try
								{
									if (Class72.formMain_0 != null)
									{
										Class72.formMain_0.BeginInvoke(new Delegate19(Class72.formMain_0.method_108), new object[0]);
									}
								}
								catch (InvalidOperationException)
								{
								}
							}
						}
						finally
						{
							((IDisposable)streamReader).Dispose();
						}
					}
				}
				catch (WebException)
				{
				}
				catch (IOException)
				{
				}
				finally
				{
					IdleManager.RemoveActivity();
				}
			}
			autoResetEvent_0.WaitOne(1000, exitContext: false);
		}
	}

	internal static string smethod_5(string string_1)
	{
		string text = Class12.smethod_1(string_1, "<font class=placename><b>", "</b></font>");
		if (text != null)
		{
			text = text.Replace("<br>", " ");
			Class72.smethod_135(text);
		}
		Class41 @class = smethod_6(string_1);
		smethod_7(string_1);
		string_1 = string_1.Replace("</HEAD>", "<style type=\"text/css\">a.activenick { background-color:inherit; padding: 2 2 2 2; }a.activenick:hover { background-color:#99CCFF; padding: 2 2 2 2; }a.activeico { background-color:inherit; padding: 1 1 1 1; }a.activeico:hover { background-color:#FF9933; padding: 1 1 1 1; }</style></head>");
		int num = string_1.IndexOf("<font", StringComparison.InvariantCultureIgnoreCase);
		if (num != -1)
		{
			string_1 = string_1.Insert(num, "<script Language=\"JavaScript\">function navto(){e_m = get_by_id ('navbox');location = e_m.value;}function get_by_id(name){if (document.getElementById) return document.getElementById(name);else if (document.all) return document.all[name];}</script><select id=\"navbox\" onchange=\"navto()\" style=\"font-family:Arial; font-size:8pt\"><option value=\"ch.php?lo=1&\">Текущая клетка</option><option value=\"ch.php?lo=1&\">Исходная клетка</option><option value=\"ch.php?lo=1&r=arena0\">Зал Помощи</option><option value=\"ch.php?lo=1&r=arena1\">Тренировочный зал</option><option value=\"ch.php?lo=1&r=arena2\">Зал Испытаний</option><option value=\"ch.php?lo=1&r=arena3\">Зал Посвящения</option><option value=\"ch.php?lo=1&r=arena4\">Зал Покровителей</option><option value=\"ch.php?lo=1&r=arena5\">Зал Закона</option><option value=\"ch.php?lo=1&r=main\">Городская площадь</option><option value=\"ch.php?lo=1&r=shop_1\">Лавка</option><option value=\"ch.php?lo=1&r=workshop\">Мастерская</option><option value=\"ch.php?lo=1&r=bar0\">Таверна, Большой Зал</option><option value=\"ch.php?lo=1&r=hospi\">Больница</option><option value=\"ch.php?lo=1&r=hospi1\">Комната отдыха</option><option value=\"ch.php?lo=1&r=hospi2\">Палата</option><option value=\"ch.php?lo=1&r=hpr\">Магазин подарков</option><option value=\"ch.php?lo=1&r=hdi\">Дом дилеров</option><option value=\"ch.php?lo=1&r=hau\">Аукцион</option><option value=\"ch.php?lo=1&r=hba\">Банк</option><option value=\"ch.php?lo=1&r=obe\">Обелиск</option><option value=\"ch.php?lo=1&r=post\">Почтовая служба</option><option value=\"ch.php?lo=1&r=market\">Рынок</option><option value=\"ch.php?lo=1&r=prison\">Тюрьма</option><option value=\"ch.php?lo=1&r=shop_2\">Деревня:Лавка</option><option value=\"ch.php?lo=1&r=arena20\">Деревня:Арена</option><option value=\"ch.php?lo=1&r=hsp_1\">Октал:Больница</option><option value=\"ch.php?lo=1&r=shop_3\">Октал:Лавка</option><option value=\"ch.php?lo=1&r=rem_1\">Октал:Пункт переработки</option></select><br>");
		}
		if (Class72.smethod_88())
		{
			string_1 = string_1.Replace("<body bgcolor=#FCFAF3", "<body bgcolor=#ECEAE3");
		}
		if (int.TryParse(Class12.smethod_1(string_1, "</b></font></a> [ ", " ]"), out var result))
		{
			int num2 = result - @class.int_0;
			Class72.smethod_97(num2);
			if (num2 > 0)
			{
				int num3 = string_1.IndexOf("<b>Всего</b>", StringComparison.Ordinal);
				if (num3 != -1)
				{
					string_1 = string_1.Substring(0, num3) + "<b><font color=#2d5063>Невидимок</font></b> [ " + num2.ToString(CultureInfo.InvariantCulture) + " ]  <a class=\"activeico\" href=\"javascript:window.external.FastAttackOpenNevid()\"><img src=http://image.neverlands.ru/weapon/i_w28_28.gif width=14 height=11 border=0 alt='Свиток Обнаружения' align=absmiddle></a><br>" + string_1.Substring(num3);
					string_1 = string_1.Replace("<body bgcolor=#FCFAF3", "<body bgcolor=#F3FAFC");
				}
				if (Class72.smethod_140() && !Class72.bool_21 && Class72.formMain_0 != null)
				{
					Class72.formMain_0.method_63("Пытаемся резвеять <font color=#5D7C91><b>невидимку</b></font>!");
					Class72.formMain_0.method_21();
					return string_1;
				}
			}
			if (!string.IsNullOrEmpty(@class.string_0) && Class72.smethod_142() != 0 && !Class72.bool_21 && Class72.formMain_0 != null)
			{
				Class72.formMain_0.method_63($"Пытаемся напасть на <b>{@class.string_0}</b>!");
				int num4 = ContactsManager.smethod_6(@class.string_0);
				if (num4 == 0)
				{
					num4 = Class72.smethod_142();
				}
				switch (num4)
				{
				case 1:
					FormMain.smethod_8(@class.string_0);
					break;
				case 2:
					FormMain.smethod_10(@class.string_0);
					break;
				case 3:
					FormMain.smethod_17(@class.string_0);
					break;
				case 4:
					FormMain.smethod_19(@class.string_0);
					break;
				case 5:
					FormMain.smethod_12(@class.string_0);
					break;
				case 6:
					FormMain.smethod_14(@class.string_0);
					break;
				}
				return string_1;
			}
			if (Class72.formMain_0.method_51() && !string.IsNullOrEmpty(@class.string_1) && !Class72.bool_21)
			{
				Class72.formMain_0.method_63($"Используем свиток тумана на <b>{@class.string_1}</b>");
				FormMain.smethod_20(@class.string_1);
			}
			if (Class72.formMain_0.method_52() && !string.IsNullOrEmpty(@class.string_2) && !Class72.bool_21 && !Class72.smethod_114() && ContactsManager.smethod_5(@class.string_2) != 1)
			{
				string arg = (new string[4] { "легкую", "среднюю", "тяжелую", "боевую" })[int.Parse(@class.string_3) - 1];
				Class72.formMain_0.method_63($"Лечим {arg} травму у <b>{@class.string_2}</b>");
				Class72.smethod_115(bool_54: true);
				Class72.smethod_117(@class.string_2);
				Class72.smethod_119(@class.string_3);
				Class72.formMain_0.BeginInvoke(new Delegate20(Class72.formMain_0.method_110), new object[0]);
			}
		}
		return string_1;
	}

	private static Class41 smethod_6(string string_1)
	{
		Class41 @class = new Class41();
		string text = Class12.smethod_1(string_1, "new Array(", ");");
		if (string.IsNullOrEmpty(text))
		{
			return @class;
		}
		string[] array = text.Split(new string[1] { "\"," }, StringSplitOptions.RemoveEmptyEntries);
		if (array.Length == 0)
		{
			return @class;
		}
		List<ToolStripMenuItem> list = new List<ToolStripMenuItem>();
		List<ToolStripMenuItem> list2 = new List<ToolStripMenuItem>();
		StringBuilder stringBuilder = new StringBuilder();
		StringBuilder[] array2 = new StringBuilder[4];
		for (int i = 0; i < 4; i++)
		{
			array2[i] = new StringBuilder();
		}
		List<string> list3 = new List<string>();
		List<string> list4 = new List<string>();
		StringBuilder stringBuilder2 = new StringBuilder();
		int[] array3 = new int[4];
		list_0.Clear();
		for (int j = 0; j < array.Length; j++)
		{
			string[] array4 = array[j].Split(':');
			if (array4.Length < 8)
			{
				continue;
			}
			string text2 = array4[1].Replace("<i>", string.Empty).Replace("</i>", string.Empty);
			string text3 = array4[2];
			string sign = string.Empty;
			string status = string.Empty;
			string string_2 = string.Empty;
			if (!string.IsNullOrEmpty(array4[3]))
			{
				string[] array5 = array4[3].Split(';');
				if (array5.Length == 3)
				{
					sign = array5[0];
					status = array5[1];
				}
			}
			if (array4.Length > 8 && !string.IsNullOrEmpty(array4[8]))
			{
				string[] array6 = array4[8].Split(';');
				if (array6.Length == 2)
				{
					string_2 = array6[1].Replace("\"", string.Empty);
				}
			}
			list_0.Add(text2);
			if (Class72.bool_30 && !Class72.bool_31 && array4[1].Equals(Class72.class19_0.method_30(), StringComparison.CurrentCultureIgnoreCase))
			{
				Class72.bool_31 = true;
				Class72.string_35 = string_2;
				Class72.int_9 = 0;
				FormMain.smethod_56();
			}
			if (Class72.class19_0.method_112())
			{
				ChatUsersManager.AddUser(new ChatUser(text2, text3, sign, status));
			}
			int num = ContactsManager.smethod_5(text2);
			if (num == 1)
			{
				list3.Add(text2);
			}
			if (num == 2)
			{
				list4.Add(text2);
			}
			if (array4[3].StartsWith("pv", StringComparison.OrdinalIgnoreCase))
			{
				int num2 = array4[3].LastIndexOf(';');
				if (num2 == -1)
				{
					continue;
				}
				ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem(text2)
				{
					Image = Class39.smethod_28(),
					ToolTipText = array4[3].Substring(num2 + 1),
					AutoToolTip = true
				};
				if (Class72.formMain_0 != null)
				{
					toolStripMenuItem.Click += Class72.formMain_0.method_34;
				}
				list.Add(toolStripMenuItem);
			}
			if (string.IsNullOrEmpty(array4[6]) || array4[6].Equals("0", StringComparison.Ordinal))
			{
				continue;
			}
			int[] array7 = new int[4];
			string[] array8 = new string[4] { "легкая", "средняя", "тяжелая", "боевая" };
			int[] array9 = new int[4];
			string[] array10 = array4[6].Split(new string[1] { ", " }, StringSplitOptions.RemoveEmptyEntries);
			foreach (string text4 in array10)
			{
				for (int l = 0; l < 4; l++)
				{
					if (!Class72.class19_0.method_70()[l] || text4.IndexOf(array8[l], StringComparison.OrdinalIgnoreCase) == -1)
					{
						continue;
					}
					string[] array11 = text4.Split(' ');
					int num3;
					int result2;
					int result;
					switch (array11.Length)
					{
					default:
						num3 = 0;
						break;
					case 4:
						if (!int.TryParse(array11[2], out result2))
						{
							result2 = 0;
						}
						num3 = ((!array11[3].Equals("ч", StringComparison.OrdinalIgnoreCase)) ? result2 : (result2 * 60));
						break;
					case 5:
						if (!int.TryParse(array11[3], out result2))
						{
							result2 = 0;
						}
						num3 = ((!array11[4].Equals("ч", StringComparison.OrdinalIgnoreCase)) ? result2 : (result2 * 60));
						break;
					case 6:
						if (!int.TryParse(array11[4], out result2))
						{
							result2 = 0;
						}
						if (array11[5].Equals("ч", StringComparison.OrdinalIgnoreCase))
						{
							num3 = result2 * 60;
							break;
						}
						if (!int.TryParse(array11[2], out result))
						{
							result = 0;
						}
						num3 = result * 60 + result2;
						break;
					case 7:
						if (!int.TryParse(array11[3], out result))
						{
							result = 0;
						}
						if (!int.TryParse(array11[5], out result2))
						{
							result2 = 0;
						}
						num3 = result * 60 + result2;
						break;
					case 8:
						if (!int.TryParse(array11[4], out result))
						{
							result = 0;
						}
						if (!int.TryParse(array11[6], out result2))
						{
							result2 = 0;
						}
						num3 = result * 60 + result2;
						break;
					}
					if (array9[l] < num3)
					{
						array9[l] = num3;
					}
					array7[l]++;
				}
			}
			if (array7[0] + array7[1] + array7[2] + array7[3] <= 0)
			{
				continue;
			}
			StringBuilder stringBuilder3 = new StringBuilder();
			stringBuilder3.Append(text2);
			stringBuilder3.Append(" [");
			stringBuilder3.Append(text3);
			stringBuilder3.Append("]: ");
			if (array7[0] > 0 && array7[1] + array7[2] + array7[3] == 0)
			{
				if (array7[0] == 1)
				{
					stringBuilder3.Append("легкая");
				}
				else
				{
					stringBuilder3.Append(array7[0]);
					stringBuilder3.Append(" легких");
				}
				stringBuilder3.Append(' ');
				stringBuilder3.Append(Class4.smethod_5(array9[0]));
			}
			else if (array7[1] > 0 && array7[0] + array7[2] + array7[3] == 0)
			{
				if (array7[1] == 1)
				{
					stringBuilder3.Append("средняя");
				}
				else
				{
					stringBuilder3.Append(array7[1]);
					stringBuilder3.Append(" средних");
				}
				stringBuilder3.Append(' ');
				stringBuilder3.Append(Class4.smethod_5(array9[1]));
			}
			else if (array7[2] > 0 && array7[0] + array7[1] + array7[3] == 0)
			{
				if (array7[2] == 1)
				{
					stringBuilder3.Append("тяжелая");
				}
				else
				{
					stringBuilder3.Append(array7[2]);
					stringBuilder3.Append(" тяжелых");
				}
				stringBuilder3.Append(' ');
				stringBuilder3.Append(Class4.smethod_5(array9[2]));
			}
			else if (array7[3] > 0 && array7[0] + array7[1] + array7[2] == 0)
			{
				if (array7[3] == 1)
				{
					stringBuilder3.Append("боевая");
				}
				else
				{
					stringBuilder3.Append(array7[3]);
					stringBuilder3.Append(" боевых");
				}
				stringBuilder3.Append(' ');
				stringBuilder3.Append(Class4.smethod_5(array9[3]));
			}
			else
			{
				for (int m = 0; m < 4; m++)
				{
					if (array7[m] == 0)
					{
						stringBuilder3.Append('-');
					}
					else
					{
						stringBuilder3.Append(array7[m]);
					}
					if (m < 3)
					{
						stringBuilder3.Append('/');
					}
				}
				int int_ = 0;
				int num4 = 3;
				while (num4 >= 0)
				{
					if (array9[num4] == 0)
					{
						num4--;
						continue;
					}
					int_ = array9[num4];
					break;
				}
				stringBuilder3.Append(' ');
				stringBuilder3.Append(Class4.smethod_5(int_));
			}
			if (stringBuilder.Length > 0)
			{
				stringBuilder.Append(':');
			}
			stringBuilder.Append(text2);
			ToolStripMenuItem toolStripMenuItem2 = new ToolStripMenuItem(stringBuilder3.ToString())
			{
				Image = ((array7[3] > 0) ? Class39.smethod_8() : ((array7[2] > 0) ? Class39.smethod_7() : ((array7[1] > 0) ? Class39.smethod_6() : Class39.smethod_5()))),
				ImageScaling = ToolStripItemImageScaling.None
			};
			if (Class72.class19_0.method_72() && (array4[2].Equals("0", StringComparison.Ordinal) || array4[2].Equals("1", StringComparison.Ordinal) || array4[2].Equals("2", StringComparison.Ordinal) || array4[2].Equals("3", StringComparison.Ordinal) || array4[2].Equals("4", StringComparison.Ordinal)))
			{
				toolStripMenuItem2.Enabled = false;
			}
			else
			{
				int num5 = -1;
				if (array7[3] > 0)
				{
					array3[3]++;
					num5 = 3;
				}
				else if (array7[2] > 0)
				{
					array3[2]++;
					if (num5 == -1)
					{
						num5 = 2;
					}
				}
				else if (array7[1] > 0)
				{
					array3[1]++;
					if (num5 == -1)
					{
						num5 = 1;
					}
				}
				else
				{
					array3[0]++;
					if (num5 == -1)
					{
						num5 = 0;
					}
				}
				string[] array12 = new string[4] { "легкую", "среднюю", "тяжелую", "боевую" };
				if (num5 != -1)
				{
					if (array2[num5].Length > 0)
					{
						array2[num5].Append(':');
					}
					array2[num5].Append(text2);
				}
				stringBuilder3.Length = 0;
				stringBuilder3.Append(text2);
				stringBuilder3.Append(" [");
				stringBuilder3.Append(text3);
				stringBuilder3.Append(']');
				ToolStripMenuItem toolStripMenuItem3 = new ToolStripMenuItem(stringBuilder3.ToString())
				{
					Image = Class39.smethod_28(),
					Tag = text2
				};
				if (Class72.formMain_0 != null)
				{
					toolStripMenuItem3.Click += Class72.formMain_0.method_35;
				}
				toolStripMenuItem2.DropDownItems.Add(toolStripMenuItem3);
				ToolStripMenuItem toolStripMenuItem4 = new ToolStripMenuItem("Открыть инфу")
				{
					Image = Class39.smethod_18(),
					Tag = text2
				};
				if (Class72.formMain_0 != null)
				{
					toolStripMenuItem4.Click += Class72.formMain_0.method_36;
				}
				toolStripMenuItem2.DropDownItems.Add(toolStripMenuItem4);
				toolStripMenuItem2.DropDownItems.Add(new ToolStripSeparator());
				Bitmap[] array13 = new Bitmap[4]
				{
					Class39.smethod_5(),
					Class39.smethod_6(),
					Class39.smethod_7(),
					Class39.smethod_8()
				};
				for (int n = 0; n < 4; n++)
				{
					if (array7[n] > 0)
					{
						ToolStripMenuItem toolStripMenuItem5 = new ToolStripMenuItem("Лечить " + array12[n] + " травму")
						{
							Image = array13[n],
							ImageScaling = ToolStripItemImageScaling.None,
							Tag = text2 + ":" + (n + 1)
						};
						if (Class72.formMain_0 != null)
						{
							toolStripMenuItem5.Click += FormMain.smethod_54;
						}
						toolStripMenuItem2.DropDownItems.Add(toolStripMenuItem5);
						if (Class72.formMain_0.method_52() && string.IsNullOrEmpty(@class.string_2) && ((Class72.formMain_0.method_53() && num == 2 && Class72.string_47 != Class68.string_2) || !Class72.formMain_0.method_53()) && string.IsNullOrEmpty(Class21.smethod_7(text2)))
						{
							@class.string_2 = text2;
							@class.string_3 = (n + 1).ToString();
						}
					}
				}
				toolStripMenuItem2.DropDownItems.Add(new ToolStripSeparator());
				ToolStripMenuItem toolStripMenuItem6 = new ToolStripMenuItem("Отправить рекламу")
				{
					Tag = text2
				};
				if (Class72.formMain_0 != null)
				{
					toolStripMenuItem6.Click += FormMain.smethod_50;
				}
				toolStripMenuItem2.DropDownItems.Add(toolStripMenuItem6);
			}
			list2.Add(toolStripMenuItem2);
		}
		if (list2.Count > 0)
		{
			stringBuilder2.Append(list2.Count);
			stringBuilder2.Append(": ");
			for (int num6 = 0; num6 < 4; num6++)
			{
				if (array3[num6] == 0)
				{
					stringBuilder2.Append('-');
				}
				else
				{
					stringBuilder2.Append(array3[num6]);
				}
				if (num6 < 3)
				{
					stringBuilder2.Append('/');
				}
			}
			ToolStripMenuItem toolStripMenuItem7 = new ToolStripMenuItem("Реклама")
			{
				Image = Class39.smethod_28()
			};
			string[] array14 = new string[4] { "легкие", "средние", "тяжелые", "боевые" };
			for (int num7 = 0; num7 < 4; num7++)
			{
				if (array2[num7].Length > 0)
				{
					ToolStripMenuItem toolStripMenuItem8 = new ToolStripMenuItem("Реклама тем, у кого " + array14[num7])
					{
						Image = Class39.smethod_28(),
						Tag = num7 + 1 + ":" + array2[num7]
					};
					if (Class72.formMain_0 != null)
					{
						toolStripMenuItem8.Click += FormMain.smethod_53;
					}
					toolStripMenuItem7.DropDownItems.Add(toolStripMenuItem8);
				}
			}
			ToolStripMenuItem toolStripMenuItem9 = new ToolStripMenuItem("Реклама всем травмированным")
			{
				Image = Class39.smethod_28(),
				Tag = stringBuilder.ToString()
			};
			if (Class72.formMain_0 != null)
			{
				toolStripMenuItem9.Click += FormMain.smethod_51;
			}
			toolStripMenuItem7.DropDownItems.Add(toolStripMenuItem9);
			ToolStripMenuItem toolStripMenuItem10 = new ToolStripMenuItem("Реклама в общий чат");
			if (Class72.formMain_0 != null)
			{
				toolStripMenuItem10.Click += FormMain.smethod_52;
			}
			toolStripMenuItem7.DropDownItems.Add(toolStripMenuItem10);
			list2.Add(toolStripMenuItem7);
		}
		try
		{
			if (Class72.formMain_0 != null)
			{
				Class72.formMain_0.BeginInvoke(new Delegate24(Class72.formMain_0.method_99), list.ToArray(), stringBuilder2.ToString(), list2.ToArray());
			}
		}
		catch (InvalidOperationException)
		{
		}
		@class.int_0 = array.Length;
		if (list3.Count > 0)
		{
			List<string> list5 = new List<string>();
			foreach (string item in list5)
			{
				if (!smethod_3(item))
				{
					list5.Add(item);
				}
			}
			@class.string_0 = ((list5.Count > 0) ? list3[Class89.smethod_0(list5.Count)] : list3[Class89.smethod_0(list3.Count)]);
		}
		if (list4.Count > 0)
		{
			@class.string_1 = list4[Class89.smethod_0(list4.Count)];
		}
		return @class;
	}

	private static void smethod_7(string string_1)
	{
		if (!Class72.smethod_88())
		{
			return;
		}
		string text = Class12.smethod_1(string_1, "<font class=placename><b>", "</b>");
		if (string.IsNullOrEmpty(text))
		{
			return;
		}
		string text2 = Class12.smethod_1(string_1, "new Array(", ");");
		if (string.IsNullOrEmpty(text2))
		{
			return;
		}
		string[] array = text2.Split(new string[1] { "\"," }, StringSplitOptions.RemoveEmptyEntries);
		if (array.Length == 0)
		{
			return;
		}
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		for (int i = 0; i < array.Length; i++)
		{
			string text3 = array[i].Substring(3, array[i].Length - 3);
			string[] array2 = text3.Split(':');
			if (array2.Length >= 3 && array2[1].IndexOf("<i>", StringComparison.OrdinalIgnoreCase) == -1)
			{
				dictionary.Add(array2[1], text3);
			}
		}
		if (Class72.class19_0.method_58() == Class72.smethod_90() && text == Class72.smethod_92())
		{
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			foreach (string key in Class72.smethod_94().Keys)
			{
				if (key == null || dictionary.ContainsKey(key))
				{
					continue;
				}
				if (key.Equals(Class72.class19_0.method_30(), StringComparison.CurrentCultureIgnoreCase))
				{
					if (Class72.formMain_0 != null)
					{
						Class72.formMain_0.method_63("<b><font color=#01A9DB>Мы ушли в невид</font></b>");
					}
				}
				else
				{
					dictionary2.Add(key, Class72.smethod_94()[key]);
				}
			}
			Dictionary<string, string> dictionary3 = new Dictionary<string, string>();
			foreach (string key2 in dictionary.Keys)
			{
				if (key2 == null || Class72.smethod_94().ContainsKey(key2))
				{
					continue;
				}
				if (key2.Equals(Class72.class19_0.method_30(), StringComparison.CurrentCultureIgnoreCase))
				{
					if (Class72.formMain_0 != null)
					{
						Class72.formMain_0.method_63("<b><font color=#DF0101>Мы вышли из невида!</font></b>");
					}
				}
				else
				{
					dictionary3.Add(key2, dictionary[key2]);
				}
			}
			int num = Class72.smethod_96() - Class72.smethod_98();
			if (dictionary2.Count != 0 || dictionary3.Count != 0 || num != 0)
			{
				StringBuilder stringBuilder = new StringBuilder();
				int num2 = 0;
				if (num > 0)
				{
					num2 = 1;
					stringBuilder.Append("<font color=#5D7C91><b>");
					if (num == 1)
					{
						stringBuilder.Append("Невидимка");
					}
					else
					{
						stringBuilder.Append(num);
						stringBuilder.Append(" невидимок");
					}
					stringBuilder.Append("</b></font>");
				}
				if (dictionary3.Count > 0)
				{
					foreach (string key3 in dictionary3.Keys)
					{
						if (num2 > 0)
						{
							stringBuilder.Append(", ");
						}
						num2++;
						stringBuilder.Append(smethod_8(dictionary3[key3]));
					}
				}
				if (num2 > 0)
				{
					stringBuilder.Append((num2 > 1) ? " приходят в локацию" : " приходит в локацию");
				}
				Class72.smethod_101(stringBuilder.ToString());
				stringBuilder.Length = 0;
				num2 = 0;
				if (num < 0)
				{
					num2 = 1;
					stringBuilder.Append("<font color=#5D7C91><b>");
					if (num == -1)
					{
						stringBuilder.Append("Невидимка");
					}
					else
					{
						stringBuilder.Append(-num);
						stringBuilder.Append(" невидимок");
					}
					stringBuilder.Append("</b></font>");
				}
				if (dictionary2.Count > 0)
				{
					foreach (string key4 in dictionary2.Keys)
					{
						if (num2 > 0)
						{
							stringBuilder.Append(", ");
						}
						num2++;
						stringBuilder.Append(smethod_8(dictionary2[key4]));
					}
				}
				if (num2 > 0)
				{
					stringBuilder.Append((num2 > 1) ? " покидают локацию" : " покидает локацию");
				}
				Class72.smethod_103(stringBuilder.ToString());
			}
		}
		Class72.smethod_91(Class72.class19_0.method_58());
		Class72.smethod_93(text);
		Class72.smethod_94().Clear();
		Class72.smethod_95(new Dictionary<string, string>(dictionary));
		Class72.smethod_99(Class72.smethod_96());
		if (!string.IsNullOrEmpty(Class72.smethod_100()))
		{
			Class18.smethod_5();
			try
			{
				if (Class72.formMain_0 != null)
				{
					Class72.formMain_0.BeginInvoke(new Delegate7(Class72.formMain_0.method_100), Class72.smethod_100());
				}
			}
			catch (InvalidOperationException)
			{
			}
			Class72.smethod_101(string.Empty);
		}
		if (string.IsNullOrEmpty(Class72.smethod_102()))
		{
			return;
		}
		try
		{
			if (Class72.formMain_0 != null)
			{
				Class72.formMain_0.BeginInvoke(new Delegate7(Class72.formMain_0.method_100), Class72.smethod_102());
			}
		}
		catch (InvalidOperationException)
		{
		}
		Class72.smethod_103(string.Empty);
	}

	private static string smethod_8(string string_1)
	{
		string[] array = string_1.Split(':');
		string text = array[1];
		string text2 = array[1];
		while (text.Contains("+"))
		{
			text = text.Replace("+", "%2B");
		}
		if (text2.Contains("<i>"))
		{
			text2 = text2.Replace("<i>", string.Empty);
			text2 = text2.Replace("</i>", string.Empty);
			text = text.Replace("<i>", string.Empty);
			text = text.Replace("</i>", string.Empty);
		}
		string text3 = string.Empty;
		string text4 = string.Empty;
		if (array[3].Length > 1)
		{
			string[] array2 = array[3].Split(';');
			if (array2[2].Length > 1)
			{
				text4 = " (" + array2[2] + ")";
			}
			text3 = "<img src=http://image.neverlands.ru/signs/" + array2[0] + " width=15 height=12 align=absmiddle alt=\"" + array2[1] + text4 + "\">&nbsp;";
		}
		string text5 = string.Empty;
		if (array[4].Length > 1)
		{
			text5 = "<img src=http://image.neverlands.ru/signs/molch.gif width=15 height=12 border=0 alt=\"" + array[4] + "\" align=absmiddle>";
		}
		string text6 = string.Empty;
		if (array[5] == "1")
		{
			text6 = "<a href=\"javascript:ch_clear_ignor('" + text2 + "');\"><img src=http://image.neverlands.ru/signs/ignor/3.gif width=15 height=12 border=0 alt=\"Снять игнорирование\"></a>";
		}
		string text7 = string.Empty;
		if (array[6] != "0")
		{
			text7 = "<img src=http://image.neverlands.ru/chat/tr4.gif border=0 width=15 height=12 alt=\"" + array[6] + "\" align=absmiddle>";
			if (array[6].Contains("боевая"))
			{
				array[1] = "<font color=\"#666600\">" + array[1] + "</font>";
			}
			else if (array[6].Contains("тяжелая"))
			{
				array[1] = "<font color=\"#c10000\">" + array[1] + "</font>";
			}
			else if (array[6].Contains("средняя"))
			{
				array[1] = "<font color=\"#e94c69\">" + array[1] + "</font>";
			}
			else if (array[6].Contains("легкая"))
			{
				array[1] = "<font color=\"#ef7f94\">" + array[1] + "</font>";
			}
		}
		string text8 = string.Empty;
		if (array[7] != "0")
		{
			string[] array3 = new string[12]
			{
				string.Empty,
				"Дилер",
				string.Empty,
				string.Empty,
				string.Empty,
				string.Empty,
				string.Empty,
				string.Empty,
				string.Empty,
				string.Empty,
				string.Empty,
				"Помощник дилера"
			};
			text8 = "<img src=http://image.neverlands.ru/signs/d_sm_" + array[7] + ".gif width=15 height=12 align=absmiddle border=0 alt=\"" + array3[int.Parse(array[7])] + "\">&nbsp;";
		}
		string text9 = string.Empty;
		if (array[8] != "0")
		{
			string[] array4 = array[8].Split(';');
			if (array4.Length >= 2)
			{
				text9 = "<img src=http://image.neverlands.ru/signs/" + array4[0] + " width=15 height=12 align=absmiddle border=0 alt=\"" + array4[1] + "\">&nbsp";
			}
		}
		return "<a href=\"#\" onclick=\"top.say_private('" + text2 + "');\"><img src=http://image.neverlands.ru/chat/private.gif width=11 height=12 border=0 align=absmiddle></a>&nbsp;" + text8 + text9 + text3 + "<a class=\"activenick\" href=\"#\" onclick=\"top.say_to('" + text2 + "');\"><font class=nickname><b>" + array[1] + "</b></a>[" + array[2] + "]</font><a href=\"http://www.neverlands.ru/pinfo.cgi?" + text + "\" onclick=\"window.open(this.href);\"><img src=http://image.neverlands.ru/chat/info.gif width=11 height=12 border=0 align=absmiddle></a>" + text5 + text6 + text7;
	}
}
