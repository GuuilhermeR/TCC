Public Class frmMenuNovo

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hideSubmenu()
    End Sub

    Private Sub hideSubmenu()

        PanelMediaSubmenu.Visible = False
        PanelPlaylistSubmenu.Visible = False

    End Sub

    Private Sub showSubmenu(submenu As Panel)

        If submenu.Visible = False Then
            hideSubmenu()
            submenu.Visible = True
        Else
            submenu.Visible = False
        End If

    End Sub

    Private Sub btnMedia_Click(sender As Object, e As EventArgs) Handles btnCadastrar.Click
        showSubmenu(PanelMediaSubmenu)
    End Sub

    Private Sub btnPlaylist_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        showSubmenu(PanelPlaylistSubmenu)
    End Sub

#Region "Buttons Submenu"
    Private Sub button2_Click(sender As Object, e As EventArgs) Handles btnCadastrarAlimento.Click
        openChildForm(New frmCadastroAlimento())
        hideSubmenu()
    End Sub

    Private Sub button3_Click(sender As Object, e As EventArgs) Handles btnCardapio.Click
        hideSubmenu()
    End Sub

    Private Sub button4_Click(sender As Object, e As EventArgs) Handles btnCadPaciente.Click
        hideSubmenu()
    End Sub

    Private Sub button5_Click(sender As Object, e As EventArgs)
        hideSubmenu()
    End Sub

    Private Sub button8_Click(sender As Object, e As EventArgs) Handles button8.Click
        openChildForm(New frmConsultaAlimentos())
        hideSubmenu()
    End Sub

    Private Sub button7_Click(sender As Object, e As EventArgs) Handles btnConsCardápio.Click
        hideSubmenu()
    End Sub

    Private Sub button6_Click(sender As Object, e As EventArgs) Handles btnPaciente.Click
        hideSubmenu()
    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs)
        hideSubmenu()
    End Sub

    Private Sub button13_Click(sender As Object, e As EventArgs)
        hideSubmenu()
    End Sub

    Private Sub button12_Click(sender As Object, e As EventArgs)
        hideSubmenu()
    End Sub

    Private Sub button10_Click(sender As Object, e As EventArgs)
        hideSubmenu()
    End Sub
#End Region

    Private Sub btnEqualizer_Click(sender As Object, e As EventArgs)
        hideSubmenu()
    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs)
        hideSubmenu()
    End Sub

    Private currentForm As Form = Nothing
    Private Sub openChildForm(childForm As Form)

        If currentForm IsNot Nothing Then currentForm.Close()
        currentForm = childForm
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        PanelChildForm.Controls.Add(childForm)
        PanelChildForm.Tag = childForm
        childForm.BringToFront()
        childForm.Show()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub PanelChildForm_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub PanelSideMenu_Paint(sender As Object, e As PaintEventArgs) Handles PanelSideMenu.Paint

    End Sub

    Private Sub btnConfigurações_Click(sender As Object, e As EventArgs) Handles btnConfigurações.Click
        openChildForm(New frmConfiguracoes())

        hideSubmenu()
    End Sub
End Class
