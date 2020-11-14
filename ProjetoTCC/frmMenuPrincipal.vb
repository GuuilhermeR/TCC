Public Class frmMenuPrincipal


    Private Sub btnConfiguracao_Click(sender As Object, e As EventArgs)
        abrirFormFilho(frmConfiguracoes)
    End Sub

    Private Sub btnCadastrarAlimento_Click(sender As Object, e As EventArgs) Handles btnCadastrarAlimento.Click
        abrirFormFilho(frmCadastroAlimento)
    End Sub

    Private currentForm As Form = Nothing

    Private Sub abrirFormFilho(childForm As Form)

        If currentForm IsNot Nothing Then currentForm.Close()
        currentForm = childForm
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        PainelFilho.Controls.Add(childForm)
        PainelFilho.Tag = childForm
        childForm.BringToFront()
        childForm.Show()

    End Sub

    Private Sub btnConsultarAlimentos_Click(sender As Object, e As EventArgs) Handles btnConsultarAlimentos.Click
        abrirFormFilho(frmConfiguracoes)
    End Sub

    Private Sub frmMenuPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ' Me.Text = ""
        'Me.ControlBox = False
        'Me.DoubleBuffered = True
        'Me.MaximizedBounds = Screen.PrimaryScreen.WorkingArea
    End Sub

    Private Sub PainelFilho_Paint(sender As Object, e As PaintEventArgs) Handles PainelFilho.Paint

    End Sub
End Class