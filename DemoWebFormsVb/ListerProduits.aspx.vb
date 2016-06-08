Imports System.Data.Entity

Public Class ListerProduits
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim db As New AW()

        Dim cat As DbSet(Of Category) = db.Categories

        drpCategory.DataSource = cat.ToList()
        drpCategory.DataTextField = "Name"
        drpCategory.DataValueField = "CategoryID"
        drpCategory.DataBind()
    End Sub

End Class