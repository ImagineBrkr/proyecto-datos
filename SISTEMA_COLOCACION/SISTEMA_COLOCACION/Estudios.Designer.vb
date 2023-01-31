<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Estudios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Estudios))
        Dim IdPostulanteLabel As System.Windows.Forms.Label
        Dim CodEstudiosLabel As System.Windows.Forms.Label
        Dim GradoAcademicoLabel As System.Windows.Forms.Label
        Dim InstitucionLabel As System.Windows.Forms.Label
        Dim CarreraLabel As System.Windows.Forms.Label
        Dim FechaInicioLabel As System.Windows.Forms.Label
        Dim AlPresenteLabel As System.Windows.Forms.Label
        Dim FechaFinLabel As System.Windows.Forms.Label
        Me.BD_ContratacionEmpleosDataSet = New SISTEMA_COLOCACION.BD_ContratacionEmpleosDataSet()
        Me.EstudiosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EstudiosTableAdapter = New SISTEMA_COLOCACION.BD_ContratacionEmpleosDataSetTableAdapters.EstudiosTableAdapter()
        Me.TableAdapterManager = New SISTEMA_COLOCACION.BD_ContratacionEmpleosDataSetTableAdapters.TableAdapterManager()
        Me.EstudiosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.EstudiosBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IdPostulanteTextBox = New System.Windows.Forms.TextBox()
        Me.CodEstudiosTextBox = New System.Windows.Forms.TextBox()
        Me.GradoAcademicoTextBox = New System.Windows.Forms.TextBox()
        Me.InstitucionTextBox = New System.Windows.Forms.TextBox()
        Me.CarreraTextBox = New System.Windows.Forms.TextBox()
        Me.FechaInicioDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.AlPresenteTextBox = New System.Windows.Forms.TextBox()
        Me.FechaFinDateTimePicker = New System.Windows.Forms.DateTimePicker()
        IdPostulanteLabel = New System.Windows.Forms.Label()
        CodEstudiosLabel = New System.Windows.Forms.Label()
        GradoAcademicoLabel = New System.Windows.Forms.Label()
        InstitucionLabel = New System.Windows.Forms.Label()
        CarreraLabel = New System.Windows.Forms.Label()
        FechaInicioLabel = New System.Windows.Forms.Label()
        AlPresenteLabel = New System.Windows.Forms.Label()
        FechaFinLabel = New System.Windows.Forms.Label()
        CType(Me.BD_ContratacionEmpleosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstudiosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstudiosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EstudiosBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'BD_ContratacionEmpleosDataSet
        '
        Me.BD_ContratacionEmpleosDataSet.DataSetName = "BD_ContratacionEmpleosDataSet"
        Me.BD_ContratacionEmpleosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EstudiosBindingSource
        '
        Me.EstudiosBindingSource.DataMember = "Estudios"
        Me.EstudiosBindingSource.DataSource = Me.BD_ContratacionEmpleosDataSet
        '
        'EstudiosTableAdapter
        '
        Me.EstudiosTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.EstudiosTableAdapter = Me.EstudiosTableAdapter
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
        'EstudiosBindingNavigator
        '
        Me.EstudiosBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.EstudiosBindingNavigator.BindingSource = Me.EstudiosBindingSource
        Me.EstudiosBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.EstudiosBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.EstudiosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.EstudiosBindingNavigatorSaveItem})
        Me.EstudiosBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.EstudiosBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.EstudiosBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.EstudiosBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.EstudiosBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.EstudiosBindingNavigator.Name = "EstudiosBindingNavigator"
        Me.EstudiosBindingNavigator.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.EstudiosBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.EstudiosBindingNavigator.Size = New System.Drawing.Size(575, 25)
        Me.EstudiosBindingNavigator.TabIndex = 0
        Me.EstudiosBindingNavigator.Text = "BindingNavigator1"
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
        'EstudiosBindingNavigatorSaveItem
        '
        Me.EstudiosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.EstudiosBindingNavigatorSaveItem.Image = CType(resources.GetObject("EstudiosBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.EstudiosBindingNavigatorSaveItem.Name = "EstudiosBindingNavigatorSaveItem"
        Me.EstudiosBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.EstudiosBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'IdPostulanteLabel
        '
        IdPostulanteLabel.AutoSize = True
        IdPostulanteLabel.Location = New System.Drawing.Point(35, 76)
        IdPostulanteLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        IdPostulanteLabel.Name = "IdPostulanteLabel"
        IdPostulanteLabel.Size = New System.Drawing.Size(121, 20)
        IdPostulanteLabel.TabIndex = 1
        IdPostulanteLabel.Text = "Id Postulante:"
        '
        'IdPostulanteTextBox
        '
        Me.IdPostulanteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EstudiosBindingSource, "IdPostulante", True))
        Me.IdPostulanteTextBox.Location = New System.Drawing.Point(203, 71)
        Me.IdPostulanteTextBox.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.IdPostulanteTextBox.Name = "IdPostulanteTextBox"
        Me.IdPostulanteTextBox.Size = New System.Drawing.Size(81, 26)
        Me.IdPostulanteTextBox.TabIndex = 2
        '
        'CodEstudiosLabel
        '
        CodEstudiosLabel.AutoSize = True
        CodEstudiosLabel.Location = New System.Drawing.Point(35, 116)
        CodEstudiosLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        CodEstudiosLabel.Name = "CodEstudiosLabel"
        CodEstudiosLabel.Size = New System.Drawing.Size(121, 20)
        CodEstudiosLabel.TabIndex = 3
        CodEstudiosLabel.Text = "Cod Estudios:"
        '
        'CodEstudiosTextBox
        '
        Me.CodEstudiosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EstudiosBindingSource, "CodEstudios", True))
        Me.CodEstudiosTextBox.Location = New System.Drawing.Point(203, 111)
        Me.CodEstudiosTextBox.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.CodEstudiosTextBox.Name = "CodEstudiosTextBox"
        Me.CodEstudiosTextBox.Size = New System.Drawing.Size(81, 26)
        Me.CodEstudiosTextBox.TabIndex = 4
        '
        'GradoAcademicoLabel
        '
        GradoAcademicoLabel.AutoSize = True
        GradoAcademicoLabel.Location = New System.Drawing.Point(35, 156)
        GradoAcademicoLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        GradoAcademicoLabel.Name = "GradoAcademicoLabel"
        GradoAcademicoLabel.Size = New System.Drawing.Size(157, 20)
        GradoAcademicoLabel.TabIndex = 5
        GradoAcademicoLabel.Text = "Grado Academico:"
        '
        'GradoAcademicoTextBox
        '
        Me.GradoAcademicoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EstudiosBindingSource, "GradoAcademico", True))
        Me.GradoAcademicoTextBox.Location = New System.Drawing.Point(203, 151)
        Me.GradoAcademicoTextBox.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.GradoAcademicoTextBox.Name = "GradoAcademicoTextBox"
        Me.GradoAcademicoTextBox.Size = New System.Drawing.Size(281, 26)
        Me.GradoAcademicoTextBox.TabIndex = 6
        '
        'InstitucionLabel
        '
        InstitucionLabel.AutoSize = True
        InstitucionLabel.Location = New System.Drawing.Point(35, 196)
        InstitucionLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        InstitucionLabel.Name = "InstitucionLabel"
        InstitucionLabel.Size = New System.Drawing.Size(98, 20)
        InstitucionLabel.TabIndex = 7
        InstitucionLabel.Text = "Institucion:"
        '
        'InstitucionTextBox
        '
        Me.InstitucionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EstudiosBindingSource, "Institucion", True))
        Me.InstitucionTextBox.Location = New System.Drawing.Point(203, 191)
        Me.InstitucionTextBox.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.InstitucionTextBox.Name = "InstitucionTextBox"
        Me.InstitucionTextBox.Size = New System.Drawing.Size(281, 26)
        Me.InstitucionTextBox.TabIndex = 8
        '
        'CarreraLabel
        '
        CarreraLabel.AutoSize = True
        CarreraLabel.Location = New System.Drawing.Point(35, 236)
        CarreraLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        CarreraLabel.Name = "CarreraLabel"
        CarreraLabel.Size = New System.Drawing.Size(74, 20)
        CarreraLabel.TabIndex = 9
        CarreraLabel.Text = "Carrera:"
        '
        'CarreraTextBox
        '
        Me.CarreraTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EstudiosBindingSource, "Carrera", True))
        Me.CarreraTextBox.Location = New System.Drawing.Point(203, 231)
        Me.CarreraTextBox.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.CarreraTextBox.Name = "CarreraTextBox"
        Me.CarreraTextBox.Size = New System.Drawing.Size(281, 26)
        Me.CarreraTextBox.TabIndex = 10
        '
        'FechaInicioLabel
        '
        FechaInicioLabel.AutoSize = True
        FechaInicioLabel.Location = New System.Drawing.Point(35, 277)
        FechaInicioLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        FechaInicioLabel.Name = "FechaInicioLabel"
        FechaInicioLabel.Size = New System.Drawing.Size(112, 20)
        FechaInicioLabel.TabIndex = 11
        FechaInicioLabel.Text = "Fecha Inicio:"
        '
        'FechaInicioDateTimePicker
        '
        Me.FechaInicioDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.EstudiosBindingSource, "FechaInicio", True))
        Me.FechaInicioDateTimePicker.Location = New System.Drawing.Point(203, 271)
        Me.FechaInicioDateTimePicker.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.FechaInicioDateTimePicker.Name = "FechaInicioDateTimePicker"
        Me.FechaInicioDateTimePicker.Size = New System.Drawing.Size(315, 26)
        Me.FechaInicioDateTimePicker.TabIndex = 12
        '
        'AlPresenteLabel
        '
        AlPresenteLabel.AutoSize = True
        AlPresenteLabel.Location = New System.Drawing.Point(35, 316)
        AlPresenteLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        AlPresenteLabel.Name = "AlPresenteLabel"
        AlPresenteLabel.Size = New System.Drawing.Size(107, 20)
        AlPresenteLabel.TabIndex = 13
        AlPresenteLabel.Text = "Al Presente:"
        '
        'AlPresenteTextBox
        '
        Me.AlPresenteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EstudiosBindingSource, "AlPresente", True))
        Me.AlPresenteTextBox.Location = New System.Drawing.Point(203, 311)
        Me.AlPresenteTextBox.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.AlPresenteTextBox.Name = "AlPresenteTextBox"
        Me.AlPresenteTextBox.Size = New System.Drawing.Size(81, 26)
        Me.AlPresenteTextBox.TabIndex = 14
        '
        'FechaFinLabel
        '
        FechaFinLabel.AutoSize = True
        FechaFinLabel.Location = New System.Drawing.Point(35, 357)
        FechaFinLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        FechaFinLabel.Name = "FechaFinLabel"
        FechaFinLabel.Size = New System.Drawing.Size(94, 20)
        FechaFinLabel.TabIndex = 15
        FechaFinLabel.Text = "Fecha Fin:"
        '
        'FechaFinDateTimePicker
        '
        Me.FechaFinDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.EstudiosBindingSource, "FechaFin", True))
        Me.FechaFinDateTimePicker.Location = New System.Drawing.Point(203, 351)
        Me.FechaFinDateTimePicker.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.FechaFinDateTimePicker.Name = "FechaFinDateTimePicker"
        Me.FechaFinDateTimePicker.Size = New System.Drawing.Size(315, 26)
        Me.FechaFinDateTimePicker.TabIndex = 16
        '
        'Estudios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(575, 440)
        Me.Controls.Add(IdPostulanteLabel)
        Me.Controls.Add(Me.IdPostulanteTextBox)
        Me.Controls.Add(CodEstudiosLabel)
        Me.Controls.Add(Me.CodEstudiosTextBox)
        Me.Controls.Add(GradoAcademicoLabel)
        Me.Controls.Add(Me.GradoAcademicoTextBox)
        Me.Controls.Add(InstitucionLabel)
        Me.Controls.Add(Me.InstitucionTextBox)
        Me.Controls.Add(CarreraLabel)
        Me.Controls.Add(Me.CarreraTextBox)
        Me.Controls.Add(FechaInicioLabel)
        Me.Controls.Add(Me.FechaInicioDateTimePicker)
        Me.Controls.Add(AlPresenteLabel)
        Me.Controls.Add(Me.AlPresenteTextBox)
        Me.Controls.Add(FechaFinLabel)
        Me.Controls.Add(Me.FechaFinDateTimePicker)
        Me.Controls.Add(Me.EstudiosBindingNavigator)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Name = "Estudios"
        Me.Text = "Estudios"
        CType(Me.BD_ContratacionEmpleosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstudiosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstudiosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EstudiosBindingNavigator.ResumeLayout(False)
        Me.EstudiosBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BD_ContratacionEmpleosDataSet As BD_ContratacionEmpleosDataSet
    Friend WithEvents EstudiosBindingSource As BindingSource
    Friend WithEvents EstudiosTableAdapter As BD_ContratacionEmpleosDataSetTableAdapters.EstudiosTableAdapter
    Friend WithEvents TableAdapterManager As BD_ContratacionEmpleosDataSetTableAdapters.TableAdapterManager
    Friend WithEvents EstudiosBindingNavigator As BindingNavigator
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
    Friend WithEvents EstudiosBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents IdPostulanteTextBox As TextBox
    Friend WithEvents CodEstudiosTextBox As TextBox
    Friend WithEvents GradoAcademicoTextBox As TextBox
    Friend WithEvents InstitucionTextBox As TextBox
    Friend WithEvents CarreraTextBox As TextBox
    Friend WithEvents FechaInicioDateTimePicker As DateTimePicker
    Friend WithEvents AlPresenteTextBox As TextBox
    Friend WithEvents FechaFinDateTimePicker As DateTimePicker
End Class
