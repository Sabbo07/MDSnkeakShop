using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace MDSnkeakShop.Models
{
    public class Scarpa
    {
    [Key]
    public int ID {set; get;}

    public int ID_Modello {set; get;}

    public int ID_Brand {set; get;}

    public int ID_Categoria {set; get;}

    public int ID_Colore {set; get;}

    public required Modello modello;

    public required Brand brand;

    public required Categoria categoria;

    public required Colore colore;
    
    }
}