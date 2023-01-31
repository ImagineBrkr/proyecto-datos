Public Class Evaluacion
    Private Sub EvaluacionBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles EvaluacionBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.EvaluacionBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BD_ContratacionEmpleosDataSet)

    End Sub

    Private Sub Evaluacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BD_ContratacionEmpleosDataSet.Evaluacion' Puede moverla o quitarla según sea necesario.
        Me.EvaluacionTableAdapter.Fill(Me.BD_ContratacionEmpleosDataSet.Evaluacion)

    End Sub
End Class