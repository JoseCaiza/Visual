<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DIAGONAL
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MENUToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SUMADEMATRICESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MATRIZSIMETRICAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MULTIPLOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SUMADEFILASYCOLUMNASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JUEGOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.REGRESARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OPCIONESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.INGRESARDATOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CALCULARLASUMAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BORRARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SALIRToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MENUToolStripMenuItem, Me.OPCIONESToolStripMenuItem, Me.BORRARToolStripMenuItem, Me.SALIRToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(862, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MENUToolStripMenuItem
        '
        Me.MENUToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SUMADEMATRICESToolStripMenuItem, Me.MATRIZSIMETRICAToolStripMenuItem, Me.MULTIPLOSToolStripMenuItem, Me.SUMADEFILASYCOLUMNASToolStripMenuItem, Me.JUEGOToolStripMenuItem, Me.REGRESARToolStripMenuItem})
        Me.MENUToolStripMenuItem.Name = "MENUToolStripMenuItem"
        Me.MENUToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.MENUToolStripMenuItem.Text = "MENU"
        '
        'SUMADEMATRICESToolStripMenuItem
        '
        Me.SUMADEMATRICESToolStripMenuItem.Name = "SUMADEMATRICESToolStripMenuItem"
        Me.SUMADEMATRICESToolStripMenuItem.Size = New System.Drawing.Size(265, 22)
        Me.SUMADEMATRICESToolStripMenuItem.Text = "SUMA DE MATRICES"
        '
        'MATRIZSIMETRICAToolStripMenuItem
        '
        Me.MATRIZSIMETRICAToolStripMenuItem.Name = "MATRIZSIMETRICAToolStripMenuItem"
        Me.MATRIZSIMETRICAToolStripMenuItem.Size = New System.Drawing.Size(265, 22)
        Me.MATRIZSIMETRICAToolStripMenuItem.Text = "MATRIZ SIMETRICA"
        '
        'MULTIPLOSToolStripMenuItem
        '
        Me.MULTIPLOSToolStripMenuItem.Name = "MULTIPLOSToolStripMenuItem"
        Me.MULTIPLOSToolStripMenuItem.Size = New System.Drawing.Size(265, 22)
        Me.MULTIPLOSToolStripMenuItem.Text = "MULTIPLOS"
        '
        'SUMADEFILASYCOLUMNASToolStripMenuItem
        '
        Me.SUMADEFILASYCOLUMNASToolStripMenuItem.Name = "SUMADEFILASYCOLUMNASToolStripMenuItem"
        Me.SUMADEFILASYCOLUMNASToolStripMenuItem.Size = New System.Drawing.Size(265, 22)
        Me.SUMADEFILASYCOLUMNASToolStripMenuItem.Text = "SUMA DE FILAS Y COLUMNAS"
        '
        'JUEGOToolStripMenuItem
        '
        Me.JUEGOToolStripMenuItem.Name = "JUEGOToolStripMenuItem"
        Me.JUEGOToolStripMenuItem.Size = New System.Drawing.Size(265, 22)
        Me.JUEGOToolStripMenuItem.Text = "JUEGO"
        '
        'REGRESARToolStripMenuItem
        '
        Me.REGRESARToolStripMenuItem.Name = "REGRESARToolStripMenuItem"
        Me.REGRESARToolStripMenuItem.Size = New System.Drawing.Size(265, 22)
        Me.REGRESARToolStripMenuItem.Text = "REGRESAR"
        '
        'OPCIONESToolStripMenuItem
        '
        Me.OPCIONESToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.INGRESARDATOSToolStripMenuItem, Me.CALCULARLASUMAToolStripMenuItem})
        Me.OPCIONESToolStripMenuItem.Name = "OPCIONESToolStripMenuItem"
        Me.OPCIONESToolStripMenuItem.Size = New System.Drawing.Size(88, 20)
        Me.OPCIONESToolStripMenuItem.Text = "OPCIONES"
        '
        'INGRESARDATOSToolStripMenuItem
        '
        Me.INGRESARDATOSToolStripMenuItem.Name = "INGRESARDATOSToolStripMenuItem"
        Me.INGRESARDATOSToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.INGRESARDATOSToolStripMenuItem.Text = "INGRESAR DATOS"
        '
        'CALCULARLASUMAToolStripMenuItem
        '
        Me.CALCULARLASUMAToolStripMenuItem.Name = "CALCULARLASUMAToolStripMenuItem"
        Me.CALCULARLASUMAToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.CALCULARLASUMAToolStripMenuItem.Text = "CALCULAR LA SUMA"
        '
        'BORRARToolStripMenuItem
        '
        Me.BORRARToolStripMenuItem.Name = "BORRARToolStripMenuItem"
        Me.BORRARToolStripMenuItem.Size = New System.Drawing.Size(75, 20)
        Me.BORRARToolStripMenuItem.Text = "BORRAR"
        '
        'SALIRToolStripMenuItem
        '
        Me.SALIRToolStripMenuItem.Name = "SALIRToolStripMenuItem"
        Me.SALIRToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.SALIRToolStripMenuItem.Text = "SALIR"
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridView1.Location = New System.Drawing.Point(31, 122)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(398, 168)
        Me.DataGridView1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(76, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(13, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(503, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(13, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(451, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(13, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(451, 163)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(13, 20)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(451, 201)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(13, 20)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(451, 241)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(13, 20)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "."
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(763, 124)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(66, 27)
        Me.TextBox1.TabIndex = 8
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(763, 163)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(66, 27)
        Me.TextBox2.TabIndex = 9
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(763, 201)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(66, 27)
        Me.TextBox3.TabIndex = 10
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(763, 241)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(66, 27)
        Me.TextBox4.TabIndex = 11
        '
        'DIAGONAL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(862, 322)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "DIAGONAL"
        Me.Text = "DIAGONAL"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MENUToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SUMADEMATRICESToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MATRIZSIMETRICAToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MULTIPLOSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SUMADEFILASYCOLUMNASToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents JUEGOToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents REGRESARToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OPCIONESToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents INGRESARDATOSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CALCULARLASUMAToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BORRARToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SALIRToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
End Class
