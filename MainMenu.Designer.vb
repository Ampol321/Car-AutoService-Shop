<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainMenu))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CRUDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MANUFACTURERToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CARMODELToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CARTYPEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MECHANICSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SERVICESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PARTSACCESSORIESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SUPPLIERSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OWNERSCARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CUSTOMERSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SEARCHToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.quiz1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.quiz2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.quiz3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.quiz4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.quiz5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CUSTOMERHISTORYToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.INCOMESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TOTALINCOMEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DATERANGEINCOMEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Picture = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.Picture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Black
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CRUDToolStripMenuItem, Me.SEARCHToolStripMenuItem, Me.INCOMESToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(831, 41)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CRUDToolStripMenuItem
        '
        Me.CRUDToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.CRUDToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MANUFACTURERToolStripMenuItem, Me.CARMODELToolStripMenuItem, Me.CARTYPEToolStripMenuItem, Me.MECHANICSToolStripMenuItem, Me.SERVICESToolStripMenuItem, Me.PARTSACCESSORIESToolStripMenuItem, Me.SUPPLIERSToolStripMenuItem, Me.OWNERSCARToolStripMenuItem, Me.CUSTOMERSToolStripMenuItem})
        Me.CRUDToolStripMenuItem.Font = New System.Drawing.Font("Montserrat", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CRUDToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.CRUDToolStripMenuItem.Name = "CRUDToolStripMenuItem"
        Me.CRUDToolStripMenuItem.Size = New System.Drawing.Size(155, 37)
        Me.CRUDToolStripMenuItem.Text = "   CRUD     |"
        '
        'MANUFACTURERToolStripMenuItem
        '
        Me.MANUFACTURERToolStripMenuItem.BackgroundImage = CType(resources.GetObject("MANUFACTURERToolStripMenuItem.BackgroundImage"), System.Drawing.Image)
        Me.MANUFACTURERToolStripMenuItem.Font = New System.Drawing.Font("Roboto Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MANUFACTURERToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.MANUFACTURERToolStripMenuItem.Name = "MANUFACTURERToolStripMenuItem"
        Me.MANUFACTURERToolStripMenuItem.Size = New System.Drawing.Size(221, 24)
        Me.MANUFACTURERToolStripMenuItem.Text = "MANUFACTURER"
        '
        'CARMODELToolStripMenuItem
        '
        Me.CARMODELToolStripMenuItem.BackgroundImage = CType(resources.GetObject("CARMODELToolStripMenuItem.BackgroundImage"), System.Drawing.Image)
        Me.CARMODELToolStripMenuItem.Font = New System.Drawing.Font("Roboto Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CARMODELToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.CARMODELToolStripMenuItem.Name = "CARMODELToolStripMenuItem"
        Me.CARMODELToolStripMenuItem.Size = New System.Drawing.Size(221, 24)
        Me.CARMODELToolStripMenuItem.Text = "CAR MODEL"
        '
        'CARTYPEToolStripMenuItem
        '
        Me.CARTYPEToolStripMenuItem.BackgroundImage = CType(resources.GetObject("CARTYPEToolStripMenuItem.BackgroundImage"), System.Drawing.Image)
        Me.CARTYPEToolStripMenuItem.Font = New System.Drawing.Font("Roboto Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CARTYPEToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.CARTYPEToolStripMenuItem.Name = "CARTYPEToolStripMenuItem"
        Me.CARTYPEToolStripMenuItem.Size = New System.Drawing.Size(221, 24)
        Me.CARTYPEToolStripMenuItem.Text = "CAR TYPE"
        '
        'MECHANICSToolStripMenuItem
        '
        Me.MECHANICSToolStripMenuItem.BackgroundImage = CType(resources.GetObject("MECHANICSToolStripMenuItem.BackgroundImage"), System.Drawing.Image)
        Me.MECHANICSToolStripMenuItem.Font = New System.Drawing.Font("Roboto Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MECHANICSToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.MECHANICSToolStripMenuItem.Name = "MECHANICSToolStripMenuItem"
        Me.MECHANICSToolStripMenuItem.Size = New System.Drawing.Size(221, 24)
        Me.MECHANICSToolStripMenuItem.Text = "MECHANICS"
        '
        'SERVICESToolStripMenuItem
        '
        Me.SERVICESToolStripMenuItem.BackgroundImage = CType(resources.GetObject("SERVICESToolStripMenuItem.BackgroundImage"), System.Drawing.Image)
        Me.SERVICESToolStripMenuItem.Font = New System.Drawing.Font("Roboto Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SERVICESToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.SERVICESToolStripMenuItem.Name = "SERVICESToolStripMenuItem"
        Me.SERVICESToolStripMenuItem.Size = New System.Drawing.Size(221, 24)
        Me.SERVICESToolStripMenuItem.Text = "SERVICES"
        '
        'PARTSACCESSORIESToolStripMenuItem
        '
        Me.PARTSACCESSORIESToolStripMenuItem.BackgroundImage = CType(resources.GetObject("PARTSACCESSORIESToolStripMenuItem.BackgroundImage"), System.Drawing.Image)
        Me.PARTSACCESSORIESToolStripMenuItem.Font = New System.Drawing.Font("Roboto Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PARTSACCESSORIESToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.PARTSACCESSORIESToolStripMenuItem.Name = "PARTSACCESSORIESToolStripMenuItem"
        Me.PARTSACCESSORIESToolStripMenuItem.Size = New System.Drawing.Size(221, 24)
        Me.PARTSACCESSORIESToolStripMenuItem.Text = "PARTS/ACCESSORIES"
        '
        'SUPPLIERSToolStripMenuItem
        '
        Me.SUPPLIERSToolStripMenuItem.BackgroundImage = CType(resources.GetObject("SUPPLIERSToolStripMenuItem.BackgroundImage"), System.Drawing.Image)
        Me.SUPPLIERSToolStripMenuItem.Font = New System.Drawing.Font("Roboto Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SUPPLIERSToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.SUPPLIERSToolStripMenuItem.Name = "SUPPLIERSToolStripMenuItem"
        Me.SUPPLIERSToolStripMenuItem.Size = New System.Drawing.Size(221, 24)
        Me.SUPPLIERSToolStripMenuItem.Text = "SUPPLIERS"
        '
        'OWNERSCARToolStripMenuItem
        '
        Me.OWNERSCARToolStripMenuItem.BackgroundImage = CType(resources.GetObject("OWNERSCARToolStripMenuItem.BackgroundImage"), System.Drawing.Image)
        Me.OWNERSCARToolStripMenuItem.Font = New System.Drawing.Font("Roboto Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OWNERSCARToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.OWNERSCARToolStripMenuItem.Name = "OWNERSCARToolStripMenuItem"
        Me.OWNERSCARToolStripMenuItem.Size = New System.Drawing.Size(221, 24)
        Me.OWNERSCARToolStripMenuItem.Text = "OWNER'S CAR"
        '
        'CUSTOMERSToolStripMenuItem
        '
        Me.CUSTOMERSToolStripMenuItem.BackgroundImage = CType(resources.GetObject("CUSTOMERSToolStripMenuItem.BackgroundImage"), System.Drawing.Image)
        Me.CUSTOMERSToolStripMenuItem.Font = New System.Drawing.Font("Roboto Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CUSTOMERSToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.CUSTOMERSToolStripMenuItem.Name = "CUSTOMERSToolStripMenuItem"
        Me.CUSTOMERSToolStripMenuItem.Size = New System.Drawing.Size(221, 24)
        Me.CUSTOMERSToolStripMenuItem.Text = "CUSTOMERS"
        '
        'SEARCHToolStripMenuItem
        '
        Me.SEARCHToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.SEARCHToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.quiz1, Me.quiz2, Me.quiz3, Me.quiz4, Me.quiz5, Me.CUSTOMERHISTORYToolStripMenuItem})
        Me.SEARCHToolStripMenuItem.Font = New System.Drawing.Font("Montserrat", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SEARCHToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.SEARCHToolStripMenuItem.Name = "SEARCHToolStripMenuItem"
        Me.SEARCHToolStripMenuItem.Size = New System.Drawing.Size(160, 37)
        Me.SEARCHToolStripMenuItem.Text = "SEARCH    |"
        Me.SEARCHToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'quiz1
        '
        Me.quiz1.BackgroundImage = CType(resources.GetObject("quiz1.BackgroundImage"), System.Drawing.Image)
        Me.quiz1.Font = New System.Drawing.Font("Roboto Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.quiz1.ForeColor = System.Drawing.Color.White
        Me.quiz1.Name = "quiz1"
        Me.quiz1.Size = New System.Drawing.Size(218, 24)
        Me.quiz1.Text = "CAR MODEL"
        '
        'quiz2
        '
        Me.quiz2.BackgroundImage = CType(resources.GetObject("quiz2.BackgroundImage"), System.Drawing.Image)
        Me.quiz2.Font = New System.Drawing.Font("Roboto Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.quiz2.ForeColor = System.Drawing.Color.White
        Me.quiz2.Name = "quiz2"
        Me.quiz2.Size = New System.Drawing.Size(218, 24)
        Me.quiz2.Text = "SUPPLIER"
        '
        'quiz3
        '
        Me.quiz3.BackgroundImage = CType(resources.GetObject("quiz3.BackgroundImage"), System.Drawing.Image)
        Me.quiz3.Font = New System.Drawing.Font("Roboto Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.quiz3.ForeColor = System.Drawing.Color.White
        Me.quiz3.Name = "quiz3"
        Me.quiz3.Size = New System.Drawing.Size(218, 24)
        Me.quiz3.Text = "MECHANIC"
        '
        'quiz4
        '
        Me.quiz4.BackgroundImage = CType(resources.GetObject("quiz4.BackgroundImage"), System.Drawing.Image)
        Me.quiz4.Font = New System.Drawing.Font("Roboto Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.quiz4.ForeColor = System.Drawing.Color.White
        Me.quiz4.Name = "quiz4"
        Me.quiz4.Size = New System.Drawing.Size(218, 24)
        Me.quiz4.Text = "SERVICE"
        '
        'quiz5
        '
        Me.quiz5.BackgroundImage = CType(resources.GetObject("quiz5.BackgroundImage"), System.Drawing.Image)
        Me.quiz5.Font = New System.Drawing.Font("Roboto Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.quiz5.ForeColor = System.Drawing.Color.White
        Me.quiz5.Name = "quiz5"
        Me.quiz5.Size = New System.Drawing.Size(218, 24)
        Me.quiz5.Text = "DATE RANGE"
        '
        'CUSTOMERHISTORYToolStripMenuItem
        '
        Me.CUSTOMERHISTORYToolStripMenuItem.BackgroundImage = CType(resources.GetObject("CUSTOMERHISTORYToolStripMenuItem.BackgroundImage"), System.Drawing.Image)
        Me.CUSTOMERHISTORYToolStripMenuItem.Font = New System.Drawing.Font("Roboto Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CUSTOMERHISTORYToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.CUSTOMERHISTORYToolStripMenuItem.Name = "CUSTOMERHISTORYToolStripMenuItem"
        Me.CUSTOMERHISTORYToolStripMenuItem.Size = New System.Drawing.Size(218, 24)
        Me.CUSTOMERHISTORYToolStripMenuItem.Text = "CUSTOMER HISTORY"
        '
        'INCOMESToolStripMenuItem
        '
        Me.INCOMESToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TOTALINCOMEToolStripMenuItem, Me.DATERANGEINCOMEToolStripMenuItem})
        Me.INCOMESToolStripMenuItem.Font = New System.Drawing.Font("Montserrat", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.INCOMESToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.INCOMESToolStripMenuItem.Name = "INCOMESToolStripMenuItem"
        Me.INCOMESToolStripMenuItem.Size = New System.Drawing.Size(145, 37)
        Me.INCOMESToolStripMenuItem.Text = "INCOMES"
        Me.INCOMESToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TOTALINCOMEToolStripMenuItem
        '
        Me.TOTALINCOMEToolStripMenuItem.BackgroundImage = CType(resources.GetObject("TOTALINCOMEToolStripMenuItem.BackgroundImage"), System.Drawing.Image)
        Me.TOTALINCOMEToolStripMenuItem.Font = New System.Drawing.Font("Roboto Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TOTALINCOMEToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.TOTALINCOMEToolStripMenuItem.Name = "TOTALINCOMEToolStripMenuItem"
        Me.TOTALINCOMEToolStripMenuItem.Size = New System.Drawing.Size(223, 24)
        Me.TOTALINCOMEToolStripMenuItem.Text = "TOTAL INCOME"
        '
        'DATERANGEINCOMEToolStripMenuItem
        '
        Me.DATERANGEINCOMEToolStripMenuItem.BackgroundImage = CType(resources.GetObject("DATERANGEINCOMEToolStripMenuItem.BackgroundImage"), System.Drawing.Image)
        Me.DATERANGEINCOMEToolStripMenuItem.Font = New System.Drawing.Font("Roboto Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DATERANGEINCOMEToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.DATERANGEINCOMEToolStripMenuItem.Name = "DATERANGEINCOMEToolStripMenuItem"
        Me.DATERANGEINCOMEToolStripMenuItem.Size = New System.Drawing.Size(223, 24)
        Me.DATERANGEINCOMEToolStripMenuItem.Text = "DATE RANGE INCOME"
        '
        'Picture
        '
        Me.Picture.BackColor = System.Drawing.Color.Black
        Me.Picture.BackgroundImage = Global.Dellova_Auto_Acme_Service_Center.My.Resources.Resources._8
        Me.Picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Picture.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Picture.Location = New System.Drawing.Point(0, 41)
        Me.Picture.Name = "Picture"
        Me.Picture.Size = New System.Drawing.Size(831, 436)
        Me.Picture.TabIndex = 9
        Me.Picture.TabStop = False
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(831, 477)
        Me.Controls.Add(Me.Picture)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.Name = "MainMenu"
        Me.Text = "ACME AUTO SERVICING CENTER"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.Picture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CRUDToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MANUFACTURERToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CARMODELToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CARTYPEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MECHANICSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SERVICESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PARTSACCESSORIESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SUPPLIERSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OWNERSCARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CUSTOMERSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SEARCHToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents quiz1 As ToolStripMenuItem
    Friend WithEvents quiz2 As ToolStripMenuItem
    Friend WithEvents quiz3 As ToolStripMenuItem
    Friend WithEvents quiz4 As ToolStripMenuItem
    Friend WithEvents quiz5 As ToolStripMenuItem
    Friend WithEvents CUSTOMERHISTORYToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Picture As PictureBox
    Friend WithEvents INCOMESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TOTALINCOMEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DATERANGEINCOMEToolStripMenuItem As ToolStripMenuItem
End Class
