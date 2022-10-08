Imports MySql.Data.MySqlClient
Public Class DateRangeIncome

    Dim range As New DateRange

    Private Sub cmdshow_Click(sender As Object, e As EventArgs) Handles cmdshow.Click
        Try
            dtable.Clear()
            conn.Open()

            sql = "SELECT customer.name, manufacturer.manufacturername, models.modeltype, vehicleservice.dateofservice,
                   services.type,servicefee, parts.parttype,partprice, vehicleservice.itemqty 
                   FROM customer,manufacturer,models,vehicle,vehicleservice,services,parts
                   WHERE customer.customer_id = vehicle.customer_id
                   AND manufacturer.manufacturer_id = models.manufacturer_id
                   AND models.model_id = vehicle.model_id
                   AND vehicle.vehicle_id = vehicleservice.vehicle_id
                   AND vehicleservice.service_id = services.service_id
                   AND vehicleservice.part_id = parts.part_id
                   AND vehicleservice.dateofservice BETWEEN '" &
                   Convert.ToDateTime(Range1.Value).ToString("yyyy-MM-dd") & "'
                   AND " & "'" & Convert.ToDateTime(Range2.Value).ToString("yyyy-MM-dd") & "'"

            dbcomm = New MySqlCommand(sql, conn)
            dbread = dbcomm.ExecuteReader
            dtable.Load(dbread)
            dbread.Close()

            range.SetDataSource(dtable)
            rangesalesviewer.ReportSource = range
            rangesalesviewer.Refresh()

        Catch ex As MySqlException
            MsgBox("Error in collecting data from Database. Error is :" & ex.Message)
        End Try
        conn.Close()
    End Sub
End Class