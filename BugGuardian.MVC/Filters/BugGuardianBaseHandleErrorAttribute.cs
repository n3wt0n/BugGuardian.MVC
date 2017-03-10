using DBTek.BugGuardian.MVC.Helpers;
using System.Web.Mvc;

namespace DBTek.BugGuardian.MVC.Filters
{
    public abstract class BugGuardianBaseHandleErrorAttribute : HandleErrorAttribute
    {
        public BugGuardianBaseHandleErrorAttribute()
        {
            //SetUp the BugGuardian configuration
            Factories.ConfigurationFactory.SetConfiguration(ConfigurationHelper.Url,
                ConfigurationHelper.Username,
                ConfigurationHelper.Password,
                ConfigurationHelper.CollectiontName,
                ConfigurationHelper.ProjectName,
                ConfigurationHelper.AvoidMultipleReport, 
                ConfigurationHelper.AssignToCurrentIteration);
        }
    }
}
