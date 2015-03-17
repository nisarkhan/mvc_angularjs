using System.Web;
using System.Web.Optimization;

namespace Src.Smartworks.Web.New
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {

            ////bundles.Add(new StyleBundle("~/bundles/assets/css").Include(
            ////                "~/assets/css/bootstrap.min.css",
            ////                "~/assets/css/font-awesome.min.css",
            ////                "~/assets/css/sunloan.css",
            ////                "~/assets/css/sunloan.datatable.css",
            ////                "~/assets/css/sunloan.datepicker.css",
            ////                "~/assets/css/sunloan.animate.css"
            ////                ));

            //bundles.Add(new StyleBundle("~/assets/css/fonts").Include(                          
            //              "~/assets/css/fonts/font-awesome.min.css"
            //              ));

            //bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
            //            "~/Scripts/jquery-{version}.js"));

            //bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
            //            "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            //bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
            //            "~/Scripts/modernizr-*"));

            ////bundles.Add(new ScriptBundle("~/bundles/assets/js/vendor").Include(
            ////      "~/assets/js/vendor/jquery.min.js",
            ////      "~/assets/js/vendor/bootstrap.min.js"
            ////  ));

            ////bundles.Add(new ScriptBundle("~/bundles/assets/js/vendor/angular").Include(                    
            ////        "~/assets/js/vendor/angular/angular.js",
            ////        "~/assets/js/vendor/angular/angular-route.js",
            ////        "~/assets/js/vendor/angular/angular-resource.js",
            ////        "~/assets/js/vendor/angular/angular-animate.js",
            ////        "~/assets/js/vendor/angular/angular-cookies.js" 
            //// ));

            ////bundles.Add(new ScriptBundle("~/bundles/common/directives").Include(
            ////    "~/common/directives/templates.js",
            ////    "~/common/directives/gridview.js",
            ////    "~/common/directives/dropdown.js",
            ////    "~/common/directives/mask.js",
            ////    "~/common/directives/form.js",
            ////    "~/common/directives/match.js"
            ////    ));

            ////bundles.Add(new ScriptBundle("~/bundles/app").Include(
            ////            "~/App_Scripts/customer.js"));

            //bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
            //    "~/Scripts/bootstrap.js",
            //    "~/Scripts/ui-bootstrap-tpls-0.11.0.min.js",
            //    "~/Scripts/respond.js"));

            

            // Set EnableOptimizations to false for debugging. For more information,
            // visit http://go.microsoft.com/fwlink/?LinkId=301862
            BundleTable.EnableOptimizations = false;
        }
    }
}
