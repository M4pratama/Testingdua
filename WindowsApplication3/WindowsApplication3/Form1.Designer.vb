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
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Cbokb = New System.Windows.Forms.ComboBox()
        Me.TxtNb = New System.Windows.Forms.TextBox()
        Me.TxtHb = New System.Windows.Forms.TextBox()
        Me.Jumlah = New System.Windows.Forms.TextBox()
        Me.Diskon = New System.Windows.Forms.TextBox()
        Me.Total = New System.Windows.Forms.TextBox()
        Me.Proses = New System.Windows.Forms.Button()
        Me.Clear = New System.Windows.Forms.Button()
        Me.BtnTutup = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(172, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(204, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "FORM PENJUALAN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(127, 131)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "kode Barang:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(127, 160)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nama Barang:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(123, 193)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Harga Barang"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(112, 301)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "JUMLAH BELI"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(115, 335)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "DISKON"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(115, 372)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "TOTAL BAYAR"
        '
        'Cbokb
        '
        Me.Cbokb.FormattingEnabled = True
        Me.Cbokb.Items.AddRange(New Object() {"PL01", "PL02", "BL01", "BL02"})
        Me.Cbokb.Location = New System.Drawing.Point(225, 130)
        Me.Cbokb.Name = "Cbokb"
        Me.Cbokb.Size = New System.Drawing.Size(121, 21)
        Me.Cbokb.TabIndex = 7
        '
        'TxtNb
        '
        Me.TxtNb.Location = New System.Drawing.Point(225, 159)
        Me.TxtNb.Name = "TxtNb"
        Me.TxtNb.Size = New System.Drawing.Size(100, 20)
        Me.TxtNb.TabIndex = 8
        '
        'TxtHb
        '
        Me.TxtHb.Location = New System.Drawing.Point(225, 189)
        Me.TxtHb.Name = "TxtHb"
        Me.TxtHb.Size = New System.Drawing.Size(100, 20)
        Me.TxtHb.TabIndex = 9
        '
        'Jumlah
        '
        Me.Jumlah.Location = New System.Drawing.Point(246, 298)
        Me.Jumlah.Name = "Jumlah"
        Me.Jumlah.Size = New System.Drawing.Size(100, 20)
        Me.Jumlah.TabIndex = 10
        '
        'Diskon
        '
        Me.Diskon.Location = New System.Drawing.Point(246, 332)
        Me.Diskon.Name = "Diskon"
        Me.Diskon.Size = New System.Drawing.Size(100, 20)
        Me.Diskon.TabIndex = 11
        '
        'Total
        '
        Me.Total.Location = New System.Drawing.Point(246, 369)
        Me.Total.Name = "Total"
        Me.Total.Size = New System.Drawing.Size(100, 20)
        Me.Total.TabIndex = 12
        '
        'Proses
        '
        Me.Proses.Location = New System.Drawing.Point(87, 457)
        Me.Proses.Name = "Proses"
        Me.Proses.Size = New System.Drawing.Size(75, 23)
        Me.Proses.TabIndex = 13
        Me.Proses.Text = "Procces"
        Me.Proses.UseVisualStyleBackColor = True
        '
        'Clear
        '
        Me.Clear.Location = New System.Drawing.Point(260, 456)
        Me.Clear.Name = "Clear"
        Me.Clear.Size = New System.Drawing.Size(75, 23)
        Me.Clear.TabIndex = 14
        Me.Clear.Text = "Clear"
        Me.Clear.UseVisualStyleBackColor = True
        '
        'BtnTutup
        '
        Me.BtnTutup.Location = New System.Drawing.Point(466, 456)
        Me.BtnTutup.Name = "BtnTutup"
        Me.BtnTutup.Size = New System.Drawing.Size(75, 23)
        Me.BtnTutup.TabIndex = 15
        Me.BtnTutup.Text = "Keluar"
        Me.BtnTutup.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(216, 301)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(24, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Rp-"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(216, 335)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(24, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Rp-"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(216, 372)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(24, 13)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Rp-"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(397, 1)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 19
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Aquamarine
        Me.ClientSize = New System.Drawing.Size(609, 582)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.BtnTutup)
        Me.Controls.Add(Me.Clear)
        Me.Controls.Add(Me.Proses)
        Me.Controls.Add(Me.Total)
        Me.Controls.Add(Me.Diskon)
        Me.Controls.Add(Me.Jumlah)
        Me.Controls.Add(Me.TxtHb)
        Me.Controls.Add(Me.TxtNb)
        Me.Controls.Add(Me.Cbokb)
        Me.Controls.Add(Me.Label7)
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
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Cbokb As System.Windows.Forms.ComboBox
    Friend WithEvents TxtNb As System.Windows.Forms.TextBox
    Friend WithEvents TxtHb As System.Windows.Forms.TextBox
    Friend WithEvents Jumlah As System.Windows.Forms.TextBox
    Friend WithEvents Diskon As System.Windows.Forms.TextBox
    Friend WithEvents Total As System.Windows.Forms.TextBox
    Friend WithEvents Proses As System.Windows.Forms.Button
    Friend WithEvents Clear As System.Windows.Forms.Button
    Friend WithEvents BtnTutup As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker

End Class
