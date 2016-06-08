Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

<Table("Production.Product")>
Partial Public Class Product
    Public Property ProductID As Integer

    <Required>
    <StringLength(50)>
    Public Property Name As String

    <Required>
    <StringLength(25)>
    Public Property ProductNumber As String

    Public Property MakeFlag As Boolean

    Public Property FinishedGoodsFlag As Boolean

    <StringLength(15)>
    Public Property Color As String

    Public Property SafetyStockLevel As Short

    Public Property ReorderPoint As Short

    <Column(TypeName:="money")>
    Public Property StandardCost As Decimal

    <Column(TypeName:="money")>
    Public Property ListPrice As Decimal

    <StringLength(5)>
    Public Property Size As String

    <StringLength(3)>
    Public Property SizeUnitMeasureCode As String

    <StringLength(3)>
    Public Property WeightUnitMeasureCode As String

    Public Property Weight As Decimal?

    Public Property DaysToManufacture As Integer

    <StringLength(2)>
    Public Property ProductLine As String

    <Column("Class")>
    <StringLength(2)>
    Public Property _Class As String

    <StringLength(2)>
    Public Property Style As String

    <Column("ProductSubcategoryID")>
    Public Property SubcategoryID As Integer?

    Public Property ProductModelID As Integer?

    Public Property SellStartDate As Date

    Public Property SellEndDate As Date?

    Public Property DiscontinuedDate As Date?

    Public Property rowguid As Guid

    Public Property ModifiedDate As Date

    Public Overridable Property ProductSubcategory As Subcategory
End Class
