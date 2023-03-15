using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities;

public class Stad
{
    public int StadId { get; set; }
    public string Naam { get; set; }
    [ForeignKey("Land")]
    public string IsoLandCode { get; set; }

    public Land Land { get; set; }

    [Timestamp]
    public byte[]? Aangepast { get; set; }


}
