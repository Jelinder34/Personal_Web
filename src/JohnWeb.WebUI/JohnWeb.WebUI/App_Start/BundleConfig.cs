﻿using System.Web.Optimization;

namespace JohnWeb.WebUI.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            var jqueryCdnPath = "https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/js/bootstrap.min.js";
       
            bundles.Add(new ScriptBundle("~/bundles/scriptscustom", "https://code.jquery.com/jquery-3.4.1.min.js")
                .Include("~/Scripts/jstyle.js")
            .Include("~/Scripts/jquery-{version}.js"));
            bundles.Add(new ScriptBundle("~/bundles/scripts/desktop", jqueryCdnPath)
                .Include("~/Scripts/bootstrap.min.js")
                .Include("~/Scripts/bootstrap.js"));
            bundles.Add(new ScriptBundle("~/bundles/analytics")
                .Include("~/Scripts/gAnalytics.js"));
            bundles.Add(new StyleBundle("~/bundles/css/desktop")
                .Include("~/Content/bootstrap.min.css"));
            bundles.Add(new StyleBundle("~/bundles/customcss")
                .Include("~/Content/style.css")
                .Include("~/Content/fixed.css"));

            BundleTable.EnableOptimizations = false;

        }
    }
}
