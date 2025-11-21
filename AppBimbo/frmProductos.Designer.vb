<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProductos))
        Label6 = New Label()
        txtIDProducto = New TextBox()
        txtNombre = New TextBox()
        txtDescripcion = New TextBox()
        txtPrecio = New TextBox()
        txtPeso = New TextBox()
        cboEstado = New ComboBox()
        btnNuevo = New Button()
        btnGuardar = New Button()
        btnActualizar = New Button()
        dgvProductos = New DataGridView()
        txtBuscarNombre = New TextBox()
        Label9 = New Label()
        Label1 = New Label()
        Label7 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        CType(dgvProductos, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.White
        Label6.Location = New Point(61, 85)
        Label6.Name = "Label6"
        Label6.Size = New Size(111, 23)
        Label6.TabIndex = 5
        Label6.Text = "ID Producto:"
        ' 
        ' txtIDProducto
        ' 
        txtIDProducto.Location = New Point(181, 81)
        txtIDProducto.Margin = New Padding(3, 4, 3, 4)
        txtIDProducto.Name = "txtIDProducto"
        txtIDProducto.ReadOnly = True
        txtIDProducto.Size = New Size(195, 27)
        txtIDProducto.TabIndex = 6
        ' 
        ' txtNombre
        ' 
        txtNombre.Location = New Point(181, 153)
        txtNombre.Margin = New Padding(3, 4, 3, 4)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(195, 27)
        txtNombre.TabIndex = 7
        ' 
        ' txtDescripcion
        ' 
        txtDescripcion.Location = New Point(181, 223)
        txtDescripcion.Margin = New Padding(3, 4, 3, 4)
        txtDescripcion.Multiline = True
        txtDescripcion.Name = "txtDescripcion"
        txtDescripcion.Size = New Size(195, 29)
        txtDescripcion.TabIndex = 8
        ' 
        ' txtPrecio
        ' 
        txtPrecio.Location = New Point(181, 303)
        txtPrecio.Margin = New Padding(3, 4, 3, 4)
        txtPrecio.Multiline = True
        txtPrecio.Name = "txtPrecio"
        txtPrecio.Size = New Size(195, 29)
        txtPrecio.TabIndex = 9
        ' 
        ' txtPeso
        ' 
        txtPeso.Location = New Point(181, 381)
        txtPeso.Margin = New Padding(3, 4, 3, 4)
        txtPeso.Multiline = True
        txtPeso.Name = "txtPeso"
        txtPeso.Size = New Size(195, 29)
        txtPeso.TabIndex = 10
        ' 
        ' cboEstado
        ' 
        cboEstado.FormattingEnabled = True
        cboEstado.Location = New Point(181, 459)
        cboEstado.Margin = New Padding(3, 4, 3, 4)
        cboEstado.Name = "cboEstado"
        cboEstado.Size = New Size(195, 28)
        cboEstado.TabIndex = 11
        ' 
        ' btnNuevo
        ' 
        btnNuevo.BackColor = Color.Black
        btnNuevo.FlatStyle = FlatStyle.Flat
        btnNuevo.ForeColor = Color.White
        btnNuevo.Location = New Point(57, 565)
        btnNuevo.Margin = New Padding(3, 4, 3, 4)
        btnNuevo.Name = "btnNuevo"
        btnNuevo.Size = New Size(86, 31)
        btnNuevo.TabIndex = 12
        btnNuevo.Text = "Nuevo"
        btnNuevo.UseVisualStyleBackColor = False
        ' 
        ' btnGuardar
        ' 
        btnGuardar.BackColor = Color.Black
        btnGuardar.FlatStyle = FlatStyle.Flat
        btnGuardar.ForeColor = Color.White
        btnGuardar.Location = New Point(203, 565)
        btnGuardar.Margin = New Padding(3, 4, 3, 4)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(86, 31)
        btnGuardar.TabIndex = 13
        btnGuardar.Text = "Guardar"
        btnGuardar.UseVisualStyleBackColor = False
        ' 
        ' btnActualizar
        ' 
        btnActualizar.BackColor = Color.Black
        btnActualizar.FlatStyle = FlatStyle.Flat
        btnActualizar.ForeColor = Color.White
        btnActualizar.Location = New Point(345, 565)
        btnActualizar.Margin = New Padding(3, 4, 3, 4)
        btnActualizar.Name = "btnActualizar"
        btnActualizar.Size = New Size(86, 31)
        btnActualizar.TabIndex = 14
        btnActualizar.Text = "Actualizar"
        btnActualizar.UseVisualStyleBackColor = False
        ' 
        ' dgvProductos
        ' 
        dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvProductos.Location = New Point(421, 223)
        dgvProductos.Margin = New Padding(3, 4, 3, 4)
        dgvProductos.Name = "dgvProductos"
        dgvProductos.RowHeadersWidth = 51
        dgvProductos.Size = New Size(481, 288)
        dgvProductos.TabIndex = 15
        ' 
        ' txtBuscarNombre
        ' 
        txtBuscarNombre.Location = New Point(591, 140)
        txtBuscarNombre.Margin = New Padding(3, 4, 3, 4)
        txtBuscarNombre.Name = "txtBuscarNombre"
        txtBuscarNombre.Size = New Size(310, 27)
        txtBuscarNombre.TabIndex = 18
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.White
        Label9.Location = New Point(314, 29)
        Label9.Name = "Label9"
        Label9.Size = New Size(344, 28)
        Label9.TabIndex = 19
        Label9.Text = "GESTIÓN DE PRODUCTOS BIMBO:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(57, 155)
        Label1.Name = "Label1"
        Label1.Size = New Size(81, 23)
        Label1.TabIndex = 20
        Label1.Text = "Nombre:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.White
        Label7.Location = New Point(57, 224)
        Label7.Name = "Label7"
        Label7.Size = New Size(108, 23)
        Label7.TabIndex = 21
        Label7.Text = "Descripción:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(61, 304)
        Label2.Name = "Label2"
        Label2.Size = New Size(64, 23)
        Label2.TabIndex = 22
        Label2.Text = "Precio:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(57, 383)
        Label3.Name = "Label3"
        Label3.Size = New Size(88, 23)
        Label3.TabIndex = 23
        Label3.Text = "Peso (kg):"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.White
        Label4.Location = New Point(57, 460)
        Label4.Name = "Label4"
        Label4.Size = New Size(68, 23)
        Label4.TabIndex = 24
        Label4.Text = "Estado:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.White
        Label5.Location = New Point(421, 141)
        Label5.Name = "Label5"
        Label5.Size = New Size(176, 23)
        Label5.TabIndex = 25
        Label5.Text = "Buscar por nombre:"
        ' 
        ' frmProductos
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        AutoValidate = AutoValidate.EnablePreventFocusChange
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(946, 691)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label7)
        Controls.Add(Label1)
        Controls.Add(Label9)
        Controls.Add(txtBuscarNombre)
        Controls.Add(dgvProductos)
        Controls.Add(btnActualizar)
        Controls.Add(btnGuardar)
        Controls.Add(btnNuevo)
        Controls.Add(cboEstado)
        Controls.Add(txtPeso)
        Controls.Add(txtPrecio)
        Controls.Add(txtDescripcion)
        Controls.Add(txtNombre)
        Controls.Add(txtIDProducto)
        Controls.Add(Label6)
        Margin = New Padding(3, 4, 3, 4)
        Name = "frmProductos"
        Text = "frmProductos"
        CType(dgvProductos, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label6 As Label
    Friend WithEvents txtIDProducto As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents txtPeso As TextBox
    Friend WithEvents cboEstado As ComboBox
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnActualizar As Button
    Friend WithEvents dgvProductos As DataGridView
    Friend WithEvents txtBuscarNombre As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
