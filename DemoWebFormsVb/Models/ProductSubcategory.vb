Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

<Table("Production.ProductSubcategory")>
Partial Public Class Subcategory
    Public Sub New()
        Products = New HashSet(Of Product)()
    End Sub

    <Column("ProductSubcategoryID")>
    Public Property SubcategoryID As Integer

    <Column("ProductCategoryID")>
    Public Property CategoryID As Integer

    <Required>
    <StringLength(50)>
    Public Property Name As String

    Public Property rowguid As Guid

    Public Property ModifiedDate As Date

    Public Overridable Property Products As ICollection(Of Product)

    Public Overridable Property Category As Category
End Class
