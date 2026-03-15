#if ANDROID
using Android.App;
using Android.Content;
using Android.OS;
using Neverlands.Core.Interfaces;
namespace Neverlands.Mobile.Platforms.Android;
[Service(Exported = false, ForegroundServiceType = global::Android.Content.PM.ForegroundService.TypeDataSync)]
public class AutomationForegroundService : Service {
    private bool _isRunning;
    private CancellationTokenSource? _cts;
    public override IBinder? OnBind(Intent? intent) => null;
    public override StartCommandResult OnStartCommand(Intent? intent, StartCommandFlags flags, int startId) {
        if (!_isRunning) {
            _isRunning = true;
            _cts = new CancellationTokenSource();
            RegisterForegroundService();
            StartAutomationLoop(_cts.Token);
        }
        return StartCommandResult.Sticky;
    }
    private void RegisterForegroundService() {
        var channelId = "automation_channel";
        var notificationManager = GetSystemService(NotificationService) as NotificationManager;
        if (Build.VERSION.SdkInt >= BuildVersionCodes.O) {
            var channel = new NotificationChannel(channelId, "Neverlands Automation", NotificationImportance.Low);
            notificationManager?.CreateNotificationChannel(channel);
        }
        var notification = new Notification.Builder(this, channelId)
            .SetContentTitle("Neverlands Automation")
            .SetContentText("Automation loop active")
            .SetSmallIcon(global::Android.Resource.Drawable.IcMenuRotate)
            .SetOngoing(true).Build();
        StartForeground(1, notification);
    }
    private void StartAutomationLoop(CancellationToken token) {
        Task.Run(async () => {
            try { while (!token.IsCancellationRequested) { await Task.Delay(5000, token); } }
            catch (System.OperationCanceledException) { }
            finally { _isRunning = false; StopForeground(StopForegroundFlags.Remove); StopSelf(); }
        }, token);
    }
    public override void OnDestroy() { _cts?.Cancel(); _isRunning = false; base.OnDestroy(); }
}
#endif
