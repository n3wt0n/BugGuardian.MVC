using System.Threading.Tasks;
using System.Web.Mvc;

namespace BugGuardian.MVC.Filters
{
    public class BugGuardianHandleErrorAttribute : HandleErrorAttribute
    {
        public override void OnException(ExceptionContext filterContext)
        {            
            base.OnException(filterContext);
            
            using (var creator = new DBTek.BugGuardian.Creator())
            {
                creator.AddBugAsync(filterContext.Exception);
            }
        }
    }
}
