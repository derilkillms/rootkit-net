<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class f_utama
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(f_utama))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.WebDavToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SinggelScannerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AspShellMakerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AuthorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(323, 225)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.WebDavToolStripMenuItem, Me.AuthorToolStripMenuItem, Me.KeluarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(343, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'WebDavToolStripMenuItem
        '
        Me.WebDavToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.WeToolStripMenuItem, Me.SinggelScannerToolStripMenuItem, Me.AspShellMakerToolStripMenuItem})
        Me.WebDavToolStripMenuItem.Name = "WebDavToolStripMenuItem"
        Me.WebDavToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.WebDavToolStripMenuItem.Text = "WebDav"
        '
        'WeToolStripMenuItem
        '
        Me.WeToolStripMenuItem.Enabled = False
        Me.WeToolStripMenuItem.Name = "WeToolStripMenuItem"
        Me.WeToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.WeToolStripMenuItem.Text = "Multi Scanner"
        '
        'SinggelScannerToolStripMenuItem
        '
        Me.SinggelScannerToolStripMenuItem.Enabled = False
        Me.SinggelScannerToolStripMenuItem.Name = "SinggelScannerToolStripMenuItem"
        Me.SinggelScannerToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.SinggelScannerToolStripMenuItem.Text = "Singgel Scanner"
        '
        'AspShellMakerToolStripMenuItem
        '
        Me.AspShellMakerToolStripMenuItem.Name = "AspShellMakerToolStripMenuItem"
        Me.AspShellMakerToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.AspShellMakerToolStripMenuItem.Text = "Asp Shell Maker"
        '
        'AuthorToolStripMenuItem
        '
        Me.AuthorToolStripMenuItem.Name = "AuthorToolStripMenuItem"
        Me.AuthorToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AuthorToolStripMenuItem.Text = "About"
        '
        'KeluarToolStripMenuItem
        '
        Me.KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        Me.KeluarToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.KeluarToolStripMenuItem.Text = "Keluar"
        '
        'f_utama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(343, 241)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "f_utama"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Peluru Kertas"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents WebDavToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AuthorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SinggelScannerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AspShellMakerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
