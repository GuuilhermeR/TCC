using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Net;
using System.Net.Mail;
using System.Text.RegularExpressions;

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
            EnviarEmail("guilherme.rudiger@catolicasc.edu.br", "", "Alteração de Senha", "Sua nova senha é: ","guilherme");
            var listaUsuarios = usuarioDAO.getEmail((mTxtEmailRecuperar.Text));
            if (listaUsuarios == null || listaUsuarios.Count <= 0)
                return;
            listaUsuarios.ForEach(x =>
            {
                EnviarEmail(x.email, "", "Alteração de Senha", "Sua nova senha é: ",x.usuario);
            });

        }

        [Obsolete]
        private string EnviarEmail(string Destinatario, string Remetente, string Assunto, string enviaMensagem, string usuario)
        {
            try
            {
                // valida o email
                bool bValidaEmail = ValidaEnderecoEmail(Destinatario);

                // Se o email não é valido retorna uma mensagem
                if (bValidaEmail == false)
                    return "Email do destinatário inválido: " + Destinatario;

               string novaSenha = usuarioDAO.GerarNovaSenha(usuario);

                // cria uma mensagem
                MailMessage mensagemEmail = new MailMessage(Remetente, Destinatario, Assunto, enviaMensagem + novaSenha);

                System.Net.Mail.SmtpClient server = new System.Net.Mail.SmtpClient();

                server.Credentials = new System.Net.NetworkCredential("guilherme.rudiger@catolicasc.org.br", "Guilherme@1");

                server.Host = Remetente;
                server.Port = 587;
                try
                {
                    server.EnableSsl = true;
                    server.Send(mensagemEmail);
                }
                catch (Exception ex)
                {
                    server.Port = 25;
                    try
                    {
                        server.Send(mensagemEmail);
                    }
                    catch (Exception ex1)
                    {
                        string erro = ex.InnerException.ToString();
                        return ex.Message.ToString() + erro;
                    }
                }

                return "Mensagem enviada para o seu e-mail";
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
