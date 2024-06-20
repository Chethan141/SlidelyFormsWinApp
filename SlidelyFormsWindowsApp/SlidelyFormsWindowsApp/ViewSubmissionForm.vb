Public Class ViewSubmissionsForm
    Private currentIndex As Integer = 0
    Private submissions As List(Of Submission)

    Public Sub New()
        InitializeComponent()
        LoadSubmissions()
        DisplaySubmission(currentIndex)
    End Sub

    Private Sub LoadSubmissions()
        ' This method should load the submissions from the backend (or a local JSON file for now)
        ' For demonstration, let's assume we have a predefined list of submissions
        submissions = New List(Of Submission) From {
            New Submission With {.Name = "John Doe", .Email = "john.doe@example.com", .Phone = "1234567890", .GithubLink = "http://github.com/johndoe", .StopwatchTime = "00:10:00"},
            New Submission With {.Name = "Jane Smith", .Email = "jane.smith@example.com", .Phone = "0987654321", .GithubLink = "http://github.com/janesmith", .StopwatchTime = "00:20:00"}
        }
    End Sub

    Private Sub DisplaySubmission(index As Integer)
        If index >= 0 AndAlso index < submissions.Count Then
            Dim submission = submissions(index)
            txtName.Text = submission.Name
            txtEmail.Text = submission.Email
            txtPhone.Text = submission.Phone
            txtGithubLink.Text = submission.GithubLink
            txtStopwatchTime.Text = submission.StopwatchTime
        End If
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            DisplaySubmission(currentIndex)
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If currentIndex < submissions.Count - 1 Then
            currentIndex += 1
            DisplaySubmission(currentIndex)
        End If
    End Sub
End Class

' Define a simple class to hold submission data
Public Class Submission
    Public Property Name As String
    Public Property Email As String
    Public Property Phone As String
    Public Property GithubLink As String
    Public Property StopwatchTime As String
End Class
