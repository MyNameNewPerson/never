using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using ABClient.ABForms;
using ABClient.ExtMap;
using ABClient.Lez;
using ABClient.PostFilter;

internal static class Class30
{
	private static readonly List<Class3> list_0;

	static Class30()
	{
		list_0 = new List<Class3>();
	}

	private static byte[] smethod_0(byte[] byte_0)
	{
		string text = Class91.encoding_0.GetString(byte_0);
		DateTime now = DateTime.Now;
		string[] obj = Class12.smethod_1(text, "var serverDate = new Date(", ");")?.Split(',');
		string text2 = obj[3]?.Trim();
		string text3 = obj[4]?.Trim();
		string text4 = obj[5]?.Trim();
		if (!string.IsNullOrEmpty(text2) && !string.IsNullOrEmpty(text3) && !string.IsNullOrEmpty(text4) && int.TryParse(text2, out var result) && int.TryParse(text3, out var result2) && int.TryParse(text4, out var result3))
		{
			DateTime value = new DateTime(now.Year, now.Month, now.Day, result, result2, result3);
			Class72.class19_0.timeSpan_0 = now.Subtract(value);
			if (Class72.class19_0.timeSpan_0 > new TimeSpan(1, 0, 0, 0))
			{
				Class72.class19_0.timeSpan_0 = new TimeSpan(0L);
			}
		}
		text = text.Replace("/b1.gif", "/b1.gif name=butinp");
		return Class91.encoding_0.GetBytes(text);
	}

	private static byte[] smethod_1()
	{
		return Class91.encoding_0.GetBytes(Class39.smethod_51().Replace("alt=", "title="));
	}

	private static byte[] smethod_2(byte[] byte_0)
	{
		StringBuilder stringBuilder = new StringBuilder(Class91.encoding_0.GetString(byte_0));
		stringBuilder.Replace("s += txt + \"<BR>\";", "s += window.external.ChatFilter(txt);");
		stringBuilder.Replace(",65000);", ", 65000); window.external.ChatUpdated()");
		stringBuilder.Replace("msgp[2].replace(user,'<SPAN alt=\"%'+user2+'\">'+user+'</SPAN>');", "msgp[2].replace(user,'<SPAN alt=\"%'+user+'\">'+user+'</SPAN>');");
		stringBuilder.Replace("msgp[2] = msgp[2].replace(' '+user,' <SPAN alt=\"'+user2+'\">'+user+'</SPAN>');", "msgp[2] = msgp[2].replace(' '+user,' <SPAN alt=\"'+user+'\">'+user+'</SPAN>');");
		stringBuilder.Replace("login = login.replace ('%', '');", "top.frames['ch_buttons'].document.FBT.text.focus(); var prompt = top.frames['ch_buttons'].document.FBT.text.value; if (prompt.indexOf('%clan%') == 0 || prompt.indexOf('%pair%') == 0) { login = login.replace('%',''); login = login.replace('%',''); login = login.replace('%',''); top.frames['ch_buttons'].document.FBT.text.value = prompt + '%<' + login + '> '; return false; } else {if (login.charAt(2) == '%'){ login = login.substr(3); top.frames['ch_buttons'].document.FBT.text.value = '%pair%%<' + login + '> ' + prompt; return false; } else if (login.charAt(1) == '%'){ login = login.substr(2); top.frames['ch_buttons'].document.FBT.text.value = '%clan%%<' + login + '> ' + prompt; return false; } else login = login.substr(1); }");
		stringBuilder.Replace("alt=", "title=");
		stringBuilder.Replace(".alt", ".title");
		stringBuilder.Replace(" + document.body.scrollLeft", string.Empty);
		stringBuilder.Replace(" + document.body.scrollTop", string.Empty);
		stringBuilder.Replace("cpn.innerHTML = nick;", "cpn.innerHTML = nick; window.external.CopyNick(nick);");
		stringBuilder.AppendLine(Environment.NewLine + "function scrollChat() { window.scrollBy(0, 65000); } setTimeout(scrollChat, 100);");
		return Class91.encoding_0.GetBytes(stringBuilder.ToString());
	}

	private static byte[] smethod_3(byte[] byte_0)
	{
		string string_ = Class91.encoding_0.GetString(byte_0);
		string_ = Class40.smethod_5(string_);
		return Class91.encoding_0.GetBytes(string_);
	}

	private static string smethod_4(string string_0, string string_1)
	{
		if (!string_0.Contains("СПИСОК ВЕЩЕЙ КЛАНА / СЕМЬИ "))
		{
			return smethod_10("Переходим в казну", "main.php?wfo=1&useaction=clan-action&addid=3");
		}
		string[] array = Class72.string_46.Split(':');
		if (array.Length < 1)
		{
			return string_0;
		}
		string text = array[0];
		string text2 = "main.php?get_id=29&uid=" + text;
		string text3 = Class12.smethod_1(string_0, text2, "'");
		Class72.string_46 = string.Empty;
		if (array.Length - 1 > 0)
		{
			for (int i = 1; i < array.Length; i++)
			{
				if (!string.IsNullOrEmpty(Class72.string_46))
				{
					Class72.string_46 += ":";
				}
				Class72.string_46 += array[i];
			}
		}
		else
		{
			Class72.string_46 = "FINISHED";
		}
		if (!string.IsNullOrEmpty(text3))
		{
			return smethod_10("Берём вещь", text2 + text3);
		}
		Class72.formMain_0.method_63("Вещь занята или отсутствует в казне. ID: <b>" + text + "</b>");
		return smethod_10("Вещь не найдена. Обновляем фрейм.", "main.php?wfo=1&useaction=clan-action&addid=3");
	}

	private static byte[] smethod_5(string string_0)
	{
		return Class91.encoding_0.GetBytes(string_0.Replace("['+pl['level']+']&nbsp;</div></td>", " ['+pl['level']+']&nbsp;</div></td><td style=\"border-right:1px solid #e0e0e0; border-bottom:1px solid #e0e0e0; background:'+bg+';text-align:center;\"><b>'+pl['money']+' NV</b>'+'</td>"));
	}

	private static string smethod_6(string string_0, string string_1)
	{
		if (string_0.Contains("<B>ТЕХНОЛОГИЯ</B>") || string_0.Contains("<B>РЕЦЕПТУРА</B>"))
		{
			Class72.string_43 = string_1;
		}
		if (!string_0.Contains("Идет процесс изготовления материалов") && !string_0.Contains("Идет процесс приготовления еды"))
		{
			if (Class72.bool_39)
			{
				if (string_0.Contains("FRES"))
				{
					if (!string.IsNullOrEmpty(Class72.string_43))
					{
						string newValue = Class12.smethod_1(string_0, "value=\"0\"><input type=\"hidden\" name=\"vcode\" value=\"", "\">");
						string oldValue = Class12.smethod_1(Class72.string_43, "vcode=", "&");
						string string_2 = Class72.string_43.Replace(oldValue, newValue);
						return smethod_10("Выбираем ресурсы...", string_2);
					}
				}
				else if (string_0.Contains("<B>ТЕХНОЛОГИЯ</B>") || string_0.Contains("<B>РЕЦЕПТУРА</B>"))
				{
					if (Class72.bool_40)
					{
						string text = Class12.smethod_1(string_0, "location='", "'");
						if (!string.IsNullOrEmpty(text))
						{
							return smethod_10("Запускаем производство...", text);
						}
						Class72.formMain_0.method_63("Невозможно произвести указанный продукт.");
						Class72.formMain_0.BeginInvoke(new Delegate5(Class72.formMain_0.method_46), new object[0]);
					}
					else if (!string.IsNullOrEmpty(Class72.string_44))
					{
						string text2 = Class12.smethod_1(Class72.string_44, "http://www.neverlands.ru/", "&tm=");
						string text3 = Class12.smethod_1(string_0, text2, "'");
						if (!string.IsNullOrEmpty(text3))
						{
							return smethod_10("Запускаем производство...", text2 + text3);
						}
						Class72.formMain_0.method_63("Невозможно произвести указанный продукт.");
						Class72.formMain_0.BeginInvoke(new Delegate5(Class72.formMain_0.method_46), new object[0]);
					}
				}
			}
			if (string_0.Contains("FRES"))
			{
				string_0 = string_0.Replace("<input type=checkbox DISABLED>", "<input type=checkbox onclick=\"for(var elements=[],inputs=document.getElementById('FRES').nextSibling.getElementsByTagName('input'),i=0;i<inputs.length;i++)'checkbox'===inputs[i].type&&elements.push(inputs[i]);for(var check=elements[0].checked,i=1;i<elements.length;i++)elements[i].checked=check;\">");
			}
			return string_0;
		}
		if (string_1.Contains("recid="))
		{
			Class72.string_44 = string_1;
		}
		return string_0;
	}

	private static string smethod_7(string string_0, string string_1)
	{
		string text = smethod_37(string_0);
		if (!string.IsNullOrEmpty(text))
		{
			return text;
		}
		if (!string_1.Contains("mselect=12"))
		{
			return smethod_10("Переключаемся на биржу DNV", "main.php?mselect=12");
		}
		string[] array = Class12.smethod_1(string_0, "<b>Всего заявок</b></td><td bgcolor=#FCFAF3></td></tr><tr>", "</tr><form action=main.php method=POST>").Split(new string[1] { "</tr><tr>" }, StringSplitOptions.RemoveEmptyEntries);
		int num = 0;
		string text3;
		string text4;
		string text5;
		string text6;
		while (true)
		{
			if (num < array.Length)
			{
				string text2 = array[num];
				text3 = Class12.smethod_1(text2, "location = '", "'");
				if (!string.IsNullOrEmpty(text3))
				{
					string[] array2 = text2.Split(new string[1] { "</td>\r\n            <td bgcolor=#FFFFFF class=forumne align=center>" }, StringSplitOptions.RemoveEmptyEntries);
					if (array2.Length < 4)
					{
						array2 = text2.Split(new string[1] { "</td>\r\n            <td bgcolor=#FCFAF3 class=forumne align=center>" }, StringSplitOptions.RemoveEmptyEntries);
					}
					text4 = Class12.smethod_1(array2[0], "<b>", "</b>");
					text5 = array2[1];
					text6 = array2[2];
					if (int.Parse(text6) <= Class72.class19_0.method_192())
					{
						break;
					}
				}
				num++;
				continue;
			}
			Class72.bool_38 = false;
			if (Class72.class19_0.method_100())
			{
				text = smethod_33(string_0);
				if (!string.IsNullOrEmpty(text))
				{
					string_0 = text;
				}
			}
			return string_0;
		}
		Class72.formMain_0.method_63("Найдены доступные DNV: " + text4 + " x " + text5 + " = " + text6 + ". Оставляем заявку.");
		return smethod_10("Оставляем заявку на DNV", text3);
	}

	private static byte[] smethod_8(byte[] byte_0)
	{
		StringBuilder stringBuilder = new StringBuilder(Class91.encoding_0.GetString(byte_0));
		stringBuilder.Replace("var tkeys = '';", "var tkeys = ''; setTimeout(function(){window.external.AntiCaptchaStart();var e=setInterval(function(){var t=window.external.GetCaptchaCode();t&&(clearInterval(e),window.external.ClearCaptchaCode(),document.getElementById('CAPInput').value=t,document.forms.FEND.submit())},1e3)},1e3); ");
		stringBuilder.Replace("name=code", "name=code id=CAPInput");
		stringBuilder.Replace("<input type=button value=\" xoд \" name=\"btx0\" class=fbut onclick=\"javascript: StartAct()\"> <input type=button value=сбросить name=\"bt2\" class=fbut onclick=\"javascript: RefreshF()\">", "<input type=button value=\" ход (0:00)\" name=\"btx0\" class=fbut onclick=\"javascript: myStartAct()\"> <input type=button value=\"автовыбор\" name=\"btav\" title=\"Предложить ход\" class=fbut onclick=\"javascript: AutoSelect()\"> <input type=button value=\"автоход\" name=\"btav\" title=\"Один ход\" class=fbut onclick=\"javascript: AutoTurn()\"> <input type=button value=\"автобой\" name=\"btab\" title=\"Полный автобой\" class=fbut onclick=\"javascript: AutoBoi()\"> <input type=button value=\"сбросить\" name=\"bt2\" class=fbut onclick=\"javascript: RefreshF()\">  <style type=\"text/css\"> .fbutred {  BACKGROUND: #ffcccc;  BORDER: solid 1px #dea6a6  COLOR: #333333;  CURSOR: hand;  FONT: 11px Tahoma, Verdana, Arial;  FONT-WEIGHT: bold; } </style> <SCRIPT language=\"JavaScript\">  document.all(\"btx0\").value = window.external.XodButtonElapsedTime();  var curTimeInt = setInterval(\"xodtimerproc()\",1000);  function xodtimerproc(){    document.all(\"btx0\").value = window.external.XodButtonElapsedTime(); } function myStartAct(){    window.external.ResetLastBoiTimer();   StartAct(); } </SCRIPT>");
		stringBuilder.Replace("<input type=submit class=fbut value=\"Завершить", "<input type=button class=fbut onclick=\"javascript: document.forms[\\'FEND\\'].submit();\" value=\"Завершить");
		stringBuilder.AppendLine();
		stringBuilder.AppendLine("function AutoSubmit(result){ var ss = result.split(\"|\");  if (ss.length > 8)  {    var form_node = d.getElementById('form_main');    form_node.appendChild(AddElement('post_id','7'));    form_node.appendChild(AddElement('vcode',ss[0]));    form_node.appendChild(AddElement('enemy',ss[1]));    form_node.appendChild(AddElement('group',ss[2]));    form_node.appendChild(AddElement('inf_bot',ss[3]));    form_node.appendChild(AddElement('lev_bot',ss[4]));    form_node.appendChild(AddElement('ftr',ss[5]));    form_node.appendChild(AddElement('inu',ss[6]));    form_node.appendChild(AddElement('inb',ss[7]));    form_node.appendChild(AddElement('ina',ss[8]));    fight_f.submit();  }}");
		stringBuilder.AppendLine("function AutoSelect(){  window.external.AutoSelect();}");
		stringBuilder.AppendLine("function AutoTurn(){  window.external.AutoTurn();}");
		stringBuilder.AppendLine("function AutoUd(){  window.external.AutoUd();  AutoSelect();}");
		stringBuilder.AppendLine("function AutoBoi(){  window.external.AutoBoi();  AutoSelect();}");
		return Class91.encoding_0.GetBytes(stringBuilder.ToString());
	}

	internal static byte[] smethod_9(string string_0, byte[] byte_0)
	{
		if (string_0.StartsWith("http://www.neverlands.ru/main.php", StringComparison.OrdinalIgnoreCase) && Class72.dateTime_13 != DateTime.MinValue)
		{
			Class72.dateTime_13.CompareTo(Class72.smethod_132());
			_ = 0;
		}
		string text = Class91.encoding_0.GetString(byte_0);
		if (Class72.class19_0.method_110() && (string_0.Contains(".js") || string_0.StartsWith("http://www.neverlands.ru/main.php", StringComparison.OrdinalIgnoreCase)))
		{
			byte_0 = smethod_11(text);
		}
		if (string_0.EndsWith("/js/store.js", StringComparison.OrdinalIgnoreCase) && Class72.class19_0.method_30() == Class68.string_1)
		{
			return Class91.encoding_0.GetBytes(Class39.smethod_321());
		}
		if (string_0.EndsWith("/js/t_v01.js", StringComparison.OrdinalIgnoreCase) && Class72.class19_0.method_30() == Class68.string_1)
		{
			return Class91.encoding_0.GetBytes(Class39.smethod_322());
		}
		if (string_0.Contains(".js"))
		{
			if (string_0.EndsWith("/js/game.js", StringComparison.OrdinalIgnoreCase))
			{
				return smethod_15(byte_0);
			}
			if (string_0.Contains("/js/fight_v"))
			{
				return smethod_8(byte_0);
			}
			if (string_0.EndsWith("/js/hpmp.js", StringComparison.OrdinalIgnoreCase))
			{
				return smethod_17();
			}
			if (string_0.EndsWith("/ch/ch_msg_v01.js", StringComparison.OrdinalIgnoreCase))
			{
				return smethod_2(byte_0);
			}
			if (string_0.EndsWith("/js/pv.js", StringComparison.OrdinalIgnoreCase))
			{
				return smethod_99(byte_0);
			}
			if (string_0.EndsWith("/ch/ch_list.js", StringComparison.OrdinalIgnoreCase))
			{
				return smethod_1();
			}
			if (string_0.EndsWith("/js/svitok.js", StringComparison.OrdinalIgnoreCase))
			{
				return smethod_101(byte_0);
			}
			if (string_0.EndsWith("/js/slots.js", StringComparison.OrdinalIgnoreCase))
			{
				return smethod_100(byte_0);
			}
			if (string_0.IndexOf("/js/shop", StringComparison.OrdinalIgnoreCase) != -1)
			{
				return smethod_85(byte_0);
			}
			if (string_0.IndexOf("/js/market", StringComparison.OrdinalIgnoreCase) != -1)
			{
				return Class91.encoding_0.GetBytes(Class91.encoding_0.GetString(byte_0).Replace("AjaxPost('market_ajax.php?action=place_item_put&cat_id='+current_cat+'&minl='+min_level+'&maxl='+max_level+'&minp='+min_price+'&maxp='+max_price+'&vcode='+place_act[1]+'&r='+Math.random()+'', data, function(xdata) {", "AjaxPost('market_ajax.php?action=place_item_put&cat_id='+current_cat+'&minl='+min_level+'&maxl='+max_level+'&minp='+min_price+'&maxp='+max_price+'&vcode='+place_act[1]+'&r='+Math.random()+'', data, function(xdata) { var id = window.external.GetItemID(); if (id > 0) place_item_put(id, window.external.GetItemPrice(), window.external.GetItemVcode());"));
			}
			if (string_0.IndexOf("/js/forum/forum_topic.js", StringComparison.OrdinalIgnoreCase) >= 0)
			{
				return smethod_14(byte_0);
			}
			if (string_0.IndexOf("/js/lottery", StringComparison.OrdinalIgnoreCase) >= 0)
			{
				if (!Class72.class19_0.method_110())
				{
					return Class91.encoding_0.GetBytes(Class39.smethod_77());
				}
				return smethod_11(Class39.smethod_77());
			}
			if (string_0.IndexOf("/js/construction", StringComparison.OrdinalIgnoreCase) >= 0)
			{
				return smethod_5(text);
			}
			if (string_0.IndexOf("/js/arena", StringComparison.OrdinalIgnoreCase) >= 0)
			{
				return Class91.encoding_0.GetBytes(Class39.smethod_48());
			}
			if (string_0.IndexOf("/js/dwarfshop", StringComparison.OrdinalIgnoreCase) >= 0)
			{
				return Class91.encoding_0.GetBytes(Class39.smethod_53());
			}
			if (string_0.IndexOf("/js/hp.js", StringComparison.OrdinalIgnoreCase) >= 0)
			{
				return Class91.encoding_0.GetBytes(Class39.smethod_54());
			}
			if (string_0.IndexOf("/js/hpr", StringComparison.OrdinalIgnoreCase) >= 0)
			{
				return Class91.encoding_0.GetBytes(Class39.smethod_55());
			}
			if (string_0.IndexOf("/js/map", StringComparison.OrdinalIgnoreCase) >= 0)
			{
				return Class91.encoding_0.GetBytes(Class39.smethod_79());
			}
			if (string_0.IndexOf("/js/mine", StringComparison.OrdinalIgnoreCase) >= 0)
			{
				return Class91.encoding_0.GetBytes(Class39.smethod_82());
			}
			if (string_0.IndexOf("/js/nl_windows_mess", StringComparison.OrdinalIgnoreCase) >= 0)
			{
				return Class91.encoding_0.GetBytes(Class39.smethod_83());
			}
			if (string_0.IndexOf("/js/outpost", StringComparison.OrdinalIgnoreCase) >= 0)
			{
				return Class91.encoding_0.GetBytes(Class39.smethod_84());
			}
			if (string_0.IndexOf("/js/timer", StringComparison.OrdinalIgnoreCase) >= 0)
			{
				return Class91.encoding_0.GetBytes(Class39.smethod_323());
			}
		}
		if (string_0.StartsWith("http://www.neverlands.ru/index.cgi", StringComparison.OrdinalIgnoreCase) || string_0.Equals("http://www.neverlands.ru/", StringComparison.OrdinalIgnoreCase))
		{
			return smethod_18(byte_0);
		}
		if (string_0.StartsWith("http://www.neverlands.ru/game.php", StringComparison.OrdinalIgnoreCase))
		{
			return smethod_16(byte_0);
		}
		if (string_0.StartsWith("http://www.neverlands.ru/main.php", StringComparison.OrdinalIgnoreCase))
		{
			Class72.dateTime_11 = DateTime.Now.AddMinutes(5.0);
			return smethod_27(string_0, byte_0);
		}
		if (string_0.StartsWith("http://www.neverlands.ru/ch/msg.php", StringComparison.OrdinalIgnoreCase))
		{
			return smethod_98(byte_0);
		}
		if (string_0.StartsWith("http://www.neverlands.ru/ch/but.php", StringComparison.OrdinalIgnoreCase))
		{
			return smethod_0(byte_0);
		}
		if (string_0.StartsWith("http://www.neverlands.ru/gameplay/ajax/fish_ajax.php", StringComparison.OrdinalIgnoreCase))
		{
			return smethod_12(byte_0);
		}
		if (string_0.StartsWith("http://www.neverlands.ru/gameplay/ajax/mine_ajax.php", StringComparison.OrdinalIgnoreCase))
		{
			return smethod_81(byte_0);
		}
		if (string_0.StartsWith("http://www.neverlands.ru/gameplay/ajax/shop_ajax.php", StringComparison.OrdinalIgnoreCase) || string_0.StartsWith("http://www.neverlands.ru/gameplay/ajax/market_ajax.php", StringComparison.OrdinalIgnoreCase))
		{
			return smethod_84(byte_0);
		}
		if (string_0.StartsWith("http://www.neverlands.ru/gameplay/ajax/roulette_ajax.php", StringComparison.OrdinalIgnoreCase))
		{
			return smethod_82(byte_0);
		}
		if (string_0.StartsWith("http://www.neverlands.ru/ch.php?lo=", StringComparison.OrdinalIgnoreCase))
		{
			return smethod_3(byte_0);
		}
		if (string_0.StartsWith("http://www.neverlands.ru/gameplay/ajax/map_act_ajax.php", StringComparison.OrdinalIgnoreCase))
		{
			if (text.Contains("нужна лопата"))
			{
				Class72.bool_49 = true;
			}
			string text2 = Class12.smethod_1(text, "Предмет: ", " (1 шт)");
			if (!string.IsNullOrEmpty(text2))
			{
				Class72.string_33 = Class72.string_48;
				Class72.formMain_0.BeginInvoke(new Delegate36(Class72.formMain_0.method_62), "[" + Class72.string_4 + "] Вы выкопали <b>" + text2 + "</b>!");
			}
			return Class91.encoding_0.GetBytes(text);
		}
		if (string_0.StartsWith("http://www.neverlands.ru/services/service_stat.php", StringComparison.OrdinalIgnoreCase))
		{
			string text3 = Class12.smethod_1(text, "Сумма за период: </td><td colspan=\"2\" bgcolor=\"#FFFFFF\">", "</td></tr>");
			float num = float.Parse(text3, NumberStyles.Any, CultureInfo.InvariantCulture);
			string string_1 = $"{text3} DNV / {num * 25f} RUB";
			text = Class12.smethod_0(text, "Сумма за период: </td><td colspan=\"2\" bgcolor=\"#FFFFFF\">", "</td></tr>", string_1);
			return Class91.encoding_0.GetBytes(text);
		}
		if (string_0.StartsWith("http://www.neverlands.ru/gameplay/ajax/event.php", StringComparison.OrdinalIgnoreCase))
		{
			string text4 = Class12.smethod_1(text, "},\"m\":[\"", "\"]}");
			if (!string.IsNullOrEmpty(text4) && text4.Contains("<br \\/>"))
			{
				text4 = text4.Replace("<br \\/>", " ");
			}
			Class72.formMain_0.BeginInvoke(new Delegate36(Class72.formMain_0.method_62), text4);
			return Class91.encoding_0.GetBytes(text);
		}
		return byte_0;
	}

	private static string smethod_10(string string_0, string string_1)
	{
		return Class7.smethod_1() + string_0 + "<script language=\"JavaScript\">window.location = \"" + string_1 + "\";</script></body></html>";
	}

	private static byte[] smethod_11(string string_0)
	{
		return Class91.encoding_0.GetBytes(string_0.Replace("width=760 height=255 border=0>", "width=0 height=0 border=0>").Replace("width=\"760\" height=\"255\" border=\"0\">", "width=0 height=0 border=0>").Replace("width=1064 height=357", "width=0 height=0")
			.Replace("id=\"mainImage\"", "id=\"mainImage\" style=\"display:none\""));
	}

