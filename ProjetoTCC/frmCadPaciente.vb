Public Class frmCadPaciente
    Private Sub txtCEP_Leave(sender As Object, e As EventArgs) Handles txtCEP.Leave

        Using WS = New BuscaCEP.AtendeClienteClient()
            Try
                Dim Resultado = WS.consultaCEP(txtCEP.Text)
                Me.txtEndereco.Text = Resultado.[end]
                Me.txtComplemento.Text = Resultado.complemento2
                Me.txtMunicipio.Text = Resultado.cidade
                Me.txtBairro.Text = Resultado.bairro
                Me.txtUF.Text = Resultado.uf
            Catch Ex As Exception
                MessageBox.Show(Ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.[Error])
            End Try
        End Using

    End Sub
End Class