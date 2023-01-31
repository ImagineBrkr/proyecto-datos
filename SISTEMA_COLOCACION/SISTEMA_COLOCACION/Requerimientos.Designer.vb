<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Requerimientos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Requerimientos))
        Dim CodOfertaLabel As System.Windows.Forms.Label
        Dim CodRequerimientoLabel As System.Windows.Forms.Label
        Dim DescripcionLabel As System.Windows.Forms.Label
        Dim PrioridadLabel As System.Windows.Forms.Label
        Me.BD_ContratacionEmpleosDataSet = New SISTEMA_COLOCACION.BD_ContratacionEmpleosDataSet()
        Me.RequerimientoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RequerimientoTableAdapter = New SISTEMA_COLOCACION.BD_ContratacionEmpleosDataSetTableAdapters.RequerimientoTableAdapter()
        Me.TableAdapterManager = New SISTEMA_COLOCACION.BD_ContratacionEmpleosDataSetTableAdapters.TableAdapterManager()
        Me.RequerimientoBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.RequerimientoBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.CodOfertaTextBox = New System.Windows.Forms.TextBox()
        Me.CodRequerimientoTextBox = New System.Windows.Forms.TextBox()
        Me.DescripcionTextBox = New System.Windows.Forms.TextBox()
        Me.PrioridadTextBox = New System.Windows.Forms.TextBox()
        CodOfertaLabel = New System.Windows.Forms.Label()
        CodRequerimientoLabel = New System.Windows.Forms.Label()
        DescripcionLabel = New System.Windows.Forms.Label()
        PrioridadLabel = New System.Windows.Forms.Label()
        CType(Me.BD_ContratacionEmpleosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RequerimientoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RequerimientoBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RequerimientoBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'BD_ContratacionEmpleosDataSet
        '
        Me.BD_ContratacionEmpleosDataSet.DataSetName = "BD_ContratacionEmpleosDataSet"
        Me.BD_ContratacionEmpleosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RequerimientoBindingSource
        '
        Me.RequerimientoBindingSource.DataMember = "Requerimiento"
        Me.RequerimientoBindingSource.DataSource = Me.BD_ContratacionEmpleosDataSet
        '
        'RequerimientoTableAdapter
        '
        Me.RequerimientoTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.Oferta_EvaluacionTableAdapter = Nothing
        Me.TableAdapterManager.OfertaTableAdapter = Nothing
        Me.TableAdapterManager.Postulacion_PreseleccionTableAdapter = Nothing
        Me.TableAdapterManager.Postulacion_SeleccionTableAdapter = Nothing
        Me.TableAdapterManager.Postulante_EvaluacionTableAdapter = Nothing
        Me.TableAdapterManager.PostulanteTableAdapter = Nothing
        Me.TableAdapterManager.ReferenciasTableAdapter = Nothing
        Me.TableAdapterManager.RegionTableAdapter = Nothing
        Me.TableAdapterManager.RequerimientoTableAdapter = Me.RequerimientoTableAdapter
        Me.TableAdapterManager.SoftwareTableAdapter = Nothing
        Me.TableAdapterManager.TipoEvaluacionTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SISTEMA_COLOCACION.BD_ContratacionEmpleosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'RequerimientoBindingNavigator
        '
        Me.RequerimientoBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.RequerimientoBindingNavigator.BindingSource = Me.RequerimientoBindingSource
        Me.RequerimientoBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.RequerimientoBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.RequerimientoBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.RequerimientoBindingNavigatorSaveItem})
        Me.RequerimientoBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.RequerimientoBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.RequerimientoBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.RequerimientoBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.RequerimientoBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.RequerimientoBindingNavigator.Name = "RequerimientoBindingNavigator"
        Me.RequerimientoBindingNavigator.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.RequerimientoBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.RequerimientoBindingNavigator.Size = New System.Drawing.Size(790, 25)
        Me.RequerimientoBindingNavigator.TabIndex = 0
        Me.RequerimientoBindingNavigator.Text = "BindingNavigator1"
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
        'RequerimientoBindingNavigatorSaveItem
        '
        Me.RequerimientoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.RequerimientoBindingNavigatorSaveItem.Image = CType(resources.GetObject("RequerimientoBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.RequerimientoBindingNavigatorSaveItem.Name = "RequerimientoBindingNavigatorSaveItem"
        Me.RequerimientoBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.RequerimientoBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'CodOfertaLabel
        '
        CodOfertaLabel.AutoSize = True
        CodOfertaLabel.Location = New System.Drawing.Point(69, 98)
        CodOfertaLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        CodOfertaLabel.Name = "CodOfertaLabel"
        CodOfertaLabel.Size = New System.Drawing.Size(102, 20)
        CodOfertaLabel.TabIndex = 1
        CodOfertaLabel.Text = "Cod Oferta:"
        '
        'CodOfertaTextBox
        '
        Me.CodOfertaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RequerimientoBindingSource, "CodOferta", True))
        Me.CodOfertaTextBox.Location = New System.Drawing.Point(245, 93)
        Me.CodOfertaTextBox.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.CodOfertaTextBox.Name = "CodOfertaTextBox"
        Me.CodOfertaTextBox.Size = New System.Drawing.Size(84, 26)
        Me.CodOfertaTextBox.TabIndex = 2
        '
        'CodRequerimientoLabel
        '
        CodRequerimientoLabel.AutoSize = True
        CodRequerimientoLabel.Location = New System.Drawing.Point(69, 138)
        CodRequerimientoLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        CodRequerimientoLabel.Name = "CodRequerimientoLabel"
        CodRequerimientoLabel.Size = New System.Drawing.Size(168, 20)
        CodRequerimientoLabel.TabIndex = 3
        CodRequerimientoLabel.Text = "Cod Requerimiento:"
        '
        'CodRequerimientoTextBox
        '
        Me.CodRequerimientoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RequerimientoBindingSource, "CodRequerimiento", True))
        Me.CodRequerimientoTextBox.Location = New System.Drawing.Point(245, 133)
        Me.CodRequerimientoTextBox.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.CodRequerimientoTextBox.Name = "CodRequerimientoTextBox"
        Me.CodRequerimientoTextBox.Size = New System.Drawing.Size(84, 26)
        Me.CodRequerimientoTextBox.TabIndex = 4
        '
        'DescripcionLabel
        '
        DescripcionLabel.AutoSize = True
        DescripcionLabel.Location = New System.Drawing.Point(69, 178)
        DescripcionLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        DescripcionLabel.Name = "DescripcionLabel"
        DescripcionLabel.Size = New System.Drawing.Size(108, 20)
        DescripcionLabel.TabIndex = 5
        DescripcionLabel.Text = "Descripcion:"
        '
        'DescripcionTextBox
        '
        Me.DescripcionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RequerimientoBindingSource, "Descripcion", True))
        Me.DescripcionTextBox.Location = New System.Drawing.Point(245, 173)
        Me.DescripcionTextBox.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.DescripcionTextBox.Name = "DescripcionTextBox"
        Me.DescripcionTextBox.Size = New System.Drawing.Size(493, 26)
        Me.DescripcionTextBox.TabIndex = 6
        '
        'PrioridadLabel
        '
        PrioridadLabel.AutoSize = True
        PrioridadLabel.Location = New System.Drawing.Point(69, 218)
        PrioridadLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        PrioridadLabel.Name = "PrioridadLabel"
        PrioridadLabel.Size = New System.Drawing.Size(85, 20)
        PrioridadLabel.TabIndex = 7
        PrioridadLabel.Text = "Prioridad:"
        '
        'PrioridadTextBox
        '
        Me.PrioridadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RequerimientoBindingSource, "Prioridad", True))
        Me.PrioridadTextBox.Location = New System.Drawing.Point(245, 213)
        Me.PrioridadTextBox.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.PrioridadTextBox.Name = "PrioridadTextBox"
        Me.PrioridadTextBox.Size = New System.Drawing.Size(164, 26)
        Me.PrioridadTextBox.TabIndex = 8
        '
        'Requerimientos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(790, 289)
        Me.Controls.Add(CodOfertaLabel)
        Me.Controls.Add(Me.CodOfertaTextBox)
        Me.Controls.Add(CodRequerimientoLabel)
        Me.Controls.Add(Me.CodRequerimientoTextBox)
        Me.Controls.Add(DescripcionLabel)
        Me.Controls.Add(Me.DescripcionTextBox)
        Me.Controls.Add(PrioridadLabel)
        Me.Controls.Add(Me.PrioridadTextBox)
        Me.Controls.Add(Me.RequerimientoBindingNavigator)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Name = "Requerimientos"
        Me.Text = "Requerimientos"
        CType(Me.BD_ContratacionEmpleosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RequerimientoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RequerimientoBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RequerimientoBindingNavigator.ResumeLayout(False)
        Me.RequerimientoBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BD_ContratacionEmpleosDataSet As BD_ContratacionEmpleosDataSet
    Friend WithEvents RequerimientoBindingSource As BindingSource
    Friend WithEvents RequerimientoTableAdapter As BD_ContratacionEmpleosDataSetTableAdapters.RequerimientoTableAdapter
    Friend WithEvents TableAdapterManager As BD_ContratacionEmpleosDataSetTableAdapters.TableAdapterManager
    Friend WithEvents RequerimientoBindingNavigator As BindingNavigator
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
    Friend WithEvents RequerimientoBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents CodOfertaTextBox As TextBox
    Friend WithEvents CodRequerimientoTextBox As TextBox
    Friend WithEvents DescripcionTextBox As TextBox
    Friend WithEvents PrioridadTextBox As TextBox
End Class
