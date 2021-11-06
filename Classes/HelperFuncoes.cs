using MaterialSkin;
using Microsoft.VisualBasic;
using System;
using System.Threading;
using System.Windows.Forms;
using NutriEz.Telas;
using System.Security.Cryptography;
using System.IO;
using System.Linq;
using System.Text;
using NutriEz.Classes;
using System.Data.SQLite;
using NutriEz;
using System.Net;
using System.Drawing;

namespace Classes
{
    public class HelperFuncoes
    {

        public HelperFuncoes() { }

        static Thread tLoad;

        private const int Keysize = 256;

        private const int DerivationIterations = 1000;

        private const string pass = "30F8HYT85aYDUW";

        public static void loadStart(Form menu)
        {
            try
            {
                if (tLoad == null || !tLoad.ThreadState.Equals(ThreadState.Running) || tLoad.ThreadState.Equals(ThreadState.Aborted) || tLoad.ThreadState.Equals(ThreadState.AbortRequested))
                {
                    tLoad = new Thread(new ThreadStart(ShowWait));
                    tLoad.Start();
                    menu.Enabled = false;
                }
                else if (tLoad.ThreadState.Equals(ThreadState.Running))
                {
                    tLoad.Abort();
                    tLoad = new Thread(ShowWait);
                    tLoad.Start();
                    menu.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                tLoad.Abort();
                tLoad = new Thread(new ThreadStart(ShowWait));
                tLoad.Start();
                menu.Enabled = false;
            }
        }

        public static void loadStop(Form menu)
        {
            try
            {
                Thread.Sleep(1000);
                tLoad.Abort();
                menu.Enabled = true;
            }
            catch (Exception ex)
            {
                menu.Enabled = true;
                return;
            }
        }

        public static void ShowWait()
        {
            bool jaDeuErro = false;
            using (frmWait wait = new frmWait())
            {
                try
                {
                    if (jaDeuErro)
                    {
                        tLoad.Abort();
                        tLoad = new Thread(new ThreadStart(ShowWait));
                        tLoad.Start();
                        return;
                    }
                    if (tLoad.ThreadState != null && !tLoad.ThreadState.Equals(ThreadState.AbortRequested) && tLoad.ThreadState.Equals(ThreadState.Running) && !tLoad.ThreadState.Equals(ThreadState.Aborted) && !tLoad.ThreadState.Equals(ThreadState.Suspended) && !tLoad.ThreadState.Equals(ThreadState.SuspendRequested))
                    {
                        wait.ShowDialog();
                        wait.Activate();
                    }
                }
                catch (ThreadAbortException ex)
                {
                    tLoad.Abort();
                    tLoad = new Thread(new ThreadStart(ShowWait));
                    tLoad.Start();
                    jaDeuErro = true;
                }
                catch (Exception ex)
                {
                    tLoad.Abort();
                    tLoad = new Thread(new ThreadStart(ShowWait));
                    tLoad.Start();
                    jaDeuErro = true;
                }
            }
        }

        public static string CalcularIMC(double peso, double altura)
        {
            double imc;

            imc = (peso / (Math.Pow(altura, 2))) * 10000;

            if (imc <= 18.5)
            {
                return ("Peso abaixo do normal");
            }
            else if ((imc > 18.5) && (imc < 25))
            {
                return ("Peso normal");
            }
            else if ((imc >= 25) && (imc < 30))
            {
                return ("Sobrepeso");
            }
            else if ((imc >= 30) && (imc < 35))
            {
                return ("Grau de Obesidade I");
            }
            else if ((imc >= 35) && (imc < 40))
            {
                return ("Grau de Obesidade II");
            }
            else if (imc >= 40)
            {
                return ("Obesidade Grau III ou Mórbida");
            }
            return string.Empty;
        }
        public static int calcularIdade(string dataNas)
        {
            DateTime dataNascimento = Convert.ToDateTime(dataNas);
            int idade = DateTime.Now.Year - dataNascimento.Year;
            if (DateTime.Now.DayOfYear < dataNascimento.DayOfYear)
            {
                idade -= 1;
            }
            return idade;
        }
        public static void FormatView(MaterialSkin.Controls.MaterialForm form)
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = false;
            materialSkinManager.AddFormToManage(form);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green800, Primary.Green900, Primary.BlueGrey500, Accent.Green700, TextShade.WHITE);
        }

