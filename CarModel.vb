Imports MySql.Data.MySqlClient
Public Class CarModel
    Private Sub modreset_Click(sender As Object, e As EventArgs) Handles modreset.Click
        txtmodid.Clear()
        txtmodtype.Clear()
    End Sub

    Private Sub model_Load(sender As Object, e As EventArgs) Handles MyBase.Load, txtmodid.TextChanged
        Dim model_id As Integer
        model_id = Val(txtmodid.Text)
        cbomanufacturer.Items.Clear()

        Try
            conn.Open()

            sql1 = "SELECT manufacturer.manufacturername FROM manufacturer"

            dbcomm1 = New MySqlCommand(sql1, conn)
            dbread1 = dbcomm1.ExecuteReader

            While dbread1.Read
                cbomanufacturer.Items.Add(dbread1("manufacturername"))
            End While
            dbread1.Close()

            sql = "SELECT models.Model_id, manufacturer.ManufacturerName, models.ModelType
                   FROM models, manufacturer WHERE manufacturer.manufacturer_id = models.manufacturer_id
                   AND models.model_id= " & model_id & ""

            dbcomm = New MySqlCommand(sql, conn)
            dbread = dbcomm.ExecuteReader()
            While dbread.Read
                txtmodtype.Text = dbread("ModelType")
                cbomanufacturer.Text = dbread("ManufacturerName")
            End While
        Catch ex As MySqlException
            MsgBox("Error in collecting data from Database. Error is :" & ex.Message)
        End Try

        dbread.Close()
        conn.Close()
    End Sub

    Private Sub modcreate_Click(sender As Object, e As EventArgs) Handles modcreate.Click
        Dim type = txtmodtype.Text

        Dim ans = MessageBox.Show("Do you want to register this type of Car Model?", "Save Car Model Data",
                  MessageBoxButtons.YesNoCancel)

        If ans = DialogResult.Yes Then
            Try
                conn.Open()

                q1 = "SELECT manufacturer.manufacturer_id FROM manufacturer
                WHERE manufacturername = '" & cbomanufacturer.Text & "'"
                dbcomm = New MySqlCommand(q1, conn)
                dbread1 = dbcomm.ExecuteReader()
                dbread1.Read()
                manufacturerid = dbread1("manufacturer_id")
                dbread1.Close()

                sql = "INSERT INTO models (modeltype,manufacturer_id) VALUES ( '" & type & "',
                '" & manufacturerid & "')"

                dbcomm = New MySqlCommand(sql, conn)
                Dim i As Integer = dbcomm.ExecuteNonQuery
                If (i > 0) Then
                    MsgBox("Car Model's data has been saved")
                Else
                    MsgBox("Failed to save Car Model's Data")
                End If
            Catch ex As MySqlException
                MsgBox("Error in collecting data from Database. Error is :" & ex.Message)
            End Try
        End If
        conn.Close()
    End Sub

    Private Sub modread_Click(sender As Object, e As EventArgs) Handles modread.Click
        Try
            conn.Open()
            sql = "SELECT models.Model_id, manufacturer.ManufacturerName, models.ModelType
                   FROM models, manufacturer WHERE manufacturer.manufacturer_id = models.manufacturer_id
                   ORDER BY models.model_id ASC"
            DataAdapter1 = New MySqlDataAdapter(sql, conn)
            dset = New DataSet()
            DataAdapter1.Fill(dset, "models,manufacturer")
            ModelView.DataSource = dset
            ModelView.DataMember = "models,manufacturer"
        Catch ex As MySqlException
            MsgBox("Error in collecting data from Database. Error is :" & ex.Message)

        Catch exception As Exception
            MsgBox("Error in code. Error is :" & exception.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub modupdate_Click(sender As Object, e As EventArgs) Handles modupdate.Click
        Dim modelsid As Integer = Val(txtmodid.Text)
        Dim type = txtmodtype.Text
        Dim mfid = cbomanufacturer.Text

        Dim ans = MessageBox.Show("Do you want to update this type of Car Model record?",
                                  "Update Car Model Data", MessageBoxButtons.YesNoCancel)

        If ans = DialogResult.Yes Then
            Try
                conn.Open()
                sql = "UPDATE models SET modeltype = '" & type & "', manufacturer_id = " & mfid & "
                WHERE model_id = '" & modelsid & "'"

                dbcomm = New MySqlCommand(sql, conn)
                Dim i As Integer = dbcomm.ExecuteNonQuery

                If (i > 0) Then
                    MsgBox("Car Model's Data has been updated")
                Else
                    MsgBox("Failed to update Car Model's Data")
                End If

            Catch ex As MySqlException
                MsgBox("Error in collecting data from Database. Error is :" & ex.Message)
            End Try
        End If
        conn.Close()
    End Sub

    Private Sub moddelete_Click(sender As Object, e As EventArgs) Handles moddelete.Click
        Dim modelsid As Integer = Val(InputBox("Enter Car Model's ID that you want to delete",
                                                    "Delete Car Model Data"))

        Dim ans = MessageBox.Show("Do you want to delete this type of Car Model Data?",
                                  "Accessorie's Data has been deleted", MessageBoxButtons.YesNoCancel)

        If ans = DialogResult.Yes Then
            Try
                conn.Open()
                sql = "DELETE from models WHERE model_id = " & modelsid

                dbcomm = New MySqlCommand(sql, conn)
                Dim i As Integer = dbcomm.ExecuteNonQuery
                If (i > 0) Then
                    MsgBox("Car Model's Data has been deleted")
                Else
                    MsgBox("Failed to delete Car Model's Data")
                End If
            Catch ex As MySqlException
                MsgBox("Error in collecting data from Database. Error is :" & ex.Message)
            End Try
        End If

        sql1 = "ALTER TABLE models Auto_Increment = 0"
        dbcomm = New MySqlCommand(sql1, conn)
        dbcomm.ExecuteNonQuery()

        conn.Close()
    End Sub


End Class