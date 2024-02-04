<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TUGAS4
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
        Me.txtN1 = New System.Windows.Forms.TextBox()
        Me.txtN2 = New System.Windows.Forms.TextBox()
        Me.txtHasil = New System.Windows.Forms.TextBox()
        Me.btnHitung = New System.Windows.Forms.Button()
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.rbJumlah = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbKurang = New System.Windows.Forms.RadioButton()
        Me.rbKali = New System.Windows.Forms.RadioButton()
        Me.rbBagi = New System.Windows.Forms.RadioButton()
        Me.rbSisa = New System.Windows.Forms.RadioButton()
        Me.rbPangkat = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(79, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(207, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PROGRAM KALKULATOR"
        '
        'txtN1
        '
        Me.txtN1.Location = New System.Drawing.Point(12, 39)
        Me.txtN1.Name = "txtN1"
        Me.txtN1.Size = New System.Drawing.Size(157, 20)
        Me.txtN1.TabIndex = 1
        '
        'txtN2
        '
        Me.txtN2.Location = New System.Drawing.Point(12, 65)
        Me.txtN2.Name = "txtN2"
        Me.txtN2.Size = New System.Drawing.Size(157, 20)
        Me.txtN2.TabIndex = 2
        '
        'txtHasil
        '
        Me.txtHasil.Location = New System.Drawing.Point(202, 40)
        Me.txtHasil.Name = "txtHasil"
        Me.txtHasil.Size = New System.Drawing.Size(156, 20)
        Me.txtHasil.TabIndex = 3
        '
        'btnHitung
        '
        Me.btnHitung.Location = New System.Drawing.Point(202, 66)
        Me.btnHitung.Name = "btnHitung"
        Me.btnHitung.Size = New System.Drawing.Size(75, 23)
        Me.btnHitung.TabIndex = 4
        Me.btnHitung.Text = "Hitung"
        Me.btnHitung.UseVisualStyleBackColor = True
        '
        'btnKeluar
        '
        Me.btnKeluar.Location = New System.Drawing.Point(283, 66)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(75, 23)
        Me.btnKeluar.TabIndex = 5
        Me.btnKeluar.Text = "Keluar"
        Me.btnKeluar.UseVisualStyleBackColor = True
        '
        'rbJumlah
        '
        Me.rbJumlah.AutoSize = True
        Me.rbJumlah.Location = New System.Drawing.Point(28, 20)
        Me.rbJumlah.Name = "rbJumlah"
        Me.rbJumlah.Size = New System.Drawing.Size(86, 17)
        Me.rbJumlah.TabIndex = 6
        Me.rbJumlah.TabStop = True
        Me.rbJumlah.Text = "Penjumlahan"
        Me.rbJumlah.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox1.Controls.Add(Me.rbPangkat)
        Me.GroupBox1.Controls.Add(Me.rbSisa)
        Me.GroupBox1.Controls.Add(Me.rbBagi)
        Me.GroupBox1.Controls.Add(Me.rbKali)
        Me.GroupBox1.Controls.Add(Me.rbKurang)
        Me.GroupBox1.Controls.Add(Me.rbJumlah)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 109)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(346, 77)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Function Operasi"
        '
        'rbKurang
        '
        Me.rbKurang.AutoSize = True
        Me.rbKurang.Location = New System.Drawing.Point(28, 43)
        Me.rbKurang.Name = "rbKurang"
        Me.rbKurang.Size = New System.Drawing.Size(89, 17)
        Me.rbKurang.TabIndex = 7
        Me.rbKurang.TabStop = True
        Me.rbKurang.Text = "Pengurangan"
        Me.rbKurang.UseVisualStyleBackColor = True
        '
        'rbKali
        '
        Me.rbKali.AutoSize = True
        Me.rbKali.Location = New System.Drawing.Point(140, 20)
        Me.rbKali.Name = "rbKali"
        Me.rbKali.Size = New System.Drawing.Size(69, 17)
        Me.rbKali.TabIndex = 8
        Me.rbKali.TabStop = True
        Me.rbKali.Text = "Perkalian"
        Me.rbKali.UseVisualStyleBackColor = True
        '
        'rbBagi
        '
        Me.rbBagi.AutoSize = True
        Me.rbBagi.Location = New System.Drawing.Point(140, 43)
        Me.rbBagi.Name = "rbBagi"
        Me.rbBagi.Size = New System.Drawing.Size(78, 17)
        Me.rbBagi.TabIndex = 9
        Me.rbBagi.TabStop = True
        Me.rbBagi.Text = "Pembagian"
        Me.rbBagi.UseVisualStyleBackColor = True
        '
        'rbSisa
        '
        Me.rbSisa.AutoSize = True
        Me.rbSisa.Location = New System.Drawing.Point(248, 20)
        Me.rbSisa.Name = "rbSisa"
        Me.rbSisa.Size = New System.Drawing.Size(65, 17)
        Me.rbSisa.TabIndex = 10
        Me.rbSisa.TabStop = True
        Me.rbSisa.Text = "Modulus"
        Me.rbSisa.UseVisualStyleBackColor = True
        '
        'rbPangkat
        '
        Me.rbPangkat.AutoSize = True
        Me.rbPangkat.Location = New System.Drawing.Point(248, 43)
        Me.rbPangkat.Name = "rbPangkat"
        Me.rbPangkat.Size = New System.Drawing.Size(65, 17)
        Me.rbPangkat.TabIndex = 11
        Me.rbPangkat.TabStop = True
        Me.rbPangkat.Text = "Pangkat"
        Me.rbPangkat.UseVisualStyleBackColor = True
        '
        'TUGAS4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(371, 206)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnKeluar)
        Me.Controls.Add(Me.btnHitung)
        Me.Controls.Add(Me.txtHasil)
        Me.Controls.Add(Me.txtN2)
        Me.Controls.Add(Me.txtN1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "TUGAS4"
        Me.Text = "2118118_TUGAS4"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtN1 As System.Windows.Forms.TextBox
    Friend WithEvents txtN2 As System.Windows.Forms.TextBox
    Friend WithEvents txtHasil As System.Windows.Forms.TextBox
    Friend WithEvents btnHitung As System.Windows.Forms.Button
    Friend WithEvents btnKeluar As System.Windows.Forms.Button
    Friend WithEvents rbJumlah As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbPangkat As System.Windows.Forms.RadioButton
    Friend WithEvents rbSisa As System.Windows.Forms.RadioButton
    Friend WithEvents rbBagi As System.Windows.Forms.RadioButton
    Friend WithEvents rbKali As System.Windows.Forms.RadioButton
    Friend WithEvents rbKurang As System.Windows.Forms.RadioButton
End Class
