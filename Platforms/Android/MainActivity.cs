using Android.App;
using Android.Content.PM;
using Android.OS;

namespace ShinyPushTest;

[Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
[IntentFilter(new[] { Shiny.ShinyPushIntents.NotificationClickAction })]
public class MainActivity : MauiAppCompatActivity
{
}

