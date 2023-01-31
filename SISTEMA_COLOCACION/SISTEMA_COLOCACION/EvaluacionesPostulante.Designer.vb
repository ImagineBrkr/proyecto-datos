<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EvaluacionesPostulante
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EvaluacionesPostulante))
        Dim IdPostulanteLabel As System.Windows.Forms.Label
        Dim IdEvaluacionLabel As System.Windows.Forms.Label
        Dim CodOfertaLabel As System.Windows.Forms.Label
        Dim FechaEvaluacionLabel As System.Windows.Forms.Label
        Dim CalificacionLabel As System.Windows.Forms.Label
        Me.BD_ContratacionEmpleosDataSet = New SISTEMA_COLOCACION.BD_ContratacionEmpleosDataSet()
        Me.Postulante_EvaluacionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Postulante_EvaluacionTableAdapter = New SISTEMA_COLOCACION.BD_ContratacionEmpleosDataSetTableAdapters.Postulante_EvaluacionTableAdapter()
        Me.TableAdapterManager = New SISTEMA_COLOCACION.BD_ContratacionEmpleosDataSetTableAdapters.TableAdapterManager()
        Me.Postulante_EvaluacionBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Postulante_EvaluacionBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IdPostulanteTextBox = New System.Windows.Forms.TextBox()
        Me.IdEvaluacionTextBox = New System.Windows.Forms.TextBox()
        Me.CodOfertaTextBox = New System.Windows.Forms.TextBox()
        Me.FechaEvaluacionDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.CalificacionTextBox = New System.Windows.Forms.TextBox()
        IdPostulanteLabel = New System.Windows.Forms.Label()
        IdEvaluacionLabel = New System.Windows.Forms.Label()
        CodOfertaLabel = New System.Windows.Forms.Label()
        FechaEvaluacionLabel = New System.Windows.Forms.Label()
        CalificacionLabel = New System.Windows.Forms.Label()
        CType(Me.BD_ContratacionEmpleosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Postulante_EvaluacionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Postulante_EvaluacionBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Postulante_EvaluacionBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'BD_ContratacionEmpleosDataSet
        '
        Me.BD_ContratacionEmpleosDataSet.DataSetName = "BD_ContratacionEmpleosDataSet"
        Me.BD_ContratacionEmpleosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Postulante_EvaluacionBindingSource
        '
        Me.Postulante_EvaluacionBindingSource.DataMember = "Postulante_Evaluacion"
        Me.Postulante_EvaluacionBindingSource.DataSource = Me.BD_ContratacionEmpleosDataSet
        '
        'Postulante_EvaluacionTableAdapter
        '
        Me.Postulante_EvaluacionTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.Postulante_EvaluacionTableAdapter = Me.Postulante_EvaluacionTableAdapter
        Me.TableAdapterManager.PostulanteTableAdapter = Nothing
        Me.TableAdapterManager.ReferenciasTableAdapter = Nothing
        Me.TableAdapterManager.RegionTableAdapter = Nothing
        Me.TableAdapterManager.RequerimientoTableAdapter = Nothing
        Me.TableAdapterManager.SoftwareTableAdapter = Nothing
        Me.TableAdapterManager.TipoEvaluacionTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SISTEMA_COLOCACION.BD_ContratacionEmpleosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Postulante_EvaluacionBindingNavigator
        '
        Me.Postulante_EvaluacionBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Postulante_EvaluacionBindingNavigator.BindingSource = Me.Postulante_EvaluacionBindingSource
        Me.Postulante_EvaluacionBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Postulante_EvaluacionBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Postulante_EvaluacionBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Postulante_EvaluacionBindingNavigatorSaveItem})
        Me.Postulante_EvaluacionBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Postulante_EvaluacionBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Postulante_EvaluacionBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Postulante_EvaluacionBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Postulante_EvaluacionBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Postulante_EvaluacionBindingNavigator.Name = "Postulante_EvaluacionBindingNavigator"
        Me.Postulante_EvaluacionBindingNavigator.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.Postulante_EvaluacionBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Postulante_EvaluacionBindingNavigator.Size = New System.Drawing.Size(586, 25)
        Me.Postulante_EvaluacionBindingNavigator.TabIndex = 0
        Me.Postulante_EvaluacionBindingNavigator.Text = "BindingNavigator1"
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
        'Postulante_EvaluacionBindingNavigatorSaveItem
        '
        Me.Postulante_EvaluacionBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Postulante_EvaluacionBindingNavigatorSaveItem.Image = CType(resources.GetObject("Postulante_EvaluacionBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Postulante_EvaluacionBindingNavigatorSaveItem.Name = "Postulante_EvaluacionBindingNavigatorSaveItem"
        Me.Postulante_EvaluacionBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.Postulante_EvaluacionBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'IdPostulanteLabel
        '
        IdPostulanteLabel.AutoSize = True
        IdPostulanteLabel.Location = New System.Drawing.Point(45, 70)
        IdPostulanteLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        IdPostulanteLabel.Name = "IdPostulanteLabel"
        IdPostulanteLabel.Size = New System.Drawing.Size(121, 20)
        IdPostulanteLabel.TabIndex = 1
        IdPostulanteLabel.Text = "Id Postulante:"
        '
        'IdPostulanteTextBox
        '
        Me.IdPostulanteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Postulante_EvaluacionBindingSource, "IdPostulante", True))
        Me.IdPostulanteTextBox.Location = New System.Drawing.Point(215, 65)
        Me.IdPostulanteTextBox.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.IdPostulanteTextBox.Name = "IdPostulanteTextBox"
        Me.IdPostulanteTextBox.Size = New System.Drawing.Size(95, 26)
        Me.IdPostulanteTextBox.TabIndex = 2
        '
        'IdEvaluacionLabel
        '
        IdEvaluacionLabel.AutoSize = True
        IdEvaluacionLabel.Location = New System.Drawing.Point(45, 110)
        IdEvaluacionLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        IdEvaluacionLabel.Name = "IdEvaluacionLabel"
        IdEvaluacionLabel.Size = New System.Drawing.Size(122, 20)
        IdEvaluacionLabel.TabIndex = 3
        IdEvaluacionLabel.Text = "Id Evaluacion:"
        '
        'IdEvaluacionTextBox
        '
        Me.IdEvaluacionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Postulante_EvaluacionBindingSource, "IdEvaluacion", True))
        Me.IdEvaluacionTextBox.Location = New System.Drawing.Point(215, 105)
        Me.IdEvaluacionTextBox.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.IdEvaluacionTextBox.Name = "IdEvaluacionTextBox"
        Me.IdEvaluacionTextBox.Size = New System.Drawing.Size(95, 26)
        Me.IdEvaluacionTextBox.TabIndex = 4
        '
        'CodOfertaLabel
        '
        CodOfertaLabel.AutoSize = True
        CodOfertaLabel.Location = New System.Drawing.Point(45, 150)
        CodOfertaLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        CodOfertaLabel.Name = "CodOfertaLabel"
        CodOfertaLabel.Size = New System.Drawing.Size(102, 20)
        CodOfertaLabel.TabIndex = 5
        CodOfertaLabel.Text = "Cod Oferta:"
        '
        'CodOfertaTextBox
        '
        Me.CodOfertaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Postulante_EvaluacionBindingSource, "CodOferta", True))
        Me.CodOfertaTextBox.Location = New System.Drawing.Point(215, 145)
        Me.CodOfertaTextBox.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.CodOfertaTextBox.Name = "CodOfertaTextBox"
        Me.CodOfertaTextBox.Size = New System.Drawing.Size(95, 26)
        Me.CodOfertaTextBox.TabIndex = 6
        '
        'FechaEvaluacionLabel
        '
        FechaEvaluacionLabel.AutoSize = True
        FechaEvaluacionLabel.Location = New System.Drawing.Point(45, 191)
        FechaEvaluacionLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        FechaEvaluacionLabel.Name = "FechaEvaluacionLabel"
        FechaEvaluacionLabel.Size = New System.Drawing.Size(156, 20)
        FechaEvaluacionLabel.TabIndex = 7
        FechaEvaluacionLabel.Text = "Fecha Evaluacion:"
        '
        'FechaEvaluacionDateTimePicker
        '
        Me.FechaEvaluacionDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Postulante_EvaluacionBindingSource, "FechaEvaluacion", True))
        Me.FechaEvaluacionDateTimePicker.Location = New System.Drawing.Point(215, 185)
        Me.FechaEvaluacionDateTimePicker.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.FechaEvaluacionDateTimePicker.Name = "FechaEvaluacionDateTimePicker"
        Me.FechaEvaluacionDateTimePicker.Size = New System.Drawing.Size(331, 26)
        Me.FechaEvaluacionDateTimePicker.TabIndex = 8
        '
        'CalificacionLabel
        '
        CalificacionLabel.AutoSize = True
        CalificacionLabel.Location = New System.Drawing.Point(45, 230)
        CalificacionLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        CalificacionLabel.Name = "CalificacionLabel"
        CalificacionLabel.Size = New System.Drawing.Size(106, 20)
        CalificacionLabel.TabIndex = 9
        CalificacionLabel.Text = "Calificacion:"
        '
        'CalificacionTextBox
        '
        Me.CalificacionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Postulante_EvaluacionBindingSource, "Calificacion", True))
        Me.CalificacionTextBox.Location = New System.Drawing.Point(215, 225)
        Me.CalificacionTextBox.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.CalificacionTextBox.Name = "CalificacionTextBox"
        Me.CalificacionTextBox.Size = New System.Drawing.Size(95, 26)
        Me.CalificacionTextBox.TabIndex = 10
        '
        'EvaluacionesPostulante
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(586, 307)
        Me.Controls.Add(IdPostulanteLabel)
        Me.Controls.Add(Me.IdPostulanteTextBox)
        Me.Controls.Add(IdEvaluacionLabel)
        Me.Controls.Add(Me.IdEvaluacionTextBox)
        Me.Controls.Add(CodOfertaLabel)
        Me.Controls.Add(Me.CodOfertaTextBox)
        Me.Controls.Add(FechaEvaluacionLabel)
        Me.Controls.Add(Me.FechaEvaluacionDateTimePicker)
        Me.Controls.Add(CalificacionLabel)
        Me.Controls.Add(Me.CalificacionTextBox)
        Me.Controls.Add(Me.Postulante_EvaluacionBindingNavigator)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Name = "EvaluacionesPostulante"
        Me.Text = "EvaluacionesPostulante"
        CType(Me.BD_ContratacionEmpleosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Postulante_EvaluacionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Postulante_EvaluacionBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Postulante_EvaluacionBindingNavigator.ResumeLayout(False)
        Me.Postulante_EvaluacionBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BD_ContratacionEmpleosDataSet As BD_ContratacionEmpleosDataSet
    Friend WithEvents Postulante_EvaluacionBindingSource As BindingSource
    Friend WithEvents Postulante_EvaluacionTableAdapter As BD_ContratacionEmpleosDataSetTableAdapters.Postulante_EvaluacionTableAdapter
    Friend WithEvents TableAdapterManager As BD_ContratacionEmpleosDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Postulante_EvaluacionBindingNavigator As BindingNavigator
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
    Friend WithEvents Postulante_EvaluacionBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents IdPostulanteTextBox As TextBox
    Friend WithEvents IdEvaluacionTextBox As TextBox
    Friend WithEvents CodOfertaTextBox As TextBox
    Friend WithEvents FechaEvaluacionDateTimePicker As DateTimePicker
    Friend WithEvents CalificacionTextBox As TextBox
End Class
