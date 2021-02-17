<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SUMA
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
        Me.DIAGONALToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JUEGOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.REGRESARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OPCIONESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.INGRESARVALORESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CALCULARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BORRARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SALIRToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
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
        Me.MenuStrip1.Size = New System.Drawing.Size(709, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MENUToolStripMenuItem
        '
        Me.MENUToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SUMADEMATRICESToolStripMenuItem, Me.MATRIZSIMETRICAToolStripMenuItem, Me.MULTIPLOSToolStripMenuItem, Me.DIAGONALToolStripMenuItem, Me.JUEGOToolStripMenuItem, Me.REGRESARToolStripMenuItem})
        Me.MENUToolStripMenuItem.Name = "MENUToolStripMenuItem"
        Me.MENUToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.MENUToolStripMenuItem.Text = "MENU"
        '
        'SUMADEMATRICESToolStripMenuItem
        '
        Me.SUMADEMATRICESToolStripMenuItem.Name = "SUMADEMATRICESToolStripMenuItem"
        Me.SUMADEMATRICESToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.SUMADEMATRICESToolStripMenuItem.Text = "SUMA DE MATRICES"
        '
        'MATRIZSIMETRICAToolStripMenuItem
        '
        Me.MATRIZSIMETRICAToolStripMenuItem.Name = "MATRIZSIMETRICAToolStripMenuItem"
        Me.MATRIZSIMETRICAToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.MATRIZSIMETRICAToolStripMenuItem.Text = "MATRIZ SIMETRICA"
        '
        'MULTIPLOSToolStripMenuItem
        '
        Me.MULTIPLOSToolStripMenuItem.Name = "MULTIPLOSToolStripMenuItem"
        Me.MULTIPLOSToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.MULTIPLOSToolStripMenuItem.Text = "MULTIPLOS"
        '
        'DIAGONALToolStripMenuItem
        '
        Me.DIAGONALToolStripMenuItem.Name = "DIAGONALToolStripMenuItem"
        Me.DIAGONALToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.DIAGONALToolStripMenuItem.Text = "DIAGONAL"
        '
        'JUEGOToolStripMenuItem
        '
        Me.JUEGOToolStripMenuItem.Name = "JUEGOToolStripMenuItem"
        Me.JUEGOToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.JUEGOToolStripMenuItem.Text = "JUEGO"
        '
        'REGRESARToolStripMenuItem
        '
        Me.REGRESARToolStripMenuItem.Name = "REGRESARToolStripMenuItem"
        Me.REGRESARToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.REGRESARToolStripMenuItem.Text = "REGRESAR"
        '
        'OPCIONESToolStripMenuItem
        '
        Me.OPCIONESToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.INGRESARVALORESToolStripMenuItem, Me.CALCULARToolStripMenuItem})
        Me.OPCIONESToolStripMenuItem.Name = "OPCIONESToolStripMenuItem"
        Me.OPCIONESToolStripMenuItem.Size = New System.Drawing.Size(88, 20)
        Me.OPCIONESToolStripMenuItem.Text = "OPCIONES"
        '
        'INGRESARVALORESToolStripMenuItem
        '
        Me.INGRESARVALORESToolStripMenuItem.Name = "INGRESARVALORESToolStripMenuItem"
        Me.INGRESARVALORESToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.INGRESARVALORESToolStripMenuItem.Text = "INGRESAR VALORES"
        '
        'CALCULARToolStripMenuItem
        '
        Me.CALCULARToolStripMenuItem.Name = "CALCULARToolStripMenuItem"
        Me.CALCULARToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.CALCULARToolStripMenuItem.Text = "CALCULAR LA SUMA"
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
        Me.SALIRToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.SALIRToolStripMenuItem.Text = "SALIR"
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(34, 136)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(240, 150)
        Me.DataGridView1.TabIndex = 1
        '
        'ListBox2
        '
        Me.ListBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(478, 139)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(123, 147)
        Me.ListBox2.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(88, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(13, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(299, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(13, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(476, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(13, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "."
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ListBox1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 17
        Me.ListBox1.Location = New System.Drawing.Point(303, 139)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(120, 140)
        Me.ListBox1.TabIndex = 2
        '
        'SUMA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(709, 325)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "SUMA"
        Me.Text = "SUMA"
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
    Friend WithEvents DIAGONALToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents JUEGOToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents REGRESARToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OPCIONESToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents INGRESARVALORESToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents CALCULARToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BORRARToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SALIRToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
