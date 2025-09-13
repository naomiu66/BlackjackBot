using BlackjackBot.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlackjackBot.Data.Configurations
{
    public class HandsConfiguration : IEntityTypeConfiguration<Hand>
    {
        public void Configure(EntityTypeBuilder<Hand> builder)
        {
            builder.HasKey(h => h.Id);

            builder.HasOne(h => h.Session)
                .WithMany(s => s.PlayerHands)
                .HasForeignKey(h => h.SessionId);

            builder.HasOne(h => h.User)
                .WithMany()
                .HasForeignKey(h => h.UserId);

            builder.ToTable("player_hands");
        }
    }
}
