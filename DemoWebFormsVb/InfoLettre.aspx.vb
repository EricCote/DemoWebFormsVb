Public Class InfoLettre
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub CustomValidator1_ServerValidate(source As Object, args As ServerValidateEventArgs)
        Dim villes() As String = {"Québec", "Montréal", "Toronto"}

        If villes.Contains(args.Value) Then
            args.IsValid = True
        Else
            args.IsValid = False
        End If
    End Sub
End Class