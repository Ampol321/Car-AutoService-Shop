<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Parts
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Parts))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.cmdpurchase = New System.Windows.Forms.Button()
        Me.txtqty = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.apreset = New System.Windows.Forms.Button()
        Me.txtapprice = New System.Windows.Forms.TextBox()
        Me.apdelete = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.apupdate = New System.Windows.Forms.Button()
        Me.txtaptype = New System.Windows.Forms.TextBox()
        Me.apread = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.apcreate = New System.Windows.Forms.Button()
        Me.txtapid = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PartsView = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PartsView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdpurchase
        '
        Me.cmdpurchase.BackColor = System.Drawing.SystemColors.Control
        Me.cmdpurchase.BackgroundImage = CType(resources.GetObject("cmdpurchase.BackgroundImage"), System.Drawing.Image)
        Me.cmdpurchase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdpurchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdpurchase.Font = New System.Drawing.Font("Roboto Cn", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdpurchase.ForeColor = System.Drawing.Color.Black
        Me.cmdpurchase.Location = New System.Drawing.Point(126, 245)
        Me.cmdpurchase.Name = "cmdpurchase"
        Me.cmdpurchase.Size = New System.Drawing.Size(100, 30)
        Me.cmdpurchase.TabIndex = 63
        Me.cmdpurchase.Text = "PURCHASE"
        Me.cmdpurchase.UseVisualStyleBackColor = False
        '
        'txtqty
        '
        Me.txtqty.Location = New System.Drawing.Point(126, 219)
        Me.txtqty.Name = "txtqty"
        Me.txtqty.Size = New System.Drawing.Size(100, 20)
        Me.txtqty.TabIndex = 62
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(49, 220)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 19)
        Me.Label5.TabIndex = 61
        Me.Label5.Text = "Quantity:"
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
        'apreset
        '
        Me.apreset.BackColor = System.Drawing.SystemColors.Control
        Me.apreset.BackgroundImage = CType(resources.GetObject("apreset.BackgroundImage"), System.Drawing.Image)
        Me.apreset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.apreset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.apreset.Font = New System.Drawing.Font("Roboto Cn", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.apreset.ForeColor = System.Drawing.Color.Black
        Me.apreset.Location = New System.Drawing.Point(126, 281)
        Me.apreset.Name = "apreset"
        Me.apreset.Size = New System.Drawing.Size(100, 30)
        Me.apreset.TabIndex = 53
        Me.apreset.Text = "RESET"
        Me.apreset.UseVisualStyleBackColor = False
        '
        'txtapprice
        '
        Me.txtapprice.Location = New System.Drawing.Point(126, 193)
        Me.txtapprice.Name = "txtapprice"
        Me.txtapprice.Size = New System.Drawing.Size(100, 20)
        Me.txtapprice.TabIndex = 52
        '
        'apdelete
        '
        Me.apdelete.BackColor = System.Drawing.SystemColors.Control
        Me.apdelete.BackgroundImage = CType(resources.GetObject("apdelete.BackgroundImage"), System.Drawing.Image)
        Me.apdelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.apdelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.apdelete.Font = New System.Drawing.Font("Roboto Cn", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.apdelete.ForeColor = System.Drawing.Color.Black
        Me.apdelete.Location = New System.Drawing.Point(579, 366)
        Me.apdelete.Name = "apdelete"
        Me.apdelete.Size = New System.Drawing.Size(75, 30)
        Me.apdelete.TabIndex = 59
        Me.apdelete.Text = "DELETE"
        Me.apdelete.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(75, 193)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 19)
        Me.Label4.TabIndex = 51
        Me.Label4.Text = "Price:"
        '
        'apupdate
        '
        Me.apupdate.BackColor = System.Drawing.SystemColors.Control
        Me.apupdate.BackgroundImage = CType(resources.GetObject("apupdate.BackgroundImage"), System.Drawing.Image)
        Me.apupdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.apupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.apupdate.Font = New System.Drawing.Font("Roboto Cn", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.apupdate.ForeColor = System.Drawing.Color.Black
        Me.apupdate.Location = New System.Drawing.Point(498, 366)
        Me.apupdate.Name = "apupdate"
        Me.apupdate.Size = New System.Drawing.Size(75, 30)
        Me.apupdate.TabIndex = 58
        Me.apupdate.Text = "UPDATE"
        Me.apupdate.UseVisualStyleBackColor = False
        '
        'txtaptype
        '
        Me.txtaptype.Location = New System.Drawing.Point(126, 167)
        Me.txtaptype.Name = "txtaptype"
        Me.txtaptype.Size = New System.Drawing.Size(100, 20)
        Me.txtaptype.TabIndex = 50
        '
        'apread
        '
        Me.apread.BackColor = System.Drawing.SystemColors.Control
        Me.apread.BackgroundImage = CType(resources.GetObject("apread.BackgroundImage"), System.Drawing.Image)
        Me.apread.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.apread.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.apread.Font = New System.Drawing.Font("Roboto Cn", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.apread.ForeColor = System.Drawing.Color.Black
        Me.apread.Location = New System.Drawing.Point(417, 366)
        Me.apread.Name = "apread"
        Me.apread.Size = New System.Drawing.Size(75, 30)
        Me.apread.TabIndex = 57
        Me.apread.Text = "READ"
        Me.apread.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(41, 166)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 19)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "Part Type:"
        '
        'apcreate
        '
        Me.apcreate.BackColor = System.Drawing.SystemColors.Control
        Me.apcreate.BackgroundImage = CType(resources.GetObject("apcreate.BackgroundImage"), System.Drawing.Image)
        Me.apcreate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.apcreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.apcreate.Font = New System.Drawing.Font("Roboto Cn", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.apcreate.ForeColor = System.Drawing.Color.Black
        Me.apcreate.Location = New System.Drawing.Point(336, 366)
        Me.apcreate.Name = "apcreate"
        Me.apcreate.Size = New System.Drawing.Size(75, 30)
        Me.apcreate.TabIndex = 56
        Me.apcreate.Text = "CREATE"
        Me.apcreate.UseVisualStyleBackColor = False
        '
        'txtapid
        '
        Me.txtapid.Location = New System.Drawing.Point(126, 141)
        Me.txtapid.Name = "txtapid"
        Me.txtapid.Size = New System.Drawing.Size(100, 20)
        Me.txtapid.TabIndex = 48
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(57, 140)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 19)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "Part_ID:"
        '
        'PartsView
        '
        Me.PartsView.AllowUserToAddRows = False
        Me.PartsView.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.PartsView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.PartsView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.PartsView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.PartsView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PartsView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.PartsView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PartsView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.PartsView.ColumnHeadersHeight = 30
        Me.PartsView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.PartsView.DefaultCellStyle = DataGridViewCellStyle3
        Me.PartsView.EnableHeadersVisualStyles = False
        Me.PartsView.Location = New System.Drawing.Point(232, 141)
        Me.PartsView.Name = "PartsView"
        Me.PartsView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PartsView.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.PartsView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.PartsView.Size = New System.Drawing.Size(578, 176)
        Me.PartsView.TabIndex = 55
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Montserrat", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(118, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(432, 48)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "PARTS / ACCESSORIES"
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "part_id"
        Me.Column1.HeaderText = "PART_ID"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "parttype"
        Me.Column2.HeaderText = "PART TYPE"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "partprice"
        Me.Column3.HeaderText = "PRICE"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "stock"
        Me.Column4.HeaderText = "STOCK"
        Me.Column4.Name = "Column4"
        '
        'Parts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Dellova_Auto_Acme_Service_Center.My.Resources.Resources._5
        Me.ClientSize = New System.Drawing.Size(822, 431)
        Me.Controls.Add(Me.cmdpurchase)
        Me.Controls.Add(Me.txtqty)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.apreset)
        Me.Controls.Add(Me.txtapprice)
        Me.Controls.Add(Me.apdelete)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.apupdate)
        Me.Controls.Add(Me.txtaptype)
        Me.Controls.Add(Me.apread)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.apcreate)
        Me.Controls.Add(Me.txtapid)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PartsView)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Parts"
        Me.Text = "Parts"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PartsView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdpurchase As Button
    Friend WithEvents txtqty As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents apreset As Button
    Friend WithEvents txtapprice As TextBox
    Friend WithEvents apdelete As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents apupdate As Button
    Friend WithEvents txtaptype As TextBox
    Friend WithEvents apread As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents apcreate As Button
    Friend WithEvents txtapid As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PartsView As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
End Class
