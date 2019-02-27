Imports DevExpress.Office.Services
Imports DevExpress.Office.Utils
Imports System


Namespace Retain_Img_Src
	Public Class CustomUriProvider
		Implements IUriProvider

		Public Function CreateCssUri(ByVal rootUri As String, ByVal styleText As String, ByVal relativeUri As String) As String Implements IUriProvider.CreateCssUri
			Return String.Empty
		End Function

		Public Function CreateImageUri(ByVal rootUri As String, ByVal image As OfficeImage, ByVal relativeUri As String) As String Implements IUriProvider.CreateImageUri
			Return image.Uri
		End Function
	End Class
End Namespace