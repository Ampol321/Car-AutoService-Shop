Imports MySql.Data.MySqlClient
Public Class Customers
    Private Sub creset_Click(sender As Object, e As EventArgs) Handles creset.Click
        txtcid.Clear()
        txtcname.Clear()
        txtcphone.Clear()
        txtcemail.Clear()
        txtccity.Clear()
        txtcstreet.Clear()
        txtczip.Clear()
    End Sub

    Private Sub customer_Load(sender As Object, e As EventArgs) Handles MyBase.Load, txtcid.TextChanged
        Dim customer_id As Integer
        customer_id = Val(txtcid.Text)
        customerid = Val(txtcid.Text)

        Try
            conn.Open()
            sql = "SELECT * FROM customer WHERE customer_id = " & customer_id
            dbcomm = New MySqlCommand(sql, conn)

            dbread = dbcomm.ExecuteReader()
            While dbread.Read
                txtcname.Text = dbread("Name")
                txtcphone.Text = dbread("Phone")
                txtcemail.Text = dbread("Email")
                txtccity.Text = dbread("City")
                txtcstreet.Text = dbread("Street")
                txtczip.Text = dbread("ZipCode")
            End While
        Catch ex As MySqlException
            MsgBox("Error in collecting data from Database. Error is :" & ex.Message)
        End Try

        dbread.Close()
        conn.Close()
    End Sub

    Private Sub ccreate_Click(sender As Object, e As EventArgs) Handles ccreate.Click
        Dim Name = txtcname.Text
        Dim Phone = txtcphone.Text
        Dim Email = txtcemail.Text
        Dim City = txtccity.Text
        Dim Street = txtcstreet.Text
        Dim ZipCode = txtczip.Text
        Dim ans = MessageBox.Show("Do you want to register this customer?", "Save Customer Data",
                  MessageBoxButtons.YesNoCancel)

        If ans = DialogResult.Yes Then
            Try
                conn.Open()
                sql = "INSERT INTO customer (name,phone,email,city,street,zipcode) " &
                       "VALUES ( '" & Name & "' , '" & Phone & "' , '" & Email & "',
                       '" & City & "', '" & Street & "', '" & ZipCode & "')"

                dbcomm = New MySqlCommand(sql, conn)
                Dim i As Integer = dbcomm.ExecuteNonQuery
                If (i > 0) Then
                    MsgBox("Customer data has been saved")
                Else
                    MsgBox("Failed to save Customer's Data")
                End If
            Catch ex As MySqlException
                MsgBox("Error in collecting data from Database. Error is :" & ex.Message)
            End Try
        End If
        conn.Close()
    End Sub

    Private Sub cread_Click(sender As Object, e As EventArgs) Handles cread.Click
        Try
            conn.Open()
            sql = "SELECT * FROM customer"
            DataAdapter1 = New MySqlDataAdapter(sql, conn)
            dset = New DataSet()
            DataAdapter1.Fill(dset, "customer")
            CustomerView.DataSource = dset
            CustomerView.DataMember = "customer"
        Catch ex As MySqlException
            MsgBox("Error in collecting data from Database. Error is :" & ex.Message)

        Catch exception As Exception
            MsgBox("Error in code. Error is :" & exception.Message)
        End Try

        conn.Close()
    End Sub

    Private Sub cupdate_Click(sender As Object, e As EventArgs) Handles cupdate.Click
        Dim Customerid As Integer = Val(txtcid.Text)
        Dim Name = txtcname.Text
        Dim Phone = txtcphone.Text
        Dim Email = txtcemail.Text
        Dim City = txtccity.Text
        Dim Street = txtcstreet.Text
        Dim ZipCode = txtczip.Text
        Dim ans = MessageBox.Show("Do you want to update this Customer's record?", "Update Customer Data",
                  MessageBoxButtons.YesNoCancel)

        If ans = DialogResult.Yes Then
            Try
                conn.Open()
                sql = "UPDATE customer SET Name = '" & Name & "', Phone = '" & Phone & "',
                Email = '" & Email & "', City = '" & City & "', Street = '" & Street & "',
                ZipCode = '" & ZipCode & "' WHERE customer_id = '" & Customerid & "'"

                dbcomm = New MySqlCommand(sql, conn)
                Dim i As Integer = dbcomm.ExecuteNonQuery

                If (i > 0) Then
                    MsgBox("Customer's Data has been updated")
                Else
                    MsgBox("Failed to update Customer's Data")
                End If

            Catch ex As MySqlException
                MsgBox("Error in collecting data from Database. Error is :" & ex.Message)
            End Try
        End If
        conn.Close()
    End Sub

    Private Sub cdelete_Click(sender As Object, e As EventArgs) Handles cdelete.Click
        Dim Customerid As Integer = Val(InputBox("Enter Customer's ID that you want to delete", "Delete Customer Data"))
        Dim ans = MessageBox.Show("Do you want to delete this Customer's Data?", "Customer Data has been deleted",
                  MessageBoxButtons.YesNoCancel)

        If ans = DialogResult.Yes Then
            Try
                conn.Open()
                sql = "DELETE from customer WHERE customer_id = " & Customerid

                dbcomm = New MySqlCommand(sql, conn)
                Dim i As Integer = dbcomm.ExecuteNonQuery
                If (i > 0) Then
                    MsgBox("Customer's Data has been deleted")
                Else
                    MsgBox("Failed to delete Customer's Data")
                End If
            Catch ex As MySqlException
                MsgBox("Error in collecting data from Database. Error is :" & ex.Message)
            End Try
        End If

        sql1 = "ALTER TABLE customer Auto_Increment = 0"
        dbcomm = New MySqlCommand(sql1, conn)
        dbcomm.ExecuteNonQuery()

        conn.Close()
    End Sub
End Class