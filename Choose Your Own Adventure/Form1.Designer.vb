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
        Me.DisplayBox = New System.Windows.Forms.RichTextBox()
        Me.Choice1 = New System.Windows.Forms.Button()
        Me.Choice2 = New System.Windows.Forms.Button()
        Me.Choice3 = New System.Windows.Forms.Button()
        Me.SuspendLayout
        '
        'DisplayBox
        '
        Me.DisplayBox.BackColor = System.Drawing.SystemColors.MenuText
        Me.DisplayBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DisplayBox.Font = New System.Drawing.Font("Source Code Pro Medium", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.DisplayBox.ForeColor = System.Drawing.Color.Lime
        Me.DisplayBox.Location = New System.Drawing.Point(12, 12)
        Me.DisplayBox.Name = "DisplayBox"
        Me.DisplayBox.Size = New System.Drawing.Size(619, 266)
        Me.DisplayBox.TabIndex = 0
        Me.DisplayBox.Text = ""
        '
        'Choice1
        '
        Me.Choice1.Location = New System.Drawing.Point(12, 284)
        Me.Choice1.Name = "Choice1"
        Me.Choice1.Size = New System.Drawing.Size(202, 50)
        Me.Choice1.TabIndex = 1
        Me.Choice1.Text = "Button1"
        Me.Choice1.UseVisualStyleBackColor = true
        '
        'Choice2
        '
        Me.Choice2.Location = New System.Drawing.Point(220, 284)
        Me.Choice2.Name = "Choice2"
        Me.Choice2.Size = New System.Drawing.Size(202, 50)
        Me.Choice2.TabIndex = 2
        Me.Choice2.Text = "Button2"
        Me.Choice2.UseVisualStyleBackColor = true
        '
        'Choice3
        '
        Me.Choice3.Location = New System.Drawing.Point(428, 284)
        Me.Choice3.Name = "Choice3"
        Me.Choice3.Size = New System.Drawing.Size(203, 50)
        Me.Choice3.TabIndex = 3
        Me.Choice3.Text = "Button3"
        Me.Choice3.UseVisualStyleBackColor = true
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = true
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(643, 346)
        Me.Controls.Add(Me.Choice3)
        Me.Controls.Add(Me.Choice2)
        Me.Controls.Add(Me.Choice1)
        Me.Controls.Add(Me.DisplayBox)
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents DisplayBox As RichTextBox
    Friend WithEvents Choice1 As Button
    Friend WithEvents Choice2 As Button
    Friend WithEvents Choice3 As Button
End Class
