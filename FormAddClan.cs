using System;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using ABClient.AppControls;

internal sealed class FormAddClan : Form
{
	private readonly StringBuilder stringBuilder_0 = new StringBuilder();

	private IContainer icontainer_0;

	private ExtendedWebBrowser wb;

	internal FormAddClan(string string_0)
	{
		InitializeComponent();
		wb.method_0(smethod_0);
		stringBuilder_0.Append("<html><head><meta content=\"text/html; charset=windows-1251\" http-equiv=Content-type><META Http-Equiv=Cache-Control Content=no-cache><body bgcolor=#FCFAF3>");
		method_2();
		smethod_1(string_0);
	}

	private static void smethod_0(object sender, WebBrowserExtendedNavigatingEventArgs e)
	{
		string address = e.Address;
		if (!address.StartsWith("http://"))
		{
			return;
		}
		if (address.IndexOf("pinfo.cgi?", StringComparison.CurrentCultureIgnoreCase) != -1)
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

	internal void method_0(string string_0)
	{
		smethod_1(string_0);
	}

	internal void method_1(string string_0)
	{
		stringBuilder_0.Append(string_0);
		method_2();
	}

	private void method_2()
	{
		wb.DocumentText = stringBuilder_0?.ToString() + "</body></html>";
	}

	private static void smethod_1(string string_0)
	{
		ThreadPool.QueueUserWorkItem(smethod_2, string_0);
	}

	private void FormAddClan_FormClosed(object sender, FormClosedEventArgs e)
	{
		Class72.formAddClan_0 = null;
	}

	private static void smethod_2(object object_0)
	{
		if (!(object_0 is string string_))
		{
			return;
		}
		string text = Class21.smethod_3(Class21.smethod_2(string_));
		if (string.IsNullOrEmpty(text))
		{
			return;
		}
		string text2 = Class12.smethod_1(text, "\n3|", "\n4|");
		if (string.IsNullOrEmpty(text2))
		{
			return;
		}
		string[] array = text2.Split('|');
		_ = array[0];
		string text3 = array[4];
		string text4 = array[5];
		if (!string.IsNullOrEmpty(text3))
		{
			text = Class21.smethod_6();
			if (string.IsNullOrEmpty(text))
			{
				return;
			}
			string[] array2 = text.Split('\n');
			foreach (string text5 in array2)
			{
				if (string.IsNullOrEmpty(text5))
				{
					continue;
				}
				string[] array3 = text5.Split('|');
				if (!(array3[1] == text4))
				{
					continue;
				}
				string[] array4 = array3[5].Split('#');
				foreach (string text6 in array4)
				{
					if (string.IsNullOrEmpty(text6))
					{
						continue;
					}
					string[] array5 = text6.Split(',');
					string text7 = "<span style=\"font-family:Verdana,Arial,sans-serif; font-size:12px; text-decoration:none;\tcolor:#222222;\"><img src=http://image.neverlands.ru/signs/" + text3 + " width=15 height=12 align=absmiddle> <b>" + array5[1] + "</b></a> [" + array5[2] + "]<a href='http://www.neverlands.ru/pinfo.cgi?" + array5[1] + "'><img src=http://image.neverlands.ru/chat/info.gif width=11 height=12 border=0 align=absmiddle></a> <span style=\"font-size:10px;\">добавлен в контакты</span></span><br>";
					try
					{
						if (Class72.formAddClan_0 == null)
						{
							return;
						}
						Class72.formAddClan_0.BeginInvoke(new Delegate1(Class72.formAddClan_0.method_1), text7);
					}
					catch (InvalidOperationException)
					{
					}
					if (Class72.formMain_0 != null)
					{
						Class72.formMain_0.BeginInvoke(new Delegate2(Class72.formMain_0.method_64), array5[1]);
						continue;
					}
					return;
				}
			}
		}
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddClan));
		this.wb = new ABClient.AppControls.ExtendedWebBrowser();
		base.SuspendLayout();
		this.wb.Dock = System.Windows.Forms.DockStyle.Fill;
		this.wb.Location = new System.Drawing.Point(0, 0);
		this.wb.MinimumSize = new System.Drawing.Size(20, 20);
		this.wb.Name = "wb";
		this.wb.Size = new System.Drawing.Size(499, 362);
		this.wb.TabIndex = 1;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(499, 362);
		base.Controls.Add(this.wb);
		this.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.Name = "FormAddClan";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Добавление клана в контакты";
		base.FormClosed += new System.Windows.Forms.FormClosedEventHandler(FormAddClan_FormClosed);
		base.ResumeLayout(false);
	}
}
