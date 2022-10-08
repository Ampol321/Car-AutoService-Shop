<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Customers
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Customers))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.creset = New System.Windows.Forms.Button()
        Me.txtczip = New System.Windows.Forms.TextBox()
        Me.cdelete = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cupdate = New System.Windows.Forms.Button()
        Me.txtcstreet = New System.Windows.Forms.TextBox()
        Me.cread = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ccreate = New System.Windows.Forms.Button()
        Me.txtccity = New System.Windows.Forms.TextBox()
        Me.CustomerView = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtcemail = New System.Windows.Forms.TextBox()
        Me.txtcid = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtcphone = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtcname = New System.Windows.Forms.TextBox()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Montserrat", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(118, 14)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(252, 48)
        Me.Label9.TabIndex = 67
        Me.Label9.Text = "CUSTOMERS"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.Dellova_Auto_Acme_Service_Center.My.Resources.Resources._8
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.TabIndex = 66
        Me.PictureBox1.TabStop = False
        '
        'creset
        '
        Me.creset.BackColor = System.Drawing.SystemColors.Control
        Me.creset.BackgroundImage = CType(resources.GetObject("creset.BackgroundImage"), System.Drawing.Image)
        Me.creset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.creset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.creset.Font = New System.Drawing.Font("Roboto Cn", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.creset.ForeColor = System.Drawing.Color.Black
        Me.creset.Location = New System.Drawing.Point(126, 326)
        Me.creset.Name = "creset"
        Me.creset.Size = New System.Drawing.Size(100, 30)
        Me.creset.TabIndex = 65
        Me.creset.Text = "RESET"
        Me.creset.UseVisualStyleBackColor = False
        '
        'txtczip
        '
        Me.txtczip.Location = New System.Drawing.Point(126, 300)
        Me.txtczip.Name = "txtczip"
        Me.txtczip.Size = New System.Drawing.Size(100, 20)
        Me.txtczip.TabIndex = 60
        '
        'cdelete
        '
        Me.cdelete.BackColor = System.Drawing.SystemColors.Control
        Me.cdelete.BackgroundImage = CType(resources.GetObject("cdelete.BackgroundImage"), System.Drawing.Image)
        Me.cdelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cdelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cdelete.Font = New System.Drawing.Font("Roboto Cn", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cdelete.ForeColor = System.Drawing.Color.Black
        Me.cdelete.Location = New System.Drawing.Point(579, 366)
        Me.cdelete.Name = "cdelete"
        Me.cdelete.Size = New System.Drawing.Size(75, 30)
        Me.cdelete.TabIndex = 64
        Me.cdelete.Text = "DELETE"
        Me.cdelete.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(46, 301)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 19)
        Me.Label8.TabIndex = 59
        Me.Label8.Text = "ZipCode:"
        '
        'cupdate
        '
        Me.cupdate.BackColor = System.Drawing.SystemColors.Control
        Me.cupdate.BackgroundImage = CType(resources.GetObject("cupdate.BackgroundImage"), System.Drawing.Image)
        Me.cupdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cupdate.Font = New System.Drawing.Font("Roboto Cn", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cupdate.ForeColor = System.Drawing.Color.Black
        Me.cupdate.Location = New System.Drawing.Point(498, 366)
        Me.cupdate.Name = "cupdate"
        Me.cupdate.Size = New System.Drawing.Size(75, 30)
        Me.cupdate.TabIndex = 63
        Me.cupdate.Text = "UPDATE"
        Me.cupdate.UseVisualStyleBackColor = False
        '
        'txtcstreet
        '
        Me.txtcstreet.Location = New System.Drawing.Point(126, 274)
        Me.txtcstreet.Name = "txtcstreet"
        Me.txtcstreet.Size = New System.Drawing.Size(100, 20)
        Me.txtcstreet.TabIndex = 58
        '
        'cread
        '
        Me.cread.BackColor = System.Drawing.SystemColors.Control
        Me.cread.BackgroundImage = CType(resources.GetObject("cread.BackgroundImage"), System.Drawing.Image)
        Me.cread.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cread.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cread.Font = New System.Drawing.Font("Roboto Cn", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cread.ForeColor = System.Drawing.Color.Black
        Me.cread.Location = New System.Drawing.Point(417, 366)
        Me.cread.Name = "cread"
        Me.cread.Size = New System.Drawing.Size(75, 30)
        Me.cread.TabIndex = 62
        Me.cread.Text = "READ"
        Me.cread.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(65, 275)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 19)
        Me.Label7.TabIndex = 57
        Me.Label7.Text = "Street:"
        '
        'ccreate
        '
        Me.ccreate.BackColor = System.Drawing.SystemColors.Control
        Me.ccreate.BackgroundImage = CType(resources.GetObject("ccreate.BackgroundImage"), System.Drawing.Image)
        Me.ccreate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ccreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ccreate.Font = New System.Drawing.Font("Roboto Cn", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ccreate.ForeColor = System.Drawing.Color.Black
        Me.ccreate.Location = New System.Drawing.Point(336, 366)
        Me.ccreate.Name = "ccreate"
        Me.ccreate.Size = New System.Drawing.Size(75, 30)
        Me.ccreate.TabIndex = 61
        Me.ccreate.Text = "CREATE"
        Me.ccreate.UseVisualStyleBackColor = False
        '
        'txtccity
        '
        Me.txtccity.Location = New System.Drawing.Point(126, 248)
        Me.txtccity.Name = "txtccity"
        Me.txtccity.Size = New System.Drawing.Size(100, 20)
        Me.txtccity.TabIndex = 56
        '
        'CustomerView
        '
        Me.CustomerView.AllowUserToAddRows = False
        Me.CustomerView.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.CustomerView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.CustomerView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.CustomerView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.CustomerView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CustomerView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.CustomerView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CustomerView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.CustomerView.ColumnHeadersHeight = 30
        Me.CustomerView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CustomerView.DefaultCellStyle = DataGridViewCellStyle3
        Me.CustomerView.EnableHeadersVisualStyles = False
        Me.CustomerView.Location = New System.Drawing.Point(232, 141)
        Me.CustomerView.Name = "CustomerView"
        Me.CustomerView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CustomerView.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.CustomerView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.CustomerView.Size = New System.Drawing.Size(578, 176)
        Me.CustomerView.TabIndex = 46
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(79, 249)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 19)
        Me.Label6.TabIndex = 55
        Me.Label6.Text = "City:"
        '
        'txtcemail
        '
        Me.txtcemail.Location = New System.Drawing.Point(126, 222)
        Me.txtcemail.Name = "txtcemail"
        Me.txtcemail.Size = New System.Drawing.Size(100, 20)
        Me.txtcemail.TabIndex = 54
        '
        'txtcid
        '
        Me.txtcid.Location = New System.Drawing.Point(126, 142)
        Me.txtcid.Name = "txtcid"
        Me.txtcid.Size = New System.Drawing.Size(100, 20)
        Me.txtcid.TabIndex = 48
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(68, 223)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 19)
        Me.Label5.TabIndex = 53
        Me.Label5.Text = "Email:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 145)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 19)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "Customer_ID:"
        '
        'txtcphone
        '
        Me.txtcphone.Location = New System.Drawing.Point(126, 196)
        Me.txtcphone.Name = "txtcphone"
        Me.txtcphone.Size = New System.Drawing.Size(100, 20)
        Me.txtcphone.TabIndex = 52
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(65, 171)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 19)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(64, 197)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 19)
        Me.Label4.TabIndex = 51
        Me.Label4.Text = "Phone:"
        '
        'txtcname
        '
        Me.txtcname.Location = New System.Drawing.Point(126, 170)
        Me.txtcname.Name = "txtcname"
        Me.txtcname.Size = New System.Drawing.Size(100, 20)
        Me.txtcname.TabIndex = 50
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "CUSTOMER_ID"
        Me.Column1.HeaderText = "CUSTOMER_ID"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 108
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "Name"
        Me.Column2.HeaderText = "NAME"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 61
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "Phone"
        Me.Column3.HeaderText = "PHONE"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 68
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "Email"
        Me.Column4.HeaderText = "EMAIL"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 62
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "City"
        Me.Column5.HeaderText = "CITY"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 54
        '
        'Column6
        '
        Me.Column6.DataPropertyName = "Street"
        Me.Column6.HeaderText = "STREET"
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 73
        '
        'Column7
        '
        Me.Column7.DataPropertyName = "ZipCode"
        Me.Column7.HeaderText = "ZIPCODE"
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 77
        '
        'Customers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Dellova_Auto_Acme_Service_Center.My.Resources.Resources._5
        Me.ClientSize = New System.Drawing.Size(822, 431)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.creset)
        Me.Controls.Add(Me.txtczip)
        Me.Controls.Add(Me.cdelete)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cupdate)
        Me.Controls.Add(Me.txtcstreet)
        Me.Controls.Add(Me.cread)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ccreate)
        Me.Controls.Add(Me.txtccity)
        Me.Controls.Add(Me.CustomerView)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtcemail)
        Me.Controls.Add(Me.txtcid)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtcphone)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtcname)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Customers"
        Me.Text = "Customers"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label9 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents creset As Button
    Friend WithEvents txtczip As TextBox
    Friend WithEvents cdelete As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents cupdate As Button
    Friend WithEvents txtcstreet As TextBox
    Friend WithEvents cread As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents ccreate As Button
    Friend WithEvents txtccity As TextBox
    Friend WithEvents CustomerView As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents txtcemail As TextBox
    Friend WithEvents txtcid As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtcphone As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtcname As TextBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
End Class
