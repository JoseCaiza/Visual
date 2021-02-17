<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class JUEGO
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
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.OPCIONESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SUMADEMATRICESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MATRIZSIMETRICAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MULTIPLOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DIAGONALToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SUMADEFILASYCOLUMNASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.REGRESARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OPCIONESToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.INGRESEDATOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GENERARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.BORRARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SALIRToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip2
        '
        Me.MenuStrip2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OPCIONESToolStripMenuItem, Me.OPCIONESToolStripMenuItem1, Me.BORRARToolStripMenuItem, Me.SALIRToolStripMenuItem})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(832, 24)
        Me.MenuStrip2.TabIndex = 1
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'OPCIONESToolStripMenuItem
        '
        Me.OPCIONESToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SUMADEMATRICESToolStripMenuItem, Me.MATRIZSIMETRICAToolStripMenuItem, Me.MULTIPLOSToolStripMenuItem, Me.DIAGONALToolStripMenuItem, Me.SUMADEFILASYCOLUMNASToolStripMenuItem, Me.REGRESARToolStripMenuItem})
        Me.OPCIONESToolStripMenuItem.Name = "OPCIONESToolStripMenuItem"
        Me.OPCIONESToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.OPCIONESToolStripMenuItem.Text = "MENU"
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
        'DIAGONALToolStripMenuItem
        '
        Me.DIAGONALToolStripMenuItem.Name = "DIAGONALToolStripMenuItem"
        Me.DIAGONALToolStripMenuItem.Size = New System.Drawing.Size(265, 22)
        Me.DIAGONALToolStripMenuItem.Text = "DIAGONAL"
        '
        'SUMADEFILASYCOLUMNASToolStripMenuItem
        '
        Me.SUMADEFILASYCOLUMNASToolStripMenuItem.Name = "SUMADEFILASYCOLUMNASToolStripMenuItem"
        Me.SUMADEFILASYCOLUMNASToolStripMenuItem.Size = New System.Drawing.Size(265, 22)
        Me.SUMADEFILASYCOLUMNASToolStripMenuItem.Text = "SUMA DE FILAS Y COLUMNAS"
        '
        'REGRESARToolStripMenuItem
        '
        Me.REGRESARToolStripMenuItem.Name = "REGRESARToolStripMenuItem"
        Me.REGRESARToolStripMenuItem.Size = New System.Drawing.Size(265, 22)
        Me.REGRESARToolStripMenuItem.Text = "REGRESAR"
        '
        'OPCIONESToolStripMenuItem1
        '
        Me.OPCIONESToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.INGRESEDATOSToolStripMenuItem, Me.GENERARToolStripMenuItem})
        Me.OPCIONESToolStripMenuItem1.Name = "OPCIONESToolStripMenuItem1"
        Me.OPCIONESToolStripMenuItem1.Size = New System.Drawing.Size(88, 20)
        Me.OPCIONESToolStripMenuItem1.Text = "OPCIONES"
        '
        'INGRESEDATOSToolStripMenuItem
        '
        Me.INGRESEDATOSToolStripMenuItem.Name = "INGRESEDATOSToolStripMenuItem"
        Me.INGRESEDATOSToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.INGRESEDATOSToolStripMenuItem.Text = "INGRESE DATOS"
        '
        'GENERARToolStripMenuItem
        '
        Me.GENERARToolStripMenuItem.Name = "GENERARToolStripMenuItem"
        Me.GENERARToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.GENERARToolStripMenuItem.Text = "GENERAR"
        '
        'DataGridView1
        '
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(25, 120)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(344, 167)
        Me.DataGridView1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(102, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(13, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(418, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(13, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(418, 171)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(13, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(418, 217)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(13, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "."
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(589, 122)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(110, 38)
        Me.TextBox1.TabIndex = 7
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(589, 171)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(110, 32)
        Me.TextBox2.TabIndex = 8
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(589, 219)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(110, 31)
        Me.TextBox3.TabIndex = 9
        '
        'BORRARToolStripMenuItem
        '
        Me.BORRARToolStripMenuItem.Name = "BORRARToolStripMenuItem"
        Me.BORRARToolStripMenuItem.Size = New System.Drawing.Size(79, 20)
        Me.BORRARToolStripMenuItem.Text = "BORRAR "
        '
        'SALIRToolStripMenuItem
        '
        Me.SALIRToolStripMenuItem.Name = "SALIRToolStripMenuItem"
        Me.SALIRToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.SALIRToolStripMenuItem.Text = "SALIR"
        '
        'JUEGO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(832, 355)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MenuStrip2)
        Me.Name = "JUEGO"
        Me.Text = "JUEGO"
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip2 As System.Windows.Forms.MenuStrip
    Friend WithEvents OPCIONESToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SUMADEMATRICESToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MATRIZSIMETRICAToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MULTIPLOSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DIAGONALToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SUMADEFILASYCOLUMNASToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents REGRESARToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OPCIONESToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents INGRESEDATOSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GENERARToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents BORRARToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SALIRToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
