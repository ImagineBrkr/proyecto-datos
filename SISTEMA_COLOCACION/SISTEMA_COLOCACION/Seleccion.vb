Imports System.Data.SqlClient

Public Class Seleccion
    Private Sub Postulacion_SeleccionBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Postulacion_SeleccionBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Postulacion_SeleccionBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BD_ContratacionEmpleosDataSet)

    End Sub

    Private Sub Seleccion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BD_ContratacionEmpleosDataSet.Oferta' Puede moverla o quitarla según sea necesario.
        Me.OfertaTableAdapter.Fill(Me.BD_ContratacionEmpleosDataSet.Oferta)
        'TODO: esta línea de código carga datos en la tabla 'BD_ContratacionEmpleosDataSet.Postulacion_Seleccion' Puede moverla o quitarla según sea necesario.
        Me.Postulacion_SeleccionTableAdapter.Fill(Me.BD_ContratacionEmpleosDataSet.Postulacion_Seleccion)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim oConeccion As New SqlConnection
            Dim oComando As New SqlCommand
            Dim oLector As SqlDataReader
            oConeccion.ConnectionString = "Server=(local);Integrated Security=true;Database=BD_ContratacionEmpleos"
            oConeccion.Open()
            oComando.CommandText = "SP_SeleccionarPostulantes"
            oComando.CommandType = CommandType.StoredProcedure
            oComando.Parameters.Add("@CodOferta", SqlDbType.Int).Value = ComboBox1.SelectedValue
            oComando.Connection = oConeccion
            oLector = oComando.ExecuteReader
            oConeccion.Close()
            oConeccion.Dispose()
            oLector.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class