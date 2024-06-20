Public Class CreateSubmissionForm
    Private stopwatch As Stopwatch
    Private stopwatchIsRunning As Boolean = False

    Public Sub New()
        InitializeComponent()
        InitializeStopwatch()
    End Sub

    Private Sub InitializeStopwatch()
        stopwatch = New Stopwatch()
    End Sub

    Private Sub btnStartStopStopwatch_Click(sender As Object, e As EventArgs) Handles btnStartStopStopwatch.Click
        If stopwatchIsRunning Then
            stopwatch.Stop()
        Else
            stopwatch.Start()
        End If
        stopwatchIsRunning = Not stopwatchIsRunning
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        ' Collect data and submit to backend/API
        Dim name As String = txtName.Text
        Dim email As String = txtEmail.Text
        Dim phone As String = txtPhone.Text
        Dim githubLink As String = txtGithubLink.Text
        Dim stopwatchTime As String = stopwatch.Elapsed.ToString()

        ' Optionally, you can validate the data here before submission

        ' For now, let's just display the collected data (replace this with actual submission logic)
        Dim submissionDetails As String = $"Name: {name}{Environment.NewLine}" &
                                          $"Email: {email}{Environment.NewLine}" &
                                          $"Phone: {phone}{Environment.NewLine}" &
                                          $"GitHub Link: {githubLink}{Environment.NewLine}" &
                                          $"Stopwatch Time: {stopwatchTime}"
        MessageBox.Show(submissionDetails, "Submission Details")

        ' Optionally, clear the form fields after submission
        ClearFormFields()
    End Sub

    Private Sub ClearFormFields()
        txtName.Text = ""
        txtEmail.Text = ""
        txtPhone.Text = ""
        txtGithubLink.Text = ""
        txtStopwatchTime.Text = ""
    End Sub
End Class
