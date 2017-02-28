namespace DBTek.BugGuardian.MVC.Config
{
    /// <summary>
    /// This class represents the structure of the BugGuardian settings structure 
    /// in the Web.config or App.config. These are the attributes.
    /// </summary>
    public class BugGuardianSettingElements : System.Configuration.ConfigurationElement
    {
        /// <summary>
        /// Returns the key value.
        /// </summary>
        [System.Configuration.ConfigurationProperty("key", IsRequired = true)]
        public string Key
            => this["key"] as string;

        /// <summary>
        /// Returns the setting value.
        /// </summary>
        [System.Configuration.ConfigurationProperty("value", IsRequired = true)]
        public string Value
            => this["value"] as string;
    }
}
