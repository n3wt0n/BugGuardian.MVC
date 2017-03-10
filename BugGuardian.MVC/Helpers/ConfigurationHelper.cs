namespace DBTek.BugGuardian.MVC.Helpers
{
    public class ConfigurationHelper
    {
        private const string DefaultCollectionName = "DefaultCollection";

        public static string Url
            => Config.ConfigurationSettings.AppSettings["Url"];

        public static string Username
           => Config.ConfigurationSettings.AppSettings["Username"];

        public static string Password
           => Config.ConfigurationSettings.AppSettings["Password"];

        public static string CollectiontName
           => Config.ConfigurationSettings.AppSettings["CollectiontName"] ?? DefaultCollectionName;

        public static string ProjectName
           => Config.ConfigurationSettings.AppSettings["ProjectName"];

        public static bool AvoidMultipleReport
           => bool.Parse(Config.ConfigurationSettings.AppSettings["AvoidMultipleReport"] ?? "true");

        public static bool AssignToCurrentIteration
           => bool.Parse(Config.ConfigurationSettings.AppSettings["AssignToCurrentIteration"] ?? "true");
    }
}
