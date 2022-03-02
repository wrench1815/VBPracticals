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
        Me.MessageButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'MessageButton
        '
        Me.MessageButton.AutoSize = True
        Me.MessageButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MessageButton.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.MessageButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.MessageButton.Location = New System.Drawing.Point(308, 168)
        Me.MessageButton.Name = "MessageButton"
        Me.MessageButton.Size = New System.Drawing.Size(122, 24)
        Me.MessageButton.TabIndex = 0
        Me.MessageButton.Text = "Show Message Box"
        Me.MessageButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MessageButton)
        Me.Name = "Form1"
        Me.Text = "Message Box"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MessageButton As Button
End Class
