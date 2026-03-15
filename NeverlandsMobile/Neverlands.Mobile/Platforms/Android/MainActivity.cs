using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;
using Microsoft.Maui;

namespace Neverlands.Mobile;

[Activity(Theme = "@style/Maui.MainTheme.NoActionBar", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
[Register("com.neverlands.mobile.MainActivity")]
public class MainActivity : MauiAppCompatActivity
{
}
