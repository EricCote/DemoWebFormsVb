Imports System
Imports System.Data.Entity
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Linq

Partial Public Class AW
    Inherits DbContext

    Public Sub New()
        MyBase.New("name=AW")
    End Sub

    Public Overridable Property Products As DbSet(Of Product)
    Public Overridable Property Categories As DbSet(Of Category)
    Public Overridable Property Subcategories As DbSet(Of Subcategory)

    Protected Overrides Sub OnModelCreating(ByVal modelBuilder As DbModelBuilder)
        modelBuilder.Entity(Of Product)() _
            .Property(Function(e) e.StandardCost) _
            .HasPrecision(19, 4)

        modelBuilder.Entity(Of Product)() _
            .Property(Function(e) e.ListPrice) _
            .HasPrecision(19, 4)

        modelBuilder.Entity(Of Product)() _
            .Property(Function(e) e.SizeUnitMeasureCode) _
            .IsFixedLength()

        modelBuilder.Entity(Of Product)() _
            .Property(Function(e) e.WeightUnitMeasureCode) _
            .IsFixedLength()

        modelBuilder.Entity(Of Product)() _
            .Property(Function(e) e.Weight) _
            .HasPrecision(8, 2)

        modelBuilder.Entity(Of Product)() _
            .Property(Function(e) e.ProductLine) _
            .IsFixedLength()

        modelBuilder.Entity(Of Product)() _
            .Property(Function(e) e._Class) _
            .IsFixedLength()

        modelBuilder.Entity(Of Product)() _
            .Property(Function(e) e.Style) _
            .IsFixedLength()

        modelBuilder.Entity(Of Category)() _
            .HasMany(Function(e) e.Subcategories) _
            .WithRequired(Function(e) e.Category) _
            .WillCascadeOnDelete(False)
    End Sub
End Class
