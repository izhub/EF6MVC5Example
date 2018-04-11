using OhioState.DAL;
using System.Data.Entity.Infrastructure.Interception;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace OhioState
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            DbInterception.Add(new SchoolInterceptorTransientErrors());
            DbInterception.Add(new SchoolInterceptorLogging());
            /*These lines of code are what causes your interceptor code to be run when Entity Framework sends queries to the database. Notice that because you created separate interceptor classes for transient error simulation and logging, you can independently enable and disable them.
            You can add interceptors using the DbInterception.Add method anywhere in your code; it doesn't have to be in the Application_Start method. Another option is to put this code in the DbConfiguration class 
                */
        }
    }
}
/*
 Note that you can't repeat this test unless you stop the application and restart it. If you wanted to be able to test connection resiliency multiple times in a single run of the application, you could write code to reset the error counter in SchoolInterceptorTransientErrors.

    To see the difference the execution strategy (retry policy) makes, comment out the SetExecutionStrategy line in SchoolConfiguration.cs, run the Students page in debug mode again, and search for "Throw" again. This time the debugger stops on the first generated exception immediately when it tries to execute the query the first time.
     */
