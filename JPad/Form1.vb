Imports System
Imports System.IO
Imports System.Security
Imports System.Security.Cryptography
Imports System.Runtime.InteropServices
Imports System.Text
Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        Try
            Debugger.Log(1, "RichTextBox1", "Success New File")
            RichTextBox1.Clear()
        Catch ex As Exception
            Debugger.Log(1, "RichTextBox1", "Error")
        End Try
    End Sub
End Class
