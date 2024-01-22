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
        Me.Cbokb = New System.Windows.Forms.ComboBox()
        Me.TxtNb = New System.Windows.Forms.TextBox()
        Me.TxtHb = New System.Windows.Forms.TextBox()
        Me.BtnTutup = New System.Windows.Forms.Button()
        Me.Judul = New System.Windows.Forms.Label()
        Me.Label = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Jumlah = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Diskon = New System.Windows.Forms.TextBox()
        Me.Clear = New System.Windows.Forms.Button()
        Me.Proses = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Total = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kode Barang"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama Barang"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Harga Barang"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(105, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(12, 19)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = ":"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(105, 84)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(12, 19)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = ":"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(107, 114)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(12, 19)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = ":"
        '
        'Cbokb
        '
        Me.Cbokb.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbokb.FormattingEnabled = True
        Me.Cbokb.Items.AddRange(New Object() {"PL01", "PL02", "BK01", "BK02"})
        Me.Cbokb.Location = New System.Drawing.Point(124, 50)
        Me.Cbokb.Name = "Cbokb"
        Me.Cbokb.Size = New System.Drawing.Size(131, 23)
        Me.Cbokb.TabIndex = 6
        '
        'TxtNb
        '
        Me.TxtNb.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNb.Location = New System.Drawing.Point(124, 82)
        Me.TxtNb.Name = "TxtNb"
        Me.TxtNb.Size = New System.Drawing.Size(178, 20)
        Me.TxtNb.TabIndex = 7
        '
        'TxtHb
        '
        Me.TxtHb.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtHb.Location = New System.Drawing.Point(124, 113)
        Me.TxtHb.Name = "TxtHb"
        Me.TxtHb.Size = New System.Drawing.Size(131, 20)
        Me.TxtHb.TabIndex = 8
        '
        'BtnTutup
        '
        Me.BtnTutup.Location = New System.Drawing.Point(227, 278)
        Me.BtnTutup.Name = "BtnTutup"
        Me.BtnTutup.Size = New System.Drawing.Size(75, 23)
        Me.BtnTutup.TabIndex = 9
        Me.BtnTutup.Text = "Keluar"
        Me.BtnTutup.UseVisualStyleBackColor = True
        '
        'Judul
        '
        Me.Judul.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Judul.AutoSize = True
        Me.Judul.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Judul.Location = New System.Drawing.Point(121, 9)
        Me.Judul.Name = "Judul"
        Me.Judul.Size = New System.Drawing.Size(236, 26)
        Me.Judul.TabIndex = 10
        Me.Judul.Text = "FORM PENJUALAN"
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label.Location = New System.Drawing.Point(8, 170)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(77, 19)
        Me.Label.TabIndex = 11
        Me.Label.Text = "Jumlah Beli"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(107, 170)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(12, 19)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = ":"
        '
        'Jumlah
        '
        Me.Jumlah.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Jumlah.Location = New System.Drawing.Point(124, 171)
        Me.Jumlah.Name = "Jumlah"
        Me.Jumlah.Size = New System.Drawing.Size(100, 20)
        Me.Jumlah.TabIndex = 13
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(8, 202)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 19)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Diskon"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(107, 202)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(12, 19)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = ":"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(120, 202)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(29, 19)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "Rp"
        '
        'Diskon
        '
        Me.Diskon.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Diskon.Location = New System.Drawing.Point(155, 203)
        Me.Diskon.Name = "Diskon"
        Me.Diskon.Size = New System.Drawing.Size(100, 20)
        Me.Diskon.TabIndex = 18
        '
        'Clear
        '
        Me.Clear.Location = New System.Drawing.Point(126, 278)
        Me.Clear.Name = "Clear"
        Me.Clear.Size = New System.Drawing.Size(75, 23)
        Me.Clear.TabIndex = 19
        Me.Clear.Text = "Clear"
        Me.Clear.UseVisualStyleBackColor = True
        '
        'Proses
        '
        Me.Proses.Location = New System.Drawing.Point(24, 278)
        Me.Proses.Name = "Proses"
        Me.Proses.Size = New System.Drawing.Size(75, 23)
        Me.Proses.TabIndex = 20
        Me.Proses.Text = "Proses"
        Me.Proses.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(8, 232)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(79, 19)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "Total Bayar"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(107, 232)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(12, 19)
        Me.Label13.TabIndex = 22
        Me.Label13.Text = ":"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(120, 232)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(29, 19)
        Me.Label14.TabIndex = 23
        Me.Label14.Text = "Rp"
        '
        'Total
        '
        Me.Total.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Total.Location = New System.Drawing.Point(155, 229)
        Me.Total.Name = "Total"
        Me.Total.Size = New System.Drawing.Size(100, 20)
        Me.Total.TabIndex = 24
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(478, 422)
        Me.Controls.Add(Me.Total)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Proses)
        Me.Controls.Add(Me.Clear)
        Me.Controls.Add(Me.Diskon)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Jumlah)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label)
        Me.Controls.Add(Me.Judul)
        Me.Controls.Add(Me.BtnTutup)
        Me.Controls.Add(Me.TxtHb)
        Me.Controls.Add(Me.TxtNb)
        Me.Controls.Add(Me.Cbokb)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Mini Market Kita Semua"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Cbokb As System.Windows.Forms.ComboBox
    Friend WithEvents TxtNb As System.Windows.Forms.TextBox
    Friend WithEvents TxtHb As System.Windows.Forms.TextBox
    Friend WithEvents BtnTutup As System.Windows.Forms.Button
    Friend WithEvents Judul As System.Windows.Forms.Label
    Friend WithEvents Label As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Jumlah As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Diskon As System.Windows.Forms.TextBox
    Friend WithEvents Clear As System.Windows.Forms.Button
    Friend WithEvents Proses As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Total As System.Windows.Forms.TextBox

End Class
