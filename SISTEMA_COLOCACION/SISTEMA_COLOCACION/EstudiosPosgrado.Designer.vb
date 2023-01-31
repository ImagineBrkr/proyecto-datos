<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EstudiosPosgrado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EstudiosPosgrado))
        Dim CodEstudiosPostgradoLabel As System.Windows.Forms.Label
        Dim TipoEstudiosLabel As System.Windows.Forms.Label
        Dim NombreEstudioLabel As System.Windows.Forms.Label
        Dim InstitucionLabel As System.Windows.Forms.Label
        Dim FechaInicioLabel As System.Windows.Forms.Label
        Dim AlPresenteLabel As System.Windows.Forms.Label
        Dim FechaFinLabel As System.Windows.Forms.Label
        Dim IdPostulanteLabel As System.Windows.Forms.Label
        Me.BD_ContratacionEmpleosDataSet = New SISTEMA_COLOCACION.BD_ContratacionEmpleosDataSet()
        Me.EstudiosPostgradoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EstudiosPostgradoTableAdapter = New SISTEMA_COLOCACION.BD_ContratacionEmpleosDataSetTableAdapters.EstudiosPostgradoTableAdapter()
        Me.TableAdapterManager = New SISTEMA_COLOCACION.BD_ContratacionEmpleosDataSetTableAdapters.TableAdapterManager()
        Me.EstudiosPostgradoBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.EstudiosPostgradoBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.CodEstudiosPostgradoTextBox = New System.Windows.Forms.TextBox()
        Me.TipoEstudiosTextBox = New System.Windows.Forms.TextBox()
        Me.NombreEstudioTextBox = New System.Windows.Forms.TextBox()
        Me.InstitucionTextBox = New System.Windows.Forms.TextBox()
        Me.FechaInicioDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.AlPresenteTextBox = New System.Windows.Forms.TextBox()
        Me.FechaFinDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.IdPostulanteTextBox = New System.Windows.Forms.TextBox()
        CodEstudiosPostgradoLabel = New System.Windows.Forms.Label()
        TipoEstudiosLabel = New System.Windows.Forms.Label()
        NombreEstudioLabel = New System.Windows.Forms.Label()
        InstitucionLabel = New System.Windows.Forms.Label()
        FechaInicioLabel = New System.Windows.Forms.Label()
        AlPresenteLabel = New System.Windows.Forms.Label()
        FechaFinLabel = New System.Windows.Forms.Label()
        IdPostulanteLabel = New System.Windows.Forms.Label()
        CType(Me.BD_ContratacionEmpleosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstudiosPostgradoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstudiosPostgradoBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EstudiosPostgradoBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'BD_ContratacionEmpleosDataSet
        '
        Me.BD_ContratacionEmpleosDataSet.DataSetName = "BD_ContratacionEmpleosDataSet"
        Me.BD_ContratacionEmpleosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EstudiosPostgradoBindingSource
        '
        Me.EstudiosPostgradoBindingSource.DataMember = "EstudiosPostgrado"
        Me.EstudiosPostgradoBindingSource.DataSource = Me.BD_ContratacionEmpleosDataSet
        '
        'EstudiosPostgradoTableAdapter
        '
        Me.EstudiosPostgradoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AreaTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BeneficiosTableAdapter = Nothing
        Me.TableAdapterManager.ContactoEmpresaTableAdapter = Nothing
        Me.TableAdapterManager.Director_RRHHTableAdapter = Nothing
        Me.TableAdapterManager.EmpresaTableAdapter = Nothing
        Me.TableAdapterManager.EstudiosPostgradoTableAdapter = Me.EstudiosPostgradoTableAdapter
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
        'EstudiosPostgradoBindingNavigator
        '
        Me.EstudiosPostgradoBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.EstudiosPostgradoBindingNavigator.BindingSource = Me.EstudiosPostgradoBindingSource
        Me.EstudiosPostgradoBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.EstudiosPostgradoBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.EstudiosPostgradoBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.EstudiosPostgradoBindingNavigatorSaveItem})
        Me.EstudiosPostgradoBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.EstudiosPostgradoBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.EstudiosPostgradoBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.EstudiosPostgradoBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.EstudiosPostgradoBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.EstudiosPostgradoBindingNavigator.Name = "EstudiosPostgradoBindingNavigator"
        Me.EstudiosPostgradoBindingNavigator.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.EstudiosPostgradoBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.EstudiosPostgradoBindingNavigator.Size = New System.Drawing.Size(659, 25)
        Me.EstudiosPostgradoBindingNavigator.TabIndex = 0
        Me.EstudiosPostgradoBindingNavigator.Text = "BindingNavigator1"
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
        'EstudiosPostgradoBindingNavigatorSaveItem
        '
        Me.EstudiosPostgradoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.EstudiosPostgradoBindingNavigatorSaveItem.Image = CType(resources.GetObject("EstudiosPostgradoBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.EstudiosPostgradoBindingNavigatorSaveItem.Name = "EstudiosPostgradoBindingNavigatorSaveItem"
        Me.EstudiosPostgradoBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.EstudiosPostgradoBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'CodEstudiosPostgradoLabel
        '
        CodEstudiosPostgradoLabel.AutoSize = True
        CodEstudiosPostgradoLabel.Location = New System.Drawing.Point(66, 77)
        CodEstudiosPostgradoLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        CodEstudiosPostgradoLabel.Name = "CodEstudiosPostgradoLabel"
        CodEstudiosPostgradoLabel.Size = New System.Drawing.Size(208, 20)
        CodEstudiosPostgradoLabel.TabIndex = 1
        CodEstudiosPostgradoLabel.Text = "Cod Estudios Postgrado:"
        '
        'CodEstudiosPostgradoTextBox
        '
        Me.CodEstudiosPostgradoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EstudiosPostgradoBindingSource, "CodEstudiosPostgrado", True))
        Me.CodEstudiosPostgradoTextBox.Location = New System.Drawing.Point(281, 72)
        Me.CodEstudiosPostgradoTextBox.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.CodEstudiosPostgradoTextBox.Name = "CodEstudiosPostgradoTextBox"
        Me.CodEstudiosPostgradoTextBox.Size = New System.Drawing.Size(86, 26)
        Me.CodEstudiosPostgradoTextBox.TabIndex = 2
        '
        'TipoEstudiosLabel
        '
        TipoEstudiosLabel.AutoSize = True
        TipoEstudiosLabel.Location = New System.Drawing.Point(66, 117)
        TipoEstudiosLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        TipoEstudiosLabel.Name = "TipoEstudiosLabel"
        TipoEstudiosLabel.Size = New System.Drawing.Size(148, 20)
        TipoEstudiosLabel.TabIndex = 3
        TipoEstudiosLabel.Text = "Tipo de Estudios:"
        '
        'TipoEstudiosTextBox
        '
        Me.TipoEstudiosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EstudiosPostgradoBindingSource, "TipoEstudios", True))
        Me.TipoEstudiosTextBox.Location = New System.Drawing.Point(281, 112)
        Me.TipoEstudiosTextBox.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.TipoEstudiosTextBox.Name = "TipoEstudiosTextBox"
        Me.TipoEstudiosTextBox.Size = New System.Drawing.Size(331, 26)
        Me.TipoEstudiosTextBox.TabIndex = 4
        '
        'NombreEstudioLabel
        '
        NombreEstudioLabel.AutoSize = True
        NombreEstudioLabel.Location = New System.Drawing.Point(66, 157)
        NombreEstudioLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        NombreEstudioLabel.Name = "NombreEstudioLabel"
        NombreEstudioLabel.Size = New System.Drawing.Size(84, 20)
        NombreEstudioLabel.TabIndex = 5
        NombreEstudioLabel.Text = "Estudios:"
        '
        'NombreEstudioTextBox
        '
        Me.NombreEstudioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EstudiosPostgradoBindingSource, "NombreEstudio", True))
        Me.NombreEstudioTextBox.Location = New System.Drawing.Point(281, 152)
        Me.NombreEstudioTextBox.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.NombreEstudioTextBox.Name = "NombreEstudioTextBox"
        Me.NombreEstudioTextBox.Size = New System.Drawing.Size(331, 26)
        Me.NombreEstudioTextBox.TabIndex = 6
        '
        'InstitucionLabel
        '
        InstitucionLabel.AutoSize = True
        InstitucionLabel.Location = New System.Drawing.Point(66, 197)
        InstitucionLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        InstitucionLabel.Name = "InstitucionLabel"
        InstitucionLabel.Size = New System.Drawing.Size(98, 20)
        InstitucionLabel.TabIndex = 7
        InstitucionLabel.Text = "Institucion:"
        '
        'InstitucionTextBox
        '
        Me.InstitucionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EstudiosPostgradoBindingSource, "Institucion", True))
        Me.InstitucionTextBox.Location = New System.Drawing.Point(281, 192)
        Me.InstitucionTextBox.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.InstitucionTextBox.Name = "InstitucionTextBox"
        Me.InstitucionTextBox.Size = New System.Drawing.Size(331, 26)
        Me.InstitucionTextBox.TabIndex = 8
        '
        'FechaInicioLabel
        '
        FechaInicioLabel.AutoSize = True
        FechaInicioLabel.Location = New System.Drawing.Point(66, 238)
        FechaInicioLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        FechaInicioLabel.Name = "FechaInicioLabel"
        FechaInicioLabel.Size = New System.Drawing.Size(112, 20)
        FechaInicioLabel.TabIndex = 9
        FechaInicioLabel.Text = "Fecha Inicio:"
        '
        'FechaInicioDateTimePicker
        '
        Me.FechaInicioDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.EstudiosPostgradoBindingSource, "FechaInicio", True))
        Me.FechaInicioDateTimePicker.Location = New System.Drawing.Point(281, 232)
        Me.FechaInicioDateTimePicker.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.FechaInicioDateTimePicker.Name = "FechaInicioDateTimePicker"
        Me.FechaInicioDateTimePicker.Size = New System.Drawing.Size(331, 26)
        Me.FechaInicioDateTimePicker.TabIndex = 10
        '
        'AlPresenteLabel
        '
        AlPresenteLabel.AutoSize = True
        AlPresenteLabel.Location = New System.Drawing.Point(66, 277)
        AlPresenteLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        AlPresenteLabel.Name = "AlPresenteLabel"
        AlPresenteLabel.Size = New System.Drawing.Size(107, 20)
        AlPresenteLabel.TabIndex = 11
        AlPresenteLabel.Text = "Al Presente:"
        '
        'AlPresenteTextBox
        '
        Me.AlPresenteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EstudiosPostgradoBindingSource, "AlPresente", True))
        Me.AlPresenteTextBox.Location = New System.Drawing.Point(281, 272)
        Me.AlPresenteTextBox.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.AlPresenteTextBox.Name = "AlPresenteTextBox"
        Me.AlPresenteTextBox.Size = New System.Drawing.Size(86, 26)
        Me.AlPresenteTextBox.TabIndex = 12
        '
        'FechaFinLabel
        '
        FechaFinLabel.AutoSize = True
        FechaFinLabel.Location = New System.Drawing.Point(66, 318)
        FechaFinLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        FechaFinLabel.Name = "FechaFinLabel"
        FechaFinLabel.Size = New System.Drawing.Size(94, 20)
        FechaFinLabel.TabIndex = 13
        FechaFinLabel.Text = "Fecha Fin:"
        '
        'FechaFinDateTimePicker
        '
        Me.FechaFinDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.EstudiosPostgradoBindingSource, "FechaFin", True))
        Me.FechaFinDateTimePicker.Location = New System.Drawing.Point(281, 312)
        Me.FechaFinDateTimePicker.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.FechaFinDateTimePicker.Name = "FechaFinDateTimePicker"
        Me.FechaFinDateTimePicker.Size = New System.Drawing.Size(331, 26)
        Me.FechaFinDateTimePicker.TabIndex = 14
        '
        'IdPostulanteLabel
        '
        IdPostulanteLabel.AutoSize = True
        IdPostulanteLabel.Location = New System.Drawing.Point(66, 37)
        IdPostulanteLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        IdPostulanteLabel.Name = "IdPostulanteLabel"
        IdPostulanteLabel.Size = New System.Drawing.Size(121, 20)
        IdPostulanteLabel.TabIndex = 15
        IdPostulanteLabel.Text = "Id Postulante:"
        '
        'IdPostulanteTextBox
        '
        Me.IdPostulanteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EstudiosPostgradoBindingSource, "IdPostulante", True))
        Me.IdPostulanteTextBox.Location = New System.Drawing.Point(281, 32)
        Me.IdPostulanteTextBox.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.IdPostulanteTextBox.Name = "IdPostulanteTextBox"
        Me.IdPostulanteTextBox.Size = New System.Drawing.Size(86, 26)
        Me.IdPostulanteTextBox.TabIndex = 16
        '
        'EstudiosPosgrado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(659, 406)
        Me.Controls.Add(CodEstudiosPostgradoLabel)
        Me.Controls.Add(Me.CodEstudiosPostgradoTextBox)
        Me.Controls.Add(TipoEstudiosLabel)
        Me.Controls.Add(Me.TipoEstudiosTextBox)
        Me.Controls.Add(NombreEstudioLabel)
        Me.Controls.Add(Me.NombreEstudioTextBox)
        Me.Controls.Add(InstitucionLabel)
        Me.Controls.Add(Me.InstitucionTextBox)
        Me.Controls.Add(FechaInicioLabel)
        Me.Controls.Add(Me.FechaInicioDateTimePicker)
        Me.Controls.Add(AlPresenteLabel)
        Me.Controls.Add(Me.AlPresenteTextBox)
        Me.Controls.Add(FechaFinLabel)
        Me.Controls.Add(Me.FechaFinDateTimePicker)
        Me.Controls.Add(IdPostulanteLabel)
        Me.Controls.Add(Me.IdPostulanteTextBox)
        Me.Controls.Add(Me.EstudiosPostgradoBindingNavigator)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Name = "EstudiosPosgrado"
        Me.Text = "EstudiosPosgrado"
        CType(Me.BD_ContratacionEmpleosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstudiosPostgradoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstudiosPostgradoBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EstudiosPostgradoBindingNavigator.ResumeLayout(False)
        Me.EstudiosPostgradoBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BD_ContratacionEmpleosDataSet As BD_ContratacionEmpleosDataSet
    Friend WithEvents EstudiosPostgradoBindingSource As BindingSource
    Friend WithEvents EstudiosPostgradoTableAdapter As BD_ContratacionEmpleosDataSetTableAdapters.EstudiosPostgradoTableAdapter
    Friend WithEvents TableAdapterManager As BD_ContratacionEmpleosDataSetTableAdapters.TableAdapterManager
    Friend WithEvents EstudiosPostgradoBindingNavigator As BindingNavigator
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
    Friend WithEvents EstudiosPostgradoBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents CodEstudiosPostgradoTextBox As TextBox
    Friend WithEvents TipoEstudiosTextBox As TextBox
    Friend WithEvents NombreEstudioTextBox As TextBox
    Friend WithEvents InstitucionTextBox As TextBox
    Friend WithEvents FechaInicioDateTimePicker As DateTimePicker
    Friend WithEvents AlPresenteTextBox As TextBox
    Friend WithEvents FechaFinDateTimePicker As DateTimePicker
    Friend WithEvents IdPostulanteTextBox As TextBox
End Class
