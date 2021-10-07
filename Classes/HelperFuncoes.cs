using MaterialSkin;
using Microsoft.VisualBasic;
using System;
using System.Threading;
using System.Windows.Forms;
using TCC2.Telas;

namespace Classes
{
    public class HelperFuncoes
    {

        public HelperFuncoes() { }

        static Thread tLoad;

        public static void loadStart()
        {
            try
            {
                if (tLoad == null || !tLoad.ThreadState.Equals(ThreadState.Running) || tLoad.ThreadState.Equals(ThreadState.Aborted))
                {
                    tLoad = new Thread(ShowWait);
                }
                else if (tLoad.ThreadState.Equals(ThreadState.Running))
                {
                    tLoad.Abort();
                }
                tLoad.Start();
            }
            catch (Exception ex)
            {
                tLoad.Abort();
                tLoad = new Thread(ShowWait);
            }
        }

        public static void loadStop()
        {
            try
            {
                tLoad.Abort();
            }
            catch (Exception ex)
            {
                return;
            }
        }

        public static void ShowWait()
        {
            using (frmWait wait = new frmWait())
            {
                bool jaDeuErro = false;
                try
                {
                    if (!jaDeuErro)
                    {
                        tLoad.Abort();
                        tLoad.Start();
                        return;
                    }
                    wait.ShowDialog();
                    wait.Activate();
                }
                catch (ThreadAbortException ex)
                {
                    tLoad.Abort();
                    tLoad = new Thread(ShowWait);
                    jaDeuErro = true;
                }
            }
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

    }
}
