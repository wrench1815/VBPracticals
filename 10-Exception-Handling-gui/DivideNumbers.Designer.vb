<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Num1Input = New System.Windows.Forms.TextBox()
        Me.Num1Label = New System.Windows.Forms.Label()
        Me.Num2Label = New System.Windows.Forms.Label()
        Me.Num2Input = New System.Windows.Forms.TextBox()
        Me.SubmitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(0, 50, 0, 0)
        Me.Label1.Size = New System.Drawing.Size(800, 450)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter two Numbers to Divide"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Num1Input
        '
        Me.Num1Input.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Num1Input.Location = New System.Drawing.Point(383, 84)
        Me.Num1Input.Name = "Num1Input"
        Me.Num1Input.Size = New System.Drawing.Size(100, 29)
        Me.Num1Input.TabIndex = 1
        '
        'Num1Label
        '
        Me.Num1Label.AutoSize = True
        Me.Num1Label.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Num1Label.Location = New System.Drawing.Point(288, 84)
        Me.Num1Label.Name = "Num1Label"
        Me.Num1Label.Size = New System.Drawing.Size(71, 28)
        Me.Num1Label.TabIndex = 4
        Me.Num1Label.Text = "Num 1"
        '
        'Num2Label
        '
        Me.Num2Label.AutoSize = True
        Me.Num2Label.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Num2Label.Location = New System.Drawing.Point(288, 129)
        Me.Num2Label.Name = "Num2Label"
        Me.Num2Label.Size = New System.Drawing.Size(71, 28)
        Me.Num2Label.TabIndex = 5
        Me.Num2Label.Text = "Num 2"
        '
        'Num2Input
        '
        Me.Num2Input.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Num2Input.Location = New System.Drawing.Point(383, 132)
        Me.Num2Input.Name = "Num2Input"
        Me.Num2Input.Size = New System.Drawing.Size(100, 29)
        Me.Num2Input.TabIndex = 6
        '
        'SubmitButton
        '
        Me.SubmitButton.BackColor = System.Drawing.SystemColors.Control
        Me.SubmitButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.SubmitButton.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.SubmitButton.Location = New System.Drawing.Point(347, 186)
        Me.SubmitButton.Name = "SubmitButton"
        Me.SubmitButton.Size = New System.Drawing.Size(86, 39)
        Me.SubmitButton.TabIndex = 7
        Me.SubmitButton.Text = "Divide"
        Me.SubmitButton.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.SubmitButton)
        Me.Controls.Add(Me.Num2Input)
        Me.Controls.Add(Me.Num2Label)
        Me.Controls.Add(Me.Num1Label)
        Me.Controls.Add(Me.Num1Input)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Divide 2 Numbers"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Num1Input As TextBox
    Friend WithEvents Num1Label As Label
    Friend WithEvents Num2Label As Label
    Friend WithEvents Num2Input As TextBox
    Friend WithEvents SubmitButton As Button

    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        ' On Click on Divide, Grab Num 1 and Num 2 from Textboxes
        ' Then Try to divide it.
        ' If 2nd number is 0, Raise and Exception
        Try
            Dim num1 As Integer = Num1Input.Text
            Dim num2 As Integer = Num2Input.Text
            Dim div As Integer

            If num2 = 0 Then
                Throw New Exception("Cannot Divide by Zero")
            End If

            div = num1 / num2

            MessageBox.Show(div, "Result")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        End Try
    End Sub
End Class
