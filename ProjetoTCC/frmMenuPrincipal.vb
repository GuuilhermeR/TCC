Public Class frmMenuPrincipal

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub btnCalculos_Click(sender As Object, e As EventArgs) Handles btnCalculos.Click

        frmCadastroNutricional.Show()

    End Sub
End Class