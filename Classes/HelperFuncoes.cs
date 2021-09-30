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
                tLoad = new Thread(ShowWait);
                tLoad.Start();
            }
            catch { }
        }

        public static void loadStop()
        {
            try
            {
                tLoad.Abort();
            }
            catch { }
        }

        public static void ShowWait()
        {
            using (frmWait wait = new frmWait())
            {
                tLoad.Join();
                try
                {
                    wait.ShowDialog();
                }
                catch { }
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
                Text = "";
            if (Text == "")
                Text = Convert.ToString(DateTime.Today);
            if (Text == "")
            {
            }
            if (Text.IndexOf("/") < 0)
            {
                if (Text.Length <= 2)
                    Text = Text + "/" + DateTime.Today.Month + "/" + DateTime.Today.Year;
                else if (Text.Length == 3 | Text.Length == 5 | Text.Length == 7)
                    Text = "";
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
                return "";
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

    }
}
