Imports System.Net.Sockets
Imports System.Globalization
Imports System.Net
Imports Renci.SshNet
Imports System.Threading
Imports System.IO

Public Class Form1

    Dim _Refresh As New Thread(AddressOf Ref)
    Public AppPath As String = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().CodeBase).Replace("file:\", "") & "\"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False
        init()
        LoadComputers()
    End Sub

    Sub LoadComputers()
        ListView1.Items.Clear()
        ListView1.BeginUpdate()
        Try
            For Each File In My.Computer.FileSystem.GetFiles(AppPath & "Computers")
                Dim reader As New StreamReader(File)
                AddComputerToList(New Computer(reader.ReadLine, reader.ReadLine, reader.ReadLine, reader.ReadLine, reader.ReadLine, reader.ReadLine))
                reader.Close()
            Next
        Catch ex As Exception

        End Try
        ListView1.EndUpdate()
    End Sub

    Sub AddComputerToList(ByVal comp As Computer)
        Dim item As New ListViewItem(comp.Name)
        item.Tag = comp
        item.ImageIndex = 0
        ListView1.Items.Add(item)
    End Sub

    Private Sub listView1_MouseClick(sender As Object, e As MouseEventArgs) Handles ListView1.MouseClick
        If e.Button = MouseButtons.Right Then
            If ListView1.FocusedItem.Bounds.Contains(e.Location) = True Then
                ComputerMenu.Show(Cursor.Position)
            End If
        End If
    End Sub

    Sub init()
        Dim list As New ImageList()
        list.ImageSize = New Size(64, 64)
        list.ColorDepth = ColorDepth.Depth32Bit
        list.Images.Add(New Bitmap(AppPath & "computeroff.png"))
        list.Images.Add(New Bitmap(AppPath & "computeron.png"))
        ListView1.View = View.LargeIcon
        ListView1.LargeImageList = list
        _Refresh.Start()
    End Sub

    Sub Ref()
        While True
            For Each Item In ListView1.Items
                Try
                    If Item.Tag.IsAlive Then
                        Item.ImageIndex = 1
                    Else
                        Item.ImageIndex = 0
                    End If
                Catch ex As Exception

                End Try
            Next
            Thread.Sleep(1000)
        End While
    End Sub

    Private Sub PowerUPToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PowerUPToolStripMenuItem.Click
        For Each SC In ListView1.SelectedItems
            SC.Tag.PowerUP()
        Next
    End Sub

    Private Sub ShutdownToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShutdownToolStripMenuItem.Click
        For Each SC In ListView1.SelectedItems
            SC.Tag.SSHShutdown()
        Next
    End Sub

    Private Sub RebootToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RebootToolStripMenuItem.Click
        For Each SC In ListView1.SelectedItems
            SC.Tag.SSHReboot()
        Next
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        _Refresh.Abort()
    End Sub

    Private Sub MenuItem3_Click(sender As Object, e As EventArgs) Handles MenuItem3.Click
        Dim r As DialogResult = Dialog1.ShowDialog
        If r = Windows.Forms.DialogResult.OK Then
            LoadComputers()
        End If
    End Sub

    Private Sub MenuItem4_Click(sender As Object, e As EventArgs) Handles MenuItem4.Click
        End
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        If ListView1.SelectedItems.Count = 1 Then
            If MessageBox.Show("Are you sure you want to delete this computer ?", "Are you sure ?", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) = Windows.Forms.DialogResult.Yes Then
                DeleteSelectedComputers()
            End If
        Else
            If MessageBox.Show("Are you sure you want to delete " & ListView1.SelectedItems.Count & " computers ?", "Are you sure ?", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) = Windows.Forms.DialogResult.Yes Then
                DeleteSelectedComputers()
            End If
        End If
    End Sub

    Sub DeleteSelectedComputers()
        For Each SC In ListView1.SelectedItems
            Try
                My.Computer.FileSystem.DeleteFile(AppPath & "Computers\" & SC.Tag.Name & ".txt")
            Catch ex As Exception

            End Try
            LoadComputers()
        Next
    End Sub

    Private Sub MenuItem7_Click(sender As Object, e As EventArgs) Handles MenuItem7.Click
        LoadComputers()
    End Sub

    Private Sub ListView1_MouseUp(sender As Object, e As MouseEventArgs) Handles ListView1.MouseUp
        If e.Button = MouseButtons.Right And ListView1.SelectedItems.Count = 0 Then
            ListViewMenu.Show(Cursor.Position)
        End If
    End Sub

    Private Sub NewComputerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewComputerToolStripMenuItem.Click
        Dim r As DialogResult = Dialog1.ShowDialog
        If r = Windows.Forms.DialogResult.OK Then
            LoadComputers()
        End If
    End Sub

    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click
        For Each Item In ListView1.SelectedItems
            Dialog2.TextBox1.Text = Item.Tag.Name
            Dialog2.TextBox2.Text = Item.Tag.IP
            Dialog2.TextBox3.Text = Item.Tag.MacAddress
            Dialog2.TextBox4.Text = Item.Tag.User
            Dialog2.TextBox5.Text = Item.Tag.Password
            Dialog2.TextBox6.Text = Item.Tag.WOLPort
            Dim r As DialogResult = Dialog2.ShowDialog
            If r = Windows.Forms.DialogResult.OK Then
                LoadComputers()
            End If
        Next
    End Sub

    Private Sub SSHToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SSHToolStripMenuItem.Click
        For Each SC In ListView1.SelectedItems
            Diagnostics.Process.Start(AppPath & "putty.exe", "-ssh " & SC.Tag.IP & " -l " & SC.Tag.User & " -pw " & SC.Tag.Password)
            'Shell("putty.exe -ssh " & SC.IP & " -l " & SC.User & " -pw " & SC.Password, AppWinStyle.NormalFocus)
        Next
    End Sub

    Private Sub MenuItem8_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ExploreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExploreToolStripMenuItem.Click
        For Each Item In ListView1.SelectedItems
            Process.Start("\\" & Item.Tag.IP & "\")
        Next
    End Sub

    Private Sub HTTPToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HTTPToolStripMenuItem.Click
        For Each Item In ListView1.SelectedItems
            Process.Start("http://" & Item.Tag.IP)
        Next
    End Sub

    Private Sub MenuItem5_Click(sender As Object, e As EventArgs) Handles MenuItem5.Click
        Process.Start("https://github.com/AlexandreRouma")
    End Sub

    Private Sub MenuItem6_Click(sender As Object, e As EventArgs) Handles MenuItem6.Click
        AboutBox1.ShowDialog()
    End Sub
    Public PassingComputer As Computer
    Private Sub InfoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InfoToolStripMenuItem.Click
        For Each Item In ListView1.SelectedItems
            Dim InfoForm As New Info
            PassingComputer = Item.Tag
            InfoForm.Show()
            While InfoForm.Created = False

            End While
        Next
    End Sub
End Class

Public Class Computer
    Public Name As String = ""
    Public IP As String = "000.000.000.000"
    Public MacAddress As String = "00:00:00:00:00:00"
    Public User As String = ""
    Public Password As String = ""
    Public WOLPort As Integer = 9

    Public Sub New(ByVal _name As String, ByVal _ip As String, ByVal _mac As String, ByVal _user As String, ByVal _password As String, ByVal _wolport As Integer)
        Name = _name
        IP = _ip
        MacAddress = _mac
        User = _user
        Password = _password
        WOLPort = _wolport
    End Sub

    Public Function IsAlive()
        Try
            Return My.Computer.Network.Ping(IP, 250)
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Sub PowerUP()
        NetUtils.WakeOnLan(MacAddress)
    End Sub

    Public Function SSHShutdown()
        Return NetUtils.SSHShutdown(IP, User, Password)
    End Function

    Public Function SSHReboot()
        Return NetUtils.SSHReboot(IP, User, Password)
    End Function
End Class

Class NetUtils
    Public Shared Sub WakeOnLan(ByVal MacAddress As String, Optional ByVal BroadCast As String = "192.168.1.255")
        MacAddress = MacAddress.Replace(":", "")
        MacAddress = MacAddress.Replace("-", "")
        Dim udp As New UdpClient With {.EnableBroadcast = True}
        Try
            udp.Client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Broadcast, 1)
            Dim offset As Integer = 0
            Dim buf(512) As Byte

            'les 6 premiers bytes sont &HFF
            For i As Integer = 0 To 5
                buf(offset) = &HFF
                offset += 1
            Next

            'on repete l'addresse MAC 16 fois
            For i As Integer = 0 To 15
                Dim n As Integer = 0
                For j As Integer = 0 To 5
                    buf(offset) = Byte.Parse(MacAddress.Substring(n, 2), NumberStyles.HexNumber)
                    offset += 1
                    n += 2
                Next
            Next

            'on envoie le wol
            udp.Send(buf, 512, New IPEndPoint(IPAddress.Parse(BroadCast), &H1))

        Catch ex As Exception
            udp.Close()
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Shared Function SSHShutdown(ByVal IP As String, ByVal User As String, ByVal Password As String)
        Dim Client As New SshClient(IP, User, Password)
        Try
            Client.Connect()
            Client.RunCommand("shutdown now")
            Client.Disconnect()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Shared Function SSHReboot(ByVal IP As String, ByVal User As String, ByVal Password As String)
        Dim Client As New SshClient(IP, User, Password)
        Try
            Client.Connect()
            Client.RunCommand("shutdown -r now")
            Client.Disconnect()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
End Class
