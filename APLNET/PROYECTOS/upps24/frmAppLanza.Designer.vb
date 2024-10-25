<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAppLanza
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
        Me.btnValidarLanza = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblAplID = New System.Windows.Forms.Label()
        Me.txtAplID = New System.Windows.Forms.TextBox()
        Me.txtApliCod = New System.Windows.Forms.TextBox()
        Me.lblApliCod = New System.Windows.Forms.Label()
        Me.lblPlataCod = New System.Windows.Forms.Label()
        Me.ComboPlataCod = New System.Windows.Forms.ComboBox()
        Me.lblUbiCod = New System.Windows.Forms.Label()
        Me.ComboUbiCod = New System.Windows.Forms.ComboBox()
        Me.lblApliNombre_C = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.txtApliNombre_E = New System.Windows.Forms.TextBox()
        Me.lblApliNombre_E = New System.Windows.Forms.Label()
        Me.txtApliFalta = New System.Windows.Forms.TextBox()
        Me.lblApliFalta = New System.Windows.Forms.Label()
        Me.txtApliFCompila = New System.Windows.Forms.TextBox()
        Me.lblApliFCompila = New System.Windows.Forms.Label()
        Me.txtApliDesc = New System.Windows.Forms.TextBox()
        Me.lblApliDesc = New System.Windows.Forms.Label()
        Me.txtApliRunTMP = New System.Windows.Forms.TextBox()
        Me.lblApliRun = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.lblApliRunTmp = New System.Windows.Forms.Label()
        Me.txtApliRun = New System.Windows.Forms.TextBox()
        Me.lblApliGeneral = New System.Windows.Forms.Label()
        Me.txtApliBaja = New System.Windows.Forms.TextBox()
        Me.lblApliBaja = New System.Windows.Forms.Label()
        Me.chkApliGeneral = New System.Windows.Forms.CheckBox()
        Me.lblApliDat = New System.Windows.Forms.Label()
        Me.lblApliTmp = New System.Windows.Forms.Label()
        Me.txtApliTmp = New System.Windows.Forms.TextBox()
        Me.lblApliPro = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtApliUrl = New System.Windows.Forms.TextBox()
        Me.lblApliVersion = New System.Windows.Forms.Label()
        Me.txtApliVersion = New System.Windows.Forms.TextBox()
        Me.lblApliDat_per_no = New System.Windows.Forms.Label()
        Me.txtApliDatPerNo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtADMOrigenApp = New System.Windows.Forms.TextBox()
        Me.lblAreaCod = New System.Windows.Forms.Label()
        Me.txtAreaCod = New System.Windows.Forms.TextBox()
        Me.lblADMOrigen = New System.Windows.Forms.Label()
        Me.txtAplidatPerSi = New System.Windows.Forms.TextBox()
        Me.lblApliIdentifica = New System.Windows.Forms.Label()
        Me.txtADMOrigen = New System.Windows.Forms.TextBox()
        Me.lblAplidat_per_si = New System.Windows.Forms.Label()
        Me.chkApliIdentifica = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'btnValidarLanza
        '
        Me.btnValidarLanza.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnValidarLanza.Location = New System.Drawing.Point(28, 21)
        Me.btnValidarLanza.Name = "btnValidarLanza"
        Me.btnValidarLanza.Size = New System.Drawing.Size(75, 23)
        Me.btnValidarLanza.TabIndex = 0
        Me.btnValidarLanza.Text = "VALIDAR"
        Me.btnValidarLanza.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(552, 902)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 1
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(108, -22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Label1"
        '
        'lblAplID
        '
        Me.lblAplID.AutoSize = True
        Me.lblAplID.Location = New System.Drawing.Point(53, 81)
        Me.lblAplID.Name = "lblAplID"
        Me.lblAplID.Size = New System.Drawing.Size(45, 13)
        Me.lblAplID.TabIndex = 3
        Me.lblAplID.Text = "APLID *"
        '
        'txtAplID
        '
        Me.txtAplID.Location = New System.Drawing.Point(165, 78)
        Me.txtAplID.MaxLength = 4
        Me.txtAplID.Name = "txtAplID"
        Me.txtAplID.Size = New System.Drawing.Size(53, 20)
        Me.txtAplID.TabIndex = 4
        '
        'txtApliCod
        '
        Me.txtApliCod.Location = New System.Drawing.Point(165, 113)
        Me.txtApliCod.MaxLength = 25
        Me.txtApliCod.Name = "txtApliCod"
        Me.txtApliCod.Size = New System.Drawing.Size(92, 20)
        Me.txtApliCod.TabIndex = 6
        '
        'lblApliCod
        '
        Me.lblApliCod.AutoSize = True
        Me.lblApliCod.Location = New System.Drawing.Point(53, 120)
        Me.lblApliCod.Name = "lblApliCod"
        Me.lblApliCod.Size = New System.Drawing.Size(60, 13)
        Me.lblApliCod.TabIndex = 5
        Me.lblApliCod.Text = "APLICOD *"
        '
        'lblPlataCod
        '
        Me.lblPlataCod.AutoSize = True
        Me.lblPlataCod.Location = New System.Drawing.Point(53, 153)
        Me.lblPlataCod.Name = "lblPlataCod"
        Me.lblPlataCod.Size = New System.Drawing.Size(71, 13)
        Me.lblPlataCod.TabIndex = 8
        Me.lblPlataCod.Text = "PLATACOD *"
        '
        'ComboPlataCod
        '
        Me.ComboPlataCod.FormattingEnabled = True
        Me.ComboPlataCod.Location = New System.Drawing.Point(165, 145)
        Me.ComboPlataCod.Name = "ComboPlataCod"
        Me.ComboPlataCod.Size = New System.Drawing.Size(121, 21)
        Me.ComboPlataCod.TabIndex = 9
        '
        'lblUbiCod
        '
        Me.lblUbiCod.AllowDrop = True
        Me.lblUbiCod.AutoSize = True
        Me.lblUbiCod.Location = New System.Drawing.Point(53, 187)
        Me.lblUbiCod.Name = "lblUbiCod"
        Me.lblUbiCod.Size = New System.Drawing.Size(55, 13)
        Me.lblUbiCod.TabIndex = 10
        Me.lblUbiCod.Text = "UBICOD *"
        '
        'ComboUbiCod
        '
        Me.ComboUbiCod.FormattingEnabled = True
        Me.ComboUbiCod.Location = New System.Drawing.Point(165, 179)
        Me.ComboUbiCod.Name = "ComboUbiCod"
        Me.ComboUbiCod.Size = New System.Drawing.Size(121, 21)
        Me.ComboUbiCod.TabIndex = 11
        '
        'lblApliNombre_C
        '
        Me.lblApliNombre_C.AutoSize = True
        Me.lblApliNombre_C.Location = New System.Drawing.Point(53, 224)
        Me.lblApliNombre_C.Name = "lblApliNombre_C"
        Me.lblApliNombre_C.Size = New System.Drawing.Size(90, 13)
        Me.lblApliNombre_C.TabIndex = 12
        Me.lblApliNombre_C.Text = "APLINOMBRE_C"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(165, 217)
        Me.TextBox1.MaxLength = 150
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(313, 20)
        Me.TextBox1.TabIndex = 13
        '
        'txtApliNombre_E
        '
        Me.txtApliNombre_E.Location = New System.Drawing.Point(165, 258)
        Me.txtApliNombre_E.MaxLength = 150
        Me.txtApliNombre_E.Name = "txtApliNombre_E"
        Me.txtApliNombre_E.Size = New System.Drawing.Size(313, 20)
        Me.txtApliNombre_E.TabIndex = 15
        '
        'lblApliNombre_E
        '
        Me.lblApliNombre_E.AutoSize = True
        Me.lblApliNombre_E.Location = New System.Drawing.Point(53, 265)
        Me.lblApliNombre_E.Name = "lblApliNombre_E"
        Me.lblApliNombre_E.Size = New System.Drawing.Size(90, 13)
        Me.lblApliNombre_E.TabIndex = 14
        Me.lblApliNombre_E.Text = "APLINOMBRE_E"
        '
        'txtApliFalta
        '
        Me.txtApliFalta.Location = New System.Drawing.Point(165, 364)
        Me.txtApliFalta.MaxLength = 150
        Me.txtApliFalta.Name = "txtApliFalta"
        Me.txtApliFalta.Size = New System.Drawing.Size(121, 20)
        Me.txtApliFalta.TabIndex = 17
        '
        'lblApliFalta
        '
        Me.lblApliFalta.AutoSize = True
        Me.lblApliFalta.Location = New System.Drawing.Point(53, 371)
        Me.lblApliFalta.Name = "lblApliFalta"
        Me.lblApliFalta.Size = New System.Drawing.Size(63, 13)
        Me.lblApliFalta.TabIndex = 16
        Me.lblApliFalta.Text = "APLIFALTA"
        '
        'txtApliFCompila
        '
        Me.txtApliFCompila.Location = New System.Drawing.Point(165, 332)
        Me.txtApliFCompila.MaxLength = 150
        Me.txtApliFCompila.Name = "txtApliFCompila"
        Me.txtApliFCompila.Size = New System.Drawing.Size(121, 20)
        Me.txtApliFCompila.TabIndex = 19
        '
        'lblApliFCompila
        '
        Me.lblApliFCompila.AutoSize = True
        Me.lblApliFCompila.Location = New System.Drawing.Point(53, 339)
        Me.lblApliFCompila.Name = "lblApliFCompila"
        Me.lblApliFCompila.Size = New System.Drawing.Size(83, 13)
        Me.lblApliFCompila.TabIndex = 18
        Me.lblApliFCompila.Text = "APLIFCOMPILA"
        '
        'txtApliDesc
        '
        Me.txtApliDesc.Location = New System.Drawing.Point(165, 297)
        Me.txtApliDesc.MaxLength = 255
        Me.txtApliDesc.Name = "txtApliDesc"
        Me.txtApliDesc.Size = New System.Drawing.Size(313, 20)
        Me.txtApliDesc.TabIndex = 21
        '
        'lblApliDesc
        '
        Me.lblApliDesc.AutoSize = True
        Me.lblApliDesc.Location = New System.Drawing.Point(53, 304)
        Me.lblApliDesc.Name = "lblApliDesc"
        Me.lblApliDesc.Size = New System.Drawing.Size(59, 13)
        Me.lblApliDesc.TabIndex = 20
        Me.lblApliDesc.Text = "APLIDESC"
        '
        'txtApliRunTMP
        '
        Me.txtApliRunTMP.Location = New System.Drawing.Point(165, 506)
        Me.txtApliRunTMP.MaxLength = 255
        Me.txtApliRunTMP.Name = "txtApliRunTMP"
        Me.txtApliRunTMP.Size = New System.Drawing.Size(313, 20)
        Me.txtApliRunTMP.TabIndex = 23
        '
        'lblApliRun
        '
        Me.lblApliRun.AutoSize = True
        Me.lblApliRun.Location = New System.Drawing.Point(53, 473)
        Me.lblApliRun.Name = "lblApliRun"
        Me.lblApliRun.Size = New System.Drawing.Size(54, 13)
        Me.lblApliRun.TabIndex = 22
        Me.lblApliRun.Text = "APLIRUN"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(165, 540)
        Me.TextBox3.MaxLength = 150
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(313, 20)
        Me.TextBox3.TabIndex = 25
        '
        'lblApliRunTmp
        '
        Me.lblApliRunTmp.AutoSize = True
        Me.lblApliRunTmp.Location = New System.Drawing.Point(53, 513)
        Me.lblApliRunTmp.Name = "lblApliRunTmp"
        Me.lblApliRunTmp.Size = New System.Drawing.Size(77, 13)
        Me.lblApliRunTmp.TabIndex = 24
        Me.lblApliRunTmp.Text = "APLIRUNTMP"
        '
        'txtApliRun
        '
        Me.txtApliRun.Location = New System.Drawing.Point(165, 466)
        Me.txtApliRun.MaxLength = 255
        Me.txtApliRun.Name = "txtApliRun"
        Me.txtApliRun.Size = New System.Drawing.Size(313, 20)
        Me.txtApliRun.TabIndex = 27
        '
        'lblApliGeneral
        '
        Me.lblApliGeneral.AutoSize = True
        Me.lblApliGeneral.Location = New System.Drawing.Point(53, 437)
        Me.lblApliGeneral.Name = "lblApliGeneral"
        Me.lblApliGeneral.Size = New System.Drawing.Size(81, 13)
        Me.lblApliGeneral.TabIndex = 26
        Me.lblApliGeneral.Text = "APLIGENERAL"
        '
        'txtApliBaja
        '
        Me.txtApliBaja.Location = New System.Drawing.Point(165, 396)
        Me.txtApliBaja.MaxLength = 150
        Me.txtApliBaja.Name = "txtApliBaja"
        Me.txtApliBaja.Size = New System.Drawing.Size(121, 20)
        Me.txtApliBaja.TabIndex = 29
        '
        'lblApliBaja
        '
        Me.lblApliBaja.AutoSize = True
        Me.lblApliBaja.Location = New System.Drawing.Point(53, 403)
        Me.lblApliBaja.Name = "lblApliBaja"
        Me.lblApliBaja.Size = New System.Drawing.Size(56, 13)
        Me.lblApliBaja.TabIndex = 28
        Me.lblApliBaja.Text = "APLIBAJA"
        '
        'chkApliGeneral
        '
        Me.chkApliGeneral.AutoSize = True
        Me.chkApliGeneral.Location = New System.Drawing.Point(165, 436)
        Me.chkApliGeneral.Name = "chkApliGeneral"
        Me.chkApliGeneral.Size = New System.Drawing.Size(15, 14)
        Me.chkApliGeneral.TabIndex = 30
        Me.chkApliGeneral.UseVisualStyleBackColor = True
        '
        'lblApliDat
        '
        Me.lblApliDat.AutoSize = True
        Me.lblApliDat.Location = New System.Drawing.Point(53, 547)
        Me.lblApliDat.Name = "lblApliDat"
        Me.lblApliDat.Size = New System.Drawing.Size(52, 13)
        Me.lblApliDat.TabIndex = 31
        Me.lblApliDat.Text = "APLIDAT"
        '
        'lblApliTmp
        '
        Me.lblApliTmp.AutoSize = True
        Me.lblApliTmp.Location = New System.Drawing.Point(53, 621)
        Me.lblApliTmp.Name = "lblApliTmp"
        Me.lblApliTmp.Size = New System.Drawing.Size(53, 13)
        Me.lblApliTmp.TabIndex = 33
        Me.lblApliTmp.Text = "APLITMP"
        '
        'txtApliTmp
        '
        Me.txtApliTmp.Location = New System.Drawing.Point(165, 614)
        Me.txtApliTmp.MaxLength = 255
        Me.txtApliTmp.Name = "txtApliTmp"
        Me.txtApliTmp.Size = New System.Drawing.Size(313, 20)
        Me.txtApliTmp.TabIndex = 32
        '
        'lblApliPro
        '
        Me.lblApliPro.AutoSize = True
        Me.lblApliPro.Location = New System.Drawing.Point(55, 583)
        Me.lblApliPro.Name = "lblApliPro"
        Me.lblApliPro.Size = New System.Drawing.Size(53, 13)
        Me.lblApliPro.TabIndex = 35
        Me.lblApliPro.Text = "APLIPRO"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(165, 576)
        Me.TextBox4.MaxLength = 150
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(313, 20)
        Me.TextBox4.TabIndex = 34
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(53, 656)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "APLIURL"
        '
        'txtApliUrl
        '
        Me.txtApliUrl.Location = New System.Drawing.Point(165, 649)
        Me.txtApliUrl.MaxLength = 150
        Me.txtApliUrl.Name = "txtApliUrl"
        Me.txtApliUrl.Size = New System.Drawing.Size(313, 20)
        Me.txtApliUrl.TabIndex = 36
        '
        'lblApliVersion
        '
        Me.lblApliVersion.AutoSize = True
        Me.lblApliVersion.Location = New System.Drawing.Point(53, 700)
        Me.lblApliVersion.Name = "lblApliVersion"
        Me.lblApliVersion.Size = New System.Drawing.Size(78, 13)
        Me.lblApliVersion.TabIndex = 39
        Me.lblApliVersion.Text = "APLIVERSION"
        '
        'txtApliVersion
        '
        Me.txtApliVersion.Location = New System.Drawing.Point(165, 693)
        Me.txtApliVersion.MaxLength = 4
        Me.txtApliVersion.Name = "txtApliVersion"
        Me.txtApliVersion.Size = New System.Drawing.Size(53, 20)
        Me.txtApliVersion.TabIndex = 38
        '
        'lblApliDat_per_no
        '
        Me.lblApliDat_per_no.AutoSize = True
        Me.lblApliDat_per_no.Location = New System.Drawing.Point(53, 858)
        Me.lblApliDat_per_no.Name = "lblApliDat_per_no"
        Me.lblApliDat_per_no.Size = New System.Drawing.Size(102, 13)
        Me.lblApliDat_per_no.TabIndex = 41
        Me.lblApliDat_per_no.Text = "APLIDAT_PER_NO"
        '
        'txtApliDatPerNo
        '
        Me.txtApliDatPerNo.Location = New System.Drawing.Point(165, 851)
        Me.txtApliDatPerNo.MaxLength = 255
        Me.txtApliDatPerNo.Name = "txtApliDatPerNo"
        Me.txtApliDatPerNo.Size = New System.Drawing.Size(313, 20)
        Me.txtApliDatPerNo.TabIndex = 40
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(53, 934)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 13)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "ADMORIGENAPP"
        '
        'txtADMOrigenApp
        '
        Me.txtADMOrigenApp.Location = New System.Drawing.Point(165, 927)
        Me.txtADMOrigenApp.MaxLength = 7
        Me.txtADMOrigenApp.Name = "txtADMOrigenApp"
        Me.txtADMOrigenApp.Size = New System.Drawing.Size(53, 20)
        Me.txtADMOrigenApp.TabIndex = 42
        '
        'lblAreaCod
        '
        Me.lblAreaCod.AutoSize = True
        Me.lblAreaCod.Location = New System.Drawing.Point(53, 742)
        Me.lblAreaCod.Name = "lblAreaCod"
        Me.lblAreaCod.Size = New System.Drawing.Size(66, 13)
        Me.lblAreaCod.TabIndex = 45
        Me.lblAreaCod.Text = "AREACOD *"
        '
        'txtAreaCod
        '
        Me.txtAreaCod.Location = New System.Drawing.Point(165, 735)
        Me.txtAreaCod.MaxLength = 3
        Me.txtAreaCod.Name = "txtAreaCod"
        Me.txtAreaCod.Size = New System.Drawing.Size(53, 20)
        Me.txtAreaCod.TabIndex = 44
        '
        'lblADMOrigen
        '
        Me.lblADMOrigen.AutoSize = True
        Me.lblADMOrigen.Location = New System.Drawing.Point(53, 890)
        Me.lblADMOrigen.Name = "lblADMOrigen"
        Me.lblADMOrigen.Size = New System.Drawing.Size(73, 13)
        Me.lblADMOrigen.TabIndex = 47
        Me.lblADMOrigen.Text = "ADMORIGEN"
        '
        'txtAplidatPerSi
        '
        Me.txtAplidatPerSi.Location = New System.Drawing.Point(165, 802)
        Me.txtAplidatPerSi.MaxLength = 150
        Me.txtAplidatPerSi.Name = "txtAplidatPerSi"
        Me.txtAplidatPerSi.Size = New System.Drawing.Size(313, 20)
        Me.txtAplidatPerSi.TabIndex = 46
        '
        'lblApliIdentifica
        '
        Me.lblApliIdentifica.AutoSize = True
        Me.lblApliIdentifica.Location = New System.Drawing.Point(53, 775)
        Me.lblApliIdentifica.Name = "lblApliIdentifica"
        Me.lblApliIdentifica.Size = New System.Drawing.Size(86, 13)
        Me.lblApliIdentifica.TabIndex = 49
        Me.lblApliIdentifica.Text = "APLIDENTIFICA"
        '
        'txtADMOrigen
        '
        Me.txtADMOrigen.Location = New System.Drawing.Point(165, 887)
        Me.txtADMOrigen.MaxLength = 1
        Me.txtADMOrigen.Name = "txtADMOrigen"
        Me.txtADMOrigen.Size = New System.Drawing.Size(31, 20)
        Me.txtADMOrigen.TabIndex = 48
        '
        'lblAplidat_per_si
        '
        Me.lblAplidat_per_si.AutoSize = True
        Me.lblAplidat_per_si.Location = New System.Drawing.Point(53, 809)
        Me.lblAplidat_per_si.Name = "lblAplidat_per_si"
        Me.lblAplidat_per_si.Size = New System.Drawing.Size(96, 13)
        Me.lblAplidat_per_si.TabIndex = 51
        Me.lblAplidat_per_si.Text = "APLIDAT_PER_SI"
        '
        'chkApliIdentifica
        '
        Me.chkApliIdentifica.AutoSize = True
        Me.chkApliIdentifica.Location = New System.Drawing.Point(165, 775)
        Me.chkApliIdentifica.Name = "chkApliIdentifica"
        Me.chkApliIdentifica.Size = New System.Drawing.Size(15, 14)
        Me.chkApliIdentifica.TabIndex = 52
        Me.chkApliIdentifica.UseVisualStyleBackColor = True
        '
        'frmAppLanza
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(695, 881)
        Me.Controls.Add(Me.chkApliIdentifica)
        Me.Controls.Add(Me.lblAplidat_per_si)
        Me.Controls.Add(Me.lblApliIdentifica)
        Me.Controls.Add(Me.txtADMOrigen)
        Me.Controls.Add(Me.lblADMOrigen)
        Me.Controls.Add(Me.txtAplidatPerSi)
        Me.Controls.Add(Me.lblAreaCod)
        Me.Controls.Add(Me.txtAreaCod)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtADMOrigenApp)
        Me.Controls.Add(Me.lblApliDat_per_no)
        Me.Controls.Add(Me.txtApliDatPerNo)
        Me.Controls.Add(Me.lblApliVersion)
        Me.Controls.Add(Me.txtApliVersion)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtApliUrl)
        Me.Controls.Add(Me.lblApliPro)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.lblApliTmp)
        Me.Controls.Add(Me.txtApliTmp)
        Me.Controls.Add(Me.lblApliDat)
        Me.Controls.Add(Me.chkApliGeneral)
        Me.Controls.Add(Me.txtApliBaja)
        Me.Controls.Add(Me.lblApliBaja)
        Me.Controls.Add(Me.txtApliRun)
        Me.Controls.Add(Me.lblApliGeneral)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.lblApliRunTmp)
        Me.Controls.Add(Me.txtApliRunTMP)
        Me.Controls.Add(Me.lblApliRun)
        Me.Controls.Add(Me.txtApliDesc)
        Me.Controls.Add(Me.lblApliDesc)
        Me.Controls.Add(Me.txtApliFCompila)
        Me.Controls.Add(Me.lblApliFCompila)
        Me.Controls.Add(Me.txtApliFalta)
        Me.Controls.Add(Me.lblApliFalta)
        Me.Controls.Add(Me.txtApliNombre_E)
        Me.Controls.Add(Me.lblApliNombre_E)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lblApliNombre_C)
        Me.Controls.Add(Me.ComboUbiCod)
        Me.Controls.Add(Me.lblUbiCod)
        Me.Controls.Add(Me.ComboPlataCod)
        Me.Controls.Add(Me.lblPlataCod)
        Me.Controls.Add(Me.txtApliCod)
        Me.Controls.Add(Me.lblApliCod)
        Me.Controls.Add(Me.txtAplID)
        Me.Controls.Add(Me.lblAplID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnValidarLanza)
        Me.Name = "frmAppLanza"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Origen APP LANZA = 2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnValidarLanza As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblAplID As Label
    Friend WithEvents txtAplID As TextBox
    Friend WithEvents txtApliCod As TextBox
    Friend WithEvents lblApliCod As Label
    Friend WithEvents lblPlataCod As Label
    Friend WithEvents ComboPlataCod As ComboBox
    Friend WithEvents lblUbiCod As Label
    Friend WithEvents ComboUbiCod As ComboBox
    Friend WithEvents lblApliNombre_C As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents txtApliNombre_E As TextBox
    Friend WithEvents lblApliNombre_E As Label
    Friend WithEvents txtApliFalta As TextBox
    Friend WithEvents lblApliFalta As Label
    Friend WithEvents txtApliFCompila As TextBox
    Friend WithEvents lblApliFCompila As Label
    Friend WithEvents txtApliDesc As TextBox
    Friend WithEvents lblApliDesc As Label
    Friend WithEvents txtApliRunTMP As TextBox
    Friend WithEvents lblApliRun As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents lblApliRunTmp As Label
    Friend WithEvents txtApliRun As TextBox
    Friend WithEvents lblApliGeneral As Label
    Friend WithEvents txtApliBaja As TextBox
    Friend WithEvents lblApliBaja As Label
    Friend WithEvents chkApliGeneral As CheckBox
    Friend WithEvents lblApliDat As Label
    Friend WithEvents lblApliTmp As Label
    Friend WithEvents txtApliTmp As TextBox
    Friend WithEvents lblApliPro As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtApliUrl As TextBox
    Friend WithEvents lblApliVersion As Label
    Friend WithEvents txtApliVersion As TextBox
    Friend WithEvents lblApliDat_per_no As Label
    Friend WithEvents txtApliDatPerNo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtADMOrigenApp As TextBox
    Friend WithEvents lblAreaCod As Label
    Friend WithEvents txtAreaCod As TextBox
    Friend WithEvents lblADMOrigen As Label
    Friend WithEvents txtAplidatPerSi As TextBox
    Friend WithEvents lblApliIdentifica As Label
    Friend WithEvents txtADMOrigen As TextBox
    Friend WithEvents lblAplidat_per_si As Label
    Friend WithEvents chkApliIdentifica As CheckBox
End Class
