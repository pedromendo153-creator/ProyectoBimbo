<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInventario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInventario))
        txtStockMinimo = New TextBox()
        txtIdProducto = New TextBox()
        txtIdAlmacen = New TextBox()
        txtIdInventario = New TextBox()
        txtCantidadStock = New TextBox()
        txtStockMaximo = New TextBox()
        dtpFechaActualizacion = New DateTimePicker()
        btnNuevo = New Button()
        btnGuardar = New Button()
        btnEditar = New Button()
        btnEliminar = New Button()
        btnCerrar = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        dgvInventario = New DataGridView()
        CType(dgvInventario, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtStockMinimo
        ' 
        txtStockMinimo.Location = New Point(140, 235)
        txtStockMinimo.Name = "txtStockMinimo"
        txtStockMinimo.Size = New Size(125, 27)
        txtStockMinimo.TabIndex = 0
        ' 
        ' txtIdProducto
        ' 
        txtIdProducto.Location = New Point(140, 80)
        txtIdProducto.Name = "txtIdProducto"
        txtIdProducto.Size = New Size(125, 27)
        txtIdProducto.TabIndex = 1
        ' 
        ' txtIdAlmacen
        ' 
        txtIdAlmacen.Location = New Point(140, 124)
        txtIdAlmacen.Name = "txtIdAlmacen"
        txtIdAlmacen.Size = New Size(125, 27)
        txtIdAlmacen.TabIndex = 2
        ' 
        ' txtIdInventario
        ' 
        txtIdInventario.Location = New Point(140, 34)
        txtIdInventario.Name = "txtIdInventario"
        txtIdInventario.ReadOnly = True
        txtIdInventario.Size = New Size(125, 27)
        txtIdInventario.TabIndex = 3
        ' 
        ' txtCantidadStock
        ' 
        txtCantidadStock.Location = New Point(140, 172)
        txtCantidadStock.Name = "txtCantidadStock"
        txtCantidadStock.Size = New Size(125, 27)
        txtCantidadStock.TabIndex = 4
        ' 
        ' txtStockMaximo
        ' 
        txtStockMaximo.Location = New Point(140, 282)
        txtStockMaximo.Name = "txtStockMaximo"
        txtStockMaximo.Size = New Size(125, 27)
        txtStockMaximo.TabIndex = 5
        ' 
        ' dtpFechaActualizacion
        ' 
        dtpFechaActualizacion.Location = New Point(152, 336)
        dtpFechaActualizacion.Name = "dtpFechaActualizacion"
        dtpFechaActualizacion.Size = New Size(250, 27)
        dtpFechaActualizacion.TabIndex = 6
        ' 
        ' btnNuevo
        ' 
        btnNuevo.Location = New Point(15, 390)
        btnNuevo.Name = "btnNuevo"
        btnNuevo.Size = New Size(94, 29)
        btnNuevo.TabIndex = 7
        btnNuevo.Text = "Nuevo"
        btnNuevo.UseVisualStyleBackColor = True
        ' 
        ' btnGuardar
        ' 
        btnGuardar.Location = New Point(171, 390)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(94, 29)
        btnGuardar.TabIndex = 8
        btnGuardar.Text = "Guardar"
        btnGuardar.UseVisualStyleBackColor = True
        ' 
        ' btnEditar
        ' 
        btnEditar.Location = New Point(308, 390)
        btnEditar.Name = "btnEditar"
        btnEditar.Size = New Size(94, 29)
        btnEditar.TabIndex = 9
        btnEditar.Text = "Editar"
        btnEditar.UseVisualStyleBackColor = True
        ' 
        ' btnEliminar
        ' 
        btnEliminar.Location = New Point(560, 390)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(94, 29)
        btnEliminar.TabIndex = 10
        btnEliminar.Text = "Eliminar"
        btnEliminar.UseVisualStyleBackColor = True
        ' 
        ' btnCerrar
        ' 
        btnCerrar.Location = New Point(441, 390)
        btnCerrar.Name = "btnCerrar"
        btnCerrar.Size = New Size(94, 29)
        btnCerrar.TabIndex = 11
        btnCerrar.Text = "Cerrar"
        btnCerrar.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 34)
        Label1.Name = "Label1"
        Label1.Size = New Size(94, 20)
        Label1.TabIndex = 12
        Label1.Text = "ID Inventario"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 83)
        Label2.Name = "Label2"
        Label2.Size = New Size(88, 20)
        Label2.TabIndex = 13
        Label2.Text = "ID Producto"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 124)
        Label3.Name = "Label3"
        Label3.Size = New Size(86, 20)
        Label3.TabIndex = 14
        Label3.Text = "ID Almacén"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(-3, 179)
        Label4.Name = "Label4"
        Label4.Size = New Size(109, 20)
        Label4.TabIndex = 15
        Label4.Text = "Cantidad Stock"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(6, 235)
        Label5.Name = "Label5"
        Label5.Size = New Size(100, 20)
        Label5.TabIndex = 16
        Label5.Text = "Stock Mínimo"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(6, 285)
        Label6.Name = "Label6"
        Label6.Size = New Size(103, 20)
        Label6.TabIndex = 17
        Label6.Text = "Stock Máximo"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(6, 340)
        Label7.Name = "Label7"
        Label7.Size = New Size(140, 20)
        Label7.TabIndex = 18
        Label7.Text = "Fecha Actualización"
        ' 
        ' dgvInventario
        ' 
        dgvInventario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvInventario.Location = New Point(330, 44)
        dgvInventario.Name = "dgvInventario"
        dgvInventario.RowHeadersWidth = 51
        dgvInventario.Size = New Size(458, 261)
        dgvInventario.TabIndex = 19
        ' 
        ' frmInventario
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(800, 450)
        Controls.Add(dgvInventario)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnCerrar)
        Controls.Add(btnEliminar)
        Controls.Add(btnEditar)
        Controls.Add(btnGuardar)
        Controls.Add(btnNuevo)
        Controls.Add(dtpFechaActualizacion)
        Controls.Add(txtStockMaximo)
        Controls.Add(txtCantidadStock)
        Controls.Add(txtIdInventario)
        Controls.Add(txtIdAlmacen)
        Controls.Add(txtIdProducto)
        Controls.Add(txtStockMinimo)
        Name = "frmInventario"
        Text = "frmInventario"
        CType(dgvInventario, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtStockMinimo As TextBox
    Friend WithEvents txtIdProducto As TextBox
    Friend WithEvents txtIdAlmacen As TextBox
    Friend WithEvents txtIdInventario As TextBox
    Friend WithEvents txtCantidadStock As TextBox
    Friend WithEvents txtStockMaximo As TextBox
    Friend WithEvents dtpFechaActualizacion As DateTimePicker
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnCerrar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents dgvInventario As DataGridView
End Class
