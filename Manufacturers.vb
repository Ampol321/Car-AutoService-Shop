Imports MySql.Data.MySqlClient
Public Class Manufacturers
    Private Sub mfreset_Click(sender As Object, e As EventArgs) Handles mfreset.Click
        txtmfname.Clear()
        txtmfemail.Clear()
    End Sub

    Private Sub manufacturer_Load(sender As Object, e As EventArgs) Handles MyBase.Load, txtmfid.TextChanged
        Dim manufacturer_id As Integer
        manufacturer_id = Val(txtmfid.Text)

        Try
            conn.Open()
            sql = "SELECT * FROM manufacturer WHERE manufacturer_id = " & manufacturer_id
            dbcomm = New MySqlCommand(sql, conn)

            dbread = dbcomm.ExecuteReader()
            While dbread.Read
                txtmfname.Text = dbread("ManufacturerName")
                txtmfemail.Text = dbread("Email")
            End While
        Catch ex As MySqlException
            MsgBox("Error in collecting data from Database. Error is :" & ex.Message)
        End Try

        dbread.Close()
        conn.Close()
    End Sub

    Private Sub mfcreate_Click(sender As Object, e As EventArgs) Handles mfcreate.Click
        Dim Name = txtmfname.Text
        Dim Email = txtmfemail.Text

        Dim ans = MessageBox.Show("Do you want to register this Manufacturer?", "Save Manufacturer Data",
                  MessageBoxButtons.YesNoCancel)

        If ans = DialogResult.Yes Then
            Try
                conn.Open()
                sql = "INSERT INTO manufacturer (manufacturername,email) VALUES ( '" & Name & "' , '" & Email & "')"

                dbcomm = New MySqlCommand(sql, conn)
                Dim i As Integer = dbcomm.ExecuteNonQuery
                If (i > 0) Then
                    MsgBox("Manufacturer data has been saved")
                Else
                    MsgBox("Failed to save Manufacturer's Data")
                End If
            Catch ex As MySqlException
                MsgBox("Error in collecting data from Database. Error is :" & ex.Message)
            End Try
        End If
        conn.Close()
    End Sub

    Private Sub mfread_Click(sender As Object, e As EventArgs) Handles mfread.Click
        Try
            conn.Open()
            sql = "SELECT * FROM manufacturer"
            DataAdapter1 = New MySqlDataAdapter(sql, conn)
            dset = New DataSet()
            DataAdapter1.Fill(dset, "manufacturer")
            ManufacturerView.DataSource = dset
            ManufacturerView.DataMember = "manufacturer"
        Catch ex As MySqlException
            MsgBox("Error in collecting data from Database. Error is :" & ex.Message)

        Catch exception As Exception
            MsgBox("Error in code. Error is :" & exception.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub mfupdate_Click(sender As Object, e As EventArgs) Handles mfupdate.Click
        Dim Manufacturerid As Integer = Val(txtmfid.Text)
        Dim Name = txtmfname.Text
        Dim Email = txtmfemail.Text

        Dim ans = MessageBox.Show("Do you want to update this manufacturer's record?",
                                  "Update manufacturer Data", MessageBoxButtons.YesNoCancel)

        If ans = DialogResult.Yes Then
            Try
                conn.Open()
                sql = "UPDATE manufacturer SET ManufacturerName = '" & Name & "', Email = '" & Email & "'
                WHERE manufacturer_id = '" & Manufacturerid & "'"

                dbcomm = New MySqlCommand(sql, conn)
                Dim i As Integer = dbcomm.ExecuteNonQuery

                If (i > 0) Then
                    MsgBox("Manufacturer Data has been updated")
                Else
                    MsgBox("Failed to update Manufacturer's Data")
                End If

            Catch ex As MySqlException
                MsgBox("Error in collecting data from Database. Error is :" & ex.Message)
            End Try
        End If
        conn.Close()
    End Sub

    Private Sub mfdelete_Click(sender As Object, e As EventArgs) Handles mfdelete.Click
        Dim Manufacturerid As Integer = Val(InputBox("Enter Manufacturer's ID that you want to delete",
                                                     "Delete Manufacturer Data"))

        Dim ans = MessageBox.Show("Do you want to delete this Manufacturer's Data?",
                                  "Manufacturer Data has been deleted", MessageBoxButtons.YesNoCancel)

        If ans = DialogResult.Yes Then
            Try
                conn.Open()
                sql = "DELETE from manufacturer WHERE manufacturer_id = " & Manufacturerid

                dbcomm = New MySqlCommand(sql, conn)
                Dim i As Integer = dbcomm.ExecuteNonQuery
                If (i > 0) Then
                    MsgBox("Manufacturer's Data has been deleted")
                Else
                    MsgBox("Failed to delete Manufacturer's Data")
                End If
            Catch ex As MySqlException
                MsgBox("Error in collecting data from Database. Error is :" & ex.Message)
            End Try
        End If

        sql1 = "ALTER TABLE manufacturer Auto_Increment = 0"
        dbcomm = New MySqlCommand(sql1, conn)
        dbcomm.ExecuteNonQuery()

        conn.Close()
    End Sub

End Class