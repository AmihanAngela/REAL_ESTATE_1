Public Class PropertiesList_Form
    Dim func As New MYFUNCTION()
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub PropertiesList_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'change data grid row height
        DataGridViewPROPERTIES.RowTemplate.Height = 30

        'display properties data in the datagridview
        Dim query As String = "SELECT * FROM `the_property`"
        DataGridViewPROPERTIES.DataSource = func.getData(query)

        'change data grid row height
        DataGridViewPROPERTIES.RowTemplate.Height = 50
    End Sub
End Class