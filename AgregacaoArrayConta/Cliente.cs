using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoArrayConta
{
    public class Cliente
    {
        public string Nome {get; set;}
        public long Rg {get; set;}
        public void Mostrar()
        {
         System.Console.WriteLine("nome: " + Nome + "\nRg: " + Rg);
        }
    }
}