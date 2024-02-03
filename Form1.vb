Imports Windows.Win32.System

Public Class F_MAIN
    Dim colr As Integer
    Dim colg As Integer
    Dim colb As Integer


    Function applycol()
        pb_main.BackColor = Color.FromArgb(CByte(colr), CByte(colg), CByte(colb))
        Return 0
    End Function


    Private Sub F_MAIN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        colr = 255
        colg = 255
        colb = 255
        tb_r.Text = colr
        tb_g.Text = colg
        tb_b.Text = colb
        Call applycol()
    End Sub




    ' Text Boxes

    Private Sub tb_r_TextChanged(sender As Object, e As EventArgs) Handles tb_r.TextChanged
        If Not tb_r.Text = "" Then
            If tb_r.Text > 255 Then
                tb_r.Text = 255
            End If
            sb_r.Value = tb_r.Text
            colr = tb_r.Text
            Call applycol()
        End If
    End Sub

    Private Sub tb_g_TextChanged(sender As Object, e As EventArgs) Handles tb_g.TextChanged
        If Not tb_g.Text = "" Then
            If tb_g.Text > 255 Then
                tb_g.Text = 255
            End If
            sb_g.Value = tb_g.Text
            colg = tb_g.Text
            Call applycol()
        End If
    End Sub

    Private Sub tb_b_TextChanged(sender As Object, e As EventArgs) Handles tb_b.TextChanged
        If Not tb_b.Text = "" Then
            If tb_b.Text > 255 Then
                tb_b.Text = 255
            End If
            sb_b.Value = tb_b.Text
            colb = tb_b.Text
            Call applycol()
        End If
    End Sub


    ' ScrollBars

    Private Sub sb_r_Scroll(sender As Object, e As ScrollEventArgs) Handles sb_r.Scroll
        colr = sb_r.Value
        tb_r.Text = colr
        Call applycol()
    End Sub

    Private Sub sb_g_Scroll(sender As Object, e As ScrollEventArgs) Handles sb_g.Scroll
        colg = sb_g.Value
        tb_g.Text = colg
        Call applycol()
    End Sub

    Private Sub sb_b_Scroll(sender As Object, e As ScrollEventArgs) Handles sb_b.Scroll
        colb = sb_b.Value
        tb_b.Text = colb
        Call applycol()
    End Sub

    ' Filter Input

    Private Sub tb_r_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_r.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub tb_g_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_g.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub tb_b_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_b.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox.Show()
    End Sub

    Private Sub btn_reset_Click(sender As Object, e As EventArgs) Handles btn_reset.Click
        colr = 255
        colg = 255
        colb = 255
        tb_r.Text = colr
        tb_g.Text = colg
        tb_b.Text = colb
        Call applycol()
    End Sub
End Class
