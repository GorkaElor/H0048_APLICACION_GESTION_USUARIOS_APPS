<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAppGrupos
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
        Me.dtgrAppGrupos = New System.Windows.Forms.DataGridView()
        Me.btnNuevoGrupo = New System.Windows.Forms.Button()
        Me.btnEditarGrupo = New System.Windows.Forms.Button()
        Me.btnEliminarGrupo = New System.Windows.Forms.Button()
        CType(Me.dtgrAppGrupos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtgrAppGrupos
        '
        Me.dtgrAppGrupos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtgrAppGrupos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgrAppGrupos.Location = New System.Drawing.Point(62, 30)
        Me.dtgrAppGrupos.Name = "dtgrAppGrupos"
        Me.dtgrAppGrupos.Size = New System.Drawing.Size(435, 379)
        Me.dtgrAppGrupos.TabIndex = 0
        '
        'btnNuevoGrupo
        '
        Me.btnNuevoGrupo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevoGrupo.Location = New System.Drawing.Point(44, 430)
        Me.btnNuevoGrupo.Name = "btnNuevoGrupo"
        Me.btnNuevoGrupo.Size = New System.Drawing.Size(75, 23)
        Me.btnNuevoGrupo.TabIndex = 1
        Me.btnNuevoGrupo.Text = "NUEVO"
        Me.btnNuevoGrupo.UseVisualStyleBackColor = True
        '
        'btnEditarGrupo
        '
        Me.btnEditarGrupo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditarGrupo.Location = New System.Drawing.Point(143, 430)
        Me.btnEditarGrupo.Name = "btnEditarGrupo"
        Me.btnEditarGrupo.Size = New System.Drawing.Size(75, 23)
        Me.btnEditarGrupo.TabIndex = 2
        Me.btnEditarGrupo.Text = "EDITAR"
        Me.btnEditarGrupo.UseVisualStyleBackColor = True
        '
        'btnEliminarGrupo
        '
        Me.btnEliminarGrupo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarGrupo.Location = New System.Drawing.Point(241, 430)
        Me.btnEliminarGrupo.Name = "btnEliminarGrupo"
        Me.btnEliminarGrupo.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminarGrupo.TabIndex = 3
        Me.btnEliminarGrupo.Text = "ELIMINAR"
        Me.btnEliminarGrupo.UseVisualStyleBackColor = True
        '
        'frmAppGrupos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(578, 475)
        Me.Controls.Add(Me.btnEliminarGrupo)
        Me.Controls.Add(Me.btnEditarGrupo)
        Me.Controls.Add(Me.btnNuevoGrupo)
        Me.Controls.Add(Me.dtgrAppGrupos)
        Me.Name = "frmAppGrupos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.dtgrAppGrupos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dtgrAppGrupos As DataGridView
    Friend WithEvents btnNuevoGrupo As Button
    Friend WithEvents btnEditarGrupo As Button
    Friend WithEvents btnEliminarGrupo As Button
End Class
