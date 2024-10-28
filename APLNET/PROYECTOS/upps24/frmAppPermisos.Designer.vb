<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAppPermisos
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
        Me.dtgrAppPermisos = New System.Windows.Forms.DataGridView()
        Me.btnNuevoPermiso = New System.Windows.Forms.Button()
        Me.btnEditarPermiso = New System.Windows.Forms.Button()
        Me.btnEliminarPermiso = New System.Windows.Forms.Button()
        CType(Me.dtgrAppPermisos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtgrAppPermisos
        '
        Me.dtgrAppPermisos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtgrAppPermisos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgrAppPermisos.Location = New System.Drawing.Point(53, 44)
        Me.dtgrAppPermisos.Name = "dtgrAppPermisos"
        Me.dtgrAppPermisos.Size = New System.Drawing.Size(435, 379)
        Me.dtgrAppPermisos.TabIndex = 0
        '
        'btnNuevoPermiso
        '
        Me.btnNuevoPermiso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevoPermiso.Location = New System.Drawing.Point(53, 441)
        Me.btnNuevoPermiso.Name = "btnNuevoPermiso"
        Me.btnNuevoPermiso.Size = New System.Drawing.Size(75, 23)
        Me.btnNuevoPermiso.TabIndex = 1
        Me.btnNuevoPermiso.Text = "NUEVO"
        Me.btnNuevoPermiso.UseVisualStyleBackColor = True
        '
        'btnEditarPermiso
        '
        Me.btnEditarPermiso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditarPermiso.Location = New System.Drawing.Point(146, 441)
        Me.btnEditarPermiso.Name = "btnEditarPermiso"
        Me.btnEditarPermiso.Size = New System.Drawing.Size(75, 23)
        Me.btnEditarPermiso.TabIndex = 2
        Me.btnEditarPermiso.Text = "EDITAR"
        Me.btnEditarPermiso.UseVisualStyleBackColor = True
        Me.btnEditarPermiso.UseWaitCursor = True
        '
        'btnEliminarPermiso
        '
        Me.btnEliminarPermiso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarPermiso.Location = New System.Drawing.Point(246, 441)
        Me.btnEliminarPermiso.Name = "btnEliminarPermiso"
        Me.btnEliminarPermiso.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminarPermiso.TabIndex = 3
        Me.btnEliminarPermiso.Text = "ELIMINAR"
        Me.btnEliminarPermiso.UseVisualStyleBackColor = True
        '
        'frmAppPermisos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(578, 475)
        Me.Controls.Add(Me.btnEliminarPermiso)
        Me.Controls.Add(Me.btnEditarPermiso)
        Me.Controls.Add(Me.btnNuevoPermiso)
        Me.Controls.Add(Me.dtgrAppPermisos)
        Me.Name = "frmAppPermisos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.dtgrAppPermisos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dtgrAppPermisos As DataGridView
    Friend WithEvents btnNuevoPermiso As Button
    Friend WithEvents btnEditarPermiso As Button
    Friend WithEvents btnEliminarPermiso As Button
End Class
