Public Class frmApp
    Private Sub btnGrupos_Click(sender As Object, e As EventArgs) Handles btnGrupos.Click
        'En este evento, como en el resto, hay que pasar el parámetro como referencia
        frmAppGrupos.Show()
        'Si hay alguno otro abierto, se cierran
        If frmAppPermisos.Visible Or frmAppUsuarios.Visible Then
            frmAppPermisos.Close()
            frmAppUsuarios.Close()
        End If
    End Sub

    Private Sub btnPermisos_Click(sender As Object, e As EventArgs) Handles btnPermisos.Click
        'Se trata de abrir el nuevo formulario. No olvidar pasar la referencia cuando tengamos
        'la información sobre negocio obtenida y entendida
        frmAppPermisos.Show()
        If frmAppUsuarios.Visible Or frmAppGrupos.Visible Then
            frmAppUsuarios.Close()
            frmAppGrupos.Close()
        End If

    End Sub

    Private Sub btnUsuarios_Click(sender As Object, e As EventArgs) Handles btnUsuarios.Click
        frmAppUsuarios.Show()
        'Si hay algun otro formulario abierto, se cierra
        If frmAppPermisos.Visible Or frmAppGrupos.Visible Then
            frmAppGrupos.Close()
            frmAppPermisos.Close()
        End If

    End Sub

    Private Sub btnAplicacion_Click(sender As Object, e As EventArgs) Handles btnAplicacion.Click
        'Aquí habría que hacer según el origen de la aplicación, diferenciar
        'frmAppASP.Show()
        'frmAppLanza.Show()
        'Nos quedaría lanzar el frmAppUsys
        'frmAppUsys.Show()
        'frmAppGrupos.Show()
        'frmAppPermisos.Show()
        'frmAppUsuarios.Show()
        'frmUsu.Show()
        'frmUsuNuevoCopia.Show()
        'frmUsuCopia.Show()
        frmMantenimientoGruposAplicacion.Show()
    End Sub

    Private Sub btnEliminarApp_Click(sender As Object, e As EventArgs) Handles btnEliminarApp.Click
        'Este evento requiere de otra lógica. Hacer más adelante
    End Sub

    Private Sub frmApp_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.GridFrmApps.Columns.Add("Codigo", "Código")
        Me.GridFrmApps.Columns.Add("Detalle", "Detalle")
        Me.GridFrmApps.Columns.Add("Origen", "Origen")
        Me.GridFrmApps.Columns.Add("FechaBaja", "Fecha de Baja")
        Me.GridFrmApps.Columns("FechaBaja").Visible = False

        'Centramos los títulos
        For Each column As DataGridViewColumn In GridFrmApps.Columns
            column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Next

        'Aquí se llama al método cargarDatos. No olvidar las traducciones
    End Sub

    Private Sub cargarDatos()
        'Método a realizar cuando tengamos todas las capas de negocio y datos

    End Sub

    Private Sub checkBajas_CheckedChanged(sender As Object, e As EventArgs) Handles checkBajas.CheckedChanged
        'Si está pulsado, aparecen las fechas de baja. 
        If checkBajas.Checked Then
            'Mostrar la columna Fecha de Baja
            GridFrmApps.Columns("FechaBaja").Visible = True
        Else
            'Ocultar la columna Fecha de Baja
            GridFrmApps.Columns("FechaBaja").Visible = False
        End If
    End Sub

    Private Sub GridFrmApps_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GridFrmApps.CellContentClick

    End Sub

    'Si por lo que sea se amplia en exceso el número de formularios a abrir en esta pantalla, una opción podría
    '    ser:
    'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    '    ' Cerrar todos los formularios abiertos
    '    For Each formulario As Form In Application.OpenForms
    '        If formulario IsNot Me Then ' No cerrar el formulario actual
    '            formulario.Close() ' O también puedes usar formulario.Hide()
    '        End If
    '    Next

    '    ' Crear y mostrar el nuevo formulario
    '    Dim nuevoFormulario As New Form2()
    '    nuevoFormulario.Show()
    'End Sub

End Class