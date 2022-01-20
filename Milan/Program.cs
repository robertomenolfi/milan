using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milan
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // aggiungere una proprieta al calciatore che mi torni l'eta' del calciatore se ho fornito una data di nascita
            // aiutino: proprieta data di nascita e proprieta in sola lettura eta'
            // se vuoi farlo piu' difficle, eta' e data di nascita sono nullable (quindi possono essere nulli) e se
            // non fornisco la data di nascita anche eta' e nullo.
            // il ciclo in fondo, dopo il numero di maglia deve mostrare anche le eta' dove hai messo la data di nascita




            //var giocatore = new GiocatoreDelMilan();
            // il giocatore HA 



            //Console.WriteLine("Hello World!");

            // ciclare una lista dei giocatori del milan e scrivere nome e numero di maglia
            // ^1      ^2            ^3                    ^4

            var rosaDelMilan = new List<GiocatoreDelMilan>(); // variabile aaaBbbbCcccDddd (prima lettera sempre minuscola)
            // ^2

            var giocatore1 = new GiocatoreDelMilan();
            giocatore1.Nome = "Zlatan Ibrahimovic";
            giocatore1.NumeroDiMaglia = 11;
            rosaDelMilan.Add(giocatore1);

            var giocatore2 = new GiocatoreDelMilan("Leao", 7);
            rosaDelMilan.Add(giocatore2);

            rosaDelMilan.Add(new GiocatoreDelMilan("Calabria", 2));

            // stoccato nella variabile e aggiunto alla lista
            var giocatore3 = CreaNuovoGiocatoreDelMilan("Kaka", 7);
            rosaDelMilan.Add(giocatore3);

            // aggiunge alla lista un elemento creato SENZA stoccarlo in una variabile
            rosaDelMilan.Add(CreaNuovoGiocatoreDelMilan("Baresi", 6));

            // aggiungo un giocatore alla lista passando anche la lista
            AggiungiNuovoGiocatoreDelMilanAllaRosa(rosaDelMilan, "Maldini", 3);

            foreach (var giocatore in rosaDelMilan
                // ^1
                )
            {
                // corpo del foreach
                //Console.WriteLine(giocatore.Nome);
                //Console.WriteLine(giocatore.NumeroDiMaglia);
                //Console.WriteLine("#" + giocatore.NumeroDiMaglia + " " + giocatore.Nome);
                Console.WriteLine("{0}: #{1}", giocatore.Nome, giocatore.NumeroDiMaglia);
                // ^4
            }

            Console.WriteLine("\nPremi un tasto per continuare...");
            Console.ReadLine();

        }


        // metodo CON valore di ritorno
        // il metodo ritorna un oggetto di tipo GiocatoreDelMilan
        static GiocatoreDelMilan CreaNuovoGiocatoreDelMilan(string nome, int numeroDiMaglia)
        {
            var giocatore = new GiocatoreDelMilan();
            giocatore.Nome = nome;
            giocatore.NumeroDiMaglia = numeroDiMaglia;
            return giocatore;
        }

        // metodo SENZA valore di ritorno
        // metodo che NON torna valori e aggiunge elemento direttamente alla lista
        static void AggiungiNuovoGiocatoreDelMilanAllaRosa(
            List<GiocatoreDelMilan> rosa,
            string nome, // nome giocatore
            int numeroDiMaglia // numero di maglia del giocatore
            )
        {
            var giocatore = new GiocatoreDelMilan();
            giocatore.Nome = nome;
            giocatore.NumeroDiMaglia = numeroDiMaglia;

            // AVVERRA' PER TUTTI


            rosa.Add(giocatore);
        }

    }
}
