Imports MySql.Data.MySqlClient
Public Class Parts
    Dim serve As New Services
    Private Sub apreset_Click(sender As Object, e As EventArgs) Handles apreset.Click
        txtapid.Clear()
        txtaptype.Clear()
        txtapprice.Clear()
    End Sub

    Private Sub accessories_Load(sender As Object, e As EventArgs) Handles MyBase.Load, txtapid.TextChanged
        Dim part_id As Integer
        part_id = Val(txtapid.Text)

        Try
            conn.Open()
            sql = "SELECT * FROM parts WHERE part_id = " & part_id
            dbcomm = New MySqlCommand(sql, conn)

            dbread = dbcomm.ExecuteReader()
            While dbread.Read
                txtaptype.Text = dbread("PartType")
                txtapprice.Text = dbread("PartPrice")
            End While
        Catch ex As MySqlException
            MsgBox("Error in collecting data from Database. Error is :" & ex.Message)
        End Try

        dbread.Close()
        conn.Close()
    End Sub

    Private Sub apcreate_Click(sender As Object, e As EventArgs) Handles apcreate.Click
        Dim type = txtaptype.Text
        Dim price = txtapprice.Text

        Dim ans = MessageBox.Show("Do you want to register this type of Accessorie?", "Save Accessorie Data",
                  MessageBoxButtons.YesNoCancel)

        If ans = DialogResult.Yes Then
            Try
                conn.Open()
                sql = "INSERT INTO parts (PartType,partprice) VALUES ( '" & type & "' , '" & price & "')"

                dbcomm = New MySqlCommand(sql, conn)
                Dim i As Integer = dbcomm.ExecuteNonQuery
                If (i > 0) Then
                    MsgBox("Accessorie's data has been saved")
                Else
                    MsgBox("Failed to save Accessorie's Data")
                End If
            Catch ex As MySqlException
                MsgBox("Error in collecting data from Database. Error is :" & ex.Message)
            End Try
        End If
        conn.Close()
    End Sub

    Private Sub apread_Click(sender As Object, e As EventArgs) Handles apread.Click
        Try
            conn.Open()
            sql = "SELECT * FROM parts"
            DataAdapter1 = New MySqlDataAdapter(sql, conn)
            dset = New DataSet()
            DataAdapter1.Fill(dset, "parts")
            PartsView.DataSource = dset
            PartsView.DataMember = "parts"
        Catch ex As MySqlException
            MsgBox("Error in collecting data from Database. Error is :" & ex.Message)

        Catch exception As Exception
            MsgBox("Error in code. Error is :" & exception.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub apupdate_Click(sender As Object, e As EventArgs) Handles apupdate.Click
        Dim Partsid As Integer = Val(txtapid.Text)
        Dim type = txtaptype.Text
        Dim price = txtapprice.Text

        Dim ans = MessageBox.Show("Do you want to update this type of Accessorie's record?",
                                  "Update Accessorie Data", MessageBoxButtons.YesNoCancel)

        If ans = DialogResult.Yes Then
            Try
                conn.Open()
                sql = "UPDATE parts SET PartType = '" & type & "', partprice = '" & price & "'
                WHERE part_id = '" & Partsid & "'"

                dbcomm = New MySqlCommand(sql, conn)
                Dim i As Integer = dbcomm.ExecuteNonQuery

                If (i > 0) Then
                    MsgBox("Accessorie's Data has been updated")
                Else
                    MsgBox("Failed to update Accessorie's Data")
                End If

            Catch ex As MySqlException
                MsgBox("Error in collecting data from Database. Error is :" & ex.Message)
            End Try
        End If
        conn.Close()
    End Sub

    Private Sub apdelete_Click(sender As Object, e As EventArgs) Handles apdelete.Click
        Dim Partsid As Integer = Val(InputBox("Enter Accessorie's ID that you want to delete",
                                                    "Delete Accessorie Data"))

        Dim ans = MessageBox.Show("Do you want to delete this type of Accessorie's Data?",
                                  "Accessorie's Data has been deleted", MessageBoxButtons.YesNoCancel)

        If ans = DialogResult.Yes Then
            Try
                conn.Open()
                sql = "DELETE from parts WHERE part_id = " & Partsid

                dbcomm = New MySqlCommand(sql, conn)
                Dim i As Integer = dbcomm.ExecuteNonQuery
                If (i > 0) Then
                    MsgBox("Accessorie's Data has been deleted")
                Else
                    MsgBox("Failed to delete Accessorie's Data")
                End If
            Catch ex As MySqlException
                MsgBox("Error in collecting data from Database. Error is :" & ex.Message)
            End Try
        End If

        sql1 = "ALTER TABLE parts Auto_Increment = 0"
        dbcomm = New MySqlCommand(sql1, conn)
        dbcomm.ExecuteNonQuery()

        conn.Close()
    End Sub

    Private Sub cmdpurchase_Click(sender As Object, e As EventArgs) Handles cmdpurchase.Click
        Dim quantity = Val(txtqty.Text)

        If quantity <= 0 Or Nothing Then
            MsgBox("Please Input a valid quantity!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim ans = MessageBox.Show("Do you want to purchase this part(s)?", "Purchase a part",
                                      MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)

            If ans = DialogResult.Yes Then
                Try
                    conn.Open()
                    partid = Val(txtapid.Text)

                    sql = "INSERT INTO vehicleservice (vehicle_id,service_id,part_id,ItemQty,DateOfService)
                          VALUES (" & vehicleid & ", " & serviceid & ", " & partid & "," & quantity & ",now())"

                    dbcomm = New MySqlCommand(sql, conn)
                    dbcomm.ExecuteNonQuery()

                    sql1 = "UPDATE Parts SET stock = stock - " & quantity & " 
                            WHERE part_id = " & partid & ""

                    dbcomm2 = New MySqlCommand(sql1, conn)
                    dbcomm2.ExecuteNonQuery()

                    MsgBox("Part(s) Successfully Purchased!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    conn.Close()

                Catch ex As MySqlException
                    MsgBox("Error in collecting data from Database. Error is :" & ex.Message)
                End Try
            End If
            Dim message = MessageBox.Show("Would you like to purchase a part(s) again?", "Purchase a part",
                                          MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)

            If message = DialogResult.Yes Then
                serviceid = 1
            ElseIf message = DialogResult.No Then
                FullServiceReceipt.Show()
            End If
        End If

        'Dim message = MessageBox.Show("Would you like to purchase a part(s) again?",
        '                              "Purchase a part", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)

        'If message = DialogResult.Yes Then
        '    quantity = Val(txtqty.Text)
        '    serviceid = 1

        '    q1 = "INSERT INTO vehicleservice (vehicle_id,service_id,part_id,ItemQty,DateOfService)
        '                  VALUES (" & vehicleid & ", " & serviceid & ", " & partid & "," & quantity & ",now())"

        '    dbcomm1 = New MySqlCommand(q1, conn)
        '    dbcomm1.ExecuteNonQuery()

        '    sql1 = "UPDATE Parts SET stock = stock - " & quantity & " 
        '                WHERE part_id = " & partid & ""

        '    dbcomm2 = New MySqlCommand(sql1, conn)
        '    dbcomm2.ExecuteNonQuery()

        '    conn.Close()

        'ElseIf message = DialogResult.No Then
        '    FullServiceReceipt.Show()
        'End If

        'Dim quantity = txtqty.Text

        'If quantity <= 0 Then
        '    MsgBox("Please Enter a valid quantity", MessageBoxIcon.Information)
        'Else
        '    Dim ans = MessageBox.Show("Do you want to purchase this part(s)?",
        '                          "Purchase a part", MessageBoxButtons.YesNoCancel)

        '    If ans = DialogResult.Yes Then
        '        Try
        '            conn.Open()

        '            sql = "INSERT INTO neededparts(service_id,part_id,itemqty)
        '               VALUES (" & serviceid & ", " & partid & ", " & quantity & ")"

        '            dbcomm = New MySqlCommand(sql, conn)
        '            Dim x As Integer = dbcomm.ExecuteNonQuery()

        '            If (x > 0) Then
        '                MsgBox("Part(s) successfully purchased!")
        '            Else
        '                MsgBox("Failed to make a purchase")
        '            End If

        '            sql1 = "UPDATE Parts SET stock = stock - " & Val(txtqty.Text) & "
        '                WHERE part_id = " & partid & ""

        '            dbcomm1 = New MySqlCommand(sql1, conn)
        '            dbcomm1.ExecuteNonQuery()

        '        Catch ex As MySqlException
        '            MsgBox("Error in collecting data from Database. Error is :" & ex.Message)
        '        End Try
        '        conn.Close()

        '        Dim message = MessageBox.Show("Would you like to purchase a part(s) again?",
        '                          "Purchase a part", MessageBoxButtons.YesNoCancel)

        '        If message = DialogResult.Yes Then
        '            serve.txtsvid.Clear()
        '            serve.txtsvtype.Clear()
        '            serve.txtsfee.Clear()

        '            conn.Open()
        '            q1 = "INSERT INTO vehicleservice (vehicle_id,service_id,dateofservice)
        '                  VALUES (" & vehicleid & ",1,now())"

        '            dbcomm2 = New MySqlCommand(q1, conn)
        '            dbcomm2.ExecuteNonQuery()
        '            conn.Close()

        '        ElseIf message = DialogResult.No Then
        '            FullServiceReceipt.Show()
        '        End If
        '    End If
        'End If
    End Sub
End Class