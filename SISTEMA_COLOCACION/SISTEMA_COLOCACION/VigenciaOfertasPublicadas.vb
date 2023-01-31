Public Class VigenciaOfertasPublicadas
    Private Sub VigenciaOfertasPublicadas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BD_ContratacionEmpleosDataSet.V_EmpresaOferta' Puede moverla o quitarla según sea necesario.
        Me.V_EmpresaOfertaTableAdapter.Fill(Me.BD_ContratacionEmpleosDataSet.V_EmpresaOferta)

    End Sub
End Class