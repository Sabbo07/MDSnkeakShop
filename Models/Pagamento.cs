using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MDSnkeakShop.Models
{
    public class Pagamento
    {
    [Key]
    public int ID {set; get;}

    public required string tipo {set; get;}

    public required string Nome {set; get;}
    }
}