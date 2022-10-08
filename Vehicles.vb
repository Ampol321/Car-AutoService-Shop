Imports MySql.Data.MySqlClient
Public Class Vehicles
    Private Sub vreset_Click(sender As Object, e As EventArgs) Handles vreset.Click
        txtcname.Clear()
        txtmfname.Clear()
        txtvmile.Clear()
        txtvprob.Clear()
        txtvid.Clear()
    End Sub

    Private Sub Vehicles_Load(sender As Object, e As EventArgs) Handles MyBase.Load, txtvid.TextChanged
        txtmfname.Enabled = False
        Dim vehicle_id As Integer
        vehicle_id = Val(txtvid.Text)
        vehicleid = Val(txtvid.Text)
        cbomodels.Items.Clear()
        cboctype.Items.Clear()

        Try
            conn.Open()

            sql1 = "SELECT models.modeltype FROM models"

            dbcomm1 = New MySqlCommand(sql1, conn)
            dbread1 = dbcomm1.ExecuteReader

            While dbread1.Read
                cbomodels.Items.Add(dbread1("modeltype"))
            End While
            dbread1.Close()

            sql2 = "SELECT type.CarType FROM type"

            dbcomm2 = New MySqlCommand(sql2, conn)
            dbread2 = dbcomm2.ExecuteReader

            While dbread2.Read
                cboctype.Items.Add(dbread2("CarType"))
            End While
            dbread2.Close()

            sql = "SELECT vehicle.Vehicle_id, customer.Name, type.CarType, models.ModelType, manufacturer.ManufacturerName, vehicle.Mileage,Maintenance
                   FROM vehicle, customer, type, models, manufacturer WHERE customer.customer_id = vehicle.customer_id
                   AND type.class_id = vehicle.class_id AND manufacturer.manufacturer_id = models.manufacturer_id
                   AND models.model_id = vehicle.model_id AND vehicle.vehicle_id = " & vehicle_id & ""
            dbcomm = New MySqlCommand(sql, conn)

            dbread = dbcomm.ExecuteReader()
            While dbread.Read
                txtcname.Text = dbread("name")
                cboctype.Text = dbread("CarType")
                cbomodels.Text = dbread("ModelType")
                txtmfname.Text = dbread("ManufacturerName")
                txtvmile.Text = dbread("mileage")
                txtvprob.Text = dbread("maintenance")
            End While

        Catch ex As MySqlException
            MsgBox("Error in collecting data from Database. Error is :" & ex.Message)
        End Try

        dbread.Close()
        conn.Close()
    End Sub

    Private Sub vcreate_Click(sender As Object, e As EventArgs) Handles vcreate.Click
        Dim mileage = txtvmile.Text
        Dim problem = txtvprob.Text
        Dim ans = MessageBox.Show("Do you want to register this Vehicle?",
                                  "Vehicle Registration", MessageBoxButtons.YesNoCancel)

        If ans = DialogResult.Yes Then

            Try
                conn.Open()

                q1 = "SELECT customer.customer_id FROM customer WHERE name = '" & txtcname.Text & "' "
                dbcomm = New MySqlCommand(q1, conn)
                dbread1 = dbcomm.ExecuteReader()
                dbread1.Read()
                custid = dbread1("customer_id")
                dbread1.Close()

                q2 = "SELECT type.class_id FROM type WHERE Cartype = '" & cboctype.Text & "' "
                dbcomm = New MySqlCommand(q2, conn)
                dbread2 = dbcomm.ExecuteReader()
                dbread2.Read()
                typeid = dbread2("class_id")
                dbread2.Close()

                q3 = "SELECT models.model_id FROM models WHERE ModelType = '" & cbomodels.Text & "' "
                dbcomm = New MySqlCommand(q3, conn)
                dbread3 = dbcomm.ExecuteReader()
                dbread3.Read()
                modid = dbread3("model_id")
                dbread3.Close()

                sql = "INSERT INTO vehicle (customer_id,class_id,model_id,mileage,maintenance) " &
                       "VALUES ( '" & custid & "' , '" & typeid & "' , '" & modid & "',
                       '" & mileage & "', '" & problem & "')"

                dbcomm = New MySqlCommand(sql, conn)
                Dim i As Integer = dbcomm.ExecuteNonQuery
                If (i > 0) Then
                    MsgBox("Vehicle's data has been saved")
                Else
                    MsgBox("Failed to save Vehicle's Data")
                End If

            Catch ex As MySqlException
                MsgBox("Error in collecting data from Database. Error is :" & ex.Message)
            End Try
        End If

        conn.Close()

    End Sub

    Private Sub vread_Click(sender As Object, e As EventArgs) Handles vread.Click
        Try
            conn.Open()
            sql = "SELECT vehicle.Vehicle_id, customer.Name, type.CarType, models.ModelType, manufacturer.ManufacturerName, vehicle.Mileage,Maintenance
                   FROM vehicle, customer, type, models, manufacturer WHERE customer.customer_id = vehicle.customer_id
                   AND type.class_id = vehicle.class_id AND manufacturer.manufacturer_id = models.manufacturer_id
                   AND models.model_id = vehicle.model_id ORDER BY vehicle.vehicle_id ASC"

            DataAdapter1 = New MySqlDataAdapter(sql, conn)
            dset = New DataSet()
            DataAdapter1.Fill(dset, "vehicle,customer,type,models,manufacturer")
            VehicleView.DataSource = dset
            VehicleView.DataMember = "vehicle,customer,type,models,manufacturer"
        Catch ex As MySqlException
            MsgBox("Error in collecting data from Database. Error is :" & ex.Message)

        Catch exception As Exception
            MsgBox("Error in code. Error is :" & exception.Message)
        End Try

        conn.Close()
    End Sub

    Private Sub vupdate_Click(sender As Object, e As EventArgs) Handles vupdate.Click
        Dim mileage = txtvmile.Text
        Dim problem = txtvprob.Text
        Dim vehicleid = txtvid.Text

        Dim ans = MessageBox.Show("Do you want to update this Vehicle's record?", "Update Vehicle Data",
                  MessageBoxButtons.YesNoCancel)

        If ans = DialogResult.Yes Then
            Try
                conn.Open()

                q1 = "SELECT customer.customer_id FROM customer WHERE name = '" & txtcname.Text & "' "
                dbcomm = New MySqlCommand(q1, conn)
                dbread1 = dbcomm.ExecuteReader()
                dbread1.Read()
                custid = dbread1("customer_id")
                dbread1.Close()

                q2 = "SELECT type.class_id FROM type WHERE Cartype = '" & cboctype.Text & "' "
                dbcomm = New MySqlCommand(q2, conn)
                dbread2 = dbcomm.ExecuteReader()
                dbread2.Read()
                typeid = dbread2("class_id")
                dbread2.Close()

                q3 = "SELECT models.model_id FROM models WHERE ModelType = '" & cbomodels.Text & "' "
                dbcomm = New MySqlCommand(q3, conn)
                dbread3 = dbcomm.ExecuteReader()
                dbread3.Read()
                modid = dbread3("model_id")
                dbread3.Close()

                sql = "UPDATE vehicle SET customer_id = '" & custid & "', class_id = '" & typeid & "',
                model_id = '" & modid & "', mileage = '" & mileage & "', maintenance = '" & problem & "'
                WHERE vehicle_id = '" & vehicleid & "'"

                dbcomm = New MySqlCommand(sql, conn)
                Dim i As Integer = dbcomm.ExecuteNonQuery

                If (i > 0) Then
                    MsgBox("Vehicle's Data has been updated")
                Else
                    MsgBox("Failed to update Vehicle's Data")
                End If

            Catch ex As MySqlException
                MsgBox("Error in collecting data from Database. Error is :" & ex.Message)
            End Try
        End If
        conn.Close()
    End Sub

    Private Sub vdelete_Click(sender As Object, e As EventArgs) Handles vdelete.Click
        Dim vehicleid As Integer = Val(InputBox("Enter Vehicle's ID that you want to delete", "Delete Vehicle Data"))
        Dim ans = MessageBox.Show("Do you want to delete this Vehicle's Data?", "Vehicle Data has been deleted",
                  MessageBoxButtons.YesNoCancel)

        If ans = DialogResult.Yes Then
            Try
                conn.Open()
                sql = "DELETE from Vehicle WHERE Vehicle_id = " & vehicleid

                dbcomm = New MySqlCommand(sql, conn)
                Dim i As Integer = dbcomm.ExecuteNonQuery
                If (i > 0) Then
                    MsgBox("Vehicle's Data has been deleted")
                Else
                    MsgBox("Failed to delete Vehicle's Data")
                End If
            Catch ex As MySqlException
                MsgBox("Error in collecting data from Database. Error is :" & ex.Message)
            End Try
        End If

        sql1 = "ALTER TABLE vehicle Auto_Increment = 0"
        dbcomm = New MySqlCommand(sql1, conn)
        dbcomm.ExecuteNonQuery()

        conn.Close()
    End Sub

End Class