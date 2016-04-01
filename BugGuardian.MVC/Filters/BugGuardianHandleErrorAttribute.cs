using System.Web.Mvc;

namespace DBTek.BugGuardian.MVC.Filters
{
    public class BugGuardianHandleErrorAttribute : HandleErrorAttribute
    {
        public override void OnException(ExceptionContext filterContext)
        {            
            base.OnException(filterContext);
            
            using (var creator = new Creator())
            {
                creator.AddBugAsync(filterContext.Exception);
            }
        }
    }
}
