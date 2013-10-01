'
' Created by SharpDevelop.
' User: Dario
' Date: 01/09/2013
' Time: 19:29
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class MainForm
	Inherits System.Windows.Forms.Form
	
	''' <summary>
	''' Designer variable used to keep track of non-visual components.
	''' </summary>
	Private components As System.ComponentModel.IContainer
	
	''' <summary>
	''' Disposes resources used by the form.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		If disposing Then
			If components IsNot Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(disposing)
	End Sub
	
	''' <summary>
	''' This method is required for Windows Forms designer support.
	''' Do not change the method contents inside the source code editor. The Forms designer might
	''' not be able to load this method if it was changed manually.
	''' </summary>
	Private Sub InitializeComponent()
		Me.recstart = New System.Windows.Forms.Button()
		Me.recsave = New System.Windows.Forms.Button()
		Me.recupload = New System.Windows.Forms.Button()
		Me.SuspendLayout
		'
		'recstart
		'
		Me.recstart.Location = New System.Drawing.Point(11, 11)
		Me.recstart.Margin = New System.Windows.Forms.Padding(2)
		Me.recstart.Name = "recstart"
		Me.recstart.Size = New System.Drawing.Size(80, 33)
		Me.recstart.TabIndex = 0
		Me.recstart.Text = "start rec"
		Me.recstart.UseVisualStyleBackColor = true
		AddHandler Me.recstart.Click, AddressOf Me.RecStartClick
		'
		'recsave
		'
		Me.recsave.Location = New System.Drawing.Point(11, 48)
		Me.recsave.Margin = New System.Windows.Forms.Padding(2)
		Me.recsave.Name = "recsave"
		Me.recsave.Size = New System.Drawing.Size(80, 33)
		Me.recsave.TabIndex = 1
		Me.recsave.Text = "save rec"
		Me.recsave.UseVisualStyleBackColor = true
		AddHandler Me.recsave.Click, AddressOf Me.RecSaveClick
		'
		'recupload
		'
		Me.recupload.Location = New System.Drawing.Point(11, 85)
		Me.recupload.Margin = New System.Windows.Forms.Padding(2)
		Me.recupload.Name = "recupload"
		Me.recupload.Size = New System.Drawing.Size(80, 33)
		Me.recupload.TabIndex = 2
		Me.recupload.Text = "upload rec"
		Me.recupload.UseVisualStyleBackColor = true
		AddHandler Me.recupload.Click, AddressOf Me.RecUploadClick
		'
		'MainForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(157, 134)
		Me.Controls.Add(Me.recupload)
		Me.Controls.Add(Me.recsave)
		Me.Controls.Add(Me.recstart)
		Me.Margin = New System.Windows.Forms.Padding(2)
		Me.Name = "MainForm"
		Me.Text = "vmic"
		Me.ResumeLayout(false)
	End Sub
	
	Private recstart As System.Windows.Forms.Button
	Private recsave As System.Windows.Forms.Button
	Private recupload As System.Windows.Forms.Button
	
	Sub RecStartClick(sender As Object, e As EventArgs)
		RecordStart		
	End Sub
	
	Sub RecSaveClick(sender As Object, e As EventArgs)
		RecordSave		
	End Sub
	
	Sub RecUploadClick(sender As Object, e As EventArgs)
		RecordUpload		
	End Sub
End Class
