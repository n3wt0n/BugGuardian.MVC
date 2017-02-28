using System.Web.Mvc;

namespace DBTek.BugGuardian.MVC.Filters
{
    public class BugGuardianTaskHandleErrorAttribute : BugGuardianBaseHandleErrorAttribute
    {
        public override void OnException(ExceptionContext filterContext)
        {
            base.OnException(filterContext);

            using (var manager = new BugGuardianManager())
            {
                //Implemented as synchronous because Asp.net doesn't support async filters
                manager.AddTask(filterContext.Exception);
            }
        }
    }
}
