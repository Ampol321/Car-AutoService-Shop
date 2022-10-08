<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Vehicles
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Vehicles))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtvprob = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.vdelete = New System.Windows.Forms.Button()
        Me.txtvmile = New System.Windows.Forms.TextBox()
        Me.vupdate = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.vread = New System.Windows.Forms.Button()
        Me.vreset = New System.Windows.Forms.Button()
        Me.vcreate = New System.Windows.Forms.Button()
        Me.txtmfname = New System.Windows.Forms.TextBox()
        Me.VehicleView = New System.Windows.Forms.DataGridView()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtvid = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtcname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbomodels = New System.Windows.Forms.ComboBox()
        Me.cboctype = New System.Windows.Forms.ComboBox()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VehicleView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Montserrat", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(118, 14)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(199, 48)
        Me.Label6.TabIndex = 69
        Me.Label6.Text = "VEHICLES"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.Dellova_Auto_Acme_Service_Center.My.Resources.Resources._8
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.TabIndex = 68
        Me.PictureBox1.TabStop = False
        '
        'txtvprob
        '
        Me.txtvprob.Location = New System.Drawing.Point(126, 297)
        Me.txtvprob.Name = "txtvprob"
        Me.txtvprob.Size = New System.Drawing.Size(100, 20)
        Me.txtvprob.TabIndex = 62
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(50, 298)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 19)
        Me.Label9.TabIndex = 61
        Me.Label9.Text = "Problem:"
        '
        'vdelete
        '
        Me.vdelete.BackColor = System.Drawing.SystemColors.Control
        Me.vdelete.BackgroundImage = CType(resources.GetObject("vdelete.BackgroundImage"), System.Drawing.Image)
        Me.vdelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.vdelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.vdelete.Font = New System.Drawing.Font("Roboto Cn", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vdelete.Location = New System.Drawing.Point(579, 366)
        Me.vdelete.Name = "vdelete"
        Me.vdelete.Size = New System.Drawing.Size(75, 30)
        Me.vdelete.TabIndex = 67
        Me.vdelete.Text = "DELETE"
        Me.vdelete.UseVisualStyleBackColor = False
        '
        'txtvmile
        '
        Me.txtvmile.Location = New System.Drawing.Point(126, 271)
        Me.txtvmile.Name = "txtvmile"
        Me.txtvmile.Size = New System.Drawing.Size(100, 20)
        Me.txtvmile.TabIndex = 60
        '
        'vupdate
        '
        Me.vupdate.BackColor = System.Drawing.SystemColors.Control
        Me.vupdate.BackgroundImage = CType(resources.GetObject("vupdate.BackgroundImage"), System.Drawing.Image)
        Me.vupdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.vupdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.vupdate.Font = New System.Drawing.Font("Roboto Cn", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vupdate.Location = New System.Drawing.Point(498, 366)
        Me.vupdate.Name = "vupdate"
        Me.vupdate.Size = New System.Drawing.Size(75, 30)
        Me.vupdate.TabIndex = 66
        Me.vupdate.Text = "UPDATE"
        Me.vupdate.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(53, 272)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 19)
        Me.Label8.TabIndex = 59
        Me.Label8.Text = "Mileage:"
        '
        'vread
        '
        Me.vread.BackColor = System.Drawing.SystemColors.Control
        Me.vread.BackgroundImage = CType(resources.GetObject("vread.BackgroundImage"), System.Drawing.Image)
        Me.vread.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.vread.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.vread.Font = New System.Drawing.Font("Roboto Cn", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vread.Location = New System.Drawing.Point(417, 366)
        Me.vread.Name = "vread"
        Me.vread.Size = New System.Drawing.Size(75, 30)
        Me.vread.TabIndex = 65
        Me.vread.Text = "READ"
        Me.vread.UseVisualStyleBackColor = False
        '
        'vreset
        '
        Me.vreset.BackColor = System.Drawing.SystemColors.Control
        Me.vreset.BackgroundImage = CType(resources.GetObject("vreset.BackgroundImage"), System.Drawing.Image)
        Me.vreset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.vreset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.vreset.Font = New System.Drawing.Font("Roboto Cn", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vreset.Location = New System.Drawing.Point(126, 323)
        Me.vreset.Name = "vreset"
        Me.vreset.Size = New System.Drawing.Size(100, 30)
        Me.vreset.TabIndex = 58
        Me.vreset.Text = "RESET"
        Me.vreset.UseVisualStyleBackColor = False
        '
        'vcreate
        '
        Me.vcreate.BackColor = System.Drawing.SystemColors.Control
        Me.vcreate.BackgroundImage = CType(resources.GetObject("vcreate.BackgroundImage"), System.Drawing.Image)
        Me.vcreate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.vcreate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.vcreate.Font = New System.Drawing.Font("Roboto Cn", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vcreate.Location = New System.Drawing.Point(336, 366)
        Me.vcreate.Name = "vcreate"
        Me.vcreate.Size = New System.Drawing.Size(75, 30)
        Me.vcreate.TabIndex = 64
        Me.vcreate.Text = "CREATE"
        Me.vcreate.UseVisualStyleBackColor = False
        '
        'txtmfname
        '
        Me.txtmfname.Location = New System.Drawing.Point(126, 245)
        Me.txtmfname.Name = "txtmfname"
        Me.txtmfname.Size = New System.Drawing.Size(100, 20)
        Me.txtmfname.TabIndex = 57
        '
        'VehicleView
        '
        Me.VehicleView.AllowUserToAddRows = False
        Me.VehicleView.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.VehicleView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.VehicleView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.VehicleView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.VehicleView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.VehicleView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.VehicleView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.VehicleView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.VehicleView.ColumnHeadersHeight = 30
        Me.VehicleView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column4, Me.Column3, Me.Column5, Me.Column6, Me.Column7})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.VehicleView.DefaultCellStyle = DataGridViewCellStyle3
        Me.VehicleView.EnableHeadersVisualStyles = False
        Me.VehicleView.Location = New System.Drawing.Point(232, 141)
        Me.VehicleView.Name = "VehicleView"
        Me.VehicleView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.VehicleView.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.VehicleView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.VehicleView.Size = New System.Drawing.Size(578, 176)
        Me.VehicleView.TabIndex = 63
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(12, 246)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(114, 19)
        Me.Label7.TabIndex = 56
        Me.Label7.Text = "Manufacturer:"
        '
        'txtvid
        '
        Me.txtvid.Location = New System.Drawing.Point(126, 141)
        Me.txtvid.Name = "txtvid"
        Me.txtvid.Size = New System.Drawing.Size(100, 20)
        Me.txtvid.TabIndex = 49
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(25, 220)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 19)
        Me.Label5.TabIndex = 54
        Me.Label5.Text = "Model Type:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(33, 142)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 19)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "Vehicle_ID:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(43, 194)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 19)
        Me.Label4.TabIndex = 52
        Me.Label4.Text = "Car Type:"
        '
        'txtcname
        '
        Me.txtcname.Location = New System.Drawing.Point(126, 167)
        Me.txtcname.Name = "txtcname"
        Me.txtcname.Size = New System.Drawing.Size(100, 20)
        Me.txtcname.TabIndex = 51
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(31, 168)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 19)
        Me.Label3.TabIndex = 50
        Me.Label3.Text = "Cust Name:"
        '
        'cbomodels
        '
        Me.cbomodels.FormattingEnabled = True
        Me.cbomodels.Location = New System.Drawing.Point(126, 218)
        Me.cbomodels.Name = "cbomodels"
        Me.cbomodels.Size = New System.Drawing.Size(100, 21)
        Me.cbomodels.TabIndex = 70
        '
        'cboctype
        '
        Me.cboctype.FormattingEnabled = True
        Me.cboctype.Location = New System.Drawing.Point(126, 192)
        Me.cboctype.Name = "cboctype"
        Me.cboctype.Size = New System.Drawing.Size(100, 21)
        Me.cboctype.TabIndex = 71
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "vehicle_id"
        Me.Column1.HeaderText = "VEHICLE_ID"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 92
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "name"
        Me.Column2.HeaderText = "CUSTOMER"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 91
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "CarType"
        Me.Column4.HeaderText = "CAR TYPE"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 76
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "modeltype"
        Me.Column3.HeaderText = "MODEL TYPE"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 91
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "manufacturername"
        Me.Column5.HeaderText = "MANUFACTURER"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 120
        '
        'Column6
        '
        Me.Column6.DataPropertyName = "mileage"
        Me.Column6.HeaderText = "MILEAGE"
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 77
        '
        'Column7
        '
        Me.Column7.DataPropertyName = "maintenance"
        Me.Column7.HeaderText = "PROBLEM"
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 82
        '
        'Vehicles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Dellova_Auto_Acme_Service_Center.My.Resources.Resources._5
        Me.ClientSize = New System.Drawing.Size(822, 431)
        Me.Controls.Add(Me.cboctype)
        Me.Controls.Add(Me.cbomodels)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtvprob)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.vdelete)
        Me.Controls.Add(Me.txtvmile)
        Me.Controls.Add(Me.vupdate)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.vread)
        Me.Controls.Add(Me.vreset)
        Me.Controls.Add(Me.vcreate)
        Me.Controls.Add(Me.txtmfname)
        Me.Controls.Add(Me.VehicleView)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtvid)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtcname)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Vehicles"
        Me.Text = "Vehicles"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VehicleView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtvprob As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents vdelete As Button
    Friend WithEvents txtvmile As TextBox
    Friend WithEvents vupdate As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents vread As Button
    Friend WithEvents vreset As Button
    Friend WithEvents vcreate As Button
    Friend WithEvents txtmfname As TextBox
    Friend WithEvents VehicleView As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents txtvid As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtcname As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cbomodels As ComboBox
    Friend WithEvents cboctype As ComboBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
End Class
