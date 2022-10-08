<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Manufacturers
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Manufacturers))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtmfemail = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.mfdelete = New System.Windows.Forms.Button()
        Me.mfreset = New System.Windows.Forms.Button()
        Me.mfupdate = New System.Windows.Forms.Button()
        Me.txtmfname = New System.Windows.Forms.TextBox()
        Me.mfread = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.mfcreate = New System.Windows.Forms.Button()
        Me.txtmfid = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ManufacturerView = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ManufacturerView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Montserrat", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(107, 14)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(335, 48)
        Me.Label9.TabIndex = 61
        Me.Label9.Text = "MANUFACTURER"
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
        'txtmfemail
        '
        Me.txtmfemail.Location = New System.Drawing.Point(126, 196)
        Me.txtmfemail.Name = "txtmfemail"
        Me.txtmfemail.Size = New System.Drawing.Size(100, 20)
        Me.txtmfemail.TabIndex = 58
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(71, 197)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 19)
        Me.Label4.TabIndex = 56
        Me.Label4.Text = "Email:"
        '
        'mfdelete
        '
        Me.mfdelete.BackColor = System.Drawing.SystemColors.Control
        Me.mfdelete.BackgroundImage = CType(resources.GetObject("mfdelete.BackgroundImage"), System.Drawing.Image)
        Me.mfdelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.mfdelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.mfdelete.Font = New System.Drawing.Font("Roboto Cn", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mfdelete.Location = New System.Drawing.Point(579, 366)
        Me.mfdelete.Name = "mfdelete"
        Me.mfdelete.Size = New System.Drawing.Size(75, 30)
        Me.mfdelete.TabIndex = 59
        Me.mfdelete.Text = "DELETE"
        Me.mfdelete.UseVisualStyleBackColor = False
        '
        'mfreset
        '
        Me.mfreset.BackColor = System.Drawing.SystemColors.Control
        Me.mfreset.BackgroundImage = CType(resources.GetObject("mfreset.BackgroundImage"), System.Drawing.Image)
        Me.mfreset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.mfreset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.mfreset.Font = New System.Drawing.Font("Roboto Cn", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mfreset.Location = New System.Drawing.Point(126, 222)
        Me.mfreset.Name = "mfreset"
        Me.mfreset.Size = New System.Drawing.Size(100, 30)
        Me.mfreset.TabIndex = 54
        Me.mfreset.Text = "RESET"
        Me.mfreset.UseVisualStyleBackColor = False
        '
        'mfupdate
        '
        Me.mfupdate.BackColor = System.Drawing.SystemColors.Control
        Me.mfupdate.BackgroundImage = CType(resources.GetObject("mfupdate.BackgroundImage"), System.Drawing.Image)
        Me.mfupdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.mfupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.mfupdate.Font = New System.Drawing.Font("Roboto Cn", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mfupdate.Location = New System.Drawing.Point(498, 366)
        Me.mfupdate.Name = "mfupdate"
        Me.mfupdate.Size = New System.Drawing.Size(75, 30)
        Me.mfupdate.TabIndex = 57
        Me.mfupdate.Text = "UPDATE"
        Me.mfupdate.UseVisualStyleBackColor = False
        '
        'txtmfname
        '
        Me.txtmfname.Location = New System.Drawing.Point(126, 169)
        Me.txtmfname.Name = "txtmfname"
        Me.txtmfname.Size = New System.Drawing.Size(100, 20)
        Me.txtmfname.TabIndex = 51
        '
        'mfread
        '
        Me.mfread.BackColor = System.Drawing.SystemColors.Control
        Me.mfread.BackgroundImage = CType(resources.GetObject("mfread.BackgroundImage"), System.Drawing.Image)
        Me.mfread.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.mfread.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.mfread.Font = New System.Drawing.Font("Roboto Cn", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mfread.Location = New System.Drawing.Point(417, 366)
        Me.mfread.Name = "mfread"
        Me.mfread.Size = New System.Drawing.Size(75, 30)
        Me.mfread.TabIndex = 55
        Me.mfread.Text = "READ"
        Me.mfread.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(68, 170)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 19)
        Me.Label3.TabIndex = 50
        Me.Label3.Text = "Name:"
        '
        'mfcreate
        '
        Me.mfcreate.BackColor = System.Drawing.SystemColors.Control
        Me.mfcreate.BackgroundImage = CType(resources.GetObject("mfcreate.BackgroundImage"), System.Drawing.Image)
        Me.mfcreate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.mfcreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.mfcreate.Font = New System.Drawing.Font("Roboto Cn", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mfcreate.Location = New System.Drawing.Point(336, 366)
        Me.mfcreate.Name = "mfcreate"
        Me.mfcreate.Size = New System.Drawing.Size(75, 30)
        Me.mfcreate.TabIndex = 53
        Me.mfcreate.Text = "CREATE"
        Me.mfcreate.UseVisualStyleBackColor = False
        '
        'txtmfid
        '
        Me.txtmfid.Location = New System.Drawing.Point(126, 141)
        Me.txtmfid.Name = "txtmfid"
        Me.txtmfid.Size = New System.Drawing.Size(100, 20)
        Me.txtmfid.TabIndex = 49
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 142)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 19)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "Manufacturer:"
        '
        'ManufacturerView
        '
        Me.ManufacturerView.AllowUserToAddRows = False
        Me.ManufacturerView.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.ManufacturerView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.ManufacturerView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ManufacturerView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ManufacturerView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.ManufacturerView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ManufacturerView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.ManufacturerView.ColumnHeadersHeight = 30
        Me.ManufacturerView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ManufacturerView.DefaultCellStyle = DataGridViewCellStyle3
        Me.ManufacturerView.EnableHeadersVisualStyles = False
        Me.ManufacturerView.Location = New System.Drawing.Point(232, 141)
        Me.ManufacturerView.Name = "ManufacturerView"
        Me.ManufacturerView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ManufacturerView.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.ManufacturerView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ManufacturerView.Size = New System.Drawing.Size(578, 176)
        Me.ManufacturerView.TabIndex = 52
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "manufacturer_id"
        Me.Column1.HeaderText = "MANUFACTURER_ID"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "manufacturername"
        Me.Column2.HeaderText = "MANUFACTURER"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "email"
        Me.Column3.HeaderText = "EMAIL"
        Me.Column3.Name = "Column3"
        '
        'Manufacturers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Dellova_Auto_Acme_Service_Center.My.Resources.Resources._5
        Me.ClientSize = New System.Drawing.Size(822, 431)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtmfemail)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.mfdelete)
        Me.Controls.Add(Me.mfreset)
        Me.Controls.Add(Me.mfupdate)
        Me.Controls.Add(Me.txtmfname)
        Me.Controls.Add(Me.mfread)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.mfcreate)
        Me.Controls.Add(Me.txtmfid)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ManufacturerView)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Manufacturers"
        Me.Text = "Manufacturers"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ManufacturerView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label9 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtmfemail As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents mfdelete As Button
    Friend WithEvents mfreset As Button
    Friend WithEvents mfupdate As Button
    Friend WithEvents txtmfname As TextBox
    Friend WithEvents mfread As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents mfcreate As Button
    Friend WithEvents txtmfid As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ManufacturerView As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
End Class
