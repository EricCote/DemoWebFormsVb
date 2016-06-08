Public Class Liaison
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            Dim pays() As String = {"Canada", "USA", "Mexique"}
            drpPays.DataSource = pays
            drpPays.DataBind()
        End If

        Page.DataBind()

    End Sub

End Class