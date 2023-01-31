<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Preseleccion
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BD_ContratacionEmpleosDataSet = New SISTEMA_COLOCACION.BD_ContratacionEmpleosDataSet()
        Me.AreaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AreaTableAdapter = New SISTEMA_COLOCACION.BD_ContratacionEmpleosDataSetTableAdapters.AreaTableAdapter()
        Me.OfertaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OfertaTableAdapter = New SISTEMA_COLOCACION.BD_ContratacionEmpleosDataSetTableAdapters.OfertaTableAdapter()
        Me.PostulanteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PostulanteTableAdapter = New SISTEMA_COLOCACION.BD_ContratacionEmpleosDataSetTableAdapters.PostulanteTableAdapter()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        CType(Me.BD_ContratacionEmpleosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AreaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OfertaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PostulanteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 50)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Oferta"
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.OfertaBindingSource
        Me.ComboBox1.DisplayMember = "Descripcion"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(153, 47)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(368, 28)
        Me.ComboBox1.TabIndex = 1
        Me.ComboBox1.ValueMember = "CodOferta"
        '
        'ComboBox2
        '
        Me.ComboBox2.DataSource = Me.PostulanteBindingSource
        Me.ComboBox2.DisplayMember = "Apellidos"
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(153, 99)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(368, 28)
        Me.ComboBox2.TabIndex = 3
        Me.ComboBox2.ValueMember = "IdPostulante"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(43, 107)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Postulante"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(596, 74)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(89, 25)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Añadir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BD_ContratacionEmpleosDataSet
        '
        Me.BD_ContratacionEmpleosDataSet.DataSetName = "BD_ContratacionEmpleosDataSet"
        Me.BD_ContratacionEmpleosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AreaBindingSource
        '
        Me.AreaBindingSource.DataMember = "Area"
        Me.AreaBindingSource.DataSource = Me.BD_ContratacionEmpleosDataSet
        '
        'AreaTableAdapter
        '
        Me.AreaTableAdapter.ClearBeforeFill = True
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
        'PostulanteBindingSource
        '
        Me.PostulanteBindingSource.DataMember = "Postulante"
        Me.PostulanteBindingSource.DataSource = Me.BD_ContratacionEmpleosDataSet
        '
        'PostulanteTableAdapter
        '
        Me.PostulanteTableAdapter.ClearBeforeFill = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(43, 180)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Resultado"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(153, 174)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(532, 26)
        Me.TextBox1.TabIndex = 6
        '
        'Preseleccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(744, 281)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Name = "Preseleccion"
        Me.Text = "Preseleccion"
        CType(Me.BD_ContratacionEmpleosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AreaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OfertaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PostulanteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents BD_ContratacionEmpleosDataSet As BD_ContratacionEmpleosDataSet
    Friend WithEvents AreaBindingSource As BindingSource
    Friend WithEvents AreaTableAdapter As BD_ContratacionEmpleosDataSetTableAdapters.AreaTableAdapter
    Friend WithEvents OfertaBindingSource As BindingSource
    Friend WithEvents OfertaTableAdapter As BD_ContratacionEmpleosDataSetTableAdapters.OfertaTableAdapter
    Friend WithEvents PostulanteBindingSource As BindingSource
    Friend WithEvents PostulanteTableAdapter As BD_ContratacionEmpleosDataSetTableAdapters.PostulanteTableAdapter
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
End Class
