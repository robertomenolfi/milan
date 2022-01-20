//using static Milan.Enumerators; // serve per poter 'vedere' il tipo Ruolo che e' qui dentro

namespace Milan
{
    internal class GiocatoreDelMilan
    // ^3
    {


        //public string Nome { get; set; }

        private string _nome;
        private string _nomeOriginale;
        public string Nome
        {
            get { return _nome; }
            set
            {
                _nomeOriginale = value;

                var nome = value;
                var t2 = nome.ToUpper();
                var t3 = t2.Replace('A', 'X');
                var t4 = t3 + "...";

                _nome = t4;
            }
        }




        public int NumeroDiMaglia { get; set; } // proprieta' => AaaBbbbbCcccDdd



        //private Ruolo _ruolo; // valiabile


        // modificatore => public (public, private, internal, protected)
        // tipo della proprieta' => Ruolo
        // nome che hai dato alla proprieta => Ruolo
        
        //public Ruolo Ruolo { get; set; } // proprieta'

        //public Ruolo Ruolo
        //{
        //    get { return _ruolo; }
        //    set { _ruolo = value; }
        //}

        // g.Ruolo => centroc => set => skadgfsdgfiouergbvjkxgfuyerwithjdksgewiuoyhwjek => centroc
        // a = g.Ruolo => get => skadgfsdgfiouergbvjkxgfuyerwithjdksgewiuoyhwjek => centroc

        // g.Ruolo => centroc => set => _ruolo => centroc
        // a = g.Ruolo => get => _ruolo => centroc



        public GiocatoreDelMilan() // costruttore
        {

        }

        public GiocatoreDelMilan(
            string nome, 
            int numeroDiMaglia
            ) // costruttore
        {
            Nome = nome;
            NumeroDiMaglia = numeroDiMaglia;
        }

        // datadinascita
        // periodo al milan
        // numero di scarpe

    }
}
