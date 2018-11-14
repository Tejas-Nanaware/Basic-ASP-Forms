using SchemaLayer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace N_TierApp
{
	public class Global : HttpApplication
	{
		void Application_Start(object sender, EventArgs e)
		{
			// Code that runs on application startup
			RouteConfig.RegisterRoutes(RouteTable.Routes);
			BundleConfig.RegisterBundles(BundleTable.Bundles);
		}

		protected void Session_Start(object sender, EventArgs e)
		{

			ConnectionInfo.ConnectionString = ConfigurationManager.ConnectionStrings["connectionString"].ToString();
			Session.Timeout = 500;
		}
	}
}