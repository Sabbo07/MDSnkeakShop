using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MDSnkeakShop.Models
{
    public class DettagliScarpa
    {
        [Key]
        public int ID {set; get;}

        public int ID_Scarpa {set; get;}


        public int ID_Taglia {set; get;}

        public int Qta_taglia {set; get;}

        public float prezzo_al_dettaglio {set; get;}

        public float sconto_applicabile {set; get;}
        public required Scarpa scarpa;
        public required Taglia taglia;


    }
}