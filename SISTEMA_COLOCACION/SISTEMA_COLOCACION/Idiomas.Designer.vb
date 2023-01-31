<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Idiomas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Idiomas))
        Dim CodIdiomaLabel As System.Windows.Forms.Label
        Dim IdiomaLabel As System.Windows.Forms.Label
        Dim NivelLabel As System.Windows.Forms.Label
        Dim IdPostulanteLabel As System.Windows.Forms.Label
        Me.BD_ContratacionEmpleosDataSet = New SISTEMA_COLOCACION.BD_ContratacionEmpleosDataSet()
        Me.IdiomasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IdiomasTableAdapter = New SISTEMA_COLOCACION.BD_ContratacionEmpleosDataSetTableAdapters.IdiomasTableAdapter()
        Me.TableAdapterManager = New SISTEMA_COLOCACION.BD_ContratacionEmpleosDataSetTableAdapters.TableAdapterManager()
        Me.IdiomasBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.IdiomasBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.CodIdiomaTextBox = New System.Windows.Forms.TextBox()
        Me.IdiomaTextBox = New System.Windows.Forms.TextBox()
        Me.NivelTextBox = New System.Windows.Forms.TextBox()
        Me.IdPostulanteTextBox = New System.Windows.Forms.TextBox()
        CodIdiomaLabel = New System.Windows.Forms.Label()
        IdiomaLabel = New System.Windows.Forms.Label()
        NivelLabel = New System.Windows.Forms.Label()
        IdPostulanteLabel = New System.Windows.Forms.Label()
        CType(Me.BD_ContratacionEmpleosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IdiomasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IdiomasBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.IdiomasBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'BD_ContratacionEmpleosDataSet
        '
        Me.BD_ContratacionEmpleosDataSet.DataSetName = "BD_ContratacionEmpleosDataSet"
        Me.BD_ContratacionEmpleosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'IdiomasBindingSource
        '
        Me.IdiomasBindingSource.DataMember = "Idiomas"
        Me.IdiomasBindingSource.DataSource = Me.BD_ContratacionEmpleosDataSet
        '
        'IdiomasTableAdapter
        '
        Me.IdiomasTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.IdiomasTableAdapter = Me.IdiomasTableAdapter
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
        'IdiomasBindingNavigator
        '
        Me.IdiomasBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.IdiomasBindingNavigator.BindingSource = Me.IdiomasBindingSource
        Me.IdiomasBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.IdiomasBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.IdiomasBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.IdiomasBindingNavigatorSaveItem})
        Me.IdiomasBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.IdiomasBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.IdiomasBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.IdiomasBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.IdiomasBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.IdiomasBindingNavigator.Name = "IdiomasBindingNavigator"
        Me.IdiomasBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.IdiomasBindingNavigator.Size = New System.Drawing.Size(438, 25)
        Me.IdiomasBindingNavigator.TabIndex = 0
        Me.IdiomasBindingNavigator.Text = "BindingNavigator1"
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
        'IdiomasBindingNavigatorSaveItem
        '
        Me.IdiomasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.IdiomasBindingNavigatorSaveItem.Image = CType(resources.GetObject("IdiomasBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.IdiomasBindingNavigatorSaveItem.Name = "IdiomasBindingNavigatorSaveItem"
        Me.IdiomasBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.IdiomasBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'CodIdiomaLabel
        '
        CodIdiomaLabel.AutoSize = True
        CodIdiomaLabel.Location = New System.Drawing.Point(66, 96)
        CodIdiomaLabel.Name = "CodIdiomaLabel"
        CodIdiomaLabel.Size = New System.Drawing.Size(105, 20)
        CodIdiomaLabel.TabIndex = 1
        CodIdiomaLabel.Text = "Cod Idioma:"
        '
        'CodIdiomaTextBox
        '
        Me.CodIdiomaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IdiomasBindingSource, "CodIdioma", True))
        Me.CodIdiomaTextBox.Location = New System.Drawing.Point(193, 93)
        Me.CodIdiomaTextBox.Name = "CodIdiomaTextBox"
        Me.CodIdiomaTextBox.Size = New System.Drawing.Size(100, 26)
        Me.CodIdiomaTextBox.TabIndex = 2
        '
        'IdiomaLabel
        '
        IdiomaLabel.AutoSize = True
        IdiomaLabel.Location = New System.Drawing.Point(66, 132)
        IdiomaLabel.Name = "IdiomaLabel"
        IdiomaLabel.Size = New System.Drawing.Size(68, 20)
        IdiomaLabel.TabIndex = 3
        IdiomaLabel.Text = "Idioma:"
        '
        'IdiomaTextBox
        '
        Me.IdiomaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IdiomasBindingSource, "Idioma", True))
        Me.IdiomaTextBox.Location = New System.Drawing.Point(193, 129)
        Me.IdiomaTextBox.Name = "IdiomaTextBox"
        Me.IdiomaTextBox.Size = New System.Drawing.Size(171, 26)
        Me.IdiomaTextBox.TabIndex = 4
        '
        'NivelLabel
        '
        NivelLabel.AutoSize = True
        NivelLabel.Location = New System.Drawing.Point(66, 176)
        NivelLabel.Name = "NivelLabel"
        NivelLabel.Size = New System.Drawing.Size(52, 20)
        NivelLabel.TabIndex = 5
        NivelLabel.Text = "Nivel:"
        '
        'NivelTextBox
        '
        Me.NivelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IdiomasBindingSource, "Nivel", True))
        Me.NivelTextBox.Location = New System.Drawing.Point(193, 173)
        Me.NivelTextBox.Name = "NivelTextBox"
        Me.NivelTextBox.Size = New System.Drawing.Size(171, 26)
        Me.NivelTextBox.TabIndex = 6
        '
        'IdPostulanteLabel
        '
        IdPostulanteLabel.AutoSize = True
        IdPostulanteLabel.Location = New System.Drawing.Point(66, 58)
        IdPostulanteLabel.Name = "IdPostulanteLabel"
        IdPostulanteLabel.Size = New System.Drawing.Size(121, 20)
        IdPostulanteLabel.TabIndex = 7
        IdPostulanteLabel.Text = "Id Postulante:"
        '
        'IdPostulanteTextBox
        '
        Me.IdPostulanteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IdiomasBindingSource, "IdPostulante", True))
        Me.IdPostulanteTextBox.Location = New System.Drawing.Point(193, 55)
        Me.IdPostulanteTextBox.Name = "IdPostulanteTextBox"
        Me.IdPostulanteTextBox.Size = New System.Drawing.Size(100, 26)
        Me.IdPostulanteTextBox.TabIndex = 8
        '
        'Idiomas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(438, 257)
        Me.Controls.Add(CodIdiomaLabel)
        Me.Controls.Add(Me.CodIdiomaTextBox)
        Me.Controls.Add(IdiomaLabel)
        Me.Controls.Add(Me.IdiomaTextBox)
        Me.Controls.Add(NivelLabel)
        Me.Controls.Add(Me.NivelTextBox)
        Me.Controls.Add(IdPostulanteLabel)
        Me.Controls.Add(Me.IdPostulanteTextBox)
        Me.Controls.Add(Me.IdiomasBindingNavigator)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Name = "Idiomas"
        Me.Text = "Idiomas"
        CType(Me.BD_ContratacionEmpleosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IdiomasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IdiomasBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.IdiomasBindingNavigator.ResumeLayout(False)
        Me.IdiomasBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BD_ContratacionEmpleosDataSet As BD_ContratacionEmpleosDataSet
    Friend WithEvents IdiomasBindingSource As BindingSource
    Friend WithEvents IdiomasTableAdapter As BD_ContratacionEmpleosDataSetTableAdapters.IdiomasTableAdapter
    Friend WithEvents TableAdapterManager As BD_ContratacionEmpleosDataSetTableAdapters.TableAdapterManager
    Friend WithEvents IdiomasBindingNavigator As BindingNavigator
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
    Friend WithEvents IdiomasBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents CodIdiomaTextBox As TextBox
    Friend WithEvents IdiomaTextBox As TextBox
    Friend WithEvents NivelTextBox As TextBox
    Friend WithEvents IdPostulanteTextBox As TextBox
End Class
