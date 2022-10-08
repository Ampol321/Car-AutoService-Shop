<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CarModel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CarModel))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.moddelete = New System.Windows.Forms.Button()
        Me.modreset = New System.Windows.Forms.Button()
        Me.modupdate = New System.Windows.Forms.Button()
        Me.txtmodtype = New System.Windows.Forms.TextBox()
        Me.modread = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.modcreate = New System.Windows.Forms.Button()
        Me.txtmodid = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ModelView = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cbomanufacturer = New System.Windows.Forms.ComboBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModelView, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label1.Size = New System.Drawing.Size(267, 48)
        Me.Label1.TabIndex = 79
        Me.Label1.Text = "CAR MODELS"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.Dellova_Auto_Acme_Service_Center.My.Resources.Resources._8
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.TabIndex = 78
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(8, 194)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 19)
        Me.Label4.TabIndex = 71
        Me.Label4.Text = "Manufactured:"
        '
        'moddelete
        '
        Me.moddelete.BackColor = System.Drawing.SystemColors.Control
        Me.moddelete.BackgroundImage = CType(resources.GetObject("moddelete.BackgroundImage"), System.Drawing.Image)
        Me.moddelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.moddelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.moddelete.Font = New System.Drawing.Font("Roboto Cn", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.moddelete.Location = New System.Drawing.Point(579, 366)
        Me.moddelete.Name = "moddelete"
        Me.moddelete.Size = New System.Drawing.Size(75, 30)
        Me.moddelete.TabIndex = 77
        Me.moddelete.Text = "DELETE"
        Me.moddelete.UseVisualStyleBackColor = False
        '
        'modreset
        '
        Me.modreset.BackColor = System.Drawing.SystemColors.Control
        Me.modreset.BackgroundImage = CType(resources.GetObject("modreset.BackgroundImage"), System.Drawing.Image)
        Me.modreset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.modreset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.modreset.Font = New System.Drawing.Font("Roboto Cn", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.modreset.Location = New System.Drawing.Point(126, 219)
        Me.modreset.Name = "modreset"
        Me.modreset.Size = New System.Drawing.Size(100, 30)
        Me.modreset.TabIndex = 70
        Me.modreset.Text = "RESET"
        Me.modreset.UseVisualStyleBackColor = False
        '
        'modupdate
        '
        Me.modupdate.BackColor = System.Drawing.SystemColors.Control
        Me.modupdate.BackgroundImage = CType(resources.GetObject("modupdate.BackgroundImage"), System.Drawing.Image)
        Me.modupdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.modupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.modupdate.Font = New System.Drawing.Font("Roboto Cn", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.modupdate.Location = New System.Drawing.Point(498, 366)
        Me.modupdate.Name = "modupdate"
        Me.modupdate.Size = New System.Drawing.Size(75, 30)
        Me.modupdate.TabIndex = 76
        Me.modupdate.Text = "UPDATE"
        Me.modupdate.UseVisualStyleBackColor = False
        '
        'txtmodtype
        '
        Me.txtmodtype.Location = New System.Drawing.Point(126, 167)
        Me.txtmodtype.Name = "txtmodtype"
        Me.txtmodtype.Size = New System.Drawing.Size(100, 20)
        Me.txtmodtype.TabIndex = 69
        '
        'modread
        '
        Me.modread.BackColor = System.Drawing.SystemColors.Control
        Me.modread.BackgroundImage = CType(resources.GetObject("modread.BackgroundImage"), System.Drawing.Image)
        Me.modread.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.modread.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.modread.Font = New System.Drawing.Font("Roboto Cn", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.modread.Location = New System.Drawing.Point(417, 366)
        Me.modread.Name = "modread"
        Me.modread.Size = New System.Drawing.Size(75, 30)
        Me.modread.TabIndex = 75
        Me.modread.Text = "READ"
        Me.modread.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(24, 168)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 19)
        Me.Label3.TabIndex = 68
        Me.Label3.Text = "Model Type:"
        '
        'modcreate
        '
        Me.modcreate.BackColor = System.Drawing.SystemColors.Control
        Me.modcreate.BackgroundImage = CType(resources.GetObject("modcreate.BackgroundImage"), System.Drawing.Image)
        Me.modcreate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.modcreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.modcreate.Font = New System.Drawing.Font("Roboto Cn", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.modcreate.Location = New System.Drawing.Point(336, 366)
        Me.modcreate.Name = "modcreate"
        Me.modcreate.Size = New System.Drawing.Size(75, 30)
        Me.modcreate.TabIndex = 74
        Me.modcreate.Text = "CREATE"
        Me.modcreate.UseVisualStyleBackColor = False
        '
        'txtmodid
        '
        Me.txtmodid.Location = New System.Drawing.Point(126, 141)
        Me.txtmodid.Name = "txtmodid"
        Me.txtmodid.Size = New System.Drawing.Size(100, 20)
        Me.txtmodid.TabIndex = 67
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(40, 142)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 19)
        Me.Label2.TabIndex = 66
        Me.Label2.Text = "Model_ID:"
        '
        'ModelView
        '
        Me.ModelView.AllowUserToAddRows = False
        Me.ModelView.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.ModelView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.ModelView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ModelView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.ModelView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ModelView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.ModelView.ColumnHeadersHeight = 30
        Me.ModelView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ModelView.DefaultCellStyle = DataGridViewCellStyle3
        Me.ModelView.EnableHeadersVisualStyles = False
        Me.ModelView.Location = New System.Drawing.Point(232, 141)
        Me.ModelView.Name = "ModelView"
        Me.ModelView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ModelView.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.ModelView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ModelView.Size = New System.Drawing.Size(578, 176)
        Me.ModelView.TabIndex = 73
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "model_id"
        Me.Column1.HeaderText = "MODEL_ID"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 179
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "modeltype"
        Me.Column2.HeaderText = "MODEL TYPE"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 179
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "manufacturername"
        Me.Column3.HeaderText = "MANUFACTURER"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 179
        '
        'cbomanufacturer
        '
        Me.cbomanufacturer.FormattingEnabled = True
        Me.cbomanufacturer.Location = New System.Drawing.Point(126, 192)
        Me.cbomanufacturer.Name = "cbomanufacturer"
        Me.cbomanufacturer.Size = New System.Drawing.Size(100, 21)
        Me.cbomanufacturer.TabIndex = 80
        '
        'CarModel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Dellova_Auto_Acme_Service_Center.My.Resources.Resources._5
        Me.ClientSize = New System.Drawing.Size(822, 431)
        Me.Controls.Add(Me.cbomanufacturer)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.moddelete)
        Me.Controls.Add(Me.modreset)
        Me.Controls.Add(Me.modupdate)
        Me.Controls.Add(Me.txtmodtype)
        Me.Controls.Add(Me.modread)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.modcreate)
        Me.Controls.Add(Me.txtmodid)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ModelView)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CarModel"
        Me.Text = "CarModel"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModelView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents moddelete As Button
    Friend WithEvents modreset As Button
    Friend WithEvents modupdate As Button
    Friend WithEvents txtmodtype As TextBox
    Friend WithEvents modread As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents modcreate As Button
    Friend WithEvents txtmodid As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ModelView As DataGridView
    Friend WithEvents cbomanufacturer As ComboBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
End Class
