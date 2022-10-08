Imports MySql.Data.MySqlClient
Public Class Receipt1
    Dim resibo1 As New CrystalReport2
    Private Sub Receipt1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conn.Open()

            sql = "SELECT Customer.Name, Manufacturer.Manufacturername, Models.modeltype,
                   Services.type,ServiceFee FROM Customer,Vehicle,Models,Manufacturer,VehicleService,Services
                   WHERE Customer.customer_id = Vehicle.customer_id AND Models.Model_id = Vehicle.Model_id
                   AND Manufacturer.manufacturer_id = Models.manufacturer_id
                   AND vehicle.vehicle_id = vehicleservice.vehicle_id
                   AND vehicleservice.service_id = services.service_id
                   AND vehicle.vehicle_id = " & vehicleid & ""

            dbcomm = New MySqlCommand(sql, conn)
            dbread = dbcomm.ExecuteReader
            dtable.Load(dbread)
            dbread.Close()

            resibo1.SetDataSource(dtable)
            CrystalReportViewer1.ReportSource = resibo1
            CrystalReportViewer1.Refresh()

        Catch ex As MySqlException
            MsgBox("Error in collecting data from Database. Error is :" & ex.Message)
        End Try
        conn.Close()
    End Sub
End Class