<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAppUsuarios
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
        Me.dtgrAppUsuarios = New System.Windows.Forms.DataGridView()
        Me.btnNuevoUsuario = New System.Windows.Forms.Button()
        Me.btnEditarUsuario = New System.Windows.Forms.Button()
        Me.btnEliminarUsuario = New System.Windows.Forms.Button()
        CType(Me.dtgrAppUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtgrAppUsuarios
        '
        Me.dtgrAppUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgrAppUsuarios.Location = New System.Drawing.Point(78, 29)
        Me.dtgrAppUsuarios.Name = "dtgrAppUsuarios"
        Me.dtgrAppUsuarios.Size = New System.Drawing.Size(435, 352)
        Me.dtgrAppUsuarios.TabIndex = 0
        '
        'btnNuevoUsuario
        '
        Me.btnNuevoUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevoUsuario.Location = New System.Drawing.Point(78, 408)
        Me.btnNuevoUsuario.Name = "btnNuevoUsuario"
        Me.btnNuevoUsuario.Size = New System.Drawing.Size(75, 23)
        Me.btnNuevoUsuario.TabIndex = 1
        Me.btnNuevoUsuario.Text = "NUEVO"
        Me.btnNuevoUsuario.UseVisualStyleBackColor = True
        '
        'btnEditarUsuario
        '
        Me.btnEditarUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditarUsuario.Location = New System.Drawing.Point(180, 408)
        Me.btnEditarUsuario.Name = "btnEditarUsuario"
        Me.btnEditarUsuario.Size = New System.Drawing.Size(75, 23)
        Me.btnEditarUsuario.TabIndex = 2
        Me.btnEditarUsuario.Text = "EDITAR"
        Me.btnEditarUsuario.UseVisualStyleBackColor = True
        '
        'btnEliminarUsuario
        '
        Me.btnEliminarUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarUsuario.Location = New System.Drawing.Point(290, 408)
        Me.btnEliminarUsuario.Name = "btnEliminarUsuario"
        Me.btnEliminarUsuario.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminarUsuario.TabIndex = 3
        Me.btnEliminarUsuario.Text = "ELIMINAR"
        Me.btnEliminarUsuario.UseVisualStyleBackColor = True
        '
        'frmAppUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(578, 465)
        Me.Controls.Add(Me.btnEliminarUsuario)
        Me.Controls.Add(Me.btnEditarUsuario)
        Me.Controls.Add(Me.btnNuevoUsuario)
        Me.Controls.Add(Me.dtgrAppUsuarios)
        Me.Name = "frmAppUsuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.dtgrAppUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dtgrAppUsuarios As DataGridView
    Friend WithEvents btnNuevoUsuario As Button
    Friend WithEvents btnEditarUsuario As Button
    Friend WithEvents btnEliminarUsuario As Button
End Class
