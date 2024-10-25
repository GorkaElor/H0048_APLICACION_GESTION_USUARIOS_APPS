<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsu
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
        Me.btnReportUsuarios = New System.Windows.Forms.Button()
        Me.btnAltaUsu = New System.Windows.Forms.Button()
        Me.dtgrfrmUsu = New System.Windows.Forms.DataGridView()
        Me.btnEliminarUsu = New System.Windows.Forms.Button()
        Me.btnEditarUsu = New System.Windows.Forms.Button()
        Me.btnSalirFrmUsu = New System.Windows.Forms.Button()
        CType(Me.dtgrfrmUsu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnReportUsuarios
        '
        Me.btnReportUsuarios.Location = New System.Drawing.Point(55, 25)
        Me.btnReportUsuarios.Name = "btnReportUsuarios"
        Me.btnReportUsuarios.Size = New System.Drawing.Size(140, 23)
        Me.btnReportUsuarios.TabIndex = 1
        Me.btnReportUsuarios.Text = "Informe de usuarios"
        Me.btnReportUsuarios.UseVisualStyleBackColor = True
        '
        'btnAltaUsu
        '
        Me.btnAltaUsu.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAltaUsu.Location = New System.Drawing.Point(55, 468)
        Me.btnAltaUsu.Name = "btnAltaUsu"
        Me.btnAltaUsu.Size = New System.Drawing.Size(75, 23)
        Me.btnAltaUsu.TabIndex = 2
        Me.btnAltaUsu.Text = "ALTA"
        Me.btnAltaUsu.UseVisualStyleBackColor = True
        '
        'dtgrfrmUsu
        '
        Me.dtgrfrmUsu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgrfrmUsu.Location = New System.Drawing.Point(55, 68)
        Me.dtgrfrmUsu.Name = "dtgrfrmUsu"
        Me.dtgrfrmUsu.Size = New System.Drawing.Size(479, 369)
        Me.dtgrfrmUsu.TabIndex = 0
        '
        'btnEliminarUsu
        '
        Me.btnEliminarUsu.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarUsu.Location = New System.Drawing.Point(259, 468)
        Me.btnEliminarUsu.Name = "btnEliminarUsu"
        Me.btnEliminarUsu.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminarUsu.TabIndex = 3
        Me.btnEliminarUsu.Text = "ELIMINAR"
        Me.btnEliminarUsu.UseVisualStyleBackColor = True
        '
        'btnEditarUsu
        '
        Me.btnEditarUsu.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditarUsu.Location = New System.Drawing.Point(157, 468)
        Me.btnEditarUsu.Name = "btnEditarUsu"
        Me.btnEditarUsu.Size = New System.Drawing.Size(75, 23)
        Me.btnEditarUsu.TabIndex = 4
        Me.btnEditarUsu.Text = "EDITAR"
        Me.btnEditarUsu.UseVisualStyleBackColor = True
        '
        'btnSalirFrmUsu
        '
        Me.btnSalirFrmUsu.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalirFrmUsu.Location = New System.Drawing.Point(459, 501)
        Me.btnSalirFrmUsu.Name = "btnSalirFrmUsu"
        Me.btnSalirFrmUsu.Size = New System.Drawing.Size(75, 23)
        Me.btnSalirFrmUsu.TabIndex = 5
        Me.btnSalirFrmUsu.Text = "SALIR"
        Me.btnSalirFrmUsu.UseVisualStyleBackColor = True
        '
        'frmUsu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(627, 536)
        Me.Controls.Add(Me.btnSalirFrmUsu)
        Me.Controls.Add(Me.btnEditarUsu)
        Me.Controls.Add(Me.btnEliminarUsu)
        Me.Controls.Add(Me.btnAltaUsu)
        Me.Controls.Add(Me.btnReportUsuarios)
        Me.Controls.Add(Me.dtgrfrmUsu)
        Me.Name = "frmUsu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "USUARIOS"
        CType(Me.dtgrfrmUsu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnReportUsuarios As Button
    Friend WithEvents btnAltaUsu As Button
    Friend WithEvents dtgrfrmUsu As DataGridView
    Friend WithEvents btnEliminarUsu As Button
    Friend WithEvents btnEditarUsu As Button
    Friend WithEvents btnSalirFrmUsu As Button
End Class
