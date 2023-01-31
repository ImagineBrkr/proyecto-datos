Public Class Idiomas
    Private Sub IdiomasBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles IdiomasBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.IdiomasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BD_ContratacionEmpleosDataSet)

    End Sub

    Private Sub Idiomas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BD_ContratacionEmpleosDataSet.Idiomas' Puede moverla o quitarla según sea necesario.
        Me.IdiomasTableAdapter.Fill(Me.BD_ContratacionEmpleosDataSet.Idiomas)

    End Sub
End Class