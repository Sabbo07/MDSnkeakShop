using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MDSnkeakShop.Models;
using Microsoft.EntityFrameworkCore;

namespace MDSnkeakShop.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
                

        }
        public DbSet<Brand> brand {get; set;}
        public DbSet<Carrello> carrello {get; set;}

        public DbSet<CartaCredito> cartacredito {get; set;}
        public DbSet<Categoria> categoria {set; get;}
        public DbSet<Colore> colore {set; get;}
        public DbSet<DettagliRifornimento> dettaglirifornimento{set; get;}
        public DbSet<DettagliScarpa> dettagliscarpa {set; get;}

        public DbSet<Magazziniere> magazziniere {set; get;}
        public DbSet<Modello> modello {set; get;}
        public DbSet<Negozio> negozio {set; get;}
        public DbSet<Ordine> ordine {set; get;}
        public DbSet<Pagamento> pagamento {set; get;}

        public DbSet<Piuvenduti> piuvenduti {set; get;}
        public DbSet<Rifornimento> rifornimento {set; get;}
        public DbSet<Scarpa> scarpa {set; get;}
        public DbSet<ScarpaColore> scarpacolore {set; get;}
        public DbSet<StoricoOrdine> storicoordine {set; get;}

        public DbSet<Taglia> taglia {set; get;}
        public DbSet<Utente> utente {set; get;}
        public DbSet<Whislist> whislist {set; get;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Configurazione Carrello
        modelBuilder.Entity<Carrello>()
            .HasKey(c => c.ID);

        modelBuilder.Entity<Carrello>()
            .HasOne(c => c.utente)
            .WithMany()  // Configura se Utente ha una collezione di Carrelli
            .HasForeignKey(c => c.ID_Utente)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Carrello>()
            .HasOne(c => c.scarpa)
            .WithMany()  // Configura se Scarpa ha una collezione di Carrelli
            .HasForeignKey(c => c.ID_Scarpa)
            .OnDelete(DeleteBehavior.Restrict);

        // Configurazione CartaCredito
        modelBuilder.Entity<CartaCredito>()
            .HasKey(c => c.ID);

        modelBuilder.Entity<CartaCredito>()
            .HasOne(c => c.utente)
            .WithMany()  // Configura se Utente ha una collezione di CarteCredito
            .HasForeignKey(c => c.ID_Utente)
            .OnDelete(DeleteBehavior.Restrict);

        // Configurazione DettagliRifornimento
        modelBuilder.Entity<DettagliRifornimento>()
            .HasKey(d => d.ID);

        modelBuilder.Entity<DettagliRifornimento>()
            .HasOne(d => d.rifornimento)
            .WithMany()  // Configura se Rifornimento ha una collezione di DettagliRifornimento
            .HasForeignKey(d => d.ID_Rifornimento)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<DettagliRifornimento>()
            .HasOne(d => d.scarpa)
            .WithMany()  // Configura se Scarpa ha una collezione di DettagliRifornimento
            .HasForeignKey(d => d.ID_Scarpa)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<DettagliRifornimento>()
            .HasOne(d => d.taglia)
            .WithMany()  // Configura se Taglia ha una collezione di DettagliRifornimento
            .HasForeignKey(d => d.ID_Taglia)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<DettagliRifornimento>()
            .HasOne(d => d.colore)
            .WithMany()  // Configura se Colore ha una collezione di DettagliRifornimento
            .HasForeignKey(d => d.ID_Colore)
            .OnDelete(DeleteBehavior.Restrict);

        // Configurazione DettagliScarpa
        modelBuilder.Entity<DettagliScarpa>()
            .HasKey(d => d.ID);

        modelBuilder.Entity<DettagliScarpa>()
            .HasOne(d => d.scarpa)
            .WithMany()  // Configura se Scarpa ha una collezione di DettagliScarpa
            .HasForeignKey(d => d.ID_Scarpa)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<DettagliScarpa>()
            .HasOne(d => d.taglia)
            .WithMany()  // Configura se Taglia ha una collezione di DettagliScarpa
            .HasForeignKey(d => d.ID_Taglia)
            .OnDelete(DeleteBehavior.Restrict);
         modelBuilder.Entity<Magazziniere>()
            .HasKey(m => m.ID);

        // Configurazione Ordine
        modelBuilder.Entity<Ordine>()
            .HasKey(o => o.ID);

        modelBuilder.Entity<Ordine>()
            .HasOne(o => o.utente)
            .WithMany() // Se Utente ha una collezione di Ordini, usa .WithMany(u => u.Ordini)
            .HasForeignKey(o => o.ID_Utente)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Ordine>()
            .HasOne(o => o.scarpa)
            .WithMany() // Se Scarpa ha una collezione di Ordini, usa .WithMany(s => s.Ordini)
            .HasForeignKey(o => o.ID_Scarpa)
            .OnDelete(DeleteBehavior.Restrict);

        // Configurazione Piuvenduti
        modelBuilder.Entity<Piuvenduti>()
            .HasKey(p => p.ID);

        modelBuilder.Entity<Piuvenduti>()
            .HasOne(p => p.scarpa)
            .WithMany() // Se Scarpa ha una collezione di Piuvenduti, usa .WithMany(s => s.Piuvenduti)
            .HasForeignKey(p => p.ID_Scarpa)
            .OnDelete(DeleteBehavior.Restrict);

        // Configurazione Rifornimento
        modelBuilder.Entity<Rifornimento>()
            .HasKey(r => r.ID);

        modelBuilder.Entity<Rifornimento>()
            .HasOne(r => r.magazziniere)
            .WithMany() // Se Magazziniere ha una collezione di Rifornimenti, usa .WithMany(m => m.Rifornimenti)
            .HasForeignKey(r => r.ID_Magazziniere)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Rifornimento>()
            .HasOne(r => r.negozio)
            .WithMany() // Se Negozio ha una collezione di Rifornimenti, usa .WithMany(n => n.Rifornimenti)
            .HasForeignKey(r => r.ID_Negozio)
            .OnDelete(DeleteBehavior.Restrict);

        // Configurazione Scarpa
        modelBuilder.Entity<Scarpa>()
            .HasKey(s => s.ID);

        modelBuilder.Entity<Scarpa>()
            .HasOne(s => s.modello)
            .WithMany() // Se Modello ha una collezione di Scarpe, usa .WithMany(m => m.Scarpe)
            .HasForeignKey(s => s.ID_Modello)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Scarpa>()
            .HasOne(s => s.brand)
            .WithMany() // Se Brand ha una collezione di Scarpe, usa .WithMany(b => b.Scarpe)
            .HasForeignKey(s => s.ID_Brand)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Scarpa>()
            .HasOne(s => s.categoria)
            .WithMany() // Se Categoria ha una collezione di Scarpe, usa .WithMany(c => c.Scarpe)
            .HasForeignKey(s => s.ID_Categoria)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Scarpa>()
            .HasOne(s => s.colore)
            .WithMany() // Se Colore ha una collezione di Scarpe, usa .WithMany(c => c.Scarpe)
            .HasForeignKey(s => s.ID_Colore)
            .OnDelete(DeleteBehavior.Restrict);
        modelBuilder.Entity<ScarpaColore>()
            .HasKey(sc => sc.ID);

        modelBuilder.Entity<ScarpaColore>()
            .HasOne(sc => sc.scarpa)
            .WithMany() // Se Scarpa ha una collezione di ScarpaColore, usa .WithMany(s => s.ScarpaColori)
            .HasForeignKey(sc => sc.ID_Scarpa)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<ScarpaColore>()
            .HasOne(sc => sc.colore)
            .WithMany() // Se Colore ha una collezione di ScarpaColore, usa .WithMany(c => c.ScarpaColori)
            .HasForeignKey(sc => sc.ID_Colore)
            .OnDelete(DeleteBehavior.Restrict);

        // Configurazione StoricoOrdine
        modelBuilder.Entity<StoricoOrdine>()
            .HasKey(so => so.ID);

        modelBuilder.Entity<StoricoOrdine>()
            .HasOne(so => so.ordine)
            .WithMany() // Se Ordine ha una collezione di StoricoOrdine, usa .WithMany(o => o.StoricoOrdini)
            .HasForeignKey(so => so.ID_Ordine)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<StoricoOrdine>()
            .HasOne(so => so.utente)
            .WithMany() // Se Utente ha una collezione di StoricoOrdine, usa .WithMany(u => u.StoricoOrdini)
            .HasForeignKey(so => so.ID_Utente)
            .OnDelete(DeleteBehavior.Restrict);

        // Configurazione Whislist
        modelBuilder.Entity<Whislist>()
            .HasKey(w => w.ID);

        modelBuilder.Entity<Whislist>()
            .HasOne(w => w.utente)
            .WithMany() // Se Utente ha una collezione di Whislist, usa .WithMany(u => u.Whislists)
            .HasForeignKey(w => w.ID_Utente)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Whislist>()
            .HasOne(w => w.scarpa)
            .WithMany() // Se Scarpa ha una collezione di Whislist, usa .WithMany(s => s.Whislists)
            .HasForeignKey(w => w.ID_Scarpa)
            .OnDelete(DeleteBehavior.Restrict);

        // Configurazione Utente
        modelBuilder.Entity<Utente>()
            .HasKey(u => u.ID);

        // Configurazione Scarpa
        modelBuilder.Entity<Scarpa>()
            .HasKey(s => s.ID);
    }
    }
}