Public Class Requerimientos
    Private Sub RequerimientoBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles RequerimientoBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.RequerimientoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BD_ContratacionEmpleosDataSet)

    End Sub

    Private Sub Requerimientos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BD_ContratacionEmpleosDataSet.Requerimiento' Puede moverla o quitarla según sea necesario.
        Me.RequerimientoTableAdapter.Fill(Me.BD_ContratacionEmpleosDataSet.Requerimiento)

    End Sub
End Class