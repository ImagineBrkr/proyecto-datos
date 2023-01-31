Public Class Estudios
    Private Sub EstudiosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles EstudiosBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.EstudiosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BD_ContratacionEmpleosDataSet)

    End Sub

    Private Sub Estudios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BD_ContratacionEmpleosDataSet.Estudios' Puede moverla o quitarla según sea necesario.
        Me.EstudiosTableAdapter.Fill(Me.BD_ContratacionEmpleosDataSet.Estudios)

    End Sub
End Class