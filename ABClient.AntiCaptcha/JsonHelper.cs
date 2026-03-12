using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace ABClient.AntiCaptcha;

public class JsonHelper
{
	private static class Class103
	{
		public static CallSite<Func<CallSite, object, string, object>> callSite_0;

		public static CallSite<Func<CallSite, object, string, object>> callSite_1;

		public static CallSite<Func<CallSite, object, string, object>> callSite_2;

		public static CallSite<Action<CallSite, Type, string, object>> callSite_3;

		public static CallSite<Action<CallSite, Type, string, object>> callSite_4;
	}

	private static class Class104
	{
		public static CallSite<Func<CallSite, Type, object, Formatting, object>> callSite_0;

		public static CallSite<Func<CallSite, object, string>> callSite_1;
	}

	private static class Class105
	{
		public static CallSite<Func<CallSite, Type, object, string, string, object>> callSite_0;

		public static CallSite<Func<CallSite, object, string>> callSite_1;

		public static CallSite<Action<CallSite, Type, string, object>> callSite_2;
	}

	private static class Class106
	{
		public static CallSite<Func<CallSite, Type, object, string, string, bool, object>> callSite_0;

		public static CallSite<Func<CallSite, object, string>> callSite_1;

		public static CallSite<Action<CallSite, Type, string, object>> callSite_2;
	}

	public static string ExtractStr(dynamic json, string firstLevel, string secondLevel = null, bool silent = false)
	{
		string text = firstLevel + ((secondLevel == null) ? string.Empty : ("=>" + secondLevel));
		try
		{
			object obj = json[firstLevel];
			if (obj != null && secondLevel != null)
			{
				obj = json[firstLevel][secondLevel];
			}
			if (obj == null)
			{
				if (!silent)
				{
					DebugHelper.JsonFieldParseError(text, json);
				}
				return null;
			}
			return obj.ToString();
		}
		catch
		{
			if (!silent)
			{
				DebugHelper.JsonFieldParseError(text, json);
			}
			return null;
		}
	}

	public static string AsString(dynamic json)
	{
		return JsonConvert.SerializeObject(json, Formatting.Indented);
	}

	public static double? ExtractDouble(dynamic json, string firstLevel, string secondLevel = null)
	{
		string text = JsonHelper.ExtractStr(json, firstLevel, secondLevel);
		if (text != null && double.TryParse(text.Replace(',', '.'), NumberStyles.Number, CultureInfo.InvariantCulture, out var result))
		{
			return result;
		}
		string text2 = firstLevel + ((secondLevel == null) ? string.Empty : ("=>" + secondLevel));
		DebugHelper.JsonFieldParseError(text2, json);
		return null;
	}

	public static int? ExtractInt(dynamic json, string firstLevel, string secondLevel = null, bool silent = false)
	{
		if (!int.TryParse(JsonHelper.ExtractStr(json, firstLevel, secondLevel, silent), out var result))
		{
			string text = firstLevel + ((secondLevel == null) ? string.Empty : ("=>" + secondLevel));
			if (!silent)
			{
				DebugHelper.JsonFieldParseError(text, json);
			}
			return null;
		}
		return result;
	}
}
