using System;
using System.Runtime.CompilerServices;
using ABClient.AntiCaptcha;

internal sealed class Class65
{
	private static class Class66
	{
		public static CallSite<Func<CallSite, Type, object, string, object>> callSite_0;

		public static CallSite<Func<CallSite, object, int?>> callSite_1;

		public static CallSite<Func<CallSite, Type, object, string, object>> callSite_2;

		public static CallSite<Func<CallSite, object, int?>> callSite_3;

		public static CallSite<Func<CallSite, Type, object, string, object>> callSite_4;

		public static CallSite<Func<CallSite, object, string>> callSite_5;

		public static CallSite<Func<CallSite, Type, object, string, object>> callSite_6;

		public static CallSite<Func<CallSite, object, string>> callSite_7;
	}

	private int? nullable_0;

	private string string_0;

	private string string_1;

	private int? nullable_1;

	public Class65(dynamic object_0)
	{
		method_1(JsonHelper.ExtractInt(object_0, "errorId"));
		if (method_0().HasValue)
		{
			if (method_0().Equals(0))
			{
				method_7(JsonHelper.ExtractInt(object_0, "taskId"));
				return;
			}
			method_3(JsonHelper.ExtractStr(object_0, "errorCode"));
			method_5(JsonHelper.ExtractStr(object_0, "errorDescription") ?? "(no error description)");
		}
		else
		{
			DebugHelper.Out("Unknown error");
		}
	}

	public int? method_0()
	{
		return nullable_0;
	}

	private void method_1(int? nullable_2)
	{
		nullable_0 = nullable_2;
	}

	public string method_2()
	{
		return string_0;
	}

	private void method_3(string string_2)
	{
		string_0 = string_2;
	}

	public string method_4()
	{
		return string_1;
	}

	private void method_5(string string_2)
	{
		string_1 = string_2;
	}

	public int? method_6()
	{
		return nullable_1;
	}

	private void method_7(int? nullable_2)
	{
		nullable_1 = nullable_2;
	}
}
