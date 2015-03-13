Imports System.Data.SqlClient

Module Module1
    Public sqlconn, sqldb, sqluser, sqlpass As String
    Public connetionString As String
    Public cnn As SqlConnection
    Public cmd As SqlCommand
    Public sql As String
    Public reader, reader1 As SqlDataReader
    Public da, adapter As New SqlDataAdapter
    Public command As SqlCommand
    Public ds As New DataSet
    Public dv As DataView
    Public i, j As Integer
    Public updrec As Integer
    Public recid, clientvar, paymentid11 As Integer
    Public clid, payid, typeid As Long
    Public uprofile, sessionuser, usertype As String
    Public vartype, strimg, complaintview, firview, crminalview, chargesheetview As String
    Public Sub dbconf()
        sqlconn = "ARAVINDA-PC"
        sqldb = "policeinfosystem"
        sqluser = "sa"
        sqlpass = "technology"
    End Sub
    Public Sub connectiondb()
        dbconf()
        connetionString = "Data Source=" & sqlconn & ";Initial Catalog=" & sqldb & ";User ID=" & sqluser & ";Password=" & sqlpass & ""
        cnn = New SqlConnection(connetionString)
        Try
            cnn.Open()
        Catch ex As Exception
            MsgBox("Can not open connection ! ")
        End Try
    End Sub
    Public Sub connection_close()
        'reader.Close()
        ' cmd.Dispose()
        cnn = Nothing
        cmd = Nothing
    End Sub
End Module

