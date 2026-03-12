using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using ABClient.AppControls;
using ABClient.ExtMap;

internal sealed class FormCompas : Form
{
	private readonly StringBuilder stringBuilder_0 = new StringBuilder();

	private IContainer icontainer_0;

	private StatusStrip statusStrip;

	private ToolStripStatusLabel status;

	private ExtendedWebBrowser wb;

	internal FormCompas(string string_0)
	{
		InitializeComponent();
		wb.method_0(smethod_0);
		stringBuilder_0.Append("<html><head><meta content=\"text/html; charset=windows-1251\" http-equiv=Content-type><META Http-Equiv=Cache-Control Content=no-cache><body bgcolor=#FCFAF3>");
		method_2();
		smethod_2(string_0);
	}

	private static void smethod_0(object sender, WebBrowserExtendedNavigatingEventArgs e)
	{
		string address = e.Address;
		if (!address.StartsWith("http://"))
		{
			return;
		}
		if (address.IndexOf("pinfo.cgi?", StringComparison.Ordinal) != -1)
		{
			if (Class72.formMain_0 != null)
			{
				Class72.formMain_0.method_142(address);
			}
		}
		else
		{
			string text = address.Substring(7);
			if (text.EndsWith("/"))
			{
				text = text.Substring(0, text.Length - 1);
				if (Class72.formMain_0 != null)
				{
					e.Cancel = true;
					Class72.formMain_0.method_122(text);
				}
			}
		}
		e.Cancel = true;
	}

	internal static void smethod_1(string string_0)
	{
		smethod_2(string_0);
	}

	private void method_0(string string_0)
	{
		status.Text = string_0;
	}

	private void method_1(string string_0)
	{
		stringBuilder_0.Append(string_0);
		method_2();
	}

	private void method_2()
	{
		wb.DocumentText = stringBuilder_0?.ToString() + "</body></html>";
	}

	private static void smethod_2(string string_0)
	{
		ThreadPool.QueueUserWorkItem(smethod_3, string_0);
	}

	private void FormCompas_FormClosed(object sender, FormClosedEventArgs e)
	{
		Class72.formCompas_0 = null;
	}