        public static string FormatDate(string Text)
        {
            if (Text == null)
                Text = string.Empty;
            if (Text.Length > 10)
                Text = string.Empty;
            if (Text == string.Empty)
                Text = Convert.ToString(DateTime.Today);
            if (Text == string.Empty)
            {
            }
            if (Text.IndexOf("/") < 0)
            {
                if (Text.Length <= 2)
                    Text = Text + "/" + DateTime.Today.Month + "/" + DateTime.Today.Year;
                else if (Text.Length == 3 | Text.Length == 5 | Text.Length == 7)
                    Text = string.Empty;
                else if (Text.Length == 4)
                    Text = (Strings.Left(Text, 2) + "/" + Strings.Right(Text, 2) + "/" + DateTime.Today.Year);
                else if (Text.Length == 6)
                    Text = (Strings.Left(Text, 2) + "/" + Strings.Right(Strings.Left(Text, 4), 2) + "/" + Strings.Right(Text, 2));
                else if (Text.Length == 8)
                    Text = (Strings.Left(Text, 2) + "/" + Strings.Right(Strings.Left(Text, 4), 2) + "/" + Strings.Right(Text, 4));
            }
            if (Information.IsDate(Text))
            {
                Text = Text;
                return Text;
            }
            else
                return string.Empty;
        }

