Public Class Softwares
    Private Sub SoftwareBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles SoftwareBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.SoftwareBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BD_ContratacionEmpleosDataSet)

    End Sub

    Private Sub Softwares_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BD_ContratacionEmpleosDataSet.Software' Puede moverla o quitarla según sea necesario.
        Me.SoftwareTableAdapter.Fill(Me.BD_ContratacionEmpleosDataSet.Software)

    End Sub
End Class