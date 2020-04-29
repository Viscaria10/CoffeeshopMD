Public Class frm_main
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> 5161a45d4146e7ea02036b6319d10c22e24ea894
    Private Sub frm_main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click

        If confirm("คุณจะออกจากระบบหรือไม่ ?") = vbNo Then Return
        Me.Close()
        frm_login.Show()
        With frm_login

            .txt_password.Text = ""
            .txt_security_code.Text = ""
            .lbl_security_code.Text = rnd_securitu_code()
            .txt_password.Select()
        End With

    End Sub

    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) Handles ToolStripButton5.Click
        frm_manage_coffee.Show()
        frm_manage_coffee.MdiParent = Me
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        frm_coffeeSale.Show()
        frm_coffeeSale.MdiParent = Me
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        frm_promotion.Show()
        frm_promotion.MdiParent = Me
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        frm_customer.Show()
        frm_customer.MdiParent = Me
    End Sub
<<<<<<< HEAD
=======
=======

>>>>>>> 216d8087a2f689497a661d7a92fca7fbdf6d69e1
>>>>>>> 5161a45d4146e7ea02036b6319d10c22e24ea894
End Class