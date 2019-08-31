using Microsoft.EntityFrameworkCore;
using Npgsql;

namespace FiveRingsDb.Models
{
    public class FiveRingsDbContext : DbContext
    {
        static FiveRingsDbContext()
        {
            NpgsqlConnection.GlobalTypeMapper.MapEnum<Side>();
            NpgsqlConnection.GlobalTypeMapper.MapEnum<Clan>();
            NpgsqlConnection.GlobalTypeMapper.MapEnum<CardType>();
            NpgsqlConnection.GlobalTypeMapper.MapEnum<KeywordType>();
            NpgsqlConnection.GlobalTypeMapper.MapEnum<SetName>();
            NpgsqlConnection.GlobalTypeMapper.MapEnum<Element>();
        }

        public FiveRingsDbContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<AttachmentCard> AttachmentCards { get; set; }

        public DbSet<Card> Cards { get; set; }

        public DbSet<CharacterCard> CharacterCards { get; set; }

        public DbSet<EventCard> EventCards { get; set; }

        public DbSet<HoldingCard> HoldingCards { get; set; }

        public DbSet<Keyword> Keywords { get; set; }

        public DbSet<PrintedCard> PrintedCards { get; set; }

        public DbSet<ProvinceCard> ProvinceCards { get; set; }

        public DbSet<RoleCard> RoleCards { get; set; }

        public DbSet<StrongholdCard> StrongholdCards { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.ForNpgsqlHasEnum<Side>();
            mb.ForNpgsqlHasEnum<Clan>();
            mb.ForNpgsqlHasEnum<CardType>();
            mb.ForNpgsqlHasEnum<KeywordType>();
            mb.ForNpgsqlHasEnum<SetName>();
            mb.ForNpgsqlHasEnum<Element>();

            mb.Entity<Card>().HasIndex(c => c.Id);

            mb.Entity<AttachmentCard>().Property(a => a.Cost).HasColumnName("AttachmentCost");
            mb.Entity<AttachmentCard>().Property(a => a.InfluenceCost).HasColumnName("AttachmentInfluenceCost");

            mb.Entity<CharacterCard>().Property(c => c.Cost).HasColumnName("CharacterCost");
            mb.Entity<CharacterCard>().Property(c => c.InfluenceCost).HasColumnName("CharacterInfluenceCost");

            mb.Entity<EventCard>().Property(e => e.Cost).HasColumnName("EventCost");
            mb.Entity<EventCard>().Property(e => e.InfluenceCost).HasColumnName("EventInfluenceCost");

            mb.Entity<HoldingCard>().Property(h => h.StrengthBonus).HasColumnName("HoldingStrengthBonus");

            mb.Entity<Keyword>().HasIndex(k => k.Id);

            mb.Entity<PrintedCard>().HasIndex(p => p.Id);

            mb.Entity<StrongholdCard>().Property(s => s.StrengthBonus).HasColumnName("StrongholdStrengthBonus");
        }
    }
}