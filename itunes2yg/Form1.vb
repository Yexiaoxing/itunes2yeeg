Public Class Form1

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Panel1.Show()
        Panel2.Hide()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim file As New OpenFileDialog
        file.Title = "请选择导出的xml文件"
        file.CheckFileExists = True
        If file.ShowDialog = Windows.Forms.DialogResult.OK Then
            TextBox1.Text = file.FileName
        End If
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim fileExists As Boolean
        fileExists = My.Computer.FileSystem.FileExists(TextBox1.Text)
        If fileExists Then
            Dim ab As New a(TextBox1.Text)
            ab.Show()
            Me.Close()
        Else
            MsgBox("文件不存在！")
        End If
    End Sub
End Class
