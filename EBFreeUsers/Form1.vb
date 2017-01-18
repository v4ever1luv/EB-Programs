Imports System.IO
Imports System.Net

Public Class Form1
    Private Sub nazi_timer(sender As Object, e As EventArgs) Handles nazitimer.Tick
        If Not jew_worker.IsBusy Then
            jew_worker.RunWorkerAsync()
        End If
    End Sub

    Private Sub jew_worker_dowork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles jew_worker.DoWork
        Dim wawixsisanidiotandhavetimetowaste As New WebClient()
        wawixsisanidiotandhavetimetowaste.Encoding = System.Text.Encoding.ASCII
        wawixsisanidiotandhavetimetowaste.DownloadFile("http://elobuddy.net/", My.Application.Info.DirectoryPath & "\source.txt")
        Dim imfuckingbored As String = File.ReadAllText(My.Application.Info.DirectoryPath & "\source.txt")
        Dim naziresult As String = finddatshit(imfuckingbored, "<strong>Free users: ", "</strong>")
        If naziresult = "Enable" Then
            My.Computer.Audio.Play(My.Resources.intervention_420, AudioPlayMode.Background)
            nazitimer.Stop()
        End If
    End Sub

    Public Function finddatshit(ByRef total As String, ByVal first As String, ByVal last As String) 'wtf too much spacebar in this code i dont understand a single shit of what i did
        Dim FirstStart As Short = total.IndexOf(first) + first.Length
        Return Trim(Mid$(total, FirstStart, total.Substring(FirstStart).IndexOf(last)))
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Shown
        Hide()
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Close()
    End Sub
End Class
