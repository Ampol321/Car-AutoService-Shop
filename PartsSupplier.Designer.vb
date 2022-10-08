<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PartsSupplier
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PartsSupplier))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cboparts = New System.Windows.Forms.ComboBox()
        Me.cmdsupply = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Montserrat", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(118, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 48)
        Me.Label1.TabIndex = 61
        Me.Label1.Text = "SUPPLY"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.Dellova_Auto_Acme_Service_Center.My.Resources.Resources._8
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.TabIndex = 60
        Me.PictureBox1.TabStop = False
        '
        'cboparts
        '
        Me.cboparts.FormattingEnabled = True
        Me.cboparts.Location = New System.Drawing.Point(99, 113)
        Me.cboparts.Name = "cboparts"
        Me.cboparts.Size = New System.Drawing.Size(121, 21)
        Me.cboparts.TabIndex = 70
        '
        'cmdsupply
        '
        Me.cmdsupply.BackColor = System.Drawing.SystemColors.Control
        Me.cmdsupply.BackgroundImage = CType(resources.GetObject("cmdsupply.BackgroundImage"), System.Drawing.Image)
        Me.cmdsupply.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdsupply.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdsupply.Font = New System.Drawing.Font("Roboto Cn", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdsupply.ForeColor = System.Drawing.Color.Black
        Me.cmdsupply.Location = New System.Drawing.Point(109, 158)
        Me.cmdsupply.Name = "cmdsupply"
        Me.cmdsupply.Size = New System.Drawing.Size(100, 30)
        Me.cmdsupply.TabIndex = 71
        Me.cmdsupply.Text = "SUPPLY"
        Me.cmdsupply.UseVisualStyleBackColor = False
        '
        'PartsSupplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Dellova_Auto_Acme_Service_Center.My.Resources.Resources._5
        Me.ClientSize = New System.Drawing.Size(330, 241)
        Me.Controls.Add(Me.cmdsupply)
        Me.Controls.Add(Me.cboparts)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "PartsSupplier"
        Me.Text = "PartsSupplier"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents cboparts As ComboBox
    Friend WithEvents cmdsupply As Button
End Class
