Imports System.Data.SqlClient

Public Class DetallesPostulante
    Private Sub DetallesPostulante_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BD_ContratacionEmpleosDataSet.Postulante' Puede moverla o quitarla según sea necesario.
        Me.PostulanteTableAdapter.Fill(Me.BD_ContratacionEmpleosDataSet.Postulante)
        'TODO: esta línea de código carga datos en la tabla 'BD_ContratacionEmpleosDataSet3.Postulante' Puede moverla o quitarla según sea necesario.
        Me.PostulanteTableAdapter.Fill(Me.BD_ContratacionEmpleosDataSet.Postulante)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim oConeccion As New SqlConnection
            Dim oComando As New SqlCommand
            Dim oLector As SqlDataReader
            Dim oFila As ListViewItem
            oConeccion.ConnectionString = "Server=(local);Integrated Security=true;Database=BD_ContratacionEmpleos"
            oConeccion.Open()
            oComando.CommandText = "SP_PostulanteDetalles"
            oComando.CommandType = CommandType.StoredProcedure
            oComando.Parameters.Add("@IdPostulante", SqlDbType.Char, 4).Value = ComboBox1.SelectedValue
            oComando.Parameters.Add("@Busqueda", SqlDbType.VarChar, 30).Value = ComboBox2.Text
            oComando.Connection = oConeccion
            Me.ListView1.Items.Clear()
            oLector = oComando.ExecuteReader
            If oLector.HasRows = True Then
                If ComboBox2.Text = "Experiencia Laboral" Then
                    oFila = New ListViewItem
                    oFila.Text = "Empresa"
                    oFila.SubItems.Add("Puesto")
                    oFila.SubItems.Add("Fecha de inicio")
                    oFila.SubItems.Add("Al presente")
                    oFila.SubItems.Add("Salario")
                    oFila.SubItems.Add("Area")
                    Me.ListView1.Items.Add(oFila)
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
                ElseIf ComboBox2.Text = "Estudios Postgrado" Then
                    oFila = New ListViewItem
                    oFila.Text = "Tipo de estudios"
                    oFila.SubItems.Add("Nombre de estudios")
                    oFila.SubItems.Add("Institución")
                    oFila.SubItems.Add("Fecha de inicio")
                    oFila.SubItems.Add("Al presente")
                    Me.ListView1.Items.Add(oFila)
                    While oLector.Read
                        oFila = New ListViewItem
                        oFila.Text = CStr(oLector.Item(0))
                        oFila.SubItems.Add(CStr(oLector.Item(1)))
                        oFila.SubItems.Add(CStr(oLector.Item(2)))
                        oFila.SubItems.Add(CStr(oLector.Item(3)))
                        oFila.SubItems.Add(CStr(oLector.Item(4)))
                        Me.ListView1.Items.Add(oFila)
                    End While
                ElseIf ComboBox2.Text = "Estudios" Then
                    oFila = New ListViewItem
                    oFila.Text = "Grado académico"
                    oFila.SubItems.Add("Institución")
                    oFila.SubItems.Add("Carrera")
                    oFila.SubItems.Add("Fecha de inicio")
                    oFila.SubItems.Add("Al presente")
                    Me.ListView1.Items.Add(oFila)
                    While oLector.Read
                        oFila = New ListViewItem
                        oFila.Text = CStr(oLector.Item(0))
                        oFila.SubItems.Add(CStr(oLector.Item(1)))
                        oFila.SubItems.Add(CStr(oLector.Item(2)))
                        oFila.SubItems.Add(CStr(oLector.Item(3)))
                        oFila.SubItems.Add(CStr(oLector.Item(4)))
                        Me.ListView1.Items.Add(oFila)
                    End While
                ElseIf ComboBox2.Text = "Idiomas" Then
                    oFila = New ListViewItem
                    oFila.Text = "Idioma"
                    oFila.SubItems.Add("Nivel")
                    Me.ListView1.Items.Add(oFila)
                    While oLector.Read
                        oFila = New ListViewItem
                        oFila.Text = CStr(oLector.Item(0))
                        oFila.SubItems.Add(CStr(oLector.Item(1)))
                        Me.ListView1.Items.Add(oFila)
                    End While
                ElseIf ComboBox2.Text = "Software" Then
                    oFila = New ListViewItem
                    oFila.Text = "Software"
                    oFila.SubItems.Add("Nivel")
                    Me.ListView1.Items.Add(oFila)
                    While oLector.Read
                        oFila = New ListViewItem
                        oFila.Text = CStr(oLector.Item(0))
                        oFila.SubItems.Add(CStr(oLector.Item(1)))
                        Me.ListView1.Items.Add(oFila)
                    End While
                ElseIf ComboBox2.Text = "Referencias" Then
                    oFila = New ListViewItem
                    oFila.Text = "Nombre"
                    oFila.SubItems.Add("Correo")
                    oFila.SubItems.Add("Telefono")
                    oFila.SubItems.Add("Tipo de referencia")
                    oFila.SubItems.Add("Tipo de relación")
                    oFila.SubItems.Add("Empresa")
                    oFila.SubItems.Add("Puesto")
                    Me.ListView1.Items.Add(oFila)
                    While oLector.Read
                        oFila = New ListViewItem
                        oFila.Text = CStr(oLector.Item(0))
                        oFila.SubItems.Add(CStr(oLector.Item(1)))
                        oFila.SubItems.Add(CStr(oLector.Item(2)))
                        oFila.SubItems.Add(CStr(oLector.Item(3)))
                        oFila.SubItems.Add(CStr(oLector.Item(4)))
                        oFila.SubItems.Add(CStr(oLector.Item(5)))
                        oFila.SubItems.Add(CStr(oLector.Item(6)))
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