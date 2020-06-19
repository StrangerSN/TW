using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace MusicShop.Web
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/bundles/bootstrap/css").Include("~/Content/bootstrap.min.css", new CssRewriteUrlTransform()));
            bundles.Add(new StyleBundle("~/bundles/icons/css").Include("~/Content/icons.min.css", new CssRewriteUrlTransform()));
            bundles.Add(new StyleBundle("~/bundles/app/css").Include("~/Content/app.min.css", new CssRewriteUrlTransform()));

            bundles.Add(new ScriptBundle("~/bundles/vendor/js").Include("~/Scripts/vendor.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/jquery-knob/js").Include("~/Scripts/jquery-knob/jquery.knob.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/peity/js").Include("~/Scripts/peity/jquery.peity.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/jquery-sparkline/js").Include("~/Scripts/jquery-sparkline/jquery.sparkline.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/dashboard-1/js").Include("~/Scripts/pages/dashboard-1.init.js"));
            bundles.Add(new ScriptBundle("~/bundles/app/js").Include("~/Scripts/app.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval/js").Include(
               "~/Scripts/jquery-{version}.min.js",
               "~/Scripts/jquery.validate.min.js",
               "~/Scripts/jquery.validate.unobtrusive.min.js"));

        }
    }
}