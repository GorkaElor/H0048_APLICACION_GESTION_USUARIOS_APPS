Public Class frmUsu
    Private Sub btnSalirFrmUsu_Click(sender As Object, e As EventArgs) Handles btnSalirFrmUsu.Click
        Me.Close()
    End Sub

    Private Sub frmUsu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtgrfrmUsu.Columns.Add("UsuCod", "Cod.")
        dtgrfrmUsu.Columns.Add("UsuNom", "Nombre")
        dtgrfrmUsu.Columns.Add("UsuApel", "Apellido")
        dtgrfrmUsu.Columns.Add("UsuStop", "Stop")
        dtgrfrmUsu.Columns.Add("FAlta", "Fecha de Alta")
        dtgrfrmUsu.Columns.Add("FBaja", "Fecha de Baja")

        dtgrfrmUsu.AutoResizeColumns()
    End Sub

    Private Sub cargarDatosUsu()
        'Lógica de inserción de datos
    End Sub
End Class