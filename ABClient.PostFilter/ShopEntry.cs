using System;

namespace ABClient.PostFilter;

public class ShopEntry : IComparable
{
	public string Name;

	public string Price;

	public string SellCall;

	public string Dolg;

	public bool IsMarket;

	private readonly string string_0;

	private int int_0;

	public ShopEntry(string html)
	{
		string_0 = html;
		int_0 = 1;
		Name = Class12.smethod_1(html, "<font class=nickname><b>", "</b>");
		if (html.Contains("Выставить на продажу"))
		{
			IsMarket = true;
			Price = Class12.smethod_1(html, "Цена: <input type=\"text\" value=\"", "\"");
			SellCall = Class12.smethod_1(html, " onclick=\"place_item_put(", ")\"");
			Dolg = Class12.smethod_1(html, "Долговечность: ", "\"");
		}
		else
		{
			IsMarket = false;
			Price = Class12.smethod_1(html, "value=\"Продать за ", " NV\">");
			SellCall = Class12.smethod_1(html, " onclick=\"shop_item_sell(", ")\" ");
		}
	}

	public int CompareTo(object obj)
	{
		if (!(obj is ShopEntry))
		{
			return 1;
		}
		ShopEntry shopEntry = (ShopEntry)obj;
		if (!string.IsNullOrEmpty(Price) && !string.IsNullOrEmpty(shopEntry.Price))
		{
			int num = string.Compare(Name, shopEntry.Name, StringComparison.Ordinal);
			if (num != 0)
			{
				return num;
			}
			num = string.Compare(Price, shopEntry.Price, StringComparison.CurrentCultureIgnoreCase);
			if (num == 0)
			{
				return string.Compare(Dolg, shopEntry.Dolg, StringComparison.CurrentCultureIgnoreCase);
			}
			return num;
		}
		return 1;
	}

	public override string ToString()
	{
		if (int_0 != 1 && !string.IsNullOrEmpty(Price))
		{
			int num = string_0.IndexOf("<font class=nickname><b>", StringComparison.CurrentCultureIgnoreCase);
			if (num != -1)
			{
				num = string_0.IndexOf("</b>", num, StringComparison.CurrentCultureIgnoreCase);
				if (num != -1)
				{
					string text = string_0.Insert(num, $" ({int_0} шт.)");
					int num2 = text.IndexOf("<input type=button class=invbut onclick=\"shop_item_sell", StringComparison.CurrentCultureIgnoreCase);
					if (num2 != -1)
					{
						int num3 = text.IndexOf('>', num2);
						if (num3 != -1)
						{
							string value = "&nbsp;<input type=button class=invbut onclick=\"javascript: window.external.StartBulkOldSell('" + Name + "', '" + Price + "'); shop_item_sell(" + SellCall + "); \" value=\"Продать все\">";
							text = text.Insert(num3 + 1, value);
						}
					}
					else
					{
						num2 = text.IndexOf("<input type=button class=invbut onclick=\"place_item_put", StringComparison.CurrentCultureIgnoreCase);
						if (num2 != -1)
						{
							int num4 = text.IndexOf('>', num2);
							if (num4 != -1)
							{
								string text2 = Class12.smethod_1(SellCall, ", ", ",");
								string value2 = "&nbsp;<input type=button class=invbut onclick=\"javascript: window.external.StartMarketPut('" + Name + "', '" + Price + "', '" + Dolg + "', " + text2 + "); place_item_put(" + SellCall + "); \" value=\"Выставить все\">";
								text = text.Insert(num4 + 1, value2);
							}
						}
					}
					return text;
				}
			}
			return string_0;
		}
		return string_0;
	}

	internal void method_0()
	{
		int_0++;
	}
}
