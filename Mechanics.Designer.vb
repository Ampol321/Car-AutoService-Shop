<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mechanics
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Mechanics))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.cmdassign = New System.Windows.Forms.Button()
        Me.txtmname = New System.Windows.Forms.TextBox()
        Me.txtmphone = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.mreset = New System.Windows.Forms.Button()
        Me.txtmzip = New System.Windows.Forms.TextBox()
        Me.mdelete = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.mupdate = New System.Windows.Forms.Button()
        Me.txtmstreet = New System.Windows.Forms.TextBox()
        Me.mread = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.mcreate = New System.Windows.Forms.Button()
        Me.txtmcity = New System.Windows.Forms.TextBox()
        Me.MechanicView = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtmid = New System.Windows.Forms.TextBox()
        Me.txtmbday = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MechanicView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdassign
        '
        Me.cmdassign.BackColor = System.Drawing.SystemColors.Control
        Me.cmdassign.BackgroundImage = CType(resources.GetObject("cmdassign.BackgroundImage"), System.Drawing.Image)
        Me.cmdassign.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdassign.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdassign.Font = New System.Drawing.Font("Roboto Cn", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdassign.Location = New System.Drawing.Point(126, 323)
        Me.cmdassign.Name = "cmdassign"
        Me.cmdassign.Size = New System.Drawing.Size(100, 30)
        Me.cmdassign.TabIndex = 85
        Me.cmdassign.Text = "ASSIGN"
        Me.cmdassign.UseVisualStyleBackColor = False
        '
        'txtmname
        '
        Me.txtmname.Location = New System.Drawing.Point(126, 167)
        Me.txtmname.Name = "txtmname"
        Me.txtmname.Size = New System.Drawing.Size(100, 20)
        Me.txtmname.TabIndex = 66
        '
        'txtmphone
        '
        Me.txtmphone.Location = New System.Drawing.Point(126, 193)
        Me.txtmphone.Name = "txtmphone"
        Me.txtmphone.Size = New System.Drawing.Size(100, 20)
        Me.txtmphone.TabIndex = 82
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Montserrat", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(118, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(244, 48)
        Me.Label1.TabIndex = 84
        Me.Label1.Text = "MECHANICS"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(70, 194)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 19)
        Me.Label7.TabIndex = 81
        Me.Label7.Text = "Phone:"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.Dellova_Auto_Acme_Service_Center.My.Resources.Resources._8
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.TabIndex = 83
        Me.PictureBox1.TabStop = False
        '
        'mreset
        '
        Me.mreset.BackColor = System.Drawing.SystemColors.Control
        Me.mreset.BackgroundImage = CType(resources.GetObject("mreset.BackgroundImage"), System.Drawing.Image)
        Me.mreset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.mreset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.mreset.Font = New System.Drawing.Font("Roboto Cn", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mreset.Location = New System.Drawing.Point(126, 359)
        Me.mreset.Name = "mreset"
        Me.mreset.Size = New System.Drawing.Size(100, 30)
        Me.mreset.TabIndex = 79
        Me.mreset.Text = "RESET"
        Me.mreset.UseVisualStyleBackColor = False
        '
        'txtmzip
        '
        Me.txtmzip.Location = New System.Drawing.Point(126, 297)
        Me.txtmzip.Name = "txtmzip"
        Me.txtmzip.Size = New System.Drawing.Size(100, 20)
        Me.txtmzip.TabIndex = 74
        '
        'mdelete
        '
        Me.mdelete.BackColor = System.Drawing.SystemColors.Control
        Me.mdelete.BackgroundImage = CType(resources.GetObject("mdelete.BackgroundImage"), System.Drawing.Image)
        Me.mdelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.mdelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.mdelete.Font = New System.Drawing.Font("Roboto Cn", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mdelete.Location = New System.Drawing.Point(579, 366)
        Me.mdelete.Name = "mdelete"
        Me.mdelete.Size = New System.Drawing.Size(75, 30)
        Me.mdelete.TabIndex = 80
        Me.mdelete.Text = "DELETE"
        Me.mdelete.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(52, 298)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 19)
        Me.Label8.TabIndex = 73
        Me.Label8.Text = "ZipCode:"
        '
        'mupdate
        '
        Me.mupdate.BackColor = System.Drawing.SystemColors.Control
        Me.mupdate.BackgroundImage = CType(resources.GetObject("mupdate.BackgroundImage"), System.Drawing.Image)
        Me.mupdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.mupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.mupdate.Font = New System.Drawing.Font("Roboto Cn", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mupdate.Location = New System.Drawing.Point(498, 366)
        Me.mupdate.Name = "mupdate"
        Me.mupdate.Size = New System.Drawing.Size(75, 30)
        Me.mupdate.TabIndex = 78
        Me.mupdate.Text = "UPDATE"
        Me.mupdate.UseVisualStyleBackColor = False
        '
        'txtmstreet
        '
        Me.txtmstreet.Location = New System.Drawing.Point(126, 271)
        Me.txtmstreet.Name = "txtmstreet"
        Me.txtmstreet.Size = New System.Drawing.Size(100, 20)
        Me.txtmstreet.TabIndex = 72
        '
        'mread
        '
        Me.mread.BackColor = System.Drawing.SystemColors.Control
        Me.mread.BackgroundImage = CType(resources.GetObject("mread.BackgroundImage"), System.Drawing.Image)
        Me.mread.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.mread.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.mread.Font = New System.Drawing.Font("Roboto Cn", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mread.Location = New System.Drawing.Point(417, 366)
        Me.mread.Name = "mread"
        Me.mread.Size = New System.Drawing.Size(75, 30)
        Me.mread.TabIndex = 77
        Me.mread.Text = "READ"
        Me.mread.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(71, 272)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 19)
        Me.Label6.TabIndex = 71
        Me.Label6.Text = "Street:"
        '
        'mcreate
        '
        Me.mcreate.BackColor = System.Drawing.SystemColors.Control
        Me.mcreate.BackgroundImage = CType(resources.GetObject("mcreate.BackgroundImage"), System.Drawing.Image)
        Me.mcreate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.mcreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.mcreate.Font = New System.Drawing.Font("Roboto Cn", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mcreate.Location = New System.Drawing.Point(336, 366)
        Me.mcreate.Name = "mcreate"
        Me.mcreate.Size = New System.Drawing.Size(75, 30)
        Me.mcreate.TabIndex = 76
        Me.mcreate.Text = "CREATE"
        Me.mcreate.UseVisualStyleBackColor = False
        '
        'txtmcity
        '
        Me.txtmcity.Location = New System.Drawing.Point(126, 245)
        Me.txtmcity.Name = "txtmcity"
        Me.txtmcity.Size = New System.Drawing.Size(100, 20)
        Me.txtmcity.TabIndex = 70
        '
        'MechanicView
        '
        Me.MechanicView.AllowUserToAddRows = False
        Me.MechanicView.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.MechanicView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.MechanicView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.MechanicView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.MechanicView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MechanicView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.MechanicView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MechanicView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.MechanicView.ColumnHeadersHeight = 30
        Me.MechanicView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MechanicView.DefaultCellStyle = DataGridViewCellStyle3
        Me.MechanicView.EnableHeadersVisualStyles = False
        Me.MechanicView.Location = New System.Drawing.Point(232, 141)
        Me.MechanicView.Name = "MechanicView"
        Me.MechanicView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MechanicView.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.MechanicView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MechanicView.Size = New System.Drawing.Size(578, 176)
        Me.MechanicView.TabIndex = 75
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(85, 246)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 19)
        Me.Label5.TabIndex = 69
        Me.Label5.Text = "City:"
        '
        'txtmid
        '
        Me.txtmid.Location = New System.Drawing.Point(126, 141)
        Me.txtmid.Name = "txtmid"
        Me.txtmid.Size = New System.Drawing.Size(100, 20)
        Me.txtmid.TabIndex = 64
        '
        'txtmbday
        '
        Me.txtmbday.Location = New System.Drawing.Point(126, 219)
        Me.txtmbday.Name = "txtmbday"
        Me.txtmbday.Size = New System.Drawing.Size(100, 20)
        Me.txtmbday.TabIndex = 68
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(20, 142)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 19)
        Me.Label2.TabIndex = 63
        Me.Label2.Text = "Mechanic_ID:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(53, 219)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 19)
        Me.Label4.TabIndex = 67
        Me.Label4.Text = "Birthday:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(71, 168)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 19)
        Me.Label3.TabIndex = 65
        Me.Label3.Text = "Name:"
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "Mechanic_ID"
        Me.Column1.HeaderText = "MECHANIC_ID"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 103
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "mechanicname"
        Me.Column2.HeaderText = "MECHANIC"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 86
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "phone"
        Me.Column3.HeaderText = "PHONE"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 68
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "birthday"
        Me.Column4.HeaderText = "BIRTHDAY"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 85
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "city"
        Me.Column5.HeaderText = "CITY"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 54
        '
        'Column6
        '
        Me.Column6.DataPropertyName = "street"
        Me.Column6.HeaderText = "STREET"
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 73
        '
        'Column7
        '
        Me.Column7.DataPropertyName = "zipcode"
        Me.Column7.HeaderText = "ZIPCODE"
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 77
        '
        'Mechanics
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Dellova_Auto_Acme_Service_Center.My.Resources.Resources._5
        Me.ClientSize = New System.Drawing.Size(822, 431)
        Me.Controls.Add(Me.cmdassign)
        Me.Controls.Add(Me.txtmname)
        Me.Controls.Add(Me.txtmphone)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.mreset)
        Me.Controls.Add(Me.txtmzip)
        Me.Controls.Add(Me.mdelete)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.mupdate)
        Me.Controls.Add(Me.txtmstreet)
        Me.Controls.Add(Me.mread)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.mcreate)
        Me.Controls.Add(Me.txtmcity)
        Me.Controls.Add(Me.MechanicView)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtmid)
        Me.Controls.Add(Me.txtmbday)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Mechanics"
        Me.Text = "Mechanics"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MechanicView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdassign As Button
    Friend WithEvents txtmname As TextBox
    Friend WithEvents txtmphone As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents mreset As Button
    Friend WithEvents txtmzip As TextBox
    Friend WithEvents mdelete As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents mupdate As Button
    Friend WithEvents txtmstreet As TextBox
    Friend WithEvents mread As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents mcreate As Button
    Friend WithEvents txtmcity As TextBox
    Friend WithEvents MechanicView As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents txtmid As TextBox
    Friend WithEvents txtmbday As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
End Class
