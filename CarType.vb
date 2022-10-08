Imports MySql.Data.MySqlClient
Public Class CarType
    Private Sub ctreset_Click(sender As Object, e As EventArgs) Handles ctreset.Click
        txtctid.Clear()
        txtcttype.Clear()
    End Sub

    Private Sub Types_Load(sender As Object, e As EventArgs) Handles MyBase.Load, txtctid.TextChanged
        Dim cartype_id As Integer
        cartype_id = Val(txtctid.Text)

        Try
            conn.Open()
            sql = "SELECT * FROM type WHERE class_id = " & cartype_id
            dbcomm = New MySqlCommand(sql, conn)

            dbread = dbcomm.ExecuteReader()
            While dbread.Read
                txtcttype.Text = dbread("cartype")
            End While
        Catch ex As MySqlException
            MsgBox("Error in collecting data from Database. Error is :" & ex.Message)
        End Try

        dbread.Close()
        conn.Close()
    End Sub

    Private Sub ctcreate_Click(sender As Object, e As EventArgs) Handles ctcreate.Click
        Dim type = txtcttype.Text

        Dim ans = MessageBox.Show("Do you want to register this Car Type?", "Save Car Type Data",
                  MessageBoxButtons.YesNoCancel)

        If ans = DialogResult.Yes Then
            Try
                conn.Open()
                sql = "INSERT INTO type (cartype) VALUES ( '" & type & "' )"

                dbcomm = New MySqlCommand(sql, conn)
                Dim i As Integer = dbcomm.ExecuteNonQuery
                If (i > 0) Then
                    MsgBox("Car Type's data has been saved")
                Else
                    MsgBox("Failed to save Car Type's Data")
                End If
            Catch ex As MySqlException
                MsgBox("Error in collecting data from Database. Error is :" & ex.Message)
            End Try
        End If
        conn.Close()
    End Sub

    Private Sub ctread_Click(sender As Object, e As EventArgs) Handles ctread.Click
        Try
            conn.Open()
            sql = "SELECT * FROM type"
            DataAdapter1 = New MySqlDataAdapter(sql, conn)
            dset = New DataSet()
            DataAdapter1.Fill(dset, "type")
            cartypeViewer.DataSource = dset
            cartypeViewer.DataMember = "type"
        Catch ex As MySqlException
            MsgBox("Error in collecting data from Database. Error is :" & ex.Message)

        Catch exception As Exception
            MsgBox("Error in code. Error is :" & exception.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub ctupdate_Click(sender As Object, e As EventArgs) Handles ctupdate.Click
        Dim cartypeid As Integer = Val(txtctid.Text)
        Dim type = txtcttype.Text

        Dim ans = MessageBox.Show("Do you want to update this Car Type record?",
                                  "Update Car Type Data", MessageBoxButtons.YesNoCancel)

        If ans = DialogResult.Yes Then
            Try
                conn.Open()
                sql = "UPDATE type SET cartype = '" & type & "' WHERE class_id = '" & cartypeid & "'"

                dbcomm = New MySqlCommand(sql, conn)
                Dim i As Integer = dbcomm.ExecuteNonQuery

                If (i > 0) Then
                    MsgBox("Car Type's Data has been updated")
                Else
                    MsgBox("Failed to update Car Type's Data")
                End If

            Catch ex As MySqlException
                MsgBox("Error in collecting data from Database. Error is :" & ex.Message)
            End Try
        End If
        conn.Close()
    End Sub

    Private Sub ctdelete_Click(sender As Object, e As EventArgs) Handles ctdelete.Click
        Dim cartypeid As Integer = Val(InputBox("Enter Car Type's ID that you want to delete",
                                                "Delete Car Type Data"))

        Dim ans = MessageBox.Show("Do you want to delete this Car Type Data?",
                                  "Car Type's Data has been deleted", MessageBoxButtons.YesNoCancel)

        If ans = DialogResult.Yes Then
            Try
                conn.Open()
                sql = "DELETE from type WHERE class_id = " & cartypeid

                dbcomm = New MySqlCommand(sql, conn)
                Dim i As Integer = dbcomm.ExecuteNonQuery
                If (i > 0) Then
                    MsgBox("Car Type's Data has been deleted")
                Else
                    MsgBox("Failed to delete Car Type's Data")
                End If
            Catch ex As MySqlException
                MsgBox("Error in collecting data from Database. Error is :" & ex.Message)
            End Try
        End If

        sql1 = "ALTER TABLE type Auto_Increment = 0"
        dbcomm = New MySqlCommand(sql1, conn)
        dbcomm.ExecuteNonQuery()

        conn.Close()
    End Sub


End Class