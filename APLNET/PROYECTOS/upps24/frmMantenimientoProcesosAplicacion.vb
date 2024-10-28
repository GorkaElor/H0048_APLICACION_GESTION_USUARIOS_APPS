Public Class frmMantenimientoProcesosAplicacion
    Private Sub frmMantenimientoProcesosAplicacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Insertamos los formularios correspondientes en cada panel
        Dim formularioPermisos As New frmAppPermisos() ' Crea una instancia del formulario que quieres insertar

        formularioPermisos.TopLevel = False ' Hace que el formulario sea no de nivel superior
        formularioPermisos.FormBorderStyle = FormBorderStyle.None ' Opcional: quita los bordes del formulario


        panelFormuPermiso.Controls.Add(formularioPermisos) ' Agrega el formulario al Panel
        formularioPermisos.Show() ' Muestra el formulario dentro del panel

        'Añadimos el formulario Grupos
        Dim formularioGrupos As New frmAppGrupos() ' Crea una instancia del formulario que quieres insertar

        formularioGrupos.TopLevel = False ' Hace que el formulario sea no de nivel superior
        formularioGrupos.FormBorderStyle = FormBorderStyle.None ' Opcional: quita los bordes del formulario


        panelFormuGrupos.Controls.Add(formularioGrupos) ' Agrega el formulario al Panel
        formularioGrupos.Show() ' Muestra el formulario dentro del panel
        'Añadimos el formulario Usuarios
        Dim formularioUsuarios As New frmAppUsuarios() ' Crea una instancia del formulario que quieres insertar

        formularioUsuarios.TopLevel = False ' Hace que el formulario sea no de nivel superior
        formularioUsuarios.FormBorderStyle = FormBorderStyle.None ' Opcional: quita los bordes del formulario


        panelFormuUsuarios.Controls.Add(formularioUsuarios) ' Agrega el formulario al Panel
        formularioUsuarios.Show() ' Muestra el formulario dentro del panel



    End Sub

    Private Sub frmMantenimientoProcesosAplicacion_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        'Igualamos las barras de desplazamiento para que queden igualados:
        panelFormuPermiso.VerticalScroll.Value = 0
        panelFormuUsuarios.VerticalScroll.Value = 0
        panelFormuGrupos.VerticalScroll.Value = 0

        panelFormuPermiso.HorizontalScroll.Value = 0
        panelFormuUsuarios.HorizontalScroll.Value = 0
        panelFormuGrupos.HorizontalScroll.Value = 0
    End Sub
End Class