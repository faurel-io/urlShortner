Public Class frmSettings
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        btnSave.Enabled = False
        Application.DoEvents()
        Environment.SetEnvironmentVariable("SHORTURL_API_KEY", txtAPI.Text, EnvironmentVariableTarget.User)
        Environment.SetEnvironmentVariable("SHORTURL_DOMAIN", txtDomain.Text, EnvironmentVariableTarget.User)
        MsgBox("Settings saved!!!", MsgBoxStyle.Information)
        btnSave.Enabled = True
        Application.DoEvents()
    End Sub
End Class