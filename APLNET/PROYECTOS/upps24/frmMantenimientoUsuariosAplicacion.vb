Public Class frmMantenimientoUsuariosAplicacion
    Private Sub frmMantenimientoUsuariosAplicacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim formularioUsuario As New frmAppUsuarios() ' Crea una instancia del formulario que quieres insertar

        formularioUsuario.TopLevel = False ' Hace que el formulario sea no de nivel superior
        formularioUsuario.FormBorderStyle = FormBorderStyle.None ' Opcional: quita los bordes del formulario


        panelFormuUsuarios.Controls.Add(formularioUsuario) ' Agrega el formulario al Panel
        formularioUsuario.Show() ' Muestra el formulario dentro del panel

        'Añadimos el formulario Grupos
        Dim formularioGrupos As New frmAppGrupos() ' Crea una instancia del formulario que quieres insertar

        formularioGrupos.TopLevel = False ' Hace que el formulario sea no de nivel superior
        formularioGrupos.FormBorderStyle = FormBorderStyle.None ' Opcional: quita los bordes del formulario


        panelFormuGrupos.Controls.Add(formularioGrupos) ' Agrega el formulario al Panel
        formularioGrupos.Show() ' Muestra el formulario dentro del panel
        'Añadimos el formulario Procesos
        Dim formularioProcesos As New frmAppPermisos() ' Crea una instancia del formulario que quieres insertar

        formularioProcesos.TopLevel = False ' Hace que el formulario sea no de nivel superior
        formularioProcesos.FormBorderStyle = FormBorderStyle.None ' Opcional: quita los bordes del formulario


        panelFormuPermisos.Controls.Add(formularioProcesos) ' Agrega el formulario al Panel
        formularioProcesos.Show() ' Muestra el formulario dentro del panel

    End Sub

    Private Sub frmMantenimientoUsuariosAplicacion_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        'Igualamos las barras de desplazamiento para que queden igualados:
        panelFormuPermisos.VerticalScroll.Value = 0
        panelFormuUsuarios.VerticalScroll.Value = 0
        panelFormuGrupos.VerticalScroll.Value = 0

        panelFormuPermisos.HorizontalScroll.Value = 0
        panelFormuUsuarios.HorizontalScroll.Value = 0
        panelFormuGrupos.HorizontalScroll.Value = 0
    End Sub
End Class