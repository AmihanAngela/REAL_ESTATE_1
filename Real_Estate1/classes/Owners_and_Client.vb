Imports MySqlConnector

Public Class Owners_and_Client
    Dim db As New Database()

    ' Create a function to insert a new owner/client
    Function insertPerson(ByVal personType As String, ByVal fname As String, ByVal lname As String, ByVal phone As String, ByVal email As String, ByVal address As String) As Boolean
        Dim query As String = $"INSERT INTO `{personType}` (first_name, last_name, phone, email, address) VALUES (@fn, @ln, @phn, @mail, @adrs)"

        Using conn As MySqlConnection = db.getConnection()
            db.openConnection(conn)
            Using command As New MySqlCommand(query, conn)
                command.Parameters.AddWithValue("@fn", fname)
                command.Parameters.AddWithValue("@ln", lname)
                command.Parameters.AddWithValue("@phn", phone)
                command.Parameters.AddWithValue("@mail", email)
                command.Parameters.AddWithValue("@adrs", address)
                Return command.ExecuteNonQuery() > 0
            End Using
        End Using
    End Function

    ' Create a function to edit a person
    Function editPerson(ByVal personType As String, ByVal personId As Integer, ByVal fname As String, ByVal lname As String, ByVal phone As String, ByVal email As String, ByVal address As String) As Boolean
        Dim query As String = $"UPDATE `{personType}` SET first_name=@fn, last_name=@ln, phone=@phn, email=@mail, address=@adrs WHERE id=@id"

        Using conn As MySqlConnection = db.getConnection()
            db.openConnection(conn)
            Using command As New MySqlCommand(query, conn)
                command.Parameters.AddWithValue("@fn", fname)
                command.Parameters.AddWithValue("@ln", lname)
                command.Parameters.AddWithValue("@phn", phone)
                command.Parameters.AddWithValue("@mail", email)
                command.Parameters.AddWithValue("@adrs", address)
                command.Parameters.AddWithValue("@id", personId)
                Return command.ExecuteNonQuery() > 0
            End Using
        End Using
    End Function

    ' Create function to delete the selected owner/client
    Function deletePerson(ByVal personType As String, ByVal personId As Integer) As Boolean
        Dim query As String = $"DELETE FROM `{personType}` WHERE id=@id"

        Using conn As MySqlConnection = db.getConnection()
            db.openConnection(conn)
            Using command As New MySqlCommand(query, conn)
                command.Parameters.AddWithValue("@id", personId)
                Return command.ExecuteNonQuery() > 0 ' Return true if a row was deleted
            End Using
        End Using
    End Function
End Class
