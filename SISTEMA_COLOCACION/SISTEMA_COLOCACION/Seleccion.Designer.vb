<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Seleccion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Seleccion))
        Dim IdPostulanteLabel As System.Windows.Forms.Label
        Dim CodOfertaLabel As System.Windows.Forms.Label
        Dim CodDirectorLabel As System.Windows.Forms.Label
        Dim ResultadoLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Me.BD_ContratacionEmpleosDataSet = New SISTEMA_COLOCACION.BD_ContratacionEmpleosDataSet()
        Me.Postulacion_SeleccionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Postulacion_SeleccionTableAdapter = New SISTEMA_COLOCACION.BD_ContratacionEmpleosDataSetTableAdapters.Postulacion_SeleccionTableAdapter()
        Me.TableAdapterManager = New SISTEMA_COLOCACION.BD_ContratacionEmpleosDataSetTableAdapters.TableAdapterManager()
        Me.Postulacion_SeleccionBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Postulacion_SeleccionBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IdPostulanteTextBox = New System.Windows.Forms.TextBox()
        Me.CodOfertaTextBox = New System.Windows.Forms.TextBox()
        Me.CodDirectorTextBox = New System.Windows.Forms.TextBox()
        Me.ResultadoTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.OfertaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OfertaTableAdapter = New SISTEMA_COLOCACION.BD_ContratacionEmpleosDataSetTableAdapters.OfertaTableAdapter()
        Me.Label2 = New System.Windows.Forms.Label()
        IdPostulanteLabel = New System.Windows.Forms.Label()
        CodOfertaLabel = New System.Windows.Forms.Label()
        CodDirectorLabel = New System.Windows.Forms.Label()
        ResultadoLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        CType(Me.BD_ContratacionEmpleosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Postulacion_SeleccionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Postulacion_SeleccionBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Postulacion_SeleccionBindingNavigator.SuspendLayout()
        CType(Me.OfertaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BD_ContratacionEmpleosDataSet
        '
        Me.BD_ContratacionEmpleosDataSet.DataSetName = "BD_ContratacionEmpleosDataSet"
        Me.BD_ContratacionEmpleosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Postulacion_SeleccionBindingSource
        '
        Me.Postulacion_SeleccionBindingSource.DataMember = "Postulacion_Seleccion"
        Me.Postulacion_SeleccionBindingSource.DataSource = Me.BD_ContratacionEmpleosDataSet
        '
        'Postulacion_SeleccionTableAdapter
        '
        Me.Postulacion_SeleccionTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.Postulacion_SeleccionTableAdapter = Me.Postulacion_SeleccionTableAdapter
        Me.TableAdapterManager.Postulante_EvaluacionTableAdapter = Nothing
        Me.TableAdapterManager.PostulanteTableAdapter = Nothing
        Me.TableAdapterManager.ReferenciasTableAdapter = Nothing
        Me.TableAdapterManager.RegionTableAdapter = Nothing
        Me.TableAdapterManager.RequerimientoTableAdapter = Nothing
        Me.TableAdapterManager.SoftwareTableAdapter = Nothing
        Me.TableAdapterManager.TipoEvaluacionTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SISTEMA_COLOCACION.BD_ContratacionEmpleosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Postulacion_SeleccionBindingNavigator
        '
        Me.Postulacion_SeleccionBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Postulacion_SeleccionBindingNavigator.BindingSource = Me.Postulacion_SeleccionBindingSource
        Me.Postulacion_SeleccionBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Postulacion_SeleccionBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Postulacion_SeleccionBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Postulacion_SeleccionBindingNavigatorSaveItem})
        Me.Postulacion_SeleccionBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Postulacion_SeleccionBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Postulacion_SeleccionBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Postulacion_SeleccionBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Postulacion_SeleccionBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Postulacion_SeleccionBindingNavigator.Name = "Postulacion_SeleccionBindingNavigator"
        Me.Postulacion_SeleccionBindingNavigator.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.Postulacion_SeleccionBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Postulacion_SeleccionBindingNavigator.Size = New System.Drawing.Size(648, 25)
        Me.Postulacion_SeleccionBindingNavigator.TabIndex = 0
        Me.Postulacion_SeleccionBindingNavigator.Text = "BindingNavigator1"
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
        'Postulacion_SeleccionBindingNavigatorSaveItem
        '
        Me.Postulacion_SeleccionBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Postulacion_SeleccionBindingNavigatorSaveItem.Image = CType(resources.GetObject("Postulacion_SeleccionBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Postulacion_SeleccionBindingNavigatorSaveItem.Name = "Postulacion_SeleccionBindingNavigatorSaveItem"
        Me.Postulacion_SeleccionBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.Postulacion_SeleccionBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'IdPostulanteLabel
        '
        IdPostulanteLabel.AutoSize = True
        IdPostulanteLabel.Location = New System.Drawing.Point(63, 67)
        IdPostulanteLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        IdPostulanteLabel.Name = "IdPostulanteLabel"
        IdPostulanteLabel.Size = New System.Drawing.Size(121, 20)
        IdPostulanteLabel.TabIndex = 1
        IdPostulanteLabel.Text = "Id Postulante:"
        '
        'IdPostulanteTextBox
        '
        Me.IdPostulanteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Postulacion_SeleccionBindingSource, "IdPostulante", True))
        Me.IdPostulanteTextBox.Location = New System.Drawing.Point(193, 62)
        Me.IdPostulanteTextBox.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.IdPostulanteTextBox.Name = "IdPostulanteTextBox"
        Me.IdPostulanteTextBox.Size = New System.Drawing.Size(80, 26)
        Me.IdPostulanteTextBox.TabIndex = 2
        '
        'CodOfertaLabel
        '
        CodOfertaLabel.AutoSize = True
        CodOfertaLabel.Location = New System.Drawing.Point(63, 107)
        CodOfertaLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        CodOfertaLabel.Name = "CodOfertaLabel"
        CodOfertaLabel.Size = New System.Drawing.Size(102, 20)
        CodOfertaLabel.TabIndex = 3
        CodOfertaLabel.Text = "Cod Oferta:"
        '
        'CodOfertaTextBox
        '
        Me.CodOfertaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Postulacion_SeleccionBindingSource, "CodOferta", True))
        Me.CodOfertaTextBox.Location = New System.Drawing.Point(193, 102)
        Me.CodOfertaTextBox.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.CodOfertaTextBox.Name = "CodOfertaTextBox"
        Me.CodOfertaTextBox.Size = New System.Drawing.Size(80, 26)
        Me.CodOfertaTextBox.TabIndex = 4
        '
        'CodDirectorLabel
        '
        CodDirectorLabel.AutoSize = True
        CodDirectorLabel.Location = New System.Drawing.Point(63, 147)
        CodDirectorLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        CodDirectorLabel.Name = "CodDirectorLabel"
        CodDirectorLabel.Size = New System.Drawing.Size(115, 20)
        CodDirectorLabel.TabIndex = 5
        CodDirectorLabel.Text = "Cod Director:"
        '
        'CodDirectorTextBox
        '
        Me.CodDirectorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Postulacion_SeleccionBindingSource, "CodDirector", True))
        Me.CodDirectorTextBox.Location = New System.Drawing.Point(193, 142)
        Me.CodDirectorTextBox.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.CodDirectorTextBox.Name = "CodDirectorTextBox"
        Me.CodDirectorTextBox.Size = New System.Drawing.Size(80, 26)
        Me.CodDirectorTextBox.TabIndex = 6
        '
        'ResultadoLabel
        '
        ResultadoLabel.AutoSize = True
        ResultadoLabel.Location = New System.Drawing.Point(63, 187)
        ResultadoLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        ResultadoLabel.Name = "ResultadoLabel"
        ResultadoLabel.Size = New System.Drawing.Size(96, 20)
        ResultadoLabel.TabIndex = 7
        ResultadoLabel.Text = "Resultado:"
        '
        'ResultadoTextBox
        '
        Me.ResultadoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Postulacion_SeleccionBindingSource, "Resultado", True))
        Me.ResultadoTextBox.Location = New System.Drawing.Point(193, 182)
        Me.ResultadoTextBox.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ResultadoTextBox.Name = "ResultadoTextBox"
        Me.ResultadoTextBox.Size = New System.Drawing.Size(213, 26)
        Me.ResultadoTextBox.TabIndex = 8
        Me.ResultadoTextBox.Text = "En evaluacion"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(461, 298)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(103, 35)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Evaluar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(63, 305)
        Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(60, 20)
        Label1.TabIndex = 10
        Label1.Text = "Oferta"
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.OfertaBindingSource
        Me.ComboBox1.DisplayMember = "Descripcion"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(193, 298)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(213, 28)
        Me.ComboBox1.TabIndex = 11
        Me.ComboBox1.ValueMember = "CodOferta"
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(63, 243)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(479, 20)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Seleccionar postulantes segun resultados de evaluaciones"
        '
        'Seleccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(648, 351)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(IdPostulanteLabel)
        Me.Controls.Add(Me.IdPostulanteTextBox)
        Me.Controls.Add(CodOfertaLabel)
        Me.Controls.Add(Me.CodOfertaTextBox)
        Me.Controls.Add(CodDirectorLabel)
        Me.Controls.Add(Me.CodDirectorTextBox)
        Me.Controls.Add(ResultadoLabel)
        Me.Controls.Add(Me.ResultadoTextBox)
        Me.Controls.Add(Me.Postulacion_SeleccionBindingNavigator)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Name = "Seleccion"
        Me.Text = "Seleccion"
        CType(Me.BD_ContratacionEmpleosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Postulacion_SeleccionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Postulacion_SeleccionBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Postulacion_SeleccionBindingNavigator.ResumeLayout(False)
        Me.Postulacion_SeleccionBindingNavigator.PerformLayout()
        CType(Me.OfertaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BD_ContratacionEmpleosDataSet As BD_ContratacionEmpleosDataSet
    Friend WithEvents Postulacion_SeleccionBindingSource As BindingSource
    Friend WithEvents Postulacion_SeleccionTableAdapter As BD_ContratacionEmpleosDataSetTableAdapters.Postulacion_SeleccionTableAdapter
    Friend WithEvents TableAdapterManager As BD_ContratacionEmpleosDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Postulacion_SeleccionBindingNavigator As BindingNavigator
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
    Friend WithEvents Postulacion_SeleccionBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents OfertaTableAdapter As BD_ContratacionEmpleosDataSetTableAdapters.OfertaTableAdapter
    Friend WithEvents IdPostulanteTextBox As TextBox
    Friend WithEvents CodOfertaTextBox As TextBox
    Friend WithEvents CodDirectorTextBox As TextBox
    Friend WithEvents ResultadoTextBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents OfertaBindingSource As BindingSource
    Friend WithEvents Label2 As Label
End Class
