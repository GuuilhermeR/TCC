Public Class frmMenuPrincipal


    Private Sub btnConfiguracao_Click(sender As Object, e As EventArgs)
        Using frmConfiguracoes As New frmConfiguracoes
            frmConfiguracoes.ShowDialog()
        End Using
    End Sub

    Private Sub btnCadastrarAlimento_Click(sender As Object, e As EventArgs) Handles btnCadastrarAlimento.Click
        Using frmCadastroNutricional As New frmCadastroNutricional
            frmCadastroNutricional.ShowDialog()
        End Using
    End Sub

    Private Sub btnConsultarAlimentos_Click(sender As Object, e As EventArgs) Handles btnConsultarAlimentos.Click
        Using frmConsultaMedidasCaseiras As New frmConsultaMedidasCaseiras
            frmConsultaMedidasCaseiras.ShowDialog()
        End Using
    End Sub

    Private Sub frmMenuPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.Text = ""
        Me.ControlBox = False
        Me.DoubleBuffered = True
        Me.MaximizedBounds = Screen.PrimaryScreen.WorkingArea
    End Sub
End Class