using Resumification.Debugging;

namespace Resumification
{
    public class ResumificationConsts
    {
        public const string LocalizationSourceName = "Resumification";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "5a4bbf7bdf3a4852a1158a84b4415ed6";
    }
}
