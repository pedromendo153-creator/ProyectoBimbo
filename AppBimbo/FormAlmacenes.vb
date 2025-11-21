Imports Microsoft.Data.SqlClient
Imports System.Data

Public Class FormAlmacenes

    Private connectionString As String = "Server=TAVOGUS\SQLEXPRESS;Database=BimboDB;Integrated Security=True;TrustServerCertificate=True;"

    Private Sub CargarEstados()
        Dim query As String = "SELECT DISTINCT estado_almacen FROM Almacen"

        Using conn As New SqlConnection(connectionString)
            Using da As New SqlDataAdapter(query, conn)
                Dim dt As New DataTable()
                da.Fill(dt)

                cboEstado.DataSource = dt
                cboEstado.DisplayMember = "estado_almacen"
                cboEstado.ValueMember = "estado_almacen"
            End Using
        End Using

        cboEstado.SelectedIndex = -1
    End Sub

    Private Sub CargarEncargados()
        Dim query As String = "SELECT id_empleado, nombre_empleado FROM Empleado WHERE estado_empleado='Activo'"

        Using conn As New SqlConnection(connectionString)
            Using da As New SqlDataAdapter(query, conn)
                Dim dt As New DataTable()
                da.Fill(dt)

                cboEncargado.DataSource = dt
                cboEncargado.DisplayMember = "nombre_empleado"
                cboEncargado.ValueMember = "id_empleado"
            End Using
        End Using

        cboEncargado.SelectedIndex = -1
    End Sub

    Private Sub CargarAlmacenes()
        Dim query As String = "SELECT * FROM Almacen"

        Using conn As New SqlConnection(connectionString)
            Using da As New SqlDataAdapter(query, conn)
                Dim dt As New DataTable()
                da.Fill(dt)
                dgvAlmacenes.DataSource = dt
            End Using
        End Using
    End Sub

    Private Sub LimpiarCampos()
        txtIdAlmacen.Clear()
        txtNombre.Clear()
        txtUbicacion.Clear()
        txtCapacidad.Clear()
        cboEncargado.SelectedIndex = -1
        cboEstado.SelectedIndex = -1
    End Sub

    Private Sub FormAlmacenes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarEncargados()
        CargarEstados()
        CargarAlmacenes()

        dgvAlmacenes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgvAlmacenes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        dgvAlmacenes.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        dgvAlmacenes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill




        cboEstado.DropDownStyle = ComboBoxStyle.DropDownList
        cboEncargado.DropDownStyle = ComboBoxStyle.DropDownList

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If txtNombre.Text = "" Or txtUbicacion.Text = "" Or txtCapacidad.Text = "" Or cboEncargado.SelectedIndex = -1 Or cboEstado.SelectedIndex = -1 Then
            MessageBox.Show("Complete todos los campos.")
            Return
        End If

        Dim query As String = "INSERT INTO Almacen (nombre_almacen, ubicacion_almacen, capacidad_pallets, responsable_id, estado_almacen)
                               VALUES (@Nombre, @Ubicacion, @Capacidad, @Encargado, @Estado)"

        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text)
                cmd.Parameters.AddWithValue("@Ubicacion", txtUbicacion.Text)
                cmd.Parameters.AddWithValue("@Capacidad", Convert.ToInt32(txtCapacidad.Text))
                cmd.Parameters.AddWithValue("@Encargado", Convert.ToInt32(cboEncargado.SelectedValue))
                cmd.Parameters.AddWithValue("@Estado", cboEstado.Text)

                conn.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using

        MessageBox.Show("Almacén agregado correctamente.")
        CargarAlmacenes()
        LimpiarCampos()
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        If txtIdAlmacen.Text = "" Then
            MessageBox.Show("Seleccione un almacén.")
            Return
        End If

        Dim query As String = "UPDATE Almacen SET nombre_almacen=@Nombre, ubicacion_almacen=@Ubicacion,
                               capacidad_pallets=@Capacidad, responsable_id=@Encargado, estado_almacen=@Estado
                               WHERE id_almacen=@Id"

        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text)
                cmd.Parameters.AddWithValue("@Ubicacion", txtUbicacion.Text)
                cmd.Parameters.AddWithValue("@Capacidad", Convert.ToInt32(txtCapacidad.Text))
                cmd.Parameters.AddWithValue("@Encargado", Convert.ToInt32(cboEncargado.SelectedValue))
                cmd.Parameters.AddWithValue("@Estado", cboEstado.Text)
                cmd.Parameters.AddWithValue("@Id", Convert.ToInt32(txtIdAlmacen.Text))

                conn.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using

        MessageBox.Show("Almacén actualizado correctamente.")
        CargarAlmacenes()
        LimpiarCampos()
    End Sub
    Private Sub dgvAlmacenes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAlmacenes.CellClick
        If e.RowIndex < 0 Then Return

        Dim row = dgvAlmacenes.Rows(e.RowIndex)

        txtIdAlmacen.Text = row.Cells("id_almacen").Value.ToString()
        txtNombre.Text = row.Cells("nombre_almacen").Value.ToString()
        txtUbicacion.Text = row.Cells("ubicacion_almacen").Value.ToString()
        txtCapacidad.Text = row.Cells("capacidad_pallets").Value.ToString()
        cboEncargado.SelectedValue = row.Cells("responsable_id").Value
        cboEstado.Text = row.Cells("estado_almacen").Value.ToString()
    End Sub

End Class
