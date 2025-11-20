Imports Microsoft.Data.SqlClient

Public Class frmDistribucion

    ' 1. Cadena de conexión
    Private connectionString As String =
        "Server=LAPTOP-2A9AH3M7;Database=BimboDB;Integrated Security=True;TrustServerCertificate=True;"

    ' 2. Cargar todas las zonas en el DataGridView
    Private Sub CargarZonas()
        Using cn As New SqlConnection(connectionString)
            Dim da As New SqlDataAdapter(
                "SELECT id_zona, nombre_zona, distritos, tiempo_estimado_min 
                 FROM ZonaDistribucion", cn)
            Dim dt As New DataTable()
            da.Fill(dt)
            dgvZonas.DataSource = dt
        End Using

        ' Que las columnas llenen el ancho
        dgvZonas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    ' 3. Load del formulario
    Private Sub frmDistribucion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Aseguramos que las columnas del DGV se vinculen bien con las columnas del DataTable
        dgvZonas.AutoGenerateColumns = False
        dgvZonas.Columns("id_zona").DataPropertyName = "id_zona"
        dgvZonas.Columns("nombre_zona").DataPropertyName = "nombre_zona"
        dgvZonas.Columns("distritos").DataPropertyName = "distritos"
        dgvZonas.Columns("tiempo_estimado_min").DataPropertyName = "tiempo_estimado_min"

        CargarZonas()
    End Sub

    ' 4. BOTÓN NUEVO
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtIdZona.Text = ""
        txtNombreZona.Text = ""
        txtDistritos.Text = ""
        txtTiempoMin.Text = ""
        txtNombreZona.Focus()
    End Sub

    ' 5. BOTÓN GUARDAR (INSERT)
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If txtNombreZona.Text = "" Or txtDistritos.Text = "" Or txtTiempoMin.Text = "" Then
            MessageBox.Show("Completa todos los campos.")
            Return
        End If

        Using cn As New SqlConnection(connectionString)
            cn.Open()

            Dim cmd As New SqlCommand(
                "INSERT INTO ZonaDistribucion (nombre_zona, distritos, tiempo_estimado_min)
                 VALUES (@nombre, @distritos, @tiempo)", cn)

            cmd.Parameters.AddWithValue("@nombre", txtNombreZona.Text)
            cmd.Parameters.AddWithValue("@distritos", txtDistritos.Text)
            cmd.Parameters.AddWithValue("@tiempo", CInt(txtTiempoMin.Text))

            cmd.ExecuteNonQuery()
        End Using

        MessageBox.Show("Zona registrada correctamente.")
        CargarZonas()
    End Sub

    ' 6. BOTÓN EDITAR (UPDATE)
    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If txtIdZona.Text = "" Then
            MessageBox.Show("Selecciona una zona de la tabla para editar.")
            Return
        End If

        Using cn As New SqlConnection(connectionString)
            cn.Open()

            Dim cmd As New SqlCommand(
                "UPDATE ZonaDistribucion SET 
                    nombre_zona = @nombre,
                    distritos = @distritos,
                    tiempo_estimado_min = @tiempo
                 WHERE id_zona = @id", cn)

            cmd.Parameters.AddWithValue("@nombre", txtNombreZona.Text)
            cmd.Parameters.AddWithValue("@distritos", txtDistritos.Text)
            cmd.Parameters.AddWithValue("@tiempo", CInt(txtTiempoMin.Text))
            cmd.Parameters.AddWithValue("@id", CInt(txtIdZona.Text))

            cmd.ExecuteNonQuery()
        End Using

        MessageBox.Show("Zona actualizada.")
        CargarZonas()
    End Sub

    ' 7. BOTÓN ELIMINAR (DELETE)
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If txtIdZona.Text = "" Then
            MessageBox.Show("Selecciona una zona para eliminar.")
            Return
        End If

        If MessageBox.Show("¿Eliminar esta zona?", "Confirmar", MessageBoxButtons.YesNo) = DialogResult.No Then
            Return
        End If

        Using cn As New SqlConnection(connectionString)
            cn.Open()

            Dim cmd As New SqlCommand(
                "DELETE FROM ZonaDistribucion WHERE id_zona = @id", cn)

            cmd.Parameters.AddWithValue("@id", CInt(txtIdZona.Text))
            cmd.ExecuteNonQuery()
        End Using

        MessageBox.Show("Zona eliminada.")
        CargarZonas()
    End Sub

    ' 8. Click en una fila del DataGridView para llenar los TextBox
    Private Sub dgvZonas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvZonas.CellClick
        If e.RowIndex >= 0 Then
            Dim fila As DataGridViewRow = dgvZonas.Rows(e.RowIndex)

            txtIdZona.Text = fila.Cells("id_zona").Value.ToString()
            txtNombreZona.Text = fila.Cells("nombre_zona").Value.ToString()
            txtDistritos.Text = fila.Cells("distritos").Value.ToString()
            txtTiempoMin.Text = fila.Cells("tiempo_estimado_min").Value.ToString()
        End If
    End Sub

    ' 9. BOTÓN CERRAR
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

End Class
