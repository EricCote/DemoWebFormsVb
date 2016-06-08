<%@ Page Title="Liaison" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Liaison.aspx.vb" Inherits="DemoWebFormsVb.Liaison" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<h1>Liaison</h1>
    <p>Entrez vos infos : </p>
    <asp:DropDownList ID="drpPays" runat="server" AutoPostBack="true"></asp:DropDownList>
    <asp:Button ID="btnEnvoyer" runat="server" Text="Envoyer" />
    <hr />
    <p>Votre pays est: <asp:Label ID="lblPays" runat="server" 
        Text="<%# drpPays.SelectedValue %>"></asp:Label>  </p>
</asp:Content>
