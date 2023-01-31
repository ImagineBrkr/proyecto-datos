Imports System.Data.SqlClient

Public Class PostulantesSeleccionadosOferta
    Private Sub PostulantesSeleccionadosOferta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BD_ContratacionEmpleosDataSet.Oferta' Puede moverla o quitarla según sea necesario.
        Me.OfertaTableAdapter.Fill(Me.BD_ContratacionEmpleosDataSet.Oferta)
        'TODO: esta línea de código carga datos en la tabla 'BD_ContratacionEmpleosDataSet4.Oferta' Puede moverla o quitarla según sea necesario.
        Me.OfertaTableAdapter.Fill(Me.BD_ContratacionEmpleosDataSet.Oferta)
        'TODO: esta línea de código carga datos en la tabla 'BD_ContratacionEmpleosDataSet.V_PostulanteSeleccionado' Puede moverla o quitarla según sea necesario.
        Me.V_PostulanteSeleccionadoTableAdapter.Fill(Me.BD_ContratacionEmpleosDataSet.V_PostulanteSeleccionado)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim oConeccion As New SqlConnection
            Dim oComando As New SqlCommand
            Dim oLector As SqlDataReader
            Dim oFila As ListViewItem
            oConeccion.ConnectionString = "Server=(local);Integrated Security=true;Database=BD_ContratacionEmpleos"
            oConeccion.Open()
            oComando.CommandText = "SP_PostulanteOferta"
            oComando.CommandType = CommandType.StoredProcedure
            oComando.Parameters.Add("@CodOferta", SqlDbType.Int).Value = ComboBox1.SelectedValue
            oComando.Connection = oConeccion
            Me.ListView1.Items.Clear()
            oLector = oComando.ExecuteReader
            If oLector.HasRows = True Then
                While oLector.Read
                    oFila = New ListViewItem
                    oFila.Text = CStr(oLector.Item(0))
                    oFila.SubItems.Add(CStr(oLector.Item(1)))
                    oFila.SubItems.Add(CStr(oLector.Item(2)))
                    oFila.SubItems.Add(CStr(oLector.Item(3)))
                    oFila.SubItems.Add(CStr(oLector.Item(4)))
                    oFila.SubItems.Add(CStr(oLector.Item(5)))
                    Me.ListView1.Items.Add(oFila)
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