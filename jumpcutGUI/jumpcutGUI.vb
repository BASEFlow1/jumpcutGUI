Imports System.Configuration
Public Class jumpcutGUI
    Public Function FileExists(filename As String) As Boolean
        FileExists = Len(Dir(filename, vbNormal)) > 0
    End Function

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        inputFileDialog.Title = "Please Select a File"
        inputFileDialog.ShowDialog()
        inputText.Text = inputFileDialog.FileName.ToString()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles inputText.TextChanged
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        outputFileDialog.Title = "Please Select a File"
        outputFileDialog.Filter = "Video Files|*.mp4"
        outputFileDialog.ShowDialog()
        outputText.Text = outputFileDialog.FileName.ToString()

    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles outputText.TextChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub TextBox1_TextChanged_2(sender As Object, e As EventArgs) Handles soundedSpeedText.TextChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim input As String = inputText.Text
        Dim output As String = outputText.Text
        Dim soundedSpeed As Decimal = Convert.ToDecimal(soundedSpeedText.Text)
        Dim silentSpeed As Decimal = Convert.ToDecimal(silentSpeedText.Text)
        Dim silentThreshold As Decimal = Convert.ToDecimal(silentThresholdText.Text)
        Dim frameMargin As Decimal = Convert.ToDecimal(frameMarginText.Text)
        Dim sampleRate As Decimal = Convert.ToDecimal(sampleRateText.Text)
        Dim frameRate As Decimal = Convert.ToDecimal(frameMarginText.Text)
        Dim frameQuality As Decimal = Convert.ToDecimal(frameQualityText.Text)
        If input.Contains("https://") Then
            Process.Start("CMD", "/K python jumpcutter.py --url " & input & " --output_file """ & output & """ --silent_threshold " & silentThreshold & " --sounded_speed " & soundedSpeed & " --silent_speed " & silentSpeed & " --frame_margin " & frameMargin & " --sample_rate " & sampleRate & " --frame_rate " & frameRate & " --frame_quality " & frameQuality)
        Else
            Process.Start("CMD", "/K python jumpcutter.py --input_file """ & input & """ --output_file """ & output & """ --silent_threshold " & silentThreshold & " --sounded_speed " & soundedSpeed & " --silent_speed " & silentSpeed & " --frame_margin " & frameMargin & " --sample_rate " & sampleRate & " --frame_rate " & frameRate & " --frame_quality " & frameQuality)
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        inputFileDialog.Title = "Please Select a File"
        inputFileDialog.InitialDirectory = "C:temp"
        'inputFileDialog.Filter = "Python File|.py"
        inputFileDialog.ShowDialog()
        inputText.Text = inputFileDialog.FileName.ToString()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Process.Start("CMD", "/C RMDIR /S /Q TEMP")
        If FileExists("jumpcutter.py") = False Then
            My.Computer.Network.DownloadFile(
            "https://raw.githubusercontent.com/carykh/jumpcutter/master/jumpcutter.py",
            "jumpcutter.py")
            Button5.Enabled = False
            Button5.Text = "Done!"
        Else
            MsgBox("jumpcutter.py is already present in root folder")
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)

    End Sub
End Class
