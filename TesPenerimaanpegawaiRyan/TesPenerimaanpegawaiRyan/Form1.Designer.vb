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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtNilai = New System.Windows.Forms.TextBox()
        Me.TxtHasil = New System.Windows.Forms.TextBox()
        Me.BtnProses = New System.Windows.Forms.Button()
        Me.BtnEnd = New System.Windows.Forms.Button()
        Me.TxtHar = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(408, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "HASIL TEST PENERIMAAN PEGAWAI"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(108, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nilai  :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(107, 159)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Hasil :"
        '
        'TxtNilai
        '
        Me.TxtNilai.Location = New System.Drawing.Point(202, 86)
        Me.TxtNilai.Name = "TxtNilai"
        Me.TxtNilai.Size = New System.Drawing.Size(48, 20)
        Me.TxtNilai.TabIndex = 3
        '
        'TxtHasil
        '
        Me.TxtHasil.Location = New System.Drawing.Point(202, 160)
        Me.TxtHasil.Name = "TxtHasil"
        Me.TxtHasil.Size = New System.Drawing.Size(100, 20)
        Me.TxtHasil.TabIndex = 4
        '
        'BtnProses
        '
        Me.BtnProses.Location = New System.Drawing.Point(68, 243)
        Me.BtnProses.Name = "BtnProses"
        Me.BtnProses.Size = New System.Drawing.Size(75, 23)
        Me.BtnProses.TabIndex = 5
        Me.BtnProses.Text = "Procces"
        Me.BtnProses.UseVisualStyleBackColor = True
        '
        'BtnEnd
        '
        Me.BtnEnd.Location = New System.Drawing.Point(285, 243)
        Me.BtnEnd.Name = "BtnEnd"
        Me.BtnEnd.Size = New System.Drawing.Size(75, 23)
        Me.BtnEnd.TabIndex = 6
        Me.BtnEnd.Text = "End"
        Me.BtnEnd.UseVisualStyleBackColor = True
        '
        'TxtHar
        '
        Me.TxtHar.AutoSize = True
        Me.TxtHar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtHar.Location = New System.Drawing.Point(108, 122)
        Me.TxtHar.Name = "TxtHar"
        Me.TxtHar.Size = New System.Drawing.Size(88, 18)
        Me.TxtHar.TabIndex = 7
        Me.TxtHar.Text = "Nilai harian :"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(202, 123)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkCyan
        Me.ClientSize = New System.Drawing.Size(440, 303)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.TxtHar)
        Me.Controls.Add(Me.BtnEnd)
        Me.Controls.Add(Me.BtnProses)
        Me.Controls.Add(Me.TxtHasil)
        Me.Controls.Add(Me.TxtNilai)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "IF THEN ELSE"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtNilai As System.Windows.Forms.TextBox
    Friend WithEvents TxtHasil As System.Windows.Forms.TextBox
    Friend WithEvents BtnProses As System.Windows.Forms.Button
    Friend WithEvents BtnEnd As System.Windows.Forms.Button
    Friend WithEvents TxtHar As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox

End Class
