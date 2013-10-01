'
' Created by SharpDevelop.
' User: Dario
' Date: 10/09/2013
' Time: 02:37
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Public Partial Class MainForm
	
	Private Declare Function mciSendString Lib "winmm.dll" Alias _
	"mciSendStringA" (ByVal lpstrCommand As String, _
	ByVal lpstrReturnString As String, ByVal uReturnLength As Long, _
	ByVal hwndCallback As Long) As Long
	
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		'
		' TODO : Add constructor code after InitializeComponents
		'
	End Sub
	
	Public Sub DownloadOpusFile()
		
		Using wc As New System.Net.WebClient()
			wc.DownloadFile("http://localhost:8081/html/upload-play/path.opus", "user-data\\path.opus")
		End Using
		
	End Sub
	
	Sub DecodeOpusFile
		
		Dim startInfo As ProcessStartInfo = new ProcessStartInfo("cmd.exe", "/c erase user-data\\path.wav && opusdec.exe user-data\\path.opus user-data\\path.wav")
		startInfo.UseShellExecute = false
		startInfo.RedirectStandardError = true
		Dim someProcess As Process = Process.Start(startInfo)
		Dim errors As String = someProcess.StandardError.ReadToEnd()
		
		'MsgBox(errors)
		'someProcess.WaitForExit()
		
		'		Dim dec as Process = new Process()
		'        Dim dpi as ProcessStartInfo = new ProcessStartInfo() 
		'        dpi.FileName = "opusdec.exe"
		'        dpi.Arguments = "path.opus path.wav"
		'        dec.StartInfo = dpi 
		'        dec.Start()
	End Sub
	
	Sub Button1Click(sender As Object, e As EventArgs)
		
		DownloadOpusFile
		
		DecodeOpusFile
        
        mciSendString("play user-data\\path.wav", "", 0, 0&)
        
	End Sub
End Class
