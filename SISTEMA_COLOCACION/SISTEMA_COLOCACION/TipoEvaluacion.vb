Public Class TipoEvaluacion
    Private Sub TipoEvaluacionBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TipoEvaluacionBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TipoEvaluacionBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BD_ContratacionEmpleosDataSet)

    End Sub

    Private Sub TipoEvaluacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BD_ContratacionEmpleosDataSet.TipoEvaluacion' Puede moverla o quitarla según sea necesario.
        Me.TipoEvaluacionTableAdapter.Fill(Me.BD_ContratacionEmpleosDataSet.TipoEvaluacion)

    End Sub
End Class