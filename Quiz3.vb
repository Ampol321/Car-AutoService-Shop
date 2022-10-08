Imports MySql.Data.MySqlClient
Public Class Quiz3
    Private Sub cmdsearch_Click(sender As Object, e As EventArgs) Handles cmdsearch.Click
        Dim mechanicname = txtmname.Text

        Try
            conn.Open()
            sql = "SELECT Vehicle.Vehicle_id, mechanics.MechanicName, Services.Type, VehicleService.DateOfService,
                   Vehicle.Maintenance, Manufacturer.ManufacturerName, Models.ModelType
                   FROM Mechanics, Services, Servicemechanics, VehicleService, Vehicle, Manufacturer, Models
                   WHERE Manufacturer.Manufacturer_id = models.manufacturer_id
                   AND Models.model_id = vehicle.model_id
                   AND Vehicle.vehicle_id = vehicleservice.vehicle_id
                   AND vehicleservice.service_id = services.service_id
                   AND mechanics.mechanic_id = servicemechanics.mechanic_id
                   AND services.service_id = servicemechanics.service_id
                   AND Mechanics.mechanicname = '" & mechanicname & "'"

            DataAdapter1 = New MySqlDataAdapter(sql, conn)
            dset = New DataSet()
            DataAdapter1.Fill(dset, "Mechanics, Services, Servicemechanics, VehicleService, Vehicle, Manufacturer, Models")
            Quiz3View.DataSource = dset
            Quiz3View.DataMember = "Mechanics, Services, Servicemechanics, VehicleService, Vehicle, Manufacturer, Models"
        Catch ex As MySqlException
            MsgBox("Error in collecting data from Database. Error is :" & ex.Message)

        Catch exception As Exception
            MsgBox("Error in code. Error is :" & exception.Message)
        End Try

        conn.Close()
    End Sub

End Class