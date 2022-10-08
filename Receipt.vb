Imports MySql.Data.MySqlClient
Public Class Receipt
    Dim resibo As New CrystalReport1
    Private Sub Receipt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conn.Open()

            sql = "SELECT Customer.Name, Manufacturer.ManufacturerName, Models.ModelType,
                   Services.Type,ServiceFee, Parts.PartType,PartPrice, Neededparts.ItemQty
                   FROM Customer,Vehicle,Models,Manufacturer,VehicleService,Services,Neededparts,Parts
                   WHERE Customer.customer_id = Vehicle.customer_id AND Models.Model_id = Vehicle.Model_id
                   AND Manufacturer.manufacturer_id = Models.manufacturer_id
                   AND vehicle.vehicle_id = vehicleservice.vehicle_id
                   AND vehicleservice.service_id = services.service_id
                   AND vehicle.vehicle_id = neededparts.vehicle_id
                   AND neededparts.part_id = parts.part_id
                   AND vehicle.vehicle_id = " & vehicleid & " "

            dbcomm = New MySqlCommand(sql, conn)
            dbread = dbcomm.ExecuteReader
            dtable.Load(dbread)
            dbread.Close()

            resibo.SetDataSource(dtable)
            CrystalReportViewer1.ReportSource = resibo
            CrystalReportViewer1.Refresh()

        Catch ex As MySqlException
            MsgBox("Error in collecting data from Database. Error is :" & ex.Message)
        End Try
        conn.Close()
    End Sub
End Class