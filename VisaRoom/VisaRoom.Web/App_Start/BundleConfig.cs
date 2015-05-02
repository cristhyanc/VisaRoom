using System.Web;
using System.Web.Optimization;

namespace VisaRoom.Web
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            
            //System.Web.Optimization.BundleTable.EnableOptimizations = false;
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
                        "~/Scripts/bootstrap.js",
                        "~/Scripts/metisMenu.js",
                        "~/Scripts/bootstrap-datepicker.js",
                        "~/Scripts/sb-admin-2.js"));

            bundles.Add(new ScriptBundle("~/bootstrapWizarJS").Include(
                          "~/Scripts/jquery.bootstrap.wizard.js",
                          "~/Scripts/prettify.js"));

            bundles.Add(new ScriptBundle("~/bootstrapFileStyle").Include(
                          "~/Scripts/bootstrap-filestyle.js"));

            bundles.Add(new ScriptBundle("~/publicPagesJs").Include(
                         "~/Scripts/easing.js",
                         "~/Scripts/bootstrap-filestyle.js",
                        "~/Scripts/move-top.js"));



            bundles.Add(new StyleBundle("~/content/bundle").Include(
                       "~/content/bootstrap.css",
                       "~/content/publicPages.css",                     
                       "~/content/metisMenu.css",
                       "~/content/sb-admin-2.css",
                       "~/content/bootstrap-datepicker.css",
                       "~/content/font-awesome.css",
                       "~/content/chosen.css",
                       "~/content/prettify.css"));


            bundles.Add(new StyleBundle("~/content/publicPagesCss").Include(
                       "~/content/bootstrap.css",
                       "~/content/publicPages.css",                      
                       "~/content/prettify.css"));
          
            
            bundles.Add(new StyleBundle("~/Content/DashBoard").Include(
                       "~/Content/bootstrap.css",
                       "~/Content/metisMenu.css",
                       "~/Content/sb-admin-2.css",
                       "~/Content/font-awesome.css"
                       ));

            bundles.Add(new StyleBundle("~/multipleSelectCSS").Include(
                      "~/css/chosen.css"));

            bundles.Add(new StyleBundle("~/bootstrapWizarCSS").Include(
                      "~/css/prettify.css"));
        }
    }
}