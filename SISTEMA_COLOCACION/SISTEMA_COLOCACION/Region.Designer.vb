<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Region
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Region))
        Dim IdRegionLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Me.BD_ContratacionEmpleosDataSet = New SISTEMA_COLOCACION.BD_ContratacionEmpleosDataSet()
        Me.RegionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RegionTableAdapter = New SISTEMA_COLOCACION.BD_ContratacionEmpleosDataSetTableAdapters.RegionTableAdapter()
        Me.TableAdapterManager = New SISTEMA_COLOCACION.BD_ContratacionEmpleosDataSetTableAdapters.TableAdapterManager()
        Me.RegionBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.RegionBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IdRegionTextBox = New System.Windows.Forms.TextBox()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        IdRegionLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        CType(Me.BD_ContratacionEmpleosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RegionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RegionBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RegionBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'BD_ContratacionEmpleosDataSet
        '
        Me.BD_ContratacionEmpleosDataSet.DataSetName = "BD_ContratacionEmpleosDataSet"
        Me.BD_ContratacionEmpleosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RegionBindingSource
        '
        Me.RegionBindingSource.DataMember = "Region"
        Me.RegionBindingSource.DataSource = Me.BD_ContratacionEmpleosDataSet
        '
        'RegionTableAdapter
        '
        Me.RegionTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.RegionTableAdapter = Me.RegionTableAdapter
        Me.TableAdapterManager.RequerimientoTableAdapter = Nothing
        Me.TableAdapterManager.SoftwareTableAdapter = Nothing
        Me.TableAdapterManager.TipoEvaluacionTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SISTEMA_COLOCACION.BD_ContratacionEmpleosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'RegionBindingNavigator
        '
        Me.RegionBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.RegionBindingNavigator.BindingSource = Me.RegionBindingSource
        Me.RegionBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.RegionBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.RegionBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.RegionBindingNavigatorSaveItem})
        Me.RegionBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.RegionBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.RegionBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.RegionBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.RegionBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.RegionBindingNavigator.Name = "RegionBindingNavigator"
        Me.RegionBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.RegionBindingNavigator.Size = New System.Drawing.Size(389, 25)
        Me.RegionBindingNavigator.TabIndex = 0
        Me.RegionBindingNavigator.Text = "BindingNavigator1"
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
        'RegionBindingNavigatorSaveItem
        '
        Me.RegionBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.RegionBindingNavigatorSaveItem.Image = CType(resources.GetObject("RegionBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.RegionBindingNavigatorSaveItem.Name = "RegionBindingNavigatorSaveItem"
        Me.RegionBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.RegionBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'IdRegionLabel
        '
        IdRegionLabel.AutoSize = True
        IdRegionLabel.Location = New System.Drawing.Point(78, 82)
        IdRegionLabel.Name = "IdRegionLabel"
        IdRegionLabel.Size = New System.Drawing.Size(92, 20)
        IdRegionLabel.TabIndex = 1
        IdRegionLabel.Text = "Id Region:"
        '
        'IdRegionTextBox
        '
        Me.IdRegionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegionBindingSource, "IdRegion", True))
        Me.IdRegionTextBox.Location = New System.Drawing.Point(176, 79)
        Me.IdRegionTextBox.Name = "IdRegionTextBox"
        Me.IdRegionTextBox.Size = New System.Drawing.Size(73, 26)
        Me.IdRegionTextBox.TabIndex = 2
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(78, 114)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(76, 20)
        NombreLabel.TabIndex = 3
        NombreLabel.Text = "Nombre:"
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegionBindingSource, "Nombre", True))
        Me.NombreTextBox.Location = New System.Drawing.Point(176, 111)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(100, 26)
        Me.NombreTextBox.TabIndex = 4
        '
        'Region
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(389, 222)
        Me.Controls.Add(IdRegionLabel)
        Me.Controls.Add(Me.IdRegionTextBox)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(Me.NombreTextBox)
        Me.Controls.Add(Me.RegionBindingNavigator)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Name = "Region"
        Me.Text = "Region"
        CType(Me.BD_ContratacionEmpleosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RegionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RegionBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RegionBindingNavigator.ResumeLayout(False)
        Me.RegionBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BD_ContratacionEmpleosDataSet As BD_ContratacionEmpleosDataSet
    Friend WithEvents RegionBindingSource As BindingSource
    Friend WithEvents RegionTableAdapter As BD_ContratacionEmpleosDataSetTableAdapters.RegionTableAdapter
    Friend WithEvents TableAdapterManager As BD_ContratacionEmpleosDataSetTableAdapters.TableAdapterManager
    Friend WithEvents RegionBindingNavigator As BindingNavigator
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
    Friend WithEvents RegionBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents IdRegionTextBox As TextBox
    Friend WithEvents NombreTextBox As TextBox
End Class
