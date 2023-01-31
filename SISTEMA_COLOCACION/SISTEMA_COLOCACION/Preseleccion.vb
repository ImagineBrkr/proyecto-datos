Imports System.Data.SqlClient

Public Class Preseleccion
    Private Sub Preseleccion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BD_ContratacionEmpleosDataSet.Postulante' Puede moverla o quitarla según sea necesario.
        Me.PostulanteTableAdapter.Fill(Me.BD_ContratacionEmpleosDataSet.Postulante)
        'TODO: esta línea de código carga datos en la tabla 'BD_ContratacionEmpleosDataSet.Oferta' Puede moverla o quitarla según sea necesario.
        Me.OfertaTableAdapter.Fill(Me.BD_ContratacionEmpleosDataSet.Oferta)
        'TODO: esta línea de código carga datos en la tabla 'BD_ContratacionEmpleosDataSet.Area' Puede moverla o quitarla según sea necesario.
        Me.AreaTableAdapter.Fill(Me.BD_ContratacionEmpleosDataSet.Area)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim oConeccion As New SqlConnection
            Dim oComando As New SqlCommand
            Dim oLector As SqlDataReader
            oConeccion.ConnectionString = "Server=(local);Integrated Security=true;Database=BD_ContratacionEmpleos"
            oConeccion.Open()
            oComando.CommandText = "SP_IngresarPostulante"
            oComando.CommandType = CommandType.StoredProcedure
            oComando.Parameters.Add("@CodOferta", SqlDbType.Int).Value = ComboBox1.SelectedValue
            oComando.Parameters.Add("@IdPostulante", SqlDbType.Char, 4).Value = ComboBox2.SelectedValue
            oComando.Connection = oConeccion
            oLector = oComando.ExecuteReader
            If oLector.HasRows = True Then
                While oLector.Read
                    TextBox1.Text = oLector.Item(0)
                End While
            End If
            oConeccion.Close()
            oConeccion.Dispose()
            oLector.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class