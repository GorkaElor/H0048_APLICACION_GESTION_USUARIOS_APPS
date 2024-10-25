Public Class frmAppGrupos
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgrAppGrupos.CellContentClick

    End Sub

    Private Sub frmAppGrupos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtgrAppGrupos.Columns.Add("GruCod", "Cod")
        dtgrAppGrupos.Columns.Add("GruDes_E", "Detalle Grupo")
        dtgrAppGrupos.Columns("GruDes_E").Width = 300
        'Llamamos al método para llenar
        cargarDatosGrupos()
    End Sub

    Private Sub cargarDatosGrupos()
        'Aquí se establece la conexion (cuando los negocios estén bien)
    End Sub

    Private Sub btnNuevoGrupo_Click(sender As Object, e As EventArgs) Handles btnNuevoGrupo.Click
        frmAltaGrupo.Show()
    End Sub

    Private Sub btnEditarGrupo_Click(sender As Object, e As EventArgs) Handles btnEditarGrupo.Click
        frmAltaGrupo.Show()
    End Sub

    Private Sub btnEliminarGrupo_Click(sender As Object, e As EventArgs) Handles btnEliminarGrupo.Click
        'Aquí implementar la lógica de eliminación
    End Sub
End Class