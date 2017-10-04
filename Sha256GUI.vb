Imports System.ComponentModel
Imports System.IO
Imports System.Security.Cryptography
Imports System.Text
Public Class Sha256Form

    Private Sub Sha256Form_DragEnter(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles Me.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub
    Private Sub Sha256Form_DragDrop(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles Me.DragDrop
        Dim theFiles() As String = CType(e.Data.GetData("FileDrop", True), String())
        For Each theFile As String In theFiles
            txtbox_FileSelect.Text = theFile
        Next
    End Sub
    Private Sub button_Browse_Click(sender As Object, e As EventArgs) Handles button_Browse.Click

        Dim ofd As New OpenFileDialog
        Dim dr As DialogResult = ofd.ShowDialog()
        If dr = DialogResult.OK Then
            txtbox_FileSelect.Text = ofd.FileName
        End If
        ComputeHash()
    End Sub

    Private Sub ComputeHash()
        Dim SHA256 As SHA256 = SHA256Managed.Create()
        Dim hashValue() As Byte
        Try
            Dim fileStream As FileStream = File.Open(txtbox_FileSelect.Text, FileMode.Open)
            Dim sbuilder As New StringBuilder
            fileStream.Position = 0
            hashValue = SHA256.ComputeHash(fileStream)
            fileStream.Close()
            txtbox_ComputedHash.Text = BitConverter.ToString(hashValue).Replace("-", String.Empty).ToLower()
            Me.Enabled = True
            Me.UseWaitCursor = False
        Catch ex As Exception
            Me.Enabled = True
            MsgBox("File Open error: " + ex.Message)
            txtbox_ComputedHash.Text = ""
            Me.UseWaitCursor = False
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If txtbox_CompareHash.Text = "" Then
            Label4.Text = "Please paste checksum to compare"
        ElseIf txtbox_ComputedHash.Text = txtbox_CompareHash.Text Then
            Label4.Text = "Checksums Match"
        Else
            Label4.Text = "Checksums do not match"
        End If
    End Sub


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtbox_FileSelect.TextChanged
        txtbox_ComputedHash.Text = ""
    End Sub

End Class
