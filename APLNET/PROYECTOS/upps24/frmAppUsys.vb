Public Class frmAppUsys
    Private Sub btnSalirUSYS_Click(sender As Object, e As EventArgs) Handles btnSalirUSYS.Click
        Me.Close()
    End Sub

    Private Sub frmAppUsys_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtAppRevision_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAppRevision.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' Si no es un número ni una tecla de control, se anula la entrada
            e.Handled = True
        End If
    End Sub
End Class