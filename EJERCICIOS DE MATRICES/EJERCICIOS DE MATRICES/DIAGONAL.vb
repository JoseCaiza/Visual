Public Class DIAGONAL
    Dim matriza(50, 50) As Integer
    Dim f, v As Integer
    Dim dp As Integer = 0
    Dim o As Integer = 0
    Dim p As Integer = 0
    Dim r As Integer = 0
    Private Sub INGRESARDATOSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles INGRESARDATOSToolStripMenuItem.Click
        Label1.Text = "MATRIZ"
        f = InputBox("INGRESE EL NUMERO DE FILA DE LA MATRIZ")
        f = InputBox("INGRESE EL NUMERO DE COLUMNA DE LA MATRIZ")
        For i = 0 To f - 1
            For j = 0 To f - 1
                v = InputBox("INGRESE EL VALOR CORRESPONDIENTE: " & "(" & i & "," & j & ")" & ":")
                matriza(j, i) = v
            Next
        Next
    End Sub

    Private Sub CALCULARLASUMAToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CALCULARLASUMAToolStripMenuItem.Click
        Label2.Text = "RESULTADO"
        Label3.Text = "SUMA DE LA DIAGONAL PRINCIPAL"
        Label4.Text = "SUMA SOBRE LA DIAGONAL PRINCIPAL"
        Label5.Text = "SUMA DEBAJO DE LA DIAGONAL PRINCIPAL"
        Label6.Text = "SUMA DE LA DIAGONAL SECUNDARIA"
        DataGridView1.RowCount = f
        DataGridView1.ColumnCount = f
        For i = 0 To f - 1
            For j = 0 To f - 1
                DataGridView1.Item(j, i).Value = (matriza(j, i))
            Next
        Next
        For i = 0 To f - 1
            For j = 0 To f - 1
                If f - 1 = j + i Then
                    r = r + matriza(j, i)
                End If
                If j = i Then
                    dp = dp + matriza(j, i)
                ElseIf i < j Then
                    p = p + matriza(j, i)
                Else
                    o = o + matriza(j, i)
                End If
            Next
        Next
        TextBox1.Text = dp
        TextBox2.Text = p
        TextBox3.Text = o
        TextBox4.Text = r
    End Sub

    Private Sub BORRARToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BORRARToolStripMenuItem.Click
        DataGridView1.Rows.Clear()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
    End Sub

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

    Private Sub SALIRToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SALIRToolStripMenuItem.Click
        Close()
    End Sub
End Class