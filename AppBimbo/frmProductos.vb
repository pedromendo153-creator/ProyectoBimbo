
Imports Microsoft.Data.SqlClient
Imports System.Data

Public Class frmProductos


    Private connectionString As String = "Server=localhost\SQLEXPRESS;Database=BimboDB;Integrated Security=True;TrustServerCertificate=True;"

    ' 1. CÓDIGO CUANDO SE ABRE EL FORMULARIO
    Private Sub frmProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Llenamos el ComboBox de Estado
        cboEstado.Items.Add("Activo")
        cboEstado.Items.Add("Inactivo")
        cboEstado.SelectedIndex = 0

        ' Llamamos a CargarProductos SIN filtro para que muestre todo al inicio
        CargarProductos()
    End Sub

    ' 2. CÓDIGO PARA LLENAR LA CUADRÍCULA 
    Private Sub CargarProductos(Optional ByVal filtroNombre As String = "")
        Try
            Using connection As New SqlConnection(connectionString)

                ' Añadimos una cláusula "WHERE" que usa el filtro.
                Dim sqlQuery As String = "SELECT id_producto, nombre_producto, descripcion_producto, precio_unitario, peso_unitario_kg, estado_producto " &
                                         "FROM Producto " &
                                         "WHERE nombre_producto LIKE @Filtro"

                Using adapter As New SqlDataAdapter(sqlQuery, connection)

                    ' 2. AÑADIMOS EL PARÁMETRO:
                    adapter.SelectCommand.Parameters.AddWithValue("@Filtro", "%" & filtroNombre & "%")


                    Dim dataTable As New DataTable()
                    adapter.Fill(dataTable)
                    dgvProductos.DataSource = dataTable

                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error al cargar los productos: " & ex.Message)
        End Try
    End Sub

    ' 3. CÓDIGO DEL BOTÓN GUARDAR
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try

            If String.IsNullOrWhiteSpace(txtNombre.Text) OrElse
               String.IsNullOrWhiteSpace(txtPrecio.Text) OrElse
               String.IsNullOrWhiteSpace(txtPeso.Text) OrElse
               String.IsNullOrWhiteSpace(cboEstado.Text) Then
                MessageBox.Show("Por favor, complete todos los campos obligatorios.", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Dim sqlQuery As String = "INSERT INTO Producto (nombre_producto, descripcion_producto, precio_unitario, peso_unitario_kg, estado_producto) " &
                                         "VALUES (@Nombre, @Descripcion, @Precio, @Peso, @Estado)"
                Using command As New SqlCommand(sqlQuery, connection)
                    command.Parameters.AddWithValue("@Nombre", txtNombre.Text)
                    command.Parameters.AddWithValue("@Descripcion", txtDescripcion.Text)
                    command.Parameters.AddWithValue("@Precio", Convert.ToDecimal(txtPrecio.Text))
                    command.Parameters.AddWithValue("@Peso", Convert.ToDecimal(txtPeso.Text))
                    command.Parameters.AddWithValue("@Estado", cboEstado.Text)
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MessageBox.Show("¡Producto guardado exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        CargarProductos() ' Refrescamos la cuadrícula (con el filtro vacío)
                    Else
                        MessageBox.Show("No se pudo guardar el producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End Using
        Catch ex As FormatException
            MessageBox.Show("Error de formato: 'Precio' y 'Peso' deben ser números.", "Error de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Error al guardar el producto: " & ex.Message, "Error de Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' 4. CÓDIGO DEL BOTÓN ACTUALIZAR 
    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Try

            If String.IsNullOrWhiteSpace(txtIDProducto.Text) Then
                MessageBox.Show("Por favor, primero seleccione un producto de la cuadrícula.", "Ningún producto seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Dim sqlQuery As String = "UPDATE Producto SET " &
                                         "nombre_producto = @Nombre, " &
                                         "descripcion_producto = @Descripcion, " &
                                         "precio_unitario = @Precio, " &
                                         "peso_unitario_kg = @Peso, " &
                                         "estado_producto = @Estado " &
                                         "WHERE id_producto = @ID"
                Using command As New SqlCommand(sqlQuery, connection)
                    command.Parameters.AddWithValue("@Nombre", txtNombre.Text)
                    command.Parameters.AddWithValue("@Descripcion", txtDescripcion.Text)
                    command.Parameters.AddWithValue("@Precio", Convert.ToDecimal(txtPrecio.Text))
                    command.Parameters.AddWithValue("@Peso", Convert.ToDecimal(txtPeso.Text))
                    command.Parameters.AddWithValue("@Estado", cboEstado.Text)
                    command.Parameters.AddWithValue("@ID", Convert.ToInt32(txtIDProducto.Text))
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MessageBox.Show("¡Producto actualizado exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        CargarProductos() ' Refrescamos la cuadrícula (con el filtro vacío)
                    Else
                        MessageBox.Show("No se pudo actualizar el producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End Using
        Catch ex As FormatException
            MessageBox.Show("Error de formato: 'Precio' y 'Peso' deben ser números.", "Error de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Error al actualizar el producto: " & ex.Message, "Error de Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' 5. CÓDIGO DEL BOTÓN NUEVO
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click

        txtIDProducto.Clear()
        txtNombre.Clear()
        txtDescripcion.Clear()
        txtPrecio.Clear()
        txtPeso.Clear()
        cboEstado.SelectedIndex = 0
        txtNombre.Focus()
    End Sub

    ' 6. CÓDIGO DEL CLIC EN LA CUADRÍCULA
    Private Sub dgvProductos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProductos.CellClick
        Try

            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow = dgvProductos.Rows(e.RowIndex)
                txtIDProducto.Text = row.Cells("id_producto").Value.ToString()
                txtNombre.Text = row.Cells("nombre_producto").Value.ToString()
                txtDescripcion.Text = row.Cells("descripcion_producto").Value.ToString()
                txtPrecio.Text = row.Cells("precio_unitario").Value.ToString()
                txtPeso.Text = row.Cells("peso_unitario_kg").Value.ToString()
                cboEstado.Text = row.Cells("estado_producto").Value.ToString()
            End If
        Catch ex As Exception

        End Try
    End Sub

    ' 7. CONECTA EL BUSCADOR
    Private Sub txtBuscarNombre_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarNombre.TextChanged
        ' Cada vez que el texto en la caja de búsqueda cambia.
        CargarProductos(txtBuscarNombre.Text)
    End Sub

End Class