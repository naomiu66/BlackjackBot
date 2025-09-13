using BlackjackBot.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlackjackBot.Data.Configurations
{
    public class UsersConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(u => u.Id);

            builder.HasOne(u => u.ActiveSession)
                .WithMany()
                .HasForeignKey(u => u.ActiveSessionId)
                .OnDelete(DeleteBehavior.SetNull);

            builder.ToTable("users");
        }
    }
}
