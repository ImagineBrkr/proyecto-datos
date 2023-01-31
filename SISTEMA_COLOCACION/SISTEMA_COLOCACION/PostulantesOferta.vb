Public Class PostulantesOferta
    Private Sub PostulantesOferta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BD_ContratacionEmpleosDataSet.V_PostulanteSeleccionado' Puede moverla o quitarla según sea necesario.
        Me.V_PostulanteSeleccionadoTableAdapter.Fill(Me.BD_ContratacionEmpleosDataSet.V_PostulanteSeleccionado)

    End Sub
End Class