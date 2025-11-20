' Importamos las librerías necesarias
Imports Microsoft.Data.SqlClient
Imports System.Data

Public Class frmClientes

    ' 1. LA "LLAVE" DE CONEXIÓN
    ' Usamos la misma "llave" para la misma base de datos
    Private connectionString As String = "Server=LAPTOP-2A9AH3M7;Database=BimboDB;Integrated Security=True;TrustServerCertificate=True;"

    ' 2. CÓDIGO CUANDO SE ABRE EL FORMULARIO
    Private Sub frmClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Llenamos las listas desplegables
        CargarTiposCliente()
        CargarZonas() ' <-- ¡Esta es la función nueva!
        cboEstadoCliente.Items.Add("Activo")
        cboEstadoCliente.Items.Add("Inactivo")
        cboEstadoCliente.SelectedIndex = 0

        ' Cargamos la cuadrícula de clientes
        CargarClientes()
    End Sub

    ' 3. CÓDIGO PARA LLENAR EL COMBOBOX "TIPO CLIENTE" (Manual)
    Private Sub CargarTiposCliente()
        ' Llenamos los tipos de cliente según tu base de datos
        cboTipoCliente.Items.Add("SUPERMERCADO")
        cboTipoCliente.Items.Add("BODEGA")
        cboTipoCliente.Items.Add("MINIMARKET")
        cboTipoCliente.Items.Add("MAYORISTA")
        cboTipoCliente.SelectedIndex = 0
    End Sub

    ' 4. ¡NUEVO! CÓDIGO PARA LLENAR EL COMBOBOX "ZONA" (Desde la BD)
    Private Sub CargarZonas()
        Try
            Using connection As New SqlConnection(connectionString)
                Dim sqlQuery As String = "SELECT id_zona, nombre_zona FROM ZonaDistribucion"
                Using adapter As New SqlDataAdapter(sqlQuery, connection)
                    Dim dtZonas As New DataTable()
                    adapter.Fill(dtZonas)

                    ' Aquí está la magia:
                    ' DisplayMember: Lo que el usuario VE (ej. "Trujillo Centro")
                    cboZona.DisplayMember = "nombre_zona"
                    ' ValueMember: Lo que el código GUARDA (ej. 1)
                    cboZona.ValueMember = "id_zona"
                    ' Fuente de datos
                    cboZona.DataSource = dtZonas
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al cargar las zonas: " & ex.Message)
        End Try
    End Sub

    ' 5. CÓDIGO PARA LLENAR LA CUADRÍCULA (con buscador)
    Private Sub CargarClientes(Optional ByVal filtroNombre As String = "")
        Try
            Using connection As New SqlConnection(connectionString)
                ' Consulta SQL para la tabla Cliente
                Dim sqlQuery As String = "SELECT id_cliente, nombre_cliente, ruc_dni, tipo_cliente, direccion_cliente, telefono_cliente, email_cliente, id_zona, estado_cliente " &
                                         "FROM Cliente " &
                                         "WHERE nombre_cliente LIKE @Filtro"

                Using adapter As New SqlDataAdapter(sqlQuery, connection)
                    adapter.SelectCommand.Parameters.AddWithValue("@Filtro", "%" & filtroNombre & "%")
                    Dim dataTable As New DataTable()
                    adapter.Fill(dataTable)
                    dgvClientes.DataSource = dataTable
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al cargar los clientes: " & ex.Message)
        End Try
    End Sub

    ' 6. CÓDIGO DEL BOTÓN "GUARDAR"
    Private Sub btnGuardarCliente_Click(sender As Object, e As EventArgs) Handles btnGuardarCliente.Click
        Try
            ' Validación de campos
            If String.IsNullOrWhiteSpace(txtNombreCliente.Text) OrElse String.IsNullOrWhiteSpace(txtRucDni.Text) Then
                MessageBox.Show("Por favor, complete Nombre y RUC/DNI.", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Using connection As New SqlConnection(connectionString)
                connection.Open()
                ' Consulta INSERT para la tabla Cliente
                Dim sqlQuery As String = "INSERT INTO Cliente (nombre_cliente, ruc_dni, tipo_cliente, direccion_cliente, telefono_cliente, email_cliente, id_zona, estado_cliente) " &
                                         "VALUES (@Nombre, @RucDni, @Tipo, @Direccion, @Telefono, @Email, @IdZona, @Estado)"

                Using command As New SqlCommand(sqlQuery, connection)
                    ' Asignamos los parámetros
                    command.Parameters.AddWithValue("@Nombre", txtNombreCliente.Text)
                    command.Parameters.AddWithValue("@RucDni", txtRucDni.Text)
                    command.Parameters.AddWithValue("@Tipo", cboTipoCliente.Text)
                    command.Parameters.AddWithValue("@Direccion", txtDireccion.Text)
                    command.Parameters.AddWithValue("@Telefono", txtTelefono.Text)
                    command.Parameters.AddWithValue("@Email", txtEmail.Text)
                    ' Aquí guardamos el ID (el ValueMember) de la zona seleccionada
                    command.Parameters.AddWithValue("@IdZona", cboZona.SelectedValue)
                    command.Parameters.AddWithValue("@Estado", cboEstadoCliente.Text)

                    command.ExecuteNonQuery()
                    MessageBox.Show("¡Cliente guardado exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    CargarClientes() ' Refrescamos
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al guardar el cliente: " & ex.Message, "Error de Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' 7. CÓDIGO DEL BOTÓN "ACTUALIZAR"
    Private Sub btnActualizarCliente_Click(sender As Object, e As EventArgs) Handles btnActualizarCliente.Click
        Try
            ' Validación de ID
            If String.IsNullOrWhiteSpace(txtIDCliente.Text) Then
                MessageBox.Show("Por favor, seleccione un cliente de la cuadrícula primero.", "Ningún cliente seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Using connection As New SqlConnection(connectionString)
                connection.Open()
                ' Consulta UPDATE para la tabla Cliente
                Dim sqlQuery As String = "UPDATE Cliente SET " &
                                         "nombre_cliente = @Nombre, ruc_dni = @RucDni, tipo_cliente = @Tipo, " &
                                         "direccion_cliente = @Direccion, telefono_cliente = @Telefono, email_cliente = @Email, " &
                                         "id_zona = @IdZona, estado_cliente = @Estado " &
                                         "WHERE id_cliente = @ID"

                Using command As New SqlCommand(sqlQuery, connection)
                    ' Asignamos todos los parámetros
                    command.Parameters.AddWithValue("@Nombre", txtNombreCliente.Text)
                    command.Parameters.AddWithValue("@RucDni", txtRucDni.Text)
                    command.Parameters.AddWithValue("@Tipo", cboTipoCliente.Text)
                    command.Parameters.AddWithValue("@Direccion", txtDireccion.Text)
                    command.Parameters.AddWithValue("@Telefono", txtTelefono.Text)
                    command.Parameters.AddWithValue("@Email", txtEmail.Text)
                    command.Parameters.AddWithValue("@IdZona", cboZona.SelectedValue)
                    command.Parameters.AddWithValue("@Estado", cboEstadoCliente.Text)
                    command.Parameters.AddWithValue("@ID", Convert.ToInt32(txtIDCliente.Text)) ' El ID para el WHERE

                    command.ExecuteNonQuery()
                    MessageBox.Show("¡Cliente actualizado exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    CargarClientes() ' Refrescamos
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al actualizar el cliente: " & ex.Message, "Error de Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' 8. CÓDIGO DEL BOTÓN "NUEVO"
    Private Sub btnNuevoCliente_Click(sender As Object, e As EventArgs) Handles btnNuevoCliente.Click
        ' Limpiamos todos los campos
        txtIDCliente.Clear()
        txtNombreCliente.Clear()
        txtRucDni.Clear()
        txtDireccion.Clear()
        txtTelefono.Clear()
        txtEmail.Clear()
        cboTipoCliente.SelectedIndex = 0
        cboZona.SelectedIndex = 0
        cboEstadoCliente.SelectedIndex = 0
        txtNombreCliente.Focus() ' Ponemos el cursor en el nombre
    End Sub

    ' 9. CÓDIGO DEL CLIC EN LA CUADRÍCULA
    Private Sub dgvClientes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvClientes.CellClick
        Try
            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow = dgvClientes.Rows(e.RowIndex)

                ' Cargamos los datos de la celda a los TextBox
                txtIDCliente.Text = row.Cells("id_cliente").Value.ToString()
                txtNombreCliente.Text = row.Cells("nombre_cliente").Value.ToString()
                txtRucDni.Text = row.Cells("ruc_dni").Value.ToString()
                txtDireccion.Text = row.Cells("direccion_cliente").Value.ToString()
                txtTelefono.Text = row.Cells("telefono_cliente").Value.ToString()
                txtEmail.Text = row.Cells("email_cliente").Value.ToString()

                ' Seleccionamos los valores correctos en los ComboBox
                cboTipoCliente.Text = row.Cells("tipo_cliente").Value.ToString()
                cboEstadoCliente.Text = row.Cells("estado_cliente").Value.ToString()
                ' Para el cboZona, seleccionamos el ID (ValueMember)
                cboZona.SelectedValue = Convert.ToInt32(row.Cells("id_zona").Value)
            End If
        Catch ex As Exception
            ' Ignorar errores
        End Try
    End Sub

    ' 10. CÓDIGO DEL BUSCADOR
    Private Sub txtBuscarCliente_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarCliente.TextChanged
        ' Llamamos a cargar clientes pasándole el filtro
        CargarClientes(txtBuscarCliente.Text)
    End Sub

End Class
