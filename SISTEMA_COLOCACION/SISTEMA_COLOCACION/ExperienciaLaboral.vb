Public Class ExperienciaLaboral
    Private Sub ExperienciaLaboralBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ExperienciaLaboralBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ExperienciaLaboralBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BD_ContratacionEmpleosDataSet)

    End Sub

    Private Sub ExperienciaLaboral_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BD_ContratacionEmpleosDataSet.ExperienciaLaboral' Puede moverla o quitarla según sea necesario.
        Me.ExperienciaLaboralTableAdapter.Fill(Me.BD_ContratacionEmpleosDataSet.ExperienciaLaboral)

    End Sub



    Private Sub PersonasACargoTextBox_TextChanged(sender As Object, e As EventArgs) Handles PersonasACargoTextBox.TextChanged

    End Sub
End Class