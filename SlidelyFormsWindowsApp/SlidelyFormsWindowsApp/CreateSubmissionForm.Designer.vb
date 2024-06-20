<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CreateSubmissionForm
    Inherits System.Windows.Forms.Form

    ' Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    ' NOTE: The following procedure is required by the Windows Form Designer
    ' It can be modified using the Windows Form Designer.  
    ' Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.lblGithubLink = New System.Windows.Forms.Label()
        Me.lblStopwatchTime = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtGithubLink = New System.Windows.Forms.TextBox()
        Me.txtStopwatchTime = New System.Windows.Forms.TextBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnStartStopStopwatch = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(166, 34)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(38, 13)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Name:"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(166, 60)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(35, 13)
        Me.lblEmail.TabIndex = 1
        Me.lblEmail.Text = "Email:"
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Location = New System.Drawing.Point(166, 86)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(41, 13)
        Me.lblPhone.TabIndex = 2
        Me.lblPhone.Text = "Phone:"
        '
        'lblGithubLink
        '
        Me.lblGithubLink.AutoSize = True
        Me.lblGithubLink.Location = New System.Drawing.Point(166, 112)
        Me.lblGithubLink.Name = "lblGithubLink"
        Me.lblGithubLink.Size = New System.Drawing.Size(66, 13)
        Me.lblGithubLink.TabIndex = 3
        Me.lblGithubLink.Text = "GitHub Link:"
        '
        'lblStopwatchTime
        '
        Me.lblStopwatchTime.AutoSize = True
        Me.lblStopwatchTime.Location = New System.Drawing.Point(166, 138)
        Me.lblStopwatchTime.Name = "lblStopwatchTime"
        Me.lblStopwatchTime.Size = New System.Drawing.Size(87, 13)
        Me.lblStopwatchTime.TabIndex = 4
        Me.lblStopwatchTime.Text = "Stopwatch Time:"
        '
        'txtName
        '
        Me.txtName.AccessibleName = "txtName"
        Me.txtName.Location = New System.Drawing.Point(259, 31)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(167, 20)
        Me.txtName.TabIndex = 5
        '
        'txtEmail
        '
        Me.txtEmail.AccessibleName = "txtEmail"
        Me.txtEmail.Location = New System.Drawing.Point(259, 57)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(167, 20)
        Me.txtEmail.TabIndex = 6
        '
        'txtPhone
        '
        Me.txtPhone.AccessibleName = "txtPhone"
        Me.txtPhone.Location = New System.Drawing.Point(259, 83)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(167, 20)
        Me.txtPhone.TabIndex = 7
        '
        'txtGithubLink
        '
        Me.txtGithubLink.AccessibleName = "txtGithubLink"
        Me.txtGithubLink.Location = New System.Drawing.Point(259, 109)
        Me.txtGithubLink.Name = "txtGithubLink"
        Me.txtGithubLink.Size = New System.Drawing.Size(167, 20)
        Me.txtGithubLink.TabIndex = 8
        '
        'txtStopwatchTime
        '
        Me.txtStopwatchTime.AccessibleName = "txtStopwatchTime"
        Me.txtStopwatchTime.Location = New System.Drawing.Point(259, 135)
        Me.txtStopwatchTime.Name = "txtStopwatchTime"
        Me.txtStopwatchTime.Size = New System.Drawing.Size(167, 20)
        Me.txtStopwatchTime.TabIndex = 9
        '
        'btnSubmit
        '
        Me.btnSubmit.AccessibleName = "btnSubmit"
        Me.btnSubmit.Location = New System.Drawing.Point(435, 214)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(75, 23)
        Me.btnSubmit.TabIndex = 10
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'btnStartStopStopwatch
        '
        Me.btnStartStopStopwatch.AccessibleName = "btnStartStopStopwatch"
        Me.btnStartStopStopwatch.Location = New System.Drawing.Point(132, 214)
        Me.btnStartStopStopwatch.Name = "btnStartStopStopwatch"
        Me.btnStartStopStopwatch.Size = New System.Drawing.Size(75, 23)
        Me.btnStartStopStopwatch.TabIndex = 11
        Me.btnStartStopStopwatch.Text = "Start/Stop"
        Me.btnStartStopStopwatch.UseVisualStyleBackColor = True
        '
        'CreateSubmissionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(665, 297)
        Me.Controls.Add(Me.btnStartStopStopwatch)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.txtStopwatchTime)
        Me.Controls.Add(Me.txtGithubLink)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblStopwatchTime)
        Me.Controls.Add(Me.lblGithubLink)
        Me.Controls.Add(Me.lblPhone)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblName)
        Me.Name = "CreateSubmissionForm"
        Me.Text = "Create New Submission"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblPhone As Label
    Friend WithEvents lblGithubLink As Label
    Friend WithEvents lblStopwatchTime As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtGithubLink As TextBox
    Friend WithEvents txtStopwatchTime As TextBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnStartStopStopwatch As Button
End Class
