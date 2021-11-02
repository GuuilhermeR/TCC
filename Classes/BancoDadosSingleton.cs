using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NutriEz.Banco_de_Dados;

namespace NutriEz
{
    class BancoDadosSingleton
    {
        private static NutreasyEntities instance;

        private BancoDadosSingleton() { }

        public static NutreasyEntities Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new NutreasyEntities();
                }
                return instance;
            }
        }
    }
}