	private static void smethod_3(object object_0)
	{
		if (!(object_0 is string string_))
		{
			return;
		}
		string text = Class21.smethod_0(string_);
		if (string.IsNullOrEmpty(text))
		{
			return;
		}
		string text2 = Class12.smethod_1(text, "var parameters = [[", "],");
		if (string.IsNullOrEmpty(text2))
		{
			return;
		}
		string[] array = Class12.smethod_2(text2);
		if (array.Length < 9)
		{
			return;
		}
		string item = array[0].Trim();
		string value = array[8];
		foreach (string item2 in new List<string> { item })
		{
			string text3 = "Анализируем [" + item2 + "]";
			try
			{
				if (Class72.formCompas_0 == null)
				{
					return;
				}
				Class72.formCompas_0.BeginInvoke(new Delegate26(Class72.formCompas_0.method_0), text3);
			}
			catch (InvalidOperationException)
			{
			}
			text = Class21.smethod_3(Class21.smethod_2(item2));
			if (string.IsNullOrEmpty(text))
			{
				continue;
			}
			string text4 = Class12.smethod_1(text, "\n3|", "\n4|");
			if (string.IsNullOrEmpty(text4))
			{
				continue;
			}
			string[] array2 = Class12.smethod_1(text, "\n2|", "\n3|").Split('@');
			string[] array3 = text4.Split('|');
			string text5 = array3[0];
			string text6 = array3[1];
			string text7 = array3[2];
			string text8 = array3[4];
			string text9 = array3[5];
			bool flag = array3[12] == "1";
			string text10 = array3[13];
			string text11 = array3[13];
			if (text11.IndexOf('[') != -1)
			{
				text11 = Class12.smethod_1(text11, "[", "]");
			}
			if (!text9.Equals(value))
			{
				continue;
			}
			bool flag2 = false;
			bool flag3 = false;
			bool flag4 = false;
			bool flag5 = false;
			StringBuilder stringBuilder = new StringBuilder();
			if (!string.IsNullOrEmpty(array2[0]))
			{
				for (int i = 0; i < array2.Length; i++)
				{
					string[] array4 = array2[i].Split('.');
					if (array4.Length > 1)
					{
						string text12 = array4[0];
						string arg = array4[1];
						stringBuilder.AppendFormat("&nbsp;<img src=http://image.neverlands.ru/pinfo/eff_{0}.gif width=15 height=15 align=absmiddle title=\"{1}\">", text12, arg);
						switch (text12)
						{
						case "4":
							flag2 = true;
							break;
						case "3":
							flag3 = true;
							break;
						case "2":
							flag4 = true;
							break;
						case "1":
							flag5 = true;
							break;
						}
					}
				}
			}
			string text13 = string.Empty;
			if (flag5)
			{
				text13 = "боевая";
			}
			else if (flag4)
			{
				text13 = "тяжелая";
			}
			else if (flag3)
			{
				text13 = "средняя";
			}
			else if (flag2)
			{
				text13 = "легкая";
			}
			string text14 = text5;
			if (!flag)
			{
				text14 = "<font color=\"#cccccc\">" + text14 + "</font>";
			}
			else if (!string.IsNullOrEmpty(text13))
			{
				switch (text13)
				{
				case "легкая":
					text14 = "<font color=\"#ef7f94\">" + text14 + "</font>";
					break;
				case "средняя":
					text14 = "<font color=\"#e94c69\">" + text14 + "</font>";
					break;
				case "тяжелая":
					text14 = "<font color=\"#c10000\">" + text14 + "</font>";
					break;
				case "боевая":
					text14 = "<font color=\"#666600\">" + text14 + "</font>";
					break;
				}
			}
			string text15 = string.Empty;
			string text16 = string.Empty;
			string text17 = string.Empty;
			switch (Class0.smethod_0(text7))
			{
			case 822911587u:
				if (text7 == "4")
				{
					text16 = "chaoss.gif";
					text17 = "Дети Хаоса";
				}
				break;
			case 806133968u:
				if (text7 == "5")
				{
					text16 = "light.gif";
					text17 = "Истинный Свет";
				}
				break;
			case 856466825u:
				if (text7 == "6")
				{
					text16 = "dark.gif";
					text17 = "Истинная Тьма";
				}
				break;
			case 839689206u:
				if (text7 == "7")
				{
					text16 = "sumer.gif";
					text17 = "Нейтральные Сумерки";
				}
				break;
			case 906799682u:
				if (text7 == "3")
				{
					text16 = "sumers.gif";
					text17 = "Дети Сумерек";
				}
				break;
			case 873244444u:
				if (text7 == "1")
				{
					text16 = "darks.gif";
					text17 = "Дети Тьмы";
				}
				break;
			case 1024243015u:
				if (text7 == "8")
				{
					text16 = "chaos.gif";
					text17 = "Абсолютный Хаос";
				}
				break;
			case 1007465396u:
				if (text7 == "9")
				{
					text16 = "angel.gif";
					text17 = "Ангел";
				}
				break;
			case 923577301u:
				if (text7 == "2")
				{
					text16 = "lights.gif";
					text17 = "Дети Света";
				}
				break;
			}
			if (!string.IsNullOrEmpty(text16))
			{
				text15 = "<img src=http://image.neverlands.ru/signs/" + text16 + " width=15 height=12 align=absmiddle border=0 title=\"" + text17 + "\">&nbsp";
			}
			string text18 = string.Empty;
			if (!string.IsNullOrEmpty(text9))
			{
				text18 = "<img src=http://image.neverlands.ru/signs/" + text8 + " width=15 height=12 align=absmiddle title=\"" + text9 + "\">&nbsp;";
			}
			string text19 = string.Empty;
			if (flag)
			{
				if (!text10.StartsWith("Форпост", StringComparison.OrdinalIgnoreCase) && !text10.StartsWith("Октал", StringComparison.OrdinalIgnoreCase) && !text10.StartsWith("Деревня", StringComparison.OrdinalIgnoreCase) && !text10.StartsWith("Тюрьма", StringComparison.OrdinalIgnoreCase) && !text10.StartsWith("Окрестности Форпоста [Окрестность Форпоста, Биржа]", StringComparison.OrdinalIgnoreCase) && !text10.StartsWith("Окрестность Форпоста [Сырьевая Биржа]", StringComparison.OrdinalIgnoreCase))
				{
					List<string> list = new List<string>();
					int num = 0;
					foreach (string key in Class77.smethod_4().Keys)
					{
						if (Class77.smethod_4()[key].Tooltip.Equals(text11, StringComparison.OrdinalIgnoreCase))
						{
							num++;
						}
					}
					if (num > 0)
					{
						int num2 = 0;
						foreach (string key2 in Class77.smethod_4().Keys)
						{
							if (!Class77.smethod_4()[key2].Tooltip.Equals(text11, StringComparison.OrdinalIgnoreCase))
							{
								continue;
							}
							int num3 = num2 * 100 / num;
							string text20 = $"{text3}... {num3}%";
							try
							{
								if (Class72.formCompas_0 == null)
								{
									return;
								}
								Class72.formCompas_0.BeginInvoke(new Delegate26(Class72.formCompas_0.method_0), text20);
							}
							catch (InvalidOperationException)
							{
							}
							num2++;
							list.Add(key2);
						}
					}
					if (list.Count > 0)
					{
						int count = list.Count;
						MapPath mapPath = new MapPath(Class72.string_4, list.ToArray());
						text19 = ((count != 1) ? $"{text11}. Возможных клеток: <b>{count}</b>, ближайшая <a style='text-decoration:none' href='http://{mapPath.Destination ?? Class72.string_4}'><b>{mapPath.Destination ?? Class72.string_4}</b></a> (шагов: <b>{mapPath.Jumps}</b>)." : $"Точное положение: <a style='text-decoration:none' href='http://{list[0]}'><b>{list[0]}</b></a> (шагов: <b>{mapPath.Jumps}</b>). {text11}.");
					}
					else
					{
						text19 = "<font color=\"#cc0000\">Неизвестная клетка!</font>";
					}
				}
				else
				{
					string[] array5 = null;
					if (text10.StartsWith("Форпост") || text10.StartsWith("Тюрьма"))
					{
						array5 = new string[2] { "8-259", "8-294" };
					}
					if (text10.StartsWith("Октал"))
					{
						array5 = new string[3] { "12-428", "12-494", "12-521" };
					}
					if (text10.StartsWith("Деревня"))
					{
						array5 = new string[3] { "8-197", "8-228", "8-229" };
					}
					if (text10.StartsWith("Окрестности Форпоста [Окрестность Форпоста, Биржа]"))
					{
						array5 = new string[1] { "8-227" };
					}
					if (text10.StartsWith("Окрестность Форпоста [Сырьевая Биржа]"))
					{
						array5 = new string[1] { "8-227" };
					}
					if (array5 != null)
					{
						MapPath mapPath2 = new MapPath(Class72.string_4, array5);
						text19 = $"Точное положение: <a style='text-decoration:none' href='http://{mapPath2.Destination}'><b>{mapPath2.Destination}</b></a> (шагов: <b>{mapPath2.Jumps}</b>). {text11}.";
					}
				}
			}
			else
			{
				text19 = "<font color=\"#cccccc\">В оффлайне или невиде.</font>";
			}
			text19 = "<span style=\"font-size:10px;\">" + text19 + "</span>";
			string text21 = "<span style=\"font-family:Verdana,Arial,sans-serif; font-size:12px; text-decoration:none;\tcolor:#222222;\">" + text15 + text18 + "<b>" + text14 + "</b></a>[" + text6 + "]<a href='http://www.neverlands.ru/pinfo.cgi?" + text5 + "'><img src=http://image.neverlands.ru/chat/info.gif width=11 height=12 border=0 align=absmiddle></a>" + stringBuilder?.ToString() + "<img src=http://image.neverlands.ru/1x1.gif width=8 height=1>" + text19 + "</span><br>";
			try
			{
				if (Class72.formCompas_0 != null)
				{
					Class72.formCompas_0.BeginInvoke(new Delegate0(Class72.formCompas_0.method_1), text21);
					continue;
				}
				return;
			}
			catch (InvalidOperationException)
			{
			}
		}
		try
		{
			if (Class72.formCompas_0 != null)
			{
				Class72.formCompas_0.BeginInvoke(new Delegate26(Class72.formCompas_0.method_0), "Сканирование завешено.");
			}
		}
		catch (InvalidOperationException)
		{
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCompas));
		this.statusStrip = new System.Windows.Forms.StatusStrip();
		this.status = new System.Windows.Forms.ToolStripStatusLabel();
		this.wb = new ABClient.AppControls.ExtendedWebBrowser();
		this.statusStrip.SuspendLayout();
		base.SuspendLayout();
		this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[1] { this.status });
		this.statusStrip.Location = new System.Drawing.Point(0, 340);
		this.statusStrip.Name = "statusStrip";
		this.statusStrip.Size = new System.Drawing.Size(744, 22);
		this.statusStrip.TabIndex = 0;
		this.statusStrip.Text = "statusStrip1";
		this.status.Name = "status";
		this.status.Size = new System.Drawing.Size(91, 17);
		this.status.Text = "Идет загрузка...";
		this.wb.Dock = System.Windows.Forms.DockStyle.Fill;
		this.wb.Location = new System.Drawing.Point(0, 0);
		this.wb.MinimumSize = new System.Drawing.Size(20, 20);
		this.wb.Name = "wb";
		this.wb.Size = new System.Drawing.Size(744, 340);
		this.wb.TabIndex = 1;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(744, 362);
		base.Controls.Add(this.wb);
		base.Controls.Add(this.statusStrip);
		this.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.Name = "FormCompas";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Поиск возможных мест нахождения";
		base.FormClosed += new System.Windows.Forms.FormClosedEventHandler(FormCompas_FormClosed);
		this.statusStrip.ResumeLayout(false);
		this.statusStrip.PerformLayout();
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
