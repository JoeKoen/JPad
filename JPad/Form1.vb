Imports System
Imports System.IO
Imports System.Security
Imports System.Security.Cryptography
Imports System.Runtime.InteropServices
Imports System.Text
Public Class Form1
    Dim SaveAs As New SaveFileDialog

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Debugger.Log(1, "SaveAs Dialog", "Updating settings passed." & vbNewLine)
            SaveAs.Title = "Save File As..."
            SaveAs.Filter = ".jpad | JPad File"
            SaveAs.AddExtension = True
        Catch ex As Exception
            Debugger.Log(1, "SaveAs Dialog", "Updating settings failed." & vbNewLine)
        End Try
    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        Try
            Debugger.Log(1, "RichTextBox1", "Success New File" & vbNewLine)
            RichTextBox1.Clear()
        Catch ex As Exception
            Debugger.Log(1, "RichTextBox1", "Error" & vbNewLine)
        End Try
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        Try
            SaveAs.ShowDialog()
            Debugger.Log(1, "SaveAs", "Show Dialog passed!" & vbNewLine)
        Catch ex As Exception
            Debugger.Log(1, "SaveAs", "Show Dialog failed!" & vbNewLine)
        End Try
        Try
            RichTextBox1.SaveFile(SaveAs.FileName + ".jpad")
            Debugger.Log(1, "SaveAs", "Save as a file passed!" & vbNewLine)
            Debugger.Log(1, "SaveAs", "Save Location: " & SaveAs.FileName + ".jpad" & vbNewLine)
        Catch ex As Exception
            Debugger.Log(1, "SaveAs", "Save as a file failed!" & vbNewLine)

        End Try
        Try
            Me.Text = "JPad - The Secret Notepad for Writers " + SaveAs.FileName + ".jpad"
            Debugger.Log(1, "SaveAs", "Title Update Passed!" & vbNewLine)
        Catch ex As Exception
            Debugger.Log(1, "SaveAs", "Title Update Failed!" & vbNewLine)
        End Try

    End Sub
End Class
