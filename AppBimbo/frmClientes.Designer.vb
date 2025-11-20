<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmClientes))
        Label9 = New Label()
        Label6 = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label10 = New Label()
        txtIDCliente = New TextBox()
        txtNombreCliente = New TextBox()
        txtRucDni = New TextBox()
        txtDireccion = New TextBox()
        txtTelefono = New TextBox()
        txtEmail = New TextBox()
        Label11 = New Label()
        txtBuscarCliente = New TextBox()
        cboTipoCliente = New ComboBox()
        cboZona = New ComboBox()
        cboEstadoCliente = New ComboBox()
        btnNuevoCliente = New Button()
        btnGuardarCliente = New Button()
        btnActualizarCliente = New Button()
        dgvClientes = New DataGridView()
        CType(dgvClientes, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.White
        Label9.Location = New Point(255, 28)
        Label9.Name = "Label9"
        Label9.Size = New Size(90, 21)
        Label9.TabIndex = 20
        Label9.Text = "CLIENTES:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.White
        Label6.Location = New Point(38, 86)
        Label6.Name = "Label6"
        Label6.Size = New Size(86, 17)
        Label6.TabIndex = 21
        Label6.Text = "ID Producto:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(38, 149)
        Label1.Name = "Label1"
        Label1.Size = New Size(109, 17)
        Label1.TabIndex = 22
        Label1.Text = "Nombre Cliente:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(38, 224)
        Label2.Name = "Label2"
        Label2.Size = New Size(67, 17)
        Label2.TabIndex = 23
        Label2.Text = "RUC/DNI:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(38, 281)
        Label3.Name = "Label3"
        Label3.Size = New Size(87, 17)
        Label3.TabIndex = 24
        Label3.Text = "Tipo Cliente:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.White
        Label4.Location = New Point(37, 338)
        Label4.Name = "Label4"
        Label4.Size = New Size(70, 17)
        Label4.TabIndex = 25
        Label4.Text = "Dirección:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.White
        Label5.Location = New Point(38, 402)
        Label5.Name = "Label5"
        Label5.Size = New Size(66, 17)
        Label5.TabIndex = 26
        Label5.Text = "Teléfono:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.White
        Label7.Location = New Point(37, 464)
        Label7.Name = "Label7"
        Label7.Size = New Size(48, 17)
        Label7.TabIndex = 27
        Label7.Text = "Gmail:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.White
        Label8.Location = New Point(37, 524)
        Label8.Name = "Label8"
        Label8.Size = New Size(43, 17)
        Label8.TabIndex = 28
        Label8.Text = "Zona:"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.Transparent
        Label10.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = Color.White
        Label10.Location = New Point(37, 582)
        Label10.Name = "Label10"
        Label10.Size = New Size(53, 17)
        Label10.TabIndex = 29
        Label10.Text = "Estado:"
        ' 
        ' txtIDCliente
        ' 
        txtIDCliente.Location = New Point(188, 86)
        txtIDCliente.Name = "txtIDCliente"
        txtIDCliente.ReadOnly = True
        txtIDCliente.Size = New Size(184, 23)
        txtIDCliente.TabIndex = 30
        ' 
        ' txtNombreCliente
        ' 
        txtNombreCliente.Location = New Point(188, 143)
        txtNombreCliente.Name = "txtNombreCliente"
        txtNombreCliente.Size = New Size(184, 23)
        txtNombreCliente.TabIndex = 31
        ' 
        ' txtRucDni
        ' 
        txtRucDni.Location = New Point(188, 218)
        txtRucDni.Name = "txtRucDni"
        txtRucDni.Size = New Size(184, 23)
        txtRucDni.TabIndex = 32
        ' 
        ' txtDireccion
        ' 
        txtDireccion.Location = New Point(188, 338)
        txtDireccion.Name = "txtDireccion"
        txtDireccion.Size = New Size(184, 23)
        txtDireccion.TabIndex = 34
        ' 
        ' txtTelefono
        ' 
        txtTelefono.Location = New Point(188, 396)
        txtTelefono.Name = "txtTelefono"
        txtTelefono.Size = New Size(184, 23)
        txtTelefono.TabIndex = 35
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(188, 464)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(184, 23)
        txtEmail.TabIndex = 36
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.BackColor = Color.Transparent
        Label11.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.ForeColor = Color.White
        Label11.Location = New Point(453, 92)
        Label11.Name = "Label11"
        Label11.Size = New Size(129, 17)
        Label11.TabIndex = 37
        Label11.Text = "Buscar por nombre:"
        ' 
        ' txtBuscarCliente
        ' 
        txtBuscarCliente.Location = New Point(400, 148)
        txtBuscarCliente.Name = "txtBuscarCliente"
        txtBuscarCliente.Size = New Size(263, 23)
        txtBuscarCliente.TabIndex = 38
        ' 
        ' cboTipoCliente
        ' 
        cboTipoCliente.FormattingEnabled = True
        cboTipoCliente.Location = New Point(188, 281)
        cboTipoCliente.Name = "cboTipoCliente"
        cboTipoCliente.Size = New Size(184, 23)
        cboTipoCliente.TabIndex = 39
        ' 
        ' cboZona
        ' 
        cboZona.FormattingEnabled = True
        cboZona.Location = New Point(188, 524)
        cboZona.Name = "cboZona"
        cboZona.Size = New Size(184, 23)
        cboZona.TabIndex = 40
        ' 
        ' cboEstadoCliente
        ' 
        cboEstadoCliente.FormattingEnabled = True
        cboEstadoCliente.Location = New Point(188, 582)
        cboEstadoCliente.Name = "cboEstadoCliente"
        cboEstadoCliente.Size = New Size(184, 23)
        cboEstadoCliente.TabIndex = 41
        ' 
        ' btnNuevoCliente
        ' 
        btnNuevoCliente.Font = New Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnNuevoCliente.ForeColor = Color.Black
        btnNuevoCliente.Location = New Point(400, 576)
        btnNuevoCliente.Name = "btnNuevoCliente"
        btnNuevoCliente.Size = New Size(75, 23)
        btnNuevoCliente.TabIndex = 42
        btnNuevoCliente.Text = "Nuevo"
        btnNuevoCliente.UseVisualStyleBackColor = True
        ' 
        ' btnGuardarCliente
        ' 
        btnGuardarCliente.Font = New Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnGuardarCliente.ForeColor = Color.Black
        btnGuardarCliente.Location = New Point(496, 576)
        btnGuardarCliente.Name = "btnGuardarCliente"
        btnGuardarCliente.Size = New Size(75, 23)
        btnGuardarCliente.TabIndex = 43
        btnGuardarCliente.Text = "Guardar"
        btnGuardarCliente.UseVisualStyleBackColor = True
        ' 
        ' btnActualizarCliente
        ' 
        btnActualizarCliente.Font = New Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnActualizarCliente.ForeColor = Color.Black
        btnActualizarCliente.Location = New Point(588, 576)
        btnActualizarCliente.Name = "btnActualizarCliente"
        btnActualizarCliente.Size = New Size(75, 23)
        btnActualizarCliente.TabIndex = 44
        btnActualizarCliente.Text = "Actualizar"
        btnActualizarCliente.UseVisualStyleBackColor = True
        ' 
        ' dgvClientes
        ' 
        dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvClientes.Location = New Point(400, 205)
        dgvClientes.Name = "dgvClientes"
        dgvClientes.Size = New Size(263, 327)
        dgvClientes.TabIndex = 45
        ' 
        ' frmClientes
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(714, 639)
        Controls.Add(dgvClientes)
        Controls.Add(btnActualizarCliente)
        Controls.Add(btnGuardarCliente)
        Controls.Add(btnNuevoCliente)
        Controls.Add(cboEstadoCliente)
        Controls.Add(cboZona)
        Controls.Add(cboTipoCliente)
        Controls.Add(txtBuscarCliente)
        Controls.Add(Label11)
        Controls.Add(txtEmail)
        Controls.Add(txtTelefono)
        Controls.Add(txtDireccion)
        Controls.Add(txtRucDni)
        Controls.Add(txtNombreCliente)
        Controls.Add(txtIDCliente)
        Controls.Add(Label10)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Label6)
        Controls.Add(Label9)
        Name = "frmClientes"
        Text = "frmClientes"
        CType(dgvClientes, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label9 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtIDCliente As TextBox
    Friend WithEvents txtNombreCliente As TextBox
    Friend WithEvents txtRucDni As TextBox
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtBuscarCliente As TextBox
    Friend WithEvents cboTipoCliente As ComboBox
    Friend WithEvents cboZona As ComboBox
    Friend WithEvents cboEstadoCliente As ComboBox
    Friend WithEvents btnNuevoCliente As Button
    Friend WithEvents btnGuardarCliente As Button
    Friend WithEvents btnActualizarCliente As Button
    Friend WithEvents dgvClientes As DataGridView
End Class
