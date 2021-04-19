Imports MediaInfo
Public Class jumpcutGUI
    Public Function FileExists(filename As String) As Boolean
        FileExists = Len(Dir(filename, vbNormal)) > 0
    End Function

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Process.Start("CMD", "/C RMDIR /S /Q TEMP")
        inputFileDialog.Title = "Please Select a File"
        inputFileDialog.ShowDialog()
        inputText.Text = inputFileDialog.FileName.ToString()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles inputText.TextChanged
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Process.Start("CMD", "/C RMDIR /S /Q TEMP")
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
        Process.Start("CMD", "/C RMDIR /S /Q TEMP")
        Dim input As String = inputText.Text
        Dim output As String = outputText.Text
        Dim soundedSpeed As Decimal = Convert.ToDecimal(soundedSpeedText.Text)
        Dim silentSpeed As Decimal = Convert.ToDecimal(silentSpeedText.Text)
        Dim silentThreshold As Decimal = Convert.ToDecimal(silentThresholdText.Text)
        Dim frameMargin As Decimal = Convert.ToDecimal(frameMarginText.Text)
        Dim sampleRate As Decimal = Convert.ToDecimal(sampleRateText.Text)
        Dim frameRate As Decimal = Convert.ToDecimal(frameMarginText.Text)
        Dim frameQuality As Decimal = Convert.ToDecimal(frameQualityText.Text)
        If String.IsNullOrEmpty(inputText.Text) = False Then
            If input.Contains("https://") Then
                Process.Start("cmd", "/k python jumpcutter.py --url " & input & " --output_file """ & output & """ --sounded_speed " & soundedSpeed & " --silent_speed " & silentSpeed & " --frame_margin " & frameMargin & " --frame_rate " & frameRate & " --frame_quality " & frameQuality)
            Else
                Process.Start("cmd", "/k python jumpcutter.py --input_file """ & input & """ --output_file """ & output & """ --sounded_speed " & soundedSpeed & " --silent_speed " & silentSpeed & " --frame_margin " & frameMargin & " --frame_rate " & frameRate & " --frame_quality " & frameQuality)
            End If
        Else
            MsgBox("Input textbox must be filled")
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Process.Start("CMD", "/C RMDIR /S /Q TEMP")
        inputFileDialog.Title = "Please Select a File"
        inputFileDialog.InitialDirectory = "C:temp"
        inputFileDialog.Filter = "Python File|*.py"
        inputFileDialog.ShowDialog()
        inputText.Text = inputFileDialog.FileName.ToString()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Process.Start("CMD", "/C RMDIR /S /Q TEMP")
        Dim urlPy As String
        Dim urlReq As String
        urlPy = "https://raw.githubusercontent.com/carykh/jumpcutter/master/jumpcutter.py"
        urlReq = "https://raw.githubusercontent.com/carykh/jumpcutter/master/requirements.txt"
        Process.Start("CMD", "/C RMDIR /S /Q TEMP")
        If FileExists("requirements.txt") = False Then
            My.Computer.Network.DownloadFile(
            urlReq,
            "requirements.txt")
        Else
            MsgBox("requirements.txt is already present in root folder")
        End If
        If FileExists("jumpcutter.py") = False Then
            My.Computer.Network.DownloadFile(
            urlPy,
            "jumpcutter.py")
            If FileExists("jumpcutter.py") Then
                If FileExists("requirements.txt") Then
                    Button5.Enabled = False
                    Button5.Text = "Done!"
                Else
                    MsgBox("Something went wrong and the files were not downloaded correctly")
                End If

            Else
                MsgBox("Something went wrong and the file was not downloaded correctly")
            End If

        Else
            MsgBox("jumpcutter.py is already present in root folder")
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles Button6.Click
        Process.Start("CMD", "/C RMDIR /S /Q TEMP")
        If FileExists("requirements.txt") Then
            Process.Start("CMD", "/C python -m pip install -r requirements.txt")
        Else
            MsgBox("requirements.txt is not present in root folder. Click the ""Download File"" Button to download it.")
        End If
    End Sub
End Class
