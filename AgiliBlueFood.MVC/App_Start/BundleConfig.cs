using System.Web;
using System.Web.Optimization;

namespace AgiliBlueFood.MVC
{
    public class BundleConfig
    {
        // Para obter mais informações sobre o agrupamento, visite https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use a versão em desenvolvimento do Modernizr para desenvolver e aprender. Em seguida, quando estiver
            // pronto para a produção, utilize a ferramenta de build em https://modernizr.com para escolher somente os testes que precisa.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            /* /// ExtJs 4
            bundles.Add(new StyleBundle("~/Content/extjs").Include(
                "~/Scripts/extjs/bootstrap.css",
                "~/Scripts/extjs/resources/css/app.css",
                "~/Scripts/extjs/ux/css/LiveSearchGridPanel.css",
                "~/Scripts/extjs/ux/statusbar/css/statusbar.css",
                "~/Scripts/extjs/ux/grid/css/GridFilters.css",
                "~/Scripts/extjs/ux/grid/css/RangeMenu.css"
                ));

            if (System.Diagnostics.Debugger.IsAttached)
                bundles.Add(new ScriptBundle("~/bundles/extjs").Include(
                "~/Scripts/extjs/ext/ext-all-dev.js",
                "~/Scripts/extjs/bootstrap.js",
                "~/translations/locale.js",
                "~/app/util/Util.js"
                ));
            else
                bundles.Add(new ScriptBundle("~/bundles/extjs").Include(
                "~/Scripts/extjs/ext/ext-all.js",
                "~/Scripts/extjs/bootstrap.js",
                "~/translations/locale.js",
                "~/app/util/Util.js"
                )); */
        }
    }
}
