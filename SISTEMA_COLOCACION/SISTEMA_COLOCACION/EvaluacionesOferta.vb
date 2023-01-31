Public Class EvaluacionesOferta
    Private Sub EvaluacionesOferta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BD_ContratacionEmpleosDataSet.V_EvaluacionesRecurrentes' Puede moverla o quitarla según sea necesario.
        Me.V_EvaluacionesRecurrentesTableAdapter.Fill(Me.BD_ContratacionEmpleosDataSet.V_EvaluacionesRecurrentes)

    End Sub
End Class