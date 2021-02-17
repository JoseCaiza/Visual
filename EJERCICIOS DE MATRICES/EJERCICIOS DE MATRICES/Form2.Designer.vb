<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.OPCIONESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.REGRESARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MULTIPOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SIMETRICAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JUEGOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SUMADEFILASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DIAGONALToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DATOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.INGRESEDATOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CALCULARLASUMAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CALCULARLASUMAToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SALIRToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BORRARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OPCIONESToolStripMenuItem, Me.DATOSToolStripMenuItem, Me.SALIRToolStripMenuItem, Me.BORRARToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(796, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OPCIONESToolStripMenuItem
        '
        Me.OPCIONESToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.REGRESARToolStripMenuItem, Me.MULTIPOSToolStripMenuItem, Me.SIMETRICAToolStripMenuItem, Me.JUEGOToolStripMenuItem, Me.SUMADEFILASToolStripMenuItem, Me.DIAGONALToolStripMenuItem})
        Me.OPCIONESToolStripMenuItem.Name = "OPCIONESToolStripMenuItem"
        Me.OPCIONESToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.OPCIONESToolStripMenuItem.Text = "MENU"
        '
        'REGRESARToolStripMenuItem
        '
        Me.REGRESARToolStripMenuItem.Name = "REGRESARToolStripMenuItem"
        Me.REGRESARToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.REGRESARToolStripMenuItem.Text = "REGRESAR"
        '
        'MULTIPOSToolStripMenuItem
        '
        Me.MULTIPOSToolStripMenuItem.Name = "MULTIPOSToolStripMenuItem"
        Me.MULTIPOSToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.MULTIPOSToolStripMenuItem.Text = "MULTIPOS"
        '
        'SIMETRICAToolStripMenuItem
        '
        Me.SIMETRICAToolStripMenuItem.Name = "SIMETRICAToolStripMenuItem"
        Me.SIMETRICAToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.SIMETRICAToolStripMenuItem.Text = "SIMETRICA"
        '
        'JUEGOToolStripMenuItem
        '
        Me.JUEGOToolStripMenuItem.Name = "JUEGOToolStripMenuItem"
        Me.JUEGOToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.JUEGOToolStripMenuItem.Text = "JUEGO"
        '
        'SUMADEFILASToolStripMenuItem
        '
        Me.SUMADEFILASToolStripMenuItem.Name = "SUMADEFILASToolStripMenuItem"
        Me.SUMADEFILASToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.SUMADEFILASToolStripMenuItem.Text = "SUMA DE FILAS "
        '
        'DIAGONALToolStripMenuItem
        '
        Me.DIAGONALToolStripMenuItem.Name = "DIAGONALToolStripMenuItem"
        Me.DIAGONALToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.DIAGONALToolStripMenuItem.Text = "DIAGONAL"
        '
        'DATOSToolStripMenuItem
        '
        Me.DATOSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.INGRESEDATOSToolStripMenuItem, Me.CALCULARLASUMAToolStripMenuItem, Me.CALCULARLASUMAToolStripMenuItem1})
        Me.DATOSToolStripMenuItem.Name = "DATOSToolStripMenuItem"
        Me.DATOSToolStripMenuItem.Size = New System.Drawing.Size(88, 20)
        Me.DATOSToolStripMenuItem.Text = "OPCIONES"
        '
        'INGRESEDATOSToolStripMenuItem
        '
        Me.INGRESEDATOSToolStripMenuItem.Name = "INGRESEDATOSToolStripMenuItem"
        Me.INGRESEDATOSToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.INGRESEDATOSToolStripMenuItem.Text = "INGRESE DATOS"
        '
        'CALCULARLASUMAToolStripMenuItem
        '
        Me.CALCULARLASUMAToolStripMenuItem.Name = "CALCULARLASUMAToolStripMenuItem"
        Me.CALCULARLASUMAToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.CALCULARLASUMAToolStripMenuItem.Text = "MOSTRAR DATOS"
        '
        'CALCULARLASUMAToolStripMenuItem1
        '
        Me.CALCULARLASUMAToolStripMenuItem1.Name = "CALCULARLASUMAToolStripMenuItem1"
        Me.CALCULARLASUMAToolStripMenuItem1.Size = New System.Drawing.Size(205, 22)
        Me.CALCULARLASUMAToolStripMenuItem1.Text = "CALCULAR LA SUMA"
        '
        'SALIRToolStripMenuItem
        '
        Me.SALIRToolStripMenuItem.Name = "SALIRToolStripMenuItem"
        Me.SALIRToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.SALIRToolStripMenuItem.Text = "SALIR"
        '
        'BORRARToolStripMenuItem
        '
        Me.BORRARToolStripMenuItem.Name = "BORRARToolStripMenuItem"
        Me.BORRARToolStripMenuItem.Size = New System.Drawing.Size(75, 20)
        Me.BORRARToolStripMenuItem.Text = "BORRAR"
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(27, 123)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(220, 141)
        Me.DataGridView1.TabIndex = 1
        '
        'DataGridView2
        '
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(288, 123)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(220, 141)
        Me.DataGridView2.TabIndex = 2
        '
        'DataGridView3
        '
        Me.DataGridView3.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Location = New System.Drawing.Point(564, 123)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.Size = New System.Drawing.Size(220, 141)
        Me.DataGridView3.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(253, 193)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(22, 32)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(526, 193)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 32)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "="
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(62, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(18, 26)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(321, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(18, 26)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(587, 72)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(18, 26)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "."
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(796, 351)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView3)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents OPCIONESToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents REGRESARToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MULTIPOSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SIMETRICAToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents JUEGOToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SUMADEFILASToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DATOSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents INGRESEDATOSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CALCULARLASUMAToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridView3 As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CALCULARLASUMAToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SALIRToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DIAGONALToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BORRARToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
