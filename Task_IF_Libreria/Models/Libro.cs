using System;
using System.Collections.Generic;

namespace Task_IF_Libreria.Models;

public partial class Libro
{
    public int LibroId { get; set; }

    public string? CodLibro { get; set; }

    public string Titolo { get; set; } = null!;

    public int? AnnoPub { get; set; }

    public bool StatoDis { get; set; }

    public virtual ICollection<Prestito> Prestitos { get; set; } = new List<Prestito>();

    public override string ToString()
    {
        return $"[Libro] {LibroId} {Titolo} {AnnoPub} {CodLibro}  \n";
    }

}
