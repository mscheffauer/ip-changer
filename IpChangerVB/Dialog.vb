Module Module2

    Public LastSubnet As String
    Public LastIPAdress As String
    Public IpNewEdit(4) As String
    Public SubnetNewEdit(4) As String
    Public EditFinished As Boolean

    Public SelectedItemInd As Integer
    Public IpToEdit(4) As String
    Public SubnetToEdit(4) As String
    Public DoActualize As Boolean
End Module

Public Class Dialog


    Dim filepathress As String = "C:\ProgramData\IpChanger\IpAdresses.txt"



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        If Not (ListBox1.SelectedIndex = -1) Then

            SetIpAdress = Split(ListBox1.SelectedItem.ToString, ".", 4)
            SetSubnet = Split(ListBox2.SelectedItem.ToString, ".", 4)

            setcmdIp = True
            Form1.Timer1.Enabled = 1
            Me.Close()
        End If



    End Sub

    Private Sub FormMyb2227_KeyDown(sender As Object, e As KeyEventArgs) Handles ListBox1.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
    Private Sub FormMyb2228_KeyDown(sender As Object, e As KeyEventArgs) Handles Button1.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
    Private Sub FormMyb2229_KeyDown(sender As Object, e As KeyEventArgs) Handles Button2.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
    Private Sub FormMyb2230_KeyDown(sender As Object, e As KeyEventArgs) Handles Button2.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
    Private Sub Dialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Dim Arr(3) As String
        Dim file As System.IO.StreamReader
        Dim TempString As String


        If filepathress.Length < 260 Then

            If My.Computer.FileSystem.FileExists(filepathress) Then

                file = My.Computer.FileSystem.OpenTextFileReader(filepathress)

                For i = 0 To 5
                    TempString = file.ReadLine()

                    Arr = Split(TempString, ",")
                    SavedIpAdresses(i) = Arr(0)
                    SavedSubnets(i) = Arr(1)




                    ListBox1.Items.Add(SavedIpAdresses(i))
                    ListBox2.Items.Add(SavedSubnets(i))
                Next

                file.Close()
            Else
                For i = 0 To 5
                    SavedIpAdresses(i) = "0.0.0.0"
                    SavedSubnets(i) = "0.0.0.0"

                    ListBox1.Items.Add(SavedIpAdresses(i))
                    ListBox2.Items.Add(SavedSubnets(i))
                Next
            End If

        End If

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.DoubleClick

        If Not (ListBox1.SelectedIndex = -1) Then

            SetIpAdress = Split(ListBox1.SelectedItem.ToString, ".", 4)
            SetSubnet = Split(ListBox2.SelectedItem.ToString, ".", 4)

            setcmdIp = True
            Form1.Timer1.Enabled = True
            Me.Close()
        End If

    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.DoubleClick

        If Not (ListBox2.SelectedIndex = -1) Then

            SetIpAdress = Split(ListBox1.SelectedItem.ToString, ".", 4)
            SetSubnet = Split(ListBox2.SelectedItem.ToString, ".", 4)

            setcmdIp = True
            Form1.Timer1.Enabled = True
            Me.Close()
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click


        Dim file As System.IO.StreamWriter

        If filepathress.Length < 260 Then
            If My.Computer.FileSystem.FileExists(filepathress) Then
                My.Computer.FileSystem.DeleteFile(filepathress)

            End If

            file = My.Computer.FileSystem.OpenTextFileWriter(filepathress, True)
            For i = 0 To 5
                file.WriteLine(SavedIpAdresses(i) & "," & SavedSubnets(i))

            Next
            file.Close()
            LabelSaved.Visible = True
            TimerSaved.Enabled = True

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim temparr(4) As String
        Dim temparr2(8) As String




        If Not (ListBox1.SelectedIndex = -1) Then
            DialogEdit.Show()

            IpToEdit = Split(ListBox1.SelectedItem.ToString, ".", 4)
            SubnetToEdit = Split(ListBox2.SelectedItem.ToString, ".", 4)

            DoActualize = 1
            SelectedItemInd = ListBox1.SelectedIndex
            DialogEdit.Timer1.Enabled = True
        End If


    End Sub



    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick


        Dim text As String
        Dim text2 As String
        Dim i As Integer


        If FocusPopUp Then
            FocusPopUp = False
            ListBox1.SelectedIndex = 0
            ListBox1.Select()
            ListBox2.SelectedIndex = 0
            ListBox2.Select()
            Timer1.Enabled = False
        End If

        If EditFinished Then
            EditFinished = False

            text = ""
            For i = 0 To 2
                text = text & IpNewEdit(i) & "."
            Next
            text = text & IpNewEdit(3)
            SavedIpAdresses(SelectedItemInd) = text

            text2 = ""
            For i = 0 To 2
                text2 = text2 & SubnetNewEdit(i) & "."
            Next
            text2 = text2 & SubnetNewEdit(3)
            SavedSubnets(SelectedItemInd) = text2


            ListBox1.Items.Item(SelectedItemInd) = text
            ListBox2.Items.Item(SelectedItemInd) = text2
            Timer1.Enabled = False

        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        SelectedItemInd = ListBox1.SelectedIndex


        If LastIPAdress IsNot vbNullString And LastSubnet IsNot vbNullString Then

            ListBox1.Items.Item(SelectedItemInd) = LastIPAdress
            ListBox2.Items.Item(SelectedItemInd) = LastSubnet

            SavedIpAdresses(SelectedItemInd) = LastIPAdress


            SavedSubnets(SelectedItemInd) = LastSubnet


        End If
    End Sub

    Private Sub TimerSaved_Tick(sender As Object, e As EventArgs) Handles TimerSaved.Tick
        LabelSaved.Visible = False
        TimerSaved.Enabled = False
    End Sub



    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If Label3.Visible Then
            Label3.Visible = False
            Button5.BackColor = SystemColors.Control
        Else
            Label3.Visible = True
            Button5.BackColor = Color.DarkGray

        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Process.Start("explorer.exe", "C:\ProgramData\IpChanger\")
    End Sub





    Private Sub ListBox1_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ListBox1.MouseClick


        ListBox2.SelectedIndex = ListBox1.SelectedIndex


    End Sub

    Private Sub ListBox2_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ListBox2.MouseClick



        ListBox1.SelectedIndex = ListBox2.SelectedIndex



    End Sub





End Class