Imports System.Net
Imports System.Net.NetworkInformation
Imports System.Diagnostics

Module Module1
    Public EthIf As Integer
    Public SavedIpAdresses(6) As String
    Public SavedSubnets(6) As String
    Public SetIpAdress(4) As String
    Public setcmdIp As Boolean
    Public SetSubnet(4) As String
    Public FocusPopUp As Boolean


End Module

Public Class Form1
    Private strEvents As String
    Dim myInterfaces(1) As NetworkInterface
    Dim gInterfaces As NetworkInterface() = NetworkInterface.GetAllNetworkInterfaces()
    Dim sCount As Integer
    Dim myindizes As List(Of Integer)
    Dim refresh As Boolean
    Dim ipssaved(4) As String

    Dim Interface1 As String = "Ethernet"
    Dim Interface2 As String = "Ethernet 2"
    Dim Trigger As Boolean
    Dim OldIp As String = "192.168.10.19"
    Dim OldIp2 As String
    Dim PerformTrig As Boolean
    Dim PressedIn As Integer
    Dim oldTextLength2 As Integer
    Dim oldTextLength3 As Integer
    Dim oldTextLength4 As Integer
    Dim oldTextLength5 As Integer
    Dim interfacesarr(3) As String
    Dim startup1 As Boolean
    Dim testarray(4) As String
    Dim startup2 As Boolean
    Dim oldDHCP1 As String





    Dim GVersion As String = My.Application.Info.Version.ToString()



    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress

        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 46 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress

        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 46 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub TextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress

        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 46 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub TextBox4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox4.KeyPress

        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 46 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

    End Sub
    Private Sub TextBox5_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox5.KeyPress

        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 46 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

    End Sub
    Private Sub TextBox6_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox6.KeyPress

        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 46 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

    End Sub
    Private Sub TextBox7_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox7.KeyPress

        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 46 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

    End Sub
    Private Sub TextBox8_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox8.KeyPress

        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 46 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim IPmsg As String = ""
        Dim Interfacestr As String = "Ethernet"
        Dim BuildIP As String = ""
        Dim BuildGateWay As String = ""
        Dim ErrorNum As Boolean

        Dim ErrorIp As Boolean
        Dim process As System.Diagnostics.Process = Nothing
        Dim processStartInfo As New System.Diagnostics.ProcessStartInfo

        'Change the '/k' to a '/c' if you don't want cmd to remain open

        If RadioButton1.Checked And Not RadioButton2.Checked Then
            Interfacestr = Interface1
        End If

        If RadioButton2.Checked And Not RadioButton1.Checked Then
            Interfacestr = Interface2
        End If

        'Check the content of the ip adresses
        If CheckBox1.Checked = True Then
            ErrorNum = False
        Else
            If TextBox2.Text.Length > 0 And TextBox3.Text.Length > 0 And TextBox4.Text.Length > 0 And TextBox5.Text.Length > 0 And TextBox1.Text.Length > 0 And TextBox6.Text.Length > 0 And TextBox7.Text.Length > 0 And TextBox8.Text.Length > 0 Then
                If TextBox2.Text = "00" Or TextBox2.Text = "000" Then
                    TextBox2.Text = "0"
                End If
                If TextBox3.Text = "00" Or TextBox3.Text = "000" Then
                    TextBox3.Text = "0"
                End If
                If TextBox4.Text = "00" Or TextBox4.Text = "000" Then
                    TextBox4.Text = "0"
                End If
                If TextBox5.Text = "00" Or TextBox5.Text = "000" Then
                    TextBox5.Text = "0"
                End If
                If TextBox6.Text = "00" Or TextBox6.Text = "000" Then
                    TextBox6.Text = "0"
                End If
                If TextBox7.Text = "00" Or TextBox7.Text = "000" Then
                    TextBox7.Text = "0"
                End If
                If TextBox1.Text = "00" Or TextBox1.Text = "000" Then
                    TextBox1.Text = "0"
                End If
                If TextBox8.Text = "00" Or TextBox8.Text = "000" Then
                    TextBox8.Text = "0"
                End If

                BuildIP = TextBox2.Text & "." & TextBox3.Text & "." & TextBox4.Text & "." & TextBox5.Text
                BuildGateWay = TextBox1.Text & "." & TextBox6.Text & "." & TextBox7.Text & "." & TextBox8.Text
                ErrorNum = False
            Else
                ErrorNum = True
            End If

            If Interfacestr = Interface1 Then
                OldIp = BuildIP

            ElseIf Interfacestr = Interface2 Then
                OldIp2 = BuildIP

            End If

            If OldIp = OldIp2 Then
                ErrorIp = True
            Else
                ErrorIp = False
            End If

        End If




        'build netsh string
        If ErrorNum = False And ErrorIp = False Then


            If CheckBox1.Checked = True Then
                IPmsg = " dhcp"
            Else

                IPmsg = " static " & BuildIP & " " & BuildGateWay
            End If

            processStartInfo.Arguments = "/c netsh interface ip set address name=" & Chr(34) & Interfacestr & Chr(34) & IPmsg
            processStartInfo.FileName = "cmd" 'program to run
            If System.Environment.OSVersion.Version.Major >= 6 Then
                ' Run as admin on Windows Vista or higher 
                processStartInfo.Verb = "runas"
            End If
            processStartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal
            processStartInfo.UseShellExecute = True

            Try
                process = System.Diagnostics.Process.Start(processStartInfo)
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                If Not process Is Nothing Then
                    process.Dispose()
                End If
                TimerRefresh.Enabled = True
                Timer2.Enabled = False
            End Try




        End If

        'show error message

        If ErrorNum = True Then
            Label3.Text = "Ip-Address and Subnetmask must be of format xxx.xxx.xxx.xxx"

            Label3.Visible = True
        ElseIf ErrorIp = True Then
            Label3.Text = "Ip-Address 1 must be different from Ip-Address 2"
            Label3.Visible = True
        Else
            TextBox1.Select()

            Label3.Visible = False
        End If
        TextBox2.Select()
        If TextBox2.TextLength > 0 Then
            TextBox2.SelectAll()
        End If



    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim adapter As NetworkInterface
        Dim index As Integer

        If Trigger = 0 Then
            For i = 0 To (Me.Controls.Count - 1)
                If Me.Controls(i).Name Is "TextBox2" Then
                    'Find the TextBox for which Text is not set.

                    'Set the focus on the control without any text.
                    If Trigger = 0 And TextBox2.TextLength = 0 Then
                        Me.ActiveControl = Me.Controls(i)
                        Trigger = True
                    Else
                        Trigger = True
                    End If


                End If
            Next
        End If


        Me.Text = "IpChanger " & GVersion

        If Not (My.Computer.FileSystem.DirectoryExists("c:\ProgramData\IpChanger")) Then
            My.Computer.FileSystem.CreateDirectory("c:\ProgramData\IpChanger")

        End If


        RadioButton1.Checked = True
        TextBox1.Text = "255"
        TextBox6.Text = "255"
        TextBox7.Text = "255"
        TextBox8.Text = "0"
        LabelDHCP.Text = ""
        Label13.Text = ""




        CheckedListBox1.Items.Clear()
        ListBox1.Items.Clear()


        For Each adapter In gInterfaces
            CheckedListBox1.Items.Add(adapter.Name)
        Next


        If My.Settings.fav2 = "" And My.Settings.fav1 = "" Then
            CheckedListBox1.SetItemChecked(0, True)

            CheckedListBox1.SetItemChecked(1, True)

            ListBox1.Items.Add(CheckedListBox1.Items(0))
            ListBox1.Items.Add(CheckedListBox1.Items(1))

            My.Settings.fav1 = CheckedListBox1.Items(0).ToString
            My.Settings.fav2 = CheckedListBox1.Items(1).ToString
            My.Settings.Save()


        ElseIf My.Settings.fav1 <> "" And My.Settings.fav2 = "" Then

            For index = 0 To CheckedListBox1.Items.Count - 1
                If My.Settings.fav1 = CheckedListBox1.Items(index) Then
                    CheckedListBox1.SetItemChecked(index, True)
                    ListBox1.Items.Add(My.Settings.fav1)

                End If
            Next


        ElseIf My.Settings.fav2 <> "" And My.Settings.fav1 = "" Then


            For index = 0 To CheckedListBox1.Items.Count - 1
                If My.Settings.fav2 = CheckedListBox1.Items(index) Then
                    CheckedListBox1.SetItemChecked(index, True)
                    ListBox1.Items.Add(My.Settings.fav2)

                End If
            Next


        Else


            For index = 0 To CheckedListBox1.Items.Count - 1
                If My.Settings.fav1 = CheckedListBox1.Items(index) Then
                    CheckedListBox1.SetItemChecked(index, True)
                    ListBox1.Items.Add(My.Settings.fav1)

                End If
            Next

            For index = 0 To CheckedListBox1.Items.Count - 1
                If My.Settings.fav2 = CheckedListBox1.Items(index) Then
                    CheckedListBox1.SetItemChecked(index, True)
                    ListBox1.Items.Add(My.Settings.fav2)

                End If

            Next


        End If

        My.Settings.Save()


    End Sub
    Private Sub RefreshDropDown()
        Dim adapter As NetworkInterface
        Dim savedindizes As List(Of Integer)

        savedindizes = myindizes

        CheckedListBox1.Items.Clear()

        For Each adapter In gInterfaces
            CheckedListBox1.Items.Add(adapter.Name)
        Next

        If savedindizes.Count > 0 Then
            CheckedListBox1.SetItemChecked(savedindizes(0), True)
        End If

        If savedindizes.Count > 1 Then
            CheckedListBox1.SetItemChecked(savedindizes(1), True)
        End If


        sCount = CheckedListBox1.CheckedItems.Count
        refreshbuttons()


    End Sub


    Private Sub refreshbuttons()


        If sCount < 2 And sCount > 0 Then
            Button3.Enabled = False
            RadioButton2.Enabled = False
        ElseIf sCount = 0 Then
            Button3.Enabled = False
            RadioButton2.Enabled = False
            Button2.Enabled = False
            RadioButton1.Enabled = False
        Else
            Button3.Enabled = True
            RadioButton2.Enabled = True
            Button2.Enabled = True
            RadioButton1.Enabled = True


        End If

    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick




        If setcmdIp Then
            setcmdIp = 0

            TextBox2.Text = SetIpAdress(0)
            TextBox3.Text = SetIpAdress(1)
            TextBox4.Text = SetIpAdress(2)
            TextBox5.Text = SetIpAdress(3)

            TextBox1.Text = SetSubnet(0)
            TextBox6.Text = SetSubnet(1)
            TextBox7.Text = SetSubnet(2)
            TextBox8.Text = SetSubnet(3)
            Timer1.Enabled = False

        End If




    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        RadioButton1.Checked = True
        RefreshNetworkInterface()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click


        RadioButton2.Checked = True
        RefreshNetworkInterface()


    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged


        If CheckBox1.Checked = True Then
            TextBox1.Enabled = False
            TextBox2.Enabled = False
            TextBox3.Enabled = False
            TextBox4.Enabled = False
            TextBox5.Enabled = False
            TextBox6.Enabled = False
            TextBox7.Enabled = False
            TextBox8.Enabled = False
            Button4.Enabled = False

        Else
            Button4.Enabled = True
            TextBox1.Enabled = True
            TextBox2.Enabled = True
            TextBox3.Enabled = True
            TextBox4.Enabled = True
            TextBox5.Enabled = True
            TextBox6.Enabled = True
            TextBox7.Enabled = True
            TextBox8.Enabled = True
        End If
    End Sub

    Private Sub RefreshNetworkInterface()

        RefreshNetwork()





        If IsNothing(myInterfaces(0)) And IsNothing(myInterfaces(1)) Then
            Return
        End If
        Dim oldipadr1 As String = ""
        Dim oldipadr2 As String = ""

        Button1.Enabled = True




        If Not IsNothing(myInterfaces(1)) Then

            Interface2 = myInterfaces(1).Name
            RadioButton2.Text = Interface2

            Dim IPInfo2 As UnicastIPAddressInformationCollection = myInterfaces(1).GetIPProperties().UnicastAddresses()

            For Each IPAddressInfo2 As UnicastIPAddressInformation In IPInfo2

                If IPAddressInfo2.Address.IsIPv6LinkLocal = False Then




                    If RadioButton2.Checked = True Then

                        If oldipadr2 IsNot IPAddressInfo2.Address.ToString Then


                            oldipadr2 = IPAddressInfo2.Address.ToString
                            Label13.Text = oldipadr2

                            If startup2 = False Then

                                testarray = Split(oldipadr2, ".")
                                TextBox2.Text = testarray(0)
                                TextBox3.Text = testarray(1)
                                TextBox4.Text = testarray(2)
                                TextBox5.Text = testarray(3)

                                testarray = Split(IPAddressInfo2.IPv4Mask.ToString, ".")
                                TextBox1.Text = testarray(0)
                                TextBox6.Text = testarray(1)
                                TextBox7.Text = testarray(2)
                                TextBox8.Text = testarray(3)

                                startup2 = True
                                startup1 = False

                                PerformTrig = True
                                TimerTrig.Enabled = True
                                PressedIn = 2

                                oldTextLength2 = TextBox2.TextLength
                                oldTextLength3 = TextBox3.TextLength
                                oldTextLength4 = TextBox4.TextLength
                                oldTextLength5 = TextBox5.TextLength
                                Timer3.Enabled = True
                            End If

                        End If
                    Else
                        Continue For

                    End If

                    LabelSub.Text = IPAddressInfo2.IPv4Mask.ToString


                    LabelDHCP.Text = myInterfaces(1).GetIPProperties.GetIPv4Properties.IsDhcpEnabled


                    If LabelDHCP.Text = oldDHCP1 Then

                    Else
                        oldDHCP1 = LabelDHCP.Text
                        If oldDHCP1 = "True" Then
                            CheckBox1.Checked = 1
                        ElseIf oldDHCP1 = "False" Then
                            CheckBox1.Checked = 0
                        End If

                    End If
                End If
            Next


        End If



        If Not IsNothing(myInterfaces(0)) Then

            Interface1 = myInterfaces(0).Name
            RadioButton1.Text = Interface1

            Dim IPInfo1 As UnicastIPAddressInformationCollection = myInterfaces(0).GetIPProperties().UnicastAddresses()


            For Each IPAddressInfo1 As UnicastIPAddressInformation In IPInfo1

                If IPAddressInfo1.Address.IsIPv6LinkLocal = False Then




                    If RadioButton1.Checked = True Then

                        If oldipadr1 IsNot IPAddressInfo1.Address.ToString Then
                            oldipadr1 = IPAddressInfo1.Address.ToString
                            Label13.Text = oldipadr1
                            If startup1 = False Then

                                testarray = Split(oldipadr1, ".")
                                TextBox2.Text = testarray(0)
                                TextBox3.Text = testarray(1)
                                TextBox4.Text = testarray(2)
                                TextBox5.Text = testarray(3)

                                testarray = Split(IPAddressInfo1.IPv4Mask.ToString, ".")
                                TextBox1.Text = testarray(0)
                                TextBox6.Text = testarray(1)
                                TextBox7.Text = testarray(2)
                                TextBox8.Text = testarray(3)


                                startup1 = True
                                startup2 = False

                                PerformTrig = True
                                TimerTrig.Enabled = True
                                PressedIn = 2

                                oldTextLength2 = TextBox2.TextLength
                                oldTextLength3 = TextBox3.TextLength
                                oldTextLength4 = TextBox4.TextLength
                                oldTextLength5 = TextBox5.TextLength
                                Timer3.Enabled = True
                            End If


                        End If
                    Else
                        Continue For
                    End If

                    LabelSub.Text = IPAddressInfo1.IPv4Mask.ToString




                    LabelDHCP.Text = myInterfaces(0).GetIPProperties.GetIPv4Properties.IsDhcpEnabled

                    If LabelDHCP.Text = oldDHCP1 Then

                    Else
                        oldDHCP1 = LabelDHCP.Text
                        If oldDHCP1 = "True" Then
                            CheckBox1.Checked = 1
                        ElseIf oldDHCP1 = "False" Then
                            CheckBox1.Checked = 0
                        End If

                    End If
                End If

            Next

        End If





    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        RefreshNetworkInterface()
        Timer2.Enabled = False

    End Sub



    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox2.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.OemPeriod Then
            PerformTrig = True
            TimerTrig.Enabled = True

            PressedIn = 0
            ipssaved(0) = TextBox2.Text

        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
    Private Sub Form2_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox3.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.OemPeriod Then
            PerformTrig = True
            TimerTrig.Enabled = True

            PressedIn = 1
            ipssaved(1) = TextBox3.Text

        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
    Private Sub Form3_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox4.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.OemPeriod Then
            PerformTrig = True
            TimerTrig.Enabled = True

            PressedIn = 2
            ipssaved(2) = TextBox4.Text

        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
    Private Sub Form4_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox5.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.OemPeriod Then
            PerformTrig = True
            TimerTrig.Enabled = True

            PressedIn = 3
            ipssaved(3) = TextBox5.Text

        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub FormBut_KeyDown(sender As Object, e As KeyEventArgs) Handles Button1.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.OemPeriod Then
            PerformTrig = True
            TimerTrig.Enabled = True

            PressedIn = 4


        End If

        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
    Private Sub FormMyb11_KeyDown(sender As Object, e As KeyEventArgs) Handles Button2.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
    Private Sub FormMyb0_KeyDown(sender As Object, e As KeyEventArgs) Handles Button3.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
    Private Sub FormMyb0_KeDown(sender As Object, e As KeyEventArgs) Handles Button4.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
    Private Sub FormMyb0_yDown(sender As Object, e As KeyEventArgs) Handles Button5.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
    Private Sub FormMyb0_KDown(sender As Object, e As KeyEventArgs) Handles Button6.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub FormMyb0_Kwn(sender As Object, e As KeyEventArgs) Handles CheckedListBox1.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub FormMyb1_KeyDown(sender As Object, e As KeyEventArgs) Handles RadioButton1.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
    Private Sub FormMyb2_KeyDown(sender As Object, e As KeyEventArgs) Handles RadioButton2.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
    Private Sub FormMyb22_KeyDown(sender As Object, e As KeyEventArgs) Handles CheckBox1.KeyDown

        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
    Private Sub FormMyb222_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown

        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
    Private Sub FormMyb2221_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown

        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
    Private Sub FormMyb2228_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox6.KeyDown

        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
    Private Sub FormMyb2226_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox7.KeyDown

        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
    Private Sub FormMyb2227_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox8.KeyDown

        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub



    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick





        If Strings.InStr(TextBox1.Text, ".") > 0 Then
            TextBox1.Text = TextBox1.Text.Replace(".", "")

        End If
        If Strings.InStr(TextBox2.Text, ".") > 0 Then
            TextBox2.Text = TextBox2.Text.Replace(".", "")
            If ipssaved(0).Length > 0 Then
                TextBox2.Text = ipssaved(0)
            End If

        End If
        If Strings.InStr(TextBox3.Text, ".") > 0 Then
            TextBox3.Text = TextBox3.Text.Replace(".", "")
            If ipssaved(1).Length > 0 Then
                TextBox3.Text = ipssaved(1)
            End If
        End If
        If Strings.InStr(TextBox4.Text, ".") > 0 Then
            TextBox4.Text = TextBox4.Text.Replace(".", "")
            If ipssaved(2).Length > 0 Then
                TextBox4.Text = ipssaved(2)
            End If
        End If
        If Strings.InStr(TextBox5.Text, ".") > 0 Then
            TextBox5.Text = TextBox5.Text.Replace(".", "")
            If ipssaved(3).Length > 0 Then
                TextBox5.Text = ipssaved(3)
            End If
        End If
        If Strings.InStr(TextBox6.Text, ".") > 0 Then
            TextBox6.Text = TextBox6.Text.Replace(".", "")
        End If
        If Strings.InStr(TextBox7.Text, ".") > 0 Then
            TextBox7.Text = TextBox7.Text.Replace(".", "")
        End If
        If Strings.InStr(TextBox8.Text, ".") > 0 Then
            TextBox8.Text = TextBox8.Text.Replace(".", "")
        End If




    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If RadioButton1.Checked Then
            EthIf = 1
        ElseIf RadioButton2.Checked Then
            EthIf = 2
        End If

        LastIPAdress = TextBox2.Text & "." & TextBox3.Text & "." & TextBox4.Text & "." & TextBox5.Text
        LastSubnet = TextBox1.Text & "." & TextBox6.Text & "." & TextBox7.Text & "." & TextBox8.Text
        Dialog.Show()
        FocusPopUp = 1
        Dialog.Timer1.Enabled = True

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If Label14.Visible Then
            Label14.Visible = False
            Button5.BackColor = SystemColors.Control

        Else
            Label14.Visible = True
            Button5.BackColor = Color.DarkGray

        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        If TextBox2.TextLength < oldTextLength2 Or TextBox2.TextLength > oldTextLength2 Then
            oldTextLength2 = TextBox2.TextLength
            If TextBox2.TextLength = 3 Then
                PerformTrig = True
                TimerTrig.Enabled = True

                PressedIn = 0
            End If
        End If
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        If TextBox3.TextLength > oldTextLength3 Or TextBox3.TextLength < oldTextLength3 Then
            oldTextLength3 = TextBox3.TextLength
            If TextBox3.TextLength = 3 Then
                PerformTrig = True
                TimerTrig.Enabled = True

                PressedIn = 1
            End If
        End If
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        If TextBox4.TextLength > oldTextLength4 Or TextBox4.TextLength < oldTextLength4 Then
            oldTextLength4 = TextBox4.TextLength
            If TextBox4.TextLength = 3 Then
                PerformTrig = True
                TimerTrig.Enabled = True

                PressedIn = 2
            End If
        End If
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        If TextBox5.TextLength > oldTextLength5 Or TextBox5.TextLength < oldTextLength5 Then
            oldTextLength5 = TextBox5.TextLength
            If TextBox5.TextLength = 3 Then
                PerformTrig = True
                TimerTrig.Enabled = True

                PressedIn = 3
            End If
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        Dim OldCheck2 As Boolean
        If RadioButton2.Checked = Not OldCheck2 Then
            OldCheck2 = RadioButton2.Checked
            If RadioButton1.Checked Then
                RadioButton1.Checked = False
            End If

        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        Dim OldCheck1 As Boolean

        If RadioButton1.Checked = Not OldCheck1 Then
            OldCheck1 = RadioButton1.Checked
            If RadioButton2.Checked Then
                RadioButton2.Checked = False
            End If

        End If
    End Sub
    Private Sub clickbut2(sender As Object, e As EventArgs) Handles RadioButton2.Click
        RadioButton2.Checked = True
        RefreshNetworkInterface()
    End Sub
    Private Sub clickbut1(sender As Object, e As EventArgs) Handles RadioButton1.Click
        RadioButton1.Checked = True
        RefreshNetworkInterface()
    End Sub

    Private Sub TimerTrig_Tick(sender As Object, e As EventArgs) Handles TimerTrig.Tick
        If PerformTrig = True Then


            Select Case PressedIn
                Case 0

                    TextBox3.Select()
                    If TextBox3.TextLength > 0 Then
                        TextBox3.SelectAll()
                    End If
                Case 1
                    TextBox4.Select()
                    If TextBox4.TextLength > 0 Then
                        TextBox4.SelectAll()
                    End If
                Case 2
                    TextBox5.Select()
                    If TextBox5.TextLength > 0 Then
                        TextBox5.SelectAll()
                    End If
                Case 3
                    Button1.Select()
                Case 4
                    TextBox2.Select()
                    If TextBox2.TextLength > 0 Then
                        TextBox2.SelectAll()
                    End If




            End Select

            PerformTrig = False
            TimerTrig.Enabled = False

        End If


    End Sub



    Private Sub RefreshNetwork()

        sCount = CheckedListBox1.CheckedItems.Count
        If Not refresh Then
            myindizes = CheckedListBox1.CheckedIndices.Cast(Of Integer).ToList

        End If


        If refresh And sCount = 1 Then
            sCount = 2
        ElseIf refresh And sCount = 2 Then
            sCount = 1
        End If
        gInterfaces = NetworkInterface.GetAllNetworkInterfaces()

        If sCount = 1 And myindizes.Count > 0 Then
            myInterfaces(0) = gInterfaces(myindizes.ElementAt(0))



        ElseIf sCount = 2 And myindizes.Count = 2 Then
            myInterfaces(0) = gInterfaces(myindizes.ElementAt(0))
            myInterfaces(1) = gInterfaces(myindizes.ElementAt(1))


        End If

        If refresh Then
            refresh = False
        End If

    End Sub

    Private Sub CheckedListBox_ItemChck(sender As Object, e As ItemCheckEventArgs) Handles CheckedListBox1.ItemCheck
        sCount = CheckedListBox1.CheckedItems.Count
        myindizes = CheckedListBox1.CheckedIndices.Cast(Of Integer).ToList


        If (e.NewValue = CheckState.Checked) Then
            sCount = sCount + 1

        End If
        If (e.NewValue = CheckState.Unchecked) Then
            sCount = sCount - 1
        End If

        If (e.NewValue = CheckState.Checked And sCount > 2) Then
            e.NewValue = CheckState.Unchecked
            Return
        End If

        If (e.NewValue = CheckState.Unchecked And sCount < 1) Then
            e.NewValue = CheckState.Checked
            Return
        End If


        If (e.NewValue = CheckState.Checked) Then
            myindizes.Add(e.Index)
        Else
            If (myindizes.Contains(e.Index)) Then
                myindizes.Remove(e.Index)
            End If

        End If

        refreshbuttons()
        refresh = True
        RefreshNetworkInterface()
        Timer4.Enabled = True

        If RadioButton1.Checked Then
            startup1 = False
            startup2 = True

        End If
        If RadioButton2.Checked Then
            startup1 = True
            startup2 = False

        End If

    End Sub

    Private Sub TimerRefresh_Tick(sender As Object, e As EventArgs) Handles TimerRefresh.Tick
        TimerRefresh.Enabled = False
        RefreshNetworkInterface()
        Timer2.Enabled = True

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        If CheckedListBox1.Visible Then
            CheckedListBox1.Visible = False
            Button6.BackColor = SystemColors.Control
            ListBox1.Visible = False
            Label15.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            GroupBox1.Visible = False
        Else
            CheckedListBox1.Visible = True
            Button6.BackColor = Color.DarkGray
            ListBox1.Visible = True
            Label15.Visible = True
            Button7.Visible = True
            Button8.Visible = True
            GroupBox1.Visible = True

        End If

        RefreshNetworkInterface()
        RefreshDropDown()
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        Timer4.Enabled = False
        RefreshNetworkInterface()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

        If ListBox1.Items.Count = 1 Then
            If Not CheckedListBox1.SelectedItem = ListBox1.Items(0) Then

                ListBox1.Items.Add(CheckedListBox1.SelectedItem)
                My.Settings.fav2 = CheckedListBox1.SelectedItem
                My.Settings.Save()


            End If
        Else


            If ListBox1.Items.Count < 2 Then
                ListBox1.Items.Add(CheckedListBox1.SelectedItem)
                My.Settings.fav1 = CheckedListBox1.SelectedItem
                My.Settings.Save()

            End If

        End If


    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        ListBox1.Items.Remove(ListBox1.SelectedItem)

    End Sub

End Class
