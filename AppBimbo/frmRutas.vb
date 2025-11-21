Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient

Public Class frmRutas

    ' 🔗 Cadena de conexión a tu base de datos BimboDB
    Private connectionString As String = "Server=LAPTOP-2A9AH3M7;Database=BimboDB;Integrated Security=True;TrustServerCertificate=True;"

    ' ================== EVENTO LOAD ==================
    Private Sub frmRutas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConfigurarControles()
        CargarRutas()
    End Sub

    Private Sub ConfigurarControles()
        ' ID autogenerado
        txtIdRuta.ReadOnly = True

        ' DateTimePicker solo hora
        dtpHorarioSalida.Format = DateTimePickerFormat.Time
        dtpHorarioSalida.ShowUpDown = True

        ' Estado por defecto
        If cboEstadoRuta.Items.Count = 0 Then
            cboEstadoRuta.Items.Add("Activa")
            cboEstadoRuta.Items.Add("Inactiva")
        End If
        If String.IsNullOrWhiteSpace(cboEstadoRuta.Text) Then
            cboEstadoRuta.Text = "Activa"
        End If

        ' Configuración del DataGridView
        dgvRutas.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvRutas.MultiSelect = False
        dgvRutas.ReadOnly = True
        dgvRutas.AllowUserToAddRows = False
    End Sub

    ' ================== MÉTODOS AUXILIARES ==================
    Private Sub LimpiarCampos()
        txtIdRuta.Text = ""
        txtNombreRuta.Text = ""
        txtIdZona.Text = ""
        txtIdTransporte.Text = ""
        txtIdConductor.Text = ""
        dtpHorarioSalida.Value = Date.Now
        cboEstadoRuta.Text = "Activa"
    End Sub

    Private Sub CargarRutas()
        Try
            Using cn As New SqlConnection(connectionString)
                Dim sql As String = "SELECT id_ruta, nombre_ruta, id_zona, id_transporte, id_conductor, horario_salida, estado_ruta FROM RutaDistribucion"
                Dim da As New SqlDataAdapter(sql, cn)
                Dim dt As New DataTable()
                da.Fill(dt)
                dgvRutas.DataSource = dt
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al cargar rutas: " & ex.Message)
        End Try
    End Sub

    ' ================== EVENTO DEL DATAGRIDVIEW ==================
    Private Sub dgvRutas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRutas.CellClick
        If e.RowIndex >= 0 AndAlso dgvRutas.Rows.Count > 0 Then
            Dim fila As DataGridViewRow = dgvRutas.Rows(e.RowIndex)

            txtIdRuta.Text = fila.Cells("id_ruta").Value.ToString()
            txtNombreRuta.Text = fila.Cells("nombre_ruta").Value.ToString()
            txtIdZona.Text = fila.Cells("id_zona").Value.ToString()
            txtIdTransporte.Text = fila.Cells("id_transporte").Value.ToString()
            txtIdConductor.Text = fila.Cells("id_conductor").Value.ToString()
            cboEstadoRuta.Text = fila.Cells("estado_ruta").Value.ToString()

            ' horario_salida es TIME en SQL → lo convertimos a TimeSpan y luego a DateTime
            If Not IsDBNull(fila.Cells("horario_salida").Value) Then
                Dim hora As TimeSpan = TimeSpan.Parse(fila.Cells("horario_salida").Value.ToString())
                dtpHorarioSalida.Value = Date.Today.Add(hora)
            End If
        End If
    End Sub

    ' ================== BOTÓN NUEVO ==================
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        LimpiarCampos()
        txtNombreRuta.Focus()
    End Sub

    ' ================== BOTÓN GUARDAR (INSERT) ==================
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            Using cn As New SqlConnection(connectionString)
                cn.Open()

                Dim sql As String =
                    "INSERT INTO RutaDistribucion (nombre_ruta, id_zona, id_transporte, id_conductor, horario_salida, estado_ruta) " &
                    "VALUES (@nombre_ruta, @id_zona, @id_transporte, @id_conductor, @horario_salida, @estado_ruta);"

                Using cmd As New SqlCommand(sql, cn)
                    cmd.Parameters.AddWithValue("@nombre_ruta", txtNombreRuta.Text)
                    cmd.Parameters.AddWithValue("@id_zona", txtIdZona.Text)
                    cmd.Parameters.AddWithValue("@id_transporte", txtIdTransporte.Text)
                    cmd.Parameters.AddWithValue("@id_conductor", txtIdConductor.Text)
                    cmd.Parameters.AddWithValue("@horario_salida", dtpHorarioSalida.Value.TimeOfDay)
                    cmd.Parameters.AddWithValue("@estado_ruta", cboEstadoRuta.Text)

                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Ruta registrada correctamente.")
            CargarRutas()
            LimpiarCampos()

        Catch ex As SqlException
            MessageBox.Show("Error al guardar la ruta. Revisa las claves foráneas (zona, transporte, conductor)." &
                            Environment.NewLine & ex.Message)
        Catch ex As Exception
            MessageBox.Show("Error al guardar: " & ex.Message)
        End Try
    End Sub

    ' ================== BOTÓN EDITAR (UPDATE) ==================
    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If String.IsNullOrWhiteSpace(txtIdRuta.Text) Then
            MessageBox.Show("Seleccione una ruta de la tabla para editar.")
            Return
        End If

        Try
            Using cn As New SqlConnection(connectionString)
                cn.Open()

                Dim sql As String =
                    "UPDATE RutaDistribucion SET " &
                    "nombre_ruta = @nombre_ruta, " &
                    "id_zona = @id_zona, " &
                    "id_transporte = @id_transporte, " &
                    "id_conductor = @id_conductor, " &
                    "horario_salida = @horario_salida, " &
                    "estado_ruta = @estado_ruta " &
                    "WHERE id_ruta = @id_ruta;"

                Using cmd As New SqlCommand(sql, cn)
                    cmd.Parameters.AddWithValue("@id_ruta", txtIdRuta.Text)
                    cmd.Parameters.AddWithValue("@nombre_ruta", txtNombreRuta.Text)
                    cmd.Parameters.AddWithValue("@id_zona", txtIdZona.Text)
                    cmd.Parameters.AddWithValue("@id_transporte", txtIdTransporte.Text)
                    cmd.Parameters.AddWithValue("@id_conductor", txtIdConductor.Text)
                    cmd.Parameters.AddWithValue("@horario_salida", dtpHorarioSalida.Value.TimeOfDay)
                    cmd.Parameters.AddWithValue("@estado_ruta", cboEstadoRuta.Text)

                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Ruta actualizada correctamente.")
            CargarRutas()

        Catch ex As SqlException
            MessageBox.Show("Error al actualizar la ruta. Revisa claves foráneas o datos numéricos." &
                            Environment.NewLine & ex.Message)
        Catch ex As Exception
            MessageBox.Show("Error al actualizar: " & ex.Message)
        End Try
    End Sub

    ' ================== BOTÓN ELIMINAR (DELETE) ==================
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If String.IsNullOrWhiteSpace(txtIdRuta.Text) Then
            MessageBox.Show("Seleccione una ruta para eliminar.")
            Return
        End If

        Dim r = MessageBox.Show("¿Seguro que deseas eliminar esta ruta?", "Confirmar",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If r <> DialogResult.Yes Then
            Return
        End If

        Try
            Using cn As New SqlConnection(connectionString)
                cn.Open()

                Dim sql As String = "DELETE FROM RutaDistribucion WHERE id_ruta = @id_ruta;"

                Using cmd As New SqlCommand(sql, cn)
                    cmd.Parameters.AddWithValue("@id_ruta", txtIdRuta.Text)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Ruta eliminada correctamente.")
            CargarRutas()
            LimpiarCampos()

        Catch ex As SqlException
            MessageBox.Show("No se pudo eliminar la ruta (puede estar relacionada con otras tablas)." &
                            Environment.NewLine & ex.Message)
        Catch ex As Exception
            MessageBox.Show("Error al eliminar: " & ex.Message)
        End Try
    End Sub

    ' ================== BOTÓN CERRAR ==================
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

End Class
