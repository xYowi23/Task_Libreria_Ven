using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;

namespace Task_IF_Libreria.Models;

public partial class Prestito
{
    public int PrestitoId { get; set; }

    public DateOnly DataPres { get; set; }

    public DateOnly DataRit { get; set; }

    public int? UtenteRif { get; set; }

    public int? LibroRif { get; set; }

    public virtual Libro? LibroRifNavigation { get; set; }

    public virtual Utente? UtenteRifNavigation { get; set; }

    public override string ToString()
    {
        return $"[Prestito] {PrestitoId} {DataPres} {DataRit} {LibroRifNavigation.ToString()} {UtenteRifNavigation.ToString()} \n ";
    }

}
