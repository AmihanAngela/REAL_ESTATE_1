Imports MySqlConnector


Public Class Database

    ' Connection string should ideally be stored in a config file
    Private Const connectionString As String = "datasource=localhost;port=3306;username=root;password=;database=vbnet_real_estate_db"

    ' Create a function to return a new MySqlConnection
    Public Function getConnection() As MySqlConnection
        Return New MySqlConnection(connectionString)
    End Function

    ' Sub to open the connection
    Public Sub openConnection(ByRef connection As MySqlConnection)
        Try
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If
        Catch ex As Exception
            MessageBox.Show("Could not open connection: " & ex.Message)
        End Try
    End Sub

    ' Sub to close connection
    Public Sub closesConnection(ByRef connection As MySqlConnection)
        Try
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("Could not close connection: " & ex.Message)
        End Try
    End Sub

End Class