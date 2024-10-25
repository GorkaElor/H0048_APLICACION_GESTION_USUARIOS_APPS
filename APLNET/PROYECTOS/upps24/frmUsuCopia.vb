Public Class frmUsuCopia
    Private Sub frmUsuCopia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Le indicamos que va a contener subformularios
        dtgrPanelFormu1.Columns.Add("Codigo", "Cod")
        dtgrPanelFormu1.Columns.Add("App", "App")
        'Rellenamos el datagrid del segundo panel
        dtgrPanelFormu2.Columns.Add("Codigo", "App")
        dtgrPanelFormu2.Columns.Add("Codigo", "App")

    End Sub

    Private Sub dtgrPanelFormu1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgrPanelFormu1.CellContentClick

    End Sub
End Class