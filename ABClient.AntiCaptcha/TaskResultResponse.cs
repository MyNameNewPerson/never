using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Linq;

namespace ABClient.AntiCaptcha;

public class TaskResultResponse
{
	private static class Class107
	{
		public static CallSite<Func<CallSite, Type, object, string, object>> callSite_0;

		public static CallSite<Func<CallSite, object, int?>> callSite_1;

		public static CallSite<Func<CallSite, Type, object, string, object>> callSite_2;

		public static CallSite<Func<CallSite, TaskResultResponse, object, object>> callSite_3;

		public static CallSite<Func<CallSite, object, StatusType?>> callSite_4;

		public static CallSite<Func<CallSite, Type, object, string, object>> callSite_5;

		public static CallSite<Func<CallSite, object, double?>> callSite_6;

		public static CallSite<Func<CallSite, Type, object, string, object, bool, object>> callSite_7;

		public static CallSite<Func<CallSite, object, string>> callSite_8;

		public static CallSite<Func<CallSite, Type, object, string, object, bool, object>> callSite_9;

		public static CallSite<Func<CallSite, object, int?>> callSite_10;

		public static CallSite<Func<CallSite, Type, object, string, object>> callSite_11;

		public static CallSite<Func<CallSite, TaskResultResponse, object, object>> callSite_12;

		public static CallSite<Func<CallSite, object, DateTime?>> callSite_13;

		public static CallSite<Func<CallSite, Type, object, string, object>> callSite_14;

		public static CallSite<Func<CallSite, TaskResultResponse, object, object>> callSite_15;

		public static CallSite<Func<CallSite, object, DateTime?>> callSite_16;

		public static CallSite<Func<CallSite, Type, object, string, string, bool, object>> callSite_17;

		public static CallSite<Func<CallSite, object, string>> callSite_18;

		public static CallSite<Func<CallSite, Type, object, string, string, bool, object>> callSite_19;

		public static CallSite<Func<CallSite, object, string>> callSite_20;

		public static CallSite<Func<CallSite, Type, object, string, string, bool, object>> callSite_21;

		public static CallSite<Func<CallSite, object, string>> callSite_22;

		public static CallSite<Func<CallSite, Type, object, string, string, bool, object>> callSite_23;

		public static CallSite<Func<CallSite, object, string>> callSite_24;

		public static CallSite<Func<CallSite, Type, object, string, string, bool, object>> callSite_25;

		public static CallSite<Func<CallSite, object, string>> callSite_26;

		public static CallSite<Func<CallSite, object, object>> callSite_27;

		public static CallSite<Func<CallSite, object, object>> callSite_28;

		public static CallSite<Func<CallSite, object, JObject>> callSite_29;

		public static CallSite<Func<CallSite, Type, object, string, object>> callSite_30;

		public static CallSite<Func<CallSite, object, string>> callSite_31;

		public static CallSite<Func<CallSite, Type, object, string, object>> callSite_32;

		public static CallSite<Func<CallSite, object, string>> callSite_33;
	}

	public class SolutionData
	{
		private JObject jobject_0;

		private string string_0;

		private string string_1;

		private string string_2;

		private string string_3;

		private string string_4;

		public JObject Answers
		{
			[CompilerGenerated]
			get
			{
				return jobject_0;
			}
		}

		public string GRecaptchaResponse
		{
			[CompilerGenerated]
			get
			{
				return string_0;
			}
		}

		public string GRecaptchaResponseMd5
		{
			[CompilerGenerated]
			get
			{
				return string_1;
			}
		}

		public string Text
		{
			[CompilerGenerated]
			get
			{
				return string_2;
			}
		}

		public string Url
		{
			[CompilerGenerated]
			get
			{
				return string_3;
			}
		}

		public string Token
		{
			[CompilerGenerated]
			get
			{
				return string_4;
			}
		}

		internal void method_0(JObject jobject_1)
		{
			jobject_0 = jobject_1;
		}

		internal void method_1(string string_5)
		{
			string_0 = string_5;
		}

		internal void method_2(string string_5)
		{
			string_1 = string_5;
		}

		internal void method_3(string string_5)
		{
			string_2 = string_5;
		}

		internal void method_4(string string_5)
		{
			string_3 = string_5;
		}

		internal void method_5(string string_5)
		{
			string_4 = string_5;
		}
	}

	public enum StatusType
	{
		Processing,
		Ready
	}

	public int? ErrorId { get; }

	public string ErrorCode { get; private set; }

	public string ErrorDescription { get; }

	public StatusType? Status { get; }

	public SolutionData Solution { get; }

	public double? Cost { get; private set; }

	public string Ip { get; private set; }

	public DateTime? CreateTime { get; private set; }

	public DateTime? EndTime { get; private set; }

	public int? SolveCount { get; private set; }

	public TaskResultResponse(dynamic json)
	{
		ErrorId = JsonHelper.ExtractInt(json, "errorId");
		if (ErrorId.HasValue)
		{
			if (ErrorId.Equals(0))
			{
				Status = ParseStatus(JsonHelper.ExtractStr(json, "status"));
				if (Status.Equals(StatusType.Ready))
				{
					Cost = JsonHelper.ExtractDouble(json, "cost");
					Ip = JsonHelper.ExtractStr(json, "ip", null, true);
					SolveCount = JsonHelper.ExtractInt(json, "solveCount", null, true);
					CreateTime = UnixTimeStampToDateTime(JsonHelper.ExtractDouble(json, "createTime"));
					EndTime = UnixTimeStampToDateTime(JsonHelper.ExtractDouble(json, "endTime"));
					SolutionData solutionData = new SolutionData();
					solutionData.method_5(JsonHelper.ExtractStr(json, "solution", "token", true));
					solutionData.method_1(JsonHelper.ExtractStr(json, "solution", "gRecaptchaResponse", silent: true));
					solutionData.method_2(JsonHelper.ExtractStr(json, "solution", "gRecaptchaResponseMd5", silent: true));
					solutionData.method_3(JsonHelper.ExtractStr(json, "solution", "text", silent: true));
					solutionData.method_4(JsonHelper.ExtractStr(json, "solution", "url", silent: true));
					Solution = solutionData;
					try
					{
						Solution.method_0(json.solution.answers);
					}
					catch
					{
						Solution.method_0(null);
					}
					if (Solution.GRecaptchaResponse == null && Solution.Text == null && Solution.Answers == null && Solution.Token == null)
					{
						DebugHelper.Out("Got no 'solution' field from API");
					}
				}
			}
			else
			{
				ErrorCode = JsonHelper.ExtractStr(json, "errorCode");
				ErrorDescription = JsonHelper.ExtractStr(json, "errorDescription") ?? "(no error description)";
				DebugHelper.Out(ErrorDescription);
			}
		}
		else
		{
			DebugHelper.Out("Unknown error");
		}
	}

	private StatusType? ParseStatus(string status)
	{
		if (string.IsNullOrEmpty(status))
		{
			return null;
		}
		try
		{
			return (StatusType)Enum.Parse(typeof(StatusType), CultureInfo.CurrentCulture.TextInfo.ToTitleCase(status), ignoreCase: true);
		}
		catch
		{
			return null;
		}
	}

	private static DateTime? UnixTimeStampToDateTime(double? unixTimeStamp)
	{
		if (!unixTimeStamp.HasValue)
		{
			return null;
		}
		return new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc).AddSeconds(unixTimeStamp.Value).ToUniversalTime();
	}
}
