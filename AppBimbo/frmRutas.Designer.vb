<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRutas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRutas))
        txtIdRuta = New TextBox()
        txtNombreRuta = New TextBox()
        txtIdZona = New TextBox()
        txtIdTransporte = New TextBox()
        txtIdConductor = New TextBox()
        dtpHorarioSalida = New DateTimePicker()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        btnNuevo = New Button()
        btnGuardar = New Button()
        btnEditar = New Button()
        btnEliminar = New Button()
        btnCerrar = New Button()
        dgvRutas = New DataGridView()
        Label6 = New Label()
        cboEstadoRuta = New ComboBox()
        CType(dgvRutas, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtIdRuta
        ' 
        txtIdRuta.Location = New Point(176, 32)
        txtIdRuta.Name = "txtIdRuta"
        txtIdRuta.ReadOnly = True
        txtIdRuta.Size = New Size(125, 27)
        txtIdRuta.TabIndex = 0
        ' 
        ' txtNombreRuta
        ' 
        txtNombreRuta.Location = New Point(165, 92)
        txtNombreRuta.Name = "txtNombreRuta"
        txtNombreRuta.Size = New Size(125, 27)
        txtNombreRuta.TabIndex = 1
        ' 
        ' txtIdZona
        ' 
        txtIdZona.Location = New Point(165, 144)
        txtIdZona.Name = "txtIdZona"
        txtIdZona.Size = New Size(125, 27)
        txtIdZona.TabIndex = 2
        ' 
        ' txtIdTransporte
        ' 
        txtIdTransporte.Location = New Point(165, 202)
        txtIdTransporte.Name = "txtIdTransporte"
        txtIdTransporte.Size = New Size(125, 27)
        txtIdTransporte.TabIndex = 4
        ' 
        ' txtIdConductor
        ' 
        txtIdConductor.Location = New Point(165, 263)
        txtIdConductor.Name = "txtIdConductor"
        txtIdConductor.Size = New Size(125, 27)
        txtIdConductor.TabIndex = 3
        ' 
        ' dtpHorarioSalida
        ' 
        dtpHorarioSalida.Format = DateTimePickerFormat.Time
        dtpHorarioSalida.Location = New Point(11, 367)
        dtpHorarioSalida.Name = "dtpHorarioSalida"
        dtpHorarioSalida.ShowUpDown = True
        dtpHorarioSalida.Size = New Size(250, 27)
        dtpHorarioSalida.TabIndex = 8
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 35)
        Label1.Name = "Label1"
        Label1.Size = New Size(58, 20)
        Label1.TabIndex = 9
        Label1.Text = "ID Ruta"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 92)
        Label2.Name = "Label2"
        Label2.Size = New Size(98, 20)
        Label2.TabIndex = 10
        Label2.Text = "Nombre Ruta"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 143)
        Label3.Name = "Label3"
        Label3.Size = New Size(62, 20)
        Label3.TabIndex = 11
        Label3.Text = "ID Zona"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(11, 202)
        Label4.Name = "Label4"
        Label4.Size = New Size(98, 20)
        Label4.TabIndex = 12
        Label4.Text = "ID Transporte"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(11, 253)
        Label5.Name = "Label5"
        Label5.Size = New Size(97, 20)
        Label5.TabIndex = 13
        Label5.Text = "ID Conductor"
        ' 
        ' btnNuevo
        ' 
        btnNuevo.Location = New Point(299, 374)
        btnNuevo.Name = "btnNuevo"
        btnNuevo.Size = New Size(94, 29)
        btnNuevo.TabIndex = 15
        btnNuevo.Text = "Nuevo"
        btnNuevo.UseVisualStyleBackColor = True
        ' 
        ' btnGuardar
        ' 
        btnGuardar.Location = New Point(420, 377)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(94, 29)
        btnGuardar.TabIndex = 16
        btnGuardar.Text = "Guardar"
        btnGuardar.UseVisualStyleBackColor = True
        ' 
        ' btnEditar
        ' 
        btnEditar.Location = New Point(491, 412)
        btnEditar.Name = "btnEditar"
        btnEditar.Size = New Size(94, 29)
        btnEditar.TabIndex = 17
        btnEditar.Text = "Editar"
        btnEditar.UseVisualStyleBackColor = True
        ' 
        ' btnEliminar
        ' 
        btnEliminar.Location = New Point(545, 377)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(94, 29)
        btnEliminar.TabIndex = 18
        btnEliminar.Text = "Eliminar"
        btnEliminar.UseVisualStyleBackColor = True
        ' 
        ' btnCerrar
        ' 
        btnCerrar.Location = New Point(694, 377)
        btnCerrar.Name = "btnCerrar"
        btnCerrar.Size = New Size(94, 29)
        btnCerrar.TabIndex = 19
        btnCerrar.Text = "Cerrar"
        btnCerrar.UseVisualStyleBackColor = True
        ' 
        ' dgvRutas
        ' 
        dgvRutas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvRutas.Location = New Point(346, 41)
        dgvRutas.Name = "dgvRutas"
        dgvRutas.RowHeadersWidth = 51
        dgvRutas.Size = New Size(442, 292)
        dgvRutas.TabIndex = 20
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(11, 326)
        Label6.Name = "Label6"
        Label6.Size = New Size(88, 20)
        Label6.TabIndex = 22
        Label6.Text = "Estado Ruta"
        ' 
        ' cboEstadoRuta
        ' 
        cboEstadoRuta.FormattingEnabled = True
        cboEstadoRuta.Items.AddRange(New Object() {"Activa, Inactiva"})
        cboEstadoRuta.Location = New Point(139, 326)
        cboEstadoRuta.Name = "cboEstadoRuta"
        cboEstadoRuta.Size = New Size(151, 28)
        cboEstadoRuta.TabIndex = 23
        ' 
        ' frmRutas
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(800, 450)
        Controls.Add(cboEstadoRuta)
        Controls.Add(Label6)
        Controls.Add(dgvRutas)
        Controls.Add(btnCerrar)
        Controls.Add(btnEliminar)
        Controls.Add(btnEditar)
        Controls.Add(btnGuardar)
        Controls.Add(btnNuevo)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(dtpHorarioSalida)
        Controls.Add(txtIdTransporte)
        Controls.Add(txtIdConductor)
        Controls.Add(txtIdZona)
        Controls.Add(txtNombreRuta)
        Controls.Add(txtIdRuta)
        Name = "frmRutas"
        Text = "frmRutas"
        CType(dgvRutas, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtIdRuta As TextBox
    Friend WithEvents txtNombreRuta As TextBox
    Friend WithEvents txtIdZona As TextBox
    Friend WithEvents txtIdTransporte As TextBox
    Friend WithEvents txtIdConductor As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents dtpHorarioSalida As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnCerrar As Button
    Friend WithEvents dgvRutas As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents cboEstadoRuta As ComboBox
End Class
