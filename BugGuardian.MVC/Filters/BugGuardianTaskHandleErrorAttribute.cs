using System.Web.Mvc;

namespace DBTek.BugGuardian.MVC.Filters
{
    public class BugGuardianTaskHandleErrorAttribute : HandleErrorAttribute
    {
        public override void OnException(ExceptionContext filterContext)
        {            
            base.OnException(filterContext);
            
            using (var creator = new Creator())
            {
                //Implemented as synchronous because Asp.net doesn't support async filters
                creator.AddTask(filterContext.Exception);
            }
        }
    }
}
