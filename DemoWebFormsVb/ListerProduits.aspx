<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="ListerProduits.aspx.vb" Inherits="DemoWebFormsVb.ListerProduits" %>
<asp:Content ID="Content1" ContentPlaceHolderID="fauxContenu" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Liste Produits</h1>
    <section>
        <asp:DropDownList ID="drpCategory" runat="server"></asp:DropDownList>

    </section>
</asp:Content>
