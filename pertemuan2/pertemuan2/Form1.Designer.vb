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
        Me.btn_if = New System.Windows.Forms.Button()
        Me.btn_ifelse = New System.Windows.Forms.Button()
        Me.btn_case = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_if
        '
        Me.btn_if.Location = New System.Drawing.Point(25, 12)
        Me.btn_if.Name = "btn_if"
        Me.btn_if.Size = New System.Drawing.Size(140, 23)
        Me.btn_if.TabIndex = 0
        Me.btn_if.Text = "IF ... ENDIF"
        Me.btn_if.UseVisualStyleBackColor = True
        '
        'btn_ifelse
        '
        Me.btn_ifelse.Location = New System.Drawing.Point(25, 61)
        Me.btn_ifelse.Name = "btn_ifelse"
        Me.btn_ifelse.Size = New System.Drawing.Size(140, 23)
        Me.btn_ifelse.TabIndex = 1
        Me.btn_ifelse.Text = " IF ... ELSE ... ENDIF"
        Me.btn_ifelse.UseVisualStyleBackColor = True
        '
        'btn_case
        '
        Me.btn_case.Location = New System.Drawing.Point(25, 108)
        Me.btn_case.Name = "btn_case"
        Me.btn_case.Size = New System.Drawing.Size(140, 23)
        Me.btn_case.TabIndex = 2
        Me.btn_case.Text = "SELECT ... CASE"
        Me.btn_case.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(189, 149)
        Me.Controls.Add(Me.btn_case)
        Me.Controls.Add(Me.btn_ifelse)
        Me.Controls.Add(Me.btn_if)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_if As System.Windows.Forms.Button
    Friend WithEvents btn_ifelse As System.Windows.Forms.Button
    Friend WithEvents btn_case As System.Windows.Forms.Button

End Class
