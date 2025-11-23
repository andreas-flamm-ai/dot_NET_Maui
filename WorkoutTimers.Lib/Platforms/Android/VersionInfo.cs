namespace WorkoutTimers.Lib
{
    // All the code in this file is only included on Android.
    public class VersionInfo : Services.IVersionInfo
    {
        public string GetOSVersion()
        {
            return Android.OS.Build.VERSION.Release;
        }
    }
}