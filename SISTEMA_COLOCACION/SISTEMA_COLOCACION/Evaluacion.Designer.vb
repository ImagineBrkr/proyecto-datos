<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Evaluacion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Evaluacion))
        Dim IdEvaluacionLabel As System.Windows.Forms.Label
        Dim PruebaLabel As System.Windows.Forms.Label
        Dim DescripcionLabel As System.Windows.Forms.Label
        Dim TiempoLimiteLabel As System.Windows.Forms.Label
        Dim IdTipoEvaluacionLabel As System.Windows.Forms.Label
        Me.BD_ContratacionEmpleosDataSet = New SISTEMA_COLOCACION.BD_ContratacionEmpleosDataSet()
        Me.EvaluacionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EvaluacionTableAdapter = New SISTEMA_COLOCACION.BD_ContratacionEmpleosDataSetTableAdapters.EvaluacionTableAdapter()
        Me.TableAdapterManager = New SISTEMA_COLOCACION.BD_ContratacionEmpleosDataSetTableAdapters.TableAdapterManager()
        Me.EvaluacionBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.EvaluacionBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IdEvaluacionTextBox = New System.Windows.Forms.TextBox()
        Me.PruebaTextBox = New System.Windows.Forms.TextBox()
        Me.DescripcionTextBox = New System.Windows.Forms.TextBox()
        Me.TiempoLimiteTextBox = New System.Windows.Forms.TextBox()
        Me.IdTipoEvaluacionTextBox = New System.Windows.Forms.TextBox()
        IdEvaluacionLabel = New System.Windows.Forms.Label()
        PruebaLabel = New System.Windows.Forms.Label()
        DescripcionLabel = New System.Windows.Forms.Label()
        TiempoLimiteLabel = New System.Windows.Forms.Label()
        IdTipoEvaluacionLabel = New System.Windows.Forms.Label()
        CType(Me.BD_ContratacionEmpleosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EvaluacionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EvaluacionBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EvaluacionBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'BD_ContratacionEmpleosDataSet
        '
        Me.BD_ContratacionEmpleosDataSet.DataSetName = "BD_ContratacionEmpleosDataSet"
        Me.BD_ContratacionEmpleosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EvaluacionBindingSource
        '
        Me.EvaluacionBindingSource.DataMember = "Evaluacion"
        Me.EvaluacionBindingSource.DataSource = Me.BD_ContratacionEmpleosDataSet
        '
        'EvaluacionTableAdapter
        '
        Me.EvaluacionTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.EvaluacionTableAdapter = Me.EvaluacionTableAdapter
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
        'EvaluacionBindingNavigator
        '
        Me.EvaluacionBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.EvaluacionBindingNavigator.BindingSource = Me.EvaluacionBindingSource
        Me.EvaluacionBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.EvaluacionBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.EvaluacionBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.EvaluacionBindingNavigatorSaveItem})
        Me.EvaluacionBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.EvaluacionBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.EvaluacionBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.EvaluacionBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.EvaluacionBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.EvaluacionBindingNavigator.Name = "EvaluacionBindingNavigator"
        Me.EvaluacionBindingNavigator.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.EvaluacionBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.EvaluacionBindingNavigator.Size = New System.Drawing.Size(489, 25)
        Me.EvaluacionBindingNavigator.TabIndex = 0
        Me.EvaluacionBindingNavigator.Text = "BindingNavigator1"
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
        'EvaluacionBindingNavigatorSaveItem
        '
        Me.EvaluacionBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.EvaluacionBindingNavigatorSaveItem.Image = CType(resources.GetObject("EvaluacionBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.EvaluacionBindingNavigatorSaveItem.Name = "EvaluacionBindingNavigatorSaveItem"
        Me.EvaluacionBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.EvaluacionBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'IdEvaluacionLabel
        '
        IdEvaluacionLabel.AutoSize = True
        IdEvaluacionLabel.Location = New System.Drawing.Point(83, 96)
        IdEvaluacionLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        IdEvaluacionLabel.Name = "IdEvaluacionLabel"
        IdEvaluacionLabel.Size = New System.Drawing.Size(122, 20)
        IdEvaluacionLabel.TabIndex = 1
        IdEvaluacionLabel.Text = "Id Evaluacion:"
        '
        'IdEvaluacionTextBox
        '
        Me.IdEvaluacionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EvaluacionBindingSource, "IdEvaluacion", True))
        Me.IdEvaluacionTextBox.Location = New System.Drawing.Point(258, 91)
        Me.IdEvaluacionTextBox.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.IdEvaluacionTextBox.Name = "IdEvaluacionTextBox"
        Me.IdEvaluacionTextBox.Size = New System.Drawing.Size(164, 26)
        Me.IdEvaluacionTextBox.TabIndex = 2
        '
        'PruebaLabel
        '
        PruebaLabel.AutoSize = True
        PruebaLabel.Location = New System.Drawing.Point(83, 136)
        PruebaLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        PruebaLabel.Name = "PruebaLabel"
        PruebaLabel.Size = New System.Drawing.Size(71, 20)
        PruebaLabel.TabIndex = 3
        PruebaLabel.Text = "Prueba:"
        '
        'PruebaTextBox
        '
        Me.PruebaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EvaluacionBindingSource, "Prueba", True))
        Me.PruebaTextBox.Location = New System.Drawing.Point(258, 131)
        Me.PruebaTextBox.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.PruebaTextBox.Name = "PruebaTextBox"
        Me.PruebaTextBox.Size = New System.Drawing.Size(164, 26)
        Me.PruebaTextBox.TabIndex = 4
        '
        'DescripcionLabel
        '
        DescripcionLabel.AutoSize = True
        DescripcionLabel.Location = New System.Drawing.Point(83, 176)
        DescripcionLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        DescripcionLabel.Name = "DescripcionLabel"
        DescripcionLabel.Size = New System.Drawing.Size(108, 20)
        DescripcionLabel.TabIndex = 5
        DescripcionLabel.Text = "Descripcion:"
        '
        'DescripcionTextBox
        '
        Me.DescripcionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EvaluacionBindingSource, "Descripcion", True))
        Me.DescripcionTextBox.Location = New System.Drawing.Point(258, 171)
        Me.DescripcionTextBox.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.DescripcionTextBox.Name = "DescripcionTextBox"
        Me.DescripcionTextBox.Size = New System.Drawing.Size(164, 26)
        Me.DescripcionTextBox.TabIndex = 6
        '
        'TiempoLimiteLabel
        '
        TiempoLimiteLabel.AutoSize = True
        TiempoLimiteLabel.Location = New System.Drawing.Point(83, 216)
        TiempoLimiteLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        TiempoLimiteLabel.Name = "TiempoLimiteLabel"
        TiempoLimiteLabel.Size = New System.Drawing.Size(125, 20)
        TiempoLimiteLabel.TabIndex = 7
        TiempoLimiteLabel.Text = "Tiempo Limite:"
        '
        'TiempoLimiteTextBox
        '
        Me.TiempoLimiteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EvaluacionBindingSource, "TiempoLimite", True))
        Me.TiempoLimiteTextBox.Location = New System.Drawing.Point(258, 211)
        Me.TiempoLimiteTextBox.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.TiempoLimiteTextBox.Name = "TiempoLimiteTextBox"
        Me.TiempoLimiteTextBox.Size = New System.Drawing.Size(164, 26)
        Me.TiempoLimiteTextBox.TabIndex = 8
        '
        'IdTipoEvaluacionLabel
        '
        IdTipoEvaluacionLabel.AutoSize = True
        IdTipoEvaluacionLabel.Location = New System.Drawing.Point(83, 256)
        IdTipoEvaluacionLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        IdTipoEvaluacionLabel.Name = "IdTipoEvaluacionLabel"
        IdTipoEvaluacionLabel.Size = New System.Drawing.Size(161, 20)
        IdTipoEvaluacionLabel.TabIndex = 9
        IdTipoEvaluacionLabel.Text = "Id Tipo Evaluacion:"
        '
        'IdTipoEvaluacionTextBox
        '
        Me.IdTipoEvaluacionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EvaluacionBindingSource, "IdTipoEvaluacion", True))
        Me.IdTipoEvaluacionTextBox.Location = New System.Drawing.Point(258, 251)
        Me.IdTipoEvaluacionTextBox.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.IdTipoEvaluacionTextBox.Name = "IdTipoEvaluacionTextBox"
        Me.IdTipoEvaluacionTextBox.Size = New System.Drawing.Size(164, 26)
        Me.IdTipoEvaluacionTextBox.TabIndex = 10
        '
        'Evaluacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(489, 361)
        Me.Controls.Add(IdEvaluacionLabel)
        Me.Controls.Add(Me.IdEvaluacionTextBox)
        Me.Controls.Add(PruebaLabel)
        Me.Controls.Add(Me.PruebaTextBox)
        Me.Controls.Add(DescripcionLabel)
        Me.Controls.Add(Me.DescripcionTextBox)
        Me.Controls.Add(TiempoLimiteLabel)
        Me.Controls.Add(Me.TiempoLimiteTextBox)
        Me.Controls.Add(IdTipoEvaluacionLabel)
        Me.Controls.Add(Me.IdTipoEvaluacionTextBox)
        Me.Controls.Add(Me.EvaluacionBindingNavigator)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Name = "Evaluacion"
        Me.Text = "Evaluacion"
        CType(Me.BD_ContratacionEmpleosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EvaluacionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EvaluacionBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EvaluacionBindingNavigator.ResumeLayout(False)
        Me.EvaluacionBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BD_ContratacionEmpleosDataSet As BD_ContratacionEmpleosDataSet
    Friend WithEvents EvaluacionBindingSource As BindingSource
    Friend WithEvents EvaluacionTableAdapter As BD_ContratacionEmpleosDataSetTableAdapters.EvaluacionTableAdapter
    Friend WithEvents TableAdapterManager As BD_ContratacionEmpleosDataSetTableAdapters.TableAdapterManager
    Friend WithEvents EvaluacionBindingNavigator As BindingNavigator
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
    Friend WithEvents EvaluacionBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents IdEvaluacionTextBox As TextBox
    Friend WithEvents PruebaTextBox As TextBox
    Friend WithEvents DescripcionTextBox As TextBox
    Friend WithEvents TiempoLimiteTextBox As TextBox
    Friend WithEvents IdTipoEvaluacionTextBox As TextBox
End Class
