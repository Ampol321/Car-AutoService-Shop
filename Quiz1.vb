Imports MySql.Data.MySqlClient
Public Class Quiz1
    Private Sub cmdsearch_Click(sender As Object, e As EventArgs) Handles cmdsearch.Click
        Dim modelname = txtmname.Text

        Try
            conn.Open()

            sql = "SELECT Vehicle.Vehicle_id, Customer.name, Models.ModelType, Vehicle.Maintenance,
                   VehicleService.DateOfService, Services.Type, Parts.PartType, Vehicleservice.ItemQty
                   FROM customer, vehicle, manufacturer, models, vehicleservice, services, parts
                   WHERE Customer.customer_id = vehicle.customer_id
                   AND Manufacturer.manufacturer_id = models.manufacturer_id
                   AND models.model_id = vehicle.model_id
                   AND vehicle.vehicle_id = vehicleservice.vehicle_id
                   AND Services.service_id = vehicleservice.service_id
                   AND parts.part_id = vehicleservice.part_id
                   AND models.modeltype = '" & modelname & "' "

            DataAdapter1 = New MySqlDataAdapter(sql, conn)
            dset = New DataSet()
            DataAdapter1.Fill(dset, "Fixed Models")
            Quiz1View.DataSource = dset
            Quiz1View.DataMember = "Fixed Models"
        Catch ex As MySqlException
            MsgBox("Error in collecting data from Database. Error is :" & ex.Message)

        Catch exception As Exception
            MsgBox("Error in code. Error is :" & exception.Message)
        End Try

        conn.Close()
    End Sub

End Class