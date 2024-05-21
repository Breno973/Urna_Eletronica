using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Urna_Eletronica
{
    internal class Candidatos
    {
        public int numero { get; set; }
        public String nome { get; set; }
        public Candidatos(int numero, string nome)
        {
            this.numero = numero;
            this.nome = nome;
        }
    }
}
