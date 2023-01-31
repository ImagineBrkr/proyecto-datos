<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OfertaEvaluacion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OfertaEvaluacion))
        Dim IdEvaluacionLabel As System.Windows.Forms.Label
        Dim CodOfertaLabel As System.Windows.Forms.Label
        Dim CalificacionMinimaLabel As System.Windows.Forms.Label
        Me.BD_ContratacionEmpleosDataSet = New SISTEMA_COLOCACION.BD_ContratacionEmpleosDataSet()
        Me.Oferta_EvaluacionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Oferta_EvaluacionTableAdapter = New SISTEMA_COLOCACION.BD_ContratacionEmpleosDataSetTableAdapters.Oferta_EvaluacionTableAdapter()
        Me.TableAdapterManager = New SISTEMA_COLOCACION.BD_ContratacionEmpleosDataSetTableAdapters.TableAdapterManager()
        Me.Oferta_EvaluacionBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Oferta_EvaluacionBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IdEvaluacionTextBox = New System.Windows.Forms.TextBox()
        Me.CodOfertaTextBox = New System.Windows.Forms.TextBox()
        Me.CalificacionMinimaTextBox = New System.Windows.Forms.TextBox()
        IdEvaluacionLabel = New System.Windows.Forms.Label()
        CodOfertaLabel = New System.Windows.Forms.Label()
        CalificacionMinimaLabel = New System.Windows.Forms.Label()
        CType(Me.BD_ContratacionEmpleosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Oferta_EvaluacionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Oferta_EvaluacionBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Oferta_EvaluacionBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'BD_ContratacionEmpleosDataSet
        '
        Me.BD_ContratacionEmpleosDataSet.DataSetName = "BD_ContratacionEmpleosDataSet"
        Me.BD_ContratacionEmpleosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Oferta_EvaluacionBindingSource
        '
        Me.Oferta_EvaluacionBindingSource.DataMember = "Oferta_Evaluacion"
        Me.Oferta_EvaluacionBindingSource.DataSource = Me.BD_ContratacionEmpleosDataSet
        '
        'Oferta_EvaluacionTableAdapter
        '
        Me.Oferta_EvaluacionTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.Oferta_EvaluacionTableAdapter = Me.Oferta_EvaluacionTableAdapter
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
        'Oferta_EvaluacionBindingNavigator
        '
        Me.Oferta_EvaluacionBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Oferta_EvaluacionBindingNavigator.BindingSource = Me.Oferta_EvaluacionBindingSource
        Me.Oferta_EvaluacionBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Oferta_EvaluacionBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Oferta_EvaluacionBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Oferta_EvaluacionBindingNavigatorSaveItem})
        Me.Oferta_EvaluacionBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Oferta_EvaluacionBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Oferta_EvaluacionBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Oferta_EvaluacionBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Oferta_EvaluacionBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Oferta_EvaluacionBindingNavigator.Name = "Oferta_EvaluacionBindingNavigator"
        Me.Oferta_EvaluacionBindingNavigator.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.Oferta_EvaluacionBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Oferta_EvaluacionBindingNavigator.Size = New System.Drawing.Size(470, 25)
        Me.Oferta_EvaluacionBindingNavigator.TabIndex = 0
        Me.Oferta_EvaluacionBindingNavigator.Text = "BindingNavigator1"
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
        'Oferta_EvaluacionBindingNavigatorSaveItem
        '
        Me.Oferta_EvaluacionBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Oferta_EvaluacionBindingNavigatorSaveItem.Image = CType(resources.GetObject("Oferta_EvaluacionBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Oferta_EvaluacionBindingNavigatorSaveItem.Name = "Oferta_EvaluacionBindingNavigatorSaveItem"
        Me.Oferta_EvaluacionBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.Oferta_EvaluacionBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'IdEvaluacionLabel
        '
        IdEvaluacionLabel.AutoSize = True
        IdEvaluacionLabel.Location = New System.Drawing.Point(71, 82)
        IdEvaluacionLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        IdEvaluacionLabel.Name = "IdEvaluacionLabel"
        IdEvaluacionLabel.Size = New System.Drawing.Size(122, 20)
        IdEvaluacionLabel.TabIndex = 1
        IdEvaluacionLabel.Text = "Id Evaluacion:"
        '
        'IdEvaluacionTextBox
        '
        Me.IdEvaluacionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Oferta_EvaluacionBindingSource, "IdEvaluacion", True))
        Me.IdEvaluacionTextBox.Location = New System.Drawing.Point(248, 78)
        Me.IdEvaluacionTextBox.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.IdEvaluacionTextBox.Name = "IdEvaluacionTextBox"
        Me.IdEvaluacionTextBox.Size = New System.Drawing.Size(85, 26)
        Me.IdEvaluacionTextBox.TabIndex = 2
        '
        'CodOfertaLabel
        '
        CodOfertaLabel.AutoSize = True
        CodOfertaLabel.Location = New System.Drawing.Point(71, 122)
        CodOfertaLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        CodOfertaLabel.Name = "CodOfertaLabel"
        CodOfertaLabel.Size = New System.Drawing.Size(102, 20)
        CodOfertaLabel.TabIndex = 3
        CodOfertaLabel.Text = "Cod Oferta:"
        '
        'CodOfertaTextBox
        '
        Me.CodOfertaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Oferta_EvaluacionBindingSource, "CodOferta", True))
        Me.CodOfertaTextBox.Location = New System.Drawing.Point(248, 118)
        Me.CodOfertaTextBox.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.CodOfertaTextBox.Name = "CodOfertaTextBox"
        Me.CodOfertaTextBox.Size = New System.Drawing.Size(85, 26)
        Me.CodOfertaTextBox.TabIndex = 4
        '
        'CalificacionMinimaLabel
        '
        CalificacionMinimaLabel.AutoSize = True
        CalificacionMinimaLabel.Location = New System.Drawing.Point(71, 162)
        CalificacionMinimaLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        CalificacionMinimaLabel.Name = "CalificacionMinimaLabel"
        CalificacionMinimaLabel.Size = New System.Drawing.Size(167, 20)
        CalificacionMinimaLabel.TabIndex = 5
        CalificacionMinimaLabel.Text = "Calificacion Minima:"
        '
        'CalificacionMinimaTextBox
        '
        Me.CalificacionMinimaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Oferta_EvaluacionBindingSource, "CalificacionMinima", True))
        Me.CalificacionMinimaTextBox.Location = New System.Drawing.Point(248, 158)
        Me.CalificacionMinimaTextBox.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.CalificacionMinimaTextBox.Name = "CalificacionMinimaTextBox"
        Me.CalificacionMinimaTextBox.Size = New System.Drawing.Size(85, 26)
        Me.CalificacionMinimaTextBox.TabIndex = 6
        '
        'OfertaEvaluacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(470, 237)
        Me.Controls.Add(IdEvaluacionLabel)
        Me.Controls.Add(Me.IdEvaluacionTextBox)
        Me.Controls.Add(CodOfertaLabel)
        Me.Controls.Add(Me.CodOfertaTextBox)
        Me.Controls.Add(CalificacionMinimaLabel)
        Me.Controls.Add(Me.CalificacionMinimaTextBox)
        Me.Controls.Add(Me.Oferta_EvaluacionBindingNavigator)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Name = "OfertaEvaluacion"
        Me.Text = "OfertaEvaluacion"
        CType(Me.BD_ContratacionEmpleosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Oferta_EvaluacionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Oferta_EvaluacionBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Oferta_EvaluacionBindingNavigator.ResumeLayout(False)
        Me.Oferta_EvaluacionBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BD_ContratacionEmpleosDataSet As BD_ContratacionEmpleosDataSet
    Friend WithEvents Oferta_EvaluacionBindingSource As BindingSource
    Friend WithEvents Oferta_EvaluacionTableAdapter As BD_ContratacionEmpleosDataSetTableAdapters.Oferta_EvaluacionTableAdapter
    Friend WithEvents TableAdapterManager As BD_ContratacionEmpleosDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Oferta_EvaluacionBindingNavigator As BindingNavigator
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
    Friend WithEvents Oferta_EvaluacionBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents IdEvaluacionTextBox As TextBox
    Friend WithEvents CodOfertaTextBox As TextBox
    Friend WithEvents CalificacionMinimaTextBox As TextBox
End Class
