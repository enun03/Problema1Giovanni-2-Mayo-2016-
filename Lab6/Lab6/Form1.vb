Public Class Form1
    Dim hits = 0
   
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Public Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        hits += 1

        If hits = 1 Then
            If cbMes.SelectedItem = 1 Or cbMes.SelectedItem = 2 Or cbMes.SelectedItem = 3 Or
            cbMes.SelectedItem = 4 Or cbMes.SelectedItem = 5 Or cbMes.SelectedItem = 6 Then
                TextBox2.Text = txtNombre.Text
                TextBox5.Text = cbMes.SelectedItem
                TextBox8.Text = cbDia.SelectedItem
                TextBox11.Text = cbAno.SelectedItem
            ElseIf cbMes.SelectedItem = 7 Or cbMes.SelectedItem = 8 Or cbMes.SelectedItem = 9 Or
            cbMes.SelectedItem = 10 Or cbMes.SelectedItem = 11 Or cbMes.SelectedItem = 12 Then
                TextBox14.Text = txtNombre.Text
                TextBox17.Text = cbMes.SelectedItem
                TextBox18.Text = cbDia.SelectedItem
                TextBox19.Text = cbAno.SelectedItem
            End If
        End If

        If hits = 2 Then
            If cbMes.SelectedItem = 1 Or cbMes.SelectedItem = 2 Or cbMes.SelectedItem = 3 Or
            cbMes.SelectedItem = 4 Or cbMes.SelectedItem = 5 Or cbMes.SelectedItem = 6 Then
                TextBox3.Text = txtNombre.Text
                TextBox6.Text = cbMes.SelectedItem
                TextBox9.Text = cbDia.SelectedItem
                TextBox12.Text = cbAno.SelectedItem
            ElseIf cbMes.SelectedItem = 7 Or cbMes.SelectedItem = 8 Or cbMes.SelectedItem = 9 Or
            cbMes.SelectedItem = 10 Or cbMes.SelectedItem = 11 Or cbMes.SelectedItem = 12 Then
                TextBox15.Text = txtNombre.Text
                TextBox20.Text = cbMes.SelectedItem
                TextBox21.Text = cbDia.SelectedItem
                TextBox22.Text = cbAno.SelectedItem
            End If
        End If

        If hits = 3 Then
            If cbMes.SelectedItem = 1 Or cbMes.SelectedItem = 2 Or cbMes.SelectedItem = 3 Or
            cbMes.SelectedItem = 4 Or cbMes.SelectedItem = 5 Or cbMes.SelectedItem = 6 Then
                TextBox4.Text = txtNombre.Text
                TextBox7.Text = cbMes.SelectedItem
                TextBox10.Text = cbDia.SelectedItem
                TextBox13.Text = cbAno.SelectedItem
            ElseIf cbMes.SelectedItem = 7 Or cbMes.SelectedItem = 8 Or cbMes.SelectedItem = 9 Or
        cbMes.SelectedItem = 10 Or cbMes.SelectedItem = 11 Or cbMes.SelectedItem = 12 Then
                TextBox16.Text = txtNombre.Text
                TextBox23.Text = cbMes.SelectedItem
                TextBox24.Text = cbDia.SelectedItem
                TextBox25.Text = cbAno.SelectedItem
            End If
        End If
        txtNombre.Text = ""
        cbAno.SelectedItem = ""
        cbDia.SelectedItem = ""
        cbMes.SelectedItem = ""
    End Sub

End Class
