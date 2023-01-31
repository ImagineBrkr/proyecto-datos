Public Class CalificacionSalarioPostulantes
    Private Sub CalificacionSalarioPostulantes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BD_ContratacionEmpleosDataSet.V_PostulantePromedios' Puede moverla o quitarla según sea necesario.
        Me.V_PostulantePromediosTableAdapter.Fill(Me.BD_ContratacionEmpleosDataSet.V_PostulantePromedios)

    End Sub
End Class