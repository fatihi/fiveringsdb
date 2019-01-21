using FiveRingsDb.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace FiveRingsDb.Models
{
    public class FiveRingsDbContext : DbContext
    {
        public FiveRingsDbContext(DbContextOptions<FiveRingsDbContext> options)
            : base(options) {}

        public DbSet<AttachmentCard> AttachmentCards { get; set; }
        public DbSet<Card> Cards { get; set; }
        public DbSet<CharacterCard> CharacterCards { get; set; }
        public DbSet<EventCard> EventCards { get; set; }
        public DbSet<HoldingCard> HoldingCards { get; set; }
        public DbSet<PrintedCard> PrintedCards { get; set; }
        public DbSet<ProvinceCard> ProvinceCards { get; set; }
        public DbSet<RoleCard> RoleCards { get; set; }
        public DbSet<StrongholdCard> StrongholdCards { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
            => optionsBuilder.UseNpgsql("Host=localhost;Database=five_rings_db;Username=postgres;Password=08rKX&8M@b&@46KCyHgA&*2ZQR9Vlilg");
    }
}