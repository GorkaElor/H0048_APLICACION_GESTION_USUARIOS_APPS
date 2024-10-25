<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMantenimientoGruposAplicacion
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
        Me.panelContenedorFormuGrupo = New System.Windows.Forms.Panel()
        Me.btnReport = New System.Windows.Forms.Button()
        Me.panelFormuPermisos = New System.Windows.Forms.Panel()
        Me.panelFormuUsuarios = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'panelContenedorFormuGrupo
        '
        Me.panelContenedorFormuGrupo.AutoScroll = True
        Me.panelContenedorFormuGrupo.AutoScrollMargin = New System.Drawing.Size(3, 3)
        Me.panelContenedorFormuGrupo.Location = New System.Drawing.Point(63, 101)
        Me.panelContenedorFormuGrupo.Name = "panelContenedorFormuGrupo"
        Me.panelContenedorFormuGrupo.Size = New System.Drawing.Size(175, 299)
        Me.panelContenedorFormuGrupo.TabIndex = 0
        '
        'btnReport
        '
        Me.btnReport.Location = New System.Drawing.Point(63, 34)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(75, 23)
        Me.btnReport.TabIndex = 1
        Me.btnReport.Text = "Informe"
        Me.btnReport.UseVisualStyleBackColor = True
        '
        'panelFormuPermisos
        '
        Me.panelFormuPermisos.AutoScroll = True
        Me.panelFormuPermisos.AutoScrollMargin = New System.Drawing.Size(3, 3)
        Me.panelFormuPermisos.Location = New System.Drawing.Point(300, 101)
        Me.panelFormuPermisos.Name = "panelFormuPermisos"
        Me.panelFormuPermisos.Size = New System.Drawing.Size(175, 299)
        Me.panelFormuPermisos.TabIndex = 2
        '
        'panelFormuUsuarios
        '
        Me.panelFormuUsuarios.AutoScroll = True
        Me.panelFormuUsuarios.AutoScrollMargin = New System.Drawing.Size(3, 3)
        Me.panelFormuUsuarios.Location = New System.Drawing.Point(522, 101)
        Me.panelFormuUsuarios.Name = "panelFormuUsuarios"
        Me.panelFormuUsuarios.Size = New System.Drawing.Size(175, 299)
        Me.panelFormuUsuarios.TabIndex = 3
        '
        'frmMantenimientoGruposAplicacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.panelFormuUsuarios)
        Me.Controls.Add(Me.panelFormuPermisos)
        Me.Controls.Add(Me.btnReport)
        Me.Controls.Add(Me.panelContenedorFormuGrupo)
        Me.Name = "frmMantenimientoGruposAplicacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GRUPOS DE APPS"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelContenedorFormuGrupo As Panel
    Friend WithEvents btnReport As Button
    Friend WithEvents panelFormuPermisos As Panel
    Friend WithEvents panelFormuUsuarios As Panel
End Class
