Public Class Form15
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub AxWindowsMediaPlayer1_Enter(sender As Object, e As EventArgs) Handles AxWindowsMediaPlayer1.Enter
        AxWindowsMediaPlayer1.URL = "C:\Users\User\Desktop\DDT4A\VB\posttraumatic-stress-disorder-ptsd-causes-symptoms-treatment-and-pathology.mp4"
        AxWindowsMediaPlayer1.Ctlcontrols.play()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked

    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs)

    End Sub

    Private Sub AxWebBrowser1_Enter(sender As Object, e As EventArgs)


    End Sub
End Class