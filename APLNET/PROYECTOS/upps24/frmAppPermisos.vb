Public Class frmAppPermisos
    Private Sub frmAppPermisos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtgrAppPermisos.Columns.Add("ProCod", "Cod")
        dtgrAppPermisos.Columns.Add("ProDes_E", "Detalle Permiso")
        dtgrAppPermisos.Columns("ProDes_E").Width = 300

        cargarDatosPermisos()
    End Sub

    Private Sub cargarDatosPermisos()

    End Sub

    Private Sub btnNuevoPermiso_Click(sender As Object, e As EventArgs) Handles btnNuevoPermiso.Click
        frmAltaPro.Show()
    End Sub

    Private Sub btnEditarPermiso_Click(sender As Object, e As EventArgs) Handles btnEditarPermiso.Click
        frmAltaPro.Show()
    End Sub

    Private Sub btnEliminarPermiso_Click(sender As Object, e As EventArgs) Handles btnEliminarPermiso.Click
        'Lógica de eliminación aquí
    End Sub


End Class