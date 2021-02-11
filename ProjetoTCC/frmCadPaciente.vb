Public Class frmCadPaciente
    Private Sub txtCEP_Leave(sender As Object, e As EventArgs) Handles txtCEP.Leave
        Using WS = New BuscaCEP.AtendeClienteClient()
            Try
                Dim Resultado = WS.consultaCEP(txtCEP.Text)
                txtEndereco.Text = Resultado.[end]
                'TbComplemento.Text = Resultado.complemento
                'TbComplemento2.Text = Resultado.complemento2
                'TbCidade.Text = Resultado.cidade
                txtBairro.Text = Resultado.bairro
                txtUF.Text = Resultado.uf
            Catch Ex As Exception
                MessageBox.Show(Ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.[Error])
            End Try
        End Using
    End Sub
End Class