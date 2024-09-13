using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;
namespace MDSnkeakShop.Models
{
    public class CartaCredito
    {
    [Key]
    public int ID {set; get;}

    public int ID_Utente {set; get;}

    [Required]
    [MaxLength(16)]
    public required string NumeroCarta {set; get;}

    [Required]
    public DateTime DataScadenza {set; get;}


    [Required]
    [MaxLength(3)]
    public required string CVV {set; get;}


    public required Utente utente;
    }
}