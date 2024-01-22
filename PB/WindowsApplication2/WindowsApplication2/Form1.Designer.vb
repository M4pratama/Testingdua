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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtNPA = New System.Windows.Forms.TextBox()
        Me.TxtNPS = New System.Windows.Forms.TextBox()
        Me.TxtHasil = New System.Windows.Forms.TextBox()
        Me.BtnProsses = New System.Windows.Forms.Button()
        Me.BtnBersih = New System.Windows.Forms.Button()
        Me.BtnKeluar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(112, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(317, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Hasil Test Penerimaan Pegawai"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(73, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nilai Potensi Akademik:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(114, 154)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nilai Psikotes:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(114, 231)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Hasil"
        '
        'TxtNPA
        '
        Me.TxtNPA.Location = New System.Drawing.Point(198, 126)
        Me.TxtNPA.Name = "TxtNPA"
        Me.TxtNPA.Size = New System.Drawing.Size(100, 20)
        Me.TxtNPA.TabIndex = 4
        '
        'TxtNPS
        '
        Me.TxtNPS.Location = New System.Drawing.Point(198, 154)
        Me.TxtNPS.Name = "TxtNPS"
        Me.TxtNPS.Size = New System.Drawing.Size(100, 20)
        Me.TxtNPS.TabIndex = 5
        '
        'TxtHasil
        '
        Me.TxtHasil.Location = New System.Drawing.Point(187, 224)
        Me.TxtHasil.Name = "TxtHasil"
        Me.TxtHasil.Size = New System.Drawing.Size(100, 20)
        Me.TxtHasil.TabIndex = 6
        '
        'BtnProsses
        '
        Me.BtnProsses.Location = New System.Drawing.Point(76, 319)
        Me.BtnProsses.Name = "BtnProsses"
        Me.BtnProsses.Size = New System.Drawing.Size(75, 23)
        Me.BtnProsses.TabIndex = 7
        Me.BtnProsses.Text = "Prosses"
        Me.BtnProsses.UseVisualStyleBackColor = True
        '
        'BtnBersih
        '
        Me.BtnBersih.Location = New System.Drawing.Point(212, 318)
        Me.BtnBersih.Name = "BtnBersih"
        Me.BtnBersih.Size = New System.Drawing.Size(75, 23)
        Me.BtnBersih.TabIndex = 8
        Me.BtnBersih.Text = "Clear"
        Me.BtnBersih.UseVisualStyleBackColor = True
        '
        'BtnKeluar
        '
        Me.BtnKeluar.Location = New System.Drawing.Point(364, 319)
        Me.BtnKeluar.Name = "BtnKeluar"
        Me.BtnKeluar.Size = New System.Drawing.Size(75, 23)
        Me.BtnKeluar.TabIndex = 9
        Me.BtnKeluar.Text = "Keluar"
        Me.BtnKeluar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(538, 410)
        Me.Controls.Add(Me.BtnKeluar)
        Me.Controls.Add(Me.BtnBersih)
        Me.Controls.Add(Me.BtnProsses)
        Me.Controls.Add(Me.TxtHasil)
        Me.Controls.Add(Me.TxtNPS)
        Me.Controls.Add(Me.TxtNPA)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtNPA As System.Windows.Forms.TextBox
    Friend WithEvents TxtNPS As System.Windows.Forms.TextBox
    Friend WithEvents TxtHasil As System.Windows.Forms.TextBox
    Friend WithEvents BtnProsses As System.Windows.Forms.Button
    Friend WithEvents BtnBersih As System.Windows.Forms.Button
    Friend WithEvents BtnKeluar As System.Windows.Forms.Button

End Class
