Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

<Table("Production.ProductCategory")>
Partial Public Class Category
    Public Sub New()
        Subcategories = New HashSet(Of Subcategory)()
    End Sub

    <Column("ProductCategoryID")>
    Public Property CategoryID As Integer

    <Required>
    <StringLength(50)>
    Public Property Name As String

    Public Property rowguid As Guid

    Public Property ModifiedDate As Date

    Public Overridable Property Subcategories As ICollection(Of Subcategory)
End Class
