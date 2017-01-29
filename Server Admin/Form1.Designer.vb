<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ComputerMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.PowerUPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShutdownToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RebootToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SSHToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExploreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HTTPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.MenuItem3 = New System.Windows.Forms.MenuItem()
        Me.MenuItem7 = New System.Windows.Forms.MenuItem()
        Me.MenuItem4 = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.MenuItem5 = New System.Windows.Forms.MenuItem()
        Me.MenuItem6 = New System.Windows.Forms.MenuItem()
        Me.ListViewMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.NewComputerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComputerMenu.SuspendLayout()
        Me.ListViewMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListView1.Location = New System.Drawing.Point(0, 0)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(589, 383)
        Me.ListView1.TabIndex = 1
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'ComputerMenu
        '
        Me.ComputerMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PowerUPToolStripMenuItem, Me.ShutdownToolStripMenuItem, Me.RebootToolStripMenuItem, Me.SSHToolStripMenuItem, Me.ExploreToolStripMenuItem, Me.HTTPToolStripMenuItem, Me.EditToolStripMenuItem, Me.DeleteToolStripMenuItem, Me.InfoToolStripMenuItem})
        Me.ComputerMenu.Name = "ComputerMenu"
        Me.ComputerMenu.Size = New System.Drawing.Size(129, 202)
        '
        'PowerUPToolStripMenuItem
        '
        Me.PowerUPToolStripMenuItem.Name = "PowerUPToolStripMenuItem"
        Me.PowerUPToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.PowerUPToolStripMenuItem.Text = "Power UP"
        '
        'ShutdownToolStripMenuItem
        '
        Me.ShutdownToolStripMenuItem.Name = "ShutdownToolStripMenuItem"
        Me.ShutdownToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.ShutdownToolStripMenuItem.Text = "Shutdown"
        '
        'RebootToolStripMenuItem
        '
        Me.RebootToolStripMenuItem.Name = "RebootToolStripMenuItem"
        Me.RebootToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.RebootToolStripMenuItem.Text = "Reboot"
        '
        'SSHToolStripMenuItem
        '
        Me.SSHToolStripMenuItem.Name = "SSHToolStripMenuItem"
        Me.SSHToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.SSHToolStripMenuItem.Text = "SSH"
        '
        'ExploreToolStripMenuItem
        '
        Me.ExploreToolStripMenuItem.Name = "ExploreToolStripMenuItem"
        Me.ExploreToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.ExploreToolStripMenuItem.Text = "Explore"
        '
        'HTTPToolStripMenuItem
        '
        Me.HTTPToolStripMenuItem.Name = "HTTPToolStripMenuItem"
        Me.HTTPToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.HTTPToolStripMenuItem.Text = "HTTP"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'InfoToolStripMenuItem
        '
        Me.InfoToolStripMenuItem.Name = "InfoToolStripMenuItem"
        Me.InfoToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.InfoToolStripMenuItem.Text = "Info"
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem2})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem3, Me.MenuItem7, Me.MenuItem4})
        Me.MenuItem1.Text = "File"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 0
        Me.MenuItem3.Text = "New Computer"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 1
        Me.MenuItem7.Text = "Reload Computers"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 2
        Me.MenuItem4.Text = "Quit"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 1
        Me.MenuItem2.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem5, Me.MenuItem6})
        Me.MenuItem2.Text = "Help"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 0
        Me.MenuItem5.Text = "My Github Page"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 1
        Me.MenuItem6.Text = "About"
        '
        'ListViewMenu
        '
        Me.ListViewMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewComputerToolStripMenuItem})
        Me.ListViewMenu.Name = "ListViewMenu"
        Me.ListViewMenu.Size = New System.Drawing.Size(156, 26)
        '
        'NewComputerToolStripMenuItem
        '
        Me.NewComputerToolStripMenuItem.Name = "NewComputerToolStripMenuItem"
        Me.NewComputerToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.NewComputerToolStripMenuItem.Text = "New Computer"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(589, 383)
        Me.Controls.Add(Me.ListView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Menu = Me.MainMenu1
        Me.Name = "Form1"
        Me.Text = "Server Admin"
        Me.ComputerMenu.ResumeLayout(False)
        Me.ListViewMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ComputerMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents PowerUPToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShutdownToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RebootToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents ListViewMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents NewComputerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SSHToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExploreToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HTTPToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InfoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
