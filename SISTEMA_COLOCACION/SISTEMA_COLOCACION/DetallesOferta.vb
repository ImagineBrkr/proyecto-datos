Imports System.Data.SqlClient

Public Class DetallesOferta
    Private Sub DetallesOferta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BD_ContratacionEmpleosDataSet.Oferta' Puede moverla o quitarla según sea necesario.
        Me.OfertaTableAdapter.Fill(Me.BD_ContratacionEmpleosDataSet.Oferta)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim oConeccion As New SqlConnection
            Dim oComando As New SqlCommand
            Dim oLector As SqlDataReader
            Dim oFila As ListViewItem
            oConeccion.ConnectionString = "Server=(local);Integrated Security=true;Database=BD_ContratacionEmpleos"
            oConeccion.Open()
            oComando.CommandText = "SP_OfertaDetalles"
            oComando.CommandType = CommandType.StoredProcedure
            oComando.Parameters.Add("@CodOferta", SqlDbType.Int).Value = ComboBox1.SelectedValue
            oComando.Parameters.Add("@Busqueda", SqlDbType.VarChar, 15).Value = ComboBox2.Text
            oComando.Connection = oConeccion
            Me.ListView1.Items.Clear()
            oLector = oComando.ExecuteReader
            If oLector.HasRows = True Then
                If ComboBox2.Text = "Requerimientos" Then
                    oFila = New ListViewItem
                    oFila.Text = "Descripción"
                    oFila.SubItems.Add("Prioridad")
                    Me.ListView1.Items.Add(oFila)
                    While oLector.Read
                        oFila = New ListViewItem
                        oFila.Text = CStr(oLector.Item(0))
                        oFila.SubItems.Add(CStr(oLector.Item(1)))
                        Me.ListView1.Items.Add(oFila)
                    End While
                ElseIf ComboBox2.Text = "Funciones" Then
                    oFila = New ListViewItem
                    oFila.Text = "Descripción"
                    Me.ListView1.Items.Add(oFila)
                    While oLector.Read
                        oFila = New ListViewItem
                        oFila.Text = CStr(oLector.Item(0))
                        Me.ListView1.Items.Add(oFila)
                    End While
                ElseIf ComboBox2.Text = "Beneficios" Then
                    oFila = New ListViewItem
                    oFila.Text = "Descripción"
                    Me.ListView1.Items.Add(oFila)
                    While oLector.Read
                        oFila = New ListViewItem
                        oFila.Text = CStr(oLector.Item(0))
                        Me.ListView1.Items.Add(oFila)
                    End While
                ElseIf ComboBox2.Text = "Evaluaciones" Then
                    oFila = New ListViewItem
                    oFila.Text = "Prueba"
                    oFila.SubItems.Add("Tipo")
                    oFila.SubItems.Add("Calificación mínima")
                    Me.ListView1.Items.Add(oFila)
                    While oLector.Read
                        oFila = New ListViewItem
                        oFila.Text = CStr(oLector.Item(0))
                        oFila.SubItems.Add(CStr(oLector.Item(1)))
                        oFila.SubItems.Add(CStr(oLector.Item(2)))
                        Me.ListView1.Items.Add(oFila)
                    End While
                End If

            End If
            oConeccion.Close()
            oConeccion.Dispose()
            oLector.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class