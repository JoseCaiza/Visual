<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SIMETRICA
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
        Me.SUMAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MULTIPLOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MATRIZDIAGONALToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JUEGOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.REGRESARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.REGRESARToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.OPCIONESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.INGRESEVALORESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VERIFICARLAMATRIZToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BORRARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SALIRToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
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
        Me.MenuStrip1.Size = New System.Drawing.Size(441, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MENUToolStripMenuItem
        '
        Me.MENUToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SUMAToolStripMenuItem, Me.MULTIPLOSToolStripMenuItem, Me.MATRIZDIAGONALToolStripMenuItem, Me.JUEGOToolStripMenuItem, Me.REGRESARToolStripMenuItem, Me.REGRESARToolStripMenuItem1})
        Me.MENUToolStripMenuItem.Name = "MENUToolStripMenuItem"
        Me.MENUToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.MENUToolStripMenuItem.Text = "MENU"
        '
        'SUMAToolStripMenuItem
        '
        Me.SUMAToolStripMenuItem.Name = "SUMAToolStripMenuItem"
        Me.SUMAToolStripMenuItem.Size = New System.Drawing.Size(255, 22)
        Me.SUMAToolStripMenuItem.Text = "SUMA DE MATRICES"
        '
        'MULTIPLOSToolStripMenuItem
        '
        Me.MULTIPLOSToolStripMenuItem.Name = "MULTIPLOSToolStripMenuItem"
        Me.MULTIPLOSToolStripMenuItem.Size = New System.Drawing.Size(255, 22)
        Me.MULTIPLOSToolStripMenuItem.Text = "MULTIPLOS"
        '
        'MATRIZDIAGONALToolStripMenuItem
        '
        Me.MATRIZDIAGONALToolStripMenuItem.Name = "MATRIZDIAGONALToolStripMenuItem"
        Me.MATRIZDIAGONALToolStripMenuItem.Size = New System.Drawing.Size(255, 22)
        Me.MATRIZDIAGONALToolStripMenuItem.Text = "MATRIZ DIAGONAL"
        '
        'JUEGOToolStripMenuItem
        '
        Me.JUEGOToolStripMenuItem.Name = "JUEGOToolStripMenuItem"
        Me.JUEGOToolStripMenuItem.Size = New System.Drawing.Size(255, 22)
        Me.JUEGOToolStripMenuItem.Text = "JUEGO"
        '
        'REGRESARToolStripMenuItem
        '
        Me.REGRESARToolStripMenuItem.Name = "REGRESARToolStripMenuItem"
        Me.REGRESARToolStripMenuItem.Size = New System.Drawing.Size(255, 22)
        Me.REGRESARToolStripMenuItem.Text = "SUMA DE FILA Y COLUMNAS"
        '
        'REGRESARToolStripMenuItem1
        '
        Me.REGRESARToolStripMenuItem1.Name = "REGRESARToolStripMenuItem1"
        Me.REGRESARToolStripMenuItem1.Size = New System.Drawing.Size(255, 22)
        Me.REGRESARToolStripMenuItem1.Text = "REGRESAR"
        '
        'OPCIONESToolStripMenuItem
        '
        Me.OPCIONESToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.INGRESEVALORESToolStripMenuItem, Me.VERIFICARLAMATRIZToolStripMenuItem})
        Me.OPCIONESToolStripMenuItem.Name = "OPCIONESToolStripMenuItem"
        Me.OPCIONESToolStripMenuItem.Size = New System.Drawing.Size(88, 20)
        Me.OPCIONESToolStripMenuItem.Text = "OPCIONES"
        '
        'INGRESEVALORESToolStripMenuItem
        '
        Me.INGRESEVALORESToolStripMenuItem.Name = "INGRESEVALORESToolStripMenuItem"
        Me.INGRESEVALORESToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.INGRESEVALORESToolStripMenuItem.Text = "INGRESE VALORES"
        '
        'VERIFICARLAMATRIZToolStripMenuItem
        '
        Me.VERIFICARLAMATRIZToolStripMenuItem.Name = "VERIFICARLAMATRIZToolStripMenuItem"
        Me.VERIFICARLAMATRIZToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.VERIFICARLAMATRIZToolStripMenuItem.Text = "VERIFICAR LA MATRIZ"
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
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(37, 114)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(345, 152)
        Me.DataGridView1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(365, 150)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 19)
        Me.Label1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(46, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(15, 24)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "."
        '
        'SIMETRICA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(441, 317)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "SIMETRICA"
        Me.Text = "SIMETRICA"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MENUToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SUMAToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MULTIPLOSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MATRIZDIAGONALToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents JUEGOToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents REGRESARToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents REGRESARToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OPCIONESToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents INGRESEVALORESToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VERIFICARLAMATRIZToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BORRARToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SALIRToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
