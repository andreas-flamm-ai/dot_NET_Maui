
using Microsoft.Maui.Storage;
using WorkoutTimers.Lib.Services;

namespace WorkoutTimers.Lib.ViewModels
{
    public class SettingsModel
    {
        string _version = null;
        IVersionInfo _versionInfo;
        public SettingsModel(IVersionInfo info)
        {
            _versionInfo = info;
        }
        public string OSVersion
        {
            get
            {
                if(_version == null)
                {
                    _version = _versionInfo.GetOSVersion();
                }

                return _version;
            }
        }

        public string UserEmail
        {
            get { return Preferences.Default.Get<string>(nameof(UserEmail), ""); }
            set { Preferences.Default.Set<string>(nameof(UserEmail), value); }
        }

        public int DefaultReps
        {
            get { return Preferences.Default.Get<int>(nameof(DefaultReps), 1); }
            set { Preferences.Default.Set<int>(nameof(DefaultReps), value); }
        }

    }
}