	internal static byte[] smethod_12(byte[] byte_0)
	{
		Class72.smethod_125(bool_54: false);
		string text = Class72.encoding_0.GetString(byte_0);
		if (text.IndexOf("У Вас нет приманки, чтобы ловить рыбу.", StringComparison.OrdinalIgnoreCase) == -1 && text.IndexOf("Приманок нет в наличии.", StringComparison.OrdinalIgnoreCase) == -1 && text.IndexOf("У Вас не хватает умения, чтобы ловить тут рыбу.", StringComparison.OrdinalIgnoreCase) == -1)
		{
			if (text.IndexOf("У Вас нет рыболовных снастей.", StringComparison.OrdinalIgnoreCase) != -1)
			{
				Class72.smethod_65(bool_54: true);
			}
			if (text.IndexOf("Нет клёва.", StringComparison.OrdinalIgnoreCase) != -1)
			{
				Class72.formMain_0.method_63("Нет клёва.");
				return byte_0;
			}
			int num = text.IndexOf('"');
			if (num == -1)
			{
				return byte_0;
			}
			num++;
			int startIndex = text.IndexOf('"', num);
			if (num == -1)
			{
				return byte_0;
			}
			if (text.IndexOf("лёв:", StringComparison.InvariantCultureIgnoreCase) != -1)
			{
				string text2 = smethod_13(text);
				if (!string.IsNullOrEmpty(text2))
				{
					text = text.Substring(0, num) + text2 + text.Substring(startIndex);
				}
				byte_0 = Class72.encoding_0.GetBytes(text);
			}
			return byte_0;
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
		return byte_0;
	}

	private static string smethod_13(string string_0)
	{
		int result = 0;
		int result2 = 0;
		bool flag = string_0.IndexOf("повысилось на 1!", StringComparison.OrdinalIgnoreCase) != -1;
		Class72.smethod_67(string_0.IndexOf("повысилось на 1!", StringComparison.OrdinalIgnoreCase) != -1 || Class72.class19_0.method_92() == 0);
		int num = string_0.IndexOf('«');
		if (num == -1)
		{
			return string.Empty;
		}
		int num2 = string_0.IndexOf('»', num);
		if (num2 == -1)
		{
			return string.Empty;
		}
		string text = string_0.Substring(num + 1, num2 - num - 1);
		string text2 = Class12.smethod_1(string_0, "Улов: ", " шт.");
		if (!string.IsNullOrEmpty(text2) && !int.TryParse(text2, out result))
		{
			result = 0;
		}
		string text3 = Class12.smethod_1(string_0, "Клёв: ", " шт.");
		if (!string.IsNullOrEmpty(text3) && !int.TryParse(text3, out result2))
		{
			result2 = 0;
		}
		string value = "Нет клёва.";
		if (string_0.IndexOf(value, StringComparison.OrdinalIgnoreCase) != -1)
		{
			result2 = 0;
		}
		else
		{
			value = "Не удалось вытащить рыбу.";
			if (string_0.IndexOf(value, StringComparison.OrdinalIgnoreCase) != -1)
			{
				return string.Empty;
			}
		}
		StringBuilder stringBuilder = new StringBuilder();
		StringBuilder stringBuilder2 = new StringBuilder();
		stringBuilder.Append("<b>");
		stringBuilder.Append(text);
		stringBuilder.Append("</b> [<b>");
		stringBuilder.Append(result);
		stringBuilder.Append('/');
		stringBuilder.Append(result2);
		stringBuilder.Append("</b>]. ");
		if (flag)
		{
			Class19 class19_ = Class72.class19_0;
			int num3 = class19_.method_92();
			class19_.method_93(num3 + 1);
		}
		if (Class72.class19_0.method_92() > 0)
		{
			stringBuilder.Append("Умение");
			stringBuilder2.Append("Умение");
			stringBuilder.Append(":&nbsp;<b>");
			stringBuilder2.Append(": ");
			stringBuilder.Append(Class72.class19_0.method_92());
			stringBuilder.Append("</b>");
			stringBuilder2.Append(Class72.class19_0.method_92());
			if (flag)
			{
				stringBuilder.Append("&nbsp;(<font color=#008800><b>+");
				stringBuilder2.Append(" (+");
				stringBuilder.Append(1);
				stringBuilder2.Append(1);
				stringBuilder.Append("<img src=http://image.neverlands.ru/gameplay/up.gif width=10 height=14></b></font>)");
				stringBuilder2.Append(')');
			}
			stringBuilder2.AppendLine();
		}
		double num4 = 0.0;
		double num5 = 0.0;
		switch (Class0.smethod_0(text))
		{
		case 373886487u:
			if (text == "Окунь")
			{
				num4 = 11.54;
				num5 = 2.0;
			}
			break;
		case 137069047u:
			if (text == "Форель")
			{
				num4 = 29.75;
				num5 = 5.0;
			}
			break;
		case 793148677u:
			if (text == "Язь")
			{
				num4 = 29.12;
				num5 = 2.0;
			}
			break;
		case 510503469u:
			if (text == "Налим")
			{
				num4 = 23.85;
				num5 = 3.0;
			}
			break;
		case 800640004u:
			if (text == "Ёрш")
			{
				num4 = 3.34;
				num5 = 2.0;
			}
			break;
		case 798447591u:
			if (text == "Щука")
			{
				num4 = 23.15;
				num5 = 5.0;
			}
			break;
		case 1032507169u:
			if (text == "Судак")
			{
				num4 = 13.14;
				num5 = 2.0;
			}
			break;
		case 954605897u:
			if (text == "Подлещик")
			{
				num4 = 4.76;
				num5 = 2.0;
			}
			break;
		case 854604668u:
			if (text == "Лещ")
			{
				num4 = 22.2;
				num5 = 2.0;
			}
			break;
		case 1735824402u:
			if (text == "Карась")
			{
				num4 = 4.32;
				num5 = 2.0;
			}
			break;
		case 1077701763u:
			if (text == "Краснопёрка")
			{
				num4 = 8.58;
				num5 = 2.0;
			}
			break;
		case 2064224503u:
			if (text == "Линь")
			{
				num4 = 31.62;
				num5 = 2.0;
			}
			break;
		case 1818151449u:
			if (text == "Плотва")
			{
				num4 = 3.62;
				num5 = 2.0;
			}
			break;
		case 1751753510u:
			if (text == "Бычок")
			{
				num4 = 8.8;
				num5 = 2.0;
			}
			break;
		case 3837116558u:
			if (text == "Карп")
			{
				num4 = 5.26;
				num5 = 2.0;
			}
			break;
		case 2407735966u:
			if (text == "Сом")
			{
				num4 = 42.04;
				num5 = 4.0;
			}
			break;
		case 4254552621u:
			if (text == "Верхоплавка")
			{
				num4 = 2.68;
				num5 = 2.0;
			}
			break;
		case 4190661792u:
			if (text == "Голавль")
			{
				num4 = 7.26;
				num5 = 2.0;
			}
			break;
		case 4084946502u:
			if (text == "Пескарь")
			{
				num4 = 3.94;
				num5 = 2.0;
			}
			break;
		}
		double num6 = 0.0;
		double num7 = 0.0;
		string text4 = Class72.smethod_126();
		switch (Class0.smethod_0(text4))
		{
		case 357040498u:
			if (text4 == "Червяк")
			{
				num6 = 1.0;
				num7 = 0.1;
			}
			break;
		case 184836036u:
			if (text4 == "Донка")
			{
				num6 = 12.0;
				num7 = 0.3;
			}
			break;
		case 495217959u:
			if (text4 == "Крупный червяк")
			{
				num6 = 1.0;
				num7 = 0.2;
			}
			break;
		case 486437143u:
			if (text4 == "Хлеб")
			{
				num6 = 1.0;
				num7 = 0.2;
			}
			break;
		case 1905844510u:
			if (text4 == "Блесна")
			{
				num6 = 10.0;
				num7 = 0.3;
			}
			break;
		case 1569760851u:
			if (text4 == "Мотыль")
			{
				num6 = 5.0;
				num7 = 0.1;
			}
			break;
		case 3483415050u:
			if (text4 == "Мормышка")
			{
				num6 = 15.0;
				num7 = 0.3;
			}
			break;
		case 3146199722u:
			if (text4 == "Заговоренная блесна")
			{
				num6 = 20.0;
				num7 = 0.4;
			}
			break;
		case 2034854705u:
			if (text4 == "Опарыш")
			{
				num6 = 5.0;
				num7 = 0.1;
			}
			break;
		}
		double num8 = 0.0;
		if (!string.IsNullOrEmpty(Class72.smethod_68()))
		{
			stringBuilder.Append("<br>");
			stringBuilder.Append("Долговечность");
			stringBuilder2.Append(Class72.smethod_68());
			stringBuilder.Append(":&nbsp;<b>");
			stringBuilder2.Append(" (до заброса): ");
			stringBuilder.Append(Class72.smethod_72());
			stringBuilder2.Append(Class72.smethod_72());
			stringBuilder.Append("</b>");
			num8 -= 2.5;
			stringBuilder2.AppendLine();
		}
		if (!string.IsNullOrEmpty(Class72.smethod_80()) && (result > 0 || result2 > 0))
		{
			stringBuilder.Append("<br>");
			stringBuilder.Append("Масса");
			stringBuilder2.Append("Масса");
			stringBuilder.Append(":&nbsp;<b>");
			stringBuilder2.Append(": ");
			double num9 = num5 * (double)result - num7 * (double)result2;
			string[] array = Class72.smethod_80().Split('/');
			Class72.smethod_81((Convert.ToDouble(array[0], CultureInfo.InvariantCulture) + num9).ToString("###0.##", CultureInfo.InvariantCulture) + "/" + array[1]);
			stringBuilder.Append(Class72.smethod_80());
			if (num9 != 0.0)
			{
				string value2 = num9.ToString("###0.##", CultureInfo.InvariantCulture);
				if (num9 < 0.0)
				{
					stringBuilder.Append("</b>&nbsp;(<font color=#CC0000><b>");
					stringBuilder2.Append(" (");
					stringBuilder.Append(value2);
					stringBuilder2.Append(value2);
					stringBuilder.Append("<img src=http://image.neverlands.ru/gameplay/down.gif width=10 height=14></b></font>)");
					stringBuilder2.Append(')');
				}
				else
				{
					stringBuilder.Append("</b>&nbsp;(<font color=#008800><b>+");
					stringBuilder2.Append(" (+");
					stringBuilder.Append(value2);
					stringBuilder2.Append(value2);
					stringBuilder.Append("<img src=http://image.neverlands.ru/gameplay/up.gif width=10 height=14></b></font>)");
					stringBuilder2.Append(')');
				}
			}
			stringBuilder2.AppendLine();
		}
		if (!string.IsNullOrEmpty(text4))
		{
			stringBuilder.Append("<br><b>");
			stringBuilder.Append(text4);
			stringBuilder2.Append(text4);
			stringBuilder.Append("</b>&nbsp;(остаток):&nbsp;<b>");
			stringBuilder2.Append(" (остаток): ");
			int value3 = Class72.smethod_128() - result2;
			stringBuilder.Append(value3);
			stringBuilder2.Append(value3);
			if (result2 > 0)
			{
				stringBuilder.Append("</b>&nbsp;(<font color=#CC0000><b>-");
				stringBuilder2.Append(" (-");
				stringBuilder.Append(result2);
				stringBuilder2.Append(result2);
				stringBuilder.Append("<img src=http://image.neverlands.ru/gameplay/down.gif width=10 height=14></b></font>)");
				stringBuilder2.Append(')');
			}
			num8 -= num6 * (double)result2;
			stringBuilder2.AppendLine();
		}
		if (!string.IsNullOrEmpty(text))
		{
			stringBuilder2.Append(text);
			stringBuilder2.Append(" (улов): ");
			stringBuilder2.Append(result);
			num8 += num4 * (double)result;
			stringBuilder2.AppendLine();
		}
		stringBuilder2.Append((num8 < 0.0) ? "Потери" : "Доход");
		stringBuilder2.Append(": ");
		string value4 = num8.ToString("###0.##", CultureInfo.InvariantCulture);
		if (num8 < 0.0)
		{
			stringBuilder2.Append(value4);
			stringBuilder2.Append(" NV");
		}
		else
		{
			stringBuilder2.Append('+');
			stringBuilder2.Append(value4);
			stringBuilder2.Append(" NV");
		}
		stringBuilder2.AppendLine();
		Class72.smethod_83(Class72.smethod_82() + num8);
		try
		{
			if (Class72.formMain_0 != null)
			{
				Class72.formMain_0.BeginInvoke(new Delegate12(Class72.formMain_0.method_86), (int)num8);
			}
		}
		catch (InvalidOperationException)
		{
		}
		stringBuilder.Append("<br>");
		if (Class72.smethod_82() < 0.0)
		{
			stringBuilder.Append("Потери&nbsp;за&nbsp;рыбалку");
			stringBuilder2.Append("Потери за рыбалку");
		}
		else
		{
			stringBuilder.Append("Доход&nbsp;за&nbsp;рыбалку");
			stringBuilder2.Append("Доход за рыбалку");
		}
		stringBuilder.Append(":&nbsp;");
		stringBuilder2.Append(": ");
		value4 = Class72.smethod_82().ToString("###0.##", CultureInfo.InvariantCulture);
		if (Class72.smethod_82() < 0.0)
		{
			stringBuilder.Append("<font color=#CC0000><b>");
			stringBuilder.Append(value4);
			stringBuilder2.Append(value4);
			stringBuilder.Append("<img src=http://image.neverlands.ru/gameplay/down.gif width=10 height=14></b></font>&nbsp;NV");
			stringBuilder2.Append(" NV");
		}
		else
		{
			stringBuilder.Append("<font color=#008800><b>+");
			stringBuilder2.Append('+');
			stringBuilder.Append(value4);
			stringBuilder2.Append(value4);
			stringBuilder.Append("<img src=http://image.neverlands.ru/gameplay/up.gif width=10 height=14></b></font>&nbsp;NV");
			stringBuilder2.Append(" NV");
		}
		if (Class72.class19_0.method_124())
		{
			try
			{
				if (Class72.formMain_0 != null)
				{
					Class72.formMain_0.BeginInvoke(new Delegate33(Class72.formMain_0.method_93), stringBuilder2.ToString());
				}
			}
			catch (InvalidOperationException)
			{
			}
		}
		if (!string.IsNullOrEmpty(text) && Class72.class19_0.method_98())
		{
			StringBuilder stringBuilder3 = new StringBuilder("Умение <b>");
			stringBuilder3.Append(Class72.class19_0.method_92());
			stringBuilder3.Append("</b>. ");
			stringBuilder3.Append(text4);
			stringBuilder3.Append(" <b>");
			stringBuilder3.Append(Class72.smethod_128() - result2);
			stringBuilder3.Append("</b>");
			if (!string.IsNullOrEmpty(Class72.smethod_68()) && !string.IsNullOrEmpty(Class72.smethod_70()) && (Class72.smethod_68().Equals("Сачок", StringComparison.OrdinalIgnoreCase) || Class72.smethod_70().Equals("Сачок", StringComparison.OrdinalIgnoreCase)))
			{
				stringBuilder3.Append("+Сачок");
			}
			stringBuilder3.Append(". ");
			stringBuilder3.Append(text);
			stringBuilder3.Append(" [");
			stringBuilder3.Append(result);
			stringBuilder3.Append('/');
			stringBuilder3.Append(result2);
			stringBuilder3.Append("]. ");
			if (Class72.smethod_82() < 0.0)
			{
				stringBuilder3.Append("Потери");
			}
			else
			{
				stringBuilder3.Append("Доход");
			}
			stringBuilder3.Append(": <b>");
			stringBuilder3.Append(Class72.smethod_82().ToString("###0.##", CultureInfo.InvariantCulture));
			stringBuilder3.Append(" NV</b>.");
			if (flag)
			{
				stringBuilder3.Append(" Умение \"Рыбалка\" <b>повысилось на 1</b>!");
			}
			if (Class72.class19_0.method_98())
			{
				try
				{
					if (Class72.formMain_0 != null)
					{
						Class72.formMain_0.BeginInvoke(new Delegate36(Class72.formMain_0.method_62), stringBuilder3.ToString());
					}
				}
				catch (InvalidOperationException)
				{
				}
			}
		}
		Class72.smethod_63(bool_54: true);
		Class72.smethod_65(bool_54: false);
		return stringBuilder.ToString();
	}

	private static byte[] smethod_14(byte[] byte_0)
	{
		if (!Class72.class19_0.method_108())
		{
			return byte_0;
		}
		string text = Class91.encoding_0.GetString(byte_0);
		text = text.Replace("<br><img src=\"http://image.neverlands.ru/forum/avatars/'+fdata[10]+'.jpg\" width=\"80\" height=\"80\" border=\"0\" vspace=\"3\">", string.Empty).Replace("<br><img src=\"http://image.neverlands.ru/forum/avatars/'+fdata[i][6]+'.jpg\" width=\"80\" height=\"80\" border=\"0\" vspace=\"3\">", string.Empty);
		return Class91.encoding_0.GetBytes(text);
	}

	private static byte[] smethod_15(byte[] byte_0)
	{
		string text = Class91.encoding_0.GetString(byte_0);
		text = text.Replace("*,300", "*,400");
		text = text.Replace("var ChatClearSize = 12228;", "var ChatClearSize=12228;" + Environment.NewLine + "var AutoArena = 1;" + Environment.NewLine + "var AutoArenaTimer = -1;" + Environment.NewLine + "function arenareload(now) {" + Environment.NewLine + "  if(!AutoArena && (AutoArenaTimer < 0 || now)) {" + Environment.NewLine + "    var tm = now ? 1000 : 500;" + Environment.NewLine + "    AutoArenaTimer = setTimeout('toprefresh('+now+')', tm);" + Environment.NewLine + "  }" + Environment.NewLine + "}" + Environment.NewLine + "function toprefresh(now){" + Environment.NewLine + "  if(AutoArenaTimer >= 0) {" + Environment.NewLine + "    clearTimeout(AutoArenaTimer);" + Environment.NewLine + "    if(!AutoArena) AutoArenaTimer = setTimeout ('toprefresh(0)', 500);" + Environment.NewLine + "    else AutoArenaTimer = -1;" + Environment.NewLine + "  }" + Environment.NewLine + "  if(!AutoArena || now) top.frames['main_top'].location = './main.php';" + Environment.NewLine + "}" + Environment.NewLine);
		return Class91.encoding_0.GetBytes(text);
	}

	private static byte[] smethod_16(byte[] byte_0)
	{
		string text = Class91.encoding_0.GetString(byte_0);
		if (Class72.smethod_8() && !string.IsNullOrEmpty(Class72.class19_0.method_36()))
		{
			string text2 = Class12.smethod_1(text, "new FlashPass(document.getElementById('canvas'), ", ");");
			if (!string.IsNullOrEmpty(text2))
			{
				Class72.smethod_17("\r\n                            " + Class7.smethod_1() + "\r\n                            Ввод второго пароля...\r\n                            <form action=\"./game.php\" method=\"POST\" name=\"ff\">\r\n                                <input type=\"hidden\" value=\"" + Class72.class19_0.method_36() + "\" name=\"flcheck\">\r\n                                <input type=\"hidden\" value=\"" + text2 + "\" name=\"nid\">\r\n                            </form>\r\n                            <script language=\"JavaScript\">\r\n                                document.ff.submit();\r\n                            </script></body></html>\r\n                        ");
				return Class91.encoding_0.GetBytes(Class72.smethod_16());
			}
		}
		Class72.smethod_9(bool_54: false);
		Class72.smethod_17(text);
		return Class91.encoding_0.GetBytes(Class72.smethod_16());
	}

	private static byte[] smethod_17()
	{
		StringBuilder stringBuilder = new StringBuilder("var interv;function ins_HP(){    interv = setInterval(\"cha_HP()\",1000);    if(inshp[0] < 0) inshp[0] = 0;    if(inshp[3] < 7) inshp[3] = 7;}function hms(secs){    time=[0,0,secs];    for(var i=2; i>0; i--)    {        time[i-1] = Math.floor(time[i]/60);        time[i] = time[i]%/**/60;        if (time[i] < 10)             time[i] = '0' + time[i];    };    if (time[0] == 0)     {        var mtime = [time[1], time[2]];        return mtime.join(':');    }    return time.join(':');}function cha_HP(){    if(inshp[0] < 0) inshp[0] = 0;    if(inshp[0] > inshp[1]) inshp[0] = inshp[1];    if(inshp[2] > inshp[3]) inshp[2] = inshp[3];    if(inshp[0] >= inshp[1] && inshp[2] >= inshp[3]) clearInterval(interv);    s_hp_f = Math.round(160*(inshp[0]/inshp[1]));    s_ma_f = Math.round(160*(inshp[2]/inshp[3]));    d.getElementById('fHP').width = s_hp_f;    d.getElementById('eHP').width = 160 - s_hp_f;    d.getElementById('fMP').width = s_ma_f;    d.getElementById('eMP').width = 160 - s_ma_f;       if(document.all(\"hbar\"))        {            var result = '<font class=hpfont>: [<font color=#bb0000><b>' + Math.round(inshp[0]) + '</b>/<b>' + inshp[1] + '</b>';");
		stringBuilder.Append("            var sHP = Math.round(((inshp[1]-inshp[0])*inshp[4])/inshp[1]);            if (sHP > 0) result = result + ' (<b>' + hms(sHP) + '</b>)';");
		stringBuilder.Append("            result = result + '</font> | <font color=#336699><b>' + Math.round(inshp[2]) + '</b>/<b>' + inshp[3] + '</b>';");
		stringBuilder.Append("            var sMA = Math.round(((inshp[3]-inshp[2])*inshp[5])/inshp[3]);            if (sMA > 0) result = result + ' (<b>' + hms(sMA) + '</b>)';");
		stringBuilder.Append("            result = result + '</font>]</font>';           document.all(\"hbar\").innerHTML = result;        }    inshp[0] += inshp[1]/inshp[4];    inshp[2] += inshp[3]/inshp[5];}");
		return Class91.encoding_0.GetBytes(stringBuilder.ToString());
	}

	private static byte[] smethod_18(byte[] byte_0)
	{
		string text = Class91.encoding_0.GetString(byte_0);
		if (text.IndexOf("<form method=\"post\" id=\"auth_form\" action=\"./game.php\">", StringComparison.OrdinalIgnoreCase) == -1)
		{
			return byte_0;
		}
		int num = text.IndexOf("show_warn(\"", StringComparison.OrdinalIgnoreCase);
		if (num != -1)
		{
			num += 11;
			int num2 = text.IndexOf('"', num);
			if (num2 != -1)
			{
				string text2 = text.Substring(num, num2 - num);
				if (!string.IsNullOrEmpty(text2))
				{
					try
					{
						if (Class72.formMain_0 != null)
						{
							Class72.formMain_0.BeginInvoke(new Delegate27(Class72.formMain_0.method_87), text2);
						}
					}
					catch (InvalidOperationException)
					{
					}
					return Class91.encoding_0.GetBytes(string.Empty);
				}
			}
		}
		StringBuilder stringBuilder = new StringBuilder(Class7.smethod_1() + "Ввод имени и пароля...<form action=\"./game.php\" method =POST name=ff><input name=player_nick type=hidden value=\"");
		stringBuilder.Append(HttpUtility.HtmlEncode(Class72.class19_0.method_30()));
		stringBuilder.Append("\"> <input name=player_password type=hidden value=\"");
		stringBuilder.Append(HttpUtility.HtmlEncode(Class72.class19_0.method_32()));
		stringBuilder.Append("\"></form><script language=\"JavaScript\">document.ff.submit();</script></body></html>");
		Class72.smethod_9(bool_54: true);
		Class72.smethod_17(stringBuilder.ToString());
		return Class91.encoding_0.GetBytes(Class72.smethod_16());
	}

	private static int[] smethod_19(string string_0)
	{
		if (!smethod_38(string_0) && !smethod_36(string_0))
		{
			return null;
		}
		if (string_0.IndexOf("<a href=\"?wfo=1\">", StringComparison.CurrentCultureIgnoreCase) == -1)
		{
			return null;
		}
		int[] array = new int[4];
		string text = Class12.smethod_1(string_0, "<script>var cureff = [[", "]]; effects_view();</script>");
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

	private static string smethod_20(string string_0)
	{
		string value = "'Зелье Лечения Отравлений'";
		int num = string_0.IndexOf(value, StringComparison.OrdinalIgnoreCase);
		if (num == -1)
		{
			return null;
		}
		int num2 = string_0.LastIndexOf('<', num);
		if (num2 == -1)
		{
			return null;
		}
		num2++;
		int num3 = string_0.IndexOf('>', num);
		if (num3 == -1)
		{
			return null;
		}
		string text = string_0.Substring(num2, num3 - num2);
		if (text.IndexOf("magicreform(", StringComparison.Ordinal) == -1)
		{
			return null;
		}
		text = Class12.smethod_1(text, "magicreform('", "')");
		if (string.IsNullOrEmpty(text))
		{
			return null;
		}
		string[] array = text.Split('\'');
		if (array.Length < 7)
		{
			return null;
		}
		string value2 = array[0];
		string value3 = array[6];
		StringBuilder stringBuilder = new StringBuilder(Class7.smethod_1() + "Используем ");
		stringBuilder.Append("Зелье Лечения Отравлений");
		stringBuilder.Append(" на себя...");
		stringBuilder.Append("<form action=main.php method=POST name=ff>");
		stringBuilder.Append("<input name=magicrestart type=hidden value=\"");
		stringBuilder.Append(1);
		stringBuilder.Append("\">");
		stringBuilder.Append("<input name=magicreuid type=hidden value=\"");
		stringBuilder.Append(value2);
		stringBuilder.Append("\">");
		stringBuilder.Append("<input name=vcode type=hidden value=\"");
		stringBuilder.Append(value3);
		stringBuilder.Append("\">");
		stringBuilder.Append("<input name=post_id type=hidden value=\"");
		stringBuilder.Append(46);
		stringBuilder.Append("\">");
		stringBuilder.Append("<input name=fornickname type=hidden value=\"");
		stringBuilder.Append(Class72.class19_0.method_30());
		stringBuilder.Append("\">");
		stringBuilder.Append("</form><script language=\"JavaScript\">document.ff.submit();</script></body></html>");
		return stringBuilder.ToString();
	}

	private static string smethod_21(string string_0)
	{
		if (string.IsNullOrEmpty(string_0))
		{
			return null;
		}
		string value;
		int num;
		switch (Class72.smethod_118())
		{
		case "4":
			value = "4";
			goto IL_0065;
		case "3":
			value = "2";
			goto IL_0065;
		case "2":
			value = "1";
			goto IL_0065;
		case "1":
			{
				value = "0";
				goto IL_0065;
			}
			IL_0065:
			num = 0;
			while (num != -1)
			{
				num = string_0.IndexOf("doctorform(", num, StringComparison.OrdinalIgnoreCase);
				if (num == -1)
				{
					break;
				}
				num += 11;
				int num2 = string_0.IndexOf(")", num, StringComparison.OrdinalIgnoreCase);
				if (num2 == -1)
				{
					continue;
				}
				string text = string_0.Substring(num, num2 - num);
				if (string.IsNullOrEmpty(text))
				{
					continue;
				}
				string[] array = text.Split(',');
				if (array.Length >= 5)
				{
					string value2 = array[0].Trim('\'');
					string value3 = array[1].Trim('\'');
					string value4 = array[2].Trim('\'');
					string text2 = array[3].Trim('\'');
					string value5 = array[4].Trim('\'');
					if (text2.Equals(value, StringComparison.OrdinalIgnoreCase))
					{
						StringBuilder stringBuilder = new StringBuilder();
						stringBuilder.Append(Class7.smethod_1() + "Используем аптечку на ");
						stringBuilder.Append(Class72.smethod_116());
						stringBuilder.Append("...");
						stringBuilder.Append("<form action=main.php method=POST name=ff>");
						stringBuilder.Append("<input name=dtype type=hidden value=\"");
						stringBuilder.Append(text2);
						stringBuilder.Append("\">");
						stringBuilder.Append("<input name=addid type=hidden value=\"");
						stringBuilder.Append(2);
						stringBuilder.Append("\">");
						stringBuilder.Append("<input name=post_id type=hidden value=\"");
						stringBuilder.Append(3);
						stringBuilder.Append("\">");
						stringBuilder.Append("<input name=dprice type=hidden value=\"");
						stringBuilder.Append(value4);
						stringBuilder.Append("\">");
						stringBuilder.Append("<input name=dcurs type=hidden value=\"");
						stringBuilder.Append(value5);
						stringBuilder.Append("\">");
						stringBuilder.Append("<input name=duid type=hidden value=\"");
						stringBuilder.Append(value2);
						stringBuilder.Append("\">");
						stringBuilder.Append("<input name=vcode type=hidden value=\"");
						stringBuilder.Append(value3);
						stringBuilder.Append("\">");
						stringBuilder.Append("<input name=fnick type=hidden value=\"");
						stringBuilder.Append(Class72.smethod_116());
						stringBuilder.Append("\">");
						stringBuilder.Append("</form><script language=\"JavaScript\">document.ff.submit();</script></body></html>");
						return stringBuilder.ToString();
					}
				}
			}
			break;
		}
		return null;
	}

	private static void smethod_22(string string_0)
	{
		Match match = new Regex("&gx=([\\d]+)").Match(string_0);
		if (match.Groups.Count >= 2)
		{
			int int_ = Convert.ToInt32(match.Groups[1].Value, CultureInfo.InvariantCulture);
			Match match2 = new Regex("&gy=([\\d]+)").Match(string_0);
			if (match2.Groups.Count >= 2)
			{
				int int_2 = Convert.ToInt32(match2.Groups[1].Value, CultureInfo.InvariantCulture);
				Class72.string_4 = Class77.smethod_26(int_, int_2);
			}
		}
	}

	private static string[] smethod_23(string string_0)
	{
		if (string.IsNullOrEmpty(string_0))
		{
			return null;
		}
		List<string> list = new List<string>();
		int num = 0;
		while (num >= 0 && num < string_0.Length)
		{
			num = string_0.IndexOf("compl_view(\"", num, StringComparison.Ordinal);
			if (num == -1)
			{
				break;
			}
			num += 12;
			int num2 = num;
			if (num2 >= string_0.Length)
			{
				break;
			}
			num2 = string_0.IndexOf("\"", num2, StringComparison.Ordinal);
			if (num2 == -1)
			{
				break;
			}
			string item = string_0.Substring(num, num2 - num);
			list.Add(item);
			num = num2 + 1;
		}
		if (list.Count != 0)
		{
			return list.ToArray();
		}
		return null;
	}

	private static string smethod_24(string string_0)
	{
		int num = string_0.IndexOf("<canvas id=\"roulette\"", StringComparison.Ordinal);
		if (num == -1)
		{
			return string_0;
		}
		int num2 = string_0.IndexOf("</script>", num, StringComparison.Ordinal);
		if (num2 == -1)
		{
			return string_0;
		}
		num2 += 9;
		string[] array = Class12.smethod_1(string_0, "new Roulette(", ");")?.Split(',');
		string text = array[1]?.Trim()?.Trim('\'');
		bool flag = array[2]?.Trim() == "true";
		bool num3 = array[3]?.Trim() == "true";
		string text2 = (flag ? "бесплатно" : "0.2 DNV");
		string text3 = (flag ? "free" : "1dnv");
		double num4 = 10.0 + Math.Floor(float.Parse(text.Remove(0, 1), CultureInfo.InvariantCulture) / 50f);
		string text4 = $"<br>Текущий джекпот:<br><br><b style='font-size:{num4}px'>{text}</b>";
		if (num3)
		{
			text4 = text4 + "<br><br><input type=\"button\" onclick=\"javascript:startRoulette({}, '" + text3 + "');\" value=\"Крутить (" + text2 + ")\" class=\"lbut\" style=\"font-size:16px;\"<br>";
		}
		string_0 = string_0.Substring(0, num) + text4 + string_0.Substring(num2);
		return string_0;
	}

	private static string smethod_25(string string_0, int int_0)
	{
		string text = string.Empty;
		string text2 = Class12.smethod_1(string_0, "<font class=nickname>", ". <b>");
		if (int_0 % 2 == 0)
		{
			text = string_0.Replace("#f0f0f0", "#ffffff");
		}
		if (int_0 % 2 == 1)
		{
			text = string_0.Replace("#ffffff", "#f0f0f0");
		}
		return text.Replace("<font class=nickname>" + text2 + ". <b>", "<font class=nickname>" + int_0 + ". <b>");
	}

	private static string smethod_26(string string_0)
	{
		Class72.formMain_0.BeginInvoke(new Delegate36(Class72.formMain_0.method_62), "На текущей клетке обнаружен клад!");
		if (Class72.bool_34 && Class72.bool_48)
		{
			string text = Class12.smethod_1(string_0, "[\"dig\",\"Копать\",\"", "\"");
			string value = "Digg('" + text + "');";
			int num = string_0.IndexOf("view_map();", StringComparison.OrdinalIgnoreCase);
			if (num != -1)
			{
				num += 11;
				return string_0.Insert(num, value);
			}
		}
		else
		{
			Class18.smethod_7();
			Class72.formMain_0.BeginInvoke(new Delegate15(Class72.formMain_0.method_95), new object[0]);
		}
		return string_0;
	}

	private static byte[] smethod_27(string string_0, byte[] byte_0)
	{
		bool flag = DateTime.Now > Class72.dateTime_12;
		smethod_22(string_0);
		Class72.dateTime_9 = DateTime.Now;
		Class72.smethod_15(DateTime.Now);
		Class72.smethod_17(null);
		string input = Class91.encoding_0.GetString(byte_0);
		input = new Regex("<!DOCTYPE[^>[]*(\\[[^]]*\\])?>").Replace(input, string.Empty);
		Class72.smethod_17(input);
		Class18.smethod_3();
		string text = Class12.smethod_1(input, "<font class=nickname><font color=#cc0000><b>", "<br><br></b></font></font>");
		if (!string.IsNullOrEmpty(text))
		{
			if (text.Contains("DNV"))
			{
				string text2 = Class12.smethod_1(input, "<b id=\"user_deamoney\">&nbsp;", " DNV");
				text = text + " (остаток: " + text2 + " DNV)";
			}
			Class72.formMain_0.BeginInvoke(new Delegate36(Class72.formMain_0.method_62), "<font color=#cc0000><b>" + text + "</b></font>");
		}
		Class43.smethod_0(input);
		int[] array = smethod_19(input);
		if (array != null)
		{
			Class72.smethod_147(array);
		}
		if (!string.IsNullOrEmpty(Class72.class19_0.method_184()))
		{
			string[] array2 = Class72.class19_0.method_184().Split('|');
			if (array2.Length != 0)
			{
				if (string.IsNullOrEmpty(Class72.class19_0.method_138()))
				{
					Class72.class19_0.method_139(array2[Class89.smethod_0(array2.Length)]);
					if (Class72.formMain_0 != null)
					{
						Class72.formMain_0.method_63("Комплект для надевания не был указан; теперь - (" + Class72.class19_0.method_138() + ")");
					}
				}
				else
				{
					int i;
					for (i = 0; i < array2.Length && !array2[i].Equals(Class72.class19_0.method_138()); i++)
					{
					}
					if (i == array2.Length)
					{
						Class72.class19_0.method_139(array2[Class89.smethod_0(array2.Length)]);
						if (Class72.formMain_0 != null)
						{
							Class72.formMain_0.method_63("Комплект для надевания был указан неверно; теперь - (" + Class72.class19_0.method_138() + ")");
						}
					}
				}
			}
		}
		string text3 = Class12.smethod_1(input, "],[11,", "]");
		if (!string.IsNullOrEmpty(text3))
		{
			string[] array3 = text3.Split(',');
			if (array3.Length == 3)
			{
				string text4 = array3[1];
				if (!string.IsNullOrEmpty(text4))
				{
					try
					{
						if (Class72.formMain_0 != null)
						{
							Class72.formMain_0.BeginInvoke(new Delegate36(Class72.formMain_0.method_62), "Результат воровства: <font color=#cc0000><b>" + text4 + "</b></font>");
						}
					}
					catch (InvalidOperationException)
					{
					}
				}
			}
		}
		if (!string_0.EndsWith("?mselect=15") && !string_0.EndsWith("useaction=addon-action&addid=5"))
		{
			if (string_0.EndsWith("?mselect=7"))
			{
				input = input.Replace("<input type=button class=invbut", "<input type=button class=invbut value=\"Отметить все\" onclick=\"[].forEach.call(document.querySelectorAll('[type=checkbox]'), function(item) { item.checked = 'checked'; })\"> <input type=button class=invbut");
			}
			else
			{
				if (string_0.StartsWith("http://www.neverlands.ru/main.php?get_id=29&uid=", StringComparison.OrdinalIgnoreCase) && Class72.bool_45)
				{
					string text5 = Class12.smethod_1(string_0, "main.php?get_id=29&uid=", "&wmas");
					if (!string.IsNullOrEmpty("itemID"))
					{
						if (!string.IsNullOrEmpty(Class72.string_45))
						{
							Class72.string_45 += ":";
						}
						Class72.string_45 += text5;
						Class72.formMain_0.method_63("К комплекту добавлена вещь. ID: <b>" + text5 + "</b>");
					}
				}
				if (!string.IsNullOrEmpty(Class72.string_46))
				{
					if (!(Class72.string_46 == "FINISHED"))
					{
						input = smethod_4(input, string_0);
						goto IL_39c5;
					}
					Class72.string_46 = string.Empty;
					Class72.formMain_0.BeginInvoke(new Delegate20(Class72.formMain_0.method_110), new object[0]);
				}
				if (string_0.Contains("useaction=clan-action&addid=3"))
				{
					int num = input.IndexOf("</font></div></td></tr>", StringComparison.Ordinal);
					if (num == -1)
					{
						goto IL_39c5;
					}
					num += 23;
					int length = num;
					StringBuilder stringBuilder = new StringBuilder(input.Substring(0, length));
					int num2 = 1;
					while (input.Substring(num, 18).StartsWith("<tr><td bgcolor=#f", StringComparison.Ordinal))
					{
						int num3 = input.IndexOf("</div></td></tr>", num, StringComparison.Ordinal);
						if (num3 != -1)
						{
							num3 += 16;
							string text6 = input.Substring(num, num3 - num);
							string text7 = Class12.smethod_1(text6, "<b>", "</b>");
							if (text7 == "Портал" || text7 == "Дверь Измерений")
							{
								string text8 = Class12.smethod_1(text6, "</b> <font class=weaponch>(", ")</font>");
								if (!string.IsNullOrEmpty(text8))
								{
									string[] array4 = text8.Split(',');
									short int_ = short.Parse(array4[0]);
									short int_2 = short.Parse(array4[1]);
									string text9 = Class77.smethod_26(int_, int_2);
									string text10 = "Название локации не найдено";
									try
									{
										text10 = Class77.smethod_4()[text9].Tooltip;
									}
									catch
									{
									}
									text6 = text6.Replace(text7, text7 + " (" + text9 + " " + text10 + ")");
								}
							}
							num = num3;
							if (Class72.int_13 != 0)
							{
								text6 = smethod_25(text6, num2);
							}
							switch (Class72.int_13)
							{
							case 0:
								num2++;
								stringBuilder.Append(text6);
								break;
							case 1:
								if (Class12.smethod_1(text6, "<b>Долговечность:</b> ", "</div>").Split('/')[1] == "300" && !text6.Contains("<b><font color=#BB0000>"))
								{
									num2++;
									stringBuilder.Append(text6);
								}
								break;
							case 2:
								if (text6.Contains("<b><font color=#BB0000>"))
								{
									num2++;
									stringBuilder.Append(text6);
								}
								break;
							}
							continue;
						}
						goto IL_39c5;
					}
					stringBuilder.Append(input.Substring(num));
					input = stringBuilder.ToString();
				}
				if (input.Contains("var arpar = [") && input.Contains("Ожидаем начала боя!"))
				{
					string text11 = Class12.smethod_1(input, "var data = [", "];");
					if (!string.IsNullOrEmpty(text11) && (text11.Contains("Королева Змей") || text11.Contains("Хранитель Леса") || text11.Contains("Громлех Синезубый") || text11.Contains("Кхалганский Налетчик") || text11.Contains("Прислужник Локара") || text11.Contains("Друид-отступник")))
					{
						input = input.Replace("view_arena();", "view_arena(); setTimeout(function(){location='./main.php'}, 1500);");
						goto IL_39c5;
					}
				}
				if (Class72.class19_0.method_134())
				{
					string text12 = smethod_75(input);
					if (!string.IsNullOrEmpty(text12))
					{
						input = text12;
						goto IL_39c5;
					}
				}
				if (Class72.class19_0.method_102())
				{
					string text13 = smethod_74(input);
					if (!string.IsNullOrEmpty(text13))
					{
						input = text13;
						goto IL_39c5;
					}
				}
				if (input.IndexOf("/invent/0.gif", StringComparison.OrdinalIgnoreCase) != -1)
				{
					input = smethod_73(input);
				}
				if (input.IndexOf("<font color=#dd0000>Внимание! Сеанс работы прерван.</b>", StringComparison.OrdinalIgnoreCase) != -1)
				{
					try
					{
						if (Class72.formMain_0 != null)
						{
							Class72.formMain_0.BeginInvoke(new Delegate16(Class72.formMain_0.method_90), "Сеанс работы прерван. Перезаход в игру");
						}
					}
					catch (InvalidOperationException)
					{
					}
				}
				if (input.IndexOf("<font color=#cc0000><b>Ошибка при использовании. Истек срок годности зелья.", StringComparison.OrdinalIgnoreCase) != -1)
				{
					try
					{
						if (Class72.formMain_0 != null)
						{
							Class72.formMain_0.BeginInvoke(new Delegate28(Class72.formMain_0.method_83), "Истек срок годности зелья");
						}
					}
					catch (InvalidOperationException)
					{
					}
					Class71.smethod_4();
				}
				if (input.IndexOf("<font color=#cc0000><b>Ошибка при использовании. Достигнут предел одновременного использования зелий.", StringComparison.OrdinalIgnoreCase) != -1)
				{
					if (Class72.formMain_0 != null)
					{
						Class72.formMain_0.method_63("Достигнут предел одновременного использования зелий");
					}
					Class71.smethod_4();
					if (Class72.bool_30 && Class72.int_9 == 0)
					{
						Class72.bool_31 = true;
						Class72.int_9 = 1;
					}
					if (Class72.class19_0.method_126())
					{
						Class72.bool_46 = false;
					}
				}
				if ((input.IndexOf("<font color=#cc0000><b>Ошибка при использовании. Уровень персонажа слишком мал.", StringComparison.OrdinalIgnoreCase) != -1 || input.IndexOf("<font color=#cc0000><b>Ошибка при использовании. Союзник не находится в бою.", StringComparison.OrdinalIgnoreCase) != -1 || input.IndexOf("<font color=#cc0000><b>Ошибка при использовании. Нет такого игрока в данный момент.", StringComparison.OrdinalIgnoreCase) != -1 || input.IndexOf("<font color=#cc0000><b>Персонаж не имеет склонности или его нет в данном месте.", StringComparison.OrdinalIgnoreCase) != -1 || input.IndexOf("<font color=#cc0000><b>Игрок не найден.", StringComparison.OrdinalIgnoreCase) != -1 || input.IndexOf("<font color=#cc0000><b>У Персонажа уровень выше Вашего.", StringComparison.OrdinalIgnoreCase) != -1) && Class72.formMain_0 != null)
				{
					Class72.formMain_0.method_20();
				}
				if (input.IndexOf("<font color=#cc0000><b>Ошибка при использовании. Нельзя вмешаться в закрытый бой.", StringComparison.OrdinalIgnoreCase) != -1 && Class72.smethod_142() != 0 && Class72.formMain_0 != null)
				{
					Class40.smethod_2(Class72.string_30);
					Class72.formMain_0.method_63($"<b>{Class72.string_30}</b> в бою, отменяем действие!");
					Class72.formMain_0.method_20();
				}
				if (input.IndexOf("<font color=#cc0000><b>Ошибка при использовании. Невозможно использовать зелье в данный момент.", StringComparison.OrdinalIgnoreCase) != -1 && Class72.bool_30 && Class72.int_9 == 1)
				{
					Class72.bool_31 = true;
				}
				if (!string.IsNullOrEmpty(Class72.smethod_116()))
				{
					if (input.IndexOf("<font color=#cc0000><b>Поздравляем, всё успешно.<br>", StringComparison.OrdinalIgnoreCase) != -1)
					{
						Class72.smethod_121(Class72.smethod_116());
						Class72.smethod_117(string.Empty);
					}
					if (input.IndexOf("<font color=#cc0000><b>Ошибка. Персонаж находится в бою.<br>", StringComparison.OrdinalIgnoreCase) != -1)
					{
						Class72.smethod_123(Class72.smethod_116());
						Class72.smethod_117(string.Empty);
					}
				}
				int num4 = input.IndexOf("ins_HP(", StringComparison.OrdinalIgnoreCase);
				if (num4 != -1)
				{
					smethod_72(input, num4 + 7);
				}
				if (input.IndexOf("magic_slots();", StringComparison.OrdinalIgnoreCase) != -1)
				{
					input = smethod_71(input);
				}
				else
				{
					if (!Class72.bool_34 || !Class72.bool_48 || !Class72.bool_49)
					{
						goto IL_09f7;
					}
					string text14 = smethod_35(input, "&im=0&wca=3");
					if (!string.IsNullOrEmpty(text14))
					{
						input = text14;
					}
					else
					{
						if (!smethod_36(input))
						{
							goto IL_09f7;
						}
						text14 = smethod_96(input);
						if (string.IsNullOrEmpty(text14))
						{
							if (string_0.EndsWith("im=0&wca=3"))
							{
								Class72.formMain_0.BeginInvoke(new Delegate5(Class72.formMain_0.method_40), new object[0]);
								Class72.formMain_0.BeginInvoke(new Delegate36(Class72.formMain_0.method_63), "Лопаты не найдены в инвентаре. Отключаем автокопание.");
								goto IL_09f7;
							}
							input = smethod_10("Переключение на вещи", "main.php?im=0&wca=3");
						}
						else
						{
							input = text14;
						}
					}
				}
			}
		}
		else
		{
			input = smethod_24(input);
		}
		goto IL_39c5;
		IL_39c5:
		if (!string.IsNullOrEmpty(input))
		{
			Class72.smethod_17(input);
			return Class91.encoding_0.GetBytes(input);
		}
		return byte_0;
		IL_375f:
		if ((Class72.bool_44 || Class72.bool_41) && flag)
		{
			string text15 = smethod_33(input);
			if (!string.IsNullOrEmpty(text15))
			{
				input = text15;
				goto IL_39c5;
			}
		}
		if (input.IndexOf("var mine = [") != -1)
		{
			Class72.class5_0 = new Class5(input);
			if (Class72.bool_44)
			{
				input = smethod_79(input);
				goto IL_39c5;
			}
			if (Class72.bool_41 && flag)
			{
				string text16 = smethod_80(input);
				if (!string.IsNullOrEmpty(text16))
				{
					input = text16;
					goto IL_39c5;
				}
			}
		}
		if (!Class72.bool_51)
		{
			goto IL_3893;
		}
		string text17 = smethod_35(input, "&im=0&wca=2");
		if (!string.IsNullOrEmpty(text17))
		{
			input = text17;
		}
		else
		{
			if (!smethod_36(input))
			{
				goto IL_3893;
			}
			text17 = smethod_94(input);
			if (string.IsNullOrEmpty(text17))
			{
				if (string_0.EndsWith("im=0&wca=2"))
				{
					Class72.formMain_0.BeginInvoke(new Delegate5(Class72.formMain_0.method_56), new object[0]);
					Class72.formMain_0.BeginInvoke(new Delegate36(Class72.formMain_0.method_63), "Топоры не найдены в инвентаре. Отключаем автолес.");
					goto IL_3893;
				}
				input = smethod_10("Переключение на вещи", "main.php?im=0&wca=2");
			}
			else
			{
				input = text17;
			}
		}
		goto IL_39c5;
		IL_2f50:
		string text18 = smethod_35(input, "&im=0&wca=27");
		if (!string.IsNullOrEmpty(text18))
		{
			input = text18;
		}
		else
		{
			if (!smethod_36(input))
			{
				goto IL_304f;
			}
			string text19 = smethod_44(input);
			if (string.IsNullOrEmpty(text19))
			{
				if (string_0.EndsWith("im=0&wca=27"))
				{
					if (Class72.formMain_0 != null)
					{
						Class72.formMain_0.method_20();
						Class72.formMain_0.method_63("Зелье не обнаружено, действие отменено.");
					}
					goto IL_304f;
				}
				input = smethod_10("Переключение на зелья", "main.php?im=0&wca=27");
			}
			else
			{
				if (Class72.formMain_0 != null && Class72.string_29 != null && Class72.string_30 != null)
				{
					Class72.formMain_0.method_63("Используем <b><font color=#610B5E>" + Class72.string_29 + "</font></b> на <b>" + Class72.string_30 + "</b>");
				}
				Class72.int_8--;
				if (Class72.int_8 == 0 && Class72.formMain_0 != null)
				{
					Class72.formMain_0.method_20();
				}
				input = text19;
			}
		}
		goto IL_39c5;
		IL_2f3b:
		throw new NotImplementedException($"AppVars.FastId = {Class72.string_29}");
		IL_0ddf:
		if (Class72.class19_0.method_130() && Class72.smethod_26() >= 50)
		{
			Class72.bool_21 = true;
			Class72.int_8 = 1;
			Class72.string_29 = "Рыбная похлебка";
			Class72.smethod_27(0);
		}
		else if (Class72.class19_0.method_126() && Class72.smethod_26() >= Class72.class19_0.method_128() && DateTime.Now > Class72.dateTime_12)
		{
			if (!smethod_36(input))
			{
				string text20 = smethod_35(input, (Class72.class19_0.method_186() == 0) ? "&im=0&wca=27" : "&im=6");
				if (!string.IsNullOrEmpty(text20))
				{
					input = text20;
					goto IL_39c5;
				}
			}
			if (smethod_36(input))
			{
				string text21 = smethod_64(input);
				if (string.IsNullOrEmpty(text21))
				{
					if (Class72.class19_0.method_186() == 0)
					{
						if (!Class72.bool_35 && !string_0.EndsWith("im=0&wca=27"))
						{
							Class72.bool_35 = true;
							input = smethod_10("Переключение на зелья", "main.php?im=0&wca=27");
						}
						else
						{
							if (!string_0.EndsWith("im=0&wca=27"))
							{
								goto IL_0f52;
							}
							input = smethod_10("Переключение на эликсиры", "main.php?im=6");
						}
					}
					else if (!Class72.bool_35 && !string_0.EndsWith("im=6"))
					{
						Class72.bool_35 = true;
						input = smethod_10("Переключение на эликсиры", "main.php?im=6");
					}
					else
					{
						if (!string_0.EndsWith("im=6"))
						{
							goto IL_0f52;
						}
						input = smethod_10("Переключение на зелья", "main.php?im=0&wca=27");
					}
				}
				else
				{
					Class72.smethod_27(0);
					Class72.bool_46 = true;
					input = text21;
				}
				goto IL_39c5;
			}
		}
		goto IL_0f88;
		IL_119e:
		string text22;
		input = text22;
		goto IL_39c5;
		IL_11fc:
		if (Class72.formMain_0 != null)
		{
			Class72.formMain_0.method_63("Мы не в невиде, используем <b><font color=#610B5E>свиток невидимости 4 часа</font></b> на себя");
		}
		Class72.bool_31 = false;
		string text23;
		input = text23;
		goto IL_39c5;
		IL_11df:
		string text24;
		input = text24;
		goto IL_39c5;
		IL_1793:
		if (!string.IsNullOrEmpty(Class72.string_53) && !Class72.bool_21)
		{
			string[] array5 = Class72.string_53.Split('|');
			if (array5.Length != 0)
			{
				string[] array6 = array5[0].Split(':');
				Class72.bool_21 = true;
				Class72.string_29 = array6[0];
				Class72.int_8 = int.Parse(array6[1]);
				Class72.string_53 = string.Empty;
				Class72.string_30 = Class72.class19_0.method_30();
				if (array5.Length > 1)
				{
					for (int j = 1; j < array5.Length; j++)
					{
						if (!string.IsNullOrEmpty(Class72.string_53))
						{
							Class72.string_53 += "|";
						}
						Class72.string_53 += array5[j];
					}
				}
			}
		}
		if (Class72.bool_21 && DateTime.Now > Class72.dateTime_12)
		{
			string string_1 = Class72.string_29;
			uint num5 = Class0.smethod_0(string_1);
			if (num5 <= 2133372590)
			{
				if (num5 <= 1067905636)
				{
					if (num5 <= 449568891)
					{
						if (num5 <= 201456646)
						{
							if (num5 <= 90572812)
							{
								if (num5 <= 47635349)
								{
									if (num5 != 25477890)
									{
										if (num5 == 47635349 && string_1 == "Превосходное Зелье Гения")
										{
											goto IL_2f50;
										}
									}
									else if (string_1 == "Свиток Величия")
									{
										goto IL_2b85;
									}
								}
								else if (num5 != 63144885)
								{
									if (num5 == 90572812 && string_1 == "Свиток Проклятия")
									{
										goto IL_2b85;
									}
								}
								else if (string_1 == "Зелье Скорости")
								{
									goto IL_2f50;
								}
							}
							else if (num5 <= 112478207)
							{
								if (num5 != 98002318)
								{
									if (num5 == 112478207 && string_1 == "Жареная рыба с красной икрой")
									{
										goto IL_2e16;
									}
								}
								else if (string_1 == "i_svi_213.gif")
								{
									goto IL_2b85;
								}
							}
							else if (num5 != 156804902)
							{
								if (num5 == 201456646 && string_1 == "Зелье Блаженства")
								{
									goto IL_2f50;
								}
							}
							else if (string_1 == "Свиток Благословения")
							{
								goto IL_2b85;
							}
						}
						else if (num5 <= 360004320)
						{
							if (num5 <= 282576027)
							{
								if (num5 != 271840760)
								{
									if (num5 == 282576027 && string_1 == "Молодильное яблочко")
									{
										goto IL_2e16;
									}
								}
								else if (string_1 == "Баалгорский травяной настой")
								{
									goto IL_2e16;
								}
							}
							else if (num5 != 303371923)
							{
								if (num5 == 360004320 && string_1 == "Превосходное Зелье Недосягаемости")
								{
									goto IL_2f50;
								}
							}
							else if (string_1 == "Запеченная рыба")
							{
								goto IL_2e16;
							}
						}
						else
						{
							if (num5 > 396950090)
							{
								if (num5 != 446680559)
								{
									if (num5 != 449568891 || !(string_1 == "Зелье Жизни"))
									{
										goto IL_2f3b;
									}
								}
								else if (!(string_1 == "Превосходное Зелье Ореола"))
								{
									goto IL_2f3b;
								}
								goto IL_2f50;
							}
							if (num5 != 387573311)
							{
								if (num5 == 396950090 && string_1 == "Превосходное Зелье Ловких Ударов")
								{
									goto IL_2f50;
								}
							}
							else if (string_1 == "Жаркое по-Кардиффски")
							{
								goto IL_2e16;
							}
						}
					}
					else if (num5 <= 721317201)
					{
						if (num5 <= 558645810)
						{
							if (num5 <= 522834873)
							{
								if (num5 != 522198175)
								{
									if (num5 == 522834873 && string_1 == "i_svi_205.gif")
									{
										goto IL_2b85;
									}
								}
								else if (string_1 == "Зелье Лечения")
								{
									goto IL_2f50;
								}
							}
							else if (num5 != 554362324)
							{
								if (num5 == 558645810 && string_1 == "Зелье Точного Попадания")
								{
									goto IL_2f50;
								}
							}
							else if (string_1 == "i_w28_25.gif")
							{
								goto IL_2b85;
							}
						}
						else if (num5 <= 689376527)
						{
							if (num5 != 640530248)
							{
								if (num5 == 689376527 && string_1 == "Пирог с бананами")
								{
									goto IL_2e16;
								}
							}
							else if (string_1 == "Тотем")
							{
								if (!(DateTime.Now > Class72.dateTime_12))
								{
									goto IL_304f;
								}
								string text25 = smethod_33(input);
								if (!string.IsNullOrEmpty(text25))
								{
									input = text25;
								}
								else
								{
									string text19 = smethod_44(input);
									if (string.IsNullOrEmpty(text19))
									{
										if (Class72.formMain_0 != null)
										{
											Class72.formMain_0.method_20();
											Class72.formMain_0.method_63("Нападение по тотему сейчас невозможно, действие отменено.");
										}
										goto IL_304f;
									}
									if (DateTime.Now.Subtract(Class72.dateTime_10).TotalSeconds > 5.0)
									{
										Class72.dateTime_10 = DateTime.Now;
										if (Class72.formMain_0 != null && Class72.string_30 != null)
										{
											Class72.formMain_0.method_63($"Используем <b><font color=#610B5E>тотемное нападение</font></b> на <b>{Class72.string_30}</b>");
										}
									}
									Class72.int_8--;
									if (Class72.int_8 == 0 && Class72.formMain_0 != null)
									{
										Class72.formMain_0.method_20();
									}
									input = text19;
								}
								goto IL_39c5;
							}
						}
						else if (num5 != 706003160)
						{
							if (num5 == 721317201 && string_1 == "i_w28_26.gif")
							{
								goto IL_2b85;
							}
						}
						else if (string_1 == "Зелье Восстановления Маны")
						{
							goto IL_2f50;
						}
					}
					else
					{
						if (num5 > 812877630)
						{
							if (num5 <= 938498820)
							{
								if (num5 != 902080332)
								{
									if (num5 != 938498820 || !(string_1 == "Зелье Мифриловый Стержень"))
									{
										goto IL_2f3b;
									}
								}
								else if (!(string_1 == "Зелье Просветления"))
								{
									goto IL_2f3b;
								}
							}
							else if (num5 != 979178017)
							{
								if (num5 != 1034570523)
								{
									if (num5 != 1067905636 || !(string_1 == "Превосходное Зелье Стойкости"))
									{
										goto IL_2f3b;
									}
								}
								else if (!(string_1 == "Зелье Соколиный взор"))
								{
									goto IL_2f3b;
								}
							}
							else if (!(string_1 == "Зелье Энергии"))
							{
								goto IL_2f3b;
							}
							goto IL_2f50;
						}
						if (num5 <= 788171765)
						{
							if (num5 != 750246592)
							{
								if (num5 == 788171765 && string_1 == "Суши")
								{
									goto IL_2e16;
								}
							}
							else if (string_1 == "Тушеное мясо с гарниром")
							{
								goto IL_2e16;
							}
						}
						else if (num5 != 794187093)
						{
							if (num5 == 812877630 && string_1 == "Зелье подвижности")
							{
								goto IL_2f50;
							}
						}
						else if (string_1 == "Рыбная солянка")
						{
							goto IL_2e16;
						}
					}
				}
				else if (num5 <= 1628597842)
				{
					if (num5 <= 1225421526)
					{
						if (num5 <= 1137003133)
						{
							if (num5 <= 1116014943)
							{
								if (num5 != 1070171056)
								{
									if (num5 == 1116014943 && string_1 == "Паштет с овощами")
									{
										goto IL_2e16;
									}
								}
								else if (string_1 == "Свиток Каменной Кожи")
								{
									goto IL_2b85;
								}
							}
							else if (num5 != 1135811353)
							{
								if (num5 == 1137003133 && string_1 == "Коньяк Дубовый")
								{
									goto IL_2e16;
								}
							}
							else if (string_1 == "Фаросское вино")
							{
								goto IL_2e16;
							}
						}
						else if (num5 <= 1173367137)
						{
							if (num5 != 1148252190)
							{
								if (num5 == 1173367137 && string_1 == "Превосходное Зелье Человек-Гора")
								{
									goto IL_2f50;
								}
							}
							else if (string_1 == "Самогон")
							{
								goto IL_2e16;
							}
						}
						else if (num5 != 1192497576)
						{
							if (num5 == 1225421526 && string_1 == "Свиток Берсерка")
							{
								goto IL_2b85;
							}
						}
						else if (string_1 == "Превосходное Зелье Мужества")
						{
							goto IL_2f50;
						}
					}
					else if (num5 <= 1441811502)
					{
						if (num5 <= 1326778013)
						{
							if (num5 != 1228032671)
							{
								if (num5 != 1326778013 || !(string_1 == "Жажда Жизни"))
								{
									goto IL_2f3b;
								}
							}
							else if (!(string_1 == "Превосходное Зелье Скорости"))
							{
								goto IL_2f3b;
							}
							goto IL_2f50;
						}
						if (num5 != 1337111575)
						{
							if (num5 == 1441811502 && string_1 == "Зелье Мужества")
							{
								goto IL_2f50;
							}
						}
						else if (string_1 == "i_w28_26X.gif")
						{
							goto IL_2b85;
						}
					}
					else if (num5 <= 1591817875)
					{
						if (num5 != 1546644912)
						{
							if (num5 == 1591817875 && string_1 == "i_w28_28.gif")
							{
								goto IL_2b85;
							}
						}
						else if (string_1 == "Зелье Медитации")
						{
							goto IL_2f50;
						}
					}
					else if (num5 != 1601947396)
					{
						if (num5 == 1628597842 && string_1 == "Рыбный салат")
						{
							goto IL_2e16;
						}
					}
					else if (string_1 == "Зелье Загрубелой Кожи")
					{
						goto IL_2f50;
					}
				}
				else if (num5 <= 1787465050)
				{
					if (num5 <= 1690607148)
					{
						if (num5 <= 1665782505)
						{
							if (num5 != 1657785153)
							{
								if (num5 == 1665782505 && string_1 == "Зелье Боевой Славы")
								{
									goto IL_2f50;
								}
							}
							else if (string_1 == "Чашу Айрис")
							{
								goto IL_2e16;
							}
						}
						else if (num5 != 1680370730)
						{
							if (num5 == 1690607148 && string_1 == "Свиток Сопротивления Огню")
							{
								goto IL_2b85;
							}
						}
						else if (string_1 == "Зелье Невидимости")
						{
							goto IL_2f50;
						}
					}
					else if (num5 <= 1708842566)
					{
						if (num5 != 1706029086)
						{
							if (num5 == 1708842566 && string_1 == "Эликсир из Подснежника")
							{
								goto IL_2e16;
							}
						}
						else if (string_1 == "i_w28_27.gif")
						{
							goto IL_2b85;
						}
					}
					else if (num5 != 1749545687)
					{
						if (num5 == 1787465050 && string_1 == "Призыв Импа-вредителя")
						{
							goto IL_2b85;
						}
					}
					else if (string_1 == "Телепорт (Гиблая Топь)")
					{
						goto IL_2b85;
					}
				}
				else if (num5 <= 1966443421)
				{
					if (num5 <= 1837336682)
					{
						if (num5 != 1836598811)
						{
							if (num5 == 1837336682 && string_1 == "Превосходное Зелье Точности")
							{
								goto IL_2f50;
							}
						}
						else if (string_1 == "Цветочный пунш")
						{
							goto IL_2e16;
						}
					}
					else if (num5 != 1960961703)
					{
						if (num5 == 1966443421 && string_1 == "Свиток Помощника")
						{
							goto IL_2b85;
						}
					}
					else if (string_1 == "Зелье Лечения Отравлений")
					{
						goto IL_2f50;
					}
				}
				else if (num5 <= 2070913494)
				{
					if (num5 != 2026751319)
					{
						if (num5 == 2070913494 && string_1 == "Свиток Магии Воды")
						{
							goto IL_2b85;
						}
					}
					else if (string_1 == "Зелье Сокрушительных Ударов")
					{
						goto IL_2f50;
					}
				}
				else if (num5 != 2075089289)
				{
					if (num5 != 2133161696)
					{
						if (num5 == 2133372590 && string_1 == "Телепорт (Остров Туротор)")
						{
							goto IL_2b85;
						}
					}
					else if (string_1 == "Рыбный суп-пюре")
					{
						goto IL_2e16;
					}
				}
				else if (string_1 == "Ярость Берсерка")
				{
					goto IL_2f50;
				}
			}
			else if (num5 <= 3148254162u)
			{
				if (num5 <= 2698831014u)
				{
					if (num5 <= 2448360414u)
					{
						if (num5 <= 2355351133u)
						{
							if (num5 <= 2175056014u)
							{
								if (num5 != 2135507288)
								{
									if (num5 == 2175056014u && string_1 == "Зелье Секрет Волшебника")
									{
										goto IL_2f50;
									}
								}
								else if (string_1 == "Эликсир Быстроты")
								{
									goto IL_2e16;
								}
							}
							else if (num5 != 2301215396u)
							{
								if (num5 == 2355351133u && string_1 == "Превосходное Зелье Волшебства")
								{
									goto IL_2f50;
								}
							}
							else if (string_1 == "Свиток Сопротивления Воздуху")
							{
								goto IL_2b85;
							}
						}
						else
						{
							if (num5 > 2405926421u)
							{
								if (num5 != 2429118811u)
								{
									if (num5 != 2448360414u || !(string_1 == "Яд"))
									{
										goto IL_2f3b;
									}
								}
								else if (!(string_1 == "Превосходное Зелье Сильной Спины"))
								{
									goto IL_2f3b;
								}
								goto IL_2f50;
							}
							if (num5 != 2384603612u)
							{
								if (num5 == 2405926421u && string_1 == "i_w28_22.gif")
								{
									goto IL_2b85;
								}
							}
							else if (string_1 == "Превосходное Зелье Сокрушения")
							{
								goto IL_2f50;
							}
						}
					}
					else if (num5 <= 2580994843u)
					{
						if (num5 <= 2557041854u)
						{
							if (num5 != 2546195787u)
							{
								if (num5 == 2557041854u && string_1 == "Превосходное Зелье Медитации")
								{
									goto IL_2f50;
								}
							}
							else if (string_1 == "Эликсир Блаженства")
							{
								goto IL_2e16;
							}
						}
						else if (num5 != 2565130601u)
						{
							if (num5 == 2580994843u && string_1 == "Рыбная паста по-Кентарийски")
							{
								goto IL_2e16;
							}
						}
						else if (string_1 == "Превосходное Зелье Удачи")
						{
							goto IL_2f50;
						}
					}
					else if (num5 <= 2675766214u)
					{
						if (num5 != 2662821515u)
						{
							if (num5 == 2675766214u && string_1 == "Свиток Магии Земли")
							{
								goto IL_2b85;
							}
						}
						else if (string_1 == "Свиток Сопротивления Воде")
						{
							goto IL_2b85;
						}
					}
					else if (num5 != 2684974432u)
					{
						if (num5 == 2698831014u && string_1 == "Свиток Гнев Локара")
						{
							goto IL_2b85;
						}
					}
					else if (string_1 == "Вяленая рыба с белым соусом")
					{
						goto IL_2e16;
					}
				}
				else if (num5 <= 2875821002u)
				{
					if (num5 <= 2820223890u)
					{
						if (num5 <= 2783139521u)
						{
							if (num5 != 2708348024u)
							{
								if (num5 == 2783139521u && string_1 == "Эликсир Восстановления")
								{
									goto IL_2e16;
								}
							}
							else if (string_1 == "Зелье Иммунитета")
							{
								goto IL_2f50;
							}
						}
						else if (num5 != 2806899480u)
						{
							if (num5 == 2820223890u && string_1 == "Яблочный пирог")
							{
								goto IL_2e16;
							}
						}
						else if (string_1 == "Свиток Магии Воздуха")
						{
							goto IL_2b85;
						}
					}
					else if (num5 <= 2835036407u)
					{
						if (num5 != 2833369889u)
						{
							if (num5 == 2835036407u && string_1 == "Паста из раковых шеек с мясом")
							{
								goto IL_2e16;
							}
						}
						else if (string_1 == "Зелье Хрупкости")
						{
							goto IL_2f50;
						}
					}
					else if (num5 != 2835609248u)
					{
						if (num5 == 2875821002u && string_1 == "i_svi_002.gif")
						{
							goto IL_2b85;
						}
					}
					else if (string_1 == "Свиток Сопротивления Земле")
					{
						goto IL_2b85;
					}
				}
				else if (num5 <= 2907296056u)
				{
					if (num5 > 2890270839u)
					{
						if (num5 != 2891769043u)
						{
							if (num5 != 2907296056u || !(string_1 == "Зелье Ловких Ударов"))
							{
								goto IL_2f3b;
							}
						}
						else if (!(string_1 == "Зелье Удачи"))
						{
							goto IL_2f3b;
						}
						goto IL_2f50;
					}
					if (num5 != 2890020870u)
					{
						if (num5 == 2890270839u && string_1 == "i_w28_24.gif")
						{
							goto IL_2b85;
						}
					}
					else if (string_1 == "Анисовая водка")
					{
						goto IL_2e16;
					}
				}
				else if (num5 <= 3036555492u)
				{
					if (num5 != 2961271354u)
					{
						if (num5 == 3036555492u && string_1 == "Дар Иланы")
						{
							goto IL_2e16;
						}
					}
					else if (string_1 == "Ментальная Жажда")
					{
						goto IL_2f50;
					}
				}
				else if (num5 != 3064268775u)
				{
					if (num5 != 3122132996u)
					{
						if (num5 == 3148254162u && string_1 == "Превосходное Зелье Силы")
						{
							goto IL_2f50;
						}
					}
					else if (string_1 == "Свиток Магии Огня")
					{
						goto IL_2b85;
					}
				}
				else if (string_1 == "Свиток Очищения")
				{
					goto IL_2b85;
				}
			}
			else if (num5 <= 3712381031u)
			{
				if (num5 <= 3486881711u)
				{
					if (num5 <= 3211767803u)
					{
						if (num5 <= 3158440362u)
						{
							if (num5 != 3152929863u)
							{
								if (num5 != 3158440362u || !(string_1 == "Зелье Недосягаемости"))
								{
									goto IL_2f3b;
								}
							}
							else if (!(string_1 == "Превосходное Зелье Колкости"))
							{
								goto IL_2f3b;
							}
							goto IL_2f50;
						}
						if (num5 != 3198464074u)
						{
							if (num5 == 3211767803u && string_1 == "Ледяной эликсир II")
							{
								goto IL_2e16;
							}
						}
						else if (string_1 == "Секретное Зелье")
						{
							goto IL_2f50;
						}
					}
					else if (num5 <= 3293993799u)
					{
						if (num5 != 3255221338u)
						{
							if (num5 == 3293993799u && string_1 == "Зелье Кровожадности")
							{
								goto IL_2e16;
							}
						}
						else if (string_1 == "Превосходное Зелье Панциря")
						{
							goto IL_2f50;
						}
					}
					else if (num5 != 3344054448u)
					{
						if (num5 == 3486881711u && string_1 == "Зелье Огненного Ореола")
						{
							goto IL_2f50;
						}
					}
					else if (string_1 == "Ледяной эликсир I")
					{
						goto IL_2e16;
					}
				}
				else if (num5 <= 3526479763u)
				{
					if (num5 <= 3519672240u)
					{
						if (num5 != 3500561370u)
						{
							if (num5 != 3519672240u || !(string_1 == "Зелье Панциря"))
							{
								goto IL_2f3b;
							}
						}
						else if (!(string_1 == "Зелье Стойкости"))
						{
							goto IL_2f3b;
						}
						goto IL_2f50;
					}
					if (num5 != 3522492755u)
					{
						if (num5 == 3526479763u && string_1 == "Приманку Для Ботов")
						{
							goto IL_2e16;
						}
					}
					else if (string_1 == "i_svi_001.gif")
					{
						goto IL_2b85;
					}
				}
				else if (num5 <= 3635257885u)
				{
					if (num5 != 3606681547u)
					{
						if (num5 == 3635257885u && string_1 == "Зелье Колкости")
						{
							goto IL_2f50;
						}
					}
					else if (string_1 == "Свиток Слеза Создателя")
					{
						goto IL_2b85;
					}
				}
				else if (num5 != 3684938870u)
				{
					if (num5 != 3689896899u)
					{
						if (num5 == 3712381031u && string_1 == "i_w28_86.gif")
						{
							goto IL_2b85;
						}
					}
					else if (string_1 == "Рыбные палочки")
					{
						goto IL_2e16;
					}
				}
				else if (string_1 == "Жихорийский шнапс")
				{
					goto IL_2e16;
				}
			}
			else if (num5 <= 4043399998u)
			{
				if (num5 <= 3843666607u)
				{
					if (num5 <= 3727919101u)
					{
						if (num5 != 3723118295u)
						{
							if (num5 == 3727919101u && string_1 == "Зелье Сильной Спины")
							{
								goto IL_2f50;
							}
						}
						else if (string_1 == "vsergard")
						{
							goto IL_2b85;
						}
					}
					else if (num5 != 3753773554u)
					{
						if (num5 == 3843666607u && string_1 == "Зелье Гения")
						{
							goto IL_2f50;
						}
					}
					else if (string_1 == "i_w28_23.gif")
					{
						goto IL_2b85;
					}
				}
				else if (num5 <= 3940853091u)
				{
					if (num5 != 3900713708u)
					{
						if (num5 == 3940853091u && string_1 == "Зелье Человек-гора")
						{
							goto IL_2f50;
						}
					}
					else if (string_1 == "Рыбная похлебка")
					{
						goto IL_2e16;
					}
				}
				else if (num5 != 4039845384u)
				{
					if (num5 == 4043399998u && string_1 == "Фаршированная форель")
					{
						goto IL_2e16;
					}
				}
				else if (string_1 == "Зелье Силы")
				{
					goto IL_2f50;
				}
			}
			else if (num5 <= 4118987183u)
			{
				if (num5 <= 4096147657u)
				{
					if (num5 != 4066425915u)
					{
						if (num5 != 4096147657u || !(string_1 == "Превосходное Зелье Жизни"))
						{
							goto IL_2f3b;
						}
					}
					else if (!(string_1 == "Превосходное Зелье Ловкости"))
					{
						goto IL_2f3b;
					}
					goto IL_2f50;
				}
				if (num5 != 4101162127u)
				{
					if (num5 == 4118987183u && string_1 == "Зелье Метаболизма")
					{
						goto IL_2f50;
					}
				}
				else if (string_1 == "Фейданский бренди")
				{
					goto IL_2e16;
				}
			}
			else if (num5 <= 4135735906u)
			{
				if (num5 != 4123533089u)
				{
					if (num5 == 4135735906u && string_1 == "Эликсир Мгновенного Исцеления")
					{
						goto IL_2e16;
					}
				}
				else if (string_1 == "Зелье Ловкости")
				{
					goto IL_2f50;
				}
			}
			else if (num5 != 4208435379u)
			{
				if (num5 != 4266458751u)
				{
					if (num5 == 4276465462u && string_1 == "Рыбное филе по-Альвийски")
					{
						goto IL_2e16;
					}
				}
				else if (string_1 == "Бифштекс от элементаля")
				{
					goto IL_2e16;
				}
			}
			else if (string_1 == "Превосходное Зелье Боевой Славы")
			{
				goto IL_2f50;
			}
			goto IL_2f3b;
		}
		goto IL_304f;
		IL_11bb:
		if (Class72.formMain_0 != null)
		{
			Class72.formMain_0.method_63("Мы не в невиде, используем <b><font color=#610B5E>свиток тумана</font></b> на себя");
		}
		Class72.bool_31 = false;
		string text26;
		input = text26;
		goto IL_39c5;
		IL_34c0:
		if (!(Class72.smethod_66() && flag))
		{
			goto IL_3506;
		}
		string text27 = smethod_37(input);
		if (!string.IsNullOrEmpty(text27))
		{
			input = text27;
		}
		else
		{
			if (input.IndexOf("<input type=button class=lbut value=\"Умения\" onclick", StringComparison.OrdinalIgnoreCase) == -1)
			{
				goto IL_3506;
			}
			input = smethod_10("Переключение на умения персонажа", "main.php?mselect=1");
		}
		goto IL_39c5;
		IL_35b1:
		text27 = smethod_33(input);
		if (!string.IsNullOrEmpty(text27))
		{
			input = text27;
		}
		else
		{
			text27 = smethod_41(input);
			if (string.IsNullOrEmpty(text27))
			{
				goto IL_35e3;
			}
			input = text27;
		}
		goto IL_39c5;
		IL_394a:
		if (Class72.formMain_0.method_55() && !string.IsNullOrEmpty(smethod_33(input)))
		{
			Class72.smethod_35(bool_54: true);
			Class72.formMain_0.BeginInvoke(new Delegate20(Class72.formMain_0.method_110), new object[0]);
		}
		goto IL_39c5;
		IL_1244:
		input = ((!string_0.EndsWith("main.php?useaction=addon-action", StringComparison.OrdinalIgnoreCase)) ? smethod_10("Переключение на возможности", "main.php?useaction=addon-action") : smethod_10("Переключение на абилки", "main.php?useaction=addon-action&addid=1"));
		goto IL_39c5;
		IL_1165:
		input = smethod_10("Переключение на зелья", "main.php?im=0&wca=27");
		goto IL_39c5;
		IL_304f:
		try
		{
			if (Class72.formMain_0 != null)
			{
				Class72.formMain_0.BeginInvoke(new Delegate6(Class72.formMain_0.method_91), new object[0]);
			}
		}
		catch (InvalidOperationException)
		{
		}
		if ((Class72.smethod_30() || Class72.smethod_36()) && flag)
		{
			string text28 = smethod_33(input);
			if (!string.IsNullOrEmpty(text28))
			{
				input = text28;
				goto IL_39c5;
			}
		}
		if (Class72.smethod_30() && flag)
		{
			string text29 = smethod_40(input);
			if (!string.IsNullOrEmpty(text29))
			{
				try
				{
					if (Class72.formMain_0 != null)
					{
						Class72.formMain_0.method_104();
					}
				}
				catch (Exception)
				{
				}
				input = text29;
				goto IL_39c5;
			}
		}
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
		if (Class72.bool_34 && !Class72.smethod_36() && flag)
		{
			string text30 = FormMain.smethod_71();
			if (!string.IsNullOrEmpty(text30) && Class72.formMain_0 != null)
			{
				Class72.formMain_0.method_123(text30);
				goto IL_39c5;
			}
			Class77.smethod_31();
			Class72.formMain_0.BeginInvoke(new Delegate36(Class72.formMain_0.method_63), "Вы обошли всю карту. Сбрасываем посещённые локации.");
			Class72.formMain_0.BeginInvoke(new Delegate20(Class72.formMain_0.method_110), new object[0]);
		}
		if (!string.IsNullOrEmpty(Class72.string_55))
		{
			string string_1 = Class72.string_55;
			if (!(string_1 == "MoveToFort"))
			{
				if (string_1 == "EnterFort" && Class72.smethod_36() && Class72.smethod_40() == Class72.smethod_38())
				{
					string text31 = smethod_39(input);
					if (!string.IsNullOrEmpty(text31))
					{
						Class72.string_55 = "TakeBuff";
						input = text31;
					}
				}
			}
			else if (string.IsNullOrEmpty(Class72.string_54))
			{
				Class72.string_55 = string.Empty;
			}
			else
			{
				string[] array7 = Class72.string_54.Split(',');
				Class72.string_54 = string.Empty;
				if (array7.Length > 1)
				{
					for (int k = 1; k < array7.Length; k++)
					{
						if (!string.IsNullOrEmpty(Class72.string_54))
						{
							Class72.string_54 += ",";
						}
						Class72.string_54 += array7[k];
					}
				}
				Class72.string_55 = "EnterFort";
				Class72.formMain_0.method_123(array7[0]);
			}
		}
		if (!(Class72.smethod_36() && flag))
		{
			goto IL_3313;
		}
		string text32 = smethod_30(input);
		if (!string.IsNullOrEmpty(text32))
		{
			input = text32;
		}
		else
		{
			string text33 = smethod_28(input);
			if (string.IsNullOrEmpty(text33))
			{
				if (input.IndexOf("var telep = ", StringComparison.Ordinal) != -1)
				{
					text33 = smethod_86(input);
					if (text33 != null)
					{
						input = text33;
						goto IL_39c5;
					}
				}
				goto IL_3313;
			}
			input = text33;
		}
		goto IL_39c5;
		IL_11e7:
		input = smethod_10("Переключение на свитки", "main.php?im=0&wca=28");
		goto IL_39c5;
		IL_140e:
		if (Class72.bool_22 || Class72.bool_23)
		{
			if (!string_0.EndsWith("main.php?useaction=addon-action&addid=1", StringComparison.OrdinalIgnoreCase))
			{
				input = ((!string_0.EndsWith("main.php?useaction=addon-action", StringComparison.OrdinalIgnoreCase)) ? smethod_10("Переключение на возможности", "main.php?useaction=addon-action") : smethod_10("Переключение на абилки", "main.php?useaction=addon-action&addid=1"));
				goto IL_39c5;
			}
			if (Class72.bool_22)
			{
				Class72.bool_22 = false;
				string text34 = smethod_32(input);
				if (!string.IsNullOrEmpty(text34))
				{
					input = text34;
					goto IL_39c5;
				}
				Class72.formMain_0.method_63("Нет возможности применить сумеречный телепорт!");
			}
			if (Class72.bool_23)
			{
				Class72.bool_23 = false;
				string text35 = smethod_31(input);
				if (!string.IsNullOrEmpty(text35))
				{
					input = text35;
					goto IL_39c5;
				}
				Class72.formMain_0.method_63("Нет возможности применить сумеречный туман!");
			}
		}
		if (!Class72.class19_0.method_136())
		{
			goto IL_1793;
		}
		if (Class72.smethod_146()[0] > 0)
		{
			string text36 = smethod_35(input, "&im=0&wca=27");
			if (!string.IsNullOrEmpty(text36))
			{
				input = text36;
			}
			else
			{
				if (!smethod_36(input))
				{
					goto IL_1793;
				}
				string text37 = smethod_20(input);
				if (string.IsNullOrEmpty(text37))
				{
					if (string_0.EndsWith("im=0&wca=27"))
					{
						Class72.formMain_0.method_63("У вас отравление и нет зелья лечения отравлений! Автолечение отключено. Не забудьте включить его обратно.");
						Class72.smethod_146()[0] = 0;
						Class72.class19_0.method_137(bool_55: false);
						if (Class72.smethod_146()[1] == 0 && Class72.smethod_146()[2] == 0 && Class72.smethod_146()[3] == 0)
						{
							Class72.string_33 = Class72.class19_0.method_138();
						}
						goto IL_1793;
					}
					input = smethod_10("Переключение на зелья", "main.php?im=0&wca=27");
				}
				else
				{
					Class72.formMain_0.method_63("Лечим свое отравление...");
					Class72.smethod_146()[0]--;
					if (Class72.smethod_146()[1] == 0 && Class72.smethod_146()[2] == 0 && Class72.smethod_146()[3] == 0)
					{
						Class72.string_33 = Class72.class19_0.method_138();
					}
					input = text37;
				}
			}
		}
		else
		{
			if (Class72.smethod_146()[1] <= 0 && Class72.smethod_146()[2] <= 0 && Class72.smethod_146()[3] <= 0)
			{
				goto IL_1793;
			}
			string text38 = smethod_35(input, "&im=0&wca=85");
			if (!string.IsNullOrEmpty(text38))
			{
				input = text38;
			}
			else
			{
				if (!smethod_36(input))
				{
					goto IL_1793;
				}
				Class72.smethod_115(bool_54: true);
				Class72.smethod_117(Class72.class19_0.method_30());
				if (Class72.smethod_146()[1] > 0)
				{
					Class72.smethod_119("1");
				}
				else if (Class72.smethod_146()[2] > 0)
				{
					Class72.smethod_119("2");
				}
				else if (Class72.smethod_146()[3] > 0)
				{
					Class72.smethod_119("3");
				}
				string text39 = smethod_21(input);
				if (string.IsNullOrEmpty(text39))
				{
					if (string_0.EndsWith("im=0&wca=85"))
					{
						Class72.formMain_0.method_63("У вас травма, но нет возможности ее вылечить! Автолечение отключено. Не забудьте включить его обратно.");
						Class72.class19_0.method_137(bool_55: false);
						Class72.smethod_115(bool_54: false);
						int[] array8 = Class72.smethod_146();
						int[] array9 = Class72.smethod_146();
						int[] array10 = Class72.smethod_146();
						int num6 = 0;
						array10[3] = 0;
						num6 = 0;
						array9[2] = 0;
						array8[1] = 0;
						goto IL_1793;
					}
					input = smethod_10("Переключение на аптечки", "main.php?im=0&wca=85");
				}
				else
				{
					switch (Class72.smethod_118())
					{
					case "3":
						Class72.smethod_146()[3]--;
						Class72.formMain_0.method_63("Лечим свою тяжелую травму...");
						break;
					case "2":
						Class72.smethod_146()[2]--;
						Class72.formMain_0.method_63("Лечим свою среднюю травму...");
						break;
					case "1":
						Class72.smethod_146()[1]--;
						Class72.formMain_0.method_63("Лечим свою легкую травму...");
						break;
					}
					if (Class72.smethod_146()[1] == 0 && Class72.smethod_146()[2] == 0 && Class72.smethod_146()[3] == 0)
					{
						Class72.string_33 = Class72.class19_0.method_138();
					}
					input = text39;
				}
			}
		}
		goto IL_39c5;
		IL_1220:
		if (Class72.formMain_0 != null)
		{
			Class72.formMain_0.method_63("Мы не в невиде, применяем <b><font color=#610B5E>сумеречный туман</b></font> на себя!");
		}
		Class72.bool_31 = false;
		string text40;
		input = text40;
		goto IL_39c5;
		IL_0f52:
		Class72.bool_35 = false;
		Class72.formMain_0.method_63("Ни зелье, ни эликсир блаженства не найдены. Автопитье блажа отключено. Не забудьте включить его обратно.");
		Class72.class19_0.method_127(bool_55: false);
		goto IL_0f88;
		IL_11a6:
		input = smethod_10("Переключение на свитки", "main.php?im=0&wca=28");
		goto IL_39c5;
		IL_0bd0:
		string text41 = Class12.smethod_1(input, "Рыбалка</td><td bgcolor=#FCFAF3><font class=proce><font color=#555555><div align=center>[", "]");
		if (!string.IsNullOrEmpty(text41) && int.TryParse(text41, out var result))
		{
			Class72.class19_0.method_93(result);
			Class72.smethod_67(bool_54: false);
		}
		text41 = Class12.smethod_1(input, "Охота</td><td bgcolor=#FCFAF3><font class=proce><font color=#555555><div align=center>[", "]");
		if (!string.IsNullOrEmpty(text41) && int.TryParse(text41, out var result2))
		{
			Class72.smethod_51(bool_54: false);
			if (Class72.smethod_52() != result2)
			{
				StringBuilder stringBuilder2 = new StringBuilder($"Умение разделки: <span style=\"color:#009933;font-weight:bold;\">{result2}</span>");
				if (Class72.smethod_52() > 0 && Class72.smethod_52() < result2)
				{
					int num7 = result2 - Class72.smethod_52();
					stringBuilder2.Append($" (+{num7})");
				}
				Class72.smethod_53(result2);
				if (Class72.class19_0.method_102())
				{
					try
					{
						if (Class72.formMain_0 != null)
						{
							Class72.formMain_0.BeginInvoke(new Delegate36(Class72.formMain_0.method_62), stringBuilder2.ToString());
						}
					}
					catch (InvalidOperationException)
					{
					}
				}
			}
		}
		string[] array11 = smethod_23(input);
		if (array11 != null)
		{
			try
			{
				if (Class72.formMain_0 != null)
				{
					Class72.formMain_0.BeginInvoke(new Delegate11(Class72.formMain_0.method_97), new object[1] { array11 });
				}
			}
			catch (InvalidOperationException)
			{
			}
		}
		if (!(!string.IsNullOrEmpty(Class72.string_33) && flag))
		{
			goto IL_0ddf;
		}
		string text42 = smethod_35(input, "&im=0&wca=4");
		if (!string.IsNullOrEmpty(text42))
		{
			input = text42;
		}
		else
		{
			if (!smethod_36(input))
			{
				goto IL_0ddf;
			}
			string text43 = smethod_77(input, Class72.string_33);
			if (string.IsNullOrEmpty(text43))
			{
				if (string_0.EndsWith("im=0&wca=4"))
				{
					Class72.formMain_0.method_63($"Комплект <b>{Class72.string_33}</b> не найден.");
					Class72.string_33 = string.Empty;
					goto IL_0ddf;
				}
				input = smethod_10("Переключение на вещи", "main.php?im=0&wca=4");
			}
			else
			{
				Class72.formMain_0.method_63($"Надеваем комплект <b>{Class72.string_33}</b>.");
				Class72.string_33 = string.Empty;
				input = text43;
			}
		}
		goto IL_39c5;
		IL_0f88:
		string text44;
		string text45;
		if (Class72.bool_31 && flag)
		{
			while (Class72.int_9 < 4)
			{
				if (Class72.int_9 == 0)
				{
					text44 = smethod_35(input, "&im=0&wca=27");
					if (!string.IsNullOrEmpty(text44))
					{
						goto IL_115d;
					}
					if (smethod_36(input))
					{
						text45 = smethod_65(input);
						if (!string.IsNullOrEmpty(text45))
						{
							goto IL_117a;
						}
						if (!string_0.EndsWith("im=0&wca=27"))
						{
							goto IL_1165;
						}
						Class72.int_9++;
					}
				}
				if (Class72.int_9 == 1)
				{
					if (Class72.string_35.StartsWith("Дети", StringComparison.CurrentCultureIgnoreCase))
					{
						text22 = smethod_35(input, "&im=0&wca=28");
						if (!string.IsNullOrEmpty(text22))
						{
							goto IL_119e;
						}
						if (smethod_36(input))
						{
							text26 = smethod_67(input);
							if (string.IsNullOrEmpty(text26))
							{
								if (string_0.EndsWith("im=0&wca=28"))
								{
									Class72.int_9++;
									continue;
								}
								goto IL_11a6;
							}
							goto IL_11bb;
						}
					}
					else
					{
						Class72.int_9++;
					}
				}
				if (Class72.int_9 == 2)
				{
					text24 = smethod_35(input, "&im=0&wca=28");
					if (!string.IsNullOrEmpty(text24))
					{
						goto IL_11df;
					}
					if (smethod_36(input))
					{
						text23 = smethod_66(input);
						if (!string.IsNullOrEmpty(text23))
						{
							goto IL_11fc;
						}
						if (!string_0.EndsWith("im=0&wca=28"))
						{
							goto IL_11e7;
						}
						Class72.int_9++;
					}
				}
				if (Class72.int_9 != 3)
				{
					continue;
				}
				if (Class72.string_35.Equals("Дети Сумерек", StringComparison.CurrentCultureIgnoreCase))
				{
					if (string_0.EndsWith("main.php?useaction=addon-action&addid=1", StringComparison.OrdinalIgnoreCase))
					{
						text40 = smethod_31(input);
						if (string.IsNullOrEmpty(text40))
						{
							Class72.int_9++;
							continue;
						}
						goto IL_1220;
					}
					goto IL_1244;
				}
				Class72.int_9++;
			}
			if (Class72.int_9 == 4 && Class72.formMain_0 != null)
			{
				Class72.formMain_0.method_63("Ни один способ ухода в невид (абилка и свиток тумана, зелье и свиток невида) не обнаружен. Автоуход в невид отключен. Не забудьте включить его обратно.");
				Class72.formMain_0.method_39();
			}
		}
		if (Class72.smethod_32() && flag)
		{
			string text46 = smethod_37(input);
			if (!string.IsNullOrEmpty(text46))
			{
				Class72.smethod_33(bool_54: false);
				input = text46;
				goto IL_39c5;
			}
		}
		else if (Class72.smethod_34())
		{
			string text47 = smethod_33(input);
			if (!string.IsNullOrEmpty(text47))
			{
				Class72.smethod_35(bool_54: false);
				input = text47;
				goto IL_39c5;
			}
		}
		if (!(Class72.class19_0.method_102() && flag))
		{
			goto IL_140e;
		}
		if (!(Class72.smethod_50() && flag))
		{
			goto IL_1321;
		}
		string text48 = smethod_37(input);
		if (!string.IsNullOrEmpty(text48))
		{
			input = text48;
		}
		else
		{
			if (input.IndexOf("<input type=button class=lbut value=\"Умения\" onclick", StringComparison.OrdinalIgnoreCase) == -1)
			{
				goto IL_1321;
			}
			input = smethod_10("Переключение на умения персонажа", "main.php?mselect=1");
		}
		goto IL_39c5;
		IL_36a5:
		if (!Class72.bool_42)
		{
			goto IL_375f;
		}
		string text49 = smethod_35(input, "&im=0&wca=3");
		if (!string.IsNullOrEmpty(text49))
		{
			input = text49;
		}
		else
		{
			if (!smethod_36(input))
			{
				goto IL_375f;
			}
			text49 = smethod_92(input);
			if (string.IsNullOrEmpty(text49))
			{
				if (string_0.EndsWith("im=0&wca=3"))
				{
					Class72.formMain_0.BeginInvoke(new Delegate5(Class72.formMain_0.method_49), new object[0]);
					Class72.formMain_0.BeginInvoke(new Delegate36(Class72.formMain_0.method_63), "Кирки не найдены в инвентаре. Отключаем автошахту.");
					goto IL_375f;
				}
				input = smethod_10("Переключение на вещи", "main.php?im=0&wca=3");
			}
			else
			{
				input = text49;
			}
		}
		goto IL_39c5;
		IL_115d:
		input = text44;
		goto IL_39c5;
		IL_3506:
		if (Class72.smethod_62() && flag)
		{
			text27 = smethod_37(input);
			if (!string.IsNullOrEmpty(text27))
			{
				input = text27;
				goto IL_39c5;
			}
			Class72.smethod_65(bool_54: false);
			if (smethod_38(input))
			{
				Class72.smethod_65(smethod_89(input));
				Class72.smethod_63(bool_54: false);
			}
		}
		if (!(Class72.smethod_64() && flag))
		{
			goto IL_35b1;
		}
		text27 = smethod_35(input, "&im=0&wca=4");
		if (!string.IsNullOrEmpty(text27))
		{
			input = text27;
		}
		else
		{
			if (!smethod_36(input))
			{
				goto IL_35b1;
			}
			text27 = smethod_87(input);
			if (string.IsNullOrEmpty(text27))
			{
				if (string_0.EndsWith("im=0&wca=4"))
				{
					goto IL_35b1;
				}
				input = smethod_10("Переключение на вещи", "main.php?im=0&wca=4");
			}
			else
			{
				input = text27;
			}
		}
		goto IL_39c5;
		IL_2e16:
		text18 = smethod_35(input, "&im=6");
		if (!string.IsNullOrEmpty(text18))
		{
			input = text18;
		}
		else
		{
			if (!smethod_36(input))
			{
				goto IL_304f;
			}
			string text19 = smethod_44(input);
			if (string.IsNullOrEmpty(text19))
			{
				if (string_0.EndsWith("im=6"))
				{
					if (Class72.formMain_0 != null)
					{
						if (Class72.string_29.Equals("Рыбная похлебка"))
						{
							Class72.class19_0.method_131(bool_55: false);
						}
						Class72.formMain_0.method_20();
						Class72.formMain_0.method_63((Class72.string_29 == "Приманку Для Ботов") ? "Приманка не обнаружена, действие отменено." : "Эликсир не обнаружен, действие отменено.");
					}
					goto IL_304f;
				}
				input = smethod_10("Переключение на эликсиры", "main.php?im=6");
			}
			else
			{
				if (Class72.formMain_0 != null && Class72.string_29 != null && Class72.string_30 != null)
				{
					Class72.formMain_0.method_63($"Используем <b><font color=#610B5E>{Class72.string_29}</font></b> на <b>{Class72.string_30}</b>");
				}
				Class72.int_8--;
				if (Class72.int_8 == 0 && Class72.formMain_0 != null)
				{
					Class72.formMain_0.method_20();
				}
				input = text19;
			}
		}
		goto IL_39c5;
		IL_3893:
		if (!Class72.bool_52)
		{
			goto IL_394a;
		}
		string text50 = smethod_35(input, "&im=0&wca=4");
		if (!string.IsNullOrEmpty(text50))
		{
			input = text50;
		}
		else
		{
			if (!smethod_36(input))
			{
				goto IL_394a;
			}
			text50 = smethod_95(input);
			if (string.IsNullOrEmpty(text50))
			{
				if (string_0.EndsWith("im=0&wca=4"))
				{
					Class72.formMain_0.BeginInvoke(new Delegate5(Class72.formMain_0.method_56), new object[0]);
					Class72.formMain_0.BeginInvoke(new Delegate36(Class72.formMain_0.method_63), "Серпы не найдены в инвентаре. Отключаем автолес.");
					goto IL_394a;
				}
				input = smethod_10("Переключение на вещи", "main.php?im=0&wca=4");
			}
			else
			{
				input = text50;
			}
		}
		goto IL_39c5;
		IL_3313:
		if (input.IndexOf("var map = ", StringComparison.Ordinal) != -1)
		{
			input = smethod_78(input);
			if (Class72.smethod_36())
			{
				goto IL_39c5;
			}
		}
		string text51 = smethod_43(string_0, input);
		if (!string.IsNullOrEmpty(text51))
		{
			input = text51;
		}
		else
		{
			if (Class72.formMain_0.method_45())
			{
				if ((Class72.bool_37 && Class72.class19_0.method_58() == "11-398") || (Class72.string_41 != "28-462" && Class72.class19_0.method_58() == "28-462"))
				{
					string string_2 = ((string.IsNullOrEmpty(Class72.string_42) || !Class12.smethod_5()) ? Class72.string_41 : Class72.string_42);
					Class72.formMain_0.method_123(string_2);
				}
				if (Class72.class19_0.method_58() == "12-168")
				{
					input = input.Replace("view_map();", "view_map(); ButClick('dep');");
					input = input.Replace("view_teleportsp();", "telep[0][3]?document.location='main.php?get_id=16&act=3&sp='+telep[0][0]+'&vcode='+telep[0][3]:telep[1][3]&&(document.location='main.php?get_id=16&act=3&sp='+telep[1][0]+'&vcode='+telep[1][3]);");
				}
			}
			if (Class72.bool_38 && flag)
			{
				string text52 = smethod_7(input, string_0);
				if (!string.IsNullOrEmpty(text52))
				{
					input = text52;
					goto IL_39c5;
				}
			}
			if (!(Class72.class19_0.method_100() && flag))
			{
				goto IL_35e3;
			}
			if (!Class72.smethod_84())
			{
				Class72.smethod_85(Class72.smethod_26() > Class72.class19_0.method_78() && Class72.class19_0.method_80());
			}
			if (Class72.smethod_26() <= Class72.class19_0.method_78() && !Class72.smethod_30() && !Class72.smethod_84())
			{
				goto IL_34c0;
			}
			text27 = smethod_40(input);
			if (!string.IsNullOrEmpty(text27))
			{
				input = text27;
				Class72.smethod_87(bool_54: true);
				Class72.smethod_33(bool_54: true);
			}
			else
			{
				text27 = smethod_33(input);
				if (string.IsNullOrEmpty(text27))
				{
					goto IL_34c0;
				}
				input = text27;
			}
		}
		goto IL_39c5;
		IL_2b85:
		text18 = smethod_35(input, "&im=0&wca=28");
		if (!string.IsNullOrEmpty(text18))
		{
			input = text18;
		}
		else
		{
			if (!smethod_36(input))
			{
				goto IL_304f;
			}
			string text19 = smethod_44(input);
			if (string.IsNullOrEmpty(text19))
			{
				if (string_0.EndsWith("im=0&wca=28"))
				{
					if (Class72.formMain_0 != null)
					{
						Class72.formMain_0.method_63("Свиток не обнаружен, действие отменено.");
						Class72.formMain_0.method_20();
					}
					goto IL_304f;
				}
				input = smethod_10("Переключение на свитки", "main.php?im=0&wca=28");
			}
			else
			{
				if (Class72.formMain_0 != null && Class72.string_30 != null)
				{
					Class72.formMain_0.method_63($"Используем свиток на <b>{Class72.string_30}</b>");
				}
				Class72.int_8--;
				if (Class72.int_8 == 0 && Class72.formMain_0 != null)
				{
					Class72.formMain_0.method_20();
				}
				input = text19;
			}
		}
		goto IL_39c5;
		IL_1321:
		if (Class72.smethod_60())
		{
			string text53 = smethod_35(input, "&im=5");
			if (!string.IsNullOrEmpty(text53))
			{
				input = text53;
				goto IL_39c5;
			}
			if (smethod_36(input))
			{
				Class72.smethod_61(bool_54: false);
				smethod_97(input);
			}
		}
		if (Class72.smethod_54() && flag)
		{
			string text54 = smethod_37(input);
			if (!string.IsNullOrEmpty(text54))
			{
				input = text54;
				goto IL_39c5;
			}
			Class72.smethod_57(bool_54: false);
			if (smethod_38(input))
			{
				Class72.smethod_57(smethod_90(input));
				Class72.smethod_55(bool_54: false);
			}
		}
		if (!(!Class72.smethod_56() && flag))
		{
			goto IL_140e;
		}
		string text55 = smethod_35(input, "&im=0&wca=4");
		if (!string.IsNullOrEmpty(text55))
		{
			input = text55;
		}
		else
		{
			if (!smethod_36(input))
			{
				goto IL_140e;
			}
			text55 = smethod_91(input);
			if (string.IsNullOrEmpty(text55))
			{
				if (string_0.EndsWith("im=0&wca=4"))
				{
					goto IL_140e;
				}
				input = smethod_10("Переключение на вещи", "main.php?im=0&wca=4");
			}
			else
			{
				Class72.smethod_55(bool_54: true);
				input = text55;
			}
		}
		goto IL_39c5;
		IL_117a:
		if (Class72.formMain_0 != null)
		{
			Class72.formMain_0.method_63("Мы не в невиде, используем <b><font color=#610B5E>зелье невидимости</font></b> на себя");
		}
		Class72.bool_31 = false;
		input = text45;
		goto IL_39c5;
		IL_09f7:
		if (Class72.class19_0.method_182() && input.IndexOf("[\"dig\",\"Копать\",", StringComparison.Ordinal) != -1)
		{
			input = smethod_26(input);
		}
		else if (Class72.class19_0.method_100() && ((Class72.class19_0.method_82() && input.IndexOf("<font color=#CC0000>Внимание! Возможен перегруз.", StringComparison.OrdinalIgnoreCase) != -1) || input.IndexOf("<font color=#CC0000><b>У Вас нет рыболовных снастей.", StringComparison.OrdinalIgnoreCase) != -1 || input.IndexOf("<font color=#CC0000><b>У Вас нет приманки, чтобы ловить рыбу.", StringComparison.OrdinalIgnoreCase) != -1 || input.IndexOf("<font color=#CC0000><b>Приманок нет в наличии.", StringComparison.OrdinalIgnoreCase) != -1 || input.IndexOf("<font color=#CC0000><b>У Вас не хватает умения, чтобы ловить тут рыбу.", StringComparison.OrdinalIgnoreCase) != -1))
		{
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
		else
		{
			int num8 = input.IndexOf("Усталость:</td><td bgcolor=#336699 nowrap><font class=proce><font color=#ffffff><b><div align=center>&nbsp;<b>", StringComparison.OrdinalIgnoreCase);
			if (num8 != -1)
			{
				smethod_76(input, num8 + 110);
			}
			if (!(Class72.smethod_114() && flag))
			{
				goto IL_0bd0;
			}
			string text56 = smethod_35(input, "&im=0&wca=85");
			if (!string.IsNullOrEmpty(text56))
			{
				input = text56;
			}
			else
			{
				if (!smethod_36(input))
				{
					goto IL_0bd0;
				}
				string text57 = smethod_21(input);
				if (string.IsNullOrEmpty(text57))
				{
					if (string_0.EndsWith("im=0&wca=85"))
					{
						if (Class72.formMain_0.method_52())
						{
							string[] array12 = new string[4] { "легких", "средних", "тяжелых", "боевых" };
							int num9 = int.Parse(Class72.smethod_118()) - 1;
							Class72.class19_0.method_70()[num9] = false;
							Class72.formMain_0.method_63($"Подходящая аптечка не найдена! Лечение <b>{array12[num9]}</b> травм отключено.");
						}
						else
						{
							Class72.formMain_0.method_63("Подходящая аптечка не найдена!");
						}
						Class72.smethod_115(bool_54: false);
						goto IL_0bd0;
					}
					input = smethod_10("Переключение на аптечки", "main.php?im=0&wca=85");
				}
				else
				{
					Class72.smethod_115(bool_54: false);
					input = text57;
				}
			}
		}
		goto IL_39c5;
		IL_35e3:
		input = smethod_6(input, string_0);
		if (!Class72.bool_43)
		{
			goto IL_36a5;
		}
		string text58 = smethod_35(input, "&im=0&wca=4");
		if (!string.IsNullOrEmpty(text58))
		{
			input = text58;
		}
		else
		{
			if (!smethod_36(input))
			{
				goto IL_36a5;
			}
			text58 = smethod_93(input);
			if (string.IsNullOrEmpty(text58))
			{
				if (string_0.EndsWith("im=0&wca=4"))
				{
					Class72.formMain_0.BeginInvoke(new Delegate17(Class72.formMain_0.method_95), new object[0]);
					Class72.formMain_0.BeginInvoke(new Delegate36(Class72.formMain_0.method_63), "Факелы/фонари не найдены в инвентаре. Отключаем навигатор.");
					goto IL_36a5;
				}
				input = smethod_10("Переключение на вещи", "main.php?im=0&wca=4");
			}
			else
			{
				input = text58;
			}
		}
		goto IL_39c5;
	}

	private static string smethod_28(string string_0)
	{
		if (string_0.IndexOf("<AREA SHAPE=", StringComparison.OrdinalIgnoreCase) == -1 && string_0.IndexOf("url(http://image.neverlands.ru/cities/forpost/", StringComparison.OrdinalIgnoreCase) == -1)
		{
			return string.Empty;
		}
		string[] array = new string[0];
		switch (Class72.smethod_44())
		{
		case CityGateType.ForpostRightToLeftGate:
			array = new string[3] { "Выход из города", "Перейти на городскую площадь", "Перейти в жилой квартал" };
			break;
		case CityGateType.ForpostLeftToRightGate:
			array = new string[3] { "Выход из города", "Перейти в квартал закона", "Перейти в жилой квартал" };
			break;
		case CityGateType.OktalLeftToRightGate:
			array = new string[5] { "Выход из города, Восточные Ворота", "Перейти на Площадь Гильдий", "Перейти в Деловой Квартал", "Перейти в Промышленный Квартал", "Перейти в Торговый Квартал" };
			break;
		case CityGateType.OktalLeftToBottomGate:
			array = new string[4] { "Выход из города, Южные Ворота", "Перейти к Конюшням", "Перейти в Промышленный Квартал", "Перейти в Торговый Квартал" };
			break;
		case CityGateType.OktalRightToLeftGate:
			array = new string[5] { "Выход из города, Западные Ворота", "Перейти на Центральную Площадь", "Перейти в Торговый Квартал", "Перейти в Промышленный Квартал", "Перейти в Деловой Квартал" };
			break;
		case CityGateType.OktalRightToBottomGate:
			array = new string[2] { "Выход из города, Южные Ворота", "Перейти к Конюшням" };
			break;
		case CityGateType.OktalBottomToLeftGate:
			array = new string[4] { "Выход из города, Западные Ворота", "Перейти на Центральную Площадь", "Перейти в Торговый Квартал", "Перейти в Промышленный Квартал" };
			break;
		case CityGateType.OktalBottomToRightGate:
			array = new string[2] { "Выход из города, Восточные Ворота", "Перейти на Площадь Гильдий" };
			break;
		}
		if (array.Length != 0)
		{
			if (Class72.smethod_44() == CityGateType.ForpostLeftToRightGate)
			{
				if (string_0.IndexOf("Выход из города", StringComparison.OrdinalIgnoreCase) != -1 && string_0.IndexOf("Перейти в деловой квартал", StringComparison.OrdinalIgnoreCase) != -1)
				{
					string text = smethod_29(string_0, "Перейти в жилой квартал");
					if (!string.IsNullOrEmpty(text))
					{
						return text;
					}
				}
				if (string_0.IndexOf("Выход из города", StringComparison.OrdinalIgnoreCase) != -1 && string_0.IndexOf("Перейти в деловой квартал", StringComparison.OrdinalIgnoreCase) == -1)
				{
					string text2 = smethod_29(string_0, "Выход из города");
					if (!string.IsNullOrEmpty(text2))
					{
						return text2;
					}
				}
			}
			if (Class72.smethod_44() == CityGateType.ForpostRightToLeftGate)
			{
				if (string_0.IndexOf("Выход из города", StringComparison.OrdinalIgnoreCase) != -1 && string_0.IndexOf("Перейти в деловой квартал", StringComparison.OrdinalIgnoreCase) == -1)
				{
					string text3 = smethod_29(string_0, "Перейти в жилой квартал");
					if (!string.IsNullOrEmpty(text3))
					{
						return text3;
					}
				}
				if (string_0.IndexOf("Выход из города", StringComparison.OrdinalIgnoreCase) != -1 && string_0.IndexOf("Перейти в деловой квартал", StringComparison.OrdinalIgnoreCase) != -1)
				{
					string text4 = smethod_29(string_0, "Выход из города");
					if (!string.IsNullOrEmpty(text4))
					{
						return text4;
					}
				}
			}
			for (int i = 0; i < array.Length; i++)
			{
				string text5 = smethod_29(string_0, array[i]);
				if (!string.IsNullOrEmpty(text5))
				{
					return text5;
				}
			}
		}
		return string.Empty;
	}

	private static string smethod_29(string string_0, string string_1)
	{
		string value = "tooltip(this,'" + string_1 + "')";
		int num = string_0.IndexOf(value, StringComparison.OrdinalIgnoreCase);
		if (num == -1)
		{
			return string.Empty;
		}
		string text = "href=\"";
		int num2 = string_0.LastIndexOf(text, num, StringComparison.OrdinalIgnoreCase);
		if (num2 == -1)
		{
			return string.Empty;
		}
		int num3 = string_0.IndexOf('"', num2 + text.Length);
		if (num3 != -1)
		{
			return smethod_10("Навигация по городу", string_0.Substring(num2 + text.Length, num3 - num2 - text.Length));
		}
		return string.Empty;
	}

	private static string smethod_30(string string_0)
	{
		string[] array = new string[6] { "8-259", "8-294", "8-197", "12-428", "12-494", "12-521" };
		if (Class72.smethod_46() == null || Class72.smethod_46().Path == null || Class72.smethod_46().Path.Length == 0 || !Class72.smethod_46().CanUseExistingPath(Class72.class19_0.method_58(), Class72.smethod_40()))
		{
			string[] destinationCellNumberList = new string[1] { Class72.smethod_40() };
			Class72.smethod_47(new MapPath(Class72.class19_0.method_58(), destinationCellNumberList));
		}
		if (Class72.smethod_46().Path.Length < 2)
		{
			return null;
		}
		string text = Class72.smethod_46().Path[1];
		if (Array.IndexOf(array, text) < 0)
		{
			text = Class72.smethod_46().Path[0];
			if (Array.IndexOf(array, text) < 0)
			{
				return null;
			}
		}
		int num = string_0.IndexOf(".jpg width=760 height=255 border=0 USEMAP=\"#links\">", StringComparison.CurrentCultureIgnoreCase);
		if (num == -1)
		{
			return null;
		}
		int num2 = string_0.LastIndexOf("/", num, StringComparison.CurrentCultureIgnoreCase);
		if (num2 == -1)
		{
			return null;
		}
		string text2 = string_0.Substring(num2 + 1, num - num2 - 1);
		if (string.IsNullOrEmpty(text2))
		{
			return null;
		}
		if (!new SortedDictionary<string, string>
		{
			{ "city1_fon_1:8-259", "Выход из города" },
			{ "city1_fon_1:8-294", "Перейти в жилой квартал" },
			{ "city1_fon_2:8-259", "Перейти на городскую площадь" },
			{ "city1_fon_2:8-294", "Перейти в квартал закона" },
			{ "city1_fon_3:8-259", "Перейти в жилой квартал" },
			{ "city1_fon_3:8-294", "Перейти в жилой квартал" },
			{ "city1_fon_4:8-259", "Перейти на городскую площадь" },
			{ "city1_fon_4:8-294", "Перейти на городскую площадь" },
			{ "city1_fon_5_new:8-259", "Перейти в жилой квартал" },
			{ "city1_fon_5_new:8-294", "Выход из города" },
			{ "country1_fon:8-197", "Выход из деревни" },
			{ "city2_1:12-428", "Выход из города, Западные Ворота" },
			{ "city2_1:12-494", "Перейти в Торговый Квартал" },
			{ "city2_1:12-521", "Перейти в Торговый Квартал" },
			{ "city2_2_new:12-428", "Перейти на Центральную Площадь" },
			{ "city2_2_new:12-494", "Перейти в Промышленный Квартал" },
			{ "city2_2_new:12-521", "Перейти в Промышленный Квартал" },
			{ "city2_3:12-428", "Перейти на Центральную Площадь" },
			{ "city2_3:12-494", "Перейти в Промышленный Квартал" },
			{ "city2_3:12-521", "Перейти в Промышленный Квартал" },
			{ "city2_4:12-428", "Перейти в Торговый Квартал" },
			{ "city2_4:12-494", "Перейти к Конюшням" },
			{ "city2_4:12-521", "Перейти к Конюшням" },
			{ "city2_5:12-428", "Перейти в Промышленный Квартал" },
			{ "city2_5:12-494", "Перейти на Площадь Гильдий" },
			{ "city2_5:12-521", "Перейти на Площадь Гильдий" },
			{ "city2_6:12-428", "Перейти в жилой квартал" },
			{ "city2_6:12-494", "Перейти к Конюшням" },
			{ "city2_6:12-521", "Перейти к Конюшням" },
			{ "city2_7_exit:12-428", "Перейти в Промышленный Квартал" },
			{ "city2_7_exit:12-494", "Перейти на Площадь Гильдий" },
			{ "city2_7_exit:12-521", "Выход из города, Южные Ворота" },
			{ "city2_8:12-428", "Перейти в Деловой Квартал" },
			{ "city2_8:12-494", "Выход из города, Восточные Ворота" },
			{ "city2_8:12-521", "Перейти к Конюшням" },
			{ "city2_8_elko:12-428", "Перейти в Деловой Квартал" },
			{ "city2_8_elko:12-494", "Выход из города, Восточные Ворота" },
			{ "city2_8_elko:12-521", "Перейти к Конюшням" },
			{ "city2_9:12-428", "Перейти в Квартал Знаний" },
			{ "city2_9:12-494", "Перейти в Квартал Знаний" },
			{ "city2_9:12-521", "Перейти в Квартал Знаний" }
		}.TryGetValue(text2 + ":" + text, out var value))
		{
			return null;
		}
		string text3 = smethod_29(string_0, value);
		if (string.IsNullOrEmpty(text3))
		{
			return null;
		}
		return text3;
	}

	private static string smethod_31(string string_0)
	{
		string value = Class12.smethod_1(string_0, "abil_2(3,'", "'");
		if (string.IsNullOrEmpty(value))
		{
			return null;
		}
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append(Class7.smethod_1() + "Используем сумеречный туман...");
		stringBuilder.Append("<form action=main.php method=POST name=ff>");
		stringBuilder.Append("<input name=useaction type=hidden value=\"");
		stringBuilder.Append("addon-action");
		stringBuilder.Append("\">");
		stringBuilder.Append("<input name=addid type=hidden value=\"");
		stringBuilder.Append(1);
		stringBuilder.Append("\">");
		stringBuilder.Append("<input name=post_id type=hidden value=\"");
		stringBuilder.Append(32);
		stringBuilder.Append("\">");
		stringBuilder.Append("<input name=vcode type=hidden value=\"");
		stringBuilder.Append(value);
		stringBuilder.Append("\">");
		stringBuilder.Append("<INPUT name=pnick type=hidden value=\"");
		stringBuilder.Append(Class72.class19_0.method_30());
		stringBuilder.Append("\">");
		stringBuilder.Append("</form><script language=\"JavaScript\">document.ff.submit();</script></body></html>");
		return stringBuilder.ToString();
	}

	private static string smethod_32(string string_0)
	{
		string value = Class12.smethod_1(string_0, "abil_1(3,'", "'");
		if (string.IsNullOrEmpty(value))
		{
			return null;
		}
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append(Class7.smethod_1() + "Используем сумеречный телепорт...");
		stringBuilder.Append("<form action=main.php method=POST name=ff>");
		stringBuilder.Append("<input name=useaction type=hidden value=\"");
		stringBuilder.Append("addon-action");
		stringBuilder.Append("\">");
		stringBuilder.Append("<input name=addid type=hidden value=\"");
		stringBuilder.Append(1);
		stringBuilder.Append("\">");
		stringBuilder.Append("<input name=post_id type=hidden value=\"");
		stringBuilder.Append(31);
		stringBuilder.Append("\">");
		stringBuilder.Append("<input name=vcode type=hidden value=\"");
		stringBuilder.Append(value);
		stringBuilder.Append("\">");
		int value2 = Class89.smethod_0(12) + 1;
		stringBuilder.Append("<input name=wtelid type=hidden value=\"");
		stringBuilder.Append(value2);
		stringBuilder.Append("\">");
		stringBuilder.Append("</form><script language=\"JavaScript\">document.ff.submit();</script></body></html>");
		return stringBuilder.ToString();
	}

	private static string smethod_33(string string_0)
	{
		if (string_0.IndexOf("<input type=button class=lbutdis value=\"Причал\" DISABLED>", StringComparison.OrdinalIgnoreCase) != -1)
		{
			return string.Empty;
		}
		int num = string_0.IndexOf("value=\"Вернуться\">", StringComparison.OrdinalIgnoreCase);
		if (num == -1)
		{
			return string.Empty;
		}
		int num2 = string_0.LastIndexOf("onclick=\"location='", num, StringComparison.OrdinalIgnoreCase);
		if (num2 == -1)
		{
			return string.Empty;
		}
		int num3 = string_0.IndexOf("'", num2 + 19, StringComparison.Ordinal);
		if (num3 != -1)
		{
			return smethod_10("Переключение на природу", string_0.Substring(num2 + 19, num3 - num2 - 19));
		}
		return string.Empty;
	}

	private static string smethod_34(string string_0, string string_1)
	{
		string text = Class12.smethod_1(string_0, "<input type=button class=lbut value=\"Инвентарь\"", ">");
		if (!string.IsNullOrEmpty(text) && text.IndexOf("DISABLED", StringComparison.OrdinalIgnoreCase) != -1)
		{
			return null;
		}
		int num = string_0.IndexOf("value=\"Инвентарь\">", StringComparison.OrdinalIgnoreCase);
		if (num != -1)
		{
			int num2 = string_0.LastIndexOf("onclick=\"location='", num, StringComparison.OrdinalIgnoreCase);
			if (num2 == -1)
			{
				return string.Empty;
			}
			int num3 = string_0.IndexOf("'", num2 + 19, StringComparison.Ordinal);
			if (num3 != -1)
			{
				return smethod_10("Переключение на инвентарь", string_0.Substring(num2 + 19, num3 - num2 - 19) + string_1);
			}
			return string.Empty;
		}
		int num4 = string_0.IndexOf("class=lbut value=\"Инвентарь\"", StringComparison.OrdinalIgnoreCase);
		if (num4 != -1)
		{
			int num5 = string_0.IndexOf("onclick=\"location='", num4, StringComparison.OrdinalIgnoreCase);
			if (num5 == -1)
			{
				return string.Empty;
			}
			int num6 = string_0.IndexOf("'", num5 + 19, StringComparison.Ordinal);
			if (num6 != -1)
			{
				return smethod_10("Переключение на инвентарь", string_0.Substring(num5 + 19, num6 - num5 - 19) + string_1);
			}
			return string.Empty;
		}
		return null;
	}

	private static string smethod_35(string string_0, string string_1)
	{
		string text = Class12.smethod_1(string_0, "var vcode = [\"", "\"]");
		if (!string.IsNullOrEmpty(text))
		{
			string[] array = text.Split(new string[1] { "\",\"" }, StringSplitOptions.RemoveEmptyEntries);
			return smethod_10("Переключение на инвентарь", "main.php?get_id=56&act=10&go=inv&vcode=" + array[1] + string_1);
		}
		text = Class12.smethod_1(string_0, "var vcode = [[1,\"", "\"]]");
		if (!string.IsNullOrEmpty(text))
		{
			string[] array2 = text.Split(new string[1] { "\"],[1,\"" }, StringSplitOptions.RemoveEmptyEntries);
			return smethod_10("Переключение на инвентарь", "main.php?get_id=56&act=10&go=inv&vcode=" + array2[1] + string_1);
		}
		string text2 = Class12.smethod_1(string_0, "[\"inv\",\"Инвентарь\",\"", "\"");
		if (!string.IsNullOrEmpty(text2))
		{
			return smethod_10("Переключение на инвентарь", "main.php?get_id=56&act=10&go=inv&vcode=" + text2 + string_1);
		}
		if (string.IsNullOrEmpty(text2))
		{
			string text3 = Class12.smethod_1(string_0, "var objActions = ", ";");
			if (!string.IsNullOrEmpty(text3))
			{
				text2 = Class12.smethod_1(text3, "\"inv\":\"", "\"");
			}
			if (!string.IsNullOrEmpty(text2))
			{
				return smethod_10("Переключение на инвентарь", "main.php?get_id=56&act=10&go=inv&vcode=" + text2 + string_1);
			}
		}
		if (string_0.IndexOf("Инвентарь", StringComparison.OrdinalIgnoreCase) == -1)
		{
			if (string_0.IndexOf("<input type=button class=lbut onclick=\"location='../main.php'\" value=\"Вернуться\">", StringComparison.Ordinal) != -1)
			{
				return smethod_10("Переключение на инвентарь", "main.php");
			}
			return null;
		}
		string text4 = smethod_34(string_0, string_1);
		if (!string.IsNullOrEmpty(text4))
		{
			return text4;
		}
		return null;
	}

	private static bool smethod_36(string string_0)
	{
		return string_0.IndexOf("<a href=\"?im=0\"><img", StringComparison.OrdinalIgnoreCase) != -1;
	}

	private static string smethod_37(string string_0)
	{
		string text = Class12.smethod_1(string_0, "'main.php?get_id=56&act=10&go=inf&vcode=", "'");
		if (string.IsNullOrEmpty(text))
		{
			text = Class12.smethod_1(string_0, "var vcode = [[1,\"", "\"");
		}
		if (string.IsNullOrEmpty(text))
		{
			text = Class12.smethod_1(string_0, "var vcode = [\"", "\"");
		}
		if (string.IsNullOrEmpty(text))
		{
			text = Class12.smethod_1(string_0, "[\"inf\",\"Ваш персонаж\",\"", "\"");
		}
		if (string.IsNullOrEmpty(text))
		{
			string text2 = Class12.smethod_1(string_0, "var objActions = ", ";");
			if (!string.IsNullOrEmpty(text2))
			{
				text = Class12.smethod_1(text2, "\"inf\":\"", "\"");
			}
		}
		if (!string.IsNullOrEmpty(text))
		{
			Class72.smethod_131(DateTime.Now);
			return smethod_10("Переключение на персонаж", "main.php?get_id=56&act=10&go=inf&vcode=" + text);
		}
		return null;
	}

	private static bool smethod_38(string string_0)
	{
		return string_0.IndexOf("input type=button class=lbut value=\"Умения\"", StringComparison.OrdinalIgnoreCase) != -1;
	}

	private static string smethod_39(string string_0)
	{
		int num = string_0.IndexOf("[\"dep\",\"Войти\",\"", StringComparison.OrdinalIgnoreCase);
		if (num == -1)
		{
			return null;
		}
		num += 16;
		int num2 = string_0.IndexOf('"', num);
		if (num2 == -1)
		{
			return null;
		}
		string text = string_0.Substring(num, num2 - num);
		string string_1 = string.Format(CultureInfo.InvariantCulture, "main.php?get_id=56&act=10&go=dep&vcode={0}", new object[1] { text });
		return smethod_10("Вход", string_1);
	}

	private static string smethod_40(string string_0)
	{
		int num = string_0.IndexOf("[\"dri\",\"Пить\",\"", StringComparison.OrdinalIgnoreCase);
		if (num == -1)
		{
			return null;
		}
		num += 15;
		int num2 = string_0.IndexOf('"', num);
		if (num2 == -1)
		{
			return null;
		}
		string text = string_0.Substring(num, num2 - num);
		string value = string.Format(CultureInfo.InvariantCulture, "Drink('{0}');", new object[1] { text });
		int num3 = string_0.IndexOf("view_map();", StringComparison.OrdinalIgnoreCase);
		if (num3 != -1)
		{
			num3 += 11;
			string_0 = string_0.Insert(num3, value);
		}
		return string_0;
	}

	private static string smethod_41(string string_0)
	{
		int num = string_0.IndexOf("[\"fis\",\"Рыбалка\",\"", StringComparison.OrdinalIgnoreCase);
		if (num == -1)
		{
			return null;
		}
		num += 18;
		int num2 = string_0.IndexOf('"', num);
		if (num2 == -1)
		{
			return null;
		}
		string text = string_0.Substring(num, num2 - num);
		string value = string.Format(CultureInfo.InvariantCulture, "Fish('{0}');", new object[1] { text });
		int num3 = string_0.IndexOf("view_map();", StringComparison.OrdinalIgnoreCase);
		if (num3 != -1)
		{
			num3 += 11;
			string_0 = string_0.Insert(num3, value);
		}
		return string_0;
	}

	private static bool smethod_42(string string_0)
	{
		return string_0.IndexOf("<a href=?useaction=addon-action&addid=2>", StringComparison.OrdinalIgnoreCase) != -1;
	}

	private static string smethod_43(string string_0, string string_1)
	{
		if (!Class72.class19_0.bool_51 && !Class72.class19_0.bool_52)
		{
			return null;
		}
		string text = Class12.smethod_1(string_1, "var inshp = [", "];");
		if (string.IsNullOrEmpty(text))
		{
			text = Class12.smethod_1(string_1, "ins_HP(", ");");
		}
		if (string.IsNullOrEmpty(text))
		{
			return null;
		}
		string[] array = text.Split(',');
		if (array.Length != 6)
		{
			return null;
		}
		if (!double.TryParse(array[0], NumberStyles.Any, CultureInfo.InvariantCulture, out var result))
		{
			return null;
		}
		int num = (int)result;
		if (num < 0)
		{
			num = 0;
		}
		if (!double.TryParse(array[1], NumberStyles.Any, CultureInfo.InvariantCulture, out result))
		{
			return null;
		}
		int num2 = (int)result;
		if (num2 <= 0)
		{
			num2 = 0;
		}
		if (!double.TryParse(array[2], NumberStyles.Any, CultureInfo.InvariantCulture, out result))
		{
			return null;
		}
		int num3 = (int)result;
		if (num3 < 0)
		{
			num3 = 0;
		}
		if (!double.TryParse(array[3], NumberStyles.Any, CultureInfo.InvariantCulture, out result))
		{
			return null;
		}
		int num4 = (int)result;
		if (num4 <= 0)
		{
			num4 = 0;
		}
		int num5 = ((num2 > 0) ? ((int)((double)num * 100.0 / (double)num2)) : 0);
		int num6 = ((num4 > 0) ? ((int)((double)num3 * 100.0 / (double)num4)) : 0);
		if ((Class72.class19_0.bool_51 && num2 > 0 && num5 < Class72.class19_0.int_11) || (Class72.class19_0.bool_52 && num4 > 0 && num6 < Class72.class19_0.int_12))
		{
			Class72.int_12++;
			if (Class72.int_12 > 30)
			{
				Class72.formMain_0.method_63("Слишком много попыток выпить Эликсир Восстановления. Восстановление здоровья/маны вне боя отключено. Не забудьте включить их обратно.");
				Class72.class19_0.bool_51 = false;
				Class72.class19_0.bool_52 = false;
				Class72.int_12 = 0;
				return null;
			}
			if (!smethod_36(string_1))
			{
				string text2 = smethod_35(string_1, "&im=6");
				if (!string.IsNullOrEmpty(text2))
				{
					return text2;
				}
			}
			if (smethod_36(string_1))
			{
				string text3 = Class12.smethod_1(string_1, "if(confirm('Использовать Эликсир Восстановления сейчас?')) { location='", "' }");
				if (!string.IsNullOrEmpty(text3))
				{
					Class72.formMain_0.method_63("Используем Эликсир Восстановления...");
					return smethod_10("Используем Эликсир Восстановления...", text3);
				}
				if (!string_0.EndsWith("im=6"))
				{
					return smethod_10("Переключение на элексиры", "main.php?im=6");
				}
				Class72.formMain_0.method_63("Эликсир Восстановления не найден. Восстановление здоровья/маны вне боя отключено. Не забудьте включить их обратно.");
				Class72.class19_0.bool_51 = false;
				Class72.class19_0.bool_52 = false;
				Class72.int_12 = 0;
				return null;
			}
		}
		else
		{
			Class72.int_12 = 0;
		}
		return null;
	}

	private static string smethod_44(string string_0)
	{
		string string_1 = Class72.string_29;
		uint num = Class0.smethod_0(string_1);
		if (num <= 2133372590)
		{
			if (num <= 1067905636)
			{
				if (num <= 449568891)
				{
					if (num <= 201456646)
					{
						if (num <= 90572812)
						{
							if (num <= 47635349)
							{
								if (num != 25477890)
								{
									if (num == 47635349 && string_1 == "Превосходное Зелье Гения")
									{
										goto IL_12d1;
									}
								}
								else if (string_1 == "Свиток Величия")
								{
									goto IL_125c;
								}
							}
							else if (num != 63144885)
							{
								if (num == 90572812 && string_1 == "Свиток Проклятия")
								{
									goto IL_05da;
								}
							}
							else if (string_1 == "Зелье Скорости")
							{
								goto IL_12d1;
							}
						}
						else if (num <= 112478207)
						{
							if (num != 98002318)
							{
								if (num == 112478207 && string_1 == "Жареная рыба с красной икрой")
								{
									goto IL_12a8;
								}
							}
							else if (string_1 == "i_svi_213.gif")
							{
								return smethod_48(string_0);
							}
						}
						else if (num != 156804902)
						{
							if (num == 201456646 && string_1 == "Зелье Блаженства")
							{
								goto IL_12d1;
							}
						}
						else if (string_1 == "Свиток Благословения")
						{
							goto IL_05da;
						}
					}
					else if (num <= 360004320)
					{
						if (num <= 282576027)
						{
							if (num != 271840760)
							{
								if (num == 282576027 && string_1 == "Молодильное яблочко")
								{
									goto IL_125c;
								}
							}
							else if (string_1 == "Баалгорский травяной настой")
							{
								goto IL_12a8;
							}
						}
						else if (num != 303371923)
						{
							if (num == 360004320 && string_1 == "Превосходное Зелье Недосягаемости")
							{
								goto IL_12d1;
							}
						}
						else if (string_1 == "Запеченная рыба")
						{
							goto IL_12a8;
						}
					}
					else
					{
						if (num > 396950090)
						{
							if (num != 446680559)
							{
								if (num != 449568891 || !(string_1 == "Зелье Жизни"))
								{
									goto IL_12bc;
								}
							}
							else if (!(string_1 == "Превосходное Зелье Ореола"))
							{
								goto IL_12bc;
							}
							goto IL_12d1;
						}
						if (num != 387573311)
						{
							if (num == 396950090 && string_1 == "Превосходное Зелье Ловких Ударов")
							{
								goto IL_12d1;
							}
						}
						else if (string_1 == "Жаркое по-Кардиффски")
						{
							goto IL_12a8;
						}
					}
				}
				else if (num <= 721317201)
				{
					if (num <= 558645810)
					{
						if (num <= 522834873)
						{
							if (num != 522198175)
							{
								if (num == 522834873 && string_1 == "i_svi_205.gif")
								{
									return smethod_60(string_0);
								}
							}
							else if (string_1 == "Зелье Лечения")
							{
								goto IL_12d1;
							}
						}
						else if (num != 554362324)
						{
							if (num == 558645810 && string_1 == "Зелье Точного Попадания")
							{
								goto IL_12d1;
							}
						}
						else if (string_1 == "i_w28_25.gif")
						{
							return smethod_57(string_0);
						}
					}
					else if (num <= 689376527)
					{
						if (num != 640530248)
						{
							if (num == 689376527 && string_1 == "Пирог с бананами")
							{
								goto IL_12a8;
							}
						}
						else if (string_1 == "Тотем")
						{
							return smethod_68(string_0);
						}
					}
					else if (num != 706003160)
					{
						if (num == 721317201 && string_1 == "i_w28_26.gif")
						{
							return smethod_54(string_0);
						}
					}
					else if (string_1 == "Зелье Восстановления Маны")
					{
						goto IL_12d1;
					}
				}
				else
				{
					if (num > 812877630)
					{
						if (num <= 938498820)
						{
							if (num != 902080332)
							{
								if (num != 938498820 || !(string_1 == "Зелье Мифриловый Стержень"))
								{
									goto IL_12bc;
								}
							}
							else if (!(string_1 == "Зелье Просветления"))
							{
								goto IL_12bc;
							}
						}
						else if (num != 979178017)
						{
							if (num != 1034570523)
							{
								if (num != 1067905636 || !(string_1 == "Превосходное Зелье Стойкости"))
								{
									goto IL_12bc;
								}
							}
							else if (!(string_1 == "Зелье Соколиный взор"))
							{
								goto IL_12bc;
							}
						}
						else if (!(string_1 == "Зелье Энергии"))
						{
							goto IL_12bc;
						}
						goto IL_12d1;
					}
					if (num <= 788171765)
					{
						if (num != 750246592)
						{
							if (num == 788171765 && string_1 == "Суши")
							{
								goto IL_12a8;
							}
						}
						else if (string_1 == "Тушеное мясо с гарниром")
						{
							goto IL_12a8;
						}
					}
					else if (num != 794187093)
					{
						if (num == 812877630 && string_1 == "Зелье подвижности")
						{
							goto IL_12d1;
						}
					}
					else if (string_1 == "Рыбная солянка")
					{
						goto IL_12a8;
					}
				}
			}
			else if (num <= 1628597842)
			{
				if (num <= 1225421526)
				{
					if (num <= 1137003133)
					{
						if (num <= 1116014943)
						{
							if (num != 1070171056)
							{
								if (num == 1116014943 && string_1 == "Паштет с овощами")
								{
									goto IL_12a8;
								}
							}
							else if (string_1 == "Свиток Каменной Кожи")
							{
								goto IL_125c;
							}
						}
						else if (num != 1135811353)
						{
							if (num == 1137003133 && string_1 == "Коньяк Дубовый")
							{
								goto IL_12a8;
							}
						}
						else if (string_1 == "Фаросское вино")
						{
							goto IL_12a8;
						}
					}
					else if (num <= 1173367137)
					{
						if (num != 1148252190)
						{
							if (num == 1173367137 && string_1 == "Превосходное Зелье Человек-Гора")
							{
								goto IL_12d1;
							}
						}
						else if (string_1 == "Самогон")
						{
							goto IL_12a8;
						}
					}
					else if (num != 1192497576)
					{
						if (num == 1225421526 && string_1 == "Свиток Берсерка")
						{
							goto IL_05da;
						}
					}
					else if (string_1 == "Превосходное Зелье Мужества")
					{
						goto IL_12d1;
					}
				}
				else if (num <= 1441811502)
				{
					if (num <= 1326778013)
					{
						if (num != 1228032671)
						{
							if (num != 1326778013 || !(string_1 == "Жажда Жизни"))
							{
								goto IL_12bc;
							}
						}
						else if (!(string_1 == "Превосходное Зелье Скорости"))
						{
							goto IL_12bc;
						}
						goto IL_12d1;
					}
					if (num != 1337111575)
					{
						if (num == 1441811502 && string_1 == "Зелье Мужества")
						{
							goto IL_12d1;
						}
					}
					else if (string_1 == "i_w28_26X.gif")
					{
						return smethod_55(string_0);
					}
				}
				else if (num <= 1591817875)
				{
					if (num != 1546644912)
					{
						if (num == 1591817875 && string_1 == "i_w28_28.gif")
						{
							return smethod_59(string_0);
						}
					}
					else if (string_1 == "Зелье Медитации")
					{
						goto IL_12d1;
					}
				}
				else if (num != 1601947396)
				{
					if (num == 1628597842 && string_1 == "Рыбный салат")
					{
						goto IL_12a8;
					}
				}
				else if (string_1 == "Зелье Загрубелой Кожи")
				{
					goto IL_12d1;
				}
			}
			else if (num <= 1787465050)
			{
				if (num <= 1690607148)
				{
					if (num <= 1665782505)
					{
						if (num != 1657785153)
						{
							if (num == 1665782505 && string_1 == "Зелье Боевой Славы")
							{
								goto IL_12d1;
							}
						}
						else if (string_1 == "Чашу Айрис")
						{
							goto IL_125c;
						}
					}
					else if (num != 1680370730)
					{
						if (num == 1690607148 && string_1 == "Свиток Сопротивления Огню")
						{
							goto IL_125c;
						}
					}
					else if (string_1 == "Зелье Невидимости")
					{
						goto IL_12d1;
					}
				}
				else if (num <= 1708842566)
				{
					if (num != 1706029086)
					{
						if (num == 1708842566 && string_1 == "Эликсир из Подснежника")
						{
							goto IL_125c;
						}
					}
					else if (string_1 == "i_w28_27.gif")
					{
						return smethod_51(string_0);
					}
				}
				else
				{
					switch (num)
					{
					case 1787465050u:
						if (string_1 == "Призыв Импа-вредителя")
						{
							return smethod_70(string_0);
						}
						break;
					case 1749545687u:
						if (string_1 == "Телепорт (Гиблая Топь)")
						{
							return smethod_69(string_0, bool_0: false);
						}
						break;
					}
				}
			}
			else if (num <= 1966443421)
			{
				if (num <= 1837336682)
				{
					if (num != 1836598811)
					{
						if (num == 1837336682 && string_1 == "Превосходное Зелье Точности")
						{
							goto IL_12d1;
						}
					}
					else if (string_1 == "Цветочный пунш")
					{
						goto IL_12a8;
					}
				}
				else if (num != 1960961703)
				{
					if (num == 1966443421 && string_1 == "Свиток Помощника")
					{
						goto IL_125c;
					}
				}
				else if (string_1 == "Зелье Лечения Отравлений")
				{
					goto IL_12d1;
				}
			}
			else if (num <= 2070913494)
			{
				if (num != 2026751319)
				{
					if (num == 2070913494 && string_1 == "Свиток Магии Воды")
					{
						goto IL_125c;
					}
				}
				else if (string_1 == "Зелье Сокрушительных Ударов")
				{
					goto IL_12d1;
				}
			}
			else if (num != 2075089289)
			{
				if (num != 2133161696)
				{
					if (num == 2133372590 && string_1 == "Телепорт (Остров Туротор)")
					{
						return smethod_69(string_0, bool_0: true);
					}
				}
				else if (string_1 == "Рыбный суп-пюре")
				{
					goto IL_12a8;
				}
			}
			else if (string_1 == "Ярость Берсерка")
			{
				goto IL_12d1;
			}
		}
		else if (num <= 3148254162u)
		{
			if (num <= 2698831014u)
			{
				if (num <= 2448360414u)
				{
					if (num <= 2355351133u)
					{
						if (num <= 2175056014u)
						{
							if (num != 2135507288)
							{
								if (num == 2175056014u && string_1 == "Зелье Секрет Волшебника")
								{
									goto IL_12d1;
								}
							}
							else if (string_1 == "Эликсир Быстроты")
							{
								goto IL_125c;
							}
						}
						else if (num != 2301215396u)
						{
							if (num == 2355351133u && string_1 == "Превосходное Зелье Волшебства")
							{
								goto IL_12d1;
							}
						}
						else if (string_1 == "Свиток Сопротивления Воздуху")
						{
							goto IL_125c;
						}
					}
					else
					{
						if (num > 2405926421u)
						{
							if (num != 2429118811u)
							{
								if (num != 2448360414u || !(string_1 == "Яд"))
								{
									goto IL_12bc;
								}
							}
							else if (!(string_1 == "Превосходное Зелье Сильной Спины"))
							{
								goto IL_12bc;
							}
							goto IL_12d1;
						}
						if (num != 2384603612u)
						{
							if (num == 2405926421u && string_1 == "i_w28_22.gif")
							{
								return smethod_46(string_0);
							}
						}
						else if (string_1 == "Превосходное Зелье Сокрушения")
						{
							goto IL_12d1;
						}
					}
				}
				else if (num <= 2580994843u)
				{
					if (num <= 2557041854u)
					{
						if (num != 2546195787u)
						{
							if (num == 2557041854u && string_1 == "Превосходное Зелье Медитации")
							{
								goto IL_12d1;
							}
						}
						else if (string_1 == "Эликсир Блаженства")
						{
							goto IL_125c;
						}
					}
					else if (num != 2565130601u)
					{
						if (num == 2580994843u && string_1 == "Рыбная паста по-Кентарийски")
						{
							goto IL_12a8;
						}
					}
					else if (string_1 == "Превосходное Зелье Удачи")
					{
						goto IL_12d1;
					}
				}
				else if (num <= 2675766214u)
				{
					if (num != 2662821515u)
					{
						if (num == 2675766214u && string_1 == "Свиток Магии Земли")
						{
							goto IL_125c;
						}
					}
					else if (string_1 == "Свиток Сопротивления Воде")
					{
						goto IL_125c;
					}
				}
				else if (num != 2684974432u)
				{
					if (num == 2698831014u && string_1 == "Свиток Гнев Локара")
					{
						goto IL_125c;
					}
				}
				else if (string_1 == "Вяленая рыба с белым соусом")
				{
					goto IL_12a8;
				}
			}
			else if (num <= 2875821002u)
			{
				if (num <= 2820223890u)
				{
					if (num <= 2783139521u)
					{
						if (num != 2708348024u)
						{
							if (num == 2783139521u && string_1 == "Эликсир Восстановления")
							{
								goto IL_125c;
							}
						}
						else if (string_1 == "Зелье Иммунитета")
						{
							goto IL_12d1;
						}
					}
					else if (num != 2806899480u)
					{
						if (num == 2820223890u && string_1 == "Яблочный пирог")
						{
							goto IL_12a8;
						}
					}
					else if (string_1 == "Свиток Магии Воздуха")
					{
						goto IL_125c;
					}
				}
				else if (num <= 2835036407u)
				{
					if (num != 2833369889u)
					{
						if (num == 2835036407u && string_1 == "Паста из раковых шеек с мясом")
						{
							goto IL_12a8;
						}
					}
					else if (string_1 == "Зелье Хрупкости")
					{
						goto IL_12d1;
					}
				}
				else if (num != 2835609248u)
				{
					if (num == 2875821002u && string_1 == "i_svi_002.gif")
					{
						return smethod_53(string_0);
					}
				}
				else if (string_1 == "Свиток Сопротивления Земле")
				{
					goto IL_125c;
				}
			}
			else if (num <= 2907296056u)
			{
				if (num > 2890270839u)
				{
					if (num != 2891769043u)
					{
						if (num != 2907296056u || !(string_1 == "Зелье Ловких Ударов"))
						{
							goto IL_12bc;
						}
					}
					else if (!(string_1 == "Зелье Удачи"))
					{
						goto IL_12bc;
					}
					goto IL_12d1;
				}
				if (num != 2890020870u)
				{
					if (num == 2890270839u && string_1 == "i_w28_24.gif")
					{
						return smethod_56(string_0);
					}
				}
				else if (string_1 == "Анисовая водка")
				{
					goto IL_12a8;
				}
			}
			else if (num <= 3036555492u)
			{
				if (num != 2961271354u)
				{
					if (num == 3036555492u && string_1 == "Дар Иланы")
					{
						goto IL_125c;
					}
				}
				else if (string_1 == "Ментальная Жажда")
				{
					goto IL_12d1;
				}
			}
			else if (num != 3064268775u)
			{
				if (num != 3122132996u)
				{
					if (num == 3148254162u && string_1 == "Превосходное Зелье Силы")
					{
						goto IL_12d1;
					}
				}
				else if (string_1 == "Свиток Магии Огня")
				{
					goto IL_125c;
				}
			}
			else if (string_1 == "Свиток Очищения")
			{
				goto IL_125c;
			}
		}
		else if (num <= 3712381031u)
		{
			if (num <= 3486881711u)
			{
				if (num <= 3211767803u)
				{
					if (num <= 3158440362u)
					{
						if (num != 3152929863u)
						{
							if (num != 3158440362u || !(string_1 == "Зелье Недосягаемости"))
							{
								goto IL_12bc;
							}
						}
						else if (!(string_1 == "Превосходное Зелье Колкости"))
						{
							goto IL_12bc;
						}
						goto IL_12d1;
					}
					if (num != 3198464074u)
					{
						if (num == 3211767803u && string_1 == "Ледяной эликсир II")
						{
							goto IL_125c;
						}
					}
					else if (string_1 == "Секретное Зелье")
					{
						goto IL_12d1;
					}
				}
				else if (num <= 3293993799u)
				{
					if (num != 3255221338u)
					{
						if (num == 3293993799u && string_1 == "Зелье Кровожадности")
						{
							goto IL_125c;
						}
					}
					else if (string_1 == "Превосходное Зелье Панциря")
					{
						goto IL_12d1;
					}
				}
				else if (num != 3344054448u)
				{
					if (num == 3486881711u && string_1 == "Зелье Огненного Ореола")
					{
						goto IL_12d1;
					}
				}
				else if (string_1 == "Ледяной эликсир I")
				{
					goto IL_125c;
				}
			}
			else if (num <= 3526479763u)
			{
				if (num <= 3519672240u)
				{
					if (num != 3500561370u)
					{
						if (num != 3519672240u || !(string_1 == "Зелье Панциря"))
						{
							goto IL_12bc;
						}
					}
					else if (!(string_1 == "Зелье Стойкости"))
					{
						goto IL_12bc;
					}
					goto IL_12d1;
				}
				if (num != 3522492755u)
				{
					if (num == 3526479763u && string_1 == "Приманку Для Ботов")
					{
						goto IL_125c;
					}
				}
				else if (string_1 == "i_svi_001.gif")
				{
					return smethod_52(string_0);
				}
			}
			else if (num <= 3635257885u)
			{
				if (num != 3606681547u)
				{
					if (num == 3635257885u && string_1 == "Зелье Колкости")
					{
						goto IL_12d1;
					}
				}
				else if (string_1 == "Свиток Слеза Создателя")
				{
					goto IL_125c;
				}
			}
			else if (num != 3684938870u)
			{
				if (num != 3689896899u)
				{
					if (num == 3712381031u && string_1 == "i_w28_86.gif")
					{
						return smethod_49(string_0);
					}
				}
				else if (string_1 == "Рыбные палочки")
				{
					goto IL_12a8;
				}
			}
			else if (string_1 == "Жихорийский шнапс")
			{
				goto IL_12a8;
			}
		}
		else if (num <= 4043399998u)
		{
			if (num <= 3843666607u)
			{
				if (num <= 3727919101u)
				{
					if (num != 3723118295u)
					{
						if (num == 3727919101u && string_1 == "Зелье Сильной Спины")
						{
							goto IL_12d1;
						}
					}
					else if (string_1 == "vsergard")
					{
						return smethod_50(string_0);
					}
				}
				else if (num != 3753773554u)
				{
					if (num == 3843666607u && string_1 == "Зелье Гения")
					{
						goto IL_12d1;
					}
				}
				else if (string_1 == "i_w28_23.gif")
				{
					return smethod_58(string_0);
				}
			}
			else if (num <= 3940853091u)
			{
				if (num != 3900713708u)
				{
					if (num == 3940853091u && string_1 == "Зелье Человек-гора")
					{
						goto IL_12d1;
					}
				}
				else if (string_1 == "Рыбная похлебка")
				{
					goto IL_12a8;
				}
			}
			else if (num != 4039845384u)
			{
				if (num == 4043399998u && string_1 == "Фаршированная форель")
				{
					goto IL_12a8;
				}
			}
			else if (string_1 == "Зелье Силы")
			{
				goto IL_12d1;
			}
		}
		else if (num <= 4118987183u)
		{
			if (num <= 4096147657u)
			{
				if (num != 4066425915u)
				{
					if (num != 4096147657u || !(string_1 == "Превосходное Зелье Жизни"))
					{
						goto IL_12bc;
					}
				}
				else if (!(string_1 == "Превосходное Зелье Ловкости"))
				{
					goto IL_12bc;
				}
				goto IL_12d1;
			}
			if (num != 4101162127u)
			{
				if (num == 4118987183u && string_1 == "Зелье Метаболизма")
				{
					goto IL_12d1;
				}
			}
			else if (string_1 == "Фейданский бренди")
			{
				goto IL_12a8;
			}
		}
		else if (num <= 4135735906u)
		{
			if (num != 4123533089u)
			{
				if (num == 4135735906u && string_1 == "Эликсир Мгновенного Исцеления")
				{
					goto IL_125c;
				}
			}
			else if (string_1 == "Зелье Ловкости")
			{
				goto IL_12d1;
			}
		}
		else if (num != 4208435379u)
		{
			if (num != 4266458751u)
			{
				if (num == 4276465462u && string_1 == "Рыбное филе по-Альвийски")
				{
					goto IL_12a8;
				}
			}
			else if (string_1 == "Бифштекс от элементаля")
			{
				goto IL_12a8;
			}
		}
		else if (string_1 == "Превосходное Зелье Боевой Славы")
		{
			goto IL_12d1;
		}
		goto IL_12bc;
		IL_05da:
		return smethod_45(string_0);
		IL_12d1:
		return smethod_47(string_0);
		IL_12a8:
		return smethod_62(string_0);
		IL_12bc:
		throw new NotImplementedException("AppVars.FastId = " + Class72.string_29);
		IL_125c:
		return smethod_61(string_0);
	}

	private static string smethod_45(string string_0)
	{
		int num = 0;
		while (num != -1)
		{
			num = string_0.IndexOf("abil_svitok(", num, StringComparison.OrdinalIgnoreCase);
			if (num == -1)
			{
				break;
			}
			num += 12;
			int num2 = string_0.IndexOf(")", num, StringComparison.OrdinalIgnoreCase);
			if (num2 == -1)
			{
				continue;
			}
			string text = string_0.Substring(num, num2 - num);
			if (string.IsNullOrEmpty(text))
			{
				continue;
			}
			string[] array = text.Split(',');
			if (array.Length >= 5)
			{
				string text2 = array[0].Trim('\'');
				string text3 = array[1].Trim('\'');
				string text4 = array[2].Trim('\'');
				string text5 = array[3].Trim('\'');
				string text6 = array[4].Trim('\'');
				if (text5.Equals(Class72.string_29))
				{
					return string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(Class7.smethod_1() + " Применяем " + Class72.string_29 + " на " + Class72.string_30 + "...", "<form action=main.php method=POST name=ff>"), "<input name=post_id type=hidden value=\"44\">"), "<input name=uid type=hidden value=\"", text2, "\">"), "<input name=mid type=hidden value=\"", text3, "\">"), "<input name=curs type=hidden value=\"", text4, "\">"), "<input name=vcode type=hidden value=\"", text6, "\">"), "<input name=fnick type=hidden value=\"", Class72.string_30, "\">"), "</form><script language=\"JavaScript\">document.ff.submit();</script></body></html>");
				}
			}
		}
		return null;
	}

	private static string smethod_46(string string_0)
	{
		int num = 0;
		while (num != -1)
		{
			num = string_0.IndexOf("w28_form(", num, StringComparison.OrdinalIgnoreCase);
			if (num == -1)
			{
				break;
			}
			num += 9;
			int num2 = string_0.IndexOf(")", num, StringComparison.OrdinalIgnoreCase);
			if (num2 == -1)
			{
				continue;
			}
			string text = string_0.Substring(num, num2 - num);
			if (string.IsNullOrEmpty(text))
			{
				continue;
			}
			string[] array = text.Split(',');
			if (array.Length >= 4)
			{
				string text2 = array[0].Trim('\'');
				string text3 = array[1].Trim('\'');
				string text4 = array[2].Trim('\'');
				string text5 = array[3].Trim('\'');
				if (text4.Equals("22"))
				{
					int num3 = ((Class72.int_18 != 0) ? Class72.int_18 : (Class89.smethod_0(12) + 1));
					Class72.int_18 = 0;
					return string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(Class7.smethod_1() + "Используем телепорт...", "<form action=main.php method=POST name=ff>"), "<input name=post_id type=hidden value=\"25\">"), "<input name=vcode type=hidden value=\"", text2, "\">"), "<input name=wuid type=hidden value=\"", text3, "\">"), "<input name=wsubid type=hidden value=\"", text4, "\">"), "<input name=wsolid type=hidden value=\"", text5, "\">"), "<input name=wtelid type=hidden value=\"", num3.ToString(), "\">"), "</form><script language=\"JavaScript\">document.ff.submit();</script></body></html>");
				}
			}
		}
		return null;
	}

	private static string smethod_47(string string_0)
	{
		int num = string_0.IndexOf("'" + Class72.string_29 + "'", StringComparison.CurrentCultureIgnoreCase);
		if (num != -1)
		{
			int num2 = string_0.LastIndexOf('<', num);
			if (num2 != -1)
			{
				num2++;
				int num3 = string_0.IndexOf('>', num);
				if (num3 != -1)
				{
					string text = string_0.Substring(num2, num3 - num2);
					if (text.IndexOf("magicreform(", StringComparison.CurrentCultureIgnoreCase) != -1)
					{
						text = Class12.smethod_1(text, "magicreform('", "')");
						if (!string.IsNullOrEmpty(text))
						{
							string[] array = text.Split('\'');
							if (array.Length >= 7)
							{
								string text2 = array[0];
								string text3 = array[6];
								string text4 = Class7.smethod_1() + " Используем " + Class72.string_29 + "...";
								text4 += "<form action=main.php method=POST name=ff>";
								text4 += "<input name=magicrestart type=hidden value=\"1\">";
								text4 = text4 + "<input name=magicreuid type=hidden value=\"" + text2 + "\">";
								text4 = text4 + "<input name=vcode type=hidden value=\"" + text3 + "\">";
								text4 += "<input name=post_id type=hidden value=\"46\">";
								text4 = text4 + "<input name=fornickname type=hidden value=\"" + Class72.string_30 + "\">";
								text4 += "</form><script language=\"JavaScript\">document.ff.submit();</script></body></html>";
								try
								{
									if (Class72.formMain_0 != null)
									{
										Class72.formMain_0.BeginInvoke(new Delegate34(Class72.formMain_0.method_102), Class72.string_30, Class72.string_29);
									}
								}
								catch (InvalidOperationException)
								{
								}
								return text4;
							}
						}
					}
				}
			}
		}
		return null;
	}

	private static string smethod_48(string string_0)
	{
		int num = string_0.IndexOf("'Свиток Искажающего Тумана'", StringComparison.OrdinalIgnoreCase);
		if (num != -1)
		{
			int num2 = string_0.LastIndexOf('<', num);
			if (num2 != -1)
			{
				num2++;
				int num3 = string_0.IndexOf('>', num);
				if (num3 != -1)
				{
					string text = string_0.Substring(num2, num3 - num2);
					if (text.IndexOf("abil_svitok(", StringComparison.Ordinal) != -1)
					{
						text = Class12.smethod_1(text, "abil_svitok('", "')");
						if (!string.IsNullOrEmpty(text))
						{
							string[] array = text.Split('\'');
							if (array.Length >= 9)
							{
								string text2 = array[0];
								string text3 = array[2];
								string text4 = array[4];
								string text5 = array[8];
								return string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(Class7.smethod_1() + " Используем Свиток Искажающего Тумана...", "<form action=main.php method=POST name=ff>"), "<input name=post_id type=hidden value=\"44\">"), "<input name=uid type=hidden value=\"", text2, "\">"), "<input name=mid type=hidden value=\"", text3, "\">"), "<input name=curs type=hidden value=\"", text4, "\">"), "<input name=vcode type=hidden value=\"", text5, "\">"), "<input name=fnick type=hidden value=\"", Class72.string_30, "\">"), "</form><script language=\"JavaScript\">document.ff.submit();</script></body></html>");
							}
						}
					}
				}
			}
		}
		return null;
	}

	private static string smethod_49(string string_0)
	{
		int num = 0;
		while (num != -1)
		{
			num = string_0.IndexOf("w28_form(", num, StringComparison.OrdinalIgnoreCase);
			if (num == -1)
			{
				break;
			}
			num += 9;
			int num2 = string_0.IndexOf(")", num, StringComparison.OrdinalIgnoreCase);
			if (num2 == -1)
			{
				continue;
			}
			string text = string_0.Substring(num, num2 - num);
			if (string.IsNullOrEmpty(text))
			{
				continue;
			}
			string[] array = text.Split(',');
			if (array.Length >= 4)
			{
				string text2 = array[0].Trim('\'');
				string text3 = array[1].Trim('\'');
				string text4 = array[2].Trim('\'');
				string text5 = array[3].Trim('\'');
				if (text4.Equals("86"))
				{
					return string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(Class7.smethod_1() + " Применяем Портал на " + Class72.string_30 + "...", "<form action=main.php method=POST name=ff>"), "<input name=post_id type=hidden value=\"25\">"), "<input name=vcode type=hidden value=\"", text2, "\">"), "<input name=wuid type=hidden value=\"", text3, "\">"), "<input name=wsubid type=hidden value=\"", text4, "\">"), "<input name=wsolid type=hidden value=\"", text5, "\">"), "<input name=pnick type=hidden value=\"", Class72.string_30, "\">"), "</form><script language=\"JavaScript\">document.ff.submit();</script></body></html>");
				}
			}
		}
		return null;
	}

	private static string smethod_50(string string_0)
	{
		int num = 0;
		while (num != -1)
		{
			num = string_0.IndexOf("w28_form(", num, StringComparison.OrdinalIgnoreCase);
			if (num == -1)
			{
				break;
			}
			num += 9;
			int num2 = string_0.IndexOf(")", num, StringComparison.OrdinalIgnoreCase);
			if (num2 == -1)
			{
				continue;
			}
			string text = string_0.Substring(num, num2 - num);
			if (string.IsNullOrEmpty(text))
			{
				continue;
			}
			string[] array = text.Split(',');
			if (array.Length >= 4)
			{
				string text2 = array[0].Trim('\'');
				string text3 = array[1].Trim('\'');
				string text4 = array[2].Trim('\'');
				string text5 = array[3].Trim('\'');
				if (text4.Equals("83"))
				{
					return string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(Class7.smethod_1() + " Применяем Проклятие Всергарда на " + Class72.string_30 + "...", "<form action=main.php method=POST name=ff>"), "<input name=post_id type=hidden value=\"25\">"), "<input name=vcode type=hidden value=\"", text2, "\">"), "<input name=wuid type=hidden value=\"", text3, "\">"), "<input name=wsubid type=hidden value=\"", text4, "\">"), "<input name=wsolid type=hidden value=\"", text5, "\">"), "<input name=pnick type=hidden value=\"", Class72.string_30, "\">"), "</form><script language=\"JavaScript\">document.ff.submit();</script></body></html>");
				}
			}
		}
		return null;
	}

	private static string smethod_51(string string_0)
	{
		int num = 0;
		while (num != -1)
		{
			num = string_0.IndexOf("w28_form(", num, StringComparison.OrdinalIgnoreCase);
			if (num == -1)
			{
				break;
			}
			num += 9;
			int num2 = string_0.IndexOf(")", num, StringComparison.OrdinalIgnoreCase);
			if (num2 == -1)
			{
				continue;
			}
			string text = string_0.Substring(num, num2 - num);
			if (string.IsNullOrEmpty(text))
			{
				continue;
			}
			string[] array = text.Split(',');
			if (array.Length >= 4)
			{
				string text2 = array[0].Trim('\'');
				string text3 = array[1].Trim('\'');
				string text4 = array[2].Trim('\'');
				string text5 = array[3].Trim('\'');
				if (text4.Equals("27"))
				{
					return string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(Class7.smethod_1() + " Применяем свиток защиты к " + Class72.string_30 + "...", "<form action=main.php method=POST name=ff>"), "<input name=post_id type=hidden value=\"25\">"), "<input name=vcode type=hidden value=\"", text2, "\">"), "<input name=wuid type=hidden value=\"", text3, "\">"), "<input name=wsubid type=hidden value=\"", text4, "\">"), "<input name=wsolid type=hidden value=\"", text5, "\">"), "<input name=pnick type=hidden value=\"", Class72.string_30, "\">"), "</form><script language=\"JavaScript\">document.ff.submit();</script></body></html>");
				}
			}
		}
		return null;
	}

	private static string smethod_52(string string_0)
	{
		int num = 0;
		while (num != -1)
		{
			num = string_0.IndexOf("w28_form(", num, StringComparison.OrdinalIgnoreCase);
			if (num == -1)
			{
				break;
			}
			num += 9;
			int num2 = string_0.IndexOf(")", num, StringComparison.OrdinalIgnoreCase);
			if (num2 == -1)
			{
				continue;
			}
			string text = string_0.Substring(num, num2 - num);
			if (string.IsNullOrEmpty(text))
			{
				continue;
			}
			string[] array = text.Split(',');
			if (array.Length >= 4)
			{
				string text2 = array[0].Trim('\'');
				string text3 = array[1].Trim('\'');
				string text4 = array[2].Trim('\'');
				string text5 = array[3].Trim('\'');
				if (text4.Equals("1") || text4.Equals("2") || text4.Equals("3") || text4.Equals("4"))
				{
					return string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(Class7.smethod_1() + " Используем обычную нападалку на " + Class72.string_30 + "...", "<form action=main.php method=POST name=ff>"), "<input name=post_id type=hidden value=\"8\">"), "<input name=vcode type=hidden value=\"", text2, "\">"), "<input name=wuid type=hidden value=\"", text3, "\">"), "<input name=wsubid type=hidden value=\"", text4, "\">"), "<input name=wsolid type=hidden value=\"", text5, "\">"), "<input name=pnick type=hidden value=\"", Class72.string_30, "\">"), "</form><script language=\"JavaScript\">document.ff.submit();</script></body></html>");
				}
			}
		}
		smethod_63("Нападалка не найдена");
		return null;
	}

	private static string smethod_53(string string_0)
	{
		int num = 0;
		while (num != -1)
		{
			num = string_0.IndexOf("w28_form(", num, StringComparison.OrdinalIgnoreCase);
			if (num == -1)
			{
				break;
			}
			num += 9;
			int num2 = string_0.IndexOf(")", num, StringComparison.OrdinalIgnoreCase);
			if (num2 == -1)
			{
				continue;
			}
			string text = string_0.Substring(num, num2 - num);
			if (string.IsNullOrEmpty(text))
			{
				continue;
			}
			string[] array = text.Split(',');
			if (array.Length >= 4)
			{
				string text2 = array[0].Trim('\'');
				string text3 = array[1].Trim('\'');
				string text4 = array[2].Trim('\'');
				string text5 = array[3].Trim('\'');
				if (text4.Equals("5") || text4.Equals("6") || text4.Equals("7") || text4.Equals("8"))
				{
					return string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(Class7.smethod_1() + " Используем кровавую нападалку на " + Class72.string_30 + "...", "<form action=main.php method=POST name=ff>"), "<input name=post_id type=hidden value=\"8\">"), "<input name=vcode type=hidden value=\"", text2, "\">"), "<input name=wuid type=hidden value=\"", text3, "\">"), "<input name=wsubid type=hidden value=\"", text4, "\">"), "<input name=wsolid type=hidden value=\"", text5, "\">"), "<input name=pnick type=hidden value=\"", Class72.string_30, "\">"), "</form><script language=\"JavaScript\">document.ff.submit();</script></body></html>");
				}
			}
		}
		smethod_63("Кровавая нападалка не найдена");
		return null;
	}

	private static string smethod_54(string string_0)
	{
		int num = 0;
		while (num != -1)
		{
			num = string_0.IndexOf("w28_form(", num, StringComparison.OrdinalIgnoreCase);
			if (num == -1)
			{
				break;
			}
			num += 9;
			int num2 = string_0.IndexOf(")", num, StringComparison.OrdinalIgnoreCase);
			if (num2 == -1)
			{
				continue;
			}
			string text = string_0.Substring(num, num2 - num);
			if (string.IsNullOrEmpty(text))
			{
				continue;
			}
			string[] array = text.Split(',');
			if (array.Length >= 4)
			{
				string text2 = array[0].Trim('\'');
				string text3 = array[1].Trim('\'');
				string text4 = array[2].Trim('\'');
				string text5 = array[3].Trim('\'');
				if (text4.Equals("26"))
				{
					return string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(Class7.smethod_1() + " Используем боевую нападалку на " + Class72.string_30 + "...", "<form action=main.php method=POST name=ff>"), "<input name=post_id type=hidden value=\"8\">"), "<input name=vcode type=hidden value=\"", text2, "\">"), "<input name=wuid type=hidden value=\"", text3, "\">"), "<input name=wsubid type=hidden value=\"", text4, "\">"), "<input name=wsolid type=hidden value=\"", text5, "\">"), "<input name=pnick type=hidden value=\"", Class72.string_30, "\">"), "</form><script language=\"JavaScript\">document.ff.submit();</script></body></html>");
				}
			}
		}
		smethod_63("Боевая нападалка не найдена");
		return null;
	}

	private static string smethod_55(string string_0)
	{
		int num = 0;
		while (num != -1)
		{
			num = string_0.IndexOf("w28_form(", num, StringComparison.OrdinalIgnoreCase);
			if (num == -1)
			{
				break;
			}
			num += 9;
			int num2 = string_0.IndexOf(")", num, StringComparison.OrdinalIgnoreCase);
			if (num2 == -1)
			{
				continue;
			}
			string text = string_0.Substring(num, num2 - num);
			if (string.IsNullOrEmpty(text))
			{
				continue;
			}
			string[] array = text.Split(',');
			if (array.Length >= 4)
			{
				string text2 = array[0].Trim('\'');
				string text3 = array[1].Trim('\'');
				string text4 = array[2].Trim('\'');
				string text5 = array[3].Trim('\'');
				if (text4.Equals("29"))
				{
					return string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(Class7.smethod_1() + " Используем закрытую боевую нападалку на " + Class72.string_30 + "...", "<form action=main.php method=POST name=ff>"), "<input name=post_id type=hidden value=\"8\">"), "<input name=vcode type=hidden value=\"", text2, "\">"), "<input name=wuid type=hidden value=\"", text3, "\">"), "<input name=wsubid type=hidden value=\"", text4, "\">"), "<input name=wsolid type=hidden value=\"", text5, "\">"), "<input name=pnick type=hidden value=\"", Class72.string_30, "\">"), "</form><script language=\"JavaScript\">document.ff.submit();</script></body></html>");
				}
			}
		}
		smethod_63("Закрытая боевая нападалка не найдена");
		return null;
	}

	private static string smethod_56(string string_0)
	{
		int num = 0;
		while (num != -1)
		{
			num = string_0.IndexOf("w28_form(", num, StringComparison.OrdinalIgnoreCase);
			if (num == -1)
			{
				break;
			}
			num += 9;
			int num2 = string_0.IndexOf(")", num, StringComparison.OrdinalIgnoreCase);
			if (num2 == -1)
			{
				continue;
			}
			string text = string_0.Substring(num, num2 - num);
			if (string.IsNullOrEmpty(text))
			{
				continue;
			}
			string[] array = text.Split(',');
			if (array.Length >= 4)
			{
				string text2 = array[0].Trim('\'');
				string text3 = array[1].Trim('\'');
				string text4 = array[2].Trim('\'');
				string text5 = array[3].Trim('\'');
				if (text4.Equals("24"))
				{
					return string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(Class7.smethod_1() + " Используем кулачку на " + Class72.string_30 + "...", "<form action=main.php method=POST name=ff>"), "<input name=post_id type=hidden value=\"8\">"), "<input name=vcode type=hidden value=\"", text2, "\">"), "<input name=wuid type=hidden value=\"", text3, "\">"), "<input name=wsubid type=hidden value=\"", text4, "\">"), "<input name=wsolid type=hidden value=\"", text5, "\">"), "<input name=pnick type=hidden value=\"", Class72.string_30, "\">"), "</form><script language=\"JavaScript\">document.ff.submit();</script></body></html>");
				}
			}
		}
		smethod_63("Кулачка не найдена");
		return null;
	}

	private static string smethod_57(string string_0)
	{
		int num = 0;
		while (num != -1)
		{
			num = string_0.IndexOf("w28_form(", num, StringComparison.OrdinalIgnoreCase);
			if (num == -1)
			{
				break;
			}
			num += 9;
			int num2 = string_0.IndexOf(")", num, StringComparison.OrdinalIgnoreCase);
			if (num2 == -1)
			{
				continue;
			}
			string text = string_0.Substring(num, num2 - num);
			if (string.IsNullOrEmpty(text))
			{
				continue;
			}
			string[] array = text.Split(',');
			if (array.Length >= 4)
			{
				string text2 = array[0].Trim('\'');
				string text3 = array[1].Trim('\'');
				string text4 = array[2].Trim('\'');
				string text5 = array[3].Trim('\'');
				if (text4.Equals("25"))
				{
					return string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(Class7.smethod_1() + " Используем закрытую кулачку на " + Class72.string_30 + "...", "<form action=main.php method=POST name=ff>"), "<input name=post_id type=hidden value=\"8\">"), "<input name=vcode type=hidden value=\"", text2, "\">"), "<input name=wuid type=hidden value=\"", text3, "\">"), "<input name=wsubid type=hidden value=\"", text4, "\">"), "<input name=wsolid type=hidden value=\"", text5, "\">"), "<input name=pnick type=hidden value=\"", Class72.string_30, "\">"), "</form><script language=\"JavaScript\">document.ff.submit();</script></body></html>");
				}
			}
		}
		smethod_63("Закрытая кулачка не найдена");
		return null;
	}

	private static string smethod_58(string string_0)
	{
		int num = 0;
		while (num != -1)
		{
			num = string_0.IndexOf("w28_form(", num, StringComparison.OrdinalIgnoreCase);
			if (num == -1)
			{
				break;
			}
			num += 9;
			int num2 = string_0.IndexOf(")", num, StringComparison.OrdinalIgnoreCase);
			if (num2 == -1)
			{
				continue;
			}
			string text = string_0.Substring(num, num2 - num);
			if (string.IsNullOrEmpty(text))
			{
				continue;
			}
			string[] array = text.Split(',');
			if (array.Length >= 4)
			{
				string text2 = array[0].Trim('\'');
				string text3 = array[1].Trim('\'');
				string text4 = array[2].Trim('\'');
				string text5 = array[3].Trim('\'');
				if (text4.Equals("23"))
				{
					return string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(Class7.smethod_1() + " Применяем свиток рассеивания невидимости на себя...", "<form action=main.php method=POST name=ff>"), "<input name=post_id type=hidden value=\"25\">"), "<input name=vcode type=hidden value=\"", text2, "\">"), "<input name=wuid type=hidden value=\"", text3, "\">"), "<input name=wsubid type=hidden value=\"", text4, "\">"), "<input name=wsolid type=hidden value=\"", text5, "\">"), "</form><script language=\"JavaScript\">document.ff.submit();</script></body></html>");
				}
			}
		}
		smethod_63("Свиток рассеивания невидимости не найден");
		return null;
	}

	private static string smethod_59(string string_0)
	{
		int num = 0;
		while (num != -1)
		{
			num = string_0.IndexOf("w28_form(", num, StringComparison.OrdinalIgnoreCase);
			if (num == -1)
			{
				break;
			}
			num += 9;
			int num2 = string_0.IndexOf(")", num, StringComparison.OrdinalIgnoreCase);
			if (num2 == -1)
			{
				continue;
			}
			string text = string_0.Substring(num, num2 - num);
			if (string.IsNullOrEmpty(text))
			{
				continue;
			}
			string[] array = text.Split(',');
			if (array.Length >= 4)
			{
				string text2 = array[0].Trim('\'');
				string text3 = array[1].Trim('\'');
				string text4 = array[2].Trim('\'');
				string text5 = array[3].Trim('\'');
				if (text4.Equals("28"))
				{
					return string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(Class7.smethod_1() + " Применяем свиток обнаружения...", "<form action=main.php method=POST name=ff>"), "<input name=post_id type=hidden value=\"25\">"), "<input name=vcode type=hidden value=\"", text2, "\">"), "<input name=wuid type=hidden value=\"", text3, "\">"), "<input name=wsubid type=hidden value=\"", text4, "\">"), "<input name=wsolid type=hidden value=\"", text5, "\">"), "</form><script language=\"JavaScript\">document.ff.submit();</script></body></html>");
				}
			}
		}
		smethod_63("Свиток обнаружения не найден");
		return null;
	}

	private static string smethod_60(string string_0)
	{
		int num = 0;
		while (num != -1)
		{
			num = string_0.IndexOf("w28_form(", num, StringComparison.OrdinalIgnoreCase);
			if (num == -1)
			{
				break;
			}
			num += 9;
			int num2 = string_0.IndexOf(")", num, StringComparison.OrdinalIgnoreCase);
			if (num2 == -1)
			{
				continue;
			}
			string text = string_0.Substring(num, num2 - num);
			if (string.IsNullOrEmpty(text))
			{
				continue;
			}
			string[] array = text.Split(',');
			if (array.Length >= 4)
			{
				string text2 = array[0].Trim('\'');
				string text3 = array[1].Trim('\'');
				string text4 = array[2].Trim('\'');
				string text5 = array[3].Trim('\'');
				if (text4.Equals("14"))
				{
					return string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(Class7.smethod_1() + " Используем закрытое нападение на " + Class72.string_30 + "...", "<form action=main.php method=POST name=ff>"), "<input name=post_id type=hidden value=\"8\">"), "<input name=vcode type=hidden value=\"", text2, "\">"), "<input name=wuid type=hidden value=\"", text3, "\">"), "<input name=wsubid type=hidden value=\"", text4, "\">"), "<input name=wsolid type=hidden value=\"", text5, "\">"), "<input name=pnick type=hidden value=\"", Class72.string_30, "\">"), "</form><script language=\"JavaScript\">document.ff.submit();</script></body></html>");
				}
			}
		}
		smethod_63("Закрытое нападение не найдено");
		return null;
	}

	private static string smethod_61(string string_0)
	{
		int num = string_0.IndexOf("Использовать " + Class72.string_29 + " сейчас?", StringComparison.CurrentCultureIgnoreCase);
		if (num != -1)
		{
			int num2 = string_0.IndexOf("='", num, StringComparison.Ordinal);
			if (num2 != -1)
			{
				num2 += 2;
				int num3 = string_0.IndexOf("'", num2, StringComparison.Ordinal);
				if (num3 != -1)
				{
					return smethod_10("Используем " + Class72.string_29 + "...", string_0.Substring(num2, num3 - num2));
				}
			}
		}
		return null;
	}

	private static string smethod_62(string string_0)
	{
		int num = string_0.IndexOf("<b> " + Class72.string_29, StringComparison.CurrentCultureIgnoreCase);
		if (num != -1)
		{
			string text = Class12.smethod_1(string_0.Substring(num - 2100, 1500), "Использовать сейчас?')) { location='", "' }");
			if (!string.IsNullOrEmpty(text))
			{
				return smethod_10("Используем " + Class72.string_29 + "...", text);
			}
		}
		return null;
	}

	private static void smethod_63(string string_0)
	{
		if (Class72.formMain_0 != null)
		{
			Class72.formMain_0.method_63("<font color=#FF0000>" + string_0 + " в инвентаре, действие отменено</font>");
		}
	}

	private static string smethod_64(string string_0)
	{
		int[] array = new int[2] { 0, 1 };
		if (Class72.class19_0.method_186() == 1)
		{
			array[0] = 1;
			array[1] = 0;
		}
		for (int i = 0; i < 2; i++)
		{
			switch (array[i])
			{
			case 1:
			{
				int num = string_0.IndexOf("Использовать Эликсир Блаженства сейчас?", StringComparison.CurrentCultureIgnoreCase);
				if (num == -1)
				{
					break;
				}
				int num4 = string_0.IndexOf("='", num, StringComparison.Ordinal);
				if (num4 != -1)
				{
					num4 += 2;
					int num5 = string_0.IndexOf("'", num4, StringComparison.Ordinal);
					if (num5 != -1)
					{
						return smethod_10("Используем Эликсир Блаженства...", string_0.Substring(num4, num5 - num4));
					}
				}
				break;
			}
			case 0:
			{
				if (!Class72.bool_46)
				{
					break;
				}
				int num = string_0.IndexOf("'Зелье Блаженства'", StringComparison.CurrentCultureIgnoreCase);
				if (num == -1)
				{
					break;
				}
				int num2 = string_0.LastIndexOf('<', num);
				if (num2 == -1)
				{
					break;
				}
				num2++;
				int num3 = string_0.IndexOf('>', num);
				if (num3 == -1)
				{
					break;
				}
				string text = string_0.Substring(num2, num3 - num2);
				if (text.IndexOf("magicreform(", StringComparison.CurrentCultureIgnoreCase) == -1)
				{
					break;
				}
				text = Class12.smethod_1(text, "magicreform('", "')");
				if (!string.IsNullOrEmpty(text))
				{
					string[] array2 = text.Split('\'');
					if (array2.Length >= 7)
					{
						string text2 = array2[0];
						string text3 = array2[6];
						return string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(Class7.smethod_1() + "Используем Зелье Блаженства...", "<form action=main.php method=POST name=ff>"), "<input name=magicrestart type=hidden value=\"1\">"), "<input name=magicreuid type=hidden value=\"", text2, "\">"), "<input name=vcode type=hidden value=\"", text3, "\">"), "<input name=post_id type=hidden value=\"46\">"), "<input name=fornickname type=hidden value=\"", Class72.class19_0.method_30(), "\">"), "</form><script language=\"JavaScript\">document.ff.submit();</script></body></html>");
					}
				}
				break;
			}
			}
		}
		return null;
	}

	private static string smethod_65(string string_0)
	{
		int num = string_0.IndexOf("'Зелье Невидимости'", StringComparison.CurrentCultureIgnoreCase);
		if (num != -1)
		{
			int num2 = string_0.LastIndexOf('<', num);
			if (num2 != -1)
			{
				num2++;
				int num3 = string_0.IndexOf('>', num);
				if (num3 != -1)
				{
					string text = string_0.Substring(num2, num3 - num2);
					if (text.IndexOf("magicreform(", StringComparison.CurrentCultureIgnoreCase) != -1)
					{
						text = Class12.smethod_1(text, "magicreform('", "')");
						if (!string.IsNullOrEmpty(text))
						{
							string[] array = text.Split('\'');
							if (array.Length >= 7)
							{
								string text2 = array[0];
								string text3 = array[6];
								string text4 = Class7.smethod_1() + " Используем Зелье Невидимости...";
								text4 += "<form action=main.php method=POST name=ff>";
								text4 += "<input name=magicrestart type=hidden value=\"1\">";
								text4 = text4 + "<input name=magicreuid type=hidden value=\"" + text2 + "\">";
								text4 = text4 + "<input name=vcode type=hidden value=\"" + text3 + "\">";
								text4 += "<input name=post_id type=hidden value=\"46\">";
								text4 = text4 + "<input name=fornickname type=hidden value=\"" + Class72.class19_0.method_30() + "\">";
								text4 += "</form><script language=\"JavaScript\">document.ff.submit();</script></body></html>";
								try
								{
									if (Class72.formMain_0 != null)
									{
										Class72.formMain_0.BeginInvoke(new Delegate34(Class72.formMain_0.method_102), Class72.class19_0.method_30(), "Зелье Невидимости");
									}
								}
								catch (InvalidOperationException)
								{
								}
								return text4;
							}
						}
					}
				}
			}
		}
		return null;
	}

	private static string smethod_66(string string_0)
	{
		int num = 0;
		while (num != -1)
		{
			num = string_0.IndexOf("w28_form(", num, StringComparison.OrdinalIgnoreCase);
			if (num == -1)
			{
				break;
			}
			num += 9;
			int num2 = string_0.IndexOf(")", num, StringComparison.OrdinalIgnoreCase);
			if (num2 == -1)
			{
				continue;
			}
			string text = string_0.Substring(num, num2 - num);
			if (string.IsNullOrEmpty(text))
			{
				continue;
			}
			string[] array = text.Split(',');
			if (array.Length >= 4)
			{
				string text2 = array[0].Trim('\'');
				string text3 = array[1].Trim('\'');
				string text4 = array[2].Trim('\'');
				string text5 = array[3].Trim('\'');
				if (text4.Equals("9"))
				{
					return string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(Class7.smethod_1() + " Используем свиток невидимости на 4 часа...", "<form action=main.php method=POST name=ff>"), "<input name=post_id type=hidden value=\"25\">"), "<input name=vcode type=hidden value=\"", text2, "\">"), "<input name=wuid type=hidden value=\"", text3, "\">"), "<input name=wsubid type=hidden value=\"", text4, "\">"), "<input name=wsolid type=hidden value=\"", text5, "\">"), "</form><script language=\"JavaScript\">document.ff.submit();</script></body></html>");
				}
			}
		}
		return null;
	}

	private static string smethod_67(string string_0)
	{
		int num = string_0.IndexOf("'Свиток Искажающего Тумана'", StringComparison.OrdinalIgnoreCase);
		if (num != -1)
		{
			int num2 = string_0.LastIndexOf('<', num);
			if (num2 != -1)
			{
				num2++;
				int num3 = string_0.IndexOf('>', num);
				if (num3 != -1)
				{
					string text = string_0.Substring(num2, num3 - num2);
					if (text.IndexOf("abil_svitok(", StringComparison.Ordinal) != -1)
					{
						text = Class12.smethod_1(text, "abil_svitok('", "')");
						if (!string.IsNullOrEmpty(text))
						{
							string[] array = text.Split('\'');
							if (array.Length >= 9)
							{
								string text2 = array[0];
								string text3 = array[2];
								string text4 = array[4];
								string text5 = array[8];
								return string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(Class7.smethod_1() + " Используем Свиток Искажающего Тумана...", "<form action=main.php method=POST name=ff>"), "<input name=post_id type=hidden value=\"44\">"), "<input name=uid type=hidden value=\"", text2, "\">"), "<input name=mid type=hidden value=\"", text3, "\">"), "<input name=curs type=hidden value=\"", text4, "\">"), "<input name=vcode type=hidden value=\"", text5, "\">"), "<input name=fnick type=hidden value=\"", Class72.class19_0.method_30(), "\">"), "</form><script language=\"JavaScript\">document.ff.submit();</script></body></html>");
							}
						}
					}
				}
			}
		}
		return null;
	}

	private static string smethod_68(string string_0)
	{
		int num = string_0.IndexOf("[\"fig\",\"Напасть\",\"", StringComparison.OrdinalIgnoreCase);
		if (num != -1)
		{
			num += 18;
			int num2 = string_0.IndexOf('"', num);
			if (num2 != -1)
			{
				string text = string_0.Substring(num, num2 - num);
				return string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(Class7.smethod_1() + " Используем тотемное нападение...", "<form action=main.php method=POST name=ff>"), "<input name=post_id type=hidden value=\"8\">"), "<input name=vcode type=hidden value=\"", text, "\">"), "<input name=pnick type=hidden value=\"", Class72.string_30, "\">"), "</form><script language=\"JavaScript\">document.ff.submit();</script></body></html>");
			}
		}
		return null;
	}

	private static string smethod_69(string string_0, bool bool_0)
	{
		string value = (bool_0 ? "subid=6" : "subid=7");
		if (string_0.IndexOf(value) != -1)
		{
			string value2 = "Использовать Свиток Телепорта сейчас?";
			while (true)
			{
				int num = string_0.IndexOf(value2, StringComparison.CurrentCultureIgnoreCase);
				if (num == -1)
				{
					break;
				}
				int num2 = string_0.IndexOf("='", num, StringComparison.Ordinal);
				if (num2 == -1)
				{
					break;
				}
				num2 += 2;
				int num3 = string_0.IndexOf("'", num2, StringComparison.Ordinal);
				if (num3 == -1)
				{
					break;
				}
				string text = string_0.Substring(num2, num3 - num2);
				string_0 = string_0.Substring(num3);
				if (text.Contains(value))
				{
					return smethod_10("Используем свиток телепорта...", text);
				}
			}
		}
		return null;
	}

	private static string smethod_70(string string_0)
	{
		int num = 0;
		while (num != -1)
		{
			num = string_0.IndexOf("w28_form(", num, StringComparison.OrdinalIgnoreCase);
			if (num == -1)
			{
				break;
			}
			num += 9;
			int num2 = string_0.IndexOf(")", num, StringComparison.OrdinalIgnoreCase);
			if (num2 == -1)
			{
				continue;
			}
			string text = string_0.Substring(num, num2 - num);
			if (string.IsNullOrEmpty(text))
			{
				continue;
			}
			string[] array = text.Split(',');
			if (array.Length >= 4)
			{
				string text2 = array[0].Trim('\'');
				string text3 = array[1].Trim('\'');
				string text4 = array[2].Trim('\'');
				string text5 = array[3].Trim('\'');
				if (text4.Equals("167"))
				{
					return string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(Class7.smethod_1() + " Применяем Призыв Импа-вредителя на " + Class72.string_30 + "...", "<form action=main.php method=POST name=ff>"), "<input name=post_id type=hidden value=\"25\">"), "<input name=vcode type=hidden value=\"", text2, "\">"), "<input name=wuid type=hidden value=\"", text3, "\">"), "<input name=wsubid type=hidden value=\"", text4, "\">"), "<input name=wsolid type=hidden value=\"", text5, "\">"), "<input name=pnick type=hidden value=\"", Class72.string_30, "\">"), "</form><script language=\"JavaScript\">document.ff.submit();</script></body></html>");
				}
			}
		}
		return null;
	}

	private static string smethod_71(string string_0)
	{
		if (string_0 == null)
		{
			throw new ArgumentNullException("htmlFight");
		}
		LezFight lezFight = new LezFight(string_0);
		if (!lezFight.IsValid)
		{
			return Class72.smethod_16();
		}
		if (lezFight.IsWaitingForNextTurn && Class72.smethod_136())
		{
			return lezFight.Frame;
		}
		if (Class72.class19_0.bool_48)
		{
			if (lezFight.IsBoi)
			{
				if (!lezFight.DoStop && !lezFight.IsLowHp && !lezFight.IsLowMa && !lezFight.DoExit)
				{
					return lezFight.Frame;
				}
				if ((lezFight.DoStop && lezFight.FoeGroup.DoExit) || lezFight.DoExit)
				{
					try
					{
						if (Class72.formMain_0 != null)
						{
							Class72.formMain_0.BeginInvoke(new Delegate36(Class72.formMain_0.method_42), "Выход из боя (" + lezFight.FoeName + ")");
						}
					}
					catch (InvalidOperationException)
					{
					}
				}
				if (Class72.smethod_18() != (Enum4)3)
				{
					try
					{
						StringBuilder stringBuilder = new StringBuilder();
						if (lezFight.IsLowHp)
						{
							stringBuilder.AppendFormat($"Здоровье упало ниже {lezFight.FoeGroup.StopLowHp}%");
						}
						else if (lezFight.IsLowMa)
						{
							stringBuilder.AppendFormat($"Мана упала ниже {lezFight.FoeGroup.StopLowMa}%");
						}
						else
						{
							stringBuilder.AppendFormat("Опасный противник.");
						}
						stringBuilder.AppendFormat($" Группа <b>\"{lezFight.FoeGroup}\"</b>. Бой остановлен.");
						if (Class72.formMain_0 != null)
						{
							Class72.formMain_0.BeginInvoke(new Delegate36(Class72.formMain_0.method_62), stringBuilder.ToString());
						}
					}
					catch (InvalidOperationException)
					{
					}
					Class72.smethod_19((Enum4)3);
					if (!lezFight.LogBoi.Equals(Class72.class19_0.struct13_0.string_0, StringComparison.Ordinal) || (lezFight.LogBoi.Equals(Class72.class19_0.struct13_0.string_0, StringComparison.Ordinal) && DateTime.Now.Ticks > Class72.class19_0.struct13_0.long_0))
					{
						Class72.class19_0.struct13_0.string_0 = lezFight.LogBoi;
						Class72.class19_0.struct13_0.long_0 = DateTime.Now.Add(new TimeSpan(0, 15, 0)).Ticks;
					}
				}
			}
			else if (Class72.smethod_18() != (Enum4)2)
			{
				if (Class72.smethod_18() == (Enum4)3)
				{
					Class72.class19_0.struct13_0.long_0 = 0L;
					Class72.class19_0.struct13_0.string_0 = string.Empty;
					Class72.smethod_19((Enum4)1);
				}
				long num = lezFight.CalcRestoreAfterBoi();
				if (num >= 60L)
				{
					Class72.smethod_19((Enum4)2);
					if (!lezFight.LogBoi.Equals(Class72.class19_0.struct13_0.string_0, StringComparison.Ordinal) || (lezFight.LogBoi.Equals(Class72.class19_0.struct13_0.string_0, StringComparison.Ordinal) && DateTime.Now.Ticks > Class72.class19_0.struct13_0.long_0))
					{
						Class72.class19_0.struct13_0.string_0 = lezFight.LogBoi;
						Class72.class19_0.struct13_0.long_0 = num;
					}
				}
				else
				{
					Class72.class19_0.struct13_0.long_0 = 0L;
					Class72.class19_0.struct13_0.string_0 = string.Empty;
					Class72.smethod_19((Enum4)1);
					if (!string.IsNullOrEmpty(Class72.string_0) && Class72.string_0.IndexOf("????", StringComparison.Ordinal) == -1)
					{
						string string_1 = Class72.string_0;
						Class72.string_0 = string.Empty;
						return smethod_10("Завершение боя", string_1);
					}
				}
			}
			else if (!lezFight.LogBoi.Equals(Class72.class19_0.struct13_0.string_0, StringComparison.Ordinal) || (lezFight.LogBoi.Equals(Class72.class19_0.struct13_0.string_0, StringComparison.Ordinal) && DateTime.Now.Ticks > Class72.class19_0.struct13_0.long_0))
			{
				Class72.class19_0.struct13_0.long_0 = 0L;
				Class72.class19_0.struct13_0.string_0 = string.Empty;
				Class72.smethod_19((Enum4)1);
				if (!string.IsNullOrEmpty(Class72.string_0))
				{
					string string_2 = Class72.string_0;
					Class72.string_0 = string.Empty;
					return smethod_10("Завершение боя после лечения", string_2);
				}
			}
		}
		return Class72.smethod_16();
	}

	private static void smethod_72(string string_0, int int_0)
	{
		int num = string_0.IndexOf(')', int_0);
		if (num == -1)
		{
			return;
		}
		string[] array = string_0.Substring(int_0, num - int_0).Split(',');
		if (array.Length == 6)
		{
			if (double.TryParse(array[4], NumberStyles.Any, CultureInfo.InvariantCulture, out var result))
			{
				Class72.class19_0.struct13_0.double_0 = result;
			}
			if (double.TryParse(array[5], NumberStyles.Any, CultureInfo.InvariantCulture, out var result2))
			{
				Class72.class19_0.struct13_0.double_1 = result2;
			}
		}
	}

	private static string smethod_73(string string_0)
	{
		int num = string_0.IndexOf("</b></font></td></tr>", StringComparison.Ordinal);
		if (num == -1)
		{
			return string_0;
		}
		num += 21;
		int length = num;
		list_0.Clear();
		while (string_0.Substring(num, 24).StartsWith("<tr><td bgcolor=#F5F5F5>", StringComparison.Ordinal))
		{
			int num2 = string_0.IndexOf("<td bgcolor=#FCFAF3><img src=http://image.neverlands.ru/1x1.gif width=5 height=1></td></tr></table></td></tr></table></td></tr>", num, StringComparison.Ordinal);
			if (num2 == -1)
			{
				num2 = string_0.IndexOf("<img src=http://image.neverlands.ru/1x1.gif width=1 height=5></td></tr></table></td></tr>", num, StringComparison.Ordinal);
				if (num2 == -1)
				{
					return string_0;
				}
				num2 += 89;
			}
			else
			{
				num2 += 127;
			}
			Class3 @class = new Class3(string_0.Substring(num, num2 - num));
			if ((@class.method_0() == "Портал" || @class.method_0() == "Дверь Измерений") && !string.IsNullOrEmpty(@class.method_2()))
			{
				string[] array = @class.method_2().Split(',');
				short int_ = short.Parse(array[0]);
				short int_2 = short.Parse(array[1]);
				string text = Class77.smethod_26(int_, int_2);
				string text2 = "Название локации не найдено";
				try
				{
					text2 = Class77.smethod_4()[text].Tooltip;
				}
				catch
				{
				}
				@class.string_5 = @class.string_5.Replace(@class.method_0(), @class.method_0() + " (" + text + " " + text2 + ")");
			}
			if (string.IsNullOrEmpty(Class72.string_31) || !Class72.string_31.Equals(@class.method_0(), StringComparison.CurrentCultureIgnoreCase) || !Class72.string_32.Equals(@class.method_4(), StringComparison.CurrentCultureIgnoreCase) || !Class72.bool_26.Equals(@class.bool_0))
			{
				list_0.Add(@class);
				num = num2;
				continue;
			}
			return smethod_10("Выбрасывание предмета <b>&laquo;" + @class.method_0() + "&raquo;</b>...", @class.method_8());
		}
		if (!string.IsNullOrEmpty(Class72.string_31))
		{
			try
			{
				if (Class72.formMain_0 != null)
				{
					Class72.formMain_0.BeginInvoke(new Delegate7(Class72.formMain_0.method_100), "Выбрасывание пачки <b>&laquo;" + Class72.string_31 + "&raquo;</b> завершено.");
				}
			}
			catch (InvalidOperationException)
			{
			}
			Class72.string_31 = string.Empty;
		}
		if (list_0.Count > 1 && Class72.class19_0.method_144())
		{
			for (int i = 0; i < list_0.Count - 1; i++)
			{
				for (int j = i + 1; j < list_0.Count; j++)
				{
					if (list_0[i].CompareTo(list_0[j]) == 0)
					{
						int int_3 = 0;
						int int_4 = 0;
						int int_5 = list_0[i].int_4 + list_0[j].int_4;
						if (Class72.class19_0.method_148())
						{
							int_3 = list_0[i].int_2 + list_0[j].int_0;
							int_4 = list_0[i].int_3 + list_0[j].int_1;
						}
						if (list_0[i].method_13(list_0[j]) > 0 || list_0[i].method_14(list_0[j]) > 0)
						{
							list_0[i] = (Class3)list_0[j].Clone();
						}
						if (Class72.class19_0.method_148())
						{
							list_0[i].int_2 = int_3;
							list_0[i].int_3 = int_4;
						}
						list_0[i].int_4 = int_5;
						list_0.RemoveAt(j);
						j--;
					}
				}
			}
		}
		for (int k = 0; k < list_0.Count; k++)
		{
			list_0[k].method_12();
		}
		list_0.Sort(new Class2());
		StringBuilder stringBuilder = new StringBuilder();
		for (int l = 0; l < list_0.Count; l++)
		{
			stringBuilder.Append(list_0[l].method_11());
		}
		StringBuilder stringBuilder2 = new StringBuilder(string_0.Substring(0, length));
		stringBuilder2.Append(stringBuilder);
		stringBuilder2.Append(string_0.Substring(num));
		return stringBuilder2.ToString();
	}

	private static string smethod_74(string string_0)
	{
		string text = Class12.smethod_1(string_0, "var fight_ty = [", "];");
		if (string.IsNullOrEmpty(text))
		{
			return null;
		}
		List<List<string>> list = Class12.smethod_4(text);
		if (list.Count > 9 && list[9].Count > 1)
		{
			string string_1 = "http://www.neverlands.ru/main.php?get_id=17&type=" + list[9][0] + "&p=" + list[9][1] + "&uid=" + list[9][2] + "&s=" + list[9][3] + "&m=" + list[9][4] + "&vcode=" + list[9][5];
			return smethod_10("Разделка", string_1);
		}
		return null;
	}

	private static string smethod_75(string string_0)
	{
		string text = Class12.smethod_1(string_0, "var fight_ty = [", "];");
		if (string.IsNullOrEmpty(text))
		{
			return null;
		}
		List<List<string>> list = Class12.smethod_4(text);
		if (list.Count > 10 && list[10].Count > 1)
		{
			string string_1 = "http://www.neverlands.ru/main.php?get_id=17&type=0&p=" + list[10][3] + "&uid=" + list[10][0] + "&s=0&m=0&vcode=" + list[10][1];
			return smethod_10("Кража", string_1);
		}
		return null;
	}

	private static void smethod_76(string string_0, int int_0)
	{
		int num = string_0.IndexOf("</b>", int_0, StringComparison.OrdinalIgnoreCase);
		if (num == -1 || !int.TryParse(string_0.Substring(int_0, num - int_0), out var result))
		{
			return;
		}
		try
		{
			if (Class72.formMain_0 != null)
			{
				Class72.formMain_0.BeginInvoke(new Delegate31(Class72.formMain_0.method_92), result);
			}
		}
		catch (InvalidOperationException)
		{
		}
	}

	private static string smethod_77(string string_0, string string_1)
	{
		int num = 0;
		while (num != -1)
		{
			num = string_0.IndexOf("compl_view(\"", num);
			if (num == -1)
			{
				break;
			}
			num += 12;
			int num2 = string_0.IndexOf('"', num + 1);
			if (num2 == -1)
			{
				break;
			}
			string value = string_0.Substring(num, num2 - num);
			if (!string_1.Equals(value, StringComparison.OrdinalIgnoreCase))
			{
				num = num2;
				continue;
			}
			int num3 = num2 + 3;
			int num4 = string_0.IndexOf('"', num3);
			if (num4 == -1)
			{
				break;
			}
			string arg = string_0.Substring(num3, num4 - num3);
			int num5 = num4 + 3;
			int num6 = string_0.IndexOf('"', num5);
			if (num6 == -1)
			{
				break;
			}
			string arg2 = string_0.Substring(num5, num6 - num5);
			string string_2 = $"Надеваем комплект <b>&laquo;{string_1}&raquo;</b>...";
			string string_3 = $"main.php?get_id=57&uid={arg}&s=2&vcode={arg2}";
			string_0 = smethod_10(string_2, string_3);
			return string_0;
		}
		return string.Empty;
	}

	private static string smethod_78(string string_0)
	{
		int num = string_0.IndexOf("var map = [[", StringComparison.Ordinal);
		if (num == -1)
		{
			return string_0;
		}
		num += 12;
		int num2 = string_0.IndexOf(',', num);
		if (num2 == -1)
		{
			return string_0;
		}
		string text = string_0.Substring(num, num2 - num);
		num2++;
		int num3 = string_0.IndexOf(',', num2);
		if (num3 == -1)
		{
			return string_0;
		}
		string text2 = string_0.Substring(num2, num3 - num2);
		string key = string.Format(CultureInfo.InvariantCulture, "{0}/{1}_{2}", new object[3] { text2, text, text2 });
		if (Class77.smethod_0().ContainsKey(key))
		{
			string text3 = Class77.smethod_0()[key].method_4();
			Class72.class19_0.method_59(text3);
			try
			{
				Class72.formMain_0.method_88(text3);
			}
			catch
			{
			}
		}
		num2 = num3 + 1;
		num3 = string_0.IndexOf(',', num2);
		if (num3 == -1)
		{
			return string_0;
		}
		Class77.smethod_8().Clear();
		int num4 = string_0.IndexOf(",[[", num, StringComparison.Ordinal);
		if (num4 == -1)
		{
			return string_0;
		}
		int num5 = num4 + 3;
		while (num5 != -1)
		{
			int num6 = string_0.IndexOf(']', num5);
			string text4 = string_0.Substring(num5, num6 - num5);
			if (text4.IndexOf(';') == -1)
			{
				string[] array = text4.Split(',');
				if (array.Length == 3)
				{
					string text5 = array[0];
					string text6 = array[1];
					string key2 = string.Format(CultureInfo.InvariantCulture, "{0}/{1}_{2}", new object[3] { text6, text5, text6 });
					string value = array[2].Trim('"');
					Class77.smethod_8().Add(key2, value);
					if (Class77.smethod_0().TryGetValue(key2, out var value2) && !Class77.smethod_4().TryGetValue(value2.method_4(), out var _))
					{
						try
						{
							if (Class72.formMain_0 != null)
							{
								Class72.formMain_0.BeginInvoke(new Delegate36(Class72.formMain_0.method_62), "Отсутствует клетка " + value2.method_4());
							}
						}
						catch (InvalidOperationException)
						{
						}
					}
				}
				num5 = string_0.IndexOf('[', num6);
				if (num5 == -1)
				{
					break;
				}
				num5++;
				continue;
			}
			return string_0;
		}
		if (Class72.smethod_36())
		{
			if (Class72.class19_0.method_58().Equals(Class72.smethod_40()))
			{
				if (!Class72.bool_34)
				{
					try
					{
						if (Class72.formMain_0 != null)
						{
							Class72.formMain_0.BeginInvoke(new Delegate17(Class72.formMain_0.method_103), new object[0]);
							Class72.formMain_0.BeginInvoke(new Delegate20(Class72.formMain_0.method_110), new object[0]);
						}
					}
					catch (InvalidOperationException)
					{
					}
					return string_0;
				}
				string text7 = FormMain.smethod_71();
				if (string.IsNullOrEmpty(text7) || Class72.formMain_0 == null)
				{
					Class77.smethod_31();
					Class72.formMain_0.BeginInvoke(new Delegate36(Class72.formMain_0.method_63), "Вы обошли всю карту. Сбрасываем посещённые локации.");
					Class72.formMain_0.BeginInvoke(new Delegate17(Class72.formMain_0.method_103), new object[0]);
					Class72.formMain_0.BeginInvoke(new Delegate20(Class72.formMain_0.method_110), new object[0]);
					return string_0;
				}
				Class72.smethod_41(text7);
			}
			if (Class72.smethod_46() == null || !Class72.smethod_46().CanUseExistingPath(Class72.class19_0.method_58(), Class72.smethod_40()))
			{
				string[] destinationCellNumberList = new string[1] { Class72.smethod_40() };
				Class72.smethod_47(new MapPath(Class72.class19_0.method_58(), destinationCellNumberList));
			}
			Class72.smethod_39(Class72.smethod_46().NextJump);
			Class72.smethod_43(Class72.smethod_46().Jumps);
			Class72.smethod_45(Class72.smethod_46().CityGate);
			if (Class72.smethod_46().IsNextTeleport)
			{
				string text8 = smethod_39(string_0);
				if (!string.IsNullOrEmpty(text8))
				{
					return text8;
				}
			}
			else if (Class72.smethod_46().IsNextCity)
			{
				string text9 = smethod_39(string_0);
				if (!string.IsNullOrEmpty(text9))
				{
					return text9;
				}
			}
			else
			{
				if (Class72.class19_0.method_124())
				{
					try
					{
						string string_1 = string.Format(CultureInfo.InvariantCulture, "Перемещаемся в {0} (еще {1})", new object[2]
						{
							Class72.smethod_46().NextJump,
							Class72.smethod_46().Jumps
						});
						if (Class72.formMain_0 != null)
						{
							Class72.formMain_0.method_105(string_1);
						}
					}
					catch
					{
					}
				}
				string key3 = Class77.smethod_2()[Class72.smethod_46().NextJump];
				Class85 @class = Class77.smethod_0()[key3];
				string value4 = string.Format(CultureInfo.InvariantCulture, "moveMapTo({0}, {1}, map[0][2]);", new object[2]
				{
					@class.method_0(),
					@class.method_2()
				});
				int num7 = string_0.IndexOf("view_map();", StringComparison.OrdinalIgnoreCase);
				if (num7 != -1)
				{
					num7 += 11;
					string_0 = string_0.Insert(num7, value4);
				}
			}
		}
		return string_0;
	}

	private static string smethod_79(string string_0)
	{
		string text = smethod_33(string_0);
		if (!string.IsNullOrEmpty(text))
		{
			return text;
		}
		string text2 = Class72.class5_0.method_6() + "-" + Class72.class5_0.method_8();
		if (!text2.Equals(Class72.class78_0) && Class72.class80_0.method_11(text2, Class72.class78_0))
		{
			string value = "move_tunnels('" + Class72.class80_0.method_8() + "');";
			int num = string_0.IndexOf("view_mine();", StringComparison.OrdinalIgnoreCase);
			if (num != -1)
			{
				num += 12;
				string_0 = string_0.Insert(num, value);
			}
			return string_0;
		}
		Class72.formMain_0.BeginInvoke(new Delegate17(Class72.formMain_0.method_103), new object[0]);
		return string_0;
	}

	private static string smethod_80(string string_0)
	{
		string text = smethod_33(string_0);
		if (!string.IsNullOrEmpty(text))
		{
			return text;
		}
		if (string.IsNullOrEmpty(Class72.class5_0.method_4()))
		{
			Class72.formMain_0.BeginInvoke(new Delegate5(Class72.formMain_0.method_49), new object[0]);
			Class72.formMain_0.BeginInvoke(new Delegate36(Class72.formMain_0.method_63), "Нет кнопки \"Начать добычу\". Автошахта отключена.");
			return string_0;
		}
		string value = string.Format(CultureInfo.InvariantCulture, "Digg('{0}');", new object[1] { Class72.class5_0.method_4() });
		int num = string_0.IndexOf("view_mine();", StringComparison.OrdinalIgnoreCase);
		if (num != -1)
		{
			num += 12;
			string_0 = string_0.Insert(num, value);
		}
		return string_0;
	}

	private static byte[] smethod_81(byte[] byte_0)
	{
		string text = Class72.encoding_0.GetString(byte_0).Split('^')[3];
		if (text.Contains("Вам нужна кирка, чтобы начать добычу."))
		{
			Class72.bool_42 = true;
			Class72.formMain_0.BeginInvoke(new Delegate20(Class72.formMain_0.method_110), new object[0]);
		}
		if (text.Contains("Вам нужен факел для перемещения по шахте."))
		{
			Class72.bool_43 = true;
			Class72.formMain_0.BeginInvoke(new Delegate20(Class72.formMain_0.method_110), new object[0]);
		}
		if (text.Contains("Обнаружены ресурсы"))
		{
			string text2 = Class12.smethod_1(text, "Обнаружены ресурсы: ", ". Добываем");
			Class72.formMain_0.method_63("Добыты ресурсы (уровень <b>" + Class72.class5_0.method_2() + "</b>, клетка <b>" + Class72.class5_0.method_6() + "</b>x<b>" + Class72.class5_0.method_8() + "</b>): <b>" + text2 + "</b>.");
			Class72.formMain_0.BeginInvoke(new Delegate21(Class72.formMain_0.method_50), new object[1] { text2.Split(',') });
		}
		if (text.Contains("Вы не нашли ни одного ресурса"))
		{
			Class72.formMain_0.method_63("Вы не нашли ни одного ресурса (уровень <b>" + Class72.class5_0.method_2() + "</b>, клетка <b>" + Class72.class5_0.method_6() + "</b>x<b>" + Class72.class5_0.method_8() + "</b>).");
		}
		return byte_0;
	}

	private static byte[] smethod_82(byte[] byte_0)
	{
		string[] array = Class72.encoding_0.GetString(byte_0).Split('@');
		if (array.Length > 2 && array[0].Equals("OK"))
		{
			try
			{
				if (Class72.formMain_0 != null)
				{
					Class72.formMain_0.BeginInvoke(new Delegate7(Class72.formMain_0.method_100), "Слот-машина: " + array[1]);
				}
			}
			catch (InvalidOperationException)
			{
			}
		}
		try
		{
			if (Class72.formMain_0 != null)
			{
				Class72.formMain_0.BeginInvoke(new Delegate25(Class72.formMain_0.method_109), "http://www.neverlands.ru/main.php?mselect=15");
			}
		}
		catch (InvalidOperationException)
		{
		}
		return byte_0;
	}

	private static void smethod_83()
	{
		Class72.string_36 = string.Empty;
		Class72.string_37 = string.Empty;
		Class72.string_38 = string.Empty;
		Class72.string_39 = string.Empty;
		Class72.string_40 = string.Empty;
	}

	private static byte[] smethod_84(byte[] byte_0)
	{
		string text = Class72.encoding_0.GetString(byte_0);
		Class72.string_38 = string.Empty;
		Class72.list_0.Clear();
		int num = text.IndexOf("</b></div></td></tr>", StringComparison.Ordinal);
		if (num == -1)
		{
			return byte_0;
		}
		num += 20;
		int length = num;
		while (text.Substring(num).StartsWith("<tr><td bgcolor=#f9f9f9>", StringComparison.Ordinal))
		{
			int num2 = text.IndexOf("</td></tr></table></td></tr></table></td></tr>", num, StringComparison.Ordinal);
			if (num2 != -1)
			{
				num2 += 46;
				ShopEntry shopEntry = new ShopEntry(text.Substring(num, num2 - num));
				if (string.IsNullOrEmpty(Class72.string_38) && !string.IsNullOrEmpty(Class72.string_36) && !string.IsNullOrEmpty(shopEntry.Name) && shopEntry.Name.Equals(Class72.string_36, StringComparison.CurrentCultureIgnoreCase) && !string.IsNullOrEmpty(Class72.string_37) && !string.IsNullOrEmpty(shopEntry.Price) && shopEntry.Price.Equals(Class72.string_37, StringComparison.CurrentCultureIgnoreCase) && (!shopEntry.IsMarket || (shopEntry.IsMarket && shopEntry.Dolg.Equals(Class72.string_40, StringComparison.CurrentCultureIgnoreCase))))
				{
					Class72.string_38 = shopEntry.SellCall;
				}
				Class72.list_0.Add(shopEntry);
				num = num2;
				continue;
			}
			return byte_0;
		}
		if (Class72.list_0.Count > 1)
		{
			for (int i = 0; i < Class72.list_0.Count - 1; i++)
			{
				for (int j = i + 1; j < Class72.list_0.Count; j++)
				{
					if (Class72.list_0[i].CompareTo(Class72.list_0[j]) == 0)
					{
						Class72.list_0[i].method_0();
						Class72.list_0.RemoveAt(j);
						j--;
					}
				}
			}
		}
		if (string.IsNullOrEmpty(Class72.string_38) || text.Contains("ERROR@"))
		{
			smethod_83();
		}
		StringBuilder stringBuilder = new StringBuilder();
		for (int k = 0; k < Class72.list_0.Count; k++)
		{
			if (string.IsNullOrEmpty(Class72.string_38) || Class72.list_0[k].IsMarket || (!Class72.list_0[k].IsMarket && Class72.string_38 == Class72.list_0[k].SellCall))
			{
				stringBuilder.Append(Class72.list_0[k]);
			}
		}
		StringBuilder stringBuilder2 = new StringBuilder(text.Substring(0, length));
		stringBuilder2.Append(stringBuilder);
		stringBuilder2.Append(text.Substring(num));
		text = stringBuilder2.ToString();
		return Class91.encoding_0.GetBytes(text);
	}

	private static byte[] smethod_85(byte[] byte_0)
	{
		string text = Class91.encoding_0.GetString(byte_0);
		text = text.Replace("AjaxPost('shop_ajax.php', data, function(xdata) {", "AjaxPost('shop_ajax.php', data, function(xdata) { var id = window.external.GetItemID(); var vcode = window.external.GetItemVcode(); if (id > 0) shop_item_sell(id, vcode);");
		return Class91.encoding_0.GetBytes(text);
	}

	private static string smethod_86(string string_0)
	{
		if (Class72.smethod_46() == null || !Class72.smethod_46().CanUseExistingPath(Class72.class19_0.method_58(), Class72.smethod_40()))
		{
			string[] destinationCellNumberList = new string[1] { Class72.smethod_40() };
			Class72.smethod_47(new MapPath(Class72.class19_0.method_58(), destinationCellNumberList));
		}
		Class72.smethod_39(Class72.smethod_46().NextJump);
		Class72.smethod_43(Class72.smethod_46().Jumps);
		Class72.smethod_45(Class72.smethod_46().CityGate);
		if (Class72.smethod_42() == 0)
		{
			try
			{
				if (Class72.formMain_0 != null)
				{
					Class72.formMain_0.BeginInvoke(new Delegate17(Class72.formMain_0.method_103), new object[0]);
				}
			}
			catch (InvalidOperationException)
			{
			}
			return null;
		}
		string text = Class12.smethod_1(string_0, "var telep = [[", "]];");
		if (string.IsNullOrEmpty(text))
		{
			return null;
		}
		string[] array = text.Split(new string[1] { "],[" }, StringSplitOptions.None);
		int num = 0;
		string[] array2;
		int result;
		int result2;
		while (true)
		{
			if (num < array.Length)
			{
				array2 = array[num].Split(',');
				if (int.TryParse(array2[0], out result) && int.TryParse(array2[1], out result2))
				{
					string key = Class77.smethod_30(result, result2);
					if (Class77.smethod_0().ContainsKey(key))
					{
						string text2 = Class77.smethod_0()[key].method_4();
						if (text2 != null && text2.Equals(Class72.smethod_38()))
						{
							break;
						}
					}
				}
				num++;
				continue;
			}
			string text3 = Class12.smethod_1(string_0, "var vcode = [[", "]];");
			if (string.IsNullOrEmpty(text3))
			{
				return null;
			}
			string[] array3 = text3.Split(new string[1] { "],[" }, StringSplitOptions.None);
			if (array3.Length >= 3)
			{
				string[] array4 = array3[2].Split(',');
				if (array4.Length >= 2)
				{
					string text4 = array4[1].Trim('"');
					string string_1 = "main.php?get_id=56&act=10&go=up&vcode=" + text4;
					string_0 = smethod_10("Выходим из телепорта", string_1);
					return string_0;
				}
			}
			return null;
		}
		string text5 = array2[3];
		string text6 = array2[4].Trim('"');
		string string_2 = string.Format(CultureInfo.InvariantCulture, "main.php?get_id=16&act=1&x={0}&y={1}&pr={2}&vcode={3}", result, result2, text5, text6);
		string_0 = smethod_10("Телепорт " + array2[2], string_2);
		return string_0;
	}

	private static string smethod_87(string string_0)
	{
		Class29 @class = new Class29(string_0);
		if (!@class.bool_0)
		{
			return null;
		}
		IEnumerable<Class3> enumerable = smethod_88(string_0);
		if (!@class.method_0() && Class72.class19_0.method_84())
		{
			foreach (Class3 item in enumerable)
			{
				if (Class72.class19_0.method_86().Equals("Любая удочка", StringComparison.OrdinalIgnoreCase))
				{
					if ((item.method_0().IndexOf("удочка", StringComparison.CurrentCultureIgnoreCase) >= 0 || item.method_0().IndexOf("спиннинг", StringComparison.CurrentCultureIgnoreCase) >= 0) && !string.IsNullOrEmpty(item.method_6()))
					{
						Class72.formMain_0.method_63("Надеваем <b>" + item.method_0().Split('(')[0] + "</b>");
						return smethod_10("Надеваем первую попавшуюся удочку", item.method_6());
					}
				}
				else if (item.method_0().IndexOf(Class72.class19_0.method_86(), StringComparison.CurrentCultureIgnoreCase) >= 0 && !string.IsNullOrEmpty(item.method_6()))
				{
					Class72.formMain_0.method_63("Надеваем <b>" + item.method_0().Split('(')[0] + "</b>");
					return smethod_10(Class72.class19_0.method_86() + " надевается", item.method_6());
				}
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
			return null;
		}
		if (!@class.method_1() && Class72.class19_0.method_84())
		{
			foreach (Class3 item2 in enumerable)
			{
				if (Class72.class19_0.method_88().Equals("Любая удочка", StringComparison.OrdinalIgnoreCase))
				{
					if ((item2.method_0().IndexOf("удочка", StringComparison.CurrentCultureIgnoreCase) >= 0 || item2.method_0().IndexOf("спиннинг", StringComparison.CurrentCultureIgnoreCase) >= 0) && !string.IsNullOrEmpty(item2.method_6()))
					{
						if (!@class.bool_1 && !@class.bool_2 && @class.bool_3)
						{
							return smethod_10("Снимаем " + @class.string_2, "main.php?get_id=57&uid=" + @class.string_0 + "&s=0&vcode=" + @class.string_1);
						}
						Class72.formMain_0.method_63("Надеваем <b>" + item2.method_0().Split('(')[0] + "</b>");
						return smethod_10("Надеваем первую попавшуюся удочку", item2.method_6());
					}
				}
				else if (item2.method_0().IndexOf(Class72.class19_0.method_88(), StringComparison.CurrentCultureIgnoreCase) >= 0 && !string.IsNullOrEmpty(item2.method_6()))
				{
					if (!@class.bool_1 && !@class.bool_2 && @class.bool_3)
					{
						return smethod_10("Снимаем " + @class.string_2, "main.php?get_id=57&uid=" + @class.string_0 + "&s=0&vcode=" + @class.string_1);
					}
					Class72.formMain_0.method_63("Надеваем <b>" + item2.method_0().Split('(')[0] + "</b>");
					return smethod_10(Class72.class19_0.method_88() + " надевается", item2.method_6());
				}
			}
		}
		Class72.smethod_65(bool_54: false);
		return null;
	}

	private static IEnumerable<Class3> smethod_88(string string_0)
	{
		List<Class3> list = new List<Class3>();
		int num = string_0.IndexOf("</b></font></td></tr>", StringComparison.Ordinal);
		if (num == -1)
		{
			return list;
		}
		num += 21;
		while (string_0.Substring(num, 24).StartsWith("<tr><td bgcolor=#F5F5F5>", StringComparison.Ordinal))
		{
			int num2 = string_0.IndexOf("<td bgcolor=#FCFAF3><img src=http://image.neverlands.ru/1x1.gif width=5 height=1></td></tr></table></td></tr></table></td></tr>", num, StringComparison.Ordinal);
			if (num2 == -1)
			{
				num2 = string_0.IndexOf("<img src=http://image.neverlands.ru/1x1.gif width=1 height=5></td></tr></table></td></tr>", num, StringComparison.Ordinal);
				if (num2 == -1)
				{
					return list;
				}
				num2 += 89;
			}
			else
			{
				num2 += 127;
			}
			Class3 item = new Class3(string_0.Substring(num, num2 - num));
			list.Add(item);
			num = num2;
		}
		return list;
	}

	private static bool smethod_89(string string_0)
	{
		Class29 @class = new Class29(string_0);
		if (!@class.bool_0)
		{
			return false;
		}
		if (!@class.method_0() && Class72.class19_0.method_84())
		{
			return true;
		}
		if (!@class.method_1())
		{
			return Class72.class19_0.method_84();
		}
		return false;
	}

	private static bool smethod_90(string string_0)
	{
		string[] string_1 = new string[7] { "Малый Разделочный Нож", "Охотничий Нож", "Вороненый Охотничий Нож", "Разделочный Топорик", "Арисайский Охотничий Нож", "Нож Мастера-охотника", "Праздничный Нож Охотника" };
		Class29 @class = new Class29(string_0);
		if (!@class.bool_0)
		{
			return false;
		}
		return @class.method_2(string_1);
	}

	private static string smethod_91(string string_0)
	{
		string[] array = new string[7] { "Малый Разделочный Нож", "Охотничий Нож", "Вороненый Охотничий Нож", "Разделочный Топорик", "Арисайский Охотничий Нож", "Нож Мастера-охотника", "Праздничный Нож Охотника" };
		Class29 @class = new Class29(string_0);
		if (!@class.bool_0)
		{
			return null;
		}
		if (!@class.method_2(array))
		{
			for (int i = 0; i < array.Length; i++)
			{
				foreach (Class3 item in smethod_88(string_0))
				{
					if (item.method_0().IndexOf(array[i], StringComparison.CurrentCultureIgnoreCase) >= 0 && !string.IsNullOrEmpty(item.method_6()))
					{
						Class72.formMain_0.method_63("Надеваем <b>" + item.method_0().Split('(')[0] + "</b>");
						return smethod_10("Надеваем " + item.method_0(), item.method_6());
					}
				}
			}
		}
		Class72.smethod_57(bool_54: false);
		return null;
	}

	private static string smethod_92(string string_0)
	{
		string[] array = new string[5] { "Легкая кирка", "Тяжелая кирка", "Сбалансированная кирка", "Кирка Мастера-рудокопа", "Праздничная Кирка Рудокопа" };
		Class29 @class = new Class29(string_0);
		if (!@class.bool_0)
		{
			return null;
		}
		if (!@class.method_2(array))
		{
			foreach (Class3 item in smethod_88(string_0))
			{
				for (int i = 0; i < array.Length; i++)
				{
					if (item.method_0().IndexOf(array[i], StringComparison.CurrentCultureIgnoreCase) >= 0 && !string.IsNullOrEmpty(item.method_6()))
					{
						Class72.formMain_0.method_63("Надеваем <b>" + item.method_0().Split('(')[0] + "</b>");
						Class72.bool_42 = false;
						return smethod_10("Надеваем " + item.method_0(), item.method_6());
					}
				}
			}
		}
		return null;
	}

	private static string smethod_93(string string_0)
	{
		string[] array = new string[3] { "Смоляной факел", "Масляный факел", "Дварфийский фонарь" };
		Class29 @class = new Class29(string_0);
		if (!@class.bool_0)
		{
			return null;
		}
		if (!@class.method_2(array))
		{
			foreach (Class3 item in smethod_88(string_0))
			{
				for (int i = 0; i < array.Length; i++)
				{
					if (item.method_0().IndexOf(array[i], StringComparison.CurrentCultureIgnoreCase) >= 0 && !string.IsNullOrEmpty(item.method_6()))
					{
						Class72.formMain_0.method_63("Надеваем <b>" + item.method_0().Split('(')[0] + "</b>");
						Class72.bool_43 = false;
						return smethod_10("Надеваем " + item.method_0(), item.method_6());
					}
				}
			}
		}
		return null;
	}

	private static string smethod_94(string string_0)
	{
		string[] array = new string[7] { "Мачете", "Столярный топорик", "Плотницкий топор", "Топор подмастерья", "Топор дровосека", "Секира лесоруба", "Секира Мастера-лесоруба" };
		Class29 @class = new Class29(string_0);
		if (!@class.bool_0)
		{
			return null;
		}
		if (!@class.method_2(array))
		{
			foreach (Class3 item in smethod_88(string_0))
			{
				for (int i = 0; i < array.Length; i++)
				{
					if (item.method_0().IndexOf(array[i], StringComparison.CurrentCultureIgnoreCase) >= 0 && !string.IsNullOrEmpty(item.method_6()))
					{
						Class72.formMain_0.method_63("Надеваем <b>" + item.method_0().Split('(')[0] + "</b>");
						Class72.bool_51 = false;
						return smethod_10("Надеваем " + item.method_0(), item.method_6());
					}
				}
			}
		}
		return null;
	}

	private static string smethod_95(string string_0)
	{
		string[] array = new string[6] { "Серп собирателя", "Серп ученика-травника", "Серп мастера-травника", "Серп эксперта-травника", "Серп Триады", "Серп Мастера-травника" };
		Class29 @class = new Class29(string_0);
		if (!@class.bool_0)
		{
			return null;
		}
		if (!@class.method_2(array))
		{
			foreach (Class3 item in smethod_88(string_0))
			{
				for (int i = 0; i < array.Length; i++)
				{
					if (item.method_0().IndexOf(array[i], StringComparison.CurrentCultureIgnoreCase) >= 0 && !string.IsNullOrEmpty(item.method_6()))
					{
						Class72.formMain_0.method_63("Надеваем <b>" + item.method_0().Split('(')[0] + "</b>");
						Class72.bool_52 = false;
						return smethod_10("Надеваем " + item.method_0(), item.method_6());
					}
				}
			}
		}
		return null;
	}

	private static string smethod_96(string string_0)
	{
		List<string> list = new List<string>();
		if (Class72.bool_50[0])
		{
			list.Add("Лопата кладоискателя");
		}
		if (Class72.bool_50[1])
		{
			list.Add("Лопата археолога");
		}
		if (Class72.bool_50[2])
		{
			list.Add("Походная лопатка");
		}
		Class29 @class = new Class29(string_0);
		if (!@class.bool_0)
		{
			return null;
		}
		if (!@class.method_2(list.ToArray()))
		{
			for (int i = 0; i < list.Count; i++)
			{
				foreach (Class3 item in smethod_88(string_0))
				{
					if (item.method_0().IndexOf(list[i], StringComparison.CurrentCultureIgnoreCase) >= 0 && !string.IsNullOrEmpty(item.method_6()))
					{
						Class72.formMain_0.method_63("Надеваем <b>" + item.method_0().Split('(')[0] + "</b>");
						Class72.bool_49 = false;
						return smethod_10("Надеваем " + item.method_0(), item.method_6());
					}
				}
			}
		}
		return null;
	}

	private static void smethod_97(string string_0)
	{
		int num = string_0.IndexOf("<B>Рост</B></td></tr>", StringComparison.Ordinal);
		if (num == -1)
		{
			return;
		}
		StringBuilder stringBuilder = new StringBuilder();
		num += 21;
		while (true)
		{
			num = string_0.IndexOf("<input type=checkbox name=", num, StringComparison.Ordinal);
			if (num == -1)
			{
				break;
			}
			num += 26;
			int num2 = string_0.IndexOf("</tr>", num, StringComparison.Ordinal);
			if (num2 != -1)
			{
				num2 += 5;
			}
			string string_1 = string_0.Substring(num, num2 - num);
			if (double.TryParse(Class12.smethod_1(string_1, " width=15% class=travma align=center>", "</td>"), NumberStyles.Any, CultureInfo.InvariantCulture, out var result))
			{
				string text = Class12.smethod_1(string_1, " width=25% class=travma align=center><B>", "</B><BR>");
				if (!string.IsNullOrEmpty(text))
				{
					if (stringBuilder.Length > 0)
					{
						stringBuilder.Append(", ");
					}
					if (Class72.dictionary_0.ContainsKey(text))
					{
						if (Math.Abs(Class72.dictionary_0[text] - result) > 0.009)
						{
							double num3 = result - Class72.dictionary_0[text];
							stringBuilder.Append($"<span style=\"color:#009933;font-weight:bold;\">«{text} {result:F2}»</span> (+{num3:F2})");
							Class72.dictionary_0[text] = result;
						}
						else
						{
							stringBuilder.Append($"<span style=\"color:#009933;font-weight:bold;\">«{text} {result:F2}»</span>");
						}
					}
					else
					{
						stringBuilder.Append($"<span style=\"color:#009933;font-weight:bold;\">«{text} {result:F2}»</span>");
						Class72.dictionary_0.Add(text, result);
					}
				}
			}
			num = num2;
		}
		if (stringBuilder.Length <= 0)
		{
			return;
		}
		stringBuilder.Insert(0, "Охотничьи ресурсы: ");
		try
		{
			if (Class72.formMain_0 != null)
			{
				Class72.formMain_0.BeginInvoke(new Delegate36(Class72.formMain_0.method_62), stringBuilder.ToString());
			}
		}
		catch (InvalidOperationException)
		{
		}
	}

	private static byte[] smethod_98(byte[] byte_0)
	{
		StringBuilder stringBuilder = new StringBuilder(Class91.encoding_0.GetString(byte_0));
		if (Class72.class19_0.method_104())
		{
			stringBuilder.Replace(" id=\"msg\">", " id=\"msg\">" + Class72.smethod_48());
		}
		return Class91.encoding_0.GetBytes(stringBuilder.ToString());
	}

	private static byte[] smethod_99(byte[] byte_0)
	{
		StringBuilder stringBuilder = new StringBuilder(Class91.encoding_0.GetString(byte_0));
		stringBuilder.Replace("'%clan% '", "'%clan%'");
		return Class91.encoding_0.GetBytes(stringBuilder.ToString());
	}

	private static byte[] smethod_100(byte[] byte_0)
	{
		StringBuilder stringBuilder = new StringBuilder(Class91.encoding_0.GetString(byte_0));
		stringBuilder.Replace("alt=", "title=");
		return Class91.encoding_0.GetBytes(stringBuilder.ToString());
	}

	private static byte[] smethod_101(byte[] byte_0)
	{
		StringBuilder stringBuilder = new StringBuilder(Class91.encoding_0.GetString(byte_0));
		stringBuilder.Replace("document.all(\"transfer\").innerHTML = '<form action=main.php method=POST><input type=hidden name=magicrestart value=\"1\"><input type=hidden name=magicreuid value='+wuid+'><input type=hidden name=vcode value='+wmcode+'><input type=hidden name=post_id value=46><table cellpadding=0 cellspacing=0 border=0 width=100%><tr><td bgcolor=#B9A05C><table cellpadding=3 cellspacing=1 border=0 width=100%><tr><td width=100% bgcolor=#FCFAF3><font class=nickname><b>Использовать \"'+wnametxt+'\" сейчас?</b></div></td></tr><tr><td bgcolor=#FCFAF3><font class=nickname><b>Кому:</b> <INPUT TYPE=\"text\" name=fornickname class=LogintextBox value=\"'+wnickname+'\" maxlength=25> <input type=submit value=\"выполнить\" class=lbut> <input type=button class=lbut onclick=\"closeform()\" value=\" x \"></td></tr></table></td></tr></table></FORM>';", "document.all(\"transfer\").innerHTML = '<form action=main.php method=POST><input type=hidden name=magicrestart value=\"1\"><input type=hidden name=magicreuid value='+wuid+'><input type=hidden name=vcode value='+wmcode+'><input type=hidden name=post_id value=46><table cellpadding=0 cellspacing=0 border=0 width=100%><tr><td bgcolor=#B9A05C><table cellpadding=3 cellspacing=1 border=0 width=100%><tr><td width=100% bgcolor=#FCFAF3><font class=nickname><b>Использовать \"'+wnametxt+'\" сейчас?</b></div></td></tr><tr><td bgcolor=#FCFAF3><font class=nickname><b>Кому:</b> <INPUT TYPE=\"text\" name=fornickname class=LogintextBox value=\"'+wnickname+'\" maxlength=25> <input type=submit value=\"выполнить\" class=lbut onclick=\"window.external.TraceDrinkPotion(fornickname.value, \\''+wnametxt+'\\')\"> <input type=button class=lbut onclick=\"closeform()\" value=\" x \"></td></tr></table></td></tr></table></FORM>';");
		return Class91.encoding_0.GetBytes(stringBuilder.ToString());
	}
}
