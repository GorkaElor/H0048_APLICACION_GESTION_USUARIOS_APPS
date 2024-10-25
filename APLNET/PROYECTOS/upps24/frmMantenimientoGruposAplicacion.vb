Public Class frmMantenimientoGruposAplicacion
    Private Sub frmMantenimientoGruposAplicacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Añadimos los formularios a los paneles

        Dim formularioGrupo As New frmAppGrupos() ' Crea una instancia del formulario que quieres insertar

        formularioGrupo.TopLevel = False ' Hace que el formulario sea no de nivel superior
        formularioGrupo.FormBorderStyle = FormBorderStyle.None ' Opcional: quita los bordes del formulario


        panelContenedorFormuGrupo.Controls.Add(formularioGrupo) ' Agrega el formulario al Panel
        formularioGrupo.Show() ' Muestra el formulario dentro del panel

        'Añadimos el formulario Permisos
        Dim formularioPermisos As New frmAppPermisos() ' Crea una instancia del formulario que quieres insertar

        formularioPermisos.TopLevel = False ' Hace que el formulario sea no de nivel superior
        formularioPermisos.FormBorderStyle = FormBorderStyle.None ' Opcional: quita los bordes del formulario


        panelFormuPermisos.Controls.Add(formularioPermisos) ' Agrega el formulario al Panel
        formularioPermisos.Show() ' Muestra el formulario dentro del panel
        'Añadimos el formulario Usuarios
        Dim formularioUsuarios As New frmAppUsuarios() ' Crea una instancia del formulario que quieres insertar

        formularioUsuarios.TopLevel = False ' Hace que el formulario sea no de nivel superior
        formularioUsuarios.FormBorderStyle = FormBorderStyle.None ' Opcional: quita los bordes del formulario


        panelFormuUsuarios.Controls.Add(formularioUsuarios) ' Agrega el formulario al Panel
        formularioUsuarios.Show() ' Muestra el formulario dentro del panel
    End Sub
End Class