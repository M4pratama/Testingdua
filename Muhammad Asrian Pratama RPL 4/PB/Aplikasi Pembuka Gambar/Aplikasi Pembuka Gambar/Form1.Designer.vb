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
        Me.ofdbuka = New System.Windows.Forms.OpenFileDialog()
        Me.Pcbgambar = New System.Windows.Forms.PictureBox()
        Me.Btnexit = New System.Windows.Forms.Button()
        Me.Btnbuka = New System.Windows.Forms.Button()
        CType(Me.Pcbgambar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ofdbuka
        '
        Me.ofdbuka.FileName = "OpenFileDialog1"
        '
        'Pcbgambar
        '
        Me.Pcbgambar.Location = New System.Drawing.Point(12, 12)
        Me.Pcbgambar.Name = "Pcbgambar"
        Me.Pcbgambar.Size = New System.Drawing.Size(642, 374)
        Me.Pcbgambar.TabIndex = 0
        Me.Pcbgambar.TabStop = False
        '
        'Btnexit
        '
        Me.Btnexit.Location = New System.Drawing.Point(589, 393)
        Me.Btnexit.Name = "Btnexit"
        Me.Btnexit.Size = New System.Drawing.Size(75, 23)
        Me.Btnexit.TabIndex = 1
        Me.Btnexit.Text = "Exit"
        Me.Btnexit.UseVisualStyleBackColor = True
        '
        'Btnbuka
        '
        Me.Btnbuka.Location = New System.Drawing.Point(497, 393)
        Me.Btnbuka.Name = "Btnbuka"
        Me.Btnbuka.Size = New System.Drawing.Size(75, 23)
        Me.Btnbuka.TabIndex = 2
        Me.Btnbuka.Text = "Buka"
        Me.Btnbuka.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(676, 428)
        Me.Controls.Add(Me.Btnbuka)
        Me.Controls.Add(Me.Btnexit)
        Me.Controls.Add(Me.Pcbgambar)
        Me.Name = "Form1"
        Me.Text = "APLIKASI PEMBUKA GAMBAR"
        CType(Me.Pcbgambar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ofdbuka As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Pcbgambar As System.Windows.Forms.PictureBox
    Friend WithEvents Btnexit As System.Windows.Forms.Button
    Friend WithEvents Btnbuka As System.Windows.Forms.Button

End Class
