using Microsoft.EntityFrameworkCore;
using System;

namespace FiveRingsDb.Models
{
    public class FiveRingsDbContext : DbContext
    {
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

        public DbSet<Trait> Traits { get; set; }

        public DbSet<PrintedCard> PrintedCards { get; set; }

        public DbSet<ProvinceCard> ProvinceCards { get; set; }

        public DbSet<RoleCard> RoleCards { get; set; }

        public DbSet<StrongholdCard> StrongholdCards { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Card>().HasIndex(c => c.Id);
            mb.Entity<Card>().Property(c => c.Side).HasConversion(s => s.ToString(), s => (Side)Enum.Parse(typeof(Side), s));
            mb.Entity<Card>().Property(c => c.Clan).HasConversion(c => c.ToString(), c => (Clan)Enum.Parse(typeof(Clan), c));
            mb.Entity<Card>().Property(c => c.Type).HasConversion(t => t.ToString(), t => (Type)Enum.Parse(typeof(Type), t));
            mb.Entity<Card>().Property(c => c.RoleRestriction).HasConversion(r => r.ToString(), r => (RoleRestriction)Enum.Parse(typeof(RoleRestriction), r));

            mb.Entity<AttachmentCard>().Property(a => a.Cost).HasColumnName("AttachmentCost");
            mb.Entity<AttachmentCard>().Property(a => a.InfluenceCost).HasColumnName("AttachmentInfluenceCost");

            mb.Entity<CharacterCard>().Property(c => c.Cost).HasColumnName("CharacterCost");
            mb.Entity<CharacterCard>().Property(c => c.InfluenceCost).HasColumnName("CharacterInfluenceCost");

            mb.Entity<EventCard>().Property(e => e.Cost).HasColumnName("EventCost");
            mb.Entity<EventCard>().Property(e => e.InfluenceCost).HasColumnName("EventInfluenceCost");

            mb.Entity<HoldingCard>().Property(h => h.StrengthBonus).HasColumnName("HoldingStrengthBonus");

            mb.Entity<Keyword>().HasIndex(k => k.Id);
            mb.Entity<Keyword>().Property(k => k.Type).HasConversion(t => t.ToString(), t => (KeywordType)Enum.Parse(typeof(KeywordType), t));

            mb.Entity<PrintedCard>().HasIndex(p => p.Id);
            mb.Entity<PrintedCard>().Property(p => p.Pack).HasConversion(p => p.ToString(), p => (SetName)Enum.Parse(typeof(SetName), p));

            mb.Entity<ProvinceCard>().Property(p => p.Element).HasConversion(e => e.ToString(), e => (Element)Enum.Parse(typeof(Element), e));

            mb.Entity<StrongholdCard>().Property(s => s.StrengthBonus).HasColumnName("StrongholdStrengthBonus");

            mb.Entity<Trait>().HasIndex(t => t.Id);
            mb.Entity<Trait>().HasKey(t => t.Id);
            mb.Entity<Trait>().Property(t => t.TraitEnum).HasConversion(t => t.ToString(), t => (TraitEnum)Enum.Parse(typeof(TraitEnum), t));

            mb.Entity<TraitOnCard>().HasKey(t => new { t.CardId, t.TraitId });
            mb.Entity<TraitOnCard>().HasOne(t => t.Card).WithMany(c => c.TraitsOnCards).HasForeignKey(t => t.CardId);
            mb.Entity<TraitOnCard>().HasOne(t => t.Trait).WithMany(t => t.TraitsOnCards).HasForeignKey(t => t.TraitId);

            mb.Entity<TraitInKeywordException>().HasKey(t => new { t.KeywordId, t.TraitId });
            mb.Entity<TraitInKeywordException>().HasOne(t => t.Keyword).WithMany(c => c.TraitInKeywordExceptions).HasForeignKey(t => t.KeywordId);
            mb.Entity<TraitInKeywordException>().HasOne(t => t.Trait).WithMany(t => t.TraitsInKeywordExceptions).HasForeignKey(t => t.TraitId);

            mb.Entity<TraitInKeywordRestriction>().HasKey(t => new { t.KeywordId, t.TraitId });
            mb.Entity<TraitInKeywordRestriction>().HasOne(t => t.Keyword).WithMany(c => c.TraitInKeywordRestrictions).HasForeignKey(t => t.KeywordId);
            mb.Entity<TraitInKeywordRestriction>().HasOne(t => t.Trait).WithMany(t => t.TraitsInKeywordRestrictions).HasForeignKey(t => t.TraitId);
        }
    }
}