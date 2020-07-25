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
        Me.TextoToHashTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.HashResultTextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'TextoToHashTextBox
        '
        Me.TextoToHashTextBox.Location = New System.Drawing.Point(0, 0)
        Me.TextoToHashTextBox.Multiline = True
        Me.TextoToHashTextBox.Name = "TextoToHashTextBox"
        Me.TextoToHashTextBox.Size = New System.Drawing.Size(828, 352)
        Me.TextoToHashTextBox.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(753, 358)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "MD5"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'HashResultTextBox
        '
        Me.HashResultTextBox.Location = New System.Drawing.Point(0, 360)
        Me.HashResultTextBox.Name = "HashResultTextBox"
        Me.HashResultTextBox.Size = New System.Drawing.Size(747, 20)
        Me.HashResultTextBox.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(826, 381)
        Me.Controls.Add(Me.HashResultTextBox)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextoToHashTextBox)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Md5Gui"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextoToHashTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents HashResultTextBox As System.Windows.Forms.TextBox

End Class
