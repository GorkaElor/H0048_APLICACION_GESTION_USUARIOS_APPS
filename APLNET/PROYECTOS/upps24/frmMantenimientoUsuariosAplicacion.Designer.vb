<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMantenimientoUsuariosAplicacion
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.panelFormuUsuarios = New System.Windows.Forms.Panel()
        Me.panelFormuGrupos = New System.Windows.Forms.Panel()
        Me.panelFormuPermisos = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'panelFormuUsuarios
        '
        Me.panelFormuUsuarios.Location = New System.Drawing.Point(40, 69)
        Me.panelFormuUsuarios.Name = "panelFormuUsuarios"
        Me.panelFormuUsuarios.Size = New System.Drawing.Size(200, 335)
        Me.panelFormuUsuarios.TabIndex = 0
        '
        'panelFormuGrupos
        '
        Me.panelFormuGrupos.AutoScroll = True
        Me.panelFormuGrupos.Location = New System.Drawing.Point(306, 69)
        Me.panelFormuGrupos.Name = "panelFormuGrupos"
        Me.panelFormuGrupos.Size = New System.Drawing.Size(200, 335)
        Me.panelFormuGrupos.TabIndex = 1
        '
        'panelFormuPermisos
        '
        Me.panelFormuPermisos.AutoScroll = True
        Me.panelFormuPermisos.Location = New System.Drawing.Point(569, 69)
        Me.panelFormuPermisos.Name = "panelFormuPermisos"
        Me.panelFormuPermisos.Size = New System.Drawing.Size(200, 335)
        Me.panelFormuPermisos.TabIndex = 2
        '
        'frmMantenimientoUsuariosAplicacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.panelFormuPermisos)
        Me.Controls.Add(Me.panelFormuGrupos)
        Me.Controls.Add(Me.panelFormuUsuarios)
        Me.Name = "frmMantenimientoUsuariosAplicacion"
        Me.Text = "USUARIOS DE APPS"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelFormuUsuarios As Panel
    Friend WithEvents panelFormuGrupos As Panel
    Friend WithEvents panelFormuPermisos As Panel
End Class
