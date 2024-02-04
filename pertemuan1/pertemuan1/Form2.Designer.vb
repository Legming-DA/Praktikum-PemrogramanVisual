<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.textA = New System.Windows.Forms.TextBox()
        Me.textB = New System.Windows.Forms.TextBox()
        Me.textHasil = New System.Windows.Forms.TextBox()
        Me.btnPlus = New System.Windows.Forms.Button()
        Me.btnMin = New System.Windows.Forms.Button()
        Me.btnMulti = New System.Windows.Forms.Button()
        Me.btnDiv = New System.Windows.Forms.Button()
        Me.btnPangkat = New System.Windows.Forms.Button()
        Me.btnMod = New System.Windows.Forms.Button()
        Me.btnString = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nilai A"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nilai B"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Hasil"
        '
        'textA
        '
        Me.textA.Location = New System.Drawing.Point(78, 19)
        Me.textA.Name = "textA"
        Me.textA.Size = New System.Drawing.Size(100, 20)
        Me.textA.TabIndex = 3
        '
        'textB
        '
        Me.textB.Location = New System.Drawing.Point(78, 50)
        Me.textB.Name = "textB"
        Me.textB.Size = New System.Drawing.Size(100, 20)
        Me.textB.TabIndex = 4
        '
        'textHasil
        '
        Me.textHasil.Location = New System.Drawing.Point(78, 78)
        Me.textHasil.Name = "textHasil"
        Me.textHasil.Size = New System.Drawing.Size(100, 20)
        Me.textHasil.TabIndex = 5
        '
        'btnPlus
        '
        Me.btnPlus.Location = New System.Drawing.Point(19, 144)
        Me.btnPlus.Name = "btnPlus"
        Me.btnPlus.Size = New System.Drawing.Size(75, 23)
        Me.btnPlus.TabIndex = 6
        Me.btnPlus.Text = "+"
        Me.btnPlus.UseVisualStyleBackColor = True
        '
        'btnMin
        '
        Me.btnMin.Location = New System.Drawing.Point(19, 186)
        Me.btnMin.Name = "btnMin"
        Me.btnMin.Size = New System.Drawing.Size(75, 23)
        Me.btnMin.TabIndex = 7
        Me.btnMin.Text = "-"
        Me.btnMin.UseVisualStyleBackColor = True
        '
        'btnMulti
        '
        Me.btnMulti.Location = New System.Drawing.Point(128, 144)
        Me.btnMulti.Name = "btnMulti"
        Me.btnMulti.Size = New System.Drawing.Size(75, 23)
        Me.btnMulti.TabIndex = 8
        Me.btnMulti.Text = "*"
        Me.btnMulti.UseVisualStyleBackColor = True
        '
        'btnDiv
        '
        Me.btnDiv.Location = New System.Drawing.Point(128, 186)
        Me.btnDiv.Name = "btnDiv"
        Me.btnDiv.Size = New System.Drawing.Size(75, 23)
        Me.btnDiv.TabIndex = 9
        Me.btnDiv.Text = "/"
        Me.btnDiv.UseVisualStyleBackColor = True
        '
        'btnPangkat
        '
        Me.btnPangkat.Location = New System.Drawing.Point(225, 144)
        Me.btnPangkat.Name = "btnPangkat"
        Me.btnPangkat.Size = New System.Drawing.Size(75, 23)
        Me.btnPangkat.TabIndex = 10
        Me.btnPangkat.Text = "^"
        Me.btnPangkat.UseVisualStyleBackColor = True
        '
        'btnMod
        '
        Me.btnMod.Location = New System.Drawing.Point(225, 186)
        Me.btnMod.Name = "btnMod"
        Me.btnMod.Size = New System.Drawing.Size(75, 23)
        Me.btnMod.TabIndex = 11
        Me.btnMod.Text = "Mod"
        Me.btnMod.UseVisualStyleBackColor = True
        '
        'btnString
        '
        Me.btnString.Location = New System.Drawing.Point(326, 144)
        Me.btnString.Name = "btnString"
        Me.btnString.Size = New System.Drawing.Size(75, 23)
        Me.btnString.TabIndex = 12
        Me.btnString.Text = "String"
        Me.btnString.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(413, 283)
        Me.Controls.Add(Me.btnString)
        Me.Controls.Add(Me.btnMod)
        Me.Controls.Add(Me.btnPangkat)
        Me.Controls.Add(Me.btnDiv)
        Me.Controls.Add(Me.btnMulti)
        Me.Controls.Add(Me.btnMin)
        Me.Controls.Add(Me.btnPlus)
        Me.Controls.Add(Me.textHasil)
        Me.Controls.Add(Me.textB)
        Me.Controls.Add(Me.textA)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Kalkulator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents textA As System.Windows.Forms.TextBox
    Friend WithEvents textB As System.Windows.Forms.TextBox
    Friend WithEvents textHasil As System.Windows.Forms.TextBox
    Friend WithEvents btnPlus As System.Windows.Forms.Button
    Friend WithEvents btnMin As System.Windows.Forms.Button
    Friend WithEvents btnMulti As System.Windows.Forms.Button
    Friend WithEvents btnDiv As System.Windows.Forms.Button
    Friend WithEvents btnPangkat As System.Windows.Forms.Button
    Friend WithEvents btnMod As System.Windows.Forms.Button
    Friend WithEvents btnString As System.Windows.Forms.Button
End Class
