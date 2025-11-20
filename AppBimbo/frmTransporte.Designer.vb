<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTransporte
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTransporte))
        txtTipo = New TextBox()
        txtPlaca = New TextBox()
        TextBox4 = New TextBox()
        TextBox1 = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        txtCapacidad = New Label()
        btnNuevo = New Button()
        btnGuardar = New Button()
        btnElimar = New Button()
        btnCerrar = New Button()
        btnEditar = New Button()
        dgvTransporte = New DataGridView()
        Label4 = New Label()
        CType(dgvTransporte, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtTipo
        ' 
        txtTipo.Location = New Point(131, 225)
        txtTipo.Name = "txtTipo"
        txtTipo.Size = New Size(125, 27)
        txtTipo.TabIndex = 1
        ' 
        ' txtPlaca
        ' 
        txtPlaca.Location = New Point(146, 101)
        txtPlaca.Name = "txtPlaca"
        txtPlaca.Size = New Size(125, 27)
        txtPlaca.TabIndex = 2
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(121, 167)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(125, 27)
        TextBox4.TabIndex = 3
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(146, 44)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(125, 27)
        TextBox1.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(16, 44)
        Label1.Name = "Label1"
        Label1.Size = New Size(98, 20)
        Label1.TabIndex = 5
        Label1.Text = "ID Transporte"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 101)
        Label2.Name = "Label2"
        Label2.Size = New Size(113, 20)
        Label2.TabIndex = 6
        Label2.Text = "Tipo Transporte"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(35, 165)
        Label3.Name = "Label3"
        Label3.Size = New Size(44, 20)
        Label3.TabIndex = 7
        Label3.Text = "Placa"
        ' 
        ' txtCapacidad
        ' 
        txtCapacidad.AutoSize = True
        txtCapacidad.Location = New Point(12, 225)
        txtCapacidad.Name = "txtCapacidad"
        txtCapacidad.Size = New Size(0, 20)
        txtCapacidad.TabIndex = 8
        ' 
        ' btnNuevo
        ' 
        btnNuevo.Location = New Point(162, 363)
        btnNuevo.Name = "btnNuevo"
        btnNuevo.Size = New Size(94, 29)
        btnNuevo.TabIndex = 9
        btnNuevo.Text = "Nuevo"
        btnNuevo.UseVisualStyleBackColor = True
        ' 
        ' btnGuardar
        ' 
        btnGuardar.Location = New Point(162, 310)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(94, 29)
        btnGuardar.TabIndex = 10
        btnGuardar.Text = "Guardar"
        btnGuardar.UseVisualStyleBackColor = True
        ' 
        ' btnElimar
        ' 
        btnElimar.Location = New Point(35, 310)
        btnElimar.Name = "btnElimar"
        btnElimar.Size = New Size(94, 29)
        btnElimar.TabIndex = 11
        btnElimar.Text = "Eliminar"
        btnElimar.UseVisualStyleBackColor = True
        ' 
        ' btnCerrar
        ' 
        btnCerrar.Location = New Point(28, 363)
        btnCerrar.Name = "btnCerrar"
        btnCerrar.Size = New Size(94, 29)
        btnCerrar.TabIndex = 12
        btnCerrar.Text = "Cerrar"
        btnCerrar.UseVisualStyleBackColor = True
        ' 
        ' btnEditar
        ' 
        btnEditar.Location = New Point(100, 409)
        btnEditar.Name = "btnEditar"
        btnEditar.Size = New Size(94, 29)
        btnEditar.TabIndex = 13
        btnEditar.Text = "Editar"
        btnEditar.UseVisualStyleBackColor = True
        ' 
        ' dgvTransporte
        ' 
        dgvTransporte.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvTransporte.Location = New Point(302, 12)
        dgvTransporte.Name = "dgvTransporte"
        dgvTransporte.RowHeadersWidth = 51
        dgvTransporte.Size = New Size(483, 426)
        dgvTransporte.TabIndex = 14
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(4, 228)
        Label4.Name = "Label4"
        Label4.Size = New Size(110, 20)
        Label4.TabIndex = 15
        Label4.Text = "Capacidad (kg)"
        ' 
        ' frmTransporte
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(788, 450)
        Controls.Add(Label4)
        Controls.Add(dgvTransporte)
        Controls.Add(btnEditar)
        Controls.Add(btnCerrar)
        Controls.Add(btnElimar)
        Controls.Add(btnGuardar)
        Controls.Add(btnNuevo)
        Controls.Add(txtCapacidad)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(TextBox1)
        Controls.Add(TextBox4)
        Controls.Add(txtPlaca)
        Controls.Add(txtTipo)
        Name = "frmTransporte"
        Text = "Transporte"
        CType(dgvTransporte, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents txtTipo As TextBox
    Friend WithEvents txtPlaca As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCapacidad As Label
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnElimar As Button
    Friend WithEvents btnCerrar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents dgvTransporte As DataGridView
    Friend WithEvents Label4 As Label
End Class
