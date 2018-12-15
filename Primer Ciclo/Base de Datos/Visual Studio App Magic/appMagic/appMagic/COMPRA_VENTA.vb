Public Class COMPRA_VENTA
    Dim nommm As String
    Dim nitt As Double
    Private Sub COMPRAVENTABindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles COMPRAVENTABindingNavigatorSaveItem.Click
        Me.Validate()
        Me.COMPRAVENTABindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BASE1DataSet)

    End Sub

    Private Sub COMPRA_VENTA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BASE1DataSet.COMPRAVENTA' Puede moverla o quitarla según sea necesario.
        Me.COMPRAVENTATableAdapter.Fill(Me.BASE1DataSet.COMPRAVENTA)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox(TextBox1.Text)
        factura.Show()
        Me.Hide()
        nommm = Val(TextBox1.Text)
        nitt = Val(TextBox5.Text)
        MODULO.nom = nommm
        nit = nitt
    End Sub
End Class