Public Class DialogEdit
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        EditFinished = 1
        Dialog.Timer1.Enabled = True


        IpNewEdit(0) = TextBox1.Text
        IpNewEdit(1) = TextBox3.Text
        IpNewEdit(2) = TextBox4.Text
        IpNewEdit(3) = TextBox5.Text


        SubnetNewEdit(0) = TextBox2.Text
        SubnetNewEdit(1) = TextBox6.Text
        SubnetNewEdit(2) = TextBox7.Text
        SubnetNewEdit(3) = TextBox8.Text

        Me.Close()

    End Sub

    Private Sub DialogEdit_Load(sender As Object, e As EventArgs) Handles MyBase.GotFocus




    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick


        If DoActualize Then
            DoActualize = False

            TextBox1.Text = IpToEdit(0)
            TextBox3.Text = IpToEdit(1)
            TextBox4.Text = IpToEdit(2)
            TextBox5.Text = IpToEdit(3)

            TextBox2.Text = SubnetToEdit(0)
            TextBox6.Text = SubnetToEdit(1)
            TextBox7.Text = SubnetToEdit(2)
            TextBox8.Text = SubnetToEdit(3)
            Timer1.Enabled = False
        End If
    End Sub
End Class