<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsuNuevoCopia
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.tblUsuNuevoCopia = New System.Windows.Forms.TableLayoutPanel()
        Me.lbl431CopiarDesde = New System.Windows.Forms.Label()
        Me.Lbl431Nuevo = New System.Windows.Forms.Label()
        Me.lblNombreCopiarDesde = New System.Windows.Forms.Label()
        Me.lblNuevo = New System.Windows.Forms.Label()
        Me.lblDNICopiarDesde = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblCopiarDesde = New System.Windows.Forms.Label()
        Me.lblDNI = New System.Windows.Forms.Label()
        Me.txtDNINuevo = New System.Windows.Forms.TextBox()
        Me.txtNombreNuevo = New System.Windows.Forms.TextBox()
        Me.txt431Nuevo = New System.Windows.Forms.TextBox()
        Me.txtDNICopiarDesde = New System.Windows.Forms.TextBox()
        Me.txtNombreCopiarDesde = New System.Windows.Forms.TextBox()
        Me.txt431CopiarDesde = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.tblUsuNuevoCopia.SuspendLayout()
        Me.SuspendLayout()
        '
        'tblUsuNuevoCopia
        '
        Me.tblUsuNuevoCopia.ColumnCount = 4
        Me.tblUsuNuevoCopia.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tblUsuNuevoCopia.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tblUsuNuevoCopia.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tblUsuNuevoCopia.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tblUsuNuevoCopia.Controls.Add(Me.txt431CopiarDesde, 3, 3)
        Me.tblUsuNuevoCopia.Controls.Add(Me.txtNombreCopiarDesde, 3, 2)
        Me.tblUsuNuevoCopia.Controls.Add(Me.txtDNICopiarDesde, 3, 1)
        Me.tblUsuNuevoCopia.Controls.Add(Me.txt431Nuevo, 1, 3)
        Me.tblUsuNuevoCopia.Controls.Add(Me.txtNombreNuevo, 1, 2)
        Me.tblUsuNuevoCopia.Controls.Add(Me.lbl431CopiarDesde, 2, 3)
        Me.tblUsuNuevoCopia.Controls.Add(Me.Lbl431Nuevo, 0, 3)
        Me.tblUsuNuevoCopia.Controls.Add(Me.lblNombreCopiarDesde, 2, 2)
        Me.tblUsuNuevoCopia.Controls.Add(Me.lblDNICopiarDesde, 2, 1)
        Me.tblUsuNuevoCopia.Controls.Add(Me.lblNombre, 0, 2)
        Me.tblUsuNuevoCopia.Controls.Add(Me.lblCopiarDesde, 2, 0)
        Me.tblUsuNuevoCopia.Controls.Add(Me.lblDNI, 0, 1)
        Me.tblUsuNuevoCopia.Controls.Add(Me.lblNuevo, 0, 0)
        Me.tblUsuNuevoCopia.Controls.Add(Me.txtDNINuevo, 1, 1)
        Me.tblUsuNuevoCopia.Location = New System.Drawing.Point(64, 30)
        Me.tblUsuNuevoCopia.Name = "tblUsuNuevoCopia"
        Me.tblUsuNuevoCopia.RowCount = 4
        Me.tblUsuNuevoCopia.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tblUsuNuevoCopia.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tblUsuNuevoCopia.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tblUsuNuevoCopia.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tblUsuNuevoCopia.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblUsuNuevoCopia.Size = New System.Drawing.Size(640, 240)
        Me.tblUsuNuevoCopia.TabIndex = 0
        '
        'lbl431CopiarDesde
        '
        Me.lbl431CopiarDesde.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl431CopiarDesde.AutoSize = True
        Me.lbl431CopiarDesde.Location = New System.Drawing.Point(323, 203)
        Me.lbl431CopiarDesde.Name = "lbl431CopiarDesde"
        Me.lbl431CopiarDesde.Size = New System.Drawing.Size(154, 13)
        Me.lbl431CopiarDesde.TabIndex = 4
        Me.lbl431CopiarDesde.Text = "431"
        Me.lbl431CopiarDesde.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl431Nuevo
        '
        Me.Lbl431Nuevo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl431Nuevo.AutoSize = True
        Me.Lbl431Nuevo.Location = New System.Drawing.Point(3, 203)
        Me.Lbl431Nuevo.Name = "Lbl431Nuevo"
        Me.Lbl431Nuevo.Size = New System.Drawing.Size(154, 13)
        Me.Lbl431Nuevo.TabIndex = 3
        Me.Lbl431Nuevo.Text = "431"
        Me.Lbl431Nuevo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNombreCopiarDesde
        '
        Me.lblNombreCopiarDesde.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNombreCopiarDesde.AutoSize = True
        Me.lblNombreCopiarDesde.Location = New System.Drawing.Point(323, 143)
        Me.lblNombreCopiarDesde.Name = "lblNombreCopiarDesde"
        Me.lblNombreCopiarDesde.Size = New System.Drawing.Size(154, 13)
        Me.lblNombreCopiarDesde.TabIndex = 3
        Me.lblNombreCopiarDesde.Text = "NOMBRE"
        Me.lblNombreCopiarDesde.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNuevo
        '
        Me.lblNuevo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNuevo.AutoSize = True
        Me.tblUsuNuevoCopia.SetColumnSpan(Me.lblNuevo, 2)
        Me.lblNuevo.Location = New System.Drawing.Point(3, 23)
        Me.lblNuevo.Name = "lblNuevo"
        Me.lblNuevo.Size = New System.Drawing.Size(314, 13)
        Me.lblNuevo.TabIndex = 0
        Me.lblNuevo.Text = "NUEVO"
        Me.lblNuevo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblDNICopiarDesde
        '
        Me.lblDNICopiarDesde.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDNICopiarDesde.AutoSize = True
        Me.lblDNICopiarDesde.Location = New System.Drawing.Point(323, 83)
        Me.lblDNICopiarDesde.Name = "lblDNICopiarDesde"
        Me.lblDNICopiarDesde.Size = New System.Drawing.Size(154, 13)
        Me.lblDNICopiarDesde.TabIndex = 2
        Me.lblDNICopiarDesde.Text = "DNI"
        Me.lblDNICopiarDesde.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNombre
        '
        Me.lblNombre.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(3, 143)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(154, 13)
        Me.lblNombre.TabIndex = 1
        Me.lblNombre.Text = "NOMBRE"
        Me.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCopiarDesde
        '
        Me.lblCopiarDesde.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCopiarDesde.AutoSize = True
        Me.tblUsuNuevoCopia.SetColumnSpan(Me.lblCopiarDesde, 2)
        Me.lblCopiarDesde.Location = New System.Drawing.Point(323, 23)
        Me.lblCopiarDesde.Name = "lblCopiarDesde"
        Me.lblCopiarDesde.Size = New System.Drawing.Size(314, 13)
        Me.lblCopiarDesde.TabIndex = 1
        Me.lblCopiarDesde.Text = "COPIAR DESDE"
        Me.lblCopiarDesde.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDNI
        '
        Me.lblDNI.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDNI.AutoSize = True
        Me.lblDNI.Location = New System.Drawing.Point(3, 83)
        Me.lblDNI.Name = "lblDNI"
        Me.lblDNI.Size = New System.Drawing.Size(154, 13)
        Me.lblDNI.TabIndex = 2
        Me.lblDNI.Text = "DNI"
        Me.lblDNI.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtDNINuevo
        '
        Me.txtDNINuevo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDNINuevo.Location = New System.Drawing.Point(163, 80)
        Me.txtDNINuevo.MaxLength = 9
        Me.txtDNINuevo.Name = "txtDNINuevo"
        Me.txtDNINuevo.Size = New System.Drawing.Size(154, 20)
        Me.txtDNINuevo.TabIndex = 5
        Me.txtDNINuevo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtNombreNuevo
        '
        Me.txtNombreNuevo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNombreNuevo.Location = New System.Drawing.Point(163, 140)
        Me.txtNombreNuevo.MaxLength = 150
        Me.txtNombreNuevo.Name = "txtNombreNuevo"
        Me.txtNombreNuevo.Size = New System.Drawing.Size(154, 20)
        Me.txtNombreNuevo.TabIndex = 6
        Me.txtNombreNuevo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt431Nuevo
        '
        Me.txt431Nuevo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt431Nuevo.Location = New System.Drawing.Point(163, 200)
        Me.txt431Nuevo.Name = "txt431Nuevo"
        Me.txt431Nuevo.Size = New System.Drawing.Size(154, 20)
        Me.txt431Nuevo.TabIndex = 6
        Me.txt431Nuevo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDNICopiarDesde
        '
        Me.txtDNICopiarDesde.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDNICopiarDesde.Location = New System.Drawing.Point(483, 80)
        Me.txtDNICopiarDesde.Name = "txtDNICopiarDesde"
        Me.txtDNICopiarDesde.Size = New System.Drawing.Size(154, 20)
        Me.txtDNICopiarDesde.TabIndex = 6
        Me.txtDNICopiarDesde.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtNombreCopiarDesde
        '
        Me.txtNombreCopiarDesde.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNombreCopiarDesde.Location = New System.Drawing.Point(483, 140)
        Me.txtNombreCopiarDesde.Name = "txtNombreCopiarDesde"
        Me.txtNombreCopiarDesde.Size = New System.Drawing.Size(154, 20)
        Me.txtNombreCopiarDesde.TabIndex = 6
        Me.txtNombreCopiarDesde.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt431CopiarDesde
        '
        Me.txt431CopiarDesde.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt431CopiarDesde.Location = New System.Drawing.Point(483, 200)
        Me.txt431CopiarDesde.Name = "txt431CopiarDesde"
        Me.txt431CopiarDesde.Size = New System.Drawing.Size(154, 20)
        Me.txt431CopiarDesde.TabIndex = 6
        Me.txt431CopiarDesde.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(64, 383)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "SALIR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(626, 383)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "COPIAR"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'frmUsuNuevoCopia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.tblUsuNuevoCopia)
        Me.Name = "frmUsuNuevoCopia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "COPIA USUARIO"
        Me.tblUsuNuevoCopia.ResumeLayout(False)
        Me.tblUsuNuevoCopia.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tblUsuNuevoCopia As TableLayoutPanel
    Friend WithEvents lbl431CopiarDesde As Label
    Friend WithEvents Lbl431Nuevo As Label
    Friend WithEvents lblNombreCopiarDesde As Label
    Friend WithEvents lblNuevo As Label
    Friend WithEvents lblDNICopiarDesde As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblCopiarDesde As Label
    Friend WithEvents lblDNI As Label
    Friend WithEvents txt431CopiarDesde As TextBox
    Friend WithEvents txtNombreCopiarDesde As TextBox
    Friend WithEvents txtDNICopiarDesde As TextBox
    Friend WithEvents txt431Nuevo As TextBox
    Friend WithEvents txtNombreNuevo As TextBox
    Friend WithEvents txtDNINuevo As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
