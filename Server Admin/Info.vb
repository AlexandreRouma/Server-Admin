Public Class Info
    Private Sub Info_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label12.Text = Form1.PassingComputer.Name
        Label11.Text = Form1.PassingComputer.IP
        Label10.Text = Form1.PassingComputer.MacAddress
        Label9.Text = Form1.PassingComputer.User
        Label8.Text = Form1.PassingComputer.Password
        Label7.Text = Form1.PassingComputer.WOLPort
    End Sub
End Class