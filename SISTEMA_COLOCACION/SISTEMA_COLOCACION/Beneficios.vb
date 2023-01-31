Public Class Beneficios
    Private Sub BeneficiosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles BeneficiosBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.BeneficiosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BD_ContratacionEmpleosDataSet)

    End Sub

    Private Sub Beneficios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BD_ContratacionEmpleosDataSet.Beneficios' Puede moverla o quitarla según sea necesario.
        Me.BeneficiosTableAdapter.Fill(Me.BD_ContratacionEmpleosDataSet.Beneficios)

    End Sub

    Private Sub CodBeneficiosTextBox_TextChanged(sender As Object, e As EventArgs) Handles CodBeneficiosTextBox.TextChanged

    End Sub
End Class