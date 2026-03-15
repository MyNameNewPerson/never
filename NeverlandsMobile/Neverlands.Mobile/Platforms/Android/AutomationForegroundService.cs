#if ANDROID
using Android.App;
using Android.Content;
using Android.OS;
using Neverlands.Core.Interfaces;
using Neverlands.Automation.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Neverlands.Mobile.Platforms.Android;

[Service(Exported = false, ForegroundServiceType = global::Android.Content.PM.ForegroundService.TypeDataSync)]
public class AutomationForegroundService : Service {
    private bool _isRunning;
    private CancellationTokenSource? _cts;
    private IBackgroundAutomationManager? _automationManager;

    public override IBinder? OnBind(Intent? intent) => null;

    public override void OnCreate()
    {
        base.OnCreate();
        _automationManager = MauiProgram.ServiceProvider?.GetService<IBackgroundAutomationManager>();
    }

    public override StartCommandResult OnStartCommand(Intent? intent, StartCommandFlags flags, int startId) {
        if (!_isRunning) {
            _isRunning = true;
            _cts = new CancellationTokenSource();
            RegisterForegroundService();

            _automationManager?.Start();
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

        if (Build.VERSION.SdkInt >= BuildVersionCodes.Q)
        {
            StartForeground(1, notification, global::Android.Content.PM.ForegroundService.TypeDataSync);
        }
        else
        {
            StartForeground(1, notification);
        }
    }

    private void StartAutomationLoop(CancellationToken token) {
        Task.Run(async () => {
            try
            {
                while (!token.IsCancellationRequested)
                {
                    // The actual work is handled by BackgroundAutomationManager
                    // This loop just keeps the service alive if needed,
                    // though BackgroundAutomationManager has its own loop.
                    await Task.Delay(5000, token);
                }
            }
            catch (OperationCanceledException) { }
            finally
            {
                _isRunning = false;
                _automationManager?.Stop();
                StopForeground(StopForegroundFlags.Remove);
                StopSelf();
            }
        }, token);
    }

    public override void OnDestroy() {
        _cts?.Cancel();
        _automationManager?.Stop();
        _isRunning = false;
        base.OnDestroy();
    }
}
#endif
