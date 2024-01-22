<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OperasiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HitungVolumeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HitungTinggiKerucutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        resources.ApplyResources(Me.MenuStrip1, "MenuStrip1")
        Me.MenuStrip1.BackColor = System.Drawing.Color.DimGray
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OperasiToolStripMenuItem, Me.ToolStripMenuItem1, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Name = "MenuStrip1"
        '
        'OperasiToolStripMenuItem
        '
        resources.ApplyResources(Me.OperasiToolStripMenuItem, "OperasiToolStripMenuItem")
        Me.OperasiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HitungVolumeToolStripMenuItem, Me.HitungTinggiKerucutToolStripMenuItem})
        Me.OperasiToolStripMenuItem.Name = "OperasiToolStripMenuItem"
        '
        'HitungVolumeToolStripMenuItem
        '
        resources.ApplyResources(Me.HitungVolumeToolStripMenuItem, "HitungVolumeToolStripMenuItem")
        Me.HitungVolumeToolStripMenuItem.Name = "HitungVolumeToolStripMenuItem"
        '
        'HitungTinggiKerucutToolStripMenuItem
        '
        resources.ApplyResources(Me.HitungTinggiKerucutToolStripMenuItem, "HitungTinggiKerucutToolStripMenuItem")
        Me.HitungTinggiKerucutToolStripMenuItem.Name = "HitungTinggiKerucutToolStripMenuItem"
        '
        'ToolStripMenuItem1
        '
        resources.ApplyResources(Me.ToolStripMenuItem1, "ToolStripMenuItem1")
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        '
        'ExitToolStripMenuItem
        '
        resources.ApplyResources(Me.ExitToolStripMenuItem, "ExitToolStripMenuItem")
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        '
        'Form1
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.Aplikasi_Belajar_Matematika
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents OperasiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HitungVolumeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HitungTinggiKerucutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
