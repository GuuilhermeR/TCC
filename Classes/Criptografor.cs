using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Criptografor
    {

        public Criptografor() { }


        private void MoveBytes(Stream fonte, Stream destino)
        {
            byte[] bytes = new byte[2049];
            var contador = fonte.Read(bytes, 0, bytes.Length - 1);
            while ((0 != contador))
            {
                destino.Write(bytes, 0, contador);
                contador = fonte.Read(bytes, 0, bytes.Length - 1);
            }
        }

        public string DescriptPassword(string senhaUsuario)
        {
            string retorno = string.Empty;
            try
            {
                if (!string.IsNullOrEmpty(senhaUsuario))
                {
                    string senha = "004195";
                    byte[] sal = { 0x0, 0x1, 0x2, 0x3, 0x4, 0x5, 0x6, 0x5, 0x4, 0x3, 0x2, 0x1, 0x0 };
                    byte[] textoCifrado = Convert.FromBase64String(senha);
                    Rfc2898DeriveBytes chave = new Rfc2898DeriveBytes(senha, sal);
                    var algoritmo = new RijndaelManaged();
                    algoritmo.Key = chave.GetBytes(16);
                    algoritmo.IV = chave.GetBytes(16);
                    using (var StreamFonte = new MemoryStream(textoCifrado))
                    {
                        using (MemoryStream StreamDestino = new MemoryStream())
                        {
                            using (CryptoStream crypto = new CryptoStream(StreamFonte, algoritmo.CreateDecryptor(), CryptoStreamMode.Read))
                            {
                                this.MoveBytes(crypto, StreamDestino);
                                byte[] bytesDescriptografados = StreamDestino.ToArray();
                                retorno = new UnicodeEncoding().GetString(bytesDescriptografados);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex);
            }
            return retorno;
        }

        public string Criptografar(string texto)
        {
            string retorno = string.Empty;
            if (!string.IsNullOrEmpty(texto))
            {
                string senha = "004195";
                byte[] sal = { 0x0, 0x1, 0x2, 0x3, 0x4, 0x5, 0x6, 0x5, 0x4, 0x3, 0x2, 0x1, 0x0 };
                Rfc2898DeriveBytes chave = new Rfc2898DeriveBytes(senha, sal);
                var algoritmo = new RijndaelManaged();
                algoritmo.Key = chave.GetBytes(16);
                algoritmo.IV = chave.GetBytes(16);
                byte[] fonteBytes = new System.Text.UnicodeEncoding().GetBytes(texto);
                using (var streamFonte = new MemoryStream(fonteBytes))
                {
                    using (MemoryStream streamDestino = new MemoryStream())
                    {
                        using (CryptoStream crypto = new CryptoStream(streamFonte, algoritmo.CreateEncryptor(), CryptoStreamMode.Read))
                        {
                            this.MoveBytes(crypto, streamDestino);
                            retorno = Convert.ToBase64String(streamDestino.ToArray());
                        }
                    }
                }
            }
            return retorno;
        }

    }
}
