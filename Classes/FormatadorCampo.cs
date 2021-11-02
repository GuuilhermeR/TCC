using System;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace NutriEz
{
    public class FormatadorCampo
    {
        public FormatadorCampo(){}

        public static string FormataCep(string cep)
        {
            try
            {
                return Convert.ToUInt64(cep).ToString(@"00000\-000");
            }
            catch
            {
                return string.Empty;
            }
        }

    }
}
