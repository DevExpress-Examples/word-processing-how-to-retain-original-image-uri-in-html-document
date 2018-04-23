#region #usings
using System;
using System.Windows.Forms;
using DevExpress.Office.Services;
using DevExpress.XtraRichEdit.API.Native;
#endregion #usings

namespace Retain_Img_Src
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            richEditControl1.CreateNewDocument();
            richEditControl1.Document.Images.Append(DocumentImageSource.FromUri("http://www.devexpress.com/i/pagetitles/xtrarichedit.png", null));
            embedImagesCheck.EditValue = true;
            richEditControl1.ContentChanged += new EventHandler(richEditControl1_ContentChanged);
        }

        private void richEditControl1_ContentChanged(object sender, EventArgs e) {
            ReloadHtml();
        }

        private void ReloadHtml() {
            #region #GetHtmlText
            DevExpress.XtraRichEdit.Export.HtmlDocumentExporterOptions exportOptions = new DevExpress.XtraRichEdit.Export.HtmlDocumentExporterOptions();
            exportOptions.EmbedImages = embedImagesCheck.Checked;
            string sText = richEditControl1.Document.GetHtmlText(richEditControl1.Document.Range, new CustomUriProvider(), exportOptions);
            #endregion #GetHtmlText
            memoEdit1.Text = sText;
        }

        #region #documentloaded
        private void richEditControl1_DocumentLoaded(object sender, EventArgs e)
        {
            IUriProviderService service = richEditControl1.GetService<IUriProviderService>();
            if (service != null) {
                service.RegisterProvider(new CustomUriProvider());
            }
        }
        #endregion #documentloaded

        private void embedImagesCheck_CheckedChanged(object sender, EventArgs e) {
            if (embedImagesCheck.Checked)
                lblText.Text = "CustomUriProvider is idle.";
            else
                lblText.Text = "The CustomUriProvider.CreateImageUri method is called to write the original image uri.";
            ReloadHtml();
        }
    }
}