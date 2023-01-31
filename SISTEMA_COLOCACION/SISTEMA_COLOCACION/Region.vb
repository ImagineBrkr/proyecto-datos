Public Class Region
    Private Sub RegionBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles RegionBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.RegionBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BD_ContratacionEmpleosDataSet)

    End Sub

    Private Sub Region_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BD_ContratacionEmpleosDataSet._Region' Puede moverla o quitarla según sea necesario.
        Me.RegionTableAdapter.Fill(Me.BD_ContratacionEmpleosDataSet._Region)

    End Sub
End Class