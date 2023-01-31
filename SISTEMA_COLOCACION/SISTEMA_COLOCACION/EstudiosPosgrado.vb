Public Class EstudiosPosgrado
    Private Sub EstudiosPostgradoBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles EstudiosPostgradoBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.EstudiosPostgradoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BD_ContratacionEmpleosDataSet)

    End Sub

    Private Sub EstudiosPosgrado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BD_ContratacionEmpleosDataSet.EstudiosPostgrado' Puede moverla o quitarla según sea necesario.
        Me.EstudiosPostgradoTableAdapter.Fill(Me.BD_ContratacionEmpleosDataSet.EstudiosPostgrado)

    End Sub
End Class