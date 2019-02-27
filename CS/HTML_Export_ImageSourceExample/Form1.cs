using DevExpress.Office.Services;
using DevExpress.XtraEditors;
using DevExpress.XtraRichEdit.API.Native;
using System;
using System.Net;

namespace Retain_Img_Src
{
    public partial class Form1 : XtraForm
    {
        string imageUri = @"https://raw.githubusercontent.com/DevExpress-Examples/how-to-retain-original-image-uri-in-html-document-e3189/17.1.3%2B/images/winforms.png";
        public Form1()
        {
            InitializeComponent();
            richEditControl1.DocumentLoaded += richEditControl1_DocumentLoaded;
            richEditControl1.CreateNewDocument();
            DocumentPosition pos = richEditControl1.Document.CaretPosition;
            richEditControl1.Document.Images.Insert(pos, DocumentImageSource.FromUri(imageUri, null));
            embedImagesCheck.EditValue = true;
            richEditControl1.ContentChanged += new EventHandler(richEditControl1_ContentChanged);
        }

        private void richEditControl1_ContentChanged(object sender, EventArgs e) {
            ReloadHtml();
        }

        private void ReloadHtml() {
            DevExpress.XtraRichEdit.Export.HtmlDocumentExporterOptions exportOptions = new DevExpress.XtraRichEdit.Export.HtmlDocumentExporterOptions();
            exportOptions.EmbedImages = embedImagesCheck.Checked;
            string sText = richEditControl1.Document.GetHtmlText(richEditControl1.Document.Range, new CustomUriProvider(), exportOptions);
            memoEdit1.Text = sText;
        }

        private void richEditControl1_DocumentLoaded(object sender, EventArgs e)
        {
            IUriProviderService service = richEditControl1.GetService<IUriProviderService>();
            if (service != null)
            {
                service.RegisterProvider(new CustomUriProvider());
            }
        }

        private void embedImagesCheck_CheckedChanged(object sender, EventArgs e) {
            if (embedImagesCheck.Checked)
                lblText.Text = "The text is the GetHtml method's result. The image is embedded. The CustomUriProvider is idle.";
            else
                lblText.Text = "The text is the GetHtml method's result. The image is linked. The CustomUriProvider.CreateImageUri method sets the src.";
            ReloadHtml();
        }

        private void btnInsertImage_Click(object sender, EventArgs e)
        {
            DocumentPosition pos = richEditControl1.Document.CaretPosition;
            richEditControl1.Document.Images.Insert(pos, DocumentImageSource.FromUri(imageUri, null));
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            richEditControl1.SaveDocument("test.html", DevExpress.XtraRichEdit.DocumentFormat.Html);
            System.Diagnostics.Process.Start("test.html");
        }
    }
}