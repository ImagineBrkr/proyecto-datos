Public Class Referencias
    Private Sub ReferenciasBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ReferenciasBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ReferenciasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BD_ContratacionEmpleosDataSet)

    End Sub

    Private Sub Referencias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BD_ContratacionEmpleosDataSet.Referencias' Puede moverla o quitarla según sea necesario.
        Me.ReferenciasTableAdapter.Fill(Me.BD_ContratacionEmpleosDataSet.Referencias)

    End Sub
End Class