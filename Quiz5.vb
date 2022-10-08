Imports MySql.Data.MySqlClient
Public Class Quiz5
    Private Sub cmdsearch_Click(sender As Object, e As EventArgs) Handles cmdsearch.Click

        Try
            conn.Open()
            sql = "SELECT Vehicle.Vehicle_id, Manufacturer.ManufacturerName, Models.ModelType,
                   Vehicle.Maintenance, Services.Type, date_format(VehicleService.DateOfService,
                   ' %M %d %Y') as 'Date of Service'
                   FROM Vehicle, Manufacturer, Models, VehicleService, Services
                   WHERE Services.Service_id = VehicleService.Service_id
                   AND VehicleService.Vehicle_id = Vehicle.Vehicle_id
                   AND Models.Model_id = Vehicle.Model_id
                   AND Manufacturer.Manufacturer_id = Models.Manufacturer_id
                   AND VehicleService.DateOfService BETWEEN '" &
                   Convert.ToDateTime(DateTimePicker1.Value).ToString("yyyy-MM-dd") & "'
                   AND " & "'" & Convert.ToDateTime(DateTimePicker2.Value).ToString("yyyy-MM-dd") & "'
                   ORDER BY vehicle.vehicle_id ASC"

            DataAdapter1 = New MySqlDataAdapter(sql, conn)
            dset = New DataSet()
            DataAdapter1.Fill(dset, "Vehicle, Manufacturer, Models, VehicleService, Services")
            Quiz5View.DataSource = dset
            Quiz5View.DataMember = "Vehicle, Manufacturer, Models, VehicleService, Services"
        Catch ex As MySqlException
            MsgBox("Error in collecting data from Database. Error is :" & ex.Message)

        Catch exception As Exception
            MsgBox("Error in code. Error is :" & exception.Message)
        End Try

        conn.Close()
    End Sub
End Class