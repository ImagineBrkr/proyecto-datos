<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Empresa
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Empresa))
        Dim DNIContactoLabel As System.Windows.Forms.Label
        Dim IdEmpresaLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim RubroLabel As System.Windows.Forms.Label
        Dim RUCLabel As System.Windows.Forms.Label
        Me.BD_ContratacionEmpleosDataSet = New SISTEMA_COLOCACION.BD_ContratacionEmpleosDataSet()
        Me.EmpresaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmpresaTableAdapter = New SISTEMA_COLOCACION.BD_ContratacionEmpleosDataSetTableAdapters.EmpresaTableAdapter()
        Me.TableAdapterManager = New SISTEMA_COLOCACION.BD_ContratacionEmpleosDataSetTableAdapters.TableAdapterManager()
        Me.EmpresaBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.EmpresaBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.DNIContactoTextBox = New System.Windows.Forms.TextBox()
        Me.IdEmpresaTextBox = New System.Windows.Forms.TextBox()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.RubroTextBox = New System.Windows.Forms.TextBox()
        Me.RUCTextBox = New System.Windows.Forms.TextBox()
        DNIContactoLabel = New System.Windows.Forms.Label()
        IdEmpresaLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        RubroLabel = New System.Windows.Forms.Label()
        RUCLabel = New System.Windows.Forms.Label()
        CType(Me.BD_ContratacionEmpleosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpresaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpresaBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EmpresaBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'BD_ContratacionEmpleosDataSet
        '
        Me.BD_ContratacionEmpleosDataSet.DataSetName = "BD_ContratacionEmpleosDataSet"
        Me.BD_ContratacionEmpleosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmpresaBindingSource
        '
        Me.EmpresaBindingSource.DataMember = "Empresa"
        Me.EmpresaBindingSource.DataSource = Me.BD_ContratacionEmpleosDataSet
        '
        'EmpresaTableAdapter
        '
        Me.EmpresaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AreaTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BeneficiosTableAdapter = Nothing
        Me.TableAdapterManager.ContactoEmpresaTableAdapter = Nothing
        Me.TableAdapterManager.Director_RRHHTableAdapter = Nothing
        Me.TableAdapterManager.EmpresaTableAdapter = Me.EmpresaTableAdapter
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
        'EmpresaBindingNavigator
        '
        Me.EmpresaBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.EmpresaBindingNavigator.BindingSource = Me.EmpresaBindingSource
        Me.EmpresaBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.EmpresaBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.EmpresaBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.EmpresaBindingNavigatorSaveItem})
        Me.EmpresaBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.EmpresaBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.EmpresaBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.EmpresaBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.EmpresaBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.EmpresaBindingNavigator.Name = "EmpresaBindingNavigator"
        Me.EmpresaBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.EmpresaBindingNavigator.Size = New System.Drawing.Size(450, 25)
        Me.EmpresaBindingNavigator.TabIndex = 0
        Me.EmpresaBindingNavigator.Text = "BindingNavigator1"
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
        'EmpresaBindingNavigatorSaveItem
        '
        Me.EmpresaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.EmpresaBindingNavigatorSaveItem.Image = CType(resources.GetObject("EmpresaBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.EmpresaBindingNavigatorSaveItem.Name = "EmpresaBindingNavigatorSaveItem"
        Me.EmpresaBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.EmpresaBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'DNIContactoLabel
        '
        DNIContactoLabel.AutoSize = True
        DNIContactoLabel.Location = New System.Drawing.Point(69, 75)
        DNIContactoLabel.Name = "DNIContactoLabel"
        DNIContactoLabel.Size = New System.Drawing.Size(118, 20)
        DNIContactoLabel.TabIndex = 1
        DNIContactoLabel.Text = "DNIContacto:"
        '
        'DNIContactoTextBox
        '
        Me.DNIContactoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresaBindingSource, "DNIContacto", True))
        Me.DNIContactoTextBox.Location = New System.Drawing.Point(193, 72)
        Me.DNIContactoTextBox.Name = "DNIContactoTextBox"
        Me.DNIContactoTextBox.Size = New System.Drawing.Size(100, 26)
        Me.DNIContactoTextBox.TabIndex = 2
        '
        'IdEmpresaLabel
        '
        IdEmpresaLabel.AutoSize = True
        IdEmpresaLabel.Location = New System.Drawing.Point(69, 107)
        IdEmpresaLabel.Name = "IdEmpresaLabel"
        IdEmpresaLabel.Size = New System.Drawing.Size(106, 20)
        IdEmpresaLabel.TabIndex = 3
        IdEmpresaLabel.Text = "Id Empresa:"
        '
        'IdEmpresaTextBox
        '
        Me.IdEmpresaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresaBindingSource, "IdEmpresa", True))
        Me.IdEmpresaTextBox.Location = New System.Drawing.Point(193, 104)
        Me.IdEmpresaTextBox.Name = "IdEmpresaTextBox"
        Me.IdEmpresaTextBox.Size = New System.Drawing.Size(69, 26)
        Me.IdEmpresaTextBox.TabIndex = 4
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(69, 139)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(76, 20)
        NombreLabel.TabIndex = 5
        NombreLabel.Text = "Nombre:"
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresaBindingSource, "Nombre", True))
        Me.NombreTextBox.Location = New System.Drawing.Point(193, 136)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(220, 26)
        Me.NombreTextBox.TabIndex = 6
        '
        'RubroLabel
        '
        RubroLabel.AutoSize = True
        RubroLabel.Location = New System.Drawing.Point(69, 171)
        RubroLabel.Name = "RubroLabel"
        RubroLabel.Size = New System.Drawing.Size(63, 20)
        RubroLabel.TabIndex = 7
        RubroLabel.Text = "Rubro:"
        '
        'RubroTextBox
        '
        Me.RubroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresaBindingSource, "Rubro", True))
        Me.RubroTextBox.Location = New System.Drawing.Point(193, 168)
        Me.RubroTextBox.Name = "RubroTextBox"
        Me.RubroTextBox.Size = New System.Drawing.Size(220, 26)
        Me.RubroTextBox.TabIndex = 8
        '
        'RUCLabel
        '
        RUCLabel.AutoSize = True
        RUCLabel.Location = New System.Drawing.Point(69, 203)
        RUCLabel.Name = "RUCLabel"
        RUCLabel.Size = New System.Drawing.Size(52, 20)
        RUCLabel.TabIndex = 9
        RUCLabel.Text = "RUC:"
        '
        'RUCTextBox
        '
        Me.RUCTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresaBindingSource, "RUC", True))
        Me.RUCTextBox.Location = New System.Drawing.Point(193, 200)
        Me.RUCTextBox.Name = "RUCTextBox"
        Me.RUCTextBox.Size = New System.Drawing.Size(138, 26)
        Me.RUCTextBox.TabIndex = 10
        '
        'Empresa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(450, 306)
        Me.Controls.Add(DNIContactoLabel)
        Me.Controls.Add(Me.DNIContactoTextBox)
        Me.Controls.Add(IdEmpresaLabel)
        Me.Controls.Add(Me.IdEmpresaTextBox)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(Me.NombreTextBox)
        Me.Controls.Add(RubroLabel)
        Me.Controls.Add(Me.RubroTextBox)
        Me.Controls.Add(RUCLabel)
        Me.Controls.Add(Me.RUCTextBox)
        Me.Controls.Add(Me.EmpresaBindingNavigator)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Name = "Empresa"
        Me.Text = "Empresa"
        CType(Me.BD_ContratacionEmpleosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpresaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpresaBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EmpresaBindingNavigator.ResumeLayout(False)
        Me.EmpresaBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BD_ContratacionEmpleosDataSet As BD_ContratacionEmpleosDataSet
    Friend WithEvents EmpresaBindingSource As BindingSource
    Friend WithEvents EmpresaTableAdapter As BD_ContratacionEmpleosDataSetTableAdapters.EmpresaTableAdapter
    Friend WithEvents TableAdapterManager As BD_ContratacionEmpleosDataSetTableAdapters.TableAdapterManager
    Friend WithEvents EmpresaBindingNavigator As BindingNavigator
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
    Friend WithEvents EmpresaBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents DNIContactoTextBox As TextBox
    Friend WithEvents IdEmpresaTextBox As TextBox
    Friend WithEvents NombreTextBox As TextBox
    Friend WithEvents RubroTextBox As TextBox
    Friend WithEvents RUCTextBox As TextBox
End Class
