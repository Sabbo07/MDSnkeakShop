using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

public class Utente{
    [Key]
    public int ID {set; get;}
    
    [Required]
    [MaxLength(15)]
    public required string Nome {set; get;}

    [Required]
    [MaxLength(15)]
    public required string Cognome {set; get;}

    [Required]
    [EmailAddress]
    public required string Email {set; get;}

    [Required]
    [MaxLength(15)]
    public required string password {set; get;}

    [Required]
    [MaxLength(50)]
    public required string Viadicasa {set; get;}

}