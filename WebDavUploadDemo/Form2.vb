Public Class f_utama

    Private Sub WebDavToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WebDavToolStripMenuItem.Click

    End Sub

    Private Sub WeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WeToolStripMenuItem.Click

    End Sub

    Private Sub AspShellMakerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AspShellMakerToolStripMenuItem.Click
        Form1.Show()

        Me.Hide()


    End Sub

    Private Sub AuthorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AuthorToolStripMenuItem.Click
        MsgBox("Peluru Kertas Rootkit" & vbNewLine & "Tool ini masih berkembang, Update dari waktu ke waktu" & vbNewLine & "jadi, Mungkin masih ada menu yang gak aktif nanti akan saya buatkan", vbInformation, "info")
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        Dim keluar As MsgBoxResult
        keluar = MsgBox("Yakin mau keluar ?", CType(vbQuestion + vbOKCancel, MsgBoxStyle), "Keluar?")
        If keluar = MsgBoxResult.Ok Then
            Close()
        End If
    End Sub

    Private Sub PictureBox1_DblClick(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim keluar As MsgBoxResult
        keluar = MsgBox("Yakin mau keluar ?", CType(vbQuestion + vbOKCancel, MsgBoxStyle), "Keluar?")
        If keluar = MsgBoxResult.Ok Then
            Close()
        End If
    End Sub
End Class