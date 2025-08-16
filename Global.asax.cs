using System;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;

namespace SistemaCotizaciones
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        void Application_End(object sender, EventArgs e)
        {
            
        }

        void Application_Error(object sender, EventArgs e)
        {
           
            Exception exc = Server.GetLastError();

            
            Server.ClearError();
        }

        void Session_Start(object sender, EventArgs e)
        {
            
        }

        void Session_End(object sender, EventArgs e)
        {
            
        }
    }
}