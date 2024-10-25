<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAppASP
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
        Me.btnValidarASP = New System.Windows.Forms.Button()
        Me.btnSalirASP = New System.Windows.Forms.Button()
        Me.lblAppCod = New System.Windows.Forms.Label()
        Me.txtAPPCOD = New System.Windows.Forms.TextBox()
        Me.txtAppDes_C = New System.Windows.Forms.TextBox()
        Me.lblAPPDES_C = New System.Windows.Forms.Label()
        Me.txtAppDes_E = New System.Windows.Forms.TextBox()
        Me.lblAppDes_E = New System.Windows.Forms.Label()
        Me.txtAppDes_I = New System.Windows.Forms.TextBox()
        Me.lblAppDes_I = New System.Windows.Forms.Label()
        Me.txtAppDes_F = New System.Windows.Forms.TextBox()
        Me.lblAppDes_F = New System.Windows.Forms.Label()
        Me.lblAppStop = New System.Windows.Forms.Label()
        Me.checkAppStop = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'btnValidarASP
        '
        Me.btnValidarASP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnValidarASP.Location = New System.Drawing.Point(13, 13)
        Me.btnValidarASP.Name = "btnValidarASP"
        Me.btnValidarASP.Size = New System.Drawing.Size(75, 23)
        Me.btnValidarASP.TabIndex = 0
        Me.btnValidarASP.Text = "VALIDAR"
        Me.btnValidarASP.UseMnemonic = False
        Me.btnValidarASP.UseVisualStyleBackColor = True
        '
        'btnSalirASP
        '
        Me.btnSalirASP.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalirASP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalirASP.Location = New System.Drawing.Point(354, 298)
        Me.btnSalirASP.Name = "btnSalirASP"
        Me.btnSalirASP.Size = New System.Drawing.Size(75, 23)
        Me.btnSalirASP.TabIndex = 1
        Me.btnSalirASP.Text = "SALIR"
        Me.btnSalirASP.UseVisualStyleBackColor = True
        '
        'lblAppCod
        '
        Me.lblAppCod.AutoSize = True
        Me.lblAppCod.Location = New System.Drawing.Point(24, 64)
        Me.lblAppCod.Name = "lblAppCod"
        Me.lblAppCod.Size = New System.Drawing.Size(58, 13)
        Me.lblAppCod.TabIndex = 2
        Me.lblAppCod.Text = "APPCOD *"
        '
        'txtAPPCOD
        '
        Me.txtAPPCOD.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAPPCOD.Location = New System.Drawing.Point(110, 57)
        Me.txtAPPCOD.MaxLength = 7
        Me.txtAPPCOD.Name = "txtAPPCOD"
        Me.txtAPPCOD.Size = New System.Drawing.Size(64, 20)
        Me.txtAPPCOD.TabIndex = 3
        '
        'txtAppDes_C
        '
        Me.txtAppDes_C.Location = New System.Drawing.Point(110, 97)
        Me.txtAppDes_C.MaxLength = 30
        Me.txtAppDes_C.Name = "txtAppDes_C"
        Me.txtAppDes_C.Size = New System.Drawing.Size(140, 20)
        Me.txtAppDes_C.TabIndex = 5
        '
        'lblAPPDES_C
        '
        Me.lblAPPDES_C.AutoSize = True
        Me.lblAPPDES_C.Location = New System.Drawing.Point(24, 104)
        Me.lblAPPDES_C.Name = "lblAPPDES_C"
        Me.lblAPPDES_C.Size = New System.Drawing.Size(70, 13)
        Me.lblAPPDES_C.TabIndex = 4
        Me.lblAPPDES_C.Text = "APPDES_C *"
        '
        'txtAppDes_E
        '
        Me.txtAppDes_E.Location = New System.Drawing.Point(110, 142)
        Me.txtAppDes_E.MaxLength = 30
        Me.txtAppDes_E.Name = "txtAppDes_E"
        Me.txtAppDes_E.Size = New System.Drawing.Size(140, 20)
        Me.txtAppDes_E.TabIndex = 7
        '
        'lblAppDes_E
        '
        Me.lblAppDes_E.AutoSize = True
        Me.lblAppDes_E.Location = New System.Drawing.Point(24, 149)
        Me.lblAppDes_E.Name = "lblAppDes_E"
        Me.lblAppDes_E.Size = New System.Drawing.Size(70, 13)
        Me.lblAppDes_E.TabIndex = 6
        Me.lblAppDes_E.Text = "APPDES_E *"
        '
        'txtAppDes_I
        '
        Me.txtAppDes_I.Location = New System.Drawing.Point(110, 191)
        Me.txtAppDes_I.MaxLength = 30
        Me.txtAppDes_I.Name = "txtAppDes_I"
        Me.txtAppDes_I.Size = New System.Drawing.Size(140, 20)
        Me.txtAppDes_I.TabIndex = 9
        '
        'lblAppDes_I
        '
        Me.lblAppDes_I.AutoSize = True
        Me.lblAppDes_I.Location = New System.Drawing.Point(24, 198)
        Me.lblAppDes_I.Name = "lblAppDes_I"
        Me.lblAppDes_I.Size = New System.Drawing.Size(59, 13)
        Me.lblAppDes_I.TabIndex = 8
        Me.lblAppDes_I.Text = "APPDES_I"
        '
        'txtAppDes_F
        '
        Me.txtAppDes_F.Location = New System.Drawing.Point(110, 230)
        Me.txtAppDes_F.MaxLength = 30
        Me.txtAppDes_F.Name = "txtAppDes_F"
        Me.txtAppDes_F.Size = New System.Drawing.Size(140, 20)
        Me.txtAppDes_F.TabIndex = 11
        '
        'lblAppDes_F
        '
        Me.lblAppDes_F.AutoSize = True
        Me.lblAppDes_F.Location = New System.Drawing.Point(24, 237)
        Me.lblAppDes_F.Name = "lblAppDes_F"
        Me.lblAppDes_F.Size = New System.Drawing.Size(62, 13)
        Me.lblAppDes_F.TabIndex = 10
        Me.lblAppDes_F.Text = "APPDES_F"
        '
        'lblAppStop
        '
        Me.lblAppStop.AutoSize = True
        Me.lblAppStop.Location = New System.Drawing.Point(24, 276)
        Me.lblAppStop.Name = "lblAppStop"
        Me.lblAppStop.Size = New System.Drawing.Size(57, 13)
        Me.lblAppStop.TabIndex = 12
        Me.lblAppStop.Text = "APPSTOP"
        '
        'checkAppStop
        '
        Me.checkAppStop.AutoSize = True
        Me.checkAppStop.Location = New System.Drawing.Point(110, 276)
        Me.checkAppStop.Name = "checkAppStop"
        Me.checkAppStop.Size = New System.Drawing.Size(15, 14)
        Me.checkAppStop.TabIndex = 13
        Me.checkAppStop.UseVisualStyleBackColor = True
        '
        'frmAppASP
        '
        Me.ClientSize = New System.Drawing.Size(459, 353)
        Me.Controls.Add(Me.checkAppStop)
        Me.Controls.Add(Me.lblAppStop)
        Me.Controls.Add(Me.txtAppDes_F)
        Me.Controls.Add(Me.lblAppDes_F)
        Me.Controls.Add(Me.txtAppDes_I)
        Me.Controls.Add(Me.lblAppDes_I)
        Me.Controls.Add(Me.txtAppDes_E)
        Me.Controls.Add(Me.lblAppDes_E)
        Me.Controls.Add(Me.txtAppDes_C)
        Me.Controls.Add(Me.lblAPPDES_C)
        Me.Controls.Add(Me.txtAPPCOD)
        Me.Controls.Add(Me.lblAppCod)
        Me.Controls.Add(Me.btnSalirASP)
        Me.Controls.Add(Me.btnValidarASP)
        Me.Name = "frmAppASP"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ASP ORIGEN ASP = 1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnValidarASP As Button
    Friend WithEvents btnSalirASP As Button
    Friend WithEvents lblAppCod As Label
    Friend WithEvents txtAPPCOD As TextBox
    Friend WithEvents txtAppDes_C As TextBox
    Friend WithEvents lblAPPDES_C As Label
    Friend WithEvents txtAppDes_E As TextBox
    Friend WithEvents lblAppDes_E As Label
    Friend WithEvents txtAppDes_I As TextBox
    Friend WithEvents lblAppDes_I As Label
    Friend WithEvents txtAppDes_F As TextBox
    Friend WithEvents lblAppDes_F As Label
    Friend WithEvents lblAppStop As Label
    Friend WithEvents checkAppStop As CheckBox

End Class
