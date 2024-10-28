<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMantenimientoProcesosAplicacion
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
        Me.panelFormuPermiso = New System.Windows.Forms.Panel()
        Me.panelFormuGrupos = New System.Windows.Forms.Panel()
        Me.panelFormuUsuarios = New System.Windows.Forms.Panel()
        Me.btnReportProcesosAplicacion = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'panelFormuPermiso
        '
        Me.panelFormuPermiso.AutoScroll = True
        Me.panelFormuPermiso.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.panelFormuPermiso.Location = New System.Drawing.Point(71, 74)
        Me.panelFormuPermiso.Name = "panelFormuPermiso"
        Me.panelFormuPermiso.Size = New System.Drawing.Size(200, 343)
        Me.panelFormuPermiso.TabIndex = 0
        '
        'panelFormuGrupos
        '
        Me.panelFormuGrupos.AutoScroll = True
        Me.panelFormuGrupos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.panelFormuGrupos.Location = New System.Drawing.Point(331, 74)
        Me.panelFormuGrupos.Name = "panelFormuGrupos"
        Me.panelFormuGrupos.Size = New System.Drawing.Size(200, 343)
        Me.panelFormuGrupos.TabIndex = 1
        '
        'panelFormuUsuarios
        '
        Me.panelFormuUsuarios.AutoScroll = True
        Me.panelFormuUsuarios.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.panelFormuUsuarios.Location = New System.Drawing.Point(570, 74)
        Me.panelFormuUsuarios.Name = "panelFormuUsuarios"
        Me.panelFormuUsuarios.Size = New System.Drawing.Size(200, 343)
        Me.panelFormuUsuarios.TabIndex = 2
        '
        'btnReportProcesosAplicacion
        '
        Me.btnReportProcesosAplicacion.Location = New System.Drawing.Point(71, 12)
        Me.btnReportProcesosAplicacion.Name = "btnReportProcesosAplicacion"
        Me.btnReportProcesosAplicacion.Size = New System.Drawing.Size(75, 23)
        Me.btnReportProcesosAplicacion.TabIndex = 3
        Me.btnReportProcesosAplicacion.Text = "INFORME"
        Me.btnReportProcesosAplicacion.UseVisualStyleBackColor = True
        '
        'frmMantenimientoProcesosAplicacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnReportProcesosAplicacion)
        Me.Controls.Add(Me.panelFormuUsuarios)
        Me.Controls.Add(Me.panelFormuGrupos)
        Me.Controls.Add(Me.panelFormuPermiso)
        Me.Name = "frmMantenimientoProcesosAplicacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PERMISOS DE APPS"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelFormuPermiso As Panel
    Friend WithEvents panelFormuGrupos As Panel
    Friend WithEvents panelFormuUsuarios As Panel
    Friend WithEvents btnReportProcesosAplicacion As Button
End Class
