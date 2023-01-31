<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Beneficios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Beneficios))
        Dim CodOfertaLabel As System.Windows.Forms.Label
        Dim CodBeneficiosLabel As System.Windows.Forms.Label
        Dim DescripcionLabel As System.Windows.Forms.Label
        Me.BD_ContratacionEmpleosDataSet = New SISTEMA_COLOCACION.BD_ContratacionEmpleosDataSet()
        Me.BeneficiosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BeneficiosTableAdapter = New SISTEMA_COLOCACION.BD_ContratacionEmpleosDataSetTableAdapters.BeneficiosTableAdapter()
        Me.TableAdapterManager = New SISTEMA_COLOCACION.BD_ContratacionEmpleosDataSetTableAdapters.TableAdapterManager()
        Me.BeneficiosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.BeneficiosBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.CodOfertaTextBox = New System.Windows.Forms.TextBox()
        Me.CodBeneficiosTextBox = New System.Windows.Forms.TextBox()
        Me.DescripcionTextBox = New System.Windows.Forms.TextBox()
        CodOfertaLabel = New System.Windows.Forms.Label()
        CodBeneficiosLabel = New System.Windows.Forms.Label()
        DescripcionLabel = New System.Windows.Forms.Label()
        CType(Me.BD_ContratacionEmpleosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BeneficiosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BeneficiosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BeneficiosBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'BD_ContratacionEmpleosDataSet
        '
        Me.BD_ContratacionEmpleosDataSet.DataSetName = "BD_ContratacionEmpleosDataSet"
        Me.BD_ContratacionEmpleosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BeneficiosBindingSource
        '
        Me.BeneficiosBindingSource.DataMember = "Beneficios"
        Me.BeneficiosBindingSource.DataSource = Me.BD_ContratacionEmpleosDataSet
        '
        'BeneficiosTableAdapter
        '
        Me.BeneficiosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AreaTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BeneficiosTableAdapter = Me.BeneficiosTableAdapter
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
        'BeneficiosBindingNavigator
        '
        Me.BeneficiosBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BeneficiosBindingNavigator.BindingSource = Me.BeneficiosBindingSource
        Me.BeneficiosBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.BeneficiosBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BeneficiosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.BeneficiosBindingNavigatorSaveItem})
        Me.BeneficiosBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.BeneficiosBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BeneficiosBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BeneficiosBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BeneficiosBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BeneficiosBindingNavigator.Name = "BeneficiosBindingNavigator"
        Me.BeneficiosBindingNavigator.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.BeneficiosBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.BeneficiosBindingNavigator.Size = New System.Drawing.Size(789, 25)
        Me.BeneficiosBindingNavigator.TabIndex = 0
        Me.BeneficiosBindingNavigator.Text = "BindingNavigator1"
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
        'BeneficiosBindingNavigatorSaveItem
        '
        Me.BeneficiosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BeneficiosBindingNavigatorSaveItem.Image = CType(resources.GetObject("BeneficiosBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.BeneficiosBindingNavigatorSaveItem.Name = "BeneficiosBindingNavigatorSaveItem"
        Me.BeneficiosBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.BeneficiosBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'CodOfertaLabel
        '
        CodOfertaLabel.AutoSize = True
        CodOfertaLabel.Location = New System.Drawing.Point(45, 75)
        CodOfertaLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        CodOfertaLabel.Name = "CodOfertaLabel"
        CodOfertaLabel.Size = New System.Drawing.Size(102, 20)
        CodOfertaLabel.TabIndex = 1
        CodOfertaLabel.Text = "Cod Oferta:"
        '
        'CodOfertaTextBox
        '
        Me.CodOfertaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BeneficiosBindingSource, "CodOferta", True))
        Me.CodOfertaTextBox.Location = New System.Drawing.Point(190, 71)
        Me.CodOfertaTextBox.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.CodOfertaTextBox.Name = "CodOfertaTextBox"
        Me.CodOfertaTextBox.Size = New System.Drawing.Size(91, 26)
        Me.CodOfertaTextBox.TabIndex = 2
        '
        'CodBeneficiosLabel
        '
        CodBeneficiosLabel.AutoSize = True
        CodBeneficiosLabel.Location = New System.Drawing.Point(45, 115)
        CodBeneficiosLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        CodBeneficiosLabel.Name = "CodBeneficiosLabel"
        CodBeneficiosLabel.Size = New System.Drawing.Size(135, 20)
        CodBeneficiosLabel.TabIndex = 3
        CodBeneficiosLabel.Text = "Cod Beneficios:"
        '
        'CodBeneficiosTextBox
        '
        Me.CodBeneficiosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BeneficiosBindingSource, "CodBeneficios", True))
        Me.CodBeneficiosTextBox.Location = New System.Drawing.Point(190, 111)
        Me.CodBeneficiosTextBox.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.CodBeneficiosTextBox.Name = "CodBeneficiosTextBox"
        Me.CodBeneficiosTextBox.Size = New System.Drawing.Size(91, 26)
        Me.CodBeneficiosTextBox.TabIndex = 4
        '
        'DescripcionLabel
        '
        DescripcionLabel.AutoSize = True
        DescripcionLabel.Location = New System.Drawing.Point(45, 155)
        DescripcionLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        DescripcionLabel.Name = "DescripcionLabel"
        DescripcionLabel.Size = New System.Drawing.Size(108, 20)
        DescripcionLabel.TabIndex = 5
        DescripcionLabel.Text = "Descripcion:"
        '
        'DescripcionTextBox
        '
        Me.DescripcionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BeneficiosBindingSource, "Descripcion", True))
        Me.DescripcionTextBox.Location = New System.Drawing.Point(190, 151)
        Me.DescripcionTextBox.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.DescripcionTextBox.Name = "DescripcionTextBox"
        Me.DescripcionTextBox.Size = New System.Drawing.Size(565, 26)
        Me.DescripcionTextBox.TabIndex = 6
        '
        'Beneficios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(789, 230)
        Me.Controls.Add(CodOfertaLabel)
        Me.Controls.Add(Me.CodOfertaTextBox)
        Me.Controls.Add(CodBeneficiosLabel)
        Me.Controls.Add(Me.CodBeneficiosTextBox)
        Me.Controls.Add(DescripcionLabel)
        Me.Controls.Add(Me.DescripcionTextBox)
        Me.Controls.Add(Me.BeneficiosBindingNavigator)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Name = "Beneficios"
        Me.Text = "Beneficios"
        CType(Me.BD_ContratacionEmpleosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BeneficiosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BeneficiosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BeneficiosBindingNavigator.ResumeLayout(False)
        Me.BeneficiosBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BD_ContratacionEmpleosDataSet As BD_ContratacionEmpleosDataSet
    Friend WithEvents BeneficiosBindingSource As BindingSource
    Friend WithEvents BeneficiosTableAdapter As BD_ContratacionEmpleosDataSetTableAdapters.BeneficiosTableAdapter
    Friend WithEvents TableAdapterManager As BD_ContratacionEmpleosDataSetTableAdapters.TableAdapterManager
    Friend WithEvents BeneficiosBindingNavigator As BindingNavigator
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
    Friend WithEvents BeneficiosBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents CodOfertaTextBox As TextBox
    Friend WithEvents CodBeneficiosTextBox As TextBox
    Friend WithEvents DescripcionTextBox As TextBox
End Class
