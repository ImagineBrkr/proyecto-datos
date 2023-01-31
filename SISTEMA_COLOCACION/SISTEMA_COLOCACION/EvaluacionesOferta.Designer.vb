<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EvaluacionesOferta
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.BD_ContratacionEmpleosDataSet = New SISTEMA_COLOCACION.BD_ContratacionEmpleosDataSet()
        Me.Oferta_EvaluacionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Oferta_EvaluacionTableAdapter = New SISTEMA_COLOCACION.BD_ContratacionEmpleosDataSetTableAdapters.Oferta_EvaluacionTableAdapter()
        Me.TableAdapterManager = New SISTEMA_COLOCACION.BD_ContratacionEmpleosDataSetTableAdapters.TableAdapterManager()
        Me.V_EvaluacionesRecurrentesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.V_EvaluacionesRecurrentesTableAdapter = New SISTEMA_COLOCACION.BD_ContratacionEmpleosDataSetTableAdapters.V_EvaluacionesRecurrentesTableAdapter()
        Me.V_EvaluacionesRecurrentesDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.BD_ContratacionEmpleosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Oferta_EvaluacionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.V_EvaluacionesRecurrentesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.V_EvaluacionesRecurrentesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BD_ContratacionEmpleosDataSet
        '
        Me.BD_ContratacionEmpleosDataSet.DataSetName = "BD_ContratacionEmpleosDataSet"
        Me.BD_ContratacionEmpleosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Oferta_EvaluacionBindingSource
        '
        Me.Oferta_EvaluacionBindingSource.DataMember = "Oferta_Evaluacion"
        Me.Oferta_EvaluacionBindingSource.DataSource = Me.BD_ContratacionEmpleosDataSet
        '
        'Oferta_EvaluacionTableAdapter
        '
        Me.Oferta_EvaluacionTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AreaTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BeneficiosTableAdapter = Nothing
        Me.TableAdapterManager.ContactoEmpresaTableAdapter = Nothing
        Me.TableAdapterManager.Director_RRHHTableAdapter = Nothing
        Me.TableAdapterManager.EmpresaTableAdapter = Nothing
        Me.TableAdapterManager.EstudiosPostgradoTableAdapter = Nothing
        Me.TableAdapterManager.EstudiosTableAdapter = Nothing
        Me.TableAdapterManager.EvaluacionTableAdapter = Nothing
        Me.TableAdapterManager.ExperienciaLaboralTableAdapter = Nothing
        Me.TableAdapterManager.FuncionesTableAdapter = Nothing
        Me.TableAdapterManager.IdiomasTableAdapter = Nothing
        Me.TableAdapterManager.Oferta_EvaluacionTableAdapter = Me.Oferta_EvaluacionTableAdapter
        Me.TableAdapterManager.OfertaTableAdapter = Nothing
        Me.TableAdapterManager.Postulacion_PreseleccionTableAdapter = Nothing
        Me.TableAdapterManager.Postulacion_SeleccionTableAdapter = Nothing
        Me.TableAdapterManager.Postulante_EvaluacionTableAdapter = Nothing
        Me.TableAdapterManager.PostulanteTableAdapter = Nothing
        Me.TableAdapterManager.ReferenciasTableAdapter = Nothing
        Me.TableAdapterManager.RegionTableAdapter = Nothing
        Me.TableAdapterManager.RequerimientoTableAdapter = Nothing
        Me.TableAdapterManager.SoftwareTableAdapter = Nothing
        Me.TableAdapterManager.TipoEvaluacionTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SISTEMA_COLOCACION.BD_ContratacionEmpleosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'V_EvaluacionesRecurrentesBindingSource
        '
        Me.V_EvaluacionesRecurrentesBindingSource.DataMember = "V_EvaluacionesRecurrentes"
        Me.V_EvaluacionesRecurrentesBindingSource.DataSource = Me.BD_ContratacionEmpleosDataSet
        '
        'V_EvaluacionesRecurrentesTableAdapter
        '
        Me.V_EvaluacionesRecurrentesTableAdapter.ClearBeforeFill = True
        '
        'V_EvaluacionesRecurrentesDataGridView
        '
        Me.V_EvaluacionesRecurrentesDataGridView.AutoGenerateColumns = False
        Me.V_EvaluacionesRecurrentesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.V_EvaluacionesRecurrentesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.V_EvaluacionesRecurrentesDataGridView.DataSource = Me.V_EvaluacionesRecurrentesBindingSource
        Me.V_EvaluacionesRecurrentesDataGridView.Location = New System.Drawing.Point(81, 76)
        Me.V_EvaluacionesRecurrentesDataGridView.Name = "V_EvaluacionesRecurrentesDataGridView"
        Me.V_EvaluacionesRecurrentesDataGridView.Size = New System.Drawing.Size(592, 220)
        Me.V_EvaluacionesRecurrentesDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Prueba"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Prueba"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Tipo de prueba"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Tipo de prueba"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Calificación mínima promedio"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Calificación mínima promedio"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Calificación promedio"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Calificación promedio"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(87, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(444, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Evaluaciones que han sido solicitadas repetidas veces"
        '
        'EvaluacionesOferta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(860, 364)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.V_EvaluacionesRecurrentesDataGridView)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "EvaluacionesOferta"
        Me.Text = "EvaluacionesOferta"
        CType(Me.BD_ContratacionEmpleosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Oferta_EvaluacionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.V_EvaluacionesRecurrentesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.V_EvaluacionesRecurrentesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BD_ContratacionEmpleosDataSet As BD_ContratacionEmpleosDataSet
    Friend WithEvents Oferta_EvaluacionBindingSource As BindingSource
    Friend WithEvents Oferta_EvaluacionTableAdapter As BD_ContratacionEmpleosDataSetTableAdapters.Oferta_EvaluacionTableAdapter
    Friend WithEvents TableAdapterManager As BD_ContratacionEmpleosDataSetTableAdapters.TableAdapterManager
    Friend WithEvents V_EvaluacionesRecurrentesBindingSource As BindingSource
    Friend WithEvents V_EvaluacionesRecurrentesTableAdapter As BD_ContratacionEmpleosDataSetTableAdapters.V_EvaluacionesRecurrentesTableAdapter
    Friend WithEvents V_EvaluacionesRecurrentesDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
End Class
