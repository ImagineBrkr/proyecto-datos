<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Softwares
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Softwares))
        Dim CodSoftwareLabel As System.Windows.Forms.Label
        Dim SoftwareLabel As System.Windows.Forms.Label
        Dim NivelLabel As System.Windows.Forms.Label
        Dim IdPostulanteLabel As System.Windows.Forms.Label
        Me.BD_ContratacionEmpleosDataSet = New SISTEMA_COLOCACION.BD_ContratacionEmpleosDataSet()
        Me.SoftwareBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SoftwareTableAdapter = New SISTEMA_COLOCACION.BD_ContratacionEmpleosDataSetTableAdapters.SoftwareTableAdapter()
        Me.TableAdapterManager = New SISTEMA_COLOCACION.BD_ContratacionEmpleosDataSetTableAdapters.TableAdapterManager()
        Me.SoftwareBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.SoftwareBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.CodSoftwareTextBox = New System.Windows.Forms.TextBox()
        Me.SoftwareTextBox = New System.Windows.Forms.TextBox()
        Me.NivelTextBox = New System.Windows.Forms.TextBox()
        Me.IdPostulanteTextBox = New System.Windows.Forms.TextBox()
        CodSoftwareLabel = New System.Windows.Forms.Label()
        SoftwareLabel = New System.Windows.Forms.Label()
        NivelLabel = New System.Windows.Forms.Label()
        IdPostulanteLabel = New System.Windows.Forms.Label()
        CType(Me.BD_ContratacionEmpleosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SoftwareBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SoftwareBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SoftwareBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'BD_ContratacionEmpleosDataSet
        '
        Me.BD_ContratacionEmpleosDataSet.DataSetName = "BD_ContratacionEmpleosDataSet"
        Me.BD_ContratacionEmpleosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SoftwareBindingSource
        '
        Me.SoftwareBindingSource.DataMember = "Software"
        Me.SoftwareBindingSource.DataSource = Me.BD_ContratacionEmpleosDataSet
        '
        'SoftwareTableAdapter
        '
        Me.SoftwareTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.RequerimientoTableAdapter = Nothing
        Me.TableAdapterManager.SoftwareTableAdapter = Me.SoftwareTableAdapter
        Me.TableAdapterManager.TipoEvaluacionTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SISTEMA_COLOCACION.BD_ContratacionEmpleosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SoftwareBindingNavigator
        '
        Me.SoftwareBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.SoftwareBindingNavigator.BindingSource = Me.SoftwareBindingSource
        Me.SoftwareBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.SoftwareBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.SoftwareBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.SoftwareBindingNavigatorSaveItem})
        Me.SoftwareBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.SoftwareBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.SoftwareBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.SoftwareBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.SoftwareBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.SoftwareBindingNavigator.Name = "SoftwareBindingNavigator"
        Me.SoftwareBindingNavigator.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.SoftwareBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.SoftwareBindingNavigator.Size = New System.Drawing.Size(459, 25)
        Me.SoftwareBindingNavigator.TabIndex = 0
        Me.SoftwareBindingNavigator.Text = "BindingNavigator1"
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
        'SoftwareBindingNavigatorSaveItem
        '
        Me.SoftwareBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SoftwareBindingNavigatorSaveItem.Image = CType(resources.GetObject("SoftwareBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.SoftwareBindingNavigatorSaveItem.Name = "SoftwareBindingNavigatorSaveItem"
        Me.SoftwareBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.SoftwareBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'CodSoftwareLabel
        '
        CodSoftwareLabel.AutoSize = True
        CodSoftwareLabel.Location = New System.Drawing.Point(72, 94)
        CodSoftwareLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        CodSoftwareLabel.Name = "CodSoftwareLabel"
        CodSoftwareLabel.Size = New System.Drawing.Size(123, 20)
        CodSoftwareLabel.TabIndex = 1
        CodSoftwareLabel.Text = "Cod Software:"
        '
        'CodSoftwareTextBox
        '
        Me.CodSoftwareTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SoftwareBindingSource, "CodSoftware", True))
        Me.CodSoftwareTextBox.Location = New System.Drawing.Point(205, 89)
        Me.CodSoftwareTextBox.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.CodSoftwareTextBox.Name = "CodSoftwareTextBox"
        Me.CodSoftwareTextBox.Size = New System.Drawing.Size(74, 26)
        Me.CodSoftwareTextBox.TabIndex = 2
        '
        'SoftwareLabel
        '
        SoftwareLabel.AutoSize = True
        SoftwareLabel.Location = New System.Drawing.Point(72, 134)
        SoftwareLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        SoftwareLabel.Name = "SoftwareLabel"
        SoftwareLabel.Size = New System.Drawing.Size(86, 20)
        SoftwareLabel.TabIndex = 3
        SoftwareLabel.Text = "Software:"
        '
        'SoftwareTextBox
        '
        Me.SoftwareTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SoftwareBindingSource, "Software", True))
        Me.SoftwareTextBox.Location = New System.Drawing.Point(205, 129)
        Me.SoftwareTextBox.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.SoftwareTextBox.Name = "SoftwareTextBox"
        Me.SoftwareTextBox.Size = New System.Drawing.Size(211, 26)
        Me.SoftwareTextBox.TabIndex = 4
        '
        'NivelLabel
        '
        NivelLabel.AutoSize = True
        NivelLabel.Location = New System.Drawing.Point(72, 174)
        NivelLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        NivelLabel.Name = "NivelLabel"
        NivelLabel.Size = New System.Drawing.Size(52, 20)
        NivelLabel.TabIndex = 5
        NivelLabel.Text = "Nivel:"
        '
        'NivelTextBox
        '
        Me.NivelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SoftwareBindingSource, "Nivel", True))
        Me.NivelTextBox.Location = New System.Drawing.Point(205, 169)
        Me.NivelTextBox.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.NivelTextBox.Name = "NivelTextBox"
        Me.NivelTextBox.Size = New System.Drawing.Size(211, 26)
        Me.NivelTextBox.TabIndex = 6
        '
        'IdPostulanteLabel
        '
        IdPostulanteLabel.AutoSize = True
        IdPostulanteLabel.Location = New System.Drawing.Point(72, 57)
        IdPostulanteLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        IdPostulanteLabel.Name = "IdPostulanteLabel"
        IdPostulanteLabel.Size = New System.Drawing.Size(121, 20)
        IdPostulanteLabel.TabIndex = 7
        IdPostulanteLabel.Text = "Id Postulante:"
        '
        'IdPostulanteTextBox
        '
        Me.IdPostulanteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SoftwareBindingSource, "IdPostulante", True))
        Me.IdPostulanteTextBox.Location = New System.Drawing.Point(205, 52)
        Me.IdPostulanteTextBox.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.IdPostulanteTextBox.Name = "IdPostulanteTextBox"
        Me.IdPostulanteTextBox.Size = New System.Drawing.Size(74, 26)
        Me.IdPostulanteTextBox.TabIndex = 8
        '
        'Softwares
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(459, 258)
        Me.Controls.Add(CodSoftwareLabel)
        Me.Controls.Add(Me.CodSoftwareTextBox)
        Me.Controls.Add(SoftwareLabel)
        Me.Controls.Add(Me.SoftwareTextBox)
        Me.Controls.Add(NivelLabel)
        Me.Controls.Add(Me.NivelTextBox)
        Me.Controls.Add(IdPostulanteLabel)
        Me.Controls.Add(Me.IdPostulanteTextBox)
        Me.Controls.Add(Me.SoftwareBindingNavigator)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Name = "Softwares"
        Me.Text = "Softwares"
        CType(Me.BD_ContratacionEmpleosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SoftwareBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SoftwareBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SoftwareBindingNavigator.ResumeLayout(False)
        Me.SoftwareBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BD_ContratacionEmpleosDataSet As BD_ContratacionEmpleosDataSet
    Friend WithEvents SoftwareBindingSource As BindingSource
    Friend WithEvents SoftwareTableAdapter As BD_ContratacionEmpleosDataSetTableAdapters.SoftwareTableAdapter
    Friend WithEvents TableAdapterManager As BD_ContratacionEmpleosDataSetTableAdapters.TableAdapterManager
    Friend WithEvents SoftwareBindingNavigator As BindingNavigator
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
    Friend WithEvents SoftwareBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents CodSoftwareTextBox As TextBox
    Friend WithEvents SoftwareTextBox As TextBox
    Friend WithEvents NivelTextBox As TextBox
    Friend WithEvents IdPostulanteTextBox As TextBox
End Class
