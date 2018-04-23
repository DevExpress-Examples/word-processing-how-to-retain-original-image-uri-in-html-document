Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
#Region "#usings"
Imports DevExpress.XtraRichEdit.Services
Imports DevExpress.Office.Utils
#End Region ' #usings

Namespace Retain_Img_Src
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
			richEditControl1.LoadDocument("test.htm")
			AddHandler richEditControl1.ContentChanged, AddressOf richEditControl1_ContentChanged
		End Sub

		Private Sub richEditControl1_ContentChanged(ByVal sender As Object, ByVal e As EventArgs)
			memoEdit1.Text = richEditControl1.Document.GetHtmlText(richEditControl1.Document.Range, New CustomUriProvider())
		End Sub
		#Region "#documentloaded"
		Private Sub richEditControl1_DocumentLoaded(ByVal sender As Object, ByVal e As EventArgs) Handles richEditControl1.DocumentLoaded
			Dim service As IUriProviderService = richEditControl1.GetService(Of IUriProviderService)()
			If service IsNot Nothing Then
				service.RegisterProvider(New CustomUriProvider())
			End If
		End Sub
		#End Region ' #documentloaded
	End Class
	#Region "#customuriprovider"
	Public Class CustomUriProvider
		Implements IUriProvider
		#Region "IUriProvider Members"
		Public Function CreateCssUri(ByVal rootUri As String, ByVal styleText As String, ByVal relativeUri As String) As String Implements  IUriProvider.CreateCssUri
			Return String.Empty
		End Function

		Public Function CreateImageUri(ByVal rootUri As String, ByVal image As OfficeImage, ByVal relativeUri As String) As String Implements  IUriProvider.CreateImageUri
			Return image.Uri
		End Function
		#End Region
	End Class
	#End Region ' #customuriprovider
End Namespace