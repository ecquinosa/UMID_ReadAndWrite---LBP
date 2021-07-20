<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCardType = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtNewPin = New System.Windows.Forms.TextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.txtSystemStatus = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tsslAuth1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsslAuth2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsslAuth3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.gridSector = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gridCommonElement = New System.Windows.Forms.DataGridView()
        Me.gridColElement = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gridColValue = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.picPhoto = New System.Windows.Forms.PictureBox()
        Me.picSignature = New System.Windows.Forms.PictureBox()
        Me.picLP = New System.Windows.Forms.PictureBox()
        Me.picLB = New System.Windows.Forms.PictureBox()
        Me.picRP = New System.Windows.Forms.PictureBox()
        Me.picRB = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.gridSector, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridCommonElement, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSignature, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(19, 105)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 14)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "CARD TYPE"
        '
        'txtCardType
        '
        Me.txtCardType.BackColor = System.Drawing.Color.White
        Me.txtCardType.Location = New System.Drawing.Point(122, 102)
        Me.txtCardType.Name = "txtCardType"
        Me.txtCardType.ReadOnly = True
        Me.txtCardType.Size = New System.Drawing.Size(296, 20)
        Me.txtCardType.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(391, 9)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(77, 25)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Misc"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Location = New System.Drawing.Point(474, 9)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(77, 25)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "Misc"
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.Visible = False
        '
        'txtNewPin
        '
        Me.txtNewPin.BackColor = System.Drawing.Color.White
        Me.txtNewPin.Location = New System.Drawing.Point(122, 76)
        Me.txtNewPin.Name = "txtNewPin"
        Me.txtNewPin.Size = New System.Drawing.Size(142, 20)
        Me.txtNewPin.TabIndex = 23
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripSeparator1, Me.ToolStripButton4, Me.ToolStripSeparator2, Me.ToolStripButton2, Me.ToolStripSeparator3, Me.ToolStripButton3})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(798, 57)
        Me.ToolStrip1.TabIndex = 25
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(113, 54)
        Me.ToolStripButton1.Text = "Read Card"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 57)
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(87, 54)
        Me.ToolStripButton4.Text = "Write"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 57)
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(112, 54)
        Me.ToolStripButton2.Text = "Chip Data"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 57)
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(101, 54)
        Me.ToolStripButton3.Text = "Settings"
        '
        'txtSystemStatus
        '
        Me.txtSystemStatus.BackColor = System.Drawing.Color.White
        Me.txtSystemStatus.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSystemStatus.Location = New System.Drawing.Point(8, 9)
        Me.txtSystemStatus.Multiline = True
        Me.txtSystemStatus.Name = "txtSystemStatus"
        Me.txtSystemStatus.Size = New System.Drawing.Size(778, 50)
        Me.txtSystemStatus.TabIndex = 29
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.txtSystemStatus)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Location = New System.Drawing.Point(0, 611)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(798, 68)
        Me.Panel1.TabIndex = 30
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsslAuth1, Me.tsslAuth2, Me.tsslAuth3})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 679)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(798, 22)
        Me.StatusStrip1.TabIndex = 31
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tsslAuth1
        '
        Me.tsslAuth1.Margin = New System.Windows.Forms.Padding(0, 3, 60, 2)
        Me.tsslAuth1.Name = "tsslAuth1"
        Me.tsslAuth1.Size = New System.Drawing.Size(110, 17)
        Me.tsslAuth1.Text = "Authentication SL1:"
        '
        'tsslAuth2
        '
        Me.tsslAuth2.Margin = New System.Windows.Forms.Padding(0, 3, 60, 2)
        Me.tsslAuth2.Name = "tsslAuth2"
        Me.tsslAuth2.Size = New System.Drawing.Size(110, 17)
        Me.tsslAuth2.Text = "Authentication SL2:"
        '
        'tsslAuth3
        '
        Me.tsslAuth3.Margin = New System.Windows.Forms.Padding(0, 3, 60, 2)
        Me.tsslAuth3.Name = "tsslAuth3"
        Me.tsslAuth3.Size = New System.Drawing.Size(110, 17)
        Me.tsslAuth3.Text = "Authentication SL3:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(19, 78)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(24, 14)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "PIN"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label9.Location = New System.Drawing.Point(270, 78)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(125, 14)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "(enter PIN if changed)"
        '
        'gridSector
        '
        Me.gridSector.AllowUserToAddRows = False
        Me.gridSector.AllowUserToDeleteRows = False
        Me.gridSector.BackgroundColor = System.Drawing.Color.White
        Me.gridSector.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.gridSector.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridSector.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn1})
        Me.gridSector.Location = New System.Drawing.Point(472, 435)
        Me.gridSector.Name = "gridSector"
        Me.gridSector.ReadOnly = True
        Me.gridSector.RowHeadersVisible = False
        Me.gridSector.Size = New System.Drawing.Size(301, 156)
        Me.gridSector.TabIndex = 37
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Element"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Element"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Value"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Data"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 150
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(469, 410)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 14)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "SECTOR(S)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(27, 143)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 14)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "UMID ELEMENT(S)"
        '
        'gridCommonElement
        '
        Me.gridCommonElement.AllowUserToAddRows = False
        Me.gridCommonElement.AllowUserToDeleteRows = False
        Me.gridCommonElement.BackgroundColor = System.Drawing.Color.White
        Me.gridCommonElement.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.gridCommonElement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridCommonElement.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.gridColElement, Me.gridColValue})
        Me.gridCommonElement.Location = New System.Drawing.Point(27, 160)
        Me.gridCommonElement.Name = "gridCommonElement"
        Me.gridCommonElement.ReadOnly = True
        Me.gridCommonElement.RowHeadersVisible = False
        Me.gridCommonElement.Size = New System.Drawing.Size(435, 431)
        Me.gridCommonElement.TabIndex = 34
        '
        'gridColElement
        '
        Me.gridColElement.DataPropertyName = "Element"
        Me.gridColElement.HeaderText = "Element"
        Me.gridColElement.Name = "gridColElement"
        Me.gridColElement.ReadOnly = True
        Me.gridColElement.Width = 130
        '
        'gridColValue
        '
        Me.gridColValue.DataPropertyName = "Value"
        Me.gridColValue.HeaderText = "Data"
        Me.gridColValue.Name = "gridColValue"
        Me.gridColValue.ReadOnly = True
        Me.gridColValue.Width = 250
        '
        'picPhoto
        '
        Me.picPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picPhoto.Location = New System.Drawing.Point(3, 4)
        Me.picPhoto.Name = "picPhoto"
        Me.picPhoto.Size = New System.Drawing.Size(127, 148)
        Me.picPhoto.TabIndex = 38
        Me.picPhoto.TabStop = False
        '
        'picSignature
        '
        Me.picSignature.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picSignature.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picSignature.Location = New System.Drawing.Point(136, 4)
        Me.picSignature.Name = "picSignature"
        Me.picSignature.Size = New System.Drawing.Size(159, 54)
        Me.picSignature.TabIndex = 39
        Me.picSignature.TabStop = False
        '
        'picLP
        '
        Me.picLP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picLP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLP.Location = New System.Drawing.Point(3, 158)
        Me.picLP.Name = "picLP"
        Me.picLP.Size = New System.Drawing.Size(64, 64)
        Me.picLP.TabIndex = 40
        Me.picLP.TabStop = False
        '
        'picLB
        '
        Me.picLB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picLB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLB.Location = New System.Drawing.Point(79, 158)
        Me.picLB.Name = "picLB"
        Me.picLB.Size = New System.Drawing.Size(64, 64)
        Me.picLB.TabIndex = 41
        Me.picLB.TabStop = False
        '
        'picRP
        '
        Me.picRP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picRP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picRP.Location = New System.Drawing.Point(155, 158)
        Me.picRP.Name = "picRP"
        Me.picRP.Size = New System.Drawing.Size(64, 64)
        Me.picRP.TabIndex = 42
        Me.picRP.TabStop = False
        '
        'picRB
        '
        Me.picRB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picRB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picRB.Location = New System.Drawing.Point(231, 158)
        Me.picRB.Name = "picRB"
        Me.picRB.Size = New System.Drawing.Size(64, 64)
        Me.picRB.TabIndex = 43
        Me.picRB.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.picPhoto)
        Me.Panel2.Controls.Add(Me.picRB)
        Me.Panel2.Controls.Add(Me.picSignature)
        Me.Panel2.Controls.Add(Me.picRP)
        Me.Panel2.Controls.Add(Me.picLB)
        Me.Panel2.Controls.Add(Me.picLP)
        Me.Panel2.Location = New System.Drawing.Point(472, 160)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(301, 238)
        Me.Panel2.TabIndex = 44
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DimGray
        Me.Label7.Location = New System.Drawing.Point(179, 222)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(21, 14)
        Me.Label7.TabIndex = 48
        Me.Label7.Text = "RP"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DimGray
        Me.Label6.Location = New System.Drawing.Point(254, 222)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(21, 14)
        Me.Label6.TabIndex = 47
        Me.Label6.Text = "RB"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DimGray
        Me.Label4.Location = New System.Drawing.Point(102, 222)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(21, 14)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "LB"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(24, 222)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(21, 14)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "LP"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(469, 143)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(73, 14)
        Me.Label10.TabIndex = 45
        Me.Label10.Text = "BIOMETRICS"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(798, 701)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.gridSector)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.gridCommonElement)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.txtNewPin)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtCardType)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UMID CARD - READ AND WRITE"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.gridSector, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridCommonElement, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSignature, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCardType As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents txtNewPin As System.Windows.Forms.TextBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtSystemStatus As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents tsslAuth1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tsslAuth2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tsslAuth3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents gridSector As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents gridCommonElement As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gridColElement As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gridColValue As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents picPhoto As System.Windows.Forms.PictureBox
    Friend WithEvents picSignature As System.Windows.Forms.PictureBox
    Friend WithEvents picLP As System.Windows.Forms.PictureBox
    Friend WithEvents picLB As System.Windows.Forms.PictureBox
    Friend WithEvents picRP As System.Windows.Forms.PictureBox
    Friend WithEvents picRB As System.Windows.Forms.PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator

End Class
