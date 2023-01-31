<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CalificacionSalarioPostulantes
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CalificacionSalarioPostulantes))
        Me.BD_ContratacionEmpleosDataSet = New SISTEMA_COLOCACION.BD_ContratacionEmpleosDataSet()
        Me.V_PostulantePromediosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.V_PostulantePromediosTableAdapter = New SISTEMA_COLOCACION.BD_ContratacionEmpleosDataSetTableAdapters.V_PostulantePromediosTableAdapter()
        Me.TableAdapterManager = New SISTEMA_COLOCACION.BD_ContratacionEmpleosDataSetTableAdapters.TableAdapterManager()
        Me.V_PostulantePromediosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.V_PostulantePromediosBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.V_PostulantePromediosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.BD_ContratacionEmpleosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.V_PostulantePromediosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.V_PostulantePromediosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.V_PostulantePromediosBindingNavigator.SuspendLayout()
        CType(Me.V_PostulantePromediosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BD_ContratacionEmpleosDataSet
        '
        Me.BD_ContratacionEmpleosDataSet.DataSetName = "BD_ContratacionEmpleosDataSet"
        Me.BD_ContratacionEmpleosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'V_PostulantePromediosBindingSource
        '
        Me.V_PostulantePromediosBindingSource.DataMember = "V_PostulantePromedios"
        Me.V_PostulantePromediosBindingSource.DataSource = Me.BD_ContratacionEmpleosDataSet
        '
        'V_PostulantePromediosTableAdapter
        '
        Me.V_PostulantePromediosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AreaTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BeneficiosTableAdapter = Nothing
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.ContactoEmpresaTableAdapter = Nothing
        Me.TableAdapterManager.Director_RRHHTableAdapter = Nothing
        Me.TableAdapterManager.EmpresaTableAdapter = Nothing
        Me.TableAdapterManager.EstudiosPostgradoTableAdapter = Nothing
        Me.TableAdapterManager.EstudiosTableAdapter = Nothing
        Me.TableAdapterManager.EvaluacionTableAdapter = Nothing
        Me.TableAdapterManager.ExperienciaLaboralTableAdapter = Nothing
        Me.TableAdapterManager.FuncionesTableAdapter = Nothing
        Me.TableAdapterManager.IdiomasTableAdapter = Nothing
        Me.TableAdapterManager.Oferta_EvaluacionTableAdapter = Nothing
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
        'V_PostulantePromediosBindingNavigator
        '
        Me.V_PostulantePromediosBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.V_PostulantePromediosBindingNavigator.BindingSource = Me.V_PostulantePromediosBindingSource
        Me.V_PostulantePromediosBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.V_PostulantePromediosBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.V_PostulantePromediosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.V_PostulantePromediosBindingNavigatorSaveItem})
        Me.V_PostulantePromediosBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.V_PostulantePromediosBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.V_PostulantePromediosBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.V_PostulantePromediosBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.V_PostulantePromediosBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.V_PostulantePromediosBindingNavigator.Name = "V_PostulantePromediosBindingNavigator"
        Me.V_PostulantePromediosBindingNavigator.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.V_PostulantePromediosBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.V_PostulantePromediosBindingNavigator.Size = New System.Drawing.Size(812, 25)
        Me.V_PostulantePromediosBindingNavigator.TabIndex = 0
        Me.V_PostulantePromediosBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 15)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'V_PostulantePromediosBindingNavigatorSaveItem
        '
        Me.V_PostulantePromediosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.V_PostulantePromediosBindingNavigatorSaveItem.Enabled = False
        Me.V_PostulantePromediosBindingNavigatorSaveItem.Image = CType(resources.GetObject("V_PostulantePromediosBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.V_PostulantePromediosBindingNavigatorSaveItem.Name = "V_PostulantePromediosBindingNavigatorSaveItem"
        Me.V_PostulantePromediosBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 20)
        Me.V_PostulantePromediosBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'V_PostulantePromediosDataGridView
        '
        Me.V_PostulantePromediosDataGridView.AutoGenerateColumns = False
        Me.V_PostulantePromediosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.V_PostulantePromediosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.V_PostulantePromediosDataGridView.DataSource = Me.V_PostulantePromediosBindingSource
        Me.V_PostulantePromediosDataGridView.Location = New System.Drawing.Point(14, 126)
        Me.V_PostulantePromediosDataGridView.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.V_PostulantePromediosDataGridView.Name = "V_PostulantePromediosDataGridView"
        Me.V_PostulantePromediosDataGridView.Size = New System.Drawing.Size(694, 338)
        Me.V_PostulantePromediosDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Nombre completo"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nombre completo"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Tipo de documento"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Tipo de documento"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Nro de documento"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Nro de documento"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Salario promedio"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Salario promedio"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Calificación promedio"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Calificación promedio"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(69, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(278, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Promedios básicos del postulante"
        '
        'CalificacionSalarioPostulantes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(812, 552)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.V_PostulantePromediosDataGridView)
        Me.Controls.Add(Me.V_PostulantePromediosBindingNavigator)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Name = "CalificacionSalarioPostulantes"
        Me.Text = "CalificacionSalarioPostulantes"
        CType(Me.BD_ContratacionEmpleosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.V_PostulantePromediosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.V_PostulantePromediosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.V_PostulantePromediosBindingNavigator.ResumeLayout(False)
        Me.V_PostulantePromediosBindingNavigator.PerformLayout()
        CType(Me.V_PostulantePromediosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BD_ContratacionEmpleosDataSet As BD_ContratacionEmpleosDataSet
    Friend WithEvents V_PostulantePromediosBindingSource As BindingSource
    Friend WithEvents V_PostulantePromediosTableAdapter As BD_ContratacionEmpleosDataSetTableAdapters.V_PostulantePromediosTableAdapter
    Friend WithEvents TableAdapterManager As BD_ContratacionEmpleosDataSetTableAdapters.TableAdapterManager
    Friend WithEvents V_PostulantePromediosBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents V_PostulantePromediosBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents V_PostulantePromediosDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
End Class
