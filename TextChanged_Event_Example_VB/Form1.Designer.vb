﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.InputTextBox = New System.Windows.Forms.TextBox()
        Me.OutputLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'InputTextBox
        '
        Me.InputTextBox.Location = New System.Drawing.Point(78, 56)
        Me.InputTextBox.Name = "InputTextBox"
        Me.InputTextBox.Size = New System.Drawing.Size(100, 20)
        Me.InputTextBox.TabIndex = 0
        '
        'OutputLabel
        '
        Me.OutputLabel.AutoSize = True
        Me.OutputLabel.Location = New System.Drawing.Point(104, 131)
        Me.OutputLabel.Name = "OutputLabel"
        Me.OutputLabel.Size = New System.Drawing.Size(65, 13)
        Me.OutputLabel.TabIndex = 1
        Me.OutputLabel.Text = "OutputLabel"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.OutputLabel)
        Me.Controls.Add(Me.InputTextBox)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents InputTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OutputLabel As System.Windows.Forms.Label

End Class
