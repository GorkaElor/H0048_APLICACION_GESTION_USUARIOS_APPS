Public Class frmAppUsuNuevo
    Private Sub dtgrAppUsuNuevo_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgrAppUsuNuevo.CellContentClick

    End Sub

    Private Sub frmAppUsuNuevo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtgrAppUsuNuevo.Columns.Add("Codigo", "Cod")
        dtgrAppUsuNuevo.Columns.Add("App", "App")
    End Sub
End Class