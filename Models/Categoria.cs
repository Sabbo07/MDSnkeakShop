using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MDSnkeakShop.Models
{
    public class Categoria
    {
    [Key]
    public int ID {set; get;}
    [Required]
    [MaxLength(15)]
    public required string Nome {set; get;}
    }
}