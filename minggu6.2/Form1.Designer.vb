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
        Me.lstHari = New System.Windows.Forms.ListBox()
        Me.btnHari = New System.Windows.Forms.Button()
        Me.lblName = New System.Windows.Forms.Label()
        Me.btnForm2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstHari
        '
        Me.lstHari.FormattingEnabled = True
        Me.lstHari.Location = New System.Drawing.Point(340, 124)
        Me.lstHari.MultiColumn = True
        Me.lstHari.Name = "lstHari"
        Me.lstHari.Size = New System.Drawing.Size(120, 95)
        Me.lstHari.TabIndex = 3
        '
        'btnHari
        '
        Me.btnHari.Location = New System.Drawing.Point(368, 262)
        Me.btnHari.Name = "btnHari"
        Me.btnHari.Size = New System.Drawing.Size(75, 23)
        Me.btnHari.TabIndex = 4
        Me.btnHari.Text = "Papar"
        Me.btnHari.UseVisualStyleBackColor = True
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(750, 428)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(38, 13)
        Me.lblName.TabIndex = 5
        Me.lblName.Text = "deylan"
        '
        'btnForm2
        '
        Me.btnForm2.Location = New System.Drawing.Point(368, 327)
        Me.btnForm2.Name = "btnForm2"
        Me.btnForm2.Size = New System.Drawing.Size(75, 23)
        Me.btnForm2.TabIndex = 6
        Me.btnForm2.Text = "Button"
        Me.btnForm2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnForm2)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.btnHari)
        Me.Controls.Add(Me.lstHari)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstHari As ListBox
    Friend WithEvents btnHari As Button
    Friend WithEvents lblName As Label
    Friend WithEvents btnForm2 As Button
End Class
