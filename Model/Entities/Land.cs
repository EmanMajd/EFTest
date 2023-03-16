using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities;

public class Land
{
    public Land() 
    { 
        Talen = new List<Taal>();
    }

    [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
    public string ISOLandCode { get; set; }
    public string? NISLandCode { get; set; }
    public string Naam { get; set; }
    public int AantalInwoners { get; set; }
    public float Oppervlakte { get; set; }

    public ICollection<Stad> staden { get; set; }

    public ICollection<Taal> Talen { get; set; }

    [Timestamp]
    public byte[]? Aangepast { get; set; }


}
