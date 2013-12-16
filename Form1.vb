Imports System
Imports System.IO
Imports System.Security.Cryptography
Imports System.Windows.Forms
Imports System.Text
Public Class Form1

    Private Sub Form1_DragEnter(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles Me.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub
    Private Sub Form1_DragDrop(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles Me.DragDrop
        Dim theFiles() As String = CType(e.Data.GetData("FileDrop", True), String())
        For Each theFile As String In theFiles
            TextBox1.Text = theFile
        Next
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim ofd As New OpenFileDialog
        Dim dr As DialogResult = ofd.ShowDialog()
        If dr = DialogResult.OK Then
            TextBox1.Text = ofd.FileName
        End If

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox2.Text = "Working, please wait..."
        Me.UseWaitCursor = True
        Me.Enabled = False
        Dim mySHA256 As SHA256 = SHA256Managed.Create()
        Dim hashValue() As Byte
        Try
            Dim fileStream As FileStream = File.Open(TextBox1.Text, FileMode.Open)
            Dim sbuilder As New StringBuilder
            fileStream.Position = 0
            hashValue = mySHA256.ComputeHash(fileStream)
            fileStream.Close()
            TextBox2.Text = BitConverter.ToString(hashValue).Replace("-", String.Empty).ToLower()
            Me.Enabled = True
            Me.UseWaitCursor = False
        Catch ex As Exception
            Me.Enabled = True
            MsgBox("Invalid filename or file already open in another process")
            TextBox2.Text = ""
            Me.UseWaitCursor = False
        End Try
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If TextBox3.Text = "" Then
            Label4.Text = "Please paste checksum to compare"
        ElseIf TextBox2.Text = TextBox3.Text Then
            Label4.Text = "Checksums Match"
        Else
            Label4.Text = "Checksums do not match"
        End If
    End Sub


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        TextBox2.Text = ""
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
