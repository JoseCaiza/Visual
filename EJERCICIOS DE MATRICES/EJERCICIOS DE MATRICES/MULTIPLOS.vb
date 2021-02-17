Public Class MULTIPLOS
    Dim matriza(50, 50) As Integer
    Dim f, c, v, s As Integer
    Private Sub SUMADEMATRICESToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SUMADEMATRICESToolStripMenuItem.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub MATRIZSIMETRICAToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MATRIZSIMETRICAToolStripMenuItem.Click
        Me.Hide()
        SIMETRICA.Show()
    End Sub

    Private Sub DIAGONALToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DIAGONALToolStripMenuItem.Click
        Me.Hide()
        DIAGONAL.Show()
    End Sub

    Private Sub SUMADEFILASYCOLUMNASToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SUMADEFILASYCOLUMNASToolStripMenuItem.Click
        Me.Hide()
        SUMA.Show()
    End Sub

    Private Sub JUEGOToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles JUEGOToolStripMenuItem.Click
        Me.Hide()
        JUEGO.Show()
    End Sub

    Private Sub REGRESARToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REGRESARToolStripMenuItem.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub INGRESEDATOSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles INGRESEDATOSToolStripMenuItem.Click
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
        Label2.Text = "LA SUMA MULTIPLOS DE 5"
        For i = 0 To f - 1
            For j = 0 To c - 1
                If i = j Then
                    If matriza(i, j) Mod 5 = 0 Then
                        s = s + matriza(i, j)
                        TextBox1.Text = s
                    Else
                        TextBox1.Text = "NO HAY MULTIPLOS DE 5"
                    End If
                End If
            Next
        Next
    End Sub

    Private Sub BORRARToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BORRARToolStripMenuItem.Click
        DataGridView1.Rows.Clear()
        TextBox1.Clear()
    End Sub

    Private Sub SALIRToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SALIRToolStripMenuItem.Click
        Close()
    End Sub
End Class