Imports MySql.Data.MySqlClient
Public Class Services
    Private Sub svreset_Click(sender As Object, e As EventArgs) Handles svreset.Click
        txtsvid.Clear()
        txtsvtype.Clear()
        txtsfee.Clear()
    End Sub

    Private Sub service_Load(sender As Object, e As EventArgs) Handles MyBase.Load, txtsvid.TextChanged
        Dim service_id As Integer
        service_id = Val(txtsvid.Text)

        Try
            conn.Open()
            sql = "SELECT * FROM services WHERE service_id = " & service_id
            dbcomm = New MySqlCommand(sql, conn)

            dbread = dbcomm.ExecuteReader()
            While dbread.Read
                txtsvtype.Text = dbread("type")
                txtsfee.Text = dbread("ServiceFee")
            End While
        Catch ex As MySqlException
            MsgBox("Error in collecting data from Database. Error is :" & ex.Message)
        End Try

        dbread.Close()
        conn.Close()
    End Sub

    Private Sub svcreate_Click(sender As Object, e As EventArgs) Handles svcreate.Click
        Dim type = txtsvtype.Text
        Dim sfee = txtsfee.Text

        Dim ans = MessageBox.Show("Do you want to register this type of Service?", "Save Service Data",
                  MessageBoxButtons.YesNoCancel)

        If ans = DialogResult.Yes Then
            Try
                conn.Open()
                sql = "INSERT INTO Services (type,servicefee) VALUES ( '" & type & "', '" & sfee & "')"

                dbcomm = New MySqlCommand(sql, conn)
                Dim i As Integer = dbcomm.ExecuteNonQuery
                If (i > 0) Then
                    MsgBox("Service's data has been saved")
                Else
                    MsgBox("Failed to save Service's Data")
                End If
            Catch ex As MySqlException
                MsgBox("Error in collecting data from Database. Error is :" & ex.Message)
            End Try
        End If
        conn.Close()
    End Sub

    Private Sub svread_Click(sender As Object, e As EventArgs) Handles svread.Click
        Try
            conn.Open()
            sql = "SELECT * FROM services"
            DataAdapter1 = New MySqlDataAdapter(sql, conn)
            dset = New DataSet()
            DataAdapter1.Fill(dset, "services")
            ServiceView.DataSource = dset
            ServiceView.DataMember = "services"
        Catch ex As MySqlException
            MsgBox("Error in collecting data from Database. Error is :" & ex.Message)

        Catch exception As Exception
            MsgBox("Error in code. Error is :" & exception.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub svupdate_Click(sender As Object, e As EventArgs) Handles svupdate.Click
        Dim Service_id As Integer = Val(txtsvid.Text)
        Dim type = txtsvtype.Text
        Dim sfee = txtsfee.Text

        Dim ans = MessageBox.Show("Do you want to update this type of Services's record?",
                                  "Update suppliers Data", MessageBoxButtons.YesNoCancel)

        If ans = DialogResult.Yes Then
            Try
                conn.Open()

                sql = "UPDATE services SET type = '" & type & "', servicefee = '" & sfee & "'
                WHERE service_id = '" & Service_id & "'"

                dbcomm = New MySqlCommand(sql, conn)
                Dim i As Integer = dbcomm.ExecuteNonQuery

                If (i > 0) Then
                    MsgBox("Service's Data has been updated")
                Else
                    MsgBox("Failed to update Service's Data")
                End If

            Catch ex As MySqlException
                MsgBox("Error in collecting data from Database. Error is :" & ex.Message)
            End Try
        End If
        conn.Close()
    End Sub

    Private Sub svdelete_Click(sender As Object, e As EventArgs) Handles svdelete.Click
        Dim Serviceid As Integer = Val(InputBox("Enter Service's ID that you want to delete",
                                                     "Delete Service Data"))

        Dim ans = MessageBox.Show("Do you want to delete this type of Service's Data?",
                                  "Service's Data has been deleted", MessageBoxButtons.YesNoCancel)

        If ans = DialogResult.Yes Then
            Try
                conn.Open()
                sql = "DELETE from services WHERE service_id = " & Serviceid

                dbcomm = New MySqlCommand(sql, conn)
                Dim i As Integer = dbcomm.ExecuteNonQuery
                If (i > 0) Then
                    MsgBox("Service's Data has been deleted")
                Else
                    MsgBox("Failed to delete Service's Data")
                End If
            Catch ex As MySqlException
                MsgBox("Error in collecting data from Database. Error is :" & ex.Message)
            End Try
        End If

        sql1 = "ALTER TABLE services Auto_Increment = 0"
        dbcomm = New MySqlCommand(sql1, conn)
        dbcomm.ExecuteNonQuery()

        conn.Close()
    End Sub

    Private Sub cmdavail_Click(sender As Object, e As EventArgs) Handles cmdavail.Click

        If txtsvid.Text = Nothing Then
            MsgBox("Please avail a service first!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim ans = MessageBox.Show("Do you want to avail this type of Service?", "Avail a service",
                                      MessageBoxButtons.YesNoCancel)

            If ans = DialogResult.Yes Then
                Try
                    serviceid = Val(txtsvid.Text)
                    MsgBox("Service Availed!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Dim message = MessageBox.Show("Would you also like to purchase a part(s) from our shop?", "Purchase a part",
                                                  MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)

                    If message = DialogResult.Yes Then
                        Parts.MdiParent = MainMenu
                        Parts.Dock = DockStyle.Fill
                        Parts.Show()
                        Me.Hide()
                    ElseIf message = DialogResult.No Then
                        conn.Open()

                        q1 = "INSERT INTO vehicleservice (vehicle_id,service_id,part_id,ItemQty,DateOfService)
                          VALUES (" & vehicleid & ", " & serviceid & ", 1,0,now())"

                        dbcomm1 = New MySqlCommand(q1, conn)
                        dbcomm1.ExecuteNonQuery()

                        conn.Close()

                        FullServiceReceipt.Show()
                    End If
                Catch ex As MySqlException
                    MsgBox("Error in collecting data from Database. Error is :" & ex.Message)
                End Try
            End If
        End If
        'Dim ans = MessageBox.Show("Do you want to avail this type of Service?",
        '                          "Avail a service", MessageBoxButtons.YesNoCancel)

        'If ans = DialogResult.Yes Then
        '    Try
        '        conn.Open()

        '        sql = "INSERT INTO vehicleservice(vehicle_id,service_id,dateofservice)
        '               VALUES (" & vehicleid & ", " & serviceid & ", now())"

        '        dbcomm = New MySqlCommand(sql, conn)
        '        Dim x As Integer = dbcomm.ExecuteNonQuery

        '        If (x > 0) Then
        '            MsgBox("Service availed")

        '        Else
        '            MsgBox("Failed to avail service")
        '        End If

        '    Catch ex As MySqlException
        '        MsgBox("Error in collecting data from Database. Error is :" & ex.Message)
        '    End Try
        'End If
        'conn.Close()


        'Dim message = MessageBox.Show("Would you also like to purchase a part(s) from our shop?",
        '                         "Purchase a part", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)

        'If message = DialogResult.No Then
        '    conn.Open()

        '    q1 = "INSERT INTO neededparts (Service_id,Part_id,ItemQty) VALUES (" & serviceid & ",1,0)"

        '    dbcomm1 = New MySqlCommand(q1, conn)
        '    dbcomm1.ExecuteNonQuery()
        '    conn.Close()

        '    FullServiceReceipt.Show()
        'ElseIf message = DialogResult.Yes Then
        '    Parts.MdiParent = MainMenu
        '    Parts.Dock = DockStyle.Fill
        '    Parts.Show()
        '    Me.Hide()
        'End If

    End Sub
End Class