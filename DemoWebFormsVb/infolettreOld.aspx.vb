Public Class infolettreOld
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Afficher("Le Page_Load est appelé")

        'Avec Viewstate, on ne remplit que la première fois. 
        'on détecte si il y a un Viewstate avec la propriété IsPostBack
        If Not IsPostBack Then
            Dim provinces() As String = {"Québec", "Ontario", "Alberta"}
            For Each province As String In provinces
                drpProvince.Items.Add(province)
            Next
            'drpProvince.DataSource = provinces
            'drpProvince.DataBind()
        End If

        'sans le viewstate
        'On remplit toujours et on restaure 
        'l 'élément sélectionné avec params
        Dim countries() As String = {"Canada", "USA", "Mexique"}
        For Each country As String In countries
            drpPays.Items.Add(country)
        Next
        drpPays.SelectedValue = Request.Params("drpPays")


    End Sub

    Protected Sub txtNom_TextChanged(sender As Object, e As EventArgs) Handles txtNom.TextChanged
        Afficher("Le txtNom a changé.")
    End Sub

    Protected Sub txtCourriel_TextChanged(sender As Object, e As EventArgs) Handles txtCourriel.TextChanged
        Afficher("Le txtCourriel a changé.")
    End Sub

    Protected Sub Afficher(texte As String)
        div2.InnerHtml &= "<br />" & texte
    End Sub

    Protected Sub chkVip_CheckedChanged(sender As Object, e As EventArgs) Handles chkVip.CheckedChanged
        Afficher("Le VIP est changé")
    End Sub

    Protected Sub drpPays_SelectedIndexChanged(sender As Object, e As EventArgs) Handles drpPays.SelectedIndexChanged
        Afficher("Le Pays est changé")
    End Sub

    Protected Sub btnEnvoyer_Click(sender As Object, e As EventArgs)
        Afficher("Le bouton est cliqué")
    End Sub

    Private Sub infolettre_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        Afficher("Disposed")
    End Sub

    Private Sub infolettre_Error(sender As Object, e As EventArgs) Handles Me.[Error]
        Afficher("Erreur")
    End Sub

    Private Sub infolettre_Init(sender As Object, e As EventArgs) Handles Me.Init
        Afficher("Init")
    End Sub

    Private Sub infolettre_InitComplete(sender As Object, e As EventArgs) Handles Me.InitComplete
        Afficher("InitComplete")
    End Sub

    Private Sub infolettre_LoadComplete(sender As Object, e As EventArgs) Handles Me.LoadComplete
        Afficher("LoadComplete")
    End Sub

    Private Sub infolettre_PreInit(sender As Object, e As EventArgs) Handles Me.PreInit
        Afficher("PreInit")
    End Sub

    Private Sub infolettre_PreLoad(sender As Object, e As EventArgs) Handles Me.PreLoad
        Afficher("PreLoad")
    End Sub

    Private Sub infolettre_PreRender(sender As Object, e As EventArgs) Handles Me.PreRender
        Afficher("PreRender")
    End Sub

    Private Sub infolettre_PreRenderComplete(sender As Object, e As EventArgs) Handles Me.PreRenderComplete
        Afficher("PreRenderComplete")
    End Sub

    Private Sub infolettre_SaveStateComplete(sender As Object, e As EventArgs) Handles Me.SaveStateComplete
        Afficher("SaveStateComplete")
    End Sub

    Private Sub infolettre_Unload(sender As Object, e As EventArgs) Handles Me.Unload
        Afficher("Unload")
    End Sub

    Private Sub infolettre_AbortTransaction(sender As Object, e As EventArgs) Handles Me.AbortTransaction
        Afficher("AbortTransaction")
    End Sub

    Private Sub infolettre_CommitTransaction(sender As Object, e As EventArgs) Handles Me.CommitTransaction
        Afficher("CommitTransaction")
    End Sub

    Private Sub infolettre_DataBinding(sender As Object, e As EventArgs) Handles Me.DataBinding
        Afficher("DataBinding")
    End Sub

    Private Sub txtNom_Init(sender As Object, e As EventArgs) Handles txtNom.Init
        Afficher("txtNom_Init")
    End Sub

    Private Sub txtNom_Load(sender As Object, e As EventArgs) Handles txtNom.Load
        Afficher("txtNom_Load")
    End Sub

    Private Sub txtNom_PreRender(sender As Object, e As EventArgs) Handles txtNom.PreRender
        Afficher("txtNom_PreRender")
    End Sub
End Class