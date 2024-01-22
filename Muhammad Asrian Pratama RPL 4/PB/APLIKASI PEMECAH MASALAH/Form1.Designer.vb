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
        Me.Txtangka = New System.Windows.Forms.TextBox()
        Me.Btnproses = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Txtangka
        '
        Me.Txtangka.Location = New System.Drawing.Point(137, 152)
        Me.Txtangka.Name = "Txtangka"
        Me.Txtangka.Size = New System.Drawing.Size(236, 20)
        Me.Txtangka.TabIndex = 0
        '
        'Btnproses
        '
        Me.Btnproses.Location = New System.Drawing.Point(342, 249)
        Me.Btnproses.Name = "Btnproses"
        Me.Btnproses.Size = New System.Drawing.Size(75, 23)
        Me.Btnproses.TabIndex = 1
        Me.Btnproses.Text = "PROSES"
        Me.Btnproses.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(503, 312)
        Me.Controls.Add(Me.Btnproses)
        Me.Controls.Add(Me.Txtangka)
        Me.Name = "Form1"
        Me.Text = "PENANGANAN MASALAH"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Txtangka As System.Windows.Forms.TextBox
    Friend WithEvents Btnproses As System.Windows.Forms.Button

End Class
