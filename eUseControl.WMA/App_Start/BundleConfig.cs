using System.Web.Optimization;

namespace eUseControl.WMA.App_Start
{
    public static class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            // Home style
            bundles.Add(new StyleBundle("~/bundles/mainelements/css").Include(
                      "~/Content/mainelements.css", new CssRewriteUrlTransform()));

            // Animate.css
            bundles.Add(new StyleBundle("~/bundles/Sliders/css").Include(
                      "~/Content/Sliders.css"));

            bundles.Add(new StyleBundle("~/bundles/tabs/css").Include(
                      "~/Content/tabs.css", new CssRewriteUrlTransform()));


            // Font Awesome icons style
            bundles.Add(new StyleBundle("~/bundles/font-awesome/css").Include(
                      "~/Content/font-awesome.min.css", new CssRewriteUrlTransform()));
          
            // jQuery
            bundles.Add(new ScriptBundle("~/bundles/jquery/js").Include(
                      "~/Scripts/jquery-3.3.1.min.js"));

            // jQuery Validation
            bundles.Add(new ScriptBundle("~/bundles/validation/js").Include(
                "~/Scripts/jquery.validate.min.js"));

            // Unobtrusive           
            bundles.Add(new ScriptBundle("~/bundles/unobtrusive/js").Include(
                      "~/Scripts/jquery.unobtrusive-ajax.min.js"));

        }
    }
}