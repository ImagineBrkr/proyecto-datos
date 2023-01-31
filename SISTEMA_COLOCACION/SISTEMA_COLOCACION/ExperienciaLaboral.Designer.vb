<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExperienciaLaboral
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ExperienciaLaboral))
        Dim IdPostulanteLabel As System.Windows.Forms.Label
        Dim CodExperienciaLabel As System.Windows.Forms.Label
        Dim EmpresaLabel As System.Windows.Forms.Label
        Dim PuestoLabel As System.Windows.Forms.Label
        Dim FechaInicioLabel As System.Windows.Forms.Label
        Dim AlPresenteLabel As System.Windows.Forms.Label
        Dim FechaFinLabel As System.Windows.Forms.Label
        Dim PersonasACargoLabel As System.Windows.Forms.Label
        Dim SalarioLabel As System.Windows.Forms.Label
        Dim IdAreaLabel As System.Windows.Forms.Label
        Me.BD_ContratacionEmpleosDataSet = New SISTEMA_COLOCACION.BD_ContratacionEmpleosDataSet()
        Me.ExperienciaLaboralBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ExperienciaLaboralTableAdapter = New SISTEMA_COLOCACION.BD_ContratacionEmpleosDataSetTableAdapters.ExperienciaLaboralTableAdapter()
        Me.TableAdapterManager = New SISTEMA_COLOCACION.BD_ContratacionEmpleosDataSetTableAdapters.TableAdapterManager()
        Me.ExperienciaLaboralBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.ExperienciaLaboralBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IdPostulanteTextBox = New System.Windows.Forms.TextBox()
        Me.CodExperienciaTextBox = New System.Windows.Forms.TextBox()
        Me.EmpresaTextBox = New System.Windows.Forms.TextBox()
        Me.PuestoTextBox = New System.Windows.Forms.TextBox()
        Me.FechaInicioDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.AlPresenteTextBox = New System.Windows.Forms.TextBox()
        Me.FechaFinDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.PersonasACargoTextBox = New System.Windows.Forms.TextBox()
        Me.SalarioTextBox = New System.Windows.Forms.TextBox()
        Me.IdAreaTextBox = New System.Windows.Forms.TextBox()
        IdPostulanteLabel = New System.Windows.Forms.Label()
        CodExperienciaLabel = New System.Windows.Forms.Label()
        EmpresaLabel = New System.Windows.Forms.Label()
        PuestoLabel = New System.Windows.Forms.Label()
        FechaInicioLabel = New System.Windows.Forms.Label()
        AlPresenteLabel = New System.Windows.Forms.Label()
        FechaFinLabel = New System.Windows.Forms.Label()
        PersonasACargoLabel = New System.Windows.Forms.Label()
        SalarioLabel = New System.Windows.Forms.Label()
        IdAreaLabel = New System.Windows.Forms.Label()
        CType(Me.BD_ContratacionEmpleosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExperienciaLaboralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExperienciaLaboralBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ExperienciaLaboralBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'BD_ContratacionEmpleosDataSet
        '
        Me.BD_ContratacionEmpleosDataSet.DataSetName = "BD_ContratacionEmpleosDataSet"
        Me.BD_ContratacionEmpleosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ExperienciaLaboralBindingSource
        '
        Me.ExperienciaLaboralBindingSource.DataMember = "ExperienciaLaboral"
        Me.ExperienciaLaboralBindingSource.DataSource = Me.BD_ContratacionEmpleosDataSet
        '
        'ExperienciaLaboralTableAdapter
        '
        Me.ExperienciaLaboralTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.ExperienciaLaboralTableAdapter = Me.ExperienciaLaboralTableAdapter
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
        'ExperienciaLaboralBindingNavigator
        '
        Me.ExperienciaLaboralBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ExperienciaLaboralBindingNavigator.BindingSource = Me.ExperienciaLaboralBindingSource
        Me.ExperienciaLaboralBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ExperienciaLaboralBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ExperienciaLaboralBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ExperienciaLaboralBindingNavigatorSaveItem})
        Me.ExperienciaLaboralBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ExperienciaLaboralBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ExperienciaLaboralBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ExperienciaLaboralBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ExperienciaLaboralBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ExperienciaLaboralBindingNavigator.Name = "ExperienciaLaboralBindingNavigator"
        Me.ExperienciaLaboralBindingNavigator.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.ExperienciaLaboralBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ExperienciaLaboralBindingNavigator.Size = New System.Drawing.Size(1126, 25)
        Me.ExperienciaLaboralBindingNavigator.TabIndex = 0
        Me.ExperienciaLaboralBindingNavigator.Text = "BindingNavigator1"
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
        'ExperienciaLaboralBindingNavigatorSaveItem
        '
        Me.ExperienciaLaboralBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ExperienciaLaboralBindingNavigatorSaveItem.Image = CType(resources.GetObject("ExperienciaLaboralBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ExperienciaLaboralBindingNavigatorSaveItem.Name = "ExperienciaLaboralBindingNavigatorSaveItem"
        Me.ExperienciaLaboralBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.ExperienciaLaboralBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'IdPostulanteLabel
        '
        IdPostulanteLabel.AutoSize = True
        IdPostulanteLabel.Location = New System.Drawing.Point(76, 65)
        IdPostulanteLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        IdPostulanteLabel.Name = "IdPostulanteLabel"
        IdPostulanteLabel.Size = New System.Drawing.Size(121, 20)
        IdPostulanteLabel.TabIndex = 1
        IdPostulanteLabel.Text = "Id Postulante:"
        '
        'IdPostulanteTextBox
        '
        Me.IdPostulanteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ExperienciaLaboralBindingSource, "IdPostulante", True))
        Me.IdPostulanteTextBox.Location = New System.Drawing.Point(239, 60)
        Me.IdPostulanteTextBox.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.IdPostulanteTextBox.Name = "IdPostulanteTextBox"
        Me.IdPostulanteTextBox.Size = New System.Drawing.Size(89, 26)
        Me.IdPostulanteTextBox.TabIndex = 2
        '
        'CodExperienciaLabel
        '
        CodExperienciaLabel.AutoSize = True
        CodExperienciaLabel.Location = New System.Drawing.Point(368, 63)
        CodExperienciaLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        CodExperienciaLabel.Name = "CodExperienciaLabel"
        CodExperienciaLabel.Size = New System.Drawing.Size(144, 20)
        CodExperienciaLabel.TabIndex = 3
        CodExperienciaLabel.Text = "Cod Experiencia:"
        '
        'CodExperienciaTextBox
        '
        Me.CodExperienciaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ExperienciaLaboralBindingSource, "CodExperiencia", True))
        Me.CodExperienciaTextBox.Location = New System.Drawing.Point(531, 58)
        Me.CodExperienciaTextBox.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.CodExperienciaTextBox.Name = "CodExperienciaTextBox"
        Me.CodExperienciaTextBox.Size = New System.Drawing.Size(89, 26)
        Me.CodExperienciaTextBox.TabIndex = 4
        '
        'EmpresaLabel
        '
        EmpresaLabel.AutoSize = True
        EmpresaLabel.Location = New System.Drawing.Point(76, 120)
        EmpresaLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        EmpresaLabel.Name = "EmpresaLabel"
        EmpresaLabel.Size = New System.Drawing.Size(85, 20)
        EmpresaLabel.TabIndex = 5
        EmpresaLabel.Text = "Empresa:"
        '
        'EmpresaTextBox
        '
        Me.EmpresaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ExperienciaLaboralBindingSource, "Empresa", True))
        Me.EmpresaTextBox.Location = New System.Drawing.Point(239, 115)
        Me.EmpresaTextBox.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.EmpresaTextBox.Name = "EmpresaTextBox"
        Me.EmpresaTextBox.Size = New System.Drawing.Size(331, 26)
        Me.EmpresaTextBox.TabIndex = 6
        '
        'PuestoLabel
        '
        PuestoLabel.AutoSize = True
        PuestoLabel.Location = New System.Drawing.Point(603, 121)
        PuestoLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        PuestoLabel.Name = "PuestoLabel"
        PuestoLabel.Size = New System.Drawing.Size(70, 20)
        PuestoLabel.TabIndex = 7
        PuestoLabel.Text = "Puesto:"
        '
        'PuestoTextBox
        '
        Me.PuestoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ExperienciaLaboralBindingSource, "Puesto", True))
        Me.PuestoTextBox.Location = New System.Drawing.Point(766, 116)
        Me.PuestoTextBox.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.PuestoTextBox.Name = "PuestoTextBox"
        Me.PuestoTextBox.Size = New System.Drawing.Size(331, 26)
        Me.PuestoTextBox.TabIndex = 8
        '
        'FechaInicioLabel
        '
        FechaInicioLabel.AutoSize = True
        FechaInicioLabel.Location = New System.Drawing.Point(76, 170)
        FechaInicioLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        FechaInicioLabel.Name = "FechaInicioLabel"
        FechaInicioLabel.Size = New System.Drawing.Size(112, 20)
        FechaInicioLabel.TabIndex = 9
        FechaInicioLabel.Text = "Fecha Inicio:"
        '
        'FechaInicioDateTimePicker
        '
        Me.FechaInicioDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ExperienciaLaboralBindingSource, "FechaInicio", True))
        Me.FechaInicioDateTimePicker.Location = New System.Drawing.Point(239, 164)
        Me.FechaInicioDateTimePicker.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.FechaInicioDateTimePicker.Name = "FechaInicioDateTimePicker"
        Me.FechaInicioDateTimePicker.Size = New System.Drawing.Size(331, 26)
        Me.FechaInicioDateTimePicker.TabIndex = 10
        '
        'AlPresenteLabel
        '
        AlPresenteLabel.AutoSize = True
        AlPresenteLabel.Location = New System.Drawing.Point(76, 219)
        AlPresenteLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        AlPresenteLabel.Name = "AlPresenteLabel"
        AlPresenteLabel.Size = New System.Drawing.Size(107, 20)
        AlPresenteLabel.TabIndex = 11
        AlPresenteLabel.Text = "Al Presente:"
        '
        'AlPresenteTextBox
        '
        Me.AlPresenteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ExperienciaLaboralBindingSource, "AlPresente", True))
        Me.AlPresenteTextBox.Location = New System.Drawing.Point(239, 214)
        Me.AlPresenteTextBox.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.AlPresenteTextBox.Name = "AlPresenteTextBox"
        Me.AlPresenteTextBox.Size = New System.Drawing.Size(89, 26)
        Me.AlPresenteTextBox.TabIndex = 12
        '
        'FechaFinLabel
        '
        FechaFinLabel.AutoSize = True
        FechaFinLabel.Location = New System.Drawing.Point(603, 170)
        FechaFinLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        FechaFinLabel.Name = "FechaFinLabel"
        FechaFinLabel.Size = New System.Drawing.Size(94, 20)
        FechaFinLabel.TabIndex = 13
        FechaFinLabel.Text = "Fecha Fin:"
        '
        'FechaFinDateTimePicker
        '
        Me.FechaFinDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ExperienciaLaboralBindingSource, "FechaFin", True))
        Me.FechaFinDateTimePicker.Location = New System.Drawing.Point(766, 164)
        Me.FechaFinDateTimePicker.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.FechaFinDateTimePicker.Name = "FechaFinDateTimePicker"
        Me.FechaFinDateTimePicker.Size = New System.Drawing.Size(331, 26)
        Me.FechaFinDateTimePicker.TabIndex = 14
        '
        'PersonasACargoLabel
        '
        PersonasACargoLabel.AutoSize = True
        PersonasACargoLabel.Location = New System.Drawing.Point(368, 219)
        PersonasACargoLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        PersonasACargoLabel.Name = "PersonasACargoLabel"
        PersonasACargoLabel.Size = New System.Drawing.Size(159, 20)
        PersonasACargoLabel.TabIndex = 15
        PersonasACargoLabel.Text = "Personas A Cargo:"
        '
        'PersonasACargoTextBox
        '
        Me.PersonasACargoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ExperienciaLaboralBindingSource, "PersonasACargo", True))
        Me.PersonasACargoTextBox.Location = New System.Drawing.Point(531, 214)
        Me.PersonasACargoTextBox.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.PersonasACargoTextBox.Name = "PersonasACargoTextBox"
        Me.PersonasACargoTextBox.Size = New System.Drawing.Size(89, 26)
        Me.PersonasACargoTextBox.TabIndex = 16
        '
        'SalarioLabel
        '
        SalarioLabel.AutoSize = True
        SalarioLabel.Location = New System.Drawing.Point(76, 273)
        SalarioLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        SalarioLabel.Name = "SalarioLabel"
        SalarioLabel.Size = New System.Drawing.Size(70, 20)
        SalarioLabel.TabIndex = 17
        SalarioLabel.Text = "Salario:"
        '
        'SalarioTextBox
        '
        Me.SalarioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ExperienciaLaboralBindingSource, "Salario", True))
        Me.SalarioTextBox.Location = New System.Drawing.Point(239, 268)
        Me.SalarioTextBox.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.SalarioTextBox.Name = "SalarioTextBox"
        Me.SalarioTextBox.Size = New System.Drawing.Size(89, 26)
        Me.SalarioTextBox.TabIndex = 18
        '
        'IdAreaLabel
        '
        IdAreaLabel.AutoSize = True
        IdAreaLabel.Location = New System.Drawing.Point(664, 219)
        IdAreaLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        IdAreaLabel.Name = "IdAreaLabel"
        IdAreaLabel.Size = New System.Drawing.Size(73, 20)
        IdAreaLabel.TabIndex = 19
        IdAreaLabel.Text = "Id Area:"
        '
        'IdAreaTextBox
        '
        Me.IdAreaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ExperienciaLaboralBindingSource, "IdArea", True))
        Me.IdAreaTextBox.Location = New System.Drawing.Point(827, 213)
        Me.IdAreaTextBox.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.IdAreaTextBox.Name = "IdAreaTextBox"
        Me.IdAreaTextBox.Size = New System.Drawing.Size(145, 26)
        Me.IdAreaTextBox.TabIndex = 20
        '
        'ExperienciaLaboral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1126, 345)
        Me.Controls.Add(IdPostulanteLabel)
        Me.Controls.Add(Me.IdPostulanteTextBox)
        Me.Controls.Add(CodExperienciaLabel)
        Me.Controls.Add(Me.CodExperienciaTextBox)
        Me.Controls.Add(EmpresaLabel)
        Me.Controls.Add(Me.EmpresaTextBox)
        Me.Controls.Add(PuestoLabel)
        Me.Controls.Add(Me.PuestoTextBox)
        Me.Controls.Add(FechaInicioLabel)
        Me.Controls.Add(Me.FechaInicioDateTimePicker)
        Me.Controls.Add(AlPresenteLabel)
        Me.Controls.Add(Me.AlPresenteTextBox)
        Me.Controls.Add(FechaFinLabel)
        Me.Controls.Add(Me.FechaFinDateTimePicker)
        Me.Controls.Add(PersonasACargoLabel)
        Me.Controls.Add(Me.PersonasACargoTextBox)
        Me.Controls.Add(SalarioLabel)
        Me.Controls.Add(Me.SalarioTextBox)
        Me.Controls.Add(IdAreaLabel)
        Me.Controls.Add(Me.IdAreaTextBox)
        Me.Controls.Add(Me.ExperienciaLaboralBindingNavigator)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Name = "ExperienciaLaboral"
        Me.Text = "ExperienciaLaboral"
        CType(Me.BD_ContratacionEmpleosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExperienciaLaboralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExperienciaLaboralBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ExperienciaLaboralBindingNavigator.ResumeLayout(False)
        Me.ExperienciaLaboralBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BD_ContratacionEmpleosDataSet As BD_ContratacionEmpleosDataSet
    Friend WithEvents ExperienciaLaboralBindingSource As BindingSource
    Friend WithEvents ExperienciaLaboralTableAdapter As BD_ContratacionEmpleosDataSetTableAdapters.ExperienciaLaboralTableAdapter
    Friend WithEvents TableAdapterManager As BD_ContratacionEmpleosDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ExperienciaLaboralBindingNavigator As BindingNavigator
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
    Friend WithEvents ExperienciaLaboralBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents IdPostulanteTextBox As TextBox
    Friend WithEvents CodExperienciaTextBox As TextBox
    Friend WithEvents EmpresaTextBox As TextBox
    Friend WithEvents PuestoTextBox As TextBox
    Friend WithEvents FechaInicioDateTimePicker As DateTimePicker
    Friend WithEvents AlPresenteTextBox As TextBox
    Friend WithEvents FechaFinDateTimePicker As DateTimePicker
    Friend WithEvents PersonasACargoTextBox As TextBox
    Friend WithEvents SalarioTextBox As TextBox
    Friend WithEvents IdAreaTextBox As TextBox
End Class
