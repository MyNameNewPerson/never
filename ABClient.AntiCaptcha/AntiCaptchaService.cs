using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ABClient.AntiCaptcha
{
    public class AntiCaptchaService
    {
        private static readonly HttpClient _httpClient = new HttpClient { Timeout = TimeSpan.FromSeconds(30) };
        private readonly string _clientKey;
        private const string BaseUrl = "https://api.anti-captcha.com/";

        public AntiCaptchaService(string clientKey)
        {
            _clientKey = clientKey;
        }

        public async Task<int?> CreateTaskAsync(byte[] imageBytes)
        {
            var body = Convert.ToBase64String(imageBytes);
            var requestObj = new
            {
                clientKey = _clientKey,
                task = new
                {
                    type = "ImageToTextTask",
                    body = body,
                    phrase = false,
                    @case = false,
                    numeric = 1,
                    math = false,
                    minLength = 5,
                    maxLength = 5
                }
            };

            var json = JsonConvert.SerializeObject(requestObj);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            try
            {
                var response = await _httpClient.PostAsync(BaseUrl + "createTask", content);
                response.EnsureSuccessStatusCode();
                var responseJson = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<JObject>(responseJson);

                if (result != null && result["errorId"]?.Value<int>() == 0)
                {
                    return result["taskId"]?.Value<int>();
                }

                var errorDescription = result?["errorDescription"]?.Value<string>() ?? "Unknown error";
                DebugHelper.Out($"Anti-Captcha error: {errorDescription}");
                return null;
            }
            catch (Exception ex)
            {
                DebugHelper.Out($"Failed to create captcha task: {ex.Message}");
                return null;
            }
        }

        public async Task<JObject?> GetTaskResultAsync(int taskId)
        {
            var requestObj = new
            {
                clientKey = _clientKey,
                taskId = taskId
            };

            var json = JsonConvert.SerializeObject(requestObj);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            try
            {
                var response = await _httpClient.PostAsync(BaseUrl + "getTaskResult", content);
                response.EnsureSuccessStatusCode();
                var responseJson = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<JObject>(responseJson);
            }
            catch (Exception ex)
            {
                DebugHelper.Out($"Failed to get captcha result: {ex.Message}");
                return null;
            }
        }

        public async Task<string?> SolveCaptchaAsync(byte[] imageBytes)
        {
            var taskId = await CreateTaskAsync(imageBytes);
            if (!taskId.HasValue)
            {
                return null;
            }

            DebugHelper.Out($"Captcha task created. ID: {taskId.Value}");

            for (int i = 0; i < 60; i++)
            {
                await Task.Delay(i == 0 ? 5000 : 2000);
                var result = await GetTaskResultAsync(taskId.Value);
                if (result == null)
                {
                    continue;
                }

                if (result["errorId"]?.Value<int>() != 0)
                {
                    var errorDescription = result["errorDescription"]?.Value<string>() ?? "Unknown error";
                    DebugHelper.Out($"Anti-Captcha polling error: {errorDescription}");
                    return null;
                }

                var status = result["status"]?.Value<string>();
                if (status == "ready")
                {
                    var solution = result["solution"]?["text"]?.Value<string>();
                    if (!string.IsNullOrEmpty(solution))
                    {
                        DebugHelper.Out($"Captcha solved successfully.");
                        return solution;
                    }

                    DebugHelper.Out("Got empty solution from Anti-Captcha");
                    return null;
                }

                if (status != "processing")
                {
                    DebugHelper.Out($"Unknown Anti-Captcha status: {status}");
                    return null;
                }
            }

            DebugHelper.Out("Timeout waiting for captcha solution");
            return null;
        }
    }
}
