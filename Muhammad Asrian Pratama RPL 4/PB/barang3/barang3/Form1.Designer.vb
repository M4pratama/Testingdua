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
        Me.txtVar1 = New System.Windows.Forms.TextBox()
        Me.txtVar2 = New System.Windows.Forms.TextBox()
        Me.txtH = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdbPengurangan = New System.Windows.Forms.RadioButton()
        Me.rdbPenjumlahan = New System.Windows.Forms.RadioButton()
        Me.rdbPerkalian = New System.Windows.Forms.RadioButton()
        Me.rdbPembagian = New System.Windows.Forms.RadioButton()
        Me.rdbPangkat = New System.Windows.Forms.RadioButton()
        Me.rdbAkar = New System.Windows.Forms.RadioButton()
        Me.btnHitung = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtVar1
        '
        Me.txtVar1.Location = New System.Drawing.Point(12, 12)
        Me.txtVar1.Name = "txtVar1"
        Me.txtVar1.Size = New System.Drawing.Size(100, 20)
        Me.txtVar1.TabIndex = 0
        '
        'txtVar2
        '
        Me.txtVar2.Location = New System.Drawing.Point(12, 51)
        Me.txtVar2.Name = "txtVar2"
        Me.txtVar2.Size = New System.Drawing.Size(100, 20)
        Me.txtVar2.TabIndex = 1
        '
        'txtH
        '
        Me.txtH.Location = New System.Drawing.Point(178, 31)
        Me.txtH.Name = "txtH"
        Me.txtH.Size = New System.Drawing.Size(100, 20)
        Me.txtH.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdbPengurangan)
        Me.GroupBox1.Controls.Add(Me.rdbPenjumlahan)
        Me.GroupBox1.Controls.Add(Me.rdbPerkalian)
        Me.GroupBox1.Controls.Add(Me.rdbPembagian)
        Me.GroupBox1.Controls.Add(Me.rdbPangkat)
        Me.GroupBox1.Controls.Add(Me.rdbAkar)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 97)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(266, 137)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Operasi"
        '
        'rdbPengurangan
        '
        Me.rdbPengurangan.AutoSize = True
        Me.rdbPengurangan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbPengurangan.Location = New System.Drawing.Point(148, 98)
        Me.rdbPengurangan.Name = "rdbPengurangan"
        Me.rdbPengurangan.Size = New System.Drawing.Size(107, 20)
        Me.rdbPengurangan.TabIndex = 5
        Me.rdbPengurangan.TabStop = True
        Me.rdbPengurangan.Text = "Pengurangan"
        Me.rdbPengurangan.UseVisualStyleBackColor = True
        '
        'rdbPenjumlahan
        '
        Me.rdbPenjumlahan.AutoSize = True
        Me.rdbPenjumlahan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbPenjumlahan.Location = New System.Drawing.Point(151, 61)
        Me.rdbPenjumlahan.Name = "rdbPenjumlahan"
        Me.rdbPenjumlahan.Size = New System.Drawing.Size(104, 20)
        Me.rdbPenjumlahan.TabIndex = 4
        Me.rdbPenjumlahan.TabStop = True
        Me.rdbPenjumlahan.Text = "Penjumlahan"
        Me.rdbPenjumlahan.UseVisualStyleBackColor = True
        '
        'rdbPerkalian
        '
        Me.rdbPerkalian.AutoSize = True
        Me.rdbPerkalian.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbPerkalian.Location = New System.Drawing.Point(151, 25)
        Me.rdbPerkalian.Name = "rdbPerkalian"
        Me.rdbPerkalian.Size = New System.Drawing.Size(83, 20)
        Me.rdbPerkalian.TabIndex = 3
        Me.rdbPerkalian.TabStop = True
        Me.rdbPerkalian.Text = "Perkalian"
        Me.rdbPerkalian.UseVisualStyleBackColor = True
        '
        'rdbPembagian
        '
        Me.rdbPembagian.AutoSize = True
        Me.rdbPembagian.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbPembagian.Location = New System.Drawing.Point(0, 98)
        Me.rdbPembagian.Name = "rdbPembagian"
        Me.rdbPembagian.Size = New System.Drawing.Size(96, 20)
        Me.rdbPembagian.TabIndex = 2
        Me.rdbPembagian.TabStop = True
        Me.rdbPembagian.Text = "Pembagian"
        Me.rdbPembagian.UseVisualStyleBackColor = True
        '
        'rdbPangkat
        '
        Me.rdbPangkat.AutoSize = True
        Me.rdbPangkat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbPangkat.Location = New System.Drawing.Point(6, 61)
        Me.rdbPangkat.Name = "rdbPangkat"
        Me.rdbPangkat.Size = New System.Drawing.Size(76, 20)
        Me.rdbPangkat.TabIndex = 1
        Me.rdbPangkat.TabStop = True
        Me.rdbPangkat.Text = "Pangkat"
        Me.rdbPangkat.UseVisualStyleBackColor = True
        '
        'rdbAkar
        '
        Me.rdbAkar.AutoSize = True
        Me.rdbAkar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbAkar.Location = New System.Drawing.Point(6, 25)
        Me.rdbAkar.Name = "rdbAkar"
        Me.rdbAkar.Size = New System.Drawing.Size(103, 20)
        Me.rdbAkar.TabIndex = 0
        Me.rdbAkar.TabStop = True
        Me.rdbAkar.Text = "Akar Kuadrat"
        Me.rdbAkar.UseVisualStyleBackColor = True
        '
        'btnHitung
        '
        Me.btnHitung.Location = New System.Drawing.Point(39, 254)
        Me.btnHitung.Name = "btnHitung"
        Me.btnHitung.Size = New System.Drawing.Size(75, 23)
        Me.btnHitung.TabIndex = 4
        Me.btnHitung.Text = "Hitung"
        Me.btnHitung.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(187, 254)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Exit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(299, 293)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnHitung)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtH)
        Me.Controls.Add(Me.txtVar2)
        Me.Controls.Add(Me.txtVar1)
        Me.Name = "Form1"
        Me.Text = "Function"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtVar1 As System.Windows.Forms.TextBox
    Friend WithEvents txtVar2 As System.Windows.Forms.TextBox
    Friend WithEvents txtH As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rdbPengurangan As System.Windows.Forms.RadioButton
    Friend WithEvents rdbPenjumlahan As System.Windows.Forms.RadioButton
    Friend WithEvents rdbPerkalian As System.Windows.Forms.RadioButton
    Friend WithEvents rdbPembagian As System.Windows.Forms.RadioButton
    Friend WithEvents rdbPangkat As System.Windows.Forms.RadioButton
    Friend WithEvents rdbAkar As System.Windows.Forms.RadioButton
    Friend WithEvents btnHitung As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button

End Class
