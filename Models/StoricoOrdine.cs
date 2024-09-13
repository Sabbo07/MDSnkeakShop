using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MDSnkeakShop.Models
{
    public class StoricoOrdine
    {
    [Key]
    public int ID {set; get;}

    public int ID_Ordine {set; get;}
    public int ID_Utente {set; get;}

    public required Ordine ordine;
    public required Utente utente;
    }
}