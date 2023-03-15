using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities;

public class Taal
{
    public Taal() 
    { 
        Landen = new List<Land>();
    }   
    public string ISOTaalCode { get; set; }
    public string NaamNL { get; set; }
    public string? NaamTaal { get; set; }

    public ICollection<Land> Landen { get; set; }
}
