<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmApp
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
        Me.btnGrupos = New System.Windows.Forms.Button()
        Me.btnPermisos = New System.Windows.Forms.Button()
        Me.btnUsuarios = New System.Windows.Forms.Button()
        Me.btnAplicacion = New System.Windows.Forms.Button()
        Me.btnEliminarApp = New System.Windows.Forms.Button()
        Me.GridFrmApps = New System.Windows.Forms.DataGridView()
        Me.checkBajas = New System.Windows.Forms.CheckBox()
        CType(Me.GridFrmApps, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnGrupos
        '
        Me.btnGrupos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGrupos.Location = New System.Drawing.Point(29, 415)
        Me.btnGrupos.Name = "btnGrupos"
        Me.btnGrupos.Size = New System.Drawing.Size(75, 23)
        Me.btnGrupos.TabIndex = 0
        Me.btnGrupos.Text = "Grupos"
        Me.btnGrupos.UseCompatibleTextRendering = True
        Me.btnGrupos.UseVisualStyleBackColor = True
        '
        'btnPermisos
        '
        Me.btnPermisos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPermisos.Location = New System.Drawing.Point(132, 414)
        Me.btnPermisos.Name = "btnPermisos"
        Me.btnPermisos.Size = New System.Drawing.Size(75, 24)
        Me.btnPermisos.TabIndex = 1
        Me.btnPermisos.Text = "Permisos"
        Me.btnPermisos.UseVisualStyleBackColor = True
        '
        'btnUsuarios
        '
        Me.btnUsuarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUsuarios.Location = New System.Drawing.Point(230, 414)
        Me.btnUsuarios.Name = "btnUsuarios"
        Me.btnUsuarios.Size = New System.Drawing.Size(75, 24)
        Me.btnUsuarios.TabIndex = 2
        Me.btnUsuarios.Text = "Usuarios"
        Me.btnUsuarios.UseVisualStyleBackColor = True
        Me.btnUsuarios.UseWaitCursor = True
        '
        'btnAplicacion
        '
        Me.btnAplicacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAplicacion.Location = New System.Drawing.Point(326, 414)
        Me.btnAplicacion.Name = "btnAplicacion"
        Me.btnAplicacion.Size = New System.Drawing.Size(75, 24)
        Me.btnAplicacion.TabIndex = 3
        Me.btnAplicacion.Text = "Aplicación"
        Me.btnAplicacion.UseVisualStyleBackColor = True
        '
        'btnEliminarApp
        '
        Me.btnEliminarApp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarApp.Location = New System.Drawing.Point(427, 414)
        Me.btnEliminarApp.Name = "btnEliminarApp"
        Me.btnEliminarApp.Size = New System.Drawing.Size(115, 24)
        Me.btnEliminarApp.TabIndex = 4
        Me.btnEliminarApp.Text = "Eliminar Aplicación"
        Me.btnEliminarApp.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnEliminarApp.UseVisualStyleBackColor = True
        '
        'GridFrmApps
        '
        Me.GridFrmApps.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.GridFrmApps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridFrmApps.Location = New System.Drawing.Point(29, 8)
        Me.GridFrmApps.Name = "GridFrmApps"
        Me.GridFrmApps.Size = New System.Drawing.Size(737, 381)
        Me.GridFrmApps.TabIndex = 5
        '
        'checkBajas
        '
        Me.checkBajas.AutoSize = True
        Me.checkBajas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkBajas.Location = New System.Drawing.Point(661, 421)
        Me.checkBajas.Name = "checkBajas"
        Me.checkBajas.Size = New System.Drawing.Size(64, 17)
        Me.checkBajas.TabIndex = 6
        Me.checkBajas.Text = "BAJAS"
        Me.checkBajas.UseVisualStyleBackColor = True
        '
        'frmApp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(819, 468)
        Me.Controls.Add(Me.checkBajas)
        Me.Controls.Add(Me.GridFrmApps)
        Me.Controls.Add(Me.btnEliminarApp)
        Me.Controls.Add(Me.btnAplicacion)
        Me.Controls.Add(Me.btnUsuarios)
        Me.Controls.Add(Me.btnPermisos)
        Me.Controls.Add(Me.btnGrupos)
        Me.Name = "frmApp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Apps"
        CType(Me.GridFrmApps, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnGrupos As Button
    Friend WithEvents btnPermisos As Button
    Friend WithEvents btnUsuarios As Button
    Friend WithEvents btnAplicacion As Button
    Friend WithEvents btnEliminarApp As Button
    Friend WithEvents GridFrmApps As DataGridView
    Friend WithEvents checkBajas As CheckBox
End Class
