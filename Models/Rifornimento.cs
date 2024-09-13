using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MDSnkeakShop.Models
{
    public class Rifornimento
    {
        [Key]
        public int ID {set; get;}

        public int ID_Magazziniere {set; get;}
        public int ID_Negozio {set; get;}
        public required Magazziniere magazziniere;

        public required Negozio negozio;
    }
}