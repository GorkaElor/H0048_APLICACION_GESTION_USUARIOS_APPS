<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmUsuCopia
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
        Dim tblUsuCopia As System.Windows.Forms.TableLayoutPanel
        Me.txt431CopiarDesde = New System.Windows.Forms.TextBox()
        Me.txtNombreCopiarDesde = New System.Windows.Forms.TextBox()
        Me.txtDNICopiarDesde = New System.Windows.Forms.TextBox()
        Me.txt431Destino = New System.Windows.Forms.TextBox()
        Me.txtNombreDestino = New System.Windows.Forms.TextBox()
        Me.lblCopiarDesdeUsuCopia = New System.Windows.Forms.Label()
        Me.lbl431Destino = New System.Windows.Forms.Label()
        Me.lblDestinoUsuCopia = New System.Windows.Forms.Label()
        Me.lblDNIUsuCopia = New System.Windows.Forms.Label()
        Me.lblNombreDestino = New System.Windows.Forms.Label()
        Me.lblDNICopiarDesde = New System.Windows.Forms.Label()
        Me.lblNombreCopiarDesde = New System.Windows.Forms.Label()
        Me.lbl431CopiarDesde = New System.Windows.Forms.Label()
        Me.txtDNIDestino = New System.Windows.Forms.TextBox()
        Me.panelFormu1 = New System.Windows.Forms.Panel()
        Me.dtgrPanelFormu1 = New System.Windows.Forms.DataGridView()
        Me.panelFormu2 = New System.Windows.Forms.Panel()
        Me.dtgrPanelFormu2 = New System.Windows.Forms.DataGridView()
        Me.btn1Formu2 = New System.Windows.Forms.Button()
        Me.btn2Formu2 = New System.Windows.Forms.Button()
        tblUsuCopia = New System.Windows.Forms.TableLayoutPanel()
        tblUsuCopia.SuspendLayout()
        Me.panelFormu1.SuspendLayout()
        CType(Me.dtgrPanelFormu1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelFormu2.SuspendLayout()
        CType(Me.dtgrPanelFormu2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tblUsuCopia
        '
        tblUsuCopia.ColumnCount = 4
        tblUsuCopia.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        tblUsuCopia.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        tblUsuCopia.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        tblUsuCopia.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        tblUsuCopia.Controls.Add(Me.txt431CopiarDesde, 3, 3)
        tblUsuCopia.Controls.Add(Me.txtNombreCopiarDesde, 3, 2)
        tblUsuCopia.Controls.Add(Me.txtDNICopiarDesde, 3, 1)
        tblUsuCopia.Controls.Add(Me.txt431Destino, 1, 3)
        tblUsuCopia.Controls.Add(Me.txtNombreDestino, 1, 2)
        tblUsuCopia.Controls.Add(Me.lblCopiarDesdeUsuCopia, 2, 0)
        tblUsuCopia.Controls.Add(Me.lbl431Destino, 0, 3)
        tblUsuCopia.Controls.Add(Me.lblDestinoUsuCopia, 0, 0)
        tblUsuCopia.Controls.Add(Me.lblDNIUsuCopia, 0, 1)
        tblUsuCopia.Controls.Add(Me.lblNombreDestino, 0, 2)
        tblUsuCopia.Controls.Add(Me.lblDNICopiarDesde, 2, 1)
        tblUsuCopia.Controls.Add(Me.lblNombreCopiarDesde, 2, 2)
        tblUsuCopia.Controls.Add(Me.lbl431CopiarDesde, 2, 3)
        tblUsuCopia.Controls.Add(Me.txtDNIDestino, 1, 1)
        tblUsuCopia.Location = New System.Drawing.Point(82, 36)
        tblUsuCopia.Name = "tblUsuCopia"
        tblUsuCopia.RowCount = 4
        tblUsuCopia.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        tblUsuCopia.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        tblUsuCopia.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        tblUsuCopia.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        tblUsuCopia.Size = New System.Drawing.Size(605, 189)
        tblUsuCopia.TabIndex = 0
        '
        'txt431CopiarDesde
        '
        Me.txt431CopiarDesde.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt431CopiarDesde.Location = New System.Drawing.Point(456, 155)
        Me.txt431CopiarDesde.Name = "txt431CopiarDesde"
        Me.txt431CopiarDesde.Size = New System.Drawing.Size(146, 20)
        Me.txt431CopiarDesde.TabIndex = 7
        Me.txt431CopiarDesde.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtNombreCopiarDesde
        '
        Me.txtNombreCopiarDesde.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNombreCopiarDesde.Location = New System.Drawing.Point(456, 107)
        Me.txtNombreCopiarDesde.Name = "txtNombreCopiarDesde"
        Me.txtNombreCopiarDesde.Size = New System.Drawing.Size(146, 20)
        Me.txtNombreCopiarDesde.TabIndex = 8
        Me.txtNombreCopiarDesde.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDNICopiarDesde
        '
        Me.txtDNICopiarDesde.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDNICopiarDesde.Location = New System.Drawing.Point(456, 60)
        Me.txtDNICopiarDesde.Name = "txtDNICopiarDesde"
        Me.txtDNICopiarDesde.Size = New System.Drawing.Size(146, 20)
        Me.txtDNICopiarDesde.TabIndex = 7
        Me.txtDNICopiarDesde.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt431Destino
        '
        Me.txt431Destino.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt431Destino.Location = New System.Drawing.Point(154, 155)
        Me.txt431Destino.Name = "txt431Destino"
        Me.txt431Destino.Size = New System.Drawing.Size(145, 20)
        Me.txt431Destino.TabIndex = 7
        Me.txt431Destino.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtNombreDestino
        '
        Me.txtNombreDestino.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNombreDestino.Location = New System.Drawing.Point(154, 107)
        Me.txtNombreDestino.Name = "txtNombreDestino"
        Me.txtNombreDestino.Size = New System.Drawing.Size(145, 20)
        Me.txtNombreDestino.TabIndex = 8
        Me.txtNombreDestino.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblCopiarDesdeUsuCopia
        '
        Me.lblCopiarDesdeUsuCopia.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCopiarDesdeUsuCopia.AutoSize = True
        tblUsuCopia.SetColumnSpan(Me.lblCopiarDesdeUsuCopia, 2)
        Me.lblCopiarDesdeUsuCopia.Location = New System.Drawing.Point(305, 17)
        Me.lblCopiarDesdeUsuCopia.Name = "lblCopiarDesdeUsuCopia"
        Me.lblCopiarDesdeUsuCopia.Size = New System.Drawing.Size(297, 13)
        Me.lblCopiarDesdeUsuCopia.TabIndex = 1
        Me.lblCopiarDesdeUsuCopia.Text = "COPIAR DESDE"
        Me.lblCopiarDesdeUsuCopia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl431Destino
        '
        Me.lbl431Destino.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl431Destino.AutoSize = True
        Me.lbl431Destino.Location = New System.Drawing.Point(3, 158)
        Me.lbl431Destino.Name = "lbl431Destino"
        Me.lbl431Destino.Size = New System.Drawing.Size(145, 13)
        Me.lbl431Destino.TabIndex = 1
        Me.lbl431Destino.Text = "431"
        Me.lbl431Destino.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'lblDestinoUsuCopia
        '
        Me.lblDestinoUsuCopia.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDestinoUsuCopia.AutoSize = True
        tblUsuCopia.SetColumnSpan(Me.lblDestinoUsuCopia, 2)
        Me.lblDestinoUsuCopia.Location = New System.Drawing.Point(3, 17)
        Me.lblDestinoUsuCopia.Name = "lblDestinoUsuCopia"
        Me.lblDestinoUsuCopia.Size = New System.Drawing.Size(296, 13)
        Me.lblDestinoUsuCopia.TabIndex = 0
        Me.lblDestinoUsuCopia.Text = "DESTINO"
        Me.lblDestinoUsuCopia.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'lblDNIUsuCopia
        '
        Me.lblDNIUsuCopia.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDNIUsuCopia.AutoSize = True
        Me.lblDNIUsuCopia.Location = New System.Drawing.Point(3, 64)
        Me.lblDNIUsuCopia.Name = "lblDNIUsuCopia"
        Me.lblDNIUsuCopia.Size = New System.Drawing.Size(145, 13)
        Me.lblDNIUsuCopia.TabIndex = 1
        Me.lblDNIUsuCopia.Text = "DNI"
        Me.lblDNIUsuCopia.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'lblNombreDestino
        '
        Me.lblNombreDestino.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNombreDestino.AutoSize = True
        Me.lblNombreDestino.Location = New System.Drawing.Point(3, 111)
        Me.lblNombreDestino.Name = "lblNombreDestino"
        Me.lblNombreDestino.Size = New System.Drawing.Size(145, 13)
        Me.lblNombreDestino.TabIndex = 2
        Me.lblNombreDestino.Text = "NOMBRE"
        Me.lblNombreDestino.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'lblDNICopiarDesde
        '
        Me.lblDNICopiarDesde.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDNICopiarDesde.AutoSize = True
        Me.lblDNICopiarDesde.Location = New System.Drawing.Point(305, 64)
        Me.lblDNICopiarDesde.Name = "lblDNICopiarDesde"
        Me.lblDNICopiarDesde.Size = New System.Drawing.Size(145, 13)
        Me.lblDNICopiarDesde.TabIndex = 3
        Me.lblDNICopiarDesde.Text = "DNI"
        Me.lblDNICopiarDesde.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblDNICopiarDesde.UseWaitCursor = True
        '
        'lblNombreCopiarDesde
        '
        Me.lblNombreCopiarDesde.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNombreCopiarDesde.AutoSize = True
        Me.lblNombreCopiarDesde.Location = New System.Drawing.Point(305, 111)
        Me.lblNombreCopiarDesde.Name = "lblNombreCopiarDesde"
        Me.lblNombreCopiarDesde.Size = New System.Drawing.Size(145, 13)
        Me.lblNombreCopiarDesde.TabIndex = 4
        Me.lblNombreCopiarDesde.Text = "NOMBRE"
        Me.lblNombreCopiarDesde.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl431CopiarDesde
        '
        Me.lbl431CopiarDesde.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl431CopiarDesde.AutoSize = True
        Me.lbl431CopiarDesde.Location = New System.Drawing.Point(305, 158)
        Me.lbl431CopiarDesde.Name = "lbl431CopiarDesde"
        Me.lbl431CopiarDesde.Size = New System.Drawing.Size(145, 13)
        Me.lbl431CopiarDesde.TabIndex = 5
        Me.lbl431CopiarDesde.Text = "431"
        Me.lbl431CopiarDesde.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtDNIDestino
        '
        Me.txtDNIDestino.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDNIDestino.Location = New System.Drawing.Point(154, 60)
        Me.txtDNIDestino.Name = "txtDNIDestino"
        Me.txtDNIDestino.Size = New System.Drawing.Size(145, 20)
        Me.txtDNIDestino.TabIndex = 6
        Me.txtDNIDestino.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'panelFormu1
        '
        Me.panelFormu1.AutoScroll = True
        Me.panelFormu1.AutoScrollMargin = New System.Drawing.Size(3, 3)
        Me.panelFormu1.Controls.Add(Me.dtgrPanelFormu1)
        Me.panelFormu1.Location = New System.Drawing.Point(82, 271)
        Me.panelFormu1.Name = "panelFormu1"
        Me.panelFormu1.Size = New System.Drawing.Size(202, 227)
        Me.panelFormu1.TabIndex = 1
        '
        'dtgrPanelFormu1
        '
        Me.dtgrPanelFormu1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgrPanelFormu1.Location = New System.Drawing.Point(16, 20)
        Me.dtgrPanelFormu1.Name = "dtgrPanelFormu1"
        Me.dtgrPanelFormu1.Size = New System.Drawing.Size(169, 150)
        Me.dtgrPanelFormu1.TabIndex = 0
        '
        'panelFormu2
        '
        Me.panelFormu2.Controls.Add(Me.btn2Formu2)
        Me.panelFormu2.Controls.Add(Me.btn1Formu2)
        Me.panelFormu2.Controls.Add(Me.dtgrPanelFormu2)
        Me.panelFormu2.Location = New System.Drawing.Point(487, 271)
        Me.panelFormu2.Name = "panelFormu2"
        Me.panelFormu2.Size = New System.Drawing.Size(202, 227)
        Me.panelFormu2.TabIndex = 2
        '
        'dtgrPanelFormu2
        '
        Me.dtgrPanelFormu2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgrPanelFormu2.Location = New System.Drawing.Point(14, 20)
        Me.dtgrPanelFormu2.Name = "dtgrPanelFormu2"
        Me.dtgrPanelFormu2.Size = New System.Drawing.Size(169, 150)
        Me.dtgrPanelFormu2.TabIndex = 0
        '
        'btn1Formu2
        '
        Me.btn1Formu2.Location = New System.Drawing.Point(14, 187)
        Me.btn1Formu2.Name = "btn1Formu2"
        Me.btn1Formu2.Size = New System.Drawing.Size(75, 23)
        Me.btn1Formu2.TabIndex = 1
        Me.btn1Formu2.Text = "Button1"
        Me.btn1Formu2.UseVisualStyleBackColor = True
        '
        'btn2Formu2
        '
        Me.btn2Formu2.Location = New System.Drawing.Point(108, 187)
        Me.btn2Formu2.Name = "btn2Formu2"
        Me.btn2Formu2.Size = New System.Drawing.Size(75, 23)
        Me.btn2Formu2.TabIndex = 2
        Me.btn2Formu2.Text = "Button2"
        Me.btn2Formu2.UseVisualStyleBackColor = True
        '
        'frmUsuCopia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 557)
        Me.Controls.Add(Me.panelFormu2)
        Me.Controls.Add(Me.panelFormu1)
        Me.Controls.Add(tblUsuCopia)
        Me.Name = "frmUsuCopia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        tblUsuCopia.ResumeLayout(False)
        tblUsuCopia.PerformLayout()
        Me.panelFormu1.ResumeLayout(False)
        CType(Me.dtgrPanelFormu1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelFormu2.ResumeLayout(False)
        CType(Me.dtgrPanelFormu2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblCopiarDesdeUsuCopia As Label
    Friend WithEvents lbl431Destino As Label
    Friend WithEvents lblDestinoUsuCopia As Label
    Friend WithEvents lblDNIUsuCopia As Label
    Friend WithEvents lblNombreDestino As Label
    Friend WithEvents lblDNICopiarDesde As Label
    Friend WithEvents lblNombreCopiarDesde As Label
    Friend WithEvents lbl431CopiarDesde As Label
    Friend WithEvents txt431CopiarDesde As TextBox
    Friend WithEvents txtNombreCopiarDesde As TextBox
    Friend WithEvents txtDNICopiarDesde As TextBox
    Friend WithEvents txt431Destino As TextBox
    Friend WithEvents txtNombreDestino As TextBox
    Friend WithEvents txtDNIDestino As TextBox
    Friend WithEvents panelFormu1 As Panel
    Friend WithEvents dtgrPanelFormu1 As DataGridView
    Friend WithEvents panelFormu2 As Panel
    Friend WithEvents dtgrPanelFormu2 As DataGridView
    Friend WithEvents btn1Formu2 As Button
    Friend WithEvents btn2Formu2 As Button
End Class
