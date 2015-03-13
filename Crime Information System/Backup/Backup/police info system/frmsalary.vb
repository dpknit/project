Public Class frmsalary

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        noofdays()
    End Sub

    Private Sub frmsalary_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Public Sub noofdays()
        Dim monthint As Integer
        If ComboBox1.Text = "JAN" Then
            monthint = 1
        ElseIf ComboBox1.Text = "FEB" Then
            monthint = 2
        ElseIf ComboBox1.Text = "MAR" Then
            monthint = 3
        ElseIf ComboBox1.Text = "APR" Then
            monthint = 4
        ElseIf ComboBox1.Text = "MAY" Then
            monthint = 5
        ElseIf ComboBox1.Text = "JUN" Then
            monthint = 6
        ElseIf ComboBox1.Text = "JUL" Then
            monthint = 7
        ElseIf ComboBox1.Text = "AUG" Then
            monthint = 8
        ElseIf ComboBox1.Text = "SEPT" Then
            monthint = 9
        ElseIf ComboBox1.Text = "OCT" Then
            monthint = 10
        ElseIf ComboBox1.Text = "NOV" Then
            monthint = 11
        ElseIf ComboBox1.Text = "DEC" Then
            monthint = 12
        Else
            MessageBox.Show("Error")
        End If
        'Total number of days
        Dim noofdays As Integer = System.DateTime.DaysInMonth(2012, monthint)
        txtnodays.Text = noofdays

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox12.SelectedIndexChanged
        noofdays()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        frmsalarygenerator.Show()
    End Sub

    Private Sub txtleaves_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtleaves.TextChanged
        txttotdays.Text = Val(txtnodays.Text) - Val(txtleaves.Text)
    End Sub
End Class