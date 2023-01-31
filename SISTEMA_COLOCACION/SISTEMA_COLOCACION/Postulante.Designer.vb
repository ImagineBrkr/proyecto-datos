<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Postulante
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Postulante))
        Dim IdPostulanteLabel As System.Windows.Forms.Label
        Dim NombresLabel As System.Windows.Forms.Label
        Dim ApellidosLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim SexoLabel As System.Windows.Forms.Label
        Dim TelFijoLabel As System.Windows.Forms.Label
        Dim TelCelularLabel As System.Windows.Forms.Label
        Dim TipoDocumentoLabel As System.Windows.Forms.Label
        Dim NroDocumentoLabel As System.Windows.Forms.Label
        Dim FechaNacimientoLabel As System.Windows.Forms.Label
        Dim EstadoCivilLabel As System.Windows.Forms.Label
        Dim ProvinciaLabel As System.Windows.Forms.Label
        Dim DistritoLabel As System.Windows.Forms.Label
        Dim DireccionLabel As System.Windows.Forms.Label
        Dim MovilidadPropiaLabel As System.Windows.Forms.Label
        Dim DisponibilidadViajarLabel As System.Windows.Forms.Label
        Dim LicenciaConducirLabel As System.Windows.Forms.Label
        Dim DiscapacidadLabel As System.Windows.Forms.Label
        Dim IdRegionLabel As System.Windows.Forms.Label
        Dim TipoLicenciaLabel As System.Windows.Forms.Label
        Me.BD_ContratacionEmpleosDataSet = New SISTEMA_COLOCACION.BD_ContratacionEmpleosDataSet()
        Me.PostulanteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PostulanteTableAdapter = New SISTEMA_COLOCACION.BD_ContratacionEmpleosDataSetTableAdapters.PostulanteTableAdapter()
        Me.TableAdapterManager = New SISTEMA_COLOCACION.BD_ContratacionEmpleosDataSetTableAdapters.TableAdapterManager()
        Me.PostulanteBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.PostulanteBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IdPostulanteTextBox = New System.Windows.Forms.TextBox()
        Me.NombresTextBox = New System.Windows.Forms.TextBox()
        Me.ApellidosTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.SexoTextBox = New System.Windows.Forms.TextBox()
        Me.TelFijoTextBox = New System.Windows.Forms.TextBox()
        Me.TelCelularTextBox = New System.Windows.Forms.TextBox()
        Me.TipoDocumentoTextBox = New System.Windows.Forms.TextBox()
        Me.NroDocumentoTextBox = New System.Windows.Forms.TextBox()
        Me.FechaNacimientoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.EstadoCivilTextBox = New System.Windows.Forms.TextBox()
        Me.ProvinciaTextBox = New System.Windows.Forms.TextBox()
        Me.DistritoTextBox = New System.Windows.Forms.TextBox()
        Me.DireccionTextBox = New System.Windows.Forms.TextBox()
        Me.MovilidadPropiaTextBox = New System.Windows.Forms.TextBox()
        Me.DisponibilidadViajarTextBox = New System.Windows.Forms.TextBox()
        Me.LicenciaConducirTextBox = New System.Windows.Forms.TextBox()
        Me.DiscapacidadTextBox = New System.Windows.Forms.TextBox()
        Me.IdRegionTextBox = New System.Windows.Forms.TextBox()
        Me.TipoLicenciaTextBox = New System.Windows.Forms.TextBox()
        Me.ReferenciasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReferenciasTableAdapter = New SISTEMA_COLOCACION.BD_ContratacionEmpleosDataSetTableAdapters.ReferenciasTableAdapter()
        IdPostulanteLabel = New System.Windows.Forms.Label()
        NombresLabel = New System.Windows.Forms.Label()
        ApellidosLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        SexoLabel = New System.Windows.Forms.Label()
        TelFijoLabel = New System.Windows.Forms.Label()
        TelCelularLabel = New System.Windows.Forms.Label()
        TipoDocumentoLabel = New System.Windows.Forms.Label()
        NroDocumentoLabel = New System.Windows.Forms.Label()
        FechaNacimientoLabel = New System.Windows.Forms.Label()
        EstadoCivilLabel = New System.Windows.Forms.Label()
        ProvinciaLabel = New System.Windows.Forms.Label()
        DistritoLabel = New System.Windows.Forms.Label()
        DireccionLabel = New System.Windows.Forms.Label()
        MovilidadPropiaLabel = New System.Windows.Forms.Label()
        DisponibilidadViajarLabel = New System.Windows.Forms.Label()
        LicenciaConducirLabel = New System.Windows.Forms.Label()
        DiscapacidadLabel = New System.Windows.Forms.Label()
        IdRegionLabel = New System.Windows.Forms.Label()
        TipoLicenciaLabel = New System.Windows.Forms.Label()
        CType(Me.BD_ContratacionEmpleosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PostulanteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PostulanteBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PostulanteBindingNavigator.SuspendLayout()
        CType(Me.ReferenciasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BD_ContratacionEmpleosDataSet
        '
        Me.BD_ContratacionEmpleosDataSet.DataSetName = "BD_ContratacionEmpleosDataSet"
        Me.BD_ContratacionEmpleosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PostulanteBindingSource
        '
        Me.PostulanteBindingSource.DataMember = "Postulante"
        Me.PostulanteBindingSource.DataSource = Me.BD_ContratacionEmpleosDataSet
        '
        'PostulanteTableAdapter
        '
        Me.PostulanteTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.PostulanteTableAdapter = Me.PostulanteTableAdapter
        Me.TableAdapterManager.ReferenciasTableAdapter = Me.ReferenciasTableAdapter
        Me.TableAdapterManager.RegionTableAdapter = Nothing
        Me.TableAdapterManager.RequerimientoTableAdapter = Nothing
        Me.TableAdapterManager.SoftwareTableAdapter = Nothing
        Me.TableAdapterManager.TipoEvaluacionTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SISTEMA_COLOCACION.BD_ContratacionEmpleosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PostulanteBindingNavigator
        '
        Me.PostulanteBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PostulanteBindingNavigator.BindingSource = Me.PostulanteBindingSource
        Me.PostulanteBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PostulanteBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PostulanteBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PostulanteBindingNavigatorSaveItem})
        Me.PostulanteBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PostulanteBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PostulanteBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PostulanteBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PostulanteBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PostulanteBindingNavigator.Name = "PostulanteBindingNavigator"
        Me.PostulanteBindingNavigator.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.PostulanteBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PostulanteBindingNavigator.Size = New System.Drawing.Size(1063, 25)
        Me.PostulanteBindingNavigator.TabIndex = 0
        Me.PostulanteBindingNavigator.Text = "BindingNavigator1"
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
        'PostulanteBindingNavigatorSaveItem
        '
        Me.PostulanteBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PostulanteBindingNavigatorSaveItem.Image = CType(resources.GetObject("PostulanteBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PostulanteBindingNavigatorSaveItem.Name = "PostulanteBindingNavigatorSaveItem"
        Me.PostulanteBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.PostulanteBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'IdPostulanteLabel
        '
        IdPostulanteLabel.AutoSize = True
        IdPostulanteLabel.Location = New System.Drawing.Point(23, 77)
        IdPostulanteLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        IdPostulanteLabel.Name = "IdPostulanteLabel"
        IdPostulanteLabel.Size = New System.Drawing.Size(121, 20)
        IdPostulanteLabel.TabIndex = 1
        IdPostulanteLabel.Text = "Id Postulante:"
        '
        'IdPostulanteTextBox
        '
        Me.IdPostulanteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PostulanteBindingSource, "IdPostulante", True))
        Me.IdPostulanteTextBox.Location = New System.Drawing.Point(206, 73)
        Me.IdPostulanteTextBox.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.IdPostulanteTextBox.Name = "IdPostulanteTextBox"
        Me.IdPostulanteTextBox.Size = New System.Drawing.Size(75, 26)
        Me.IdPostulanteTextBox.TabIndex = 2
        '
        'NombresLabel
        '
        NombresLabel.AutoSize = True
        NombresLabel.Location = New System.Drawing.Point(23, 140)
        NombresLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        NombresLabel.Name = "NombresLabel"
        NombresLabel.Size = New System.Drawing.Size(85, 20)
        NombresLabel.TabIndex = 3
        NombresLabel.Text = "Nombres:"
        '
        'NombresTextBox
        '
        Me.NombresTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PostulanteBindingSource, "Nombres", True))
        Me.NombresTextBox.Location = New System.Drawing.Point(186, 136)
        Me.NombresTextBox.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.NombresTextBox.Name = "NombresTextBox"
        Me.NombresTextBox.Size = New System.Drawing.Size(331, 26)
        Me.NombresTextBox.TabIndex = 4
        '
        'ApellidosLabel
        '
        ApellidosLabel.AutoSize = True
        ApellidosLabel.Location = New System.Drawing.Point(549, 138)
        ApellidosLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        ApellidosLabel.Name = "ApellidosLabel"
        ApellidosLabel.Size = New System.Drawing.Size(87, 20)
        ApellidosLabel.TabIndex = 5
        ApellidosLabel.Text = "Apellidos:"
        '
        'ApellidosTextBox
        '
        Me.ApellidosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PostulanteBindingSource, "Apellidos", True))
        Me.ApellidosTextBox.Location = New System.Drawing.Point(691, 134)
        Me.ApellidosTextBox.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ApellidosTextBox.Name = "ApellidosTextBox"
        Me.ApellidosTextBox.Size = New System.Drawing.Size(331, 26)
        Me.ApellidosTextBox.TabIndex = 6
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(23, 188)
        EmailLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(58, 20)
        EmailLabel.TabIndex = 7
        EmailLabel.Text = "Email:"
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PostulanteBindingSource, "Email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(186, 185)
        Me.EmailTextBox.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(331, 26)
        Me.EmailTextBox.TabIndex = 8
        '
        'SexoLabel
        '
        SexoLabel.AutoSize = True
        SexoLabel.Location = New System.Drawing.Point(549, 191)
        SexoLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        SexoLabel.Name = "SexoLabel"
        SexoLabel.Size = New System.Drawing.Size(54, 20)
        SexoLabel.TabIndex = 9
        SexoLabel.Text = "Sexo:"
        '
        'SexoTextBox
        '
        Me.SexoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PostulanteBindingSource, "Sexo", True))
        Me.SexoTextBox.Location = New System.Drawing.Point(691, 188)
        Me.SexoTextBox.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.SexoTextBox.Name = "SexoTextBox"
        Me.SexoTextBox.Size = New System.Drawing.Size(167, 26)
        Me.SexoTextBox.TabIndex = 10
        '
        'TelFijoLabel
        '
        TelFijoLabel.AutoSize = True
        TelFijoLabel.Location = New System.Drawing.Point(23, 245)
        TelFijoLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        TelFijoLabel.Name = "TelFijoLabel"
        TelFijoLabel.Size = New System.Drawing.Size(72, 20)
        TelFijoLabel.TabIndex = 11
        TelFijoLabel.Text = "Tel Fijo:"
        '
        'TelFijoTextBox
        '
        Me.TelFijoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PostulanteBindingSource, "TelFijo", True))
        Me.TelFijoTextBox.Location = New System.Drawing.Point(186, 245)
        Me.TelFijoTextBox.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.TelFijoTextBox.Name = "TelFijoTextBox"
        Me.TelFijoTextBox.Size = New System.Drawing.Size(331, 26)
        Me.TelFijoTextBox.TabIndex = 12
        '
        'TelCelularLabel
        '
        TelCelularLabel.AutoSize = True
        TelCelularLabel.Location = New System.Drawing.Point(549, 245)
        TelCelularLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        TelCelularLabel.Name = "TelCelularLabel"
        TelCelularLabel.Size = New System.Drawing.Size(99, 20)
        TelCelularLabel.TabIndex = 13
        TelCelularLabel.Text = "Tel Celular:"
        '
        'TelCelularTextBox
        '
        Me.TelCelularTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PostulanteBindingSource, "TelCelular", True))
        Me.TelCelularTextBox.Location = New System.Drawing.Point(691, 245)
        Me.TelCelularTextBox.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.TelCelularTextBox.Name = "TelCelularTextBox"
        Me.TelCelularTextBox.Size = New System.Drawing.Size(331, 26)
        Me.TelCelularTextBox.TabIndex = 14
        '
        'TipoDocumentoLabel
        '
        TipoDocumentoLabel.AutoSize = True
        TipoDocumentoLabel.Location = New System.Drawing.Point(23, 303)
        TipoDocumentoLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        TipoDocumentoLabel.Name = "TipoDocumentoLabel"
        TipoDocumentoLabel.Size = New System.Drawing.Size(145, 20)
        TipoDocumentoLabel.TabIndex = 15
        TipoDocumentoLabel.Text = "Tipo Documento:"
        '
        'TipoDocumentoTextBox
        '
        Me.TipoDocumentoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PostulanteBindingSource, "TipoDocumento", True))
        Me.TipoDocumentoTextBox.Location = New System.Drawing.Point(186, 303)
        Me.TipoDocumentoTextBox.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.TipoDocumentoTextBox.Name = "TipoDocumentoTextBox"
        Me.TipoDocumentoTextBox.Size = New System.Drawing.Size(200, 26)
        Me.TipoDocumentoTextBox.TabIndex = 16
        '
        'NroDocumentoLabel
        '
        NroDocumentoLabel.AutoSize = True
        NroDocumentoLabel.Location = New System.Drawing.Point(549, 306)
        NroDocumentoLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        NroDocumentoLabel.Name = "NroDocumentoLabel"
        NroDocumentoLabel.Size = New System.Drawing.Size(139, 20)
        NroDocumentoLabel.TabIndex = 17
        NroDocumentoLabel.Text = "Nro Documento:"
        '
        'NroDocumentoTextBox
        '
        Me.NroDocumentoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PostulanteBindingSource, "NroDocumento", True))
        Me.NroDocumentoTextBox.Location = New System.Drawing.Point(691, 306)
        Me.NroDocumentoTextBox.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.NroDocumentoTextBox.Name = "NroDocumentoTextBox"
        Me.NroDocumentoTextBox.Size = New System.Drawing.Size(331, 26)
        Me.NroDocumentoTextBox.TabIndex = 18
        '
        'FechaNacimientoLabel
        '
        FechaNacimientoLabel.AutoSize = True
        FechaNacimientoLabel.Location = New System.Drawing.Point(23, 362)
        FechaNacimientoLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        FechaNacimientoLabel.Name = "FechaNacimientoLabel"
        FechaNacimientoLabel.Size = New System.Drawing.Size(158, 20)
        FechaNacimientoLabel.TabIndex = 19
        FechaNacimientoLabel.Text = "Fecha Nacimiento:"
        '
        'FechaNacimientoDateTimePicker
        '
        Me.FechaNacimientoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PostulanteBindingSource, "FechaNacimiento", True))
        Me.FechaNacimientoDateTimePicker.Location = New System.Drawing.Point(186, 357)
        Me.FechaNacimientoDateTimePicker.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.FechaNacimientoDateTimePicker.Name = "FechaNacimientoDateTimePicker"
        Me.FechaNacimientoDateTimePicker.Size = New System.Drawing.Size(331, 26)
        Me.FechaNacimientoDateTimePicker.TabIndex = 20
        '
        'EstadoCivilLabel
        '
        EstadoCivilLabel.AutoSize = True
        EstadoCivilLabel.Location = New System.Drawing.Point(549, 363)
        EstadoCivilLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        EstadoCivilLabel.Name = "EstadoCivilLabel"
        EstadoCivilLabel.Size = New System.Drawing.Size(108, 20)
        EstadoCivilLabel.TabIndex = 21
        EstadoCivilLabel.Text = "Estado Civil:"
        '
        'EstadoCivilTextBox
        '
        Me.EstadoCivilTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PostulanteBindingSource, "EstadoCivil", True))
        Me.EstadoCivilTextBox.Location = New System.Drawing.Point(691, 363)
        Me.EstadoCivilTextBox.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.EstadoCivilTextBox.Name = "EstadoCivilTextBox"
        Me.EstadoCivilTextBox.Size = New System.Drawing.Size(331, 26)
        Me.EstadoCivilTextBox.TabIndex = 22
        '
        'ProvinciaLabel
        '
        ProvinciaLabel.AutoSize = True
        ProvinciaLabel.Location = New System.Drawing.Point(23, 412)
        ProvinciaLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        ProvinciaLabel.Name = "ProvinciaLabel"
        ProvinciaLabel.Size = New System.Drawing.Size(86, 20)
        ProvinciaLabel.TabIndex = 23
        ProvinciaLabel.Text = "Provincia:"
        '
        'ProvinciaTextBox
        '
        Me.ProvinciaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PostulanteBindingSource, "Provincia", True))
        Me.ProvinciaTextBox.Location = New System.Drawing.Point(186, 412)
        Me.ProvinciaTextBox.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ProvinciaTextBox.Name = "ProvinciaTextBox"
        Me.ProvinciaTextBox.Size = New System.Drawing.Size(331, 26)
        Me.ProvinciaTextBox.TabIndex = 24
        '
        'DistritoLabel
        '
        DistritoLabel.AutoSize = True
        DistritoLabel.Location = New System.Drawing.Point(549, 415)
        DistritoLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        DistritoLabel.Name = "DistritoLabel"
        DistritoLabel.Size = New System.Drawing.Size(72, 20)
        DistritoLabel.TabIndex = 25
        DistritoLabel.Text = "Distrito:"
        '
        'DistritoTextBox
        '
        Me.DistritoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PostulanteBindingSource, "Distrito", True))
        Me.DistritoTextBox.Location = New System.Drawing.Point(691, 415)
        Me.DistritoTextBox.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.DistritoTextBox.Name = "DistritoTextBox"
        Me.DistritoTextBox.Size = New System.Drawing.Size(331, 26)
        Me.DistritoTextBox.TabIndex = 26
        '
        'DireccionLabel
        '
        DireccionLabel.AutoSize = True
        DireccionLabel.Location = New System.Drawing.Point(23, 467)
        DireccionLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        DireccionLabel.Name = "DireccionLabel"
        DireccionLabel.Size = New System.Drawing.Size(89, 20)
        DireccionLabel.TabIndex = 27
        DireccionLabel.Text = "Direccion:"
        '
        'DireccionTextBox
        '
        Me.DireccionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PostulanteBindingSource, "Direccion", True))
        Me.DireccionTextBox.Location = New System.Drawing.Point(186, 467)
        Me.DireccionTextBox.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.DireccionTextBox.Name = "DireccionTextBox"
        Me.DireccionTextBox.Size = New System.Drawing.Size(331, 26)
        Me.DireccionTextBox.TabIndex = 28
        '
        'MovilidadPropiaLabel
        '
        MovilidadPropiaLabel.AutoSize = True
        MovilidadPropiaLabel.Location = New System.Drawing.Point(23, 528)
        MovilidadPropiaLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        MovilidadPropiaLabel.Name = "MovilidadPropiaLabel"
        MovilidadPropiaLabel.Size = New System.Drawing.Size(144, 20)
        MovilidadPropiaLabel.TabIndex = 29
        MovilidadPropiaLabel.Text = "Movilidad Propia:"
        '
        'MovilidadPropiaTextBox
        '
        Me.MovilidadPropiaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PostulanteBindingSource, "MovilidadPropia", True))
        Me.MovilidadPropiaTextBox.Location = New System.Drawing.Point(186, 525)
        Me.MovilidadPropiaTextBox.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.MovilidadPropiaTextBox.Name = "MovilidadPropiaTextBox"
        Me.MovilidadPropiaTextBox.Size = New System.Drawing.Size(61, 26)
        Me.MovilidadPropiaTextBox.TabIndex = 30
        '
        'DisponibilidadViajarLabel
        '
        DisponibilidadViajarLabel.AutoSize = True
        DisponibilidadViajarLabel.Location = New System.Drawing.Point(257, 528)
        DisponibilidadViajarLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        DisponibilidadViajarLabel.Name = "DisponibilidadViajarLabel"
        DisponibilidadViajarLabel.Size = New System.Drawing.Size(177, 20)
        DisponibilidadViajarLabel.TabIndex = 31
        DisponibilidadViajarLabel.Text = "Disponibilidad Viajar:"
        '
        'DisponibilidadViajarTextBox
        '
        Me.DisponibilidadViajarTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PostulanteBindingSource, "DisponibilidadViajar", True))
        Me.DisponibilidadViajarTextBox.Location = New System.Drawing.Point(460, 522)
        Me.DisponibilidadViajarTextBox.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.DisponibilidadViajarTextBox.Name = "DisponibilidadViajarTextBox"
        Me.DisponibilidadViajarTextBox.Size = New System.Drawing.Size(58, 26)
        Me.DisponibilidadViajarTextBox.TabIndex = 32
        '
        'LicenciaConducirLabel
        '
        LicenciaConducirLabel.AutoSize = True
        LicenciaConducirLabel.Location = New System.Drawing.Point(550, 525)
        LicenciaConducirLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        LicenciaConducirLabel.Name = "LicenciaConducirLabel"
        LicenciaConducirLabel.Size = New System.Drawing.Size(156, 20)
        LicenciaConducirLabel.TabIndex = 33
        LicenciaConducirLabel.Text = "Licencia Conducir:"
        '
        'LicenciaConducirTextBox
        '
        Me.LicenciaConducirTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PostulanteBindingSource, "LicenciaConducir", True))
        Me.LicenciaConducirTextBox.Location = New System.Drawing.Point(716, 519)
        Me.LicenciaConducirTextBox.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.LicenciaConducirTextBox.Name = "LicenciaConducirTextBox"
        Me.LicenciaConducirTextBox.Size = New System.Drawing.Size(56, 26)
        Me.LicenciaConducirTextBox.TabIndex = 34
        '
        'DiscapacidadLabel
        '
        DiscapacidadLabel.AutoSize = True
        DiscapacidadLabel.Location = New System.Drawing.Point(796, 522)
        DiscapacidadLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        DiscapacidadLabel.Name = "DiscapacidadLabel"
        DiscapacidadLabel.Size = New System.Drawing.Size(122, 20)
        DiscapacidadLabel.TabIndex = 35
        DiscapacidadLabel.Text = "Discapacidad:"
        '
        'DiscapacidadTextBox
        '
        Me.DiscapacidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PostulanteBindingSource, "Discapacidad", True))
        Me.DiscapacidadTextBox.Location = New System.Drawing.Point(949, 519)
        Me.DiscapacidadTextBox.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.DiscapacidadTextBox.Name = "DiscapacidadTextBox"
        Me.DiscapacidadTextBox.Size = New System.Drawing.Size(73, 26)
        Me.DiscapacidadTextBox.TabIndex = 36
        '
        'IdRegionLabel
        '
        IdRegionLabel.AutoSize = True
        IdRegionLabel.Location = New System.Drawing.Point(549, 473)
        IdRegionLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        IdRegionLabel.Name = "IdRegionLabel"
        IdRegionLabel.Size = New System.Drawing.Size(92, 20)
        IdRegionLabel.TabIndex = 37
        IdRegionLabel.Text = "Id Region:"
        '
        'IdRegionTextBox
        '
        Me.IdRegionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PostulanteBindingSource, "IdRegion", True))
        Me.IdRegionTextBox.Location = New System.Drawing.Point(691, 470)
        Me.IdRegionTextBox.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.IdRegionTextBox.Name = "IdRegionTextBox"
        Me.IdRegionTextBox.Size = New System.Drawing.Size(331, 26)
        Me.IdRegionTextBox.TabIndex = 38
        '
        'TipoLicenciaLabel
        '
        TipoLicenciaLabel.AutoSize = True
        TipoLicenciaLabel.Location = New System.Drawing.Point(550, 571)
        TipoLicenciaLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        TipoLicenciaLabel.Name = "TipoLicenciaLabel"
        TipoLicenciaLabel.Size = New System.Drawing.Size(119, 20)
        TipoLicenciaLabel.TabIndex = 39
        TipoLicenciaLabel.Text = "Tipo Licencia:"
        '
        'TipoLicenciaTextBox
        '
        Me.TipoLicenciaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PostulanteBindingSource, "TipoLicencia", True))
        Me.TipoLicenciaTextBox.Location = New System.Drawing.Point(691, 565)
        Me.TipoLicenciaTextBox.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.TipoLicenciaTextBox.Name = "TipoLicenciaTextBox"
        Me.TipoLicenciaTextBox.Size = New System.Drawing.Size(141, 26)
        Me.TipoLicenciaTextBox.TabIndex = 40
        '
        'ReferenciasBindingSource
        '
        Me.ReferenciasBindingSource.DataMember = "Referencias"
        Me.ReferenciasBindingSource.DataSource = Me.BD_ContratacionEmpleosDataSet
        '
        'ReferenciasTableAdapter
        '
        Me.ReferenciasTableAdapter.ClearBeforeFill = True
        '
        'Postulante
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1063, 617)
        Me.Controls.Add(IdPostulanteLabel)
        Me.Controls.Add(Me.IdPostulanteTextBox)
        Me.Controls.Add(NombresLabel)
        Me.Controls.Add(Me.NombresTextBox)
        Me.Controls.Add(ApellidosLabel)
        Me.Controls.Add(Me.ApellidosTextBox)
        Me.Controls.Add(EmailLabel)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(SexoLabel)
        Me.Controls.Add(Me.SexoTextBox)
        Me.Controls.Add(TelFijoLabel)
        Me.Controls.Add(Me.TelFijoTextBox)
        Me.Controls.Add(TelCelularLabel)
        Me.Controls.Add(Me.TelCelularTextBox)
        Me.Controls.Add(TipoDocumentoLabel)
        Me.Controls.Add(Me.TipoDocumentoTextBox)
        Me.Controls.Add(NroDocumentoLabel)
        Me.Controls.Add(Me.NroDocumentoTextBox)
        Me.Controls.Add(FechaNacimientoLabel)
        Me.Controls.Add(Me.FechaNacimientoDateTimePicker)
        Me.Controls.Add(EstadoCivilLabel)
        Me.Controls.Add(Me.EstadoCivilTextBox)
        Me.Controls.Add(ProvinciaLabel)
        Me.Controls.Add(Me.ProvinciaTextBox)
        Me.Controls.Add(DistritoLabel)
        Me.Controls.Add(Me.DistritoTextBox)
        Me.Controls.Add(DireccionLabel)
        Me.Controls.Add(Me.DireccionTextBox)
        Me.Controls.Add(MovilidadPropiaLabel)
        Me.Controls.Add(Me.MovilidadPropiaTextBox)
        Me.Controls.Add(DisponibilidadViajarLabel)
        Me.Controls.Add(Me.DisponibilidadViajarTextBox)
        Me.Controls.Add(LicenciaConducirLabel)
        Me.Controls.Add(Me.LicenciaConducirTextBox)
        Me.Controls.Add(DiscapacidadLabel)
        Me.Controls.Add(Me.DiscapacidadTextBox)
        Me.Controls.Add(IdRegionLabel)
        Me.Controls.Add(Me.IdRegionTextBox)
        Me.Controls.Add(TipoLicenciaLabel)
        Me.Controls.Add(Me.TipoLicenciaTextBox)
        Me.Controls.Add(Me.PostulanteBindingNavigator)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Name = "Postulante"
        Me.Text = "Postulante"
        CType(Me.BD_ContratacionEmpleosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PostulanteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PostulanteBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PostulanteBindingNavigator.ResumeLayout(False)
        Me.PostulanteBindingNavigator.PerformLayout()
        CType(Me.ReferenciasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BD_ContratacionEmpleosDataSet As BD_ContratacionEmpleosDataSet
    Friend WithEvents PostulanteBindingSource As BindingSource
    Friend WithEvents PostulanteTableAdapter As BD_ContratacionEmpleosDataSetTableAdapters.PostulanteTableAdapter
    Friend WithEvents TableAdapterManager As BD_ContratacionEmpleosDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PostulanteBindingNavigator As BindingNavigator
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
    Friend WithEvents PostulanteBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents IdPostulanteTextBox As TextBox
    Friend WithEvents NombresTextBox As TextBox
    Friend WithEvents ApellidosTextBox As TextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents SexoTextBox As TextBox
    Friend WithEvents TelFijoTextBox As TextBox
    Friend WithEvents TelCelularTextBox As TextBox
    Friend WithEvents TipoDocumentoTextBox As TextBox
    Friend WithEvents NroDocumentoTextBox As TextBox
    Friend WithEvents FechaNacimientoDateTimePicker As DateTimePicker
    Friend WithEvents EstadoCivilTextBox As TextBox
    Friend WithEvents ProvinciaTextBox As TextBox
    Friend WithEvents DistritoTextBox As TextBox
    Friend WithEvents DireccionTextBox As TextBox
    Friend WithEvents MovilidadPropiaTextBox As TextBox
    Friend WithEvents DisponibilidadViajarTextBox As TextBox
    Friend WithEvents LicenciaConducirTextBox As TextBox
    Friend WithEvents DiscapacidadTextBox As TextBox
    Friend WithEvents IdRegionTextBox As TextBox
    Friend WithEvents TipoLicenciaTextBox As TextBox
    Friend WithEvents ReferenciasTableAdapter As BD_ContratacionEmpleosDataSetTableAdapters.ReferenciasTableAdapter
    Friend WithEvents ReferenciasBindingSource As BindingSource
End Class
