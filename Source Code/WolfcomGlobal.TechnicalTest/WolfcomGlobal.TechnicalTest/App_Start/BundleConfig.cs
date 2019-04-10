using System.Web;
using System.Web.Optimization;

namespace WolfcomGlobal.TechnicalTest
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-min.js",
                        "~/Scripts/bootstrap.min.js",
                        "~/Scripts/material.min.js",
                        "~/Scripts/material-kit.js",
                        "~/Scripts/jquery.parallax.js",
                        "~/Scripts/owl.carousel.min.js",
                        "~/Scripts/jquery.slicknav.js",
                        "~/Scripts/main.js",
                        "~/Scripts/jquery.counterup.min.js",
                        "~/Scripts/waypoints.min.js",
                        "~/Scripts/jasny-bootstrap.min.js",
                        "~/Scripts/bootstrap-select.min.js",
                        "~/Scripts/form-validator.min.js",
                        "~/Scripts/contact-form-script.js",
                        "~/Scripts/jquery.themepunch.revolution.min.js",
                        "~/Scripts/jquery.themepunch.tools.min.js",
                        "~/Scripts/operations.js",
                        "~/Scripts/jquery.blockUI.js",
                        "~/Scripts/sweetalert.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.min.css",
                      "~/Content/jasny-bootstrap.min.css",
                       "~/Content/bootstrap-select.min.css",
                       "~/Content/material-kit.css",
                       "~/Content/font-awesome.min.css",
                       "~/Content/themify-icons.css",
                       "~/Content/animate.css",
                       "~/Content/owl.carousel.css",
                       "~/Content/owl.theme.css",
                       "~/Content/settings.css",
                       "~/Content/slicknav.css",
                       "~/Content/main.css",
                       "~/Content/responsive.css",
                       "~/Content/red.css",
                       "~/Content/block.css"
                       ));

        }
    }
}
