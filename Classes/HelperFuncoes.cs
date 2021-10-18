using MaterialSkin;
using Microsoft.VisualBasic;
using System;
using System.Threading;
using System.Windows.Forms;
using TCC2.Telas;
using System.Security.Cryptography;
using System.IO;
using System.Linq;
using System.Text;
using TCC2.Classes;
using System.Data.SQLite;
using TCC2;

namespace Classes
{
    public class HelperFuncoes
    {

        public HelperFuncoes() { }

        static Thread tLoad;

        private const int Keysize = 256;

        private const int DerivationIterations = 1000;

        public static void loadStart(Form menu)
        {
            try
            {
                if (tLoad == null || !tLoad.ThreadState.Equals(ThreadState.Running) || tLoad.ThreadState.Equals(ThreadState.Aborted) || tLoad.ThreadState.Equals(ThreadState.AbortRequested))
                {
                    tLoad = new Thread(ShowWait);
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
                tLoad = new Thread(ShowWait);
                tLoad.Start();
                menu.Enabled = false;
            }
        }

        public static void loadStop(Form menu)
        {
            try
            {
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
                        tLoad.Start();
                        return;
                    }
                    if (tLoad.ThreadState != null && !tLoad.ThreadState.Equals(ThreadState.AbortRequested) && tLoad.ThreadState.Equals(ThreadState.Running) && !tLoad.ThreadState.Equals(ThreadState.Aborted))
                    {
                        wait.ShowDialog();
                        wait.Activate();

                    }
                }
                catch (ThreadAbortException ex)
                {
                    tLoad.Abort();
                    tLoad = new Thread(ShowWait);
                    tLoad.Start();
                    jaDeuErro = true;
                }
                catch (Exception ex)
                {
                    tLoad.Abort();
                    tLoad = new Thread(ShowWait);
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
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
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

        public string DescriptPassword(string texto)
        {
            var cipherTextBytesWithSaltAndIv = Convert.FromBase64String(texto);
            var saltStringBytes = cipherTextBytesWithSaltAndIv.Take(Keysize / 8).ToArray();
            var ivStringBytes = cipherTextBytesWithSaltAndIv.Skip(Keysize / 8).Take(Keysize / 8).ToArray();
            var cipherTextBytes = cipherTextBytesWithSaltAndIv.Skip((Keysize / 8) * 2).Take(cipherTextBytesWithSaltAndIv.Length - ((Keysize / 8) * 2)).ToArray();

            using (var password = new Rfc2898DeriveBytes(texto, saltStringBytes, DerivationIterations))
            {
                var keyBytes = password.GetBytes(Keysize / 8);
                using (var symmetricKey = new RijndaelManaged())
                {
                    symmetricKey.BlockSize = 256;
                    symmetricKey.Mode = CipherMode.CBC;
                    symmetricKey.Padding = PaddingMode.PKCS7;
                    using (var decryptor = symmetricKey.CreateDecryptor(keyBytes, ivStringBytes))
                    {
                        using (var memoryStream = new MemoryStream(cipherTextBytes))
                        {
                            using (var cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read))
                            {
                                var plainTextBytes = new byte[cipherTextBytes.Length];
                                var decryptedByteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);
                                memoryStream.Close();
                                cryptoStream.Close();
                                return Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount);
                            }
                        }
                    }
                }
            }
        }
        public string Criptografar(string texto)
        {
            // Salt and IV is randomly generated each time, but is preprended to encrypted cipher text
            // so that the same Salt and IV values can be used when decrypting.  
            var saltStringBytes = Generate256BitsOfRandomEntropy();
            var ivStringBytes = Generate256BitsOfRandomEntropy();
            var plainTextBytes = Encoding.UTF8.GetBytes(texto);
            using (var password = new Rfc2898DeriveBytes(texto, saltStringBytes, DerivationIterations))
            {
                var keyBytes = password.GetBytes(Keysize / 8);
                using (var symmetricKey = new RijndaelManaged())
                {
                    symmetricKey.BlockSize = 256;
                    symmetricKey.Mode = CipherMode.CBC;
                    symmetricKey.Padding = PaddingMode.PKCS7;
                    using (var encryptor = symmetricKey.CreateEncryptor(keyBytes, ivStringBytes))
                    {
                        using (var memoryStream = new MemoryStream())
                        {
                            using (var cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write))
                            {
                                cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);
                                cryptoStream.FlushFinalBlock();
                                // Create the final bytes as a concatenation of the random salt bytes, the random iv bytes and the cipher bytes.
                                var cipherTextBytes = saltStringBytes;
                                cipherTextBytes = cipherTextBytes.Concat(ivStringBytes).ToArray();
                                cipherTextBytes = cipherTextBytes.Concat(memoryStream.ToArray()).ToArray();
                                memoryStream.Close();
                                cryptoStream.Close();
                                return Convert.ToBase64String(cipherTextBytes);
                            }
                        }
                    }
                }
            }
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

    }
}
