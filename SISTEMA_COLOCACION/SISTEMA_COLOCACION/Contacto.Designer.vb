<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Contacto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Contacto))
        Dim DNIContactoLabel As System.Windows.Forms.Label
        Dim NombresLabel As System.Windows.Forms.Label
        Dim ApellidosLabel As System.Windows.Forms.Label
        Dim CargoLabel As System.Windows.Forms.Label
        Dim TelefonoLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Me.BD_ContratacionEmpleosDataSet = New SISTEMA_COLOCACION.BD_ContratacionEmpleosDataSet()
        Me.ContactoEmpresaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ContactoEmpresaTableAdapter = New SISTEMA_COLOCACION.BD_ContratacionEmpleosDataSetTableAdapters.ContactoEmpresaTableAdapter()
        Me.TableAdapterManager = New SISTEMA_COLOCACION.BD_ContratacionEmpleosDataSetTableAdapters.TableAdapterManager()
        Me.ContactoEmpresaBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.ContactoEmpresaBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.DNIContactoTextBox = New System.Windows.Forms.TextBox()
        Me.NombresTextBox = New System.Windows.Forms.TextBox()
        Me.ApellidosTextBox = New System.Windows.Forms.TextBox()
        Me.CargoTextBox = New System.Windows.Forms.TextBox()
        Me.TelefonoTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        DNIContactoLabel = New System.Windows.Forms.Label()
        NombresLabel = New System.Windows.Forms.Label()
        ApellidosLabel = New System.Windows.Forms.Label()
        CargoLabel = New System.Windows.Forms.Label()
        TelefonoLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        CType(Me.BD_ContratacionEmpleosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContactoEmpresaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContactoEmpresaBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContactoEmpresaBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'BD_ContratacionEmpleosDataSet
        '
        Me.BD_ContratacionEmpleosDataSet.DataSetName = "BD_ContratacionEmpleosDataSet"
        Me.BD_ContratacionEmpleosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ContactoEmpresaBindingSource
        '
        Me.ContactoEmpresaBindingSource.DataMember = "ContactoEmpresa"
        Me.ContactoEmpresaBindingSource.DataSource = Me.BD_ContratacionEmpleosDataSet
        '
        'ContactoEmpresaTableAdapter
        '
        Me.ContactoEmpresaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AreaTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BeneficiosTableAdapter = Nothing
        Me.TableAdapterManager.ContactoEmpresaTableAdapter = Me.ContactoEmpresaTableAdapter
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
        'ContactoEmpresaBindingNavigator
        '
        Me.ContactoEmpresaBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ContactoEmpresaBindingNavigator.BindingSource = Me.ContactoEmpresaBindingSource
        Me.ContactoEmpresaBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ContactoEmpresaBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ContactoEmpresaBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ContactoEmpresaBindingNavigatorSaveItem})
        Me.ContactoEmpresaBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ContactoEmpresaBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ContactoEmpresaBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ContactoEmpresaBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ContactoEmpresaBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ContactoEmpresaBindingNavigator.Name = "ContactoEmpresaBindingNavigator"
        Me.ContactoEmpresaBindingNavigator.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.ContactoEmpresaBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ContactoEmpresaBindingNavigator.Size = New System.Drawing.Size(461, 25)
        Me.ContactoEmpresaBindingNavigator.TabIndex = 0
        Me.ContactoEmpresaBindingNavigator.Text = "BindingNavigator1"
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
        'ContactoEmpresaBindingNavigatorSaveItem
        '
        Me.ContactoEmpresaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ContactoEmpresaBindingNavigatorSaveItem.Image = CType(resources.GetObject("ContactoEmpresaBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ContactoEmpresaBindingNavigatorSaveItem.Name = "ContactoEmpresaBindingNavigatorSaveItem"
        Me.ContactoEmpresaBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.ContactoEmpresaBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'DNIContactoLabel
        '
        DNIContactoLabel.AutoSize = True
        DNIContactoLabel.Location = New System.Drawing.Point(81, 80)
        DNIContactoLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        DNIContactoLabel.Name = "DNIContactoLabel"
        DNIContactoLabel.Size = New System.Drawing.Size(118, 20)
        DNIContactoLabel.TabIndex = 1
        DNIContactoLabel.Text = "DNIContacto:"
        '
        'DNIContactoTextBox
        '
        Me.DNIContactoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContactoEmpresaBindingSource, "DNIContacto", True))
        Me.DNIContactoTextBox.Location = New System.Drawing.Point(211, 75)
        Me.DNIContactoTextBox.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.DNIContactoTextBox.Name = "DNIContactoTextBox"
        Me.DNIContactoTextBox.Size = New System.Drawing.Size(102, 26)
        Me.DNIContactoTextBox.TabIndex = 2
        '
        'NombresLabel
        '
        NombresLabel.AutoSize = True
        NombresLabel.Location = New System.Drawing.Point(81, 120)
        NombresLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        NombresLabel.Name = "NombresLabel"
        NombresLabel.Size = New System.Drawing.Size(85, 20)
        NombresLabel.TabIndex = 3
        NombresLabel.Text = "Nombres:"
        '
        'NombresTextBox
        '
        Me.NombresTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContactoEmpresaBindingSource, "Nombres", True))
        Me.NombresTextBox.Location = New System.Drawing.Point(211, 115)
        Me.NombresTextBox.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.NombresTextBox.Name = "NombresTextBox"
        Me.NombresTextBox.Size = New System.Drawing.Size(217, 26)
        Me.NombresTextBox.TabIndex = 4
        '
        'ApellidosLabel
        '
        ApellidosLabel.AutoSize = True
        ApellidosLabel.Location = New System.Drawing.Point(81, 160)
        ApellidosLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        ApellidosLabel.Name = "ApellidosLabel"
        ApellidosLabel.Size = New System.Drawing.Size(87, 20)
        ApellidosLabel.TabIndex = 5
        ApellidosLabel.Text = "Apellidos:"
        '
        'ApellidosTextBox
        '
        Me.ApellidosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContactoEmpresaBindingSource, "Apellidos", True))
        Me.ApellidosTextBox.Location = New System.Drawing.Point(211, 155)
        Me.ApellidosTextBox.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ApellidosTextBox.Name = "ApellidosTextBox"
        Me.ApellidosTextBox.Size = New System.Drawing.Size(217, 26)
        Me.ApellidosTextBox.TabIndex = 6
        '
        'CargoLabel
        '
        CargoLabel.AutoSize = True
        CargoLabel.Location = New System.Drawing.Point(81, 200)
        CargoLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        CargoLabel.Name = "CargoLabel"
        CargoLabel.Size = New System.Drawing.Size(62, 20)
        CargoLabel.TabIndex = 7
        CargoLabel.Text = "Cargo:"
        '
        'CargoTextBox
        '
        Me.CargoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContactoEmpresaBindingSource, "Cargo", True))
        Me.CargoTextBox.Location = New System.Drawing.Point(211, 195)
        Me.CargoTextBox.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.CargoTextBox.Name = "CargoTextBox"
        Me.CargoTextBox.Size = New System.Drawing.Size(217, 26)
        Me.CargoTextBox.TabIndex = 8
        '
        'TelefonoLabel
        '
        TelefonoLabel.AutoSize = True
        TelefonoLabel.Location = New System.Drawing.Point(81, 240)
        TelefonoLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        TelefonoLabel.Name = "TelefonoLabel"
        TelefonoLabel.Size = New System.Drawing.Size(84, 20)
        TelefonoLabel.TabIndex = 9
        TelefonoLabel.Text = "Telefono:"
        '
        'TelefonoTextBox
        '
        Me.TelefonoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContactoEmpresaBindingSource, "Telefono", True))
        Me.TelefonoTextBox.Location = New System.Drawing.Point(211, 235)
        Me.TelefonoTextBox.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.TelefonoTextBox.Name = "TelefonoTextBox"
        Me.TelefonoTextBox.Size = New System.Drawing.Size(128, 26)
        Me.TelefonoTextBox.TabIndex = 10
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(81, 280)
        EmailLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(58, 20)
        EmailLabel.TabIndex = 11
        EmailLabel.Text = "Email:"
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContactoEmpresaBindingSource, "Email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(211, 275)
        Me.EmailTextBox.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(217, 26)
        Me.EmailTextBox.TabIndex = 12
        '
        'Contacto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(461, 351)
        Me.Controls.Add(DNIContactoLabel)
        Me.Controls.Add(Me.DNIContactoTextBox)
        Me.Controls.Add(NombresLabel)
        Me.Controls.Add(Me.NombresTextBox)
        Me.Controls.Add(ApellidosLabel)
        Me.Controls.Add(Me.ApellidosTextBox)
        Me.Controls.Add(CargoLabel)
        Me.Controls.Add(Me.CargoTextBox)
        Me.Controls.Add(TelefonoLabel)
        Me.Controls.Add(Me.TelefonoTextBox)
        Me.Controls.Add(EmailLabel)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(Me.ContactoEmpresaBindingNavigator)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Name = "Contacto"
        Me.Text = "Contacto"
        CType(Me.BD_ContratacionEmpleosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContactoEmpresaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContactoEmpresaBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContactoEmpresaBindingNavigator.ResumeLayout(False)
        Me.ContactoEmpresaBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BD_ContratacionEmpleosDataSet As BD_ContratacionEmpleosDataSet
    Friend WithEvents ContactoEmpresaBindingSource As BindingSource
    Friend WithEvents ContactoEmpresaTableAdapter As BD_ContratacionEmpleosDataSetTableAdapters.ContactoEmpresaTableAdapter
    Friend WithEvents TableAdapterManager As BD_ContratacionEmpleosDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ContactoEmpresaBindingNavigator As BindingNavigator
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
    Friend WithEvents ContactoEmpresaBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents DNIContactoTextBox As TextBox
    Friend WithEvents NombresTextBox As TextBox
    Friend WithEvents ApellidosTextBox As TextBox
    Friend WithEvents CargoTextBox As TextBox
    Friend WithEvents TelefonoTextBox As TextBox
    Friend WithEvents EmailTextBox As TextBox
End Class
