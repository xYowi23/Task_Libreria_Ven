using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_IF_Libreria.Models
{
    internal class Gestore
    {

        public static void StampaTutto()
        {


            using (var ctx = new TaskLibreriaContext())
            {
                var elenco = ctx.Prestitos.ToList();
                foreach (var prest in elenco)
                {
                    prest.UtenteRifNavigation = ctx.Utentes.Single(u => u.UtenteId == prest.UtenteRif);
                    prest.LibroRifNavigation = ctx.Libros.Single(u => u.LibroId == prest.UtenteRif);


                    Console.WriteLine(prest);

                }

            }

        }

        public static void StampaLibro()
        {

            using (var ctx = new TaskLibreriaContext())
            {
                var elenco = ctx.Libros.ToList();
                foreach (var prest in elenco)
                {

                    Console.WriteLine(prest);

                }

            }


        }

        public static void StampaUtene()
        {

            using (var ctx = new TaskLibreriaContext())
            {
                var elenco = ctx.Utentes.ToList();
                foreach (var prest in elenco)
                {


                    Console.WriteLine(prest);

                }

            }


        }

        public static bool InsertLibro(string varTitolo, int varAnPub, bool varStato)
        {
            bool risultato = false;

            Libro lib = new Libro()
            {

                Titolo = varTitolo,
                AnnoPub = varAnPub,
                StatoDis = varStato,
            };

            using (var ctx = new TaskLibreriaContext())
            {
                try
                {
                    ctx.Libros.Add(lib);
                    ctx.SaveChanges();
                    Console.WriteLine("Inserimento ok!");
                    risultato = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }




                return (risultato);
            }



        }

        public static void  Trovalibro (string varCodLibro)
        {
           
            using (var ctx = new TaskLibreriaContext())
            {

                Libro? libe = ctx.Libros.FirstOrDefault(l => l.CodLibro.Equals(varCodLibro));
                Console.Write(libe);


            }
        }


        public static void StampaLibDispo()
        {
            using (var ctx = new TaskLibreriaContext())
            {
                var elenLibri= ctx.Libros.ToList();
                var risultato = from lib in elenLibri
                                where lib.StatoDis == true
                                select lib;

                foreach (var lib in risultato)
                {
                    Console.WriteLine(lib);
                    
                }

            }
        }

    }
}