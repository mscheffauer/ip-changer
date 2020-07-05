<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LabelSub = New System.Windows.Forms.Label()
        Me.LabelIP = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.LabelDHCP = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.TimerTrig = New System.Windows.Forms.Timer(Me.components)
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
        Me.TimerRefresh = New System.Windows.Forms.Timer(Me.components)
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(281, 345)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(177, 79)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Change"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(221, 277)
        Me.TextBox1.MaxLength = 3
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ShortcutsEnabled = False
        Me.TextBox1.Size = New System.Drawing.Size(59, 36)
        Me.TextBox1.TabIndex = 1
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(221, 187)
        Me.TextBox2.MaxLength = 3
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ShortcutsEnabled = False
        Me.TextBox2.Size = New System.Drawing.Size(59, 36)
        Me.TextBox2.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(87, 196)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Ip-Address:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(87, 287)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Subnetmask:"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'RadioButton1
        '
        Me.RadioButton1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.RadioButton1.Location = New System.Drawing.Point(54, 26)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Padding = New System.Windows.Forms.Padding(15, 0, 10, 0)
        Me.RadioButton1.Size = New System.Drawing.Size(165, 83)
        Me.RadioButton1.TabIndex = 5
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Ethernet 1"
        Me.RadioButton1.UseVisualStyleBackColor = False
        '
        'RadioButton2
        '
        Me.RadioButton2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.RadioButton2.Location = New System.Drawing.Point(276, 27)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Padding = New System.Windows.Forms.Padding(15, 0, 10, 0)
        Me.RadioButton2.Size = New System.Drawing.Size(165, 83)
        Me.RadioButton2.TabIndex = 6
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Ethernet 2"
        Me.RadioButton2.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.Location = New System.Drawing.Point(49, 23)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(175, 91)
        Me.Button2.TabIndex = 7
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(271, 24)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(175, 91)
        Me.Button3.TabIndex = 8
        Me.Button3.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(90, 148)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(142, 21)
        Me.CheckBox1.TabIndex = 9
        Me.CheckBox1.Text = "Get Ip from DHCP"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(302, 187)
        Me.TextBox3.MaxLength = 3
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ShortcutsEnabled = False
        Me.TextBox3.Size = New System.Drawing.Size(59, 36)
        Me.TextBox3.TabIndex = 10
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(378, 187)
        Me.TextBox4.MaxLength = 3
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ShortcutsEnabled = False
        Me.TextBox4.Size = New System.Drawing.Size(59, 36)
        Me.TextBox4.TabIndex = 11
        '
        'TextBox5
        '
        Me.TextBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(457, 187)
        Me.TextBox5.MaxLength = 3
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ShortcutsEnabled = False
        Me.TextBox5.Size = New System.Drawing.Size(59, 36)
        Me.TextBox5.TabIndex = 12
        '
        'TextBox6
        '
        Me.TextBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.Location = New System.Drawing.Point(302, 277)
        Me.TextBox6.MaxLength = 3
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.ShortcutsEnabled = False
        Me.TextBox6.Size = New System.Drawing.Size(59, 36)
        Me.TextBox6.TabIndex = 13
        '
        'TextBox7
        '
        Me.TextBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox7.Location = New System.Drawing.Point(378, 277)
        Me.TextBox7.MaxLength = 3
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.ShortcutsEnabled = False
        Me.TextBox7.Size = New System.Drawing.Size(59, 36)
        Me.TextBox7.TabIndex = 14
        '
        'TextBox8
        '
        Me.TextBox8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox8.Location = New System.Drawing.Point(457, 277)
        Me.TextBox8.MaxLength = 3
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.ShortcutsEnabled = False
        Me.TextBox8.Size = New System.Drawing.Size(59, 36)
        Me.TextBox8.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(191, 241)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(388, 17)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Ip-Address and Subnetmask must be of format xxx.xxx.xxx.xxx"
        Me.Label3.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(577, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(131, 17)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Current Ip-Address:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(577, 61)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(141, 17)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Current Subnetmask:"
        '
        'LabelSub
        '
        Me.LabelSub.AutoSize = True
        Me.LabelSub.Location = New System.Drawing.Point(736, 61)
        Me.LabelSub.Name = "LabelSub"
        Me.LabelSub.Size = New System.Drawing.Size(35, 17)
        Me.LabelSub.TabIndex = 21
        Me.LabelSub.Text = "asdf"
        '
        'LabelIP
        '
        Me.LabelIP.AutoSize = True
        Me.LabelIP.Location = New System.Drawing.Point(714, 27)
        Me.LabelIP.Name = "LabelIP"
        Me.LabelIP.Size = New System.Drawing.Size(0, 17)
        Me.LabelIP.TabIndex = 22
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        '
        'Timer3
        '
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(281, 190)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(20, 29)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(361, 190)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(20, 29)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "."
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(438, 190)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(20, 29)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "."
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(438, 280)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(20, 29)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "."
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(361, 280)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(20, 29)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "."
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(281, 280)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(20, 29)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "."
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(577, 96)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(131, 17)
        Me.Label12.TabIndex = 29
        Me.Label12.Text = "Gets Ip from DHCP:"
        '
        'LabelDHCP
        '
        Me.LabelDHCP.AutoSize = True
        Me.LabelDHCP.Location = New System.Drawing.Point(736, 96)
        Me.LabelDHCP.Name = "LabelDHCP"
        Me.LabelDHCP.Size = New System.Drawing.Size(50, 17)
        Me.LabelDHCP.TabIndex = 30
        Me.LabelDHCP.Text = "DHCP:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(736, 27)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(59, 17)
        Me.Label13.TabIndex = 31
        Me.Label13.Text = "Label13"
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(532, 187)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(47, 36)
        Me.Button4.TabIndex = 34
        Me.Button4.Text = "..."
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(51, 451)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(562, 17)
        Me.Label14.TabIndex = 47
        Me.Label14.Text = "Press ""..."" to select a set for Ip address. Press ""."" or ""Enter"" to switch betwee" &
    "n textboxes."
        Me.Label14.Visible = False
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(12, 445)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(28, 28)
        Me.Button5.TabIndex = 46
        Me.Button5.Text = "?"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'TimerTrig
        '
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.CheckOnClick = True
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.HorizontalScrollbar = True
        Me.CheckedListBox1.Location = New System.Drawing.Point(6, 26)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(265, 157)
        Me.CheckedListBox1.TabIndex = 48
        Me.CheckedListBox1.Visible = False
        '
        'TimerRefresh
        '
        Me.TimerRefresh.Interval = 500
        '
        'Button6
        '
        Me.Button6.Image = CType(resources.GetObject("Button6.Image"), System.Drawing.Image)
        Me.Button6.Location = New System.Drawing.Point(225, 47)
        Me.Button6.Margin = New System.Windows.Forms.Padding(0)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(45, 45)
        Me.Button6.TabIndex = 49
        Me.Button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Timer4
        '
        Me.Timer4.Interval = 300
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(6, 210)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(265, 84)
        Me.ListBox1.TabIndex = 50
        Me.ListBox1.Visible = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(6, 187)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(66, 17)
        Me.Label15.TabIndex = 51
        Me.Label15.Text = "Favorites"
        Me.Label15.Visible = False
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(115, 184)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(125, 23)
        Me.Button7.TabIndex = 52
        Me.Button7.Text = "Add as favorite"
        Me.Button7.UseVisualStyleBackColor = True
        Me.Button7.Visible = False
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(247, 184)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(24, 23)
        Me.Button8.TabIndex = 53
        Me.Button8.Text = "x"
        Me.Button8.UseVisualStyleBackColor = True
        Me.Button8.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CheckedListBox1)
        Me.GroupBox1.Controls.Add(Me.Button8)
        Me.GroupBox1.Controls.Add(Me.ListBox1)
        Me.GroupBox1.Controls.Add(Me.Button7)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox1.Location = New System.Drawing.Point(636, 170)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(278, 303)
        Me.GroupBox1.TabIndex = 54
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Settings"
        Me.GroupBox1.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(926, 485)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.LabelDHCP)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.LabelIP)
        Me.Controls.Add(Me.LabelSub)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "IpChanger"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents LabelSub As Label
    Friend WithEvents LabelIP As Label
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Timer3 As Timer
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents LabelDHCP As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents TimerTrig As Timer
    Friend WithEvents CheckedListBox1 As CheckedListBox
    Friend WithEvents TimerRefresh As Timer
    Friend WithEvents Button6 As Button
    Friend WithEvents Timer4 As Timer
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents GroupBox1 As GroupBox
End Class
