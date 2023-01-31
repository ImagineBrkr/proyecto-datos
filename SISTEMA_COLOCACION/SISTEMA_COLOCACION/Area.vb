Public Class Area
    Private Sub AreaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles AreaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.AreaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BD_ContratacionEmpleosDataSet)

    End Sub

    Private Sub Area_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BD_ContratacionEmpleosDataSet.Area' Puede moverla o quitarla según sea necesario.
        Me.AreaTableAdapter.Fill(Me.BD_ContratacionEmpleosDataSet.Area)

    End Sub
End Class