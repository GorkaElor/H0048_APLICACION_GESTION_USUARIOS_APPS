<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAppUsys
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
        Me.btnValidarUSYS = New System.Windows.Forms.Button()
        Me.btnSalirUSYS = New System.Windows.Forms.Button()
        Me.lblAppCod = New System.Windows.Forms.Label()
        Me.txtAppCod = New System.Windows.Forms.TextBox()
        Me.txtAppDes_C = New System.Windows.Forms.TextBox()
        Me.lblAppDes_C = New System.Windows.Forms.Label()
        Me.txtAppDes_E = New System.Windows.Forms.TextBox()
        Me.lblAppDes_E = New System.Windows.Forms.Label()
        Me.txtAppDes_I = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtAppDes_F = New System.Windows.Forms.TextBox()
        Me.lblAppDes_F = New System.Windows.Forms.Label()
        Me.lblAppStop = New System.Windows.Forms.Label()
        Me.chkAppStop = New System.Windows.Forms.CheckBox()
        Me.lblAreaCod = New System.Windows.Forms.Label()
        Me.comboAreaCod = New System.Windows.Forms.ComboBox()
        Me.lblAppRevision = New System.Windows.Forms.Label()
        Me.txtAppRevision = New System.Windows.Forms.TextBox()
        Me.lblPlataCod = New System.Windows.Forms.Label()
        Me.comboPlataCod = New System.Windows.Forms.ComboBox()
        Me.txtApliFCompila = New System.Windows.Forms.TextBox()
        Me.lblApliFCompila = New System.Windows.Forms.Label()
        Me.txtApliFAlta = New System.Windows.Forms.TextBox()
        Me.lblApliFAlta = New System.Windows.Forms.Label()
        Me.txtApliFBaja = New System.Windows.Forms.TextBox()
        Me.lblApliFBaja = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblADMOrigenApp = New System.Windows.Forms.Label()
        Me.txtAdmOrigen = New System.Windows.Forms.TextBox()
        Me.lblADMOrigen = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.chkApliGeneral = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'btnValidarUSYS
        '
        Me.btnValidarUSYS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnValidarUSYS.Location = New System.Drawing.Point(22, 13)
        Me.btnValidarUSYS.Name = "btnValidarUSYS"
        Me.btnValidarUSYS.Size = New System.Drawing.Size(75, 23)
        Me.btnValidarUSYS.TabIndex = 0
        Me.btnValidarUSYS.Text = "VALIDAR"
        Me.btnValidarUSYS.UseVisualStyleBackColor = True
        '
        'btnSalirUSYS
        '
        Me.btnSalirUSYS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalirUSYS.Location = New System.Drawing.Point(713, 629)
        Me.btnSalirUSYS.Name = "btnSalirUSYS"
        Me.btnSalirUSYS.Size = New System.Drawing.Size(75, 23)
        Me.btnSalirUSYS.TabIndex = 1
        Me.btnSalirUSYS.Text = "Salir"
        Me.btnSalirUSYS.UseVisualStyleBackColor = True
        '
        'lblAppCod
        '
        Me.lblAppCod.AutoSize = True
        Me.lblAppCod.Location = New System.Drawing.Point(42, 59)
        Me.lblAppCod.Name = "lblAppCod"
        Me.lblAppCod.Size = New System.Drawing.Size(51, 13)
        Me.lblAppCod.TabIndex = 2
        Me.lblAppCod.Text = "APPCOD"
        '
        'txtAppCod
        '
        Me.txtAppCod.Location = New System.Drawing.Point(146, 52)
        Me.txtAppCod.MaxLength = 7
        Me.txtAppCod.Name = "txtAppCod"
        Me.txtAppCod.Size = New System.Drawing.Size(73, 20)
        Me.txtAppCod.TabIndex = 3
        '
        'txtAppDes_C
        '
        Me.txtAppDes_C.Location = New System.Drawing.Point(144, 84)
        Me.txtAppDes_C.MaxLength = 150
        Me.txtAppDes_C.Name = "txtAppDes_C"
        Me.txtAppDes_C.Size = New System.Drawing.Size(351, 20)
        Me.txtAppDes_C.TabIndex = 5
        '
        'lblAppDes_C
        '
        Me.lblAppDes_C.AutoSize = True
        Me.lblAppDes_C.Location = New System.Drawing.Point(42, 91)
        Me.lblAppDes_C.Name = "lblAppDes_C"
        Me.lblAppDes_C.Size = New System.Drawing.Size(63, 13)
        Me.lblAppDes_C.TabIndex = 4
        Me.lblAppDes_C.Text = "APPDES_C"
        '
        'txtAppDes_E
        '
        Me.txtAppDes_E.Location = New System.Drawing.Point(144, 119)
        Me.txtAppDes_E.MaxLength = 150
        Me.txtAppDes_E.Name = "txtAppDes_E"
        Me.txtAppDes_E.Size = New System.Drawing.Size(351, 20)
        Me.txtAppDes_E.TabIndex = 7
        '
        'lblAppDes_E
        '
        Me.lblAppDes_E.AutoSize = True
        Me.lblAppDes_E.Location = New System.Drawing.Point(42, 126)
        Me.lblAppDes_E.Name = "lblAppDes_E"
        Me.lblAppDes_E.Size = New System.Drawing.Size(63, 13)
        Me.lblAppDes_E.TabIndex = 6
        Me.lblAppDes_E.Text = "APPDES_E"
        '
        'txtAppDes_I
        '
        Me.txtAppDes_I.Location = New System.Drawing.Point(144, 164)
        Me.txtAppDes_I.MaxLength = 100
        Me.txtAppDes_I.Name = "txtAppDes_I"
        Me.txtAppDes_I.Size = New System.Drawing.Size(351, 20)
        Me.txtAppDes_I.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(42, 167)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "APPDES_I"
        '
        'txtAppDes_F
        '
        Me.txtAppDes_F.Location = New System.Drawing.Point(144, 202)
        Me.txtAppDes_F.MaxLength = 7
        Me.txtAppDes_F.Name = "txtAppDes_F"
        Me.txtAppDes_F.Size = New System.Drawing.Size(351, 20)
        Me.txtAppDes_F.TabIndex = 11
        '
        'lblAppDes_F
        '
        Me.lblAppDes_F.AutoSize = True
        Me.lblAppDes_F.Location = New System.Drawing.Point(42, 209)
        Me.lblAppDes_F.Name = "lblAppDes_F"
        Me.lblAppDes_F.Size = New System.Drawing.Size(62, 13)
        Me.lblAppDes_F.TabIndex = 10
        Me.lblAppDes_F.Text = "APPDES_F"
        '
        'lblAppStop
        '
        Me.lblAppStop.AutoSize = True
        Me.lblAppStop.Location = New System.Drawing.Point(42, 255)
        Me.lblAppStop.Name = "lblAppStop"
        Me.lblAppStop.Size = New System.Drawing.Size(57, 13)
        Me.lblAppStop.TabIndex = 12
        Me.lblAppStop.Text = "APPSTOP"
        '
        'chkAppStop
        '
        Me.chkAppStop.AutoSize = True
        Me.chkAppStop.Location = New System.Drawing.Point(144, 254)
        Me.chkAppStop.Name = "chkAppStop"
        Me.chkAppStop.Size = New System.Drawing.Size(15, 14)
        Me.chkAppStop.TabIndex = 13
        Me.chkAppStop.UseVisualStyleBackColor = True
        '
        'lblAreaCod
        '
        Me.lblAreaCod.AutoSize = True
        Me.lblAreaCod.Location = New System.Drawing.Point(42, 295)
        Me.lblAreaCod.Name = "lblAreaCod"
        Me.lblAreaCod.Size = New System.Drawing.Size(59, 13)
        Me.lblAreaCod.TabIndex = 14
        Me.lblAreaCod.Text = "AREACOD"
        '
        'comboAreaCod
        '
        Me.comboAreaCod.FormattingEnabled = True
        Me.comboAreaCod.Location = New System.Drawing.Point(144, 287)
        Me.comboAreaCod.Name = "comboAreaCod"
        Me.comboAreaCod.Size = New System.Drawing.Size(121, 21)
        Me.comboAreaCod.TabIndex = 15
        '
        'lblAppRevision
        '
        Me.lblAppRevision.AutoSize = True
        Me.lblAppRevision.Location = New System.Drawing.Point(45, 336)
        Me.lblAppRevision.Name = "lblAppRevision"
        Me.lblAppRevision.Size = New System.Drawing.Size(79, 13)
        Me.lblAppRevision.TabIndex = 16
        Me.lblAppRevision.Text = "APPREVISION"
        '
        'txtAppRevision
        '
        Me.txtAppRevision.Location = New System.Drawing.Point(144, 329)
        Me.txtAppRevision.MaxLength = 4
        Me.txtAppRevision.Name = "txtAppRevision"
        Me.txtAppRevision.ShortcutsEnabled = False
        Me.txtAppRevision.Size = New System.Drawing.Size(73, 20)
        Me.txtAppRevision.TabIndex = 17
        '
        'lblPlataCod
        '
        Me.lblPlataCod.AutoSize = True
        Me.lblPlataCod.Location = New System.Drawing.Point(45, 374)
        Me.lblPlataCod.Name = "lblPlataCod"
        Me.lblPlataCod.Size = New System.Drawing.Size(64, 13)
        Me.lblPlataCod.TabIndex = 18
        Me.lblPlataCod.Text = "PLATACOD"
        '
        'comboPlataCod
        '
        Me.comboPlataCod.FormattingEnabled = True
        Me.comboPlataCod.Location = New System.Drawing.Point(144, 366)
        Me.comboPlataCod.Name = "comboPlataCod"
        Me.comboPlataCod.Size = New System.Drawing.Size(121, 21)
        Me.comboPlataCod.TabIndex = 19
        '
        'txtApliFCompila
        '
        Me.txtApliFCompila.Location = New System.Drawing.Point(144, 410)
        Me.txtApliFCompila.MaxLength = 150
        Me.txtApliFCompila.Name = "txtApliFCompila"
        Me.txtApliFCompila.Size = New System.Drawing.Size(121, 20)
        Me.txtApliFCompila.TabIndex = 21
        '
        'lblApliFCompila
        '
        Me.lblApliFCompila.AutoSize = True
        Me.lblApliFCompila.Location = New System.Drawing.Point(45, 417)
        Me.lblApliFCompila.Name = "lblApliFCompila"
        Me.lblApliFCompila.Size = New System.Drawing.Size(83, 13)
        Me.lblApliFCompila.TabIndex = 20
        Me.lblApliFCompila.Text = "APLIFCOMPILA"
        '
        'txtApliFAlta
        '
        Me.txtApliFAlta.Location = New System.Drawing.Point(144, 449)
        Me.txtApliFAlta.MaxLength = 150
        Me.txtApliFAlta.Name = "txtApliFAlta"
        Me.txtApliFAlta.Size = New System.Drawing.Size(121, 20)
        Me.txtApliFAlta.TabIndex = 23
        '
        'lblApliFAlta
        '
        Me.lblApliFAlta.AutoSize = True
        Me.lblApliFAlta.Location = New System.Drawing.Point(46, 456)
        Me.lblApliFAlta.Name = "lblApliFAlta"
        Me.lblApliFAlta.Size = New System.Drawing.Size(63, 13)
        Me.lblApliFAlta.TabIndex = 22
        Me.lblApliFAlta.Text = "APLIFALTA"
        '
        'txtApliFBaja
        '
        Me.txtApliFBaja.Location = New System.Drawing.Point(144, 485)
        Me.txtApliFBaja.MaxLength = 150
        Me.txtApliFBaja.Name = "txtApliFBaja"
        Me.txtApliFBaja.Size = New System.Drawing.Size(121, 20)
        Me.txtApliFBaja.TabIndex = 25
        '
        'lblApliFBaja
        '
        Me.lblApliFBaja.AutoSize = True
        Me.lblApliFBaja.Location = New System.Drawing.Point(47, 492)
        Me.lblApliFBaja.Name = "lblApliFBaja"
        Me.lblApliFBaja.Size = New System.Drawing.Size(62, 13)
        Me.lblApliFBaja.TabIndex = 24
        Me.lblApliFBaja.Text = "APLIFBAJA"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(146, 596)
        Me.TextBox1.MaxLength = 7
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(91, 20)
        Me.TextBox1.TabIndex = 27
        '
        'lblADMOrigenApp
        '
        Me.lblADMOrigenApp.AutoSize = True
        Me.lblADMOrigenApp.Location = New System.Drawing.Point(46, 603)
        Me.lblADMOrigenApp.Name = "lblADMOrigenApp"
        Me.lblADMOrigenApp.Size = New System.Drawing.Size(94, 13)
        Me.lblADMOrigenApp.TabIndex = 26
        Me.lblADMOrigenApp.Text = "ADMORIGENAPP"
        '
        'txtAdmOrigen
        '
        Me.txtAdmOrigen.Location = New System.Drawing.Point(144, 557)
        Me.txtAdmOrigen.MaxLength = 1
        Me.txtAdmOrigen.Name = "txtAdmOrigen"
        Me.txtAdmOrigen.Size = New System.Drawing.Size(52, 20)
        Me.txtAdmOrigen.TabIndex = 29
        '
        'lblADMOrigen
        '
        Me.lblADMOrigen.AutoSize = True
        Me.lblADMOrigen.Location = New System.Drawing.Point(47, 564)
        Me.lblADMOrigen.Name = "lblADMOrigen"
        Me.lblADMOrigen.Size = New System.Drawing.Size(73, 13)
        Me.lblADMOrigen.TabIndex = 28
        Me.lblADMOrigen.Text = "ADMORIGEN"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(47, 525)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 13)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "APLIGENERAL"
        '
        'chkApliGeneral
        '
        Me.chkApliGeneral.AutoSize = True
        Me.chkApliGeneral.Location = New System.Drawing.Point(144, 525)
        Me.chkApliGeneral.Name = "chkApliGeneral"
        Me.chkApliGeneral.Size = New System.Drawing.Size(15, 14)
        Me.chkApliGeneral.TabIndex = 31
        Me.chkApliGeneral.UseVisualStyleBackColor = True
        '
        'frmAppUsys
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 698)
        Me.Controls.Add(Me.chkApliGeneral)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtAdmOrigen)
        Me.Controls.Add(Me.lblADMOrigen)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lblADMOrigenApp)
        Me.Controls.Add(Me.txtApliFBaja)
        Me.Controls.Add(Me.lblApliFBaja)
        Me.Controls.Add(Me.txtApliFAlta)
        Me.Controls.Add(Me.lblApliFAlta)
        Me.Controls.Add(Me.txtApliFCompila)
        Me.Controls.Add(Me.lblApliFCompila)
        Me.Controls.Add(Me.comboPlataCod)
        Me.Controls.Add(Me.lblPlataCod)
        Me.Controls.Add(Me.txtAppRevision)
        Me.Controls.Add(Me.lblAppRevision)
        Me.Controls.Add(Me.comboAreaCod)
        Me.Controls.Add(Me.lblAreaCod)
        Me.Controls.Add(Me.chkAppStop)
        Me.Controls.Add(Me.lblAppStop)
        Me.Controls.Add(Me.txtAppDes_F)
        Me.Controls.Add(Me.lblAppDes_F)
        Me.Controls.Add(Me.txtAppDes_I)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtAppDes_E)
        Me.Controls.Add(Me.lblAppDes_E)
        Me.Controls.Add(Me.txtAppDes_C)
        Me.Controls.Add(Me.lblAppDes_C)
        Me.Controls.Add(Me.txtAppCod)
        Me.Controls.Add(Me.lblAppCod)
        Me.Controls.Add(Me.btnSalirUSYS)
        Me.Controls.Add(Me.btnValidarUSYS)
        Me.Name = "frmAppUsys"
        Me.Text = "APP ORIGEN USYS = 3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnValidarUSYS As Button
    Friend WithEvents btnSalirUSYS As Button
    Friend WithEvents lblAppCod As Label
    Friend WithEvents txtAppCod As TextBox
    Friend WithEvents txtAppDes_C As TextBox
    Friend WithEvents lblAppDes_C As Label
    Friend WithEvents txtAppDes_E As TextBox
    Friend WithEvents lblAppDes_E As Label
    Friend WithEvents txtAppDes_I As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtAppDes_F As TextBox
    Friend WithEvents lblAppDes_F As Label
    Friend WithEvents lblAppStop As Label
    Friend WithEvents chkAppStop As CheckBox
    Friend WithEvents lblAreaCod As Label
    Friend WithEvents comboAreaCod As ComboBox
    Friend WithEvents lblAppRevision As Label
    Friend WithEvents txtAppRevision As TextBox
    Friend WithEvents lblPlataCod As Label
    Friend WithEvents comboPlataCod As ComboBox
    Friend WithEvents txtApliFCompila As TextBox
    Friend WithEvents lblApliFCompila As Label
    Friend WithEvents txtApliFAlta As TextBox
    Friend WithEvents lblApliFAlta As Label
    Friend WithEvents txtApliFBaja As TextBox
    Friend WithEvents lblApliFBaja As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lblADMOrigenApp As Label
    Friend WithEvents txtAdmOrigen As TextBox
    Friend WithEvents lblADMOrigen As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents chkApliGeneral As CheckBox
End Class
