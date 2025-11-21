<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAlmacenes
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer


    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAlmacenes))
        Label1 = New Label()
        Label2 = New Label()
        txtNombre = New TextBox()
        txtUbicacion = New TextBox()
        txtCapacidad = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        cboEncargado = New ComboBox()
        dgvAlmacenes = New DataGridView()
        btnActualizar = New Button()
        txtIdAlmacen = New TextBox()
        btnAgregar = New Button()
        cboEstado = New ComboBox()
        CType(dgvAlmacenes, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("UD Digi Kyokasho NP-B", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(22, 337)
        Label1.Name = "Label1"
        Label1.Size = New Size(59, 14)
        Label1.TabIndex = 0
        Label1.Text = "Nombre:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("UD Digi Kyokasho NP-B", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(12, 376)
        Label2.Name = "Label2"
        Label2.Size = New Size(74, 14)
        Label2.TabIndex = 1
        Label2.Text = "Ubicación:"
        Label2.UseMnemonic = False
        ' 
        ' txtNombre
        ' 
        txtNombre.Location = New Point(98, 333)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(232, 23)
        txtNombre.TabIndex = 2
        ' 
        ' txtUbicacion
        ' 
        txtUbicacion.Location = New Point(98, 372)
        txtUbicacion.Name = "txtUbicacion"
        txtUbicacion.Size = New Size(232, 23)
        txtUbicacion.TabIndex = 3
        ' 
        ' txtCapacidad
        ' 
        txtCapacidad.Location = New Point(493, 334)
        txtCapacidad.Name = "txtCapacidad"
        txtCapacidad.Size = New Size(100, 23)
        txtCapacidad.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("UD Digi Kyokasho NP-B", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(378, 338)
        Label3.Name = "Label3"
        Label3.Size = New Size(83, 14)
        Label3.TabIndex = 5
        Label3.Text = "Capacidad: "
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("UD Digi Kyokasho NP-B", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        Label4.ForeColor = Color.White
        Label4.Location = New Point(378, 372)
        Label4.Name = "Label4"
        Label4.Size = New Size(95, 14)
        Label4.TabIndex = 6
        Label4.Text = "Encargado id:"
        ' 
        ' cboEncargado
        ' 
        cboEncargado.DropDownStyle = ComboBoxStyle.DropDownList
        cboEncargado.FormattingEnabled = True
        cboEncargado.Items.AddRange(New Object() {"1 ", "2"})
        cboEncargado.Location = New Point(493, 367)
        cboEncargado.Name = "cboEncargado"
        cboEncargado.Size = New Size(138, 23)
        cboEncargado.TabIndex = 7
        ' 
        ' dgvAlmacenes
        ' 
        dgvAlmacenes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvAlmacenes.Location = New Point(12, 12)
        dgvAlmacenes.Name = "dgvAlmacenes"
        dgvAlmacenes.ReadOnly = True
        dgvAlmacenes.Size = New Size(787, 308)
        dgvAlmacenes.TabIndex = 8
        ' 
        ' btnActualizar
        ' 
        btnActualizar.Location = New Point(686, 328)
        btnActualizar.Name = "btnActualizar"
        btnActualizar.Size = New Size(75, 23)
        btnActualizar.TabIndex = 9
        btnActualizar.Text = "Actualizar"
        btnActualizar.UseVisualStyleBackColor = True
        ' 
        ' txtIdAlmacen
        ' 
        txtIdAlmacen.Enabled = False
        txtIdAlmacen.Location = New Point(815, 31)
        txtIdAlmacen.Name = "txtIdAlmacen"
        txtIdAlmacen.Size = New Size(83, 23)
        txtIdAlmacen.TabIndex = 10
        ' 
        ' btnAgregar
        ' 
        btnAgregar.Location = New Point(686, 363)
        btnAgregar.Name = "btnAgregar"
        btnAgregar.Size = New Size(75, 23)
        btnAgregar.TabIndex = 11
        btnAgregar.Text = "Agregar"
        btnAgregar.UseVisualStyleBackColor = True
        ' 
        ' cboEstado
        ' 
        cboEstado.DropDownStyle = ComboBoxStyle.DropDownList
        cboEstado.FormattingEnabled = True
        cboEstado.Location = New Point(815, 60)
        cboEstado.Name = "cboEstado"
        cboEstado.Size = New Size(83, 23)
        cboEstado.TabIndex = 13
        ' 
        ' FormAlmacenes
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(910, 447)
        Controls.Add(cboEstado)
        Controls.Add(btnAgregar)
        Controls.Add(txtIdAlmacen)
        Controls.Add(btnActualizar)
        Controls.Add(dgvAlmacenes)
        Controls.Add(cboEncargado)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(txtCapacidad)
        Controls.Add(txtUbicacion)
        Controls.Add(txtNombre)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "FormAlmacenes"
        Text = "FormAlmacenes"
        CType(dgvAlmacenes, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtUbicacion As TextBox
    Friend WithEvents txtCapacidad As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cboEncargado As ComboBox
    Friend WithEvents dgvAlmacenes As DataGridView
    Friend WithEvents btnActualizar As Button
    Friend WithEvents txtIdAlmacen As TextBox
    Friend WithEvents btnAgregar As Button
    Friend WithEvents cboEstado As ComboBox
End Class
