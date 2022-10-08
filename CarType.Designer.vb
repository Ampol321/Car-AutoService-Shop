<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CarType
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CarType))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ctdelete = New System.Windows.Forms.Button()
        Me.ctupdate = New System.Windows.Forms.Button()
        Me.ctread = New System.Windows.Forms.Button()
        Me.ctcreate = New System.Windows.Forms.Button()
        Me.cartypeViewer = New System.Windows.Forms.DataGridView()
        Me.ctreset = New System.Windows.Forms.Button()
        Me.txtcttype = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtctid = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cartypeViewer, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label1.Size = New System.Drawing.Size(226, 48)
        Me.Label1.TabIndex = 71
        Me.Label1.Text = "CAR TYPES"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.Dellova_Auto_Acme_Service_Center.My.Resources.Resources._8
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.TabIndex = 70
        Me.PictureBox1.TabStop = False
        '
        'ctdelete
        '
        Me.ctdelete.BackColor = System.Drawing.SystemColors.Control
        Me.ctdelete.BackgroundImage = CType(resources.GetObject("ctdelete.BackgroundImage"), System.Drawing.Image)
        Me.ctdelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ctdelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ctdelete.Font = New System.Drawing.Font("Roboto Cn", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ctdelete.Location = New System.Drawing.Point(579, 366)
        Me.ctdelete.Name = "ctdelete"
        Me.ctdelete.Size = New System.Drawing.Size(75, 30)
        Me.ctdelete.TabIndex = 69
        Me.ctdelete.Text = "DELETE"
        Me.ctdelete.UseVisualStyleBackColor = False
        '
        'ctupdate
        '
        Me.ctupdate.BackColor = System.Drawing.SystemColors.Control
        Me.ctupdate.BackgroundImage = CType(resources.GetObject("ctupdate.BackgroundImage"), System.Drawing.Image)
        Me.ctupdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ctupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ctupdate.Font = New System.Drawing.Font("Roboto Cn", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ctupdate.Location = New System.Drawing.Point(498, 366)
        Me.ctupdate.Name = "ctupdate"
        Me.ctupdate.Size = New System.Drawing.Size(75, 30)
        Me.ctupdate.TabIndex = 68
        Me.ctupdate.Text = "UPDATE"
        Me.ctupdate.UseVisualStyleBackColor = False
        '
        'ctread
        '
        Me.ctread.BackColor = System.Drawing.SystemColors.Control
        Me.ctread.BackgroundImage = CType(resources.GetObject("ctread.BackgroundImage"), System.Drawing.Image)
        Me.ctread.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ctread.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ctread.Font = New System.Drawing.Font("Roboto Cn", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ctread.Location = New System.Drawing.Point(417, 366)
        Me.ctread.Name = "ctread"
        Me.ctread.Size = New System.Drawing.Size(75, 30)
        Me.ctread.TabIndex = 67
        Me.ctread.Text = "READ"
        Me.ctread.UseVisualStyleBackColor = False
        '
        'ctcreate
        '
        Me.ctcreate.BackColor = System.Drawing.SystemColors.Control
        Me.ctcreate.BackgroundImage = CType(resources.GetObject("ctcreate.BackgroundImage"), System.Drawing.Image)
        Me.ctcreate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ctcreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ctcreate.Font = New System.Drawing.Font("Roboto Cn", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ctcreate.Location = New System.Drawing.Point(336, 366)
        Me.ctcreate.Name = "ctcreate"
        Me.ctcreate.Size = New System.Drawing.Size(75, 30)
        Me.ctcreate.TabIndex = 66
        Me.ctcreate.Text = "CREATE"
        Me.ctcreate.UseVisualStyleBackColor = False
        '
        'cartypeViewer
        '
        Me.cartypeViewer.AllowUserToAddRows = False
        Me.cartypeViewer.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.cartypeViewer.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.cartypeViewer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.cartypeViewer.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.cartypeViewer.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.cartypeViewer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cartypeViewer.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.cartypeViewer.ColumnHeadersHeight = 30
        Me.cartypeViewer.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.cartypeViewer.DefaultCellStyle = DataGridViewCellStyle3
        Me.cartypeViewer.EnableHeadersVisualStyles = False
        Me.cartypeViewer.Location = New System.Drawing.Point(232, 141)
        Me.cartypeViewer.Name = "cartypeViewer"
        Me.cartypeViewer.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cartypeViewer.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.cartypeViewer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.cartypeViewer.Size = New System.Drawing.Size(578, 176)
        Me.cartypeViewer.TabIndex = 75
        '
        'ctreset
        '
        Me.ctreset.BackColor = System.Drawing.SystemColors.Control
        Me.ctreset.BackgroundImage = CType(resources.GetObject("ctreset.BackgroundImage"), System.Drawing.Image)
        Me.ctreset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ctreset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ctreset.Font = New System.Drawing.Font("Roboto Cn", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ctreset.Location = New System.Drawing.Point(126, 193)
        Me.ctreset.Name = "ctreset"
        Me.ctreset.Size = New System.Drawing.Size(100, 30)
        Me.ctreset.TabIndex = 76
        Me.ctreset.Text = "RESET"
        Me.ctreset.UseVisualStyleBackColor = False
        '
        'txtcttype
        '
        Me.txtcttype.Location = New System.Drawing.Point(126, 167)
        Me.txtcttype.Name = "txtcttype"
        Me.txtcttype.Size = New System.Drawing.Size(100, 20)
        Me.txtcttype.TabIndex = 80
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(42, 168)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 19)
        Me.Label3.TabIndex = 79
        Me.Label3.Text = "Car Type:"
        '
        'txtctid
        '
        Me.txtctid.Location = New System.Drawing.Point(126, 141)
        Me.txtctid.Name = "txtctid"
        Me.txtctid.Size = New System.Drawing.Size(100, 20)
        Me.txtctid.TabIndex = 78
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(17, 142)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 19)
        Me.Label2.TabIndex = 77
        Me.Label2.Text = "Car Type_ID:"
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "Class_ID"
        Me.Column1.HeaderText = "CLASS_ID"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "CarType"
        Me.Column2.HeaderText = "CAR TYPE"
        Me.Column2.Name = "Column2"
        '
        'CarType
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Dellova_Auto_Acme_Service_Center.My.Resources.Resources._5
        Me.ClientSize = New System.Drawing.Size(822, 431)
        Me.Controls.Add(Me.txtcttype)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtctid)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ctreset)
        Me.Controls.Add(Me.cartypeViewer)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ctdelete)
        Me.Controls.Add(Me.ctupdate)
        Me.Controls.Add(Me.ctread)
        Me.Controls.Add(Me.ctcreate)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CarType"
        Me.Text = "CarType"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cartypeViewer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ctdelete As Button
    Friend WithEvents ctupdate As Button
    Friend WithEvents ctread As Button
    Friend WithEvents ctcreate As Button
    Friend WithEvents cartypeViewer As DataGridView
    Friend WithEvents ctreset As Button
    Friend WithEvents txtcttype As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtctid As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
End Class
