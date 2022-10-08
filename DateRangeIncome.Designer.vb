<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DateRangeIncome
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
        Me.rangesalesviewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Range1 = New System.Windows.Forms.DateTimePicker()
        Me.Range2 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmdshow = New Guna.UI2.WinForms.Guna2Button()
        Me.SuspendLayout()
        '
        'rangesalesviewer
        '
        Me.rangesalesviewer.ActiveViewIndex = -1
        Me.rangesalesviewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.rangesalesviewer.Cursor = System.Windows.Forms.Cursors.Default
        Me.rangesalesviewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rangesalesviewer.Location = New System.Drawing.Point(0, 0)
        Me.rangesalesviewer.Name = "rangesalesviewer"
        Me.rangesalesviewer.Size = New System.Drawing.Size(800, 450)
        Me.rangesalesviewer.TabIndex = 0
        '
        'Range1
        '
        Me.Range1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Range1.Location = New System.Drawing.Point(74, 133)
        Me.Range1.Name = "Range1"
        Me.Range1.Size = New System.Drawing.Size(108, 20)
        Me.Range1.TabIndex = 1
        '
        'Range2
        '
        Me.Range2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Range2.Location = New System.Drawing.Point(74, 170)
        Me.Range2.Name = "Range2"
        Me.Range2.Size = New System.Drawing.Size(108, 20)
        Me.Range2.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Montserrat", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 29)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Date Income"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 131)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 22)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "From:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(37, 168)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 22)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "To:"
        '
        'cmdshow
        '
        Me.cmdshow.BorderRadius = 17
        Me.cmdshow.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.cmdshow.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.cmdshow.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.cmdshow.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.cmdshow.Font = New System.Drawing.Font("Montserrat", 12.0!)
        Me.cmdshow.ForeColor = System.Drawing.Color.White
        Me.cmdshow.Location = New System.Drawing.Point(27, 219)
        Me.cmdshow.Name = "cmdshow"
        Me.cmdshow.Size = New System.Drawing.Size(149, 37)
        Me.cmdshow.TabIndex = 6
        Me.cmdshow.Text = "Show"
        '
        'DateRangeIncome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.cmdshow)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Range2)
        Me.Controls.Add(Me.Range1)
        Me.Controls.Add(Me.rangesalesviewer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "DateRangeIncome"
        Me.Text = "DateRangeIncome"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rangesalesviewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Range1 As DateTimePicker
    Friend WithEvents Range2 As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cmdshow As Guna.UI2.WinForms.Guna2Button
End Class
