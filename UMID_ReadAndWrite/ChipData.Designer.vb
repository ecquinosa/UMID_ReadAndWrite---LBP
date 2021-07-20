<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChipData
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.gridCommonElement = New System.Windows.Forms.DataGridView()
        Me.gridColCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gridColElement = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gridColIsRead = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gridSector = New System.Windows.Forms.DataGridView()
        Me.gridColSectorCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gridColSectorElement = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gridColSectorIsRead = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.chkElements = New System.Windows.Forms.CheckBox()
        Me.chkSectors = New System.Windows.Forms.CheckBox()
        CType(Me.gridCommonElement, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridSector, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gridCommonElement
        '
        Me.gridCommonElement.AllowUserToAddRows = False
        Me.gridCommonElement.AllowUserToDeleteRows = False
        Me.gridCommonElement.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.gridCommonElement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridCommonElement.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.gridColCode, Me.gridColElement, Me.gridColIsRead})
        Me.gridCommonElement.Location = New System.Drawing.Point(12, 39)
        Me.gridCommonElement.Name = "gridCommonElement"
        Me.gridCommonElement.ShowEditingIcon = False
        Me.gridCommonElement.Size = New System.Drawing.Size(362, 412)
        Me.gridCommonElement.TabIndex = 0
        '
        'gridColCode
        '
        Me.gridColCode.DataPropertyName = "Code"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.gridColCode.DefaultCellStyle = DataGridViewCellStyle1
        Me.gridColCode.HeaderText = "Code"
        Me.gridColCode.Name = "gridColCode"
        Me.gridColCode.ReadOnly = True
        Me.gridColCode.Width = 57
        '
        'gridColElement
        '
        Me.gridColElement.DataPropertyName = "Element"
        Me.gridColElement.HeaderText = "Element"
        Me.gridColElement.Name = "gridColElement"
        Me.gridColElement.ReadOnly = True
        Me.gridColElement.Width = 69
        '
        'gridColIsRead
        '
        Me.gridColIsRead.DataPropertyName = "IsSelected"
        Me.gridColIsRead.HeaderText = "Read"
        Me.gridColIsRead.Name = "gridColIsRead"
        Me.gridColIsRead.Width = 38
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(101, 14)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "UMID ELEMENT(S)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(377, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 14)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "SECTOR(S)"
        '
        'gridSector
        '
        Me.gridSector.AllowUserToAddRows = False
        Me.gridSector.AllowUserToDeleteRows = False
        Me.gridSector.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.gridSector.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridSector.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.gridColSectorCode, Me.gridColSectorElement, Me.gridColSectorIsRead})
        Me.gridSector.Location = New System.Drawing.Point(380, 39)
        Me.gridSector.Name = "gridSector"
        Me.gridSector.Size = New System.Drawing.Size(362, 412)
        Me.gridSector.TabIndex = 31
        '
        'gridColSectorCode
        '
        Me.gridColSectorCode.DataPropertyName = "Code"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.gridColSectorCode.DefaultCellStyle = DataGridViewCellStyle2
        Me.gridColSectorCode.HeaderText = "Code"
        Me.gridColSectorCode.Name = "gridColSectorCode"
        Me.gridColSectorCode.ReadOnly = True
        Me.gridColSectorCode.Width = 57
        '
        'gridColSectorElement
        '
        Me.gridColSectorElement.DataPropertyName = "Element"
        Me.gridColSectorElement.HeaderText = "Element"
        Me.gridColSectorElement.Name = "gridColSectorElement"
        Me.gridColSectorElement.ReadOnly = True
        Me.gridColSectorElement.Width = 69
        '
        'gridColSectorIsRead
        '
        Me.gridColSectorIsRead.DataPropertyName = "IsSelected"
        Me.gridColSectorIsRead.HeaderText = "Read"
        Me.gridColSectorIsRead.Name = "gridColSectorIsRead"
        Me.gridColSectorIsRead.Width = 38
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.DarkGreen
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(12, 459)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(95, 44)
        Me.btnSave.TabIndex = 32
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'chkElements
        '
        Me.chkElements.AutoSize = True
        Me.chkElements.Location = New System.Drawing.Point(280, 16)
        Me.chkElements.Name = "chkElements"
        Me.chkElements.Size = New System.Drawing.Size(70, 18)
        Me.chkElements.TabIndex = 33
        Me.chkElements.Text = "Check All"
        Me.chkElements.UseVisualStyleBackColor = True
        '
        'chkSectors
        '
        Me.chkSectors.AutoSize = True
        Me.chkSectors.Location = New System.Drawing.Point(646, 16)
        Me.chkSectors.Name = "chkSectors"
        Me.chkSectors.Size = New System.Drawing.Size(70, 18)
        Me.chkSectors.TabIndex = 34
        Me.chkSectors.Text = "Check All"
        Me.chkSectors.UseVisualStyleBackColor = True
        '
        'ChipData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(757, 513)
        Me.Controls.Add(Me.chkSectors)
        Me.Controls.Add(Me.chkElements)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.gridSector)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.gridCommonElement)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "ChipData"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ELEMENTS AND SECTORS"
        CType(Me.gridCommonElement, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridSector, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gridCommonElement As System.Windows.Forms.DataGridView
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents gridSector As System.Windows.Forms.DataGridView
    Friend WithEvents gridColCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gridColElement As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gridColIsRead As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents gridColSectorCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gridColSectorElement As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gridColSectorIsRead As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents chkElements As System.Windows.Forms.CheckBox
    Friend WithEvents chkSectors As System.Windows.Forms.CheckBox
End Class
