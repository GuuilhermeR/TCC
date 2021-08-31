using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Net;
using System.Net.Mail;
using System.Text.RegularExpressions;
using static Classes.ExibidorMensagem;

namespace TCC2.Telas
{
    public partial class frmEsqueciSenha : MaterialForm
    {

        UsuarioDAO usuarioDAO = new UsuarioDAO();

        public frmEsqueciSenha()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green800, Primary.Green900, Primary.BlueGrey500, Accent.Green700, TextShade.WHITE);
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
                retorno = EnviarEmail(x.email, "nutreasy.suporte@gmail.com", "Recuperação de Senha", x.usuario);
            });
            if (retorno != "")
                nMensagemErro(retorno);
        }

        [Obsolete]
        private string EnviarEmail(string para, string Remetente, string Assunto, string usuario)
        {
            try
            {
                bool bValidaEmail = ValidaEnderecoEmail(para);

                if (bValidaEmail == false)
                    return "Email do destinatário inválido: " + para;

                string novaSenha = usuarioDAO.GerarNovaSenha();

                var enviaMensagem = $@"<html>
                            <head>
                            <title>Recuperação de senha</title>
                            </head>
                            <body>

                            <h1>Recuperação de senha</h1>
                            <p>Você solicitou sua nova senha para acessar o Nutreasy Software Nutricional, sua nova senha é: <b>{novaSenha}</b></p>

                            <p>Para acessar novamente o programa, é necessário que você utilize a senha que enviamos para você e após isso, poderá alterar a senha pelo nosso programa.</p>  
                            <p>Não responda este e-mail.</p>  

                            </body>
                            </html>";

                System.Net.Mail.MailMessage objEmail = new System.Net.Mail.MailMessage();

                System.Net.Mail.MailAddress enviadoPor = new System.Net.Mail.MailAddress(Remetente);
                objEmail.From = enviadoPor;
                objEmail.To.Add(para);
                objEmail.Subject = Assunto;
                objEmail.Body = enviaMensagem;
                objEmail.Priority = System.Net.Mail.MailPriority.High;

                System.Net.Mail.SmtpClient server = new System.Net.Mail.SmtpClient();
                server.UseDefaultCredentials = false;
                server.Credentials = new NetworkCredential("nutreasy.suporte@gmail.com", "Guilherme@1");

                objEmail.IsBodyHtml = true;
                server.Host = "smtp.gmail.com";
                server.Port = 587;
                try
                {
                    server.EnableSsl = true;
                    server.Send(objEmail);
                    usuarioDAO.SalvarNovaSenha(usuario, novaSenha);
                }
                catch (Exception ex)
                {
                    server.Port = 25;
                    try
                    {
                        server.Send(objEmail);
                        usuarioDAO.SalvarNovaSenha(usuario, novaSenha);
                    }
                    catch (Exception ex1)
                    {
                        return ex1.Message;
                    }
                }

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
