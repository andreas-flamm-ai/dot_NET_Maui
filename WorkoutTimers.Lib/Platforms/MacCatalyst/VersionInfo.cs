using Foundation;
using Microsoft.Maui.Controls.PlatformConfiguration;

namespace WorkoutTimers.Lib
{
    // All the code in this file is only included on iOS.
    public class VersionInfo : Services.IVersionInfo
    {
        public string GetOSVersion()
        {
            return NSProcessInfo.ProcessInfo.OperatingSystemName;
        }
    }
}