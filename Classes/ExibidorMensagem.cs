using System.Windows.Forms;

namespace Classes
{
    public class ExibidorMensagem
    {   
        public ExibidorMensagem() { }
        public static DialogResult nMensagemErro(string mensagem, IWin32Window owner = null)
        {
            return MessageBox.Show(owner, mensagem, "Nutreasy", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static DialogResult nMensagemAviso(string mensagem, IWin32Window owner = null)
        {
            return MessageBox.Show(owner, mensagem, "Nutreasy", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static DialogResult nMensagemAlerta(string mensagem, IWin32Window owner = null)
        {
            return MessageBox.Show(owner, mensagem, "Nutreasy", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public static DialogResult nMensagemAceita(string mensagem, IWin32Window owner = null)
        {
            return MessageBox.Show(owner, mensagem, "Nutreasy", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        }
    }
}
