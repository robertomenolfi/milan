using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milan
{
    internal class GiocatoreDelMilan
    // ^3
    {
        public string Nome { get; set; }
        public int NumeroDiMaglia { get; set; } // proprieta' => AaaBbbbbCcccDdd

        public GiocatoreDelMilan() // costruttore
        {

        }

        public GiocatoreDelMilan(string nome, int numeroDiMaglia) // costruttore
        {
            Nome = nome;
            NumeroDiMaglia = numeroDiMaglia;
        }

        // datadinascita
        // periodo al milan
        // numero di scarpe

    }
}
