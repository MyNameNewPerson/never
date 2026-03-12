using System;
using ABClient.AntiCaptcha;

namespace ABClient.AntiCaptcha;

public sealed class CreateTaskResponse
{
    public int? ErrorId { get; private set; }
    public string ErrorCode { get; private set; }
    public string ErrorDescription { get; private set; }
    public int? TaskId { get; private set; }

    public CreateTaskResponse(dynamic json)
    {
        ErrorId = JsonHelper.ExtractInt(json, "errorId");
        if (ErrorId.HasValue)
        {
            if (ErrorId.Value == 0)
            {
                TaskId = JsonHelper.ExtractInt(json, "taskId");
                return;
            }
            ErrorCode = JsonHelper.ExtractStr(json, "errorCode");
            ErrorDescription = JsonHelper.ExtractStr(json, "errorDescription") ?? "(no error description)";
        }
        else
        {
            DebugHelper.Out("Unknown error in CreateTaskResponse");
        }
    }
}
