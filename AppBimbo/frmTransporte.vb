Imports Microsoft.Data.SqlClient

Public Class frmTransporte

    ' 🔗 Cadena de conexión (igual que en frmDistribucion)
    Private connectionString As String =
        "Server=LAPTOP-2A9AH3M7;Database=BimboDB;Integrated Security=True;TrustServerCertificate=True;"

    ' ============================
    '   CARGAR TABLA AL GRID
    ' ============================
    Private Sub CargarTransporte()
        Using cn As New SqlConnection(connectionString)
            Dim da As New SqlDataAdapter(
                "SELECT id_transporte, tipo_transporte, placa_transporte, capacidad_kg 
                 FROM Transporte", cn)

            Dim dt As New DataTable()
            da.Fill(dt)
            dgvTransporte.DataSource = dt
        End Using

        dgvTransporte.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    ' ============================
    '   LIMPIAR CAMPOS
    ' ============================
    Private Sub Limpiar()
        TextBox1.Text = ""    ' ID Transporte
        txtTipo.Text = ""     ' Tipo Transporte
        txtPlaca.Text = ""    ' Placa
        TextBox4.Text = ""    ' Capacidad (kg)
    End Sub

    ' ============================
    '   LOAD DEL FORMULARIO
    ' ============================
    Private Sub frmTransporte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarTransporte()
    End Sub

    ' ============================
    '   CLICK EN UNA FILA DEL GRID
    ' ============================
    Private Sub dgvTransporte_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTransporte.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvTransporte.Rows(e.RowIndex)

            TextBox1.Text = row.Cells("id_transporte").Value.ToString()
            txtTipo.Text = row.Cells("tipo_transporte").Value.ToString()
            txtPlaca.Text = row.Cells("placa_transporte").Value.ToString()
            TextBox4.Text = row.Cells("capacidad_kg").Value.ToString()
        End If
    End Sub

    ' ============================
    '   BOTÓN NUEVO
    ' ============================
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Limpiar()
        txtTipo.Focus()
    End Sub

    ' ============================
    '   BOTÓN GUARDAR (INSERT)
    ' ============================
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        ' Validaciones básicas
        If txtTipo.Text = "" Or txtPlaca.Text = "" Or TextBox4.Text = "" Then
            MessageBox.Show("Completa Tipo, Placa y Capacidad antes de guardar.")
            Return
        End If

        Dim capacidadValor As Double
        If Not Double.TryParse(txtTipo.Text, capacidadValor) Then
            MessageBox.Show("La capacidad debe ser un número (ej: 5000 o 250.5).")
            Return
        End If

        Try
            Using cn As New SqlConnection(connectionString)
                cn.Open()

                Dim cmd As New SqlCommand(
                    "INSERT INTO Transporte (tipo_transporte, placa_transporte, capacidad_kg)
                     VALUES (@tipo, @placa, @capacidad)", cn)

                cmd.Parameters.AddWithValue("@tipo", txtTipo.Text)
                cmd.Parameters.AddWithValue("@placa", txtPlaca.Text)
                cmd.Parameters.AddWithValue("@capacidad", capacidadValor)

                cmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("Transporte registrado correctamente.")
            CargarTransporte()
            Limpiar()

        Catch ex As Exception
            MessageBox.Show("Error al guardar: " & ex.Message)
        End Try
    End Sub

    ' ============================
    '   BOTÓN EDITAR (UPDATE)
    ' ============================
    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click

        ' Debe haber un ID seleccionado
        If String.IsNullOrWhiteSpace(TextBox1.Text) Then
            MessageBox.Show("Selecciona primero un transporte de la tabla (haz clic en una fila).")
            Return
        End If

        If txtTipo.Text = "" Or txtPlaca.Text = "" Or TextBox4.Text = "" Then
            MessageBox.Show("Completa Tipo, Placa y Capacidad antes de editar.")
            Return
        End If

        Dim capacidadValor As Double
        If Not Double.TryParse(txtTipo.Text, capacidadValor) Then
            MessageBox.Show("La capacidad debe ser un número (ej: 5000 o 250.5).")
            Return
        End If

        Try
            Using cn As New SqlConnection(connectionString)
                cn.Open()

                Dim cmd As New SqlCommand(
                    "UPDATE Transporte SET 
                        tipo_transporte = @tipo,
                        placa_transporte = @placa,
                        capacidad_kg  = @capacidad
                     WHERE id_transporte = @id", cn)

                cmd.Parameters.AddWithValue("@tipo", txtTipo.Text)
                cmd.Parameters.AddWithValue("@placa", txtPlaca.Text)
                cmd.Parameters.AddWithValue("@capacidad", capacidadValor)
                cmd.Parameters.AddWithValue("@id", CInt(TextBox1.Text))

                cmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("Transporte actualizado correctamente.")
            CargarTransporte()
            Limpiar()

        Catch ex As Exception
            MessageBox.Show("Error al editar: " & ex.Message)
        End Try
    End Sub

    ' ============================
    '   BOTÓN ELIMINAR (DELETE)
    ' ============================
    Private Sub btnElimar_Click(sender As Object, e As EventArgs) Handles btnElimar.Click

        If String.IsNullOrWhiteSpace(TextBox1.Text) Then
            MessageBox.Show("Selecciona un registro para eliminar (clic en la tabla).")
            Return
        End If

        If MessageBox.Show("¿Seguro que deseas eliminar este transporte?",
                           "Confirmar eliminación",
                           MessageBoxButtons.YesNo,
                           MessageBoxIcon.Warning) = DialogResult.No Then
            Return
        End If

        Try
            Using cn As New SqlConnection(connectionString)
                cn.Open()

                Dim cmd As New SqlCommand(
                    "DELETE FROM Transporte WHERE id_transporte = @id", cn)

                cmd.Parameters.AddWithValue("@id", CInt(TextBox1.Text))
                cmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("Transporte eliminado.")
            CargarTransporte()
            Limpiar()

        Catch ex As Exception
            MessageBox.Show("Error al eliminar: " & ex.Message)
        End Try
    End Sub

    ' ============================
    '   BOTÓN CERRAR
    ' ============================
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
