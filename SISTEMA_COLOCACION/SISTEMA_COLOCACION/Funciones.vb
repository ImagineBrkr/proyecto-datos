Public Class Funciones
    Private Sub FuncionesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles FuncionesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.FuncionesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BD_ContratacionEmpleosDataSet)

    End Sub

    Private Sub Funciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BD_ContratacionEmpleosDataSet.Funciones' Puede moverla o quitarla según sea necesario.
        Me.FuncionesTableAdapter.Fill(Me.BD_ContratacionEmpleosDataSet.Funciones)

    End Sub
End Class