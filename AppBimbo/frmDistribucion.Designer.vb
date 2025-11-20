<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDistribucion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDistribucion))
        dgvZonas = New DataGridView()
        id_zona = New DataGridViewTextBoxColumn()
        nombre_zona = New DataGridViewTextBoxColumn()
        DISTRITOS = New DataGridViewTextBoxColumn()
        tiempo_estimado_min = New DataGridViewTextBoxColumn()
        txtIdZona = New TextBox()
        txtDistritos = New TextBox()
        txtNombreZona = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        txtTiempoMin = New TextBox()
        btnNuevo = New Button()
        btnGuardar = New Button()
        btnEditar = New Button()
        btnEliminar = New Button()
        btnCerrar = New Button()
        CType(dgvZonas, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvZonas
        ' 
        dgvZonas.AccessibleName = ""
        dgvZonas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvZonas.Columns.AddRange(New DataGridViewColumn() {id_zona, nombre_zona, DISTRITOS, tiempo_estimado_min})
        dgvZonas.Location = New Point(124, 31)
        dgvZonas.Name = "dgvZonas"
        dgvZonas.RowHeadersWidth = 51
        dgvZonas.Size = New Size(553, 197)
        dgvZonas.TabIndex = 0
        ' 
        ' id_zona
        ' 
        id_zona.HeaderText = "ID ZONA"
        id_zona.MinimumWidth = 6
        id_zona.Name = "id_zona"
        id_zona.ReadOnly = True
        id_zona.Width = 125
        ' 
        ' nombre_zona
        ' 
        nombre_zona.HeaderText = "NOMBRE ZONA"
        nombre_zona.MinimumWidth = 6
        nombre_zona.Name = "nombre_zona"
        nombre_zona.Width = 125
        ' 
        ' DISTRITOS
        ' 
        DISTRITOS.HeaderText = "DISTRITOS"
        DISTRITOS.MinimumWidth = 6
        DISTRITOS.Name = "DISTRITOS"
        DISTRITOS.Width = 125
        ' 
        ' tiempo_estimado_min
        ' 
        tiempo_estimado_min.HeaderText = "TIEMPO MIN"
        tiempo_estimado_min.MinimumWidth = 6
        tiempo_estimado_min.Name = "tiempo_estimado_min"
        tiempo_estimado_min.Width = 125
        ' 
        ' txtIdZona
        ' 
        txtIdZona.Location = New Point(232, 269)
        txtIdZona.Name = "txtIdZona"
        txtIdZona.ReadOnly = True
        txtIdZona.Size = New Size(125, 27)
        txtIdZona.TabIndex = 1
        ' 
        ' txtDistritos
        ' 
        txtDistritos.Location = New Point(232, 359)
        txtDistritos.Multiline = True
        txtDistritos.Name = "txtDistritos"
        txtDistritos.Size = New Size(125, 27)
        txtDistritos.TabIndex = 2
        ' 
        ' txtNombreZona
        ' 
        txtNombreZona.Location = New Point(232, 320)
        txtNombreZona.Name = "txtNombreZona"
        txtNombreZona.Size = New Size(125, 27)
        txtNombreZona.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(60, 269)
        Label1.Name = "Label1"
        Label1.Size = New Size(62, 20)
        Label1.TabIndex = 4
        Label1.Text = "ID Zona"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(48, 320)
        Label2.Name = "Label2"
        Label2.Size = New Size(102, 20)
        Label2.TabIndex = 5
        Label2.Text = "Nombre Zona"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(60, 359)
        Label3.Name = "Label3"
        Label3.Size = New Size(64, 20)
        Label3.TabIndex = 6
        Label3.Text = "Distritos"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(67, 406)
        Label4.Name = "Label4"
        Label4.Size = New Size(89, 20)
        Label4.TabIndex = 7
        Label4.Text = "Tiempo Min"
        ' 
        ' txtTiempoMin
        ' 
        txtTiempoMin.Location = New Point(232, 406)
        txtTiempoMin.Name = "txtTiempoMin"
        txtTiempoMin.Size = New Size(125, 27)
        txtTiempoMin.TabIndex = 8
        ' 
        ' btnNuevo
        ' 
        btnNuevo.Location = New Point(663, 265)
        btnNuevo.Name = "btnNuevo"
        btnNuevo.Size = New Size(94, 29)
        btnNuevo.TabIndex = 9
        btnNuevo.Text = "Nuevo"
        btnNuevo.UseVisualStyleBackColor = True
        ' 
        ' btnGuardar
        ' 
        btnGuardar.Location = New Point(663, 300)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(94, 29)
        btnGuardar.TabIndex = 10
        btnGuardar.Text = "Guardar"
        btnGuardar.UseVisualStyleBackColor = True
        ' 
        ' btnEditar
        ' 
        btnEditar.Location = New Point(663, 335)
        btnEditar.Name = "btnEditar"
        btnEditar.Size = New Size(94, 29)
        btnEditar.TabIndex = 11
        btnEditar.Text = "Editar"
        btnEditar.UseVisualStyleBackColor = True
        ' 
        ' btnEliminar
        ' 
        btnEliminar.Location = New Point(663, 370)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(94, 29)
        btnEliminar.TabIndex = 12
        btnEliminar.Text = "Eliminar"
        btnEliminar.UseVisualStyleBackColor = True
        ' 
        ' btnCerrar
        ' 
        btnCerrar.Location = New Point(663, 406)
        btnCerrar.Name = "btnCerrar"
        btnCerrar.Size = New Size(94, 29)
        btnCerrar.TabIndex = 13
        btnCerrar.Text = "Cerrar"
        btnCerrar.UseVisualStyleBackColor = True
        ' 
        ' frmDistribucion
        ' 
        AccessibleName = ""
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(800, 450)
        Controls.Add(btnCerrar)
        Controls.Add(btnEliminar)
        Controls.Add(btnEditar)
        Controls.Add(btnGuardar)
        Controls.Add(btnNuevo)
        Controls.Add(txtTiempoMin)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtNombreZona)
        Controls.Add(txtDistritos)
        Controls.Add(txtIdZona)
        Controls.Add(dgvZonas)
        Name = "frmDistribucion"
        Text = "frmDistribucion"
        CType(dgvZonas, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvZonas As DataGridView
    Friend WithEvents id_zona As DataGridViewTextBoxColumn
    Friend WithEvents nombre_zona As DataGridViewTextBoxColumn
    Friend WithEvents DISTRITOS As DataGridViewTextBoxColumn
    Friend WithEvents tiempo_estimado_min As DataGridViewTextBoxColumn
    Friend WithEvents txtIdZona As TextBox
    Friend WithEvents txtDistritos As TextBox
    Friend WithEvents txtNombreZona As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtTiempoMin As TextBox
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnCerrar As Button
End Class
