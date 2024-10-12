Imports MySqlConnector




Public Class MYFUNCTION
    Dim db As New Database()

    ' Create function to return table data
    Function getData(ByVal query As String) As DataTable
        Dim table As New DataTable()
        Using connection As MySqlConnection = db.GetConnection()
            Using command As New MySqlCommand(query, connection)
                Using adapter As New MySqlDataAdapter(command)
                    db.OpenConnection(connection)
                    adapter.Fill(table)
                End Using
            End Using
            db.closesConnection(connection)
        End Using
        Return table
    End Function

    ' Create function to execute queries
    Function exeQuery(ByVal command As MySqlCommand) As Boolean
        Using connection As MySqlConnection = db.GetConnection()
            command.Connection = connection
            db.OpenConnection(connection)
            Try
                Return command.ExecuteNonQuery() = 1
            Finally
                db.closesConnection(connection)
            End Try
        End Using
    End Function

    ' Add other functions as needed...
    Function getData(ByVal command As MySqlCommand) As DataTable
        Dim table As New DataTable()
        Using connection As MySqlConnection = db.getConnection()
            command.Connection = connection  ' Set the connection for the command
            Using adapter As New MySqlDataAdapter(command)
                db.openConnection(connection)
                adapter.Fill(table)
            End Using
            db.closesConnection(connection)
        End Using
        Return table
    End Function


End Class