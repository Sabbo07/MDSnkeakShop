using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MDSnkeakShop.Models
{
    public class DettagliRifornimento
    {
        [Key]
        public int ID {set; get;}

        public int ID_Rifornimento {set; get;}

        public int ID_Scarpa {set; get;}

        public int ID_Taglia {set; get;}

        public int ID_Colore {set; get;}

        public int Qta_aggiungi_per_taglia {set; get;}
        public required Rifornimento rifornimento;

        public required Scarpa scarpa;
        public required Taglia taglia;

        public required Colore colore;




    }
}