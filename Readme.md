<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128611082/17.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3189)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# Rich Text Editor for WinForms - Retain the Original Image URI in an HTML Document

This example demonstrates how to use the [DocumentImage.Uri](https://docs.devexpress.com/OfficeFileAPI/DevExpress.XtraRichEdit.API.Native.DocumentImage.Uri) property to set the image's _src_ attribute when a document is saved in HTML format. You can switch on the [HtmlDocumentExporterOptions.EmbedImages](https://docs.devexpress.com/OfficeFileAPI/DevExpress.XtraRichEdit.Export.HtmlDocumentExporterOptions.EmbedImages) option to observe that the custom URI provider is idle for embedded images.

![](./images/screenshot.png)

The project implements a custom class with the **IUriProvider** interface and registers it as the **IUriProviderService** provider.

## Files to Review

* [CustomUriProvider.cs](./CS/HTML_Export_ImageSourceExample/CustomUriProvider.cs) (VB: [CustomUriProvider.vb](./VB/HTML_Export_ImageSourceExample/CustomUriProvider.vb))
* [Form1.cs](./CS/HTML_Export_ImageSourceExample/Form1.cs) (VB: [Form1.vb](./VB/HTML_Export_ImageSourceExample/Form1.vb))

## Documentation

* [Import an HTML File into the Rich Text Editor or Export a Document to HTML](https://docs.devexpress.com/WindowsForms/402852/controls-and-libraries/rich-text-editor/html-import-and-export?p=netframework)
