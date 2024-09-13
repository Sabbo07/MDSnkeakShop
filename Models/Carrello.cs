using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace MDSnkeakShop.Models
{
    public class Carrello
    {
    [Key]
    public int ID {set; get;}

    public int ID_Utente {set; get;}

    public int ID_Scarpa {set; get;}



    public required Utente utente;

    
    }
}