<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Services
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Services))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtsfee = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmdavail = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.svreset = New System.Windows.Forms.Button()
        Me.svdelete = New System.Windows.Forms.Button()
        Me.svupdate = New System.Windows.Forms.Button()
        Me.txtsvtype = New System.Windows.Forms.TextBox()
        Me.svread = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.svcreate = New System.Windows.Forms.Button()
        Me.txtsvid = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ServiceView = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ServiceView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtsfee
        '
        Me.txtsfee.Location = New System.Drawing.Point(126, 193)
        Me.txtsfee.Name = "txtsfee"
        Me.txtsfee.Size = New System.Drawing.Size(100, 20)
        Me.txtsfee.TabIndex = 81
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(20, 194)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 19)
        Me.Label4.TabIndex = 80
        Me.Label4.Text = "Service Fee:"
        '
        'cmdavail
        '
        Me.cmdavail.BackColor = System.Drawing.SystemColors.Control
        Me.cmdavail.BackgroundImage = CType(resources.GetObject("cmdavail.BackgroundImage"), System.Drawing.Image)
        Me.cmdavail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdavail.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdavail.Font = New System.Drawing.Font("Roboto Cn", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdavail.Location = New System.Drawing.Point(126, 219)
        Me.cmdavail.Name = "cmdavail"
        Me.cmdavail.Size = New System.Drawing.Size(100, 30)
        Me.cmdavail.TabIndex = 79
        Me.cmdavail.Text = "AVAIL"
        Me.cmdavail.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Montserrat", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(118, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(198, 48)
        Me.Label1.TabIndex = 78
        Me.Label1.Text = "SERVICES"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.Dellova_Auto_Acme_Service_Center.My.Resources.Resources._8
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.TabIndex = 77
        Me.PictureBox1.TabStop = False
        '
        'svreset
        '
        Me.svreset.BackColor = System.Drawing.SystemColors.Control
        Me.svreset.BackgroundImage = CType(resources.GetObject("svreset.BackgroundImage"), System.Drawing.Image)
        Me.svreset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.svreset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.svreset.Font = New System.Drawing.Font("Roboto Cn", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.svreset.Location = New System.Drawing.Point(126, 255)
        Me.svreset.Name = "svreset"
        Me.svreset.Size = New System.Drawing.Size(100, 30)
        Me.svreset.TabIndex = 71
        Me.svreset.Text = "RESET"
        Me.svreset.UseVisualStyleBackColor = False
        '
        'svdelete
        '
        Me.svdelete.BackColor = System.Drawing.SystemColors.Control
        Me.svdelete.BackgroundImage = CType(resources.GetObject("svdelete.BackgroundImage"), System.Drawing.Image)
        Me.svdelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.svdelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.svdelete.Font = New System.Drawing.Font("Roboto Cn", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.svdelete.Location = New System.Drawing.Point(579, 366)
        Me.svdelete.Name = "svdelete"
        Me.svdelete.Size = New System.Drawing.Size(75, 30)
        Me.svdelete.TabIndex = 76
        Me.svdelete.Text = "DELETE"
        Me.svdelete.UseVisualStyleBackColor = False
        '
        'svupdate
        '
        Me.svupdate.BackColor = System.Drawing.SystemColors.Control
        Me.svupdate.BackgroundImage = CType(resources.GetObject("svupdate.BackgroundImage"), System.Drawing.Image)
        Me.svupdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.svupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.svupdate.Font = New System.Drawing.Font("Roboto Cn", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.svupdate.Location = New System.Drawing.Point(498, 366)
        Me.svupdate.Name = "svupdate"
        Me.svupdate.Size = New System.Drawing.Size(75, 30)
        Me.svupdate.TabIndex = 75
        Me.svupdate.Text = "UPDATE"
        Me.svupdate.UseVisualStyleBackColor = False
        '
        'txtsvtype
        '
        Me.txtsvtype.Location = New System.Drawing.Point(126, 167)
        Me.txtsvtype.Name = "txtsvtype"
        Me.txtsvtype.Size = New System.Drawing.Size(100, 20)
        Me.txtsvtype.TabIndex = 70
        '
        'svread
        '
        Me.svread.BackColor = System.Drawing.SystemColors.Control
        Me.svread.BackgroundImage = CType(resources.GetObject("svread.BackgroundImage"), System.Drawing.Image)
        Me.svread.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.svread.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.svread.Font = New System.Drawing.Font("Roboto Cn", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.svread.Location = New System.Drawing.Point(417, 366)
        Me.svread.Name = "svread"
        Me.svread.Size = New System.Drawing.Size(75, 30)
        Me.svread.TabIndex = 74
        Me.svread.Text = "READ"
        Me.svread.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(10, 168)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 19)
        Me.Label3.TabIndex = 69
        Me.Label3.Text = "Service Type:"
        '
        'svcreate
        '
        Me.svcreate.BackColor = System.Drawing.SystemColors.Control
        Me.svcreate.BackgroundImage = CType(resources.GetObject("svcreate.BackgroundImage"), System.Drawing.Image)
        Me.svcreate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.svcreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.svcreate.Font = New System.Drawing.Font("Roboto Cn", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.svcreate.Location = New System.Drawing.Point(336, 366)
        Me.svcreate.Name = "svcreate"
        Me.svcreate.Size = New System.Drawing.Size(75, 30)
        Me.svcreate.TabIndex = 73
        Me.svcreate.Text = "CREATE"
        Me.svcreate.UseVisualStyleBackColor = False
        '
        'txtsvid
        '
        Me.txtsvid.Location = New System.Drawing.Point(126, 141)
        Me.txtsvid.Name = "txtsvid"
        Me.txtsvid.Size = New System.Drawing.Size(100, 20)
        Me.txtsvid.TabIndex = 68
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(26, 142)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 19)
        Me.Label2.TabIndex = 67
        Me.Label2.Text = "Service_ID:"
        '
        'ServiceView
        '
        Me.ServiceView.AllowUserToAddRows = False
        Me.ServiceView.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.ServiceView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.ServiceView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ServiceView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ServiceView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.ServiceView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ServiceView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.ServiceView.ColumnHeadersHeight = 30
        Me.ServiceView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ServiceView.DefaultCellStyle = DataGridViewCellStyle3
        Me.ServiceView.EnableHeadersVisualStyles = False
        Me.ServiceView.Location = New System.Drawing.Point(232, 141)
        Me.ServiceView.Name = "ServiceView"
        Me.ServiceView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ServiceView.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.ServiceView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ServiceView.Size = New System.Drawing.Size(578, 176)
        Me.ServiceView.TabIndex = 72
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "Service_id"
        Me.Column1.HeaderText = "SERVICE_ID"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "type"
        Me.Column2.HeaderText = "SERVICE TYPE"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "servicefee"
        Me.Column3.HeaderText = "SERVICE FEE"
        Me.Column3.Name = "Column3"
        '
        'Services
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.BackgroundImage = Global.Dellova_Auto_Acme_Service_Center.My.Resources.Resources._5
        Me.ClientSize = New System.Drawing.Size(822, 431)
        Me.Controls.Add(Me.txtsfee)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmdavail)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.svreset)
        Me.Controls.Add(Me.svdelete)
        Me.Controls.Add(Me.svupdate)
        Me.Controls.Add(Me.txtsvtype)
        Me.Controls.Add(Me.svread)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.svcreate)
        Me.Controls.Add(Me.txtsvid)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ServiceView)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Services"
        Me.Text = "Services"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ServiceView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtsfee As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cmdavail As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents svreset As Button
    Friend WithEvents svdelete As Button
    Friend WithEvents svupdate As Button
    Friend WithEvents txtsvtype As TextBox
    Friend WithEvents svread As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents svcreate As Button
    Friend WithEvents txtsvid As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ServiceView As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
End Class
