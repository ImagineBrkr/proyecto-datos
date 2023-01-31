Public Class Empresa
    Private Sub EmpresaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles EmpresaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.EmpresaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BD_ContratacionEmpleosDataSet)

    End Sub

    Private Sub EmpresaBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles EmpresaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.EmpresaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BD_ContratacionEmpleosDataSet)

    End Sub

    Private Sub Empresa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BD_ContratacionEmpleosDataSet.Empresa' Puede moverla o quitarla según sea necesario.
        Me.EmpresaTableAdapter.Fill(Me.BD_ContratacionEmpleosDataSet.Empresa)

    End Sub
End Class