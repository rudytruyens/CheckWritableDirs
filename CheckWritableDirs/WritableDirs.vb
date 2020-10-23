Imports System.IO

Public Class WritableDirs
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'created by rudy truyens
        Dim fs As System.IO.FileStream, thispath As String = ""
        Try
            TextBox2.Text = ""
            For Each ln As String In Me.TextBox1.Text.Split(vbNewLine).Distinct().ToArray
                'process unike values for the path
                ln = Trim(ln).Replace(vbLf, "")
                If ln.Length > 0 Then
                    Try
                        thispath = System.IO.Path.GetDirectoryName(ln)
                        If System.IO.Directory.Exists(thispath) Then
                            Try
                                fs = System.IO.File.Create(Path.Combine(thispath, Path.GetRandomFileName()), 1, FileOptions.DeleteOnClose)
                                TextBox2.Text = TextBox2.Text + thispath + vbCrLf
                            Catch ex As Exception
                                'not writable
                            End Try
                        End If
                    Catch pth As Exception
                        TextBox2.Text = TextBox2.Text + "There was a problem with this path: " + Chr(34) + ln + Chr(34) + vbCrLf
                    End Try
                    lblstatus.Text = "current folder: " + thispath
                    Application.DoEvents()
                End If
            Next
            MsgBox("done !")
        Catch msg As Exception
            MsgBox(msg.Message)
        End Try
    End Sub
End Class
