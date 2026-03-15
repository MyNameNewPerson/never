# Building Neverlands Mobile APK

To build the Android APK, follow these steps:

## Prerequisites
- .NET 8 SDK
- Android SDK and Build-Tools (version 34.0.0 is configured)
- .NET MAUI Workloads

## Build Steps

1. **Restore Workloads**
   Open a terminal in the project root and run:
   ```bash
   dotnet workload restore NeverlandsMobile/Neverlands.Mobile/Neverlands.Mobile.csproj
   ```

2. **Generate APK**
   Run the publish command targeting Android:
   ```bash
   dotnet publish NeverlandsMobile/Neverlands.Mobile/Neverlands.Mobile.csproj -f net8.0-android -c Release
   ```

3. **Locate APK**
   The generated APK will be available at:
   `NeverlandsMobile/Neverlands.Mobile/bin/Release/net8.0-android/publish/com.neverlands.mobile-Signed.apk`

## Troubleshooting
- If you encounter "workload not installed" errors, ensure you are running the terminal as Administrator (on Windows) or with sufficient permissions.
- Ensure the `AndroidSdkBuildToolsVersion` in `Neverlands.Mobile.csproj` matches your installed SDK version if 34.0.0 is not available.
