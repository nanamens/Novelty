Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With Me.DataGridView1.Rows
            .Add({"basic", "$5.95", "$5.95", "$5.95", $"5.95", "$7.95", "$7.95"})
        End With
    End Sub

    Private womanBasic As Decimal = 5.95
    Private womenStandard As Decimal = 7.75
    Private womenPremium As Decimal = 10.5

    p

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub maleRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles maleRadioButton.CheckedChanged

    End Sub

    Private Sub calculate()

    End Sub



    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class
