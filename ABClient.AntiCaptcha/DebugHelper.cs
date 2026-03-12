using System;
using System.Runtime.CompilerServices;

namespace ABClient.AntiCaptcha;

public class DebugHelper
{
	private static class Class102
	{
		public static CallSite<Func<CallSite, Type, object, object>> callSite_0;

		public static CallSite<Func<CallSite, string, object, object>> callSite_1;

		public static CallSite<Func<CallSite, object, string>> callSite_2;
	}

	public static void JsonFieldParseError(string field, dynamic submitResult)
	{
		Out(field + " could not be parsed. Raw response: " + JsonHelper.AsString(submitResult));
	}

	public static void Out(string message)
	{
		Class72.formMain_0.method_63(message);
	}
}
