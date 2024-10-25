Public Class frmAppLanza
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub frmAppLanza_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboPlataCod.SelectedIndex = 0
        ComboUbiCod.SelectedIndex = 0
    End Sub

    Private Sub ComboPlataCod_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboPlataCod.SelectedIndexChanged
        'PlataCod depende de la tabla USYSPLATAFORMA (PlataCod, PlataDes). A tener en cuenta para futuros desarrollos
    End Sub

    Private Sub ComboUbiCod_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboUbiCod.SelectedIndexChanged
        'UbiCod depende de la tabla USYSUBICA (UbiCod, UbiDes)
    End Sub

    Private Sub txtApliFCompila_TextChanged(sender As Object, e As EventArgs) Handles txtApliFCompila.TextChanged
        'Todos los textBox que ApliF.... tienen formato de fecha
    End Sub




    'Eventos para que admitan solo números (los textbox correspondientes)
    Private Sub txtApliVersion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtApliVersion.KeyPress


        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then

            e.Handled = True
        End If
    End Sub

    Private Sub txtAreaCod_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAreaCod.KeyPress

        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then

            e.Handled = True
        End If
    End Sub

    Private Sub txtAplID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAplID.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then

            e.Handled = True
        End If
    End Sub
End Class