Public Class Postulante
    Private Sub PostulanteBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles PostulanteBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PostulanteBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BD_ContratacionEmpleosDataSet)

    End Sub

    Private Sub Postulante_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BD_ContratacionEmpleosDataSet.Referencias' Puede moverla o quitarla según sea necesario.
        Me.ReferenciasTableAdapter.Fill(Me.BD_ContratacionEmpleosDataSet.Referencias)
        'TODO: esta línea de código carga datos en la tabla 'BD_ContratacionEmpleosDataSet.Postulante' Puede moverla o quitarla según sea necesario.
        Me.PostulanteTableAdapter.Fill(Me.BD_ContratacionEmpleosDataSet.Postulante)

    End Sub
End Class