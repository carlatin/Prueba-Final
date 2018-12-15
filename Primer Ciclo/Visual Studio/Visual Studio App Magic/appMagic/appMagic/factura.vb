Public Class factura
    Dim n As String
    Private Sub nombre_Click(sender As Object, e As EventArgs) Handles nom2.Click
    End Sub

    Private Sub factura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        n = Val(MODULO.nom)
        Label9.Text = n
        asdf.Text = nit
    End Sub
End Class