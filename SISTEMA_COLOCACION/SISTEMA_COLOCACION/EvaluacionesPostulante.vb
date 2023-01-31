Public Class EvaluacionesPostulante
    Private Sub Postulante_EvaluacionBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Postulante_EvaluacionBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Postulante_EvaluacionBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BD_ContratacionEmpleosDataSet)

    End Sub

    Private Sub EvaluacionesPostulante_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BD_ContratacionEmpleosDataSet.Postulante_Evaluacion' Puede moverla o quitarla según sea necesario.
        Me.Postulante_EvaluacionTableAdapter.Fill(Me.BD_ContratacionEmpleosDataSet.Postulante_Evaluacion)

    End Sub
End Class