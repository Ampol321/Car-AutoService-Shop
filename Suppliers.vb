Imports MySql.Data.MySqlClient
Public Class Suppliers
    Private Sub supreset_Click(sender As Object, e As EventArgs) Handles supreset.Click
        txtsupcity.Clear()
        txtsupemail.Clear()
        txtsupid.Clear()
        txtsupname.Clear()
        txtsupphone.Clear()
    End Sub

    Private Sub supplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load, txtsupid.TextChanged
        Dim supplier_id As Integer
        supplier_id = Val(txtsupid.Text)
        supplierid = Val(txtsupid.Text)

        Try
            conn.Open()
            sql = "SELECT * FROM suppliers WHERE supplier_id = " & supplier_id
            dbcomm = New MySqlCommand(sql, conn)

            dbread = dbcomm.ExecuteReader()
            While dbread.Read
                txtsupname.Text = dbread("CompName")
                txtsupphone.Text = dbread("Phone")
                txtsupemail.Text = dbread("Email")
                txtsupcity.Text = dbread("City")
            End While
        Catch ex As MySqlException
            MsgBox("Error in collecting data from Database. Error is :" & ex.Message)
        End Try

        dbread.Close()
        conn.Close()
    End Sub

    Private Sub supcreate_Click(sender As Object, e As EventArgs) Handles supcreate.Click
        Dim Name = txtsupname.Text
        Dim Phone = txtsupphone.Text
        Dim Email = txtsupemail.Text
        Dim City = txtsupcity.Text

        Dim ans = MessageBox.Show("Do you want to register this Supplier?", "Save Supplier Data",
                  MessageBoxButtons.YesNoCancel)

        If ans = DialogResult.Yes Then
            Try
                conn.Open()
                sql = "INSERT INTO Suppliers (CompName,phone,email,city) VALUES ( '" & Name & "' , '" & Phone & "' ,
                '" & Email & "' , '" & City & "')"

                dbcomm = New MySqlCommand(sql, conn)
                Dim i As Integer = dbcomm.ExecuteNonQuery
                If (i > 0) Then
                    MsgBox("Supplier's data has been saved")
                Else
                    MsgBox("Failed to save Supplier's Data")
                End If
            Catch ex As MySqlException
                MsgBox("Error in collecting data from Database. Error is :" & ex.Message)
            End Try
        End If
        conn.Close()
    End Sub

    Private Sub supread_Click(sender As Object, e As EventArgs) Handles supread.Click
        Try
            conn.Open()
            sql = "SELECT * FROM suppliers"
            DataAdapter1 = New MySqlDataAdapter(sql, conn)
            dset = New DataSet()
            DataAdapter1.Fill(dset, "suppliers")
            SupplierView.DataSource = dset
            SupplierView.DataMember = "suppliers"
        Catch ex As MySqlException
            MsgBox("Error in collecting data from Database. Error is :" & ex.Message)

        Catch exception As Exception
            MsgBox("Error in code. Error is :" & exception.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub supupdate_Click(sender As Object, e As EventArgs) Handles supupdate.Click
        Dim Supplierid As Integer = Val(txtsupid.Text)
        Dim Name = txtsupname.Text
        Dim Phone = txtsupphone.Text
        Dim Email = txtsupemail.Text
        Dim City = txtsupcity.Text

        Dim ans = MessageBox.Show("Do you want to update this suppliers's record?",
                                  "Update suppliers Data", MessageBoxButtons.YesNoCancel)

        If ans = DialogResult.Yes Then
            Try
                conn.Open()
                sql = "UPDATE suppliers SET CompName = '" & Name & "', Phone = '" & Phone & "' ,
                Email = '" & Email & "', City = '" & City & "'
                WHERE supplier_id = '" & Supplierid & "'"

                dbcomm = New MySqlCommand(sql, conn)
                Dim i As Integer = dbcomm.ExecuteNonQuery

                If (i > 0) Then
                    MsgBox("Supplier Data has been updated")
                Else
                    MsgBox("Failed to update Supplier's Data")
                End If

            Catch ex As MySqlException
                MsgBox("Error in collecting data from Database. Error is :" & ex.Message)
            End Try
        End If
        conn.Close()
    End Sub

    Private Sub supdelete_Click(sender As Object, e As EventArgs) Handles supdelete.Click
        Dim Supplierid As Integer = Val(InputBox("Enter Supplier's ID that you want to delete",
                                                     "Delete Supplier Data"))

        Dim ans = MessageBox.Show("Do you want to delete this Supplier's Data?",
                                  "Supplier Data has been deleted", MessageBoxButtons.YesNoCancel)

        If ans = DialogResult.Yes Then
            Try
                conn.Open()
                sql = "DELETE from Suppliers WHERE supplier_id = " & Supplierid

                dbcomm = New MySqlCommand(sql, conn)
                Dim i As Integer = dbcomm.ExecuteNonQuery
                If (i > 0) Then
                    MsgBox("Supplier's Data has been deleted")
                Else
                    MsgBox("Failed to delete Supplier's Data")
                End If
            Catch ex As MySqlException
                MsgBox("Error in collecting data from Database. Error is :" & ex.Message)
            End Try
        End If
        sql1 = "ALTER TABLE suppliers Auto_Increment = 0"
        dbcomm = New MySqlCommand(sql1, conn)
        dbcomm.ExecuteNonQuery()
        conn.Close()
    End Sub

    Private Sub cmdsupply_Click(sender As Object, e As EventArgs) Handles cmdsupply.Click
        Dim ans = MessageBox.Show("Do you want to supply a parts/accessorie?",
                                  "Supply a parts/accessorie", MessageBoxButtons.YesNoCancel)

        If ans = DialogResult.Yes Then
            If txtsupid.Text = Nothing Then
                MsgBox("Please Identify yourself first", MessageBoxIcon.Information)
            Else
                PartsSupplier.Show()
            End If
        End If
    End Sub
End Class