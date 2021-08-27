<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128611082/17.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3189)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [CustomUriProvider.cs](./CS/HTML_Export_ImageSourceExample/CustomUriProvider.cs) (VB: [CustomUriProvider.vb](./VB/HTML_Export_ImageSourceExample/CustomUriProvider.vb))
* [Form1.cs](./CS/HTML_Export_ImageSourceExample/Form1.cs) (VB: [Form1.vb](./VB/HTML_Export_ImageSourceExample/Form1.vb))
<!-- default file list end -->
# How to retain the original image URI in an HTML document


This example demonstrates how to use the [DocumentImage.Uri](https://docs.devexpress.com/OfficeFileAPI/DevExpress.XtraRichEdit.API.Native.DocumentImage.Uri) property to set the image's **src** attribute when a document is saved in HTML format. You can switch on the [HtmlDocumentExporterOptions.EmbedImages](https://docs.devexpress.com/OfficeFileAPI/DevExpress.XtraRichEdit.Export.HtmlDocumentExporterOptions.EmbedImages) option to observe that the custom URI provider is idle for emdedded images.


![](./images/screenshot.png)

The project implements a custom class with the **IUriProvider** interface and registers it as the **IUriProviderService** provider.

API in this example:

* [IUriProvider](https://docs.devexpress.com/OfficeFileAPI/DevExpress.Office.Services.IUriProvider) interface
* [IUriProviderService](https://docs.devexpress.com/OfficeFileAPI/DevExpress.Office.Services.IUriProviderService) interface
* [IUriProviderService.RegisterProvider](https://docs.devexpress.com/OfficeFileAPI/DevExpress.Office.Services.IUriProviderService.RegisterProvider(DevExpress.Office.Services.IUriProvider)) method
* [RichEditControl.GetService](https://docs.devexpress.com/WindowsForms/DevExpress.XtraRichEdit.RichEditControl.GetService.overloads) method
* [DocumentImageSource.FromUri](https://docs.devexpress.com/OfficeFileAPI/DevExpress.XtraRichEdit.API.Native.DocumentImageSource.FromUri(System.String-System.ComponentModel.Design.IServiceContainer)) method
* [SubDocument.Images](https://docs.devexpress.com/OfficeFileAPI/DevExpress.XtraRichEdit.API.Native.SubDocument.Images) property
* [SubDocument.GetHtmlText](https://docs.devexpress.com/OfficeFileAPI/DevExpress.XtraRichEdit.API.Native.SubDocument.GetHtmlText.overloads) method
* [HtmlDocumentExporterOptions.EmbedImages](https://docs.devexpress.com/OfficeFileAPI/DevExpress.XtraRichEdit.Export.HtmlDocumentExporterOptions.EmbedImages) property

**See also:**

* [Import and Export](https://docs.devexpress.com/WindowsForms/9333)
