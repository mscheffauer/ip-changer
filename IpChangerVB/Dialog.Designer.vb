<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Dialog
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.LabelSaved = New System.Windows.Forms.Label()
        Me.TimerSaved = New System.Windows.Forms.Timer(Me.components)
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(167, 259)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(123, 61)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Select Set"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 25
        Me.ListBox1.Location = New System.Drawing.Point(29, 49)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(200, 204)
        Me.ListBox1.TabIndex = 37
        '
        'Timer1
        '
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 17)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Ip-Address"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(230, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 17)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Subnetmask"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(456, 125)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(83, 50)
        Me.Button2.TabIndex = 40
        Me.Button2.Text = "Edit Selected"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(456, 201)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(83, 50)
        Me.Button3.TabIndex = 41
        Me.Button3.Text = "Save all"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(456, 49)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(83, 50)
        Me.Button4.TabIndex = 42
        Me.Button4.Text = "Copy from current"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'LabelSaved
        '
        Me.LabelSaved.AutoSize = True
        Me.LabelSaved.ForeColor = System.Drawing.Color.Green
        Me.LabelSaved.Location = New System.Drawing.Point(488, 293)
        Me.LabelSaved.Name = "LabelSaved"
        Me.LabelSaved.Size = New System.Drawing.Size(51, 17)
        Me.LabelSaved.TabIndex = 43
        Me.LabelSaved.Text = "Saved!"
        Me.LabelSaved.Visible = False
        '
        'TimerSaved
        '
        Me.TimerSaved.Interval = 3000
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(12, 345)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(28, 28)
        Me.Button5.TabIndex = 44
        Me.Button5.Text = "?"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(46, 351)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(378, 17)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "Double-click on list item or Select Set Button to select a set"
        Me.Label3.Visible = False
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(545, 214)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(40, 37)
        Me.Button6.TabIndex = 46
        Me.Button6.Text = "..."
        Me.Button6.UseVisualStyleBackColor = True
        '
        'ListBox2
        '
        Me.ListBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 25
        Me.ListBox2.Location = New System.Drawing.Point(229, 49)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(200, 204)
        Me.ListBox2.TabIndex = 47
        '
        'Dialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(599, 385)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.LabelSaved)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Dialog"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Select Set"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents LabelSaved As Label
    Friend WithEvents TimerSaved As Timer
    Friend WithEvents Button5 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Button6 As Button
    Friend WithEvents ListBox2 As ListBox
End Class
