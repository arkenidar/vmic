Public Partial Class MainForm
	
	Private Declare Function mciSendString Lib "winmm.dll" Alias _
		"mciSendStringA" (ByVal lpstrCommand As String, _
		ByVal lpstrReturnString As String, ByVal uReturnLength As Long, _
		ByVal hwndCallback As Long) As Long

	Public Sub RecordStart
	
		' start record
		mciSendString("open new Type waveaudio Alias recsound", "", 0, 0&)
		mciSendString("record recsound", "", 0, 0&)
		
	End Sub
	
	Public Sub RecordSave
		
		' save record
		mciSendString("save recsound user-data/path.wav", "", 0, 0&)
		mciSendString("close recsound ", "", 0, 0&)
		
		' play record
		'mciSendString("play path.wav", "", 0, 0&)
		
	End Sub
	
	Public Sub RecordUpload
		
		' encode record
		Dim startInfo As ProcessStartInfo = new ProcessStartInfo("cmd.exe", "/k auxbin\\opusenc.exe user-data/path.wav user-data/path.opus")
		startInfo.UseShellExecute = false
		startInfo.RedirectStandardError = true
		Dim someProcess As Process = Process.Start(startInfo)
		Dim errors As String = someProcess.StandardError.ReadToEnd()
		
		' upload record
		Using wc As New System.Net.WebClient()
			wc.UploadFile("http://localhost:8081/html/upload-play/upload.php", "user-data/path.opus")
		End Using
		
	End Sub
	
	Public Sub New()
		
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
	End Sub
	
End Class
