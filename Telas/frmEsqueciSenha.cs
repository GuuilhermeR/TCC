using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Net;
using System.Net.Mail;
using System.Text.RegularExpressions;
using static Classes.HelperFuncoes;

namespace TCC2.Telas
{
    public partial class frmEsqueciSenha : MaterialForm
    {

        UsuarioDAO usuarioDAO = new UsuarioDAO();

        public frmEsqueciSenha()
        {
            InitializeComponent();
            FormatView(this);
        }

        private void frmEsqueciSenha_Load(object sender, EventArgs e)
        {

        }

        [Obsolete]
        private void mBtnRecuperar_Click(object sender, EventArgs e)
        {

            var listaUsuarios = usuarioDAO.getEmail((mTxtEmailRecuperar.Text));
            if (listaUsuarios == null || listaUsuarios.Count <= 0)
                return;

            string retorno = string.Empty;
            
            listaUsuarios.ForEach(x =>
            {
                retorno = EnviarEmail(x.email, "nutriez.suporte@gmail.com", "Recuperação de Senha", x.usuario);
            });
            if (retorno != string.Empty)
                nMensagemAviso(retorno);
        }

        [Obsolete]
        private string EnviarEmail(string para, string Remetente, string Assunto, string usuario)
        {
            try
            {
                bool bValidaEmail = ValidaEnderecoEmail(para);

                if (bValidaEmail == false)
                    return "Email do destinatário inválido: " + para;

                string novaSenha = GerarNovaSenha();

                var enviaMensagem = $@"
                      <html>

                        <head>
                            <title>Recuperação de senha</title>
                        </head>

                       <body>

                          <h1>Recuperação de senha</h1>

                          <h4>Você solicitou sua nova senha para acessar o NutriEz Software Nutricional, sua nova senha é: <h2><b>{novaSenha}</b></h2></h4>

                          <h4>Para acessar novamente o programa, é necessário que você utilize a senha que enviamos para você e após isso, poderá alterar a senha pelo nosso programa.</h4>


                          <h4 style=string.Emptycolor:#ff0000;string.Empty>Não responda este e-mail.</h4>
                       </body>

                      </html> ";

                string erro = SenderMail(para, Remetente, Assunto, enviaMensagem);

                if (!string.IsNullOrEmpty(erro))
                {
                    return erro;
                }

                usuarioDAO.SalvarNovaSenha(usuario, novaSenha);
                return "Uma nova senha foi enviado para o seu e-mail";
            }
            catch (Exception ex)
            {
                string erro = ex.InnerException.ToString();
                return ex.Message.ToString() + erro;
            }
        }
        public static bool ValidaEnderecoEmail(string enderecoEmail)
        {
            try
            {
                string texto_Validar = enderecoEmail;
                Regex expressaoRegex = new Regex(@"\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}");

                if (expressaoRegex.IsMatch(texto_Validar))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
