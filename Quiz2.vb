Imports MySql.Data.MySqlClient
Public Class Quiz2
    Private Sub cmdsearch_Click(sender As Object, e As EventArgs) Handles cmdsearch.Click
        Dim suppliername = txtsname.Text

        Try
            conn.Open()
            sql = "SELECT suppliers.Supplier_id,CompName,Email, parts.PartType, DeliveredParts.ItemQty,DateDelivered
                   FROM Suppliers, Parts, DeliveredParts WHERE Suppliers.supplier_id = DeliveredParts.supplier_id
                   AND DeliveredParts.part_id = Parts.part_id AND Suppliers.CompName = '" & suppliername & "'"

            DataAdapter1 = New MySqlDataAdapter(sql, conn)
            dset = New DataSet()
            DataAdapter1.Fill(dset, "DeliveredParts")
            Quiz2View.DataSource = dset
            Quiz2View.DataMember = "DeliveredParts"
        Catch ex As MySqlException
            MsgBox("Error in collecting data from Database. Error is :" & ex.Message)

        Catch exception As Exception
            MsgBox("Error in code. Error is :" & exception.Message)
        End Try
        conn.Close()

    End Sub
End Class