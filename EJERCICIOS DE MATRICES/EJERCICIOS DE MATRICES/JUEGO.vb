Public Class JUEGO
    Dim jugador(50, 50) As String
    Dim f, c As Integer
    Dim v As String
    Dim s As Integer = 0
    Dim sum As Integer = 0
    Private Sub INGRESEDATOSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles INGRESEDATOSToolStripMenuItem.Click
        Try
            Label1.Text = "JUEGO"
            DataGridView1.RowCount = 3
            DataGridView1.ColumnCount = 3
            For i = 0 To 2
                For j = 0 To 2
                    v = InputBox("INGRESE VALORES: " & "(" & i & "," & j & ")" & ":")
                    jugador(j, i) = v
                    If v = "x" Then
                        s = s + 1
                    ElseIf v = "o" Then
                        sum = sum + 1
                    Else
                        MsgBox("INGRESE SOLO X - O")
                    End If
                    DataGridView1.Item(j, i).Value = (jugador(j, i))
                Next
            Next
        Catch
            MessageBox.Show("INGRESE VALORES", "JUEGO", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Asterisk)
        End Try
    End Sub

    Private Sub GENERARToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GENERARToolStripMenuItem.Click
        Label2.Text = "NUMERO DE X"
        Label3.Text = "NUMERO DE O"
        Label4.Text = "GANADOR"
        TextBox1.Text = s
        TextBox2.Text = sum
        If s > sum Then
            TextBox3.Text = ("GANADOR X" & s)
        ElseIf sum < s Then
            TextBox3.Text = ("GANADOR O" & sum)
        Else
            TextBox3.Text = ("EMPATES: " & "(" & s & "-" & sum & ")")
        End If
    End Sub

    Private Sub BORRARToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BORRARToolStripMenuItem.Click
        DataGridView1.Rows.Clear()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
    End Sub

    Private Sub SALIRToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SALIRToolStripMenuItem.Click
        Close()
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

    Private Sub DIAGONALToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DIAGONALToolStripMenuItem.Click
        Me.Hide()
        DIAGONAL.Show()
    End Sub

    Private Sub SUMADEFILASYCOLUMNASToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SUMADEFILASYCOLUMNASToolStripMenuItem.Click
        Me.Hide()
        SUMA.Show()
    End Sub

    Private Sub REGRESARToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REGRESARToolStripMenuItem.Click
        Me.Hide()
        Form1.Show()
    End Sub
End Class