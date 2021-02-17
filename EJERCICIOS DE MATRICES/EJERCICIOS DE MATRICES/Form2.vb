Public Class Form2
    Dim ma(50, 50), mb(50, 50), mc(50, 50) As Integer
    Dim a As Integer
    Private Sub INGRESEDATOSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles INGRESEDATOSToolStripMenuItem.Click
        Label1.Text = "+"
        Try
            For i = 0 To 3 - 1
                For j = 0 To 3 - 1
                    a = InputBox("INGRESE EL VALOR DE LA MATRIZ A: " & "(" & i & "," & j & ")" & ":")
                    ma(j, i) = a
                Next
            Next
            For i = 0 To 3 - 1
                For j = 0 To 3 - 1
                    a = InputBox("INGRESE EL VALOR DE LA MATRIZ B: " & "(" & i & "," & j & ")" & ":")
                    mb(j, i) = a
                Next
            Next
        Catch
            MessageBox.Show("INGRESE SOLO NUMEROS", "SUMA DE MATRICES", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub CALCULARLASUMAToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CALCULARLASUMAToolStripMenuItem.Click
        DataGridView1.RowCount = 3
        DataGridView1.ColumnCount = 3
        DataGridView2.RowCount = 3
        DataGridView2.ColumnCount = 3
        For i = 0 To 3 - 1
            For j = 0 To 3 - 1
                DataGridView1.Item(j, i).Value = (ma(j, i))
                DataGridView2.Item(j, i).Value = (mb(j, i))
            Next
        Next
    End Sub

    Private Sub CALCULARLASUMAToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CALCULARLASUMAToolStripMenuItem1.Click
        Label5.Text = "RESULTADO"
        For i = 0 To 3 - 1
            For j = 0 To 3 - 1
                mc(j, i) = ma(j, i) + mb(j, i)
                DataGridView3.RowCount = 3
                DataGridView3.ColumnCount = 3
                DataGridView3.Item(j, i).Value = (mc(j, i))
            Next
        Next
    End Sub

    Private Sub DATOSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DATOSToolStripMenuItem.Click
        Label3.Text = "MATRIZ A"
        Label4.Text = "MATRIZ B"
    End Sub

    Private Sub SALIRToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SALIRToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub REGRESARToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REGRESARToolStripMenuItem.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub MULTIPOSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MULTIPOSToolStripMenuItem.Click
        Me.Hide()
        MULTIPLOS.Show()
    End Sub

    Private Sub SIMETRICAToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SIMETRICAToolStripMenuItem.Click
        Me.Hide()
        SIMETRICA.Show()
    End Sub

    Private Sub JUEGOToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles JUEGOToolStripMenuItem.Click
        Me.Hide()
        JUEGO.Show()
    End Sub

    Private Sub SUMADEFILASToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SUMADEFILASToolStripMenuItem.Click
        Me.Hide()
        SUMA.Show()
    End Sub

    Private Sub DIAGONALToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DIAGONALToolStripMenuItem.Click
        Me.Hide()
        DIAGONAL.Show()
    End Sub

    Private Sub BORRARToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BORRARToolStripMenuItem.Click
        DataGridView1.Rows.Clear()
        DataGridView2.Rows.Clear()
        DataGridView3.Rows.Clear()
    End Sub
End Class