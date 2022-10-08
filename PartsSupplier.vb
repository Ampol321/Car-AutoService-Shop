Imports MySql.Data.MySqlClient
Public Class PartsSupplier
    Private Sub cmdsupply_Click(sender As Object, e As EventArgs) Handles cmdsupply.Click
        Dim qty = Val(InputBox("Enter Amount of Quantity you want to supply", "ITEM QUANTITY"))
        Dim pid As Integer

        Try
            conn.Open()

            sql = "UPDATE parts SET stock = stock + " & qty & " WHERE parttype = '" & cboparts.Text & "'"

            dbcomm = New MySqlCommand(sql, conn)
            Dim x As Integer = dbcomm.ExecuteNonQuery()

            If (X > 0) Then
                MsgBox("Part(s) is successfully supplied", MessageBoxButtons.OK)
            Else
                MsgBox("Failed to supply part(s)")
            End If

            q1 = "SELECT parts.part_id FROM parts WHERE parttype = '" & cboparts.Text & "'"

            dbcomm1 = New MySqlCommand(q1, conn)
            dbread1 = dbcomm1.ExecuteReader()
            dbread1.Read()
            pid = dbread1("part_id")
            dbread1.Close()

            sql1 = "INSERT INTO Deliveredparts (Supplier_id,part_id,datedelivered,itemqty)
                    VALUES (" & supplierid & ", " & pid & ",now()," & qty & ")"

            dbcomm2 = New MySqlCommand(sql1, conn)
            dbcomm2.ExecuteNonQuery()

        Catch ex As MySqlException
            MsgBox("Error in collecting data from Database. Error Is : " & ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub PartsSupplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conn.Open()

            sql = "SELECT parts.parttype FROM parts WHERE parttype <> 'None'"

            dbcomm = New MySqlCommand(sql, conn)
            dbread = dbcomm.ExecuteReader

            While dbread.Read
                cboparts.Items.Add(dbread("parttype"))
            End While

        Catch ex As MySqlException
            MsgBox("Error in collecting data from Database. Error is :" & ex.Message)
        End Try
        conn.Close()
    End Sub
End Class