﻿using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Http;
using AutoMapper;
using Vidly.App_Start;

/* DataTables Plug-in
 * 
 * Install package "jquery.datatables" (1.10.11)
 * We got a bunch of js scripts under DataTables folder from installing this package
 * 
 * Before that, we want to consolidate the javascript for jquery and bootstrap in _Layout.cshtml
 * Bundling the jquery and bootstrap js code in BundleConfig
 * 
 * Add also for jquery.dataTables.js, dataTables.bootstrap.js under "~/bundles/lib"
 * Add also for dataTables.bootstrap.css under css bundle
 * 
 * There is some disadvantage if we use current datatables
 * It extract from markup html generated by server
 * If the data is huge, like 1000 rows, it will take much resource 
 * on client-side. Therefore it will be good if we consume the data
 * through API, since it provide in a json form
 *  GET /api/customers
 * 
 * Look at:
 * • BundleConfig.cs
 * • _Layout.cshtml
 * • Customers -> Index.cshtml
*/

namespace Vidly
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            Mapper.Initialize(c => c.AddProfile<MappingProfile>());
            GlobalConfiguration.Configure(WebApiConfig.Register);
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
