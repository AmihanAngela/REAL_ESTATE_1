Public Class OwnersList_Form
    Dim func As New MYFUNCTION()
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub OwnersList_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'populate the datagridview
        Dim query As String = "SELECT `id`, `first_name`, `last_name` FROM `prop_owner` "
        DataGridViewOWNERS.DataSource = func.getData(query)


    End Sub

    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridViewOWNERS.DoubleClick
        ' Close the form when the user double-clicks on the DataGridView
        Me.Close()
    End Sub
End Class