# Technical Investigation Report: Auto Woodcutting Captcha Issue

## 1. Explanation of the Original Problem

The auto woodcutting feature was failing because the client's integration with the Anti-Captcha service was outdated and non-functional.

Specifically:
- **Incorrect API Endpoint**: The client was sending requests to a hardcoded IP address (`88.198.203.65`) over HTTP, instead of the official `https://api.anti-captcha.com/` endpoint.
- **Outdated API Logic**: The implementation used a custom `HttpWebRequest` wrapper with manual JSON construction and synchronous polling, which was prone to failures and didn't strictly follow the current Anti-Captcha API v2 workflow.
- **Lack of Error Handling**: Errors from the API were often ignored or not properly reported, making it difficult to diagnose why the solver was failing.
- **Blocking Thread**: The worker thread used `Thread.Sleep`, which is less efficient than modern `Task.Delay`.

## 2. Exact Location in Code where the Issue Occurs

- **`Class50.cs`**: Line 64 defined the outdated IP address `88.198.203.65:80`.
- **`Class50.cs`**: Line 194 constructed the full URI using this IP and HTTP protocol.
- **`ABClient/ScriptManager.cs`**: Lines 671-694 contained the logic that initiated the captcha solving process, which relied on the broken `Class50`.
- **`iBClient.csproj`**: The project targeted `net40`, which limited the use of modern libraries like `HttpClient` and `async/await` patterns.

## 3. The Corrected Implementation

The integration has been updated to use the official Anti-Captcha API v2:
- **Endpoints**:
  - Task Creation: `POST https://api.anti-captcha.com/createTask`
  - Result Polling: `POST https://api.anti-captcha.com/getTaskResult`
- **Workflow**:
  1. Captcha image is extracted from `Class72.smethod_24()`.
  2. A task is created via `CreateTaskAsync`, sending the image as a base64 string.
  3. The service receives a `taskId`.
  4. The service polls `getTaskResult` every 2-5 seconds until the status is `ready`.
  5. The solution text is extracted and returned to the woodcutting logic.

## 4. Refactored AntiCaptcha Service Class

A new service class `ABClient.AntiCaptcha.AntiCaptchaService` was created to encapsulate the logic:

```csharp
public class AntiCaptchaService
{
    private static readonly HttpClient _httpClient = new HttpClient { Timeout = TimeSpan.FromSeconds(30) };
    private readonly string _clientKey;
    private const string BaseUrl = "https://api.anti-captcha.com/";

    public AntiCaptchaService(string clientKey) { ... }
    public async Task<int?> CreateTaskAsync(byte[] imageBytes) { ... }
    public async Task<JObject?> GetTaskResultAsync(int taskId) { ... }
    public async Task<string?> SolveCaptchaAsync(byte[] imageBytes) { ... }
}
```

- **Modern C#**: Uses `HttpClient`, `async/await`, and `Task.Run` for non-blocking execution.
- **Namespace**: Logic is now properly organized under `ABClient.AntiCaptcha`.
- **Readability**: `Class65` was renamed to `CreateTaskResponse` with meaningful property names.

## 5. Steps Required to Build and Test the Project

1. **Prerequisites**: .NET 8 SDK or later installed on a Windows environment (or Linux with Windows targeting enabled).
2. **Configuration**: Ensure your Anti-Captcha API key is correctly entered in the client settings (stored in the profile's `anticaptchakey` field).
3. **Build**:
   ```bash
   dotnet build iBClient.csproj
   ```
4. **Execution**: Run `iBClient.exe`. The auto woodcutting feature will now use the new `AntiCaptchaService` when a captcha is detected.
5. **Verification**: When woodcutting, if a captcha appears, the log window should show "Captcha task created" followed by "Captcha solved successfully" and the resulting code.
