Public Class Oferta
    Private Sub OfertaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles OfertaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.OfertaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BD_ContratacionEmpleosDataSet)

    End Sub

    Private Sub Oferta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BD_ContratacionEmpleosDataSet.Oferta' Puede moverla o quitarla según sea necesario.
        Me.OfertaTableAdapter.Fill(Me.BD_ContratacionEmpleosDataSet.Oferta)

    End Sub

    Private Sub CodOfertaTextBox_TextChanged(sender As Object, e As EventArgs) Handles CodOfertaTextBox.TextChanged

    End Sub

    Private Sub CodOfertaLabel_Click(sender As Object, e As EventArgs)

    End Sub
End Class