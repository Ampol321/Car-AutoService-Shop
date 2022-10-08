Imports MySql.Data.MySqlClient
Public Class Quiz4
    Private Sub cmdsearch_Click(sender As Object, e As EventArgs) Handles cmdsearch.Click
        Dim servicetype = txtstype.Text

        Try
            conn.Open()
            sql = "SELECT Vehicle.Vehicle_id, Services.Type, Manufacturer.ManufacturerName, Models.ModelType,
                   Vehicle.Maintenance, VehicleService.DateOfService FROM Services, VehicleService,
                   Vehicle, Models, Manufacturer WHERE Services.Service_id = VehicleService.Service_id
                   AND VehicleService.Vehicle_id = Vehicle.Vehicle_id
                   AND Models.Model_id = Vehicle.Model_id
                   AND Manufacturer.Manufacturer_id = Models.Manufacturer_id
                   AND Services.Type = '" & servicetype & "'"

            DataAdapter1 = New MySqlDataAdapter(sql, conn)
            dset = New DataSet()
            DataAdapter1.Fill(dset, "Service Mechanics")
            Quiz4View.DataSource = dset
            Quiz4View.DataMember = "Service Mechanics"
        Catch ex As MySqlException
            MsgBox("Error in collecting data from Database. Error is :" & ex.Message)

        Catch exception As Exception
            MsgBox("Error in code. Error is :" & exception.Message)
        End Try

        conn.Close()
    End Sub

End Class