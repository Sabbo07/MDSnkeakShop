using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MDSnkeakShop.Models
{
    public class Whislist
    {
        [Key]
        public int ID {set; get;}
        
        public int ID_Utente {set; get;}
        public int ID_Scarpa {set; get;}
        public required Utente utente;
        public required Scarpa scarpa;

    }
}