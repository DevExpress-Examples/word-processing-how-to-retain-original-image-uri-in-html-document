using System;
using System.Windows.Forms;
#region #usings
using DevExpress.XtraRichEdit.Services;
using DevExpress.Office.Utils;
#endregion #usings

namespace Retain_Img_Src
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            richEditControl1.LoadDocument("test.htm");
            richEditControl1.ContentChanged+=new EventHandler(richEditControl1_ContentChanged);
        }

        private void richEditControl1_ContentChanged(object sender, EventArgs e)
        {
            memoEdit1.Text = richEditControl1.Document.GetHtmlText(richEditControl1.Document.Range, new CustomUriProvider());
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
    }
    #region #customuriprovider
    public class CustomUriProvider : IUriProvider
    {
        #region IUriProvider Members
        public string CreateCssUri(string rootUri, string styleText, string relativeUri)
        {
            return String.Empty;
        }

        public string CreateImageUri(string rootUri, OfficeImage image, string relativeUri)
        {
            return image.Uri;
        }
        #endregion
    }
    #endregion #customuriprovider
}