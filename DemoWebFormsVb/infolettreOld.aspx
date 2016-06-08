<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="infolettreOld.aspx.vb" Inherits="DemoWebFormsVb.infolettreOld" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Infolettre</title>
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <script src="Scripts/bootstrap.js"></script>
</head>
<body>
    <form id="form1" runat="server" >
    <div class="container body-content">
        <h1 class="text-center">Infolettre</h1>
        <p>Entrez vos informations pour recevoir L'infoLettre.</p>
        <section  >
            <asp:Calendar  ID="Calendar1" runat="server"></asp:Calendar>
            <br />
            <label>Nom : <asp:TextBox  onChange="afficher('Le txtNom est modifié');" runat="server" id="txtNom" class="form-control" /></label>
            <br />
            <label>Courriel : <asp:TextBox  onChange="afficher('Le txtcourriel est modifié');" runat="server" id="txtCourriel" class="form-control" /> </label>
            <br />
            <label>Province : <asp:DropDownList  onChange="afficher('Le drpProvince est modifié');" runat="server" ID="drpProvince" class="form-control">
                          
                         </asp:DropDownList>   </label>
            <br />
            <label>Pays: <asp:DropDownList   EnableViewState="false" onChange="afficher('Le drpPays est modifié');" runat="server" ID="drpPays" class="form-control">
                          
                         </asp:DropDownList>   </label>
            <br />

            <label>Vip? <asp:CheckBox onClick="afficher('Le chkVip est modifié');"  runat="server" ID="chkVip" class="form-control" />  </label>
            <br />
            <asp:Button ID="btnEnvoyer"  OnClick="btnEnvoyer_Click"  onClientClick="afficher('Le bouton est cliqué');" runat="server"  Text="Envoyer" class="btn btn-default" />
            <br />
     
            <div class="col-xs-6 bg-primary" id="div1" ></div>
            <div class="col-xs-6 bg-info" id="div2" runat="server" enableviewstate="false" ></div>
        </section>

    </div>
    </form>
</body>
</html>

<script>
    function afficher(texte) {
        var div1 = document.getElementById("div1");
        div1.innerHTML +=  "<br />" + texte;
    }


</script>
