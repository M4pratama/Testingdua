<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tinggi
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ButtonHitungTinggi = New System.Windows.Forms.Button()
        Me.TextBoxVolume = New System.Windows.Forms.TextBox()
        Me.TextBoxJariJari = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxHasil = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(59, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Volume"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(54, 148)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Jari-Jari"
        '
        'ButtonHitungTinggi
        '
        Me.ButtonHitungTinggi.Location = New System.Drawing.Point(59, 275)
        Me.ButtonHitungTinggi.Name = "ButtonHitungTinggi"
        Me.ButtonHitungTinggi.Size = New System.Drawing.Size(75, 23)
        Me.ButtonHitungTinggi.TabIndex = 2
        Me.ButtonHitungTinggi.Text = "Proses"
        Me.ButtonHitungTinggi.UseVisualStyleBackColor = True
        '
        'TextBoxVolume
        '
        Me.TextBoxVolume.Location = New System.Drawing.Point(149, 98)
        Me.TextBoxVolume.Name = "TextBoxVolume"
        Me.TextBoxVolume.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxVolume.TabIndex = 3
        '
        'TextBoxJariJari
        '
        Me.TextBoxJariJari.Location = New System.Drawing.Point(149, 148)
        Me.TextBoxJariJari.Name = "TextBoxJariJari"
        Me.TextBoxJariJari.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxJariJari.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(234, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 31)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Tinggi"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(74, 190)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 25)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Hasil"
        '
        'TextBoxHasil
        '
        Me.TextBoxHasil.Location = New System.Drawing.Point(149, 190)
        Me.TextBoxHasil.Name = "TextBoxHasil"
        Me.TextBoxHasil.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxHasil.TabIndex = 7
        '
        'Tinggi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(599, 368)
        Me.Controls.Add(Me.TextBoxHasil)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBoxJariJari)
        Me.Controls.Add(Me.TextBoxVolume)
        Me.Controls.Add(Me.ButtonHitungTinggi)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Tinggi"
        Me.Text = "Tinggi"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ButtonHitungTinggi As System.Windows.Forms.Button
    Friend WithEvents TextBoxVolume As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxJariJari As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBoxHasil As System.Windows.Forms.TextBox
End Class
