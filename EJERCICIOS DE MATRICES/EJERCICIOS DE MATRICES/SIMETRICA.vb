Public Class SIMETRICA
    Dim matriz(50, 50) As Integer
    Dim f, c, a As Integer
    Dim band As Boolean = False
    Private Sub SUMAToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SUMAToolStripMenuItem.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub MULTIPLOSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MULTIPLOSToolStripMenuItem.Click
        Me.Hide()
        MULTIPLOS.Show()
    End Sub

    Private Sub MATRIZDIAGONALToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MATRIZDIAGONALToolStripMenuItem.Click
        Me.Hide()
        DIAGONAL.Show()
    End Sub

    Private Sub JUEGOToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles JUEGOToolStripMenuItem.Click
        Me.Hide()
        JUEGO.Show()
    End Sub

    Private Sub REGRESARToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REGRESARToolStripMenuItem.Click
        Me.Hide()
        SUMA.Show()
    End Sub

    Private Sub REGRESARToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REGRESARToolStripMenuItem1.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub INGRESEVALORESToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles INGRESEVALORESToolStripMenuItem.Click
        Label2.Text = "MATRIZ SIMETRICA"
        f = InputBox("INGRESE EL NUMERO DE FILA DE LA MATRIZ ")
        c = InputBox("INGRESE EL NUMERO DE COLUMNA DE LA MATRIZ ")
        For i = 0 To f - 1
            For j = 0 To c - 1
                a = InputBox("INGRESE EL VALOR DE LA MATRIZ A: " & "(" & i & "," & j & ")" & ":")
                matriz(j, i) = a
            Next
        Next
        DataGridView1.RowCount = f
        DataGridView1.ColumnCount = c
        For i = 0 To f - 1
            For j = 0 To c - 1
                DataGridView1.Item(j, i).Value = (matriz(j, i))
            Next
        Next
    End Sub

    Private Sub VERIFICARLAMATRIZToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VERIFICARLAMATRIZToolStripMenuItem.Click
        If f = c Then
            For i = 0 To f - 1
                For j = 0 To c - 1
                    If matriz(i, j) = matriz(j, i) Then
                        band = True
                    End If
                Next
            Next
        End If
        If band = True Then
            MessageBox.Show("LA MATRIZ ES SIMETRICA", "RESULTADO", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information)
        Else
            MessageBox.Show("LA MATRIZ NO ES SIMETRICA", "RESULTADO", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub BORRARToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BORRARToolStripMenuItem.Click
        DataGridView1.Rows.Clear()
    End Sub

    Private Sub SALIRToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SALIRToolStripMenuItem.Click
        Close()
    End Sub
End Class