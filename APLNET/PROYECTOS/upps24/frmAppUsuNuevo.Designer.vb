<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAppUsuNuevo
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
        Me.dtgrAppUsuNuevo = New System.Windows.Forms.DataGridView()
        Me.btnAppUsuNuevo1 = New System.Windows.Forms.Button()
        Me.btnAppUsuNuevo2 = New System.Windows.Forms.Button()
        CType(Me.dtgrAppUsuNuevo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtgrAppUsuNuevo
        '
        Me.dtgrAppUsuNuevo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtgrAppUsuNuevo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgrAppUsuNuevo.Location = New System.Drawing.Point(35, 27)
        Me.dtgrAppUsuNuevo.Name = "dtgrAppUsuNuevo"
        Me.dtgrAppUsuNuevo.Size = New System.Drawing.Size(469, 345)
        Me.dtgrAppUsuNuevo.TabIndex = 0
        '
        'btnAppUsuNuevo1
        '
        Me.btnAppUsuNuevo1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAppUsuNuevo1.Location = New System.Drawing.Point(35, 385)
        Me.btnAppUsuNuevo1.Name = "btnAppUsuNuevo1"
        Me.btnAppUsuNuevo1.Size = New System.Drawing.Size(93, 30)
        Me.btnAppUsuNuevo1.TabIndex = 1
        Me.btnAppUsuNuevo1.Text = "Button1"
        Me.btnAppUsuNuevo1.UseVisualStyleBackColor = True
        '
        'btnAppUsuNuevo2
        '
        Me.btnAppUsuNuevo2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAppUsuNuevo2.Location = New System.Drawing.Point(177, 385)
        Me.btnAppUsuNuevo2.Name = "btnAppUsuNuevo2"
        Me.btnAppUsuNuevo2.Size = New System.Drawing.Size(93, 30)
        Me.btnAppUsuNuevo2.TabIndex = 2
        Me.btnAppUsuNuevo2.Text = "Button2"
        Me.btnAppUsuNuevo2.UseVisualStyleBackColor = True
        '
        'frmAppUsuNuevo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(530, 427)
        Me.Controls.Add(Me.btnAppUsuNuevo2)
        Me.Controls.Add(Me.btnAppUsuNuevo1)
        Me.Controls.Add(Me.dtgrAppUsuNuevo)
        Me.Name = "frmAppUsuNuevo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.dtgrAppUsuNuevo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dtgrAppUsuNuevo As DataGridView
    Friend WithEvents btnAppUsuNuevo1 As Button
    Friend WithEvents btnAppUsuNuevo2 As Button
End Class
