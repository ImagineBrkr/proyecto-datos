<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Referencias
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Referencias))
        Dim IdPostulanteLabel As System.Windows.Forms.Label
        Dim CodReferenciaLabel As System.Windows.Forms.Label
        Dim NombresLabel As System.Windows.Forms.Label
        Dim ApellidosLabel As System.Windows.Forms.Label
        Dim CorreoLabel As System.Windows.Forms.Label
        Dim TelefonoLabel As System.Windows.Forms.Label
        Dim TipoReferenciaLabel As System.Windows.Forms.Label
        Dim TipoRelacionLabel As System.Windows.Forms.Label
        Dim EmpresaLabel As System.Windows.Forms.Label
        Dim PuestoLabel As System.Windows.Forms.Label
        Me.BD_ContratacionEmpleosDataSet = New SISTEMA_COLOCACION.BD_ContratacionEmpleosDataSet()
        Me.ReferenciasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReferenciasTableAdapter = New SISTEMA_COLOCACION.BD_ContratacionEmpleosDataSetTableAdapters.ReferenciasTableAdapter()
        Me.TableAdapterManager = New SISTEMA_COLOCACION.BD_ContratacionEmpleosDataSetTableAdapters.TableAdapterManager()
        Me.ReferenciasBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.ReferenciasBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IdPostulanteTextBox = New System.Windows.Forms.TextBox()
        Me.CodReferenciaTextBox = New System.Windows.Forms.TextBox()
        Me.NombresTextBox = New System.Windows.Forms.TextBox()
        Me.ApellidosTextBox = New System.Windows.Forms.TextBox()
        Me.CorreoTextBox = New System.Windows.Forms.TextBox()
        Me.TelefonoTextBox = New System.Windows.Forms.TextBox()
        Me.TipoReferenciaTextBox = New System.Windows.Forms.TextBox()
        Me.TipoRelacionTextBox = New System.Windows.Forms.TextBox()
        Me.EmpresaTextBox = New System.Windows.Forms.TextBox()
        Me.PuestoTextBox = New System.Windows.Forms.TextBox()
        IdPostulanteLabel = New System.Windows.Forms.Label()
        CodReferenciaLabel = New System.Windows.Forms.Label()
        NombresLabel = New System.Windows.Forms.Label()
        ApellidosLabel = New System.Windows.Forms.Label()
        CorreoLabel = New System.Windows.Forms.Label()
        TelefonoLabel = New System.Windows.Forms.Label()
        TipoReferenciaLabel = New System.Windows.Forms.Label()
        TipoRelacionLabel = New System.Windows.Forms.Label()
        EmpresaLabel = New System.Windows.Forms.Label()
        PuestoLabel = New System.Windows.Forms.Label()
        CType(Me.BD_ContratacionEmpleosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReferenciasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReferenciasBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ReferenciasBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'BD_ContratacionEmpleosDataSet
        '
        Me.BD_ContratacionEmpleosDataSet.DataSetName = "BD_ContratacionEmpleosDataSet"
        Me.BD_ContratacionEmpleosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.TableAdapterManager.ReferenciasTableAdapter = Me.ReferenciasTableAdapter
        Me.TableAdapterManager.RegionTableAdapter = Nothing
        Me.TableAdapterManager.RequerimientoTableAdapter = Nothing
        Me.TableAdapterManager.SoftwareTableAdapter = Nothing
        Me.TableAdapterManager.TipoEvaluacionTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SISTEMA_COLOCACION.BD_ContratacionEmpleosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ReferenciasBindingNavigator
        '
        Me.ReferenciasBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ReferenciasBindingNavigator.BindingSource = Me.ReferenciasBindingSource
        Me.ReferenciasBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ReferenciasBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ReferenciasBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ReferenciasBindingNavigatorSaveItem})
        Me.ReferenciasBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ReferenciasBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ReferenciasBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ReferenciasBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ReferenciasBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ReferenciasBindingNavigator.Name = "ReferenciasBindingNavigator"
        Me.ReferenciasBindingNavigator.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.ReferenciasBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ReferenciasBindingNavigator.Size = New System.Drawing.Size(894, 25)
        Me.ReferenciasBindingNavigator.TabIndex = 0
        Me.ReferenciasBindingNavigator.Text = "BindingNavigator1"
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
        'ReferenciasBindingNavigatorSaveItem
        '
        Me.ReferenciasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ReferenciasBindingNavigatorSaveItem.Image = CType(resources.GetObject("ReferenciasBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ReferenciasBindingNavigatorSaveItem.Name = "ReferenciasBindingNavigatorSaveItem"
        Me.ReferenciasBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.ReferenciasBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'IdPostulanteLabel
        '
        IdPostulanteLabel.AutoSize = True
        IdPostulanteLabel.Location = New System.Drawing.Point(41, 67)
        IdPostulanteLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        IdPostulanteLabel.Name = "IdPostulanteLabel"
        IdPostulanteLabel.Size = New System.Drawing.Size(121, 20)
        IdPostulanteLabel.TabIndex = 1
        IdPostulanteLabel.Text = "Id Postulante:"
        '
        'IdPostulanteTextBox
        '
        Me.IdPostulanteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReferenciasBindingSource, "IdPostulante", True))
        Me.IdPostulanteTextBox.Location = New System.Drawing.Point(195, 62)
        Me.IdPostulanteTextBox.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.IdPostulanteTextBox.Name = "IdPostulanteTextBox"
        Me.IdPostulanteTextBox.Size = New System.Drawing.Size(76, 26)
        Me.IdPostulanteTextBox.TabIndex = 2
        '
        'CodReferenciaLabel
        '
        CodReferenciaLabel.AutoSize = True
        CodReferenciaLabel.Location = New System.Drawing.Point(314, 67)
        CodReferenciaLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        CodReferenciaLabel.Name = "CodReferenciaLabel"
        CodReferenciaLabel.Size = New System.Drawing.Size(139, 20)
        CodReferenciaLabel.TabIndex = 3
        CodReferenciaLabel.Text = "Cod Referencia:"
        '
        'CodReferenciaTextBox
        '
        Me.CodReferenciaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReferenciasBindingSource, "CodReferencia", True))
        Me.CodReferenciaTextBox.Location = New System.Drawing.Point(463, 61)
        Me.CodReferenciaTextBox.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.CodReferenciaTextBox.Name = "CodReferenciaTextBox"
        Me.CodReferenciaTextBox.Size = New System.Drawing.Size(63, 26)
        Me.CodReferenciaTextBox.TabIndex = 4
        '
        'NombresLabel
        '
        NombresLabel.AutoSize = True
        NombresLabel.Location = New System.Drawing.Point(41, 124)
        NombresLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        NombresLabel.Name = "NombresLabel"
        NombresLabel.Size = New System.Drawing.Size(85, 20)
        NombresLabel.TabIndex = 5
        NombresLabel.Text = "Nombres:"
        '
        'NombresTextBox
        '
        Me.NombresTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReferenciasBindingSource, "Nombres", True))
        Me.NombresTextBox.Location = New System.Drawing.Point(195, 119)
        Me.NombresTextBox.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.NombresTextBox.Name = "NombresTextBox"
        Me.NombresTextBox.Size = New System.Drawing.Size(258, 26)
        Me.NombresTextBox.TabIndex = 6
        '
        'ApellidosLabel
        '
        ApellidosLabel.AutoSize = True
        ApellidosLabel.Location = New System.Drawing.Point(463, 122)
        ApellidosLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        ApellidosLabel.Name = "ApellidosLabel"
        ApellidosLabel.Size = New System.Drawing.Size(87, 20)
        ApellidosLabel.TabIndex = 7
        ApellidosLabel.Text = "Apellidos:"
        '
        'ApellidosTextBox
        '
        Me.ApellidosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReferenciasBindingSource, "Apellidos", True))
        Me.ApellidosTextBox.Location = New System.Drawing.Point(584, 118)
        Me.ApellidosTextBox.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ApellidosTextBox.Name = "ApellidosTextBox"
        Me.ApellidosTextBox.Size = New System.Drawing.Size(280, 26)
        Me.ApellidosTextBox.TabIndex = 8
        '
        'CorreoLabel
        '
        CorreoLabel.AutoSize = True
        CorreoLabel.Location = New System.Drawing.Point(43, 173)
        CorreoLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        CorreoLabel.Name = "CorreoLabel"
        CorreoLabel.Size = New System.Drawing.Size(68, 20)
        CorreoLabel.TabIndex = 9
        CorreoLabel.Text = "Correo:"
        '
        'CorreoTextBox
        '
        Me.CorreoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReferenciasBindingSource, "Correo", True))
        Me.CorreoTextBox.Location = New System.Drawing.Point(197, 166)
        Me.CorreoTextBox.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.CorreoTextBox.Name = "CorreoTextBox"
        Me.CorreoTextBox.Size = New System.Drawing.Size(256, 26)
        Me.CorreoTextBox.TabIndex = 10
        '
        'TelefonoLabel
        '
        TelefonoLabel.AutoSize = True
        TelefonoLabel.Location = New System.Drawing.Point(466, 172)
        TelefonoLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        TelefonoLabel.Name = "TelefonoLabel"
        TelefonoLabel.Size = New System.Drawing.Size(84, 20)
        TelefonoLabel.TabIndex = 11
        TelefonoLabel.Text = "Telefono:"
        '
        'TelefonoTextBox
        '
        Me.TelefonoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReferenciasBindingSource, "Telefono", True))
        Me.TelefonoTextBox.Location = New System.Drawing.Point(584, 166)
        Me.TelefonoTextBox.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.TelefonoTextBox.Name = "TelefonoTextBox"
        Me.TelefonoTextBox.Size = New System.Drawing.Size(157, 26)
        Me.TelefonoTextBox.TabIndex = 12
        '
        'TipoReferenciaLabel
        '
        TipoReferenciaLabel.AutoSize = True
        TipoReferenciaLabel.Location = New System.Drawing.Point(41, 223)
        TipoReferenciaLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        TipoReferenciaLabel.Name = "TipoReferenciaLabel"
        TipoReferenciaLabel.Size = New System.Drawing.Size(141, 20)
        TipoReferenciaLabel.TabIndex = 13
        TipoReferenciaLabel.Text = "Tipo Referencia:"
        '
        'TipoReferenciaTextBox
        '
        Me.TipoReferenciaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReferenciasBindingSource, "TipoReferencia", True))
        Me.TipoReferenciaTextBox.Location = New System.Drawing.Point(195, 223)
        Me.TipoReferenciaTextBox.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.TipoReferenciaTextBox.Name = "TipoReferenciaTextBox"
        Me.TipoReferenciaTextBox.Size = New System.Drawing.Size(164, 26)
        Me.TipoReferenciaTextBox.TabIndex = 14
        '
        'TipoRelacionLabel
        '
        TipoRelacionLabel.AutoSize = True
        TipoRelacionLabel.Location = New System.Drawing.Point(448, 220)
        TipoRelacionLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        TipoRelacionLabel.Name = "TipoRelacionLabel"
        TipoRelacionLabel.Size = New System.Drawing.Size(123, 20)
        TipoRelacionLabel.TabIndex = 15
        TipoRelacionLabel.Text = "Tipo Relacion:"
        '
        'TipoRelacionTextBox
        '
        Me.TipoRelacionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReferenciasBindingSource, "TipoRelacion", True))
        Me.TipoRelacionTextBox.Location = New System.Drawing.Point(584, 217)
        Me.TipoRelacionTextBox.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.TipoRelacionTextBox.Name = "TipoRelacionTextBox"
        Me.TipoRelacionTextBox.Size = New System.Drawing.Size(164, 26)
        Me.TipoRelacionTextBox.TabIndex = 16
        '
        'EmpresaLabel
        '
        EmpresaLabel.AutoSize = True
        EmpresaLabel.Location = New System.Drawing.Point(43, 276)
        EmpresaLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        EmpresaLabel.Name = "EmpresaLabel"
        EmpresaLabel.Size = New System.Drawing.Size(85, 20)
        EmpresaLabel.TabIndex = 17
        EmpresaLabel.Text = "Empresa:"
        '
        'EmpresaTextBox
        '
        Me.EmpresaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReferenciasBindingSource, "Empresa", True))
        Me.EmpresaTextBox.Location = New System.Drawing.Point(197, 271)
        Me.EmpresaTextBox.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.EmpresaTextBox.Name = "EmpresaTextBox"
        Me.EmpresaTextBox.Size = New System.Drawing.Size(256, 26)
        Me.EmpresaTextBox.TabIndex = 18
        '
        'PuestoLabel
        '
        PuestoLabel.AutoSize = True
        PuestoLabel.Location = New System.Drawing.Point(463, 277)
        PuestoLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        PuestoLabel.Name = "PuestoLabel"
        PuestoLabel.Size = New System.Drawing.Size(70, 20)
        PuestoLabel.TabIndex = 19
        PuestoLabel.Text = "Puesto:"
        '
        'PuestoTextBox
        '
        Me.PuestoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReferenciasBindingSource, "Puesto", True))
        Me.PuestoTextBox.Location = New System.Drawing.Point(584, 270)
        Me.PuestoTextBox.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.PuestoTextBox.Name = "PuestoTextBox"
        Me.PuestoTextBox.Size = New System.Drawing.Size(280, 26)
        Me.PuestoTextBox.TabIndex = 20
        '
        'Referencias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(894, 326)
        Me.Controls.Add(IdPostulanteLabel)
        Me.Controls.Add(Me.IdPostulanteTextBox)
        Me.Controls.Add(CodReferenciaLabel)
        Me.Controls.Add(Me.CodReferenciaTextBox)
        Me.Controls.Add(NombresLabel)
        Me.Controls.Add(Me.NombresTextBox)
        Me.Controls.Add(ApellidosLabel)
        Me.Controls.Add(Me.ApellidosTextBox)
        Me.Controls.Add(CorreoLabel)
        Me.Controls.Add(Me.CorreoTextBox)
        Me.Controls.Add(TelefonoLabel)
        Me.Controls.Add(Me.TelefonoTextBox)
        Me.Controls.Add(TipoReferenciaLabel)
        Me.Controls.Add(Me.TipoReferenciaTextBox)
        Me.Controls.Add(TipoRelacionLabel)
        Me.Controls.Add(Me.TipoRelacionTextBox)
        Me.Controls.Add(EmpresaLabel)
        Me.Controls.Add(Me.EmpresaTextBox)
        Me.Controls.Add(PuestoLabel)
        Me.Controls.Add(Me.PuestoTextBox)
        Me.Controls.Add(Me.ReferenciasBindingNavigator)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Name = "Referencias"
        Me.Text = "Referencias"
        CType(Me.BD_ContratacionEmpleosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReferenciasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReferenciasBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ReferenciasBindingNavigator.ResumeLayout(False)
        Me.ReferenciasBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BD_ContratacionEmpleosDataSet As BD_ContratacionEmpleosDataSet
    Friend WithEvents ReferenciasBindingSource As BindingSource
    Friend WithEvents ReferenciasTableAdapter As BD_ContratacionEmpleosDataSetTableAdapters.ReferenciasTableAdapter
    Friend WithEvents TableAdapterManager As BD_ContratacionEmpleosDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ReferenciasBindingNavigator As BindingNavigator
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
    Friend WithEvents ReferenciasBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents IdPostulanteTextBox As TextBox
    Friend WithEvents CodReferenciaTextBox As TextBox
    Friend WithEvents NombresTextBox As TextBox
    Friend WithEvents ApellidosTextBox As TextBox
    Friend WithEvents CorreoTextBox As TextBox
    Friend WithEvents TelefonoTextBox As TextBox
    Friend WithEvents TipoReferenciaTextBox As TextBox
    Friend WithEvents TipoRelacionTextBox As TextBox
    Friend WithEvents EmpresaTextBox As TextBox
    Friend WithEvents PuestoTextBox As TextBox
End Class
