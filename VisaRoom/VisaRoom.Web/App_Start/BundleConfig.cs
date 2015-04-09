using System.Web;
using System.Web.Optimization;

namespace VisaRoom.Web
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
                        "~/Scripts/jquery-ui-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.unobtrusive*",
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));
            

            bundles.Add(new ScriptBundle("~/mainScript").Include(
                         "~/Scripts/main.js"));

            bundles.Add(new ScriptBundle("~/multipleSelectJS").Include(
                         "~/Scripts/chosen.jquery.js"));

            bundles.Add(new ScriptBundle("~/bootstrapjs").Include(
                         "~/Content/bower_components/bootstrap/dist/js/bootstrap.js",
                        "~/Content/bower_components/metisMenu/dist/metisMenu.js",
                        "~/Scripts/bootstrap-datepicker.js",
                        "~/Content/dist/js/sb-admin-2.js"));

            bundles.Add(new ScriptBundle("~/bootstrapWizarJS").Include(
                          "~/Content/bower_components/wizard/jquery.bootstrap.wizard.js",
                          "~/Content/bower_components/wizard/prettify.js"));

            bundles.Add(new ScriptBundle("~/bootstrapFile").Include(
                          "~/Scripts/bootstrap-filestyle.js"));



            bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/site.css"));
            //   "~/Content/themes/bootstrap/css/bootstrap.css",
            bundles.Add(new StyleBundle("~/Content/bootstrapcss").Include(
                       "~/Content/bower_components/bootstrap/dist/css/bootstrap.css",
                       "~/Content/bower_components/metisMenu/dist/metisMenu.css",
                       "~/Content/dist/css/sb-admin-2.css",
                       "~/Content/bower_components/bootstrap-datepicker.css",
                       "~/Content/bower_components/font-awesome/css/font-awesome.css"
                       ));

            bundles.Add(new StyleBundle("~/multipleSelectCSS").Include(
                      "~/Content/chosen.css"));

            bundles.Add(new StyleBundle("~/bootstrapWizarCSS").Include(
                      "~/Content/bower_components/wizard/prettify.css"));
        }
    }
}