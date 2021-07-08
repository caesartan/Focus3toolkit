Class MainWindow
    Private Sub Button1_Click(sender As Object, e As RoutedEventArgs) Handles Button1.Click
        Dim p As New Process
        p.StartInfo.FileName = "adb.exe"
        p.StartInfo.Arguments = "pull /sdcard/Pictures/Screenshots/"
        p.StartInfo.UseShellExecute = False
        p.StartInfo.CreateNoWindow = True
        p.Start()
    End Sub
    Private Sub Button2_Click(sender As Object, e As RoutedEventArgs) Handles Button2.Click
        Dim p As New Process
        p.StartInfo.FileName = "adb.exe"
        p.StartInfo.Arguments = "pull /sdcard/Movies/Screenrecorder/"
        p.StartInfo.UseShellExecute = False
        p.StartInfo.CreateNoWindow = True
        p.Start()

    End Sub

End Class
