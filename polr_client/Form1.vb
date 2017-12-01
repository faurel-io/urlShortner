Imports System.IO
Imports System.Net

Public Class Form1
    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        Me.Close()
    End Sub

    Private Sub RightClick(sender As Object, e As EventArgs) Handles NotifyIcon1.Click
        Dim MyButton As System.Windows.Forms.MouseEventArgs = e
        If MyButton.Button = MouseButtons.Right Then
            FromFieldToolStripMenuItem.Visible = False
        End If
    End Sub

    Private Sub lblSettings_Click(sender As Object, e As EventArgs) Handles lblSettings.Click
        Dim settings As New frmSettings()
        settings.txtAPI.Text = Environment.GetEnvironmentVariable("SHORTURL_API_KEY", EnvironmentVariableTarget.User)
        settings.txtDomain.Text = Environment.GetEnvironmentVariable("SHORTURL_DOMAIN", EnvironmentVariableTarget.User)
        settings.Show()
    End Sub

    Private Sub FromClipboardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FromClipboardToolStripMenuItem.Click
        Dim sURL As String
        If (Clipboard.ContainsText()) Then
            sURL = Clipboard.GetText()
            generateURL(sURL)
        End If
    End Sub

    Private Sub generateURL(ByVal longURL As String)
        Dim service As String
        service = "https://" &
                  Environment.GetEnvironmentVariable("SHORTURL_DOMAIN",
                                                     EnvironmentVariableTarget.User) &
                  "/api/v2/action/shorten?key={0}&url={1}"

        Dim sURL As String

        Dim apiKey As String
        apiKey = Environment.GetEnvironmentVariable("SHORTURL_API_KEY", EnvironmentVariableTarget.User)

        If (Clipboard.ContainsText()) Then
            sURL = Clipboard.GetText()

            Dim wrGETURL As WebRequest
            wrGETURL = WebRequest.Create(String.Format(service, apiKey, longURL))

            Try
                Dim objStream As Stream
                objStream = wrGETURL.GetResponse.GetResponseStream()

                Dim objReader As New StreamReader(objStream)
                Dim sLine As String = ""
                Dim i As Integer = 0
                Dim msgTxt As String
                Do While Not sLine Is Nothing
                    i += 1
                    sLine = objReader.ReadLine
                    If Not sLine Is Nothing Then
                        'Console.WriteLine("{0}:{1}", i, sLine)
                        Clipboard.SetText(sLine)
                        msgTxt = "Long URL: {0}{2}Short URL: {1}{2}Copied to clipboard!!!"
                        MsgBox(String.Format(msgTxt, longURL, sLine, vbCrLf),
                               MsgBoxStyle.OkOnly)
                    End If
                Loop
                Console.ReadLine()
            Catch ex As Exception
                MsgBox("Error: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub FromFieldToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FromFieldToolStripMenuItem.Click

    End Sub
End Class
