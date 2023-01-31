<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Oferta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Oferta))
        Dim IdEmpresaLabel As System.Windows.Forms.Label
        Dim CodOfertaLabel As System.Windows.Forms.Label
        Dim DescripcionLabel As System.Windows.Forms.Label
        Dim FechaPublicacionLabel As System.Windows.Forms.Label
        Dim TipoHorarioLabel As System.Windows.Forms.Label
        Dim NivelLaboralLabel As System.Windows.Forms.Label
        Dim DisponibilidadViajarLabel As System.Windows.Forms.Label
        Dim MovilidadPropiaLabel As System.Windows.Forms.Label
        Dim DiscapacidadLabel As System.Windows.Forms.Label
        Dim IdRegionLabel As System.Windows.Forms.Label
        Dim IdAreaLabel As System.Windows.Forms.Label
        Dim FechaFinLabel As System.Windows.Forms.Label
        Dim LicenciaConducirLabel As System.Windows.Forms.Label
        Dim TipoLicenciaLabel As System.Windows.Forms.Label
        Me.BD_ContratacionEmpleosDataSet = New SISTEMA_COLOCACION.BD_ContratacionEmpleosDataSet()
        Me.OfertaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OfertaTableAdapter = New SISTEMA_COLOCACION.BD_ContratacionEmpleosDataSetTableAdapters.OfertaTableAdapter()
        Me.TableAdapterManager = New SISTEMA_COLOCACION.BD_ContratacionEmpleosDataSetTableAdapters.TableAdapterManager()
        Me.OfertaBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.OfertaBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IdEmpresaTextBox = New System.Windows.Forms.TextBox()
        Me.CodOfertaTextBox = New System.Windows.Forms.TextBox()
        Me.DescripcionTextBox = New System.Windows.Forms.TextBox()
        Me.FechaPublicacionDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.TipoHorarioTextBox = New System.Windows.Forms.TextBox()
        Me.NivelLaboralTextBox = New System.Windows.Forms.TextBox()
        Me.DisponibilidadViajarTextBox = New System.Windows.Forms.TextBox()
        Me.MovilidadPropiaTextBox = New System.Windows.Forms.TextBox()
        Me.DiscapacidadTextBox = New System.Windows.Forms.TextBox()
        Me.IdRegionTextBox = New System.Windows.Forms.TextBox()
        Me.IdAreaTextBox = New System.Windows.Forms.TextBox()
        Me.FechaFinDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.LicenciaConducirTextBox = New System.Windows.Forms.TextBox()
        Me.TipoLicenciaTextBox = New System.Windows.Forms.TextBox()
        IdEmpresaLabel = New System.Windows.Forms.Label()
        CodOfertaLabel = New System.Windows.Forms.Label()
        DescripcionLabel = New System.Windows.Forms.Label()
        FechaPublicacionLabel = New System.Windows.Forms.Label()
        TipoHorarioLabel = New System.Windows.Forms.Label()
        NivelLaboralLabel = New System.Windows.Forms.Label()
        DisponibilidadViajarLabel = New System.Windows.Forms.Label()
        MovilidadPropiaLabel = New System.Windows.Forms.Label()
        DiscapacidadLabel = New System.Windows.Forms.Label()
        IdRegionLabel = New System.Windows.Forms.Label()
        IdAreaLabel = New System.Windows.Forms.Label()
        FechaFinLabel = New System.Windows.Forms.Label()
        LicenciaConducirLabel = New System.Windows.Forms.Label()
        TipoLicenciaLabel = New System.Windows.Forms.Label()
        CType(Me.BD_ContratacionEmpleosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OfertaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OfertaBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.OfertaBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'BD_ContratacionEmpleosDataSet
        '
        Me.BD_ContratacionEmpleosDataSet.DataSetName = "BD_ContratacionEmpleosDataSet"
        Me.BD_ContratacionEmpleosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OfertaBindingSource
        '
        Me.OfertaBindingSource.DataMember = "Oferta"
        Me.OfertaBindingSource.DataSource = Me.BD_ContratacionEmpleosDataSet
        '
        'OfertaTableAdapter
        '
        Me.OfertaTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.OfertaTableAdapter = Me.OfertaTableAdapter
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
        'OfertaBindingNavigator
        '
        Me.OfertaBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.OfertaBindingNavigator.BindingSource = Me.OfertaBindingSource
        Me.OfertaBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.OfertaBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.OfertaBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.OfertaBindingNavigatorSaveItem})
        Me.OfertaBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.OfertaBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.OfertaBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.OfertaBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.OfertaBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.OfertaBindingNavigator.Name = "OfertaBindingNavigator"
        Me.OfertaBindingNavigator.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.OfertaBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.OfertaBindingNavigator.Size = New System.Drawing.Size(1143, 25)
        Me.OfertaBindingNavigator.TabIndex = 0
        Me.OfertaBindingNavigator.Text = "BindingNavigator1"
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
        'OfertaBindingNavigatorSaveItem
        '
        Me.OfertaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.OfertaBindingNavigatorSaveItem.Image = CType(resources.GetObject("OfertaBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.OfertaBindingNavigatorSaveItem.Name = "OfertaBindingNavigatorSaveItem"
        Me.OfertaBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.OfertaBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'IdEmpresaLabel
        '
        IdEmpresaLabel.AutoSize = True
        IdEmpresaLabel.Location = New System.Drawing.Point(48, 80)
        IdEmpresaLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        IdEmpresaLabel.Name = "IdEmpresaLabel"
        IdEmpresaLabel.Size = New System.Drawing.Size(106, 20)
        IdEmpresaLabel.TabIndex = 1
        IdEmpresaLabel.Text = "Id Empresa:"
        '
        'IdEmpresaTextBox
        '
        Me.IdEmpresaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OfertaBindingSource, "IdEmpresa", True))
        Me.IdEmpresaTextBox.Location = New System.Drawing.Point(231, 75)
        Me.IdEmpresaTextBox.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.IdEmpresaTextBox.Name = "IdEmpresaTextBox"
        Me.IdEmpresaTextBox.Size = New System.Drawing.Size(123, 26)
        Me.IdEmpresaTextBox.TabIndex = 2
        '
        'CodOfertaLabel
        '
        CodOfertaLabel.AutoSize = True
        CodOfertaLabel.Location = New System.Drawing.Point(384, 78)
        CodOfertaLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        CodOfertaLabel.Name = "CodOfertaLabel"
        CodOfertaLabel.Size = New System.Drawing.Size(102, 20)
        CodOfertaLabel.TabIndex = 3
        CodOfertaLabel.Text = "Cod Oferta:"
        AddHandler CodOfertaLabel.Click, AddressOf Me.CodOfertaLabel_Click
        '
        'CodOfertaTextBox
        '
        Me.CodOfertaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OfertaBindingSource, "CodOferta", True))
        Me.CodOfertaTextBox.Location = New System.Drawing.Point(567, 73)
        Me.CodOfertaTextBox.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.CodOfertaTextBox.Name = "CodOfertaTextBox"
        Me.CodOfertaTextBox.Size = New System.Drawing.Size(123, 26)
        Me.CodOfertaTextBox.TabIndex = 4
        '
        'DescripcionLabel
        '
        DescripcionLabel.AutoSize = True
        DescripcionLabel.Location = New System.Drawing.Point(48, 135)
        DescripcionLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        DescripcionLabel.Name = "DescripcionLabel"
        DescripcionLabel.Size = New System.Drawing.Size(108, 20)
        DescripcionLabel.TabIndex = 5
        DescripcionLabel.Text = "Descripcion:"
        '
        'DescripcionTextBox
        '
        Me.DescripcionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OfertaBindingSource, "Descripcion", True))
        Me.DescripcionTextBox.Location = New System.Drawing.Point(231, 130)
        Me.DescripcionTextBox.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.DescripcionTextBox.Name = "DescripcionTextBox"
        Me.DescripcionTextBox.Size = New System.Drawing.Size(331, 26)
        Me.DescripcionTextBox.TabIndex = 6
        '
        'FechaPublicacionLabel
        '
        FechaPublicacionLabel.AutoSize = True
        FechaPublicacionLabel.Location = New System.Drawing.Point(572, 133)
        FechaPublicacionLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        FechaPublicacionLabel.Name = "FechaPublicacionLabel"
        FechaPublicacionLabel.Size = New System.Drawing.Size(160, 20)
        FechaPublicacionLabel.TabIndex = 7
        FechaPublicacionLabel.Text = "Fecha Publicacion:"
        '
        'FechaPublicacionDateTimePicker
        '
        Me.FechaPublicacionDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.OfertaBindingSource, "FechaPublicacion", True))
        Me.FechaPublicacionDateTimePicker.Location = New System.Drawing.Point(755, 127)
        Me.FechaPublicacionDateTimePicker.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.FechaPublicacionDateTimePicker.Name = "FechaPublicacionDateTimePicker"
        Me.FechaPublicacionDateTimePicker.Size = New System.Drawing.Size(331, 26)
        Me.FechaPublicacionDateTimePicker.TabIndex = 8
        '
        'TipoHorarioLabel
        '
        TipoHorarioLabel.AutoSize = True
        TipoHorarioLabel.Location = New System.Drawing.Point(48, 185)
        TipoHorarioLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        TipoHorarioLabel.Name = "TipoHorarioLabel"
        TipoHorarioLabel.Size = New System.Drawing.Size(112, 20)
        TipoHorarioLabel.TabIndex = 9
        TipoHorarioLabel.Text = "Tipo Horario:"
        '
        'TipoHorarioTextBox
        '
        Me.TipoHorarioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OfertaBindingSource, "TipoHorario", True))
        Me.TipoHorarioTextBox.Location = New System.Drawing.Point(231, 180)
        Me.TipoHorarioTextBox.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.TipoHorarioTextBox.Name = "TipoHorarioTextBox"
        Me.TipoHorarioTextBox.Size = New System.Drawing.Size(209, 26)
        Me.TipoHorarioTextBox.TabIndex = 10
        '
        'NivelLaboralLabel
        '
        NivelLaboralLabel.AutoSize = True
        NivelLaboralLabel.Location = New System.Drawing.Point(572, 184)
        NivelLaboralLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        NivelLaboralLabel.Name = "NivelLaboralLabel"
        NivelLaboralLabel.Size = New System.Drawing.Size(117, 20)
        NivelLaboralLabel.TabIndex = 11
        NivelLaboralLabel.Text = "Nivel Laboral:"
        '
        'NivelLaboralTextBox
        '
        Me.NivelLaboralTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OfertaBindingSource, "NivelLaboral", True))
        Me.NivelLaboralTextBox.Location = New System.Drawing.Point(755, 179)
        Me.NivelLaboralTextBox.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.NivelLaboralTextBox.Name = "NivelLaboralTextBox"
        Me.NivelLaboralTextBox.Size = New System.Drawing.Size(331, 26)
        Me.NivelLaboralTextBox.TabIndex = 12
        '
        'DisponibilidadViajarLabel
        '
        DisponibilidadViajarLabel.AutoSize = True
        DisponibilidadViajarLabel.Location = New System.Drawing.Point(48, 239)
        DisponibilidadViajarLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        DisponibilidadViajarLabel.Name = "DisponibilidadViajarLabel"
        DisponibilidadViajarLabel.Size = New System.Drawing.Size(177, 20)
        DisponibilidadViajarLabel.TabIndex = 13
        DisponibilidadViajarLabel.Text = "Disponibilidad Viajar:"
        '
        'DisponibilidadViajarTextBox
        '
        Me.DisponibilidadViajarTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OfertaBindingSource, "DisponibilidadViajar", True))
        Me.DisponibilidadViajarTextBox.Location = New System.Drawing.Point(231, 235)
        Me.DisponibilidadViajarTextBox.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.DisponibilidadViajarTextBox.Name = "DisponibilidadViajarTextBox"
        Me.DisponibilidadViajarTextBox.Size = New System.Drawing.Size(81, 26)
        Me.DisponibilidadViajarTextBox.TabIndex = 14
        '
        'MovilidadPropiaLabel
        '
        MovilidadPropiaLabel.AutoSize = True
        MovilidadPropiaLabel.Location = New System.Drawing.Point(384, 240)
        MovilidadPropiaLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        MovilidadPropiaLabel.Name = "MovilidadPropiaLabel"
        MovilidadPropiaLabel.Size = New System.Drawing.Size(144, 20)
        MovilidadPropiaLabel.TabIndex = 15
        MovilidadPropiaLabel.Text = "Movilidad Propia:"
        '
        'MovilidadPropiaTextBox
        '
        Me.MovilidadPropiaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OfertaBindingSource, "MovilidadPropia", True))
        Me.MovilidadPropiaTextBox.Location = New System.Drawing.Point(567, 235)
        Me.MovilidadPropiaTextBox.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.MovilidadPropiaTextBox.Name = "MovilidadPropiaTextBox"
        Me.MovilidadPropiaTextBox.Size = New System.Drawing.Size(83, 26)
        Me.MovilidadPropiaTextBox.TabIndex = 16
        '
        'DiscapacidadLabel
        '
        DiscapacidadLabel.AutoSize = True
        DiscapacidadLabel.Location = New System.Drawing.Point(685, 240)
        DiscapacidadLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        DiscapacidadLabel.Name = "DiscapacidadLabel"
        DiscapacidadLabel.Size = New System.Drawing.Size(122, 20)
        DiscapacidadLabel.TabIndex = 17
        DiscapacidadLabel.Text = "Discapacidad:"
        '
        'DiscapacidadTextBox
        '
        Me.DiscapacidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OfertaBindingSource, "Discapacidad", True))
        Me.DiscapacidadTextBox.Location = New System.Drawing.Point(839, 236)
        Me.DiscapacidadTextBox.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.DiscapacidadTextBox.Name = "DiscapacidadTextBox"
        Me.DiscapacidadTextBox.Size = New System.Drawing.Size(106, 26)
        Me.DiscapacidadTextBox.TabIndex = 18
        '
        'IdRegionLabel
        '
        IdRegionLabel.AutoSize = True
        IdRegionLabel.Location = New System.Drawing.Point(50, 295)
        IdRegionLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        IdRegionLabel.Name = "IdRegionLabel"
        IdRegionLabel.Size = New System.Drawing.Size(92, 20)
        IdRegionLabel.TabIndex = 19
        IdRegionLabel.Text = "Id Region:"
        '
        'IdRegionTextBox
        '
        Me.IdRegionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OfertaBindingSource, "IdRegion", True))
        Me.IdRegionTextBox.Location = New System.Drawing.Point(233, 290)
        Me.IdRegionTextBox.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.IdRegionTextBox.Name = "IdRegionTextBox"
        Me.IdRegionTextBox.Size = New System.Drawing.Size(121, 26)
        Me.IdRegionTextBox.TabIndex = 20
        '
        'IdAreaLabel
        '
        IdAreaLabel.AutoSize = True
        IdAreaLabel.Location = New System.Drawing.Point(384, 296)
        IdAreaLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        IdAreaLabel.Name = "IdAreaLabel"
        IdAreaLabel.Size = New System.Drawing.Size(73, 20)
        IdAreaLabel.TabIndex = 21
        IdAreaLabel.Text = "Id Area:"
        '
        'IdAreaTextBox
        '
        Me.IdAreaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OfertaBindingSource, "IdArea", True))
        Me.IdAreaTextBox.Location = New System.Drawing.Point(567, 291)
        Me.IdAreaTextBox.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.IdAreaTextBox.Name = "IdAreaTextBox"
        Me.IdAreaTextBox.Size = New System.Drawing.Size(123, 26)
        Me.IdAreaTextBox.TabIndex = 22
        '
        'FechaFinLabel
        '
        FechaFinLabel.AutoSize = True
        FechaFinLabel.Location = New System.Drawing.Point(48, 361)
        FechaFinLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        FechaFinLabel.Name = "FechaFinLabel"
        FechaFinLabel.Size = New System.Drawing.Size(94, 20)
        FechaFinLabel.TabIndex = 23
        FechaFinLabel.Text = "Fecha Fin:"
        '
        'FechaFinDateTimePicker
        '
        Me.FechaFinDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.OfertaBindingSource, "FechaFin", True))
        Me.FechaFinDateTimePicker.Location = New System.Drawing.Point(231, 355)
        Me.FechaFinDateTimePicker.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.FechaFinDateTimePicker.Name = "FechaFinDateTimePicker"
        Me.FechaFinDateTimePicker.Size = New System.Drawing.Size(331, 26)
        Me.FechaFinDateTimePicker.TabIndex = 24
        '
        'LicenciaConducirLabel
        '
        LicenciaConducirLabel.AutoSize = True
        LicenciaConducirLabel.Location = New System.Drawing.Point(50, 421)
        LicenciaConducirLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        LicenciaConducirLabel.Name = "LicenciaConducirLabel"
        LicenciaConducirLabel.Size = New System.Drawing.Size(156, 20)
        LicenciaConducirLabel.TabIndex = 25
        LicenciaConducirLabel.Text = "Licencia Conducir:"
        '
        'LicenciaConducirTextBox
        '
        Me.LicenciaConducirTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OfertaBindingSource, "LicenciaConducir", True))
        Me.LicenciaConducirTextBox.Location = New System.Drawing.Point(233, 416)
        Me.LicenciaConducirTextBox.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.LicenciaConducirTextBox.Name = "LicenciaConducirTextBox"
        Me.LicenciaConducirTextBox.Size = New System.Drawing.Size(79, 26)
        Me.LicenciaConducirTextBox.TabIndex = 26
        '
        'TipoLicenciaLabel
        '
        TipoLicenciaLabel.AutoSize = True
        TipoLicenciaLabel.Location = New System.Drawing.Point(384, 422)
        TipoLicenciaLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        TipoLicenciaLabel.Name = "TipoLicenciaLabel"
        TipoLicenciaLabel.Size = New System.Drawing.Size(119, 20)
        TipoLicenciaLabel.TabIndex = 27
        TipoLicenciaLabel.Text = "Tipo Licencia:"
        '
        'TipoLicenciaTextBox
        '
        Me.TipoLicenciaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OfertaBindingSource, "TipoLicencia", True))
        Me.TipoLicenciaTextBox.Location = New System.Drawing.Point(567, 417)
        Me.TipoLicenciaTextBox.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.TipoLicenciaTextBox.Name = "TipoLicenciaTextBox"
        Me.TipoLicenciaTextBox.Size = New System.Drawing.Size(123, 26)
        Me.TipoLicenciaTextBox.TabIndex = 28
        '
        'Oferta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1143, 474)
        Me.Controls.Add(IdEmpresaLabel)
        Me.Controls.Add(Me.IdEmpresaTextBox)
        Me.Controls.Add(CodOfertaLabel)
        Me.Controls.Add(Me.CodOfertaTextBox)
        Me.Controls.Add(DescripcionLabel)
        Me.Controls.Add(Me.DescripcionTextBox)
        Me.Controls.Add(FechaPublicacionLabel)
        Me.Controls.Add(Me.FechaPublicacionDateTimePicker)
        Me.Controls.Add(TipoHorarioLabel)
        Me.Controls.Add(Me.TipoHorarioTextBox)
        Me.Controls.Add(NivelLaboralLabel)
        Me.Controls.Add(Me.NivelLaboralTextBox)
        Me.Controls.Add(DisponibilidadViajarLabel)
        Me.Controls.Add(Me.DisponibilidadViajarTextBox)
        Me.Controls.Add(MovilidadPropiaLabel)
        Me.Controls.Add(Me.MovilidadPropiaTextBox)
        Me.Controls.Add(DiscapacidadLabel)
        Me.Controls.Add(Me.DiscapacidadTextBox)
        Me.Controls.Add(IdRegionLabel)
        Me.Controls.Add(Me.IdRegionTextBox)
        Me.Controls.Add(IdAreaLabel)
        Me.Controls.Add(Me.IdAreaTextBox)
        Me.Controls.Add(FechaFinLabel)
        Me.Controls.Add(Me.FechaFinDateTimePicker)
        Me.Controls.Add(LicenciaConducirLabel)
        Me.Controls.Add(Me.LicenciaConducirTextBox)
        Me.Controls.Add(TipoLicenciaLabel)
        Me.Controls.Add(Me.TipoLicenciaTextBox)
        Me.Controls.Add(Me.OfertaBindingNavigator)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Name = "Oferta"
        Me.Text = "Oferta"
        CType(Me.BD_ContratacionEmpleosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OfertaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OfertaBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.OfertaBindingNavigator.ResumeLayout(False)
        Me.OfertaBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BD_ContratacionEmpleosDataSet As BD_ContratacionEmpleosDataSet
    Friend WithEvents OfertaBindingSource As BindingSource
    Friend WithEvents OfertaTableAdapter As BD_ContratacionEmpleosDataSetTableAdapters.OfertaTableAdapter
    Friend WithEvents TableAdapterManager As BD_ContratacionEmpleosDataSetTableAdapters.TableAdapterManager
    Friend WithEvents OfertaBindingNavigator As BindingNavigator
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
    Friend WithEvents OfertaBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents IdEmpresaTextBox As TextBox
    Friend WithEvents CodOfertaTextBox As TextBox
    Friend WithEvents DescripcionTextBox As TextBox
    Friend WithEvents FechaPublicacionDateTimePicker As DateTimePicker
    Friend WithEvents TipoHorarioTextBox As TextBox
    Friend WithEvents NivelLaboralTextBox As TextBox
    Friend WithEvents DisponibilidadViajarTextBox As TextBox
    Friend WithEvents MovilidadPropiaTextBox As TextBox
    Friend WithEvents DiscapacidadTextBox As TextBox
    Friend WithEvents IdRegionTextBox As TextBox
    Friend WithEvents IdAreaTextBox As TextBox
    Friend WithEvents FechaFinDateTimePicker As DateTimePicker
    Friend WithEvents LicenciaConducirTextBox As TextBox
    Friend WithEvents TipoLicenciaTextBox As TextBox
End Class
