using mGISv3.Debugging;

namespace mGISv3
{
    public class mGISv3Consts
    {
        public const string LocalizationSourceName = "mGISv3";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "ccb9d77d62554e44bf75cbdcdd15a15c";
    }
}
