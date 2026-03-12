using System;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using ABClient.AntiCaptcha;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

internal sealed class Class50
{
	private static class Class51
	{
		public static CallSite<Func<CallSite, object, object, object>> callSite_0;

		public static CallSite<Func<CallSite, object, bool, object>> callSite_1;

		public static CallSite<Func<CallSite, object, object, object>> callSite_2;

		public static CallSite<Func<CallSite, object, bool>> callSite_3;

		public static CallSite<Func<CallSite, object, bool>> callSite_4;

		public static CallSite<Func<CallSite, Type, object, Class65>> callSite_5;

		public static CallSite<Action<CallSite, Type, string, object>> callSite_6;
	}

	private static class Class52
	{
		public static CallSite<Func<CallSite, object, object, object>> callSite_0;

		public static CallSite<Func<CallSite, object, bool, object>> callSite_1;

		public static CallSite<Func<CallSite, object, object, object>> callSite_2;

		public static CallSite<Func<CallSite, object, bool>> callSite_3;

		public static CallSite<Func<CallSite, object, bool>> callSite_4;

		public static CallSite<Func<CallSite, Type, object, TaskResultResponse>> callSite_5;
	}

	private static class Class53
	{
		public static CallSite<Func<CallSite, object, object, object>> callSite_0;

		public static CallSite<Func<CallSite, object, bool>> callSite_1;
	}

	private enum Enum3
	{

	}

	private enum ApiMethod
	{
		CreateTask,
		GetTaskResult,
		GetBalance
	}

	private readonly string string_0 = "88.198.203.65:80";

	private string string_1;

	private int int_0;

	private TaskResultResponse taskResultResponse_0;

	public string method_0()
	{
		return string_1;
	}

	private void method_1(string string_2)
	{
		string_1 = string_2;
	}

	public int method_2()
	{
		return int_0;
	}

	private void method_3(int int_1)
	{
		int_0 = int_1;
	}

	public TaskResultResponse method_4()
	{
		return taskResultResponse_0;
	}

	protected void method_5(TaskResultResponse taskResultResponse_1)
	{
		taskResultResponse_0 = taskResultResponse_1;
	}

	public bool method_6()
	{
		JObject jObject = method_9();
		if (jObject == null)
		{
			DebugHelper.Out("A task preparing error.");
			return false;
		}
		JObject jobject_ = new JObject
		{
			["clientKey"] = Class72.class19_0.method_198(),
			["task"] = jObject
		};
		dynamic val = method_8(ApiMethod.CreateTask, jobject_);
		dynamic val2 = val == null;
		if (!(val2 ? true : false) && !((val2 | val.Equals(false)) ? true : false))
		{
			Class65 @class = new Class65(val);
			if (!@class.method_0().Equals(0))
			{
				method_1(@class.method_4());
				DebugHelper.Out("API error " + @class.method_0() + ": " + @class.method_4());
				return false;
			}
			if (!@class.method_6().HasValue)
			{
				DebugHelper.JsonFieldParseError("taskId", val);
				return false;
			}
			method_3(@class.method_6().Value);
			return true;
		}
		DebugHelper.Out("API error");
		return false;
	}

	public bool method_7(int int_1, int int_2)
	{
		if (int_2 >= int_1)
		{
			DebugHelper.Out("Time's out.");
			return false;
		}
		if (int_2.Equals(0))
		{
			Thread.Sleep(5000);
		}
		else
		{
			Thread.Sleep(1000);
		}
		JObject jobject_ = new JObject
		{
			["clientKey"] = Class72.class19_0.method_198(),
			["taskId"] = method_2()
		};
		dynamic val = method_8(ApiMethod.GetTaskResult, jobject_);
		dynamic val2 = val == null;
		if (!(val2 ? true : false) && !((val2 | val.Equals(false)) ? true : false))
		{
			method_5(new TaskResultResponse(val));
			if (!method_4().ErrorId.Equals(0))
			{
				method_1(method_4().ErrorDescription);
				DebugHelper.Out("API error " + method_4().ErrorId + ": " + method_0());
				return false;
			}
			if (method_4().Status.Equals(TaskResultResponse.StatusType.Processing))
			{
				return method_7(int_1, int_2 + 1);
			}
			if (method_4().Status.Equals(TaskResultResponse.StatusType.Ready))
			{
				if (method_4().Solution.GRecaptchaResponse == null && method_4().Solution.Text == null && method_4().Solution.Answers == null && method_4().Solution.Token == null)
				{
					DebugHelper.Out("Got no 'solution' field from API");
					return false;
				}
				return true;
			}
			method_1("An unknown API status, please update your software");
			DebugHelper.Out(method_0());
			return false;
		}
		DebugHelper.Out("API error");
		return false;
	}

	private dynamic method_8(ApiMethod apiMethod_0, JObject jobject_0)
	{
		string text = char.ToLowerInvariant(apiMethod_0.ToString()[0]) + apiMethod_0.ToString().Substring(1);
		string string_;
		dynamic val = smethod_0(new Uri("http://" + string_0 + "/" + text), JsonConvert.SerializeObject(jobject_0, Formatting.Indented), out string_);
		if (string.IsNullOrEmpty(string_))
		{
			if (!((val == null) ? true : false))
			{
				return val;
			}
			string_ = "Got empty or invalid response from API";
		}
		else
		{
			string_ = "HTTP or JSON error: " + string_;
		}
		DebugHelper.Out(string_);
		return false;
	}

	private static dynamic smethod_0(Uri uri_0, string string_2, out string string_3)
	{
		string_3 = null;
		object obj = null;
		byte[] bytes = Encoding.UTF8.GetBytes(string_2);
		HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(uri_0);
		httpWebRequest.Method = "POST";
		httpWebRequest.ContentType = "application/json";
		httpWebRequest.ContentLength = bytes.Length;
		httpWebRequest.Timeout = 30000;
		try
		{
			using (Stream stream = httpWebRequest.GetRequestStream())
			{
				stream.Write(bytes, 0, bytes.Length);
				stream.Close();
			}
			using HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
			obj = JsonConvert.DeserializeObject(new StreamReader(httpWebResponse.GetResponseStream(), Encoding.UTF8).ReadToEnd());
			httpWebResponse.Close();
			return obj;
		}
		catch (Exception ex)
		{
			string_3 = ex.Message;
			return false;
		}
	}

	private JObject method_9()
	{
		if (Class72.smethod_24() == null)
		{
			return null;
		}
		string text = Convert.ToBase64String(Class72.smethod_24()).Replace("\r", string.Empty).Replace("\n", string.Empty);
		return new JObject
		{
			{ "type", "ImageToTextTask" },
			{ "body", text },
			{ "phrase", false },
			{ "case", false },
			{ "numeric", 1 },
			{ "math", false },
			{ "minLength", 5 },
			{ "maxLength", 5 }
		};
	}

	public TaskResultResponse.SolutionData method_10()
	{
		return method_4().Solution;
	}
}
