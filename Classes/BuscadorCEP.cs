using System;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace TCC2
{
    public class BuscadorCEP
    {

        public BuscadorCEP(){}

        public void buscarEndCep(frmMenuPrincipal menu, string CEP)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create($@"https://viacep.com.br/ws/{CEP}/json/");
            request.AllowAutoRedirect = false;
            HttpWebResponse ChecaServidor;

            try
            {
                ChecaServidor = (HttpWebResponse)request.GetResponse();
            }
            catch
            {
                MessageBox.Show("Você não tem uma conexão com a internet, não foi possível buscar os dados.");
                return;
            }

            if (ChecaServidor.StatusCode != HttpStatusCode.OK)
            {
                MessageBox.Show("Você não tem conexão com a internet.");
                return;
            }

            using (Stream webStream = ChecaServidor.GetResponseStream())
            {
                if (webStream != null)
                {
                    using (StreamReader responseReader = new StreamReader(webStream))
                    {
                        string response = responseReader.ReadToEnd();
                        response = Regex.Replace(response, "[{},]", string.Empty);
                        response = response.Replace("\"", "");

                        String[] substrings = response.Split('\n');

                        int cont = 0;
                        foreach (var substring in substrings)
                        {
                            if (cont == 1)
                            {
                                string[] valor = substring.Split(":".ToCharArray());
                                if (valor[0] == "  erro")
                                {
                                    MessageBox.Show("CEP não encontrado");
                                    menu.txtCEP.Focus();
                                    return;
                                }
                            }

                            //Logradouro
                            if (cont == 2)
                            {
                                string[] valor = substring.Split(":".ToCharArray());
                                menu.txtEndereco.Text = valor[1];
                            }

                            //Complemento
                            if (cont == 3)
                            {
                                string[] valor = substring.Split(":".ToCharArray());
                                menu.txtComplemento.Text = valor[1];
                            }

                            //Bairro
                            if (cont == 4)
                            {
                                string[] valor = substring.Split(":".ToCharArray());
                                menu.txtBairro.Text = valor[1];
                            }

                            //Localidade (Cidade)
                            if (cont == 5)
                            {
                                string[] valor = substring.Split(":".ToCharArray());
                                menu.txtMunicipio.Text = valor[1];
                            }

                            //Estado (UF)
                            if (cont == 6)
                            {
                                string[] valor = substring.Split(":".ToCharArray());
                                menu.txtUF.Text = valor[1];
                            }

                            cont++;
                        }
                    }
                }
            }
        }
    }
}
