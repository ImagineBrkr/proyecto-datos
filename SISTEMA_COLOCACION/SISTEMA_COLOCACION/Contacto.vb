Public Class Contacto
    Private Sub ContactoEmpresaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ContactoEmpresaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ContactoEmpresaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BD_ContratacionEmpleosDataSet)

    End Sub

    Private Sub Contacto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BD_ContratacionEmpleosDataSet.ContactoEmpresa' Puede moverla o quitarla según sea necesario.
        Me.ContactoEmpresaTableAdapter.Fill(Me.BD_ContratacionEmpleosDataSet.ContactoEmpresa)

    End Sub
End Class