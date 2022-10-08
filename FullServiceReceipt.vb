Imports MySql.Data.MySqlClient
Public Class FullServiceReceipt

    Dim Full As New FullReceipt
    Private Sub FullServiceReceipt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            dtable.Clear()
            conn.Open()

            sql = "SELECT customer.name, manufacturer.manufacturername, models.modeltype, services.type,servicefee,
                   parts.parttype,partprice, vehicleservice.itemqty 
                   FROM customer,manufacturer,models,vehicle,vehicleservice,services,parts
                   WHERE customer.customer_id = vehicle.customer_id
                   AND manufacturer.manufacturer_id = models.manufacturer_id
                   AND models.model_id = vehicle.model_id
                   AND vehicle.vehicle_id = vehicleservice.vehicle_id
                   AND vehicleservice.service_id = services.service_id
                   AND vehicleservice.part_id = parts.part_id
                   AND vehicle.vehicle_id = " & vehicleid & ""

            dbcomm = New MySqlCommand(sql, conn)
            dbread = dbcomm.ExecuteReader
            dtable.Load(dbread)
            dbread.Close()

            Full.SetDataSource(dtable)
            CrystalReportViewer1.ReportSource = Full
            CrystalReportViewer1.Refresh()

        Catch ex As MySqlException
            MsgBox("Error in collecting data from Database. Error is :" & ex.Message)
        End Try
        conn.Close()
    End Sub
End Class