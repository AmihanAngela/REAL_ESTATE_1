Imports MySqlConnector

Public Class The_Property
    Dim func As New MYFUNCTION()

    ' Get all properties

    ' Get properties by id
    Function getPropertyById(ByVal id As Integer) As DataTable
        Dim command As New MySqlCommand("SELECT * FROM `the_property` WHERE `id`=@id")
        command.Parameters.AddWithValue("@id", id)
        Return func.getData(command)

    End Function


    'get properties by owner id


    ' Add a new property
    Function addProperty(ByVal type As Integer,
                         ByVal owner As Integer,
                         ByVal size As Integer,
                         ByVal price As String,
                         ByVal address As String,
                         ByVal beds As Integer,
                         ByVal baths As Integer,
                         ByVal age As Integer,
                         ByVal balcony As Boolean,
                         ByVal backyard As Boolean,
                         ByVal garage As Boolean,
                         ByVal pool As Boolean,
                         ByVal fireplace As Boolean,
                         ByVal elevator As Boolean,
                         ByVal comment As String) As Boolean

        Dim command As New MySqlCommand("INSERT INTO `the_property`(`type`, `owner`, `size`, `price`, `address`, `beds`, `baths`, `age`, `balcony`, `backyard`, `garage`, `pool`, `fireplace`, `elevator`, `comment`) VALUES (@tp,@ownerId,@sz,@prc,@adrs,@bds,@bths,@age,@blcn,@bkyd,@grg,@pool,@frplc,@elv,@cmnt)")

        command.Parameters.AddWithValue("@tp", type)
        command.Parameters.AddWithValue("@ownerId", owner)
        command.Parameters.AddWithValue("@sz", size)
        command.Parameters.AddWithValue("@prc", price)
        command.Parameters.AddWithValue("@adrs", address)
        command.Parameters.AddWithValue("@bds", beds)
        command.Parameters.AddWithValue("@bths", baths)
        command.Parameters.AddWithValue("@age", age)
        command.Parameters.AddWithValue("@blcn", balcony)
        command.Parameters.AddWithValue("@bkyd", backyard)
        command.Parameters.AddWithValue("@grg", garage)
        command.Parameters.AddWithValue("@pool", pool)
        command.Parameters.AddWithValue("@frplc", fireplace)
        command.Parameters.AddWithValue("@elv", elevator)
        command.Parameters.AddWithValue("@cmnt", comment)

        Return func.exeQuery(command)
    End Function

    ' Edit the selected property
    Function editProperty(ByVal propertyId As Integer,
                          ByVal type As Integer,
                          ByVal owner As Integer,
                          ByVal size As Integer,
                          ByVal price As String,
                          ByVal address As String,
                          ByVal beds As Integer,
                          ByVal baths As Integer,
                          ByVal age As Integer,
                          ByVal balcony As Boolean,
                          ByVal backyard As Boolean,
                          ByVal garage As Boolean,
                          ByVal pool As Boolean,
                          ByVal fireplace As Boolean,
                          ByVal elevator As Boolean,
                          ByVal comment As String) As Boolean

        Dim command As New MySqlCommand("UPDATE `the_property` SET `type`=@tp, `owner`=@ownerId, `size`=@sz, `price`=@prc, `address`=@adrs, `beds`=@bds, `baths`=@bths, `age`=@age, `balcony`=@blcn, `backyard`=@bkyd, `garage`=@grg, `pool`=@pool, `fireplace`=@frplc, `elevator`=@elv, `comment`=@cmnt WHERE `id`=@id")

        command.Parameters.AddWithValue("@tp", type)
        command.Parameters.AddWithValue("@ownerId", owner)
        command.Parameters.AddWithValue("@sz", size)
        command.Parameters.AddWithValue("@prc", price)
        command.Parameters.AddWithValue("@adrs", address)
        command.Parameters.AddWithValue("@bds", beds)
        command.Parameters.AddWithValue("@bths", baths)
        command.Parameters.AddWithValue("@age", age)
        command.Parameters.AddWithValue("@blcn", balcony)
        command.Parameters.AddWithValue("@bkyd", backyard)
        command.Parameters.AddWithValue("@grg", garage)
        command.Parameters.AddWithValue("@pool", pool)
        command.Parameters.AddWithValue("@frplc", fireplace)
        command.Parameters.AddWithValue("@elv", elevator)
        command.Parameters.AddWithValue("@cmnt", comment)
        command.Parameters.AddWithValue("@id", propertyId)  ' Ensure property ID is added

        Return func.exeQuery(command)
    End Function

    ' Remove the selected property
    Function removeProperty(ByVal propertyId As Integer) As Boolean
        Dim command As New MySqlCommand("DELETE FROM `the_property` WHERE `id`=@id")
        command.Parameters.AddWithValue("@id", propertyId)
        Return func.exeQuery(command)
    End Function

    ' Additional methods can be added here (e.g., get property by owner id, etc.)
End Class
