using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MDSnkeakShop.Models
{
    public class ScarpaColore
    {
        [Key]
        public int ID {set; get;}
        public int ID_Scarpa {set; get;}

        public int ID_Colore {set; get;}
        public required Scarpa scarpa;

        public required Colore colore;
    }
}