Public Class SUMA
    Dim matriza(50, 50) As Integer
    Dim f, c, v, sf, sc As Integer
    Private Sub SUMADEMATRICESToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SUMADEMATRICESToolStripMenuItem.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub MATRIZSIMETRICAToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MATRIZSIMETRICAToolStripMenuItem.Click
        Me.Hide()
        SIMETRICA.Show()
    End Sub

    Private Sub MULTIPLOSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MULTIPLOSToolStripMenuItem.Click
        Me.Hide()
        MULTIPLOS.Show()
    End Sub

    Private Sub DIAGONALToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DIAGONALToolStripMenuItem.Click
        Me.Hide()
        DIAGONAL.Show()
    End Sub

    Private Sub JUEGOToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles JUEGOToolStripMenuItem.Click
        Me.Hide()
        JUEGO.Show()
    End Sub

    Private Sub REGRESARToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REGRESARToolStripMenuItem.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub INGRESARVALORESToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles INGRESARVALORESToolStripMenuItem.Click
        Label1.Text = "MATRIZ"
        f = InputBox("INGRESE EL NUMERO DE FILA DE LA MATRIZ")
        c = InputBox("INGRESE EL NUMERO DE COLUMNA DE LA MATRIZ")
        For i = 0 To f - 1
            For j = 0 To c - 1
                v = InputBox("INGRESE EL VALOR CORRESPONDIENTE: " & "(" & i & "," & j & ")" & ":")
                matriza(j, i) = v
            Next
        Next
        DataGridView1.RowCount = f
        DataGridView1.ColumnCount = c
        For i = 0 To f - 1
            For j = 0 To c - 1
                DataGridView1.Item(j, i).Value = (matriza(j, i))
            Next
        Next
    End Sub
    Private Sub CALCULARToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CALCULARToolStripMenuItem.Click
        Label2.Text = "SUMA DE FILAS"
        For i = 0 To f - 1
            sf = 0
            For j = 0 To c - 1
                sf = sf + matriza(j, i)
            Next
            ListBox1.Items.Add(sf)
        Next
        Label3.Text = "SUMA DE COLUMNAS"
        For i = 0 To f - 1
            sc = 0
            For j = 0 To c - 1
                sc = sc + matriza(i, j)
            Next
            ListBox2.Items.Add(sc)
        Next
    End Sub

    Private Sub BORRARToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BORRARToolStripMenuItem.Click
        DataGridView1.Rows.Clear()
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
    End Sub
End Class