Public Class Form1
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

    Private Sub DIAGONALPRINCIPALToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DIAGONALPRINCIPALToolStripMenuItem.Click
        Me.Hide()
        MULTIPLOS.Show()
    End Sub

    Private Sub MATRIZDIAGONALToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MATRIZDIAGONALToolStripMenuItem.Click
        Me.Hide()
        DIAGONAL.Show()
    End Sub

    Private Sub SUMADEFILASYCOLUMNASDEUNAMATRIZToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SUMADEFILASYCOLUMNASDEUNAMATRIZToolStripMenuItem.Click
        Me.Hide()
        SUMA.Show()
    End Sub

    Private Sub JUEGOToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles JUEGOToolStripMenuItem.Click
        Me.Hide()
        JUEGO.Show()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class
