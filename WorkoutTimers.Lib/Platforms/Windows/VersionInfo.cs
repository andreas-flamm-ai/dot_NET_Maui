using Microsoft.Maui.Controls.PlatformConfiguration;

namespace WorkoutTimers.Lib
{
    // All the code in this file is only included on Windows.
    public class VersionInfo : Services.IVersionInfo
    {
        public string GetOSVersion()
        {
            return String.Empty;
        }
    }
}