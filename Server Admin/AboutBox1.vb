Public NotInheritable Class AboutBox1

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("https://github.com/AlexandreRouma")
    End Sub
End Class
