Public Class DetallesCargoPostulantes
    Private Sub DetallesCargoPostulantes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BD_ContratacionEmpleosDataSet.V_PostulanteACargo' Puede moverla o quitarla según sea necesario.
        Me.V_PostulanteACargoTableAdapter.Fill(Me.BD_ContratacionEmpleosDataSet.V_PostulanteACargo)

    End Sub
End Class