Imports MySql.Data.MySqlClient
Module Connections

    Public sql, sql1, sql2 As String
    Public dset As DataSet
    Public dtable As New DataTable
    Public dbcomm, dbcomm1, dbcomm2 As MySqlCommand
    Public dbread, dbread1, dbread2, dbread3 As MySqlDataReader
    Public DataAdapter1 As New MySqlDataAdapter
    Public conn As MySqlConnection = New MySqlConnection("Data Source=localhost;Database=db_Cars;User=root;Password=;")
    Public q1, q2, q3 As String
    Public custid, typeid, modid As Integer
    Public customerid, vehicleid, serviceid, partid, mechanicid, manufacturerid, supplierid As Integer
    Public qty As Integer

End Module