        public static DialogResult nMensagemErro(string mensagem, IWin32Window owner = null)
        {
            return MessageBox.Show(owner, mensagem, "NutriEz", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static DialogResult nMensagemAviso(string mensagem, IWin32Window owner = null)
        {
            return MessageBox.Show(owner, mensagem, "NutriEz", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static DialogResult nMensagemAlerta(string mensagem, IWin32Window owner = null)
        {
            return MessageBox.Show(owner, mensagem, "NutriEz", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public static DialogResult nMensagemAceita(string mensagem, IWin32Window owner = null)
        {
            return MessageBox.Show(owner, mensagem, "NutriEz", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        public static string formatarHora(string hora)
        {
            if (string.IsNullOrEmpty(hora))
                return string.Empty;

            if (hora.Length.Equals(1))
            {
                return hora + "0" + ":" + "00";
            }
            else if (hora.Length.Equals(2))
            {
                return Strings.Left(hora, 2) + ":" + "00";
            }
            else if (hora.Length.Equals(3))
            {
                return Strings.Left(hora, 2) + ":" + Strings.Right(hora, 1) + "0";
            }

            return Strings.Left(hora, 2) + ":" + Strings.Right(hora, 2);
        }

        public static string AESEncrypt(string input)
        {
            System.Security.Cryptography.RijndaelManaged AES = new System.Security.Cryptography.RijndaelManaged();
            System.Security.Cryptography.MD5CryptoServiceProvider Hash_AES = new System.Security.Cryptography.MD5CryptoServiceProvider();
            string encrypted = "";
            try
            {
                byte[] hash = new byte[32];
                byte[] temp = Hash_AES.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(pass));
                Array.Copy(temp, 0, hash, 0, 16);
                Array.Copy(temp, 0, hash, 15, 16);
                AES.Key = hash;
                AES.Mode = System.Security.Cryptography.CipherMode.ECB;
                System.Security.Cryptography.ICryptoTransform DESEncrypter = AES.CreateEncryptor();
                byte[] Buffer = System.Text.ASCIIEncoding.ASCII.GetBytes(input);
                encrypted = Convert.ToBase64String(DESEncrypter.TransformFinalBlock(Buffer, 0, Buffer.Length));
                return encrypted;
            }
            catch (Exception ex)
            {
            }
            return string.Empty;
        }

        public static Bitmap ByteToImage(byte[] blob)
        {
            MemoryStream mStream = new MemoryStream();
            byte[] pData = blob;
            mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            Bitmap bm = new Bitmap(mStream, false);
            mStream.Dispose();
            return bm;
        }

        public static string AESDecrypt(string input)
        {
            System.Security.Cryptography.RijndaelManaged AES = new System.Security.Cryptography.RijndaelManaged();
            System.Security.Cryptography.MD5CryptoServiceProvider Hash_AES = new System.Security.Cryptography.MD5CryptoServiceProvider();
            string decrypted = "";
            try
            {
                byte[] hash = new byte[32];
                byte[] temp = Hash_AES.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(pass));
                Array.Copy(temp, 0, hash, 0, 16);
                Array.Copy(temp, 0, hash, 15, 16);
                AES.Key = hash;
                AES.Mode = System.Security.Cryptography.CipherMode.ECB;
                System.Security.Cryptography.ICryptoTransform DESDecrypter = AES.CreateDecryptor();
                byte[] Buffer = Convert.FromBase64String(input);
                decrypted = System.Text.ASCIIEncoding.ASCII.GetString(DESDecrypter.TransformFinalBlock(Buffer, 0, Buffer.Length));
                return decrypted;
            }
            catch (Exception ex)
            {
            }
            return String.Empty;
        }

        private static byte[] Generate256BitsOfRandomEntropy()
        {
            var randomBytes = new byte[32]; // 32 Bytes will give us 256 bits.
            using (var rngCsp = new RNGCryptoServiceProvider())
            {
                // Fill the array with cryptographically secure random bytes.
                rngCsp.GetBytes(randomBytes);
            }
            return randomBytes;
        }

        public static string GerarNovaSenha()
        {
            SQLiteCommand cmd;
            cmd = new SQLiteCommand();
            string senha = string.Empty;

            string senhaDescrip = GeraSenhaAleatoria();
            senha = senhaDescrip;

            return senhaDescrip;
        }

        private static string GeraSenhaAleatoria()
        {
            const string charPerm = "abcdefghijkmnopqrstuvwxyzABCDEFGHJKLMNOPQRSTUVWXYZ0123456789!@$?_-";


            string permitido = string.Empty;
            permitido += charPerm;

            int caracteres_minimo = 5;
            int caracteres_maximo = 10;
            int numero_caracteres = Crypto.RandomInteger(caracteres_minimo, caracteres_maximo);

            string _senha = string.Empty;
            _senha += RandomChar(charPerm);

            while (_senha.Length < numero_caracteres)
                _senha += RandomChar(permitido);

            _senha = RandomizeString(_senha);
            return _senha;
        }

        private static string RandomChar(string str)
        {
            return str.Substring(Crypto.RandomInteger(0, str.Length - 1), 1);
        }

        private static string RandomizeString(string str)
        {
            string resultado = string.Empty;
            while (str.Length > 0)
            {
                // Pega um numero aleatorio
                int i = Crypto.RandomInteger(0, str.Length - 1);
                resultado += str.Substring(i, 1);
                str = str.Remove(i, 1);
            }
            return resultado;
        }

        public static string SenderMail(string para, string Remetente, string Assunto, string corpo)
        {
            try
            {
                System.Net.Mail.MailMessage objEmail = new System.Net.Mail.MailMessage();

                System.Net.Mail.MailAddress enviadoPor = new System.Net.Mail.MailAddress(Remetente);
                objEmail.From = enviadoPor;
                objEmail.To.Add(para);
                objEmail.Subject = Assunto;
                objEmail.Body = corpo;
                objEmail.Priority = System.Net.Mail.MailPriority.High;

                System.Net.Mail.SmtpClient server = new System.Net.Mail.SmtpClient();
                server.UseDefaultCredentials = false;
                server.Credentials = new NetworkCredential("nutriez.suporte@gmail.com", "Guilherme@1");

                objEmail.IsBodyHtml = true;
                server.Host = "smtp.gmail.com";
                server.Port = 587;

                try
                {
                    server.EnableSsl = true;
                    server.Send(objEmail);
                }
                catch
                {
                    server.Port = 25;
                    try
                    {
                        server.Send(objEmail);
                    }
                    catch (Exception ex1)
                    {
                        return ex1.Message;
                    }
                }

                return string.Empty;
            }
            catch (Exception ex)
            {
                string erro = ex.Message.ToString();
                return ex.Message.ToString() + erro;
            }

        }

    }
}
