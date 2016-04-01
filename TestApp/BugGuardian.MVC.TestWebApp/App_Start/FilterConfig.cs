using DBTek.BugGuardian.MVC.Filters;
using System.Web.Mvc;

namespace BugGuardian.MVC.TestWebApp
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {            
            filters.Add(new BugGuardianBugHandleErrorAttribute());
            //filters.Add(new BugGuardianTaskHandleErrorAttribute());
        }
    }
}
