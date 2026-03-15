using System;
using System.Text;

internal sealed class Class69
{
	internal DateTime dateTime_0 = DateTime.MinValue;

	internal string string_0 = string.Empty;

	internal string string_1 = string.Empty;

	internal int int_0;

	internal bool bool_0;

	internal int int_1;

	internal string string_2 = string.Empty;

	internal string string_3 = string.Empty;

	internal int int_2;

	internal bool bool_1;

	internal bool bool_2;

	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append(int_2);
		if (bool_0)
		{
			stringBuilder.Append('*');
		}
		stringBuilder.Append(") Еще ");
		DateTime dateTime = dateTime_0;
		if (dateTime < DateTime.Now)
		{
			if (bool_1)
			{
				TimeSpan timeSpan = dateTime_0.Subtract(DateTime.Now);
				if (timeSpan.Hours > 0)
				{
					stringBuilder.AppendFormat("{0}:{1:00}:{2:00} (?)", (int)timeSpan.TotalHours, timeSpan.Minutes, timeSpan.Seconds);
				}
				else if (timeSpan.Minutes > 0)
				{
					stringBuilder.AppendFormat("{0}:{1:00} (?)", timeSpan.Minutes, timeSpan.Seconds);
				}
				else
				{
					stringBuilder.AppendFormat("0:{0:00} (?)", timeSpan.Seconds);
				}
			}
			else
			{
				stringBuilder.Append("0:00");
			}
		}
		else
		{
			TimeSpan timeSpan2 = dateTime.Subtract(DateTime.Now);
			if (timeSpan2.Hours > 0)
			{
				stringBuilder.AppendFormat("{0}:{1:00}:{2:00}", (int)timeSpan2.TotalHours, timeSpan2.Minutes, timeSpan2.Seconds);
			}
			else if (timeSpan2.Minutes > 0)
			{
				stringBuilder.AppendFormat("{0}:{1:00}", timeSpan2.Minutes, timeSpan2.Seconds);
			}
			else
			{
				stringBuilder.AppendFormat("0:{0:00}", timeSpan2.Seconds);
			}
		}
		stringBuilder.Append(" - ");
		stringBuilder.Append(string_0);
		if (int_0 > 1)
		{
			stringBuilder.AppendFormat(" [{0}]", int_0);
		}
		return stringBuilder.ToString();
	}
}
