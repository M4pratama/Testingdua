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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextboxKB = New System.Windows.Forms.TextBox()
        Me.TextboxNB = New System.Windows.Forms.TextBox()
        Me.TextboxS = New System.Windows.Forms.TextBox()
        Me.TextboxH = New System.Windows.Forms.TextBox()
        Me.TextboxJ = New System.Windows.Forms.TextBox()
        Me.TextboxTH = New System.Windows.Forms.TextBox()
        Me.ButtonHITUNG = New System.Windows.Forms.Button()
        Me.ButtonCLEAR = New System.Windows.Forms.Button()
        Me.ButtonEXIT = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(137, 115)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "KODE BARANG : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(137, 145)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "NAMA BARANG:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(170, 178)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "SATUAN :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(129, 207)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "HARGA SATUAN :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(172, 237)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "JUMLAH : "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(158, 269)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Total Harga :"
        '
        'TextboxKB
        '
        Me.TextboxKB.Location = New System.Drawing.Point(237, 112)
        Me.TextboxKB.Name = "TextboxKB"
        Me.TextboxKB.Size = New System.Drawing.Size(100, 20)
        Me.TextboxKB.TabIndex = 6
        '
        'TextboxNB
        '
        Me.TextboxNB.Location = New System.Drawing.Point(237, 145)
        Me.TextboxNB.Name = "TextboxNB"
        Me.TextboxNB.Size = New System.Drawing.Size(161, 20)
        Me.TextboxNB.TabIndex = 7
        '
        'TextboxS
        '
        Me.TextboxS.Location = New System.Drawing.Point(237, 178)
        Me.TextboxS.Name = "TextboxS"
        Me.TextboxS.Size = New System.Drawing.Size(100, 20)
        Me.TextboxS.TabIndex = 8
        '
        'TextboxH
        '
        Me.TextboxH.Location = New System.Drawing.Point(237, 207)
        Me.TextboxH.Name = "TextboxH"
        Me.TextboxH.Size = New System.Drawing.Size(100, 20)
        Me.TextboxH.TabIndex = 9
        '
        'TextboxJ
        '
        Me.TextboxJ.Location = New System.Drawing.Point(237, 237)
        Me.TextboxJ.Name = "TextboxJ"
        Me.TextboxJ.Size = New System.Drawing.Size(100, 20)
        Me.TextboxJ.TabIndex = 10
        '
        'TextboxTH
        '
        Me.TextboxTH.Location = New System.Drawing.Point(237, 266)
        Me.TextboxTH.Name = "TextboxTH"
        Me.TextboxTH.Size = New System.Drawing.Size(100, 20)
        Me.TextboxTH.TabIndex = 11
        '
        'ButtonHITUNG
        '
        Me.ButtonHITUNG.Location = New System.Drawing.Point(262, 425)
        Me.ButtonHITUNG.Name = "ButtonHITUNG"
        Me.ButtonHITUNG.Size = New System.Drawing.Size(75, 23)
        Me.ButtonHITUNG.TabIndex = 12
        Me.ButtonHITUNG.Text = "Hitung"
        Me.ButtonHITUNG.UseVisualStyleBackColor = True
        '
        'ButtonCLEAR
        '
        Me.ButtonCLEAR.Location = New System.Drawing.Point(393, 424)
        Me.ButtonCLEAR.Name = "ButtonCLEAR"
        Me.ButtonCLEAR.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCLEAR.TabIndex = 13
        Me.ButtonCLEAR.Text = "CLEAR"
        Me.ButtonCLEAR.UseVisualStyleBackColor = True
        '
        'ButtonEXIT
        '
        Me.ButtonEXIT.Location = New System.Drawing.Point(520, 424)
        Me.ButtonEXIT.Name = "ButtonEXIT"
        Me.ButtonEXIT.Size = New System.Drawing.Size(75, 23)
        Me.ButtonEXIT.TabIndex = 14
        Me.ButtonEXIT.Text = "Exit"
        Me.ButtonEXIT.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(823, 493)
        Me.Controls.Add(Me.ButtonEXIT)
        Me.Controls.Add(Me.ButtonCLEAR)
        Me.Controls.Add(Me.ButtonHITUNG)
        Me.Controls.Add(Me.TextboxTH)
        Me.Controls.Add(Me.TextboxJ)
        Me.Controls.Add(Me.TextboxH)
        Me.Controls.Add(Me.TextboxS)
        Me.Controls.Add(Me.TextboxNB)
        Me.Controls.Add(Me.TextboxKB)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
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
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextboxKB As System.Windows.Forms.TextBox
    Friend WithEvents TextboxNB As System.Windows.Forms.TextBox
    Friend WithEvents TextboxS As System.Windows.Forms.TextBox
    Friend WithEvents TextboxH As System.Windows.Forms.TextBox
    Friend WithEvents TextboxJ As System.Windows.Forms.TextBox
    Friend WithEvents TextboxTH As System.Windows.Forms.TextBox
    Friend WithEvents ButtonHITUNG As System.Windows.Forms.Button
    Friend WithEvents ButtonCLEAR As System.Windows.Forms.Button
    Friend WithEvents ButtonEXIT As System.Windows.Forms.Button

End Class
