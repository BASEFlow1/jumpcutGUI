<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class jumpcutGUI
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(jumpcutGUI))
        Me.attribLabel = New System.Windows.Forms.Label()
        Me.inputFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.inputText = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.outputText = New System.Windows.Forms.TextBox()
        Me.outputFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.soundedSpeedText = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.silentSpeedText = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.silentThresholdText = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.frameMarginText = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.sampleRateText = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.frameRateText = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.frameQualityText = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.cutterLocationText = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'attribLabel
        '
        Me.attribLabel.Location = New System.Drawing.Point(-9, 391)
        Me.attribLabel.Name = "attribLabel"
        Me.attribLabel.Size = New System.Drawing.Size(606, 23)
        Me.attribLabel.TabIndex = 0
        Me.attribLabel.Text = "Icon made by Freepik from www.flaticon.com"
        Me.attribLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'inputFileDialog
        '
        Me.inputFileDialog.Title = "inputFileDialog"
        '
        'inputText
        '
        Me.inputText.Location = New System.Drawing.Point(115, 55)
        Me.inputText.Name = "inputText"
        Me.inputText.Size = New System.Drawing.Size(330, 23)
        Me.inputText.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(451, 55)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(108, 24)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Select File"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(-9, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 23)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Input File"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(-9, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 23)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Output File"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(451, 84)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(108, 24)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Select File"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'outputText
        '
        Me.outputText.Location = New System.Drawing.Point(115, 84)
        Me.outputText.Name = "outputText"
        Me.outputText.Size = New System.Drawing.Size(330, 23)
        Me.outputText.TabIndex = 4
        '
        'outputFileDialog
        '
        Me.outputFileDialog.Title = "outputFileDialog"
        '
        'soundedSpeedText
        '
        Me.soundedSpeedText.Location = New System.Drawing.Point(133, 114)
        Me.soundedSpeedText.Name = "soundedSpeedText"
        Me.soundedSpeedText.Size = New System.Drawing.Size(312, 23)
        Me.soundedSpeedText.TabIndex = 7
        Me.soundedSpeedText.Text = "1"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(-9, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 23)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Sounded Speed"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'silentSpeedText
        '
        Me.silentSpeedText.Location = New System.Drawing.Point(133, 143)
        Me.silentSpeedText.Name = "silentSpeedText"
        Me.silentSpeedText.Size = New System.Drawing.Size(312, 23)
        Me.silentSpeedText.TabIndex = 9
        Me.silentSpeedText.Text = "5"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(-9, 144)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(136, 23)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Silent Speed"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'silentThresholdText
        '
        Me.silentThresholdText.Location = New System.Drawing.Point(133, 172)
        Me.silentThresholdText.Name = "silentThresholdText"
        Me.silentThresholdText.Size = New System.Drawing.Size(312, 23)
        Me.silentThresholdText.TabIndex = 11
        Me.silentThresholdText.Text = "0.03"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(-9, 173)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(136, 23)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Silent Threshold"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frameMarginText
        '
        Me.frameMarginText.Location = New System.Drawing.Point(133, 201)
        Me.frameMarginText.Name = "frameMarginText"
        Me.frameMarginText.Size = New System.Drawing.Size(312, 23)
        Me.frameMarginText.TabIndex = 13
        Me.frameMarginText.Text = "1"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(-9, 202)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(136, 23)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Frame Margin"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'sampleRateText
        '
        Me.sampleRateText.Enabled = False
        Me.sampleRateText.Location = New System.Drawing.Point(133, 230)
        Me.sampleRateText.Name = "sampleRateText"
        Me.sampleRateText.Size = New System.Drawing.Size(312, 23)
        Me.sampleRateText.TabIndex = 15
        Me.sampleRateText.Text = "44100"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(-9, 231)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(136, 23)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Sample Rate"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frameRateText
        '
        Me.frameRateText.Location = New System.Drawing.Point(133, 259)
        Me.frameRateText.Name = "frameRateText"
        Me.frameRateText.Size = New System.Drawing.Size(312, 23)
        Me.frameRateText.TabIndex = 17
        Me.frameRateText.Text = "30"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(-9, 260)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(136, 23)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Framerate"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frameQualityText
        '
        Me.frameQualityText.Location = New System.Drawing.Point(133, 288)
        Me.frameQualityText.Name = "frameQualityText"
        Me.frameQualityText.Size = New System.Drawing.Size(312, 23)
        Me.frameQualityText.TabIndex = 19
        Me.frameQualityText.Text = "3"
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(-9, 289)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(136, 23)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Frame Quality"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(186, 365)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(212, 23)
        Me.Button3.TabIndex = 21
        Me.Button3.Text = "Submit"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'cutterLocationText
        '
        Me.cutterLocationText.Location = New System.Drawing.Point(115, 26)
        Me.cutterLocationText.Name = "cutterLocationText"
        Me.cutterLocationText.Size = New System.Drawing.Size(283, 23)
        Me.cutterLocationText.TabIndex = 22
        Me.cutterLocationText.Text = ".\jumpcutter.py"
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(-9, 20)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(120, 36)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "jumpcutter.py Location"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(502, 26)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(73, 24)
        Me.Button4.TabIndex = 23
        Me.Button4.Text = "Select File"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(404, 27)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(92, 23)
        Me.Button5.TabIndex = 25
        Me.Button5.Text = "Download File"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(12, 350)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(99, 38)
        Me.Button6.TabIndex = 26
        Me.Button6.Text = "Install Python Dependencies"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'jumpcutGUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(587, 412)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.cutterLocationText)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.frameQualityText)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.frameRateText)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.sampleRateText)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.frameMarginText)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.silentThresholdText)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.silentSpeedText)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.soundedSpeedText)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.inputText)
        Me.Controls.Add(Me.outputText)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.attribLabel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "jumpcutGUI"
        Me.Text = "jumpcutGUI"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents attribLabel As Label
    Friend WithEvents inputFileDialog As OpenFileDialog
    Friend WithEvents inputText As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents outputText As TextBox
    Friend WithEvents outputFileDialog As SaveFileDialog
    Friend WithEvents soundedSpeedText As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents silentSpeedText As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents silentThresholdText As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents frameMarginText As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents sampleRateText As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents frameRateText As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents frameQualityText As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents cutterLocationText As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
End Class
