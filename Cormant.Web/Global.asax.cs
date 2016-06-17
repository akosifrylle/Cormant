using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;
using Cormant.NHibernate;

namespace Cormant.Web
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AutoMapperConfig.Initilize();
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}
