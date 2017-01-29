Imports System.Windows.Forms

Public Class Dialog2

    Dim InitFile As String = ""

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        My.Computer.FileSystem.DeleteFile(InitFile)
        My.Computer.FileSystem.WriteAllText(Form1.AppPath & "Computers\" & TextBox1.Text & ".txt", TextBox1.Text & ChrW(13) & TextBox2.Text & ChrW(13) & TextBox3.Text & ChrW(13) & TextBox4.Text & ChrW(13) & TextBox5.Text & ChrW(13) & TextBox6.Text, False)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        ack()
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged
        ack()
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        ack()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        ack()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        ack()
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        ack()
    End Sub

    Sub ack()
        If TextBox1.Text.Length > 0 And TextBox2.Text.Length > 0 And TextBox3.Text.Length > 0 And TextBox4.Text.Length > 0 And TextBox5.Text.Length > 0 And TextBox6.Text.Length > 0 Then
            OK_Button.Enabled = True
        Else
            OK_Button.Enabled = False
        End If
    End Sub

    Private Sub Dialog2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitFile = Form1.AppPath & "Computers\" & TextBox1.Text & ".txt"
    End Sub
End Class
