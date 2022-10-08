Imports MySql.Data.MySqlClient
Public Class Mechanics
    Private Sub mreset_Click(sender As Object, e As EventArgs) Handles mreset.Click
        txtmid.Clear()
        txtmname.Clear()
        txtmphone.Clear()
        txtmbday.Clear()
        txtmcity.Clear()
        txtmstreet.Clear()
        txtmzip.Clear()
    End Sub

    Private Sub mechanic_Load(sender As Object, e As EventArgs) Handles MyBase.Load, txtmid.TextChanged
        Dim mechanic_id As Integer
        mechanic_id = Val(txtmid.Text)
        mechanicid = Val(txtmid.Text)

        Try
            conn.Open()
            sql = "SELECT * FROM mechanics WHERE mechanic_id = " & mechanic_id
            dbcomm = New MySqlCommand(sql, conn)

            dbread = dbcomm.ExecuteReader()
            While dbread.Read
                txtmname.Text = dbread("MechanicName")
                txtmbday.Text = dbread("Birthday")
                txtmcity.Text = dbread("City")
                txtmstreet.Text = dbread("Street")
                txtmzip.Text = dbread("ZipCode")
                txtmphone.Text = dbread("Phone")
            End While
        Catch ex As MySqlException
            MsgBox("Error in collecting data from Database. Error is :" & ex.Message)
        End Try

        dbread.Close()
        conn.Close()
    End Sub

    Private Sub mcreate_Click(sender As Object, e As EventArgs) Handles mcreate.Click
        Dim Name = txtmname.Text
        Dim Phone = txtmphone.Text
        Dim Bday = txtmbday.Text
        Dim City = txtmcity.Text
        Dim Street = txtmstreet.Text
        Dim ZipCode = txtmzip.Text
        Dim ans = MessageBox.Show("Do you want to register this Mechanic?", "Save Mechanic Data",
                  MessageBoxButtons.YesNoCancel)

        If ans = DialogResult.Yes Then
            Try
                conn.Open()
                sql = "INSERT INTO mechanics (MechanicName,birthday,city,street,zipcode,phone) " &
                       "VALUES ( '" & Name & "' , '" & Bday & "' , '" & City & "',
                       '" & Street & "', '" & ZipCode & "', '" & Phone & "')"

                dbcomm = New MySqlCommand(sql, conn)
                Dim i As Integer = dbcomm.ExecuteNonQuery
                If (i > 0) Then
                    MsgBox("Mechanic's data has been saved")
                Else
                    MsgBox("Failed to save Mechanic's Data")
                End If
            Catch ex As MySqlException
                MsgBox("Error in collecting data from Database. Error is :" & ex.Message)
            End Try
        End If
        conn.Close()
    End Sub

    Private Sub mread_Click(sender As Object, e As EventArgs) Handles mread.Click
        Try
            conn.Open()
            sql = "SELECT * FROM mechanics"
            DataAdapter1 = New MySqlDataAdapter(sql, conn)
            dset = New DataSet()
            DataAdapter1.Fill(dset, "mechanics")
            MechanicView.DataSource = dset
            MechanicView.DataMember = "mechanics"
        Catch ex As MySqlException
            MsgBox("Error in collecting data from Database. Error is :" & ex.Message)

        Catch exception As Exception
            MsgBox("Error in code. Error is :" & exception.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub mupdate_Click(sender As Object, e As EventArgs) Handles mupdate.Click
        Dim Mechanicid As Integer = Val(txtmid.Text)
        Dim Name = txtmname.Text
        Dim Phone = txtmphone.Text
        Dim Bday = txtmbday.Text
        Dim City = txtmcity.Text
        Dim Street = txtmstreet.Text
        Dim ZipCode = txtmzip.Text
        Dim ans = MessageBox.Show("Do you want to update this Mechanic's record?", "Update Mechanic Data",
                  MessageBoxButtons.YesNoCancel)

        If ans = DialogResult.Yes Then
            Try
                conn.Open()
                sql = "UPDATE mechanics SET MechanicName = '" & Name & "', Birthday = '" & Bday & "',
                City = '" & City & "', Street = '" & Street & "', ZipCode = '" & ZipCode & "',
                Phone = '" & Phone & "'WHERE mechanic_id = '" & Mechanicid & "'"

                dbcomm = New MySqlCommand(sql, conn)
                Dim i As Integer = dbcomm.ExecuteNonQuery

                If (i > 0) Then
                    MsgBox("Mechanic's Data has been updated")
                Else
                    MsgBox("Failed to update Mechanic's Data")
                End If

            Catch ex As MySqlException
                MsgBox("Error in collecting data from Database. Error is :" & ex.Message)
            End Try
        End If
        conn.Close()
    End Sub

    Private Sub mdelete_Click(sender As Object, e As EventArgs) Handles mdelete.Click
        Dim Mechanicid As Integer = Val(InputBox("Enter Mechanic's ID that you want to delete", "Delete Mechanic's Data"))
        Dim ans = MessageBox.Show("Do you want to delete this Mechanic's Data?", "Mechanic's Data has been deleted",
                  MessageBoxButtons.YesNoCancel)

        If ans = DialogResult.Yes Then
            Try
                conn.Open()
                sql = "DELETE from mechanics WHERE mechanic_id = " & Mechanicid

                dbcomm = New MySqlCommand(sql, conn)
                Dim i As Integer = dbcomm.ExecuteNonQuery
                If (i > 0) Then
                    MsgBox("Mechanic's Data has been deleted")
                Else
                    MsgBox("Failed to delete Mechanic's Data")
                End If
            Catch ex As MySqlException
                MsgBox("Error in collecting data from Database. Error is :" & ex.Message)
            End Try
        End If

        sql1 = "ALTER TABLE mechanics Auto_Increment = 0"
        dbcomm = New MySqlCommand(sql1, conn)
        dbcomm.ExecuteNonQuery()

        conn.Close()
    End Sub

    Private Sub cmdassign_Click(sender As Object, e As EventArgs) Handles cmdassign.Click
        Dim ans = MessageBox.Show("Do you want to deploy this mechanic?",
                                  "Deploy a mechanic", MessageBoxButtons.YesNoCancel)

        If ans = DialogResult.Yes Then
            Try
                conn.Open()

                sql = "INSERT INTO servicemechanics(service_id,mechanic_id)
                       VALUES (" & serviceid & ", " & mechanicid & ")"

                dbcomm = New MySqlCommand(sql, conn)
                Dim x As Integer = dbcomm.ExecuteNonQuery

                If (x > 0) Then
                    MsgBox("Mechanic Deployment Successful")
                Else
                    MsgBox("Failed to Deploy Mechanic")
                End If

            Catch ex As MySqlException
                MsgBox("Error in collecting data from Database. Error is :" & ex.Message)
            End Try
        End If
        conn.Close()
    End Sub
End Class