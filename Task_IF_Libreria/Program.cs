using Azure.Core.GeoJson;
using System.Collections.Generic;
using Task_IF_Libreria.Models;

namespace Task_IF_Libreria
{
    internal class Program
    {
        static void Main(string[] args)
        {

            

            using (var ctx = new TaskLibreriaContext())
            {
                //ICollection < Prestito > elenco = ctx.Prestitos.ToList();

                //foreach (Prestito pres in elenco)
                //{
                //    Console.WriteLine(pres.ToString);
                //}


                //Stampo di tutti i prestiti 
                //var elenco = ctx.Prestitos.ToList();

                // foreach (var prest in elenco)
                // {
                //     prest.UtenteRifNavigation = ctx.Utentes.Single(u => u.UtenteId == prest.UtenteRif);
                //     prest.LibroRifNavigation = ctx.Libros.Single(u => u.LibroId == prest.UtenteRif);


                //     Console.WriteLine(prest);

                // }

                    



            };


            //Gestore.StampaTutto();

            //Gestore.StampaLibro();

            //Gestore.StampaUtene();


            Console.WriteLine("Ao er dimme er titolo");
            string ? inTitolo = Console.ReadLine();

            Console.WriteLine("Ao er dimme er Anno Pubblicazione");
            int inAnPub = Convert.ToInt32( Console.ReadLine());

            Console.WriteLine("Ao er dimme er Disponibilità");
            bool inStato=Convert.ToBoolean( Console.ReadLine());


            Gestore.InsertLibro(inTitolo, inAnPub, inStato);   



        }
    }
}
