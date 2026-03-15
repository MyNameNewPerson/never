# Building Neverlands Mobile APK

To build the Android APK, follow these steps:

## Prerequisites
- .NET 8 SDK (or newer, but the project targets net8.0)
- Android SDK and Build-Tools (version 34.0.0 is configured)
- .NET MAUI Workloads

## Build Steps

Run these commands from the solution root directory (`NeverlandsMobile/`):

1. **Restore Workloads**
   ```bash
   dotnet workload restore Neverlands.Mobile/Neverlands.Mobile.csproj
   ```

2. **Generate APK**
   Run the publish command targeting Android. We use `<CheckEolTargetFramework>false</CheckEolTargetFramework>` in the project file to allow building with newer .NET SDKs (like .NET 9 or 10) even though net8.0 is in maintenance.
   ```bash
   dotnet publish Neverlands.Mobile/Neverlands.Mobile.csproj -f net8.0-android -c Release
   ```

3. **Locate APK**
   The generated APK will be available at:
   `Neverlands.Mobile/bin/Release/net8.0-android/publish/com.neverlands.mobile-Signed.apk`

## Troubleshooting
- **NU1015**: If you see errors about missing PackageReference versions, ensure `Microsoft.Maui.Controls` has an explicit version (e.g., `8.0.82`) in the `.csproj`.
- **NETSDK1202**: If you see EOL (End of Life) errors, ensure `<CheckEolTargetFramework>false</CheckEolTargetFramework>` is present in the `<PropertyGroup>` of your `.csproj`.
- **Workload errors**: If workloads fail to install, try running `dotnet workload install android maui` manually.
