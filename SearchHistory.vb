Imports MySql.Data.MySqlClient
Public Class SearchHistory
    Private Sub cmdsearch_Click(sender As Object, e As EventArgs) Handles cmdsearch.Click
        Dim customername = txtcustname.Text
        Label3.Visible = True

        Try
            conn.Open()

            sql = "SELECT Vehicle.vehicle_id, Customer.Name, Manufacturer.ManufacturerName, Models.ModelType,
                   Type.CarType, Services.Type,ServiceFee, Parts.PartType,PartPrice, Vehicleservice.ItemQty
                   FROM Customer,Vehicle,Models,Manufacturer,Type, VehicleService,Services,Parts
                   WHERE Customer.customer_id = Vehicle.customer_id
                   AND Models.Model_id = Vehicle.Model_id
                   AND Manufacturer.manufacturer_id = Models.manufacturer_id
                   AND Type.Class_id = vehicle.class_id
                   AND vehicle.vehicle_id = vehicleservice.vehicle_id
                   AND vehicleservice.service_id = services.service_id
                   AND parts.part_id  = vehicleservice.part_id
                   AND customer.name = '" & customername & "'"

            DataAdapter1 = New MySqlDataAdapter(sql, conn)
            dset = New DataSet()
            DataAdapter1.Fill(dset, "History")
            HistoryView1.DataSource = dset
            HistoryView1.DataMember = "History"

            Dim total As Decimal = 0.0

            For Each row As DataGridViewRow In HistoryView1.Rows
                total = total + (row.Cells("column9").Value * row.Cells("column10").Value) + row.Cells("column7").Value
            Next
            Label3.Text = "Php " & total & ".00"

        Catch ex As MySqlException
            MsgBox("Error in collecting data from Database. Error is :" & ex.Message)
        End Try
        conn.Close()
    End Sub

End Class