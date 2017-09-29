using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibreriaCamilo
{
    public class Utilidades
    {
        public static int TOINT(string numero)
        {
            int retorno = 0;
            int.TryParse(numero, out retorno);
            return retorno;
        }
    }
}
