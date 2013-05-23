using System.Web;
using System.Web.Optimization;

namespace jQueryFileUploadCustom
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {


            //bundles.Clear();
            //bundles.ResetAll();

            BundleTable.EnableOptimizations = true;

            bundles.Add(new ScriptBundle("~/Scripts/jquery").Include("~/Scripts/jquery-1.9.1.js"));
            bundles.Add(new ScriptBundle("~/Scripts/widget").Include("~/Scripts/jquery.ui.widget.js"));
            bundles.Add(new ScriptBundle("~/Scripts/loadimage").Include("~/Scripts/jquery.load-image.min.js"));
            bundles.Add(new ScriptBundle("~/Scripts/canvastoblob").Include("~/Scripts/jquery.canvas-to-blob.min.js"));
            bundles.Add(new ScriptBundle("~/Scripts/iframetransport").Include("~/Scripts/jquery.iframe-transport.js"));
            bundles.Add(new ScriptBundle("~/Scripts/fileupload").Include("~/Scripts/jquery.fileupload.js"));
            bundles.Add(new ScriptBundle("~/Scripts/fileuploadprocess").Include("~/Scripts/jquery.fileupload-process.js"));
            bundles.Add(new ScriptBundle("~/Scripts/fileuploadresize").Include("~/Scripts/jquery.fileupload-resize.js"));
            bundles.Add(new ScriptBundle("~/Scripts/fileuploadvalidate").Include("~/Scripts/jquery.fileupload-validate.js"));
            bundles.Add(new ScriptBundle("~/Scripts/knob").Include("~/Scripts/jquery.knob.js"));


            bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/site.css"));
            //bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/bootstrap.min.css"));
            //bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/style.css"));
            //bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/bootstrap-responsive.min.css"));
            //bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/bootstrap-ie6.min.css"));
            //bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/jquery.fileupload-ui.css"));
            bundles.Add(new StyleBundle("~/Content/themes/base/css").Include(
                        "~/Content/themes/base/jquery.ui.core.css",
                        "~/Content/themes/base/jquery.ui.resizable.css",
                        "~/Content/themes/base/jquery.ui.selectable.css",
                        "~/Content/themes/base/jquery.ui.accordion.css",
                        "~/Content/themes/base/jquery.ui.autocomplete.css",
                        "~/Content/themes/base/jquery.ui.button.css",
                        "~/Content/themes/base/jquery.ui.dialog.css",
                        "~/Content/themes/base/jquery.ui.slider.css",
                        "~/Content/themes/base/jquery.ui.tabs.css",
                        "~/Content/themes/base/jquery.ui.datepicker.css",
                        "~/Content/themes/base/jquery.ui.progressbar.css",
                        "~/Content/themes/base/jquery.ui.theme.css"));
        }
    }
}