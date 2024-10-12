Imports MySqlConnector

Public Class The_Type
    Dim func As New MYFUNCTION()
    Dim db As New Database()

    ' Create a function to get all the data
    Function getAllTypes() As DataTable
        Dim query As String = "SELECT * FROM `prop_type`"
        Return func.getData(query)
    End Function

    ' Create a function to add a new type
    Function addType(ByVal name As String, ByVal description As String) As Boolean
        Dim query As String = "INSERT INTO `prop_type` (name, description) VALUES (@nm, @dscrp)"

        Using conn As MySqlConnection = db.getConnection()
            db.openConnection(conn)
            Using command As New MySqlCommand(query, conn)
                command.Parameters.AddWithValue("@nm", name)
                command.Parameters.AddWithValue("@dscrp", description)
                Return command.ExecuteNonQuery() > 0
            End Using
        End Using
    End Function

    ' Create a function to edit the selected type
    Function editType(ByVal id As Integer, ByVal name As String, ByVal description As String) As Boolean
        Dim query As String = "UPDATE `prop_type` SET name = @nm, description = @dscrp WHERE id = @id"

        Using conn As MySqlConnection = db.getConnection()
            db.openConnection(conn)
            Using command As New MySqlCommand(query, conn)
                command.Parameters.AddWithValue("@nm", name)
                command.Parameters.AddWithValue("@dscrp", description)
                command.Parameters.AddWithValue("@id", id)
                Return command.ExecuteNonQuery() > 0
            End Using
        End Using
    End Function

    ' Create a function to delete the selected type
    Function deleteType(ByVal id As Integer) As Boolean
        Dim query As String = "DELETE FROM `prop_type` WHERE id = @id"

        Using conn As MySqlConnection = db.getConnection()
            db.openConnection(conn)
            Using command As New MySqlCommand(query, conn)
                command.Parameters.AddWithValue("@id", id)
                Return command.ExecuteNonQuery() > 0 ' Return true if a row was deleted
            End Using
        End Using
    End Function
End Class
