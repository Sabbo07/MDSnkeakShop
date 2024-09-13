using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MDSnkeakShop.Models
{
    public class Taglia
    {
        [Key]
    public int ID {set; get;}
    
    [Required]
    [MaxLength(2)]
    public required string Numero {set; get;}
    }
}