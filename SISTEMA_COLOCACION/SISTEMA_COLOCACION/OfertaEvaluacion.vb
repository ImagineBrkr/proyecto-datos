Public Class OfertaEvaluacion
    Private Sub Oferta_EvaluacionBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Oferta_EvaluacionBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Oferta_EvaluacionBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BD_ContratacionEmpleosDataSet)

    End Sub

    Private Sub OfertaEvaluacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BD_ContratacionEmpleosDataSet.Oferta_Evaluacion' Puede moverla o quitarla según sea necesario.
        Me.Oferta_EvaluacionTableAdapter.Fill(Me.BD_ContratacionEmpleosDataSet.Oferta_Evaluacion)

    End Sub
End Class