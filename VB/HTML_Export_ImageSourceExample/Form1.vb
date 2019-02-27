Imports DevExpress.Office.Services
Imports DevExpress.XtraEditors
Imports DevExpress.XtraRichEdit.API.Native
Imports System
Imports System.Net

Namespace Retain_Img_Src
	Partial Public Class Form1
		Inherits XtraForm

		Private imageUri As String = "https://raw.githubusercontent.com/DevExpress-Examples/how-to-retain-original-image-uri-in-html-document-e3189/17.1.3%2B/images/winforms.png"
		Public Sub New()
			InitializeComponent()
			AddHandler richEditControl1.DocumentLoaded, AddressOf richEditControl1_DocumentLoaded
			richEditControl1.CreateNewDocument()
			Dim pos As DocumentPosition = richEditControl1.Document.CaretPosition
			richEditControl1.Document.Images.Insert(pos, DocumentImageSource.FromUri(imageUri, Nothing))
			embedImagesCheck.EditValue = True
			AddHandler richEditControl1.ContentChanged, AddressOf richEditControl1_ContentChanged
		End Sub

		Private Sub richEditControl1_ContentChanged(ByVal sender As Object, ByVal e As EventArgs)
			ReloadHtml()
		End Sub

		Private Sub ReloadHtml()
			Dim exportOptions As New DevExpress.XtraRichEdit.Export.HtmlDocumentExporterOptions()
			exportOptions.EmbedImages = embedImagesCheck.Checked
			Dim sText As String = richEditControl1.Document.GetHtmlText(richEditControl1.Document.Range, New CustomUriProvider(), exportOptions)
			memoEdit1.Text = sText
		End Sub

		Private Sub richEditControl1_DocumentLoaded(ByVal sender As Object, ByVal e As EventArgs)
			Dim service As IUriProviderService = richEditControl1.GetService(Of IUriProviderService)()
			If service IsNot Nothing Then
				service.RegisterProvider(New CustomUriProvider())
			End If
		End Sub

		Private Sub embedImagesCheck_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles embedImagesCheck.CheckedChanged
			If embedImagesCheck.Checked Then
				lblText.Text = "CustomUriProvider is idle."
			Else
				lblText.Text = "The CustomUriProvider.CreateImageUri method is called to write the original image uri."
			End If
			ReloadHtml()
		End Sub

		Private Sub btnInsertImage_Click(ByVal sender As Object, ByVal e As EventArgs)
			Dim pos As DocumentPosition = richEditControl1.Document.CaretPosition
			richEditControl1.Document.Images.Insert(pos, DocumentImageSource.FromUri(imageUri, Nothing))
		End Sub
	End Class
End Namespace