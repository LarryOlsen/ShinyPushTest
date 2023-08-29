using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;
using Shiny.Push;

namespace ShinyPushTest;

public class MyPushDelegate : IPushDelegate
{
    private int _pushNotificationCount = 0;

    public MyPushDelegate()
    {
    }

    public async Task OnEntry(PushNotification pushNotification)
    {
        var text = $"Push notification #{_pushNotificationCount++} received via OnEntry\n{pushNotification.Notification.Title}\n{pushNotification.Notification.Message}";
        var toast = Toast.Make(text, ToastDuration.Long);

        await toast.Show();
    }

    public async Task OnReceived(PushNotification pushNotification)
    {
        var text = $"Push notification #{_pushNotificationCount++} received via OnReceived\n{pushNotification.Notification.Title}\n{pushNotification.Notification.Message}";
        var toast = Toast.Make(text, ToastDuration.Long);

        await toast.Show();
    }

    public async Task OnTokenRefreshed(string token)
    {
        var text = $"New token received\n{token}";
        var toast = Toast.Make(text, ToastDuration.Long);

        await toast.Show();
    }
}
