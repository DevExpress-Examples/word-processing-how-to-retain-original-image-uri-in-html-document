using DevExpress.Office.Services;
using DevExpress.Office.Utils;
using System;


namespace Retain_Img_Src {
    public class CustomUriProvider : IUriProvider {
        public string CreateCssUri(string rootUri, string styleText, string relativeUri) {
            return String.Empty;
        }

        public string CreateImageUri(string rootUri, OfficeImage image, string relativeUri) {
            return image.Uri;
        }
    }
}