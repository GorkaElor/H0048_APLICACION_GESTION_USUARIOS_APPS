Public Class frmAppUsuarios
    Private Sub frmAppUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtgrAppUsuarios.Columns.Add("UsuCod", "Cod")
        dtgrAppUsuarios.Columns.Add("UsuNom", "Detalle Usuario")
        dtgrAppUsuarios.Columns("UsuNom").Width = 300

        cargarDatosUsuarios()
    End Sub

    Private Sub cargarDatosUsuarios()
        'Lógica de datos de usuarios
    End Sub



End Class