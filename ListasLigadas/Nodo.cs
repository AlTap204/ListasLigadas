using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasLigadas
{
    internal class Nodo
    {
        public Nodo(string valor = "", Nodo enlace = null)
        {
            Valor = valor;
            Enlace = enlace;
        }

        public string Valor { get; set; }
        public Nodo Enlace { get; set; }

        
    }
}
