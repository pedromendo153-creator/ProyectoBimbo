Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient

Public Class frmInventario

    ' 🔗 Cadena de conexión a tu base de datos BimboDB
    Private connectionString As String = "Server=LAPTOP-2A9AH3M7;Database=BimboDB;Integrated Security=True;TrustServerCertificate=True;"

    ' ============ MÉTODOS AUXILIARES ============

    Private Sub frmInventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConfigurarControles()
        CargarInventario()
    End Sub

    Private Sub ConfigurarControles()
        txtIdInventario.ReadOnly = True
        dtpFechaActualizacion.Enabled = False   ' La fecha la pone SQL con GETDATE()

        dgvInventario.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvInventario.MultiSelect = False
        dgvInventario.ReadOnly = True
        dgvInventario.AllowUserToAddRows = False
    End Sub

    Private Sub LimpiarCampos()
        txtIdInventario.Text = ""
        txtIdProducto.Text = ""
        txtIdAlmacen.Text = ""
        txtCantidadStock.Text = ""
        txtStockMinimo.Text = ""
        txtStockMaximo.Text = ""
        dtpFechaActualizacion.Value = DateTime.Now
    End Sub

    Private Sub CargarInventario()
        Try
            Using cn As New SqlConnection(connectionString)
                Dim da As New SqlDataAdapter("SELECT id_inventario, id_producto, id_almacen, cantidad_stock, stock_minimo, stock_maximo, fecha_actualizacion FROM Inventario", cn)
                Dim dt As New DataTable()
                da.Fill(dt)
                dgvInventario.DataSource = dt
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al cargar inventario: " & ex.Message)
        End Try
    End Sub

    ' ============ EVENTOS DE LA GRILLA ============

    Private Sub dgvInventario_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvInventario.CellClick
        If e.RowIndex >= 0 AndAlso dgvInventario.Rows.Count > 0 Then
            Dim fila As DataGridViewRow = dgvInventario.Rows(e.RowIndex)

            txtIdInventario.Text = fila.Cells("id_inventario").Value.ToString()
            txtIdProducto.Text = fila.Cells("id_producto").Value.ToString()
            txtIdAlmacen.Text = fila.Cells("id_almacen").Value.ToString()
            txtCantidadStock.Text = fila.Cells("cantidad_stock").Value.ToString()
            txtStockMinimo.Text = fila.Cells("stock_minimo").Value.ToString()
            txtStockMaximo.Text = fila.Cells("stock_maximo").Value.ToString()

            If Not IsDBNull(fila.Cells("fecha_actualizacion").Value) Then
                dtpFechaActualizacion.Value = Convert.ToDateTime(fila.Cells("fecha_actualizacion").Value)
            End If
        End If
    End Sub

    ' ============ BOTONES ============

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        LimpiarCampos()
        txtIdProducto.Focus()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        ' INSERT
        Try
            Using cn As New SqlConnection(connectionString)
                cn.Open()

                Dim sql As String = "INSERT INTO Inventario (id_producto, id_almacen, cantidad_stock, stock_minimo, stock_maximo) " &
                                    "VALUES (@id_producto, @id_almacen, @cantidad_stock, @stock_minimo, @stock_maximo);"

                Using cmd As New SqlCommand(sql, cn)
                    cmd.Parameters.AddWithValue("@id_producto", txtIdProducto.Text)
                    cmd.Parameters.AddWithValue("@id_almacen", txtIdAlmacen.Text)
                    cmd.Parameters.AddWithValue("@cantidad_stock", txtCantidadStock.Text)
                    cmd.Parameters.AddWithValue("@stock_minimo", txtStockMinimo.Text)
                    cmd.Parameters.AddWithValue("@stock_maximo", txtStockMaximo.Text)

                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Inventario registrado correctamente.")
            CargarInventario()
            LimpiarCampos()

        Catch ex As SqlException
            MessageBox.Show("Error al guardar. Verifica que el id_producto y el id_almacen existan." &
                            Environment.NewLine & ex.Message)
        Catch ex As Exception
            MessageBox.Show("Error al guardar: " & ex.Message)
        End Try
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        ' UPDATE
        If String.IsNullOrWhiteSpace(txtIdInventario.Text) Then
            MessageBox.Show("Seleccione un registro de la tabla para editar.")
            Return
        End If

        Try
            Using cn As New SqlConnection(connectionString)
                cn.Open()

                Dim sql As String = "UPDATE Inventario SET " &
                                    "id_producto = @id_producto, " &
                                    "id_almacen = @id_almacen, " &
                                    "cantidad_stock = @cantidad_stock, " &
                                    "stock_minimo = @stock_minimo, " &
                                    "stock_maximo = @stock_maximo, " &
                                    "fecha_actualizacion = GETDATE() " &
                                    "WHERE id_inventario = @id_inventario;"

                Using cmd As New SqlCommand(sql, cn)
                    cmd.Parameters.AddWithValue("@id_inventario", txtIdInventario.Text)
                    cmd.Parameters.AddWithValue("@id_producto", txtIdProducto.Text)
                    cmd.Parameters.AddWithValue("@id_almacen", txtIdAlmacen.Text)
                    cmd.Parameters.AddWithValue("@cantidad_stock", txtCantidadStock.Text)
                    cmd.Parameters.AddWithValue("@stock_minimo", txtStockMinimo.Text)
                    cmd.Parameters.AddWithValue("@stock_maximo", txtStockMaximo.Text)

                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Inventario actualizado correctamente.")
            CargarInventario()

        Catch ex As SqlException
            MessageBox.Show("Error al actualizar. Revisa las claves foráneas o los datos numéricos." &
                            Environment.NewLine & ex.Message)
        Catch ex As Exception
            MessageBox.Show("Error al actualizar: " & ex.Message)
        End Try
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        ' DELETE
        If String.IsNullOrWhiteSpace(txtIdInventario.Text) Then
            MessageBox.Show("Seleccione un registro para eliminar.")
            Return
        End If

        Dim r = MessageBox.Show("¿Seguro que deseas eliminar este registro?", "Confirmar",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If r <> DialogResult.Yes Then
            Return
        End If

        Try
            Using cn As New SqlConnection(connectionString)
                cn.Open()

                Dim sql As String = "DELETE FROM Inventario WHERE id_inventario = @id_inventario;"

                Using cmd As New SqlCommand(sql, cn)
                    cmd.Parameters.AddWithValue("@id_inventario", txtIdInventario.Text)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Registro eliminado correctamente.")
            CargarInventario()
            LimpiarCampos()

        Catch ex As SqlException
            MessageBox.Show("No se pudo eliminar el registro (puede estar relacionado con otros datos)." &
                            Environment.NewLine & ex.Message)
        Catch ex As Exception
            MessageBox.Show("Error al eliminar: " & ex.Message)
        End Try
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

End Class
