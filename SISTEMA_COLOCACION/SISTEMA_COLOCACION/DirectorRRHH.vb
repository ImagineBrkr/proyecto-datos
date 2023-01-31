Public Class DirectorRRHH
    Private Sub Director_RRHHBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Director_RRHHBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Director_RRHHBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BD_ContratacionEmpleosDataSet)

    End Sub

    Private Sub DirectorRRHH_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BD_ContratacionEmpleosDataSet.Director_RRHH' Puede moverla o quitarla según sea necesario.
        Me.Director_RRHHTableAdapter.Fill(Me.BD_ContratacionEmpleosDataSet.Director_RRHH)

    End Sub
End Class