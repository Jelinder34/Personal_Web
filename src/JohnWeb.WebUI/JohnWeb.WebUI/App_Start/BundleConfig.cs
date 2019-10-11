using System.Web.Optimization;

namespace JohnWeb.WebUI.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            var jqueryCdnPath = "https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/js/bootstrap.min.js";
            var cssCdnPath = "https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/4.3.1/css/bootstrap.min.css";
       
            bundles.Add(new ScriptBundle("~/bundles/scriptscustom", "https://code.jquery.com/jquery-3.4.1.min.js")
                .Include("~/Scripts/jstyle.js")
            .Include("~/Scripts/jquery-{version}.js"));
            bundles.Add(new ScriptBundle("~/bundles/scripts/desktop", jqueryCdnPath)
                .Include("~/Scripts/bootstrap.js"));
            bundles.Add(new ScriptBundle("~/bundles/analytics")
                .Include("~/Scripts/gAnalytics.js"));
            bundles.Add(new StyleBundle("~/bundles/css/desktop", cssCdnPath)
                .Include("~/Content/bootstrap.min.css"));
            bundles.Add(new StyleBundle("~/bundles/customcss")
                .Include("~/Content/*.css"));
            bundles.Add(new StyleBundle("~/bundles/fontawesome")
                .Include("~/Content/css/*.css"));

            bundles.Add(new StyleBundle("~/bundles/fonticons")
                .Include("~/Content/webfonts/*.eot")
                .Include("~/Content/webfonts/*.svg")
                .Include("~/Content/webfonts/*.ttf")
                .Include("~/Content/webfonts/*.woff")
                .Include("~/Content/webfonts/*.woff2"));
        }
    }
}
