#Region "#usings"
Imports System
Imports System.Windows.Forms
Imports DevExpress.Office.Services
Imports DevExpress.XtraRichEdit.API.Native
#End Region ' #usings

Namespace Retain_Img_Src
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()

            richEditControl1.CreateNewDocument()
            richEditControl1.Document.Images.Append(DocumentImageSource.FromUri("http://www.devexpress.com/i/pagetitles/xtrarichedit.png", Nothing))
            embedImagesCheck.EditValue = True
            AddHandler richEditControl1.ContentChanged, AddressOf richEditControl1_ContentChanged
        End Sub

        Private Sub richEditControl1_ContentChanged(ByVal sender As Object, ByVal e As EventArgs)
            ReloadHtml()
        End Sub

        Private Sub ReloadHtml()
'            #Region "#GetHtmlText"
            Dim exportOptions As New DevExpress.XtraRichEdit.Export.HtmlDocumentExporterOptions()
            exportOptions.EmbedImages = embedImagesCheck.Checked
            Dim sText As String = richEditControl1.Document.GetHtmlText(richEditControl1.Document.Range, New CustomUriProvider(), exportOptions)
'            #End Region ' #GetHtmlText
            memoEdit1.Text = sText
        End Sub

        #Region "#documentloaded"
        Private Sub richEditControl1_DocumentLoaded(ByVal sender As Object, ByVal e As EventArgs) Handles richEditControl1.DocumentLoaded
            Dim service As IUriProviderService = richEditControl1.GetService(Of IUriProviderService)()
            If service IsNot Nothing Then
                service.RegisterProvider(New CustomUriProvider())
            End If
        End Sub
        #End Region ' #documentloaded

        Private Sub embedImagesCheck_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles embedImagesCheck.CheckedChanged
            If embedImagesCheck.Checked Then
                lblText.Text = "CustomUriProvider is idle."
            Else
                lblText.Text = "The CustomUriProvider.CreateImageUri method is called to write the original image uri."
            End If
            ReloadHtml()
        End Sub
    End Class
End Namespace